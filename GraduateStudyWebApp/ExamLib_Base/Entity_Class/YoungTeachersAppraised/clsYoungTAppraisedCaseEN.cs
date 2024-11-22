
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsYoungTAppraisedCaseEN
 表名:YoungTAppraisedCase(01120463)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// 表YoungTAppraisedCase的关键字(IdYoungTAppraisedCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdYoungTAppraisedCase_YoungTAppraisedCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdYoungTAppraisedCase">表关键字</param>
public K_IdYoungTAppraisedCase_YoungTAppraisedCase(string strIdYoungTAppraisedCase)
{
if (IsValid(strIdYoungTAppraisedCase)) Value = strIdYoungTAppraisedCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdYoungTAppraisedCase)
{
if (string.IsNullOrEmpty(strIdYoungTAppraisedCase) == true) return false;
if (strIdYoungTAppraisedCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdYoungTAppraisedCase_YoungTAppraisedCase]类型的对象</returns>
public static implicit operator K_IdYoungTAppraisedCase_YoungTAppraisedCase(string value)
{
return new K_IdYoungTAppraisedCase_YoungTAppraisedCase(value);
}
}
 /// <summary>
 /// 青教评优案例(YoungTAppraisedCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsYoungTAppraisedCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "YoungTAppraisedCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdYoungTAppraisedCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 33;
