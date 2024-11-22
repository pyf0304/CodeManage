
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCase_BaseEN
 表名:vEduMSTRGiftedClsCase_Base(01120498)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
 /// 表vEduMSTRGiftedClsCase_Base的关键字(IdEduMSTRGiftedClsCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase_Base
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdEduMSTRGiftedClsCase">表关键字</param>
public K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase_Base(string strIdEduMSTRGiftedClsCase)
{
if (IsValid(strIdEduMSTRGiftedClsCase)) Value = strIdEduMSTRGiftedClsCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdEduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase) == true) return false;
if (strIdEduMSTRGiftedClsCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase_Base]类型的对象</returns>
public static implicit operator K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase_Base(string value)
{
return new K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase_Base(value);
}
}
 /// <summary>
 /// v教育硕士优课案例_Base(vEduMSTRGiftedClsCase_Base)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvEduMSTRGiftedClsCase_BaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vEduMSTRGiftedClsCase_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduMSTRGiftedClsCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 66;
public static string[] AttributeName = new string[] {"IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseTheme", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTime", "EduMSTRGiftedClsCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "EduMSTRGiftedClsCaseTimeIn", "IdEduMSTRGiftedClsCaseType", "EduMSTRGiftedClsCaseTypeName", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "EduMSTRGiftedClsCaseText", "OwnerId", "StuName", "StuId", "SexDesc", "StuTypeID", "StuTypeDesc", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "StuCardNo", "EnrollmentDate", "IsDualVideo", "UserTypeId", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "ResourceNum", "Memo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId"};

