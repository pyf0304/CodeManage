
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWritingOnBBCaseEN
 表名:WritingOnBBCase(01120467)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// 表WritingOnBBCase的关键字(IdWritingOnBBCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWritingOnBBCase_WritingOnBBCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdWritingOnBBCase">表关键字</param>
public K_IdWritingOnBBCase_WritingOnBBCase(string strIdWritingOnBBCase)
{
if (IsValid(strIdWritingOnBBCase)) Value = strIdWritingOnBBCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdWritingOnBBCase)
{
if (string.IsNullOrEmpty(strIdWritingOnBBCase) == true) return false;
if (strIdWritingOnBBCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWritingOnBBCase_WritingOnBBCase]类型的对象</returns>
public static implicit operator K_IdWritingOnBBCase_WritingOnBBCase(string value)
{
return new K_IdWritingOnBBCase_WritingOnBBCase(value);
}
}
 /// <summary>
 /// 板书教学案例(WritingOnBBCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsWritingOnBBCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "WritingOnBBCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWritingOnBBCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"IdWritingOnBBCase", "WritingOnBBCaseID", "WritingOnBBCaseName", "WritingOnBBCaseTheme", "IdDiscipline", "WritingOnBBCaseDate", "WritingOnBBCaseTime", "WritingOnBBCaseDateIn", "WritingOnBBCaseTimeIn", "BrowseCount", "IdStudyLevel", "IsNeedGeneWord", "WordCreateDate", "DocFile", "CaseLevelId", "IdSenateGaugeVersion", "IsVisible", "OwnerId", "IsDualVideo", "IdWritingOnBBCaseType", "UserTypeId", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdUserId", "UpdDate", "Memo"};

