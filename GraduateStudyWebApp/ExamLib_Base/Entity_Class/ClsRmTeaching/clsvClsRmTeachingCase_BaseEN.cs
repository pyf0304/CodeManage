
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCase_BaseEN
 表名:vClsRmTeachingCase_Base(01120488)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 表vClsRmTeachingCase_Base的关键字(IdClsRmTeachingCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdClsRmTeachingCase_vClsRmTeachingCase_Base
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdClsRmTeachingCase">表关键字</param>
public K_IdClsRmTeachingCase_vClsRmTeachingCase_Base(string strIdClsRmTeachingCase)
{
if (IsValid(strIdClsRmTeachingCase)) Value = strIdClsRmTeachingCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strIdClsRmTeachingCase) == true) return false;
if (strIdClsRmTeachingCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdClsRmTeachingCase_vClsRmTeachingCase_Base]类型的对象</returns>
public static implicit operator K_IdClsRmTeachingCase_vClsRmTeachingCase_Base(string value)
{
return new K_IdClsRmTeachingCase_vClsRmTeachingCase_Base(value);
}
}
 /// <summary>
 /// v课堂教学案例_Base(vClsRmTeachingCase_Base)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvClsRmTeachingCase_BaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vClsRmTeachingCase_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdClsRmTeachingCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 86;
