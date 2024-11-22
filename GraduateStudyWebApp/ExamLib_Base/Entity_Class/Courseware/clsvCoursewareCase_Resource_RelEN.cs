
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCase_Resource_RelEN
 表名:vCoursewareCase_Resource_Rel(01120433)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// 表vCoursewareCase_Resource_Rel的关键字(IdMicroteachCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseResourceRel_vCoursewareCase_Resource_Rel
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
public K_IdMicroteachCaseResourceRel_vCoursewareCase_Resource_Rel(long lngIdMicroteachCaseResourceRel)
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
 /// <returns>返回:[K_IdMicroteachCaseResourceRel_vCoursewareCase_Resource_Rel]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseResourceRel_vCoursewareCase_Resource_Rel(long value)
{
return new K_IdMicroteachCaseResourceRel_vCoursewareCase_Resource_Rel(value);
}
}
 /// <summary>
 /// v课件案例资源关系(vCoursewareCase_Resource_Rel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCoursewareCase_Resource_RelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCoursewareCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 104;
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "CoursewareCaseID", "CoursewareCaseName", "CoursewareCaseTheme", "IdCoursewareCaseType", "CoursewareCaseTypeName", "CoursewareCaseText", "CoursewareCaseDate", "CoursewareCaseTime", "CoursewareCaseDateIn", "CoursewareCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "OwnerId", "StuName", "StuID", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "UserKindId", "UserKindName", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};

