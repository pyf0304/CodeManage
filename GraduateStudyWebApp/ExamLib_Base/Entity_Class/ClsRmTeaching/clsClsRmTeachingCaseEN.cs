
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClsRmTeachingCaseEN
 表名:ClsRmTeachingCase(01120381)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 表ClsRmTeachingCase的关键字(IdClsRmTeachingCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdClsRmTeachingCase_ClsRmTeachingCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdClsRmTeachingCase">表关键字</param>
public K_IdClsRmTeachingCase_ClsRmTeachingCase(string strIdClsRmTeachingCase)
{
if (IsValid(strIdClsRmTeachingCase)) Value = strIdClsRmTeachingCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdClsRmTeachingCase)
{
if (string.IsNullOrEmpty(strIdClsRmTeachingCase) == true) return false;
if (strIdClsRmTeachingCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdClsRmTeachingCase_ClsRmTeachingCase]类型的对象</returns>
public static implicit operator K_IdClsRmTeachingCase_ClsRmTeachingCase(string value)
{
return new K_IdClsRmTeachingCase_ClsRmTeachingCase(value);
}
}
 /// <summary>
 /// 课堂教学案例(ClsRmTeachingCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsClsRmTeachingCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ClsRmTeachingCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdClsRmTeachingCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 37;
public static string[] AttributeName = new string[] {"IdClsRmTeachingCase", "ClsRmTeachingCaseID", "ClsRmTeachingCaseName", "ClsRmTeachingCaseTheme", "IdClsRmTeachingCaseType", "ClsRmTeachingCaseText", "ClsRmTeachingCaseDate", "ClsRmTeachingCaseTime", "ClsRmTeachingCaseDateIn", "ClsRmTeachingCaseTimeIn", "IdStudyLevel", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "IdSchoolPs", "IdDisciplinePs", "IdGradeBase", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "UserKindId", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdClsRmTeachingCase;    //课堂教学案例流水号
protected string mstrClsRmTeachingCaseID;    //课堂教学案例ID
protected string mstrClsRmTeachingCaseName;    //课堂教学案例名称
protected string mstrClsRmTeachingCaseTheme;    //课堂教学案例主题词
protected string mstrIdClsRmTeachingCaseType;    //课堂案例类型流水号
protected string mstrClsRmTeachingCaseText;    //案例文本内容
protected string mstrClsRmTeachingCaseDate;    //课堂教学日期
protected string mstrClsRmTeachingCaseTime;    //课堂教学时间
protected string mstrClsRmTeachingCaseDateIn;    //案例入库日期
protected string mstrClsRmTeachingCaseTimeIn;    //案例入库时间
protected string mstrIdStudyLevel;    //学段流水号
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrIdSchoolPs;    //学校流水号
protected string mstrIdDisciplinePs;    //学科流水号
protected string mstrIdGradeBase;    //年级流水号
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
 public clsClsRmTeachingCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdClsRmTeachingCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdClsRmTeachingCase">关键字:课堂教学案例流水号</param>
public clsClsRmTeachingCaseEN(string strIdClsRmTeachingCase)
 {
strIdClsRmTeachingCase = strIdClsRmTeachingCase.Replace("'", "''");
if (strIdClsRmTeachingCase.Length > 8)
{
throw new Exception("在表:ClsRmTeachingCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdClsRmTeachingCase)  ==  true)
{
throw new Exception("在表:ClsRmTeachingCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdClsRmTeachingCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdClsRmTeachingCase = strIdClsRmTeachingCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdClsRmTeachingCase");
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
if (strAttributeName  ==  conClsRmTeachingCase.IdClsRmTeachingCase)
{
return mstrIdClsRmTeachingCase;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseID)
{
return mstrClsRmTeachingCaseID;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseName)
{
return mstrClsRmTeachingCaseName;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseTheme)
{
return mstrClsRmTeachingCaseTheme;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdClsRmTeachingCaseType)
{
return mstrIdClsRmTeachingCaseType;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseText)
{
return mstrClsRmTeachingCaseText;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseDate)
{
return mstrClsRmTeachingCaseDate;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseTime)
{
return mstrClsRmTeachingCaseTime;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseDateIn)
{
return mstrClsRmTeachingCaseDateIn;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseTimeIn)
{
return mstrClsRmTeachingCaseTimeIn;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdSchoolPs)
{
return mstrIdSchoolPs;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdDisciplinePs)
{
return mstrIdDisciplinePs;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conClsRmTeachingCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conClsRmTeachingCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conClsRmTeachingCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conClsRmTeachingCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conClsRmTeachingCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conClsRmTeachingCase.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  conClsRmTeachingCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conClsRmTeachingCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conClsRmTeachingCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conClsRmTeachingCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conClsRmTeachingCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conClsRmTeachingCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conClsRmTeachingCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conClsRmTeachingCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conClsRmTeachingCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conClsRmTeachingCase.IdClsRmTeachingCase)
{
mstrIdClsRmTeachingCase = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdClsRmTeachingCase);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseID)
{
mstrClsRmTeachingCaseID = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseID);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseName)
{
mstrClsRmTeachingCaseName = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseName);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseTheme)
{
mstrClsRmTeachingCaseTheme = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTheme);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdClsRmTeachingCaseType)
{
mstrIdClsRmTeachingCaseType = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdClsRmTeachingCaseType);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseText)
{
mstrClsRmTeachingCaseText = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseText);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseDate)
{
mstrClsRmTeachingCaseDate = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseDate);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseTime)
{
mstrClsRmTeachingCaseTime = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTime);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseDateIn)
{
mstrClsRmTeachingCaseDateIn = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ClsRmTeachingCaseTimeIn)
{
mstrClsRmTeachingCaseTimeIn = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdStudyLevel);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdCaseType);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdDiscipline);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdSchoolPs)
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdSchoolPs);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdDisciplinePs)
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdDisciplinePs);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdGradeBase);
}
else if (strAttributeName  ==  conClsRmTeachingCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conClsRmTeachingCase.BrowseCount);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdTeachSkill);
}
else if (strAttributeName  ==  conClsRmTeachingCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.CaseLevelId);
}
else if (strAttributeName  ==  conClsRmTeachingCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.DocFile);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conClsRmTeachingCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conClsRmTeachingCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.WordCreateDate);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conClsRmTeachingCase.IsVisible);
}
else if (strAttributeName  ==  conClsRmTeachingCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.OwnerId);
}
else if (strAttributeName  ==  conClsRmTeachingCase.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.UserKindId);
}
else if (strAttributeName  ==  conClsRmTeachingCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.UserTypeId);
}
else if (strAttributeName  ==  conClsRmTeachingCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conClsRmTeachingCase.IsDualVideo);
}
else if (strAttributeName  ==  conClsRmTeachingCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ftpFileType);
}
else if (strAttributeName  ==  conClsRmTeachingCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.VideoUrl);
}
else if (strAttributeName  ==  conClsRmTeachingCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.VideoPath);
}
else if (strAttributeName  ==  conClsRmTeachingCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ResErrMsg);
}
else if (strAttributeName  ==  conClsRmTeachingCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.UpdDate);
}
else if (strAttributeName  ==  conClsRmTeachingCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.UpdUserId);
}
else if (strAttributeName  ==  conClsRmTeachingCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conClsRmTeachingCase.IdClsRmTeachingCase  ==  AttributeName[intIndex])
{
return mstrIdClsRmTeachingCase;
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseID  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseID;
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseName  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseName;
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseTheme  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTheme;
}
else if (conClsRmTeachingCase.IdClsRmTeachingCaseType  ==  AttributeName[intIndex])
{
return mstrIdClsRmTeachingCaseType;
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseText  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseText;
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseDate  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseDate;
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseTime  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTime;
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseDateIn  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseDateIn;
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTimeIn;
}
else if (conClsRmTeachingCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conClsRmTeachingCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conClsRmTeachingCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conClsRmTeachingCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conClsRmTeachingCase.IdSchoolPs  ==  AttributeName[intIndex])
{
return mstrIdSchoolPs;
}
else if (conClsRmTeachingCase.IdDisciplinePs  ==  AttributeName[intIndex])
{
return mstrIdDisciplinePs;
}
else if (conClsRmTeachingCase.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conClsRmTeachingCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conClsRmTeachingCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conClsRmTeachingCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conClsRmTeachingCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conClsRmTeachingCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conClsRmTeachingCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conClsRmTeachingCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conClsRmTeachingCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conClsRmTeachingCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conClsRmTeachingCase.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (conClsRmTeachingCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conClsRmTeachingCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conClsRmTeachingCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conClsRmTeachingCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conClsRmTeachingCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conClsRmTeachingCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conClsRmTeachingCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conClsRmTeachingCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conClsRmTeachingCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conClsRmTeachingCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conClsRmTeachingCase.IdClsRmTeachingCase  ==  AttributeName[intIndex])
{
mstrIdClsRmTeachingCase = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdClsRmTeachingCase);
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseID  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseID = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseID);
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseName  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseName = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseName);
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseTheme  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTheme = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTheme);
}
else if (conClsRmTeachingCase.IdClsRmTeachingCaseType  ==  AttributeName[intIndex])
{
mstrIdClsRmTeachingCaseType = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdClsRmTeachingCaseType);
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseText  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseText = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseText);
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseDate  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseDate = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseDate);
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseTime  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTime = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTime);
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseDateIn  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseDateIn = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
}
else if (conClsRmTeachingCase.ClsRmTeachingCaseTimeIn  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTimeIn = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
}
else if (conClsRmTeachingCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdStudyLevel);
}
else if (conClsRmTeachingCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdTeachingPlan);
}
else if (conClsRmTeachingCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdCaseType);
}
else if (conClsRmTeachingCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdDiscipline);
}
else if (conClsRmTeachingCase.IdSchoolPs  ==  AttributeName[intIndex])
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdSchoolPs);
}
else if (conClsRmTeachingCase.IdDisciplinePs  ==  AttributeName[intIndex])
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdDisciplinePs);
}
else if (conClsRmTeachingCase.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdGradeBase);
}
else if (conClsRmTeachingCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conClsRmTeachingCase.BrowseCount);
}
else if (conClsRmTeachingCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdSenateGaugeVersion);
}
else if (conClsRmTeachingCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.IdTeachSkill);
}
else if (conClsRmTeachingCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.CaseLevelId);
}
else if (conClsRmTeachingCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.DocFile);
}
else if (conClsRmTeachingCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conClsRmTeachingCase.IsNeedGeneWord);
}
else if (conClsRmTeachingCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.WordCreateDate);
}
else if (conClsRmTeachingCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conClsRmTeachingCase.IsVisible);
}
else if (conClsRmTeachingCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.OwnerId);
}
else if (conClsRmTeachingCase.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.UserKindId);
}
else if (conClsRmTeachingCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.UserTypeId);
}
else if (conClsRmTeachingCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conClsRmTeachingCase.IsDualVideo);
}
else if (conClsRmTeachingCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.RecommendedDegreeId);
}
else if (conClsRmTeachingCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ftpFileType);
}
else if (conClsRmTeachingCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.VideoUrl);
}
else if (conClsRmTeachingCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.VideoPath);
}
else if (conClsRmTeachingCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.ResErrMsg);
}
else if (conClsRmTeachingCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.UpdDate);
}
else if (conClsRmTeachingCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.UpdUserId);
}
else if (conClsRmTeachingCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClsRmTeachingCase.Memo);
}
}
}

