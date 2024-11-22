
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel4AllEN
 表名:vMicroteachCase_Resource_Rel4All(01120429)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表vMicroteachCase_Resource_Rel4All的关键字(IdMicroteachCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4All
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroteachCaseResourceRel">表关键字</param>
public K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4All(long lngIdMicroteachCaseResourceRel)
{
if (IsValid(lngIdMicroteachCaseResourceRel)) Value = lngIdMicroteachCaseResourceRel;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroteachCaseResourceRel)
{
if (lngIdMicroteachCaseResourceRel == 0) return false;
if (lngIdMicroteachCaseResourceRel == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4All]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4All(long value)
{
return new K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4All(value);
}
}
 /// <summary>
 /// vMicroteachCase_Resource_Rel4All(vMicroteachCase_Resource_Rel4All)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachCase_Resource_Rel4AllEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachCase_Resource_Rel4All"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 81;
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "microteachCaseText", "OwnerId", "OwnerName", "CollegeID", "CollegeName", "OwnerNameWithId", "IdXzCollege", "IsDualVideo", "UserKindId", "UserKindName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};

protected long mlngIdMicroteachCaseResourceRel;    //微格案例资源关系流水号
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrMicroteachCaseID;    //微格教学案例ID
protected string mstrMicroteachCaseName;    //微格教学案例名称
protected string mstrMicroteachCaseTheme;    //微格教学案例主题词
protected string mstrMicroteachCaseDate;    //微格教学日期
protected string mstrMicroteachCaseTime;    //微格教学时间
protected string mstrMicroteachCaseDateIn;    //案例入库日期
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrMicroTeachCaseTimeIn;    //案例入库时间
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
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
protected string mstrmicroteachCaseText;    //案例文本内容
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrIdXzCollege;    //学院流水号
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
protected string mstrResourceName;    //资源名称
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrIdFile;    //文件流水号
protected string mstrFileName;    //文件名称
protected string mstrFileType;    //文件类型
protected string mstrSaveDate;    //创建日期
protected string mstrFileSize;    //文件大小
protected string mstrSaveTime;    //创建时间
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected bool mbolSaveMode;    //文件存放方式
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrResourceOwner;    //上传者
protected string mstrftpFileType;    //ftp文件类型
protected string mstrftpFileSize;    //ftp文件大小
protected string mstrftpResourceOwner;    //Ftp资源拥有者
protected string mstrFileOriginName;    //原文件名
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名
protected bool mbolIsMain;    //是否主资源
protected string mstrIdUsingMode;    //资源使用模式流水号
protected bool mbolIsVisible;    //是否显示
protected int? mintIndexNO;    //序号
protected int? mintBrowseCount;    //浏览次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachCase_Resource_Rel4AllEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseResourceRel");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroteachCaseResourceRel">关键字:微格案例资源关系流水号</param>
public clsvMicroteachCase_Resource_Rel4AllEN(long lngIdMicroteachCaseResourceRel)
 {
 if (lngIdMicroteachCaseResourceRel  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseResourceRel");
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
if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel)
{
return mlngIdMicroteachCaseResourceRel;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseID)
{
return mstrMicroteachCaseID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseName)
{
return mstrMicroteachCaseName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme)
{
return mstrMicroteachCaseTheme;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseDate)
{
return mstrMicroteachCaseDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseTime)
{
return mstrMicroteachCaseTime;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn)
{
return mstrMicroteachCaseDateIn;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn)
{
return mstrMicroTeachCaseTimeIn;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.microteachCaseText)
{
return mstrmicroteachCaseText;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdUsingMode)
{
return mstrIdUsingMode;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel)
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseID)
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseName)
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme)
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseDate)
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseTime)
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn)
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdStudyLevel);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.StudyLevelName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdTeachingPlan);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn)
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdCaseType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdDiscipline);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.DisciplineID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.DisciplineName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.VersionNo);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdTeachSkill);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SkillTypeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillTheory);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdSkillType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SkillTypeID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CaseLevelId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CaseLevelName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.microteachCaseText)
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.microteachCaseText);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CollegeID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CollegeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerNameWithId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdXzCollege);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsDualVideo);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserKindId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserKindName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserTypeId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserTypeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.BrowseCount4Case);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdResource);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdFtpResource);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdFile);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileSize);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveTime);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FtpResourceID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOriginalName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileDirName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileRename);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileUpDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileUpTime);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveMode);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdResourceType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceTypeID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceTypeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceOwner);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpFileType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpFileSize);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpResourceOwner);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOriginName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsExistFile);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileNewName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOldName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsMain);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IdUsingMode)
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdUsingMode);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsVisible);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IndexNO);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.BrowseCount);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UpdDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UpdUser);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4All.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseResourceRel;
}
else if (convMicroteachCase_Resource_Rel4All.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseID;
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseName;
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTheme;
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseDate  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDate;
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseTime  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTime;
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDateIn;
}
else if (convMicroteachCase_Resource_Rel4All.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convMicroteachCase_Resource_Rel4All.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convMicroteachCase_Resource_Rel4All.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseTimeIn;
}
else if (convMicroteachCase_Resource_Rel4All.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convMicroteachCase_Resource_Rel4All.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convMicroteachCase_Resource_Rel4All.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convMicroteachCase_Resource_Rel4All.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convMicroteachCase_Resource_Rel4All.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convMicroteachCase_Resource_Rel4All.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convMicroteachCase_Resource_Rel4All.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convMicroteachCase_Resource_Rel4All.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convMicroteachCase_Resource_Rel4All.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convMicroteachCase_Resource_Rel4All.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convMicroteachCase_Resource_Rel4All.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convMicroteachCase_Resource_Rel4All.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convMicroteachCase_Resource_Rel4All.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convMicroteachCase_Resource_Rel4All.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convMicroteachCase_Resource_Rel4All.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convMicroteachCase_Resource_Rel4All.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convMicroteachCase_Resource_Rel4All.microteachCaseText  ==  AttributeName[intIndex])
{
return mstrmicroteachCaseText;
}
else if (convMicroteachCase_Resource_Rel4All.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convMicroteachCase_Resource_Rel4All.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convMicroteachCase_Resource_Rel4All.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convMicroteachCase_Resource_Rel4All.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convMicroteachCase_Resource_Rel4All.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convMicroteachCase_Resource_Rel4All.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convMicroteachCase_Resource_Rel4All.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convMicroteachCase_Resource_Rel4All.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convMicroteachCase_Resource_Rel4All.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convMicroteachCase_Resource_Rel4All.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convMicroteachCase_Resource_Rel4All.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convMicroteachCase_Resource_Rel4All.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convMicroteachCase_Resource_Rel4All.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convMicroteachCase_Resource_Rel4All.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convMicroteachCase_Resource_Rel4All.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convMicroteachCase_Resource_Rel4All.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convMicroteachCase_Resource_Rel4All.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convMicroteachCase_Resource_Rel4All.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convMicroteachCase_Resource_Rel4All.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convMicroteachCase_Resource_Rel4All.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convMicroteachCase_Resource_Rel4All.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convMicroteachCase_Resource_Rel4All.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convMicroteachCase_Resource_Rel4All.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convMicroteachCase_Resource_Rel4All.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convMicroteachCase_Resource_Rel4All.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convMicroteachCase_Resource_Rel4All.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convMicroteachCase_Resource_Rel4All.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convMicroteachCase_Resource_Rel4All.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convMicroteachCase_Resource_Rel4All.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convMicroteachCase_Resource_Rel4All.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convMicroteachCase_Resource_Rel4All.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convMicroteachCase_Resource_Rel4All.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convMicroteachCase_Resource_Rel4All.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convMicroteachCase_Resource_Rel4All.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convMicroteachCase_Resource_Rel4All.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convMicroteachCase_Resource_Rel4All.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convMicroteachCase_Resource_Rel4All.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convMicroteachCase_Resource_Rel4All.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convMicroteachCase_Resource_Rel4All.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convMicroteachCase_Resource_Rel4All.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convMicroteachCase_Resource_Rel4All.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convMicroteachCase_Resource_Rel4All.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convMicroteachCase_Resource_Rel4All.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convMicroteachCase_Resource_Rel4All.IdUsingMode  ==  AttributeName[intIndex])
{
return mstrIdUsingMode;
}
else if (convMicroteachCase_Resource_Rel4All.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convMicroteachCase_Resource_Rel4All.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convMicroteachCase_Resource_Rel4All.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convMicroteachCase_Resource_Rel4All.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convMicroteachCase_Resource_Rel4All.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convMicroteachCase_Resource_Rel4All.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel);
}
else if (convMicroteachCase_Resource_Rel4All.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdMicroteachCase);
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseName);
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme);
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseDate  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseTime  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
}
else if (convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
}
else if (convMicroteachCase_Resource_Rel4All.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdStudyLevel);
}
else if (convMicroteachCase_Resource_Rel4All.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.StudyLevelName);
}
else if (convMicroteachCase_Resource_Rel4All.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdTeachingPlan);
}
else if (convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
}
else if (convMicroteachCase_Resource_Rel4All.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdCaseType);
}
else if (convMicroteachCase_Resource_Rel4All.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdDiscipline);
}
else if (convMicroteachCase_Resource_Rel4All.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.DisciplineID);
}
else if (convMicroteachCase_Resource_Rel4All.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.DisciplineName);
}
else if (convMicroteachCase_Resource_Rel4All.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
}
else if (convMicroteachCase_Resource_Rel4All.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName);
}
else if (convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore);
}
else if (convMicroteachCase_Resource_Rel4All.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.VersionNo);
}
else if (convMicroteachCase_Resource_Rel4All.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdTeachSkill);
}
else if (convMicroteachCase_Resource_Rel4All.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillID);
}
else if (convMicroteachCase_Resource_Rel4All.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SkillTypeName);
}
else if (convMicroteachCase_Resource_Rel4All.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillName);
}
else if (convMicroteachCase_Resource_Rel4All.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillTheory);
}
else if (convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod);
}
else if (convMicroteachCase_Resource_Rel4All.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdSkillType);
}
else if (convMicroteachCase_Resource_Rel4All.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SkillTypeID);
}
else if (convMicroteachCase_Resource_Rel4All.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CaseLevelId);
}
else if (convMicroteachCase_Resource_Rel4All.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CaseLevelName);
}
else if (convMicroteachCase_Resource_Rel4All.microteachCaseText  ==  AttributeName[intIndex])
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.microteachCaseText);
}
else if (convMicroteachCase_Resource_Rel4All.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerId);
}
else if (convMicroteachCase_Resource_Rel4All.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerName);
}
else if (convMicroteachCase_Resource_Rel4All.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CollegeID);
}
else if (convMicroteachCase_Resource_Rel4All.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CollegeName);
}
else if (convMicroteachCase_Resource_Rel4All.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerNameWithId);
}
else if (convMicroteachCase_Resource_Rel4All.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdXzCollege);
}
else if (convMicroteachCase_Resource_Rel4All.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsDualVideo);
}
else if (convMicroteachCase_Resource_Rel4All.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserKindId);
}
else if (convMicroteachCase_Resource_Rel4All.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserKindName);
}
else if (convMicroteachCase_Resource_Rel4All.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserTypeId);
}
else if (convMicroteachCase_Resource_Rel4All.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserTypeName);
}
else if (convMicroteachCase_Resource_Rel4All.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
}
else if (convMicroteachCase_Resource_Rel4All.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName);
}
else if (convMicroteachCase_Resource_Rel4All.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.BrowseCount4Case);
}
else if (convMicroteachCase_Resource_Rel4All.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdResource);
}
else if (convMicroteachCase_Resource_Rel4All.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceID);
}
else if (convMicroteachCase_Resource_Rel4All.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceName);
}
else if (convMicroteachCase_Resource_Rel4All.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdFtpResource);
}
else if (convMicroteachCase_Resource_Rel4All.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdFile);
}
else if (convMicroteachCase_Resource_Rel4All.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileName);
}
else if (convMicroteachCase_Resource_Rel4All.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileType);
}
else if (convMicroteachCase_Resource_Rel4All.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveDate);
}
else if (convMicroteachCase_Resource_Rel4All.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileSize);
}
else if (convMicroteachCase_Resource_Rel4All.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveTime);
}
else if (convMicroteachCase_Resource_Rel4All.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FtpResourceID);
}
else if (convMicroteachCase_Resource_Rel4All.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOriginalName);
}
else if (convMicroteachCase_Resource_Rel4All.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileDirName);
}
else if (convMicroteachCase_Resource_Rel4All.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileRename);
}
else if (convMicroteachCase_Resource_Rel4All.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileUpDate);
}
else if (convMicroteachCase_Resource_Rel4All.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileUpTime);
}
else if (convMicroteachCase_Resource_Rel4All.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveMode);
}
else if (convMicroteachCase_Resource_Rel4All.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdResourceType);
}
else if (convMicroteachCase_Resource_Rel4All.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceTypeID);
}
else if (convMicroteachCase_Resource_Rel4All.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceTypeName);
}
else if (convMicroteachCase_Resource_Rel4All.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceOwner);
}
else if (convMicroteachCase_Resource_Rel4All.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpFileType);
}
else if (convMicroteachCase_Resource_Rel4All.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpFileSize);
}
else if (convMicroteachCase_Resource_Rel4All.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpResourceOwner);
}
else if (convMicroteachCase_Resource_Rel4All.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOriginName);
}
else if (convMicroteachCase_Resource_Rel4All.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsExistFile);
}
else if (convMicroteachCase_Resource_Rel4All.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileNewName);
}
else if (convMicroteachCase_Resource_Rel4All.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOldName);
}
else if (convMicroteachCase_Resource_Rel4All.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsMain);
}
else if (convMicroteachCase_Resource_Rel4All.IdUsingMode  ==  AttributeName[intIndex])
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdUsingMode);
}
else if (convMicroteachCase_Resource_Rel4All.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsVisible);
}
else if (convMicroteachCase_Resource_Rel4All.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IndexNO);
}
else if (convMicroteachCase_Resource_Rel4All.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.BrowseCount);
}
else if (convMicroteachCase_Resource_Rel4All.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UpdDate);
}
else if (convMicroteachCase_Resource_Rel4All.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UpdUser);
}
else if (convMicroteachCase_Resource_Rel4All.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.Memo);
}
}
}

