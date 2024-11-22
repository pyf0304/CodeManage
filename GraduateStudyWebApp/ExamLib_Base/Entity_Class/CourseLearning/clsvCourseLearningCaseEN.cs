
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseEN
 表名:vCourseLearningCase(01120267)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表vCourseLearningCase的关键字(IdCourseLearningCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCourseLearningCase_vCourseLearningCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCourseLearningCase">表关键字</param>
public K_IdCourseLearningCase_vCourseLearningCase(string strIdCourseLearningCase)
{
if (IsValid(strIdCourseLearningCase)) Value = strIdCourseLearningCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCourseLearningCase)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true) return false;
if (strIdCourseLearningCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCourseLearningCase_vCourseLearningCase]类型的对象</returns>
public static implicit operator K_IdCourseLearningCase_vCourseLearningCase(string value)
{
return new K_IdCourseLearningCase_vCourseLearningCase(value);
}
}
 /// <summary>
 /// v课程学习案例(vCourseLearningCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCourseLearningCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCourseLearningCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCourseLearningCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 84;
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseText", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "IdCaseType", "CaseTypeName", "IdCourseLearningCaseType", "CourseLearningCaseTypeName", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IsUse", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ImageUrl", "ResErrMsg", "OrderNum", "UpdDate", "UpdUserId", "Memo", "IsHaveVideo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId"};

