
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCase_BaseEN
 表名:vCoursewareCase_Base(01120494)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// 表vCoursewareCase_Base的关键字(IdCoursewareCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCoursewareCase_vCoursewareCase_Base
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCoursewareCase">表关键字</param>
public K_IdCoursewareCase_vCoursewareCase_Base(string strIdCoursewareCase)
{
if (IsValid(strIdCoursewareCase)) Value = strIdCoursewareCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCoursewareCase)
{
if (string.IsNullOrEmpty(strIdCoursewareCase) == true) return false;
if (strIdCoursewareCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCoursewareCase_vCoursewareCase_Base]类型的对象</returns>
public static implicit operator K_IdCoursewareCase_vCoursewareCase_Base(string value)
{
return new K_IdCoursewareCase_vCoursewareCase_Base(value);
}
}
 /// <summary>
 /// v课件教学案例_Base(vCoursewareCase_Base)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCoursewareCase_BaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCoursewareCase_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCoursewareCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 80;
public static string[] AttributeName = new string[] {"IdCoursewareCase", "CoursewareCaseID", "CoursewareCaseName", "CoursewareCaseTheme", "IdCoursewareCaseType", "CoursewareCaseTypeName", "CoursewareCaseText", "CoursewareCaseDate", "CoursewareCaseTime", "CoursewareCaseDateIn", "CoursewareCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "IdStudentInfo", "StuName", "StuID", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "UserKindId", "UserKindName", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "OwnerName", "OwnerNameWithId", "BrowseCount4Case"};

protected string mstrIdCoursewareCase;    //课件教学案例流水号
protected string mstrCoursewareCaseID;    //课件教学案例ID
protected string mstrCoursewareCaseName;    //课件教学案例名称
protected string mstrCoursewareCaseTheme;    //课件教学案例主题词
protected string mstrIdCoursewareCaseType;    //课件案例类型流水号
protected string mstrCoursewareCaseTypeName;    //课件案例类型名称
protected string mstrCoursewareCaseText;    //案例文本内容
protected string mstrCoursewareCaseDate;    //课件教学日期
protected string mstrCoursewareCaseTime;    //课件教学时间
protected string mstrCoursewareCaseDateIn;    //案例入库日期
protected string mstrCoursewareCaseTimeIn;    //案例入库时间
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
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
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrUserTypeId;    //用户类型Id
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrMemo;    //备注
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected int? mintBrowseCount4Case;    //课例浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCoursewareCase_BaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCoursewareCase">关键字:课件教学案例流水号</param>
public clsvCoursewareCase_BaseEN(string strIdCoursewareCase)
 {
strIdCoursewareCase = strIdCoursewareCase.Replace("'", "''");
if (strIdCoursewareCase.Length > 8)
{
throw new Exception("在表:vCoursewareCase_Base中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCoursewareCase)  ==  true)
{
throw new Exception("在表:vCoursewareCase_Base中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCoursewareCase = strIdCoursewareCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareCase");
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
if (strAttributeName  ==  convCoursewareCase_Base.IdCoursewareCase)
{
return mstrIdCoursewareCase;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseID)
{
return mstrCoursewareCaseID;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseName)
{
return mstrCoursewareCaseName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseTheme)
{
return mstrCoursewareCaseTheme;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdCoursewareCaseType)
{
return mstrIdCoursewareCaseType;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseTypeName)
{
return mstrCoursewareCaseTypeName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseText)
{
return mstrCoursewareCaseText;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseDate)
{
return mstrCoursewareCaseDate;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseTime)
{
return mstrCoursewareCaseTime;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseDateIn)
{
return mstrCoursewareCaseDateIn;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseTimeIn)
{
return mstrCoursewareCaseTimeIn;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convCoursewareCase_Base.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convCoursewareCase_Base.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convCoursewareCase_Base.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convCoursewareCase_Base.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convCoursewareCase_Base.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convCoursewareCase_Base.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convCoursewareCase_Base.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convCoursewareCase_Base.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convCoursewareCase_Base.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convCoursewareCase_Base.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convCoursewareCase_Base.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convCoursewareCase_Base.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convCoursewareCase_Base.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convCoursewareCase_Base.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convCoursewareCase_Base.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convCoursewareCase_Base.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCoursewareCase_Base.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convCoursewareCase_Base.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convCoursewareCase_Base.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  convCoursewareCase_Base.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convCoursewareCase_Base.NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  convCoursewareCase_Base.Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IDCardNo)
{
return mstrIDCardNo;
}
else if (strAttributeName  ==  convCoursewareCase_Base.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convCoursewareCase_Base.LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  convCoursewareCase_Base.HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  convCoursewareCase_Base.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convCoursewareCase_Base.PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  convCoursewareCase_Base.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convCoursewareCase_Base.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convCoursewareCase_Base.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCoursewareCase_Base.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convCoursewareCase_Base.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convCoursewareCase_Base.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convCoursewareCase_Base.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convCoursewareCase_Base.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convCoursewareCase_Base.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCoursewareCase_Base.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCoursewareCase_Base.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convCoursewareCase_Base.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (strAttributeName  ==  convCoursewareCase_Base.IdCoursewareCase)
{
mstrIdCoursewareCase = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdCoursewareCase);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseID)
{
mstrCoursewareCaseID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseID);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseName)
{
mstrCoursewareCaseName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseTheme)
{
mstrCoursewareCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTheme);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdCoursewareCaseType)
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdCoursewareCaseType);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseTypeName)
{
mstrCoursewareCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTypeName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseText)
{
mstrCoursewareCaseText = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseText);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseDate)
{
mstrCoursewareCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseDate);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseTime)
{
mstrCoursewareCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTime);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseDateIn)
{
mstrCoursewareCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseDateIn);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CoursewareCaseTimeIn)
{
mstrCoursewareCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTimeIn);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdStudyLevel);
}
else if (strAttributeName  ==  convCoursewareCase_Base.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StudyLevelName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdTeachingPlan);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdCaseType);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdDiscipline);
}
else if (strAttributeName  ==  convCoursewareCase_Base.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.DisciplineID);
}
else if (strAttributeName  ==  convCoursewareCase_Base.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.DisciplineName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convCoursewareCase_Base.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionID);
}
else if (strAttributeName  ==  convCoursewareCase_Base.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convCoursewareCase_Base.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.VersionNo);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdTeachSkill);
}
else if (strAttributeName  ==  convCoursewareCase_Base.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillID);
}
else if (strAttributeName  ==  convCoursewareCase_Base.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.SkillTypeName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillTheory);
}
else if (strAttributeName  ==  convCoursewareCase_Base.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdSkillType);
}
else if (strAttributeName  ==  convCoursewareCase_Base.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.SkillTypeID);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CaseLevelId);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CaseLevelName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.DocFile);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.IsNeedGeneWord);
}
else if (strAttributeName  ==  convCoursewareCase_Base.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.WordCreateDate);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.IsVisible);
}
else if (strAttributeName  ==  convCoursewareCase_Base.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.OwnerId);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdStudentInfo);
}
else if (strAttributeName  ==  convCoursewareCase_Base.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StuName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StuID);
}
else if (strAttributeName  ==  convCoursewareCase_Base.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.PoliticsName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.SexDesc);
}
else if (strAttributeName  ==  convCoursewareCase_Base.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.EthnicName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.UniZoneDesc);
}
else if (strAttributeName  ==  convCoursewareCase_Base.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StuTypeDesc);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdXzCollege);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CollegeID);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CollegeName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CollegeNameA);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdXzMajor);
}
else if (strAttributeName  ==  convCoursewareCase_Base.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.MajorName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdGradeBase);
}
else if (strAttributeName  ==  convCoursewareCase_Base.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.GradeBaseName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdAdminCls);
}
else if (strAttributeName  ==  convCoursewareCase_Base.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.AdminClsId);
}
else if (strAttributeName  ==  convCoursewareCase_Base.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.AdminClsName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.Birthday);
}
else if (strAttributeName  ==  convCoursewareCase_Base.NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.NativePlace);
}
else if (strAttributeName  ==  convCoursewareCase_Base.Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.Duty);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IDCardNo)
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IDCardNo);
}
else if (strAttributeName  ==  convCoursewareCase_Base.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StuCardNo);
}
else if (strAttributeName  ==  convCoursewareCase_Base.LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.LiveAddress);
}
else if (strAttributeName  ==  convCoursewareCase_Base.HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.HomePhone);
}
else if (strAttributeName  ==  convCoursewareCase_Base.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.EnrollmentDate);
}
else if (strAttributeName  ==  convCoursewareCase_Base.PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.PostCode);
}
else if (strAttributeName  ==  convCoursewareCase_Base.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.UserKindId);
}
else if (strAttributeName  ==  convCoursewareCase_Base.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.UserKindName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.UserTypeId);
}
else if (strAttributeName  ==  convCoursewareCase_Base.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.IsDualVideo);
}
else if (strAttributeName  ==  convCoursewareCase_Base.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.RecommendedDegreeId);
}
else if (strAttributeName  ==  convCoursewareCase_Base.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.RecommendedDegreeName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.ftpFileType);
}
else if (strAttributeName  ==  convCoursewareCase_Base.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.VideoUrl);
}
else if (strAttributeName  ==  convCoursewareCase_Base.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.VideoPath);
}
else if (strAttributeName  ==  convCoursewareCase_Base.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.ResErrMsg);
}
else if (strAttributeName  ==  convCoursewareCase_Base.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.Memo);
}
else if (strAttributeName  ==  convCoursewareCase_Base.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.OwnerName);
}
else if (strAttributeName  ==  convCoursewareCase_Base.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.OwnerNameWithId);
}
else if (strAttributeName  ==  convCoursewareCase_Base.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.BrowseCount4Case);
}
}
}
public object this[int intIndex]
{
get
{
if (convCoursewareCase_Base.IdCoursewareCase  ==  AttributeName[intIndex])
{
return mstrIdCoursewareCase;
}
else if (convCoursewareCase_Base.CoursewareCaseID  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseID;
}
else if (convCoursewareCase_Base.CoursewareCaseName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseName;
}
else if (convCoursewareCase_Base.CoursewareCaseTheme  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTheme;
}
else if (convCoursewareCase_Base.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareCaseType;
}
else if (convCoursewareCase_Base.CoursewareCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTypeName;
}
else if (convCoursewareCase_Base.CoursewareCaseText  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseText;
}
else if (convCoursewareCase_Base.CoursewareCaseDate  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseDate;
}
else if (convCoursewareCase_Base.CoursewareCaseTime  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTime;
}
else if (convCoursewareCase_Base.CoursewareCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseDateIn;
}
else if (convCoursewareCase_Base.CoursewareCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTimeIn;
}
else if (convCoursewareCase_Base.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convCoursewareCase_Base.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convCoursewareCase_Base.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convCoursewareCase_Base.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convCoursewareCase_Base.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convCoursewareCase_Base.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convCoursewareCase_Base.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convCoursewareCase_Base.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convCoursewareCase_Base.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convCoursewareCase_Base.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCoursewareCase_Base.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convCoursewareCase_Base.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convCoursewareCase_Base.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convCoursewareCase_Base.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convCoursewareCase_Base.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convCoursewareCase_Base.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convCoursewareCase_Base.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convCoursewareCase_Base.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convCoursewareCase_Base.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convCoursewareCase_Base.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convCoursewareCase_Base.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convCoursewareCase_Base.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convCoursewareCase_Base.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convCoursewareCase_Base.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convCoursewareCase_Base.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convCoursewareCase_Base.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convCoursewareCase_Base.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCoursewareCase_Base.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convCoursewareCase_Base.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convCoursewareCase_Base.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convCoursewareCase_Base.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (convCoursewareCase_Base.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convCoursewareCase_Base.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (convCoursewareCase_Base.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convCoursewareCase_Base.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convCoursewareCase_Base.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCoursewareCase_Base.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convCoursewareCase_Base.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCoursewareCase_Base.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convCoursewareCase_Base.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCoursewareCase_Base.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCoursewareCase_Base.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convCoursewareCase_Base.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convCoursewareCase_Base.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convCoursewareCase_Base.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (convCoursewareCase_Base.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (convCoursewareCase_Base.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convCoursewareCase_Base.NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (convCoursewareCase_Base.Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (convCoursewareCase_Base.IDCardNo  ==  AttributeName[intIndex])
{
return mstrIDCardNo;
}
else if (convCoursewareCase_Base.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convCoursewareCase_Base.LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (convCoursewareCase_Base.HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (convCoursewareCase_Base.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convCoursewareCase_Base.PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (convCoursewareCase_Base.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convCoursewareCase_Base.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convCoursewareCase_Base.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convCoursewareCase_Base.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCoursewareCase_Base.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convCoursewareCase_Base.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convCoursewareCase_Base.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convCoursewareCase_Base.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convCoursewareCase_Base.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convCoursewareCase_Base.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convCoursewareCase_Base.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCoursewareCase_Base.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCoursewareCase_Base.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convCoursewareCase_Base.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (convCoursewareCase_Base.IdCoursewareCase  ==  AttributeName[intIndex])
{
mstrIdCoursewareCase = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdCoursewareCase);
}
else if (convCoursewareCase_Base.CoursewareCaseID  ==  AttributeName[intIndex])
{
mstrCoursewareCaseID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseID);
}
else if (convCoursewareCase_Base.CoursewareCaseName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseName);
}
else if (convCoursewareCase_Base.CoursewareCaseTheme  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTheme);
}
else if (convCoursewareCase_Base.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdCoursewareCaseType);
}
else if (convCoursewareCase_Base.CoursewareCaseTypeName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTypeName);
}
else if (convCoursewareCase_Base.CoursewareCaseText  ==  AttributeName[intIndex])
{
mstrCoursewareCaseText = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseText);
}
else if (convCoursewareCase_Base.CoursewareCaseDate  ==  AttributeName[intIndex])
{
mstrCoursewareCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseDate);
}
else if (convCoursewareCase_Base.CoursewareCaseTime  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTime);
}
else if (convCoursewareCase_Base.CoursewareCaseDateIn  ==  AttributeName[intIndex])
{
mstrCoursewareCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseDateIn);
}
else if (convCoursewareCase_Base.CoursewareCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTimeIn);
}
else if (convCoursewareCase_Base.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdStudyLevel);
}
else if (convCoursewareCase_Base.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StudyLevelName);
}
else if (convCoursewareCase_Base.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdTeachingPlan);
}
else if (convCoursewareCase_Base.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdCaseType);
}
else if (convCoursewareCase_Base.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdDiscipline);
}
else if (convCoursewareCase_Base.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.DisciplineID);
}
else if (convCoursewareCase_Base.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.DisciplineName);
}
else if (convCoursewareCase_Base.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdSenateGaugeVersion);
}
else if (convCoursewareCase_Base.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionID);
}
else if (convCoursewareCase_Base.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionName);
}
else if (convCoursewareCase_Base.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionTtlScore);
}
else if (convCoursewareCase_Base.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.VersionNo);
}
else if (convCoursewareCase_Base.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdTeachSkill);
}
else if (convCoursewareCase_Base.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillID);
}
else if (convCoursewareCase_Base.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.SkillTypeName);
}
else if (convCoursewareCase_Base.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillName);
}
else if (convCoursewareCase_Base.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillTheory);
}
else if (convCoursewareCase_Base.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillOperMethod);
}
else if (convCoursewareCase_Base.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdSkillType);
}
else if (convCoursewareCase_Base.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.SkillTypeID);
}
else if (convCoursewareCase_Base.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CaseLevelId);
}
else if (convCoursewareCase_Base.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CaseLevelName);
}
else if (convCoursewareCase_Base.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.DocFile);
}
else if (convCoursewareCase_Base.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.IsNeedGeneWord);
}
else if (convCoursewareCase_Base.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.WordCreateDate);
}
else if (convCoursewareCase_Base.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.IsVisible);
}
else if (convCoursewareCase_Base.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.OwnerId);
}
else if (convCoursewareCase_Base.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdStudentInfo);
}
else if (convCoursewareCase_Base.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StuName);
}
else if (convCoursewareCase_Base.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StuID);
}
else if (convCoursewareCase_Base.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.PoliticsName);
}
else if (convCoursewareCase_Base.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.SexDesc);
}
else if (convCoursewareCase_Base.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.EthnicName);
}
else if (convCoursewareCase_Base.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.UniZoneDesc);
}
else if (convCoursewareCase_Base.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StuTypeDesc);
}
else if (convCoursewareCase_Base.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdXzCollege);
}
else if (convCoursewareCase_Base.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CollegeID);
}
else if (convCoursewareCase_Base.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CollegeName);
}
else if (convCoursewareCase_Base.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.CollegeNameA);
}
else if (convCoursewareCase_Base.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdXzMajor);
}
else if (convCoursewareCase_Base.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.MajorName);
}
else if (convCoursewareCase_Base.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdGradeBase);
}
else if (convCoursewareCase_Base.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.GradeBaseName);
}
else if (convCoursewareCase_Base.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IdAdminCls);
}
else if (convCoursewareCase_Base.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.AdminClsId);
}
else if (convCoursewareCase_Base.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.AdminClsName);
}
else if (convCoursewareCase_Base.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.Birthday);
}
else if (convCoursewareCase_Base.NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.NativePlace);
}
else if (convCoursewareCase_Base.Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.Duty);
}
else if (convCoursewareCase_Base.IDCardNo  ==  AttributeName[intIndex])
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.IDCardNo);
}
else if (convCoursewareCase_Base.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.StuCardNo);
}
else if (convCoursewareCase_Base.LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.LiveAddress);
}
else if (convCoursewareCase_Base.HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.HomePhone);
}
else if (convCoursewareCase_Base.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.EnrollmentDate);
}
else if (convCoursewareCase_Base.PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.PostCode);
}
else if (convCoursewareCase_Base.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.UserKindId);
}
else if (convCoursewareCase_Base.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.UserKindName);
}
else if (convCoursewareCase_Base.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.UserTypeId);
}
else if (convCoursewareCase_Base.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.IsDualVideo);
}
else if (convCoursewareCase_Base.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.RecommendedDegreeId);
}
else if (convCoursewareCase_Base.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.RecommendedDegreeName);
}
else if (convCoursewareCase_Base.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.ftpFileType);
}
else if (convCoursewareCase_Base.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.VideoUrl);
}
else if (convCoursewareCase_Base.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.VideoPath);
}
else if (convCoursewareCase_Base.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.ResErrMsg);
}
else if (convCoursewareCase_Base.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.Memo);
}
else if (convCoursewareCase_Base.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.OwnerName);
}
else if (convCoursewareCase_Base.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Base.OwnerNameWithId);
}
else if (convCoursewareCase_Base.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Base.BrowseCount4Case);
}
}
}

