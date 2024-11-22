
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCaseEN
 表名:vWritingOnBBCase(01120468)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// 表vWritingOnBBCase的关键字(IdWritingOnBBCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWritingOnBBCase_vWritingOnBBCase
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
public K_IdWritingOnBBCase_vWritingOnBBCase(string strIdWritingOnBBCase)
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
 /// <returns>返回:[K_IdWritingOnBBCase_vWritingOnBBCase]类型的对象</returns>
public static implicit operator K_IdWritingOnBBCase_vWritingOnBBCase(string value)
{
return new K_IdWritingOnBBCase_vWritingOnBBCase(value);
}
}
 /// <summary>
 /// v板书教学案例(vWritingOnBBCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvWritingOnBBCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vWritingOnBBCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWritingOnBBCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 53;
public static string[] AttributeName = new string[] {"IdWritingOnBBCase", "WritingOnBBCaseID", "WritingOnBBCaseName", "WritingOnBBCaseTheme", "IdDiscipline", "DisciplineID", "DisciplineName", "WritingOnBBCaseDate", "WritingOnBBCaseTime", "WritingOnBBCaseDateIn", "WritingOnBBCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IsNeedGeneWord", "WordCreateDate", "DocFile", "CaseLevelId", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IsVisible", "OwnerId", "StuName", "StuID", "CollegeID", "CollegeName", "CollegeNameA", "IdXzCollege", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "IsDualVideo", "IdWritingOnBBCaseType", "WritingOnBBCaseTypeName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdUserId", "UpdDate", "Memo", "OwnerNameWithId", "OwnerName", "BrowseCount4Case", "IsHaveVideo"};

protected string mstrIdWritingOnBBCase;    //板书案例流水号
protected string mstrWritingOnBBCaseID;    //板书教学案例ID
protected string mstrWritingOnBBCaseName;    //板书教学案例名称
protected string mstrWritingOnBBCaseTheme;    //板书教学案例主题词
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrWritingOnBBCaseDate;    //板书教学日期
protected string mstrWritingOnBBCaseTime;    //板书教学时间
protected string mstrWritingOnBBCaseDateIn;    //案例入库日期
protected string mstrWritingOnBBCaseTimeIn;    //案例入库时间
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected string mstrDocFile;    //生成的Word文件名
protected string mstrCaseLevelId;    //课例等级Id
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected int? mintVersionNo;    //版本号
protected bool mbolIsVisible;    //是否显示
protected string mstrOwnerId;    //拥有者Id
protected string mstrStuName;    //姓名
protected string mstrStuID;    //学号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrIdAdminCls;    //行政班流水号
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdWritingOnBBCaseType;    //板书案例类型流水号
protected string mstrWritingOnBBCaseTypeName;    //板书案例类型名称
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrOwnerName;    //拥有者姓名
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrIsHaveVideo;    //IsHaveVideo

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvWritingOnBBCaseEN()
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
public clsvWritingOnBBCaseEN(string strIdWritingOnBBCase)
 {
strIdWritingOnBBCase = strIdWritingOnBBCase.Replace("'", "''");
if (strIdWritingOnBBCase.Length > 8)
{
throw new Exception("在表:vWritingOnBBCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdWritingOnBBCase)  ==  true)
{
throw new Exception("在表:vWritingOnBBCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convWritingOnBBCase.IdWritingOnBBCase)
{
return mstrIdWritingOnBBCase;
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseID)
{
return mstrWritingOnBBCaseID;
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseName)
{
return mstrWritingOnBBCaseName;
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseTheme)
{
return mstrWritingOnBBCaseTheme;
}
else if (strAttributeName  ==  convWritingOnBBCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convWritingOnBBCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convWritingOnBBCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseDate)
{
return mstrWritingOnBBCaseDate;
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseTime)
{
return mstrWritingOnBBCaseTime;
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseDateIn)
{
return mstrWritingOnBBCaseDateIn;
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseTimeIn)
{
return mstrWritingOnBBCaseTimeIn;
}
else if (strAttributeName  ==  convWritingOnBBCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convWritingOnBBCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convWritingOnBBCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convWritingOnBBCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convWritingOnBBCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convWritingOnBBCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convWritingOnBBCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convWritingOnBBCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convWritingOnBBCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convWritingOnBBCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convWritingOnBBCase.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convWritingOnBBCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convWritingOnBBCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convWritingOnBBCase.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convWritingOnBBCase.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convWritingOnBBCase.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convWritingOnBBCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convWritingOnBBCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convWritingOnBBCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convWritingOnBBCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convWritingOnBBCase.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convWritingOnBBCase.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convWritingOnBBCase.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convWritingOnBBCase.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convWritingOnBBCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convWritingOnBBCase.IdWritingOnBBCaseType)
{
return mstrIdWritingOnBBCaseType;
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseTypeName)
{
return mstrWritingOnBBCaseTypeName;
}
else if (strAttributeName  ==  convWritingOnBBCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convWritingOnBBCase.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convWritingOnBBCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convWritingOnBBCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convWritingOnBBCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convWritingOnBBCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convWritingOnBBCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convWritingOnBBCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convWritingOnBBCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convWritingOnBBCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convWritingOnBBCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convWritingOnBBCase.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convWritingOnBBCase.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convWritingOnBBCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convWritingOnBBCase.IsHaveVideo)
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (strAttributeName  ==  convWritingOnBBCase.IdWritingOnBBCase)
{
mstrIdWritingOnBBCase = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdWritingOnBBCase);
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseID)
{
mstrWritingOnBBCaseID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseID);
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseName)
{
mstrWritingOnBBCaseName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseName);
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseTheme)
{
mstrWritingOnBBCaseTheme = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTheme);
}
else if (strAttributeName  ==  convWritingOnBBCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdDiscipline);
}
else if (strAttributeName  ==  convWritingOnBBCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.DisciplineID);
}
else if (strAttributeName  ==  convWritingOnBBCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.DisciplineName);
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseDate)
{
mstrWritingOnBBCaseDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseDate);
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseTime)
{
mstrWritingOnBBCaseTime = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTime);
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseDateIn)
{
mstrWritingOnBBCaseDateIn = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseDateIn);
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseTimeIn)
{
mstrWritingOnBBCaseTimeIn = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTimeIn);
}
else if (strAttributeName  ==  convWritingOnBBCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdStudyLevel);
}
else if (strAttributeName  ==  convWritingOnBBCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.StudyLevelName);
}
else if (strAttributeName  ==  convWritingOnBBCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convWritingOnBBCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WordCreateDate);
}
else if (strAttributeName  ==  convWritingOnBBCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.DocFile);
}
else if (strAttributeName  ==  convWritingOnBBCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.CaseLevelId);
}
else if (strAttributeName  ==  convWritingOnBBCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convWritingOnBBCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convWritingOnBBCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convWritingOnBBCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convWritingOnBBCase.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.VersionNo);
}
else if (strAttributeName  ==  convWritingOnBBCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.IsVisible);
}
else if (strAttributeName  ==  convWritingOnBBCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.OwnerId);
}
else if (strAttributeName  ==  convWritingOnBBCase.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.StuName);
}
else if (strAttributeName  ==  convWritingOnBBCase.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.StuID);
}
else if (strAttributeName  ==  convWritingOnBBCase.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.CollegeID);
}
else if (strAttributeName  ==  convWritingOnBBCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.CollegeName);
}
else if (strAttributeName  ==  convWritingOnBBCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.CollegeNameA);
}
else if (strAttributeName  ==  convWritingOnBBCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdXzCollege);
}
else if (strAttributeName  ==  convWritingOnBBCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdXzMajor);
}
else if (strAttributeName  ==  convWritingOnBBCase.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.MajorName);
}
else if (strAttributeName  ==  convWritingOnBBCase.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdGradeBase);
}
else if (strAttributeName  ==  convWritingOnBBCase.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.GradeBaseName);
}
else if (strAttributeName  ==  convWritingOnBBCase.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdAdminCls);
}
else if (strAttributeName  ==  convWritingOnBBCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.IsDualVideo);
}
else if (strAttributeName  ==  convWritingOnBBCase.IdWritingOnBBCaseType)
{
mstrIdWritingOnBBCaseType = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdWritingOnBBCaseType);
}
else if (strAttributeName  ==  convWritingOnBBCase.WritingOnBBCaseTypeName)
{
mstrWritingOnBBCaseTypeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTypeName);
}
else if (strAttributeName  ==  convWritingOnBBCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.UserTypeId);
}
else if (strAttributeName  ==  convWritingOnBBCase.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.UserTypeName);
}
else if (strAttributeName  ==  convWritingOnBBCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convWritingOnBBCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convWritingOnBBCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.ftpFileType);
}
else if (strAttributeName  ==  convWritingOnBBCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.VideoUrl);
}
else if (strAttributeName  ==  convWritingOnBBCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.VideoPath);
}
else if (strAttributeName  ==  convWritingOnBBCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.ResErrMsg);
}
else if (strAttributeName  ==  convWritingOnBBCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.UpdUserId);
}
else if (strAttributeName  ==  convWritingOnBBCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.UpdDate);
}
else if (strAttributeName  ==  convWritingOnBBCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.Memo);
}
else if (strAttributeName  ==  convWritingOnBBCase.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.OwnerNameWithId);
}
else if (strAttributeName  ==  convWritingOnBBCase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.OwnerName);
}
else if (strAttributeName  ==  convWritingOnBBCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.BrowseCount4Case);
}
else if (strAttributeName  ==  convWritingOnBBCase.IsHaveVideo)
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IsHaveVideo);
}
}
}
public object this[int intIndex]
{
get
{
if (convWritingOnBBCase.IdWritingOnBBCase  ==  AttributeName[intIndex])
{
return mstrIdWritingOnBBCase;
}
else if (convWritingOnBBCase.WritingOnBBCaseID  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseID;
}
else if (convWritingOnBBCase.WritingOnBBCaseName  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseName;
}
else if (convWritingOnBBCase.WritingOnBBCaseTheme  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTheme;
}
else if (convWritingOnBBCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convWritingOnBBCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convWritingOnBBCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convWritingOnBBCase.WritingOnBBCaseDate  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseDate;
}
else if (convWritingOnBBCase.WritingOnBBCaseTime  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTime;
}
else if (convWritingOnBBCase.WritingOnBBCaseDateIn  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseDateIn;
}
else if (convWritingOnBBCase.WritingOnBBCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTimeIn;
}
else if (convWritingOnBBCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convWritingOnBBCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convWritingOnBBCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convWritingOnBBCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convWritingOnBBCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convWritingOnBBCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convWritingOnBBCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convWritingOnBBCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convWritingOnBBCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convWritingOnBBCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convWritingOnBBCase.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convWritingOnBBCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convWritingOnBBCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convWritingOnBBCase.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convWritingOnBBCase.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convWritingOnBBCase.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convWritingOnBBCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convWritingOnBBCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convWritingOnBBCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convWritingOnBBCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convWritingOnBBCase.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convWritingOnBBCase.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convWritingOnBBCase.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convWritingOnBBCase.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convWritingOnBBCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convWritingOnBBCase.IdWritingOnBBCaseType  ==  AttributeName[intIndex])
{
return mstrIdWritingOnBBCaseType;
}
else if (convWritingOnBBCase.WritingOnBBCaseTypeName  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTypeName;
}
else if (convWritingOnBBCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convWritingOnBBCase.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convWritingOnBBCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convWritingOnBBCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convWritingOnBBCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convWritingOnBBCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convWritingOnBBCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convWritingOnBBCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convWritingOnBBCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convWritingOnBBCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convWritingOnBBCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convWritingOnBBCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convWritingOnBBCase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convWritingOnBBCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convWritingOnBBCase.IsHaveVideo  ==  AttributeName[intIndex])
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (convWritingOnBBCase.IdWritingOnBBCase  ==  AttributeName[intIndex])
{
mstrIdWritingOnBBCase = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdWritingOnBBCase);
}
else if (convWritingOnBBCase.WritingOnBBCaseID  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseID);
}
else if (convWritingOnBBCase.WritingOnBBCaseName  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseName);
}
else if (convWritingOnBBCase.WritingOnBBCaseTheme  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTheme = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTheme);
}
else if (convWritingOnBBCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdDiscipline);
}
else if (convWritingOnBBCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.DisciplineID);
}
else if (convWritingOnBBCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.DisciplineName);
}
else if (convWritingOnBBCase.WritingOnBBCaseDate  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseDate);
}
else if (convWritingOnBBCase.WritingOnBBCaseTime  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTime = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTime);
}
else if (convWritingOnBBCase.WritingOnBBCaseDateIn  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseDateIn = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseDateIn);
}
else if (convWritingOnBBCase.WritingOnBBCaseTimeIn  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTimeIn = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTimeIn);
}
else if (convWritingOnBBCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdStudyLevel);
}
else if (convWritingOnBBCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.StudyLevelName);
}
else if (convWritingOnBBCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.IsNeedGeneWord);
}
else if (convWritingOnBBCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WordCreateDate);
}
else if (convWritingOnBBCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.DocFile);
}
else if (convWritingOnBBCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.CaseLevelId);
}
else if (convWritingOnBBCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdSenateGaugeVersion);
}
else if (convWritingOnBBCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionID);
}
else if (convWritingOnBBCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionName);
}
else if (convWritingOnBBCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionTtlScore);
}
else if (convWritingOnBBCase.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.VersionNo);
}
else if (convWritingOnBBCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.IsVisible);
}
else if (convWritingOnBBCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.OwnerId);
}
else if (convWritingOnBBCase.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.StuName);
}
else if (convWritingOnBBCase.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.StuID);
}
else if (convWritingOnBBCase.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.CollegeID);
}
else if (convWritingOnBBCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.CollegeName);
}
else if (convWritingOnBBCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.CollegeNameA);
}
else if (convWritingOnBBCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdXzCollege);
}
else if (convWritingOnBBCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdXzMajor);
}
else if (convWritingOnBBCase.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.MajorName);
}
else if (convWritingOnBBCase.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdGradeBase);
}
else if (convWritingOnBBCase.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.GradeBaseName);
}
else if (convWritingOnBBCase.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdAdminCls);
}
else if (convWritingOnBBCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.IsDualVideo);
}
else if (convWritingOnBBCase.IdWritingOnBBCaseType  ==  AttributeName[intIndex])
{
mstrIdWritingOnBBCaseType = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IdWritingOnBBCaseType);
}
else if (convWritingOnBBCase.WritingOnBBCaseTypeName  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTypeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTypeName);
}
else if (convWritingOnBBCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.UserTypeId);
}
else if (convWritingOnBBCase.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.UserTypeName);
}
else if (convWritingOnBBCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.RecommendedDegreeId);
}
else if (convWritingOnBBCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.RecommendedDegreeName);
}
else if (convWritingOnBBCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.ftpFileType);
}
else if (convWritingOnBBCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.VideoUrl);
}
else if (convWritingOnBBCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.VideoPath);
}
else if (convWritingOnBBCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.ResErrMsg);
}
else if (convWritingOnBBCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.UpdUserId);
}
else if (convWritingOnBBCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.UpdDate);
}
else if (convWritingOnBBCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.Memo);
}
else if (convWritingOnBBCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.OwnerNameWithId);
}
else if (convWritingOnBBCase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.OwnerName);
}
else if (convWritingOnBBCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convWritingOnBBCase.BrowseCount4Case);
}
else if (convWritingOnBBCase.IsHaveVideo  ==  AttributeName[intIndex])
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convWritingOnBBCase.IsHaveVideo);
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
 AddUpdatedFld(convWritingOnBBCase.IdWritingOnBBCase);
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
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseID);
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
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseName);
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
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTheme);
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
 AddUpdatedFld(convWritingOnBBCase.IdDiscipline);
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
 AddUpdatedFld(convWritingOnBBCase.DisciplineID);
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
 AddUpdatedFld(convWritingOnBBCase.DisciplineName);
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
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseDate);
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
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTime);
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
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseDateIn);
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
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTimeIn);
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
 AddUpdatedFld(convWritingOnBBCase.IdStudyLevel);
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
 AddUpdatedFld(convWritingOnBBCase.StudyLevelName);
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
 AddUpdatedFld(convWritingOnBBCase.IsNeedGeneWord);
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
 AddUpdatedFld(convWritingOnBBCase.WordCreateDate);
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
 AddUpdatedFld(convWritingOnBBCase.DocFile);
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
 AddUpdatedFld(convWritingOnBBCase.CaseLevelId);
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
 AddUpdatedFld(convWritingOnBBCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionID);
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
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionName);
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
 AddUpdatedFld(convWritingOnBBCase.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convWritingOnBBCase.VersionNo);
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
 AddUpdatedFld(convWritingOnBBCase.IsVisible);
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
 AddUpdatedFld(convWritingOnBBCase.OwnerId);
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
 AddUpdatedFld(convWritingOnBBCase.StuName);
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
 AddUpdatedFld(convWritingOnBBCase.StuID);
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
 AddUpdatedFld(convWritingOnBBCase.CollegeID);
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
 AddUpdatedFld(convWritingOnBBCase.CollegeName);
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
 AddUpdatedFld(convWritingOnBBCase.CollegeNameA);
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
 AddUpdatedFld(convWritingOnBBCase.IdXzCollege);
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
 AddUpdatedFld(convWritingOnBBCase.IdXzMajor);
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
 AddUpdatedFld(convWritingOnBBCase.MajorName);
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
 AddUpdatedFld(convWritingOnBBCase.IdGradeBase);
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
 AddUpdatedFld(convWritingOnBBCase.GradeBaseName);
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
 AddUpdatedFld(convWritingOnBBCase.IdAdminCls);
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
 AddUpdatedFld(convWritingOnBBCase.IsDualVideo);
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
 AddUpdatedFld(convWritingOnBBCase.IdWritingOnBBCaseType);
}
}
/// <summary>
/// 板书案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseTypeName
{
get
{
return mstrWritingOnBBCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseTypeName = value;
}
else
{
 mstrWritingOnBBCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCase.WritingOnBBCaseTypeName);
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
 AddUpdatedFld(convWritingOnBBCase.UserTypeId);
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
 AddUpdatedFld(convWritingOnBBCase.UserTypeName);
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
 AddUpdatedFld(convWritingOnBBCase.RecommendedDegreeId);
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
 AddUpdatedFld(convWritingOnBBCase.RecommendedDegreeName);
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
 AddUpdatedFld(convWritingOnBBCase.ftpFileType);
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
 AddUpdatedFld(convWritingOnBBCase.VideoUrl);
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
 AddUpdatedFld(convWritingOnBBCase.VideoPath);
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
 AddUpdatedFld(convWritingOnBBCase.ResErrMsg);
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
 AddUpdatedFld(convWritingOnBBCase.UpdUserId);
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
 AddUpdatedFld(convWritingOnBBCase.UpdDate);
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
 AddUpdatedFld(convWritingOnBBCase.Memo);
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
 AddUpdatedFld(convWritingOnBBCase.OwnerNameWithId);
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
 AddUpdatedFld(convWritingOnBBCase.OwnerName);
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
 AddUpdatedFld(convWritingOnBBCase.BrowseCount4Case);
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
 AddUpdatedFld(convWritingOnBBCase.IsHaveVideo);
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
}
 /// <summary>
 /// v板书教学案例(vWritingOnBBCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convWritingOnBBCase
{
public const string _CurrTabName = "vWritingOnBBCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWritingOnBBCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWritingOnBBCase", "WritingOnBBCaseID", "WritingOnBBCaseName", "WritingOnBBCaseTheme", "IdDiscipline", "DisciplineID", "DisciplineName", "WritingOnBBCaseDate", "WritingOnBBCaseTime", "WritingOnBBCaseDateIn", "WritingOnBBCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IsNeedGeneWord", "WordCreateDate", "DocFile", "CaseLevelId", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IsVisible", "OwnerId", "StuName", "StuID", "CollegeID", "CollegeName", "CollegeNameA", "IdXzCollege", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "IsDualVideo", "IdWritingOnBBCaseType", "WritingOnBBCaseTypeName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdUserId", "UpdDate", "Memo", "OwnerNameWithId", "OwnerName", "BrowseCount4Case", "IsHaveVideo"};
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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

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
 /// 常量:"IdWritingOnBBCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWritingOnBBCaseType = "IdWritingOnBBCaseType";    //板书案例类型流水号

 /// <summary>
 /// 常量:"WritingOnBBCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseTypeName = "WritingOnBBCaseTypeName";    //板书案例类型名称

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
}

}