public static string[] AttributeName = new string[] {"IdClsRmTeachingCase", "ClsRmTeachingCaseID", "ClsRmTeachingCaseName", "ClsRmTeachingCaseTheme", "IdClsRmTeachingCaseType", "ClsRmTeachingCaseTypeName", "ClsRmTeachingCaseText", "ClsRmTeachingCaseDate", "ClsRmTeachingCaseTime", "ClsRmTeachingCaseDateIn", "ClsRmTeachingCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "IdSchoolPs", "SchoolId", "SchoolName", "IdDisciplinePs", "DisciplineName", "IdGradeBase", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "IdStudentInfo", "StuName", "StuId", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IdCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "UserKindId", "UserKindName", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "Memo", "DisciplineNamePs", "GradeNamePs", "IdGradePs", "OwnerName", "OwnerNameWithId", "BrowseCount4Case", "CaseTypeName", "ftpFileType", "IsUse"};

protected string mstrIdClsRmTeachingCase;    //课堂教学案例流水号
protected string mstrClsRmTeachingCaseID;    //课堂教学案例ID
protected string mstrClsRmTeachingCaseName;    //课堂教学案例名称
protected string mstrClsRmTeachingCaseTheme;    //课堂教学案例主题词
protected string mstrIdClsRmTeachingCaseType;    //课堂案例类型流水号
protected string mstrClsRmTeachingCaseTypeName;    //课堂案例类型名称
protected string mstrClsRmTeachingCaseText;    //案例文本内容
protected string mstrClsRmTeachingCaseDate;    //课堂教学日期
protected string mstrClsRmTeachingCaseTime;    //课堂教学时间
protected string mstrClsRmTeachingCaseDateIn;    //案例入库日期
protected string mstrClsRmTeachingCaseTimeIn;    //案例入库时间
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrIdSchoolPs;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrIdDisciplinePs;    //学科流水号
protected string mstrDisciplineName;    //学科名称
protected string mstrIdGradeBase;    //年级流水号
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
protected string mstrStuId;    //学号
protected string mstrPoliticsName;    //政治面貌
protected string mstrSexDesc;    //性别名称
protected string mstrEthnicName;    //民族名称
protected string mstrUniZoneDesc;    //校区名称
protected string mstrStuTypeDesc;    //学生类别名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrGradeBaseName;    //年级名称
protected string mstrIdAdminCls;    //行政班流水号
protected string mstrAdminClsId;    //行政班代号
protected string mstrAdminClsName;    //行政班名称
protected string mstrBirthday;    //出生日期
protected string mstrNativePlace;    //籍贯
protected string mstrDuty;    //职位
protected string mstrIdCardNo;    //身份证号
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
protected string mstrMemo;    //备注
protected string mstrDisciplineNamePs;    //学科
protected string mstrGradeNamePs;    //年级
protected string mstrIdGradePs;    //年级流水号
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrCaseTypeName;    //案例类型名称
protected string mstrftpFileType;    //ftp文件类型
protected bool mbolIsUse;    //是否使用

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvClsRmTeachingCase_BaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdClsRmTeachingCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdClsRmTeachingCase">关键字:课堂教学案例流水号</param>
public clsvClsRmTeachingCase_BaseEN(string strIdClsRmTeachingCase)
 {
strIdClsRmTeachingCase = strIdClsRmTeachingCase.Replace("'", "''");
if (strIdClsRmTeachingCase.Length > 8)
{
throw new Exception("在表:vClsRmTeachingCase_Base中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdClsRmTeachingCase)  ==  true)
{
throw new Exception("在表:vClsRmTeachingCase_Base中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdClsRmTeachingCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdClsRmTeachingCase = strIdClsRmTeachingCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdClsRmTeachingCase");
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
if (strAttributeName  ==  convClsRmTeachingCase_Base.IdClsRmTeachingCase)
{
return mstrIdClsRmTeachingCase;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseID)
{
return mstrClsRmTeachingCaseID;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseName)
{
return mstrClsRmTeachingCaseName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme)
{
return mstrClsRmTeachingCaseTheme;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdClsRmTeachingCaseType)
{
return mstrIdClsRmTeachingCaseType;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName)
{
return mstrClsRmTeachingCaseTypeName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseText)
{
return mstrClsRmTeachingCaseText;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseDate)
{
return mstrClsRmTeachingCaseDate;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseTime)
{
return mstrClsRmTeachingCaseTime;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn)
{
return mstrClsRmTeachingCaseDateIn;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn)
{
return mstrClsRmTeachingCaseTimeIn;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdSchoolPs)
{
return mstrIdSchoolPs;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdDisciplinePs)
{
return mstrIdDisciplinePs;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdCardNo)
{
return mstrIdCardNo;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.DisciplineNamePs)
{
return mstrDisciplineNamePs;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.GradeNamePs)
{
return mstrGradeNamePs;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdGradePs)
{
return mstrIdGradePs;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CaseTypeName)
{
return mstrCaseTypeName;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IsUse)
{
return mbolIsUse;
}
return null;
}
set
{
if (strAttributeName  ==  convClsRmTeachingCase_Base.IdClsRmTeachingCase)
{
mstrIdClsRmTeachingCase = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdClsRmTeachingCase);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseID)
{
mstrClsRmTeachingCaseID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseName)
{
mstrClsRmTeachingCaseName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme)
{
mstrClsRmTeachingCaseTheme = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdClsRmTeachingCaseType)
{
mstrIdClsRmTeachingCaseType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdClsRmTeachingCaseType);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName)
{
mstrClsRmTeachingCaseTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseText)
{
mstrClsRmTeachingCaseText = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseText);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseDate)
{
mstrClsRmTeachingCaseDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseTime)
{
mstrClsRmTeachingCaseTime = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn)
{
mstrClsRmTeachingCaseDateIn = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn)
{
mstrClsRmTeachingCaseTimeIn = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdStudyLevel);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StudyLevelName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdTeachingPlan);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdCaseType);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdDiscipline);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineID);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdSchoolPs)
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSchoolPs);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SchoolId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SchoolName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdDisciplinePs)
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdDisciplinePs);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdGradeBase);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionID);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.VersionNo);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdTeachSkill);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillID);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SkillTypeName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillTheory);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSkillType);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SkillTypeID);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseLevelId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseLevelName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.DocFile);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.IsNeedGeneWord);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.WordCreateDate);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.IsVisible);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdStudentInfo);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StuName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StuId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.PoliticsName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SexDesc);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.EthnicName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.UniZoneDesc);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StuTypeDesc);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdXzCollege);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeNameA);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdXzMajor);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.MajorName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.GradeBaseName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdAdminCls);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.AdminClsId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.AdminClsName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.Birthday);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.NativePlace);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.Duty);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdCardNo)
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdCardNo);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StuCardNo);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.LiveAddress);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.HomePhone);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.EnrollmentDate);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.PostCode);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.UserKindId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.UserKindName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.UserTypeId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.IsDualVideo);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.RecommendedDegreeId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.RecommendedDegreeName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.Memo);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.DisciplineNamePs)
{
mstrDisciplineNamePs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineNamePs);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.GradeNamePs)
{
mstrGradeNamePs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.GradeNamePs);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IdGradePs)
{
mstrIdGradePs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdGradePs);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerNameWithId);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.BrowseCount4Case);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.CaseTypeName)
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseTypeName);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ftpFileType);
}
else if (strAttributeName  ==  convClsRmTeachingCase_Base.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.IsUse);
}
}
}
public object this[int intIndex]
{
get
{
if (convClsRmTeachingCase_Base.IdClsRmTeachingCase  ==  AttributeName[intIndex])
{
return mstrIdClsRmTeachingCase;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseID  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseID;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseName  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseName;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTheme;
}
else if (convClsRmTeachingCase_Base.IdClsRmTeachingCaseType  ==  AttributeName[intIndex])
{
return mstrIdClsRmTeachingCaseType;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTypeName;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseText  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseText;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseDate  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseDate;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseTime  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTime;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseDateIn;
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTimeIn;
}
else if (convClsRmTeachingCase_Base.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convClsRmTeachingCase_Base.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convClsRmTeachingCase_Base.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convClsRmTeachingCase_Base.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convClsRmTeachingCase_Base.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convClsRmTeachingCase_Base.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convClsRmTeachingCase_Base.IdSchoolPs  ==  AttributeName[intIndex])
{
return mstrIdSchoolPs;
}
else if (convClsRmTeachingCase_Base.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convClsRmTeachingCase_Base.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convClsRmTeachingCase_Base.IdDisciplinePs  ==  AttributeName[intIndex])
{
return mstrIdDisciplinePs;
}
else if (convClsRmTeachingCase_Base.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convClsRmTeachingCase_Base.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convClsRmTeachingCase_Base.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convClsRmTeachingCase_Base.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convClsRmTeachingCase_Base.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convClsRmTeachingCase_Base.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convClsRmTeachingCase_Base.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convClsRmTeachingCase_Base.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convClsRmTeachingCase_Base.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convClsRmTeachingCase_Base.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convClsRmTeachingCase_Base.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convClsRmTeachingCase_Base.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convClsRmTeachingCase_Base.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convClsRmTeachingCase_Base.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convClsRmTeachingCase_Base.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convClsRmTeachingCase_Base.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convClsRmTeachingCase_Base.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convClsRmTeachingCase_Base.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convClsRmTeachingCase_Base.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convClsRmTeachingCase_Base.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convClsRmTeachingCase_Base.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convClsRmTeachingCase_Base.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convClsRmTeachingCase_Base.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convClsRmTeachingCase_Base.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convClsRmTeachingCase_Base.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (convClsRmTeachingCase_Base.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (convClsRmTeachingCase_Base.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convClsRmTeachingCase_Base.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (convClsRmTeachingCase_Base.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convClsRmTeachingCase_Base.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convClsRmTeachingCase_Base.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convClsRmTeachingCase_Base.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convClsRmTeachingCase_Base.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convClsRmTeachingCase_Base.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convClsRmTeachingCase_Base.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convClsRmTeachingCase_Base.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convClsRmTeachingCase_Base.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convClsRmTeachingCase_Base.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convClsRmTeachingCase_Base.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (convClsRmTeachingCase_Base.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (convClsRmTeachingCase_Base.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convClsRmTeachingCase_Base.NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (convClsRmTeachingCase_Base.Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (convClsRmTeachingCase_Base.IdCardNo  ==  AttributeName[intIndex])
{
return mstrIdCardNo;
}
else if (convClsRmTeachingCase_Base.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convClsRmTeachingCase_Base.LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (convClsRmTeachingCase_Base.HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (convClsRmTeachingCase_Base.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convClsRmTeachingCase_Base.PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (convClsRmTeachingCase_Base.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convClsRmTeachingCase_Base.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convClsRmTeachingCase_Base.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convClsRmTeachingCase_Base.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convClsRmTeachingCase_Base.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convClsRmTeachingCase_Base.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convClsRmTeachingCase_Base.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convClsRmTeachingCase_Base.DisciplineNamePs  ==  AttributeName[intIndex])
{
return mstrDisciplineNamePs;
}
else if (convClsRmTeachingCase_Base.GradeNamePs  ==  AttributeName[intIndex])
{
return mstrGradeNamePs;
}
else if (convClsRmTeachingCase_Base.IdGradePs  ==  AttributeName[intIndex])
{
return mstrIdGradePs;
}
else if (convClsRmTeachingCase_Base.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convClsRmTeachingCase_Base.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convClsRmTeachingCase_Base.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convClsRmTeachingCase_Base.CaseTypeName  ==  AttributeName[intIndex])
{
return mstrCaseTypeName;
}
else if (convClsRmTeachingCase_Base.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convClsRmTeachingCase_Base.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
return null;
}
set
{
if (convClsRmTeachingCase_Base.IdClsRmTeachingCase  ==  AttributeName[intIndex])
{
mstrIdClsRmTeachingCase = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdClsRmTeachingCase);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseID  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseName  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTheme = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme);
}
else if (convClsRmTeachingCase_Base.IdClsRmTeachingCaseType  ==  AttributeName[intIndex])
{
mstrIdClsRmTeachingCaseType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdClsRmTeachingCaseType);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseText  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseText = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseText);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseDate  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseTime  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTime = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseDateIn = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
}
else if (convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTimeIn = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
}
else if (convClsRmTeachingCase_Base.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdStudyLevel);
}
else if (convClsRmTeachingCase_Base.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StudyLevelName);
}
else if (convClsRmTeachingCase_Base.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdTeachingPlan);
}
else if (convClsRmTeachingCase_Base.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdCaseType);
}
else if (convClsRmTeachingCase_Base.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdDiscipline);
}
else if (convClsRmTeachingCase_Base.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineID);
}
else if (convClsRmTeachingCase_Base.IdSchoolPs  ==  AttributeName[intIndex])
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSchoolPs);
}
else if (convClsRmTeachingCase_Base.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SchoolId);
}
else if (convClsRmTeachingCase_Base.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SchoolName);
}
else if (convClsRmTeachingCase_Base.IdDisciplinePs  ==  AttributeName[intIndex])
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdDisciplinePs);
}
else if (convClsRmTeachingCase_Base.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineName);
}
else if (convClsRmTeachingCase_Base.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdGradeBase);
}
else if (convClsRmTeachingCase_Base.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSenateGaugeVersion);
}
else if (convClsRmTeachingCase_Base.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionID);
}
else if (convClsRmTeachingCase_Base.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionName);
}
else if (convClsRmTeachingCase_Base.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore);
}
else if (convClsRmTeachingCase_Base.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.VersionNo);
}
else if (convClsRmTeachingCase_Base.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdTeachSkill);
}
else if (convClsRmTeachingCase_Base.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillID);
}
else if (convClsRmTeachingCase_Base.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SkillTypeName);
}
else if (convClsRmTeachingCase_Base.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillName);
}
else if (convClsRmTeachingCase_Base.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillTheory);
}
else if (convClsRmTeachingCase_Base.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillOperMethod);
}
else if (convClsRmTeachingCase_Base.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSkillType);
}
else if (convClsRmTeachingCase_Base.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SkillTypeID);
}
else if (convClsRmTeachingCase_Base.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseLevelId);
}
else if (convClsRmTeachingCase_Base.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseLevelName);
}
else if (convClsRmTeachingCase_Base.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.DocFile);
}
else if (convClsRmTeachingCase_Base.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.IsNeedGeneWord);
}
else if (convClsRmTeachingCase_Base.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.WordCreateDate);
}
else if (convClsRmTeachingCase_Base.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.IsVisible);
}
else if (convClsRmTeachingCase_Base.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerId);
}
else if (convClsRmTeachingCase_Base.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdStudentInfo);
}
else if (convClsRmTeachingCase_Base.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StuName);
}
else if (convClsRmTeachingCase_Base.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StuId);
}
else if (convClsRmTeachingCase_Base.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.PoliticsName);
}
else if (convClsRmTeachingCase_Base.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.SexDesc);
}
else if (convClsRmTeachingCase_Base.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.EthnicName);
}
else if (convClsRmTeachingCase_Base.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.UniZoneDesc);
}
else if (convClsRmTeachingCase_Base.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StuTypeDesc);
}
else if (convClsRmTeachingCase_Base.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdXzCollege);
}
else if (convClsRmTeachingCase_Base.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeId);
}
else if (convClsRmTeachingCase_Base.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeName);
}
else if (convClsRmTeachingCase_Base.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeNameA);
}
else if (convClsRmTeachingCase_Base.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdXzMajor);
}
else if (convClsRmTeachingCase_Base.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.MajorName);
}
else if (convClsRmTeachingCase_Base.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.GradeBaseName);
}
else if (convClsRmTeachingCase_Base.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdAdminCls);
}
else if (convClsRmTeachingCase_Base.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.AdminClsId);
}
else if (convClsRmTeachingCase_Base.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.AdminClsName);
}
else if (convClsRmTeachingCase_Base.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.Birthday);
}
else if (convClsRmTeachingCase_Base.NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.NativePlace);
}
else if (convClsRmTeachingCase_Base.Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.Duty);
}
else if (convClsRmTeachingCase_Base.IdCardNo  ==  AttributeName[intIndex])
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdCardNo);
}
else if (convClsRmTeachingCase_Base.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.StuCardNo);
}
else if (convClsRmTeachingCase_Base.LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.LiveAddress);
}
else if (convClsRmTeachingCase_Base.HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.HomePhone);
}
else if (convClsRmTeachingCase_Base.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.EnrollmentDate);
}
else if (convClsRmTeachingCase_Base.PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.PostCode);
}
else if (convClsRmTeachingCase_Base.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.UserKindId);
}
else if (convClsRmTeachingCase_Base.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.UserKindName);
}
else if (convClsRmTeachingCase_Base.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.UserTypeId);
}
else if (convClsRmTeachingCase_Base.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.IsDualVideo);
}
else if (convClsRmTeachingCase_Base.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.RecommendedDegreeId);
}
else if (convClsRmTeachingCase_Base.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.RecommendedDegreeName);
}
else if (convClsRmTeachingCase_Base.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.Memo);
}
else if (convClsRmTeachingCase_Base.DisciplineNamePs  ==  AttributeName[intIndex])
{
mstrDisciplineNamePs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineNamePs);
}
else if (convClsRmTeachingCase_Base.GradeNamePs  ==  AttributeName[intIndex])
{
mstrGradeNamePs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.GradeNamePs);
}
else if (convClsRmTeachingCase_Base.IdGradePs  ==  AttributeName[intIndex])
{
mstrIdGradePs = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.IdGradePs);
}
else if (convClsRmTeachingCase_Base.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerName);
}
else if (convClsRmTeachingCase_Base.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerNameWithId);
}
else if (convClsRmTeachingCase_Base.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.BrowseCount4Case);
}
else if (convClsRmTeachingCase_Base.CaseTypeName  ==  AttributeName[intIndex])
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseTypeName);
}
else if (convClsRmTeachingCase_Base.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCase_Base.ftpFileType);
}
else if (convClsRmTeachingCase_Base.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCase_Base.IsUse);
}
}
}