/// <summary>
/// 课件教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareCase
{
get
{
return mstrIdCoursewareCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareCase = value;
}
else
{
 mstrIdCoursewareCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.IdCoursewareCase);
}
}
/// <summary>
/// 课件教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseID
{
get
{
return mstrCoursewareCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseID = value;
}
else
{
 mstrCoursewareCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseID);
}
}
/// <summary>
/// 课件教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseName
{
get
{
return mstrCoursewareCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseName = value;
}
else
{
 mstrCoursewareCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseName);
}
}
/// <summary>
/// 课件教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTheme
{
get
{
return mstrCoursewareCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTheme = value;
}
else
{
 mstrCoursewareCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTheme);
}
}
/// <summary>
/// 课件案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareCaseType
{
get
{
return mstrIdCoursewareCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareCaseType = value;
}
else
{
 mstrIdCoursewareCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.IdCoursewareCaseType);
}
}
/// <summary>
/// 课件案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTypeName
{
get
{
return mstrCoursewareCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTypeName = value;
}
else
{
 mstrCoursewareCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTypeName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseText
{
get
{
return mstrCoursewareCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseText = value;
}
else
{
 mstrCoursewareCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseText);
}
}
/// <summary>
/// 课件教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseDate
{
get
{
return mstrCoursewareCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseDate = value;
}
else
{
 mstrCoursewareCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseDate);
}
}
/// <summary>
/// 课件教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTime
{
get
{
return mstrCoursewareCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTime = value;
}
else
{
 mstrCoursewareCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseDateIn
{
get
{
return mstrCoursewareCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseDateIn = value;
}
else
{
 mstrCoursewareCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTimeIn
{
get
{
return mstrCoursewareCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTimeIn = value;
}
else
{
 mstrCoursewareCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.CoursewareCaseTimeIn);
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
 AddUpdatedFld(convCoursewareCase_Base.IdStudyLevel);
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
 AddUpdatedFld(convCoursewareCase_Base.StudyLevelName);
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
 AddUpdatedFld(convCoursewareCase_Base.IdTeachingPlan);
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
 AddUpdatedFld(convCoursewareCase_Base.IdCaseType);
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
 AddUpdatedFld(convCoursewareCase_Base.IdDiscipline);
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
 AddUpdatedFld(convCoursewareCase_Base.DisciplineID);
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
 AddUpdatedFld(convCoursewareCase_Base.DisciplineName);
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
 AddUpdatedFld(convCoursewareCase_Base.IdSenateGaugeVersion);
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
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionID);
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
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convCoursewareCase_Base.VersionNo);
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
 AddUpdatedFld(convCoursewareCase_Base.IdTeachSkill);
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
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillID);
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
 AddUpdatedFld(convCoursewareCase_Base.SkillTypeName);
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
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillName);
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
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillTheory);
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
 AddUpdatedFld(convCoursewareCase_Base.TeachSkillOperMethod);
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
 AddUpdatedFld(convCoursewareCase_Base.IdSkillType);
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
 AddUpdatedFld(convCoursewareCase_Base.SkillTypeID);
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
 AddUpdatedFld(convCoursewareCase_Base.CaseLevelId);
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
 AddUpdatedFld(convCoursewareCase_Base.CaseLevelName);
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
 AddUpdatedFld(convCoursewareCase_Base.DocFile);
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
 AddUpdatedFld(convCoursewareCase_Base.IsNeedGeneWord);
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
 AddUpdatedFld(convCoursewareCase_Base.WordCreateDate);
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
 AddUpdatedFld(convCoursewareCase_Base.IsVisible);
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
 AddUpdatedFld(convCoursewareCase_Base.OwnerId);
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
 AddUpdatedFld(convCoursewareCase_Base.IdStudentInfo);
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
 AddUpdatedFld(convCoursewareCase_Base.StuName);
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
 AddUpdatedFld(convCoursewareCase_Base.StuID);
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
 AddUpdatedFld(convCoursewareCase_Base.PoliticsName);
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
 AddUpdatedFld(convCoursewareCase_Base.SexDesc);
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
 AddUpdatedFld(convCoursewareCase_Base.EthnicName);
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
 AddUpdatedFld(convCoursewareCase_Base.UniZoneDesc);
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
 AddUpdatedFld(convCoursewareCase_Base.StuTypeDesc);
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
 AddUpdatedFld(convCoursewareCase_Base.IdXzCollege);
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
 AddUpdatedFld(convCoursewareCase_Base.CollegeID);
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
 AddUpdatedFld(convCoursewareCase_Base.CollegeName);
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
 AddUpdatedFld(convCoursewareCase_Base.CollegeNameA);
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
 AddUpdatedFld(convCoursewareCase_Base.IdXzMajor);
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
 AddUpdatedFld(convCoursewareCase_Base.MajorName);
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
 AddUpdatedFld(convCoursewareCase_Base.IdGradeBase);
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
 AddUpdatedFld(convCoursewareCase_Base.GradeBaseName);
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
 AddUpdatedFld(convCoursewareCase_Base.IdAdminCls);
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
 AddUpdatedFld(convCoursewareCase_Base.AdminClsId);
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
 AddUpdatedFld(convCoursewareCase_Base.AdminClsName);
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
 AddUpdatedFld(convCoursewareCase_Base.Birthday);
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
 AddUpdatedFld(convCoursewareCase_Base.NativePlace);
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
 AddUpdatedFld(convCoursewareCase_Base.Duty);
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
 AddUpdatedFld(convCoursewareCase_Base.IDCardNo);
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
 AddUpdatedFld(convCoursewareCase_Base.StuCardNo);
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
 AddUpdatedFld(convCoursewareCase_Base.LiveAddress);
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
 AddUpdatedFld(convCoursewareCase_Base.HomePhone);
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
 AddUpdatedFld(convCoursewareCase_Base.EnrollmentDate);
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
 AddUpdatedFld(convCoursewareCase_Base.PostCode);
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
 AddUpdatedFld(convCoursewareCase_Base.UserKindId);
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
 AddUpdatedFld(convCoursewareCase_Base.UserKindName);
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
 AddUpdatedFld(convCoursewareCase_Base.UserTypeId);
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
 AddUpdatedFld(convCoursewareCase_Base.IsDualVideo);
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
 AddUpdatedFld(convCoursewareCase_Base.RecommendedDegreeId);
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
 AddUpdatedFld(convCoursewareCase_Base.RecommendedDegreeName);
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
 AddUpdatedFld(convCoursewareCase_Base.ftpFileType);
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
 AddUpdatedFld(convCoursewareCase_Base.VideoUrl);
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
 AddUpdatedFld(convCoursewareCase_Base.VideoPath);
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
 AddUpdatedFld(convCoursewareCase_Base.ResErrMsg);
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
 AddUpdatedFld(convCoursewareCase_Base.Memo);
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
 AddUpdatedFld(convCoursewareCase_Base.OwnerName);
}
}
/// <summary>
/// 拥有者名称附Id(说明:;字段类型:varchar;字段长度:51;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerNameWithId
{
get
{
return mstrOwnerNameWithId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerNameWithId = value;
}
else
{
 mstrOwnerNameWithId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Base.OwnerNameWithId);
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
 AddUpdatedFld(convCoursewareCase_Base.BrowseCount4Case);
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
  return mstrIdCoursewareCase;
 }
 }
}
 /// <summary>
 /// v课件教学案例_Base(vCoursewareCase_Base)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCoursewareCase_Base
{
public const string _CurrTabName = "vCoursewareCase_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCoursewareCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCoursewareCase", "CoursewareCaseID", "CoursewareCaseName", "CoursewareCaseTheme", "IdCoursewareCaseType", "CoursewareCaseTypeName", "CoursewareCaseText", "CoursewareCaseDate", "CoursewareCaseTime", "CoursewareCaseDateIn", "CoursewareCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "IdStudentInfo", "StuName", "StuID", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "UserKindId", "UserKindName", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "OwnerName", "OwnerNameWithId", "BrowseCount4Case"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCoursewareCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareCase = "IdCoursewareCase";    //课件教学案例流水号

 /// <summary>
 /// 常量:"CoursewareCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseID = "CoursewareCaseID";    //课件教学案例ID

 /// <summary>
 /// 常量:"CoursewareCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseName = "CoursewareCaseName";    //课件教学案例名称

 /// <summary>
 /// 常量:"CoursewareCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTheme = "CoursewareCaseTheme";    //课件教学案例主题词

 /// <summary>
 /// 常量:"IdCoursewareCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareCaseType = "IdCoursewareCaseType";    //课件案例类型流水号

 /// <summary>
 /// 常量:"CoursewareCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTypeName = "CoursewareCaseTypeName";    //课件案例类型名称

 /// <summary>
 /// 常量:"CoursewareCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseText = "CoursewareCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"CoursewareCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseDate = "CoursewareCaseDate";    //课件教学日期

 /// <summary>
 /// 常量:"CoursewareCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTime = "CoursewareCaseTime";    //课件教学时间

 /// <summary>
 /// 常量:"CoursewareCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseDateIn = "CoursewareCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CoursewareCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTimeIn = "CoursewareCaseTimeIn";    //案例入库时间

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
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

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
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数
}

}