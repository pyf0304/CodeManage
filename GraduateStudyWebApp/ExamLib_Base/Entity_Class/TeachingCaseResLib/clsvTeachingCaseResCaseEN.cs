
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseEN
 表名:vTeachingCaseResCase(01120378)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
 /// 表vTeachingCaseResCase的关键字(IdTeachingCaseResCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachingCaseResCase_vTeachingCaseResCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeachingCaseResCase">表关键字</param>
public K_IdTeachingCaseResCase_vTeachingCaseResCase(string strIdTeachingCaseResCase)
{
if (IsValid(strIdTeachingCaseResCase)) Value = strIdTeachingCaseResCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeachingCaseResCase)
{
if (string.IsNullOrEmpty(strIdTeachingCaseResCase) == true) return false;
if (strIdTeachingCaseResCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachingCaseResCase_vTeachingCaseResCase]类型的对象</returns>
public static implicit operator K_IdTeachingCaseResCase_vTeachingCaseResCase(string value)
{
return new K_IdTeachingCaseResCase_vTeachingCaseResCase(value);
}
}
 /// <summary>
 /// v教学案例资源案例(vTeachingCaseResCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeachingCaseResCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeachingCaseResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachingCaseResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 73;
public static string[] AttributeName = new string[] {"IdTeachingCaseResCase", "TeachingCaseResCaseID", "TeachingCaseResCaseName", "TeachingCaseResCaseTheme", "TeachingCaseResCaseText", "TeachingCaseResCaseDate", "TeachingCaseResCaseTime", "TeachingCaseResCaseDateIn", "TeachingCaseResCaseTimeIn", "IdTeachingCaseResCaseType", "TeachingCaseResCaseTypeName", "CourseId", "CourseCode", "CourseName", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseChapterId", "CourseChapterName", "ParentNodeID", "ParentNodeName", "CourseChapterReferred", "ParentNodeReferred", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo", "OwnerNameWithId", "OwnerName", "BrowseCount4Case", "IsHaveVideo"};

protected string mstrIdTeachingCaseResCase;    //教学案例资源案例流水号
protected string mstrTeachingCaseResCaseID;    //教学案例资源案例ID
protected string mstrTeachingCaseResCaseName;    //教学案例资源案例名称
protected string mstrTeachingCaseResCaseTheme;    //教学案例资源案例主题词
protected string mstrTeachingCaseResCaseText;    //案例文本内容
protected string mstrTeachingCaseResCaseDate;    //视频资源日期
protected string mstrTeachingCaseResCaseTime;    //视频资源时间
protected string mstrTeachingCaseResCaseDateIn;    //案例入库日期
protected string mstrTeachingCaseResCaseTimeIn;    //案例入库时间
protected string mstrIdTeachingCaseResCaseType;    //教学案例资源类型流水号
protected string mstrTeachingCaseResCaseTypeName;    //教学案例资源案例类型名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
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
protected string mstrCourseChapterReferred;    //节简称
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
 public clsvTeachingCaseResCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachingCaseResCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeachingCaseResCase">关键字:教学案例资源案例流水号</param>
