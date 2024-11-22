
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseWithResourceRelEN
 表名:vCourseLearningCaseWithResourceRel(01120472)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vCourseLearningCaseWithResourceRel的关键字(IdCourseLearningCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCourseLearningCase_vCourseLearningCaseWithResourceRel
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
public K_IdCourseLearningCase_vCourseLearningCaseWithResourceRel(string strIdCourseLearningCase)
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
 /// <returns>返回:[K_IdCourseLearningCase_vCourseLearningCaseWithResourceRel]类型的对象</returns>
public static implicit operator K_IdCourseLearningCase_vCourseLearningCaseWithResourceRel(string value)
{
return new K_IdCourseLearningCase_vCourseLearningCaseWithResourceRel(value);
}
}
 /// <summary>
 /// v课程学习案例With资源关系(vCourseLearningCaseWithResourceRel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCourseLearningCaseWithResourceRelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCourseLearningCaseWithResourceRel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCourseLearningCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 87;
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileSize", "SaveTime", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "IsExistFile", "FileNewName", "IsMain", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseText", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "IdCaseType", "IdCourseLearningCaseType", "CourseLearningCaseTypeName", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "TeachingSolutionId", "CourseChapterId", "CourseChapterName", "ParentNodeID", "ParentNodeName", "CourseChapterReferred", "ParentNodeReferred", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "Memo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId", "CaseTypeName"};