/// <summary>
/// 微格案例资源关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroteachCaseResourceRel
{
get
{
return mlngIdMicroteachCaseResourceRel;
}
set
{
 mlngIdMicroteachCaseResourceRel = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdMicroteachCase);
}
}
/// <summary>
/// 微格教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseID
{
get
{
return mstrMicroteachCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseID = value;
}
else
{
 mstrMicroteachCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
}
}
/// <summary>
/// 微格教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseName
{
get
{
return mstrMicroteachCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseName = value;
}
else
{
 mstrMicroteachCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseName);
}
}
/// <summary>
/// 微格教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseTheme
{
get
{
return mstrMicroteachCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseTheme = value;
}
else
{
 mstrMicroteachCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme);
}
}
/// <summary>
/// 微格教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseDate
{
get
{
return mstrMicroteachCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseDate = value;
}
else
{
 mstrMicroteachCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
}
}
/// <summary>
/// 微格教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseTime
{
get
{
return mstrMicroteachCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseTime = value;
}
else
{
 mstrMicroteachCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseDateIn
{
get
{
return mstrMicroteachCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseDateIn = value;
}
else
{
 mstrMicroteachCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdStudyLevel);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.StudyLevelName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdTeachingPlan);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseTimeIn
{
get
{
return mstrMicroTeachCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseTimeIn = value;
}
else
{
 mstrMicroTeachCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdCaseType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdDiscipline);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.DisciplineID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.DisciplineName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.VersionNo);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdTeachSkill);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SkillTypeName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillTheory);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdSkillType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SkillTypeID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CaseLevelId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CaseLevelName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string microteachCaseText
{
get
{
return mstrmicroteachCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmicroteachCaseText = value;
}
else
{
 mstrmicroteachCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.microteachCaseText);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CollegeID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.CollegeName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.OwnerNameWithId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdXzCollege);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsDualVideo);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserKindId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserKindName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserTypeId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UserTypeName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.RecommendedDegreeName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.BrowseCount4Case);
}
}
/// <summary>
/// 资源流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResource
{
get
{
return mstrIdResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResource = value;
}
else
{
 mstrIdResource = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdResource);
}
}
/// <summary>
/// 资源ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceID
{
get
{
return mstrResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceID = value;
}
else
{
 mstrResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceID);
}
}
/// <summary>
/// 资源名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceName
{
get
{
return mstrResourceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceName = value;
}
else
{
 mstrResourceName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceName);
}
}
/// <summary>
/// FTP资源流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFtpResource
{
get
{
return mstrIdFtpResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFtpResource = value;
}
else
{
 mstrIdFtpResource = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdFtpResource);
}
}
/// <summary>
/// 文件流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFile
{
get
{
return mstrIdFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFile = value;
}
else
{
 mstrIdFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdFile);
}
}
/// <summary>
/// 文件名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileName);
}
}
/// <summary>
/// 文件类型(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileType
{
get
{
return mstrFileType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileType = value;
}
else
{
 mstrFileType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileType);
}
}
/// <summary>
/// 创建日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SaveDate
{
get
{
return mstrSaveDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSaveDate = value;
}
else
{
 mstrSaveDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveDate);
}
}
/// <summary>
/// 文件大小(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileSize
{
get
{
return mstrFileSize;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileSize = value;
}
else
{
 mstrFileSize = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileSize);
}
}
/// <summary>
/// 创建时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SaveTime
{
get
{
return mstrSaveTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSaveTime = value;
}
else
{
 mstrSaveTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveTime);
}
}
/// <summary>
/// FTP资源ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpResourceID
{
get
{
return mstrFtpResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpResourceID = value;
}
else
{
 mstrFtpResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FtpResourceID);
}
}
/// <summary>
/// 文件原名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileOriginalName
{
get
{
return mstrFileOriginalName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileOriginalName = value;
}
else
{
 mstrFileOriginalName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOriginalName);
}
}
/// <summary>
/// 文件目录名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileDirName
{
get
{
return mstrFileDirName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileDirName = value;
}
else
{
 mstrFileDirName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileDirName);
}
}
/// <summary>
/// 文件新名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileRename
{
get
{
return mstrFileRename;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileRename = value;
}
else
{
 mstrFileRename = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileRename);
}
}
/// <summary>
/// 创建日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileUpDate
{
get
{
return mstrFileUpDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileUpDate = value;
}
else
{
 mstrFileUpDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileUpDate);
}
}
/// <summary>
/// 创建时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileUpTime
{
get
{
return mstrFileUpTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileUpTime = value;
}
else
{
 mstrFileUpTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileUpTime);
}
}
/// <summary>
/// 文件存放方式(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool SaveMode
{
get
{
return mbolSaveMode;
}
set
{
 mbolSaveMode = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.SaveMode);
}
}
/// <summary>
/// 资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResourceType
{
get
{
return mstrIdResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResourceType = value;
}
else
{
 mstrIdResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdResourceType);
}
}
/// <summary>
/// 资源类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeID
{
get
{
return mstrResourceTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeID = value;
}
else
{
 mstrResourceTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceTypeID);
}
}
/// <summary>
/// 资源类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeName
{
get
{
return mstrResourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeName = value;
}
else
{
 mstrResourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceTypeName);
}
}
/// <summary>
/// 上传者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceOwner
{
get
{
return mstrResourceOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceOwner = value;
}
else
{
 mstrResourceOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ResourceOwner);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpFileType);
}
}
/// <summary>
/// ftp文件大小(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ftpFileSize
{
get
{
return mstrftpFileSize;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrftpFileSize = value;
}
else
{
 mstrftpFileSize = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpFileSize);
}
}
/// <summary>
/// Ftp资源拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ftpResourceOwner
{
get
{
return mstrftpResourceOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrftpResourceOwner = value;
}
else
{
 mstrftpResourceOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.ftpResourceOwner);
}
}
/// <summary>
/// 原文件名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileOriginName
{
get
{
return mstrFileOriginName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileOriginName = value;
}
else
{
 mstrFileOriginName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOriginName);
}
}
/// <summary>
/// 是否存在文件(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistFile
{
get
{
return mbolIsExistFile;
}
set
{
 mbolIsExistFile = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsExistFile);
}
}
/// <summary>
/// 新文件名(说明:;字段类型:varchar;字段长度:530;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileNewName
{
get
{
return mstrFileNewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileNewName = value;
}
else
{
 mstrFileNewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileNewName);
}
}
/// <summary>
/// 旧文件名(说明:;字段类型:varchar;字段长度:530;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileOldName
{
get
{
return mstrFileOldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileOldName = value;
}
else
{
 mstrFileOldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.FileOldName);
}
}
/// <summary>
/// 是否主资源(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMain
{
get
{
return mbolIsMain;
}
set
{
 mbolIsMain = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsMain);
}
}
/// <summary>
/// 资源使用模式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUsingMode
{
get
{
return mstrIdUsingMode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUsingMode = value;
}
else
{
 mstrIdUsingMode = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IdUsingMode);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IsVisible);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? IndexNO
{
get
{
return mintIndexNO;
}
set
{
 mintIndexNO = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.IndexNO);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.BrowseCount);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.UpdUser);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4All.Memo);
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
  return mlngIdMicroteachCaseResourceRel.ToString();
 }
 }
}
 /// <summary>
 /// vMicroteachCase_Resource_Rel4All(vMicroteachCase_Resource_Rel4All)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachCase_Resource_Rel4All
{
public const string _CurrTabName = "vMicroteachCase_Resource_Rel4All"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "CaseLevelName", "microteachCaseText", "OwnerId", "OwnerName", "CollegeID", "CollegeName", "OwnerNameWithId", "IdXzCollege", "IsDualVideo", "UserKindId", "UserKindName", "UserTypeId", "UserTypeName", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseResourceRel = "IdMicroteachCaseResourceRel";    //微格案例资源关系流水号

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"MicroteachCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseID = "MicroteachCaseID";    //微格教学案例ID

 /// <summary>
 /// 常量:"MicroteachCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseName = "MicroteachCaseName";    //微格教学案例名称

 /// <summary>
 /// 常量:"MicroteachCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseTheme = "MicroteachCaseTheme";    //微格教学案例主题词

 /// <summary>
 /// 常量:"MicroteachCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseDate = "MicroteachCaseDate";    //微格教学日期

 /// <summary>
 /// 常量:"MicroteachCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseTime = "MicroteachCaseTime";    //微格教学时间

 /// <summary>
 /// 常量:"MicroteachCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseDateIn = "MicroteachCaseDateIn";    //案例入库日期

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
 /// 常量:"MicroTeachCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseTimeIn = "MicroTeachCaseTimeIn";    //案例入库时间

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
 /// 常量:"microteachCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string microteachCaseText = "microteachCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

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
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

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
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"ResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceID = "ResourceID";    //资源ID

 /// <summary>
 /// 常量:"ResourceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceName = "ResourceName";    //资源名称

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

 /// <summary>
 /// 常量:"IdFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFile = "IdFile";    //文件流水号

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"FileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileType = "FileType";    //文件类型

 /// <summary>
 /// 常量:"SaveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveDate = "SaveDate";    //创建日期

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"SaveTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveTime = "SaveTime";    //创建时间

 /// <summary>
 /// 常量:"FtpResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpResourceID = "FtpResourceID";    //FTP资源ID

 /// <summary>
 /// 常量:"FileOriginalName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginalName = "FileOriginalName";    //文件原名

 /// <summary>
 /// 常量:"FileDirName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileDirName = "FileDirName";    //文件目录名

 /// <summary>
 /// 常量:"FileRename"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileRename = "FileRename";    //文件新名

 /// <summary>
 /// 常量:"FileUpDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileUpDate = "FileUpDate";    //创建日期

 /// <summary>
 /// 常量:"FileUpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileUpTime = "FileUpTime";    //创建时间

 /// <summary>
 /// 常量:"SaveMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveMode = "SaveMode";    //文件存放方式

 /// <summary>
 /// 常量:"IdResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResourceType = "IdResourceType";    //资源类型流水号

 /// <summary>
 /// 常量:"ResourceTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeID = "ResourceTypeID";    //资源类型ID

 /// <summary>
 /// 常量:"ResourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeName = "ResourceTypeName";    //资源类型名称

 /// <summary>
 /// 常量:"ResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceOwner = "ResourceOwner";    //上传者

 /// <summary>
 /// 常量:"ftpFileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpFileType = "ftpFileType";    //ftp文件类型

 /// <summary>
 /// 常量:"ftpFileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpFileSize = "ftpFileSize";    //ftp文件大小

 /// <summary>
 /// 常量:"ftpResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpResourceOwner = "ftpResourceOwner";    //Ftp资源拥有者

 /// <summary>
 /// 常量:"FileOriginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginName = "FileOriginName";    //原文件名

 /// <summary>
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

 /// <summary>
 /// 常量:"FileNewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNewName = "FileNewName";    //新文件名

 /// <summary>
 /// 常量:"FileOldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOldName = "FileOldName";    //旧文件名

 /// <summary>
 /// 常量:"IsMain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMain = "IsMain";    //是否主资源

 /// <summary>
 /// 常量:"IdUsingMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUsingMode = "IdUsingMode";    //资源使用模式流水号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IndexNO"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IndexNO = "IndexNO";    //序号

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}