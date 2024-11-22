
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseEN
 表名:vPubClassCase(01120386)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表vPubClassCase的关键字(IdPubClassCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCase_vPubClassCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPubClassCase">表关键字</param>
public K_IdPubClassCase_vPubClassCase(string strIdPubClassCase)
{
if (IsValid(strIdPubClassCase)) Value = strIdPubClassCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPubClassCase)
{
if (string.IsNullOrEmpty(strIdPubClassCase) == true) return false;
if (strIdPubClassCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCase_vPubClassCase]类型的对象</returns>
public static implicit operator K_IdPubClassCase_vPubClassCase(string value)
{
return new K_IdPubClassCase_vPubClassCase(value);
}
}
 /// <summary>
 /// v公开课案例(vPubClassCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPubClassCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPubClassCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 44;
public static string[] AttributeName = new string[] {"IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "WorkUnit", "PubClassCaseTheme", "PubClassCaseBG", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdDiscipline", "DisciplineID", "DisciplineName", "IdTeachingPlan", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "TeachingPlanType", "SimplePlanContent", "PubClassCaseTimeIn", "IdPubClassCaseSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "IdStudyLevel", "StudyLevelName", "CDID", "Introduction", "IsVisible", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "BrowseCount4Case"};

protected string mstrIdPubClassCase;    //案例流水号
protected string mstrPubClassCaseID;    //案例ID
protected string mstrPubClassCaseName;    //案例课题名称
protected string mstrPubClassCaseExecutor;    //案例执教者
protected string mstrWorkUnit;    //工作单位
protected string mstrPubClassCaseTheme;    //案例主题词
protected string mstrPubClassCaseBG;    //案例背景资料
protected string mstrPubClassCaseTeachDate;    //案例授课日期
protected string mstrPubClassCaseDateIn;    //案例入库日期
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrSubjectName;    //课题名称
protected string mstrTeachingPlanAuthor;    //教案撰写人
protected string mstrTeachingObject;    //教学目标
protected string mstrTeachingEmphases;    //教学重点
protected string mstrTeachingDifficulty;    //教学难点
protected string mstrTeachingTool;    //教学用具
protected string mstrTeachingProcess;    //教学过程
protected string mstrTeachingPlanType;    //教案类型
protected string mstrSimplePlanContent;    //简案内容
protected string mstrPubClassCaseTimeIn;    //案例入库时间
protected string mstrIdPubClassCaseSenateGaugeVersion;    //公开课量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrIdPubCaseType;    //公开课案例类型流水号
protected string mstrPubCaseTypeID;    //公开课案例类型ID
protected string mstrPubCaseTypeName;    //公开课案例类型名称
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrCDID;    //光盘编号
protected string mstrIntroduction;    //简要介绍
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrMemo;    //备注
protected int? mintBrowseCount4Case;    //课例浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPubClassCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPubClassCase">关键字:案例流水号</param>
public clsvPubClassCaseEN(string strIdPubClassCase)
 {
strIdPubClassCase = strIdPubClassCase.Replace("'", "''");
if (strIdPubClassCase.Length > 8)
{
throw new Exception("在表:vPubClassCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPubClassCase)  ==  true)
{
throw new Exception("在表:vPubClassCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubClassCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPubClassCase = strIdPubClassCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCase");
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
if (strAttributeName  ==  convPubClassCase.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseID)
{
return mstrPubClassCaseID;
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseName)
{
return mstrPubClassCaseName;
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseExecutor)
{
return mstrPubClassCaseExecutor;
}
else if (strAttributeName  ==  convPubClassCase.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseTheme)
{
return mstrPubClassCaseTheme;
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseBG)
{
return mstrPubClassCaseBG;
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseTeachDate)
{
return mstrPubClassCaseTeachDate;
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseDateIn)
{
return mstrPubClassCaseDateIn;
}
else if (strAttributeName  ==  convPubClassCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convPubClassCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convPubClassCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convPubClassCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convPubClassCase.SubjectName)
{
return mstrSubjectName;
}
else if (strAttributeName  ==  convPubClassCase.TeachingPlanAuthor)
{
return mstrTeachingPlanAuthor;
}
else if (strAttributeName  ==  convPubClassCase.TeachingObject)
{
return mstrTeachingObject;
}
else if (strAttributeName  ==  convPubClassCase.TeachingEmphases)
{
return mstrTeachingEmphases;
}
else if (strAttributeName  ==  convPubClassCase.TeachingDifficulty)
{
return mstrTeachingDifficulty;
}
else if (strAttributeName  ==  convPubClassCase.TeachingTool)
{
return mstrTeachingTool;
}
else if (strAttributeName  ==  convPubClassCase.TeachingProcess)
{
return mstrTeachingProcess;
}
else if (strAttributeName  ==  convPubClassCase.TeachingPlanType)
{
return mstrTeachingPlanType;
}
else if (strAttributeName  ==  convPubClassCase.SimplePlanContent)
{
return mstrSimplePlanContent;
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseTimeIn)
{
return mstrPubClassCaseTimeIn;
}
else if (strAttributeName  ==  convPubClassCase.IdPubClassCaseSenateGaugeVersion)
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (strAttributeName  ==  convPubClassCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convPubClassCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convPubClassCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convPubClassCase.IdPubCaseType)
{
return mstrIdPubCaseType;
}
else if (strAttributeName  ==  convPubClassCase.PubCaseTypeID)
{
return mstrPubCaseTypeID;
}
else if (strAttributeName  ==  convPubClassCase.PubCaseTypeName)
{
return mstrPubCaseTypeName;
}
else if (strAttributeName  ==  convPubClassCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convPubClassCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convPubClassCase.CDID)
{
return mstrCDID;
}
else if (strAttributeName  ==  convPubClassCase.Introduction)
{
return mstrIntroduction;
}
else if (strAttributeName  ==  convPubClassCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convPubClassCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convPubClassCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convPubClassCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convPubClassCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convPubClassCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convPubClassCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convPubClassCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convPubClassCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPubClassCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (strAttributeName  ==  convPubClassCase.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCase.IdPubClassCase);
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseID)
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseID);
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseName)
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseName);
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseExecutor)
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseExecutor);
}
else if (strAttributeName  ==  convPubClassCase.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convPubClassCase.WorkUnit);
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseTheme)
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseTheme);
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseBG)
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseBG);
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseTeachDate)
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseTeachDate);
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseDateIn)
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseDateIn);
}
else if (strAttributeName  ==  convPubClassCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPubClassCase.IdDiscipline);
}
else if (strAttributeName  ==  convPubClassCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPubClassCase.DisciplineID);
}
else if (strAttributeName  ==  convPubClassCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubClassCase.DisciplineName);
}
else if (strAttributeName  ==  convPubClassCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPubClassCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convPubClassCase.SubjectName)
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPubClassCase.SubjectName);
}
else if (strAttributeName  ==  convPubClassCase.TeachingPlanAuthor)
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingPlanAuthor);
}
else if (strAttributeName  ==  convPubClassCase.TeachingObject)
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingObject);
}
else if (strAttributeName  ==  convPubClassCase.TeachingEmphases)
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingEmphases);
}
else if (strAttributeName  ==  convPubClassCase.TeachingDifficulty)
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingDifficulty);
}
else if (strAttributeName  ==  convPubClassCase.TeachingTool)
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingTool);
}
else if (strAttributeName  ==  convPubClassCase.TeachingProcess)
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingProcess);
}
else if (strAttributeName  ==  convPubClassCase.TeachingPlanType)
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingPlanType);
}
else if (strAttributeName  ==  convPubClassCase.SimplePlanContent)
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(convPubClassCase.SimplePlanContent);
}
else if (strAttributeName  ==  convPubClassCase.PubClassCaseTimeIn)
{
mstrPubClassCaseTimeIn = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseTimeIn);
}
else if (strAttributeName  ==  convPubClassCase.IdPubClassCaseSenateGaugeVersion)
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convPubClassCase.IdPubClassCaseSenateGaugeVersion);
}
else if (strAttributeName  ==  convPubClassCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convPubClassCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convPubClassCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convPubClassCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convPubClassCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPubClassCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convPubClassCase.IdPubCaseType)
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubClassCase.IdPubCaseType);
}
else if (strAttributeName  ==  convPubClassCase.PubCaseTypeID)
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubClassCase.PubCaseTypeID);
}
else if (strAttributeName  ==  convPubClassCase.PubCaseTypeName)
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubClassCase.PubCaseTypeName);
}
else if (strAttributeName  ==  convPubClassCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPubClassCase.IdStudyLevel);
}
else if (strAttributeName  ==  convPubClassCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubClassCase.StudyLevelName);
}
else if (strAttributeName  ==  convPubClassCase.CDID)
{
mstrCDID = value.ToString();
 AddUpdatedFld(convPubClassCase.CDID);
}
else if (strAttributeName  ==  convPubClassCase.Introduction)
{
mstrIntroduction = value.ToString();
 AddUpdatedFld(convPubClassCase.Introduction);
}
else if (strAttributeName  ==  convPubClassCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase.IsVisible);
}
else if (strAttributeName  ==  convPubClassCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase.IsDualVideo);
}
else if (strAttributeName  ==  convPubClassCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convPubClassCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convPubClassCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convPubClassCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convPubClassCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convPubClassCase.ftpFileType);
}
else if (strAttributeName  ==  convPubClassCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convPubClassCase.VideoUrl);
}
else if (strAttributeName  ==  convPubClassCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convPubClassCase.VideoPath);
}
else if (strAttributeName  ==  convPubClassCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convPubClassCase.ResErrMsg);
}
else if (strAttributeName  ==  convPubClassCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPubClassCase.Memo);
}
else if (strAttributeName  ==  convPubClassCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase.BrowseCount4Case);
}
}
}
public object this[int intIndex]
{
get
{
if (convPubClassCase.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (convPubClassCase.PubClassCaseID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseID;
}
else if (convPubClassCase.PubClassCaseName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseName;
}
else if (convPubClassCase.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
return mstrPubClassCaseExecutor;
}
else if (convPubClassCase.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convPubClassCase.PubClassCaseTheme  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTheme;
}
else if (convPubClassCase.PubClassCaseBG  ==  AttributeName[intIndex])
{
return mstrPubClassCaseBG;
}
else if (convPubClassCase.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTeachDate;
}
else if (convPubClassCase.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseDateIn;
}
else if (convPubClassCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convPubClassCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convPubClassCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convPubClassCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convPubClassCase.SubjectName  ==  AttributeName[intIndex])
{
return mstrSubjectName;
}
else if (convPubClassCase.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
return mstrTeachingPlanAuthor;
}
else if (convPubClassCase.TeachingObject  ==  AttributeName[intIndex])
{
return mstrTeachingObject;
}
else if (convPubClassCase.TeachingEmphases  ==  AttributeName[intIndex])
{
return mstrTeachingEmphases;
}
else if (convPubClassCase.TeachingDifficulty  ==  AttributeName[intIndex])
{
return mstrTeachingDifficulty;
}
else if (convPubClassCase.TeachingTool  ==  AttributeName[intIndex])
{
return mstrTeachingTool;
}
else if (convPubClassCase.TeachingProcess  ==  AttributeName[intIndex])
{
return mstrTeachingProcess;
}
else if (convPubClassCase.TeachingPlanType  ==  AttributeName[intIndex])
{
return mstrTeachingPlanType;
}
else if (convPubClassCase.SimplePlanContent  ==  AttributeName[intIndex])
{
return mstrSimplePlanContent;
}
else if (convPubClassCase.PubClassCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTimeIn;
}
else if (convPubClassCase.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (convPubClassCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convPubClassCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convPubClassCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convPubClassCase.IdPubCaseType  ==  AttributeName[intIndex])
{
return mstrIdPubCaseType;
}
else if (convPubClassCase.PubCaseTypeID  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeID;
}
else if (convPubClassCase.PubCaseTypeName  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeName;
}
else if (convPubClassCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convPubClassCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convPubClassCase.CDID  ==  AttributeName[intIndex])
{
return mstrCDID;
}
else if (convPubClassCase.Introduction  ==  AttributeName[intIndex])
{
return mstrIntroduction;
}
else if (convPubClassCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convPubClassCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convPubClassCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convPubClassCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convPubClassCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convPubClassCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convPubClassCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convPubClassCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convPubClassCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPubClassCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (convPubClassCase.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCase.IdPubClassCase);
}
else if (convPubClassCase.PubClassCaseID  ==  AttributeName[intIndex])
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseID);
}
else if (convPubClassCase.PubClassCaseName  ==  AttributeName[intIndex])
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseName);
}
else if (convPubClassCase.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseExecutor);
}
else if (convPubClassCase.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convPubClassCase.WorkUnit);
}
else if (convPubClassCase.PubClassCaseTheme  ==  AttributeName[intIndex])
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseTheme);
}
else if (convPubClassCase.PubClassCaseBG  ==  AttributeName[intIndex])
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseBG);
}
else if (convPubClassCase.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseTeachDate);
}
else if (convPubClassCase.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseDateIn);
}
else if (convPubClassCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPubClassCase.IdDiscipline);
}
else if (convPubClassCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPubClassCase.DisciplineID);
}
else if (convPubClassCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubClassCase.DisciplineName);
}
else if (convPubClassCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPubClassCase.IdTeachingPlan);
}
else if (convPubClassCase.SubjectName  ==  AttributeName[intIndex])
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPubClassCase.SubjectName);
}
else if (convPubClassCase.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingPlanAuthor);
}
else if (convPubClassCase.TeachingObject  ==  AttributeName[intIndex])
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingObject);
}
else if (convPubClassCase.TeachingEmphases  ==  AttributeName[intIndex])
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingEmphases);
}
else if (convPubClassCase.TeachingDifficulty  ==  AttributeName[intIndex])
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingDifficulty);
}
else if (convPubClassCase.TeachingTool  ==  AttributeName[intIndex])
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingTool);
}
else if (convPubClassCase.TeachingProcess  ==  AttributeName[intIndex])
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingProcess);
}
else if (convPubClassCase.TeachingPlanType  ==  AttributeName[intIndex])
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(convPubClassCase.TeachingPlanType);
}
else if (convPubClassCase.SimplePlanContent  ==  AttributeName[intIndex])
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(convPubClassCase.SimplePlanContent);
}
else if (convPubClassCase.PubClassCaseTimeIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseTimeIn = value.ToString();
 AddUpdatedFld(convPubClassCase.PubClassCaseTimeIn);
}
else if (convPubClassCase.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convPubClassCase.IdPubClassCaseSenateGaugeVersion);
}
else if (convPubClassCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convPubClassCase.senateGaugeVersionID);
}
else if (convPubClassCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convPubClassCase.senateGaugeVersionName);
}
else if (convPubClassCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPubClassCase.senateGaugeVersionTtlScore);
}
else if (convPubClassCase.IdPubCaseType  ==  AttributeName[intIndex])
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubClassCase.IdPubCaseType);
}
else if (convPubClassCase.PubCaseTypeID  ==  AttributeName[intIndex])
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubClassCase.PubCaseTypeID);
}
else if (convPubClassCase.PubCaseTypeName  ==  AttributeName[intIndex])
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubClassCase.PubCaseTypeName);
}
else if (convPubClassCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPubClassCase.IdStudyLevel);
}
else if (convPubClassCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubClassCase.StudyLevelName);
}
else if (convPubClassCase.CDID  ==  AttributeName[intIndex])
{
mstrCDID = value.ToString();
 AddUpdatedFld(convPubClassCase.CDID);
}
else if (convPubClassCase.Introduction  ==  AttributeName[intIndex])
{
mstrIntroduction = value.ToString();
 AddUpdatedFld(convPubClassCase.Introduction);
}
else if (convPubClassCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase.IsVisible);
}
else if (convPubClassCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase.IsDualVideo);
}
else if (convPubClassCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convPubClassCase.RecommendedDegreeId);
}
else if (convPubClassCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convPubClassCase.RecommendedDegreeName);
}
else if (convPubClassCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convPubClassCase.ftpFileType);
}
else if (convPubClassCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convPubClassCase.VideoUrl);
}
else if (convPubClassCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convPubClassCase.VideoPath);
}
else if (convPubClassCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convPubClassCase.ResErrMsg);
}
else if (convPubClassCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPubClassCase.Memo);
}
else if (convPubClassCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase.BrowseCount4Case);
}
}
}

