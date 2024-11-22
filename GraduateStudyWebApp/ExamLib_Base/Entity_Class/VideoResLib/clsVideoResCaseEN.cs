
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoResCaseEN
 表名:VideoResCase(01120371)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:59
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
 /// 表VideoResCase的关键字(IdVideoResCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoResCase_VideoResCase
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
public K_IdVideoResCase_VideoResCase(string strIdVideoResCase)
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
 /// <returns>返回:[K_IdVideoResCase_VideoResCase]类型的对象</returns>
public static implicit operator K_IdVideoResCase_VideoResCase(string value)
{
return new K_IdVideoResCase_VideoResCase(value);
}
}
 /// <summary>
 /// 视频资源案例(VideoResCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsVideoResCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "VideoResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 41;
public static string[] AttributeName = new string[] {"IdVideoResCase", "VideoResCaseID", "VideoResCaseName", "VideoResCaseTheme", "IdVideoResCaseType", "VideoResCaseText", "VideoResCaseDate", "VideoResCaseTime", "VideoResCaseDateIn", "VideoResCaseTimeIn", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "CourseChapterId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "ftpFileType", "CourseId", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdVideoResCase;    //视频资源案例流水号
protected string mstrVideoResCaseID;    //视频资源案例ID
protected string mstrVideoResCaseName;    //视频资源案例名称
protected string mstrVideoResCaseTheme;    //视频资源案例主题词
protected string mstrIdVideoResCaseType;    //视频资源类型流水号
protected string mstrVideoResCaseText;    //案例文本内容
protected string mstrVideoResCaseDate;    //视频资源日期
protected string mstrVideoResCaseTime;    //视频资源时间
protected string mstrVideoResCaseDateIn;    //案例入库日期
protected string mstrVideoResCaseTimeIn;    //案例入库时间
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdStudyLevel;    //id_StudyLevel
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
protected string mstrCourseChapterId;    //课程章节ID
protected int? mintViewCount;    //浏览量
protected bool mbolIsShow;    //是否启用
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrftpFileType;    //ftp文件类型
protected string mstrCourseId;    //课程Id
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsVideoResCaseEN()
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
public clsVideoResCaseEN(string strIdVideoResCase)
 {
strIdVideoResCase = strIdVideoResCase.Replace("'", "''");
if (strIdVideoResCase.Length > 8)
{
throw new Exception("在表:VideoResCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdVideoResCase)  ==  true)
{
throw new Exception("在表:VideoResCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conVideoResCase.IdVideoResCase)
{
return mstrIdVideoResCase;
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseID)
{
return mstrVideoResCaseID;
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseName)
{
return mstrVideoResCaseName;
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseTheme)
{
return mstrVideoResCaseTheme;
}
else if (strAttributeName  ==  conVideoResCase.IdVideoResCaseType)
{
return mstrIdVideoResCaseType;
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseText)
{
return mstrVideoResCaseText;
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseDate)
{
return mstrVideoResCaseDate;
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseTime)
{
return mstrVideoResCaseTime;
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseDateIn)
{
return mstrVideoResCaseDateIn;
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseTimeIn)
{
return mstrVideoResCaseTimeIn;
}
else if (strAttributeName  ==  conVideoResCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conVideoResCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conVideoResCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conVideoResCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conVideoResCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conVideoResCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conVideoResCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conVideoResCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conVideoResCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conVideoResCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conVideoResCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conVideoResCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conVideoResCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conVideoResCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conVideoResCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conVideoResCase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  conVideoResCase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  conVideoResCase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conVideoResCase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  conVideoResCase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  conVideoResCase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  conVideoResCase.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conVideoResCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conVideoResCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conVideoResCase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conVideoResCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conVideoResCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conVideoResCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conVideoResCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conVideoResCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conVideoResCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conVideoResCase.IdVideoResCase)
{
mstrIdVideoResCase = value.ToString();
 AddUpdatedFld(conVideoResCase.IdVideoResCase);
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseID)
{
mstrVideoResCaseID = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseID);
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseName)
{
mstrVideoResCaseName = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseName);
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseTheme)
{
mstrVideoResCaseTheme = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseTheme);
}
else if (strAttributeName  ==  conVideoResCase.IdVideoResCaseType)
{
mstrIdVideoResCaseType = value.ToString();
 AddUpdatedFld(conVideoResCase.IdVideoResCaseType);
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseText)
{
mstrVideoResCaseText = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseText);
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseDate)
{
mstrVideoResCaseDate = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseDate);
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseTime)
{
mstrVideoResCaseTime = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseTime);
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseDateIn)
{
mstrVideoResCaseDateIn = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseDateIn);
}
else if (strAttributeName  ==  conVideoResCase.VideoResCaseTimeIn)
{
mstrVideoResCaseTimeIn = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseTimeIn);
}
else if (strAttributeName  ==  conVideoResCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conVideoResCase.OwnerId);
}
else if (strAttributeName  ==  conVideoResCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conVideoResCase.IdStudyLevel);
}
else if (strAttributeName  ==  conVideoResCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conVideoResCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conVideoResCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conVideoResCase.IdDiscipline);
}
else if (strAttributeName  ==  conVideoResCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.BrowseCount);
}
else if (strAttributeName  ==  conVideoResCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conVideoResCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conVideoResCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conVideoResCase.IdTeachSkill);
}
else if (strAttributeName  ==  conVideoResCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conVideoResCase.CaseLevelId);
}
else if (strAttributeName  ==  conVideoResCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conVideoResCase.DocFile);
}
else if (strAttributeName  ==  conVideoResCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoResCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conVideoResCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conVideoResCase.WordCreateDate);
}
else if (strAttributeName  ==  conVideoResCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoResCase.IsVisible);
}
else if (strAttributeName  ==  conVideoResCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoResCase.IsDualVideo);
}
else if (strAttributeName  ==  conVideoResCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conVideoResCase.IdXzCollege);
}
else if (strAttributeName  ==  conVideoResCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conVideoResCase.IdXzMajor);
}
else if (strAttributeName  ==  conVideoResCase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conVideoResCase.CourseChapterId);
}
else if (strAttributeName  ==  conVideoResCase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.ViewCount);
}
else if (strAttributeName  ==  conVideoResCase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoResCase.IsShow);
}
else if (strAttributeName  ==  conVideoResCase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.DownloadNumber);
}
else if (strAttributeName  ==  conVideoResCase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.FileIntegration);
}
else if (strAttributeName  ==  conVideoResCase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.LikeCount);
}
else if (strAttributeName  ==  conVideoResCase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.CollectionCount);
}
else if (strAttributeName  ==  conVideoResCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conVideoResCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conVideoResCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conVideoResCase.ftpFileType);
}
else if (strAttributeName  ==  conVideoResCase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conVideoResCase.CourseId);
}
else if (strAttributeName  ==  conVideoResCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoUrl);
}
else if (strAttributeName  ==  conVideoResCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoPath);
}
else if (strAttributeName  ==  conVideoResCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conVideoResCase.ResErrMsg);
}
else if (strAttributeName  ==  conVideoResCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conVideoResCase.UpdDate);
}
else if (strAttributeName  ==  conVideoResCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conVideoResCase.UpdUserId);
}
else if (strAttributeName  ==  conVideoResCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoResCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conVideoResCase.IdVideoResCase  ==  AttributeName[intIndex])
{
return mstrIdVideoResCase;
}
else if (conVideoResCase.VideoResCaseID  ==  AttributeName[intIndex])
{
return mstrVideoResCaseID;
}
else if (conVideoResCase.VideoResCaseName  ==  AttributeName[intIndex])
{
return mstrVideoResCaseName;
}
else if (conVideoResCase.VideoResCaseTheme  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTheme;
}
else if (conVideoResCase.IdVideoResCaseType  ==  AttributeName[intIndex])
{
return mstrIdVideoResCaseType;
}
else if (conVideoResCase.VideoResCaseText  ==  AttributeName[intIndex])
{
return mstrVideoResCaseText;
}
else if (conVideoResCase.VideoResCaseDate  ==  AttributeName[intIndex])
{
return mstrVideoResCaseDate;
}
else if (conVideoResCase.VideoResCaseTime  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTime;
}
else if (conVideoResCase.VideoResCaseDateIn  ==  AttributeName[intIndex])
{
return mstrVideoResCaseDateIn;
}
else if (conVideoResCase.VideoResCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTimeIn;
}
else if (conVideoResCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conVideoResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conVideoResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conVideoResCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conVideoResCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conVideoResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conVideoResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conVideoResCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conVideoResCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conVideoResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conVideoResCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conVideoResCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conVideoResCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conVideoResCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conVideoResCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conVideoResCase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (conVideoResCase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (conVideoResCase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conVideoResCase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (conVideoResCase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (conVideoResCase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (conVideoResCase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conVideoResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conVideoResCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conVideoResCase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conVideoResCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conVideoResCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conVideoResCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conVideoResCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conVideoResCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conVideoResCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conVideoResCase.IdVideoResCase  ==  AttributeName[intIndex])
{
mstrIdVideoResCase = value.ToString();
 AddUpdatedFld(conVideoResCase.IdVideoResCase);
}
else if (conVideoResCase.VideoResCaseID  ==  AttributeName[intIndex])
{
mstrVideoResCaseID = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseID);
}
else if (conVideoResCase.VideoResCaseName  ==  AttributeName[intIndex])
{
mstrVideoResCaseName = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseName);
}
else if (conVideoResCase.VideoResCaseTheme  ==  AttributeName[intIndex])
{
mstrVideoResCaseTheme = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseTheme);
}
else if (conVideoResCase.IdVideoResCaseType  ==  AttributeName[intIndex])
{
mstrIdVideoResCaseType = value.ToString();
 AddUpdatedFld(conVideoResCase.IdVideoResCaseType);
}
else if (conVideoResCase.VideoResCaseText  ==  AttributeName[intIndex])
{
mstrVideoResCaseText = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseText);
}
else if (conVideoResCase.VideoResCaseDate  ==  AttributeName[intIndex])
{
mstrVideoResCaseDate = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseDate);
}
else if (conVideoResCase.VideoResCaseTime  ==  AttributeName[intIndex])
{
mstrVideoResCaseTime = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseTime);
}
else if (conVideoResCase.VideoResCaseDateIn  ==  AttributeName[intIndex])
{
mstrVideoResCaseDateIn = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseDateIn);
}
else if (conVideoResCase.VideoResCaseTimeIn  ==  AttributeName[intIndex])
{
mstrVideoResCaseTimeIn = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoResCaseTimeIn);
}
else if (conVideoResCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conVideoResCase.OwnerId);
}
else if (conVideoResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conVideoResCase.IdStudyLevel);
}
else if (conVideoResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conVideoResCase.IdTeachingPlan);
}
else if (conVideoResCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conVideoResCase.IdDiscipline);
}
else if (conVideoResCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.BrowseCount);
}
else if (conVideoResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conVideoResCase.IdSenateGaugeVersion);
}
else if (conVideoResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conVideoResCase.IdTeachSkill);
}
else if (conVideoResCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conVideoResCase.CaseLevelId);
}
else if (conVideoResCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conVideoResCase.DocFile);
}
else if (conVideoResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoResCase.IsNeedGeneWord);
}
else if (conVideoResCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conVideoResCase.WordCreateDate);
}
else if (conVideoResCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoResCase.IsVisible);
}
else if (conVideoResCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoResCase.IsDualVideo);
}
else if (conVideoResCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conVideoResCase.IdXzCollege);
}
else if (conVideoResCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conVideoResCase.IdXzMajor);
}
else if (conVideoResCase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conVideoResCase.CourseChapterId);
}
else if (conVideoResCase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.ViewCount);
}
else if (conVideoResCase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoResCase.IsShow);
}
else if (conVideoResCase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.DownloadNumber);
}
else if (conVideoResCase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.FileIntegration);
}
else if (conVideoResCase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.LikeCount);
}
else if (conVideoResCase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoResCase.CollectionCount);
}
else if (conVideoResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conVideoResCase.RecommendedDegreeId);
}
else if (conVideoResCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conVideoResCase.ftpFileType);
}
else if (conVideoResCase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conVideoResCase.CourseId);
}
else if (conVideoResCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoUrl);
}
else if (conVideoResCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conVideoResCase.VideoPath);
}
else if (conVideoResCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conVideoResCase.ResErrMsg);
}
else if (conVideoResCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conVideoResCase.UpdDate);
}
else if (conVideoResCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conVideoResCase.UpdUserId);
}
else if (conVideoResCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoResCase.Memo);
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
 AddUpdatedFld(conVideoResCase.IdVideoResCase);
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
 AddUpdatedFld(conVideoResCase.VideoResCaseID);
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
 AddUpdatedFld(conVideoResCase.VideoResCaseName);
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
 AddUpdatedFld(conVideoResCase.VideoResCaseTheme);
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
 AddUpdatedFld(conVideoResCase.IdVideoResCaseType);
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
 AddUpdatedFld(conVideoResCase.VideoResCaseText);
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
 AddUpdatedFld(conVideoResCase.VideoResCaseDate);
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
 AddUpdatedFld(conVideoResCase.VideoResCaseTime);
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
 AddUpdatedFld(conVideoResCase.VideoResCaseDateIn);
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
 AddUpdatedFld(conVideoResCase.VideoResCaseTimeIn);
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
 AddUpdatedFld(conVideoResCase.OwnerId);
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
 AddUpdatedFld(conVideoResCase.IdStudyLevel);
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
 AddUpdatedFld(conVideoResCase.IdTeachingPlan);
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
 AddUpdatedFld(conVideoResCase.IdDiscipline);
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
 AddUpdatedFld(conVideoResCase.BrowseCount);
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
 AddUpdatedFld(conVideoResCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conVideoResCase.IdTeachSkill);
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
 AddUpdatedFld(conVideoResCase.CaseLevelId);
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
 AddUpdatedFld(conVideoResCase.DocFile);
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
 AddUpdatedFld(conVideoResCase.IsNeedGeneWord);
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
 AddUpdatedFld(conVideoResCase.WordCreateDate);
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
 AddUpdatedFld(conVideoResCase.IsVisible);
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
 AddUpdatedFld(conVideoResCase.IsDualVideo);
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
 AddUpdatedFld(conVideoResCase.IdXzCollege);
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
 AddUpdatedFld(conVideoResCase.IdXzMajor);
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
 AddUpdatedFld(conVideoResCase.CourseChapterId);
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
 AddUpdatedFld(conVideoResCase.ViewCount);
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
 AddUpdatedFld(conVideoResCase.IsShow);
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
 AddUpdatedFld(conVideoResCase.DownloadNumber);
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
 AddUpdatedFld(conVideoResCase.FileIntegration);
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
 AddUpdatedFld(conVideoResCase.LikeCount);
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
 AddUpdatedFld(conVideoResCase.CollectionCount);
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
 AddUpdatedFld(conVideoResCase.RecommendedDegreeId);
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
 AddUpdatedFld(conVideoResCase.ftpFileType);
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
 AddUpdatedFld(conVideoResCase.CourseId);
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
 AddUpdatedFld(conVideoResCase.VideoUrl);
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
 AddUpdatedFld(conVideoResCase.VideoPath);
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
 AddUpdatedFld(conVideoResCase.ResErrMsg);
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
 AddUpdatedFld(conVideoResCase.UpdDate);
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
 AddUpdatedFld(conVideoResCase.UpdUserId);
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
 AddUpdatedFld(conVideoResCase.Memo);
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
 /// 视频资源案例(VideoResCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conVideoResCase
{
public const string _CurrTabName = "VideoResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoResCase", "VideoResCaseID", "VideoResCaseName", "VideoResCaseTheme", "IdVideoResCaseType", "VideoResCaseText", "VideoResCaseDate", "VideoResCaseTime", "VideoResCaseDateIn", "VideoResCaseTimeIn", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "CourseChapterId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "ftpFileType", "CourseId", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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
}

}