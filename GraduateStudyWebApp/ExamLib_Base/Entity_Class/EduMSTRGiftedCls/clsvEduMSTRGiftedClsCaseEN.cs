
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseEN
 表名:vEduMSTRGiftedClsCase(01120380)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vEduMSTRGiftedClsCase的关键字(IdEduMSTRGiftedClsCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase
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
public K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase(string strIdEduMSTRGiftedClsCase)
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
 /// <returns>返回:[K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase]类型的对象</returns>
public static implicit operator K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase(string value)
{
return new K_IdEduMSTRGiftedClsCase_vEduMSTRGiftedClsCase(value);
}
}
 /// <summary>
 /// v教育硕士优课案例(vEduMSTRGiftedClsCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvEduMSTRGiftedClsCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vEduMSTRGiftedClsCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduMSTRGiftedClsCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 84;
public static string[] AttributeName = new string[] {"IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseTheme", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTime", "EduMSTRGiftedClsCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "EduMSTRGiftedClsCaseTimeIn", "IdEduMSTRGiftedClsCaseType", "EduMSTRGiftedClsCaseTypeID", "EduMSTRGiftedClsCaseTypeName", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "EduMSTRGiftedClsCaseText", "OwnerId", "IdStudentInfo", "StuName", "StuId", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IdCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "IsDualVideo", "UserKindId", "UserKindName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "ResourceNum", "Memo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId", "IsHaveVideo"};

protected string mstrIdEduMSTRGiftedClsCase;    //教育硕士优课案例流水号
protected string mstrEduMSTRGiftedClsCaseID;    //教育硕士优课案例ID
protected string mstrEduMSTRGiftedClsCaseName;    //教育硕士优课案例名称
protected string mstrEduMSTRGiftedClsCaseTheme;    //教育硕士优课案例主题词
protected string mstrEduMSTRGiftedClsCaseDate;    //教育硕士优课案例日期
protected string mstrEduMSTRGiftedClsCaseTime;    //教育硕士优课案例时间
protected string mstrEduMSTRGiftedClsCaseDateIn;    //案例入库日期
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrEduMSTRGiftedClsCaseTimeIn;    //案例入库时间
protected string mstrIdEduMSTRGiftedClsCaseType;    //教育硕士优课案例类型流水号
protected string mstrEduMSTRGiftedClsCaseTypeID;    //教育硕士优课案例类型Id
protected string mstrEduMSTRGiftedClsCaseTypeName;    //教育硕士优课案例类型名称
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected int? mintVersionNo;    //版本号
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrTeachSkillID;    //教学技能ID
protected string mstrSkillTypeName;    //技能类型名称
protected string mstrTeachSkillName;    //教学技能名称
protected string mstrTeachSkillTheory;    //教学技能理论阐述
protected string mstrTeachSkillOperMethod;    //教学技能实践操作方法
protected string mstrIdSkillType;    //技能类型流水号
protected string mstrSkillTypeID;    //技能类型ID
protected string mstrCaseLevelId;    //课例等级Id
protected string mstrCaseLevelName;    //案例等级名称
protected string mstrDocFile;    //生成的Word文件名
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrWordCreateDate;    //Word生成日期
protected bool mbolIsVisible;    //是否显示
protected string mstrEduMSTRGiftedClsCaseText;    //教育硕士优课案例文本
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrStuName;    //姓名
protected string mstrStuId;    //学号
protected string mstrPoliticsName;    //政治面貌
protected string mstrSexDesc;    //性别名称
protected string mstrEthnicName;    //民族名称
protected string mstrUniZoneDesc;    //校区名称
protected string mstrStuTypeDesc;    //学生类别名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrIdAdminCls;    //行政班流水号
protected string mstrAdminClsId;    //行政班代号
protected string mstrAdminClsName;    //行政班名称
protected string mstrBirthday;    //出生日期
protected string mstrNativePlace;    //籍贯
protected string mstrDuty;    //职位
protected string mstrIdCardNo;    //身份证号
protected string mstrStuCardNo;    //学生证号
protected string mstrLiveAddress;    //居住地址
protected string mstrHomePhone;    //住宅电话
protected string mstrEnrollmentDate;    //入校日期
protected string mstrPostCode;    //邮编
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected int? mintResourceNum;    //资源数
protected string mstrMemo;    //备注
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrIsHaveVideo;    //IsHaveVideo

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvEduMSTRGiftedClsCaseEN()
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
public clsvEduMSTRGiftedClsCaseEN(string strIdEduMSTRGiftedClsCase)
 {
strIdEduMSTRGiftedClsCase = strIdEduMSTRGiftedClsCase.Replace("'", "''");
if (strIdEduMSTRGiftedClsCase.Length > 8)
{
throw new Exception("在表:vEduMSTRGiftedClsCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase)  ==  true)
{
throw new Exception("在表:vEduMSTRGiftedClsCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase)
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID)
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName)
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme)
{
return mstrEduMSTRGiftedClsCaseTheme;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate)
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime)
{
return mstrEduMSTRGiftedClsCaseTime;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn)
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn)
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType)
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID)
{
return mstrEduMSTRGiftedClsCaseTypeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName)
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText)
{
return mstrEduMSTRGiftedClsCaseText;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdCardNo)
{
return mstrIdCardNo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.ResourceNum)
{
return mintResourceNum;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IsHaveVideo)
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase)
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID)
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName)
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme)
{
mstrEduMSTRGiftedClsCaseTheme = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate)
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime)
{
mstrEduMSTRGiftedClsCaseTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn)
{
mstrEduMSTRGiftedClsCaseDateIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdStudyLevel);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StudyLevelName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn)
{
mstrEduMSTRGiftedClsCaseTimeIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType)
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID)
{
mstrEduMSTRGiftedClsCaseTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName)
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdCaseType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdDiscipline);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.DisciplineID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.DisciplineName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.VersionNo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdTeachSkill);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.SkillTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillTheory);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdSkillType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.SkillTypeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CaseLevelId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CaseLevelName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.DocFile);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.WordCreateDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsVisible);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText)
{
mstrEduMSTRGiftedClsCaseText = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdStudentInfo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.PoliticsName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.SexDesc);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EthnicName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UniZoneDesc);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuTypeDesc);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdXzCollege);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeNameA);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdXzMajor);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.MajorName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdGradeBase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.GradeBaseName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdAdminCls);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.AdminClsId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.AdminClsName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.Birthday);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.NativePlace);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.Duty);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IdCardNo)
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdCardNo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuCardNo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.LiveAddress);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.HomePhone);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EnrollmentDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.PostCode);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsDualVideo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserKindId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserKindName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserTypeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.ftpFileType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.VideoUrl);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.VideoPath);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.ResErrMsg);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.ResourceNum)
{
mintResourceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.ResourceNum);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.Memo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.BrowseCount4Case);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerNameWithId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase.IsHaveVideo)
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsHaveVideo);
}
}
}
public object this[int intIndex]
{
get
{
if (convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTheme;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTime;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
else if (convEduMSTRGiftedClsCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convEduMSTRGiftedClsCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convEduMSTRGiftedClsCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
else if (convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTypeID;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (convEduMSTRGiftedClsCase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convEduMSTRGiftedClsCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convEduMSTRGiftedClsCase.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convEduMSTRGiftedClsCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convEduMSTRGiftedClsCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convEduMSTRGiftedClsCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convEduMSTRGiftedClsCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convEduMSTRGiftedClsCase.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convEduMSTRGiftedClsCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convEduMSTRGiftedClsCase.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convEduMSTRGiftedClsCase.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convEduMSTRGiftedClsCase.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convEduMSTRGiftedClsCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convEduMSTRGiftedClsCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convEduMSTRGiftedClsCase.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convEduMSTRGiftedClsCase.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convEduMSTRGiftedClsCase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convEduMSTRGiftedClsCase.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convEduMSTRGiftedClsCase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convEduMSTRGiftedClsCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convEduMSTRGiftedClsCase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convEduMSTRGiftedClsCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseText;
}
else if (convEduMSTRGiftedClsCase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convEduMSTRGiftedClsCase.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convEduMSTRGiftedClsCase.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convEduMSTRGiftedClsCase.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (convEduMSTRGiftedClsCase.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (convEduMSTRGiftedClsCase.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convEduMSTRGiftedClsCase.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (convEduMSTRGiftedClsCase.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convEduMSTRGiftedClsCase.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convEduMSTRGiftedClsCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convEduMSTRGiftedClsCase.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convEduMSTRGiftedClsCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convEduMSTRGiftedClsCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convEduMSTRGiftedClsCase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convEduMSTRGiftedClsCase.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convEduMSTRGiftedClsCase.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convEduMSTRGiftedClsCase.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convEduMSTRGiftedClsCase.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convEduMSTRGiftedClsCase.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (convEduMSTRGiftedClsCase.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (convEduMSTRGiftedClsCase.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convEduMSTRGiftedClsCase.NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (convEduMSTRGiftedClsCase.Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (convEduMSTRGiftedClsCase.IdCardNo  ==  AttributeName[intIndex])
{
return mstrIdCardNo;
}
else if (convEduMSTRGiftedClsCase.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convEduMSTRGiftedClsCase.LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (convEduMSTRGiftedClsCase.HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (convEduMSTRGiftedClsCase.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convEduMSTRGiftedClsCase.PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (convEduMSTRGiftedClsCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convEduMSTRGiftedClsCase.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convEduMSTRGiftedClsCase.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convEduMSTRGiftedClsCase.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convEduMSTRGiftedClsCase.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convEduMSTRGiftedClsCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convEduMSTRGiftedClsCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convEduMSTRGiftedClsCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convEduMSTRGiftedClsCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convEduMSTRGiftedClsCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convEduMSTRGiftedClsCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convEduMSTRGiftedClsCase.ResourceNum  ==  AttributeName[intIndex])
{
return mintResourceNum;
}
else if (convEduMSTRGiftedClsCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convEduMSTRGiftedClsCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convEduMSTRGiftedClsCase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convEduMSTRGiftedClsCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convEduMSTRGiftedClsCase.IsHaveVideo  ==  AttributeName[intIndex])
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTheme = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDateIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
}
else if (convEduMSTRGiftedClsCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdStudyLevel);
}
else if (convEduMSTRGiftedClsCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StudyLevelName);
}
else if (convEduMSTRGiftedClsCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdTeachingPlan);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTimeIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
}
else if (convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName);
}
else if (convEduMSTRGiftedClsCase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdCaseType);
}
else if (convEduMSTRGiftedClsCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdDiscipline);
}
else if (convEduMSTRGiftedClsCase.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.DisciplineID);
}
else if (convEduMSTRGiftedClsCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.DisciplineName);
}
else if (convEduMSTRGiftedClsCase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdSenateGaugeVersion);
}
else if (convEduMSTRGiftedClsCase.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionID);
}
else if (convEduMSTRGiftedClsCase.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionName);
}
else if (convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore);
}
else if (convEduMSTRGiftedClsCase.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.VersionNo);
}
else if (convEduMSTRGiftedClsCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdTeachSkill);
}
else if (convEduMSTRGiftedClsCase.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillID);
}
else if (convEduMSTRGiftedClsCase.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.SkillTypeName);
}
else if (convEduMSTRGiftedClsCase.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillName);
}
else if (convEduMSTRGiftedClsCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillTheory);
}
else if (convEduMSTRGiftedClsCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillOperMethod);
}
else if (convEduMSTRGiftedClsCase.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdSkillType);
}
else if (convEduMSTRGiftedClsCase.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.SkillTypeID);
}
else if (convEduMSTRGiftedClsCase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CaseLevelId);
}
else if (convEduMSTRGiftedClsCase.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CaseLevelName);
}
else if (convEduMSTRGiftedClsCase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.DocFile);
}
else if (convEduMSTRGiftedClsCase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsNeedGeneWord);
}
else if (convEduMSTRGiftedClsCase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.WordCreateDate);
}
else if (convEduMSTRGiftedClsCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsVisible);
}
else if (convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseText = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
}
else if (convEduMSTRGiftedClsCase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerId);
}
else if (convEduMSTRGiftedClsCase.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdStudentInfo);
}
else if (convEduMSTRGiftedClsCase.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuName);
}
else if (convEduMSTRGiftedClsCase.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuId);
}
else if (convEduMSTRGiftedClsCase.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.PoliticsName);
}
else if (convEduMSTRGiftedClsCase.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.SexDesc);
}
else if (convEduMSTRGiftedClsCase.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EthnicName);
}
else if (convEduMSTRGiftedClsCase.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UniZoneDesc);
}
else if (convEduMSTRGiftedClsCase.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuTypeDesc);
}
else if (convEduMSTRGiftedClsCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdXzCollege);
}
else if (convEduMSTRGiftedClsCase.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeId);
}
else if (convEduMSTRGiftedClsCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeName);
}
else if (convEduMSTRGiftedClsCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeNameA);
}
else if (convEduMSTRGiftedClsCase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdXzMajor);
}
else if (convEduMSTRGiftedClsCase.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.MajorName);
}
else if (convEduMSTRGiftedClsCase.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdGradeBase);
}
else if (convEduMSTRGiftedClsCase.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.GradeBaseName);
}
else if (convEduMSTRGiftedClsCase.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdAdminCls);
}
else if (convEduMSTRGiftedClsCase.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.AdminClsId);
}
else if (convEduMSTRGiftedClsCase.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.AdminClsName);
}
else if (convEduMSTRGiftedClsCase.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.Birthday);
}
else if (convEduMSTRGiftedClsCase.NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.NativePlace);
}
else if (convEduMSTRGiftedClsCase.Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.Duty);
}
else if (convEduMSTRGiftedClsCase.IdCardNo  ==  AttributeName[intIndex])
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdCardNo);
}
else if (convEduMSTRGiftedClsCase.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuCardNo);
}
else if (convEduMSTRGiftedClsCase.LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.LiveAddress);
}
else if (convEduMSTRGiftedClsCase.HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.HomePhone);
}
else if (convEduMSTRGiftedClsCase.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.EnrollmentDate);
}
else if (convEduMSTRGiftedClsCase.PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.PostCode);
}
else if (convEduMSTRGiftedClsCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsDualVideo);
}
else if (convEduMSTRGiftedClsCase.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserKindId);
}
else if (convEduMSTRGiftedClsCase.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserKindName);
}
else if (convEduMSTRGiftedClsCase.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserTypeId);
}
else if (convEduMSTRGiftedClsCase.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserTypeName);
}
else if (convEduMSTRGiftedClsCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.RecommendedDegreeId);
}
else if (convEduMSTRGiftedClsCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.RecommendedDegreeName);
}
else if (convEduMSTRGiftedClsCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.ftpFileType);
}
else if (convEduMSTRGiftedClsCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.VideoUrl);
}
else if (convEduMSTRGiftedClsCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.VideoPath);
}
else if (convEduMSTRGiftedClsCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.ResErrMsg);
}
else if (convEduMSTRGiftedClsCase.ResourceNum  ==  AttributeName[intIndex])
{
mintResourceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.ResourceNum);
}
else if (convEduMSTRGiftedClsCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.Memo);
}
else if (convEduMSTRGiftedClsCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase.BrowseCount4Case);
}
else if (convEduMSTRGiftedClsCase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerName);
}
else if (convEduMSTRGiftedClsCase.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerNameWithId);
}
else if (convEduMSTRGiftedClsCase.IsHaveVideo  ==  AttributeName[intIndex])
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsHaveVideo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdStudyLevel);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.StudyLevelName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdTeachingPlan);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
}
}
/// <summary>
/// 教育硕士优课案例类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTypeID
{
get
{
return mstrEduMSTRGiftedClsCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTypeID = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
}
}
/// <summary>
/// 教育硕士优课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTypeName
{
get
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTypeName = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdCaseType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdDiscipline);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.DisciplineID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.DisciplineName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdSenateGaugeVersion);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.VersionNo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdTeachSkill);
}
}
/// <summary>
/// 教学技能ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillID
{
get
{
return mstrTeachSkillID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillID = value;
}
else
{
 mstrTeachSkillID = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillID);
}
}
/// <summary>
/// 技能类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeName
{
get
{
return mstrSkillTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeName = value;
}
else
{
 mstrSkillTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.SkillTypeName);
}
}
/// <summary>
/// 教学技能名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillName
{
get
{
return mstrTeachSkillName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillName = value;
}
else
{
 mstrTeachSkillName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillName);
}
}
/// <summary>
/// 教学技能理论阐述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillTheory
{
get
{
return mstrTeachSkillTheory;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillTheory = value;
}
else
{
 mstrTeachSkillTheory = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillTheory);
}
}
/// <summary>
/// 教学技能实践操作方法(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillOperMethod
{
get
{
return mstrTeachSkillOperMethod;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillOperMethod = value;
}
else
{
 mstrTeachSkillOperMethod = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.TeachSkillOperMethod);
}
}
/// <summary>
/// 技能类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSkillType
{
get
{
return mstrIdSkillType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSkillType = value;
}
else
{
 mstrIdSkillType = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdSkillType);
}
}
/// <summary>
/// 技能类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeID
{
get
{
return mstrSkillTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeID = value;
}
else
{
 mstrSkillTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.SkillTypeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.CaseLevelId);
}
}
/// <summary>
/// 案例等级名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseLevelName
{
get
{
return mstrCaseLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseLevelName = value;
}
else
{
 mstrCaseLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.CaseLevelName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.DocFile);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsNeedGeneWord);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.WordCreateDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsVisible);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerId);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdStudentInfo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuName);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuId
{
get
{
return mstrStuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuId = value;
}
else
{
 mstrStuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuId);
}
}
/// <summary>
/// 政治面貌(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PoliticsName
{
get
{
return mstrPoliticsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPoliticsName = value;
}
else
{
 mstrPoliticsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.PoliticsName);
}
}
/// <summary>
/// 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SexDesc
{
get
{
return mstrSexDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexDesc = value;
}
else
{
 mstrSexDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.SexDesc);
}
}
/// <summary>
/// 民族名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EthnicName
{
get
{
return mstrEthnicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEthnicName = value;
}
else
{
 mstrEthnicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.EthnicName);
}
}
/// <summary>
/// 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneDesc
{
get
{
return mstrUniZoneDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneDesc = value;
}
else
{
 mstrUniZoneDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.UniZoneDesc);
}
}
/// <summary>
/// 学生类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeDesc
{
get
{
return mstrStuTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeDesc = value;
}
else
{
 mstrStuTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuTypeDesc);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdXzCollege);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.CollegeNameA);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdXzMajor);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.MajorName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdGradeBase);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.GradeBaseName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdAdminCls);
}
}
/// <summary>
/// 行政班代号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsId
{
get
{
return mstrAdminClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsId = value;
}
else
{
 mstrAdminClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.AdminClsId);
}
}
/// <summary>
/// 行政班名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsName
{
get
{
return mstrAdminClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsName = value;
}
else
{
 mstrAdminClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.AdminClsName);
}
}
/// <summary>
/// 出生日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Birthday
{
get
{
return mstrBirthday;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBirthday = value;
}
else
{
 mstrBirthday = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.Birthday);
}
}
/// <summary>
/// 籍贯(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NativePlace
{
get
{
return mstrNativePlace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNativePlace = value;
}
else
{
 mstrNativePlace = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.NativePlace);
}
}
/// <summary>
/// 职位(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Duty
{
get
{
return mstrDuty;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDuty = value;
}
else
{
 mstrDuty = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.Duty);
}
}
/// <summary>
/// 身份证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCardNo
{
get
{
return mstrIdCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCardNo = value;
}
else
{
 mstrIdCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.IdCardNo);
}
}
/// <summary>
/// 学生证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuCardNo
{
get
{
return mstrStuCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuCardNo = value;
}
else
{
 mstrStuCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.StuCardNo);
}
}
/// <summary>
/// 居住地址(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiveAddress
{
get
{
return mstrLiveAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiveAddress = value;
}
else
{
 mstrLiveAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.LiveAddress);
}
}
/// <summary>
/// 住宅电话(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomePhone
{
get
{
return mstrHomePhone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomePhone = value;
}
else
{
 mstrHomePhone = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.HomePhone);
}
}
/// <summary>
/// 入校日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EnrollmentDate
{
get
{
return mstrEnrollmentDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEnrollmentDate = value;
}
else
{
 mstrEnrollmentDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.EnrollmentDate);
}
}
/// <summary>
/// 邮编(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PostCode
{
get
{
return mstrPostCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPostCode = value;
}
else
{
 mstrPostCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.PostCode);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsDualVideo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserKindId);
}
}
/// <summary>
/// 用户类别名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindName
{
get
{
return mstrUserKindName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindName = value;
}
else
{
 mstrUserKindName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserKindName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserTypeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.UserTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.RecommendedDegreeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.RecommendedDegreeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.ftpFileType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.VideoUrl);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.VideoPath);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.ResErrMsg);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.ResourceNum);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.Memo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.BrowseCount4Case);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.OwnerNameWithId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase.IsHaveVideo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrEduMSTRGiftedClsCaseName;
 }
 }
}
 /// <summary>
 /// v教育硕士优课案例(vEduMSTRGiftedClsCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convEduMSTRGiftedClsCase
{
public const string _CurrTabName = "vEduMSTRGiftedClsCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduMSTRGiftedClsCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseTheme", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTime", "EduMSTRGiftedClsCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "EduMSTRGiftedClsCaseTimeIn", "IdEduMSTRGiftedClsCaseType", "EduMSTRGiftedClsCaseTypeID", "EduMSTRGiftedClsCaseTypeName", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "DocFile", "IsNeedGeneWord", "WordCreateDate", "IsVisible", "EduMSTRGiftedClsCaseText", "OwnerId", "IdStudentInfo", "StuName", "StuId", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IdCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "IsDualVideo", "UserKindId", "UserKindName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "ResourceNum", "Memo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId", "IsHaveVideo"};
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
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

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
 /// 常量:"EduMSTRGiftedClsCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTypeID = "EduMSTRGiftedClsCaseTypeID";    //教育硕士优课案例类型Id

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTypeName = "EduMSTRGiftedClsCaseTypeName";    //教育硕士优课案例类型名称

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
 /// 常量:"IdTeachSkill"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachSkill = "IdTeachSkill";    //教学技能流水号

 /// <summary>
 /// 常量:"TeachSkillID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillID = "TeachSkillID";    //教学技能ID

 /// <summary>
 /// 常量:"SkillTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeName = "SkillTypeName";    //技能类型名称

 /// <summary>
 /// 常量:"TeachSkillName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillName = "TeachSkillName";    //教学技能名称

 /// <summary>
 /// 常量:"TeachSkillTheory"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillTheory = "TeachSkillTheory";    //教学技能理论阐述

 /// <summary>
 /// 常量:"TeachSkillOperMethod"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillOperMethod = "TeachSkillOperMethod";    //教学技能实践操作方法

 /// <summary>
 /// 常量:"IdSkillType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSkillType = "IdSkillType";    //技能类型流水号

 /// <summary>
 /// 常量:"SkillTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeID = "SkillTypeID";    //技能类型ID

 /// <summary>
 /// 常量:"CaseLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelId = "CaseLevelId";    //课例等级Id

 /// <summary>
 /// 常量:"CaseLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelName = "CaseLevelName";    //案例等级名称

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
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"StuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuId = "StuId";    //学号

 /// <summary>
 /// 常量:"PoliticsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsName = "PoliticsName";    //政治面貌

 /// <summary>
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

 /// <summary>
 /// 常量:"EthnicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EthnicName = "EthnicName";    //民族名称

 /// <summary>
 /// 常量:"UniZoneDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneDesc = "UniZoneDesc";    //校区名称

 /// <summary>
 /// 常量:"StuTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeDesc = "StuTypeDesc";    //学生类别名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

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
 /// 常量:"AdminClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsId = "AdminClsId";    //行政班代号

 /// <summary>
 /// 常量:"AdminClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsName = "AdminClsName";    //行政班名称

 /// <summary>
 /// 常量:"Birthday"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Birthday = "Birthday";    //出生日期

 /// <summary>
 /// 常量:"NativePlace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NativePlace = "NativePlace";    //籍贯

 /// <summary>
 /// 常量:"Duty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Duty = "Duty";    //职位

 /// <summary>
 /// 常量:"IdCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCardNo = "IdCardNo";    //身份证号

 /// <summary>
 /// 常量:"StuCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuCardNo = "StuCardNo";    //学生证号

 /// <summary>
 /// 常量:"LiveAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiveAddress = "LiveAddress";    //居住地址

 /// <summary>
 /// 常量:"HomePhone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomePhone = "HomePhone";    //住宅电话

 /// <summary>
 /// 常量:"EnrollmentDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnrollmentDate = "EnrollmentDate";    //入校日期

 /// <summary>
 /// 常量:"PostCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PostCode = "PostCode";    //邮编

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
 /// 常量:"UserKindName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindName = "UserKindName";    //用户类别名

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
 /// 常量:"ResourceNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceNum = "ResourceNum";    //资源数

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
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"IsHaveVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveVideo = "IsHaveVideo";    //IsHaveVideo
}

}