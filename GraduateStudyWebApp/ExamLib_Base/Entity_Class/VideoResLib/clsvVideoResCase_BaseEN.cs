
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCase_BaseEN
 表名:vVideoResCase_Base(01120527)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库(VideoResLib)
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
 /// 表vVideoResCase_Base的关键字(IdVideoResCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoResCase_vVideoResCase_Base
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdVideoResCase">表关键字</param>
public K_IdVideoResCase_vVideoResCase_Base(string strIdVideoResCase)
{
if (IsValid(strIdVideoResCase)) Value = strIdVideoResCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdVideoResCase)
{
if (string.IsNullOrEmpty(strIdVideoResCase) == true) return false;
if (strIdVideoResCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdVideoResCase_vVideoResCase_Base]类型的对象</returns>
public static implicit operator K_IdVideoResCase_vVideoResCase_Base(string value)
{
return new K_IdVideoResCase_vVideoResCase_Base(value);
}
}
 /// <summary>
 /// v视频资源案例_Base(vVideoResCase_Base)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoResCase_BaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoResCase_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 68;
public static string[] AttributeName = new string[] {"IdVideoResCase", "VideoResCaseID", "VideoResCaseName", "VideoResCaseTheme", "IdVideoResCaseType", "VideoResCaseTypeName", "VideoResCaseText", "VideoResCaseDate", "VideoResCaseTime", "VideoResCaseDateIn", "VideoResCaseTimeIn", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseChapterId", "CourseChapterName", "ParentNodeID", "ParentNodeName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "CourseId", "CourseCode", "CourseName", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "OwnerName", "OwnerNameWithId", "BrowseCount4Case"};

protected string mstrIdVideoResCase;    //视频资源案例流水号
protected string mstrVideoResCaseID;    //视频资源案例ID
protected string mstrVideoResCaseName;    //视频资源案例名称
protected string mstrVideoResCaseTheme;    //视频资源案例主题词
protected string mstrIdVideoResCaseType;    //视频资源类型流水号
protected string mstrVideoResCaseTypeName;    //视频资源案例类型名称
protected string mstrVideoResCaseText;    //案例文本内容
protected string mstrVideoResCaseDate;    //视频资源日期
protected string mstrVideoResCaseTime;    //视频资源时间
protected string mstrVideoResCaseDateIn;    //案例入库日期
protected string mstrVideoResCaseTimeIn;    //案例入库时间
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
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrParentNodeID;    //父节点编号
protected string mstrParentNodeName;    //父节点名称
protected int? mintViewCount;    //浏览量
protected bool mbolIsShow;    //是否启用
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
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
 public clsvVideoResCase_BaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoResCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdVideoResCase">关键字:视频资源案例流水号</param>
