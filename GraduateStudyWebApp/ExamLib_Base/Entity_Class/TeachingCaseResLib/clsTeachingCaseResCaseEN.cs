
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingCaseResCaseEN
 表名:TeachingCaseResCase(01120377)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:49
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
 /// 表TeachingCaseResCase的关键字(IdTeachingCaseResCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachingCaseResCase_TeachingCaseResCase
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
public K_IdTeachingCaseResCase_TeachingCaseResCase(string strIdTeachingCaseResCase)
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
 /// <returns>返回:[K_IdTeachingCaseResCase_TeachingCaseResCase]类型的对象</returns>
public static implicit operator K_IdTeachingCaseResCase_TeachingCaseResCase(string value)
{
return new K_IdTeachingCaseResCase_TeachingCaseResCase(value);
}
}
 /// <summary>
 /// 教学案例资源案例(TeachingCaseResCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachingCaseResCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachingCaseResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachingCaseResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 42;
public static string[] AttributeName = new string[] {"IdTeachingCaseResCase", "TeachingCaseResCaseID", "TeachingCaseResCaseName", "TeachingCaseResCaseTheme", "TeachingCaseResCaseText", "TeachingCaseResCaseDate", "TeachingCaseResCaseTime", "TeachingCaseResCaseDateIn", "TeachingCaseResCaseTimeIn", "IdCaseType", "IdTeachingCaseResCaseType", "CourseId", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "CourseChapterId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdTeachingCaseResCase;    //教学案例资源案例流水号
protected string mstrTeachingCaseResCaseID;    //教学案例资源案例ID
protected string mstrTeachingCaseResCaseName;    //教学案例资源案例名称
protected string mstrTeachingCaseResCaseTheme;    //教学案例资源案例主题词
protected string mstrTeachingCaseResCaseText;    //案例文本内容
protected string mstrTeachingCaseResCaseDate;    //视频资源日期
protected string mstrTeachingCaseResCaseTime;    //视频资源时间
protected string mstrTeachingCaseResCaseDateIn;    //案例入库日期
protected string mstrTeachingCaseResCaseTimeIn;    //案例入库时间
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdTeachingCaseResCaseType;    //教学案例资源类型流水号
protected string mstrCourseId;    //课程Id
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
 public clsTeachingCaseResCaseEN()
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
public clsTeachingCaseResCaseEN(string strIdTeachingCaseResCase)
 {
strIdTeachingCaseResCase = strIdTeachingCaseResCase.Replace("'", "''");
if (strIdTeachingCaseResCase.Length > 8)
{
throw new Exception("在表:TeachingCaseResCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachingCaseResCase)  ==  true)
{
throw new Exception("在表:TeachingCaseResCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conTeachingCaseResCase.IdTeachingCaseResCase)
{
return mstrIdTeachingCaseResCase;
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseID)
{
return mstrTeachingCaseResCaseID;
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseName)
{
return mstrTeachingCaseResCaseName;
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseTheme)
{
return mstrTeachingCaseResCaseTheme;
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseText)
{
return mstrTeachingCaseResCaseText;
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseDate)
{
return mstrTeachingCaseResCaseDate;
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseTime)
{
return mstrTeachingCaseResCaseTime;
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseDateIn)
{
return mstrTeachingCaseResCaseDateIn;
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseTimeIn)
{
return mstrTeachingCaseResCaseTimeIn;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdTeachingCaseResCaseType)
{
return mstrIdTeachingCaseResCaseType;
}
else if (strAttributeName  ==  conTeachingCaseResCase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conTeachingCaseResCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conTeachingCaseResCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conTeachingCaseResCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conTeachingCaseResCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conTeachingCaseResCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conTeachingCaseResCase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  conTeachingCaseResCase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  conTeachingCaseResCase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conTeachingCaseResCase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  conTeachingCaseResCase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  conTeachingCaseResCase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  conTeachingCaseResCase.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conTeachingCaseResCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conTeachingCaseResCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conTeachingCaseResCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conTeachingCaseResCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conTeachingCaseResCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conTeachingCaseResCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTeachingCaseResCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conTeachingCaseResCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachingCaseResCase.IdTeachingCaseResCase)
{
mstrIdTeachingCaseResCase = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingCaseResCase);
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseID)
{
mstrTeachingCaseResCaseID = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseID);
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseName)
{
mstrTeachingCaseResCaseName = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseName);
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseTheme)
{
mstrTeachingCaseResCaseTheme = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTheme);
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseText)
{
mstrTeachingCaseResCaseText = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseText);
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseDate)
{
mstrTeachingCaseResCaseDate = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseDate);
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseTime)
{
mstrTeachingCaseResCaseTime = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTime);
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseDateIn)
{
mstrTeachingCaseResCaseDateIn = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
else if (strAttributeName  ==  conTeachingCaseResCase.TeachingCaseResCaseTimeIn)
{
mstrTeachingCaseResCaseTimeIn = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdCaseType);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdTeachingCaseResCaseType)
{
mstrIdTeachingCaseResCaseType = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingCaseResCaseType);
}
else if (strAttributeName  ==  conTeachingCaseResCase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.CourseId);
}
else if (strAttributeName  ==  conTeachingCaseResCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.OwnerId);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdStudyLevel);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdDiscipline);
}
else if (strAttributeName  ==  conTeachingCaseResCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.BrowseCount);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdTeachSkill);
}
else if (strAttributeName  ==  conTeachingCaseResCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.CaseLevelId);
}
else if (strAttributeName  ==  conTeachingCaseResCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.DocFile);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conTeachingCaseResCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.WordCreateDate);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.IsVisible);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.IsDualVideo);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdXzCollege);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdXzMajor);
}
else if (strAttributeName  ==  conTeachingCaseResCase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.CourseChapterId);
}
else if (strAttributeName  ==  conTeachingCaseResCase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.ViewCount);
}
else if (strAttributeName  ==  conTeachingCaseResCase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.IsShow);
}
else if (strAttributeName  ==  conTeachingCaseResCase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.DownloadNumber);
}
else if (strAttributeName  ==  conTeachingCaseResCase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.FileIntegration);
}
else if (strAttributeName  ==  conTeachingCaseResCase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.LikeCount);
}
else if (strAttributeName  ==  conTeachingCaseResCase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.CollectionCount);
}
else if (strAttributeName  ==  conTeachingCaseResCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conTeachingCaseResCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.ftpFileType);
}
else if (strAttributeName  ==  conTeachingCaseResCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.VideoUrl);
}
else if (strAttributeName  ==  conTeachingCaseResCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.VideoPath);
}
else if (strAttributeName  ==  conTeachingCaseResCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.ResErrMsg);
}
else if (strAttributeName  ==  conTeachingCaseResCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.UpdDate);
}
else if (strAttributeName  ==  conTeachingCaseResCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.UpdUserId);
}
else if (strAttributeName  ==  conTeachingCaseResCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachingCaseResCase.IdTeachingCaseResCase  ==  AttributeName[intIndex])
{
return mstrIdTeachingCaseResCase;
}
else if (conTeachingCaseResCase.TeachingCaseResCaseID  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseID;
}
else if (conTeachingCaseResCase.TeachingCaseResCaseName  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseName;
}
else if (conTeachingCaseResCase.TeachingCaseResCaseTheme  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTheme;
}
else if (conTeachingCaseResCase.TeachingCaseResCaseText  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseText;
}
else if (conTeachingCaseResCase.TeachingCaseResCaseDate  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseDate;
}
else if (conTeachingCaseResCase.TeachingCaseResCaseTime  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTime;
}
else if (conTeachingCaseResCase.TeachingCaseResCaseDateIn  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseDateIn;
}
else if (conTeachingCaseResCase.TeachingCaseResCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTimeIn;
}
else if (conTeachingCaseResCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conTeachingCaseResCase.IdTeachingCaseResCaseType  ==  AttributeName[intIndex])
{
return mstrIdTeachingCaseResCaseType;
}
else if (conTeachingCaseResCase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conTeachingCaseResCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conTeachingCaseResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conTeachingCaseResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conTeachingCaseResCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conTeachingCaseResCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conTeachingCaseResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conTeachingCaseResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conTeachingCaseResCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conTeachingCaseResCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conTeachingCaseResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conTeachingCaseResCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conTeachingCaseResCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conTeachingCaseResCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conTeachingCaseResCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conTeachingCaseResCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conTeachingCaseResCase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (conTeachingCaseResCase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (conTeachingCaseResCase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conTeachingCaseResCase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (conTeachingCaseResCase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (conTeachingCaseResCase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (conTeachingCaseResCase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conTeachingCaseResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conTeachingCaseResCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conTeachingCaseResCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conTeachingCaseResCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conTeachingCaseResCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conTeachingCaseResCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTeachingCaseResCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conTeachingCaseResCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachingCaseResCase.IdTeachingCaseResCase  ==  AttributeName[intIndex])
{
mstrIdTeachingCaseResCase = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingCaseResCase);
}
else if (conTeachingCaseResCase.TeachingCaseResCaseID  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseID = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseID);
}
else if (conTeachingCaseResCase.TeachingCaseResCaseName  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseName = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseName);
}
else if (conTeachingCaseResCase.TeachingCaseResCaseTheme  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTheme = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTheme);
}
else if (conTeachingCaseResCase.TeachingCaseResCaseText  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseText = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseText);
}
else if (conTeachingCaseResCase.TeachingCaseResCaseDate  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseDate = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseDate);
}
else if (conTeachingCaseResCase.TeachingCaseResCaseTime  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTime = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTime);
}
else if (conTeachingCaseResCase.TeachingCaseResCaseDateIn  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseDateIn = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
else if (conTeachingCaseResCase.TeachingCaseResCaseTimeIn  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTimeIn = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
else if (conTeachingCaseResCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdCaseType);
}
else if (conTeachingCaseResCase.IdTeachingCaseResCaseType  ==  AttributeName[intIndex])
{
mstrIdTeachingCaseResCaseType = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingCaseResCaseType);
}
else if (conTeachingCaseResCase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.CourseId);
}
else if (conTeachingCaseResCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.OwnerId);
}
else if (conTeachingCaseResCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdStudyLevel);
}
else if (conTeachingCaseResCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingPlan);
}
else if (conTeachingCaseResCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdDiscipline);
}
else if (conTeachingCaseResCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.BrowseCount);
}
else if (conTeachingCaseResCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdSenateGaugeVersion);
}
else if (conTeachingCaseResCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdTeachSkill);
}
else if (conTeachingCaseResCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.CaseLevelId);
}
else if (conTeachingCaseResCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.DocFile);
}
else if (conTeachingCaseResCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.IsNeedGeneWord);
}
else if (conTeachingCaseResCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.WordCreateDate);
}
else if (conTeachingCaseResCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.IsVisible);
}
else if (conTeachingCaseResCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.IsDualVideo);
}
else if (conTeachingCaseResCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdXzCollege);
}
else if (conTeachingCaseResCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.IdXzMajor);
}
else if (conTeachingCaseResCase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.CourseChapterId);
}
else if (conTeachingCaseResCase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.ViewCount);
}
else if (conTeachingCaseResCase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.IsShow);
}
else if (conTeachingCaseResCase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.DownloadNumber);
}
else if (conTeachingCaseResCase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.FileIntegration);
}
else if (conTeachingCaseResCase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.LikeCount);
}
else if (conTeachingCaseResCase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingCaseResCase.CollectionCount);
}
else if (conTeachingCaseResCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.RecommendedDegreeId);
}
else if (conTeachingCaseResCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.ftpFileType);
}
else if (conTeachingCaseResCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.VideoUrl);
}
else if (conTeachingCaseResCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.VideoPath);
}
else if (conTeachingCaseResCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.ResErrMsg);
}
else if (conTeachingCaseResCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.UpdDate);
}
else if (conTeachingCaseResCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.UpdUserId);
}
else if (conTeachingCaseResCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingCaseResCase.Memo);
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
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingCaseResCase);
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
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseID);
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
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseName);
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
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTheme);
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
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseText);
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
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseDate);
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
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTime);
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
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseDateIn);
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
 AddUpdatedFld(conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
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
 AddUpdatedFld(conTeachingCaseResCase.IdCaseType);
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
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingCaseResCaseType);
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
 AddUpdatedFld(conTeachingCaseResCase.CourseId);
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
 AddUpdatedFld(conTeachingCaseResCase.OwnerId);
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
 AddUpdatedFld(conTeachingCaseResCase.IdStudyLevel);
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
 AddUpdatedFld(conTeachingCaseResCase.IdTeachingPlan);
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
 AddUpdatedFld(conTeachingCaseResCase.IdDiscipline);
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
 AddUpdatedFld(conTeachingCaseResCase.BrowseCount);
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
 AddUpdatedFld(conTeachingCaseResCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conTeachingCaseResCase.IdTeachSkill);
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
 AddUpdatedFld(conTeachingCaseResCase.CaseLevelId);
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
 AddUpdatedFld(conTeachingCaseResCase.DocFile);
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
 AddUpdatedFld(conTeachingCaseResCase.IsNeedGeneWord);
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
 AddUpdatedFld(conTeachingCaseResCase.WordCreateDate);
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
 AddUpdatedFld(conTeachingCaseResCase.IsVisible);
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
 AddUpdatedFld(conTeachingCaseResCase.IsDualVideo);
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
 AddUpdatedFld(conTeachingCaseResCase.IdXzCollege);
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
 AddUpdatedFld(conTeachingCaseResCase.IdXzMajor);
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
 AddUpdatedFld(conTeachingCaseResCase.CourseChapterId);
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
 AddUpdatedFld(conTeachingCaseResCase.ViewCount);
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
 AddUpdatedFld(conTeachingCaseResCase.IsShow);
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
 AddUpdatedFld(conTeachingCaseResCase.DownloadNumber);
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
 AddUpdatedFld(conTeachingCaseResCase.FileIntegration);
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
 AddUpdatedFld(conTeachingCaseResCase.LikeCount);
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
 AddUpdatedFld(conTeachingCaseResCase.CollectionCount);
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
 AddUpdatedFld(conTeachingCaseResCase.RecommendedDegreeId);
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
 AddUpdatedFld(conTeachingCaseResCase.ftpFileType);
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
 AddUpdatedFld(conTeachingCaseResCase.VideoUrl);
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
 AddUpdatedFld(conTeachingCaseResCase.VideoPath);
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
 AddUpdatedFld(conTeachingCaseResCase.ResErrMsg);
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
 AddUpdatedFld(conTeachingCaseResCase.UpdDate);
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
 AddUpdatedFld(conTeachingCaseResCase.UpdUserId);
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
 AddUpdatedFld(conTeachingCaseResCase.Memo);
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
 /// 教学案例资源案例(TeachingCaseResCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachingCaseResCase
{
public const string _CurrTabName = "TeachingCaseResCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachingCaseResCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachingCaseResCase", "TeachingCaseResCaseID", "TeachingCaseResCaseName", "TeachingCaseResCaseTheme", "TeachingCaseResCaseText", "TeachingCaseResCaseDate", "TeachingCaseResCaseTime", "TeachingCaseResCaseDateIn", "TeachingCaseResCaseTimeIn", "IdCaseType", "IdTeachingCaseResCaseType", "CourseId", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "CourseChapterId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

 /// <summary>
 /// 常量:"IdTeachingCaseResCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingCaseResCaseType = "IdTeachingCaseResCaseType";    //教学案例资源类型流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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