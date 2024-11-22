
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCase_SimEN
 表名:vYoungTAppraisedCase_Sim(01120521)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// 表vYoungTAppraisedCase_Sim的关键字(IdYoungTAppraisedCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdYoungTAppraisedCase_vYoungTAppraisedCase_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdYoungTAppraisedCase">表关键字</param>
public K_IdYoungTAppraisedCase_vYoungTAppraisedCase_Sim(string strIdYoungTAppraisedCase)
{
if (IsValid(strIdYoungTAppraisedCase)) Value = strIdYoungTAppraisedCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdYoungTAppraisedCase)
{
if (string.IsNullOrEmpty(strIdYoungTAppraisedCase) == true) return false;
if (strIdYoungTAppraisedCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdYoungTAppraisedCase_vYoungTAppraisedCase_Sim]类型的对象</returns>
public static implicit operator K_IdYoungTAppraisedCase_vYoungTAppraisedCase_Sim(string value)
{
return new K_IdYoungTAppraisedCase_vYoungTAppraisedCase_Sim(value);
}
}
 /// <summary>
 /// vYoungTAppraisedCase_Sim(vYoungTAppraisedCase_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvYoungTAppraisedCase_SimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vYoungTAppraisedCase_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdYoungTAppraisedCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 53;
public static string[] AttributeName = new string[] {"IdYoungTAppraisedCase", "YoungTAppraisedCaseID", "YoungTAppraisedCaseName", "YoungTAppraisedCaseText", "YoungTAppraisedCaseDate", "YoungTAppraisedCaseTime", "YoungTAppraisedCaseTheme", "YoungTAppraisedCaseDateIn", "YoungTAppraisedCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "TeacherID", "TeacherName", "IdXzCollege", "CollegeName", "EntryDate", "CollegeID", "EntryYear", "CollegeNameA", "IsDualVideo", "IdYoungTAppraisedCaseType", "YoungTAppraisedCaseTypeName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "Memo", "IsUse"};

