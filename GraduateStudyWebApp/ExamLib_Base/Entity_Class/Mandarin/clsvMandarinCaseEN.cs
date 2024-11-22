
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCaseEN
 表名:vMandarinCase(01120465)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// 表vMandarinCase的关键字(IdMandarinCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMandarinCase_vMandarinCase
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
public K_IdMandarinCase_vMandarinCase(string strIdMandarinCase)
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
 /// <returns>返回:[K_IdMandarinCase_vMandarinCase]类型的对象</returns>
public static implicit operator K_IdMandarinCase_vMandarinCase(string value)
{
return new K_IdMandarinCase_vMandarinCase(value);
}
}
 /// <summary>
 /// v普通话教学案例(vMandarinCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMandarinCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMandarinCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMandarinCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 54;
public static string[] AttributeName = new string[] {"IdMandarinCase", "MandarinCaseID", "MandarinCaseName", "IdDiscipline", "DisciplineID", "DisciplineName", "IdStudyLevel", "StudyLevelName", "MandarinCaseTheme", "MandarinCaseDate", "MandarinCaseTime", "MandarinCaseDateIn", "MandarinCaseTimeIn", "IdTeachingPlan", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "CaseLevelId", "IsNeedGeneWord", "DocFile", "WordCreateDate", "IsVisible", "OwnerId", "StuName", "StuID", "CollegeID", "CollegeName", "IdXzCollege", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "IsDualVideo", "IdMandarinCaseType", "MandarinCaseTypeName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo", "BrowseCount4Case", "IsHaveVideo", "OwnerNameWithId", "OwnerName"};