protected string mstrIdEduMSTRGiftedClsCase;    //教育硕士优课案例流水号
protected string mstrEduMSTRGiftedClsCaseID;    //教育硕士优课案例ID
protected string mstrEduMSTRGiftedClsCaseName;    //教育硕士优课案例名称
protected string mstrEduMSTRGiftedClsCaseTheme;    //教育硕士优课案例主题词
protected string mstrEduMSTRGiftedClsCaseDate;    //教育硕士优课案例日期
protected string mstrEduMSTRGiftedClsCaseTime;    //教育硕士优课案例时间
protected string mstrEduMSTRGiftedClsCaseDateIn;    //案例入库日期
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrEduMSTRGiftedClsCaseTimeIn;    //案例入库时间
protected string mstrIdEduMSTRGiftedClsCaseType;    //教育硕士优课案例类型流水号
protected string mstrEduMSTRGiftedClsCaseTypeName;    //教育硕士优课案例类型名称
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
protected string mstrEduMSTRGiftedClsCaseText;    //教育硕士优课案例文本
protected string mstrOwnerId;    //拥有者Id
protected string mstrStuName;    //姓名
protected string mstrStuId;    //学号
protected string mstrSexDesc;    //性别名称
protected string mstrStuTypeID;    //学生类别ID
protected string mstrStuTypeDesc;    //学生类别名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrStuCardNo;    //学生证号
protected string mstrEnrollmentDate;    //入校日期
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserTypeId;    //用户类型Id
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected int? mintResourceNum;    //资源数
protected string mstrMemo;    //备注
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvEduMSTRGiftedClsCase_BaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduMSTRGiftedClsCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdEduMSTRGiftedClsCase">关键字:教育硕士优课案例流水号</param>
public clsvEduMSTRGiftedClsCase_BaseEN(string strIdEduMSTRGiftedClsCase)
 {
strIdEduMSTRGiftedClsCase = strIdEduMSTRGiftedClsCase.Replace("'", "''");
if (strIdEduMSTRGiftedClsCase.Length > 8)
{
throw new Exception("在表:vEduMSTRGiftedClsCase_Base中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase)  ==  true)
{
throw new Exception("在表:vEduMSTRGiftedClsCase_Base中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdEduMSTRGiftedClsCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdEduMSTRGiftedClsCase = strIdEduMSTRGiftedClsCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduMSTRGiftedClsCase");
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
if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase)
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID)
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName)
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme)
{
return mstrEduMSTRGiftedClsCaseTheme;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate)
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime)
{
return mstrEduMSTRGiftedClsCaseTime;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn)
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn)
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType)
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName)
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText)
{
return mstrEduMSTRGiftedClsCaseText;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuTypeID)
{
return mstrStuTypeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.ResourceNum)
{
return mintResourceNum;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
return null;
}
set
{
if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase)
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID)
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName)
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme)
{
mstrEduMSTRGiftedClsCaseTheme = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate)
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime)
{
mstrEduMSTRGiftedClsCaseTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn)
{
mstrEduMSTRGiftedClsCaseDateIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdStudyLevel);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StudyLevelName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdTeachingPlan);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn)
{
mstrEduMSTRGiftedClsCaseTimeIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType)
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName)
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdCaseType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdDiscipline);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DisciplineID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DisciplineName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VersionNo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdTeachSkill);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SkillTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillTheory);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdSkillType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SkillTypeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CaseLevelId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CaseLevelName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DocFile);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.WordCreateDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsVisible);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText)
{
mstrEduMSTRGiftedClsCaseText = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SexDesc);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuTypeID)
{
mstrStuTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuTypeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuTypeDesc);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdXzCollege);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeNameA);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdXzMajor);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.MajorName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdGradeBase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.GradeBaseName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuCardNo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EnrollmentDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsDualVideo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.UserTypeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ftpFileType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VideoUrl);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VideoPath);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ResErrMsg);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.ResourceNum)
{
mintResourceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ResourceNum);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.Memo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.BrowseCount4Case);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Base.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerNameWithId);
}
}
}
public object this[int intIndex]
{
get
{
if (convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTheme;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTime;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
else if (convEduMSTRGiftedClsCase_Base.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convEduMSTRGiftedClsCase_Base.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convEduMSTRGiftedClsCase_Base.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
else if (convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (convEduMSTRGiftedClsCase_Base.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convEduMSTRGiftedClsCase_Base.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convEduMSTRGiftedClsCase_Base.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convEduMSTRGiftedClsCase_Base.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convEduMSTRGiftedClsCase_Base.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convEduMSTRGiftedClsCase_Base.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convEduMSTRGiftedClsCase_Base.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convEduMSTRGiftedClsCase_Base.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convEduMSTRGiftedClsCase_Base.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convEduMSTRGiftedClsCase_Base.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convEduMSTRGiftedClsCase_Base.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convEduMSTRGiftedClsCase_Base.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convEduMSTRGiftedClsCase_Base.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convEduMSTRGiftedClsCase_Base.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convEduMSTRGiftedClsCase_Base.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convEduMSTRGiftedClsCase_Base.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convEduMSTRGiftedClsCase_Base.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convEduMSTRGiftedClsCase_Base.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convEduMSTRGiftedClsCase_Base.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convEduMSTRGiftedClsCase_Base.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseText;
}
else if (convEduMSTRGiftedClsCase_Base.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convEduMSTRGiftedClsCase_Base.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convEduMSTRGiftedClsCase_Base.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (convEduMSTRGiftedClsCase_Base.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convEduMSTRGiftedClsCase_Base.StuTypeID  ==  AttributeName[intIndex])
{
return mstrStuTypeID;
}
else if (convEduMSTRGiftedClsCase_Base.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convEduMSTRGiftedClsCase_Base.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convEduMSTRGiftedClsCase_Base.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convEduMSTRGiftedClsCase_Base.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convEduMSTRGiftedClsCase_Base.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convEduMSTRGiftedClsCase_Base.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convEduMSTRGiftedClsCase_Base.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convEduMSTRGiftedClsCase_Base.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convEduMSTRGiftedClsCase_Base.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convEduMSTRGiftedClsCase_Base.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convEduMSTRGiftedClsCase_Base.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convEduMSTRGiftedClsCase_Base.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convEduMSTRGiftedClsCase_Base.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convEduMSTRGiftedClsCase_Base.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convEduMSTRGiftedClsCase_Base.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convEduMSTRGiftedClsCase_Base.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convEduMSTRGiftedClsCase_Base.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convEduMSTRGiftedClsCase_Base.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convEduMSTRGiftedClsCase_Base.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convEduMSTRGiftedClsCase_Base.ResourceNum  ==  AttributeName[intIndex])
{
return mintResourceNum;
}
else if (convEduMSTRGiftedClsCase_Base.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convEduMSTRGiftedClsCase_Base.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convEduMSTRGiftedClsCase_Base.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convEduMSTRGiftedClsCase_Base.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
return null;
}
set
{
if (convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTheme = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDateIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
}
else if (convEduMSTRGiftedClsCase_Base.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdStudyLevel);
}
else if (convEduMSTRGiftedClsCase_Base.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StudyLevelName);
}
else if (convEduMSTRGiftedClsCase_Base.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdTeachingPlan);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTimeIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
}
else if (convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName);
}
else if (convEduMSTRGiftedClsCase_Base.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdCaseType);
}
else if (convEduMSTRGiftedClsCase_Base.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdDiscipline);
}
else if (convEduMSTRGiftedClsCase_Base.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DisciplineID);
}
else if (convEduMSTRGiftedClsCase_Base.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DisciplineName);
}
else if (convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion);
}
else if (convEduMSTRGiftedClsCase_Base.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
}
else if (convEduMSTRGiftedClsCase_Base.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName);
}
else if (convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore);
}
else if (convEduMSTRGiftedClsCase_Base.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VersionNo);
}
else if (convEduMSTRGiftedClsCase_Base.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdTeachSkill);
}
else if (convEduMSTRGiftedClsCase_Base.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillID);
}
else if (convEduMSTRGiftedClsCase_Base.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SkillTypeName);
}
else if (convEduMSTRGiftedClsCase_Base.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillName);
}
else if (convEduMSTRGiftedClsCase_Base.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillTheory);
}
else if (convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod);
}
else if (convEduMSTRGiftedClsCase_Base.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdSkillType);
}
else if (convEduMSTRGiftedClsCase_Base.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SkillTypeID);
}
else if (convEduMSTRGiftedClsCase_Base.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CaseLevelId);
}
else if (convEduMSTRGiftedClsCase_Base.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CaseLevelName);
}
else if (convEduMSTRGiftedClsCase_Base.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DocFile);
}
else if (convEduMSTRGiftedClsCase_Base.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord);
}
else if (convEduMSTRGiftedClsCase_Base.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.WordCreateDate);
}
else if (convEduMSTRGiftedClsCase_Base.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsVisible);
}
else if (convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseText = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText);
}
else if (convEduMSTRGiftedClsCase_Base.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerId);
}
else if (convEduMSTRGiftedClsCase_Base.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuName);
}
else if (convEduMSTRGiftedClsCase_Base.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuId);
}
else if (convEduMSTRGiftedClsCase_Base.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SexDesc);
}
else if (convEduMSTRGiftedClsCase_Base.StuTypeID  ==  AttributeName[intIndex])
{
mstrStuTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuTypeID);
}
else if (convEduMSTRGiftedClsCase_Base.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuTypeDesc);
}
else if (convEduMSTRGiftedClsCase_Base.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdXzCollege);
}
else if (convEduMSTRGiftedClsCase_Base.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeId);
}
else if (convEduMSTRGiftedClsCase_Base.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeName);
}
else if (convEduMSTRGiftedClsCase_Base.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeNameA);
}
else if (convEduMSTRGiftedClsCase_Base.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdXzMajor);
}
else if (convEduMSTRGiftedClsCase_Base.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.MajorName);
}
else if (convEduMSTRGiftedClsCase_Base.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdGradeBase);
}
else if (convEduMSTRGiftedClsCase_Base.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.GradeBaseName);
}
else if (convEduMSTRGiftedClsCase_Base.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuCardNo);
}
else if (convEduMSTRGiftedClsCase_Base.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EnrollmentDate);
}
else if (convEduMSTRGiftedClsCase_Base.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsDualVideo);
}
else if (convEduMSTRGiftedClsCase_Base.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.UserTypeId);
}
else if (convEduMSTRGiftedClsCase_Base.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
}
else if (convEduMSTRGiftedClsCase_Base.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName);
}
else if (convEduMSTRGiftedClsCase_Base.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ftpFileType);
}
else if (convEduMSTRGiftedClsCase_Base.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VideoUrl);
}
else if (convEduMSTRGiftedClsCase_Base.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VideoPath);
}
else if (convEduMSTRGiftedClsCase_Base.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ResErrMsg);
}
else if (convEduMSTRGiftedClsCase_Base.ResourceNum  ==  AttributeName[intIndex])
{
mintResourceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ResourceNum);
}
else if (convEduMSTRGiftedClsCase_Base.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.Memo);
}
else if (convEduMSTRGiftedClsCase_Base.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.BrowseCount4Case);
}
else if (convEduMSTRGiftedClsCase_Base.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerName);
}
else if (convEduMSTRGiftedClsCase_Base.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerNameWithId);
}
}
}

