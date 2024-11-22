
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseEN
 表名:vCoursewareResCase(01120419)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库(CoursewareResLib)
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
 /// 表vCoursewareResCase的关键字(IdCoursewareResCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCoursewareResCase_vCoursewareResCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCoursewareResCase">表关键字</param>
public K_IdCoursewareResCase_vCoursewareResCase(string strIdCoursewareResCase)
{
if (IsValid(strIdCoursewareResCase)) Value = strIdCoursewareResCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCoursewareResCase)
{
if (string.IsNullOrEmpty(strIdCoursewareResCase) == true) return false;
if (strIdCoursewareResCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCoursewareResCase_vCoursewareResCase]类型的对象</returns>
public static implicit operator K_IdCoursewareResCase_vCoursewareResCase(string value)
{
return new K_IdCoursewareResCase_vCoursewareResCase(value);
}
}
 /// <summary>
 /// v课件资源案例(vCoursewareResCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCoursewareResCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCoursewareResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCoursewareResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 71;
public static string[] AttributeName = new string[] {"IdCoursewareResCase", "CoursewareResCaseID", "CoursewareResCaseName", "CoursewareResCaseTheme", "CoursewareResCaseText", "IdCoursewareResCaseType", "CoursewareResCaseTypeName", "CoursewareResCaseDate", "CoursewareResCaseTime", "CoursewareResCaseDateIn", "CoursewareResCaseTimeIn", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseChapterId", "CourseChapterName", "ParentNodeID", "ParentNodeName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "CourseId", "CourseCode", "CourseName", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo", "OwnerNameWithId", "OwnerName", "BrowseCount4Case", "IsHaveVideo"};

protected string mstrIdCoursewareResCase;    //课件资源案例流水号
protected string mstrCoursewareResCaseID;    //课件资源案例ID
protected string mstrCoursewareResCaseName;    //课件资源案例名称
protected string mstrCoursewareResCaseTheme;    //课件资源案例主题词
protected string mstrCoursewareResCaseText;    //案例文本内容
protected string mstrIdCoursewareResCaseType;    //课件资源类型流水号
protected string mstrCoursewareResCaseTypeName;    //课件资源案例类型名称
protected string mstrCoursewareResCaseDate;    //视频资源日期
protected string mstrCoursewareResCaseTime;    //视频资源时间
protected string mstrCoursewareResCaseDateIn;    //案例入库日期
protected string mstrCoursewareResCaseTimeIn;    //案例入库时间
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
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrOwnerName;    //拥有者姓名
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrIsHaveVideo;    //IsHaveVideo

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCoursewareResCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareResCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCoursewareResCase">关键字:课件资源案例流水号</param>
public clsvCoursewareResCaseEN(string strIdCoursewareResCase)
 {
strIdCoursewareResCase = strIdCoursewareResCase.Replace("'", "''");
if (strIdCoursewareResCase.Length > 8)
{
throw new Exception("在表:vCoursewareResCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCoursewareResCase)  ==  true)
{
throw new Exception("在表:vCoursewareResCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCoursewareResCase = strIdCoursewareResCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareResCase");
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
if (strAttributeName  ==  convCoursewareResCase.IdCoursewareResCase)
{
return mstrIdCoursewareResCase;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseID)
{
return mstrCoursewareResCaseID;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseName)
{
return mstrCoursewareResCaseName;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseTheme)
{
return mstrCoursewareResCaseTheme;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseText)
{
return mstrCoursewareResCaseText;
}
else if (strAttributeName  ==  convCoursewareResCase.IdCoursewareResCaseType)
{
return mstrIdCoursewareResCaseType;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseTypeName)
{
return mstrCoursewareResCaseTypeName;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseDate)
{
return mstrCoursewareResCaseDate;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseTime)
{
return mstrCoursewareResCaseTime;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseDateIn)
{
return mstrCoursewareResCaseDateIn;
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseTimeIn)
{
return mstrCoursewareResCaseTimeIn;
}
else if (strAttributeName  ==  convCoursewareResCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCoursewareResCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convCoursewareResCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convCoursewareResCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convCoursewareResCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convCoursewareResCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convCoursewareResCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convCoursewareResCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convCoursewareResCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convCoursewareResCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCoursewareResCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convCoursewareResCase.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convCoursewareResCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convCoursewareResCase.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convCoursewareResCase.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convCoursewareResCase.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convCoursewareResCase.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convCoursewareResCase.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convCoursewareResCase.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convCoursewareResCase.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convCoursewareResCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convCoursewareResCase.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convCoursewareResCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convCoursewareResCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convCoursewareResCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convCoursewareResCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convCoursewareResCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCoursewareResCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCoursewareResCase.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convCoursewareResCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCoursewareResCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convCoursewareResCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCoursewareResCase.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convCoursewareResCase.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCoursewareResCase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convCoursewareResCase.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convCoursewareResCase.ParentNodeID)
{
return mstrParentNodeID;
}
else if (strAttributeName  ==  convCoursewareResCase.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convCoursewareResCase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convCoursewareResCase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convCoursewareResCase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convCoursewareResCase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convCoursewareResCase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convCoursewareResCase.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convCoursewareResCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convCoursewareResCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convCoursewareResCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convCoursewareResCase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCoursewareResCase.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCoursewareResCase.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCoursewareResCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convCoursewareResCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convCoursewareResCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convCoursewareResCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCoursewareResCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convCoursewareResCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCoursewareResCase.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convCoursewareResCase.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCoursewareResCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convCoursewareResCase.IsHaveVideo)
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (strAttributeName  ==  convCoursewareResCase.IdCoursewareResCase)
{
mstrIdCoursewareResCase = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdCoursewareResCase);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseID)
{
mstrCoursewareResCaseID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseID);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseName)
{
mstrCoursewareResCaseName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseName);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseTheme)
{
mstrCoursewareResCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTheme);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseText)
{
mstrCoursewareResCaseText = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseText);
}
else if (strAttributeName  ==  convCoursewareResCase.IdCoursewareResCaseType)
{
mstrIdCoursewareResCaseType = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdCoursewareResCaseType);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseTypeName)
{
mstrCoursewareResCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTypeName);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseDate)
{
mstrCoursewareResCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseDate);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseTime)
{
mstrCoursewareResCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTime);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseDateIn)
{
mstrCoursewareResCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseDateIn);
}
else if (strAttributeName  ==  convCoursewareResCase.CoursewareResCaseTimeIn)
{
mstrCoursewareResCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTimeIn);
}
else if (strAttributeName  ==  convCoursewareResCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.OwnerId);
}
else if (strAttributeName  ==  convCoursewareResCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdStudyLevel);
}
else if (strAttributeName  ==  convCoursewareResCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.StudyLevelName);
}
else if (strAttributeName  ==  convCoursewareResCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convCoursewareResCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdDiscipline);
}
else if (strAttributeName  ==  convCoursewareResCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.DisciplineID);
}
else if (strAttributeName  ==  convCoursewareResCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.DisciplineName);
}
else if (strAttributeName  ==  convCoursewareResCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convCoursewareResCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convCoursewareResCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCoursewareResCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convCoursewareResCase.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.VersionNo);
}
else if (strAttributeName  ==  convCoursewareResCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdTeachSkill);
}
else if (strAttributeName  ==  convCoursewareResCase.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.TeachSkillID);
}
else if (strAttributeName  ==  convCoursewareResCase.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.SkillTypeName);
}
else if (strAttributeName  ==  convCoursewareResCase.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.TeachSkillName);
}
else if (strAttributeName  ==  convCoursewareResCase.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCoursewareResCase.TeachSkillTheory);
}
else if (strAttributeName  ==  convCoursewareResCase.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCoursewareResCase.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convCoursewareResCase.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdSkillType);
}
else if (strAttributeName  ==  convCoursewareResCase.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.SkillTypeID);
}
else if (strAttributeName  ==  convCoursewareResCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CaseLevelId);
}
else if (strAttributeName  ==  convCoursewareResCase.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CaseLevelName);
}
else if (strAttributeName  ==  convCoursewareResCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCoursewareResCase.DocFile);
}
else if (strAttributeName  ==  convCoursewareResCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convCoursewareResCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCoursewareResCase.WordCreateDate);
}
else if (strAttributeName  ==  convCoursewareResCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCase.IsVisible);
}
else if (strAttributeName  ==  convCoursewareResCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCase.IsDualVideo);
}
else if (strAttributeName  ==  convCoursewareResCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdXzCollege);
}
else if (strAttributeName  ==  convCoursewareResCase.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CollegeID);
}
else if (strAttributeName  ==  convCoursewareResCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CollegeName);
}
else if (strAttributeName  ==  convCoursewareResCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CollegeNameA);
}
else if (strAttributeName  ==  convCoursewareResCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdXzMajor);
}
else if (strAttributeName  ==  convCoursewareResCase.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.MajorID);
}
else if (strAttributeName  ==  convCoursewareResCase.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.MajorName);
}
else if (strAttributeName  ==  convCoursewareResCase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseChapterId);
}
else if (strAttributeName  ==  convCoursewareResCase.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseChapterName);
}
else if (strAttributeName  ==  convCoursewareResCase.ParentNodeID)
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.ParentNodeID);
}
else if (strAttributeName  ==  convCoursewareResCase.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.ParentNodeName);
}
else if (strAttributeName  ==  convCoursewareResCase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.ViewCount);
}
else if (strAttributeName  ==  convCoursewareResCase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCase.IsShow);
}
else if (strAttributeName  ==  convCoursewareResCase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.DownloadNumber);
}
else if (strAttributeName  ==  convCoursewareResCase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.FileIntegration);
}
else if (strAttributeName  ==  convCoursewareResCase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.LikeCount);
}
else if (strAttributeName  ==  convCoursewareResCase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.CollectionCount);
}
else if (strAttributeName  ==  convCoursewareResCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convCoursewareResCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convCoursewareResCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convCoursewareResCase.ftpFileType);
}
else if (strAttributeName  ==  convCoursewareResCase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseId);
}
else if (strAttributeName  ==  convCoursewareResCase.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseCode);
}
else if (strAttributeName  ==  convCoursewareResCase.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseName);
}
else if (strAttributeName  ==  convCoursewareResCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convCoursewareResCase.VideoUrl);
}
else if (strAttributeName  ==  convCoursewareResCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convCoursewareResCase.VideoPath);
}
else if (strAttributeName  ==  convCoursewareResCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convCoursewareResCase.ResErrMsg);
}
else if (strAttributeName  ==  convCoursewareResCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCoursewareResCase.UpdDate);
}
else if (strAttributeName  ==  convCoursewareResCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.UpdUserId);
}
else if (strAttributeName  ==  convCoursewareResCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareResCase.Memo);
}
else if (strAttributeName  ==  convCoursewareResCase.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.OwnerNameWithId);
}
else if (strAttributeName  ==  convCoursewareResCase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.OwnerName);
}
else if (strAttributeName  ==  convCoursewareResCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.BrowseCount4Case);
}
else if (strAttributeName  ==  convCoursewareResCase.IsHaveVideo)
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IsHaveVideo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCoursewareResCase.IdCoursewareResCase  ==  AttributeName[intIndex])
{
return mstrIdCoursewareResCase;
}
else if (convCoursewareResCase.CoursewareResCaseID  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseID;
}
else if (convCoursewareResCase.CoursewareResCaseName  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseName;
}
else if (convCoursewareResCase.CoursewareResCaseTheme  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTheme;
}
else if (convCoursewareResCase.CoursewareResCaseText  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseText;
}
else if (convCoursewareResCase.IdCoursewareResCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareResCaseType;
}
else if (convCoursewareResCase.CoursewareResCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTypeName;
}
else if (convCoursewareResCase.CoursewareResCaseDate  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseDate;
}
else if (convCoursewareResCase.CoursewareResCaseTime  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTime;
}
else if (convCoursewareResCase.CoursewareResCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseDateIn;
}
else if (convCoursewareResCase.CoursewareResCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTimeIn;
}
else if (convCoursewareResCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCoursewareResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convCoursewareResCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convCoursewareResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convCoursewareResCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convCoursewareResCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convCoursewareResCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convCoursewareResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convCoursewareResCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convCoursewareResCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCoursewareResCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convCoursewareResCase.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convCoursewareResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convCoursewareResCase.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convCoursewareResCase.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convCoursewareResCase.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convCoursewareResCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convCoursewareResCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convCoursewareResCase.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convCoursewareResCase.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convCoursewareResCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convCoursewareResCase.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convCoursewareResCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convCoursewareResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convCoursewareResCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convCoursewareResCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convCoursewareResCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCoursewareResCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCoursewareResCase.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convCoursewareResCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCoursewareResCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convCoursewareResCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCoursewareResCase.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convCoursewareResCase.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCoursewareResCase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convCoursewareResCase.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convCoursewareResCase.ParentNodeID  ==  AttributeName[intIndex])
{
return mstrParentNodeID;
}
else if (convCoursewareResCase.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convCoursewareResCase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convCoursewareResCase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convCoursewareResCase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convCoursewareResCase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convCoursewareResCase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convCoursewareResCase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convCoursewareResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convCoursewareResCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convCoursewareResCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convCoursewareResCase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCoursewareResCase.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCoursewareResCase.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCoursewareResCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convCoursewareResCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convCoursewareResCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convCoursewareResCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCoursewareResCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convCoursewareResCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCoursewareResCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convCoursewareResCase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCoursewareResCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convCoursewareResCase.IsHaveVideo  ==  AttributeName[intIndex])
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (convCoursewareResCase.IdCoursewareResCase  ==  AttributeName[intIndex])
{
mstrIdCoursewareResCase = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdCoursewareResCase);
}
else if (convCoursewareResCase.CoursewareResCaseID  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseID);
}
else if (convCoursewareResCase.CoursewareResCaseName  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseName);
}
else if (convCoursewareResCase.CoursewareResCaseTheme  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTheme);
}
else if (convCoursewareResCase.CoursewareResCaseText  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseText = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseText);
}
else if (convCoursewareResCase.IdCoursewareResCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareResCaseType = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdCoursewareResCaseType);
}
else if (convCoursewareResCase.CoursewareResCaseTypeName  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTypeName);
}
else if (convCoursewareResCase.CoursewareResCaseDate  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseDate);
}
else if (convCoursewareResCase.CoursewareResCaseTime  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTime);
}
else if (convCoursewareResCase.CoursewareResCaseDateIn  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseDateIn);
}
else if (convCoursewareResCase.CoursewareResCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTimeIn);
}
else if (convCoursewareResCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.OwnerId);
}
else if (convCoursewareResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdStudyLevel);
}
else if (convCoursewareResCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.StudyLevelName);
}
else if (convCoursewareResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdTeachingPlan);
}
else if (convCoursewareResCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdDiscipline);
}
else if (convCoursewareResCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.DisciplineID);
}
else if (convCoursewareResCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.DisciplineName);
}
else if (convCoursewareResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdSenateGaugeVersion);
}
else if (convCoursewareResCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionID);
}
else if (convCoursewareResCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionName);
}
else if (convCoursewareResCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionTtlScore);
}
else if (convCoursewareResCase.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.VersionNo);
}
else if (convCoursewareResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdTeachSkill);
}
else if (convCoursewareResCase.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.TeachSkillID);
}
else if (convCoursewareResCase.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.SkillTypeName);
}
else if (convCoursewareResCase.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.TeachSkillName);
}
else if (convCoursewareResCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCoursewareResCase.TeachSkillTheory);
}
else if (convCoursewareResCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCoursewareResCase.TeachSkillOperMethod);
}
else if (convCoursewareResCase.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdSkillType);
}
else if (convCoursewareResCase.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.SkillTypeID);
}
else if (convCoursewareResCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CaseLevelId);
}
else if (convCoursewareResCase.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CaseLevelName);
}
else if (convCoursewareResCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCoursewareResCase.DocFile);
}
else if (convCoursewareResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCase.IsNeedGeneWord);
}
else if (convCoursewareResCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCoursewareResCase.WordCreateDate);
}
else if (convCoursewareResCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCase.IsVisible);
}
else if (convCoursewareResCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCase.IsDualVideo);
}
else if (convCoursewareResCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdXzCollege);
}
else if (convCoursewareResCase.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CollegeID);
}
else if (convCoursewareResCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CollegeName);
}
else if (convCoursewareResCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CollegeNameA);
}
else if (convCoursewareResCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IdXzMajor);
}
else if (convCoursewareResCase.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.MajorID);
}
else if (convCoursewareResCase.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.MajorName);
}
else if (convCoursewareResCase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseChapterId);
}
else if (convCoursewareResCase.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseChapterName);
}
else if (convCoursewareResCase.ParentNodeID  ==  AttributeName[intIndex])
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convCoursewareResCase.ParentNodeID);
}
else if (convCoursewareResCase.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.ParentNodeName);
}
else if (convCoursewareResCase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.ViewCount);
}
else if (convCoursewareResCase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCase.IsShow);
}
else if (convCoursewareResCase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.DownloadNumber);
}
else if (convCoursewareResCase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.FileIntegration);
}
else if (convCoursewareResCase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.LikeCount);
}
else if (convCoursewareResCase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.CollectionCount);
}
else if (convCoursewareResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.RecommendedDegreeId);
}
else if (convCoursewareResCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.RecommendedDegreeName);
}
else if (convCoursewareResCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convCoursewareResCase.ftpFileType);
}
else if (convCoursewareResCase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseId);
}
else if (convCoursewareResCase.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseCode);
}
else if (convCoursewareResCase.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.CourseName);
}
else if (convCoursewareResCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convCoursewareResCase.VideoUrl);
}
else if (convCoursewareResCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convCoursewareResCase.VideoPath);
}
else if (convCoursewareResCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convCoursewareResCase.ResErrMsg);
}
else if (convCoursewareResCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCoursewareResCase.UpdDate);
}
else if (convCoursewareResCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.UpdUserId);
}
else if (convCoursewareResCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareResCase.Memo);
}
else if (convCoursewareResCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCoursewareResCase.OwnerNameWithId);
}
else if (convCoursewareResCase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCoursewareResCase.OwnerName);
}
else if (convCoursewareResCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCase.BrowseCount4Case);
}
else if (convCoursewareResCase.IsHaveVideo  ==  AttributeName[intIndex])
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convCoursewareResCase.IsHaveVideo);
}
}
}