protected string mstrIdMandarinCase;    //普通话案例流水号
protected string mstrMandarinCaseID;    //普通话教学案例ID
protected string mstrMandarinCaseName;    //普通话教学案例名称
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrMandarinCaseTheme;    //普通话教学案例主题词
protected string mstrMandarinCaseDate;    //普通话教学日期
protected string mstrMandarinCaseTime;    //普通话教学时间
protected string mstrMandarinCaseDateIn;    //案例入库日期
protected string mstrMandarinCaseTimeIn;    //案例入库时间
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected int? mintVersionNo;    //版本号
protected string mstrCaseLevelId;    //课例等级Id
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrDocFile;    //生成的Word文件名
protected string mstrWordCreateDate;    //Word生成日期
protected bool mbolIsVisible;    //是否显示
protected string mstrOwnerId;    //拥有者Id
protected string mstrStuName;    //姓名
protected string mstrStuID;    //学号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrIdAdminCls;    //行政班流水号
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdMandarinCaseType;    //普通话案例类型流水号
protected string mstrMandarinCaseTypeName;    //普通话案例类型名称
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrIsHaveVideo;    //IsHaveVideo
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrOwnerName;    //拥有者姓名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMandarinCaseEN()
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
public clsvMandarinCaseEN(string strIdMandarinCase)
 {
strIdMandarinCase = strIdMandarinCase.Replace("'", "''");
if (strIdMandarinCase.Length > 8)
{
throw new Exception("在表:vMandarinCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMandarinCase)  ==  true)
{
throw new Exception("在表:vMandarinCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convMandarinCase.IdMandarinCase)
{
return mstrIdMandarinCase;
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseID)
{
return mstrMandarinCaseID;
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseName)
{
return mstrMandarinCaseName;
}
else if (strAttributeName  ==  convMandarinCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convMandarinCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convMandarinCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convMandarinCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convMandarinCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseTheme)
{
return mstrMandarinCaseTheme;
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseDate)
{
return mstrMandarinCaseDate;
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseTime)
{
return mstrMandarinCaseTime;
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseDateIn)
{
return mstrMandarinCaseDateIn;
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseTimeIn)
{
return mstrMandarinCaseTimeIn;
}
else if (strAttributeName  ==  convMandarinCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convMandarinCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convMandarinCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convMandarinCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convMandarinCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convMandarinCase.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convMandarinCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convMandarinCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convMandarinCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convMandarinCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convMandarinCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convMandarinCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convMandarinCase.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convMandarinCase.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convMandarinCase.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convMandarinCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convMandarinCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convMandarinCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convMandarinCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convMandarinCase.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convMandarinCase.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convMandarinCase.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convMandarinCase.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convMandarinCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convMandarinCase.IdMandarinCaseType)
{
return mstrIdMandarinCaseType;
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseTypeName)
{
return mstrMandarinCaseTypeName;
}
else if (strAttributeName  ==  convMandarinCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convMandarinCase.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convMandarinCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convMandarinCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convMandarinCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convMandarinCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convMandarinCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convMandarinCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convMandarinCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convMandarinCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convMandarinCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convMandarinCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convMandarinCase.IsHaveVideo)
{
return mstrIsHaveVideo;
}
else if (strAttributeName  ==  convMandarinCase.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convMandarinCase.OwnerName)
{
return mstrOwnerName;
}
return null;
}
set
{
if (strAttributeName  ==  convMandarinCase.IdMandarinCase)
{
mstrIdMandarinCase = value.ToString();
 AddUpdatedFld(convMandarinCase.IdMandarinCase);
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseID)
{
mstrMandarinCaseID = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseID);
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseName)
{
mstrMandarinCaseName = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseName);
}
else if (strAttributeName  ==  convMandarinCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMandarinCase.IdDiscipline);
}
else if (strAttributeName  ==  convMandarinCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMandarinCase.DisciplineID);
}
else if (strAttributeName  ==  convMandarinCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMandarinCase.DisciplineName);
}
else if (strAttributeName  ==  convMandarinCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMandarinCase.IdStudyLevel);
}
else if (strAttributeName  ==  convMandarinCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMandarinCase.StudyLevelName);
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseTheme)
{
mstrMandarinCaseTheme = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseTheme);
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseDate)
{
mstrMandarinCaseDate = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseDate);
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseTime)
{
mstrMandarinCaseTime = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseTime);
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseDateIn)
{
mstrMandarinCaseDateIn = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseDateIn);
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseTimeIn)
{
mstrMandarinCaseTimeIn = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseTimeIn);
}
else if (strAttributeName  ==  convMandarinCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMandarinCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convMandarinCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convMandarinCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convMandarinCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMandarinCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convMandarinCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMandarinCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convMandarinCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMandarinCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convMandarinCase.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMandarinCase.VersionNo);
}
else if (strAttributeName  ==  convMandarinCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMandarinCase.CaseLevelId);
}
else if (strAttributeName  ==  convMandarinCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convMandarinCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convMandarinCase.DocFile);
}
else if (strAttributeName  ==  convMandarinCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convMandarinCase.WordCreateDate);
}
else if (strAttributeName  ==  convMandarinCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCase.IsVisible);
}
else if (strAttributeName  ==  convMandarinCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMandarinCase.OwnerId);
}
else if (strAttributeName  ==  convMandarinCase.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convMandarinCase.StuName);
}
else if (strAttributeName  ==  convMandarinCase.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convMandarinCase.StuID);
}
else if (strAttributeName  ==  convMandarinCase.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMandarinCase.CollegeID);
}
else if (strAttributeName  ==  convMandarinCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMandarinCase.CollegeName);
}
else if (strAttributeName  ==  convMandarinCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMandarinCase.IdXzCollege);
}
else if (strAttributeName  ==  convMandarinCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMandarinCase.CollegeNameA);
}
else if (strAttributeName  ==  convMandarinCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMandarinCase.IdXzMajor);
}
else if (strAttributeName  ==  convMandarinCase.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMandarinCase.MajorName);
}
else if (strAttributeName  ==  convMandarinCase.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convMandarinCase.IdGradeBase);
}
else if (strAttributeName  ==  convMandarinCase.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convMandarinCase.GradeBaseName);
}
else if (strAttributeName  ==  convMandarinCase.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convMandarinCase.IdAdminCls);
}
else if (strAttributeName  ==  convMandarinCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCase.IsDualVideo);
}
else if (strAttributeName  ==  convMandarinCase.IdMandarinCaseType)
{
mstrIdMandarinCaseType = value.ToString();
 AddUpdatedFld(convMandarinCase.IdMandarinCaseType);
}
else if (strAttributeName  ==  convMandarinCase.MandarinCaseTypeName)
{
mstrMandarinCaseTypeName = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseTypeName);
}
else if (strAttributeName  ==  convMandarinCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMandarinCase.UserTypeId);
}
else if (strAttributeName  ==  convMandarinCase.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convMandarinCase.UserTypeName);
}
else if (strAttributeName  ==  convMandarinCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMandarinCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convMandarinCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMandarinCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convMandarinCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMandarinCase.ftpFileType);
}
else if (strAttributeName  ==  convMandarinCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convMandarinCase.VideoUrl);
}
else if (strAttributeName  ==  convMandarinCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convMandarinCase.VideoPath);
}
else if (strAttributeName  ==  convMandarinCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convMandarinCase.ResErrMsg);
}
else if (strAttributeName  ==  convMandarinCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMandarinCase.UpdDate);
}
else if (strAttributeName  ==  convMandarinCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convMandarinCase.UpdUserId);
}
else if (strAttributeName  ==  convMandarinCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMandarinCase.Memo);
}
else if (strAttributeName  ==  convMandarinCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMandarinCase.BrowseCount4Case);
}
else if (strAttributeName  ==  convMandarinCase.IsHaveVideo)
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convMandarinCase.IsHaveVideo);
}
else if (strAttributeName  ==  convMandarinCase.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convMandarinCase.OwnerNameWithId);
}
else if (strAttributeName  ==  convMandarinCase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMandarinCase.OwnerName);
}
}
}
public object this[int intIndex]
{
get
{
if (convMandarinCase.IdMandarinCase  ==  AttributeName[intIndex])
{
return mstrIdMandarinCase;
}
else if (convMandarinCase.MandarinCaseID  ==  AttributeName[intIndex])
{
return mstrMandarinCaseID;
}
else if (convMandarinCase.MandarinCaseName  ==  AttributeName[intIndex])
{
return mstrMandarinCaseName;
}
else if (convMandarinCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convMandarinCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convMandarinCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convMandarinCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convMandarinCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convMandarinCase.MandarinCaseTheme  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTheme;
}
else if (convMandarinCase.MandarinCaseDate  ==  AttributeName[intIndex])
{
return mstrMandarinCaseDate;
}
else if (convMandarinCase.MandarinCaseTime  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTime;
}
else if (convMandarinCase.MandarinCaseDateIn  ==  AttributeName[intIndex])
{
return mstrMandarinCaseDateIn;
}
else if (convMandarinCase.MandarinCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTimeIn;
}
else if (convMandarinCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convMandarinCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convMandarinCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convMandarinCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convMandarinCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convMandarinCase.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convMandarinCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convMandarinCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convMandarinCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convMandarinCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convMandarinCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convMandarinCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convMandarinCase.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convMandarinCase.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convMandarinCase.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convMandarinCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convMandarinCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convMandarinCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convMandarinCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convMandarinCase.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convMandarinCase.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convMandarinCase.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convMandarinCase.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convMandarinCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convMandarinCase.IdMandarinCaseType  ==  AttributeName[intIndex])
{
return mstrIdMandarinCaseType;
}
else if (convMandarinCase.MandarinCaseTypeName  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTypeName;
}
else if (convMandarinCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convMandarinCase.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convMandarinCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convMandarinCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convMandarinCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convMandarinCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convMandarinCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convMandarinCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convMandarinCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convMandarinCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convMandarinCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convMandarinCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convMandarinCase.IsHaveVideo  ==  AttributeName[intIndex])
{
return mstrIsHaveVideo;
}
else if (convMandarinCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convMandarinCase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
return null;
}
set
{
if (convMandarinCase.IdMandarinCase  ==  AttributeName[intIndex])
{
mstrIdMandarinCase = value.ToString();
 AddUpdatedFld(convMandarinCase.IdMandarinCase);
}
else if (convMandarinCase.MandarinCaseID  ==  AttributeName[intIndex])
{
mstrMandarinCaseID = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseID);
}
else if (convMandarinCase.MandarinCaseName  ==  AttributeName[intIndex])
{
mstrMandarinCaseName = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseName);
}
else if (convMandarinCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMandarinCase.IdDiscipline);
}
else if (convMandarinCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMandarinCase.DisciplineID);
}
else if (convMandarinCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMandarinCase.DisciplineName);
}
else if (convMandarinCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMandarinCase.IdStudyLevel);
}
else if (convMandarinCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMandarinCase.StudyLevelName);
}
else if (convMandarinCase.MandarinCaseTheme  ==  AttributeName[intIndex])
{
mstrMandarinCaseTheme = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseTheme);
}
else if (convMandarinCase.MandarinCaseDate  ==  AttributeName[intIndex])
{
mstrMandarinCaseDate = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseDate);
}
else if (convMandarinCase.MandarinCaseTime  ==  AttributeName[intIndex])
{
mstrMandarinCaseTime = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseTime);
}
else if (convMandarinCase.MandarinCaseDateIn  ==  AttributeName[intIndex])
{
mstrMandarinCaseDateIn = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseDateIn);
}
else if (convMandarinCase.MandarinCaseTimeIn  ==  AttributeName[intIndex])
{
mstrMandarinCaseTimeIn = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseTimeIn);
}
else if (convMandarinCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMandarinCase.IdTeachingPlan);
}
else if (convMandarinCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convMandarinCase.IdSenateGaugeVersion);
}
else if (convMandarinCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMandarinCase.senateGaugeVersionID);
}
else if (convMandarinCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMandarinCase.senateGaugeVersionName);
}
else if (convMandarinCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMandarinCase.senateGaugeVersionTtlScore);
}
else if (convMandarinCase.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMandarinCase.VersionNo);
}
else if (convMandarinCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMandarinCase.CaseLevelId);
}
else if (convMandarinCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCase.IsNeedGeneWord);
}
else if (convMandarinCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convMandarinCase.DocFile);
}
else if (convMandarinCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convMandarinCase.WordCreateDate);
}
else if (convMandarinCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCase.IsVisible);
}
else if (convMandarinCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMandarinCase.OwnerId);
}
else if (convMandarinCase.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convMandarinCase.StuName);
}
else if (convMandarinCase.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convMandarinCase.StuID);
}
else if (convMandarinCase.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMandarinCase.CollegeID);
}
else if (convMandarinCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMandarinCase.CollegeName);
}
else if (convMandarinCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMandarinCase.IdXzCollege);
}
else if (convMandarinCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMandarinCase.CollegeNameA);
}
else if (convMandarinCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMandarinCase.IdXzMajor);
}
else if (convMandarinCase.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMandarinCase.MajorName);
}
else if (convMandarinCase.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convMandarinCase.IdGradeBase);
}
else if (convMandarinCase.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convMandarinCase.GradeBaseName);
}
else if (convMandarinCase.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convMandarinCase.IdAdminCls);
}
else if (convMandarinCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCase.IsDualVideo);
}
else if (convMandarinCase.IdMandarinCaseType  ==  AttributeName[intIndex])
{
mstrIdMandarinCaseType = value.ToString();
 AddUpdatedFld(convMandarinCase.IdMandarinCaseType);
}
else if (convMandarinCase.MandarinCaseTypeName  ==  AttributeName[intIndex])
{
mstrMandarinCaseTypeName = value.ToString();
 AddUpdatedFld(convMandarinCase.MandarinCaseTypeName);
}
else if (convMandarinCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMandarinCase.UserTypeId);
}
else if (convMandarinCase.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convMandarinCase.UserTypeName);
}
else if (convMandarinCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMandarinCase.RecommendedDegreeId);
}
else if (convMandarinCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMandarinCase.RecommendedDegreeName);
}
else if (convMandarinCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMandarinCase.ftpFileType);
}
else if (convMandarinCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convMandarinCase.VideoUrl);
}
else if (convMandarinCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convMandarinCase.VideoPath);
}
else if (convMandarinCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convMandarinCase.ResErrMsg);
}
else if (convMandarinCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMandarinCase.UpdDate);
}
else if (convMandarinCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convMandarinCase.UpdUserId);
}
else if (convMandarinCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMandarinCase.Memo);
}
else if (convMandarinCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMandarinCase.BrowseCount4Case);
}
else if (convMandarinCase.IsHaveVideo  ==  AttributeName[intIndex])
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convMandarinCase.IsHaveVideo);
}
else if (convMandarinCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convMandarinCase.OwnerNameWithId);
}
else if (convMandarinCase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMandarinCase.OwnerName);
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
 AddUpdatedFld(convMandarinCase.IdMandarinCase);
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
 AddUpdatedFld(convMandarinCase.MandarinCaseID);
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
 AddUpdatedFld(convMandarinCase.MandarinCaseName);
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
 AddUpdatedFld(convMandarinCase.IdDiscipline);
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
 AddUpdatedFld(convMandarinCase.DisciplineID);
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
 AddUpdatedFld(convMandarinCase.DisciplineName);
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
 AddUpdatedFld(convMandarinCase.IdStudyLevel);
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
 AddUpdatedFld(convMandarinCase.StudyLevelName);
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
 AddUpdatedFld(convMandarinCase.MandarinCaseTheme);
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
 AddUpdatedFld(convMandarinCase.MandarinCaseDate);
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
 AddUpdatedFld(convMandarinCase.MandarinCaseTime);
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
 AddUpdatedFld(convMandarinCase.MandarinCaseDateIn);
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
 AddUpdatedFld(convMandarinCase.MandarinCaseTimeIn);
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
 AddUpdatedFld(convMandarinCase.IdTeachingPlan);
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
 AddUpdatedFld(convMandarinCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(convMandarinCase.senateGaugeVersionID);
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
 AddUpdatedFld(convMandarinCase.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 版本号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionNo
{
get
{
return mintVersionNo;
}
set
{
 mintVersionNo = value;
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.VersionNo);
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
 AddUpdatedFld(convMandarinCase.CaseLevelId);
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
 AddUpdatedFld(convMandarinCase.IsNeedGeneWord);
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
 AddUpdatedFld(convMandarinCase.DocFile);
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
 AddUpdatedFld(convMandarinCase.WordCreateDate);
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
 AddUpdatedFld(convMandarinCase.IsVisible);
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
 AddUpdatedFld(convMandarinCase.OwnerId);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.StuName);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuID
{
get
{
return mstrStuID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuID = value;
}
else
{
 mstrStuID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.StuID);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeID
{
get
{
return mstrCollegeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeID = value;
}
else
{
 mstrCollegeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.CollegeID);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.CollegeName);
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
 AddUpdatedFld(convMandarinCase.IdXzCollege);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.CollegeNameA);
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
 AddUpdatedFld(convMandarinCase.IdXzMajor);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.MajorName);
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
 AddUpdatedFld(convMandarinCase.IdGradeBase);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.GradeBaseName);
}
}
/// <summary>
/// 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminCls
{
get
{
return mstrIdAdminCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminCls = value;
}
else
{
 mstrIdAdminCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.IdAdminCls);
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
 AddUpdatedFld(convMandarinCase.IsDualVideo);
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
 AddUpdatedFld(convMandarinCase.IdMandarinCaseType);
}
}
/// <summary>
/// 普通话案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseTypeName
{
get
{
return mstrMandarinCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseTypeName = value;
}
else
{
 mstrMandarinCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.MandarinCaseTypeName);
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
 AddUpdatedFld(convMandarinCase.UserTypeId);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.UserTypeName);
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
 AddUpdatedFld(convMandarinCase.RecommendedDegreeId);
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
 AddUpdatedFld(convMandarinCase.RecommendedDegreeName);
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
 AddUpdatedFld(convMandarinCase.ftpFileType);
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
 AddUpdatedFld(convMandarinCase.VideoUrl);
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
 AddUpdatedFld(convMandarinCase.VideoPath);
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
 AddUpdatedFld(convMandarinCase.ResErrMsg);
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
 AddUpdatedFld(convMandarinCase.UpdDate);
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
 AddUpdatedFld(convMandarinCase.UpdUserId);
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
 AddUpdatedFld(convMandarinCase.Memo);
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
 AddUpdatedFld(convMandarinCase.BrowseCount4Case);
}
}
/// <summary>
/// IsHaveVideo(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IsHaveVideo
{
get
{
return mstrIsHaveVideo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIsHaveVideo = value;
}
else
{
 mstrIsHaveVideo = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.IsHaveVideo);
}
}
/// <summary>
/// 拥有者名称附Id(说明:;字段类型:varchar;字段长度:51;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerNameWithId
{
get
{
return mstrOwnerNameWithId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerNameWithId = value;
}
else
{
 mstrOwnerNameWithId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.OwnerNameWithId);
}
}
/// <summary>
/// 拥有者姓名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerName
{
get
{
return mstrOwnerName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerName = value;
}
else
{
 mstrOwnerName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCase.OwnerName);
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
}
 /// <summary>
 /// v普通话教学案例(vMandarinCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMandarinCase
{
public const string _CurrTabName = "vMandarinCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMandarinCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMandarinCase", "MandarinCaseID", "MandarinCaseName", "IdDiscipline", "DisciplineID", "DisciplineName", "IdStudyLevel", "StudyLevelName", "MandarinCaseTheme", "MandarinCaseDate", "MandarinCaseTime", "MandarinCaseDateIn", "MandarinCaseTimeIn", "IdTeachingPlan", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "CaseLevelId", "IsNeedGeneWord", "DocFile", "WordCreateDate", "IsVisible", "OwnerId", "StuName", "StuID", "CollegeID", "CollegeName", "IdXzCollege", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "IsDualVideo", "IdMandarinCaseType", "MandarinCaseTypeName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo", "BrowseCount4Case", "IsHaveVideo", "OwnerNameWithId", "OwnerName"};
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
 /// 常量:"VersionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNo = "VersionNo";    //版本号

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
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"StuID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuID = "StuID";    //学号

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"IdAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminCls = "IdAdminCls";    //行政班流水号

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
 /// 常量:"MandarinCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseTypeName = "MandarinCaseTypeName";    //普通话案例类型名称

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

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

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"IsHaveVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveVideo = "IsHaveVideo";    //IsHaveVideo

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名
}

}