protected string mstrIdYoungTAppraisedCase;    //青教评优案例流水号
protected string mstrYoungTAppraisedCaseID;    //青教评优案例ID
protected string mstrYoungTAppraisedCaseName;    //青教评优案例名称
protected string mstrYoungTAppraisedCaseText;    //案例文本内容
protected string mstrYoungTAppraisedCaseDate;    //青教评优教学日期
protected string mstrYoungTAppraisedCaseTime;    //青教评优教学时间
protected string mstrYoungTAppraisedCaseTheme;    //青教评优案例主题词
protected string mstrYoungTAppraisedCaseDateIn;    //案例入库日期
protected string mstrYoungTAppraisedCaseTimeIn;    //案例入库时间
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected int? mintBrowseCount;    //浏览次数
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
protected string mstrDocFile;    //生成的Word文件名
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected bool mbolIsVisible;    //是否显示
protected string mstrOwnerId;    //拥有者Id
protected string mstrTeacherID;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrEntryDate;    //进校日期
protected string mstrCollegeID;    //学院ID
protected string mstrEntryYear;    //EntryYear
protected string mstrCollegeNameA;    //学院名称简写
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdYoungTAppraisedCaseType;    //青教案例类型流水号
protected string mstrYoungTAppraisedCaseTypeName;    //青教案例类型名称
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrMemo;    //备注
protected bool mbolIsUse;    //是否使用

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvYoungTAppraisedCase_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdYoungTAppraisedCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdYoungTAppraisedCase">关键字:青教评优案例流水号</param>
public clsvYoungTAppraisedCase_SimEN(string strIdYoungTAppraisedCase)
 {
strIdYoungTAppraisedCase = strIdYoungTAppraisedCase.Replace("'", "''");
if (strIdYoungTAppraisedCase.Length > 8)
{
throw new Exception("在表:vYoungTAppraisedCase_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdYoungTAppraisedCase)  ==  true)
{
throw new Exception("在表:vYoungTAppraisedCase_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdYoungTAppraisedCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdYoungTAppraisedCase = strIdYoungTAppraisedCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdYoungTAppraisedCase");
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
if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase)
{
return mstrIdYoungTAppraisedCase;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID)
{
return mstrYoungTAppraisedCaseID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName)
{
return mstrYoungTAppraisedCaseName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText)
{
return mstrYoungTAppraisedCaseText;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate)
{
return mstrYoungTAppraisedCaseDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime)
{
return mstrYoungTAppraisedCaseTime;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme)
{
return mstrYoungTAppraisedCaseTheme;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn)
{
return mstrYoungTAppraisedCaseDateIn;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn)
{
return mstrYoungTAppraisedCaseTimeIn;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeacherID)
{
return mstrTeacherID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.EntryDate)
{
return mstrEntryDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.EntryYear)
{
return mstrEntryYear;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType)
{
return mstrIdYoungTAppraisedCaseType;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName)
{
return mstrYoungTAppraisedCaseTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IsUse)
{
return mbolIsUse;
}
return null;
}
set
{
if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase)
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID)
{
mstrYoungTAppraisedCaseID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName)
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText)
{
mstrYoungTAppraisedCaseText = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate)
{
mstrYoungTAppraisedCaseDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime)
{
mstrYoungTAppraisedCaseTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme)
{
mstrYoungTAppraisedCaseTheme = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn)
{
mstrYoungTAppraisedCaseDateIn = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn)
{
mstrYoungTAppraisedCaseTimeIn = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdStudyLevel);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.StudyLevelName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdTeachingPlan);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdCaseType);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdDiscipline);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DisciplineID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DisciplineName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.BrowseCount);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.VersionNo);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdTeachSkill);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.SkillTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillTheory);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdSkillType);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.SkillTypeID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CaseLevelId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DocFile);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsNeedGeneWord);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.WordCreateDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsVisible);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.OwnerId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeacherID)
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeacherID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeacherName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdXzCollege);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.EntryDate)
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.EntryDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.EntryYear)
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.EntryYear);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeNameA);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsDualVideo);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType)
{
mstrIdYoungTAppraisedCaseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName)
{
mstrYoungTAppraisedCaseTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.UserTypeId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.UserTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.RecommendedDegreeId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.RecommendedDegreeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.Memo);
}
else if (strAttributeName  ==  convYoungTAppraisedCase_Sim.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsUse);
}
}
}
public object this[int intIndex]
{
get
{
if (convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCase;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseID;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseName;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseText;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseDate;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTime;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTheme;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseDateIn;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTimeIn;
}
else if (convYoungTAppraisedCase_Sim.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convYoungTAppraisedCase_Sim.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convYoungTAppraisedCase_Sim.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convYoungTAppraisedCase_Sim.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convYoungTAppraisedCase_Sim.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convYoungTAppraisedCase_Sim.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convYoungTAppraisedCase_Sim.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convYoungTAppraisedCase_Sim.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convYoungTAppraisedCase_Sim.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convYoungTAppraisedCase_Sim.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convYoungTAppraisedCase_Sim.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convYoungTAppraisedCase_Sim.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convYoungTAppraisedCase_Sim.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convYoungTAppraisedCase_Sim.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convYoungTAppraisedCase_Sim.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convYoungTAppraisedCase_Sim.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convYoungTAppraisedCase_Sim.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convYoungTAppraisedCase_Sim.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convYoungTAppraisedCase_Sim.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convYoungTAppraisedCase_Sim.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convYoungTAppraisedCase_Sim.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convYoungTAppraisedCase_Sim.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convYoungTAppraisedCase_Sim.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convYoungTAppraisedCase_Sim.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convYoungTAppraisedCase_Sim.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convYoungTAppraisedCase_Sim.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convYoungTAppraisedCase_Sim.TeacherID  ==  AttributeName[intIndex])
{
return mstrTeacherID;
}
else if (convYoungTAppraisedCase_Sim.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convYoungTAppraisedCase_Sim.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convYoungTAppraisedCase_Sim.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convYoungTAppraisedCase_Sim.EntryDate  ==  AttributeName[intIndex])
{
return mstrEntryDate;
}
else if (convYoungTAppraisedCase_Sim.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convYoungTAppraisedCase_Sim.EntryYear  ==  AttributeName[intIndex])
{
return mstrEntryYear;
}
else if (convYoungTAppraisedCase_Sim.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convYoungTAppraisedCase_Sim.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCaseType;
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTypeName;
}
else if (convYoungTAppraisedCase_Sim.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convYoungTAppraisedCase_Sim.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convYoungTAppraisedCase_Sim.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convYoungTAppraisedCase_Sim.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convYoungTAppraisedCase_Sim.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convYoungTAppraisedCase_Sim.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
return null;
}
set
{
if (convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseText = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTheme = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseDateIn = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTimeIn = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn);
}
else if (convYoungTAppraisedCase_Sim.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdStudyLevel);
}
else if (convYoungTAppraisedCase_Sim.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.StudyLevelName);
}
else if (convYoungTAppraisedCase_Sim.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdTeachingPlan);
}
else if (convYoungTAppraisedCase_Sim.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdCaseType);
}
else if (convYoungTAppraisedCase_Sim.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdDiscipline);
}
else if (convYoungTAppraisedCase_Sim.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DisciplineID);
}
else if (convYoungTAppraisedCase_Sim.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DisciplineName);
}
else if (convYoungTAppraisedCase_Sim.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.BrowseCount);
}
else if (convYoungTAppraisedCase_Sim.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdSenateGaugeVersion);
}
else if (convYoungTAppraisedCase_Sim.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionID);
}
else if (convYoungTAppraisedCase_Sim.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionName);
}
else if (convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore);
}
else if (convYoungTAppraisedCase_Sim.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.VersionNo);
}
else if (convYoungTAppraisedCase_Sim.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdTeachSkill);
}
else if (convYoungTAppraisedCase_Sim.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillID);
}
else if (convYoungTAppraisedCase_Sim.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.SkillTypeName);
}
else if (convYoungTAppraisedCase_Sim.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillName);
}
else if (convYoungTAppraisedCase_Sim.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillTheory);
}
else if (convYoungTAppraisedCase_Sim.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillOperMethod);
}
else if (convYoungTAppraisedCase_Sim.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdSkillType);
}
else if (convYoungTAppraisedCase_Sim.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.SkillTypeID);
}
else if (convYoungTAppraisedCase_Sim.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CaseLevelId);
}
else if (convYoungTAppraisedCase_Sim.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DocFile);
}
else if (convYoungTAppraisedCase_Sim.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsNeedGeneWord);
}
else if (convYoungTAppraisedCase_Sim.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.WordCreateDate);
}
else if (convYoungTAppraisedCase_Sim.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsVisible);
}
else if (convYoungTAppraisedCase_Sim.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.OwnerId);
}
else if (convYoungTAppraisedCase_Sim.TeacherID  ==  AttributeName[intIndex])
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeacherID);
}
else if (convYoungTAppraisedCase_Sim.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeacherName);
}
else if (convYoungTAppraisedCase_Sim.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdXzCollege);
}
else if (convYoungTAppraisedCase_Sim.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeName);
}
else if (convYoungTAppraisedCase_Sim.EntryDate  ==  AttributeName[intIndex])
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.EntryDate);
}
else if (convYoungTAppraisedCase_Sim.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeID);
}
else if (convYoungTAppraisedCase_Sim.EntryYear  ==  AttributeName[intIndex])
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.EntryYear);
}
else if (convYoungTAppraisedCase_Sim.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeNameA);
}
else if (convYoungTAppraisedCase_Sim.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsDualVideo);
}
else if (convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCaseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType);
}
else if (convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName);
}
else if (convYoungTAppraisedCase_Sim.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.UserTypeId);
}
else if (convYoungTAppraisedCase_Sim.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.UserTypeName);
}
else if (convYoungTAppraisedCase_Sim.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.RecommendedDegreeId);
}
else if (convYoungTAppraisedCase_Sim.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.RecommendedDegreeName);
}
else if (convYoungTAppraisedCase_Sim.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase_Sim.Memo);
}
else if (convYoungTAppraisedCase_Sim.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsUse);
}
}
}

