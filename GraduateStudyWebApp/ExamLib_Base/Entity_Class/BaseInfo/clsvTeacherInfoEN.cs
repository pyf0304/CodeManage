
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeacherInfoEN
 表名:vTeacherInfo(01120094)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:19:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表vTeacherInfo的关键字(IdTeacher)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeacher_vTeacherInfo
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
public K_IdTeacher_vTeacherInfo(string strIdTeacher)
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
 /// <returns>返回:[K_IdTeacher_vTeacherInfo]类型的对象</returns>
public static implicit operator K_IdTeacher_vTeacherInfo(string value)
{
return new K_IdTeacher_vTeacherInfo(value);
}
}
 /// <summary>
 /// v教师(vTeacherInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeacherInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeacherInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 62;
public static string[] AttributeName = new string[] {"IdTeacher", "TeacherId", "TeacherName", "IdSex", "SexDesc", "IdSchoolPs", "IdDisciplinePs", "IdUniZone", "UniZoneDesc", "IdEthnic", "EthnicName", "IdPolitics", "PoliticsName", "IdAdminGrade", "AdminGradeDesc", "IdProfGrade", "ProfenssionalGradeName", "IdQualif", "QualifDesc", "IdDegree", "DegreeName", "IdStaffType", "StaffTypeName", "IdProvince", "ProvinceName", "CitizenId", "CardNo", "Birthday", "GraduationMajor", "TelNo", "Email", "WebSite", "PersonBlog", "EntryDate", "Offed", "IsAvconUser", "IsGpUser", "IsLocalUser", "FromUnit", "Memo", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "EntryDay", "IdPhoto", "IdReligion", "ReligionName", "IsMessage", "Microblog", "ModifyUserId", "OffedBak", "PhoneNumber", "QQ", "TeachIdCollege", "TeachIdMajor", "Tel", "ModifyDate", "RegisterPassword", "EntryYear", "IdCardNo"};

