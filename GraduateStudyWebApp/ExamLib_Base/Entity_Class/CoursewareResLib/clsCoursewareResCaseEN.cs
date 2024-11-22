
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareResCaseEN
 表名:CoursewareResCase(01120418)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库(CoursewareResLib)
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
 /// 表CoursewareResCase的关键字(IdCoursewareResCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCoursewareResCase_CoursewareResCase
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
public K_IdCoursewareResCase_CoursewareResCase(string strIdCoursewareResCase)
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
 /// <returns>返回:[K_IdCoursewareResCase_CoursewareResCase]类型的对象</returns>
public static implicit operator K_IdCoursewareResCase_CoursewareResCase(string value)
{
return new K_IdCoursewareResCase_CoursewareResCase(value);
}
}
 /// <summary>
 /// 课件资源案例(CoursewareResCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCoursewareResCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CoursewareResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCoursewareResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 41;
public static string[] AttributeName = new string[] {"IdCoursewareResCase", "CoursewareResCaseID", "CoursewareResCaseName", "CoursewareResCaseTheme", "CoursewareResCaseText", "IdCoursewareResCaseType", "CoursewareResCaseDate", "CoursewareResCaseTime", "CoursewareResCaseDateIn", "CoursewareResCaseTimeIn", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "CourseChapterId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "ftpFileType", "CourseId", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdCoursewareResCase;    //课件资源案例流水号
protected string mstrCoursewareResCaseID;    //课件资源案例ID
protected string mstrCoursewareResCaseName;    //课件资源案例名称
protected string mstrCoursewareResCaseTheme;    //课件资源案例主题词
protected string mstrCoursewareResCaseText;    //案例文本内容
protected string mstrIdCoursewareResCaseType;    //课件资源类型流水号
protected string mstrCoursewareResCaseDate;    //视频资源日期
protected string mstrCoursewareResCaseTime;    //视频资源时间
protected string mstrCoursewareResCaseDateIn;    //案例入库日期
protected string mstrCoursewareResCaseTimeIn;    //案例入库时间
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
 public clsCoursewareResCaseEN()
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
public clsCoursewareResCaseEN(string strIdCoursewareResCase)
 {
strIdCoursewareResCase = strIdCoursewareResCase.Replace("'", "''");
if (strIdCoursewareResCase.Length > 8)
{
throw new Exception("在表:CoursewareResCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCoursewareResCase)  ==  true)
{
throw new Exception("在表:CoursewareResCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conCoursewareResCase.IdCoursewareResCase)
{
return mstrIdCoursewareResCase;
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseID)
{
return mstrCoursewareResCaseID;
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseName)
{
return mstrCoursewareResCaseName;
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseTheme)
{
return mstrCoursewareResCaseTheme;
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseText)
{
return mstrCoursewareResCaseText;
}
else if (strAttributeName  ==  conCoursewareResCase.IdCoursewareResCaseType)
{
return mstrIdCoursewareResCaseType;
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseDate)
{
return mstrCoursewareResCaseDate;
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseTime)
{
return mstrCoursewareResCaseTime;
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseDateIn)
{
return mstrCoursewareResCaseDateIn;
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseTimeIn)
{
return mstrCoursewareResCaseTimeIn;
}
else if (strAttributeName  ==  conCoursewareResCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conCoursewareResCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conCoursewareResCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conCoursewareResCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conCoursewareResCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conCoursewareResCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conCoursewareResCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conCoursewareResCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conCoursewareResCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conCoursewareResCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conCoursewareResCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conCoursewareResCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conCoursewareResCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conCoursewareResCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conCoursewareResCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conCoursewareResCase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  conCoursewareResCase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  conCoursewareResCase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conCoursewareResCase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  conCoursewareResCase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  conCoursewareResCase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  conCoursewareResCase.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conCoursewareResCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conCoursewareResCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conCoursewareResCase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conCoursewareResCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conCoursewareResCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conCoursewareResCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conCoursewareResCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCoursewareResCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCoursewareResCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCoursewareResCase.IdCoursewareResCase)
{
mstrIdCoursewareResCase = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdCoursewareResCase);
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseID)
{
mstrCoursewareResCaseID = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseID);
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseName)
{
mstrCoursewareResCaseName = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseName);
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseTheme)
{
mstrCoursewareResCaseTheme = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTheme);
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseText)
{
mstrCoursewareResCaseText = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseText);
}
else if (strAttributeName  ==  conCoursewareResCase.IdCoursewareResCaseType)
{
mstrIdCoursewareResCaseType = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdCoursewareResCaseType);
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseDate)
{
mstrCoursewareResCaseDate = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseDate);
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseTime)
{
mstrCoursewareResCaseTime = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTime);
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseDateIn)
{
mstrCoursewareResCaseDateIn = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseDateIn);
}
else if (strAttributeName  ==  conCoursewareResCase.CoursewareResCaseTimeIn)
{
mstrCoursewareResCaseTimeIn = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTimeIn);
}
else if (strAttributeName  ==  conCoursewareResCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.OwnerId);
}
else if (strAttributeName  ==  conCoursewareResCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdStudyLevel);
}
else if (strAttributeName  ==  conCoursewareResCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conCoursewareResCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdDiscipline);
}
else if (strAttributeName  ==  conCoursewareResCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.BrowseCount);
}
else if (strAttributeName  ==  conCoursewareResCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conCoursewareResCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdTeachSkill);
}
else if (strAttributeName  ==  conCoursewareResCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CaseLevelId);
}
else if (strAttributeName  ==  conCoursewareResCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conCoursewareResCase.DocFile);
}
else if (strAttributeName  ==  conCoursewareResCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareResCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conCoursewareResCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conCoursewareResCase.WordCreateDate);
}
else if (strAttributeName  ==  conCoursewareResCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareResCase.IsVisible);
}
else if (strAttributeName  ==  conCoursewareResCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareResCase.IsDualVideo);
}
else if (strAttributeName  ==  conCoursewareResCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdXzCollege);
}
else if (strAttributeName  ==  conCoursewareResCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdXzMajor);
}
else if (strAttributeName  ==  conCoursewareResCase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CourseChapterId);
}
else if (strAttributeName  ==  conCoursewareResCase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.ViewCount);
}
else if (strAttributeName  ==  conCoursewareResCase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareResCase.IsShow);
}
else if (strAttributeName  ==  conCoursewareResCase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.DownloadNumber);
}
else if (strAttributeName  ==  conCoursewareResCase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.FileIntegration);
}
else if (strAttributeName  ==  conCoursewareResCase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.LikeCount);
}
else if (strAttributeName  ==  conCoursewareResCase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.CollectionCount);
}
else if (strAttributeName  ==  conCoursewareResCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conCoursewareResCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conCoursewareResCase.ftpFileType);
}
else if (strAttributeName  ==  conCoursewareResCase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CourseId);
}
else if (strAttributeName  ==  conCoursewareResCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conCoursewareResCase.VideoUrl);
}
else if (strAttributeName  ==  conCoursewareResCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conCoursewareResCase.VideoPath);
}
else if (strAttributeName  ==  conCoursewareResCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conCoursewareResCase.ResErrMsg);
}
else if (strAttributeName  ==  conCoursewareResCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCoursewareResCase.UpdDate);
}
else if (strAttributeName  ==  conCoursewareResCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.UpdUserId);
}
else if (strAttributeName  ==  conCoursewareResCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCoursewareResCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCoursewareResCase.IdCoursewareResCase  ==  AttributeName[intIndex])
{
return mstrIdCoursewareResCase;
}
else if (conCoursewareResCase.CoursewareResCaseID  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseID;
}
else if (conCoursewareResCase.CoursewareResCaseName  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseName;
}
else if (conCoursewareResCase.CoursewareResCaseTheme  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTheme;
}
else if (conCoursewareResCase.CoursewareResCaseText  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseText;
}
else if (conCoursewareResCase.IdCoursewareResCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareResCaseType;
}
else if (conCoursewareResCase.CoursewareResCaseDate  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseDate;
}
else if (conCoursewareResCase.CoursewareResCaseTime  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTime;
}
else if (conCoursewareResCase.CoursewareResCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseDateIn;
}
else if (conCoursewareResCase.CoursewareResCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTimeIn;
}
else if (conCoursewareResCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conCoursewareResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conCoursewareResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conCoursewareResCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conCoursewareResCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conCoursewareResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conCoursewareResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conCoursewareResCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conCoursewareResCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conCoursewareResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conCoursewareResCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conCoursewareResCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conCoursewareResCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conCoursewareResCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conCoursewareResCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conCoursewareResCase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (conCoursewareResCase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (conCoursewareResCase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conCoursewareResCase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (conCoursewareResCase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (conCoursewareResCase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (conCoursewareResCase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conCoursewareResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conCoursewareResCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conCoursewareResCase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conCoursewareResCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conCoursewareResCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conCoursewareResCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conCoursewareResCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCoursewareResCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCoursewareResCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCoursewareResCase.IdCoursewareResCase  ==  AttributeName[intIndex])
{
mstrIdCoursewareResCase = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdCoursewareResCase);
}
else if (conCoursewareResCase.CoursewareResCaseID  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseID = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseID);
}
else if (conCoursewareResCase.CoursewareResCaseName  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseName = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseName);
}
else if (conCoursewareResCase.CoursewareResCaseTheme  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTheme = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTheme);
}
else if (conCoursewareResCase.CoursewareResCaseText  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseText = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseText);
}
else if (conCoursewareResCase.IdCoursewareResCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareResCaseType = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdCoursewareResCaseType);
}
else if (conCoursewareResCase.CoursewareResCaseDate  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseDate = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseDate);
}
else if (conCoursewareResCase.CoursewareResCaseTime  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTime = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTime);
}
else if (conCoursewareResCase.CoursewareResCaseDateIn  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseDateIn = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseDateIn);
}
else if (conCoursewareResCase.CoursewareResCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTimeIn = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTimeIn);
}
else if (conCoursewareResCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.OwnerId);
}
else if (conCoursewareResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdStudyLevel);
}
else if (conCoursewareResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdTeachingPlan);
}
else if (conCoursewareResCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdDiscipline);
}
else if (conCoursewareResCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.BrowseCount);
}
else if (conCoursewareResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdSenateGaugeVersion);
}
else if (conCoursewareResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdTeachSkill);
}
else if (conCoursewareResCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CaseLevelId);
}
else if (conCoursewareResCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conCoursewareResCase.DocFile);
}
else if (conCoursewareResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareResCase.IsNeedGeneWord);
}
else if (conCoursewareResCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conCoursewareResCase.WordCreateDate);
}
else if (conCoursewareResCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareResCase.IsVisible);
}
else if (conCoursewareResCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareResCase.IsDualVideo);
}
else if (conCoursewareResCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdXzCollege);
}
else if (conCoursewareResCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conCoursewareResCase.IdXzMajor);
}
else if (conCoursewareResCase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CourseChapterId);
}
else if (conCoursewareResCase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.ViewCount);
}
else if (conCoursewareResCase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareResCase.IsShow);
}
else if (conCoursewareResCase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.DownloadNumber);
}
else if (conCoursewareResCase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.FileIntegration);
}
else if (conCoursewareResCase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.LikeCount);
}
else if (conCoursewareResCase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareResCase.CollectionCount);
}
else if (conCoursewareResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.RecommendedDegreeId);
}
else if (conCoursewareResCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conCoursewareResCase.ftpFileType);
}
else if (conCoursewareResCase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.CourseId);
}
else if (conCoursewareResCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conCoursewareResCase.VideoUrl);
}
else if (conCoursewareResCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conCoursewareResCase.VideoPath);
}
else if (conCoursewareResCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conCoursewareResCase.ResErrMsg);
}
else if (conCoursewareResCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCoursewareResCase.UpdDate);
}
else if (conCoursewareResCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCoursewareResCase.UpdUserId);
}
else if (conCoursewareResCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCoursewareResCase.Memo);
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
 AddUpdatedFld(conCoursewareResCase.IdCoursewareResCase);
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
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseID);
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
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseName);
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
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTheme);
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
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseText);
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
 AddUpdatedFld(conCoursewareResCase.IdCoursewareResCaseType);
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
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseDate);
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
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTime);
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
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseDateIn);
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
 AddUpdatedFld(conCoursewareResCase.CoursewareResCaseTimeIn);
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
 AddUpdatedFld(conCoursewareResCase.OwnerId);
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
 AddUpdatedFld(conCoursewareResCase.IdStudyLevel);
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
 AddUpdatedFld(conCoursewareResCase.IdTeachingPlan);
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
 AddUpdatedFld(conCoursewareResCase.IdDiscipline);
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
 AddUpdatedFld(conCoursewareResCase.BrowseCount);
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
 AddUpdatedFld(conCoursewareResCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conCoursewareResCase.IdTeachSkill);
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
 AddUpdatedFld(conCoursewareResCase.CaseLevelId);
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
 AddUpdatedFld(conCoursewareResCase.DocFile);
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
 AddUpdatedFld(conCoursewareResCase.IsNeedGeneWord);
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
 AddUpdatedFld(conCoursewareResCase.WordCreateDate);
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
 AddUpdatedFld(conCoursewareResCase.IsVisible);
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
 AddUpdatedFld(conCoursewareResCase.IsDualVideo);
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
 AddUpdatedFld(conCoursewareResCase.IdXzCollege);
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
 AddUpdatedFld(conCoursewareResCase.IdXzMajor);
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
 AddUpdatedFld(conCoursewareResCase.CourseChapterId);
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
 AddUpdatedFld(conCoursewareResCase.ViewCount);
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
 AddUpdatedFld(conCoursewareResCase.IsShow);
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
 AddUpdatedFld(conCoursewareResCase.DownloadNumber);
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
 AddUpdatedFld(conCoursewareResCase.FileIntegration);
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
 AddUpdatedFld(conCoursewareResCase.LikeCount);
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
 AddUpdatedFld(conCoursewareResCase.CollectionCount);
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
 AddUpdatedFld(conCoursewareResCase.RecommendedDegreeId);
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
 AddUpdatedFld(conCoursewareResCase.ftpFileType);
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
 AddUpdatedFld(conCoursewareResCase.CourseId);
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
 AddUpdatedFld(conCoursewareResCase.VideoUrl);
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
 AddUpdatedFld(conCoursewareResCase.VideoPath);
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
 AddUpdatedFld(conCoursewareResCase.ResErrMsg);
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
 AddUpdatedFld(conCoursewareResCase.UpdDate);
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
 AddUpdatedFld(conCoursewareResCase.UpdUserId);
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
 AddUpdatedFld(conCoursewareResCase.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrCoursewareResCaseName;
 }
 }
}
 /// <summary>
 /// 课件资源案例(CoursewareResCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCoursewareResCase
{
public const string _CurrTabName = "CoursewareResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCoursewareResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCoursewareResCase", "CoursewareResCaseID", "CoursewareResCaseName", "CoursewareResCaseTheme", "CoursewareResCaseText", "IdCoursewareResCaseType", "CoursewareResCaseDate", "CoursewareResCaseTime", "CoursewareResCaseDateIn", "CoursewareResCaseTimeIn", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "CourseChapterId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "ftpFileType", "CourseId", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
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