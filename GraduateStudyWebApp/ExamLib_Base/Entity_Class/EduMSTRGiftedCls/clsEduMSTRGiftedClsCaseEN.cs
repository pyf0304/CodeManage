
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEduMSTRGiftedClsCaseEN
 表名:EduMSTRGiftedClsCase(01120379)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
 /// 表EduMSTRGiftedClsCase的关键字(IdEduMSTRGiftedClsCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduMSTRGiftedClsCase_EduMSTRGiftedClsCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdEduMSTRGiftedClsCase">表关键字</param>
public K_IdEduMSTRGiftedClsCase_EduMSTRGiftedClsCase(string strIdEduMSTRGiftedClsCase)
{
if (IsValid(strIdEduMSTRGiftedClsCase)) Value = strIdEduMSTRGiftedClsCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdEduMSTRGiftedClsCase)
{
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase) == true) return false;
if (strIdEduMSTRGiftedClsCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEduMSTRGiftedClsCase_EduMSTRGiftedClsCase]类型的对象</returns>
public static implicit operator K_IdEduMSTRGiftedClsCase_EduMSTRGiftedClsCase(string value)
{
return new K_IdEduMSTRGiftedClsCase_EduMSTRGiftedClsCase(value);
}
}
 /// <summary>
 /// 教育硕士优课案例(EduMSTRGiftedClsCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsEduMSTRGiftedClsCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "EduMSTRGiftedClsCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduMSTRGiftedClsCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 35;