/// <summary>
/// 课件资源案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareResCase
{
get
{
return mstrIdCoursewareResCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareResCase = value;
}
else
{
 mstrIdCoursewareResCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.IdCoursewareResCase);
}
}
/// <summary>
/// 课件资源案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseID
{
get
{
return mstrCoursewareResCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseID = value;
}
else
{
 mstrCoursewareResCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseID);
}
}
/// <summary>
/// 课件资源案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseName
{
get
{
return mstrCoursewareResCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseName = value;
}
else
{
 mstrCoursewareResCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseName);
}
}
/// <summary>
/// 课件资源案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTheme
{
get
{
return mstrCoursewareResCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTheme = value;
}
else
{
 mstrCoursewareResCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTheme);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseText
{
get
{
return mstrCoursewareResCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseText = value;
}
else
{
 mstrCoursewareResCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseText);
}
}
/// <summary>
/// 课件资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareResCaseType
{
get
{
return mstrIdCoursewareResCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareResCaseType = value;
}
else
{
 mstrIdCoursewareResCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.IdCoursewareResCaseType);
}
}
/// <summary>
/// 课件资源案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTypeName
{
get
{
return mstrCoursewareResCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTypeName = value;
}
else
{
 mstrCoursewareResCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTypeName);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseDate
{
get
{
return mstrCoursewareResCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseDate = value;
}
else
{
 mstrCoursewareResCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseDate);
}
}
/// <summary>
/// 视频资源时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTime
{
get
{
return mstrCoursewareResCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTime = value;
}
else
{
 mstrCoursewareResCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseDateIn
{
get
{
return mstrCoursewareResCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseDateIn = value;
}
else
{
 mstrCoursewareResCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTimeIn
{
get
{
return mstrCoursewareResCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTimeIn = value;
}
else
{
 mstrCoursewareResCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCase.CoursewareResCaseTimeIn);
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
 AddUpdatedFld(convCoursewareResCase.OwnerId);
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
 AddUpdatedFld(convCoursewareResCase.IdStudyLevel);
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
 AddUpdatedFld(convCoursewareResCase.StudyLevelName);
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
 AddUpdatedFld(convCoursewareResCase.IdTeachingPlan);
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
 AddUpdatedFld(convCoursewareResCase.IdDiscipline);
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
 AddUpdatedFld(convCoursewareResCase.DisciplineID);
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
 AddUpdatedFld(convCoursewareResCase.DisciplineName);
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
 AddUpdatedFld(convCoursewareResCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionID);
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
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionName);
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
 AddUpdatedFld(convCoursewareResCase.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convCoursewareResCase.VersionNo);
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
 AddUpdatedFld(convCoursewareResCase.IdTeachSkill);
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
 AddUpdatedFld(convCoursewareResCase.TeachSkillID);
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
 AddUpdatedFld(convCoursewareResCase.SkillTypeName);
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
 AddUpdatedFld(convCoursewareResCase.TeachSkillName);
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
 AddUpdatedFld(convCoursewareResCase.TeachSkillTheory);
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
 AddUpdatedFld(convCoursewareResCase.TeachSkillOperMethod);
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
 AddUpdatedFld(convCoursewareResCase.IdSkillType);
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
 AddUpdatedFld(convCoursewareResCase.SkillTypeID);
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
 AddUpdatedFld(convCoursewareResCase.CaseLevelId);
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
 AddUpdatedFld(convCoursewareResCase.CaseLevelName);
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
 AddUpdatedFld(convCoursewareResCase.DocFile);
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
 AddUpdatedFld(convCoursewareResCase.IsNeedGeneWord);
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
 AddUpdatedFld(convCoursewareResCase.WordCreateDate);
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
 AddUpdatedFld(convCoursewareResCase.IsVisible);
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
 AddUpdatedFld(convCoursewareResCase.IsDualVideo);
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
 AddUpdatedFld(convCoursewareResCase.IdXzCollege);
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
 AddUpdatedFld(convCoursewareResCase.CollegeID);
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
 AddUpdatedFld(convCoursewareResCase.CollegeName);
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
 AddUpdatedFld(convCoursewareResCase.CollegeNameA);
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
 AddUpdatedFld(convCoursewareResCase.IdXzMajor);
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
 AddUpdatedFld(convCoursewareResCase.MajorID);
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
 AddUpdatedFld(convCoursewareResCase.MajorName);
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
 AddUpdatedFld(convCoursewareResCase.CourseChapterId);
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
 AddUpdatedFld(convCoursewareResCase.CourseChapterName);
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
 AddUpdatedFld(convCoursewareResCase.ParentNodeID);
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
 AddUpdatedFld(convCoursewareResCase.ParentNodeName);
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
 AddUpdatedFld(convCoursewareResCase.ViewCount);
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
 AddUpdatedFld(convCoursewareResCase.IsShow);
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
 AddUpdatedFld(convCoursewareResCase.DownloadNumber);
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
 AddUpdatedFld(convCoursewareResCase.FileIntegration);
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
 AddUpdatedFld(convCoursewareResCase.LikeCount);
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
 AddUpdatedFld(convCoursewareResCase.CollectionCount);
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
 AddUpdatedFld(convCoursewareResCase.RecommendedDegreeId);
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
 AddUpdatedFld(convCoursewareResCase.RecommendedDegreeName);
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
 AddUpdatedFld(convCoursewareResCase.ftpFileType);
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
 AddUpdatedFld(convCoursewareResCase.CourseId);
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
 AddUpdatedFld(convCoursewareResCase.CourseCode);
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
 AddUpdatedFld(convCoursewareResCase.CourseName);
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
 AddUpdatedFld(convCoursewareResCase.VideoUrl);
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
 AddUpdatedFld(convCoursewareResCase.VideoPath);
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
 AddUpdatedFld(convCoursewareResCase.ResErrMsg);
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
 AddUpdatedFld(convCoursewareResCase.UpdDate);
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
 AddUpdatedFld(convCoursewareResCase.UpdUserId);
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
 AddUpdatedFld(convCoursewareResCase.Memo);
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
 AddUpdatedFld(convCoursewareResCase.OwnerNameWithId);
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
 AddUpdatedFld(convCoursewareResCase.OwnerName);
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
 AddUpdatedFld(convCoursewareResCase.BrowseCount4Case);
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
 AddUpdatedFld(convCoursewareResCase.IsHaveVideo);
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
  return mstrIdCoursewareResCase;
 }
 }
}
 /// <summary>
 /// v课件资源案例(vCoursewareResCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCoursewareResCase
{
public const string _CurrTabName = "vCoursewareResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCoursewareResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCoursewareResCase", "CoursewareResCaseID", "CoursewareResCaseName", "CoursewareResCaseTheme", "CoursewareResCaseText", "IdCoursewareResCaseType", "CoursewareResCaseTypeName", "CoursewareResCaseDate", "CoursewareResCaseTime", "CoursewareResCaseDateIn", "CoursewareResCaseTimeIn", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseChapterId", "CourseChapterName", "ParentNodeID", "ParentNodeName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "CourseId", "CourseCode", "CourseName", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo", "OwnerNameWithId", "OwnerName", "BrowseCount4Case", "IsHaveVideo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCoursewareResCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareResCase = "IdCoursewareResCase";    //课件资源案例流水号

 /// <summary>
 /// 常量:"CoursewareResCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseID = "CoursewareResCaseID";    //课件资源案例ID

 /// <summary>
 /// 常量:"CoursewareResCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseName = "CoursewareResCaseName";    //课件资源案例名称

 /// <summary>
 /// 常量:"CoursewareResCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTheme = "CoursewareResCaseTheme";    //课件资源案例主题词

 /// <summary>
 /// 常量:"CoursewareResCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseText = "CoursewareResCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"IdCoursewareResCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareResCaseType = "IdCoursewareResCaseType";    //课件资源类型流水号

 /// <summary>
 /// 常量:"CoursewareResCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTypeName = "CoursewareResCaseTypeName";    //课件资源案例类型名称

 /// <summary>
 /// 常量:"CoursewareResCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseDate = "CoursewareResCaseDate";    //视频资源日期

 /// <summary>
 /// 常量:"CoursewareResCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTime = "CoursewareResCaseTime";    //视频资源时间

 /// <summary>
 /// 常量:"CoursewareResCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseDateIn = "CoursewareResCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CoursewareResCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTimeIn = "CoursewareResCaseTimeIn";    //案例入库时间

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
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"IsHaveVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveVideo = "IsHaveVideo";    //IsHaveVideo
}

}