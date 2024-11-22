
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMandarinCaseEN
 表名:MandarinCase(01120466)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// 表MandarinCase的关键字(IdMandarinCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMandarinCase_MandarinCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMandarinCase">表关键字</param>
public K_IdMandarinCase_MandarinCase(string strIdMandarinCase)
{
if (IsValid(strIdMandarinCase)) Value = strIdMandarinCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMandarinCase)
{
if (string.IsNullOrEmpty(strIdMandarinCase) == true) return false;
if (strIdMandarinCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMandarinCase_MandarinCase]类型的对象</returns>
public static implicit operator K_IdMandarinCase_MandarinCase(string value)
{
return new K_IdMandarinCase_MandarinCase(value);
}
}
 /// <summary>
 /// 普通话教学案例(MandarinCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMandarinCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MandarinCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMandarinCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 30;
public static string[] AttributeName = new string[] {"IdMandarinCase", "MandarinCaseID", "MandarinCaseName", "IdDiscipline", "IdStudyLevel", "MandarinCaseTheme", "MandarinCaseDate", "MandarinCaseTime", "MandarinCaseDateIn", "MandarinCaseTimeIn", "IdTeachingPlan", "IdSenateGaugeVersion", "CaseLevelId", "IsNeedGeneWord", "DocFile", "WordCreateDate", "BrowseCount", "IsVisible", "OwnerId", "IsDualVideo", "IdMandarinCaseType", "UserTypeId", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdMandarinCase;    //普通话案例流水号
protected string mstrMandarinCaseID;    //普通话教学案例ID
protected string mstrMandarinCaseName;    //普通话教学案例名称
protected string mstrIdDiscipline;    //学科流水号
protected string mstrIdStudyLevel;    //学段流水号
protected string mstrMandarinCaseTheme;    //普通话教学案例主题词
protected string mstrMandarinCaseDate;    //普通话教学日期
protected string mstrMandarinCaseTime;    //普通话教学时间
protected string mstrMandarinCaseDateIn;    //案例入库日期
protected string mstrMandarinCaseTimeIn;    //案例入库时间
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrCaseLevelId;    //课例等级Id
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrDocFile;    //生成的Word文件名
protected string mstrWordCreateDate;    //Word生成日期
protected int? mintBrowseCount;    //浏览次数
protected bool mbolIsVisible;    //是否显示
protected string mstrOwnerId;    //拥有者Id
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdMandarinCaseType;    //普通话案例类型流水号
protected string mstrUserTypeId;    //用户类型Id
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
 public clsMandarinCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMandarinCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMandarinCase">关键字:普通话案例流水号</param>
public clsMandarinCaseEN(string strIdMandarinCase)
 {
strIdMandarinCase = strIdMandarinCase.Replace("'", "''");
if (strIdMandarinCase.Length > 8)
{
throw new Exception("在表:MandarinCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMandarinCase)  ==  true)
{
throw new Exception("在表:MandarinCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMandarinCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMandarinCase = strIdMandarinCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMandarinCase");
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
if (strAttributeName  ==  conMandarinCase.IdMandarinCase)
{
return mstrIdMandarinCase;
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseID)
{
return mstrMandarinCaseID;
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseName)
{
return mstrMandarinCaseName;
}
else if (strAttributeName  ==  conMandarinCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conMandarinCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseTheme)
{
return mstrMandarinCaseTheme;
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseDate)
{
return mstrMandarinCaseDate;
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseTime)
{
return mstrMandarinCaseTime;
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseDateIn)
{
return mstrMandarinCaseDateIn;
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseTimeIn)
{
return mstrMandarinCaseTimeIn;
}
else if (strAttributeName  ==  conMandarinCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conMandarinCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conMandarinCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conMandarinCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conMandarinCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conMandarinCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conMandarinCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conMandarinCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conMandarinCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conMandarinCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conMandarinCase.IdMandarinCaseType)
{
return mstrIdMandarinCaseType;
}
else if (strAttributeName  ==  conMandarinCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conMandarinCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conMandarinCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conMandarinCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conMandarinCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conMandarinCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conMandarinCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conMandarinCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conMandarinCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMandarinCase.IdMandarinCase)
{
mstrIdMandarinCase = value.ToString();
 AddUpdatedFld(conMandarinCase.IdMandarinCase);
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseID)
{
mstrMandarinCaseID = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseID);
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseName)
{
mstrMandarinCaseName = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseName);
}
else if (strAttributeName  ==  conMandarinCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conMandarinCase.IdDiscipline);
}
else if (strAttributeName  ==  conMandarinCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conMandarinCase.IdStudyLevel);
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseTheme)
{
mstrMandarinCaseTheme = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseTheme);
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseDate)
{
mstrMandarinCaseDate = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseDate);
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseTime)
{
mstrMandarinCaseTime = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseTime);
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseDateIn)
{
mstrMandarinCaseDateIn = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseDateIn);
}
else if (strAttributeName  ==  conMandarinCase.MandarinCaseTimeIn)
{
mstrMandarinCaseTimeIn = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseTimeIn);
}
else if (strAttributeName  ==  conMandarinCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conMandarinCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conMandarinCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conMandarinCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conMandarinCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conMandarinCase.CaseLevelId);
}
else if (strAttributeName  ==  conMandarinCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conMandarinCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conMandarinCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conMandarinCase.DocFile);
}
else if (strAttributeName  ==  conMandarinCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conMandarinCase.WordCreateDate);
}
else if (strAttributeName  ==  conMandarinCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conMandarinCase.BrowseCount);
}
else if (strAttributeName  ==  conMandarinCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conMandarinCase.IsVisible);
}
else if (strAttributeName  ==  conMandarinCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conMandarinCase.OwnerId);
}
else if (strAttributeName  ==  conMandarinCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conMandarinCase.IsDualVideo);
}
else if (strAttributeName  ==  conMandarinCase.IdMandarinCaseType)
{
mstrIdMandarinCaseType = value.ToString();
 AddUpdatedFld(conMandarinCase.IdMandarinCaseType);
}
else if (strAttributeName  ==  conMandarinCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conMandarinCase.UserTypeId);
}
else if (strAttributeName  ==  conMandarinCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conMandarinCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conMandarinCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conMandarinCase.ftpFileType);
}
else if (strAttributeName  ==  conMandarinCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conMandarinCase.VideoUrl);
}
else if (strAttributeName  ==  conMandarinCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conMandarinCase.VideoPath);
}
else if (strAttributeName  ==  conMandarinCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conMandarinCase.ResErrMsg);
}
else if (strAttributeName  ==  conMandarinCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMandarinCase.UpdDate);
}
else if (strAttributeName  ==  conMandarinCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conMandarinCase.UpdUserId);
}
else if (strAttributeName  ==  conMandarinCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMandarinCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMandarinCase.IdMandarinCase  ==  AttributeName[intIndex])
{
return mstrIdMandarinCase;
}
else if (conMandarinCase.MandarinCaseID  ==  AttributeName[intIndex])
{
return mstrMandarinCaseID;
}
else if (conMandarinCase.MandarinCaseName  ==  AttributeName[intIndex])
{
return mstrMandarinCaseName;
}
else if (conMandarinCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conMandarinCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conMandarinCase.MandarinCaseTheme  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTheme;
}
else if (conMandarinCase.MandarinCaseDate  ==  AttributeName[intIndex])
{
return mstrMandarinCaseDate;
}
else if (conMandarinCase.MandarinCaseTime  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTime;
}
else if (conMandarinCase.MandarinCaseDateIn  ==  AttributeName[intIndex])
{
return mstrMandarinCaseDateIn;
}
else if (conMandarinCase.MandarinCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTimeIn;
}
else if (conMandarinCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conMandarinCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conMandarinCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conMandarinCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conMandarinCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conMandarinCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conMandarinCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conMandarinCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conMandarinCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conMandarinCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conMandarinCase.IdMandarinCaseType  ==  AttributeName[intIndex])
{
return mstrIdMandarinCaseType;
}
else if (conMandarinCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conMandarinCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conMandarinCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conMandarinCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conMandarinCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conMandarinCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conMandarinCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conMandarinCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conMandarinCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMandarinCase.IdMandarinCase  ==  AttributeName[intIndex])
{
mstrIdMandarinCase = value.ToString();
 AddUpdatedFld(conMandarinCase.IdMandarinCase);
}
else if (conMandarinCase.MandarinCaseID  ==  AttributeName[intIndex])
{
mstrMandarinCaseID = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseID);
}
else if (conMandarinCase.MandarinCaseName  ==  AttributeName[intIndex])
{
mstrMandarinCaseName = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseName);
}
else if (conMandarinCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conMandarinCase.IdDiscipline);
}
else if (conMandarinCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conMandarinCase.IdStudyLevel);
}
else if (conMandarinCase.MandarinCaseTheme  ==  AttributeName[intIndex])
{
mstrMandarinCaseTheme = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseTheme);
}
else if (conMandarinCase.MandarinCaseDate  ==  AttributeName[intIndex])
{
mstrMandarinCaseDate = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseDate);
}
else if (conMandarinCase.MandarinCaseTime  ==  AttributeName[intIndex])
{
mstrMandarinCaseTime = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseTime);
}
else if (conMandarinCase.MandarinCaseDateIn  ==  AttributeName[intIndex])
{
mstrMandarinCaseDateIn = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseDateIn);
}
else if (conMandarinCase.MandarinCaseTimeIn  ==  AttributeName[intIndex])
{
mstrMandarinCaseTimeIn = value.ToString();
 AddUpdatedFld(conMandarinCase.MandarinCaseTimeIn);
}
else if (conMandarinCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conMandarinCase.IdTeachingPlan);
}
else if (conMandarinCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conMandarinCase.IdSenateGaugeVersion);
}
else if (conMandarinCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conMandarinCase.CaseLevelId);
}
else if (conMandarinCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conMandarinCase.IsNeedGeneWord);
}
else if (conMandarinCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conMandarinCase.DocFile);
}
else if (conMandarinCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conMandarinCase.WordCreateDate);
}
else if (conMandarinCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conMandarinCase.BrowseCount);
}
else if (conMandarinCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conMandarinCase.IsVisible);
}
else if (conMandarinCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conMandarinCase.OwnerId);
}
else if (conMandarinCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conMandarinCase.IsDualVideo);
}
else if (conMandarinCase.IdMandarinCaseType  ==  AttributeName[intIndex])
{
mstrIdMandarinCaseType = value.ToString();
 AddUpdatedFld(conMandarinCase.IdMandarinCaseType);
}
else if (conMandarinCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conMandarinCase.UserTypeId);
}
else if (conMandarinCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conMandarinCase.RecommendedDegreeId);
}
else if (conMandarinCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conMandarinCase.ftpFileType);
}
else if (conMandarinCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conMandarinCase.VideoUrl);
}
else if (conMandarinCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conMandarinCase.VideoPath);
}
else if (conMandarinCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conMandarinCase.ResErrMsg);
}
else if (conMandarinCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMandarinCase.UpdDate);
}
else if (conMandarinCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conMandarinCase.UpdUserId);
}
else if (conMandarinCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMandarinCase.Memo);
}
}
}

