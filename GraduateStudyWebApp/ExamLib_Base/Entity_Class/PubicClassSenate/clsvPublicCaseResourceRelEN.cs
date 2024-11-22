
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPublicCaseResourceRelEN
 表名:vPublicCaseResourceRel(01120406)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表vPublicCaseResourceRel的关键字(IdPubClassCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseResourceRel_vPublicCaseResourceRel
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubClassCaseResourceRel">表关键字</param>
public K_IdPubClassCaseResourceRel_vPublicCaseResourceRel(long lngIdPubClassCaseResourceRel)
{
if (IsValid(lngIdPubClassCaseResourceRel)) Value = lngIdPubClassCaseResourceRel;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubClassCaseResourceRel)
{
if (lngIdPubClassCaseResourceRel == 0) return false;
if (lngIdPubClassCaseResourceRel == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseResourceRel_vPublicCaseResourceRel]类型的对象</returns>
public static implicit operator K_IdPubClassCaseResourceRel_vPublicCaseResourceRel(long value)
{
return new K_IdPubClassCaseResourceRel_vPublicCaseResourceRel(value);
}
}
 /// <summary>
 /// vPublicCaseResourceRel(vPublicCaseResourceRel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPublicCaseResourceRelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPublicCaseResourceRel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 63;
public static string[] AttributeName = new string[] {"IdPubClassCaseResourceRel", "IdPubClassCase", "PubClassCaseName", "PubClassCaseExecutor", "PubClassCaseTheme", "PubClassCaseBG", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdDiscipline", "DisciplineID", "DisciplineName", "IdTeachingPlan", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "TeachingPlanType", "SimplePlanContent", "PubClassCaseTimeIn", "PubCaseTypeName", "IdStudyLevel", "StudyLevelName", "Introduction", "CaseIsVisible", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IndexNO", "Memo", "IsVisible", "BrowseCount"};

protected long mlngIdPubClassCaseResourceRel;    //案例与资源关系表流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrPubClassCaseName;    //案例课题名称
protected string mstrPubClassCaseExecutor;    //案例执教者
protected string mstrPubClassCaseTheme;    //案例主题词
protected string mstrPubClassCaseBG;    //案例背景资料
protected string mstrPubClassCaseTeachDate;    //案例授课日期
protected string mstrPubClassCaseDateIn;    //案例入库日期
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrSubjectName;    //课题名称
protected string mstrTeachingPlanAuthor;    //教案撰写人
protected string mstrTeachingObject;    //教学目标
protected string mstrTeachingEmphases;    //教学重点
protected string mstrTeachingDifficulty;    //教学难点
protected string mstrTeachingTool;    //教学用具
protected string mstrTeachingProcess;    //教学过程
protected string mstrTeachingPlanType;    //教案类型
protected string mstrSimplePlanContent;    //简案内容
protected string mstrPubClassCaseTimeIn;    //案例入库时间
protected string mstrPubCaseTypeName;    //公开课案例类型名称
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIntroduction;    //简要介绍
protected bool mbolCaseIsVisible;    //CaseIsVisible
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
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
protected int? mintIndexNO;    //序号
protected string mstrMemo;    //备注
protected bool mbolIsVisible;    //是否显示
protected int? mintBrowseCount;    //浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPublicCaseResourceRelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseResourceRel");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubClassCaseResourceRel">关键字:案例与资源关系表流水号</param>
public clsvPublicCaseResourceRelEN(long lngIdPubClassCaseResourceRel)
 {
 if (lngIdPubClassCaseResourceRel  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubClassCaseResourceRel = lngIdPubClassCaseResourceRel;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseResourceRel");
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
if (strAttributeName  ==  convPublicCaseResourceRel.IdPubClassCaseResourceRel)
{
return mlngIdPubClassCaseResourceRel;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseName)
{
return mstrPubClassCaseName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseExecutor)
{
return mstrPubClassCaseExecutor;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseTheme)
{
return mstrPubClassCaseTheme;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseBG)
{
return mstrPubClassCaseBG;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseTeachDate)
{
return mstrPubClassCaseTeachDate;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseDateIn)
{
return mstrPubClassCaseDateIn;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SubjectName)
{
return mstrSubjectName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingPlanAuthor)
{
return mstrTeachingPlanAuthor;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingObject)
{
return mstrTeachingObject;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingEmphases)
{
return mstrTeachingEmphases;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingDifficulty)
{
return mstrTeachingDifficulty;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingTool)
{
return mstrTeachingTool;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingProcess)
{
return mstrTeachingProcess;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingPlanType)
{
return mstrTeachingPlanType;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SimplePlanContent)
{
return mstrSimplePlanContent;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseTimeIn)
{
return mstrPubClassCaseTimeIn;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubCaseTypeName)
{
return mstrPubCaseTypeName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.Introduction)
{
return mstrIntroduction;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.CaseIsVisible)
{
return mbolCaseIsVisible;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convPublicCaseResourceRel.BrowseCount)
{
return mintBrowseCount;
}
return null;
}
set
{
if (strAttributeName  ==  convPublicCaseResourceRel.IdPubClassCaseResourceRel)
{
mlngIdPubClassCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IdPubClassCaseResourceRel);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdPubClassCase);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseName)
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseExecutor)
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseExecutor);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseTheme)
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTheme);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseBG)
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseBG);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseTeachDate)
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTeachDate);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseDateIn)
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseDateIn);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdDiscipline);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.DisciplineID);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.DisciplineName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdTeachingPlan);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SubjectName)
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.SubjectName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingPlanAuthor)
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingPlanAuthor);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingObject)
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingObject);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingEmphases)
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingEmphases);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingDifficulty)
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingDifficulty);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingTool)
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingTool);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingProcess)
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingProcess);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.TeachingPlanType)
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingPlanType);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SimplePlanContent)
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.SimplePlanContent);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubClassCaseTimeIn)
{
mstrPubClassCaseTimeIn = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTimeIn);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.PubCaseTypeName)
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubCaseTypeName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdStudyLevel);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.StudyLevelName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.Introduction)
{
mstrIntroduction = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.Introduction);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.CaseIsVisible)
{
mbolCaseIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.CaseIsVisible);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IsDualVideo);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.RecommendedDegreeId);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.RecommendedDegreeName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdResource);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceID);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdFtpResource);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdFile);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileType);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.SaveDate);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileSize);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.SaveTime);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FtpResourceID);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileOriginalName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileDirName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileRename);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileUpDate);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileUpTime);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.SaveMode);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdResourceType);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceTypeID);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceTypeName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceOwner);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ftpFileType);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ftpFileSize);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ftpResourceOwner);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileOriginName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IsExistFile);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileNewName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileOldName);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IsMain);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IndexNO);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.Memo);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IsVisible);
}
else if (strAttributeName  ==  convPublicCaseResourceRel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.BrowseCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convPublicCaseResourceRel.IdPubClassCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdPubClassCaseResourceRel;
}
else if (convPublicCaseResourceRel.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (convPublicCaseResourceRel.PubClassCaseName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseName;
}
else if (convPublicCaseResourceRel.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
return mstrPubClassCaseExecutor;
}
else if (convPublicCaseResourceRel.PubClassCaseTheme  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTheme;
}
else if (convPublicCaseResourceRel.PubClassCaseBG  ==  AttributeName[intIndex])
{
return mstrPubClassCaseBG;
}
else if (convPublicCaseResourceRel.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTeachDate;
}
else if (convPublicCaseResourceRel.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseDateIn;
}
else if (convPublicCaseResourceRel.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convPublicCaseResourceRel.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convPublicCaseResourceRel.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convPublicCaseResourceRel.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convPublicCaseResourceRel.SubjectName  ==  AttributeName[intIndex])
{
return mstrSubjectName;
}
else if (convPublicCaseResourceRel.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
return mstrTeachingPlanAuthor;
}
else if (convPublicCaseResourceRel.TeachingObject  ==  AttributeName[intIndex])
{
return mstrTeachingObject;
}
else if (convPublicCaseResourceRel.TeachingEmphases  ==  AttributeName[intIndex])
{
return mstrTeachingEmphases;
}
else if (convPublicCaseResourceRel.TeachingDifficulty  ==  AttributeName[intIndex])
{
return mstrTeachingDifficulty;
}
else if (convPublicCaseResourceRel.TeachingTool  ==  AttributeName[intIndex])
{
return mstrTeachingTool;
}
else if (convPublicCaseResourceRel.TeachingProcess  ==  AttributeName[intIndex])
{
return mstrTeachingProcess;
}
else if (convPublicCaseResourceRel.TeachingPlanType  ==  AttributeName[intIndex])
{
return mstrTeachingPlanType;
}
else if (convPublicCaseResourceRel.SimplePlanContent  ==  AttributeName[intIndex])
{
return mstrSimplePlanContent;
}
else if (convPublicCaseResourceRel.PubClassCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTimeIn;
}
else if (convPublicCaseResourceRel.PubCaseTypeName  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeName;
}
else if (convPublicCaseResourceRel.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convPublicCaseResourceRel.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convPublicCaseResourceRel.Introduction  ==  AttributeName[intIndex])
{
return mstrIntroduction;
}
else if (convPublicCaseResourceRel.CaseIsVisible  ==  AttributeName[intIndex])
{
return mbolCaseIsVisible;
}
else if (convPublicCaseResourceRel.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convPublicCaseResourceRel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convPublicCaseResourceRel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convPublicCaseResourceRel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convPublicCaseResourceRel.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convPublicCaseResourceRel.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convPublicCaseResourceRel.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convPublicCaseResourceRel.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convPublicCaseResourceRel.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convPublicCaseResourceRel.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convPublicCaseResourceRel.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convPublicCaseResourceRel.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convPublicCaseResourceRel.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convPublicCaseResourceRel.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convPublicCaseResourceRel.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convPublicCaseResourceRel.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convPublicCaseResourceRel.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convPublicCaseResourceRel.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convPublicCaseResourceRel.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convPublicCaseResourceRel.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convPublicCaseResourceRel.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convPublicCaseResourceRel.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convPublicCaseResourceRel.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convPublicCaseResourceRel.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convPublicCaseResourceRel.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convPublicCaseResourceRel.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convPublicCaseResourceRel.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convPublicCaseResourceRel.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convPublicCaseResourceRel.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convPublicCaseResourceRel.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convPublicCaseResourceRel.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convPublicCaseResourceRel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convPublicCaseResourceRel.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convPublicCaseResourceRel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPublicCaseResourceRel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convPublicCaseResourceRel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
return null;
}
set
{
if (convPublicCaseResourceRel.IdPubClassCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdPubClassCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IdPubClassCaseResourceRel);
}
else if (convPublicCaseResourceRel.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdPubClassCase);
}
else if (convPublicCaseResourceRel.PubClassCaseName  ==  AttributeName[intIndex])
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseName);
}
else if (convPublicCaseResourceRel.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseExecutor);
}
else if (convPublicCaseResourceRel.PubClassCaseTheme  ==  AttributeName[intIndex])
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTheme);
}
else if (convPublicCaseResourceRel.PubClassCaseBG  ==  AttributeName[intIndex])
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseBG);
}
else if (convPublicCaseResourceRel.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTeachDate);
}
else if (convPublicCaseResourceRel.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseDateIn);
}
else if (convPublicCaseResourceRel.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdDiscipline);
}
else if (convPublicCaseResourceRel.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.DisciplineID);
}
else if (convPublicCaseResourceRel.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.DisciplineName);
}
else if (convPublicCaseResourceRel.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdTeachingPlan);
}
else if (convPublicCaseResourceRel.SubjectName  ==  AttributeName[intIndex])
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.SubjectName);
}
else if (convPublicCaseResourceRel.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingPlanAuthor);
}
else if (convPublicCaseResourceRel.TeachingObject  ==  AttributeName[intIndex])
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingObject);
}
else if (convPublicCaseResourceRel.TeachingEmphases  ==  AttributeName[intIndex])
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingEmphases);
}
else if (convPublicCaseResourceRel.TeachingDifficulty  ==  AttributeName[intIndex])
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingDifficulty);
}
else if (convPublicCaseResourceRel.TeachingTool  ==  AttributeName[intIndex])
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingTool);
}
else if (convPublicCaseResourceRel.TeachingProcess  ==  AttributeName[intIndex])
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingProcess);
}
else if (convPublicCaseResourceRel.TeachingPlanType  ==  AttributeName[intIndex])
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.TeachingPlanType);
}
else if (convPublicCaseResourceRel.SimplePlanContent  ==  AttributeName[intIndex])
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.SimplePlanContent);
}
else if (convPublicCaseResourceRel.PubClassCaseTimeIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseTimeIn = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTimeIn);
}
else if (convPublicCaseResourceRel.PubCaseTypeName  ==  AttributeName[intIndex])
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.PubCaseTypeName);
}
else if (convPublicCaseResourceRel.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdStudyLevel);
}
else if (convPublicCaseResourceRel.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.StudyLevelName);
}
else if (convPublicCaseResourceRel.Introduction  ==  AttributeName[intIndex])
{
mstrIntroduction = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.Introduction);
}
else if (convPublicCaseResourceRel.CaseIsVisible  ==  AttributeName[intIndex])
{
mbolCaseIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.CaseIsVisible);
}
else if (convPublicCaseResourceRel.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IsDualVideo);
}
else if (convPublicCaseResourceRel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.RecommendedDegreeId);
}
else if (convPublicCaseResourceRel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.RecommendedDegreeName);
}
else if (convPublicCaseResourceRel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdResource);
}
else if (convPublicCaseResourceRel.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceID);
}
else if (convPublicCaseResourceRel.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceName);
}
else if (convPublicCaseResourceRel.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdFtpResource);
}
else if (convPublicCaseResourceRel.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdFile);
}
else if (convPublicCaseResourceRel.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileName);
}
else if (convPublicCaseResourceRel.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileType);
}
else if (convPublicCaseResourceRel.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.SaveDate);
}
else if (convPublicCaseResourceRel.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileSize);
}
else if (convPublicCaseResourceRel.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.SaveTime);
}
else if (convPublicCaseResourceRel.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FtpResourceID);
}
else if (convPublicCaseResourceRel.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileOriginalName);
}
else if (convPublicCaseResourceRel.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileDirName);
}
else if (convPublicCaseResourceRel.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileRename);
}
else if (convPublicCaseResourceRel.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileUpDate);
}
else if (convPublicCaseResourceRel.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileUpTime);
}
else if (convPublicCaseResourceRel.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.SaveMode);
}
else if (convPublicCaseResourceRel.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.IdResourceType);
}
else if (convPublicCaseResourceRel.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceTypeID);
}
else if (convPublicCaseResourceRel.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceTypeName);
}
else if (convPublicCaseResourceRel.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ResourceOwner);
}
else if (convPublicCaseResourceRel.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ftpFileType);
}
else if (convPublicCaseResourceRel.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ftpFileSize);
}
else if (convPublicCaseResourceRel.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.ftpResourceOwner);
}
else if (convPublicCaseResourceRel.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileOriginName);
}
else if (convPublicCaseResourceRel.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IsExistFile);
}
else if (convPublicCaseResourceRel.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileNewName);
}
else if (convPublicCaseResourceRel.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.FileOldName);
}
else if (convPublicCaseResourceRel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IsMain);
}
else if (convPublicCaseResourceRel.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IndexNO);
}
else if (convPublicCaseResourceRel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPublicCaseResourceRel.Memo);
}
else if (convPublicCaseResourceRel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.IsVisible);
}
else if (convPublicCaseResourceRel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPublicCaseResourceRel.BrowseCount);
}
}
}