protected string mstrIdWritingOnBBCase;    //板书案例流水号
protected string mstrWritingOnBBCaseID;    //板书教学案例ID
protected string mstrWritingOnBBCaseName;    //板书教学案例名称
protected string mstrWritingOnBBCaseTheme;    //板书教学案例主题词
protected string mstrIdDiscipline;    //学科流水号
protected string mstrWritingOnBBCaseDate;    //板书教学日期
protected string mstrWritingOnBBCaseTime;    //板书教学时间
protected string mstrWritingOnBBCaseDateIn;    //案例入库日期
protected string mstrWritingOnBBCaseTimeIn;    //案例入库时间
protected int? mintBrowseCount;    //浏览次数
protected string mstrIdStudyLevel;    //学段流水号
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected string mstrDocFile;    //生成的Word文件名
protected string mstrCaseLevelId;    //课例等级Id
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected bool mbolIsVisible;    //是否显示
protected string mstrOwnerId;    //拥有者Id
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdWritingOnBBCaseType;    //板书案例类型流水号
protected string mstrUserTypeId;    //用户类型Id
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsWritingOnBBCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWritingOnBBCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdWritingOnBBCase">关键字:板书案例流水号</param>
public clsWritingOnBBCaseEN(string strIdWritingOnBBCase)
 {
strIdWritingOnBBCase = strIdWritingOnBBCase.Replace("'", "''");
if (strIdWritingOnBBCase.Length > 8)
{
throw new Exception("在表:WritingOnBBCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdWritingOnBBCase)  ==  true)
{
throw new Exception("在表:WritingOnBBCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdWritingOnBBCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdWritingOnBBCase = strIdWritingOnBBCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWritingOnBBCase");
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
if (strAttributeName  ==  conWritingOnBBCase.IdWritingOnBBCase)
{
return mstrIdWritingOnBBCase;
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseID)
{
return mstrWritingOnBBCaseID;
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseName)
{
return mstrWritingOnBBCaseName;
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseTheme)
{
return mstrWritingOnBBCaseTheme;
}
else if (strAttributeName  ==  conWritingOnBBCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseDate)
{
return mstrWritingOnBBCaseDate;
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseTime)
{
return mstrWritingOnBBCaseTime;
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseDateIn)
{
return mstrWritingOnBBCaseDateIn;
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseTimeIn)
{
return mstrWritingOnBBCaseTimeIn;
}
else if (strAttributeName  ==  conWritingOnBBCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conWritingOnBBCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conWritingOnBBCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conWritingOnBBCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conWritingOnBBCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conWritingOnBBCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conWritingOnBBCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conWritingOnBBCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conWritingOnBBCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conWritingOnBBCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conWritingOnBBCase.IdWritingOnBBCaseType)
{
return mstrIdWritingOnBBCaseType;
}
else if (strAttributeName  ==  conWritingOnBBCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conWritingOnBBCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conWritingOnBBCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conWritingOnBBCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conWritingOnBBCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conWritingOnBBCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conWritingOnBBCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conWritingOnBBCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conWritingOnBBCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conWritingOnBBCase.IdWritingOnBBCase)
{
mstrIdWritingOnBBCase = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdWritingOnBBCase);
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseID)
{
mstrWritingOnBBCaseID = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseID);
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseName)
{
mstrWritingOnBBCaseName = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseName);
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseTheme)
{
mstrWritingOnBBCaseTheme = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTheme);
}
else if (strAttributeName  ==  conWritingOnBBCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdDiscipline);
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseDate)
{
mstrWritingOnBBCaseDate = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseDate);
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseTime)
{
mstrWritingOnBBCaseTime = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTime);
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseDateIn)
{
mstrWritingOnBBCaseDateIn = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseDateIn);
}
else if (strAttributeName  ==  conWritingOnBBCase.WritingOnBBCaseTimeIn)
{
mstrWritingOnBBCaseTimeIn = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTimeIn);
}
else if (strAttributeName  ==  conWritingOnBBCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conWritingOnBBCase.BrowseCount);
}
else if (strAttributeName  ==  conWritingOnBBCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdStudyLevel);
}
else if (strAttributeName  ==  conWritingOnBBCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conWritingOnBBCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conWritingOnBBCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WordCreateDate);
}
else if (strAttributeName  ==  conWritingOnBBCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.DocFile);
}
else if (strAttributeName  ==  conWritingOnBBCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.CaseLevelId);
}
else if (strAttributeName  ==  conWritingOnBBCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conWritingOnBBCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conWritingOnBBCase.IsVisible);
}
else if (strAttributeName  ==  conWritingOnBBCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.OwnerId);
}
else if (strAttributeName  ==  conWritingOnBBCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conWritingOnBBCase.IsDualVideo);
}
else if (strAttributeName  ==  conWritingOnBBCase.IdWritingOnBBCaseType)
{
mstrIdWritingOnBBCaseType = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdWritingOnBBCaseType);
}
else if (strAttributeName  ==  conWritingOnBBCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.UserTypeId);
}
else if (strAttributeName  ==  conWritingOnBBCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conWritingOnBBCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.ftpFileType);
}
else if (strAttributeName  ==  conWritingOnBBCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.VideoUrl);
}
else if (strAttributeName  ==  conWritingOnBBCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.VideoPath);
}
else if (strAttributeName  ==  conWritingOnBBCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.ResErrMsg);
}
else if (strAttributeName  ==  conWritingOnBBCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.UpdUserId);
}
else if (strAttributeName  ==  conWritingOnBBCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.UpdDate);
}
else if (strAttributeName  ==  conWritingOnBBCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conWritingOnBBCase.IdWritingOnBBCase  ==  AttributeName[intIndex])
{
return mstrIdWritingOnBBCase;
}
else if (conWritingOnBBCase.WritingOnBBCaseID  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseID;
}
else if (conWritingOnBBCase.WritingOnBBCaseName  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseName;
}
else if (conWritingOnBBCase.WritingOnBBCaseTheme  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTheme;
}
else if (conWritingOnBBCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conWritingOnBBCase.WritingOnBBCaseDate  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseDate;
}
else if (conWritingOnBBCase.WritingOnBBCaseTime  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTime;
}
else if (conWritingOnBBCase.WritingOnBBCaseDateIn  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseDateIn;
}
else if (conWritingOnBBCase.WritingOnBBCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTimeIn;
}
else if (conWritingOnBBCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conWritingOnBBCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conWritingOnBBCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conWritingOnBBCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conWritingOnBBCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conWritingOnBBCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conWritingOnBBCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conWritingOnBBCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conWritingOnBBCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conWritingOnBBCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conWritingOnBBCase.IdWritingOnBBCaseType  ==  AttributeName[intIndex])
{
return mstrIdWritingOnBBCaseType;
}
else if (conWritingOnBBCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conWritingOnBBCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conWritingOnBBCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conWritingOnBBCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conWritingOnBBCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conWritingOnBBCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conWritingOnBBCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conWritingOnBBCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conWritingOnBBCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conWritingOnBBCase.IdWritingOnBBCase  ==  AttributeName[intIndex])
{
mstrIdWritingOnBBCase = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdWritingOnBBCase);
}
else if (conWritingOnBBCase.WritingOnBBCaseID  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseID = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseID);
}
else if (conWritingOnBBCase.WritingOnBBCaseName  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseName = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseName);
}
else if (conWritingOnBBCase.WritingOnBBCaseTheme  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTheme = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTheme);
}
else if (conWritingOnBBCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdDiscipline);
}
else if (conWritingOnBBCase.WritingOnBBCaseDate  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseDate = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseDate);
}
else if (conWritingOnBBCase.WritingOnBBCaseTime  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTime = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTime);
}
else if (conWritingOnBBCase.WritingOnBBCaseDateIn  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseDateIn = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseDateIn);
}
else if (conWritingOnBBCase.WritingOnBBCaseTimeIn  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTimeIn = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTimeIn);
}
else if (conWritingOnBBCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conWritingOnBBCase.BrowseCount);
}
else if (conWritingOnBBCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdStudyLevel);
}
else if (conWritingOnBBCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conWritingOnBBCase.IsNeedGeneWord);
}
else if (conWritingOnBBCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.WordCreateDate);
}
else if (conWritingOnBBCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.DocFile);
}
else if (conWritingOnBBCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.CaseLevelId);
}
else if (conWritingOnBBCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdSenateGaugeVersion);
}
else if (conWritingOnBBCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conWritingOnBBCase.IsVisible);
}
else if (conWritingOnBBCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.OwnerId);
}
else if (conWritingOnBBCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conWritingOnBBCase.IsDualVideo);
}
else if (conWritingOnBBCase.IdWritingOnBBCaseType  ==  AttributeName[intIndex])
{
mstrIdWritingOnBBCaseType = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.IdWritingOnBBCaseType);
}
else if (conWritingOnBBCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.UserTypeId);
}
else if (conWritingOnBBCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.RecommendedDegreeId);
}
else if (conWritingOnBBCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.ftpFileType);
}
else if (conWritingOnBBCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.VideoUrl);
}
else if (conWritingOnBBCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.VideoPath);
}
else if (conWritingOnBBCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.ResErrMsg);
}
else if (conWritingOnBBCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.UpdUserId);
}
else if (conWritingOnBBCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.UpdDate);
}
else if (conWritingOnBBCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWritingOnBBCase.Memo);
}
}
}