public static string[] AttributeName = new string[] {"IdYoungTAppraisedCase", "YoungTAppraisedCaseID", "YoungTAppraisedCaseName", "YoungTAppraisedCaseText", "YoungTAppraisedCaseDate", "YoungTAppraisedCaseTime", "YoungTAppraisedCaseTheme", "YoungTAppraisedCaseDateIn", "YoungTAppraisedCaseTimeIn", "IdStudyLevel", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "IsDualVideo", "IdYoungTAppraisedCaseType", "UserTypeId", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdUserId", "UpdDate", "Memo"};

protected string mstrIdYoungTAppraisedCase;    //青教评优案例流水号
protected string mstrYoungTAppraisedCaseID;    //青教评优案例ID
protected string mstrYoungTAppraisedCaseName;    //青教评优案例名称
protected string mstrYoungTAppraisedCaseText;    //案例文本内容
protected string mstrYoungTAppraisedCaseDate;    //青教评优教学日期
protected string mstrYoungTAppraisedCaseTime;    //青教评优教学时间
protected string mstrYoungTAppraisedCaseTheme;    //青教评优案例主题词
protected string mstrYoungTAppraisedCaseDateIn;    //案例入库日期
protected string mstrYoungTAppraisedCaseTimeIn;    //案例入库时间
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
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdYoungTAppraisedCaseType;    //青教案例类型流水号
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
 public clsYoungTAppraisedCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdYoungTAppraisedCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdYoungTAppraisedCase">关键字:青教评优案例流水号</param>
public clsYoungTAppraisedCaseEN(string strIdYoungTAppraisedCase)
 {
strIdYoungTAppraisedCase = strIdYoungTAppraisedCase.Replace("'", "''");
if (strIdYoungTAppraisedCase.Length > 8)
{
throw new Exception("在表:YoungTAppraisedCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdYoungTAppraisedCase)  ==  true)
{
throw new Exception("在表:YoungTAppraisedCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdYoungTAppraisedCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdYoungTAppraisedCase = strIdYoungTAppraisedCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdYoungTAppraisedCase");
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
if (strAttributeName  ==  conYoungTAppraisedCase.IdYoungTAppraisedCase)
{
return mstrIdYoungTAppraisedCase;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseID)
{
return mstrYoungTAppraisedCaseID;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseName)
{
return mstrYoungTAppraisedCaseName;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseText)
{
return mstrYoungTAppraisedCaseText;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseDate)
{
return mstrYoungTAppraisedCaseDate;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseTime)
{
return mstrYoungTAppraisedCaseTime;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseTheme)
{
return mstrYoungTAppraisedCaseTheme;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseDateIn)
{
return mstrYoungTAppraisedCaseDateIn;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn)
{
return mstrYoungTAppraisedCaseTimeIn;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdYoungTAppraisedCaseType)
{
return mstrIdYoungTAppraisedCaseType;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conYoungTAppraisedCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conYoungTAppraisedCase.IdYoungTAppraisedCase)
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdYoungTAppraisedCase);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseID)
{
mstrYoungTAppraisedCaseID = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseID);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseName)
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseName);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseText)
{
mstrYoungTAppraisedCaseText = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseText);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseDate)
{
mstrYoungTAppraisedCaseDate = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseDate);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseTime)
{
mstrYoungTAppraisedCaseTime = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTime);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseTheme)
{
mstrYoungTAppraisedCaseTheme = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseDateIn)
{
mstrYoungTAppraisedCaseDateIn = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn)
{
mstrYoungTAppraisedCaseTimeIn = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdStudyLevel);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdCaseType);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdDiscipline);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conYoungTAppraisedCase.BrowseCount);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdTeachSkill);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.CaseLevelId);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.DocFile);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conYoungTAppraisedCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.WordCreateDate);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conYoungTAppraisedCase.IsVisible);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.OwnerId);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conYoungTAppraisedCase.IsDualVideo);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.IdYoungTAppraisedCaseType)
{
mstrIdYoungTAppraisedCaseType = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.UserTypeId);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.ftpFileType);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.VideoUrl);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.VideoPath);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.ResErrMsg);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.UpdUserId);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.UpdDate);
}
else if (strAttributeName  ==  conYoungTAppraisedCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conYoungTAppraisedCase.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCase;
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseID  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseID;
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseName;
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseText  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseText;
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseDate  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseDate;
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseTime  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTime;
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseTheme  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTheme;
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseDateIn  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseDateIn;
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTimeIn;
}
else if (conYoungTAppraisedCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conYoungTAppraisedCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conYoungTAppraisedCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conYoungTAppraisedCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conYoungTAppraisedCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conYoungTAppraisedCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conYoungTAppraisedCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conYoungTAppraisedCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conYoungTAppraisedCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conYoungTAppraisedCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conYoungTAppraisedCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conYoungTAppraisedCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conYoungTAppraisedCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conYoungTAppraisedCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conYoungTAppraisedCase.IdYoungTAppraisedCaseType  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCaseType;
}
else if (conYoungTAppraisedCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conYoungTAppraisedCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conYoungTAppraisedCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conYoungTAppraisedCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conYoungTAppraisedCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conYoungTAppraisedCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conYoungTAppraisedCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conYoungTAppraisedCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conYoungTAppraisedCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conYoungTAppraisedCase.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdYoungTAppraisedCase);
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseID  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseID = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseID);
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseName);
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseText  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseText = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseText);
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseDate  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseDate = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseDate);
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseTime  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTime = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTime);
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseTheme  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTheme = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseDateIn  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseDateIn = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
}
else if (conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTimeIn = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
}
else if (conYoungTAppraisedCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdStudyLevel);
}
else if (conYoungTAppraisedCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdTeachingPlan);
}
else if (conYoungTAppraisedCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdCaseType);
}
else if (conYoungTAppraisedCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdDiscipline);
}
else if (conYoungTAppraisedCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conYoungTAppraisedCase.BrowseCount);
}
else if (conYoungTAppraisedCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdSenateGaugeVersion);
}
else if (conYoungTAppraisedCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdTeachSkill);
}
else if (conYoungTAppraisedCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.CaseLevelId);
}
else if (conYoungTAppraisedCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.DocFile);
}
else if (conYoungTAppraisedCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conYoungTAppraisedCase.IsNeedGeneWord);
}
else if (conYoungTAppraisedCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.WordCreateDate);
}
else if (conYoungTAppraisedCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conYoungTAppraisedCase.IsVisible);
}
else if (conYoungTAppraisedCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.OwnerId);
}
else if (conYoungTAppraisedCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conYoungTAppraisedCase.IsDualVideo);
}
else if (conYoungTAppraisedCase.IdYoungTAppraisedCaseType  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCaseType = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
}
else if (conYoungTAppraisedCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.UserTypeId);
}
else if (conYoungTAppraisedCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.RecommendedDegreeId);
}
else if (conYoungTAppraisedCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.ftpFileType);
}
else if (conYoungTAppraisedCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.VideoUrl);
}
else if (conYoungTAppraisedCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.VideoPath);
}
else if (conYoungTAppraisedCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.ResErrMsg);
}
else if (conYoungTAppraisedCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.UpdUserId);
}
else if (conYoungTAppraisedCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.UpdDate);
}
else if (conYoungTAppraisedCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCase.Memo);
}
}
}

