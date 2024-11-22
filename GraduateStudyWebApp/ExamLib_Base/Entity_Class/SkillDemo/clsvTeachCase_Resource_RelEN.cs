
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCase_Resource_RelEN
 表名:vTeachCase_Resource_Rel(01120426)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表vTeachCase_Resource_Rel的关键字(IdTeachCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachCaseResourceRel_vTeachCase_Resource_Rel
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdTeachCaseResourceRel">表关键字</param>
public K_IdTeachCaseResourceRel_vTeachCase_Resource_Rel(long lngIdTeachCaseResourceRel)
{
if (IsValid(lngIdTeachCaseResourceRel)) Value = lngIdTeachCaseResourceRel;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdTeachCaseResourceRel)
{
if (lngIdTeachCaseResourceRel == 0) return false;
if (lngIdTeachCaseResourceRel == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachCaseResourceRel_vTeachCase_Resource_Rel]类型的对象</returns>
public static implicit operator K_IdTeachCaseResourceRel_vTeachCase_Resource_Rel(long value)
{
return new K_IdTeachCaseResourceRel_vTeachCase_Resource_Rel(value);
}
}
 /// <summary>
 /// 案例与资源关系表视图(vTeachCase_Resource_Rel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeachCase_Resource_RelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeachCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 65;
public static string[] AttributeName = new string[] {"IdTeachCaseResourceRel", "IdTeachCase", "TeachCaseID", "TeachCaseName", "TeachCaseExecutor", "TeachCaseTheme", "TeachCaseBG", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "IdDiscipline", "DisciplineName", "IdStudyLevel", "StudyLevelName", "TeachCaseDateIn", "IdTeachingPlan", "TeachCaseTimeIn", "WorkUnit", "CDID", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "Memo", "IndexNO", "IsVisible", "BrowseCount", "CollegeNameA"};

protected long mlngIdTeachCaseResourceRel;    //案例与资源表系表流水号
protected string mstrIdTeachCase;    //案例流水号
protected string mstrTeachCaseID;    //案例ID
protected string mstrTeachCaseName;    //案例名称
protected string mstrTeachCaseExecutor;    //案例执教者
protected string mstrTeachCaseTheme;    //案例主题词
protected string mstrTeachCaseBG;    //案例背景资料
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrTeachSkillID;    //教学技能ID
protected string mstrSkillTypeName;    //技能类型名称
protected string mstrTeachSkillName;    //教学技能名称
protected string mstrTeachSkillTheory;    //教学技能理论阐述
protected string mstrTeachSkillOperMethod;    //教学技能实践操作方法
protected string mstrIdSkillType;    //技能类型流水号
protected string mstrSkillTypeID;    //技能类型ID
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineName;    //学科名称
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrTeachCaseDateIn;    //案例入库日期
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrTeachCaseTimeIn;    //案例入库时间
protected string mstrWorkUnit;    //工作单位
protected string mstrCDID;    //光盘编号
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
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
protected string mstrMemo;    //备注
protected int? mintIndexNO;    //序号
protected bool mbolIsVisible;    //是否显示
protected int? mintBrowseCount;    //浏览次数
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTeachCase_Resource_RelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCaseResourceRel");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdTeachCaseResourceRel">关键字:案例与资源表系表流水号</param>
public clsvTeachCase_Resource_RelEN(long lngIdTeachCaseResourceRel)
 {
 if (lngIdTeachCaseResourceRel  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdTeachCaseResourceRel = lngIdTeachCaseResourceRel;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCaseResourceRel");
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
if (strAttributeName  ==  convTeachCase_Resource_Rel.IdTeachCaseResourceRel)
{
return mlngIdTeachCaseResourceRel;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdTeachCase)
{
return mstrIdTeachCase;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseID)
{
return mstrTeachCaseID;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseName)
{
return mstrTeachCaseName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseExecutor)
{
return mstrTeachCaseExecutor;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseTheme)
{
return mstrTeachCaseTheme;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseBG)
{
return mstrTeachCaseBG;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseDateIn)
{
return mstrTeachCaseDateIn;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseTimeIn)
{
return mstrTeachCaseTimeIn;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.CDID)
{
return mstrCDID;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convTeachCase_Resource_Rel.IdTeachCaseResourceRel)
{
mlngIdTeachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachCaseResourceRel);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdTeachCase)
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachCase);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseID)
{
mstrTeachCaseID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseID);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseName)
{
mstrTeachCaseName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseExecutor)
{
mstrTeachCaseExecutor = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseExecutor);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseTheme)
{
mstrTeachCaseTheme = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseTheme);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseBG)
{
mstrTeachCaseBG = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseBG);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachSkill);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillID);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.SkillTypeName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillTheory);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdSkillType);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.SkillTypeID);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdDiscipline);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.DisciplineName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdStudyLevel);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.StudyLevelName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseDateIn)
{
mstrTeachCaseDateIn = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseDateIn);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachingPlan);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.TeachCaseTimeIn)
{
mstrTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseTimeIn);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.WorkUnit);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.CDID)
{
mstrCDID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.CDID);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IsDualVideo);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdXzCollege);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeID);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.RecommendedDegreeId);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.RecommendedDegreeName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.BrowseCount4Case);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdResource);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceID);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdFtpResource);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdFile);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileType);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveDate);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileSize);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveTime);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FtpResourceID);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOriginalName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileDirName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileRename);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileUpDate);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileUpTime);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveMode);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdResourceType);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceTypeID);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceTypeName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceOwner);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpFileType);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpFileSize);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpResourceOwner);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOriginName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IsExistFile);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileNewName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOldName);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IsMain);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.Memo);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IndexNO);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IsVisible);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.BrowseCount);
}
else if (strAttributeName  ==  convTeachCase_Resource_Rel.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeachCase_Resource_Rel.IdTeachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdTeachCaseResourceRel;
}
else if (convTeachCase_Resource_Rel.IdTeachCase  ==  AttributeName[intIndex])
{
return mstrIdTeachCase;
}
else if (convTeachCase_Resource_Rel.TeachCaseID  ==  AttributeName[intIndex])
{
return mstrTeachCaseID;
}
else if (convTeachCase_Resource_Rel.TeachCaseName  ==  AttributeName[intIndex])
{
return mstrTeachCaseName;
}
else if (convTeachCase_Resource_Rel.TeachCaseExecutor  ==  AttributeName[intIndex])
{
return mstrTeachCaseExecutor;
}
else if (convTeachCase_Resource_Rel.TeachCaseTheme  ==  AttributeName[intIndex])
{
return mstrTeachCaseTheme;
}
else if (convTeachCase_Resource_Rel.TeachCaseBG  ==  AttributeName[intIndex])
{
return mstrTeachCaseBG;
}
else if (convTeachCase_Resource_Rel.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convTeachCase_Resource_Rel.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convTeachCase_Resource_Rel.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convTeachCase_Resource_Rel.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convTeachCase_Resource_Rel.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convTeachCase_Resource_Rel.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convTeachCase_Resource_Rel.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convTeachCase_Resource_Rel.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convTeachCase_Resource_Rel.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convTeachCase_Resource_Rel.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convTeachCase_Resource_Rel.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convTeachCase_Resource_Rel.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convTeachCase_Resource_Rel.TeachCaseDateIn  ==  AttributeName[intIndex])
{
return mstrTeachCaseDateIn;
}
else if (convTeachCase_Resource_Rel.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convTeachCase_Resource_Rel.TeachCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrTeachCaseTimeIn;
}
else if (convTeachCase_Resource_Rel.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convTeachCase_Resource_Rel.CDID  ==  AttributeName[intIndex])
{
return mstrCDID;
}
else if (convTeachCase_Resource_Rel.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convTeachCase_Resource_Rel.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convTeachCase_Resource_Rel.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convTeachCase_Resource_Rel.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convTeachCase_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convTeachCase_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convTeachCase_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convTeachCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convTeachCase_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convTeachCase_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convTeachCase_Resource_Rel.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convTeachCase_Resource_Rel.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convTeachCase_Resource_Rel.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convTeachCase_Resource_Rel.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convTeachCase_Resource_Rel.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convTeachCase_Resource_Rel.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convTeachCase_Resource_Rel.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convTeachCase_Resource_Rel.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convTeachCase_Resource_Rel.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convTeachCase_Resource_Rel.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convTeachCase_Resource_Rel.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convTeachCase_Resource_Rel.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convTeachCase_Resource_Rel.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convTeachCase_Resource_Rel.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convTeachCase_Resource_Rel.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convTeachCase_Resource_Rel.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convTeachCase_Resource_Rel.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convTeachCase_Resource_Rel.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convTeachCase_Resource_Rel.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convTeachCase_Resource_Rel.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convTeachCase_Resource_Rel.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convTeachCase_Resource_Rel.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convTeachCase_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convTeachCase_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convTeachCase_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convTeachCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convTeachCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTeachCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convTeachCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convTeachCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convTeachCase_Resource_Rel.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convTeachCase_Resource_Rel.IdTeachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdTeachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachCaseResourceRel);
}
else if (convTeachCase_Resource_Rel.IdTeachCase  ==  AttributeName[intIndex])
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachCase);
}
else if (convTeachCase_Resource_Rel.TeachCaseID  ==  AttributeName[intIndex])
{
mstrTeachCaseID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseID);
}
else if (convTeachCase_Resource_Rel.TeachCaseName  ==  AttributeName[intIndex])
{
mstrTeachCaseName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseName);
}
else if (convTeachCase_Resource_Rel.TeachCaseExecutor  ==  AttributeName[intIndex])
{
mstrTeachCaseExecutor = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseExecutor);
}
else if (convTeachCase_Resource_Rel.TeachCaseTheme  ==  AttributeName[intIndex])
{
mstrTeachCaseTheme = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseTheme);
}
else if (convTeachCase_Resource_Rel.TeachCaseBG  ==  AttributeName[intIndex])
{
mstrTeachCaseBG = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseBG);
}
else if (convTeachCase_Resource_Rel.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachSkill);
}
else if (convTeachCase_Resource_Rel.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillID);
}
else if (convTeachCase_Resource_Rel.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.SkillTypeName);
}
else if (convTeachCase_Resource_Rel.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillName);
}
else if (convTeachCase_Resource_Rel.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillTheory);
}
else if (convTeachCase_Resource_Rel.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillOperMethod);
}
else if (convTeachCase_Resource_Rel.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdSkillType);
}
else if (convTeachCase_Resource_Rel.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.SkillTypeID);
}
else if (convTeachCase_Resource_Rel.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdDiscipline);
}
else if (convTeachCase_Resource_Rel.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.DisciplineName);
}
else if (convTeachCase_Resource_Rel.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdStudyLevel);
}
else if (convTeachCase_Resource_Rel.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.StudyLevelName);
}
else if (convTeachCase_Resource_Rel.TeachCaseDateIn  ==  AttributeName[intIndex])
{
mstrTeachCaseDateIn = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseDateIn);
}
else if (convTeachCase_Resource_Rel.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachingPlan);
}
else if (convTeachCase_Resource_Rel.TeachCaseTimeIn  ==  AttributeName[intIndex])
{
mstrTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseTimeIn);
}
else if (convTeachCase_Resource_Rel.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.WorkUnit);
}
else if (convTeachCase_Resource_Rel.CDID  ==  AttributeName[intIndex])
{
mstrCDID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.CDID);
}
else if (convTeachCase_Resource_Rel.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IsDualVideo);
}
else if (convTeachCase_Resource_Rel.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdXzCollege);
}
else if (convTeachCase_Resource_Rel.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeID);
}
else if (convTeachCase_Resource_Rel.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeName);
}
else if (convTeachCase_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.RecommendedDegreeId);
}
else if (convTeachCase_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.RecommendedDegreeName);
}
else if (convTeachCase_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.BrowseCount4Case);
}
else if (convTeachCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdResource);
}
else if (convTeachCase_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceID);
}
else if (convTeachCase_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceName);
}
else if (convTeachCase_Resource_Rel.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdFtpResource);
}
else if (convTeachCase_Resource_Rel.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdFile);
}
else if (convTeachCase_Resource_Rel.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileName);
}
else if (convTeachCase_Resource_Rel.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileType);
}
else if (convTeachCase_Resource_Rel.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveDate);
}
else if (convTeachCase_Resource_Rel.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileSize);
}
else if (convTeachCase_Resource_Rel.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveTime);
}
else if (convTeachCase_Resource_Rel.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FtpResourceID);
}
else if (convTeachCase_Resource_Rel.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOriginalName);
}
else if (convTeachCase_Resource_Rel.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileDirName);
}
else if (convTeachCase_Resource_Rel.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileRename);
}
else if (convTeachCase_Resource_Rel.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileUpDate);
}
else if (convTeachCase_Resource_Rel.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileUpTime);
}
else if (convTeachCase_Resource_Rel.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveMode);
}
else if (convTeachCase_Resource_Rel.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.IdResourceType);
}
else if (convTeachCase_Resource_Rel.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceTypeID);
}
else if (convTeachCase_Resource_Rel.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceTypeName);
}
else if (convTeachCase_Resource_Rel.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceOwner);
}
else if (convTeachCase_Resource_Rel.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpFileType);
}
else if (convTeachCase_Resource_Rel.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpFileSize);
}
else if (convTeachCase_Resource_Rel.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpResourceOwner);
}
else if (convTeachCase_Resource_Rel.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOriginName);
}
else if (convTeachCase_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IsExistFile);
}
else if (convTeachCase_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileNewName);
}
else if (convTeachCase_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOldName);
}
else if (convTeachCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IsMain);
}
else if (convTeachCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.Memo);
}
else if (convTeachCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IndexNO);
}
else if (convTeachCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.IsVisible);
}
else if (convTeachCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase_Resource_Rel.BrowseCount);
}
else if (convTeachCase_Resource_Rel.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeNameA);
}
}
}

