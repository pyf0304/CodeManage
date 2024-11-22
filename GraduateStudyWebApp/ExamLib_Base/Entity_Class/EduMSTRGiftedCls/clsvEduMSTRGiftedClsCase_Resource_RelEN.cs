
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCase_Resource_RelEN
 表名:vEduMSTRGiftedClsCase_Resource_Rel(01120431)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:27
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
 /// 表vEduMSTRGiftedClsCase_Resource_Rel的关键字(IdMicroteachCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseResourceRel_vEduMSTRGiftedClsCase_Resource_Rel
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
public K_IdMicroteachCaseResourceRel_vEduMSTRGiftedClsCase_Resource_Rel(long lngIdMicroteachCaseResourceRel)
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
 /// <returns>返回:[K_IdMicroteachCaseResourceRel_vEduMSTRGiftedClsCase_Resource_Rel]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseResourceRel_vEduMSTRGiftedClsCase_Resource_Rel(long value)
{
return new K_IdMicroteachCaseResourceRel_vEduMSTRGiftedClsCase_Resource_Rel(value);
}
}
 /// <summary>
 /// v教育硕士优课案例与资源关系(vEduMSTRGiftedClsCase_Resource_Rel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvEduMSTRGiftedClsCase_Resource_RelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vEduMSTRGiftedClsCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 93;
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseTheme", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTime", "EduMSTRGiftedClsCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "EduMSTRGiftedClsCaseTimeIn", "IdEduMSTRGiftedClsCaseType", "EduMSTRGiftedClsCaseTypeName", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "EduMSTRGiftedClsCaseText", "OwnerId", "StuName", "StuID", "SexDesc", "StuTypeID", "StuTypeDesc", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "StuCardNo", "EnrollmentDate", "IsDualVideo", "UserTypeId", "RecommendedDegreeId", "RecommendedDegreeName", "OwnerName", "OwnerNameWithId", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};

protected long mlngIdMicroteachCaseResourceRel;    //微格案例资源关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
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
protected string mstrEduMSTRGiftedClsCaseTypeName;    //教育硕士优课案例类型名称
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
protected string mstrEduMSTRGiftedClsCaseText;    //教育硕士优课案例文本
protected string mstrOwnerId;    //拥有者Id
protected string mstrStuName;    //姓名
protected string mstrStuID;    //学号
protected string mstrSexDesc;    //性别名称
protected string mstrStuTypeID;    //学生类别ID
protected string mstrStuTypeDesc;    //学生类别名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrStuCardNo;    //学生证号
protected string mstrEnrollmentDate;    //入校日期
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserTypeId;    //用户类型Id
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
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
 public clsvEduMSTRGiftedClsCase_Resource_RelEN()
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
public clsvEduMSTRGiftedClsCase_Resource_RelEN(long lngIdMicroteachCaseResourceRel)
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
if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel)
{
return mlngIdMicroteachCaseResourceRel;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase)
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID)
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName)
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme)
{
return mstrEduMSTRGiftedClsCaseTheme;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate)
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime)
{
return mstrEduMSTRGiftedClsCaseTime;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn)
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn)
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType)
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName)
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText)
{
return mstrEduMSTRGiftedClsCaseText;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID)
{
return mstrStuTypeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode)
{
return mstrIdUsingMode;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel)
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase)
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID)
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName)
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme)
{
mstrEduMSTRGiftedClsCaseTheme = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate)
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime)
{
mstrEduMSTRGiftedClsCaseTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn)
{
mstrEduMSTRGiftedClsCaseDateIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn)
{
mstrEduMSTRGiftedClsCaseTimeIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType)
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName)
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.VersionNo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText)
{
mstrEduMSTRGiftedClsCaseText = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SexDesc);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID)
{
mstrStuTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CollegeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.MajorName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdResource);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdFile);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileSize);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveTime);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileDirName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileRename);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveMode);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileNewName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOldName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsMain);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode)
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsVisible);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IndexNO);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UpdDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UpdUser);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCase_Resource_Rel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseResourceRel;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTheme;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTime;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDateIn;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTimeIn;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCaseType;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseText;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID  ==  AttributeName[intIndex])
{
return mstrStuTypeID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode  ==  AttributeName[intIndex])
{
return mstrIdUsingMode;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTheme = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDateIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTimeIn = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.VersionNo);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseText = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerId);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SexDesc);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID  ==  AttributeName[intIndex])
{
mstrStuTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CollegeName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.MajorName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdResource);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdFile);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileType);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveDate);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileSize);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveTime);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileDirName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileRename);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveMode);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileNewName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOldName);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsMain);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode  ==  AttributeName[intIndex])
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsVisible);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IndexNO);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UpdDate);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UpdUser);
}
else if (convEduMSTRGiftedClsCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.Memo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.VersionNo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SexDesc);
}
}
/// <summary>
/// 学生类别ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeID
{
get
{
return mstrStuTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeID = value;
}
else
{
 mstrStuTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CollegeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.MajorName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdResource);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdFile);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileSize);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveTime);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileDirName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileRename);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.SaveMode);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileNewName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.FileOldName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsMain);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IsVisible);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.IndexNO);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UpdDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.UpdUser);
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
 AddUpdatedFld(convEduMSTRGiftedClsCase_Resource_Rel.Memo);
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
 /// v教育硕士优课案例与资源关系(vEduMSTRGiftedClsCase_Resource_Rel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convEduMSTRGiftedClsCase_Resource_Rel
{
public const string _CurrTabName = "vEduMSTRGiftedClsCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseTheme", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTime", "EduMSTRGiftedClsCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "EduMSTRGiftedClsCaseTimeIn", "IdEduMSTRGiftedClsCaseType", "EduMSTRGiftedClsCaseTypeName", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "EduMSTRGiftedClsCaseText", "OwnerId", "StuName", "StuID", "SexDesc", "StuTypeID", "StuTypeDesc", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "StuCardNo", "EnrollmentDate", "IsDualVideo", "UserTypeId", "RecommendedDegreeId", "RecommendedDegreeName", "OwnerName", "OwnerNameWithId", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseResourceRel = "IdMicroteachCaseResourceRel";    //微格案例资源关系流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

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
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

 /// <summary>
 /// 常量:"StuTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeID = "StuTypeID";    //学生类别ID

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
 /// 常量:"StuCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuCardNo = "StuCardNo";    //学生证号

 /// <summary>
 /// 常量:"EnrollmentDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnrollmentDate = "EnrollmentDate";    //入校日期

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