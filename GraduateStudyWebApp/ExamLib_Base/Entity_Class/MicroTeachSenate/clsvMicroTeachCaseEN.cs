
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroTeachCaseEN
 表名:vMicroTeachCase(01120324)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表vMicroTeachCase的关键字(IdMicroteachCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCase_vMicroTeachCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMicroteachCase">表关键字</param>
public K_IdMicroteachCase_vMicroTeachCase(string strIdMicroteachCase)
{
if (IsValid(strIdMicroteachCase)) Value = strIdMicroteachCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true) return false;
if (strIdMicroteachCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachCase_vMicroTeachCase]类型的对象</returns>
public static implicit operator K_IdMicroteachCase_vMicroTeachCase(string value)
{
return new K_IdMicroteachCase_vMicroTeachCase(value);
}
}
 /// <summary>
 /// v微格教学案例(vMicroTeachCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroTeachCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroTeachCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 81;
public static string[] AttributeName = new string[] {"IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IdMicroteachCaseType", "MicroteachCaseTypeName", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "microteachCaseText", "OwnerId", "IdStudentInfo", "StuName", "StuID", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "IsDualVideo", "UserKindId", "UserKindName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "IsHaveVideo", "OwnerName", "BrowseCount4Case"};

protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrMicroteachCaseID;    //微格教学案例ID
protected string mstrMicroteachCaseName;    //微格教学案例名称
protected string mstrMicroteachCaseTheme;    //微格教学案例主题词
protected string mstrMicroteachCaseDate;    //微格教学日期
protected string mstrMicroteachCaseTime;    //微格教学时间
protected string mstrMicroteachCaseDateIn;    //案例入库日期
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrMicroTeachCaseTimeIn;    //案例入库时间
protected string mstrIdMicroteachCaseType;    //微格案例类型流水号
protected string mstrMicroteachCaseTypeName;    //微格案例类型名称
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected int? mintVersionNo;    //版本号
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrTeachSkillID;    //教学技能ID
protected string mstrSkillTypeName;    //技能类型名称
protected string mstrTeachSkillName;    //教学技能名称
protected string mstrTeachSkillTheory;    //教学技能理论阐述
protected string mstrTeachSkillOperMethod;    //教学技能实践操作方法
protected string mstrIdSkillType;    //技能类型流水号
protected string mstrSkillTypeID;    //技能类型ID
protected string mstrCaseLevelId;    //课例等级Id
protected string mstrCaseLevelName;    //案例等级名称
protected string mstrDocFile;    //生成的Word文件名
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected bool mbolIsVisible;    //是否显示
protected string mstrmicroteachCaseText;    //案例文本内容
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrStuName;    //姓名
protected string mstrStuID;    //学号
protected string mstrPoliticsName;    //政治面貌
protected string mstrSexDesc;    //性别名称
protected string mstrEthnicName;    //民族名称
protected string mstrUniZoneDesc;    //校区名称
protected string mstrStuTypeDesc;    //学生类别名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrIdAdminCls;    //行政班流水号
protected string mstrAdminClsId;    //行政班代号
protected string mstrAdminClsName;    //行政班名称
protected string mstrBirthday;    //出生日期
protected string mstrNativePlace;    //籍贯
protected string mstrDuty;    //职位
protected string mstrIDCardNo;    //身份证号
protected string mstrStuCardNo;    //学生证号
protected string mstrLiveAddress;    //居住地址
protected string mstrHomePhone;    //住宅电话
protected string mstrEnrollmentDate;    //入校日期
protected string mstrPostCode;    //邮编
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrMemo;    //备注
protected string mstrIsHaveVideo;    //IsHaveVideo
protected string mstrOwnerName;    //拥有者姓名
protected int? mintBrowseCount4Case;    //课例浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroTeachCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMicroteachCase">关键字:微格教学案例流水号</param>
public clsvMicroTeachCaseEN(string strIdMicroteachCase)
 {
strIdMicroteachCase = strIdMicroteachCase.Replace("'", "''");
if (strIdMicroteachCase.Length > 8)
{
throw new Exception("在表:vMicroTeachCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMicroteachCase)  ==  true)
{
throw new Exception("在表:vMicroTeachCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroteachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMicroteachCase = strIdMicroteachCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCase");
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
if (strAttributeName  ==  convMicroTeachCase.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseID)
{
return mstrMicroteachCaseID;
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseName)
{
return mstrMicroteachCaseName;
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseTheme)
{
return mstrMicroteachCaseTheme;
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseDate)
{
return mstrMicroteachCaseDate;
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseTime)
{
return mstrMicroteachCaseTime;
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseDateIn)
{
return mstrMicroteachCaseDateIn;
}
else if (strAttributeName  ==  convMicroTeachCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convMicroTeachCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convMicroTeachCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convMicroTeachCase.MicroTeachCaseTimeIn)
{
return mstrMicroTeachCaseTimeIn;
}
else if (strAttributeName  ==  convMicroTeachCase.IdMicroteachCaseType)
{
return mstrIdMicroteachCaseType;
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseTypeName)
{
return mstrMicroteachCaseTypeName;
}
else if (strAttributeName  ==  convMicroTeachCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convMicroTeachCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convMicroTeachCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convMicroTeachCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convMicroTeachCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convMicroTeachCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convMicroTeachCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convMicroTeachCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convMicroTeachCase.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convMicroTeachCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convMicroTeachCase.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convMicroTeachCase.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convMicroTeachCase.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convMicroTeachCase.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convMicroTeachCase.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convMicroTeachCase.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convMicroTeachCase.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convMicroTeachCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convMicroTeachCase.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convMicroTeachCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convMicroTeachCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convMicroTeachCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convMicroTeachCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convMicroTeachCase.microteachCaseText)
{
return mstrmicroteachCaseText;
}
else if (strAttributeName  ==  convMicroTeachCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convMicroTeachCase.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convMicroTeachCase.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convMicroTeachCase.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convMicroTeachCase.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  convMicroTeachCase.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convMicroTeachCase.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  convMicroTeachCase.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convMicroTeachCase.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convMicroTeachCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convMicroTeachCase.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convMicroTeachCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convMicroTeachCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convMicroTeachCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convMicroTeachCase.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convMicroTeachCase.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convMicroTeachCase.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convMicroTeachCase.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convMicroTeachCase.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  convMicroTeachCase.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  convMicroTeachCase.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convMicroTeachCase.NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  convMicroTeachCase.Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  convMicroTeachCase.IDCardNo)
{
return mstrIDCardNo;
}
else if (strAttributeName  ==  convMicroTeachCase.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convMicroTeachCase.LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  convMicroTeachCase.HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  convMicroTeachCase.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convMicroTeachCase.PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  convMicroTeachCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convMicroTeachCase.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convMicroTeachCase.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convMicroTeachCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convMicroTeachCase.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convMicroTeachCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convMicroTeachCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convMicroTeachCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convMicroTeachCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convMicroTeachCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convMicroTeachCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convMicroTeachCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convMicroTeachCase.IsHaveVideo)
{
return mstrIsHaveVideo;
}
else if (strAttributeName  ==  convMicroTeachCase.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convMicroTeachCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroTeachCase.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseID)
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseID);
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseName)
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseName);
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseTheme)
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTheme);
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseDate)
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseDate);
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseTime)
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTime);
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseDateIn)
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseDateIn);
}
else if (strAttributeName  ==  convMicroTeachCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdStudyLevel);
}
else if (strAttributeName  ==  convMicroTeachCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StudyLevelName);
}
else if (strAttributeName  ==  convMicroTeachCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convMicroTeachCase.MicroTeachCaseTimeIn)
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroTeachCaseTimeIn);
}
else if (strAttributeName  ==  convMicroTeachCase.IdMicroteachCaseType)
{
mstrIdMicroteachCaseType = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdMicroteachCaseType);
}
else if (strAttributeName  ==  convMicroTeachCase.MicroteachCaseTypeName)
{
mstrMicroteachCaseTypeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTypeName);
}
else if (strAttributeName  ==  convMicroTeachCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdCaseType);
}
else if (strAttributeName  ==  convMicroTeachCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdDiscipline);
}
else if (strAttributeName  ==  convMicroTeachCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.DisciplineID);
}
else if (strAttributeName  ==  convMicroTeachCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.DisciplineName);
}
else if (strAttributeName  ==  convMicroTeachCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convMicroTeachCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convMicroTeachCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convMicroTeachCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convMicroTeachCase.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroTeachCase.VersionNo);
}
else if (strAttributeName  ==  convMicroTeachCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdTeachSkill);
}
else if (strAttributeName  ==  convMicroTeachCase.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.TeachSkillID);
}
else if (strAttributeName  ==  convMicroTeachCase.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.SkillTypeName);
}
else if (strAttributeName  ==  convMicroTeachCase.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.TeachSkillName);
}
else if (strAttributeName  ==  convMicroTeachCase.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convMicroTeachCase.TeachSkillTheory);
}
else if (strAttributeName  ==  convMicroTeachCase.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convMicroTeachCase.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convMicroTeachCase.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdSkillType);
}
else if (strAttributeName  ==  convMicroTeachCase.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.SkillTypeID);
}
else if (strAttributeName  ==  convMicroTeachCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CaseLevelId);
}
else if (strAttributeName  ==  convMicroTeachCase.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CaseLevelName);
}
else if (strAttributeName  ==  convMicroTeachCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convMicroTeachCase.DocFile);
}
else if (strAttributeName  ==  convMicroTeachCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroTeachCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convMicroTeachCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convMicroTeachCase.WordCreateDate);
}
else if (strAttributeName  ==  convMicroTeachCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroTeachCase.IsVisible);
}
else if (strAttributeName  ==  convMicroTeachCase.microteachCaseText)
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroTeachCase.microteachCaseText);
}
else if (strAttributeName  ==  convMicroTeachCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.OwnerId);
}
else if (strAttributeName  ==  convMicroTeachCase.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdStudentInfo);
}
else if (strAttributeName  ==  convMicroTeachCase.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StuName);
}
else if (strAttributeName  ==  convMicroTeachCase.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StuID);
}
else if (strAttributeName  ==  convMicroTeachCase.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.PoliticsName);
}
else if (strAttributeName  ==  convMicroTeachCase.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convMicroTeachCase.SexDesc);
}
else if (strAttributeName  ==  convMicroTeachCase.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.EthnicName);
}
else if (strAttributeName  ==  convMicroTeachCase.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UniZoneDesc);
}
else if (strAttributeName  ==  convMicroTeachCase.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StuTypeDesc);
}
else if (strAttributeName  ==  convMicroTeachCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdXzCollege);
}
else if (strAttributeName  ==  convMicroTeachCase.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CollegeID);
}
else if (strAttributeName  ==  convMicroTeachCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CollegeName);
}
else if (strAttributeName  ==  convMicroTeachCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CollegeNameA);
}
else if (strAttributeName  ==  convMicroTeachCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdXzMajor);
}
else if (strAttributeName  ==  convMicroTeachCase.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MajorName);
}
else if (strAttributeName  ==  convMicroTeachCase.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdGradeBase);
}
else if (strAttributeName  ==  convMicroTeachCase.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.GradeBaseName);
}
else if (strAttributeName  ==  convMicroTeachCase.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdAdminCls);
}
else if (strAttributeName  ==  convMicroTeachCase.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.AdminClsId);
}
else if (strAttributeName  ==  convMicroTeachCase.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.AdminClsName);
}
else if (strAttributeName  ==  convMicroTeachCase.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convMicroTeachCase.Birthday);
}
else if (strAttributeName  ==  convMicroTeachCase.NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convMicroTeachCase.NativePlace);
}
else if (strAttributeName  ==  convMicroTeachCase.Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(convMicroTeachCase.Duty);
}
else if (strAttributeName  ==  convMicroTeachCase.IDCardNo)
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IDCardNo);
}
else if (strAttributeName  ==  convMicroTeachCase.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StuCardNo);
}
else if (strAttributeName  ==  convMicroTeachCase.LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convMicroTeachCase.LiveAddress);
}
else if (strAttributeName  ==  convMicroTeachCase.HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convMicroTeachCase.HomePhone);
}
else if (strAttributeName  ==  convMicroTeachCase.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convMicroTeachCase.EnrollmentDate);
}
else if (strAttributeName  ==  convMicroTeachCase.PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convMicroTeachCase.PostCode);
}
else if (strAttributeName  ==  convMicroTeachCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroTeachCase.IsDualVideo);
}
else if (strAttributeName  ==  convMicroTeachCase.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UserKindId);
}
else if (strAttributeName  ==  convMicroTeachCase.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UserKindName);
}
else if (strAttributeName  ==  convMicroTeachCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UserTypeId);
}
else if (strAttributeName  ==  convMicroTeachCase.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UserTypeName);
}
else if (strAttributeName  ==  convMicroTeachCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convMicroTeachCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convMicroTeachCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroTeachCase.ftpFileType);
}
else if (strAttributeName  ==  convMicroTeachCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convMicroTeachCase.VideoUrl);
}
else if (strAttributeName  ==  convMicroTeachCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convMicroTeachCase.VideoPath);
}
else if (strAttributeName  ==  convMicroTeachCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convMicroTeachCase.ResErrMsg);
}
else if (strAttributeName  ==  convMicroTeachCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.Memo);
}
else if (strAttributeName  ==  convMicroTeachCase.IsHaveVideo)
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IsHaveVideo);
}
else if (strAttributeName  ==  convMicroTeachCase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.OwnerName);
}
else if (strAttributeName  ==  convMicroTeachCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroTeachCase.BrowseCount4Case);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroTeachCase.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroTeachCase.MicroteachCaseID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseID;
}
else if (convMicroTeachCase.MicroteachCaseName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseName;
}
else if (convMicroTeachCase.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTheme;
}
else if (convMicroTeachCase.MicroteachCaseDate  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDate;
}
else if (convMicroTeachCase.MicroteachCaseTime  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTime;
}
else if (convMicroTeachCase.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDateIn;
}
else if (convMicroTeachCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convMicroTeachCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convMicroTeachCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convMicroTeachCase.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseTimeIn;
}
else if (convMicroTeachCase.IdMicroteachCaseType  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCaseType;
}
else if (convMicroTeachCase.MicroteachCaseTypeName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTypeName;
}
else if (convMicroTeachCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convMicroTeachCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convMicroTeachCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convMicroTeachCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convMicroTeachCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convMicroTeachCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convMicroTeachCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convMicroTeachCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convMicroTeachCase.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convMicroTeachCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convMicroTeachCase.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convMicroTeachCase.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convMicroTeachCase.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convMicroTeachCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convMicroTeachCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convMicroTeachCase.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convMicroTeachCase.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convMicroTeachCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convMicroTeachCase.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convMicroTeachCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convMicroTeachCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convMicroTeachCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convMicroTeachCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convMicroTeachCase.microteachCaseText  ==  AttributeName[intIndex])
{
return mstrmicroteachCaseText;
}
else if (convMicroTeachCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convMicroTeachCase.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convMicroTeachCase.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convMicroTeachCase.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convMicroTeachCase.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (convMicroTeachCase.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convMicroTeachCase.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (convMicroTeachCase.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convMicroTeachCase.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convMicroTeachCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convMicroTeachCase.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convMicroTeachCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convMicroTeachCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convMicroTeachCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convMicroTeachCase.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convMicroTeachCase.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convMicroTeachCase.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convMicroTeachCase.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convMicroTeachCase.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (convMicroTeachCase.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (convMicroTeachCase.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convMicroTeachCase.NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (convMicroTeachCase.Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (convMicroTeachCase.IDCardNo  ==  AttributeName[intIndex])
{
return mstrIDCardNo;
}
else if (convMicroTeachCase.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convMicroTeachCase.LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (convMicroTeachCase.HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (convMicroTeachCase.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convMicroTeachCase.PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (convMicroTeachCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convMicroTeachCase.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convMicroTeachCase.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convMicroTeachCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convMicroTeachCase.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convMicroTeachCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convMicroTeachCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convMicroTeachCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convMicroTeachCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convMicroTeachCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convMicroTeachCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convMicroTeachCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convMicroTeachCase.IsHaveVideo  ==  AttributeName[intIndex])
{
return mstrIsHaveVideo;
}
else if (convMicroTeachCase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convMicroTeachCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (convMicroTeachCase.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdMicroteachCase);
}
else if (convMicroTeachCase.MicroteachCaseID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseID);
}
else if (convMicroTeachCase.MicroteachCaseName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseName);
}
else if (convMicroTeachCase.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTheme);
}
else if (convMicroTeachCase.MicroteachCaseDate  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseDate);
}
else if (convMicroTeachCase.MicroteachCaseTime  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTime);
}
else if (convMicroTeachCase.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseDateIn);
}
else if (convMicroTeachCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdStudyLevel);
}
else if (convMicroTeachCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StudyLevelName);
}
else if (convMicroTeachCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdTeachingPlan);
}
else if (convMicroTeachCase.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroTeachCaseTimeIn);
}
else if (convMicroTeachCase.IdMicroteachCaseType  ==  AttributeName[intIndex])
{
mstrIdMicroteachCaseType = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdMicroteachCaseType);
}
else if (convMicroTeachCase.MicroteachCaseTypeName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTypeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTypeName);
}
else if (convMicroTeachCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdCaseType);
}
else if (convMicroTeachCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdDiscipline);
}
else if (convMicroTeachCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.DisciplineID);
}
else if (convMicroTeachCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.DisciplineName);
}
else if (convMicroTeachCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdSenateGaugeVersion);
}
else if (convMicroTeachCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionID);
}
else if (convMicroTeachCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionName);
}
else if (convMicroTeachCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionTtlScore);
}
else if (convMicroTeachCase.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroTeachCase.VersionNo);
}
else if (convMicroTeachCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdTeachSkill);
}
else if (convMicroTeachCase.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.TeachSkillID);
}
else if (convMicroTeachCase.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.SkillTypeName);
}
else if (convMicroTeachCase.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.TeachSkillName);
}
else if (convMicroTeachCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convMicroTeachCase.TeachSkillTheory);
}
else if (convMicroTeachCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convMicroTeachCase.TeachSkillOperMethod);
}
else if (convMicroTeachCase.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdSkillType);
}
else if (convMicroTeachCase.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.SkillTypeID);
}
else if (convMicroTeachCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CaseLevelId);
}
else if (convMicroTeachCase.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CaseLevelName);
}
else if (convMicroTeachCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convMicroTeachCase.DocFile);
}
else if (convMicroTeachCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroTeachCase.IsNeedGeneWord);
}
else if (convMicroTeachCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convMicroTeachCase.WordCreateDate);
}
else if (convMicroTeachCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroTeachCase.IsVisible);
}
else if (convMicroTeachCase.microteachCaseText  ==  AttributeName[intIndex])
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroTeachCase.microteachCaseText);
}
else if (convMicroTeachCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.OwnerId);
}
else if (convMicroTeachCase.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdStudentInfo);
}
else if (convMicroTeachCase.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StuName);
}
else if (convMicroTeachCase.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StuID);
}
else if (convMicroTeachCase.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.PoliticsName);
}
else if (convMicroTeachCase.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convMicroTeachCase.SexDesc);
}
else if (convMicroTeachCase.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.EthnicName);
}
else if (convMicroTeachCase.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UniZoneDesc);
}
else if (convMicroTeachCase.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StuTypeDesc);
}
else if (convMicroTeachCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdXzCollege);
}
else if (convMicroTeachCase.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CollegeID);
}
else if (convMicroTeachCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CollegeName);
}
else if (convMicroTeachCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroTeachCase.CollegeNameA);
}
else if (convMicroTeachCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdXzMajor);
}
else if (convMicroTeachCase.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.MajorName);
}
else if (convMicroTeachCase.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdGradeBase);
}
else if (convMicroTeachCase.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.GradeBaseName);
}
else if (convMicroTeachCase.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IdAdminCls);
}
else if (convMicroTeachCase.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.AdminClsId);
}
else if (convMicroTeachCase.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.AdminClsName);
}
else if (convMicroTeachCase.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convMicroTeachCase.Birthday);
}
else if (convMicroTeachCase.NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convMicroTeachCase.NativePlace);
}
else if (convMicroTeachCase.Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(convMicroTeachCase.Duty);
}
else if (convMicroTeachCase.IDCardNo  ==  AttributeName[intIndex])
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IDCardNo);
}
else if (convMicroTeachCase.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.StuCardNo);
}
else if (convMicroTeachCase.LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convMicroTeachCase.LiveAddress);
}
else if (convMicroTeachCase.HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convMicroTeachCase.HomePhone);
}
else if (convMicroTeachCase.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convMicroTeachCase.EnrollmentDate);
}
else if (convMicroTeachCase.PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convMicroTeachCase.PostCode);
}
else if (convMicroTeachCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroTeachCase.IsDualVideo);
}
else if (convMicroTeachCase.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UserKindId);
}
else if (convMicroTeachCase.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UserKindName);
}
else if (convMicroTeachCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UserTypeId);
}
else if (convMicroTeachCase.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.UserTypeName);
}
else if (convMicroTeachCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMicroTeachCase.RecommendedDegreeId);
}
else if (convMicroTeachCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.RecommendedDegreeName);
}
else if (convMicroTeachCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroTeachCase.ftpFileType);
}
else if (convMicroTeachCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convMicroTeachCase.VideoUrl);
}
else if (convMicroTeachCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convMicroTeachCase.VideoPath);
}
else if (convMicroTeachCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convMicroTeachCase.ResErrMsg);
}
else if (convMicroTeachCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.Memo);
}
else if (convMicroTeachCase.IsHaveVideo  ==  AttributeName[intIndex])
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convMicroTeachCase.IsHaveVideo);
}
else if (convMicroTeachCase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroTeachCase.OwnerName);
}
else if (convMicroTeachCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroTeachCase.BrowseCount4Case);
}
}
}

