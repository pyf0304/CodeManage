
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase4TeaEN
 表名:vMicroteachCase4Tea(01120503)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vMicroteachCase4Tea的关键字(IdMicroteachCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCase_vMicroteachCase4Tea
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
public K_IdMicroteachCase_vMicroteachCase4Tea(string strIdMicroteachCase)
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
 /// <returns>返回:[K_IdMicroteachCase_vMicroteachCase4Tea]类型的对象</returns>
public static implicit operator K_IdMicroteachCase_vMicroteachCase4Tea(string value)
{
return new K_IdMicroteachCase_vMicroteachCase4Tea(value);
}
}
 /// <summary>
 /// vMicroteachCase4Tea(vMicroteachCase4Tea)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachCase4TeaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachCase4Tea"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 53;
public static string[] AttributeName = new string[] {"IdMicroteachCase", "MicroteachCaseTypeName", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IdMicroteachCaseType", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "microteachCaseText", "OwnerId", "OwnerName", "TeacherId", "TeacherName", "IdXzCollege", "CollegeName", "EntryDate", "CollegeId", "EntryYear", "IsDualVideo", "UserTypeId", "RecommendedDegreeId", "RecommendedDegreeName", "Memo", "BrowseCount4Case", "CollegeNameA", "ftpFileType"};

protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrMicroteachCaseTypeName;    //微格案例类型名称
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
protected string mstrDocFile;    //生成的Word文件名
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected bool mbolIsVisible;    //是否显示
protected string mstrmicroteachCaseText;    //案例文本内容
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrTeacherId;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrEntryDate;    //进校日期
protected string mstrCollegeId;    //学院ID
protected string mstrEntryYear;    //EntryYear
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserTypeId;    //用户类型Id
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrMemo;    //备注
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrftpFileType;    //ftp文件类型

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachCase4TeaEN()
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
public clsvMicroteachCase4TeaEN(string strIdMicroteachCase)
 {
strIdMicroteachCase = strIdMicroteachCase.Replace("'", "''");
if (strIdMicroteachCase.Length > 8)
{
throw new Exception("在表:vMicroteachCase4Tea中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMicroteachCase)  ==  true)
{
throw new Exception("在表:vMicroteachCase4Tea中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convMicroteachCase4Tea.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseTypeName)
{
return mstrMicroteachCaseTypeName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseID)
{
return mstrMicroteachCaseID;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseName)
{
return mstrMicroteachCaseName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseTheme)
{
return mstrMicroteachCaseTheme;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseDate)
{
return mstrMicroteachCaseDate;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseTime)
{
return mstrMicroteachCaseTime;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseDateIn)
{
return mstrMicroteachCaseDateIn;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroTeachCaseTimeIn)
{
return mstrMicroTeachCaseTimeIn;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdMicroteachCaseType)
{
return mstrIdMicroteachCaseType;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.microteachCaseText)
{
return mstrmicroteachCaseText;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.EntryDate)
{
return mstrEntryDate;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.EntryYear)
{
return mstrEntryYear;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convMicroteachCase4Tea.ftpFileType)
{
return mstrftpFileType;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachCase4Tea.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseTypeName)
{
mstrMicroteachCaseTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTypeName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseID)
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseID);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseName)
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseTheme)
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTheme);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseDate)
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseDate);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseTime)
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTime);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroteachCaseDateIn)
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseDateIn);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdStudyLevel);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.StudyLevelName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdTeachingPlan);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.MicroTeachCaseTimeIn)
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroTeachCaseTimeIn);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdMicroteachCaseType)
{
mstrIdMicroteachCaseType = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdMicroteachCaseType);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdCaseType);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdDiscipline);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.DisciplineID);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.DisciplineName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionID);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.VersionNo);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdTeachSkill);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillID);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.SkillTypeName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillTheory);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdSkillType);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.SkillTypeID);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.CaseLevelId);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.DocFile);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.IsNeedGeneWord);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.WordCreateDate);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.IsVisible);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.microteachCaseText)
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.microteachCaseText);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.OwnerId);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.OwnerName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeacherId);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeacherName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdXzCollege);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.CollegeName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.EntryDate)
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.EntryDate);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.CollegeId);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.EntryYear)
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.EntryYear);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.IsDualVideo);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.UserTypeId);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.RecommendedDegreeId);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.RecommendedDegreeName);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.Memo);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.BrowseCount4Case);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.CollegeNameA);
}
else if (strAttributeName  ==  convMicroteachCase4Tea.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.ftpFileType);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachCase4Tea.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroteachCase4Tea.MicroteachCaseTypeName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTypeName;
}
else if (convMicroteachCase4Tea.MicroteachCaseID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseID;
}
else if (convMicroteachCase4Tea.MicroteachCaseName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseName;
}
else if (convMicroteachCase4Tea.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTheme;
}
else if (convMicroteachCase4Tea.MicroteachCaseDate  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDate;
}
else if (convMicroteachCase4Tea.MicroteachCaseTime  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTime;
}
else if (convMicroteachCase4Tea.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDateIn;
}
else if (convMicroteachCase4Tea.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convMicroteachCase4Tea.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convMicroteachCase4Tea.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convMicroteachCase4Tea.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseTimeIn;
}
else if (convMicroteachCase4Tea.IdMicroteachCaseType  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCaseType;
}
else if (convMicroteachCase4Tea.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convMicroteachCase4Tea.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convMicroteachCase4Tea.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convMicroteachCase4Tea.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convMicroteachCase4Tea.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convMicroteachCase4Tea.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convMicroteachCase4Tea.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convMicroteachCase4Tea.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convMicroteachCase4Tea.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convMicroteachCase4Tea.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convMicroteachCase4Tea.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convMicroteachCase4Tea.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convMicroteachCase4Tea.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convMicroteachCase4Tea.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convMicroteachCase4Tea.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convMicroteachCase4Tea.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convMicroteachCase4Tea.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convMicroteachCase4Tea.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convMicroteachCase4Tea.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convMicroteachCase4Tea.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convMicroteachCase4Tea.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convMicroteachCase4Tea.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convMicroteachCase4Tea.microteachCaseText  ==  AttributeName[intIndex])
{
return mstrmicroteachCaseText;
}
else if (convMicroteachCase4Tea.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convMicroteachCase4Tea.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convMicroteachCase4Tea.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (convMicroteachCase4Tea.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convMicroteachCase4Tea.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convMicroteachCase4Tea.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convMicroteachCase4Tea.EntryDate  ==  AttributeName[intIndex])
{
return mstrEntryDate;
}
else if (convMicroteachCase4Tea.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convMicroteachCase4Tea.EntryYear  ==  AttributeName[intIndex])
{
return mstrEntryYear;
}
else if (convMicroteachCase4Tea.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convMicroteachCase4Tea.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convMicroteachCase4Tea.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convMicroteachCase4Tea.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convMicroteachCase4Tea.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convMicroteachCase4Tea.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convMicroteachCase4Tea.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convMicroteachCase4Tea.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
return null;
}
set
{
if (convMicroteachCase4Tea.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdMicroteachCase);
}
else if (convMicroteachCase4Tea.MicroteachCaseTypeName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTypeName);
}
else if (convMicroteachCase4Tea.MicroteachCaseID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseID);
}
else if (convMicroteachCase4Tea.MicroteachCaseName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseName);
}
else if (convMicroteachCase4Tea.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTheme);
}
else if (convMicroteachCase4Tea.MicroteachCaseDate  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseDate);
}
else if (convMicroteachCase4Tea.MicroteachCaseTime  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTime);
}
else if (convMicroteachCase4Tea.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseDateIn);
}
else if (convMicroteachCase4Tea.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdStudyLevel);
}
else if (convMicroteachCase4Tea.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.StudyLevelName);
}
else if (convMicroteachCase4Tea.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdTeachingPlan);
}
else if (convMicroteachCase4Tea.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.MicroTeachCaseTimeIn);
}
else if (convMicroteachCase4Tea.IdMicroteachCaseType  ==  AttributeName[intIndex])
{
mstrIdMicroteachCaseType = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdMicroteachCaseType);
}
else if (convMicroteachCase4Tea.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdCaseType);
}
else if (convMicroteachCase4Tea.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdDiscipline);
}
else if (convMicroteachCase4Tea.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.DisciplineID);
}
else if (convMicroteachCase4Tea.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.DisciplineName);
}
else if (convMicroteachCase4Tea.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdSenateGaugeVersion);
}
else if (convMicroteachCase4Tea.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionID);
}
else if (convMicroteachCase4Tea.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionName);
}
else if (convMicroteachCase4Tea.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionTtlScore);
}
else if (convMicroteachCase4Tea.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.VersionNo);
}
else if (convMicroteachCase4Tea.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdTeachSkill);
}
else if (convMicroteachCase4Tea.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillID);
}
else if (convMicroteachCase4Tea.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.SkillTypeName);
}
else if (convMicroteachCase4Tea.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillName);
}
else if (convMicroteachCase4Tea.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillTheory);
}
else if (convMicroteachCase4Tea.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillOperMethod);
}
else if (convMicroteachCase4Tea.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdSkillType);
}
else if (convMicroteachCase4Tea.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.SkillTypeID);
}
else if (convMicroteachCase4Tea.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.CaseLevelId);
}
else if (convMicroteachCase4Tea.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.DocFile);
}
else if (convMicroteachCase4Tea.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.IsNeedGeneWord);
}
else if (convMicroteachCase4Tea.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.WordCreateDate);
}
else if (convMicroteachCase4Tea.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.IsVisible);
}
else if (convMicroteachCase4Tea.microteachCaseText  ==  AttributeName[intIndex])
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.microteachCaseText);
}
else if (convMicroteachCase4Tea.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.OwnerId);
}
else if (convMicroteachCase4Tea.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.OwnerName);
}
else if (convMicroteachCase4Tea.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeacherId);
}
else if (convMicroteachCase4Tea.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.TeacherName);
}
else if (convMicroteachCase4Tea.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.IdXzCollege);
}
else if (convMicroteachCase4Tea.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.CollegeName);
}
else if (convMicroteachCase4Tea.EntryDate  ==  AttributeName[intIndex])
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.EntryDate);
}
else if (convMicroteachCase4Tea.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.CollegeId);
}
else if (convMicroteachCase4Tea.EntryYear  ==  AttributeName[intIndex])
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.EntryYear);
}
else if (convMicroteachCase4Tea.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.IsDualVideo);
}
else if (convMicroteachCase4Tea.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.UserTypeId);
}
else if (convMicroteachCase4Tea.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.RecommendedDegreeId);
}
else if (convMicroteachCase4Tea.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.RecommendedDegreeName);
}
else if (convMicroteachCase4Tea.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.Memo);
}
else if (convMicroteachCase4Tea.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase4Tea.BrowseCount4Case);
}
else if (convMicroteachCase4Tea.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.CollegeNameA);
}
else if (convMicroteachCase4Tea.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase4Tea.ftpFileType);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdMicroteachCase);
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
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTypeName);
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
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseID);
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
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseName);
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
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTheme);
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
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseDate);
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
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseTime);
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
 AddUpdatedFld(convMicroteachCase4Tea.MicroteachCaseDateIn);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdStudyLevel);
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
 AddUpdatedFld(convMicroteachCase4Tea.StudyLevelName);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdTeachingPlan);
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
 AddUpdatedFld(convMicroteachCase4Tea.MicroTeachCaseTimeIn);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdMicroteachCaseType);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdCaseType);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdDiscipline);
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
 AddUpdatedFld(convMicroteachCase4Tea.DisciplineID);
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
 AddUpdatedFld(convMicroteachCase4Tea.DisciplineName);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdSenateGaugeVersion);
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
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionID);
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
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionName);
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
 AddUpdatedFld(convMicroteachCase4Tea.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convMicroteachCase4Tea.VersionNo);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdTeachSkill);
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
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillID);
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
 AddUpdatedFld(convMicroteachCase4Tea.SkillTypeName);
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
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillName);
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
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillTheory);
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
 AddUpdatedFld(convMicroteachCase4Tea.TeachSkillOperMethod);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdSkillType);
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
 AddUpdatedFld(convMicroteachCase4Tea.SkillTypeID);
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
 AddUpdatedFld(convMicroteachCase4Tea.CaseLevelId);
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
 AddUpdatedFld(convMicroteachCase4Tea.DocFile);
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
 AddUpdatedFld(convMicroteachCase4Tea.IsNeedGeneWord);
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
 AddUpdatedFld(convMicroteachCase4Tea.WordCreateDate);
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
 AddUpdatedFld(convMicroteachCase4Tea.IsVisible);
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
 AddUpdatedFld(convMicroteachCase4Tea.microteachCaseText);
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
 AddUpdatedFld(convMicroteachCase4Tea.OwnerId);
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
 AddUpdatedFld(convMicroteachCase4Tea.OwnerName);
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
 AddUpdatedFld(convMicroteachCase4Tea.TeacherId);
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
 AddUpdatedFld(convMicroteachCase4Tea.TeacherName);
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
 AddUpdatedFld(convMicroteachCase4Tea.IdXzCollege);
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
 AddUpdatedFld(convMicroteachCase4Tea.CollegeName);
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
 AddUpdatedFld(convMicroteachCase4Tea.EntryDate);
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
 AddUpdatedFld(convMicroteachCase4Tea.CollegeId);
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
 AddUpdatedFld(convMicroteachCase4Tea.EntryYear);
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
 AddUpdatedFld(convMicroteachCase4Tea.IsDualVideo);
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
 AddUpdatedFld(convMicroteachCase4Tea.UserTypeId);
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
 AddUpdatedFld(convMicroteachCase4Tea.RecommendedDegreeId);
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
 AddUpdatedFld(convMicroteachCase4Tea.RecommendedDegreeName);
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
 AddUpdatedFld(convMicroteachCase4Tea.Memo);
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
 AddUpdatedFld(convMicroteachCase4Tea.BrowseCount4Case);
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
 AddUpdatedFld(convMicroteachCase4Tea.CollegeNameA);
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
 AddUpdatedFld(convMicroteachCase4Tea.ftpFileType);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrMicroteachCaseName;
 }
 }
}
 /// <summary>
 /// vMicroteachCase4Tea(vMicroteachCase4Tea)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachCase4Tea
{
public const string _CurrTabName = "vMicroteachCase4Tea"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCase", "MicroteachCaseTypeName", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IdMicroteachCaseType", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "microteachCaseText", "OwnerId", "OwnerName", "TeacherId", "TeacherName", "IdXzCollege", "CollegeName", "EntryDate", "CollegeId", "EntryYear", "IsDualVideo", "UserTypeId", "RecommendedDegreeId", "RecommendedDegreeName", "Memo", "BrowseCount4Case", "CollegeNameA", "ftpFileType"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"MicroteachCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseTypeName = "MicroteachCaseTypeName";    //微格案例类型名称

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
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

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
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

 /// <summary>
 /// 常量:"EntryYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryYear = "EntryYear";    //EntryYear

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

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
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"ftpFileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpFileType = "ftpFileType";    //ftp文件类型
}

}