public static string[] AttributeName = new string[] {"IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseTheme", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTime", "EduMSTRGiftedClsCaseDateIn", "IdStudyLevel", "IdTeachingPlan", "EduMSTRGiftedClsCaseTimeIn", "IdEduMSTRGiftedClsCaseType", "IdCaseType", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "EduMSTRGiftedClsCaseText", "OwnerId", "IsDualVideo", "UserKindId", "UserTypeId", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "ResourceNum", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdEduMSTRGiftedClsCase;    //教育硕士优课案例流水号
protected string mstrEduMSTRGiftedClsCaseID;    //教育硕士优课案例ID
protected string mstrEduMSTRGiftedClsCaseName;    //教育硕士优课案例名称
protected string mstrEduMSTRGiftedClsCaseTheme;    //教育硕士优课案例主题词
protected string mstrEduMSTRGiftedClsCaseDate;    //教育硕士优课案例日期
protected string mstrEduMSTRGiftedClsCaseTime;    //教育硕士优课案例时间
protected string mstrEduMSTRGiftedClsCaseDateIn;    //案例入库日期
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrEduMSTRGiftedClsCaseTimeIn;    //案例入库时间
protected string mstrIdEduMSTRGiftedClsCaseType;    //教育硕士优课案例类型流水号
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
protected string mstrEduMSTRGiftedClsCaseText;    //教育硕士优课案例文本
protected string mstrOwnerId;    //拥有者Id
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserTypeId;    //用户类型Id
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected int? mintResourceNum;    //资源数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsEduMSTRGiftedClsCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduMSTRGiftedClsCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdEduMSTRGiftedClsCase">关键字:教育硕士优课案例流水号</param>
public clsEduMSTRGiftedClsCaseEN(string strIdEduMSTRGiftedClsCase)
 {
strIdEduMSTRGiftedClsCase = strIdEduMSTRGiftedClsCase.Replace("'", "''");
if (strIdEduMSTRGiftedClsCase.Length > 8)
{
throw new Exception("在表:EduMSTRGiftedClsCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase)  ==  true)
{
throw new Exception("在表:EduMSTRGiftedClsCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdEduMSTRGiftedClsCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdEduMSTRGiftedClsCase = strIdEduMSTRGiftedClsCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduMSTRGiftedClsCase");
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
if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase)
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID)
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName)
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme)
{
return mstrEduMSTRGiftedClsCaseTheme;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate)
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime)
{
return mstrEduMSTRGiftedClsCaseTime;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn)
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn)
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType)
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText)
{
return mstrEduMSTRGiftedClsCaseText;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.ResourceNum)
{
return mintResourceNum;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase)
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID)
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName)
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme)
{
mstrEduMSTRGiftedClsCaseTheme = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate)
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime)
{
mstrEduMSTRGiftedClsCaseTime = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn)
{
mstrEduMSTRGiftedClsCaseDateIn = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdStudyLevel);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn)
{
mstrEduMSTRGiftedClsCaseTimeIn = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType)
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdCaseType);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdDiscipline);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.BrowseCount);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdTeachSkill);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.CaseLevelId);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.DocFile);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.WordCreateDate);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsVisible);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText)
{
mstrEduMSTRGiftedClsCaseText = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.OwnerId);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsDualVideo);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.UserKindId);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.UserTypeId);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.ftpFileType);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.VideoUrl);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.VideoPath);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.ResErrMsg);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.ResourceNum)
{
mintResourceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.ResourceNum);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.UpdDate);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.UpdUserId);
}
else if (strAttributeName  ==  conEduMSTRGiftedClsCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTheme;
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTime;
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
else if (conEduMSTRGiftedClsCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conEduMSTRGiftedClsCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
else if (conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (conEduMSTRGiftedClsCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conEduMSTRGiftedClsCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conEduMSTRGiftedClsCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conEduMSTRGiftedClsCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conEduMSTRGiftedClsCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conEduMSTRGiftedClsCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conEduMSTRGiftedClsCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (conEduMSTRGiftedClsCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (conEduMSTRGiftedClsCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (conEduMSTRGiftedClsCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseText;
}
else if (conEduMSTRGiftedClsCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conEduMSTRGiftedClsCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conEduMSTRGiftedClsCase.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (conEduMSTRGiftedClsCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conEduMSTRGiftedClsCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conEduMSTRGiftedClsCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conEduMSTRGiftedClsCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conEduMSTRGiftedClsCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conEduMSTRGiftedClsCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conEduMSTRGiftedClsCase.ResourceNum  ==  AttributeName[intIndex])
{
return mintResourceNum;
}
else if (conEduMSTRGiftedClsCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conEduMSTRGiftedClsCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conEduMSTRGiftedClsCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTheme = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTime = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDateIn = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
}
else if (conEduMSTRGiftedClsCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdStudyLevel);
}
else if (conEduMSTRGiftedClsCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdTeachingPlan);
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTimeIn = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
}
else if (conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
}
else if (conEduMSTRGiftedClsCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdCaseType);
}
else if (conEduMSTRGiftedClsCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdDiscipline);
}
else if (conEduMSTRGiftedClsCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.BrowseCount);
}
else if (conEduMSTRGiftedClsCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
}
else if (conEduMSTRGiftedClsCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdTeachSkill);
}
else if (conEduMSTRGiftedClsCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.CaseLevelId);
}
else if (conEduMSTRGiftedClsCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.DocFile);
}
else if (conEduMSTRGiftedClsCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsNeedGeneWord);
}
else if (conEduMSTRGiftedClsCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.WordCreateDate);
}
else if (conEduMSTRGiftedClsCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsVisible);
}
else if (conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseText = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
}
else if (conEduMSTRGiftedClsCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.OwnerId);
}
else if (conEduMSTRGiftedClsCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsDualVideo);
}
else if (conEduMSTRGiftedClsCase.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.UserKindId);
}
else if (conEduMSTRGiftedClsCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.UserTypeId);
}
else if (conEduMSTRGiftedClsCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.RecommendedDegreeId);
}
else if (conEduMSTRGiftedClsCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.ftpFileType);
}
else if (conEduMSTRGiftedClsCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.VideoUrl);
}
else if (conEduMSTRGiftedClsCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.VideoPath);
}
else if (conEduMSTRGiftedClsCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.ResErrMsg);
}
else if (conEduMSTRGiftedClsCase.ResourceNum  ==  AttributeName[intIndex])
{
mintResourceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conEduMSTRGiftedClsCase.ResourceNum);
}
else if (conEduMSTRGiftedClsCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.UpdDate);
}
else if (conEduMSTRGiftedClsCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.UpdUserId);
}
else if (conEduMSTRGiftedClsCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conEduMSTRGiftedClsCase.Memo);
}
}
}