public clsvTeachingCaseResCaseEN(string strIdTeachingCaseResCase)
 {
strIdTeachingCaseResCase = strIdTeachingCaseResCase.Replace("'", "''");
if (strIdTeachingCaseResCase.Length > 8)
{
throw new Exception("在表:vTeachingCaseResCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachingCaseResCase)  ==  true)
{
throw new Exception("在表:vTeachingCaseResCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingCaseResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeachingCaseResCase = strIdTeachingCaseResCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachingCaseResCase");
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
if (strAttributeName  ==  convTeachingCaseResCase.IdTeachingCaseResCase)
{
return mstrIdTeachingCaseResCase;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseID)
{
return mstrTeachingCaseResCaseID;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseName)
{
return mstrTeachingCaseResCaseName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseTheme)
{
return mstrTeachingCaseResCaseTheme;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseText)
{
return mstrTeachingCaseResCaseText;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseDate)
{
return mstrTeachingCaseResCaseDate;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseTime)
{
return mstrTeachingCaseResCaseTime;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseDateIn)
{
return mstrTeachingCaseResCaseDateIn;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseTimeIn)
{
return mstrTeachingCaseResCaseTimeIn;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdTeachingCaseResCaseType)
{
return mstrIdTeachingCaseResCaseType;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseTypeName)
{
return mstrTeachingCaseResCaseTypeName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convTeachingCaseResCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convTeachingCaseResCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convTeachingCaseResCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convTeachingCaseResCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convTeachingCaseResCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convTeachingCaseResCase.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convTeachingCaseResCase.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convTeachingCaseResCase.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convTeachingCaseResCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convTeachingCaseResCase.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convTeachingCaseResCase.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.ParentNodeID)
{
return mstrParentNodeID;
}
else if (strAttributeName  ==  convTeachingCaseResCase.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convTeachingCaseResCase.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convTeachingCaseResCase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convTeachingCaseResCase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convTeachingCaseResCase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convTeachingCaseResCase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convTeachingCaseResCase.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convTeachingCaseResCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convTeachingCaseResCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convTeachingCaseResCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convTeachingCaseResCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convTeachingCaseResCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convTeachingCaseResCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convTeachingCaseResCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convTeachingCaseResCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTeachingCaseResCase.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convTeachingCaseResCase.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convTeachingCaseResCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsHaveVideo)
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (strAttributeName  ==  convTeachingCaseResCase.IdTeachingCaseResCase)
{
mstrIdTeachingCaseResCase = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingCaseResCase);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseID)
{
mstrTeachingCaseResCaseID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseID);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseName)
{
mstrTeachingCaseResCaseName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseTheme)
{
mstrTeachingCaseResCaseTheme = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTheme);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseText)
{
mstrTeachingCaseResCaseText = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseText);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseDate)
{
mstrTeachingCaseResCaseDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseDate);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseTime)
{
mstrTeachingCaseResCaseTime = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTime);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseDateIn)
{
mstrTeachingCaseResCaseDateIn = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseTimeIn)
{
mstrTeachingCaseResCaseTimeIn = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdTeachingCaseResCaseType)
{
mstrIdTeachingCaseResCaseType = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingCaseResCaseType);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachingCaseResCaseTypeName)
{
mstrTeachingCaseResCaseTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTypeName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseId);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseCode);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.OwnerId);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdStudyLevel);
}
else if (strAttributeName  ==  convTeachingCaseResCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.StudyLevelName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdDiscipline);
}
else if (strAttributeName  ==  convTeachingCaseResCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.DisciplineID);
}
else if (strAttributeName  ==  convTeachingCaseResCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.DisciplineName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convTeachingCaseResCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convTeachingCaseResCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convTeachingCaseResCase.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.VersionNo);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdTeachSkill);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillID);
}
else if (strAttributeName  ==  convTeachingCaseResCase.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.SkillTypeName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillTheory);
}
else if (strAttributeName  ==  convTeachingCaseResCase.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdSkillType);
}
else if (strAttributeName  ==  convTeachingCaseResCase.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.SkillTypeID);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CaseLevelId);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CaseLevelName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.DocFile);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convTeachingCaseResCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.WordCreateDate);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.IsVisible);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.IsDualVideo);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdXzCollege);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CollegeID);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CollegeName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CollegeNameA);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdXzMajor);
}
else if (strAttributeName  ==  convTeachingCaseResCase.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.MajorID);
}
else if (strAttributeName  ==  convTeachingCaseResCase.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.MajorName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterId);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.ParentNodeID)
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeID);
}
else if (strAttributeName  ==  convTeachingCaseResCase.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterReferred);
}
else if (strAttributeName  ==  convTeachingCaseResCase.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeReferred);
}
else if (strAttributeName  ==  convTeachingCaseResCase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.ViewCount);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.IsShow);
}
else if (strAttributeName  ==  convTeachingCaseResCase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.DownloadNumber);
}
else if (strAttributeName  ==  convTeachingCaseResCase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.FileIntegration);
}
else if (strAttributeName  ==  convTeachingCaseResCase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.LikeCount);
}
else if (strAttributeName  ==  convTeachingCaseResCase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.CollectionCount);
}
else if (strAttributeName  ==  convTeachingCaseResCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convTeachingCaseResCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ftpFileType);
}
else if (strAttributeName  ==  convTeachingCaseResCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.VideoUrl);
}
else if (strAttributeName  ==  convTeachingCaseResCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.VideoPath);
}
else if (strAttributeName  ==  convTeachingCaseResCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ResErrMsg);
}
else if (strAttributeName  ==  convTeachingCaseResCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.UpdDate);
}
else if (strAttributeName  ==  convTeachingCaseResCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.UpdUserId);
}
else if (strAttributeName  ==  convTeachingCaseResCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.Memo);
}
else if (strAttributeName  ==  convTeachingCaseResCase.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.OwnerNameWithId);
}
else if (strAttributeName  ==  convTeachingCaseResCase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.OwnerName);
}
else if (strAttributeName  ==  convTeachingCaseResCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.BrowseCount4Case);
}
else if (strAttributeName  ==  convTeachingCaseResCase.IsHaveVideo)
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IsHaveVideo);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeachingCaseResCase.IdTeachingCaseResCase  ==  AttributeName[intIndex])
{
return mstrIdTeachingCaseResCase;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseID  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseID;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseName  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseName;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseTheme  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTheme;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseText  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseText;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseDate  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseDate;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseTime  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTime;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseDateIn  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseDateIn;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTimeIn;
}
else if (convTeachingCaseResCase.IdTeachingCaseResCaseType  ==  AttributeName[intIndex])
{
return mstrIdTeachingCaseResCaseType;
}
else if (convTeachingCaseResCase.TeachingCaseResCaseTypeName  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTypeName;
}
else if (convTeachingCaseResCase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convTeachingCaseResCase.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convTeachingCaseResCase.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convTeachingCaseResCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convTeachingCaseResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convTeachingCaseResCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convTeachingCaseResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convTeachingCaseResCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convTeachingCaseResCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convTeachingCaseResCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convTeachingCaseResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convTeachingCaseResCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convTeachingCaseResCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convTeachingCaseResCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convTeachingCaseResCase.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convTeachingCaseResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convTeachingCaseResCase.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convTeachingCaseResCase.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convTeachingCaseResCase.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convTeachingCaseResCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convTeachingCaseResCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convTeachingCaseResCase.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convTeachingCaseResCase.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convTeachingCaseResCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convTeachingCaseResCase.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convTeachingCaseResCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convTeachingCaseResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convTeachingCaseResCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convTeachingCaseResCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convTeachingCaseResCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convTeachingCaseResCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convTeachingCaseResCase.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convTeachingCaseResCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convTeachingCaseResCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convTeachingCaseResCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convTeachingCaseResCase.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convTeachingCaseResCase.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convTeachingCaseResCase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convTeachingCaseResCase.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convTeachingCaseResCase.ParentNodeID  ==  AttributeName[intIndex])
{
return mstrParentNodeID;
}
else if (convTeachingCaseResCase.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convTeachingCaseResCase.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convTeachingCaseResCase.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convTeachingCaseResCase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convTeachingCaseResCase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convTeachingCaseResCase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convTeachingCaseResCase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convTeachingCaseResCase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convTeachingCaseResCase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convTeachingCaseResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convTeachingCaseResCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convTeachingCaseResCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convTeachingCaseResCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convTeachingCaseResCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convTeachingCaseResCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convTeachingCaseResCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convTeachingCaseResCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convTeachingCaseResCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTeachingCaseResCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convTeachingCaseResCase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convTeachingCaseResCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convTeachingCaseResCase.IsHaveVideo  ==  AttributeName[intIndex])
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (convTeachingCaseResCase.IdTeachingCaseResCase  ==  AttributeName[intIndex])
{
mstrIdTeachingCaseResCase = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingCaseResCase);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseID  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseID);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseName  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseName);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseTheme  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTheme = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTheme);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseText  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseText = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseText);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseDate  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseDate);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseTime  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTime = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTime);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseDateIn  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseDateIn = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseTimeIn  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTimeIn = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
else if (convTeachingCaseResCase.IdTeachingCaseResCaseType  ==  AttributeName[intIndex])
{
mstrIdTeachingCaseResCaseType = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingCaseResCaseType);
}
else if (convTeachingCaseResCase.TeachingCaseResCaseTypeName  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTypeName);
}
else if (convTeachingCaseResCase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseId);
}
else if (convTeachingCaseResCase.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseCode);
}
else if (convTeachingCaseResCase.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseName);
}
else if (convTeachingCaseResCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.OwnerId);
}
else if (convTeachingCaseResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdStudyLevel);
}
else if (convTeachingCaseResCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.StudyLevelName);
}
else if (convTeachingCaseResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingPlan);
}
else if (convTeachingCaseResCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdDiscipline);
}
else if (convTeachingCaseResCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.DisciplineID);
}
else if (convTeachingCaseResCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.DisciplineName);
}
else if (convTeachingCaseResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdSenateGaugeVersion);
}
else if (convTeachingCaseResCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionID);
}
else if (convTeachingCaseResCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionName);
}
else if (convTeachingCaseResCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionTtlScore);
}
else if (convTeachingCaseResCase.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.VersionNo);
}
else if (convTeachingCaseResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdTeachSkill);
}
else if (convTeachingCaseResCase.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillID);
}
else if (convTeachingCaseResCase.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.SkillTypeName);
}
else if (convTeachingCaseResCase.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillName);
}
else if (convTeachingCaseResCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillTheory);
}
else if (convTeachingCaseResCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillOperMethod);
}
else if (convTeachingCaseResCase.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdSkillType);
}
else if (convTeachingCaseResCase.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.SkillTypeID);
}
else if (convTeachingCaseResCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CaseLevelId);
}
else if (convTeachingCaseResCase.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CaseLevelName);
}
else if (convTeachingCaseResCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.DocFile);
}
else if (convTeachingCaseResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.IsNeedGeneWord);
}
else if (convTeachingCaseResCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.WordCreateDate);
}
else if (convTeachingCaseResCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.IsVisible);
}
else if (convTeachingCaseResCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.IsDualVideo);
}
else if (convTeachingCaseResCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdXzCollege);
}
else if (convTeachingCaseResCase.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CollegeID);
}
else if (convTeachingCaseResCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CollegeName);
}
else if (convTeachingCaseResCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CollegeNameA);
}
else if (convTeachingCaseResCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IdXzMajor);
}
else if (convTeachingCaseResCase.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.MajorID);
}
else if (convTeachingCaseResCase.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.MajorName);
}
else if (convTeachingCaseResCase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterId);
}
else if (convTeachingCaseResCase.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterName);
}
else if (convTeachingCaseResCase.ParentNodeID  ==  AttributeName[intIndex])
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeID);
}
else if (convTeachingCaseResCase.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeName);
}
else if (convTeachingCaseResCase.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterReferred);
}
else if (convTeachingCaseResCase.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeReferred);
}
else if (convTeachingCaseResCase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.ViewCount);
}
else if (convTeachingCaseResCase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.IsShow);
}
else if (convTeachingCaseResCase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.DownloadNumber);
}
else if (convTeachingCaseResCase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.FileIntegration);
}
else if (convTeachingCaseResCase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.LikeCount);
}
else if (convTeachingCaseResCase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.CollectionCount);
}
else if (convTeachingCaseResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.RecommendedDegreeId);
}
else if (convTeachingCaseResCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.RecommendedDegreeName);
}
else if (convTeachingCaseResCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ftpFileType);
}
else if (convTeachingCaseResCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.VideoUrl);
}
else if (convTeachingCaseResCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.VideoPath);
}
else if (convTeachingCaseResCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.ResErrMsg);
}
else if (convTeachingCaseResCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.UpdDate);
}
else if (convTeachingCaseResCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.UpdUserId);
}
else if (convTeachingCaseResCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.Memo);
}
else if (convTeachingCaseResCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.OwnerNameWithId);
}
else if (convTeachingCaseResCase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.OwnerName);
}
else if (convTeachingCaseResCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCase.BrowseCount4Case);
}
else if (convTeachingCaseResCase.IsHaveVideo  ==  AttributeName[intIndex])
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convTeachingCaseResCase.IsHaveVideo);
}
}
}