public clsvVideoResCase_BaseEN(string strIdVideoResCase)
 {
strIdVideoResCase = strIdVideoResCase.Replace("'", "''");
if (strIdVideoResCase.Length > 8)
{
throw new Exception("在表:vVideoResCase_Base中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdVideoResCase)  ==  true)
{
throw new Exception("在表:vVideoResCase_Base中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdVideoResCase = strIdVideoResCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoResCase");
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
if (strAttributeName  ==  convVideoResCase_Base.IdVideoResCase)
{
return mstrIdVideoResCase;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseID)
{
return mstrVideoResCaseID;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseName)
{
return mstrVideoResCaseName;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseTheme)
{
return mstrVideoResCaseTheme;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdVideoResCaseType)
{
return mstrIdVideoResCaseType;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseTypeName)
{
return mstrVideoResCaseTypeName;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseText)
{
return mstrVideoResCaseText;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseDate)
{
return mstrVideoResCaseDate;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseTime)
{
return mstrVideoResCaseTime;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseDateIn)
{
return mstrVideoResCaseDateIn;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseTimeIn)
{
return mstrVideoResCaseTimeIn;
}
else if (strAttributeName  ==  convVideoResCase_Base.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convVideoResCase_Base.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convVideoResCase_Base.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convVideoResCase_Base.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convVideoResCase_Base.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convVideoResCase_Base.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convVideoResCase_Base.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convVideoResCase_Base.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convVideoResCase_Base.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convVideoResCase_Base.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convVideoResCase_Base.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convVideoResCase_Base.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convVideoResCase_Base.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convVideoResCase_Base.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convVideoResCase_Base.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convVideoResCase_Base.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convVideoResCase_Base.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convVideoResCase_Base.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convVideoResCase_Base.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convVideoResCase_Base.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convVideoResCase_Base.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convVideoResCase_Base.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convVideoResCase_Base.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convVideoResCase_Base.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convVideoResCase_Base.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convVideoResCase_Base.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convVideoResCase_Base.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convVideoResCase_Base.ParentNodeID)
{
return mstrParentNodeID;
}
else if (strAttributeName  ==  convVideoResCase_Base.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convVideoResCase_Base.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convVideoResCase_Base.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convVideoResCase_Base.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convVideoResCase_Base.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convVideoResCase_Base.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convVideoResCase_Base.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convVideoResCase_Base.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convVideoResCase_Base.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convVideoResCase_Base.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convVideoResCase_Base.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convVideoResCase_Base.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convVideoResCase_Base.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convVideoResCase_Base.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convVideoResCase_Base.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoResCase_Base.IdVideoResCase)
{
mstrIdVideoResCase = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdVideoResCase);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseID)
{
mstrVideoResCaseID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseID);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseName)
{
mstrVideoResCaseName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseName);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseTheme)
{
mstrVideoResCaseTheme = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTheme);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdVideoResCaseType)
{
mstrIdVideoResCaseType = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdVideoResCaseType);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseTypeName)
{
mstrVideoResCaseTypeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTypeName);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseText)
{
mstrVideoResCaseText = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseText);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseDate)
{
mstrVideoResCaseDate = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseDate);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseTime)
{
mstrVideoResCaseTime = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTime);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseDateIn)
{
mstrVideoResCaseDateIn = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseDateIn);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoResCaseTimeIn)
{
mstrVideoResCaseTimeIn = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTimeIn);
}
else if (strAttributeName  ==  convVideoResCase_Base.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.OwnerId);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdStudyLevel);
}
else if (strAttributeName  ==  convVideoResCase_Base.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.StudyLevelName);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdTeachingPlan);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdDiscipline);
}
else if (strAttributeName  ==  convVideoResCase_Base.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.DisciplineID);
}
else if (strAttributeName  ==  convVideoResCase_Base.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.DisciplineName);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convVideoResCase_Base.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionID);
}
else if (strAttributeName  ==  convVideoResCase_Base.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionName);
}
else if (strAttributeName  ==  convVideoResCase_Base.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convVideoResCase_Base.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.VersionNo);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdTeachSkill);
}
else if (strAttributeName  ==  convVideoResCase_Base.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.TeachSkillID);
}
else if (strAttributeName  ==  convVideoResCase_Base.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.SkillTypeName);
}
else if (strAttributeName  ==  convVideoResCase_Base.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.TeachSkillName);
}
else if (strAttributeName  ==  convVideoResCase_Base.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.TeachSkillTheory);
}
else if (strAttributeName  ==  convVideoResCase_Base.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdSkillType);
}
else if (strAttributeName  ==  convVideoResCase_Base.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.SkillTypeID);
}
else if (strAttributeName  ==  convVideoResCase_Base.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CaseLevelId);
}
else if (strAttributeName  ==  convVideoResCase_Base.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CaseLevelName);
}
else if (strAttributeName  ==  convVideoResCase_Base.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.DocFile);
}
else if (strAttributeName  ==  convVideoResCase_Base.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.IsNeedGeneWord);
}
else if (strAttributeName  ==  convVideoResCase_Base.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.WordCreateDate);
}
else if (strAttributeName  ==  convVideoResCase_Base.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.IsVisible);
}
else if (strAttributeName  ==  convVideoResCase_Base.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.IsDualVideo);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdXzCollege);
}
else if (strAttributeName  ==  convVideoResCase_Base.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CollegeID);
}
else if (strAttributeName  ==  convVideoResCase_Base.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CollegeName);
}
else if (strAttributeName  ==  convVideoResCase_Base.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CollegeNameA);
}
else if (strAttributeName  ==  convVideoResCase_Base.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdXzMajor);
}
else if (strAttributeName  ==  convVideoResCase_Base.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.MajorID);
}
else if (strAttributeName  ==  convVideoResCase_Base.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.MajorName);
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseChapterId);
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseChapterName);
}
else if (strAttributeName  ==  convVideoResCase_Base.ParentNodeID)
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.ParentNodeID);
}
else if (strAttributeName  ==  convVideoResCase_Base.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.ParentNodeName);
}
else if (strAttributeName  ==  convVideoResCase_Base.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.ViewCount);
}
else if (strAttributeName  ==  convVideoResCase_Base.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.IsShow);
}
else if (strAttributeName  ==  convVideoResCase_Base.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.DownloadNumber);
}
else if (strAttributeName  ==  convVideoResCase_Base.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.FileIntegration);
}
else if (strAttributeName  ==  convVideoResCase_Base.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.LikeCount);
}
else if (strAttributeName  ==  convVideoResCase_Base.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.CollectionCount);
}
else if (strAttributeName  ==  convVideoResCase_Base.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.RecommendedDegreeId);
}
else if (strAttributeName  ==  convVideoResCase_Base.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.RecommendedDegreeName);
}
else if (strAttributeName  ==  convVideoResCase_Base.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.ftpFileType);
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseId);
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseCode);
}
else if (strAttributeName  ==  convVideoResCase_Base.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseName);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoUrl);
}
else if (strAttributeName  ==  convVideoResCase_Base.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoPath);
}
else if (strAttributeName  ==  convVideoResCase_Base.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.ResErrMsg);
}
else if (strAttributeName  ==  convVideoResCase_Base.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.Memo);
}
else if (strAttributeName  ==  convVideoResCase_Base.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.OwnerName);
}
else if (strAttributeName  ==  convVideoResCase_Base.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.OwnerNameWithId);
}
else if (strAttributeName  ==  convVideoResCase_Base.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.BrowseCount4Case);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoResCase_Base.IdVideoResCase  ==  AttributeName[intIndex])
{
return mstrIdVideoResCase;
}
else if (convVideoResCase_Base.VideoResCaseID  ==  AttributeName[intIndex])
{
return mstrVideoResCaseID;
}
else if (convVideoResCase_Base.VideoResCaseName  ==  AttributeName[intIndex])
{
return mstrVideoResCaseName;
}
else if (convVideoResCase_Base.VideoResCaseTheme  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTheme;
}
else if (convVideoResCase_Base.IdVideoResCaseType  ==  AttributeName[intIndex])
{
return mstrIdVideoResCaseType;
}
else if (convVideoResCase_Base.VideoResCaseTypeName  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTypeName;
}
else if (convVideoResCase_Base.VideoResCaseText  ==  AttributeName[intIndex])
{
return mstrVideoResCaseText;
}
else if (convVideoResCase_Base.VideoResCaseDate  ==  AttributeName[intIndex])
{
return mstrVideoResCaseDate;
}
else if (convVideoResCase_Base.VideoResCaseTime  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTime;
}
else if (convVideoResCase_Base.VideoResCaseDateIn  ==  AttributeName[intIndex])
{
return mstrVideoResCaseDateIn;
}
else if (convVideoResCase_Base.VideoResCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTimeIn;
}
else if (convVideoResCase_Base.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convVideoResCase_Base.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convVideoResCase_Base.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convVideoResCase_Base.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convVideoResCase_Base.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convVideoResCase_Base.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convVideoResCase_Base.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convVideoResCase_Base.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convVideoResCase_Base.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convVideoResCase_Base.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convVideoResCase_Base.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convVideoResCase_Base.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convVideoResCase_Base.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convVideoResCase_Base.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convVideoResCase_Base.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convVideoResCase_Base.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convVideoResCase_Base.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convVideoResCase_Base.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convVideoResCase_Base.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convVideoResCase_Base.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convVideoResCase_Base.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convVideoResCase_Base.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convVideoResCase_Base.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convVideoResCase_Base.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convVideoResCase_Base.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convVideoResCase_Base.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convVideoResCase_Base.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convVideoResCase_Base.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convVideoResCase_Base.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convVideoResCase_Base.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convVideoResCase_Base.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convVideoResCase_Base.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convVideoResCase_Base.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convVideoResCase_Base.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convVideoResCase_Base.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convVideoResCase_Base.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convVideoResCase_Base.ParentNodeID  ==  AttributeName[intIndex])
{
return mstrParentNodeID;
}
else if (convVideoResCase_Base.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convVideoResCase_Base.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convVideoResCase_Base.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convVideoResCase_Base.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convVideoResCase_Base.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convVideoResCase_Base.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convVideoResCase_Base.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convVideoResCase_Base.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convVideoResCase_Base.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convVideoResCase_Base.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convVideoResCase_Base.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convVideoResCase_Base.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convVideoResCase_Base.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convVideoResCase_Base.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convVideoResCase_Base.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convVideoResCase_Base.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convVideoResCase_Base.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convVideoResCase_Base.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convVideoResCase_Base.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convVideoResCase_Base.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (convVideoResCase_Base.IdVideoResCase  ==  AttributeName[intIndex])
{
mstrIdVideoResCase = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdVideoResCase);
}
else if (convVideoResCase_Base.VideoResCaseID  ==  AttributeName[intIndex])
{
mstrVideoResCaseID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseID);
}
else if (convVideoResCase_Base.VideoResCaseName  ==  AttributeName[intIndex])
{
mstrVideoResCaseName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseName);
}
else if (convVideoResCase_Base.VideoResCaseTheme  ==  AttributeName[intIndex])
{
mstrVideoResCaseTheme = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTheme);
}
else if (convVideoResCase_Base.IdVideoResCaseType  ==  AttributeName[intIndex])
{
mstrIdVideoResCaseType = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdVideoResCaseType);
}
else if (convVideoResCase_Base.VideoResCaseTypeName  ==  AttributeName[intIndex])
{
mstrVideoResCaseTypeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTypeName);
}
else if (convVideoResCase_Base.VideoResCaseText  ==  AttributeName[intIndex])
{
mstrVideoResCaseText = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseText);
}
else if (convVideoResCase_Base.VideoResCaseDate  ==  AttributeName[intIndex])
{
mstrVideoResCaseDate = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseDate);
}
else if (convVideoResCase_Base.VideoResCaseTime  ==  AttributeName[intIndex])
{
mstrVideoResCaseTime = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTime);
}
else if (convVideoResCase_Base.VideoResCaseDateIn  ==  AttributeName[intIndex])
{
mstrVideoResCaseDateIn = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseDateIn);
}
else if (convVideoResCase_Base.VideoResCaseTimeIn  ==  AttributeName[intIndex])
{
mstrVideoResCaseTimeIn = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTimeIn);
}
else if (convVideoResCase_Base.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.OwnerId);
}
else if (convVideoResCase_Base.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdStudyLevel);
}
else if (convVideoResCase_Base.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.StudyLevelName);
}
else if (convVideoResCase_Base.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdTeachingPlan);
}
else if (convVideoResCase_Base.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdDiscipline);
}
else if (convVideoResCase_Base.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.DisciplineID);
}
else if (convVideoResCase_Base.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.DisciplineName);
}
else if (convVideoResCase_Base.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdSenateGaugeVersion);
}
else if (convVideoResCase_Base.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionID);
}
else if (convVideoResCase_Base.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionName);
}
else if (convVideoResCase_Base.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionTtlScore);
}
else if (convVideoResCase_Base.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.VersionNo);
}
else if (convVideoResCase_Base.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdTeachSkill);
}
else if (convVideoResCase_Base.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.TeachSkillID);
}
else if (convVideoResCase_Base.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.SkillTypeName);
}
else if (convVideoResCase_Base.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.TeachSkillName);
}
else if (convVideoResCase_Base.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.TeachSkillTheory);
}
else if (convVideoResCase_Base.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.TeachSkillOperMethod);
}
else if (convVideoResCase_Base.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdSkillType);
}
else if (convVideoResCase_Base.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.SkillTypeID);
}
else if (convVideoResCase_Base.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CaseLevelId);
}
else if (convVideoResCase_Base.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CaseLevelName);
}
else if (convVideoResCase_Base.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.DocFile);
}
else if (convVideoResCase_Base.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.IsNeedGeneWord);
}
else if (convVideoResCase_Base.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.WordCreateDate);
}
else if (convVideoResCase_Base.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.IsVisible);
}
else if (convVideoResCase_Base.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.IsDualVideo);
}
else if (convVideoResCase_Base.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdXzCollege);
}
else if (convVideoResCase_Base.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CollegeID);
}
else if (convVideoResCase_Base.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CollegeName);
}
else if (convVideoResCase_Base.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CollegeNameA);
}
else if (convVideoResCase_Base.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.IdXzMajor);
}
else if (convVideoResCase_Base.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.MajorID);
}
else if (convVideoResCase_Base.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.MajorName);
}
else if (convVideoResCase_Base.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseChapterId);
}
else if (convVideoResCase_Base.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseChapterName);
}
else if (convVideoResCase_Base.ParentNodeID  ==  AttributeName[intIndex])
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.ParentNodeID);
}
else if (convVideoResCase_Base.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.ParentNodeName);
}
else if (convVideoResCase_Base.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.ViewCount);
}
else if (convVideoResCase_Base.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.IsShow);
}
else if (convVideoResCase_Base.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.DownloadNumber);
}
else if (convVideoResCase_Base.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.FileIntegration);
}
else if (convVideoResCase_Base.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.LikeCount);
}
else if (convVideoResCase_Base.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.CollectionCount);
}
else if (convVideoResCase_Base.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.RecommendedDegreeId);
}
else if (convVideoResCase_Base.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.RecommendedDegreeName);
}
else if (convVideoResCase_Base.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.ftpFileType);
}
else if (convVideoResCase_Base.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseId);
}
else if (convVideoResCase_Base.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseCode);
}
else if (convVideoResCase_Base.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.CourseName);
}
else if (convVideoResCase_Base.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoUrl);
}
else if (convVideoResCase_Base.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.VideoPath);
}
else if (convVideoResCase_Base.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.ResErrMsg);
}
else if (convVideoResCase_Base.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.Memo);
}
else if (convVideoResCase_Base.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.OwnerName);
}
else if (convVideoResCase_Base.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convVideoResCase_Base.OwnerNameWithId);
}
else if (convVideoResCase_Base.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCase_Base.BrowseCount4Case);
}
}
}