/// <summary>
/// 教育硕士优课案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduMSTRGiftedClsCase
{
get
{
return mstrIdEduMSTRGiftedClsCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduMSTRGiftedClsCase = value;
}
else
{
 mstrIdEduMSTRGiftedClsCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
}
}
/// <summary>
/// 教育硕士优课案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseID
{
get
{
return mstrEduMSTRGiftedClsCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseID = value;
}
else
{
 mstrEduMSTRGiftedClsCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
}
}
/// <summary>
/// 教育硕士优课案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseName
{
get
{
return mstrEduMSTRGiftedClsCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseName = value;
}
else
{
 mstrEduMSTRGiftedClsCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
}
}
/// <summary>
/// 教育硕士优课案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTheme
{
get
{
return mstrEduMSTRGiftedClsCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTheme = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
}
}
/// <summary>
/// 教育硕士优课案例日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseDate
{
get
{
return mstrEduMSTRGiftedClsCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseDate = value;
}
else
{
 mstrEduMSTRGiftedClsCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
}
}
/// <summary>
/// 教育硕士优课案例时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTime
{
get
{
return mstrEduMSTRGiftedClsCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTime = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseDateIn
{
get
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseDateIn = value;
}
else
{
 mstrEduMSTRGiftedClsCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdStudyLevel);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdTeachingPlan);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTimeIn
{
get
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTimeIn = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
}
}
/// <summary>
/// 教育硕士优课案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduMSTRGiftedClsCaseType
{
get
{
return mstrIdEduMSTRGiftedClsCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduMSTRGiftedClsCaseType = value;
}
else
{
 mstrIdEduMSTRGiftedClsCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdCaseType);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdDiscipline);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.BrowseCount);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IdTeachSkill);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.CaseLevelId);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.DocFile);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsNeedGeneWord);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.WordCreateDate);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsVisible);
}
}
/// <summary>
/// 教育硕士优课案例文本(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseText
{
get
{
return mstrEduMSTRGiftedClsCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseText = value;
}
else
{
 mstrEduMSTRGiftedClsCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.OwnerId);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.IsDualVideo);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.UserKindId);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.UserTypeId);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.RecommendedDegreeId);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.ftpFileType);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.VideoUrl);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.VideoPath);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.ResErrMsg);
}
}
/// <summary>
/// 资源数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ResourceNum
{
get
{
return mintResourceNum;
}
set
{
 mintResourceNum = value;
//记录修改过的字段
 AddUpdatedFld(conEduMSTRGiftedClsCase.ResourceNum);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.UpdDate);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.UpdUserId);
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
 AddUpdatedFld(conEduMSTRGiftedClsCase.Memo);
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
  return mstrIdEduMSTRGiftedClsCase;
 }
 }
}
 /// <summary>
 /// 教育硕士优课案例(EduMSTRGiftedClsCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conEduMSTRGiftedClsCase
{
public const string _CurrTabName = "EduMSTRGiftedClsCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduMSTRGiftedClsCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseTheme", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTime", "EduMSTRGiftedClsCaseDateIn", "IdStudyLevel", "IdTeachingPlan", "EduMSTRGiftedClsCaseTimeIn", "IdEduMSTRGiftedClsCaseType", "IdCaseType", "IdDiscipline", "BrowseCount", "IdSenateGaugeVersion", "IdTeachSkill", "CaseLevelId", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "EduMSTRGiftedClsCaseText", "OwnerId", "IsDualVideo", "UserKindId", "UserTypeId", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "ResourceNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEduMSTRGiftedClsCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduMSTRGiftedClsCase = "IdEduMSTRGiftedClsCase";    //教育硕士优课案例流水号

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseID = "EduMSTRGiftedClsCaseID";    //教育硕士优课案例ID

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseName = "EduMSTRGiftedClsCaseName";    //教育硕士优课案例名称

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTheme = "EduMSTRGiftedClsCaseTheme";    //教育硕士优课案例主题词

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseDate = "EduMSTRGiftedClsCaseDate";    //教育硕士优课案例日期

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTime = "EduMSTRGiftedClsCaseTime";    //教育硕士优课案例时间

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseDateIn = "EduMSTRGiftedClsCaseDateIn";    //案例入库日期

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
 /// 常量:"EduMSTRGiftedClsCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTimeIn = "EduMSTRGiftedClsCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdEduMSTRGiftedClsCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduMSTRGiftedClsCaseType = "IdEduMSTRGiftedClsCaseType";    //教育硕士优课案例类型流水号

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
 /// 常量:"EduMSTRGiftedClsCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseText = "EduMSTRGiftedClsCaseText";    //教育硕士优课案例文本

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
 /// 常量:"ResourceNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceNum = "ResourceNum";    //资源数

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