/// <summary>
/// 课堂教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdClsRmTeachingCase
{
get
{
return mstrIdClsRmTeachingCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdClsRmTeachingCase = value;
}
else
{
 mstrIdClsRmTeachingCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.IdClsRmTeachingCase);
}
}
/// <summary>
/// 课堂教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseID
{
get
{
return mstrClsRmTeachingCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseID = value;
}
else
{
 mstrClsRmTeachingCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
}
}
/// <summary>
/// 课堂教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseName
{
get
{
return mstrClsRmTeachingCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseName = value;
}
else
{
 mstrClsRmTeachingCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
}
}
/// <summary>
/// 课堂教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTheme
{
get
{
return mstrClsRmTeachingCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTheme = value;
}
else
{
 mstrClsRmTeachingCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme);
}
}
/// <summary>
/// 课堂案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdClsRmTeachingCaseType
{
get
{
return mstrIdClsRmTeachingCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdClsRmTeachingCaseType = value;
}
else
{
 mstrIdClsRmTeachingCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.IdClsRmTeachingCaseType);
}
}
/// <summary>
/// 课堂案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTypeName
{
get
{
return mstrClsRmTeachingCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTypeName = value;
}
else
{
 mstrClsRmTeachingCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseText
{
get
{
return mstrClsRmTeachingCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseText = value;
}
else
{
 mstrClsRmTeachingCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseText);
}
}
/// <summary>
/// 课堂教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseDate
{
get
{
return mstrClsRmTeachingCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseDate = value;
}
else
{
 mstrClsRmTeachingCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
}
}
/// <summary>
/// 课堂教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTime
{
get
{
return mstrClsRmTeachingCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTime = value;
}
else
{
 mstrClsRmTeachingCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseDateIn
{
get
{
return mstrClsRmTeachingCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseDateIn = value;
}
else
{
 mstrClsRmTeachingCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTimeIn
{
get
{
return mstrClsRmTeachingCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTimeIn = value;
}
else
{
 mstrClsRmTeachingCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdStudyLevel);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.StudyLevelName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdTeachingPlan);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdCaseType);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdDiscipline);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineID);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSchoolPs);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.SchoolName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdDisciplinePs);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdGradeBase);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSenateGaugeVersion);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionID);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.VersionNo);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdTeachSkill);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillID);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.SkillTypeName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillTheory);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.TeachSkillOperMethod);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdSkillType);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.SkillTypeID);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseLevelId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseLevelName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.DocFile);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IsNeedGeneWord);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.WordCreateDate);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IsVisible);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdStudentInfo);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.StuName);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuId
{
get
{
return mstrStuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuId = value;
}
else
{
 mstrStuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.StuId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.PoliticsName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.SexDesc);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.EthnicName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.UniZoneDesc);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.StuTypeDesc);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdXzCollege);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.CollegeNameA);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdXzMajor);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.MajorName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.GradeBaseName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdAdminCls);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.AdminClsId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.AdminClsName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.Birthday);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.NativePlace);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.Duty);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IdCardNo);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.StuCardNo);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.LiveAddress);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.HomePhone);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.EnrollmentDate);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.PostCode);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.UserKindId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.UserKindName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.UserTypeId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.IsDualVideo);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.RecommendedDegreeId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.RecommendedDegreeName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.Memo);
}
}
/// <summary>
/// 学科(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineNamePs
{
get
{
return mstrDisciplineNamePs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineNamePs = value;
}
else
{
 mstrDisciplineNamePs = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.DisciplineNamePs);
}
}
/// <summary>
/// 年级(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeNamePs
{
get
{
return mstrGradeNamePs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeNamePs = value;
}
else
{
 mstrGradeNamePs = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.GradeNamePs);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradePs
{
get
{
return mstrIdGradePs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradePs = value;
}
else
{
 mstrIdGradePs = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.IdGradePs);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.OwnerNameWithId);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.BrowseCount4Case);
}
}
/// <summary>
/// 案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTypeName
{
get
{
return mstrCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTypeName = value;
}
else
{
 mstrCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.CaseTypeName);
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
 AddUpdatedFld(convClsRmTeachingCase_Base.ftpFileType);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCase_Base.IsUse);
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
  return mstrIdClsRmTeachingCase;
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
  return mstrClsRmTeachingCaseName;
 }
 }
}
 /// <summary>
 /// v课堂教学案例_Base(vClsRmTeachingCase_Base)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convClsRmTeachingCase_Base
{
public const string _CurrTabName = "vClsRmTeachingCase_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdClsRmTeachingCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdClsRmTeachingCase", "ClsRmTeachingCaseID", "ClsRmTeachingCaseName", "ClsRmTeachingCaseTheme", "IdClsRmTeachingCaseType", "ClsRmTeachingCaseTypeName", "ClsRmTeachingCaseText", "ClsRmTeachingCaseDate", "ClsRmTeachingCaseTime", "ClsRmTeachingCaseDateIn", "ClsRmTeachingCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "IdSchoolPs", "SchoolId", "SchoolName", "IdDisciplinePs", "DisciplineName", "IdGradeBase", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "IdStudentInfo", "StuName", "StuId", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IdCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "UserKindId", "UserKindName", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "Memo", "DisciplineNamePs", "GradeNamePs", "IdGradePs", "OwnerName", "OwnerNameWithId", "BrowseCount4Case", "CaseTypeName", "ftpFileType", "IsUse"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdClsRmTeachingCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdClsRmTeachingCase = "IdClsRmTeachingCase";    //课堂教学案例流水号

 /// <summary>
 /// 常量:"ClsRmTeachingCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseID = "ClsRmTeachingCaseID";    //课堂教学案例ID

 /// <summary>
 /// 常量:"ClsRmTeachingCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseName = "ClsRmTeachingCaseName";    //课堂教学案例名称

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTheme = "ClsRmTeachingCaseTheme";    //课堂教学案例主题词

 /// <summary>
 /// 常量:"IdClsRmTeachingCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdClsRmTeachingCaseType = "IdClsRmTeachingCaseType";    //课堂案例类型流水号

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTypeName = "ClsRmTeachingCaseTypeName";    //课堂案例类型名称

 /// <summary>
 /// 常量:"ClsRmTeachingCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseText = "ClsRmTeachingCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"ClsRmTeachingCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseDate = "ClsRmTeachingCaseDate";    //课堂教学日期

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTime = "ClsRmTeachingCaseTime";    //课堂教学时间

 /// <summary>
 /// 常量:"ClsRmTeachingCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseDateIn = "ClsRmTeachingCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTimeIn = "ClsRmTeachingCaseTimeIn";    //案例入库时间

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
 /// 常量:"IdSchoolPs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchoolPs = "IdSchoolPs";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"IdDisciplinePs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDisciplinePs = "IdDisciplinePs";    //学科流水号

 /// <summary>
 /// 常量:"DisciplineName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineName = "DisciplineName";    //学科名称

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

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
 /// 常量:"StuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuId = "StuId";    //学号

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
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

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
 /// 常量:"IdCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCardNo = "IdCardNo";    //身份证号

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"DisciplineNamePs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineNamePs = "DisciplineNamePs";    //学科

 /// <summary>
 /// 常量:"GradeNamePs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeNamePs = "GradeNamePs";    //年级

 /// <summary>
 /// 常量:"IdGradePs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradePs = "IdGradePs";    //年级流水号

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

 /// <summary>
 /// 常量:"CaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTypeName = "CaseTypeName";    //案例类型名称

 /// <summary>
 /// 常量:"ftpFileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpFileType = "ftpFileType";    //ftp文件类型

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用
}

}