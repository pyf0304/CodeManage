
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareCaseEN
 表名:CoursewareCase(01120416)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// 表CoursewareCase的关键字(IdCoursewareCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCoursewareCase_CoursewareCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCoursewareCase">表关键字</param>
public K_IdCoursewareCase_CoursewareCase(string strIdCoursewareCase)
{
if (IsValid(strIdCoursewareCase)) Value = strIdCoursewareCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCoursewareCase)
{
if (string.IsNullOrEmpty(strIdCoursewareCase) == true) return false;
if (strIdCoursewareCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCoursewareCase_CoursewareCase]类型的对象</returns>
public static implicit operator K_IdCoursewareCase_CoursewareCase(string value)
{
return new K_IdCoursewareCase_CoursewareCase(value);
}
}
 /// <summary>
 /// 课件教学案例(CoursewareCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCoursewareCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CoursewareCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCoursewareCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 34;
public static string[] AttributeName = new string[] {"IdCoursewareCase", "CoursewareCaseID", "CoursewareCaseName", "CoursewareCaseTheme", "IdCoursewareCaseType", "CoursewareCaseText", "CoursewareCaseDate", "CoursewareCaseTime", "CoursewareCaseDateIn", "CoursewareCaseTimeIn", "IdStudyLevel", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "UserKindId", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdCoursewareCase;    //课件教学案例流水号
protected string mstrCoursewareCaseID;    //课件教学案例ID
protected string mstrCoursewareCaseName;    //课件教学案例名称
protected string mstrCoursewareCaseTheme;    //课件教学案例主题词
protected string mstrIdCoursewareCaseType;    //课件案例类型流水号
protected string mstrCoursewareCaseText;    //案例文本内容
protected string mstrCoursewareCaseDate;    //课件教学日期
protected string mstrCoursewareCaseTime;    //课件教学时间
protected string mstrCoursewareCaseDateIn;    //案例入库日期
protected string mstrCoursewareCaseTimeIn;    //案例入库时间
protected string mstrIdStudyLevel;    //学段流水号
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdDiscipline;    //学科流水号
protected int? mintBrowseCount;    //浏览次数
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrCaseLevelId;    //课例等级Id
protected string mstrDocFile;    //生成的Word文件名
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected bool mbolIsVisible;    //是否显示
protected string mstrOwnerId;    //拥有者Id
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserTypeId;    //用户类型Id
protected bool mbolIsDualVideo;    //是否双视频
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
 public clsCoursewareCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCoursewareCase">关键字:课件教学案例流水号</param>
public clsCoursewareCaseEN(string strIdCoursewareCase)
 {
strIdCoursewareCase = strIdCoursewareCase.Replace("'", "''");
if (strIdCoursewareCase.Length > 8)
{
throw new Exception("在表:CoursewareCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCoursewareCase)  ==  true)
{
throw new Exception("在表:CoursewareCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCoursewareCase = strIdCoursewareCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareCase");
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
if (strAttributeName  ==  conCoursewareCase.IdCoursewareCase)
{
return mstrIdCoursewareCase;
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseID)
{
return mstrCoursewareCaseID;
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseName)
{
return mstrCoursewareCaseName;
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseTheme)
{
return mstrCoursewareCaseTheme;
}
else if (strAttributeName  ==  conCoursewareCase.IdCoursewareCaseType)
{
return mstrIdCoursewareCaseType;
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseText)
{
return mstrCoursewareCaseText;
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseDate)
{
return mstrCoursewareCaseDate;
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseTime)
{
return mstrCoursewareCaseTime;
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseDateIn)
{
return mstrCoursewareCaseDateIn;
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseTimeIn)
{
return mstrCoursewareCaseTimeIn;
}
else if (strAttributeName  ==  conCoursewareCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conCoursewareCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conCoursewareCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conCoursewareCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conCoursewareCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conCoursewareCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conCoursewareCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conCoursewareCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conCoursewareCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conCoursewareCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conCoursewareCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conCoursewareCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conCoursewareCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conCoursewareCase.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  conCoursewareCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conCoursewareCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conCoursewareCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conCoursewareCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conCoursewareCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conCoursewareCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conCoursewareCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conCoursewareCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCoursewareCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCoursewareCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCoursewareCase.IdCoursewareCase)
{
mstrIdCoursewareCase = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdCoursewareCase);
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseID)
{
mstrCoursewareCaseID = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseID);
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseName)
{
mstrCoursewareCaseName = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseName);
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseTheme)
{
mstrCoursewareCaseTheme = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTheme);
}
else if (strAttributeName  ==  conCoursewareCase.IdCoursewareCaseType)
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdCoursewareCaseType);
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseText)
{
mstrCoursewareCaseText = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseText);
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseDate)
{
mstrCoursewareCaseDate = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseDate);
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseTime)
{
mstrCoursewareCaseTime = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTime);
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseDateIn)
{
mstrCoursewareCaseDateIn = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseDateIn);
}
else if (strAttributeName  ==  conCoursewareCase.CoursewareCaseTimeIn)
{
mstrCoursewareCaseTimeIn = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTimeIn);
}
else if (strAttributeName  ==  conCoursewareCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdStudyLevel);
}
else if (strAttributeName  ==  conCoursewareCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conCoursewareCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdCaseType);
}
else if (strAttributeName  ==  conCoursewareCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdDiscipline);
}
else if (strAttributeName  ==  conCoursewareCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareCase.BrowseCount);
}
else if (strAttributeName  ==  conCoursewareCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conCoursewareCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdTeachSkill);
}
else if (strAttributeName  ==  conCoursewareCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conCoursewareCase.CaseLevelId);
}
else if (strAttributeName  ==  conCoursewareCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conCoursewareCase.DocFile);
}
else if (strAttributeName  ==  conCoursewareCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conCoursewareCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conCoursewareCase.WordCreateDate);
}
else if (strAttributeName  ==  conCoursewareCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareCase.IsVisible);
}
else if (strAttributeName  ==  conCoursewareCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCoursewareCase.OwnerId);
}
else if (strAttributeName  ==  conCoursewareCase.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(conCoursewareCase.UserKindId);
}
else if (strAttributeName  ==  conCoursewareCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conCoursewareCase.UserTypeId);
}
else if (strAttributeName  ==  conCoursewareCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareCase.IsDualVideo);
}
else if (strAttributeName  ==  conCoursewareCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conCoursewareCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conCoursewareCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conCoursewareCase.ftpFileType);
}
else if (strAttributeName  ==  conCoursewareCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conCoursewareCase.VideoUrl);
}
else if (strAttributeName  ==  conCoursewareCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conCoursewareCase.VideoPath);
}
else if (strAttributeName  ==  conCoursewareCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conCoursewareCase.ResErrMsg);
}
else if (strAttributeName  ==  conCoursewareCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCoursewareCase.UpdDate);
}
else if (strAttributeName  ==  conCoursewareCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCoursewareCase.UpdUserId);
}
else if (strAttributeName  ==  conCoursewareCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCoursewareCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCoursewareCase.IdCoursewareCase  ==  AttributeName[intIndex])
{
return mstrIdCoursewareCase;
}
else if (conCoursewareCase.CoursewareCaseID  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseID;
}
else if (conCoursewareCase.CoursewareCaseName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseName;
}
else if (conCoursewareCase.CoursewareCaseTheme  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTheme;
}
else if (conCoursewareCase.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareCaseType;
}
else if (conCoursewareCase.CoursewareCaseText  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseText;
}
else if (conCoursewareCase.CoursewareCaseDate  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseDate;
}
else if (conCoursewareCase.CoursewareCaseTime  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTime;
}
else if (conCoursewareCase.CoursewareCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseDateIn;
}
else if (conCoursewareCase.CoursewareCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTimeIn;
}
else if (conCoursewareCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conCoursewareCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conCoursewareCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conCoursewareCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conCoursewareCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conCoursewareCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conCoursewareCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conCoursewareCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conCoursewareCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conCoursewareCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conCoursewareCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conCoursewareCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conCoursewareCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conCoursewareCase.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (conCoursewareCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conCoursewareCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conCoursewareCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conCoursewareCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conCoursewareCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conCoursewareCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conCoursewareCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conCoursewareCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCoursewareCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCoursewareCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCoursewareCase.IdCoursewareCase  ==  AttributeName[intIndex])
{
mstrIdCoursewareCase = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdCoursewareCase);
}
else if (conCoursewareCase.CoursewareCaseID  ==  AttributeName[intIndex])
{
mstrCoursewareCaseID = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseID);
}
else if (conCoursewareCase.CoursewareCaseName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseName = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseName);
}
else if (conCoursewareCase.CoursewareCaseTheme  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTheme = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTheme);
}
else if (conCoursewareCase.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdCoursewareCaseType);
}
else if (conCoursewareCase.CoursewareCaseText  ==  AttributeName[intIndex])
{
mstrCoursewareCaseText = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseText);
}
else if (conCoursewareCase.CoursewareCaseDate  ==  AttributeName[intIndex])
{
mstrCoursewareCaseDate = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseDate);
}
else if (conCoursewareCase.CoursewareCaseTime  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTime = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTime);
}
else if (conCoursewareCase.CoursewareCaseDateIn  ==  AttributeName[intIndex])
{
mstrCoursewareCaseDateIn = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseDateIn);
}
else if (conCoursewareCase.CoursewareCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTimeIn = value.ToString();
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTimeIn);
}
else if (conCoursewareCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdStudyLevel);
}
else if (conCoursewareCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdTeachingPlan);
}
else if (conCoursewareCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdCaseType);
}
else if (conCoursewareCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdDiscipline);
}
else if (conCoursewareCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCoursewareCase.BrowseCount);
}
else if (conCoursewareCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdSenateGaugeVersion);
}
else if (conCoursewareCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conCoursewareCase.IdTeachSkill);
}
else if (conCoursewareCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conCoursewareCase.CaseLevelId);
}
else if (conCoursewareCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conCoursewareCase.DocFile);
}
else if (conCoursewareCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareCase.IsNeedGeneWord);
}
else if (conCoursewareCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conCoursewareCase.WordCreateDate);
}
else if (conCoursewareCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareCase.IsVisible);
}
else if (conCoursewareCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCoursewareCase.OwnerId);
}
else if (conCoursewareCase.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(conCoursewareCase.UserKindId);
}
else if (conCoursewareCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conCoursewareCase.UserTypeId);
}
else if (conCoursewareCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conCoursewareCase.IsDualVideo);
}
else if (conCoursewareCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conCoursewareCase.RecommendedDegreeId);
}
else if (conCoursewareCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conCoursewareCase.ftpFileType);
}
else if (conCoursewareCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conCoursewareCase.VideoUrl);
}
else if (conCoursewareCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conCoursewareCase.VideoPath);
}
else if (conCoursewareCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conCoursewareCase.ResErrMsg);
}
else if (conCoursewareCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCoursewareCase.UpdDate);
}
else if (conCoursewareCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCoursewareCase.UpdUserId);
}
else if (conCoursewareCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCoursewareCase.Memo);
}
}
}

