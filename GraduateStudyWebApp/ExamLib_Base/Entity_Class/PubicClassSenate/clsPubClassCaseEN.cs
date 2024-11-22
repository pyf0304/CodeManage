
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseEN
 表名:PubClassCase(01120385)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表PubClassCase的关键字(IdPubClassCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCase_PubClassCase
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
public K_IdPubClassCase_PubClassCase(string strIdPubClassCase)
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
 /// <returns>返回:[K_IdPubClassCase_PubClassCase]类型的对象</returns>
public static implicit operator K_IdPubClassCase_PubClassCase(string value)
{
return new K_IdPubClassCase_PubClassCase(value);
}
}
 /// <summary>
 /// 公开课案例(PubClassCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubClassCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubClassCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "WorkUnit", "PubClassCaseTheme", "PubClassCaseBG", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdDiscipline", "IdTeachingPlan", "PubClassCaseTimeIn", "IdPubClassCaseSenateGaugeVersion", "BrowseCount", "IdPubCaseType", "IdStudyLevel", "CDID", "Introduction", "IsVisible", "IsDualVideo", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

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
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrPubClassCaseTimeIn;    //案例入库时间
protected string mstrIdPubClassCaseSenateGaugeVersion;    //公开课量表版本流水号
protected int? mintBrowseCount;    //浏览次数
protected string mstrIdPubCaseType;    //公开课案例类型流水号
protected string mstrIdStudyLevel;    //学段流水号
protected string mstrCDID;    //光盘编号
protected string mstrIntroduction;    //简要介绍
protected bool mbolIsVisible;    //是否显示
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
 public clsPubClassCaseEN()
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
public clsPubClassCaseEN(string strIdPubClassCase)
 {
strIdPubClassCase = strIdPubClassCase.Replace("'", "''");
if (strIdPubClassCase.Length > 8)
{
throw new Exception("在表:PubClassCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPubClassCase)  ==  true)
{
throw new Exception("在表:PubClassCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conPubClassCase.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseID)
{
return mstrPubClassCaseID;
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseName)
{
return mstrPubClassCaseName;
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseExecutor)
{
return mstrPubClassCaseExecutor;
}
else if (strAttributeName  ==  conPubClassCase.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseTheme)
{
return mstrPubClassCaseTheme;
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseBG)
{
return mstrPubClassCaseBG;
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseTeachDate)
{
return mstrPubClassCaseTeachDate;
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseDateIn)
{
return mstrPubClassCaseDateIn;
}
else if (strAttributeName  ==  conPubClassCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conPubClassCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseTimeIn)
{
return mstrPubClassCaseTimeIn;
}
else if (strAttributeName  ==  conPubClassCase.IdPubClassCaseSenateGaugeVersion)
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (strAttributeName  ==  conPubClassCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conPubClassCase.IdPubCaseType)
{
return mstrIdPubCaseType;
}
else if (strAttributeName  ==  conPubClassCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conPubClassCase.CDID)
{
return mstrCDID;
}
else if (strAttributeName  ==  conPubClassCase.Introduction)
{
return mstrIntroduction;
}
else if (strAttributeName  ==  conPubClassCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conPubClassCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conPubClassCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conPubClassCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conPubClassCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conPubClassCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conPubClassCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conPubClassCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPubClassCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conPubClassCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPubClassCase.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCase.IdPubClassCase);
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseID)
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseID);
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseName)
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseName);
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseExecutor)
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseExecutor);
}
else if (strAttributeName  ==  conPubClassCase.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conPubClassCase.WorkUnit);
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseTheme)
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseTheme);
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseBG)
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseBG);
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseTeachDate)
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseTeachDate);
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseDateIn)
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseDateIn);
}
else if (strAttributeName  ==  conPubClassCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conPubClassCase.IdDiscipline);
}
else if (strAttributeName  ==  conPubClassCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conPubClassCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conPubClassCase.PubClassCaseTimeIn)
{
mstrPubClassCaseTimeIn = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseTimeIn);
}
else if (strAttributeName  ==  conPubClassCase.IdPubClassCaseSenateGaugeVersion)
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conPubClassCase.IdPubClassCaseSenateGaugeVersion);
}
else if (strAttributeName  ==  conPubClassCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCase.BrowseCount);
}
else if (strAttributeName  ==  conPubClassCase.IdPubCaseType)
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(conPubClassCase.IdPubCaseType);
}
else if (strAttributeName  ==  conPubClassCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conPubClassCase.IdStudyLevel);
}
else if (strAttributeName  ==  conPubClassCase.CDID)
{
mstrCDID = value.ToString();
 AddUpdatedFld(conPubClassCase.CDID);
}
else if (strAttributeName  ==  conPubClassCase.Introduction)
{
mstrIntroduction = value.ToString();
 AddUpdatedFld(conPubClassCase.Introduction);
}
else if (strAttributeName  ==  conPubClassCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCase.IsVisible);
}
else if (strAttributeName  ==  conPubClassCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCase.IsDualVideo);
}
else if (strAttributeName  ==  conPubClassCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conPubClassCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conPubClassCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conPubClassCase.ftpFileType);
}
else if (strAttributeName  ==  conPubClassCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conPubClassCase.VideoUrl);
}
else if (strAttributeName  ==  conPubClassCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conPubClassCase.VideoPath);
}
else if (strAttributeName  ==  conPubClassCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conPubClassCase.ResErrMsg);
}
else if (strAttributeName  ==  conPubClassCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPubClassCase.UpdDate);
}
else if (strAttributeName  ==  conPubClassCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPubClassCase.UpdUserId);
}
else if (strAttributeName  ==  conPubClassCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubClassCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubClassCase.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (conPubClassCase.PubClassCaseID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseID;
}
else if (conPubClassCase.PubClassCaseName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseName;
}
else if (conPubClassCase.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
return mstrPubClassCaseExecutor;
}
else if (conPubClassCase.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (conPubClassCase.PubClassCaseTheme  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTheme;
}
else if (conPubClassCase.PubClassCaseBG  ==  AttributeName[intIndex])
{
return mstrPubClassCaseBG;
}
else if (conPubClassCase.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTeachDate;
}
else if (conPubClassCase.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseDateIn;
}
else if (conPubClassCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conPubClassCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conPubClassCase.PubClassCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTimeIn;
}
else if (conPubClassCase.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (conPubClassCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conPubClassCase.IdPubCaseType  ==  AttributeName[intIndex])
{
return mstrIdPubCaseType;
}
else if (conPubClassCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conPubClassCase.CDID  ==  AttributeName[intIndex])
{
return mstrCDID;
}
else if (conPubClassCase.Introduction  ==  AttributeName[intIndex])
{
return mstrIntroduction;
}
else if (conPubClassCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conPubClassCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conPubClassCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conPubClassCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conPubClassCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conPubClassCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conPubClassCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conPubClassCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPubClassCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conPubClassCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPubClassCase.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCase.IdPubClassCase);
}
else if (conPubClassCase.PubClassCaseID  ==  AttributeName[intIndex])
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseID);
}
else if (conPubClassCase.PubClassCaseName  ==  AttributeName[intIndex])
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseName);
}
else if (conPubClassCase.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseExecutor);
}
else if (conPubClassCase.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conPubClassCase.WorkUnit);
}
else if (conPubClassCase.PubClassCaseTheme  ==  AttributeName[intIndex])
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseTheme);
}
else if (conPubClassCase.PubClassCaseBG  ==  AttributeName[intIndex])
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseBG);
}
else if (conPubClassCase.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseTeachDate);
}
else if (conPubClassCase.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseDateIn);
}
else if (conPubClassCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conPubClassCase.IdDiscipline);
}
else if (conPubClassCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conPubClassCase.IdTeachingPlan);
}
else if (conPubClassCase.PubClassCaseTimeIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseTimeIn = value.ToString();
 AddUpdatedFld(conPubClassCase.PubClassCaseTimeIn);
}
else if (conPubClassCase.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conPubClassCase.IdPubClassCaseSenateGaugeVersion);
}
else if (conPubClassCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCase.BrowseCount);
}
else if (conPubClassCase.IdPubCaseType  ==  AttributeName[intIndex])
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(conPubClassCase.IdPubCaseType);
}
else if (conPubClassCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conPubClassCase.IdStudyLevel);
}
else if (conPubClassCase.CDID  ==  AttributeName[intIndex])
{
mstrCDID = value.ToString();
 AddUpdatedFld(conPubClassCase.CDID);
}
else if (conPubClassCase.Introduction  ==  AttributeName[intIndex])
{
mstrIntroduction = value.ToString();
 AddUpdatedFld(conPubClassCase.Introduction);
}
else if (conPubClassCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCase.IsVisible);
}
else if (conPubClassCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCase.IsDualVideo);
}
else if (conPubClassCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conPubClassCase.RecommendedDegreeId);
}
else if (conPubClassCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conPubClassCase.ftpFileType);
}
else if (conPubClassCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conPubClassCase.VideoUrl);
}
else if (conPubClassCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conPubClassCase.VideoPath);
}
else if (conPubClassCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conPubClassCase.ResErrMsg);
}
else if (conPubClassCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPubClassCase.UpdDate);
}
else if (conPubClassCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPubClassCase.UpdUserId);
}
else if (conPubClassCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubClassCase.Memo);
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
 AddUpdatedFld(conPubClassCase.IdPubClassCase);
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
 AddUpdatedFld(conPubClassCase.PubClassCaseID);
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
 AddUpdatedFld(conPubClassCase.PubClassCaseName);
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
 AddUpdatedFld(conPubClassCase.PubClassCaseExecutor);
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
 AddUpdatedFld(conPubClassCase.WorkUnit);
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
 AddUpdatedFld(conPubClassCase.PubClassCaseTheme);
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
 AddUpdatedFld(conPubClassCase.PubClassCaseBG);
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
 AddUpdatedFld(conPubClassCase.PubClassCaseTeachDate);
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
 AddUpdatedFld(conPubClassCase.PubClassCaseDateIn);
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
 AddUpdatedFld(conPubClassCase.IdDiscipline);
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
 AddUpdatedFld(conPubClassCase.IdTeachingPlan);
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
 AddUpdatedFld(conPubClassCase.PubClassCaseTimeIn);
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
 AddUpdatedFld(conPubClassCase.IdPubClassCaseSenateGaugeVersion);
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
 AddUpdatedFld(conPubClassCase.BrowseCount);
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
 AddUpdatedFld(conPubClassCase.IdPubCaseType);
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
 AddUpdatedFld(conPubClassCase.IdStudyLevel);
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
 AddUpdatedFld(conPubClassCase.CDID);
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
 AddUpdatedFld(conPubClassCase.Introduction);
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
 AddUpdatedFld(conPubClassCase.IsVisible);
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
 AddUpdatedFld(conPubClassCase.IsDualVideo);
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
 AddUpdatedFld(conPubClassCase.RecommendedDegreeId);
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
 AddUpdatedFld(conPubClassCase.ftpFileType);
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
 AddUpdatedFld(conPubClassCase.VideoUrl);
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
 AddUpdatedFld(conPubClassCase.VideoPath);
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
 AddUpdatedFld(conPubClassCase.ResErrMsg);
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
 AddUpdatedFld(conPubClassCase.UpdDate);
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
 AddUpdatedFld(conPubClassCase.UpdUserId);
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
 AddUpdatedFld(conPubClassCase.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrPubClassCaseName;
 }
 }
}
 /// <summary>
 /// 公开课案例(PubClassCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubClassCase
{
public const string _CurrTabName = "PubClassCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "WorkUnit", "PubClassCaseTheme", "PubClassCaseBG", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdDiscipline", "IdTeachingPlan", "PubClassCaseTimeIn", "IdPubClassCaseSenateGaugeVersion", "BrowseCount", "IdPubCaseType", "IdStudyLevel", "CDID", "Introduction", "IsVisible", "IsDualVideo", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

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
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"IdPubCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubCaseType = "IdPubCaseType";    //公开课案例类型流水号

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //学段流水号

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