protected long mlngIdMicroteachCaseResourceRel;    //微格案例资源关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrCoursewareCaseID;    //课件教学案例ID
protected string mstrCoursewareCaseName;    //课件教学案例名称
protected string mstrCoursewareCaseTheme;    //课件教学案例主题词
protected string mstrIdCoursewareCaseType;    //课件案例类型流水号
protected string mstrCoursewareCaseTypeName;    //课件案例类型名称
protected string mstrCoursewareCaseText;    //案例文本内容
protected string mstrCoursewareCaseDate;    //课件教学日期
protected string mstrCoursewareCaseTime;    //课件教学时间
protected string mstrCoursewareCaseDateIn;    //案例入库日期
protected string mstrCoursewareCaseTimeIn;    //案例入库时间
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdTeachingPlan;    //教案流水号
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
protected string mstrOwnerId;    //拥有者Id
protected string mstrStuName;    //姓名
protected string mstrStuID;    //学号
protected string mstrPoliticsName;    //政治面貌
protected string mstrSexDesc;    //性别名称
protected string mstrEthnicName;    //民族名称
protected string mstrUniZoneDesc;    //校区名称
protected string mstrStuTypeDesc;    //学生类别名称
protected string mstrIdXzCollege;    //学院流水号
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
protected string mstrIDCardNo;    //身份证号
protected string mstrStuCardNo;    //学生证号
protected string mstrLiveAddress;    //居住地址
protected string mstrHomePhone;    //住宅电话
protected string mstrEnrollmentDate;    //入校日期
protected string mstrPostCode;    //邮编
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrUserTypeId;    //用户类型Id
protected bool mbolIsDualVideo;    //是否双视频
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
 public clsvCoursewareCase_Resource_RelEN()
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
public clsvCoursewareCase_Resource_RelEN(long lngIdMicroteachCaseResourceRel)
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
if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel)
{
return mlngIdMicroteachCaseResourceRel;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseID)
{
return mstrCoursewareCaseID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseName)
{
return mstrCoursewareCaseName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseTheme)
{
return mstrCoursewareCaseTheme;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdCoursewareCaseType)
{
return mstrIdCoursewareCaseType;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseTypeName)
{
return mstrCoursewareCaseTypeName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseText)
{
return mstrCoursewareCaseText;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseDate)
{
return mstrCoursewareCaseDate;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseTime)
{
return mstrCoursewareCaseTime;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseDateIn)
{
return mstrCoursewareCaseDateIn;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn)
{
return mstrCoursewareCaseTimeIn;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IDCardNo)
{
return mstrIDCardNo;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdUsingMode)
{
return mstrIdUsingMode;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel)
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FuncModuleId);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FuncModuleName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdMicroteachCase);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseID)
{
mstrCoursewareCaseID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseName)
{
mstrCoursewareCaseName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseTheme)
{
mstrCoursewareCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTheme);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdCoursewareCaseType)
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdCoursewareCaseType);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseTypeName)
{
mstrCoursewareCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTypeName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseText)
{
mstrCoursewareCaseText = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseText);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseDate)
{
mstrCoursewareCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseDate);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseTime)
{
mstrCoursewareCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTime);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseDateIn)
{
mstrCoursewareCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseDateIn);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn)
{
mstrCoursewareCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdStudyLevel);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StudyLevelName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdTeachingPlan);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdCaseType);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdDiscipline);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.DisciplineID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.DisciplineName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.VersionNo);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdTeachSkill);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SkillTypeName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillTheory);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdSkillType);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SkillTypeID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CaseLevelId);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.OwnerId);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.PoliticsName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SexDesc);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.EthnicName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UniZoneDesc);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuTypeDesc);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdXzCollege);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CollegeName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CollegeNameA);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdXzMajor);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.MajorName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdGradeBase);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.GradeBaseName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdAdminCls);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.AdminClsId);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.AdminClsName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Birthday);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.NativePlace);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Duty);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IDCardNo)
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IDCardNo);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuCardNo);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.LiveAddress);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.HomePhone);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.EnrollmentDate);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.PostCode);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserKindId);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserKindName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserTypeId);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsDualVideo);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.RecommendedDegreeId);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.RecommendedDegreeName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.BrowseCount4Case);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdResource);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdFtpResource);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdFile);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileType);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveDate);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileSize);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveTime);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FtpResourceID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOriginalName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileDirName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileRename);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileUpDate);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileUpTime);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveMode);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdResourceType);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceTypeID);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceTypeName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceOwner);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpFileType);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpFileSize);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpResourceOwner);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOriginName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsExistFile);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileNewName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOldName);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsMain);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IdUsingMode)
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdUsingMode);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsVisible);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IndexNO);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.BrowseCount);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UpdDate);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UpdUser);
}
else if (strAttributeName  ==  convCoursewareCase_Resource_Rel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseResourceRel;
}
else if (convCoursewareCase_Resource_Rel.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCoursewareCase_Resource_Rel.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCoursewareCase_Resource_Rel.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseID  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseID;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseName;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseTheme  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTheme;
}
else if (convCoursewareCase_Resource_Rel.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareCaseType;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTypeName;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseText  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseText;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseDate  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseDate;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseTime  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTime;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseDateIn;
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTimeIn;
}
else if (convCoursewareCase_Resource_Rel.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convCoursewareCase_Resource_Rel.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convCoursewareCase_Resource_Rel.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convCoursewareCase_Resource_Rel.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convCoursewareCase_Resource_Rel.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convCoursewareCase_Resource_Rel.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convCoursewareCase_Resource_Rel.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convCoursewareCase_Resource_Rel.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convCoursewareCase_Resource_Rel.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convCoursewareCase_Resource_Rel.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convCoursewareCase_Resource_Rel.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convCoursewareCase_Resource_Rel.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convCoursewareCase_Resource_Rel.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convCoursewareCase_Resource_Rel.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convCoursewareCase_Resource_Rel.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convCoursewareCase_Resource_Rel.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convCoursewareCase_Resource_Rel.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convCoursewareCase_Resource_Rel.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convCoursewareCase_Resource_Rel.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convCoursewareCase_Resource_Rel.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCoursewareCase_Resource_Rel.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convCoursewareCase_Resource_Rel.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convCoursewareCase_Resource_Rel.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (convCoursewareCase_Resource_Rel.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convCoursewareCase_Resource_Rel.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (convCoursewareCase_Resource_Rel.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convCoursewareCase_Resource_Rel.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convCoursewareCase_Resource_Rel.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCoursewareCase_Resource_Rel.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCoursewareCase_Resource_Rel.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convCoursewareCase_Resource_Rel.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCoursewareCase_Resource_Rel.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCoursewareCase_Resource_Rel.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convCoursewareCase_Resource_Rel.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convCoursewareCase_Resource_Rel.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convCoursewareCase_Resource_Rel.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (convCoursewareCase_Resource_Rel.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (convCoursewareCase_Resource_Rel.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convCoursewareCase_Resource_Rel.NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (convCoursewareCase_Resource_Rel.Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (convCoursewareCase_Resource_Rel.IDCardNo  ==  AttributeName[intIndex])
{
return mstrIDCardNo;
}
else if (convCoursewareCase_Resource_Rel.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convCoursewareCase_Resource_Rel.LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (convCoursewareCase_Resource_Rel.HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (convCoursewareCase_Resource_Rel.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convCoursewareCase_Resource_Rel.PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (convCoursewareCase_Resource_Rel.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convCoursewareCase_Resource_Rel.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convCoursewareCase_Resource_Rel.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convCoursewareCase_Resource_Rel.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCoursewareCase_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convCoursewareCase_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convCoursewareCase_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convCoursewareCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convCoursewareCase_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convCoursewareCase_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convCoursewareCase_Resource_Rel.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convCoursewareCase_Resource_Rel.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convCoursewareCase_Resource_Rel.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convCoursewareCase_Resource_Rel.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convCoursewareCase_Resource_Rel.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convCoursewareCase_Resource_Rel.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convCoursewareCase_Resource_Rel.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convCoursewareCase_Resource_Rel.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convCoursewareCase_Resource_Rel.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convCoursewareCase_Resource_Rel.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convCoursewareCase_Resource_Rel.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convCoursewareCase_Resource_Rel.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convCoursewareCase_Resource_Rel.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convCoursewareCase_Resource_Rel.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convCoursewareCase_Resource_Rel.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convCoursewareCase_Resource_Rel.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convCoursewareCase_Resource_Rel.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convCoursewareCase_Resource_Rel.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convCoursewareCase_Resource_Rel.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convCoursewareCase_Resource_Rel.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convCoursewareCase_Resource_Rel.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convCoursewareCase_Resource_Rel.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convCoursewareCase_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convCoursewareCase_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convCoursewareCase_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convCoursewareCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convCoursewareCase_Resource_Rel.IdUsingMode  ==  AttributeName[intIndex])
{
return mstrIdUsingMode;
}
else if (convCoursewareCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convCoursewareCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convCoursewareCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCoursewareCase_Resource_Rel.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCoursewareCase_Resource_Rel.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCoursewareCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel);
}
else if (convCoursewareCase_Resource_Rel.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FuncModuleId);
}
else if (convCoursewareCase_Resource_Rel.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FuncModuleName);
}
else if (convCoursewareCase_Resource_Rel.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdMicroteachCase);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseID  ==  AttributeName[intIndex])
{
mstrCoursewareCaseID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseID);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseName);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseTheme  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTheme);
}
else if (convCoursewareCase_Resource_Rel.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdCoursewareCaseType);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseTypeName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTypeName);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseText  ==  AttributeName[intIndex])
{
mstrCoursewareCaseText = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseText);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseDate  ==  AttributeName[intIndex])
{
mstrCoursewareCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseDate);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseTime  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTime);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseDateIn  ==  AttributeName[intIndex])
{
mstrCoursewareCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseDateIn);
}
else if (convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn);
}
else if (convCoursewareCase_Resource_Rel.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdStudyLevel);
}
else if (convCoursewareCase_Resource_Rel.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StudyLevelName);
}
else if (convCoursewareCase_Resource_Rel.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdTeachingPlan);
}
else if (convCoursewareCase_Resource_Rel.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdCaseType);
}
else if (convCoursewareCase_Resource_Rel.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdDiscipline);
}
else if (convCoursewareCase_Resource_Rel.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.DisciplineID);
}
else if (convCoursewareCase_Resource_Rel.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.DisciplineName);
}
else if (convCoursewareCase_Resource_Rel.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionID);
}
else if (convCoursewareCase_Resource_Rel.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionName);
}
else if (convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore);
}
else if (convCoursewareCase_Resource_Rel.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.VersionNo);
}
else if (convCoursewareCase_Resource_Rel.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdTeachSkill);
}
else if (convCoursewareCase_Resource_Rel.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillID);
}
else if (convCoursewareCase_Resource_Rel.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SkillTypeName);
}
else if (convCoursewareCase_Resource_Rel.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillName);
}
else if (convCoursewareCase_Resource_Rel.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillTheory);
}
else if (convCoursewareCase_Resource_Rel.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillOperMethod);
}
else if (convCoursewareCase_Resource_Rel.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdSkillType);
}
else if (convCoursewareCase_Resource_Rel.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SkillTypeID);
}
else if (convCoursewareCase_Resource_Rel.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CaseLevelId);
}
else if (convCoursewareCase_Resource_Rel.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.OwnerId);
}
else if (convCoursewareCase_Resource_Rel.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuName);
}
else if (convCoursewareCase_Resource_Rel.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuID);
}
else if (convCoursewareCase_Resource_Rel.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.PoliticsName);
}
else if (convCoursewareCase_Resource_Rel.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SexDesc);
}
else if (convCoursewareCase_Resource_Rel.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.EthnicName);
}
else if (convCoursewareCase_Resource_Rel.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UniZoneDesc);
}
else if (convCoursewareCase_Resource_Rel.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuTypeDesc);
}
else if (convCoursewareCase_Resource_Rel.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdXzCollege);
}
else if (convCoursewareCase_Resource_Rel.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CollegeName);
}
else if (convCoursewareCase_Resource_Rel.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CollegeNameA);
}
else if (convCoursewareCase_Resource_Rel.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdXzMajor);
}
else if (convCoursewareCase_Resource_Rel.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.MajorName);
}
else if (convCoursewareCase_Resource_Rel.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdGradeBase);
}
else if (convCoursewareCase_Resource_Rel.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.GradeBaseName);
}
else if (convCoursewareCase_Resource_Rel.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdAdminCls);
}
else if (convCoursewareCase_Resource_Rel.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.AdminClsId);
}
else if (convCoursewareCase_Resource_Rel.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.AdminClsName);
}
else if (convCoursewareCase_Resource_Rel.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Birthday);
}
else if (convCoursewareCase_Resource_Rel.NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.NativePlace);
}
else if (convCoursewareCase_Resource_Rel.Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Duty);
}
else if (convCoursewareCase_Resource_Rel.IDCardNo  ==  AttributeName[intIndex])
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IDCardNo);
}
else if (convCoursewareCase_Resource_Rel.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuCardNo);
}
else if (convCoursewareCase_Resource_Rel.LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.LiveAddress);
}
else if (convCoursewareCase_Resource_Rel.HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.HomePhone);
}
else if (convCoursewareCase_Resource_Rel.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.EnrollmentDate);
}
else if (convCoursewareCase_Resource_Rel.PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.PostCode);
}
else if (convCoursewareCase_Resource_Rel.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserKindId);
}
else if (convCoursewareCase_Resource_Rel.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserKindName);
}
else if (convCoursewareCase_Resource_Rel.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserTypeId);
}
else if (convCoursewareCase_Resource_Rel.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsDualVideo);
}
else if (convCoursewareCase_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.RecommendedDegreeId);
}
else if (convCoursewareCase_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.RecommendedDegreeName);
}
else if (convCoursewareCase_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.BrowseCount4Case);
}
else if (convCoursewareCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdResource);
}
else if (convCoursewareCase_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceID);
}
else if (convCoursewareCase_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceName);
}
else if (convCoursewareCase_Resource_Rel.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdFtpResource);
}
else if (convCoursewareCase_Resource_Rel.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdFile);
}
else if (convCoursewareCase_Resource_Rel.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileName);
}
else if (convCoursewareCase_Resource_Rel.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileType);
}
else if (convCoursewareCase_Resource_Rel.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveDate);
}
else if (convCoursewareCase_Resource_Rel.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileSize);
}
else if (convCoursewareCase_Resource_Rel.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveTime);
}
else if (convCoursewareCase_Resource_Rel.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FtpResourceID);
}
else if (convCoursewareCase_Resource_Rel.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOriginalName);
}
else if (convCoursewareCase_Resource_Rel.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileDirName);
}
else if (convCoursewareCase_Resource_Rel.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileRename);
}
else if (convCoursewareCase_Resource_Rel.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileUpDate);
}
else if (convCoursewareCase_Resource_Rel.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileUpTime);
}
else if (convCoursewareCase_Resource_Rel.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveMode);
}
else if (convCoursewareCase_Resource_Rel.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdResourceType);
}
else if (convCoursewareCase_Resource_Rel.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceTypeID);
}
else if (convCoursewareCase_Resource_Rel.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceTypeName);
}
else if (convCoursewareCase_Resource_Rel.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceOwner);
}
else if (convCoursewareCase_Resource_Rel.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpFileType);
}
else if (convCoursewareCase_Resource_Rel.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpFileSize);
}
else if (convCoursewareCase_Resource_Rel.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpResourceOwner);
}
else if (convCoursewareCase_Resource_Rel.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOriginName);
}
else if (convCoursewareCase_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsExistFile);
}
else if (convCoursewareCase_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileNewName);
}
else if (convCoursewareCase_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOldName);
}
else if (convCoursewareCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsMain);
}
else if (convCoursewareCase_Resource_Rel.IdUsingMode  ==  AttributeName[intIndex])
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdUsingMode);
}
else if (convCoursewareCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsVisible);
}
else if (convCoursewareCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IndexNO);
}
else if (convCoursewareCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCase_Resource_Rel.BrowseCount);
}
else if (convCoursewareCase_Resource_Rel.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UpdDate);
}
else if (convCoursewareCase_Resource_Rel.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UpdUser);
}
else if (convCoursewareCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Memo);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FuncModuleId);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FuncModuleName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdMicroteachCase);
}
}
/// <summary>
/// 课件教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseID
{
get
{
return mstrCoursewareCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseID = value;
}
else
{
 mstrCoursewareCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseID);
}
}
/// <summary>
/// 课件教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseName
{
get
{
return mstrCoursewareCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseName = value;
}
else
{
 mstrCoursewareCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseName);
}
}
/// <summary>
/// 课件教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTheme
{
get
{
return mstrCoursewareCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTheme = value;
}
else
{
 mstrCoursewareCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTheme);
}
}
/// <summary>
/// 课件案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareCaseType
{
get
{
return mstrIdCoursewareCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareCaseType = value;
}
else
{
 mstrIdCoursewareCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdCoursewareCaseType);
}
}
/// <summary>
/// 课件案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTypeName
{
get
{
return mstrCoursewareCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTypeName = value;
}
else
{
 mstrCoursewareCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTypeName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseText
{
get
{
return mstrCoursewareCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseText = value;
}
else
{
 mstrCoursewareCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseText);
}
}
/// <summary>
/// 课件教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseDate
{
get
{
return mstrCoursewareCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseDate = value;
}
else
{
 mstrCoursewareCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseDate);
}
}
/// <summary>
/// 课件教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTime
{
get
{
return mstrCoursewareCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTime = value;
}
else
{
 mstrCoursewareCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseDateIn
{
get
{
return mstrCoursewareCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseDateIn = value;
}
else
{
 mstrCoursewareCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTimeIn
{
get
{
return mstrCoursewareCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTimeIn = value;
}
else
{
 mstrCoursewareCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdStudyLevel);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StudyLevelName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdTeachingPlan);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdCaseType);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdDiscipline);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.DisciplineID);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.DisciplineName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionID);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.VersionNo);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdTeachSkill);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillID);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SkillTypeName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillTheory);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.TeachSkillOperMethod);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdSkillType);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SkillTypeID);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CaseLevelId);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.OwnerId);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuID);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.PoliticsName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SexDesc);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.EthnicName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UniZoneDesc);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuTypeDesc);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdXzCollege);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CollegeName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.CollegeNameA);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdXzMajor);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.MajorName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdGradeBase);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.GradeBaseName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdAdminCls);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.AdminClsId);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.AdminClsName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Birthday);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.NativePlace);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Duty);
}
}
/// <summary>
/// 身份证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IDCardNo
{
get
{
return mstrIDCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIDCardNo = value;
}
else
{
 mstrIDCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IDCardNo);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.StuCardNo);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.LiveAddress);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.HomePhone);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.EnrollmentDate);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.PostCode);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserKindId);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserKindName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UserTypeId);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsDualVideo);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.RecommendedDegreeId);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.RecommendedDegreeName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.BrowseCount4Case);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdResource);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceID);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdFtpResource);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdFile);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileType);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveDate);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileSize);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveTime);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FtpResourceID);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOriginalName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileDirName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileRename);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileUpDate);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileUpTime);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.SaveMode);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdResourceType);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceTypeID);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceTypeName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ResourceOwner);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpFileType);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpFileSize);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.ftpResourceOwner);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOriginName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsExistFile);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileNewName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.FileOldName);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsMain);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IdUsingMode);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IsVisible);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.IndexNO);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.BrowseCount);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UpdDate);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.UpdUser);
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
 AddUpdatedFld(convCoursewareCase_Resource_Rel.Memo);
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
 /// v课件案例资源关系(vCoursewareCase_Resource_Rel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCoursewareCase_Resource_Rel
{
public const string _CurrTabName = "vCoursewareCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "CoursewareCaseID", "CoursewareCaseName", "CoursewareCaseTheme", "IdCoursewareCaseType", "CoursewareCaseTypeName", "CoursewareCaseText", "CoursewareCaseDate", "CoursewareCaseTime", "CoursewareCaseDateIn", "CoursewareCaseTimeIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "IdCaseType", "IdDiscipline", "DisciplineID", "DisciplineName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "CaseLevelId", "OwnerId", "StuName", "StuID", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsId", "AdminClsName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "UserKindId", "UserKindName", "UserTypeId", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"CoursewareCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseID = "CoursewareCaseID";    //课件教学案例ID

 /// <summary>
 /// 常量:"CoursewareCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseName = "CoursewareCaseName";    //课件教学案例名称

 /// <summary>
 /// 常量:"CoursewareCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTheme = "CoursewareCaseTheme";    //课件教学案例主题词

 /// <summary>
 /// 常量:"IdCoursewareCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareCaseType = "IdCoursewareCaseType";    //课件案例类型流水号

 /// <summary>
 /// 常量:"CoursewareCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTypeName = "CoursewareCaseTypeName";    //课件案例类型名称

 /// <summary>
 /// 常量:"CoursewareCaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseText = "CoursewareCaseText";    //案例文本内容

 /// <summary>
 /// 常量:"CoursewareCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseDate = "CoursewareCaseDate";    //课件教学日期

 /// <summary>
 /// 常量:"CoursewareCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTime = "CoursewareCaseTime";    //课件教学时间

 /// <summary>
 /// 常量:"CoursewareCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseDateIn = "CoursewareCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CoursewareCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTimeIn = "CoursewareCaseTimeIn";    //案例入库时间

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
 /// 常量:"IDCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IDCardNo = "IDCardNo";    //身份证号

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