/// <summary>
/// 板书案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdWritingOnBBCase
{
get
{
return mstrIdWritingOnBBCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdWritingOnBBCase = value;
}
else
{
 mstrIdWritingOnBBCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.IdWritingOnBBCase);
}
}
/// <summary>
/// 板书教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseID
{
get
{
return mstrWritingOnBBCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseID = value;
}
else
{
 mstrWritingOnBBCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseID);
}
}
/// <summary>
/// 板书教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseName
{
get
{
return mstrWritingOnBBCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseName = value;
}
else
{
 mstrWritingOnBBCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseName);
}
}
/// <summary>
/// 板书教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseTheme
{
get
{
return mstrWritingOnBBCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseTheme = value;
}
else
{
 mstrWritingOnBBCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTheme);
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
 AddUpdatedFld(conWritingOnBBCase.IdDiscipline);
}
}
/// <summary>
/// 板书教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseDate
{
get
{
return mstrWritingOnBBCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseDate = value;
}
else
{
 mstrWritingOnBBCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseDate);
}
}
/// <summary>
/// 板书教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseTime
{
get
{
return mstrWritingOnBBCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseTime = value;
}
else
{
 mstrWritingOnBBCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseDateIn
{
get
{
return mstrWritingOnBBCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseDateIn = value;
}
else
{
 mstrWritingOnBBCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseTimeIn
{
get
{
return mstrWritingOnBBCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseTimeIn = value;
}
else
{
 mstrWritingOnBBCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.WritingOnBBCaseTimeIn);
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
 AddUpdatedFld(conWritingOnBBCase.BrowseCount);
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
 AddUpdatedFld(conWritingOnBBCase.IdStudyLevel);
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
 AddUpdatedFld(conWritingOnBBCase.IsNeedGeneWord);
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
 AddUpdatedFld(conWritingOnBBCase.WordCreateDate);
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
 AddUpdatedFld(conWritingOnBBCase.DocFile);
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
 AddUpdatedFld(conWritingOnBBCase.CaseLevelId);
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
 AddUpdatedFld(conWritingOnBBCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conWritingOnBBCase.IsVisible);
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
 AddUpdatedFld(conWritingOnBBCase.OwnerId);
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
 AddUpdatedFld(conWritingOnBBCase.IsDualVideo);
}
}
/// <summary>
/// 板书案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdWritingOnBBCaseType
{
get
{
return mstrIdWritingOnBBCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdWritingOnBBCaseType = value;
}
else
{
 mstrIdWritingOnBBCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCase.IdWritingOnBBCaseType);
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
 AddUpdatedFld(conWritingOnBBCase.UserTypeId);
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
 AddUpdatedFld(conWritingOnBBCase.RecommendedDegreeId);
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
 AddUpdatedFld(conWritingOnBBCase.ftpFileType);
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
 AddUpdatedFld(conWritingOnBBCase.VideoUrl);
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
 AddUpdatedFld(conWritingOnBBCase.VideoPath);
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
 AddUpdatedFld(conWritingOnBBCase.ResErrMsg);
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
 AddUpdatedFld(conWritingOnBBCase.UpdUserId);
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
 AddUpdatedFld(conWritingOnBBCase.UpdDate);
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
 AddUpdatedFld(conWritingOnBBCase.Memo);
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
  return mstrIdWritingOnBBCase;
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
  return mstrWritingOnBBCaseName;
 }
 }
}
 /// <summary>
 /// 板书教学案例(WritingOnBBCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conWritingOnBBCase
{
public const string _CurrTabName = "WritingOnBBCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWritingOnBBCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWritingOnBBCase", "WritingOnBBCaseID", "WritingOnBBCaseName", "WritingOnBBCaseTheme", "IdDiscipline", "WritingOnBBCaseDate", "WritingOnBBCaseTime", "WritingOnBBCaseDateIn", "WritingOnBBCaseTimeIn", "BrowseCount", "IdStudyLevel", "IsNeedGeneWord", "WordCreateDate", "DocFile", "CaseLevelId", "IdSenateGaugeVersion", "IsVisible", "OwnerId", "IsDualVideo", "IdWritingOnBBCaseType", "UserTypeId", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdUserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWritingOnBBCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWritingOnBBCase = "IdWritingOnBBCase";    //板书案例流水号

 /// <summary>
 /// 常量:"WritingOnBBCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseID = "WritingOnBBCaseID";    //板书教学案例ID

 /// <summary>
 /// 常量:"WritingOnBBCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseName = "WritingOnBBCaseName";    //板书教学案例名称

 /// <summary>
 /// 常量:"WritingOnBBCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseTheme = "WritingOnBBCaseTheme";    //板书教学案例主题词

 /// <summary>
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

 /// <summary>
 /// 常量:"WritingOnBBCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseDate = "WritingOnBBCaseDate";    //板书教学日期

 /// <summary>
 /// 常量:"WritingOnBBCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseTime = "WritingOnBBCaseTime";    //板书教学时间

 /// <summary>
 /// 常量:"WritingOnBBCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseDateIn = "WritingOnBBCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"WritingOnBBCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseTimeIn = "WritingOnBBCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //学段流水号

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
 /// 常量:"DocFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DocFile = "DocFile";    //生成的Word文件名

 /// <summary>
 /// 常量:"CaseLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelId = "CaseLevelId";    //课例等级Id

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

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
 /// 常量:"IdWritingOnBBCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWritingOnBBCaseType = "IdWritingOnBBCaseType";    //板书案例类型流水号

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
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}