
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCourseLearningCaseEN
 表名:CourseLearningCase(01120274)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表CourseLearningCase的关键字(IdCourseLearningCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCourseLearningCase_CourseLearningCase
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
public K_IdCourseLearningCase_CourseLearningCase(string strIdCourseLearningCase)
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
 /// <returns>返回:[K_IdCourseLearningCase_CourseLearningCase]类型的对象</returns>
public static implicit operator K_IdCourseLearningCase_CourseLearningCase(string value)
{
return new K_IdCourseLearningCase_CourseLearningCase(value);
}
}
 /// <summary>
 /// 课程学习案例(CourseLearningCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCourseLearningCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CourseLearningCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCourseLearningCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 45;
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseText", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "IdCaseType", "IdCourseLearningCaseType", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "CourseId", "TeachingSolutionId", "CourseChapterId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ImageUrl", "ResErrMsg", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

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
protected string mstrIdCourseLearningCaseType;    //课程学习案例类型流水号
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdStudyLevel;    //学段流水号
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdDiscipline;    //学科流水号
protected int? mintBrowseCount;    //浏览次数
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrCaseLevelId;    //课例等级Id
protected string mstrDocFile;    //生成的Word文件名
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrCourseId;    //课程Id
protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrCourseChapterId;    //课程章节ID
protected int? mintViewCount;    //浏览量
protected bool mbolIsShow;    //是否启用
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrImageUrl;    //ImageUrl
protected string mstrResErrMsg;    //资源错误信息
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCourseLearningCaseEN()
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
public clsCourseLearningCaseEN(string strIdCourseLearningCase)
 {
strIdCourseLearningCase = strIdCourseLearningCase.Replace("'", "''");
if (strIdCourseLearningCase.Length > 8)
{
throw new Exception("在表:CourseLearningCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("在表:CourseLearningCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conCourseLearningCase.IdCourseLearningCase)
{
return mstrIdCourseLearningCase;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseID)
{
return mstrCourseLearningCaseID;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseName)
{
return mstrCourseLearningCaseName;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseText)
{
return mstrCourseLearningCaseText;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseTheme)
{
return mstrCourseLearningCaseTheme;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseDate)
{
return mstrCourseLearningCaseDate;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseTime)
{
return mstrCourseLearningCaseTime;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseDateIn)
{
return mstrCourseLearningCaseDateIn;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseTimeIn)
{
return mstrCourseLearningCaseTimeIn;
}
else if (strAttributeName  ==  conCourseLearningCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conCourseLearningCase.IdCourseLearningCaseType)
{
return mstrIdCourseLearningCaseType;
}
else if (strAttributeName  ==  conCourseLearningCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conCourseLearningCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conCourseLearningCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conCourseLearningCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conCourseLearningCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conCourseLearningCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conCourseLearningCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conCourseLearningCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conCourseLearningCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conCourseLearningCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conCourseLearningCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conCourseLearningCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conCourseLearningCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conCourseLearningCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conCourseLearningCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conCourseLearningCase.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  conCourseLearningCase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  conCourseLearningCase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  conCourseLearningCase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conCourseLearningCase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  conCourseLearningCase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  conCourseLearningCase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  conCourseLearningCase.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conCourseLearningCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conCourseLearningCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conCourseLearningCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conCourseLearningCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conCourseLearningCase.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  conCourseLearningCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conCourseLearningCase.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCourseLearningCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCourseLearningCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCourseLearningCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCourseLearningCase.IdCourseLearningCase)
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdCourseLearningCase);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseID)
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseID);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseName)
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseName);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseText)
{
mstrCourseLearningCaseText = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseText);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseTheme)
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTheme);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseDate)
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseDate);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseTime)
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTime);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseDateIn)
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseDateIn);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseLearningCaseTimeIn)
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTimeIn);
}
else if (strAttributeName  ==  conCourseLearningCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdCaseType);
}
else if (strAttributeName  ==  conCourseLearningCase.IdCourseLearningCaseType)
{
mstrIdCourseLearningCaseType = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdCourseLearningCaseType);
}
else if (strAttributeName  ==  conCourseLearningCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.OwnerId);
}
else if (strAttributeName  ==  conCourseLearningCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdStudyLevel);
}
else if (strAttributeName  ==  conCourseLearningCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conCourseLearningCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdDiscipline);
}
else if (strAttributeName  ==  conCourseLearningCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.BrowseCount);
}
else if (strAttributeName  ==  conCourseLearningCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conCourseLearningCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdTeachSkill);
}
else if (strAttributeName  ==  conCourseLearningCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CaseLevelId);
}
else if (strAttributeName  ==  conCourseLearningCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conCourseLearningCase.DocFile);
}
else if (strAttributeName  ==  conCourseLearningCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conCourseLearningCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conCourseLearningCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conCourseLearningCase.WordCreateDate);
}
else if (strAttributeName  ==  conCourseLearningCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCourseLearningCase.IsVisible);
}
else if (strAttributeName  ==  conCourseLearningCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conCourseLearningCase.IsDualVideo);
}
else if (strAttributeName  ==  conCourseLearningCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdXzCollege);
}
else if (strAttributeName  ==  conCourseLearningCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdXzMajor);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseId);
}
else if (strAttributeName  ==  conCourseLearningCase.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.TeachingSolutionId);
}
else if (strAttributeName  ==  conCourseLearningCase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseChapterId);
}
else if (strAttributeName  ==  conCourseLearningCase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.ViewCount);
}
else if (strAttributeName  ==  conCourseLearningCase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conCourseLearningCase.IsShow);
}
else if (strAttributeName  ==  conCourseLearningCase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.DownloadNumber);
}
else if (strAttributeName  ==  conCourseLearningCase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.FileIntegration);
}
else if (strAttributeName  ==  conCourseLearningCase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.LikeCount);
}
else if (strAttributeName  ==  conCourseLearningCase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.CollectionCount);
}
else if (strAttributeName  ==  conCourseLearningCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conCourseLearningCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conCourseLearningCase.ftpFileType);
}
else if (strAttributeName  ==  conCourseLearningCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conCourseLearningCase.VideoUrl);
}
else if (strAttributeName  ==  conCourseLearningCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conCourseLearningCase.VideoPath);
}
else if (strAttributeName  ==  conCourseLearningCase.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conCourseLearningCase.ImageUrl);
}
else if (strAttributeName  ==  conCourseLearningCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conCourseLearningCase.ResErrMsg);
}
else if (strAttributeName  ==  conCourseLearningCase.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.OrderNum);
}
else if (strAttributeName  ==  conCourseLearningCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCourseLearningCase.UpdDate);
}
else if (strAttributeName  ==  conCourseLearningCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.UpdUserId);
}
else if (strAttributeName  ==  conCourseLearningCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCourseLearningCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCourseLearningCase.IdCourseLearningCase  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCase;
}
else if (conCourseLearningCase.CourseLearningCaseID  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseID;
}
else if (conCourseLearningCase.CourseLearningCaseName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseName;
}
else if (conCourseLearningCase.CourseLearningCaseText  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseText;
}
else if (conCourseLearningCase.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTheme;
}
else if (conCourseLearningCase.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDate;
}
else if (conCourseLearningCase.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTime;
}
else if (conCourseLearningCase.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDateIn;
}
else if (conCourseLearningCase.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTimeIn;
}
else if (conCourseLearningCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conCourseLearningCase.IdCourseLearningCaseType  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCaseType;
}
else if (conCourseLearningCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conCourseLearningCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conCourseLearningCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conCourseLearningCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conCourseLearningCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conCourseLearningCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conCourseLearningCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conCourseLearningCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conCourseLearningCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conCourseLearningCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conCourseLearningCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conCourseLearningCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conCourseLearningCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conCourseLearningCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conCourseLearningCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conCourseLearningCase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conCourseLearningCase.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (conCourseLearningCase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (conCourseLearningCase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (conCourseLearningCase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conCourseLearningCase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (conCourseLearningCase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (conCourseLearningCase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (conCourseLearningCase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conCourseLearningCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conCourseLearningCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conCourseLearningCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conCourseLearningCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conCourseLearningCase.ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (conCourseLearningCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conCourseLearningCase.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCourseLearningCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCourseLearningCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCourseLearningCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCourseLearningCase.IdCourseLearningCase  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdCourseLearningCase);
}
else if (conCourseLearningCase.CourseLearningCaseID  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseID);
}
else if (conCourseLearningCase.CourseLearningCaseName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseName);
}
else if (conCourseLearningCase.CourseLearningCaseText  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseText = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseText);
}
else if (conCourseLearningCase.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTheme);
}
else if (conCourseLearningCase.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseDate);
}
else if (conCourseLearningCase.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTime);
}
else if (conCourseLearningCase.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseDateIn);
}
else if (conCourseLearningCase.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTimeIn);
}
else if (conCourseLearningCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdCaseType);
}
else if (conCourseLearningCase.IdCourseLearningCaseType  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCaseType = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdCourseLearningCaseType);
}
else if (conCourseLearningCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.OwnerId);
}
else if (conCourseLearningCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdStudyLevel);
}
else if (conCourseLearningCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdTeachingPlan);
}
else if (conCourseLearningCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdDiscipline);
}
else if (conCourseLearningCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.BrowseCount);
}
else if (conCourseLearningCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdSenateGaugeVersion);
}
else if (conCourseLearningCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdTeachSkill);
}
else if (conCourseLearningCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CaseLevelId);
}
else if (conCourseLearningCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conCourseLearningCase.DocFile);
}
else if (conCourseLearningCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conCourseLearningCase.IsNeedGeneWord);
}
else if (conCourseLearningCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conCourseLearningCase.WordCreateDate);
}
else if (conCourseLearningCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCourseLearningCase.IsVisible);
}
else if (conCourseLearningCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conCourseLearningCase.IsDualVideo);
}
else if (conCourseLearningCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdXzCollege);
}
else if (conCourseLearningCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conCourseLearningCase.IdXzMajor);
}
else if (conCourseLearningCase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseId);
}
else if (conCourseLearningCase.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.TeachingSolutionId);
}
else if (conCourseLearningCase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.CourseChapterId);
}
else if (conCourseLearningCase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.ViewCount);
}
else if (conCourseLearningCase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conCourseLearningCase.IsShow);
}
else if (conCourseLearningCase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.DownloadNumber);
}
else if (conCourseLearningCase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.FileIntegration);
}
else if (conCourseLearningCase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.LikeCount);
}
else if (conCourseLearningCase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.CollectionCount);
}
else if (conCourseLearningCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.RecommendedDegreeId);
}
else if (conCourseLearningCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conCourseLearningCase.ftpFileType);
}
else if (conCourseLearningCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conCourseLearningCase.VideoUrl);
}
else if (conCourseLearningCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conCourseLearningCase.VideoPath);
}
else if (conCourseLearningCase.ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conCourseLearningCase.ImageUrl);
}
else if (conCourseLearningCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conCourseLearningCase.ResErrMsg);
}
else if (conCourseLearningCase.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCourseLearningCase.OrderNum);
}
else if (conCourseLearningCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCourseLearningCase.UpdDate);
}
else if (conCourseLearningCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCourseLearningCase.UpdUserId);
}
else if (conCourseLearningCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCourseLearningCase.Memo);
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
 AddUpdatedFld(conCourseLearningCase.IdCourseLearningCase);
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
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseID);
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
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseName);
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
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseText);
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
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTheme);
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
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseDate);
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
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTime);
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
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseDateIn);
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
 AddUpdatedFld(conCourseLearningCase.CourseLearningCaseTimeIn);
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
 AddUpdatedFld(conCourseLearningCase.IdCaseType);
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
 AddUpdatedFld(conCourseLearningCase.IdCourseLearningCaseType);
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
 AddUpdatedFld(conCourseLearningCase.OwnerId);
}
}
/// <summary>
/// 学段流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
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
 AddUpdatedFld(conCourseLearningCase.IdStudyLevel);
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
 AddUpdatedFld(conCourseLearningCase.IdTeachingPlan);
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
 AddUpdatedFld(conCourseLearningCase.IdDiscipline);
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
 AddUpdatedFld(conCourseLearningCase.BrowseCount);
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
 AddUpdatedFld(conCourseLearningCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conCourseLearningCase.IdTeachSkill);
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
 AddUpdatedFld(conCourseLearningCase.CaseLevelId);
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
 AddUpdatedFld(conCourseLearningCase.DocFile);
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
 AddUpdatedFld(conCourseLearningCase.IsNeedGeneWord);
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
 AddUpdatedFld(conCourseLearningCase.WordCreateDate);
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
 AddUpdatedFld(conCourseLearningCase.IsVisible);
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
 AddUpdatedFld(conCourseLearningCase.IsDualVideo);
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
 AddUpdatedFld(conCourseLearningCase.IdXzCollege);
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
 AddUpdatedFld(conCourseLearningCase.IdXzMajor);
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
 AddUpdatedFld(conCourseLearningCase.CourseId);
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
 AddUpdatedFld(conCourseLearningCase.TeachingSolutionId);
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
 AddUpdatedFld(conCourseLearningCase.CourseChapterId);
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
 AddUpdatedFld(conCourseLearningCase.ViewCount);
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
 AddUpdatedFld(conCourseLearningCase.IsShow);
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
 AddUpdatedFld(conCourseLearningCase.DownloadNumber);
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
 AddUpdatedFld(conCourseLearningCase.FileIntegration);
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
 AddUpdatedFld(conCourseLearningCase.LikeCount);
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
 AddUpdatedFld(conCourseLearningCase.CollectionCount);
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
 AddUpdatedFld(conCourseLearningCase.RecommendedDegreeId);
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
 AddUpdatedFld(conCourseLearningCase.ftpFileType);
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
 AddUpdatedFld(conCourseLearningCase.VideoUrl);
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
 AddUpdatedFld(conCourseLearningCase.VideoPath);
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
 AddUpdatedFld(conCourseLearningCase.ImageUrl);
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
 AddUpdatedFld(conCourseLearningCase.ResErrMsg);
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
 AddUpdatedFld(conCourseLearningCase.OrderNum);
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
 AddUpdatedFld(conCourseLearningCase.UpdDate);
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
 AddUpdatedFld(conCourseLearningCase.UpdUserId);
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
 AddUpdatedFld(conCourseLearningCase.Memo);
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
 /// 课程学习案例(CourseLearningCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCourseLearningCase
{
public const string _CurrTabName = "CourseLearningCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCourseLearningCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseText", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "IdCaseType", "IdCourseLearningCaseType", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "CourseId", "TeachingSolutionId", "CourseChapterId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ImageUrl", "ResErrMsg", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"IdCourseLearningCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseLearningCaseType = "IdCourseLearningCaseType";    //课程学习案例类型流水号

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //学段流水号

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
 /// 常量:"IdTeachSkill"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachSkill = "IdTeachSkill";    //教学技能流水号

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
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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
}

}