/// <summary>
/// 普通话案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMandarinCase
{
get
{
return mstrIdMandarinCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMandarinCase = value;
}
else
{
 mstrIdMandarinCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.IdMandarinCase);
}
}
/// <summary>
/// 普通话教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseID
{
get
{
return mstrMandarinCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseID = value;
}
else
{
 mstrMandarinCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.MandarinCaseID);
}
}
/// <summary>
/// 普通话教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseName
{
get
{
return mstrMandarinCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseName = value;
}
else
{
 mstrMandarinCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.MandarinCaseName);
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
 AddUpdatedFld(conMandarinCase.IdDiscipline);
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
 AddUpdatedFld(conMandarinCase.IdStudyLevel);
}
}
/// <summary>
/// 普通话教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseTheme
{
get
{
return mstrMandarinCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseTheme = value;
}
else
{
 mstrMandarinCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.MandarinCaseTheme);
}
}
/// <summary>
/// 普通话教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseDate
{
get
{
return mstrMandarinCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseDate = value;
}
else
{
 mstrMandarinCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.MandarinCaseDate);
}
}
/// <summary>
/// 普通话教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseTime
{
get
{
return mstrMandarinCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseTime = value;
}
else
{
 mstrMandarinCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.MandarinCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseDateIn
{
get
{
return mstrMandarinCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseDateIn = value;
}
else
{
 mstrMandarinCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.MandarinCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseTimeIn
{
get
{
return mstrMandarinCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseTimeIn = value;
}
else
{
 mstrMandarinCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.MandarinCaseTimeIn);
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
 AddUpdatedFld(conMandarinCase.IdTeachingPlan);
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
 AddUpdatedFld(conMandarinCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conMandarinCase.CaseLevelId);
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
 AddUpdatedFld(conMandarinCase.IsNeedGeneWord);
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
 AddUpdatedFld(conMandarinCase.DocFile);
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
 AddUpdatedFld(conMandarinCase.WordCreateDate);
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
 AddUpdatedFld(conMandarinCase.BrowseCount);
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
 AddUpdatedFld(conMandarinCase.IsVisible);
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
 AddUpdatedFld(conMandarinCase.OwnerId);
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
 AddUpdatedFld(conMandarinCase.IsDualVideo);
}
}
/// <summary>
/// 普通话案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMandarinCaseType
{
get
{
return mstrIdMandarinCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMandarinCaseType = value;
}
else
{
 mstrIdMandarinCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCase.IdMandarinCaseType);
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
 AddUpdatedFld(conMandarinCase.UserTypeId);
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
 AddUpdatedFld(conMandarinCase.RecommendedDegreeId);
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
 AddUpdatedFld(conMandarinCase.ftpFileType);
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
 AddUpdatedFld(conMandarinCase.VideoUrl);
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
 AddUpdatedFld(conMandarinCase.VideoPath);
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
 AddUpdatedFld(conMandarinCase.ResErrMsg);
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
 AddUpdatedFld(conMandarinCase.UpdDate);
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
 AddUpdatedFld(conMandarinCase.UpdUserId);
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
 AddUpdatedFld(conMandarinCase.Memo);
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
  return mstrIdMandarinCase;
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
  return mstrMandarinCaseName;
 }
 }
}
 /// <summary>
 /// 普通话教学案例(MandarinCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMandarinCase
{
public const string _CurrTabName = "MandarinCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMandarinCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMandarinCase", "MandarinCaseID", "MandarinCaseName", "IdDiscipline", "IdStudyLevel", "MandarinCaseTheme", "MandarinCaseDate", "MandarinCaseTime", "MandarinCaseDateIn", "MandarinCaseTimeIn", "IdTeachingPlan", "IdSenateGaugeVersion", "CaseLevelId", "IsNeedGeneWord", "DocFile", "WordCreateDate", "BrowseCount", "IsVisible", "OwnerId", "IsDualVideo", "IdMandarinCaseType", "UserTypeId", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMandarinCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMandarinCase = "IdMandarinCase";    //普通话案例流水号

 /// <summary>
 /// 常量:"MandarinCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseID = "MandarinCaseID";    //普通话教学案例ID

 /// <summary>
 /// 常量:"MandarinCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseName = "MandarinCaseName";    //普通话教学案例名称

 /// <summary>
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //学段流水号

 /// <summary>
 /// 常量:"MandarinCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseTheme = "MandarinCaseTheme";    //普通话教学案例主题词

 /// <summary>
 /// 常量:"MandarinCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseDate = "MandarinCaseDate";    //普通话教学日期

 /// <summary>
 /// 常量:"MandarinCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseTime = "MandarinCaseTime";    //普通话教学时间

 /// <summary>
 /// 常量:"MandarinCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseDateIn = "MandarinCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"MandarinCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseTimeIn = "MandarinCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"CaseLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelId = "CaseLevelId";    //课例等级Id

 /// <summary>
 /// 常量:"IsNeedGeneWord"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGeneWord = "IsNeedGeneWord";    //是否需要生成Word

 /// <summary>
 /// 常量:"DocFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DocFile = "DocFile";    //生成的Word文件名

 /// <summary>
 /// 常量:"WordCreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WordCreateDate = "WordCreateDate";    //Word生成日期

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"IdMandarinCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMandarinCaseType = "IdMandarinCaseType";    //普通话案例类型流水号

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

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