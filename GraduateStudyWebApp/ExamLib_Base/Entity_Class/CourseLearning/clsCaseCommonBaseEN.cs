
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCommonBaseEN
 表名:CaseCommonBase(01120343)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:48
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
 /// 表CaseCommonBase的关键字(IdCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCase_CaseCommonBase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCase">表关键字</param>
public K_IdCase_CaseCommonBase(string strIdCase)
{
if (IsValid(strIdCase)) Value = strIdCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCase)
{
if (string.IsNullOrEmpty(strIdCase) == true) return false;
if (strIdCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCase_CaseCommonBase]类型的对象</returns>
public static implicit operator K_IdCase_CaseCommonBase(string value)
{
return new K_IdCase_CaseCommonBase(value);
}
}
 /// <summary>
 /// 案例公共基类(CaseCommonBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseCommonBaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseCommonBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 43;
public static string[] AttributeName = new string[] {"IdCase", "CaseId", "CaseName", "CaseText", "CaseTheme", "FuncModuleId", "CourseChapterId", "IdCaseType", "CaseDate", "CaseTime", "CaseDateIn", "CaseTimeIn", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "CourseId", "IdCaseType4FuncModuleId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdCase;    //案例流水号
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrCaseText;    //案例文本内容
protected string mstrCaseTheme;    //案例主题词
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrCaseDate;    //案例建立日期
protected string mstrCaseTime;    //案例建立时间
protected string mstrCaseDateIn;    //案例入库日期
protected string mstrCaseTimeIn;    //案例入库时间
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
protected int? mintViewCount;    //浏览量
protected bool mbolIsShow;    //是否启用
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrCourseId;    //课程Id
protected string mstrIdCaseType4FuncModuleId;    //案例类型流水号4模块
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
 public clsCaseCommonBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCase">关键字:案例流水号</param>
public clsCaseCommonBaseEN(string strIdCase)
 {
strIdCase = strIdCase.Replace("'", "''");
if (strIdCase.Length > 8)
{
throw new Exception("在表:CaseCommonBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCase)  ==  true)
{
throw new Exception("在表:CaseCommonBase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCase = strIdCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCase");
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
if (strAttributeName  ==  conCaseCommonBase.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseText)
{
return mstrCaseText;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseTheme)
{
return mstrCaseTheme;
}
else if (strAttributeName  ==  conCaseCommonBase.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conCaseCommonBase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  conCaseCommonBase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseDate)
{
return mstrCaseDate;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseTime)
{
return mstrCaseTime;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseDateIn)
{
return mstrCaseDateIn;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseTimeIn)
{
return mstrCaseTimeIn;
}
else if (strAttributeName  ==  conCaseCommonBase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conCaseCommonBase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conCaseCommonBase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conCaseCommonBase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conCaseCommonBase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conCaseCommonBase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conCaseCommonBase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conCaseCommonBase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conCaseCommonBase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conCaseCommonBase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conCaseCommonBase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conCaseCommonBase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conCaseCommonBase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conCaseCommonBase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conCaseCommonBase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conCaseCommonBase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  conCaseCommonBase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conCaseCommonBase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  conCaseCommonBase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  conCaseCommonBase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  conCaseCommonBase.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conCaseCommonBase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conCaseCommonBase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conCaseCommonBase.IdCaseType4FuncModuleId)
{
return mstrIdCaseType4FuncModuleId;
}
else if (strAttributeName  ==  conCaseCommonBase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conCaseCommonBase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conCaseCommonBase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conCaseCommonBase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conCaseCommonBase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCaseCommonBase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCaseCommonBase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseCommonBase.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdCase);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseId);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseName);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseText)
{
mstrCaseText = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseText);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseTheme)
{
mstrCaseTheme = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseTheme);
}
else if (strAttributeName  ==  conCaseCommonBase.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.FuncModuleId);
}
else if (strAttributeName  ==  conCaseCommonBase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CourseChapterId);
}
else if (strAttributeName  ==  conCaseCommonBase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdCaseType);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseDate)
{
mstrCaseDate = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseDate);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseTime)
{
mstrCaseTime = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseTime);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseDateIn)
{
mstrCaseDateIn = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseDateIn);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseTimeIn)
{
mstrCaseTimeIn = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseTimeIn);
}
else if (strAttributeName  ==  conCaseCommonBase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.OwnerId);
}
else if (strAttributeName  ==  conCaseCommonBase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdStudyLevel);
}
else if (strAttributeName  ==  conCaseCommonBase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdTeachingPlan);
}
else if (strAttributeName  ==  conCaseCommonBase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdDiscipline);
}
else if (strAttributeName  ==  conCaseCommonBase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.BrowseCount);
}
else if (strAttributeName  ==  conCaseCommonBase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conCaseCommonBase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdTeachSkill);
}
else if (strAttributeName  ==  conCaseCommonBase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseLevelId);
}
else if (strAttributeName  ==  conCaseCommonBase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conCaseCommonBase.DocFile);
}
else if (strAttributeName  ==  conCaseCommonBase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conCaseCommonBase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conCaseCommonBase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conCaseCommonBase.WordCreateDate);
}
else if (strAttributeName  ==  conCaseCommonBase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCaseCommonBase.IsVisible);
}
else if (strAttributeName  ==  conCaseCommonBase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conCaseCommonBase.IsDualVideo);
}
else if (strAttributeName  ==  conCaseCommonBase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdXzCollege);
}
else if (strAttributeName  ==  conCaseCommonBase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdXzMajor);
}
else if (strAttributeName  ==  conCaseCommonBase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.ViewCount);
}
else if (strAttributeName  ==  conCaseCommonBase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conCaseCommonBase.IsShow);
}
else if (strAttributeName  ==  conCaseCommonBase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.DownloadNumber);
}
else if (strAttributeName  ==  conCaseCommonBase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.FileIntegration);
}
else if (strAttributeName  ==  conCaseCommonBase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.LikeCount);
}
else if (strAttributeName  ==  conCaseCommonBase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.CollectionCount);
}
else if (strAttributeName  ==  conCaseCommonBase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conCaseCommonBase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CourseId);
}
else if (strAttributeName  ==  conCaseCommonBase.IdCaseType4FuncModuleId)
{
mstrIdCaseType4FuncModuleId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdCaseType4FuncModuleId);
}
else if (strAttributeName  ==  conCaseCommonBase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conCaseCommonBase.ftpFileType);
}
else if (strAttributeName  ==  conCaseCommonBase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conCaseCommonBase.VideoUrl);
}
else if (strAttributeName  ==  conCaseCommonBase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conCaseCommonBase.VideoPath);
}
else if (strAttributeName  ==  conCaseCommonBase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conCaseCommonBase.ResErrMsg);
}
else if (strAttributeName  ==  conCaseCommonBase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseCommonBase.UpdDate);
}
else if (strAttributeName  ==  conCaseCommonBase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.UpdUserId);
}
else if (strAttributeName  ==  conCaseCommonBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCommonBase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseCommonBase.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (conCaseCommonBase.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (conCaseCommonBase.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conCaseCommonBase.CaseText  ==  AttributeName[intIndex])
{
return mstrCaseText;
}
else if (conCaseCommonBase.CaseTheme  ==  AttributeName[intIndex])
{
return mstrCaseTheme;
}
else if (conCaseCommonBase.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conCaseCommonBase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (conCaseCommonBase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conCaseCommonBase.CaseDate  ==  AttributeName[intIndex])
{
return mstrCaseDate;
}
else if (conCaseCommonBase.CaseTime  ==  AttributeName[intIndex])
{
return mstrCaseTime;
}
else if (conCaseCommonBase.CaseDateIn  ==  AttributeName[intIndex])
{
return mstrCaseDateIn;
}
else if (conCaseCommonBase.CaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCaseTimeIn;
}
else if (conCaseCommonBase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conCaseCommonBase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conCaseCommonBase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conCaseCommonBase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conCaseCommonBase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conCaseCommonBase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conCaseCommonBase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conCaseCommonBase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conCaseCommonBase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conCaseCommonBase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conCaseCommonBase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conCaseCommonBase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conCaseCommonBase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conCaseCommonBase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conCaseCommonBase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conCaseCommonBase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (conCaseCommonBase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conCaseCommonBase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (conCaseCommonBase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (conCaseCommonBase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (conCaseCommonBase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conCaseCommonBase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conCaseCommonBase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conCaseCommonBase.IdCaseType4FuncModuleId  ==  AttributeName[intIndex])
{
return mstrIdCaseType4FuncModuleId;
}
else if (conCaseCommonBase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conCaseCommonBase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conCaseCommonBase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conCaseCommonBase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conCaseCommonBase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCaseCommonBase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCaseCommonBase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseCommonBase.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdCase);
}
else if (conCaseCommonBase.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseId);
}
else if (conCaseCommonBase.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseName);
}
else if (conCaseCommonBase.CaseText  ==  AttributeName[intIndex])
{
mstrCaseText = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseText);
}
else if (conCaseCommonBase.CaseTheme  ==  AttributeName[intIndex])
{
mstrCaseTheme = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseTheme);
}
else if (conCaseCommonBase.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.FuncModuleId);
}
else if (conCaseCommonBase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CourseChapterId);
}
else if (conCaseCommonBase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdCaseType);
}
else if (conCaseCommonBase.CaseDate  ==  AttributeName[intIndex])
{
mstrCaseDate = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseDate);
}
else if (conCaseCommonBase.CaseTime  ==  AttributeName[intIndex])
{
mstrCaseTime = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseTime);
}
else if (conCaseCommonBase.CaseDateIn  ==  AttributeName[intIndex])
{
mstrCaseDateIn = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseDateIn);
}
else if (conCaseCommonBase.CaseTimeIn  ==  AttributeName[intIndex])
{
mstrCaseTimeIn = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseTimeIn);
}
else if (conCaseCommonBase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.OwnerId);
}
else if (conCaseCommonBase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdStudyLevel);
}
else if (conCaseCommonBase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdTeachingPlan);
}
else if (conCaseCommonBase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdDiscipline);
}
else if (conCaseCommonBase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.BrowseCount);
}
else if (conCaseCommonBase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdSenateGaugeVersion);
}
else if (conCaseCommonBase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdTeachSkill);
}
else if (conCaseCommonBase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CaseLevelId);
}
else if (conCaseCommonBase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conCaseCommonBase.DocFile);
}
else if (conCaseCommonBase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conCaseCommonBase.IsNeedGeneWord);
}
else if (conCaseCommonBase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conCaseCommonBase.WordCreateDate);
}
else if (conCaseCommonBase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCaseCommonBase.IsVisible);
}
else if (conCaseCommonBase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conCaseCommonBase.IsDualVideo);
}
else if (conCaseCommonBase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdXzCollege);
}
else if (conCaseCommonBase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdXzMajor);
}
else if (conCaseCommonBase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.ViewCount);
}
else if (conCaseCommonBase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conCaseCommonBase.IsShow);
}
else if (conCaseCommonBase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.DownloadNumber);
}
else if (conCaseCommonBase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.FileIntegration);
}
else if (conCaseCommonBase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.LikeCount);
}
else if (conCaseCommonBase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCommonBase.CollectionCount);
}
else if (conCaseCommonBase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.RecommendedDegreeId);
}
else if (conCaseCommonBase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.CourseId);
}
else if (conCaseCommonBase.IdCaseType4FuncModuleId  ==  AttributeName[intIndex])
{
mstrIdCaseType4FuncModuleId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.IdCaseType4FuncModuleId);
}
else if (conCaseCommonBase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conCaseCommonBase.ftpFileType);
}
else if (conCaseCommonBase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conCaseCommonBase.VideoUrl);
}
else if (conCaseCommonBase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conCaseCommonBase.VideoPath);
}
else if (conCaseCommonBase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conCaseCommonBase.ResErrMsg);
}
else if (conCaseCommonBase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseCommonBase.UpdDate);
}
else if (conCaseCommonBase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseCommonBase.UpdUserId);
}
else if (conCaseCommonBase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCommonBase.Memo);
}
}
}