/// <summary>
/// 教育硕士优课案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduMSTRGiftedClsCase
{
get
{
return mstrIdEduMSTRGiftedClsCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduMSTRGiftedClsCase = value;
}
else
{
 mstrIdEduMSTRGiftedClsCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase);
}
}
/// <summary>
/// 教育硕士优课案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseID
{
get
{
return mstrEduMSTRGiftedClsCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseID = value;
}
else
{
 mstrEduMSTRGiftedClsCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
}
}
/// <summary>
/// 教育硕士优课案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseName
{
get
{
return mstrEduMSTRGiftedClsCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseName = value;
}
else
{
 mstrEduMSTRGiftedClsCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
}
}
/// <summary>
/// 教育硕士优课案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTheme
{
get
{
return mstrEduMSTRGiftedClsCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTheme = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme);
}
}
/// <summary>
/// 教育硕士优课案例日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseDate
{
get
{
return mstrEduMSTRGiftedClsCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseDate = value;
}
else
{
 mstrEduMSTRGiftedClsCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
}
}
/// <summary>
/// 教育硕士优课案例时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTime
{
get
{
return mstrEduMSTRGiftedClsCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTime = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseDateIn
{
get
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseDateIn = value;
}
else
{
 mstrEduMSTRGiftedClsCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdStudyLevel);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StudyLevelName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdTeachingPlan);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTimeIn
{
get
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTimeIn = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
}
}
/// <summary>
/// 教育硕士优课案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduMSTRGiftedClsCaseType
{
get
{
return mstrIdEduMSTRGiftedClsCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduMSTRGiftedClsCaseType = value;
}
else
{
 mstrIdEduMSTRGiftedClsCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType);
}
}
/// <summary>
/// 教育硕士优课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTypeName
{
get
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTypeName = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdCaseType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdDiscipline);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DisciplineID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DisciplineName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VersionNo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdTeachSkill);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SkillTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillTheory);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdSkillType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SkillTypeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CaseLevelId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CaseLevelName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.DocFile);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsNeedGeneWord);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.WordCreateDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsVisible);
}
}
/// <summary>
/// 教育硕士优课案例文本(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseText
{
get
{
return mstrEduMSTRGiftedClsCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseText = value;
}
else
{
 mstrEduMSTRGiftedClsCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.SexDesc);
}
}
/// <summary>
/// 学生类别ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeID
{
get
{
return mstrStuTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeID = value;
}
else
{
 mstrStuTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuTypeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuTypeDesc);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdXzCollege);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.CollegeNameA);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdXzMajor);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.MajorName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IdGradeBase);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.GradeBaseName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.StuCardNo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.EnrollmentDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.IsDualVideo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.UserTypeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.RecommendedDegreeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ftpFileType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VideoUrl);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.VideoPath);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ResErrMsg);
}
}
/// <summary>
/// 资源数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ResourceNum
{
get
{
return mintResourceNum;
}
set
{
 mintResourceNum = value;
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.ResourceNum);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.Memo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.BrowseCount4Case);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Base.OwnerNameWithId);
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
  return mstrIdEduMSTRGiftedClsCase;
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
  return mstrEduMSTRGiftedClsCaseName;
 }
 }
}
 /// <summary>
 /// v教育硕士优课案例_Base(vEduMSTRGiftedClsCase_Base)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convEduMSTRGiftedClsCase_Base
{
public const string _CurrTabName = "vEduMSTRGiftedClsCase_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduMSTRGiftedClsCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseTheme", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTime", "EduMSTRGiftedClsCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "EduMSTRGiftedClsCaseTimeIn", "IdEduMSTRGiftedClsCaseType", "EduMSTRGiftedClsCaseTypeName", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "EduMSTRGiftedClsCaseText", "OwnerId", "StuName", "StuId", "SexDesc", "StuTypeID", "StuTypeDesc", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "StuCardNo", "EnrollmentDate", "IsDualVideo", "UserTypeId", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "ResourceNum", "Memo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEduMSTRGiftedClsCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduMSTRGiftedClsCase = "IdEduMSTRGiftedClsCase";    //教育硕士优课案例流水号

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseID = "EduMSTRGiftedClsCaseID";    //教育硕士优课案例ID

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseName = "EduMSTRGiftedClsCaseName";    //教育硕士优课案例名称

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTheme = "EduMSTRGiftedClsCaseTheme";    //教育硕士优课案例主题词

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseDate = "EduMSTRGiftedClsCaseDate";    //教育硕士优课案例日期

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTime = "EduMSTRGiftedClsCaseTime";    //教育硕士优课案例时间

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseDateIn = "EduMSTRGiftedClsCaseDateIn";    //案例入库日期

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
 /// 常量:"EduMSTRGiftedClsCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTimeIn = "EduMSTRGiftedClsCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdEduMSTRGiftedClsCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduMSTRGiftedClsCaseType = "IdEduMSTRGiftedClsCaseType";    //教育硕士优课案例类型流水号

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTypeName = "EduMSTRGiftedClsCaseTypeName";    //教育硕士优课案例类型名称

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
 /// 常量:"EduMSTRGiftedClsCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseText = "EduMSTRGiftedClsCaseText";    //教育硕士优课案例文本

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

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
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

 /// <summary>
 /// 常量:"StuTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeID = "StuTypeID";    //学生类别ID

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
 /// 常量:"StuCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuCardNo = "StuCardNo";    //学生证号

 /// <summary>
 /// 常量:"EnrollmentDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnrollmentDate = "EnrollmentDate";    //入校日期

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
 /// 常量:"ResourceNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceNum = "ResourceNum";    //资源数

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
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id
}

}