/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdMicroteachCase);
}
}
/// <summary>
/// 微格教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseID
{
get
{
return mstrMicroteachCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseID = value;
}
else
{
 mstrMicroteachCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseID);
}
}
/// <summary>
/// 微格教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseName
{
get
{
return mstrMicroteachCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseName = value;
}
else
{
 mstrMicroteachCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseName);
}
}
/// <summary>
/// 微格教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseTheme
{
get
{
return mstrMicroteachCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseTheme = value;
}
else
{
 mstrMicroteachCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTheme);
}
}
/// <summary>
/// 微格教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseDate
{
get
{
return mstrMicroteachCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseDate = value;
}
else
{
 mstrMicroteachCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseDate);
}
}
/// <summary>
/// 微格教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseTime
{
get
{
return mstrMicroteachCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseTime = value;
}
else
{
 mstrMicroteachCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseDateIn
{
get
{
return mstrMicroteachCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseDateIn = value;
}
else
{
 mstrMicroteachCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseDateIn);
}
}
/// <summary>
/// id_StudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudyLevel
{
get
{
return mstrIdStudyLevel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudyLevel = value;
}
else
{
 mstrIdStudyLevel = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdStudyLevel);
}
}
/// <summary>
/// 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StudyLevelName
{
get
{
return mstrStudyLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStudyLevelName = value;
}
else
{
 mstrStudyLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.StudyLevelName);
}
}
/// <summary>
/// 教案流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingPlan
{
get
{
return mstrIdTeachingPlan;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingPlan = value;
}
else
{
 mstrIdTeachingPlan = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdTeachingPlan);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseTimeIn
{
get
{
return mstrMicroTeachCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseTimeIn = value;
}
else
{
 mstrMicroTeachCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MicroTeachCaseTimeIn);
}
}
/// <summary>
/// 微格案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCaseType
{
get
{
return mstrIdMicroteachCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCaseType = value;
}
else
{
 mstrIdMicroteachCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdMicroteachCaseType);
}
}
/// <summary>
/// 微格案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseTypeName
{
get
{
return mstrMicroteachCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseTypeName = value;
}
else
{
 mstrMicroteachCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MicroteachCaseTypeName);
}
}
/// <summary>
/// 案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseType
{
get
{
return mstrIdCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseType = value;
}
else
{
 mstrIdCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdCaseType);
}
}
/// <summary>
/// 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDiscipline
{
get
{
return mstrIdDiscipline;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDiscipline = value;
}
else
{
 mstrIdDiscipline = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdDiscipline);
}
}
/// <summary>
/// 学科ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineID
{
get
{
return mstrDisciplineID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineID = value;
}
else
{
 mstrDisciplineID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.DisciplineID);
}
}
/// <summary>
/// 学科名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineName
{
get
{
return mstrDisciplineName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineName = value;
}
else
{
 mstrDisciplineName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.DisciplineName);
}
}
/// <summary>
/// 评价量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeVersion
{
get
{
return mstrIdSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeVersion = value;
}
else
{
 mstrIdSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdSenateGaugeVersion);
}
}
/// <summary>
/// 评价量表版本ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionID
{
get
{
return mstrsenateGaugeVersionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionID = value;
}
else
{
 mstrsenateGaugeVersionID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionID);
}
}
/// <summary>
/// 评价量表版本名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionName
{
get
{
return mstrsenateGaugeVersionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionName = value;
}
else
{
 mstrsenateGaugeVersionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 版本号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionNo
{
get
{
return mintVersionNo;
}
set
{
 mintVersionNo = value;
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.VersionNo);
}
}
/// <summary>
/// 教学技能流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachSkill
{
get
{
return mstrIdTeachSkill;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachSkill = value;
}
else
{
 mstrIdTeachSkill = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdTeachSkill);
}
}
/// <summary>
/// 教学技能ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillID
{
get
{
return mstrTeachSkillID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillID = value;
}
else
{
 mstrTeachSkillID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.TeachSkillID);
}
}
/// <summary>
/// 技能类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeName
{
get
{
return mstrSkillTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeName = value;
}
else
{
 mstrSkillTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.SkillTypeName);
}
}
/// <summary>
/// 教学技能名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillName
{
get
{
return mstrTeachSkillName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillName = value;
}
else
{
 mstrTeachSkillName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.TeachSkillName);
}
}
/// <summary>
/// 教学技能理论阐述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillTheory
{
get
{
return mstrTeachSkillTheory;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillTheory = value;
}
else
{
 mstrTeachSkillTheory = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.TeachSkillTheory);
}
}
/// <summary>
/// 教学技能实践操作方法(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillOperMethod
{
get
{
return mstrTeachSkillOperMethod;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillOperMethod = value;
}
else
{
 mstrTeachSkillOperMethod = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.TeachSkillOperMethod);
}
}
/// <summary>
/// 技能类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSkillType
{
get
{
return mstrIdSkillType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSkillType = value;
}
else
{
 mstrIdSkillType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdSkillType);
}
}
/// <summary>
/// 技能类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeID
{
get
{
return mstrSkillTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeID = value;
}
else
{
 mstrSkillTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.SkillTypeID);
}
}
/// <summary>
/// 课例等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseLevelId
{
get
{
return mstrCaseLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseLevelId = value;
}
else
{
 mstrCaseLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.CaseLevelId);
}
}
/// <summary>
/// 案例等级名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseLevelName
{
get
{
return mstrCaseLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseLevelName = value;
}
else
{
 mstrCaseLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.CaseLevelName);
}
}
/// <summary>
/// 生成的Word文件名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DocFile
{
get
{
return mstrDocFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDocFile = value;
}
else
{
 mstrDocFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.DocFile);
}
}
/// <summary>
/// 是否需要生成Word(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedGeneWord
{
get
{
return mbolIsNeedGeneWord;
}
set
{
 mbolIsNeedGeneWord = value;
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IsNeedGeneWord);
}
}
/// <summary>
/// Word生成日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WordCreateDate
{
get
{
return mstrWordCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWordCreateDate = value;
}
else
{
 mstrWordCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.WordCreateDate);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IsVisible);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string microteachCaseText
{
get
{
return mstrmicroteachCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmicroteachCaseText = value;
}
else
{
 mstrmicroteachCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.microteachCaseText);
}
}
/// <summary>
/// 拥有者Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId
{
get
{
return mstrOwnerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId = value;
}
else
{
 mstrOwnerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.OwnerId);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdStudentInfo);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.StuName);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuID
{
get
{
return mstrStuID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuID = value;
}
else
{
 mstrStuID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.StuID);
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
 AddUpdatedFld(convMicroTeachCase.PoliticsName);
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
 AddUpdatedFld(convMicroTeachCase.SexDesc);
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
 AddUpdatedFld(convMicroTeachCase.EthnicName);
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
 AddUpdatedFld(convMicroTeachCase.UniZoneDesc);
}
}
/// <summary>
/// 学生类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeDesc
{
get
{
return mstrStuTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeDesc = value;
}
else
{
 mstrStuTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.StuTypeDesc);
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
 AddUpdatedFld(convMicroTeachCase.IdXzCollege);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeID
{
get
{
return mstrCollegeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeID = value;
}
else
{
 mstrCollegeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.CollegeID);
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
 AddUpdatedFld(convMicroTeachCase.CollegeName);
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
 AddUpdatedFld(convMicroTeachCase.CollegeNameA);
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
 AddUpdatedFld(convMicroTeachCase.IdXzMajor);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.MajorName);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdGradeBase);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.GradeBaseName);
}
}
/// <summary>
/// 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminCls
{
get
{
return mstrIdAdminCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminCls = value;
}
else
{
 mstrIdAdminCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IdAdminCls);
}
}
/// <summary>
/// 行政班代号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsId
{
get
{
return mstrAdminClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsId = value;
}
else
{
 mstrAdminClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.AdminClsId);
}
}
/// <summary>
/// 行政班名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsName
{
get
{
return mstrAdminClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsName = value;
}
else
{
 mstrAdminClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.AdminClsName);
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
 AddUpdatedFld(convMicroTeachCase.Birthday);
}
}
/// <summary>
/// 籍贯(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NativePlace
{
get
{
return mstrNativePlace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNativePlace = value;
}
else
{
 mstrNativePlace = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.NativePlace);
}
}
/// <summary>
/// 职位(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Duty
{
get
{
return mstrDuty;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDuty = value;
}
else
{
 mstrDuty = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.Duty);
}
}
/// <summary>
/// 身份证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IDCardNo
{
get
{
return mstrIDCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIDCardNo = value;
}
else
{
 mstrIDCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IDCardNo);
}
}
/// <summary>
/// 学生证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuCardNo
{
get
{
return mstrStuCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuCardNo = value;
}
else
{
 mstrStuCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.StuCardNo);
}
}
/// <summary>
/// 居住地址(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiveAddress
{
get
{
return mstrLiveAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiveAddress = value;
}
else
{
 mstrLiveAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.LiveAddress);
}
}
/// <summary>
/// 住宅电话(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomePhone
{
get
{
return mstrHomePhone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomePhone = value;
}
else
{
 mstrHomePhone = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.HomePhone);
}
}
/// <summary>
/// 入校日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EnrollmentDate
{
get
{
return mstrEnrollmentDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEnrollmentDate = value;
}
else
{
 mstrEnrollmentDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.EnrollmentDate);
}
}
/// <summary>
/// 邮编(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PostCode
{
get
{
return mstrPostCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPostCode = value;
}
else
{
 mstrPostCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.PostCode);
}
}
/// <summary>
/// 是否双视频(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDualVideo
{
get
{
return mbolIsDualVideo;
}
set
{
 mbolIsDualVideo = value;
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IsDualVideo);
}
}
/// <summary>
/// 用户类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindId
{
get
{
return mstrUserKindId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindId = value;
}
else
{
 mstrUserKindId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.UserKindId);
}
}
/// <summary>
/// 用户类别名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindName
{
get
{
return mstrUserKindName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindName = value;
}
else
{
 mstrUserKindName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.UserKindName);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.UserTypeId);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.UserTypeName);
}
}
/// <summary>
/// 推荐度Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedDegreeId
{
get
{
return mstrRecommendedDegreeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedDegreeId = value;
}
else
{
 mstrRecommendedDegreeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.RecommendedDegreeId);
}
}
/// <summary>
/// 推荐度名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedDegreeName
{
get
{
return mstrRecommendedDegreeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedDegreeName = value;
}
else
{
 mstrRecommendedDegreeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.RecommendedDegreeName);
}
}
/// <summary>
/// ftp文件类型(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ftpFileType
{
get
{
return mstrftpFileType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrftpFileType = value;
}
else
{
 mstrftpFileType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.ftpFileType);
}
}
/// <summary>
/// 视频Url(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoUrl
{
get
{
return mstrVideoUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoUrl = value;
}
else
{
 mstrVideoUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.VideoUrl);
}
}
/// <summary>
/// 视频目录(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoPath
{
get
{
return mstrVideoPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoPath = value;
}
else
{
 mstrVideoPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.VideoPath);
}
}
/// <summary>
/// 资源错误信息(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResErrMsg
{
get
{
return mstrResErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResErrMsg = value;
}
else
{
 mstrResErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.ResErrMsg);
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
 AddUpdatedFld(convMicroTeachCase.Memo);
}
}
/// <summary>
/// IsHaveVideo(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IsHaveVideo
{
get
{
return mstrIsHaveVideo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIsHaveVideo = value;
}
else
{
 mstrIsHaveVideo = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.IsHaveVideo);
}
}
/// <summary>
/// 拥有者姓名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerName
{
get
{
return mstrOwnerName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerName = value;
}
else
{
 mstrOwnerName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.OwnerName);
}
}
/// <summary>
/// 课例浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount4Case
{
get
{
return mintBrowseCount4Case;
}
set
{
 mintBrowseCount4Case = value;
//记录修改过的字段
 AddUpdatedFld(convMicroTeachCase.BrowseCount4Case);
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
  return mstrIdMicroteachCase;
 }
 }
}
 /// <summary>
 /// v微格教学案例(vMicroTeachCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroTeachCase
{
public const string _CurrTabName = "vMicroTeachCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IdMicroteachCaseType", "MicroteachCaseTypeName", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "microteachCaseText", "OwnerId", "IdStudentInfo", "StuName", "StuID", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "IsDualVideo", "UserKindId", "UserKindName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "IsHaveVideo", "OwnerName", "BrowseCount4Case"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"MicroteachCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseID = "MicroteachCaseID";    //微格教学案例ID

 /// <summary>
 /// 常量:"MicroteachCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseName = "MicroteachCaseName";    //微格教学案例名称

 /// <summary>
 /// 常量:"MicroteachCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseTheme = "MicroteachCaseTheme";    //微格教学案例主题词

 /// <summary>
 /// 常量:"MicroteachCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseDate = "MicroteachCaseDate";    //微格教学日期

 /// <summary>
 /// 常量:"MicroteachCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseTime = "MicroteachCaseTime";    //微格教学时间

 /// <summary>
 /// 常量:"MicroteachCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseDateIn = "MicroteachCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //id_StudyLevel

 /// <summary>
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"MicroTeachCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseTimeIn = "MicroTeachCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdMicroteachCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseType = "IdMicroteachCaseType";    //微格案例类型流水号

 /// <summary>
 /// 常量:"MicroteachCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseTypeName = "MicroteachCaseTypeName";    //微格案例类型名称

 /// <summary>
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

 /// <summary>
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

 /// <summary>
 /// 常量:"DisciplineID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineID = "DisciplineID";    //学科ID

 /// <summary>
 /// 常量:"DisciplineName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineName = "DisciplineName";    //学科名称

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"senateGaugeVersionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionID = "senateGaugeVersionID";    //评价量表版本ID

 /// <summary>
 /// 常量:"senateGaugeVersionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionName = "senateGaugeVersionName";    //评价量表版本名称

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"VersionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNo = "VersionNo";    //版本号

 /// <summary>
 /// 常量:"IdTeachSkill"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachSkill = "IdTeachSkill";    //教学技能流水号

 /// <summary>
 /// 常量:"TeachSkillID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillID = "TeachSkillID";    //教学技能ID

 /// <summary>
 /// 常量:"SkillTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeName = "SkillTypeName";    //技能类型名称

 /// <summary>
 /// 常量:"TeachSkillName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillName = "TeachSkillName";    //教学技能名称

 /// <summary>
 /// 常量:"TeachSkillTheory"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillTheory = "TeachSkillTheory";    //教学技能理论阐述

 /// <summary>
 /// 常量:"TeachSkillOperMethod"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillOperMethod = "TeachSkillOperMethod";    //教学技能实践操作方法

 /// <summary>
 /// 常量:"IdSkillType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSkillType = "IdSkillType";    //技能类型流水号

 /// <summary>
 /// 常量:"SkillTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeID = "SkillTypeID";    //技能类型ID

 /// <summary>
 /// 常量:"CaseLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelId = "CaseLevelId";    //课例等级Id

 /// <summary>
 /// 常量:"CaseLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelName = "CaseLevelName";    //案例等级名称

 /// <summary>
 /// 常量:"DocFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DocFile = "DocFile";    //生成的Word文件名

 /// <summary>
 /// 常量:"IsNeedGeneWord"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGeneWord = "IsNeedGeneWord";    //是否需要生成Word

 /// <summary>
 /// 常量:"WordCreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WordCreateDate = "WordCreateDate";    //Word生成日期

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"microteachCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string microteachCaseText = "microteachCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"StuID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuID = "StuID";    //学号

 /// <summary>
 /// 常量:"PoliticsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsName = "PoliticsName";    //政治面貌

 /// <summary>
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

 /// <summary>
 /// 常量:"EthnicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EthnicName = "EthnicName";    //民族名称

 /// <summary>
 /// 常量:"UniZoneDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneDesc = "UniZoneDesc";    //校区名称

 /// <summary>
 /// 常量:"StuTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeDesc = "StuTypeDesc";    //学生类别名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

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
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"IdAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminCls = "IdAdminCls";    //行政班流水号

 /// <summary>
 /// 常量:"AdminClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsId = "AdminClsId";    //行政班代号

 /// <summary>
 /// 常量:"AdminClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsName = "AdminClsName";    //行政班名称

 /// <summary>
 /// 常量:"Birthday"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Birthday = "Birthday";    //出生日期

 /// <summary>
 /// 常量:"NativePlace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NativePlace = "NativePlace";    //籍贯

 /// <summary>
 /// 常量:"Duty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Duty = "Duty";    //职位

 /// <summary>
 /// 常量:"IDCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IDCardNo = "IDCardNo";    //身份证号

 /// <summary>
 /// 常量:"StuCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuCardNo = "StuCardNo";    //学生证号

 /// <summary>
 /// 常量:"LiveAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiveAddress = "LiveAddress";    //居住地址

 /// <summary>
 /// 常量:"HomePhone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomePhone = "HomePhone";    //住宅电话

 /// <summary>
 /// 常量:"EnrollmentDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnrollmentDate = "EnrollmentDate";    //入校日期

 /// <summary>
 /// 常量:"PostCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PostCode = "PostCode";    //邮编

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"UserKindId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindId = "UserKindId";    //用户类别Id

 /// <summary>
 /// 常量:"UserKindName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindName = "UserKindName";    //用户类别名

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"RecommendedDegreeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeId = "RecommendedDegreeId";    //推荐度Id

 /// <summary>
 /// 常量:"RecommendedDegreeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeName = "RecommendedDegreeName";    //推荐度名称

 /// <summary>
 /// 常量:"ftpFileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpFileType = "ftpFileType";    //ftp文件类型

 /// <summary>
 /// 常量:"VideoUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoUrl = "VideoUrl";    //视频Url

 /// <summary>
 /// 常量:"VideoPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoPath = "VideoPath";    //视频目录

 /// <summary>
 /// 常量:"ResErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResErrMsg = "ResErrMsg";    //资源错误信息

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IsHaveVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveVideo = "IsHaveVideo";    //IsHaveVideo

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数
}

}