protected string mstrIdCourseLearningCase;    //课程学习案例流水号
protected long? mlngIdMicroteachCaseResourceRel;    //微格案例资源关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
protected string mstrResourceName;    //资源名称
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrIdFile;    //文件流水号
protected string mstrFileSize;    //文件大小
protected string mstrSaveTime;    //创建时间
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrResourceOwner;    //上传者
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrFileNewName;    //新文件名
protected bool mbolIsMain;    //是否主资源
protected string mstrCourseLearningCaseID;    //课程学习案例ID
protected string mstrCourseLearningCaseName;    //课程学习案例名称
protected string mstrCourseLearningCaseText;    //案例文本内容
protected string mstrCourseLearningCaseTheme;    //课程学习案例主题词
protected string mstrCourseLearningCaseDate;    //课程学习日期
protected string mstrCourseLearningCaseTime;    //课程学习时间
protected string mstrCourseLearningCaseDateIn;    //案例入库日期
protected string mstrCourseLearningCaseTimeIn;    //案例入库时间
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdCourseLearningCaseType;    //课程学习案例类型流水号
protected string mstrCourseLearningCaseTypeName;    //课程学习案例类型名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
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
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrTeachingSolutionId;    //教学方案Id
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
protected string mstrMemo;    //备注
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrCaseTypeName;    //案例类型名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCourseLearningCaseWithResourceRelEN()
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
public clsvCourseLearningCaseWithResourceRelEN(string strIdCourseLearningCase)
 {
strIdCourseLearningCase = strIdCourseLearningCase.Replace("'", "''");
if (strIdCourseLearningCase.Length > 8)
{
throw new Exception("在表:vCourseLearningCaseWithResourceRel中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("在表:vCourseLearningCaseWithResourceRel中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdCourseLearningCase)
{
return mstrIdCourseLearningCase;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel)
{
return mlngIdMicroteachCaseResourceRel;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseID)
{
return mstrCourseLearningCaseID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseName)
{
return mstrCourseLearningCaseName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseText)
{
return mstrCourseLearningCaseText;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme)
{
return mstrCourseLearningCaseTheme;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseDate)
{
return mstrCourseLearningCaseDate;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseTime)
{
return mstrCourseLearningCaseTime;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn)
{
return mstrCourseLearningCaseDateIn;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn)
{
return mstrCourseLearningCaseTimeIn;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType)
{
return mstrIdCourseLearningCaseType;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName)
{
return mstrCourseLearningCaseTypeName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ParentNodeID)
{
return mstrParentNodeID;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CaseTypeName)
{
return mstrCaseTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdCourseLearningCase)
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCourseLearningCase);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel)
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FuncModuleId);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FuncModuleName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdResource);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdFtpResource);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdFile);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileSize);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SaveTime);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdResourceType);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceTypeID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceTypeName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceOwner);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsExistFile);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileNewName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsMain);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseID)
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseName)
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseText)
{
mstrCourseLearningCaseText = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseText);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme)
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseDate)
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseTime)
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn)
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn)
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCaseType);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType)
{
mstrIdCourseLearningCaseType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName)
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerId);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdStudyLevel);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.StudyLevelName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdTeachingPlan);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdDiscipline);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DisciplineID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DisciplineName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.BrowseCount);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.VersionNo);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdTeachSkill);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SkillTypeName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillTheory);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdSkillType);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SkillTypeID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseLevelId);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseLevelName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DocFile);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsNeedGeneWord);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.WordCreateDate);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsVisible);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsDualVideo);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdXzCollege);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeNameA);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdXzMajor);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.MajorID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.MajorName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseId);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseCode);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachingSolutionId);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterId);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ParentNodeID)
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeID);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterReferred);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeReferred);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ViewCount);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsShow);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DownloadNumber);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileIntegration);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.LikeCount);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollectionCount);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.RecommendedDegreeName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.Memo);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.BrowseCount4Case);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerName);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerNameWithId);
}
else if (strAttributeName  ==  convCourseLearningCaseWithResourceRel.CaseTypeName)
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convCourseLearningCaseWithResourceRel.IdCourseLearningCase  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCase;
}
else if (convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseResourceRel;
}
else if (convCourseLearningCaseWithResourceRel.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCourseLearningCaseWithResourceRel.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCourseLearningCaseWithResourceRel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convCourseLearningCaseWithResourceRel.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convCourseLearningCaseWithResourceRel.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convCourseLearningCaseWithResourceRel.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convCourseLearningCaseWithResourceRel.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convCourseLearningCaseWithResourceRel.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convCourseLearningCaseWithResourceRel.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convCourseLearningCaseWithResourceRel.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convCourseLearningCaseWithResourceRel.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convCourseLearningCaseWithResourceRel.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convCourseLearningCaseWithResourceRel.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convCourseLearningCaseWithResourceRel.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convCourseLearningCaseWithResourceRel.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convCourseLearningCaseWithResourceRel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseID  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseID;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseName;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseText  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseText;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTheme;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDate;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTime;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDateIn;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTimeIn;
}
else if (convCourseLearningCaseWithResourceRel.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCaseType;
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTypeName;
}
else if (convCourseLearningCaseWithResourceRel.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCourseLearningCaseWithResourceRel.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convCourseLearningCaseWithResourceRel.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convCourseLearningCaseWithResourceRel.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convCourseLearningCaseWithResourceRel.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convCourseLearningCaseWithResourceRel.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convCourseLearningCaseWithResourceRel.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convCourseLearningCaseWithResourceRel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convCourseLearningCaseWithResourceRel.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convCourseLearningCaseWithResourceRel.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convCourseLearningCaseWithResourceRel.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convCourseLearningCaseWithResourceRel.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convCourseLearningCaseWithResourceRel.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convCourseLearningCaseWithResourceRel.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convCourseLearningCaseWithResourceRel.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convCourseLearningCaseWithResourceRel.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convCourseLearningCaseWithResourceRel.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convCourseLearningCaseWithResourceRel.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convCourseLearningCaseWithResourceRel.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convCourseLearningCaseWithResourceRel.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convCourseLearningCaseWithResourceRel.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convCourseLearningCaseWithResourceRel.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convCourseLearningCaseWithResourceRel.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convCourseLearningCaseWithResourceRel.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convCourseLearningCaseWithResourceRel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convCourseLearningCaseWithResourceRel.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCourseLearningCaseWithResourceRel.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCourseLearningCaseWithResourceRel.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convCourseLearningCaseWithResourceRel.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCourseLearningCaseWithResourceRel.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convCourseLearningCaseWithResourceRel.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCourseLearningCaseWithResourceRel.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convCourseLearningCaseWithResourceRel.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCourseLearningCaseWithResourceRel.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCourseLearningCaseWithResourceRel.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCourseLearningCaseWithResourceRel.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCourseLearningCaseWithResourceRel.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (convCourseLearningCaseWithResourceRel.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convCourseLearningCaseWithResourceRel.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convCourseLearningCaseWithResourceRel.ParentNodeID  ==  AttributeName[intIndex])
{
return mstrParentNodeID;
}
else if (convCourseLearningCaseWithResourceRel.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convCourseLearningCaseWithResourceRel.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convCourseLearningCaseWithResourceRel.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convCourseLearningCaseWithResourceRel.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convCourseLearningCaseWithResourceRel.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convCourseLearningCaseWithResourceRel.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convCourseLearningCaseWithResourceRel.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convCourseLearningCaseWithResourceRel.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convCourseLearningCaseWithResourceRel.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convCourseLearningCaseWithResourceRel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convCourseLearningCaseWithResourceRel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convCourseLearningCaseWithResourceRel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCourseLearningCaseWithResourceRel.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convCourseLearningCaseWithResourceRel.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCourseLearningCaseWithResourceRel.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convCourseLearningCaseWithResourceRel.CaseTypeName  ==  AttributeName[intIndex])
{
return mstrCaseTypeName;
}
return null;
}
set
{
if (convCourseLearningCaseWithResourceRel.IdCourseLearningCase  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCourseLearningCase);
}
else if (convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel);
}
else if (convCourseLearningCaseWithResourceRel.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FuncModuleId);
}
else if (convCourseLearningCaseWithResourceRel.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FuncModuleName);
}
else if (convCourseLearningCaseWithResourceRel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdResource);
}
else if (convCourseLearningCaseWithResourceRel.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceID);
}
else if (convCourseLearningCaseWithResourceRel.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceName);
}
else if (convCourseLearningCaseWithResourceRel.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdFtpResource);
}
else if (convCourseLearningCaseWithResourceRel.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdFile);
}
else if (convCourseLearningCaseWithResourceRel.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileSize);
}
else if (convCourseLearningCaseWithResourceRel.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SaveTime);
}
else if (convCourseLearningCaseWithResourceRel.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdResourceType);
}
else if (convCourseLearningCaseWithResourceRel.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceTypeID);
}
else if (convCourseLearningCaseWithResourceRel.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceTypeName);
}
else if (convCourseLearningCaseWithResourceRel.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceOwner);
}
else if (convCourseLearningCaseWithResourceRel.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsExistFile);
}
else if (convCourseLearningCaseWithResourceRel.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileNewName);
}
else if (convCourseLearningCaseWithResourceRel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsMain);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseID  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseText  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseText = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseText);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
}
else if (convCourseLearningCaseWithResourceRel.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCaseType);
}
else if (convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCaseType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType);
}
else if (convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName);
}
else if (convCourseLearningCaseWithResourceRel.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerId);
}
else if (convCourseLearningCaseWithResourceRel.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdStudyLevel);
}
else if (convCourseLearningCaseWithResourceRel.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.StudyLevelName);
}
else if (convCourseLearningCaseWithResourceRel.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdTeachingPlan);
}
else if (convCourseLearningCaseWithResourceRel.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdDiscipline);
}
else if (convCourseLearningCaseWithResourceRel.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DisciplineID);
}
else if (convCourseLearningCaseWithResourceRel.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DisciplineName);
}
else if (convCourseLearningCaseWithResourceRel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.BrowseCount);
}
else if (convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion);
}
else if (convCourseLearningCaseWithResourceRel.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
}
else if (convCourseLearningCaseWithResourceRel.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionName);
}
else if (convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore);
}
else if (convCourseLearningCaseWithResourceRel.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.VersionNo);
}
else if (convCourseLearningCaseWithResourceRel.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdTeachSkill);
}
else if (convCourseLearningCaseWithResourceRel.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillID);
}
else if (convCourseLearningCaseWithResourceRel.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SkillTypeName);
}
else if (convCourseLearningCaseWithResourceRel.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillName);
}
else if (convCourseLearningCaseWithResourceRel.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillTheory);
}
else if (convCourseLearningCaseWithResourceRel.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod);
}
else if (convCourseLearningCaseWithResourceRel.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdSkillType);
}
else if (convCourseLearningCaseWithResourceRel.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SkillTypeID);
}
else if (convCourseLearningCaseWithResourceRel.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseLevelId);
}
else if (convCourseLearningCaseWithResourceRel.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseLevelName);
}
else if (convCourseLearningCaseWithResourceRel.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DocFile);
}
else if (convCourseLearningCaseWithResourceRel.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsNeedGeneWord);
}
else if (convCourseLearningCaseWithResourceRel.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.WordCreateDate);
}
else if (convCourseLearningCaseWithResourceRel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsVisible);
}
else if (convCourseLearningCaseWithResourceRel.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsDualVideo);
}
else if (convCourseLearningCaseWithResourceRel.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdXzCollege);
}
else if (convCourseLearningCaseWithResourceRel.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeID);
}
else if (convCourseLearningCaseWithResourceRel.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeName);
}
else if (convCourseLearningCaseWithResourceRel.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeNameA);
}
else if (convCourseLearningCaseWithResourceRel.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdXzMajor);
}
else if (convCourseLearningCaseWithResourceRel.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.MajorID);
}
else if (convCourseLearningCaseWithResourceRel.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.MajorName);
}
else if (convCourseLearningCaseWithResourceRel.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseId);
}
else if (convCourseLearningCaseWithResourceRel.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseCode);
}
else if (convCourseLearningCaseWithResourceRel.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseName);
}
else if (convCourseLearningCaseWithResourceRel.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachingSolutionId);
}
else if (convCourseLearningCaseWithResourceRel.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterId);
}
else if (convCourseLearningCaseWithResourceRel.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterName);
}
else if (convCourseLearningCaseWithResourceRel.ParentNodeID  ==  AttributeName[intIndex])
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeID);
}
else if (convCourseLearningCaseWithResourceRel.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeName);
}
else if (convCourseLearningCaseWithResourceRel.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterReferred);
}
else if (convCourseLearningCaseWithResourceRel.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeReferred);
}
else if (convCourseLearningCaseWithResourceRel.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ViewCount);
}
else if (convCourseLearningCaseWithResourceRel.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsShow);
}
else if (convCourseLearningCaseWithResourceRel.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DownloadNumber);
}
else if (convCourseLearningCaseWithResourceRel.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileIntegration);
}
else if (convCourseLearningCaseWithResourceRel.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.LikeCount);
}
else if (convCourseLearningCaseWithResourceRel.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollectionCount);
}
else if (convCourseLearningCaseWithResourceRel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
}
else if (convCourseLearningCaseWithResourceRel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.RecommendedDegreeName);
}
else if (convCourseLearningCaseWithResourceRel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.Memo);
}
else if (convCourseLearningCaseWithResourceRel.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.BrowseCount4Case);
}
else if (convCourseLearningCaseWithResourceRel.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerName);
}
else if (convCourseLearningCaseWithResourceRel.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerNameWithId);
}
else if (convCourseLearningCaseWithResourceRel.CaseTypeName  ==  AttributeName[intIndex])
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseTypeName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCourseLearningCase);
}
}
/// <summary>
/// 微格案例资源关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? IdMicroteachCaseResourceRel
{
get
{
return mlngIdMicroteachCaseResourceRel;
}
set
{
 mlngIdMicroteachCaseResourceRel = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FuncModuleId);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FuncModuleName);
}
}
/// <summary>
/// 资源流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResource
{
get
{
return mstrIdResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResource = value;
}
else
{
 mstrIdResource = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdResource);
}
}
/// <summary>
/// 资源ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceID
{
get
{
return mstrResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceID = value;
}
else
{
 mstrResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceID);
}
}
/// <summary>
/// 资源名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceName
{
get
{
return mstrResourceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceName = value;
}
else
{
 mstrResourceName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceName);
}
}
/// <summary>
/// FTP资源流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFtpResource
{
get
{
return mstrIdFtpResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFtpResource = value;
}
else
{
 mstrIdFtpResource = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdFtpResource);
}
}
/// <summary>
/// 文件流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFile
{
get
{
return mstrIdFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFile = value;
}
else
{
 mstrIdFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdFile);
}
}
/// <summary>
/// 文件大小(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileSize
{
get
{
return mstrFileSize;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileSize = value;
}
else
{
 mstrFileSize = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileSize);
}
}
/// <summary>
/// 创建时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SaveTime
{
get
{
return mstrSaveTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSaveTime = value;
}
else
{
 mstrSaveTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SaveTime);
}
}
/// <summary>
/// 资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResourceType
{
get
{
return mstrIdResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResourceType = value;
}
else
{
 mstrIdResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdResourceType);
}
}
/// <summary>
/// 资源类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeID
{
get
{
return mstrResourceTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeID = value;
}
else
{
 mstrResourceTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceTypeID);
}
}
/// <summary>
/// 资源类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeName
{
get
{
return mstrResourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeName = value;
}
else
{
 mstrResourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceTypeName);
}
}
/// <summary>
/// 上传者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceOwner
{
get
{
return mstrResourceOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceOwner = value;
}
else
{
 mstrResourceOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ResourceOwner);
}
}
/// <summary>
/// 是否存在文件(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistFile
{
get
{
return mbolIsExistFile;
}
set
{
 mbolIsExistFile = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsExistFile);
}
}
/// <summary>
/// 新文件名(说明:;字段类型:varchar;字段长度:530;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileNewName
{
get
{
return mstrFileNewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileNewName = value;
}
else
{
 mstrFileNewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileNewName);
}
}
/// <summary>
/// 是否主资源(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMain
{
get
{
return mbolIsMain;
}
set
{
 mbolIsMain = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsMain);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseText);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCaseType);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerId);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdStudyLevel);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.StudyLevelName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdTeachingPlan);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdDiscipline);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DisciplineID);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DisciplineName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.BrowseCount);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.VersionNo);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdTeachSkill);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillID);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SkillTypeName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillTheory);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdSkillType);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.SkillTypeID);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseLevelId);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseLevelName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DocFile);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsNeedGeneWord);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.WordCreateDate);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsVisible);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsDualVideo);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdXzCollege);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeID);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollegeNameA);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IdXzMajor);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.MajorID);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.MajorName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseId);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseCode);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseName);
}
}
/// <summary>
/// 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingSolutionId
{
get
{
return mstrTeachingSolutionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingSolutionId = value;
}
else
{
 mstrTeachingSolutionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.TeachingSolutionId);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterId);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeID);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CourseChapterReferred);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ParentNodeReferred);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.ViewCount);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.IsShow);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.DownloadNumber);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.FileIntegration);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.LikeCount);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CollectionCount);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.RecommendedDegreeName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.Memo);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.BrowseCount4Case);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerName);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.OwnerNameWithId);
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
 AddUpdatedFld(convCourseLearningCaseWithResourceRel.CaseTypeName);
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
}
 /// <summary>
 /// v课程学习案例With资源关系(vCourseLearningCaseWithResourceRel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCourseLearningCaseWithResourceRel
{
public const string _CurrTabName = "vCourseLearningCaseWithResourceRel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCourseLearningCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileSize", "SaveTime", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "IsExistFile", "FileNewName", "IsMain", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseText", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "IdCaseType", "IdCourseLearningCaseType", "CourseLearningCaseTypeName", "OwnerId", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdDiscipline", "DisciplineID", "DisciplineName", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "TeachingSolutionId", "CourseChapterId", "CourseChapterName", "ParentNodeID", "ParentNodeName", "CourseChapterReferred", "ParentNodeReferred", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "Memo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId", "CaseTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCourseLearningCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseLearningCase = "IdCourseLearningCase";    //课程学习案例流水号

 /// <summary>
 /// 常量:"IdMicroteachCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseResourceRel = "IdMicroteachCaseResourceRel";    //微格案例资源关系流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"ResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceID = "ResourceID";    //资源ID

 /// <summary>
 /// 常量:"ResourceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceName = "ResourceName";    //资源名称

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

 /// <summary>
 /// 常量:"IdFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFile = "IdFile";    //文件流水号

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"SaveTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveTime = "SaveTime";    //创建时间

 /// <summary>
 /// 常量:"IdResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResourceType = "IdResourceType";    //资源类型流水号

 /// <summary>
 /// 常量:"ResourceTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeID = "ResourceTypeID";    //资源类型ID

 /// <summary>
 /// 常量:"ResourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeName = "ResourceTypeName";    //资源类型名称

 /// <summary>
 /// 常量:"ResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceOwner = "ResourceOwner";    //上传者

 /// <summary>
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

 /// <summary>
 /// 常量:"FileNewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNewName = "FileNewName";    //新文件名

 /// <summary>
 /// 常量:"IsMain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMain = "IsMain";    //是否主资源

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
 /// 常量:"TeachingSolutionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionId = "TeachingSolutionId";    //教学方案Id

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

 /// <summary>
 /// 常量:"CaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTypeName = "CaseTypeName";    //案例类型名称
}

}