/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCase
{
get
{
return mstrIdCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCase = value;
}
else
{
 mstrIdCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.IdCase);
}
}
/// <summary>
/// 案例Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId
{
get
{
return mstrCaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId = value;
}
else
{
 mstrCaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.CaseId);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName
{
get
{
return mstrCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName = value;
}
else
{
 mstrCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.CaseName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseText
{
get
{
return mstrCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseText = value;
}
else
{
 mstrCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.CaseText);
}
}
/// <summary>
/// 案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTheme
{
get
{
return mstrCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTheme = value;
}
else
{
 mstrCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.CaseTheme);
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
 AddUpdatedFld(conCaseCommonBase.FuncModuleId);
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
 AddUpdatedFld(conCaseCommonBase.CourseChapterId);
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
 AddUpdatedFld(conCaseCommonBase.IdCaseType);
}
}
/// <summary>
/// 案例建立日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseDate
{
get
{
return mstrCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseDate = value;
}
else
{
 mstrCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.CaseDate);
}
}
/// <summary>
/// 案例建立时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTime
{
get
{
return mstrCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTime = value;
}
else
{
 mstrCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.CaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseDateIn
{
get
{
return mstrCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseDateIn = value;
}
else
{
 mstrCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.CaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTimeIn
{
get
{
return mstrCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTimeIn = value;
}
else
{
 mstrCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.CaseTimeIn);
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
 AddUpdatedFld(conCaseCommonBase.OwnerId);
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
 AddUpdatedFld(conCaseCommonBase.IdStudyLevel);
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
 AddUpdatedFld(conCaseCommonBase.IdTeachingPlan);
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
 AddUpdatedFld(conCaseCommonBase.IdDiscipline);
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
 AddUpdatedFld(conCaseCommonBase.BrowseCount);
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
 AddUpdatedFld(conCaseCommonBase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conCaseCommonBase.IdTeachSkill);
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
 AddUpdatedFld(conCaseCommonBase.CaseLevelId);
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
 AddUpdatedFld(conCaseCommonBase.DocFile);
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
 AddUpdatedFld(conCaseCommonBase.IsNeedGeneWord);
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
 AddUpdatedFld(conCaseCommonBase.WordCreateDate);
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
 AddUpdatedFld(conCaseCommonBase.IsVisible);
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
 AddUpdatedFld(conCaseCommonBase.IsDualVideo);
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
 AddUpdatedFld(conCaseCommonBase.IdXzCollege);
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
 AddUpdatedFld(conCaseCommonBase.IdXzMajor);
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
 AddUpdatedFld(conCaseCommonBase.ViewCount);
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
 AddUpdatedFld(conCaseCommonBase.IsShow);
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
 AddUpdatedFld(conCaseCommonBase.DownloadNumber);
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
 AddUpdatedFld(conCaseCommonBase.FileIntegration);
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
 AddUpdatedFld(conCaseCommonBase.LikeCount);
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
 AddUpdatedFld(conCaseCommonBase.CollectionCount);
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
 AddUpdatedFld(conCaseCommonBase.RecommendedDegreeId);
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
 AddUpdatedFld(conCaseCommonBase.CourseId);
}
}
/// <summary>
/// 案例类型流水号4模块(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseType4FuncModuleId
{
get
{
return mstrIdCaseType4FuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseType4FuncModuleId = value;
}
else
{
 mstrIdCaseType4FuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCommonBase.IdCaseType4FuncModuleId);
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
 AddUpdatedFld(conCaseCommonBase.ftpFileType);
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
 AddUpdatedFld(conCaseCommonBase.VideoUrl);
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
 AddUpdatedFld(conCaseCommonBase.VideoPath);
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
 AddUpdatedFld(conCaseCommonBase.ResErrMsg);
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
 AddUpdatedFld(conCaseCommonBase.UpdDate);
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
 AddUpdatedFld(conCaseCommonBase.UpdUserId);
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
 AddUpdatedFld(conCaseCommonBase.Memo);
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
  return mstrIdCase;
 }
 }
}
 /// <summary>
 /// 案例公共基类(CaseCommonBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseCommonBase
{
public const string _CurrTabName = "CaseCommonBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCase", "CaseId", "CaseName", "CaseText", "CaseTheme", "FuncModuleId", "CourseChapterId", "IdCaseType", "CaseDate", "CaseTime", "CaseDateIn", "CaseTimeIn", "OwnerId", "IdStudyLevel", "IdTeachingPlan", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "IsDualVideo", "IdXzCollege", "IdXzMajor", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "CourseId", "IdCaseType4FuncModuleId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"CaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId = "CaseId";    //案例Id

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //案例名称

 /// <summary>
 /// 常量:"CaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseText = "CaseText";    //案例文本内容

 /// <summary>
 /// 常量:"CaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTheme = "CaseTheme";    //案例主题词

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

 /// <summary>
 /// 常量:"CaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseDate = "CaseDate";    //案例建立日期

 /// <summary>
 /// 常量:"CaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTime = "CaseTime";    //案例建立时间

 /// <summary>
 /// 常量:"CaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseDateIn = "CaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTimeIn = "CaseTimeIn";    //案例入库时间

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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IdCaseType4FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType4FuncModuleId = "IdCaseType4FuncModuleId";    //案例类型流水号4模块

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