/// <summary>
/// 课件教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareCase
{
get
{
return mstrIdCoursewareCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareCase = value;
}
else
{
 mstrIdCoursewareCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.IdCoursewareCase);
}
}
/// <summary>
/// 课件教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseID
{
get
{
return mstrCoursewareCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseID = value;
}
else
{
 mstrCoursewareCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.CoursewareCaseID);
}
}
/// <summary>
/// 课件教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseName
{
get
{
return mstrCoursewareCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseName = value;
}
else
{
 mstrCoursewareCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.CoursewareCaseName);
}
}
/// <summary>
/// 课件教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTheme
{
get
{
return mstrCoursewareCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTheme = value;
}
else
{
 mstrCoursewareCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTheme);
}
}
/// <summary>
/// 课件案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareCaseType
{
get
{
return mstrIdCoursewareCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareCaseType = value;
}
else
{
 mstrIdCoursewareCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.IdCoursewareCaseType);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseText
{
get
{
return mstrCoursewareCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseText = value;
}
else
{
 mstrCoursewareCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.CoursewareCaseText);
}
}
/// <summary>
/// 课件教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseDate
{
get
{
return mstrCoursewareCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseDate = value;
}
else
{
 mstrCoursewareCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.CoursewareCaseDate);
}
}
/// <summary>
/// 课件教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTime
{
get
{
return mstrCoursewareCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTime = value;
}
else
{
 mstrCoursewareCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseDateIn
{
get
{
return mstrCoursewareCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseDateIn = value;
}
else
{
 mstrCoursewareCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.CoursewareCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTimeIn
{
get
{
return mstrCoursewareCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTimeIn = value;
}
else
{
 mstrCoursewareCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.CoursewareCaseTimeIn);
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
 AddUpdatedFld(conCoursewareCase.IdStudyLevel);
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
 AddUpdatedFld(conCoursewareCase.IdTeachingPlan);
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
 AddUpdatedFld(conCoursewareCase.IdCaseType);
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
 AddUpdatedFld(conCoursewareCase.IdDiscipline);
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
 AddUpdatedFld(conCoursewareCase.BrowseCount);
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
 AddUpdatedFld(conCoursewareCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conCoursewareCase.IdTeachSkill);
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
 AddUpdatedFld(conCoursewareCase.CaseLevelId);
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
 AddUpdatedFld(conCoursewareCase.DocFile);
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
 AddUpdatedFld(conCoursewareCase.IsNeedGeneWord);
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
 AddUpdatedFld(conCoursewareCase.WordCreateDate);
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
 AddUpdatedFld(conCoursewareCase.IsVisible);
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
 AddUpdatedFld(conCoursewareCase.OwnerId);
}
}
/// <summary>
/// 用户类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindId
{
get
{
return mstrUserKindId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindId = value;
}
else
{
 mstrUserKindId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.UserKindId);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCase.UserTypeId);
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
 AddUpdatedFld(conCoursewareCase.IsDualVideo);
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
 AddUpdatedFld(conCoursewareCase.RecommendedDegreeId);
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
 AddUpdatedFld(conCoursewareCase.ftpFileType);
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
 AddUpdatedFld(conCoursewareCase.VideoUrl);
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
 AddUpdatedFld(conCoursewareCase.VideoPath);
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
 AddUpdatedFld(conCoursewareCase.ResErrMsg);
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
 AddUpdatedFld(conCoursewareCase.UpdDate);
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
 AddUpdatedFld(conCoursewareCase.UpdUserId);
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
 AddUpdatedFld(conCoursewareCase.Memo);
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
  return mstrIdCoursewareCase;
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
  return mstrCoursewareCaseName;
 }
 }
}
 /// <summary>
 /// 课件教学案例(CoursewareCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCoursewareCase
{
public const string _CurrTabName = "CoursewareCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCoursewareCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCoursewareCase", "CoursewareCaseID", "CoursewareCaseName", "CoursewareCaseTheme", "IdCoursewareCaseType", "CoursewareCaseText", "CoursewareCaseDate", "CoursewareCaseTime", "CoursewareCaseDateIn", "CoursewareCaseTimeIn", "IdStudyLevel", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "UserKindId", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCoursewareCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareCase = "IdCoursewareCase";    //课件教学案例流水号

 /// <summary>
 /// 常量:"CoursewareCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseID = "CoursewareCaseID";    //课件教学案例ID

 /// <summary>
 /// 常量:"CoursewareCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseName = "CoursewareCaseName";    //课件教学案例名称

 /// <summary>
 /// 常量:"CoursewareCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTheme = "CoursewareCaseTheme";    //课件教学案例主题词

 /// <summary>
 /// 常量:"IdCoursewareCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareCaseType = "IdCoursewareCaseType";    //课件案例类型流水号

 /// <summary>
 /// 常量:"CoursewareCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseText = "CoursewareCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"CoursewareCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseDate = "CoursewareCaseDate";    //课件教学日期

 /// <summary>
 /// 常量:"CoursewareCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTime = "CoursewareCaseTime";    //课件教学时间

 /// <summary>
 /// 常量:"CoursewareCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseDateIn = "CoursewareCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CoursewareCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTimeIn = "CoursewareCaseTimeIn";    //案例入库时间

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
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

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
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"UserKindId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindId = "UserKindId";    //用户类别Id

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

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