protected string mstrIdTeacher;    //教师流水号
protected string mstrTeacherId;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdSex;    //性别流水号
protected string mstrSexDesc;    //性别名称
protected string mstrIdSchoolPs;    //学校流水号
protected string mstrIdDisciplinePs;    //学科流水号
protected string mstrIdUniZone;    //校区流水号
protected string mstrUniZoneDesc;    //校区名称
protected string mstrIdEthnic;    //民族流水号
protected string mstrEthnicName;    //民族名称
protected string mstrIdPolitics;    //政治面貌流水号
protected string mstrPoliticsName;    //政治面貌
protected string mstrIdAdminGrade;    //行政职务流水号
protected string mstrAdminGradeDesc;    //行政职务描述
protected string mstrIdProfGrade;    //专业职称流水号
protected string mstrProfenssionalGradeName;    //专业职称
protected string mstrIdQualif;    //学历流水号
protected string mstrQualifDesc;    //QualifDesc
protected string mstrIdDegree;    //学位流水号
protected string mstrDegreeName;    //学位名称
protected string mstrIdStaffType;    //职工类型流水号
protected string mstrStaffTypeName;    //职工类型名称
protected string mstrIdProvince;    //省份流水号
protected string mstrProvinceName;    //ProvinceName
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
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrEntryDay;    //EntryDay
protected string mstrIdPhoto;    //id_Photo
protected string mstrIdReligion;    //id_Religion
protected string mstrReligionName;    //ReligionName
protected bool mbolIsMessage;    //IsMessage
protected string mstrMicroblog;    //Microblog
protected string mstrModifyUserId;    //修改人
protected bool mbolOffedBak;    //OffedBak
protected string mstrPhoneNumber;    //电话
protected string mstrQQ;    //QQ
protected string mstrTeachIdCollege;    //Teach_id_College
protected string mstrTeachIdMajor;    //Teach_id_Major
protected string mstrTel;    //Tel
protected string mstrModifyDate;    //修改日期
protected string mstrRegisterPassword;    //RegisterPassword
protected string mstrEntryYear;    //EntryYear
protected string mstrIdCardNo;    //身份证号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTeacherInfoEN()
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
public clsvTeacherInfoEN(string strIdTeacher)
 {
strIdTeacher = strIdTeacher.Replace("'", "''");
if (strIdTeacher.Length > 8)
{
throw new Exception("在表:vTeacherInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeacher)  ==  true)
{
throw new Exception("在表:vTeacherInfo中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convTeacherInfo.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  convTeacherInfo.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  convTeacherInfo.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convTeacherInfo.IdSex)
{
return mstrIdSex;
}
else if (strAttributeName  ==  convTeacherInfo.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convTeacherInfo.IdSchoolPs)
{
return mstrIdSchoolPs;
}
else if (strAttributeName  ==  convTeacherInfo.IdDisciplinePs)
{
return mstrIdDisciplinePs;
}
else if (strAttributeName  ==  convTeacherInfo.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  convTeacherInfo.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convTeacherInfo.IdEthnic)
{
return mstrIdEthnic;
}
else if (strAttributeName  ==  convTeacherInfo.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  convTeacherInfo.IdPolitics)
{
return mstrIdPolitics;
}
else if (strAttributeName  ==  convTeacherInfo.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  convTeacherInfo.IdAdminGrade)
{
return mstrIdAdminGrade;
}
else if (strAttributeName  ==  convTeacherInfo.AdminGradeDesc)
{
return mstrAdminGradeDesc;
}
else if (strAttributeName  ==  convTeacherInfo.IdProfGrade)
{
return mstrIdProfGrade;
}
else if (strAttributeName  ==  convTeacherInfo.ProfenssionalGradeName)
{
return mstrProfenssionalGradeName;
}
else if (strAttributeName  ==  convTeacherInfo.IdQualif)
{
return mstrIdQualif;
}
else if (strAttributeName  ==  convTeacherInfo.QualifDesc)
{
return mstrQualifDesc;
}
else if (strAttributeName  ==  convTeacherInfo.IdDegree)
{
return mstrIdDegree;
}
else if (strAttributeName  ==  convTeacherInfo.DegreeName)
{
return mstrDegreeName;
}
else if (strAttributeName  ==  convTeacherInfo.IdStaffType)
{
return mstrIdStaffType;
}
else if (strAttributeName  ==  convTeacherInfo.StaffTypeName)
{
return mstrStaffTypeName;
}
else if (strAttributeName  ==  convTeacherInfo.IdProvince)
{
return mstrIdProvince;
}
else if (strAttributeName  ==  convTeacherInfo.ProvinceName)
{
return mstrProvinceName;
}
else if (strAttributeName  ==  convTeacherInfo.CitizenId)
{
return mstrCitizenId;
}
else if (strAttributeName  ==  convTeacherInfo.CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  convTeacherInfo.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convTeacherInfo.GraduationMajor)
{
return mstrGraduationMajor;
}
else if (strAttributeName  ==  convTeacherInfo.TelNo)
{
return mstrTelNo;
}
else if (strAttributeName  ==  convTeacherInfo.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  convTeacherInfo.WebSite)
{
return mstrWebSite;
}
else if (strAttributeName  ==  convTeacherInfo.PersonBlog)
{
return mstrPersonBlog;
}
else if (strAttributeName  ==  convTeacherInfo.EntryDate)
{
return mstrEntryDate;
}
else if (strAttributeName  ==  convTeacherInfo.Offed)
{
return mbolOffed;
}
else if (strAttributeName  ==  convTeacherInfo.IsAvconUser)
{
return mbolIsAvconUser;
}
else if (strAttributeName  ==  convTeacherInfo.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  convTeacherInfo.IsLocalUser)
{
return mbolIsLocalUser;
}
else if (strAttributeName  ==  convTeacherInfo.FromUnit)
{
return mstrFromUnit;
}
else if (strAttributeName  ==  convTeacherInfo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTeacherInfo.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convTeacherInfo.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convTeacherInfo.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convTeacherInfo.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convTeacherInfo.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convTeacherInfo.EntryDay)
{
return mstrEntryDay;
}
else if (strAttributeName  ==  convTeacherInfo.IdPhoto)
{
return mstrIdPhoto;
}
else if (strAttributeName  ==  convTeacherInfo.IdReligion)
{
return mstrIdReligion;
}
else if (strAttributeName  ==  convTeacherInfo.ReligionName)
{
return mstrReligionName;
}
else if (strAttributeName  ==  convTeacherInfo.IsMessage)
{
return mbolIsMessage;
}
else if (strAttributeName  ==  convTeacherInfo.Microblog)
{
return mstrMicroblog;
}
else if (strAttributeName  ==  convTeacherInfo.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convTeacherInfo.OffedBak)
{
return mbolOffedBak;
}
else if (strAttributeName  ==  convTeacherInfo.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  convTeacherInfo.QQ)
{
return mstrQQ;
}
else if (strAttributeName  ==  convTeacherInfo.TeachIdCollege)
{
return mstrTeachIdCollege;
}
else if (strAttributeName  ==  convTeacherInfo.TeachIdMajor)
{
return mstrTeachIdMajor;
}
else if (strAttributeName  ==  convTeacherInfo.Tel)
{
return mstrTel;
}
else if (strAttributeName  ==  convTeacherInfo.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convTeacherInfo.RegisterPassword)
{
return mstrRegisterPassword;
}
else if (strAttributeName  ==  convTeacherInfo.EntryYear)
{
return mstrEntryYear;
}
else if (strAttributeName  ==  convTeacherInfo.IdCardNo)
{
return mstrIdCardNo;
}
return null;
}
set
{
if (strAttributeName  ==  convTeacherInfo.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdTeacher);
}
else if (strAttributeName  ==  convTeacherInfo.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convTeacherInfo.TeacherId);
}
else if (strAttributeName  ==  convTeacherInfo.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convTeacherInfo.TeacherName);
}
else if (strAttributeName  ==  convTeacherInfo.IdSex)
{
mstrIdSex = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdSex);
}
else if (strAttributeName  ==  convTeacherInfo.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convTeacherInfo.SexDesc);
}
else if (strAttributeName  ==  convTeacherInfo.IdSchoolPs)
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdSchoolPs);
}
else if (strAttributeName  ==  convTeacherInfo.IdDisciplinePs)
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdDisciplinePs);
}
else if (strAttributeName  ==  convTeacherInfo.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdUniZone);
}
else if (strAttributeName  ==  convTeacherInfo.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convTeacherInfo.UniZoneDesc);
}
else if (strAttributeName  ==  convTeacherInfo.IdEthnic)
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdEthnic);
}
else if (strAttributeName  ==  convTeacherInfo.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convTeacherInfo.EthnicName);
}
else if (strAttributeName  ==  convTeacherInfo.IdPolitics)
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdPolitics);
}
else if (strAttributeName  ==  convTeacherInfo.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convTeacherInfo.PoliticsName);
}
else if (strAttributeName  ==  convTeacherInfo.IdAdminGrade)
{
mstrIdAdminGrade = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdAdminGrade);
}
else if (strAttributeName  ==  convTeacherInfo.AdminGradeDesc)
{
mstrAdminGradeDesc = value.ToString();
 AddUpdatedFld(convTeacherInfo.AdminGradeDesc);
}
else if (strAttributeName  ==  convTeacherInfo.IdProfGrade)
{
mstrIdProfGrade = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdProfGrade);
}
else if (strAttributeName  ==  convTeacherInfo.ProfenssionalGradeName)
{
mstrProfenssionalGradeName = value.ToString();
 AddUpdatedFld(convTeacherInfo.ProfenssionalGradeName);
}
else if (strAttributeName  ==  convTeacherInfo.IdQualif)
{
mstrIdQualif = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdQualif);
}
else if (strAttributeName  ==  convTeacherInfo.QualifDesc)
{
mstrQualifDesc = value.ToString();
 AddUpdatedFld(convTeacherInfo.QualifDesc);
}
else if (strAttributeName  ==  convTeacherInfo.IdDegree)
{
mstrIdDegree = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdDegree);
}
else if (strAttributeName  ==  convTeacherInfo.DegreeName)
{
mstrDegreeName = value.ToString();
 AddUpdatedFld(convTeacherInfo.DegreeName);
}
else if (strAttributeName  ==  convTeacherInfo.IdStaffType)
{
mstrIdStaffType = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdStaffType);
}
else if (strAttributeName  ==  convTeacherInfo.StaffTypeName)
{
mstrStaffTypeName = value.ToString();
 AddUpdatedFld(convTeacherInfo.StaffTypeName);
}
else if (strAttributeName  ==  convTeacherInfo.IdProvince)
{
mstrIdProvince = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdProvince);
}
else if (strAttributeName  ==  convTeacherInfo.ProvinceName)
{
mstrProvinceName = value.ToString();
 AddUpdatedFld(convTeacherInfo.ProvinceName);
}
else if (strAttributeName  ==  convTeacherInfo.CitizenId)
{
mstrCitizenId = value.ToString();
 AddUpdatedFld(convTeacherInfo.CitizenId);
}
else if (strAttributeName  ==  convTeacherInfo.CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(convTeacherInfo.CardNo);
}
else if (strAttributeName  ==  convTeacherInfo.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convTeacherInfo.Birthday);
}
else if (strAttributeName  ==  convTeacherInfo.GraduationMajor)
{
mstrGraduationMajor = value.ToString();
 AddUpdatedFld(convTeacherInfo.GraduationMajor);
}
else if (strAttributeName  ==  convTeacherInfo.TelNo)
{
mstrTelNo = value.ToString();
 AddUpdatedFld(convTeacherInfo.TelNo);
}
else if (strAttributeName  ==  convTeacherInfo.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(convTeacherInfo.Email);
}
else if (strAttributeName  ==  convTeacherInfo.WebSite)
{
mstrWebSite = value.ToString();
 AddUpdatedFld(convTeacherInfo.WebSite);
}
else if (strAttributeName  ==  convTeacherInfo.PersonBlog)
{
mstrPersonBlog = value.ToString();
 AddUpdatedFld(convTeacherInfo.PersonBlog);
}
else if (strAttributeName  ==  convTeacherInfo.EntryDate)
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convTeacherInfo.EntryDate);
}
else if (strAttributeName  ==  convTeacherInfo.Offed)
{
mbolOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.Offed);
}
else if (strAttributeName  ==  convTeacherInfo.IsAvconUser)
{
mbolIsAvconUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.IsAvconUser);
}
else if (strAttributeName  ==  convTeacherInfo.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.IsGpUser);
}
else if (strAttributeName  ==  convTeacherInfo.IsLocalUser)
{
mbolIsLocalUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.IsLocalUser);
}
else if (strAttributeName  ==  convTeacherInfo.FromUnit)
{
mstrFromUnit = value.ToString();
 AddUpdatedFld(convTeacherInfo.FromUnit);
}
else if (strAttributeName  ==  convTeacherInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeacherInfo.Memo);
}
else if (strAttributeName  ==  convTeacherInfo.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdXzCollege);
}
else if (strAttributeName  ==  convTeacherInfo.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convTeacherInfo.CollegeId);
}
else if (strAttributeName  ==  convTeacherInfo.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeacherInfo.CollegeName);
}
else if (strAttributeName  ==  convTeacherInfo.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeacherInfo.CollegeNameA);
}
else if (strAttributeName  ==  convTeacherInfo.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdXzMajor);
}
else if (strAttributeName  ==  convTeacherInfo.EntryDay)
{
mstrEntryDay = value.ToString();
 AddUpdatedFld(convTeacherInfo.EntryDay);
}
else if (strAttributeName  ==  convTeacherInfo.IdPhoto)
{
mstrIdPhoto = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdPhoto);
}
else if (strAttributeName  ==  convTeacherInfo.IdReligion)
{
mstrIdReligion = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdReligion);
}
else if (strAttributeName  ==  convTeacherInfo.ReligionName)
{
mstrReligionName = value.ToString();
 AddUpdatedFld(convTeacherInfo.ReligionName);
}
else if (strAttributeName  ==  convTeacherInfo.IsMessage)
{
mbolIsMessage = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.IsMessage);
}
else if (strAttributeName  ==  convTeacherInfo.Microblog)
{
mstrMicroblog = value.ToString();
 AddUpdatedFld(convTeacherInfo.Microblog);
}
else if (strAttributeName  ==  convTeacherInfo.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convTeacherInfo.ModifyUserId);
}
else if (strAttributeName  ==  convTeacherInfo.OffedBak)
{
mbolOffedBak = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.OffedBak);
}
else if (strAttributeName  ==  convTeacherInfo.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convTeacherInfo.PhoneNumber);
}
else if (strAttributeName  ==  convTeacherInfo.QQ)
{
mstrQQ = value.ToString();
 AddUpdatedFld(convTeacherInfo.QQ);
}
else if (strAttributeName  ==  convTeacherInfo.TeachIdCollege)
{
mstrTeachIdCollege = value.ToString();
 AddUpdatedFld(convTeacherInfo.TeachIdCollege);
}
else if (strAttributeName  ==  convTeacherInfo.TeachIdMajor)
{
mstrTeachIdMajor = value.ToString();
 AddUpdatedFld(convTeacherInfo.TeachIdMajor);
}
else if (strAttributeName  ==  convTeacherInfo.Tel)
{
mstrTel = value.ToString();
 AddUpdatedFld(convTeacherInfo.Tel);
}
else if (strAttributeName  ==  convTeacherInfo.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convTeacherInfo.ModifyDate);
}
else if (strAttributeName  ==  convTeacherInfo.RegisterPassword)
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(convTeacherInfo.RegisterPassword);
}
else if (strAttributeName  ==  convTeacherInfo.EntryYear)
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convTeacherInfo.EntryYear);
}
else if (strAttributeName  ==  convTeacherInfo.IdCardNo)
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdCardNo);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeacherInfo.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (convTeacherInfo.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (convTeacherInfo.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convTeacherInfo.IdSex  ==  AttributeName[intIndex])
{
return mstrIdSex;
}
else if (convTeacherInfo.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convTeacherInfo.IdSchoolPs  ==  AttributeName[intIndex])
{
return mstrIdSchoolPs;
}
else if (convTeacherInfo.IdDisciplinePs  ==  AttributeName[intIndex])
{
return mstrIdDisciplinePs;
}
else if (convTeacherInfo.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (convTeacherInfo.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convTeacherInfo.IdEthnic  ==  AttributeName[intIndex])
{
return mstrIdEthnic;
}
else if (convTeacherInfo.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (convTeacherInfo.IdPolitics  ==  AttributeName[intIndex])
{
return mstrIdPolitics;
}
else if (convTeacherInfo.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (convTeacherInfo.IdAdminGrade  ==  AttributeName[intIndex])
{
return mstrIdAdminGrade;
}
else if (convTeacherInfo.AdminGradeDesc  ==  AttributeName[intIndex])
{
return mstrAdminGradeDesc;
}
else if (convTeacherInfo.IdProfGrade  ==  AttributeName[intIndex])
{
return mstrIdProfGrade;
}
else if (convTeacherInfo.ProfenssionalGradeName  ==  AttributeName[intIndex])
{
return mstrProfenssionalGradeName;
}
else if (convTeacherInfo.IdQualif  ==  AttributeName[intIndex])
{
return mstrIdQualif;
}
else if (convTeacherInfo.QualifDesc  ==  AttributeName[intIndex])
{
return mstrQualifDesc;
}
else if (convTeacherInfo.IdDegree  ==  AttributeName[intIndex])
{
return mstrIdDegree;
}
else if (convTeacherInfo.DegreeName  ==  AttributeName[intIndex])
{
return mstrDegreeName;
}
else if (convTeacherInfo.IdStaffType  ==  AttributeName[intIndex])
{
return mstrIdStaffType;
}
else if (convTeacherInfo.StaffTypeName  ==  AttributeName[intIndex])
{
return mstrStaffTypeName;
}
else if (convTeacherInfo.IdProvince  ==  AttributeName[intIndex])
{
return mstrIdProvince;
}
else if (convTeacherInfo.ProvinceName  ==  AttributeName[intIndex])
{
return mstrProvinceName;
}
else if (convTeacherInfo.CitizenId  ==  AttributeName[intIndex])
{
return mstrCitizenId;
}
else if (convTeacherInfo.CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (convTeacherInfo.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convTeacherInfo.GraduationMajor  ==  AttributeName[intIndex])
{
return mstrGraduationMajor;
}
else if (convTeacherInfo.TelNo  ==  AttributeName[intIndex])
{
return mstrTelNo;
}
else if (convTeacherInfo.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (convTeacherInfo.WebSite  ==  AttributeName[intIndex])
{
return mstrWebSite;
}
else if (convTeacherInfo.PersonBlog  ==  AttributeName[intIndex])
{
return mstrPersonBlog;
}
else if (convTeacherInfo.EntryDate  ==  AttributeName[intIndex])
{
return mstrEntryDate;
}
else if (convTeacherInfo.Offed  ==  AttributeName[intIndex])
{
return mbolOffed;
}
else if (convTeacherInfo.IsAvconUser  ==  AttributeName[intIndex])
{
return mbolIsAvconUser;
}
else if (convTeacherInfo.IsGpUser  ==  AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (convTeacherInfo.IsLocalUser  ==  AttributeName[intIndex])
{
return mbolIsLocalUser;
}
else if (convTeacherInfo.FromUnit  ==  AttributeName[intIndex])
{
return mstrFromUnit;
}
else if (convTeacherInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTeacherInfo.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convTeacherInfo.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convTeacherInfo.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convTeacherInfo.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convTeacherInfo.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convTeacherInfo.EntryDay  ==  AttributeName[intIndex])
{
return mstrEntryDay;
}
else if (convTeacherInfo.IdPhoto  ==  AttributeName[intIndex])
{
return mstrIdPhoto;
}
else if (convTeacherInfo.IdReligion  ==  AttributeName[intIndex])
{
return mstrIdReligion;
}
else if (convTeacherInfo.ReligionName  ==  AttributeName[intIndex])
{
return mstrReligionName;
}
else if (convTeacherInfo.IsMessage  ==  AttributeName[intIndex])
{
return mbolIsMessage;
}
else if (convTeacherInfo.Microblog  ==  AttributeName[intIndex])
{
return mstrMicroblog;
}
else if (convTeacherInfo.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convTeacherInfo.OffedBak  ==  AttributeName[intIndex])
{
return mbolOffedBak;
}
else if (convTeacherInfo.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (convTeacherInfo.QQ  ==  AttributeName[intIndex])
{
return mstrQQ;
}
else if (convTeacherInfo.TeachIdCollege  ==  AttributeName[intIndex])
{
return mstrTeachIdCollege;
}
else if (convTeacherInfo.TeachIdMajor  ==  AttributeName[intIndex])
{
return mstrTeachIdMajor;
}
else if (convTeacherInfo.Tel  ==  AttributeName[intIndex])
{
return mstrTel;
}
else if (convTeacherInfo.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convTeacherInfo.RegisterPassword  ==  AttributeName[intIndex])
{
return mstrRegisterPassword;
}
else if (convTeacherInfo.EntryYear  ==  AttributeName[intIndex])
{
return mstrEntryYear;
}
else if (convTeacherInfo.IdCardNo  ==  AttributeName[intIndex])
{
return mstrIdCardNo;
}
return null;
}
set
{
if (convTeacherInfo.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdTeacher);
}
else if (convTeacherInfo.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convTeacherInfo.TeacherId);
}
else if (convTeacherInfo.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convTeacherInfo.TeacherName);
}
else if (convTeacherInfo.IdSex  ==  AttributeName[intIndex])
{
mstrIdSex = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdSex);
}
else if (convTeacherInfo.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convTeacherInfo.SexDesc);
}
else if (convTeacherInfo.IdSchoolPs  ==  AttributeName[intIndex])
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdSchoolPs);
}
else if (convTeacherInfo.IdDisciplinePs  ==  AttributeName[intIndex])
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdDisciplinePs);
}
else if (convTeacherInfo.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdUniZone);
}
else if (convTeacherInfo.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convTeacherInfo.UniZoneDesc);
}
else if (convTeacherInfo.IdEthnic  ==  AttributeName[intIndex])
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdEthnic);
}
else if (convTeacherInfo.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convTeacherInfo.EthnicName);
}
else if (convTeacherInfo.IdPolitics  ==  AttributeName[intIndex])
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdPolitics);
}
else if (convTeacherInfo.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convTeacherInfo.PoliticsName);
}
else if (convTeacherInfo.IdAdminGrade  ==  AttributeName[intIndex])
{
mstrIdAdminGrade = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdAdminGrade);
}
else if (convTeacherInfo.AdminGradeDesc  ==  AttributeName[intIndex])
{
mstrAdminGradeDesc = value.ToString();
 AddUpdatedFld(convTeacherInfo.AdminGradeDesc);
}
else if (convTeacherInfo.IdProfGrade  ==  AttributeName[intIndex])
{
mstrIdProfGrade = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdProfGrade);
}
else if (convTeacherInfo.ProfenssionalGradeName  ==  AttributeName[intIndex])
{
mstrProfenssionalGradeName = value.ToString();
 AddUpdatedFld(convTeacherInfo.ProfenssionalGradeName);
}
else if (convTeacherInfo.IdQualif  ==  AttributeName[intIndex])
{
mstrIdQualif = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdQualif);
}
else if (convTeacherInfo.QualifDesc  ==  AttributeName[intIndex])
{
mstrQualifDesc = value.ToString();
 AddUpdatedFld(convTeacherInfo.QualifDesc);
}
else if (convTeacherInfo.IdDegree  ==  AttributeName[intIndex])
{
mstrIdDegree = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdDegree);
}
else if (convTeacherInfo.DegreeName  ==  AttributeName[intIndex])
{
mstrDegreeName = value.ToString();
 AddUpdatedFld(convTeacherInfo.DegreeName);
}
else if (convTeacherInfo.IdStaffType  ==  AttributeName[intIndex])
{
mstrIdStaffType = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdStaffType);
}
else if (convTeacherInfo.StaffTypeName  ==  AttributeName[intIndex])
{
mstrStaffTypeName = value.ToString();
 AddUpdatedFld(convTeacherInfo.StaffTypeName);
}
else if (convTeacherInfo.IdProvince  ==  AttributeName[intIndex])
{
mstrIdProvince = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdProvince);
}
else if (convTeacherInfo.ProvinceName  ==  AttributeName[intIndex])
{
mstrProvinceName = value.ToString();
 AddUpdatedFld(convTeacherInfo.ProvinceName);
}
else if (convTeacherInfo.CitizenId  ==  AttributeName[intIndex])
{
mstrCitizenId = value.ToString();
 AddUpdatedFld(convTeacherInfo.CitizenId);
}
else if (convTeacherInfo.CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(convTeacherInfo.CardNo);
}
else if (convTeacherInfo.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convTeacherInfo.Birthday);
}
else if (convTeacherInfo.GraduationMajor  ==  AttributeName[intIndex])
{
mstrGraduationMajor = value.ToString();
 AddUpdatedFld(convTeacherInfo.GraduationMajor);
}
else if (convTeacherInfo.TelNo  ==  AttributeName[intIndex])
{
mstrTelNo = value.ToString();
 AddUpdatedFld(convTeacherInfo.TelNo);
}
else if (convTeacherInfo.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(convTeacherInfo.Email);
}
else if (convTeacherInfo.WebSite  ==  AttributeName[intIndex])
{
mstrWebSite = value.ToString();
 AddUpdatedFld(convTeacherInfo.WebSite);
}
else if (convTeacherInfo.PersonBlog  ==  AttributeName[intIndex])
{
mstrPersonBlog = value.ToString();
 AddUpdatedFld(convTeacherInfo.PersonBlog);
}
else if (convTeacherInfo.EntryDate  ==  AttributeName[intIndex])
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convTeacherInfo.EntryDate);
}
else if (convTeacherInfo.Offed  ==  AttributeName[intIndex])
{
mbolOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.Offed);
}
else if (convTeacherInfo.IsAvconUser  ==  AttributeName[intIndex])
{
mbolIsAvconUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.IsAvconUser);
}
else if (convTeacherInfo.IsGpUser  ==  AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.IsGpUser);
}
else if (convTeacherInfo.IsLocalUser  ==  AttributeName[intIndex])
{
mbolIsLocalUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.IsLocalUser);
}
else if (convTeacherInfo.FromUnit  ==  AttributeName[intIndex])
{
mstrFromUnit = value.ToString();
 AddUpdatedFld(convTeacherInfo.FromUnit);
}
else if (convTeacherInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeacherInfo.Memo);
}
else if (convTeacherInfo.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdXzCollege);
}
else if (convTeacherInfo.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convTeacherInfo.CollegeId);
}
else if (convTeacherInfo.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeacherInfo.CollegeName);
}
else if (convTeacherInfo.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeacherInfo.CollegeNameA);
}
else if (convTeacherInfo.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdXzMajor);
}
else if (convTeacherInfo.EntryDay  ==  AttributeName[intIndex])
{
mstrEntryDay = value.ToString();
 AddUpdatedFld(convTeacherInfo.EntryDay);
}
else if (convTeacherInfo.IdPhoto  ==  AttributeName[intIndex])
{
mstrIdPhoto = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdPhoto);
}
else if (convTeacherInfo.IdReligion  ==  AttributeName[intIndex])
{
mstrIdReligion = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdReligion);
}
else if (convTeacherInfo.ReligionName  ==  AttributeName[intIndex])
{
mstrReligionName = value.ToString();
 AddUpdatedFld(convTeacherInfo.ReligionName);
}
else if (convTeacherInfo.IsMessage  ==  AttributeName[intIndex])
{
mbolIsMessage = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.IsMessage);
}
else if (convTeacherInfo.Microblog  ==  AttributeName[intIndex])
{
mstrMicroblog = value.ToString();
 AddUpdatedFld(convTeacherInfo.Microblog);
}
else if (convTeacherInfo.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convTeacherInfo.ModifyUserId);
}
else if (convTeacherInfo.OffedBak  ==  AttributeName[intIndex])
{
mbolOffedBak = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeacherInfo.OffedBak);
}
else if (convTeacherInfo.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convTeacherInfo.PhoneNumber);
}
else if (convTeacherInfo.QQ  ==  AttributeName[intIndex])
{
mstrQQ = value.ToString();
 AddUpdatedFld(convTeacherInfo.QQ);
}
else if (convTeacherInfo.TeachIdCollege  ==  AttributeName[intIndex])
{
mstrTeachIdCollege = value.ToString();
 AddUpdatedFld(convTeacherInfo.TeachIdCollege);
}
else if (convTeacherInfo.TeachIdMajor  ==  AttributeName[intIndex])
{
mstrTeachIdMajor = value.ToString();
 AddUpdatedFld(convTeacherInfo.TeachIdMajor);
}
else if (convTeacherInfo.Tel  ==  AttributeName[intIndex])
{
mstrTel = value.ToString();
 AddUpdatedFld(convTeacherInfo.Tel);
}
else if (convTeacherInfo.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convTeacherInfo.ModifyDate);
}
else if (convTeacherInfo.RegisterPassword  ==  AttributeName[intIndex])
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(convTeacherInfo.RegisterPassword);
}
else if (convTeacherInfo.EntryYear  ==  AttributeName[intIndex])
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convTeacherInfo.EntryYear);
}
else if (convTeacherInfo.IdCardNo  ==  AttributeName[intIndex])
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(convTeacherInfo.IdCardNo);
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
 AddUpdatedFld(convTeacherInfo.IdTeacher);
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
 AddUpdatedFld(convTeacherInfo.TeacherId);
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
 AddUpdatedFld(convTeacherInfo.TeacherName);
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
 AddUpdatedFld(convTeacherInfo.IdSex);
}
}
/// <summary>
/// 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SexDesc
{
get
{
return mstrSexDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexDesc = value;
}
else
{
 mstrSexDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.SexDesc);
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
 AddUpdatedFld(convTeacherInfo.IdSchoolPs);
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
 AddUpdatedFld(convTeacherInfo.IdDisciplinePs);
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
 AddUpdatedFld(convTeacherInfo.IdUniZone);
}
}
/// <summary>
/// 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneDesc
{
get
{
return mstrUniZoneDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneDesc = value;
}
else
{
 mstrUniZoneDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.UniZoneDesc);
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
 AddUpdatedFld(convTeacherInfo.IdEthnic);
}
}
/// <summary>
/// 民族名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EthnicName
{
get
{
return mstrEthnicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEthnicName = value;
}
else
{
 mstrEthnicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.EthnicName);
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
 AddUpdatedFld(convTeacherInfo.IdPolitics);
}
}
/// <summary>
/// 政治面貌(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PoliticsName
{
get
{
return mstrPoliticsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPoliticsName = value;
}
else
{
 mstrPoliticsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.PoliticsName);
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
 AddUpdatedFld(convTeacherInfo.IdAdminGrade);
}
}
/// <summary>
/// 行政职务描述(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminGradeDesc
{
get
{
return mstrAdminGradeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminGradeDesc = value;
}
else
{
 mstrAdminGradeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.AdminGradeDesc);
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
 AddUpdatedFld(convTeacherInfo.IdProfGrade);
}
}
/// <summary>
/// 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProfenssionalGradeName
{
get
{
return mstrProfenssionalGradeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProfenssionalGradeName = value;
}
else
{
 mstrProfenssionalGradeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.ProfenssionalGradeName);
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
 AddUpdatedFld(convTeacherInfo.IdQualif);
}
}
/// <summary>
/// QualifDesc(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QualifDesc
{
get
{
return mstrQualifDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQualifDesc = value;
}
else
{
 mstrQualifDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.QualifDesc);
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
 AddUpdatedFld(convTeacherInfo.IdDegree);
}
}
/// <summary>
/// 学位名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DegreeName
{
get
{
return mstrDegreeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDegreeName = value;
}
else
{
 mstrDegreeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.DegreeName);
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
 AddUpdatedFld(convTeacherInfo.IdStaffType);
}
}
/// <summary>
/// 职工类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StaffTypeName
{
get
{
return mstrStaffTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStaffTypeName = value;
}
else
{
 mstrStaffTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.StaffTypeName);
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
 AddUpdatedFld(convTeacherInfo.IdProvince);
}
}
/// <summary>
/// ProvinceName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProvinceName
{
get
{
return mstrProvinceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProvinceName = value;
}
else
{
 mstrProvinceName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.ProvinceName);
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
 AddUpdatedFld(convTeacherInfo.CitizenId);
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
 AddUpdatedFld(convTeacherInfo.CardNo);
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
 AddUpdatedFld(convTeacherInfo.Birthday);
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
 AddUpdatedFld(convTeacherInfo.GraduationMajor);
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
 AddUpdatedFld(convTeacherInfo.TelNo);
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
 AddUpdatedFld(convTeacherInfo.Email);
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
 AddUpdatedFld(convTeacherInfo.WebSite);
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
 AddUpdatedFld(convTeacherInfo.PersonBlog);
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
 AddUpdatedFld(convTeacherInfo.EntryDate);
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
 AddUpdatedFld(convTeacherInfo.Offed);
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
 AddUpdatedFld(convTeacherInfo.IsAvconUser);
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
 AddUpdatedFld(convTeacherInfo.IsGpUser);
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
 AddUpdatedFld(convTeacherInfo.IsLocalUser);
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
 AddUpdatedFld(convTeacherInfo.FromUnit);
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
 AddUpdatedFld(convTeacherInfo.Memo);
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
 AddUpdatedFld(convTeacherInfo.IdXzCollege);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.CollegeId);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.CollegeName);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.CollegeNameA);
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
 AddUpdatedFld(convTeacherInfo.IdXzMajor);
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
 AddUpdatedFld(convTeacherInfo.EntryDay);
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
 AddUpdatedFld(convTeacherInfo.IdPhoto);
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
 AddUpdatedFld(convTeacherInfo.IdReligion);
}
}
/// <summary>
/// ReligionName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReligionName
{
get
{
return mstrReligionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReligionName = value;
}
else
{
 mstrReligionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.ReligionName);
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
 AddUpdatedFld(convTeacherInfo.IsMessage);
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
 AddUpdatedFld(convTeacherInfo.Microblog);
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
 AddUpdatedFld(convTeacherInfo.ModifyUserId);
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
 AddUpdatedFld(convTeacherInfo.OffedBak);
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
 AddUpdatedFld(convTeacherInfo.PhoneNumber);
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
 AddUpdatedFld(convTeacherInfo.QQ);
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
 AddUpdatedFld(convTeacherInfo.TeachIdCollege);
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
 AddUpdatedFld(convTeacherInfo.TeachIdMajor);
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
 AddUpdatedFld(convTeacherInfo.Tel);
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
 AddUpdatedFld(convTeacherInfo.ModifyDate);
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
 AddUpdatedFld(convTeacherInfo.RegisterPassword);
}
}
/// <summary>
/// EntryYear(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EntryYear
{
get
{
return mstrEntryYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEntryYear = value;
}
else
{
 mstrEntryYear = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeacherInfo.EntryYear);
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
 AddUpdatedFld(convTeacherInfo.IdCardNo);
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
 /// v教师(vTeacherInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeacherInfo
{
public const string _CurrTabName = "vTeacherInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeacher", "TeacherId", "TeacherName", "IdSex", "SexDesc", "IdSchoolPs", "IdDisciplinePs", "IdUniZone", "UniZoneDesc", "IdEthnic", "EthnicName", "IdPolitics", "PoliticsName", "IdAdminGrade", "AdminGradeDesc", "IdProfGrade", "ProfenssionalGradeName", "IdQualif", "QualifDesc", "IdDegree", "DegreeName", "IdStaffType", "StaffTypeName", "IdProvince", "ProvinceName", "CitizenId", "CardNo", "Birthday", "GraduationMajor", "TelNo", "Email", "WebSite", "PersonBlog", "EntryDate", "Offed", "IsAvconUser", "IsGpUser", "IsLocalUser", "FromUnit", "Memo", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "EntryDay", "IdPhoto", "IdReligion", "ReligionName", "IsMessage", "Microblog", "ModifyUserId", "OffedBak", "PhoneNumber", "QQ", "TeachIdCollege", "TeachIdMajor", "Tel", "ModifyDate", "RegisterPassword", "EntryYear", "IdCardNo"};
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
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

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
 /// 常量:"UniZoneDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneDesc = "UniZoneDesc";    //校区名称

 /// <summary>
 /// 常量:"IdEthnic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEthnic = "IdEthnic";    //民族流水号

 /// <summary>
 /// 常量:"EthnicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EthnicName = "EthnicName";    //民族名称

 /// <summary>
 /// 常量:"IdPolitics"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPolitics = "IdPolitics";    //政治面貌流水号

 /// <summary>
 /// 常量:"PoliticsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsName = "PoliticsName";    //政治面貌

 /// <summary>
 /// 常量:"IdAdminGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminGrade = "IdAdminGrade";    //行政职务流水号

 /// <summary>
 /// 常量:"AdminGradeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminGradeDesc = "AdminGradeDesc";    //行政职务描述

 /// <summary>
 /// 常量:"IdProfGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdProfGrade = "IdProfGrade";    //专业职称流水号

 /// <summary>
 /// 常量:"ProfenssionalGradeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProfenssionalGradeName = "ProfenssionalGradeName";    //专业职称

 /// <summary>
 /// 常量:"IdQualif"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdQualif = "IdQualif";    //学历流水号

 /// <summary>
 /// 常量:"QualifDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QualifDesc = "QualifDesc";    //QualifDesc

 /// <summary>
 /// 常量:"IdDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDegree = "IdDegree";    //学位流水号

 /// <summary>
 /// 常量:"DegreeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DegreeName = "DegreeName";    //学位名称

 /// <summary>
 /// 常量:"IdStaffType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStaffType = "IdStaffType";    //职工类型流水号

 /// <summary>
 /// 常量:"StaffTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StaffTypeName = "StaffTypeName";    //职工类型名称

 /// <summary>
 /// 常量:"IdProvince"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdProvince = "IdProvince";    //省份流水号

 /// <summary>
 /// 常量:"ProvinceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProvinceName = "ProvinceName";    //ProvinceName

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
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

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
 /// 常量:"ReligionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReligionName = "ReligionName";    //ReligionName

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
 /// 常量:"EntryYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryYear = "EntryYear";    //EntryYear

 /// <summary>
 /// 常量:"IdCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCardNo = "IdCardNo";    //身份证号
}

}