/// <summary>
/// 课堂教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdClsRmTeachingCase
{
get
{
return mstrIdClsRmTeachingCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdClsRmTeachingCase = value;
}
else
{
 mstrIdClsRmTeachingCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.IdClsRmTeachingCase);
}
}
/// <summary>
/// 课堂教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseID
{
get
{
return mstrClsRmTeachingCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseID = value;
}
else
{
 mstrClsRmTeachingCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseID);
}
}
/// <summary>
/// 课堂教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseName
{
get
{
return mstrClsRmTeachingCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseName = value;
}
else
{
 mstrClsRmTeachingCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseName);
}
}
/// <summary>
/// 课堂教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTheme
{
get
{
return mstrClsRmTeachingCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTheme = value;
}
else
{
 mstrClsRmTeachingCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTheme);
}
}
/// <summary>
/// 课堂案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdClsRmTeachingCaseType
{
get
{
return mstrIdClsRmTeachingCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdClsRmTeachingCaseType = value;
}
else
{
 mstrIdClsRmTeachingCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.IdClsRmTeachingCaseType);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseText
{
get
{
return mstrClsRmTeachingCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseText = value;
}
else
{
 mstrClsRmTeachingCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseText);
}
}
/// <summary>
/// 课堂教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseDate
{
get
{
return mstrClsRmTeachingCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseDate = value;
}
else
{
 mstrClsRmTeachingCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseDate);
}
}
/// <summary>
/// 课堂教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTime
{
get
{
return mstrClsRmTeachingCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTime = value;
}
else
{
 mstrClsRmTeachingCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseDateIn
{
get
{
return mstrClsRmTeachingCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseDateIn = value;
}
else
{
 mstrClsRmTeachingCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTimeIn
{
get
{
return mstrClsRmTeachingCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTimeIn = value;
}
else
{
 mstrClsRmTeachingCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
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
 AddUpdatedFld(conClsRmTeachingCase.IdStudyLevel);
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
 AddUpdatedFld(conClsRmTeachingCase.IdTeachingPlan);
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
 AddUpdatedFld(conClsRmTeachingCase.IdCaseType);
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
 AddUpdatedFld(conClsRmTeachingCase.IdDiscipline);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchoolPs
{
get
{
return mstrIdSchoolPs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchoolPs = value;
}
else
{
 mstrIdSchoolPs = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.IdSchoolPs);
}
}
/// <summary>
/// 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDisciplinePs
{
get
{
return mstrIdDisciplinePs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDisciplinePs = value;
}
else
{
 mstrIdDisciplinePs = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.IdDisciplinePs);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCase.IdGradeBase);
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
 AddUpdatedFld(conClsRmTeachingCase.BrowseCount);
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
 AddUpdatedFld(conClsRmTeachingCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conClsRmTeachingCase.IdTeachSkill);
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
 AddUpdatedFld(conClsRmTeachingCase.CaseLevelId);
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
 AddUpdatedFld(conClsRmTeachingCase.DocFile);
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
 AddUpdatedFld(conClsRmTeachingCase.IsNeedGeneWord);
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
 AddUpdatedFld(conClsRmTeachingCase.WordCreateDate);
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
 AddUpdatedFld(conClsRmTeachingCase.IsVisible);
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
 AddUpdatedFld(conClsRmTeachingCase.OwnerId);
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
 AddUpdatedFld(conClsRmTeachingCase.UserKindId);
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
 AddUpdatedFld(conClsRmTeachingCase.UserTypeId);
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
 AddUpdatedFld(conClsRmTeachingCase.IsDualVideo);
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
 AddUpdatedFld(conClsRmTeachingCase.RecommendedDegreeId);
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
 AddUpdatedFld(conClsRmTeachingCase.ftpFileType);
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
 AddUpdatedFld(conClsRmTeachingCase.VideoUrl);
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
 AddUpdatedFld(conClsRmTeachingCase.VideoPath);
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
 AddUpdatedFld(conClsRmTeachingCase.ResErrMsg);
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
 AddUpdatedFld(conClsRmTeachingCase.UpdDate);
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
 AddUpdatedFld(conClsRmTeachingCase.UpdUserId);
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
 AddUpdatedFld(conClsRmTeachingCase.Memo);
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
  return mstrIdClsRmTeachingCase;
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
  return mstrClsRmTeachingCaseName;
 }
 }
}
 /// <summary>
 /// 课堂教学案例(ClsRmTeachingCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conClsRmTeachingCase
{
public const string _CurrTabName = "ClsRmTeachingCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdClsRmTeachingCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdClsRmTeachingCase", "ClsRmTeachingCaseID", "ClsRmTeachingCaseName", "ClsRmTeachingCaseTheme", "IdClsRmTeachingCaseType", "ClsRmTeachingCaseText", "ClsRmTeachingCaseDate", "ClsRmTeachingCaseTime", "ClsRmTeachingCaseDateIn", "ClsRmTeachingCaseTimeIn", "IdStudyLevel", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "IdSchoolPs", "IdDisciplinePs", "IdGradeBase", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "OwnerId", "UserKindId", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdClsRmTeachingCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdClsRmTeachingCase = "IdClsRmTeachingCase";    //课堂教学案例流水号

 /// <summary>
 /// 常量:"ClsRmTeachingCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseID = "ClsRmTeachingCaseID";    //课堂教学案例ID

 /// <summary>
 /// 常量:"ClsRmTeachingCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseName = "ClsRmTeachingCaseName";    //课堂教学案例名称

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTheme = "ClsRmTeachingCaseTheme";    //课堂教学案例主题词

 /// <summary>
 /// 常量:"IdClsRmTeachingCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdClsRmTeachingCaseType = "IdClsRmTeachingCaseType";    //课堂案例类型流水号

 /// <summary>
 /// 常量:"ClsRmTeachingCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseText = "ClsRmTeachingCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"ClsRmTeachingCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseDate = "ClsRmTeachingCaseDate";    //课堂教学日期

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTime = "ClsRmTeachingCaseTime";    //课堂教学时间

 /// <summary>
 /// 常量:"ClsRmTeachingCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseDateIn = "ClsRmTeachingCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTimeIn = "ClsRmTeachingCaseTimeIn";    //案例入库时间

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
 /// 常量:"IdSchoolPs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchoolPs = "IdSchoolPs";    //学校流水号

 /// <summary>
 /// 常量:"IdDisciplinePs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDisciplinePs = "IdDisciplinePs";    //学科流水号

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

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