/// <summary>
/// 青教评优案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdYoungTAppraisedCase
{
get
{
return mstrIdYoungTAppraisedCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdYoungTAppraisedCase = value;
}
else
{
 mstrIdYoungTAppraisedCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdYoungTAppraisedCase);
}
}
/// <summary>
/// 青教评优案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseID
{
get
{
return mstrYoungTAppraisedCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseID = value;
}
else
{
 mstrYoungTAppraisedCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseID);
}
}
/// <summary>
/// 青教评优案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseName
{
get
{
return mstrYoungTAppraisedCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseName = value;
}
else
{
 mstrYoungTAppraisedCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseText
{
get
{
return mstrYoungTAppraisedCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseText = value;
}
else
{
 mstrYoungTAppraisedCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseText);
}
}
/// <summary>
/// 青教评优教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseDate
{
get
{
return mstrYoungTAppraisedCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseDate = value;
}
else
{
 mstrYoungTAppraisedCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDate);
}
}
/// <summary>
/// 青教评优教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTime
{
get
{
return mstrYoungTAppraisedCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTime = value;
}
else
{
 mstrYoungTAppraisedCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTime);
}
}
/// <summary>
/// 青教评优案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTheme
{
get
{
return mstrYoungTAppraisedCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTheme = value;
}
else
{
 mstrYoungTAppraisedCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTheme);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseDateIn
{
get
{
return mstrYoungTAppraisedCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseDateIn = value;
}
else
{
 mstrYoungTAppraisedCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTimeIn
{
get
{
return mstrYoungTAppraisedCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTimeIn = value;
}
else
{
 mstrYoungTAppraisedCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTimeIn);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdStudyLevel);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.StudyLevelName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdTeachingPlan);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdCaseType);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdDiscipline);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DisciplineID);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DisciplineName);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.BrowseCount);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdSenateGaugeVersion);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionID);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.VersionNo);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdTeachSkill);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillID);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.SkillTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillTheory);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeachSkillOperMethod);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdSkillType);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.SkillTypeID);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CaseLevelId);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.DocFile);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsNeedGeneWord);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.WordCreateDate);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsVisible);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.OwnerId);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherID
{
get
{
return mstrTeacherID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherID = value;
}
else
{
 mstrTeacherID = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeacherID);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.TeacherName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdXzCollege);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.EntryDate);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeID);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.EntryYear);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.CollegeNameA);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsDualVideo);
}
}
/// <summary>
/// 青教案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdYoungTAppraisedCaseType
{
get
{
return mstrIdYoungTAppraisedCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdYoungTAppraisedCaseType = value;
}
else
{
 mstrIdYoungTAppraisedCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IdYoungTAppraisedCaseType);
}
}
/// <summary>
/// 青教案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTypeName
{
get
{
return mstrYoungTAppraisedCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTypeName = value;
}
else
{
 mstrYoungTAppraisedCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase_Sim.YoungTAppraisedCaseTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.UserTypeId);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.UserTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.RecommendedDegreeId);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.RecommendedDegreeName);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.Memo);
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
 AddUpdatedFld(convYoungTAppraisedCase_Sim.IsUse);
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
  return mstrIdYoungTAppraisedCase;
 }
 }
}
 /// <summary>
 /// vYoungTAppraisedCase_Sim(vYoungTAppraisedCase_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convYoungTAppraisedCase_Sim
{
public const string _CurrTabName = "vYoungTAppraisedCase_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdYoungTAppraisedCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdYoungTAppraisedCase", "YoungTAppraisedCaseID", "YoungTAppraisedCaseName", "YoungTAppraisedCaseText", "YoungTAppraisedCaseDate", "YoungTAppraisedCaseTime", "YoungTAppraisedCaseTheme", "YoungTAppraisedCaseDateIn", "YoungTAppraisedCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "TeacherID", "TeacherName", "IdXzCollege", "CollegeName", "EntryDate", "CollegeID", "EntryYear", "CollegeNameA", "IsDualVideo", "IdYoungTAppraisedCaseType", "YoungTAppraisedCaseTypeName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "Memo", "IsUse"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdYoungTAppraisedCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdYoungTAppraisedCase = "IdYoungTAppraisedCase";    //青教评优案例流水号

 /// <summary>
 /// 常量:"YoungTAppraisedCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseID = "YoungTAppraisedCaseID";    //青教评优案例ID

 /// <summary>
 /// 常量:"YoungTAppraisedCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseName = "YoungTAppraisedCaseName";    //青教评优案例名称

 /// <summary>
 /// 常量:"YoungTAppraisedCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseText = "YoungTAppraisedCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"YoungTAppraisedCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseDate = "YoungTAppraisedCaseDate";    //青教评优教学日期

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTime = "YoungTAppraisedCaseTime";    //青教评优教学时间

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTheme = "YoungTAppraisedCaseTheme";    //青教评优案例主题词

 /// <summary>
 /// 常量:"YoungTAppraisedCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseDateIn = "YoungTAppraisedCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTimeIn = "YoungTAppraisedCaseTimeIn";    //案例入库时间

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
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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
 /// 常量:"TeacherID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherID = "TeacherID";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"EntryDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryDate = "EntryDate";    //进校日期

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

 /// <summary>
 /// 常量:"EntryYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryYear = "EntryYear";    //EntryYear

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"IdYoungTAppraisedCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdYoungTAppraisedCaseType = "IdYoungTAppraisedCaseType";    //青教案例类型流水号

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTypeName = "YoungTAppraisedCaseTypeName";    //青教案例类型名称

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用
}

}