/// <summary>
/// 视频资源案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdVideoResCase
{
get
{
return mstrIdVideoResCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdVideoResCase = value;
}
else
{
 mstrIdVideoResCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.IdVideoResCase);
}
}
/// <summary>
/// 视频资源案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseID
{
get
{
return mstrVideoResCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseID = value;
}
else
{
 mstrVideoResCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseID);
}
}
/// <summary>
/// 视频资源案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseName
{
get
{
return mstrVideoResCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseName = value;
}
else
{
 mstrVideoResCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseName);
}
}
/// <summary>
/// 视频资源案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseTheme
{
get
{
return mstrVideoResCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseTheme = value;
}
else
{
 mstrVideoResCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTheme);
}
}
/// <summary>
/// 视频资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdVideoResCaseType
{
get
{
return mstrIdVideoResCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdVideoResCaseType = value;
}
else
{
 mstrIdVideoResCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.IdVideoResCaseType);
}
}
/// <summary>
/// 视频资源案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseTypeName
{
get
{
return mstrVideoResCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseTypeName = value;
}
else
{
 mstrVideoResCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTypeName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseText
{
get
{
return mstrVideoResCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseText = value;
}
else
{
 mstrVideoResCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseText);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseDate
{
get
{
return mstrVideoResCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseDate = value;
}
else
{
 mstrVideoResCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseDate);
}
}
/// <summary>
/// 视频资源时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseTime
{
get
{
return mstrVideoResCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseTime = value;
}
else
{
 mstrVideoResCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseDateIn
{
get
{
return mstrVideoResCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseDateIn = value;
}
else
{
 mstrVideoResCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseTimeIn
{
get
{
return mstrVideoResCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseTimeIn = value;
}
else
{
 mstrVideoResCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.VideoResCaseTimeIn);
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
 AddUpdatedFld(convVideoResCase_Base.OwnerId);
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
 AddUpdatedFld(convVideoResCase_Base.IdStudyLevel);
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
 AddUpdatedFld(convVideoResCase_Base.StudyLevelName);
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
 AddUpdatedFld(convVideoResCase_Base.IdTeachingPlan);
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
 AddUpdatedFld(convVideoResCase_Base.IdDiscipline);
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
 AddUpdatedFld(convVideoResCase_Base.DisciplineID);
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
 AddUpdatedFld(convVideoResCase_Base.DisciplineName);
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
 AddUpdatedFld(convVideoResCase_Base.IdSenateGaugeVersion);
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
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionID);
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
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionName);
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
 AddUpdatedFld(convVideoResCase_Base.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convVideoResCase_Base.VersionNo);
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
 AddUpdatedFld(convVideoResCase_Base.IdTeachSkill);
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
 AddUpdatedFld(convVideoResCase_Base.TeachSkillID);
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
 AddUpdatedFld(convVideoResCase_Base.SkillTypeName);
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
 AddUpdatedFld(convVideoResCase_Base.TeachSkillName);
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
 AddUpdatedFld(convVideoResCase_Base.TeachSkillTheory);
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
 AddUpdatedFld(convVideoResCase_Base.TeachSkillOperMethod);
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
 AddUpdatedFld(convVideoResCase_Base.IdSkillType);
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
 AddUpdatedFld(convVideoResCase_Base.SkillTypeID);
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
 AddUpdatedFld(convVideoResCase_Base.CaseLevelId);
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
 AddUpdatedFld(convVideoResCase_Base.CaseLevelName);
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
 AddUpdatedFld(convVideoResCase_Base.DocFile);
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
 AddUpdatedFld(convVideoResCase_Base.IsNeedGeneWord);
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
 AddUpdatedFld(convVideoResCase_Base.WordCreateDate);
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
 AddUpdatedFld(convVideoResCase_Base.IsVisible);
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
 AddUpdatedFld(convVideoResCase_Base.IsDualVideo);
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
 AddUpdatedFld(convVideoResCase_Base.IdXzCollege);
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
 AddUpdatedFld(convVideoResCase_Base.CollegeID);
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
 AddUpdatedFld(convVideoResCase_Base.CollegeName);
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
 AddUpdatedFld(convVideoResCase_Base.CollegeNameA);
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
 AddUpdatedFld(convVideoResCase_Base.IdXzMajor);
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
 AddUpdatedFld(convVideoResCase_Base.MajorID);
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
 AddUpdatedFld(convVideoResCase_Base.MajorName);
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
 AddUpdatedFld(convVideoResCase_Base.CourseChapterId);
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
 AddUpdatedFld(convVideoResCase_Base.CourseChapterName);
}
}
/// <summary>
/// 父节点编号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeID
{
get
{
return mstrParentNodeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeID = value;
}
else
{
 mstrParentNodeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCase_Base.ParentNodeID);
}
}
/// <summary>
/// 父节点名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
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
 AddUpdatedFld(convVideoResCase_Base.ParentNodeName);
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
 AddUpdatedFld(convVideoResCase_Base.ViewCount);
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
 AddUpdatedFld(convVideoResCase_Base.IsShow);
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
 AddUpdatedFld(convVideoResCase_Base.DownloadNumber);
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
 AddUpdatedFld(convVideoResCase_Base.FileIntegration);
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
 AddUpdatedFld(convVideoResCase_Base.LikeCount);
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
 AddUpdatedFld(convVideoResCase_Base.CollectionCount);
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
 AddUpdatedFld(convVideoResCase_Base.RecommendedDegreeId);
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
 AddUpdatedFld(convVideoResCase_Base.RecommendedDegreeName);
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
 AddUpdatedFld(convVideoResCase_Base.ftpFileType);
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
 AddUpdatedFld(convVideoResCase_Base.CourseId);
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
 AddUpdatedFld(convVideoResCase_Base.CourseCode);
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
 AddUpdatedFld(convVideoResCase_Base.CourseName);
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
 AddUpdatedFld(convVideoResCase_Base.VideoUrl);
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
 AddUpdatedFld(convVideoResCase_Base.VideoPath);
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
 AddUpdatedFld(convVideoResCase_Base.ResErrMsg);
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
 AddUpdatedFld(convVideoResCase_Base.Memo);
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
 AddUpdatedFld(convVideoResCase_Base.OwnerName);
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
 AddUpdatedFld(convVideoResCase_Base.OwnerNameWithId);
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
 AddUpdatedFld(convVideoResCase_Base.BrowseCount4Case);
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
  return mstrIdVideoResCase;
 }
 }
}
 /// <summary>
 /// v视频资源案例_Base(vVideoResCase_Base)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoResCase_Base
{
public const string _CurrTabName = "vVideoResCase_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoResCase", "VideoResCaseID", "VideoResCaseName", "VideoResCaseTheme", "IdVideoResCaseType", "VideoResCaseTypeName", "VideoResCaseText", "VideoResCaseDate", "VideoResCaseTime", "VideoResCaseDateIn", "VideoResCaseTimeIn", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseChapterId", "CourseChapterName", "ParentNodeID", "ParentNodeName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "CourseId", "CourseCode", "CourseName", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "OwnerName", "OwnerNameWithId", "BrowseCount4Case"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdVideoResCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoResCase = "IdVideoResCase";    //视频资源案例流水号

 /// <summary>
 /// 常量:"VideoResCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseID = "VideoResCaseID";    //视频资源案例ID

 /// <summary>
 /// 常量:"VideoResCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseName = "VideoResCaseName";    //视频资源案例名称

 /// <summary>
 /// 常量:"VideoResCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseTheme = "VideoResCaseTheme";    //视频资源案例主题词

 /// <summary>
 /// 常量:"IdVideoResCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoResCaseType = "IdVideoResCaseType";    //视频资源类型流水号

 /// <summary>
 /// 常量:"VideoResCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseTypeName = "VideoResCaseTypeName";    //视频资源案例类型名称

 /// <summary>
 /// 常量:"VideoResCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseText = "VideoResCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"VideoResCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseDate = "VideoResCaseDate";    //视频资源日期

 /// <summary>
 /// 常量:"VideoResCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseTime = "VideoResCaseTime";    //视频资源时间

 /// <summary>
 /// 常量:"VideoResCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseDateIn = "VideoResCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"VideoResCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseTimeIn = "VideoResCaseTimeIn";    //案例入库时间

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
 /// 常量:"ParentNodeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeID = "ParentNodeID";    //父节点编号

 /// <summary>
 /// 常量:"ParentNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeName = "ParentNodeName";    //父节点名称

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