/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCase
{
get
{
return mstrIdPubClassCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCase = value;
}
else
{
 mstrIdPubClassCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.IdPubClassCase);
}
}
/// <summary>
/// 案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseID
{
get
{
return mstrPubClassCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseID = value;
}
else
{
 mstrPubClassCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubClassCaseID);
}
}
/// <summary>
/// 案例课题名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseName
{
get
{
return mstrPubClassCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseName = value;
}
else
{
 mstrPubClassCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubClassCaseName);
}
}
/// <summary>
/// 案例执教者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseExecutor
{
get
{
return mstrPubClassCaseExecutor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseExecutor = value;
}
else
{
 mstrPubClassCaseExecutor = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubClassCaseExecutor);
}
}
/// <summary>
/// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkUnit
{
get
{
return mstrWorkUnit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkUnit = value;
}
else
{
 mstrWorkUnit = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.WorkUnit);
}
}
/// <summary>
/// 案例主题词(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseTheme
{
get
{
return mstrPubClassCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseTheme = value;
}
else
{
 mstrPubClassCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubClassCaseTheme);
}
}
/// <summary>
/// 案例背景资料(说明:;字段类型:text;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseBG
{
get
{
return mstrPubClassCaseBG;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseBG = value;
}
else
{
 mstrPubClassCaseBG = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubClassCaseBG);
}
}
/// <summary>
/// 案例授课日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseTeachDate
{
get
{
return mstrPubClassCaseTeachDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseTeachDate = value;
}
else
{
 mstrPubClassCaseTeachDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubClassCaseTeachDate);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseDateIn
{
get
{
return mstrPubClassCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseDateIn = value;
}
else
{
 mstrPubClassCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubClassCaseDateIn);
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
 AddUpdatedFld(convPubClassCase.IdDiscipline);
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
 AddUpdatedFld(convPubClassCase.DisciplineID);
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
 AddUpdatedFld(convPubClassCase.DisciplineName);
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
 AddUpdatedFld(convPubClassCase.IdTeachingPlan);
}
}
/// <summary>
/// 课题名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubjectName
{
get
{
return mstrSubjectName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubjectName = value;
}
else
{
 mstrSubjectName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.SubjectName);
}
}
/// <summary>
/// 教案撰写人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanAuthor
{
get
{
return mstrTeachingPlanAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanAuthor = value;
}
else
{
 mstrTeachingPlanAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.TeachingPlanAuthor);
}
}
/// <summary>
/// 教学目标(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingObject
{
get
{
return mstrTeachingObject;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingObject = value;
}
else
{
 mstrTeachingObject = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.TeachingObject);
}
}
/// <summary>
/// 教学重点(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingEmphases
{
get
{
return mstrTeachingEmphases;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingEmphases = value;
}
else
{
 mstrTeachingEmphases = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.TeachingEmphases);
}
}
/// <summary>
/// 教学难点(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingDifficulty
{
get
{
return mstrTeachingDifficulty;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingDifficulty = value;
}
else
{
 mstrTeachingDifficulty = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.TeachingDifficulty);
}
}
/// <summary>
/// 教学用具(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingTool
{
get
{
return mstrTeachingTool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingTool = value;
}
else
{
 mstrTeachingTool = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.TeachingTool);
}
}
/// <summary>
/// 教学过程(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingProcess
{
get
{
return mstrTeachingProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingProcess = value;
}
else
{
 mstrTeachingProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.TeachingProcess);
}
}
/// <summary>
/// 教案类型(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanType
{
get
{
return mstrTeachingPlanType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanType = value;
}
else
{
 mstrTeachingPlanType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.TeachingPlanType);
}
}
/// <summary>
/// 简案内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SimplePlanContent
{
get
{
return mstrSimplePlanContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSimplePlanContent = value;
}
else
{
 mstrSimplePlanContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.SimplePlanContent);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseTimeIn
{
get
{
return mstrPubClassCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseTimeIn = value;
}
else
{
 mstrPubClassCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubClassCaseTimeIn);
}
}
/// <summary>
/// 公开课量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCaseSenateGaugeVersion
{
get
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCaseSenateGaugeVersion = value;
}
else
{
 mstrIdPubClassCaseSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.IdPubClassCaseSenateGaugeVersion);
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
 AddUpdatedFld(convPubClassCase.senateGaugeVersionID);
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
 AddUpdatedFld(convPubClassCase.senateGaugeVersionName);
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
 AddUpdatedFld(convPubClassCase.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 公开课案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubCaseType
{
get
{
return mstrIdPubCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubCaseType = value;
}
else
{
 mstrIdPubCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.IdPubCaseType);
}
}
/// <summary>
/// 公开课案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeID
{
get
{
return mstrPubCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeID = value;
}
else
{
 mstrPubCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubCaseTypeID);
}
}
/// <summary>
/// 公开课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeName
{
get
{
return mstrPubCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeName = value;
}
else
{
 mstrPubCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.PubCaseTypeName);
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
 AddUpdatedFld(convPubClassCase.IdStudyLevel);
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
 AddUpdatedFld(convPubClassCase.StudyLevelName);
}
}
/// <summary>
/// 光盘编号(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CDID
{
get
{
return mstrCDID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCDID = value;
}
else
{
 mstrCDID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.CDID);
}
}
/// <summary>
/// 简要介绍(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Introduction
{
get
{
return mstrIntroduction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIntroduction = value;
}
else
{
 mstrIntroduction = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase.Introduction);
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
 AddUpdatedFld(convPubClassCase.IsVisible);
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
 AddUpdatedFld(convPubClassCase.IsDualVideo);
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
 AddUpdatedFld(convPubClassCase.RecommendedDegreeId);
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
 AddUpdatedFld(convPubClassCase.RecommendedDegreeName);
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
 AddUpdatedFld(convPubClassCase.ftpFileType);
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
 AddUpdatedFld(convPubClassCase.VideoUrl);
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
 AddUpdatedFld(convPubClassCase.VideoPath);
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
 AddUpdatedFld(convPubClassCase.ResErrMsg);
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
 AddUpdatedFld(convPubClassCase.Memo);
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
 AddUpdatedFld(convPubClassCase.BrowseCount4Case);
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
  return mstrIdPubClassCase;
 }
 }
}
 /// <summary>
 /// v公开课案例(vPubClassCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPubClassCase
{
public const string _CurrTabName = "vPubClassCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "WorkUnit", "PubClassCaseTheme", "PubClassCaseBG", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdDiscipline", "DisciplineID", "DisciplineName", "IdTeachingPlan", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "TeachingPlanType", "SimplePlanContent", "PubClassCaseTimeIn", "IdPubClassCaseSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "IdStudyLevel", "StudyLevelName", "CDID", "Introduction", "IsVisible", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "BrowseCount4Case"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"PubClassCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseID = "PubClassCaseID";    //案例ID

 /// <summary>
 /// 常量:"PubClassCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseName = "PubClassCaseName";    //案例课题名称

 /// <summary>
 /// 常量:"PubClassCaseExecutor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseExecutor = "PubClassCaseExecutor";    //案例执教者

 /// <summary>
 /// 常量:"WorkUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkUnit = "WorkUnit";    //工作单位

 /// <summary>
 /// 常量:"PubClassCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTheme = "PubClassCaseTheme";    //案例主题词

 /// <summary>
 /// 常量:"PubClassCaseBG"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseBG = "PubClassCaseBG";    //案例背景资料

 /// <summary>
 /// 常量:"PubClassCaseTeachDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTeachDate = "PubClassCaseTeachDate";    //案例授课日期

 /// <summary>
 /// 常量:"PubClassCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseDateIn = "PubClassCaseDateIn";    //案例入库日期

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
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"SubjectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubjectName = "SubjectName";    //课题名称

 /// <summary>
 /// 常量:"TeachingPlanAuthor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanAuthor = "TeachingPlanAuthor";    //教案撰写人

 /// <summary>
 /// 常量:"TeachingObject"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingObject = "TeachingObject";    //教学目标

 /// <summary>
 /// 常量:"TeachingEmphases"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingEmphases = "TeachingEmphases";    //教学重点

 /// <summary>
 /// 常量:"TeachingDifficulty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingDifficulty = "TeachingDifficulty";    //教学难点

 /// <summary>
 /// 常量:"TeachingTool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingTool = "TeachingTool";    //教学用具

 /// <summary>
 /// 常量:"TeachingProcess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingProcess = "TeachingProcess";    //教学过程

 /// <summary>
 /// 常量:"TeachingPlanType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanType = "TeachingPlanType";    //教案类型

 /// <summary>
 /// 常量:"SimplePlanContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SimplePlanContent = "SimplePlanContent";    //简案内容

 /// <summary>
 /// 常量:"PubClassCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTimeIn = "PubClassCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdPubClassCaseSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenateGaugeVersion = "IdPubClassCaseSenateGaugeVersion";    //公开课量表版本流水号

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
 /// 常量:"IdPubCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubCaseType = "IdPubCaseType";    //公开课案例类型流水号

 /// <summary>
 /// 常量:"PubCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeID = "PubCaseTypeID";    //公开课案例类型ID

 /// <summary>
 /// 常量:"PubCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeName = "PubCaseTypeName";    //公开课案例类型名称

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
 /// 常量:"CDID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CDID = "CDID";    //光盘编号

 /// <summary>
 /// 常量:"Introduction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Introduction = "Introduction";    //简要介绍

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数
}

}