/// <summary>
/// 教学案例资源案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingCaseResCase
{
get
{
return mstrIdTeachingCaseResCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingCaseResCase = value;
}
else
{
 mstrIdTeachingCaseResCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingCaseResCase);
}
}
/// <summary>
/// 教学案例资源案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseID
{
get
{
return mstrTeachingCaseResCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseID = value;
}
else
{
 mstrTeachingCaseResCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseID);
}
}
/// <summary>
/// 教学案例资源案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseName
{
get
{
return mstrTeachingCaseResCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseName = value;
}
else
{
 mstrTeachingCaseResCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseName);
}
}
/// <summary>
/// 教学案例资源案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTheme
{
get
{
return mstrTeachingCaseResCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTheme = value;
}
else
{
 mstrTeachingCaseResCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTheme);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseText
{
get
{
return mstrTeachingCaseResCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseText = value;
}
else
{
 mstrTeachingCaseResCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseText);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseDate
{
get
{
return mstrTeachingCaseResCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseDate = value;
}
else
{
 mstrTeachingCaseResCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseDate);
}
}
/// <summary>
/// 视频资源时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTime
{
get
{
return mstrTeachingCaseResCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTime = value;
}
else
{
 mstrTeachingCaseResCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseDateIn
{
get
{
return mstrTeachingCaseResCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseDateIn = value;
}
else
{
 mstrTeachingCaseResCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTimeIn
{
get
{
return mstrTeachingCaseResCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTimeIn = value;
}
else
{
 mstrTeachingCaseResCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
}
/// <summary>
/// 教学案例资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingCaseResCaseType
{
get
{
return mstrIdTeachingCaseResCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingCaseResCaseType = value;
}
else
{
 mstrIdTeachingCaseResCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingCaseResCaseType);
}
}
/// <summary>
/// 教学案例资源案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTypeName
{
get
{
return mstrTeachingCaseResCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTypeName = value;
}
else
{
 mstrTeachingCaseResCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCase.TeachingCaseResCaseTypeName);
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
 AddUpdatedFld(convTeachingCaseResCase.CourseId);
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
 AddUpdatedFld(convTeachingCaseResCase.CourseCode);
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
 AddUpdatedFld(convTeachingCaseResCase.CourseName);
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
 AddUpdatedFld(convTeachingCaseResCase.OwnerId);
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
 AddUpdatedFld(convTeachingCaseResCase.IdStudyLevel);
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
 AddUpdatedFld(convTeachingCaseResCase.StudyLevelName);
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
 AddUpdatedFld(convTeachingCaseResCase.IdTeachingPlan);
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
 AddUpdatedFld(convTeachingCaseResCase.IdDiscipline);
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
 AddUpdatedFld(convTeachingCaseResCase.DisciplineID);
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
 AddUpdatedFld(convTeachingCaseResCase.DisciplineName);
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
 AddUpdatedFld(convTeachingCaseResCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionID);
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
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionName);
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
 AddUpdatedFld(convTeachingCaseResCase.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convTeachingCaseResCase.VersionNo);
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
 AddUpdatedFld(convTeachingCaseResCase.IdTeachSkill);
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
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillID);
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
 AddUpdatedFld(convTeachingCaseResCase.SkillTypeName);
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
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillName);
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
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillTheory);
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
 AddUpdatedFld(convTeachingCaseResCase.TeachSkillOperMethod);
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
 AddUpdatedFld(convTeachingCaseResCase.IdSkillType);
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
 AddUpdatedFld(convTeachingCaseResCase.SkillTypeID);
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
 AddUpdatedFld(convTeachingCaseResCase.CaseLevelId);
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
 AddUpdatedFld(convTeachingCaseResCase.CaseLevelName);
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
 AddUpdatedFld(convTeachingCaseResCase.DocFile);
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
 AddUpdatedFld(convTeachingCaseResCase.IsNeedGeneWord);
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
 AddUpdatedFld(convTeachingCaseResCase.WordCreateDate);
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
 AddUpdatedFld(convTeachingCaseResCase.IsVisible);
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
 AddUpdatedFld(convTeachingCaseResCase.IsDualVideo);
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
 AddUpdatedFld(convTeachingCaseResCase.IdXzCollege);
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
 AddUpdatedFld(convTeachingCaseResCase.CollegeID);
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
 AddUpdatedFld(convTeachingCaseResCase.CollegeName);
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
 AddUpdatedFld(convTeachingCaseResCase.CollegeNameA);
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
 AddUpdatedFld(convTeachingCaseResCase.IdXzMajor);
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
 AddUpdatedFld(convTeachingCaseResCase.MajorID);
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
 AddUpdatedFld(convTeachingCaseResCase.MajorName);
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
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterId);
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
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterName);
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
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeID);
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
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeName);
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
 AddUpdatedFld(convTeachingCaseResCase.CourseChapterReferred);
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
 AddUpdatedFld(convTeachingCaseResCase.ParentNodeReferred);
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
 AddUpdatedFld(convTeachingCaseResCase.ViewCount);
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
 AddUpdatedFld(convTeachingCaseResCase.IsShow);
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
 AddUpdatedFld(convTeachingCaseResCase.DownloadNumber);
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
 AddUpdatedFld(convTeachingCaseResCase.FileIntegration);
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
 AddUpdatedFld(convTeachingCaseResCase.LikeCount);
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
 AddUpdatedFld(convTeachingCaseResCase.CollectionCount);
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
 AddUpdatedFld(convTeachingCaseResCase.RecommendedDegreeId);
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
 AddUpdatedFld(convTeachingCaseResCase.RecommendedDegreeName);
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
 AddUpdatedFld(convTeachingCaseResCase.ftpFileType);
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
 AddUpdatedFld(convTeachingCaseResCase.VideoUrl);
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
 AddUpdatedFld(convTeachingCaseResCase.VideoPath);
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
 AddUpdatedFld(convTeachingCaseResCase.ResErrMsg);
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
 AddUpdatedFld(convTeachingCaseResCase.UpdDate);
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
 AddUpdatedFld(convTeachingCaseResCase.UpdUserId);
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
 AddUpdatedFld(convTeachingCaseResCase.Memo);
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
 AddUpdatedFld(convTeachingCaseResCase.OwnerNameWithId);
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
 AddUpdatedFld(convTeachingCaseResCase.OwnerName);
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
 AddUpdatedFld(convTeachingCaseResCase.BrowseCount4Case);
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
 AddUpdatedFld(convTeachingCaseResCase.IsHaveVideo);
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
  return mstrIdTeachingCaseResCase;
 }
 }
}
 /// <summary>
 /// v教学案例资源案例(vTeachingCaseResCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeachingCaseResCase
{
public const string _CurrTabName = "vTeachingCaseResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachingCaseResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachingCaseResCase", "TeachingCaseResCaseID", "TeachingCaseResCaseName", "TeachingCaseResCaseTheme", "TeachingCaseResCaseText", "TeachingCaseResCaseDate", "TeachingCaseResCaseTime", "TeachingCaseResCaseDateIn", "TeachingCaseResCaseTimeIn", "IdTeachingCaseResCaseType", "TeachingCaseResCaseTypeName", "CourseId", "CourseCode", "CourseName", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseChapterId", "CourseChapterName", "ParentNodeID", "ParentNodeName", "CourseChapterReferred", "ParentNodeReferred", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo", "OwnerNameWithId", "OwnerName", "BrowseCount4Case", "IsHaveVideo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachingCaseResCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingCaseResCase = "IdTeachingCaseResCase";    //教学案例资源案例流水号

 /// <summary>
 /// 常量:"TeachingCaseResCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseID = "TeachingCaseResCaseID";    //教学案例资源案例ID

 /// <summary>
 /// 常量:"TeachingCaseResCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseName = "TeachingCaseResCaseName";    //教学案例资源案例名称

 /// <summary>
 /// 常量:"TeachingCaseResCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTheme = "TeachingCaseResCaseTheme";    //教学案例资源案例主题词

 /// <summary>
 /// 常量:"TeachingCaseResCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseText = "TeachingCaseResCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"TeachingCaseResCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseDate = "TeachingCaseResCaseDate";    //视频资源日期

 /// <summary>
 /// 常量:"TeachingCaseResCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTime = "TeachingCaseResCaseTime";    //视频资源时间

 /// <summary>
 /// 常量:"TeachingCaseResCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseDateIn = "TeachingCaseResCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"TeachingCaseResCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTimeIn = "TeachingCaseResCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdTeachingCaseResCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingCaseResCaseType = "IdTeachingCaseResCaseType";    //教学案例资源类型流水号

 /// <summary>
 /// 常量:"TeachingCaseResCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTypeName = "TeachingCaseResCaseTypeName";    //教学案例资源案例类型名称

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
 /// 常量:"CourseChapterReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterReferred = "CourseChapterReferred";    //节简称

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