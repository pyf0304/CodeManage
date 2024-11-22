
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel4TeaEN
 表名:vMicroteachCase_Resource_Rel4Tea(01120428)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:36
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
 /// 表vMicroteachCase_Resource_Rel4Tea的关键字(IdMicroteachCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4Tea
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
public K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4Tea(long lngIdMicroteachCaseResourceRel)
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
 /// <returns>返回:[K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4Tea]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4Tea(long value)
{
return new K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel4Tea(value);
}
}
 /// <summary>
 /// v微格资源关系4Tea(vMicroteachCase_Resource_Rel4Tea)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachCase_Resource_Rel4TeaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachCase_Resource_Rel4Tea"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 79;
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IdDiscipline", "DisciplineID", "DisciplineName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "microteachCaseText", "OwnerId", "OwnerName", "TeacherID", "TeacherName", "IdXzCollege", "CollegeName", "EntryDate", "CollegeID", "EntryYear", "IsDualVideo", "UserTypeId", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo", "CollegeNameA"};

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
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrTeachSkillID;    //教学技能ID
protected string mstrSkillTypeName;    //技能类型名称
protected string mstrTeachSkillName;    //教学技能名称
protected string mstrTeachSkillTheory;    //教学技能理论阐述
protected string mstrTeachSkillOperMethod;    //教学技能实践操作方法
protected string mstrIdSkillType;    //技能类型流水号
protected string mstrSkillTypeID;    //技能类型ID
protected string mstrCaseLevelId;    //课例等级Id
protected string mstrmicroteachCaseText;    //案例文本内容
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrTeacherID;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrEntryDate;    //进校日期
protected string mstrCollegeID;    //学院ID
protected string mstrEntryYear;    //EntryYear
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserTypeId;    //用户类型Id
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
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachCase_Resource_Rel4TeaEN()
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
public clsvMicroteachCase_Resource_Rel4TeaEN(long lngIdMicroteachCaseResourceRel)
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
if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel)
{
return mlngIdMicroteachCaseResourceRel;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID)
{
return mstrMicroteachCaseID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName)
{
return mstrMicroteachCaseName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme)
{
return mstrMicroteachCaseTheme;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate)
{
return mstrMicroteachCaseDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime)
{
return mstrMicroteachCaseTime;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn)
{
return mstrMicroteachCaseDateIn;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn)
{
return mstrMicroTeachCaseTimeIn;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.microteachCaseText)
{
return mstrmicroteachCaseText;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeacherID)
{
return mstrTeacherID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.EntryDate)
{
return mstrEntryDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.EntryYear)
{
return mstrEntryYear;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdUsingMode)
{
return mstrIdUsingMode;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel)
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID)
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName)
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme)
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate)
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime)
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn)
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdStudyLevel);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.StudyLevelName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn)
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdDiscipline);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.DisciplineID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.DisciplineName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdTeachSkill);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SkillTypeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdSkillType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.microteachCaseText)
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.microteachCaseText);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.OwnerId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.OwnerName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeacherID)
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeacherID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeacherName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdXzCollege);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.EntryDate)
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.EntryDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.EntryYear)
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.EntryYear);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsDualVideo);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UserTypeId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdResource);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdFtpResource);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdFile);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileSize);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveTime);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOriginalName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileDirName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileRename);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileUpDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileUpTime);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveMode);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdResourceType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceOwner);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpFileType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpFileSize);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOriginName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsExistFile);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileNewName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOldName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsMain);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IdUsingMode)
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdUsingMode);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsVisible);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IndexNO);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.BrowseCount);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UpdDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UpdUser);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.Memo);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel4Tea.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseResourceRel;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseID;
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseName;
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTheme;
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDate;
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTime;
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDateIn;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convMicroteachCase_Resource_Rel4Tea.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseTimeIn;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convMicroteachCase_Resource_Rel4Tea.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convMicroteachCase_Resource_Rel4Tea.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convMicroteachCase_Resource_Rel4Tea.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convMicroteachCase_Resource_Rel4Tea.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convMicroteachCase_Resource_Rel4Tea.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convMicroteachCase_Resource_Rel4Tea.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convMicroteachCase_Resource_Rel4Tea.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convMicroteachCase_Resource_Rel4Tea.microteachCaseText  ==  AttributeName[intIndex])
{
return mstrmicroteachCaseText;
}
else if (convMicroteachCase_Resource_Rel4Tea.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convMicroteachCase_Resource_Rel4Tea.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convMicroteachCase_Resource_Rel4Tea.TeacherID  ==  AttributeName[intIndex])
{
return mstrTeacherID;
}
else if (convMicroteachCase_Resource_Rel4Tea.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convMicroteachCase_Resource_Rel4Tea.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convMicroteachCase_Resource_Rel4Tea.EntryDate  ==  AttributeName[intIndex])
{
return mstrEntryDate;
}
else if (convMicroteachCase_Resource_Rel4Tea.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convMicroteachCase_Resource_Rel4Tea.EntryYear  ==  AttributeName[intIndex])
{
return mstrEntryYear;
}
else if (convMicroteachCase_Resource_Rel4Tea.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convMicroteachCase_Resource_Rel4Tea.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convMicroteachCase_Resource_Rel4Tea.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convMicroteachCase_Resource_Rel4Tea.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convMicroteachCase_Resource_Rel4Tea.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convMicroteachCase_Resource_Rel4Tea.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convMicroteachCase_Resource_Rel4Tea.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convMicroteachCase_Resource_Rel4Tea.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convMicroteachCase_Resource_Rel4Tea.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convMicroteachCase_Resource_Rel4Tea.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convMicroteachCase_Resource_Rel4Tea.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convMicroteachCase_Resource_Rel4Tea.IdUsingMode  ==  AttributeName[intIndex])
{
return mstrIdUsingMode;
}
else if (convMicroteachCase_Resource_Rel4Tea.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convMicroteachCase_Resource_Rel4Tea.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convMicroteachCase_Resource_Rel4Tea.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convMicroteachCase_Resource_Rel4Tea.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convMicroteachCase_Resource_Rel4Tea.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convMicroteachCase_Resource_Rel4Tea.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convMicroteachCase_Resource_Rel4Tea.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase);
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme);
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdStudyLevel);
}
else if (convMicroteachCase_Resource_Rel4Tea.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.StudyLevelName);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan);
}
else if (convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdDiscipline);
}
else if (convMicroteachCase_Resource_Rel4Tea.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.DisciplineID);
}
else if (convMicroteachCase_Resource_Rel4Tea.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.DisciplineName);
}
else if (convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
}
else if (convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName);
}
else if (convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdTeachSkill);
}
else if (convMicroteachCase_Resource_Rel4Tea.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
}
else if (convMicroteachCase_Resource_Rel4Tea.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SkillTypeName);
}
else if (convMicroteachCase_Resource_Rel4Tea.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillName);
}
else if (convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory);
}
else if (convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdSkillType);
}
else if (convMicroteachCase_Resource_Rel4Tea.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
}
else if (convMicroteachCase_Resource_Rel4Tea.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
}
else if (convMicroteachCase_Resource_Rel4Tea.microteachCaseText  ==  AttributeName[intIndex])
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.microteachCaseText);
}
else if (convMicroteachCase_Resource_Rel4Tea.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.OwnerId);
}
else if (convMicroteachCase_Resource_Rel4Tea.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.OwnerName);
}
else if (convMicroteachCase_Resource_Rel4Tea.TeacherID  ==  AttributeName[intIndex])
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeacherID);
}
else if (convMicroteachCase_Resource_Rel4Tea.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeacherName);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdXzCollege);
}
else if (convMicroteachCase_Resource_Rel4Tea.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeName);
}
else if (convMicroteachCase_Resource_Rel4Tea.EntryDate  ==  AttributeName[intIndex])
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.EntryDate);
}
else if (convMicroteachCase_Resource_Rel4Tea.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeID);
}
else if (convMicroteachCase_Resource_Rel4Tea.EntryYear  ==  AttributeName[intIndex])
{
mstrEntryYear = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.EntryYear);
}
else if (convMicroteachCase_Resource_Rel4Tea.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsDualVideo);
}
else if (convMicroteachCase_Resource_Rel4Tea.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UserTypeId);
}
else if (convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
}
else if (convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName);
}
else if (convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdResource);
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceID);
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceName);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdFtpResource);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdFile);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileName);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileType);
}
else if (convMicroteachCase_Resource_Rel4Tea.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveDate);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileSize);
}
else if (convMicroteachCase_Resource_Rel4Tea.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveTime);
}
else if (convMicroteachCase_Resource_Rel4Tea.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOriginalName);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileDirName);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileRename);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileUpDate);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileUpTime);
}
else if (convMicroteachCase_Resource_Rel4Tea.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveMode);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdResourceType);
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName);
}
else if (convMicroteachCase_Resource_Rel4Tea.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceOwner);
}
else if (convMicroteachCase_Resource_Rel4Tea.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpFileType);
}
else if (convMicroteachCase_Resource_Rel4Tea.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpFileSize);
}
else if (convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOriginName);
}
else if (convMicroteachCase_Resource_Rel4Tea.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsExistFile);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileNewName);
}
else if (convMicroteachCase_Resource_Rel4Tea.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOldName);
}
else if (convMicroteachCase_Resource_Rel4Tea.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsMain);
}
else if (convMicroteachCase_Resource_Rel4Tea.IdUsingMode  ==  AttributeName[intIndex])
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdUsingMode);
}
else if (convMicroteachCase_Resource_Rel4Tea.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsVisible);
}
else if (convMicroteachCase_Resource_Rel4Tea.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IndexNO);
}
else if (convMicroteachCase_Resource_Rel4Tea.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.BrowseCount);
}
else if (convMicroteachCase_Resource_Rel4Tea.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UpdDate);
}
else if (convMicroteachCase_Resource_Rel4Tea.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UpdUser);
}
else if (convMicroteachCase_Resource_Rel4Tea.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.Memo);
}
else if (convMicroteachCase_Resource_Rel4Tea.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeNameA);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdStudyLevel);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.StudyLevelName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdDiscipline);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.DisciplineID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.DisciplineName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdTeachSkill);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SkillTypeName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdSkillType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.microteachCaseText);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.OwnerId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.OwnerName);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherID
{
get
{
return mstrTeacherID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherID = value;
}
else
{
 mstrTeacherID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeacherID);
}
}
/// <summary>
/// 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherName
{
get
{
return mstrTeacherName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherName = value;
}
else
{
 mstrTeacherName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.TeacherName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdXzCollege);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeName);
}
}
/// <summary>
/// 进校日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EntryDate
{
get
{
return mstrEntryDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEntryDate = value;
}
else
{
 mstrEntryDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.EntryDate);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeID);
}
}
/// <summary>
/// EntryYear(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EntryYear
{
get
{
return mstrEntryYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEntryYear = value;
}
else
{
 mstrEntryYear = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.EntryYear);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsDualVideo);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UserTypeId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdResource);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdFtpResource);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdFile);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveDate);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileSize);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveTime);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOriginalName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileDirName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileRename);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileUpDate);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileUpTime);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.SaveMode);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdResourceType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceTypeName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ResourceOwner);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpFileType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpFileSize);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOriginName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsExistFile);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileNewName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.FileOldName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsMain);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IdUsingMode);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IsVisible);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.IndexNO);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.BrowseCount);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UpdDate);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.UpdUser);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.Memo);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel4Tea.CollegeNameA);
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
 /// v微格资源关系4Tea(vMicroteachCase_Resource_Rel4Tea)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachCase_Resource_Rel4Tea
{
public const string _CurrTabName = "vMicroteachCase_Resource_Rel4Tea"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IdDiscipline", "DisciplineID", "DisciplineName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "microteachCaseText", "OwnerId", "OwnerName", "TeacherID", "TeacherName", "IdXzCollege", "CollegeName", "EntryDate", "CollegeID", "EntryYear", "IsDualVideo", "UserTypeId", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo", "CollegeNameA"};
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
 /// 常量:"TeacherID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherID = "TeacherID";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"EntryDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryDate = "EntryDate";    //进校日期

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

 /// <summary>
 /// 常量:"EntryYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryYear = "EntryYear";    //EntryYear

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

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

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}