/// <summary>
/// 案例与资源表系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdTeachCaseResourceRel
{
get
{
return mlngIdTeachCaseResourceRel;
}
set
{
 mlngIdTeachCaseResourceRel = value;
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachCaseResourceRel);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachCase
{
get
{
return mstrIdTeachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachCase = value;
}
else
{
 mstrIdTeachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachCase);
}
}
/// <summary>
/// 案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseID
{
get
{
return mstrTeachCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseID = value;
}
else
{
 mstrTeachCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseID);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseName
{
get
{
return mstrTeachCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseName = value;
}
else
{
 mstrTeachCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseName);
}
}
/// <summary>
/// 案例执教者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseExecutor
{
get
{
return mstrTeachCaseExecutor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseExecutor = value;
}
else
{
 mstrTeachCaseExecutor = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseExecutor);
}
}
/// <summary>
/// 案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseTheme
{
get
{
return mstrTeachCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseTheme = value;
}
else
{
 mstrTeachCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseTheme);
}
}
/// <summary>
/// 案例背景资料(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseBG
{
get
{
return mstrTeachCaseBG;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseBG = value;
}
else
{
 mstrTeachCaseBG = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseBG);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachSkill);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillID);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.SkillTypeName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillTheory);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachSkillOperMethod);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdSkillType);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.SkillTypeID);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdDiscipline);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.DisciplineName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdStudyLevel);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.StudyLevelName);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseDateIn
{
get
{
return mstrTeachCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseDateIn = value;
}
else
{
 mstrTeachCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseDateIn);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdTeachingPlan);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseTimeIn
{
get
{
return mstrTeachCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseTimeIn = value;
}
else
{
 mstrTeachCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase_Resource_Rel.TeachCaseTimeIn);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.WorkUnit);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.CDID);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IsDualVideo);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdXzCollege);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeID);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.RecommendedDegreeId);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.RecommendedDegreeName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.BrowseCount4Case);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdResource);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceID);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdFtpResource);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdFile);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileType);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveDate);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileSize);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveTime);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FtpResourceID);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOriginalName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileDirName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileRename);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileUpDate);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileUpTime);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.SaveMode);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IdResourceType);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceTypeID);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceTypeName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.ResourceOwner);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpFileType);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpFileSize);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.ftpResourceOwner);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOriginName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IsExistFile);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileNewName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.FileOldName);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IsMain);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.Memo);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IndexNO);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.IsVisible);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.BrowseCount);
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
 AddUpdatedFld(convTeachCase_Resource_Rel.CollegeNameA);
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
  return mlngIdTeachCaseResourceRel.ToString();
 }
 }
}
 /// <summary>
 /// 案例与资源关系表视图(vTeachCase_Resource_Rel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeachCase_Resource_Rel
{
public const string _CurrTabName = "vTeachCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachCaseResourceRel", "IdTeachCase", "TeachCaseID", "TeachCaseName", "TeachCaseExecutor", "TeachCaseTheme", "TeachCaseBG", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "IdDiscipline", "DisciplineName", "IdStudyLevel", "StudyLevelName", "TeachCaseDateIn", "IdTeachingPlan", "TeachCaseTimeIn", "WorkUnit", "CDID", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "Memo", "IndexNO", "IsVisible", "BrowseCount", "CollegeNameA"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachCaseResourceRel = "IdTeachCaseResourceRel";    //案例与资源表系表流水号

 /// <summary>
 /// 常量:"IdTeachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachCase = "IdTeachCase";    //案例流水号

 /// <summary>
 /// 常量:"TeachCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseID = "TeachCaseID";    //案例ID

 /// <summary>
 /// 常量:"TeachCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseName = "TeachCaseName";    //案例名称

 /// <summary>
 /// 常量:"TeachCaseExecutor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseExecutor = "TeachCaseExecutor";    //案例执教者

 /// <summary>
 /// 常量:"TeachCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseTheme = "TeachCaseTheme";    //案例主题词

 /// <summary>
 /// 常量:"TeachCaseBG"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseBG = "TeachCaseBG";    //案例背景资料

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
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

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
 /// 常量:"TeachCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseDateIn = "TeachCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"TeachCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseTimeIn = "TeachCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"WorkUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkUnit = "WorkUnit";    //工作单位

 /// <summary>
 /// 常量:"CDID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CDID = "CDID";    //光盘编号

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IndexNO"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IndexNO = "IndexNO";    //序号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}