protected string mstrIdCourseLearningCase;    //课程学习案例流水号
protected string mstrCourseLearningCaseID;    //课程学习案例ID
protected string mstrCourseLearningCaseName;    //课程学习案例名称
protected string mstrCourseLearningCaseText;    //案例文本内容
protected string mstrCourseLearningCaseTheme;    //课程学习案例主题词
protected string mstrCourseLearningCaseDate;    //课程学习日期
protected string mstrCourseLearningCaseTime;    //课程学习时间
protected string mstrCourseLearningCaseDateIn;    //案例入库日期
protected string mstrCourseLearningCaseTimeIn;    //案例入库时间
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrCaseTypeName;    //案例类型名称
protected string mstrIdCourseLearningCaseType;    //课程学习案例类型流水号
protected string mstrCourseLearningCaseTypeName;    //课程学习案例类型名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected bool mbolIsUse;    //是否使用
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
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrChapterId;    //章Id
protected string mstrSectionId;    //节Id
protected string mstrChapterName;    //章名
protected string mstrSectionName;    //节名
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected string mstrParentNodeId;    //父节点编号
protected string mstrCourseChapterReferred;    //节简称
protected string mstrParentNodeName;    //父节点名称
protected string mstrParentNodeReferred;    //章简称
protected int? mintViewCount;    //浏览量
protected bool mbolIsShow;    //是否启用
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrImageUrl;    //ImageUrl
protected string mstrResErrMsg;    //资源错误信息
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrIsHaveVideo;    //IsHaveVideo
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCourseLearningCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCourseLearningCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCourseLearningCase">关键字:课程学习案例流水号</param>
public clsvCourseLearningCaseEN(string strIdCourseLearningCase)
 {
strIdCourseLearningCase = strIdCourseLearningCase.Replace("'", "''");
if (strIdCourseLearningCase.Length > 8)
{
throw new Exception("在表:vCourseLearningCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("在表:vCourseLearningCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseLearningCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCourseLearningCase = strIdCourseLearningCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCourseLearningCase");
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
if (strAttributeName  ==  convCourseLearningCase.IdCourseLearningCase)
{
return mstrIdCourseLearningCase;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseID)
{
return mstrCourseLearningCaseID;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseName)
{
return mstrCourseLearningCaseName;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseText)
{
return mstrCourseLearningCaseText;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseTheme)
{
return mstrCourseLearningCaseTheme;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseDate)
{
return mstrCourseLearningCaseDate;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseTime)
{
return mstrCourseLearningCaseTime;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseDateIn)
{
return mstrCourseLearningCaseDateIn;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseTimeIn)
{
return mstrCourseLearningCaseTimeIn;
}
else if (strAttributeName  ==  convCourseLearningCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convCourseLearningCase.CaseTypeName)
{
return mstrCaseTypeName;
}
else if (strAttributeName  ==  convCourseLearningCase.IdCourseLearningCaseType)
{
return mstrIdCourseLearningCaseType;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseTypeName)
{
return mstrCourseLearningCaseTypeName;
}
else if (strAttributeName  ==  convCourseLearningCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCourseLearningCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convCourseLearningCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convCourseLearningCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convCourseLearningCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convCourseLearningCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convCourseLearningCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convCourseLearningCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convCourseLearningCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convCourseLearningCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCourseLearningCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convCourseLearningCase.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convCourseLearningCase.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convCourseLearningCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convCourseLearningCase.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convCourseLearningCase.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convCourseLearningCase.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convCourseLearningCase.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convCourseLearningCase.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convCourseLearningCase.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convCourseLearningCase.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convCourseLearningCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convCourseLearningCase.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convCourseLearningCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convCourseLearningCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convCourseLearningCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convCourseLearningCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convCourseLearningCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCourseLearningCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCourseLearningCase.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convCourseLearningCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCourseLearningCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convCourseLearningCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCourseLearningCase.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convCourseLearningCase.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convCourseLearningCase.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convCourseLearningCase.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convCourseLearningCase.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convCourseLearningCase.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convCourseLearningCase.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convCourseLearningCase.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convCourseLearningCase.ParentNodeId)
{
return mstrParentNodeId;
}
else if (strAttributeName  ==  convCourseLearningCase.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convCourseLearningCase.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convCourseLearningCase.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convCourseLearningCase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convCourseLearningCase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convCourseLearningCase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convCourseLearningCase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convCourseLearningCase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convCourseLearningCase.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convCourseLearningCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convCourseLearningCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convCourseLearningCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convCourseLearningCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convCourseLearningCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convCourseLearningCase.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  convCourseLearningCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convCourseLearningCase.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCourseLearningCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCourseLearningCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convCourseLearningCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCourseLearningCase.IsHaveVideo)
{
return mstrIsHaveVideo;
}
else if (strAttributeName  ==  convCourseLearningCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convCourseLearningCase.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCourseLearningCase.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
return null;
}
set
{
if (strAttributeName  ==  convCourseLearningCase.IdCourseLearningCase)
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdCourseLearningCase);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseID)
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseID);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseName)
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseName);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseText)
{
mstrCourseLearningCaseText = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseText);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseTheme)
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTheme);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseDate)
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseDate);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseTime)
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTime);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseDateIn)
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseDateIn);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseTimeIn)
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTimeIn);
}
else if (strAttributeName  ==  convCourseLearningCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdCaseType);
}
else if (strAttributeName  ==  convCourseLearningCase.CaseTypeName)
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CaseTypeName);
}
else if (strAttributeName  ==  convCourseLearningCase.IdCourseLearningCaseType)
{
mstrIdCourseLearningCaseType = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdCourseLearningCaseType);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseLearningCaseTypeName)
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTypeName);
}
else if (strAttributeName  ==  convCourseLearningCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.OwnerId);
}
else if (strAttributeName  ==  convCourseLearningCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdStudyLevel);
}
else if (strAttributeName  ==  convCourseLearningCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.StudyLevelName);
}
else if (strAttributeName  ==  convCourseLearningCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convCourseLearningCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdDiscipline);
}
else if (strAttributeName  ==  convCourseLearningCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.DisciplineID);
}
else if (strAttributeName  ==  convCourseLearningCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.DisciplineName);
}
else if (strAttributeName  ==  convCourseLearningCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convCourseLearningCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convCourseLearningCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCourseLearningCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convCourseLearningCase.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsUse);
}
else if (strAttributeName  ==  convCourseLearningCase.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.VersionNo);
}
else if (strAttributeName  ==  convCourseLearningCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdTeachSkill);
}
else if (strAttributeName  ==  convCourseLearningCase.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.TeachSkillID);
}
else if (strAttributeName  ==  convCourseLearningCase.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SkillTypeName);
}
else if (strAttributeName  ==  convCourseLearningCase.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.TeachSkillName);
}
else if (strAttributeName  ==  convCourseLearningCase.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCourseLearningCase.TeachSkillTheory);
}
else if (strAttributeName  ==  convCourseLearningCase.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCourseLearningCase.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convCourseLearningCase.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdSkillType);
}
else if (strAttributeName  ==  convCourseLearningCase.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SkillTypeID);
}
else if (strAttributeName  ==  convCourseLearningCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CaseLevelId);
}
else if (strAttributeName  ==  convCourseLearningCase.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CaseLevelName);
}
else if (strAttributeName  ==  convCourseLearningCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCourseLearningCase.DocFile);
}
else if (strAttributeName  ==  convCourseLearningCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convCourseLearningCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCourseLearningCase.WordCreateDate);
}
else if (strAttributeName  ==  convCourseLearningCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsVisible);
}
else if (strAttributeName  ==  convCourseLearningCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsDualVideo);
}
else if (strAttributeName  ==  convCourseLearningCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdXzCollege);
}
else if (strAttributeName  ==  convCourseLearningCase.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CollegeId);
}
else if (strAttributeName  ==  convCourseLearningCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CollegeName);
}
else if (strAttributeName  ==  convCourseLearningCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CollegeNameA);
}
else if (strAttributeName  ==  convCourseLearningCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdXzMajor);
}
else if (strAttributeName  ==  convCourseLearningCase.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.MajorID);
}
else if (strAttributeName  ==  convCourseLearningCase.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.MajorName);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseId);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseCode);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseName);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseChapterId);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseChapterName);
}
else if (strAttributeName  ==  convCourseLearningCase.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ChapterId);
}
else if (strAttributeName  ==  convCourseLearningCase.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SectionId);
}
else if (strAttributeName  ==  convCourseLearningCase.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ChapterName);
}
else if (strAttributeName  ==  convCourseLearningCase.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SectionName);
}
else if (strAttributeName  ==  convCourseLearningCase.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ChapterNameSim);
}
else if (strAttributeName  ==  convCourseLearningCase.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SectionNameSim);
}
else if (strAttributeName  ==  convCourseLearningCase.ParentNodeId)
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ParentNodeId);
}
else if (strAttributeName  ==  convCourseLearningCase.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseChapterReferred);
}
else if (strAttributeName  ==  convCourseLearningCase.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ParentNodeName);
}
else if (strAttributeName  ==  convCourseLearningCase.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ParentNodeReferred);
}
else if (strAttributeName  ==  convCourseLearningCase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.ViewCount);
}
else if (strAttributeName  ==  convCourseLearningCase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsShow);
}
else if (strAttributeName  ==  convCourseLearningCase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.DownloadNumber);
}
else if (strAttributeName  ==  convCourseLearningCase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.FileIntegration);
}
else if (strAttributeName  ==  convCourseLearningCase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.LikeCount);
}
else if (strAttributeName  ==  convCourseLearningCase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.CollectionCount);
}
else if (strAttributeName  ==  convCourseLearningCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convCourseLearningCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convCourseLearningCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ftpFileType);
}
else if (strAttributeName  ==  convCourseLearningCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convCourseLearningCase.VideoUrl);
}
else if (strAttributeName  ==  convCourseLearningCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convCourseLearningCase.VideoPath);
}
else if (strAttributeName  ==  convCourseLearningCase.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ImageUrl);
}
else if (strAttributeName  ==  convCourseLearningCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ResErrMsg);
}
else if (strAttributeName  ==  convCourseLearningCase.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.OrderNum);
}
else if (strAttributeName  ==  convCourseLearningCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCourseLearningCase.UpdDate);
}
else if (strAttributeName  ==  convCourseLearningCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.UpdUserId);
}
else if (strAttributeName  ==  convCourseLearningCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCourseLearningCase.Memo);
}
else if (strAttributeName  ==  convCourseLearningCase.IsHaveVideo)
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IsHaveVideo);
}
else if (strAttributeName  ==  convCourseLearningCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.BrowseCount4Case);
}
else if (strAttributeName  ==  convCourseLearningCase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.OwnerName);
}
else if (strAttributeName  ==  convCourseLearningCase.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.OwnerNameWithId);
}
}
}
public object this[int intIndex]
{
get
{
if (convCourseLearningCase.IdCourseLearningCase  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCase;
}
else if (convCourseLearningCase.CourseLearningCaseID  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseID;
}
else if (convCourseLearningCase.CourseLearningCaseName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseName;
}
else if (convCourseLearningCase.CourseLearningCaseText  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseText;
}
else if (convCourseLearningCase.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTheme;
}
else if (convCourseLearningCase.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDate;
}
else if (convCourseLearningCase.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTime;
}
else if (convCourseLearningCase.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDateIn;
}
else if (convCourseLearningCase.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTimeIn;
}
else if (convCourseLearningCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convCourseLearningCase.CaseTypeName  ==  AttributeName[intIndex])
{
return mstrCaseTypeName;
}
else if (convCourseLearningCase.IdCourseLearningCaseType  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCaseType;
}
else if (convCourseLearningCase.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTypeName;
}
else if (convCourseLearningCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCourseLearningCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convCourseLearningCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convCourseLearningCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convCourseLearningCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convCourseLearningCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convCourseLearningCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convCourseLearningCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convCourseLearningCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convCourseLearningCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCourseLearningCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convCourseLearningCase.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convCourseLearningCase.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convCourseLearningCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convCourseLearningCase.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convCourseLearningCase.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convCourseLearningCase.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convCourseLearningCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convCourseLearningCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convCourseLearningCase.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convCourseLearningCase.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convCourseLearningCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convCourseLearningCase.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convCourseLearningCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convCourseLearningCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convCourseLearningCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convCourseLearningCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convCourseLearningCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCourseLearningCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCourseLearningCase.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convCourseLearningCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCourseLearningCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convCourseLearningCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCourseLearningCase.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convCourseLearningCase.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCourseLearningCase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCourseLearningCase.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCourseLearningCase.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCourseLearningCase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convCourseLearningCase.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convCourseLearningCase.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convCourseLearningCase.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convCourseLearningCase.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convCourseLearningCase.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convCourseLearningCase.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convCourseLearningCase.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convCourseLearningCase.ParentNodeId  ==  AttributeName[intIndex])
{
return mstrParentNodeId;
}
else if (convCourseLearningCase.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convCourseLearningCase.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convCourseLearningCase.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convCourseLearningCase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convCourseLearningCase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convCourseLearningCase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convCourseLearningCase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convCourseLearningCase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convCourseLearningCase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convCourseLearningCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convCourseLearningCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convCourseLearningCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convCourseLearningCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convCourseLearningCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convCourseLearningCase.ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (convCourseLearningCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convCourseLearningCase.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCourseLearningCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCourseLearningCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convCourseLearningCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCourseLearningCase.IsHaveVideo  ==  AttributeName[intIndex])
{
return mstrIsHaveVideo;
}
else if (convCourseLearningCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convCourseLearningCase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCourseLearningCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
return null;
}
set
{
if (convCourseLearningCase.IdCourseLearningCase  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdCourseLearningCase);
}
else if (convCourseLearningCase.CourseLearningCaseID  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseID);
}
else if (convCourseLearningCase.CourseLearningCaseName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseName);
}
else if (convCourseLearningCase.CourseLearningCaseText  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseText = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseText);
}
else if (convCourseLearningCase.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTheme);
}
else if (convCourseLearningCase.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseDate);
}
else if (convCourseLearningCase.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTime);
}
else if (convCourseLearningCase.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseDateIn);
}
else if (convCourseLearningCase.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTimeIn);
}
else if (convCourseLearningCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdCaseType);
}
else if (convCourseLearningCase.CaseTypeName  ==  AttributeName[intIndex])
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CaseTypeName);
}
else if (convCourseLearningCase.IdCourseLearningCaseType  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCaseType = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdCourseLearningCaseType);
}
else if (convCourseLearningCase.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTypeName);
}
else if (convCourseLearningCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.OwnerId);
}
else if (convCourseLearningCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdStudyLevel);
}
else if (convCourseLearningCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.StudyLevelName);
}
else if (convCourseLearningCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdTeachingPlan);
}
else if (convCourseLearningCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdDiscipline);
}
else if (convCourseLearningCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.DisciplineID);
}
else if (convCourseLearningCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.DisciplineName);
}
else if (convCourseLearningCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdSenateGaugeVersion);
}
else if (convCourseLearningCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionID);
}
else if (convCourseLearningCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionName);
}
else if (convCourseLearningCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionTtlScore);
}
else if (convCourseLearningCase.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsUse);
}
else if (convCourseLearningCase.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.VersionNo);
}
else if (convCourseLearningCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdTeachSkill);
}
else if (convCourseLearningCase.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.TeachSkillID);
}
else if (convCourseLearningCase.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SkillTypeName);
}
else if (convCourseLearningCase.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.TeachSkillName);
}
else if (convCourseLearningCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCourseLearningCase.TeachSkillTheory);
}
else if (convCourseLearningCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCourseLearningCase.TeachSkillOperMethod);
}
else if (convCourseLearningCase.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdSkillType);
}
else if (convCourseLearningCase.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SkillTypeID);
}
else if (convCourseLearningCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CaseLevelId);
}
else if (convCourseLearningCase.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CaseLevelName);
}
else if (convCourseLearningCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCourseLearningCase.DocFile);
}
else if (convCourseLearningCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsNeedGeneWord);
}
else if (convCourseLearningCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCourseLearningCase.WordCreateDate);
}
else if (convCourseLearningCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsVisible);
}
else if (convCourseLearningCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsDualVideo);
}
else if (convCourseLearningCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdXzCollege);
}
else if (convCourseLearningCase.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CollegeId);
}
else if (convCourseLearningCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CollegeName);
}
else if (convCourseLearningCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CollegeNameA);
}
else if (convCourseLearningCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IdXzMajor);
}
else if (convCourseLearningCase.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCourseLearningCase.MajorID);
}
else if (convCourseLearningCase.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.MajorName);
}
else if (convCourseLearningCase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseId);
}
else if (convCourseLearningCase.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseCode);
}
else if (convCourseLearningCase.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseName);
}
else if (convCourseLearningCase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseChapterId);
}
else if (convCourseLearningCase.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseChapterName);
}
else if (convCourseLearningCase.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ChapterId);
}
else if (convCourseLearningCase.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SectionId);
}
else if (convCourseLearningCase.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ChapterName);
}
else if (convCourseLearningCase.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SectionName);
}
else if (convCourseLearningCase.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ChapterNameSim);
}
else if (convCourseLearningCase.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convCourseLearningCase.SectionNameSim);
}
else if (convCourseLearningCase.ParentNodeId  ==  AttributeName[intIndex])
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ParentNodeId);
}
else if (convCourseLearningCase.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convCourseLearningCase.CourseChapterReferred);
}
else if (convCourseLearningCase.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ParentNodeName);
}
else if (convCourseLearningCase.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ParentNodeReferred);
}
else if (convCourseLearningCase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.ViewCount);
}
else if (convCourseLearningCase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCase.IsShow);
}
else if (convCourseLearningCase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.DownloadNumber);
}
else if (convCourseLearningCase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.FileIntegration);
}
else if (convCourseLearningCase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.LikeCount);
}
else if (convCourseLearningCase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.CollectionCount);
}
else if (convCourseLearningCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.RecommendedDegreeId);
}
else if (convCourseLearningCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.RecommendedDegreeName);
}
else if (convCourseLearningCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ftpFileType);
}
else if (convCourseLearningCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convCourseLearningCase.VideoUrl);
}
else if (convCourseLearningCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convCourseLearningCase.VideoPath);
}
else if (convCourseLearningCase.ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ImageUrl);
}
else if (convCourseLearningCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convCourseLearningCase.ResErrMsg);
}
else if (convCourseLearningCase.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.OrderNum);
}
else if (convCourseLearningCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCourseLearningCase.UpdDate);
}
else if (convCourseLearningCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.UpdUserId);
}
else if (convCourseLearningCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCourseLearningCase.Memo);
}
else if (convCourseLearningCase.IsHaveVideo  ==  AttributeName[intIndex])
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convCourseLearningCase.IsHaveVideo);
}
else if (convCourseLearningCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase.BrowseCount4Case);
}
else if (convCourseLearningCase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCourseLearningCase.OwnerName);
}
else if (convCourseLearningCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCourseLearningCase.OwnerNameWithId);
}
}
}

