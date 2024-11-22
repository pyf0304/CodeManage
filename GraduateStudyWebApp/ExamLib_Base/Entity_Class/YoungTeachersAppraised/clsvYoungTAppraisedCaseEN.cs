
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseEN
 表名:vYoungTAppraisedCase(01120464)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:22
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
 /// 表vYoungTAppraisedCase的关键字(IdYoungTAppraisedCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdYoungTAppraisedCase_vYoungTAppraisedCase
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
public K_IdYoungTAppraisedCase_vYoungTAppraisedCase(string strIdYoungTAppraisedCase)
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
 /// <returns>返回:[K_IdYoungTAppraisedCase_vYoungTAppraisedCase]类型的对象</returns>
public static implicit operator K_IdYoungTAppraisedCase_vYoungTAppraisedCase(string value)
{
return new K_IdYoungTAppraisedCase_vYoungTAppraisedCase(value);
}
}
 /// <summary>
 /// v青教评优案例(vYoungTAppraisedCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvYoungTAppraisedCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vYoungTAppraisedCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdYoungTAppraisedCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 63;
public static string[] AttributeName = new string[] {"IdYoungTAppraisedCase", "IdDecompressionFile", "FuncModuleName", "YoungTAppraisedCaseID", "YoungTAppraisedCaseName", "YoungTAppraisedCaseText", "YoungTAppraisedCaseDate", "YoungTAppraisedCaseTime", "YoungTAppraisedCaseTheme", "YoungTAppraisedCaseDateIn", "YoungTAppraisedCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "TeacherID", "TeacherName", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "EntryDate", "IsDualVideo", "IdYoungTAppraisedCaseType", "YoungTAppraisedCaseTypeName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdUserId", "UpdDate", "Memo", "OwnerNameWithId", "OwnerName", "AddiSiteName", "BrowseCount4Case", "EntryYear"};

protected string mstrIdYoungTAppraisedCase;    //青教评优案例流水号
protected long? mlngIdDecompressionFile;    //解压缩文件流水号
protected string mstrFuncModuleName;    //功能模块名称
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
protected string mstrDocFile;    //生成的Word文件名
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected bool mbolIsVisible;    //是否显示
protected string mstrOwnerId;    //拥有者Id
protected string mstrTeacherID;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrEntryDate;    //进校日期
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdYoungTAppraisedCaseType;    //青教案例类型流水号
protected string mstrYoungTAppraisedCaseTypeName;    //青教案例类型名称
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrAddiSiteName;    //AddiSiteName
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrEntryYear;    //EntryYear

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvYoungTAppraisedCaseEN()
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
public clsvYoungTAppraisedCaseEN(string strIdYoungTAppraisedCase)
 {
strIdYoungTAppraisedCase = strIdYoungTAppraisedCase.Replace("'", "''");
if (strIdYoungTAppraisedCase.Length > 8)
{
throw new Exception("在表:vYoungTAppraisedCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdYoungTAppraisedCase)  ==  true)
{
throw new Exception("在表:vYoungTAppraisedCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convYoungTAppraisedCase.IdYoungTAppraisedCase)
{
return mstrIdYoungTAppraisedCase;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdDecompressionFile)
{
return mlngIdDecompressionFile;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseID)
{
return mstrYoungTAppraisedCaseID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseName)
{
return mstrYoungTAppraisedCaseName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseText)
{
return mstrYoungTAppraisedCaseText;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseDate)
{
return mstrYoungTAppraisedCaseDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseTime)
{
return mstrYoungTAppraisedCaseTime;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseTheme)
{
return mstrYoungTAppraisedCaseTheme;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseDateIn)
{
return mstrYoungTAppraisedCaseDateIn;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn)
{
return mstrYoungTAppraisedCaseTimeIn;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeacherID)
{
return mstrTeacherID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.EntryDate)
{
return mstrEntryDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdYoungTAppraisedCaseType)
{
return mstrIdYoungTAppraisedCaseType;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseTypeName)
{
return mstrYoungTAppraisedCaseTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.AddiSiteName)
{
return mstrAddiSiteName;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convYoungTAppraisedCase.EntryYear)
{
return mstrEntryYear;
}
return null;
}
set
{
if (strAttributeName  ==  convYoungTAppraisedCase.IdYoungTAppraisedCase)
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdYoungTAppraisedCase);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdDecompressionFile)
{
mlngIdDecompressionFile = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.IdDecompressionFile);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.FuncModuleName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseID)
{
mstrYoungTAppraisedCaseID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseName)
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseText)
{
mstrYoungTAppraisedCaseText = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseText);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseDate)
{
mstrYoungTAppraisedCaseDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseTime)
{
mstrYoungTAppraisedCaseTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTime);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseTheme)
{
mstrYoungTAppraisedCaseTheme = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTheme);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseDateIn)
{
mstrYoungTAppraisedCaseDateIn = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn)
{
mstrYoungTAppraisedCaseTimeIn = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdStudyLevel);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.StudyLevelName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdCaseType);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdDiscipline);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.DisciplineID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.DisciplineName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.VersionNo);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdTeachSkill);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.SkillTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillTheory);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdSkillType);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.SkillTypeID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.CaseLevelId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.DocFile);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.WordCreateDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.IsVisible);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.OwnerId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeacherID)
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeacherID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeacherName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdXzCollege);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.CollegeID);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.CollegeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.CollegeNameA);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.EntryDate)
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.EntryDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.IsDualVideo);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.IdYoungTAppraisedCaseType)
{
mstrIdYoungTAppraisedCaseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdYoungTAppraisedCaseType);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.YoungTAppraisedCaseTypeName)
{
mstrYoungTAppraisedCaseTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.UserTypeId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.UserTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.ftpFileType);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.VideoUrl);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.VideoPath);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.ResErrMsg);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.UpdUserId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.UpdDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.Memo);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.OwnerNameWithId);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.OwnerName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.AddiSiteName)
{
mstrAddiSiteName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.AddiSiteName);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.BrowseCount4Case);
}
else if (strAttributeName  ==  convYoungTAppraisedCase.EntryYear)
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.EntryYear);
}
}
}
public object this[int intIndex]
{
get
{
if (convYoungTAppraisedCase.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCase;
}
else if (convYoungTAppraisedCase.IdDecompressionFile  ==  AttributeName[intIndex])
{
return mlngIdDecompressionFile;
}
else if (convYoungTAppraisedCase.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseID  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseID;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseName;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseText  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseText;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseDate  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseDate;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseTime  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTime;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseTheme  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTheme;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseDateIn  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseDateIn;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTimeIn;
}
else if (convYoungTAppraisedCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convYoungTAppraisedCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convYoungTAppraisedCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convYoungTAppraisedCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convYoungTAppraisedCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convYoungTAppraisedCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convYoungTAppraisedCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convYoungTAppraisedCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convYoungTAppraisedCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convYoungTAppraisedCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convYoungTAppraisedCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convYoungTAppraisedCase.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convYoungTAppraisedCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convYoungTAppraisedCase.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convYoungTAppraisedCase.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convYoungTAppraisedCase.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convYoungTAppraisedCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convYoungTAppraisedCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convYoungTAppraisedCase.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convYoungTAppraisedCase.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convYoungTAppraisedCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convYoungTAppraisedCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convYoungTAppraisedCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convYoungTAppraisedCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convYoungTAppraisedCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convYoungTAppraisedCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convYoungTAppraisedCase.TeacherID  ==  AttributeName[intIndex])
{
return mstrTeacherID;
}
else if (convYoungTAppraisedCase.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convYoungTAppraisedCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convYoungTAppraisedCase.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convYoungTAppraisedCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convYoungTAppraisedCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convYoungTAppraisedCase.EntryDate  ==  AttributeName[intIndex])
{
return mstrEntryDate;
}
else if (convYoungTAppraisedCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convYoungTAppraisedCase.IdYoungTAppraisedCaseType  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCaseType;
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseTypeName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTypeName;
}
else if (convYoungTAppraisedCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convYoungTAppraisedCase.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convYoungTAppraisedCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convYoungTAppraisedCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convYoungTAppraisedCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convYoungTAppraisedCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convYoungTAppraisedCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convYoungTAppraisedCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convYoungTAppraisedCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convYoungTAppraisedCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convYoungTAppraisedCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convYoungTAppraisedCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convYoungTAppraisedCase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convYoungTAppraisedCase.AddiSiteName  ==  AttributeName[intIndex])
{
return mstrAddiSiteName;
}
else if (convYoungTAppraisedCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convYoungTAppraisedCase.EntryYear  ==  AttributeName[intIndex])
{
return mstrEntryYear;
}
return null;
}
set
{
if (convYoungTAppraisedCase.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdYoungTAppraisedCase);
}
else if (convYoungTAppraisedCase.IdDecompressionFile  ==  AttributeName[intIndex])
{
mlngIdDecompressionFile = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.IdDecompressionFile);
}
else if (convYoungTAppraisedCase.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.FuncModuleName);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseID  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseID);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseName);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseText  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseText = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseText);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseDate  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseDate);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseTime  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTime);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseTheme  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTheme = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTheme);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseDateIn  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseDateIn = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTimeIn = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
}
else if (convYoungTAppraisedCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdStudyLevel);
}
else if (convYoungTAppraisedCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.StudyLevelName);
}
else if (convYoungTAppraisedCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdTeachingPlan);
}
else if (convYoungTAppraisedCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdCaseType);
}
else if (convYoungTAppraisedCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdDiscipline);
}
else if (convYoungTAppraisedCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.DisciplineID);
}
else if (convYoungTAppraisedCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.DisciplineName);
}
else if (convYoungTAppraisedCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdSenateGaugeVersion);
}
else if (convYoungTAppraisedCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionID);
}
else if (convYoungTAppraisedCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionName);
}
else if (convYoungTAppraisedCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionTtlScore);
}
else if (convYoungTAppraisedCase.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.VersionNo);
}
else if (convYoungTAppraisedCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdTeachSkill);
}
else if (convYoungTAppraisedCase.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillID);
}
else if (convYoungTAppraisedCase.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.SkillTypeName);
}
else if (convYoungTAppraisedCase.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillName);
}
else if (convYoungTAppraisedCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillTheory);
}
else if (convYoungTAppraisedCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillOperMethod);
}
else if (convYoungTAppraisedCase.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdSkillType);
}
else if (convYoungTAppraisedCase.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.SkillTypeID);
}
else if (convYoungTAppraisedCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.CaseLevelId);
}
else if (convYoungTAppraisedCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.DocFile);
}
else if (convYoungTAppraisedCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.IsNeedGeneWord);
}
else if (convYoungTAppraisedCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.WordCreateDate);
}
else if (convYoungTAppraisedCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.IsVisible);
}
else if (convYoungTAppraisedCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.OwnerId);
}
else if (convYoungTAppraisedCase.TeacherID  ==  AttributeName[intIndex])
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeacherID);
}
else if (convYoungTAppraisedCase.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.TeacherName);
}
else if (convYoungTAppraisedCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdXzCollege);
}
else if (convYoungTAppraisedCase.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.CollegeID);
}
else if (convYoungTAppraisedCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.CollegeName);
}
else if (convYoungTAppraisedCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.CollegeNameA);
}
else if (convYoungTAppraisedCase.EntryDate  ==  AttributeName[intIndex])
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.EntryDate);
}
else if (convYoungTAppraisedCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.IsDualVideo);
}
else if (convYoungTAppraisedCase.IdYoungTAppraisedCaseType  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCaseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.IdYoungTAppraisedCaseType);
}
else if (convYoungTAppraisedCase.YoungTAppraisedCaseTypeName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTypeName);
}
else if (convYoungTAppraisedCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.UserTypeId);
}
else if (convYoungTAppraisedCase.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.UserTypeName);
}
else if (convYoungTAppraisedCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.RecommendedDegreeId);
}
else if (convYoungTAppraisedCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.RecommendedDegreeName);
}
else if (convYoungTAppraisedCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.ftpFileType);
}
else if (convYoungTAppraisedCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.VideoUrl);
}
else if (convYoungTAppraisedCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.VideoPath);
}
else if (convYoungTAppraisedCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.ResErrMsg);
}
else if (convYoungTAppraisedCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.UpdUserId);
}
else if (convYoungTAppraisedCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.UpdDate);
}
else if (convYoungTAppraisedCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.Memo);
}
else if (convYoungTAppraisedCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.OwnerNameWithId);
}
else if (convYoungTAppraisedCase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.OwnerName);
}
else if (convYoungTAppraisedCase.AddiSiteName  ==  AttributeName[intIndex])
{
mstrAddiSiteName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.AddiSiteName);
}
else if (convYoungTAppraisedCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCase.BrowseCount4Case);
}
else if (convYoungTAppraisedCase.EntryYear  ==  AttributeName[intIndex])
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCase.EntryYear);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdYoungTAppraisedCase);
}
}
/// <summary>
/// 解压缩文件流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? IdDecompressionFile
{
get
{
return mlngIdDecompressionFile;
}
set
{
 mlngIdDecompressionFile = value;
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase.IdDecompressionFile);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase.FuncModuleName);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseID);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseName);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseText);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseDate);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTime);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTheme);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdStudyLevel);
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
 AddUpdatedFld(convYoungTAppraisedCase.StudyLevelName);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdTeachingPlan);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdCaseType);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdDiscipline);
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
 AddUpdatedFld(convYoungTAppraisedCase.DisciplineID);
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
 AddUpdatedFld(convYoungTAppraisedCase.DisciplineName);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionID);
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
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionName);
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
 AddUpdatedFld(convYoungTAppraisedCase.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convYoungTAppraisedCase.VersionNo);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdTeachSkill);
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
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillID);
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
 AddUpdatedFld(convYoungTAppraisedCase.SkillTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillName);
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
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillTheory);
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
 AddUpdatedFld(convYoungTAppraisedCase.TeachSkillOperMethod);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdSkillType);
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
 AddUpdatedFld(convYoungTAppraisedCase.SkillTypeID);
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
 AddUpdatedFld(convYoungTAppraisedCase.CaseLevelId);
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
 AddUpdatedFld(convYoungTAppraisedCase.DocFile);
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
 AddUpdatedFld(convYoungTAppraisedCase.IsNeedGeneWord);
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
 AddUpdatedFld(convYoungTAppraisedCase.WordCreateDate);
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
 AddUpdatedFld(convYoungTAppraisedCase.IsVisible);
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
 AddUpdatedFld(convYoungTAppraisedCase.OwnerId);
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
 AddUpdatedFld(convYoungTAppraisedCase.TeacherID);
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
 AddUpdatedFld(convYoungTAppraisedCase.TeacherName);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdXzCollege);
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
 AddUpdatedFld(convYoungTAppraisedCase.CollegeID);
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
 AddUpdatedFld(convYoungTAppraisedCase.CollegeName);
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
 AddUpdatedFld(convYoungTAppraisedCase.CollegeNameA);
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
 AddUpdatedFld(convYoungTAppraisedCase.EntryDate);
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
 AddUpdatedFld(convYoungTAppraisedCase.IsDualVideo);
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
 AddUpdatedFld(convYoungTAppraisedCase.IdYoungTAppraisedCaseType);
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
 AddUpdatedFld(convYoungTAppraisedCase.YoungTAppraisedCaseTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCase.UserTypeId);
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
 AddUpdatedFld(convYoungTAppraisedCase.UserTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCase.RecommendedDegreeId);
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
 AddUpdatedFld(convYoungTAppraisedCase.RecommendedDegreeName);
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
 AddUpdatedFld(convYoungTAppraisedCase.ftpFileType);
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
 AddUpdatedFld(convYoungTAppraisedCase.VideoUrl);
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
 AddUpdatedFld(convYoungTAppraisedCase.VideoPath);
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
 AddUpdatedFld(convYoungTAppraisedCase.ResErrMsg);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase.UpdUserId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase.UpdDate);
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
 AddUpdatedFld(convYoungTAppraisedCase.Memo);
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
 AddUpdatedFld(convYoungTAppraisedCase.OwnerNameWithId);
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
 AddUpdatedFld(convYoungTAppraisedCase.OwnerName);
}
}
/// <summary>
/// AddiSiteName(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AddiSiteName
{
get
{
return mstrAddiSiteName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAddiSiteName = value;
}
else
{
 mstrAddiSiteName = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCase.AddiSiteName);
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
 AddUpdatedFld(convYoungTAppraisedCase.BrowseCount4Case);
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
 AddUpdatedFld(convYoungTAppraisedCase.EntryYear);
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
 /// v青教评优案例(vYoungTAppraisedCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convYoungTAppraisedCase
{
public const string _CurrTabName = "vYoungTAppraisedCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdYoungTAppraisedCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdYoungTAppraisedCase", "IdDecompressionFile", "FuncModuleName", "YoungTAppraisedCaseID", "YoungTAppraisedCaseName", "YoungTAppraisedCaseText", "YoungTAppraisedCaseDate", "YoungTAppraisedCaseTime", "YoungTAppraisedCaseTheme", "YoungTAppraisedCaseDateIn", "YoungTAppraisedCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "TeacherID", "TeacherName", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "EntryDate", "IsDualVideo", "IdYoungTAppraisedCaseType", "YoungTAppraisedCaseTypeName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdUserId", "UpdDate", "Memo", "OwnerNameWithId", "OwnerName", "AddiSiteName", "BrowseCount4Case", "EntryYear"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdYoungTAppraisedCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdYoungTAppraisedCase = "IdYoungTAppraisedCase";    //青教评优案例流水号

 /// <summary>
 /// 常量:"IdDecompressionFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDecompressionFile = "IdDecompressionFile";    //解压缩文件流水号

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

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
 /// 常量:"EntryDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryDate = "EntryDate";    //进校日期

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
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"AddiSiteName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AddiSiteName = "AddiSiteName";    //AddiSiteName

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"EntryYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryYear = "EntryYear";    //EntryYear
}

}