/// <summary>
/// 青教评优案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdYoungTAppraisedCase
{
get
{
return mstrIdYoungTAppraisedCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdYoungTAppraisedCase = value;
}
else
{
 mstrIdYoungTAppraisedCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.IdYoungTAppraisedCase);
}
}
/// <summary>
/// 青教评优案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseID
{
get
{
return mstrYoungTAppraisedCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseID = value;
}
else
{
 mstrYoungTAppraisedCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseID);
}
}
/// <summary>
/// 青教评优案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseName
{
get
{
return mstrYoungTAppraisedCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseName = value;
}
else
{
 mstrYoungTAppraisedCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseText
{
get
{
return mstrYoungTAppraisedCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseText = value;
}
else
{
 mstrYoungTAppraisedCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseText);
}
}
/// <summary>
/// 青教评优教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseDate
{
get
{
return mstrYoungTAppraisedCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseDate = value;
}
else
{
 mstrYoungTAppraisedCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseDate);
}
}
/// <summary>
/// 青教评优教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTime
{
get
{
return mstrYoungTAppraisedCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTime = value;
}
else
{
 mstrYoungTAppraisedCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTime);
}
}
/// <summary>
/// 青教评优案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTheme
{
get
{
return mstrYoungTAppraisedCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTheme = value;
}
else
{
 mstrYoungTAppraisedCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseDateIn
{
get
{
return mstrYoungTAppraisedCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseDateIn = value;
}
else
{
 mstrYoungTAppraisedCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTimeIn
{
get
{
return mstrYoungTAppraisedCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTimeIn = value;
}
else
{
 mstrYoungTAppraisedCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
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
 AddUpdatedFld(conYoungTAppraisedCase.IdStudyLevel);
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
 AddUpdatedFld(conYoungTAppraisedCase.IdTeachingPlan);
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
 AddUpdatedFld(conYoungTAppraisedCase.IdCaseType);
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
 AddUpdatedFld(conYoungTAppraisedCase.IdDiscipline);
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
 AddUpdatedFld(conYoungTAppraisedCase.BrowseCount);
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
 AddUpdatedFld(conYoungTAppraisedCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conYoungTAppraisedCase.IdTeachSkill);
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
 AddUpdatedFld(conYoungTAppraisedCase.CaseLevelId);
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
 AddUpdatedFld(conYoungTAppraisedCase.DocFile);
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
 AddUpdatedFld(conYoungTAppraisedCase.IsNeedGeneWord);
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
 AddUpdatedFld(conYoungTAppraisedCase.WordCreateDate);
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
 AddUpdatedFld(conYoungTAppraisedCase.IsVisible);
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
 AddUpdatedFld(conYoungTAppraisedCase.OwnerId);
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
 AddUpdatedFld(conYoungTAppraisedCase.IsDualVideo);
}
}
/// <summary>
/// 青教案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdYoungTAppraisedCaseType
{
get
{
return mstrIdYoungTAppraisedCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdYoungTAppraisedCaseType = value;
}
else
{
 mstrIdYoungTAppraisedCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
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
 AddUpdatedFld(conYoungTAppraisedCase.UserTypeId);
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
 AddUpdatedFld(conYoungTAppraisedCase.RecommendedDegreeId);
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
 AddUpdatedFld(conYoungTAppraisedCase.ftpFileType);
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
 AddUpdatedFld(conYoungTAppraisedCase.VideoUrl);
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
 AddUpdatedFld(conYoungTAppraisedCase.VideoPath);
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
 AddUpdatedFld(conYoungTAppraisedCase.ResErrMsg);
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
 AddUpdatedFld(conYoungTAppraisedCase.UpdUserId);
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
 AddUpdatedFld(conYoungTAppraisedCase.UpdDate);
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
 AddUpdatedFld(conYoungTAppraisedCase.Memo);
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
  return mstrIdYoungTAppraisedCase;
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
  return mstrYoungTAppraisedCaseName;
 }
 }
}
 /// <summary>
 /// 青教评优案例(YoungTAppraisedCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conYoungTAppraisedCase
{
public const string _CurrTabName = "YoungTAppraisedCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdYoungTAppraisedCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdYoungTAppraisedCase", "YoungTAppraisedCaseID", "YoungTAppraisedCaseName", "YoungTAppraisedCaseText", "YoungTAppraisedCaseDate", "YoungTAppraisedCaseTime", "YoungTAppraisedCaseTheme", "YoungTAppraisedCaseDateIn", "YoungTAppraisedCaseTimeIn", "IdStudyLevel", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "IsDualVideo", "IdYoungTAppraisedCaseType", "UserTypeId", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdUserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdYoungTAppraisedCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdYoungTAppraisedCase = "IdYoungTAppraisedCase";    //青教评优案例流水号

 /// <summary>
 /// 常量:"YoungTAppraisedCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseID = "YoungTAppraisedCaseID";    //青教评优案例ID

 /// <summary>
 /// 常量:"YoungTAppraisedCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseName = "YoungTAppraisedCaseName";    //青教评优案例名称

 /// <summary>
 /// 常量:"YoungTAppraisedCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseText = "YoungTAppraisedCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"YoungTAppraisedCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseDate = "YoungTAppraisedCaseDate";    //青教评优教学日期

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTime = "YoungTAppraisedCaseTime";    //青教评优教学时间

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTheme = "YoungTAppraisedCaseTheme";    //青教评优案例主题词

 /// <summary>
 /// 常量:"YoungTAppraisedCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseDateIn = "YoungTAppraisedCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTimeIn = "YoungTAppraisedCaseTimeIn";    //案例入库时间

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
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"IdYoungTAppraisedCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdYoungTAppraisedCaseType = "IdYoungTAppraisedCaseType";    //青教案例类型流水号

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