/// <summary>
/// 课程学习案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourseLearningCase
{
get
{
return mstrIdCourseLearningCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourseLearningCase = value;
}
else
{
 mstrIdCourseLearningCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.IdCourseLearningCase);
}
}
/// <summary>
/// 课程学习案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseID
{
get
{
return mstrCourseLearningCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseID = value;
}
else
{
 mstrCourseLearningCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseID);
}
}
/// <summary>
/// 课程学习案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseName
{
get
{
return mstrCourseLearningCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseName = value;
}
else
{
 mstrCourseLearningCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseText
{
get
{
return mstrCourseLearningCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseText = value;
}
else
{
 mstrCourseLearningCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseText);
}
}
/// <summary>
/// 课程学习案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTheme
{
get
{
return mstrCourseLearningCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTheme = value;
}
else
{
 mstrCourseLearningCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTheme);
}
}
/// <summary>
/// 课程学习日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseDate
{
get
{
return mstrCourseLearningCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseDate = value;
}
else
{
 mstrCourseLearningCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseDate);
}
}
/// <summary>
/// 课程学习时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTime
{
get
{
return mstrCourseLearningCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTime = value;
}
else
{
 mstrCourseLearningCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseDateIn
{
get
{
return mstrCourseLearningCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseDateIn = value;
}
else
{
 mstrCourseLearningCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTimeIn
{
get
{
return mstrCourseLearningCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTimeIn = value;
}
else
{
 mstrCourseLearningCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTimeIn);
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
 AddUpdatedFld(convCourseLearningCase.IdCaseType);
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
 AddUpdatedFld(convCourseLearningCase.CaseTypeName);
}
}
/// <summary>
/// 课程学习案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourseLearningCaseType
{
get
{
return mstrIdCourseLearningCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourseLearningCaseType = value;
}
else
{
 mstrIdCourseLearningCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.IdCourseLearningCaseType);
}
}
/// <summary>
/// 课程学习案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTypeName
{
get
{
return mstrCourseLearningCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTypeName = value;
}
else
{
 mstrCourseLearningCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseLearningCaseTypeName);
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
 AddUpdatedFld(convCourseLearningCase.OwnerId);
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
 AddUpdatedFld(convCourseLearningCase.IdStudyLevel);
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
 AddUpdatedFld(convCourseLearningCase.StudyLevelName);
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
 AddUpdatedFld(convCourseLearningCase.IdTeachingPlan);
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
 AddUpdatedFld(convCourseLearningCase.IdDiscipline);
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
 AddUpdatedFld(convCourseLearningCase.DisciplineID);
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
 AddUpdatedFld(convCourseLearningCase.DisciplineName);
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
 AddUpdatedFld(convCourseLearningCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionID);
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
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionName);
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
 AddUpdatedFld(convCourseLearningCase.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convCourseLearningCase.IsUse);
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
 AddUpdatedFld(convCourseLearningCase.VersionNo);
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
 AddUpdatedFld(convCourseLearningCase.IdTeachSkill);
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
 AddUpdatedFld(convCourseLearningCase.TeachSkillID);
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
 AddUpdatedFld(convCourseLearningCase.SkillTypeName);
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
 AddUpdatedFld(convCourseLearningCase.TeachSkillName);
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
 AddUpdatedFld(convCourseLearningCase.TeachSkillTheory);
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
 AddUpdatedFld(convCourseLearningCase.TeachSkillOperMethod);
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
 AddUpdatedFld(convCourseLearningCase.IdSkillType);
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
 AddUpdatedFld(convCourseLearningCase.SkillTypeID);
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
 AddUpdatedFld(convCourseLearningCase.CaseLevelId);
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
 AddUpdatedFld(convCourseLearningCase.CaseLevelName);
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
 AddUpdatedFld(convCourseLearningCase.DocFile);
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
 AddUpdatedFld(convCourseLearningCase.IsNeedGeneWord);
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
 AddUpdatedFld(convCourseLearningCase.WordCreateDate);
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
 AddUpdatedFld(convCourseLearningCase.IsVisible);
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
 AddUpdatedFld(convCourseLearningCase.IsDualVideo);
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
 AddUpdatedFld(convCourseLearningCase.IdXzCollege);
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
 AddUpdatedFld(convCourseLearningCase.CollegeId);
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
 AddUpdatedFld(convCourseLearningCase.CollegeName);
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
 AddUpdatedFld(convCourseLearningCase.CollegeNameA);
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
 AddUpdatedFld(convCourseLearningCase.IdXzMajor);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.MajorID);
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
 AddUpdatedFld(convCourseLearningCase.MajorName);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseId);
}
}
/// <summary>
/// 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCode
{
get
{
return mstrCourseCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCode = value;
}
else
{
 mstrCourseCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseCode);
}
}
/// <summary>
/// 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseName
{
get
{
return mstrCourseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseName = value;
}
else
{
 mstrCourseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseName);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseChapterId);
}
}
/// <summary>
/// 课程章节名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterName
{
get
{
return mstrCourseChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterName = value;
}
else
{
 mstrCourseChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseChapterName);
}
}
/// <summary>
/// 章Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterId
{
get
{
return mstrChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterId = value;
}
else
{
 mstrChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.ChapterId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.SectionId);
}
}
/// <summary>
/// 章名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterName
{
get
{
return mstrChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterName = value;
}
else
{
 mstrChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.ChapterName);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.SectionName);
}
}
/// <summary>
/// 章名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim
{
get
{
return mstrChapterNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim = value;
}
else
{
 mstrChapterNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.ChapterNameSim);
}
}
/// <summary>
/// 节名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionNameSim
{
get
{
return mstrSectionNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionNameSim = value;
}
else
{
 mstrSectionNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.SectionNameSim);
}
}
/// <summary>
/// 父节点编号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeId
{
get
{
return mstrParentNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeId = value;
}
else
{
 mstrParentNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.ParentNodeId);
}
}
/// <summary>
/// 节简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterReferred
{
get
{
return mstrCourseChapterReferred;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterReferred = value;
}
else
{
 mstrCourseChapterReferred = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CourseChapterReferred);
}
}
/// <summary>
/// 父节点名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeName
{
get
{
return mstrParentNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeName = value;
}
else
{
 mstrParentNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.ParentNodeName);
}
}
/// <summary>
/// 章简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeReferred
{
get
{
return mstrParentNodeReferred;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeReferred = value;
}
else
{
 mstrParentNodeReferred = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.ParentNodeReferred);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ViewCount
{
get
{
return mintViewCount;
}
set
{
 mintViewCount = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.ViewCount);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.IsShow);
}
}
/// <summary>
/// 下载数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadNumber
{
get
{
return mintDownloadNumber;
}
set
{
 mintDownloadNumber = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.DownloadNumber);
}
}
/// <summary>
/// 文件积分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FileIntegration
{
get
{
return mintFileIntegration;
}
set
{
 mintFileIntegration = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.FileIntegration);
}
}
/// <summary>
/// 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? LikeCount
{
get
{
return mlngLikeCount;
}
set
{
 mlngLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.LikeCount);
}
}
/// <summary>
/// 收藏数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CollectionCount
{
get
{
return mlngCollectionCount;
}
set
{
 mlngCollectionCount = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.CollectionCount);
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
 AddUpdatedFld(convCourseLearningCase.RecommendedDegreeId);
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
 AddUpdatedFld(convCourseLearningCase.RecommendedDegreeName);
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
 AddUpdatedFld(convCourseLearningCase.ftpFileType);
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
 AddUpdatedFld(convCourseLearningCase.VideoUrl);
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
 AddUpdatedFld(convCourseLearningCase.VideoPath);
}
}
/// <summary>
/// ImageUrl(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImageUrl
{
get
{
return mstrImageUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImageUrl = value;
}
else
{
 mstrImageUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.ImageUrl);
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
 AddUpdatedFld(convCourseLearningCase.ResErrMsg);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase.OrderNum);
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
 AddUpdatedFld(convCourseLearningCase.UpdDate);
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
 AddUpdatedFld(convCourseLearningCase.UpdUserId);
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
 AddUpdatedFld(convCourseLearningCase.Memo);
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
 AddUpdatedFld(convCourseLearningCase.IsHaveVideo);
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
 AddUpdatedFld(convCourseLearningCase.BrowseCount4Case);
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
 AddUpdatedFld(convCourseLearningCase.OwnerName);
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
 AddUpdatedFld(convCourseLearningCase.OwnerNameWithId);
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
  return mstrIdCourseLearningCase;
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
  return mstrCourseLearningCaseName;
 }
 }
}
 /// <summary>
 /// v课程学习案例(vCourseLearningCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCourseLearningCase
{
public const string _CurrTabName = "vCourseLearningCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCourseLearningCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseText", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "IdCaseType", "CaseTypeName", "IdCourseLearningCaseType", "CourseLearningCaseTypeName", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IsUse", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ImageUrl", "ResErrMsg", "OrderNum", "UpdDate", "UpdUserId", "Memo", "IsHaveVideo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCourseLearningCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseLearningCase = "IdCourseLearningCase";    //课程学习案例流水号

 /// <summary>
 /// 常量:"CourseLearningCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseID = "CourseLearningCaseID";    //课程学习案例ID

 /// <summary>
 /// 常量:"CourseLearningCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseName = "CourseLearningCaseName";    //课程学习案例名称

 /// <summary>
 /// 常量:"CourseLearningCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseText = "CourseLearningCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"CourseLearningCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTheme = "CourseLearningCaseTheme";    //课程学习案例主题词

 /// <summary>
 /// 常量:"CourseLearningCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseDate = "CourseLearningCaseDate";    //课程学习日期

 /// <summary>
 /// 常量:"CourseLearningCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTime = "CourseLearningCaseTime";    //课程学习时间

 /// <summary>
 /// 常量:"CourseLearningCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseDateIn = "CourseLearningCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CourseLearningCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTimeIn = "CourseLearningCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

 /// <summary>
 /// 常量:"CaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTypeName = "CaseTypeName";    //案例类型名称

 /// <summary>
 /// 常量:"IdCourseLearningCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseLearningCaseType = "IdCourseLearningCaseType";    //课程学习案例类型流水号

 /// <summary>
 /// 常量:"CourseLearningCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTypeName = "CourseLearningCaseTypeName";    //课程学习案例类型名称

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

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
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

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
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

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
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"CourseChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterName = "CourseChapterName";    //课程章节名称

 /// <summary>
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"ChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterName = "ChapterName";    //章名

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"ChapterNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim = "ChapterNameSim";    //章名简称

 /// <summary>
 /// 常量:"SectionNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionNameSim = "SectionNameSim";    //节名简称

 /// <summary>
 /// 常量:"ParentNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeId = "ParentNodeId";    //父节点编号

 /// <summary>
 /// 常量:"CourseChapterReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterReferred = "CourseChapterReferred";    //节简称

 /// <summary>
 /// 常量:"ParentNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeName = "ParentNodeName";    //父节点名称

 /// <summary>
 /// 常量:"ParentNodeReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeReferred = "ParentNodeReferred";    //章简称

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"DownloadNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadNumber = "DownloadNumber";    //下载数目

 /// <summary>
 /// 常量:"FileIntegration"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileIntegration = "FileIntegration";    //文件积分

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

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
 /// 常量:"ImageUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImageUrl = "ImageUrl";    //ImageUrl

 /// <summary>
 /// 常量:"ResErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResErrMsg = "ResErrMsg";    //资源错误信息

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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