/// <summary>
/// 案例与资源关系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubClassCaseResourceRel
{
get
{
return mlngIdPubClassCaseResourceRel;
}
set
{
 mlngIdPubClassCaseResourceRel = value;
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.IdPubClassCaseResourceRel);
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
 AddUpdatedFld(convPublicCaseResourceRel.IdPubClassCase);
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
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseName);
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
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseExecutor);
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
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTheme);
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
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseBG);
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
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTeachDate);
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
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseDateIn);
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
 AddUpdatedFld(convPublicCaseResourceRel.IdDiscipline);
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
 AddUpdatedFld(convPublicCaseResourceRel.DisciplineID);
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
 AddUpdatedFld(convPublicCaseResourceRel.DisciplineName);
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
 AddUpdatedFld(convPublicCaseResourceRel.IdTeachingPlan);
}
}
/// <summary>
/// 课题名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubjectName
{
get
{
return mstrSubjectName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubjectName = value;
}
else
{
 mstrSubjectName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.SubjectName);
}
}
/// <summary>
/// 教案撰写人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanAuthor
{
get
{
return mstrTeachingPlanAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanAuthor = value;
}
else
{
 mstrTeachingPlanAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.TeachingPlanAuthor);
}
}
/// <summary>
/// 教学目标(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingObject
{
get
{
return mstrTeachingObject;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingObject = value;
}
else
{
 mstrTeachingObject = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.TeachingObject);
}
}
/// <summary>
/// 教学重点(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingEmphases
{
get
{
return mstrTeachingEmphases;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingEmphases = value;
}
else
{
 mstrTeachingEmphases = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.TeachingEmphases);
}
}
/// <summary>
/// 教学难点(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingDifficulty
{
get
{
return mstrTeachingDifficulty;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingDifficulty = value;
}
else
{
 mstrTeachingDifficulty = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.TeachingDifficulty);
}
}
/// <summary>
/// 教学用具(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingTool
{
get
{
return mstrTeachingTool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingTool = value;
}
else
{
 mstrTeachingTool = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.TeachingTool);
}
}
/// <summary>
/// 教学过程(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingProcess
{
get
{
return mstrTeachingProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingProcess = value;
}
else
{
 mstrTeachingProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.TeachingProcess);
}
}
/// <summary>
/// 教案类型(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanType
{
get
{
return mstrTeachingPlanType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanType = value;
}
else
{
 mstrTeachingPlanType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.TeachingPlanType);
}
}
/// <summary>
/// 简案内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SimplePlanContent
{
get
{
return mstrSimplePlanContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSimplePlanContent = value;
}
else
{
 mstrSimplePlanContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.SimplePlanContent);
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
 AddUpdatedFld(convPublicCaseResourceRel.PubClassCaseTimeIn);
}
}
/// <summary>
/// 公开课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeName
{
get
{
return mstrPubCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeName = value;
}
else
{
 mstrPubCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.PubCaseTypeName);
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
 AddUpdatedFld(convPublicCaseResourceRel.IdStudyLevel);
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
 AddUpdatedFld(convPublicCaseResourceRel.StudyLevelName);
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
 AddUpdatedFld(convPublicCaseResourceRel.Introduction);
}
}
/// <summary>
/// CaseIsVisible(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool CaseIsVisible
{
get
{
return mbolCaseIsVisible;
}
set
{
 mbolCaseIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convPublicCaseResourceRel.CaseIsVisible);
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
 AddUpdatedFld(convPublicCaseResourceRel.IsDualVideo);
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
 AddUpdatedFld(convPublicCaseResourceRel.RecommendedDegreeId);
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
 AddUpdatedFld(convPublicCaseResourceRel.RecommendedDegreeName);
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
 AddUpdatedFld(convPublicCaseResourceRel.IdResource);
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
 AddUpdatedFld(convPublicCaseResourceRel.ResourceID);
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
 AddUpdatedFld(convPublicCaseResourceRel.ResourceName);
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
 AddUpdatedFld(convPublicCaseResourceRel.IdFtpResource);
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
 AddUpdatedFld(convPublicCaseResourceRel.IdFile);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileName);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileType);
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
 AddUpdatedFld(convPublicCaseResourceRel.SaveDate);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileSize);
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
 AddUpdatedFld(convPublicCaseResourceRel.SaveTime);
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
 AddUpdatedFld(convPublicCaseResourceRel.FtpResourceID);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileOriginalName);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileDirName);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileRename);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileUpDate);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileUpTime);
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
 AddUpdatedFld(convPublicCaseResourceRel.SaveMode);
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
 AddUpdatedFld(convPublicCaseResourceRel.IdResourceType);
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
 AddUpdatedFld(convPublicCaseResourceRel.ResourceTypeID);
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
 AddUpdatedFld(convPublicCaseResourceRel.ResourceTypeName);
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
 AddUpdatedFld(convPublicCaseResourceRel.ResourceOwner);
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
 AddUpdatedFld(convPublicCaseResourceRel.ftpFileType);
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
 AddUpdatedFld(convPublicCaseResourceRel.ftpFileSize);
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
 AddUpdatedFld(convPublicCaseResourceRel.ftpResourceOwner);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileOriginName);
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
 AddUpdatedFld(convPublicCaseResourceRel.IsExistFile);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileNewName);
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
 AddUpdatedFld(convPublicCaseResourceRel.FileOldName);
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
 AddUpdatedFld(convPublicCaseResourceRel.IsMain);
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
 AddUpdatedFld(convPublicCaseResourceRel.IndexNO);
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
 AddUpdatedFld(convPublicCaseResourceRel.Memo);
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
 AddUpdatedFld(convPublicCaseResourceRel.IsVisible);
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
 AddUpdatedFld(convPublicCaseResourceRel.BrowseCount);
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
  return mlngIdPubClassCaseResourceRel.ToString();
 }
 }
}
 /// <summary>
 /// vPublicCaseResourceRel(vPublicCaseResourceRel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPublicCaseResourceRel
{
public const string _CurrTabName = "vPublicCaseResourceRel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseResourceRel", "IdPubClassCase", "PubClassCaseName", "PubClassCaseExecutor", "PubClassCaseTheme", "PubClassCaseBG", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdDiscipline", "DisciplineID", "DisciplineName", "IdTeachingPlan", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "TeachingPlanType", "SimplePlanContent", "PubClassCaseTimeIn", "PubCaseTypeName", "IdStudyLevel", "StudyLevelName", "Introduction", "CaseIsVisible", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IndexNO", "Memo", "IsVisible", "BrowseCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseResourceRel = "IdPubClassCaseResourceRel";    //案例与资源关系表流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

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
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"SubjectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubjectName = "SubjectName";    //课题名称

 /// <summary>
 /// 常量:"TeachingPlanAuthor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanAuthor = "TeachingPlanAuthor";    //教案撰写人

 /// <summary>
 /// 常量:"TeachingObject"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingObject = "TeachingObject";    //教学目标

 /// <summary>
 /// 常量:"TeachingEmphases"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingEmphases = "TeachingEmphases";    //教学重点

 /// <summary>
 /// 常量:"TeachingDifficulty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingDifficulty = "TeachingDifficulty";    //教学难点

 /// <summary>
 /// 常量:"TeachingTool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingTool = "TeachingTool";    //教学用具

 /// <summary>
 /// 常量:"TeachingProcess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingProcess = "TeachingProcess";    //教学过程

 /// <summary>
 /// 常量:"TeachingPlanType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanType = "TeachingPlanType";    //教案类型

 /// <summary>
 /// 常量:"SimplePlanContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SimplePlanContent = "SimplePlanContent";    //简案内容

 /// <summary>
 /// 常量:"PubClassCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTimeIn = "PubClassCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"PubCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeName = "PubCaseTypeName";    //公开课案例类型名称

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
 /// 常量:"Introduction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Introduction = "Introduction";    //简要介绍

 /// <summary>
 /// 常量:"CaseIsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseIsVisible = "CaseIsVisible";    //CaseIsVisible

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
 /// 常量:"IndexNO"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IndexNO = "IndexNO";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
}

}