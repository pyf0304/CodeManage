
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubTeachCaseRelaInfoEN
 表名:vPubTeachCaseRelaInfo(01120400)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:55
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
 /// 表vPubTeachCaseRelaInfo的关键字(IdPubTeachCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubTeachCaseRelaInfo_vPubTeachCaseRelaInfo
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubTeachCaseRelaInfo">表关键字</param>
public K_IdPubTeachCaseRelaInfo_vPubTeachCaseRelaInfo(long lngIdPubTeachCaseRelaInfo)
{
if (IsValid(lngIdPubTeachCaseRelaInfo)) Value = lngIdPubTeachCaseRelaInfo;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubTeachCaseRelaInfo)
{
if (lngIdPubTeachCaseRelaInfo == 0) return false;
if (lngIdPubTeachCaseRelaInfo == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubTeachCaseRelaInfo_vPubTeachCaseRelaInfo]类型的对象</returns>
public static implicit operator K_IdPubTeachCaseRelaInfo_vPubTeachCaseRelaInfo(long value)
{
return new K_IdPubTeachCaseRelaInfo_vPubTeachCaseRelaInfo(value);
}
}
 /// <summary>
 /// v公开课案例相关信息(vPubTeachCaseRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPubTeachCaseRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPubTeachCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 60;
public static string[] AttributeName = new string[] {"IdPubTeachCaseRelaInfo", "IsVisible", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "IdResource", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "IdPubTeachCaseRelaInfoType", "PubTeachCaseRelaInfoTypeID", "PubTeachCaseRelaInfoTypeName", "TeachingPlanType", "BrowseCount", "SimplePlanContent", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "IdDiscipline", "DisciplineID", "DisciplineName", "IdStudyLevel", "StudyLevelName", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "PubClassCaseTheme", "PubClassCaseBG", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdTeachingPlan", "Memo", "FileOriginName", "IsExistFile", "ResourceID", "FileNewName", "FileOldName"};

protected long mlngIdPubTeachCaseRelaInfo;    //公开课案例相关信息流水号
protected bool mbolIsVisible;    //是否显示
protected string mstrSubjectName;    //课题名称
protected string mstrTeachingPlanAuthor;    //教案撰写人
protected string mstrTeachingObject;    //教学目标
protected string mstrTeachingEmphases;    //教学重点
protected string mstrTeachingDifficulty;    //教学难点
protected string mstrTeachingTool;    //教学用具
protected string mstrTeachingProcess;    //教学过程
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected string mstrIdResource;    //资源流水号
protected bool mbolSaveMode;    //文件存放方式
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrIdPubCaseType;    //公开课案例类型流水号
protected string mstrPubCaseTypeID;    //公开课案例类型ID
protected string mstrPubCaseTypeName;    //公开课案例类型名称
protected string mstrIdPubTeachCaseRelaInfoType;    //公开课案例相关信息类型流水号
protected string mstrPubTeachCaseRelaInfoTypeID;    //公开课案例相关信息类型ID
protected string mstrPubTeachCaseRelaInfoTypeName;    //公开课案例相关信息类型名称
protected string mstrTeachingPlanType;    //教案类型
protected int? mintBrowseCount;    //浏览次数
protected string mstrSimplePlanContent;    //简案内容
protected string mstrResourceOwner;    //上传者
protected string mstrftpFileType;    //ftp文件类型
protected string mstrftpFileSize;    //ftp文件大小
protected string mstrftpResourceOwner;    //Ftp资源拥有者
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrIdFile;    //文件流水号
protected string mstrFileName;    //文件名称
protected string mstrFileType;    //文件类型
protected string mstrSaveDate;    //创建日期
protected string mstrFileSize;    //文件大小
protected string mstrSaveTime;    //创建时间
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrPubClassCaseID;    //案例ID
protected string mstrPubClassCaseName;    //案例课题名称
protected string mstrPubClassCaseExecutor;    //案例执教者
protected string mstrPubClassCaseTheme;    //案例主题词
protected string mstrPubClassCaseBG;    //案例背景资料
protected string mstrPubClassCaseTeachDate;    //案例授课日期
protected string mstrPubClassCaseDateIn;    //案例入库日期
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrMemo;    //备注
protected string mstrFileOriginName;    //原文件名
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrResourceID;    //资源ID
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPubTeachCaseRelaInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubTeachCaseRelaInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubTeachCaseRelaInfo">关键字:公开课案例相关信息流水号</param>
public clsvPubTeachCaseRelaInfoEN(long lngIdPubTeachCaseRelaInfo)
 {
 if (lngIdPubTeachCaseRelaInfo  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubTeachCaseRelaInfo = lngIdPubTeachCaseRelaInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubTeachCaseRelaInfo");
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
if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo)
{
return mlngIdPubTeachCaseRelaInfo;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SubjectName)
{
return mstrSubjectName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingPlanAuthor)
{
return mstrTeachingPlanAuthor;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingObject)
{
return mstrTeachingObject;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingEmphases)
{
return mstrTeachingEmphases;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingDifficulty)
{
return mstrTeachingDifficulty;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingTool)
{
return mstrTeachingTool;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingProcess)
{
return mstrTeachingProcess;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdPubCaseType)
{
return mstrIdPubCaseType;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubCaseTypeID)
{
return mstrPubCaseTypeID;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubCaseTypeName)
{
return mstrPubCaseTypeName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType)
{
return mstrIdPubTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID)
{
return mstrPubTeachCaseRelaInfoTypeID;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName)
{
return mstrPubTeachCaseRelaInfoTypeName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingPlanType)
{
return mstrTeachingPlanType;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SimplePlanContent)
{
return mstrSimplePlanContent;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseID)
{
return mstrPubClassCaseID;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseName)
{
return mstrPubClassCaseName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseExecutor)
{
return mstrPubClassCaseExecutor;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseTheme)
{
return mstrPubClassCaseTheme;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseBG)
{
return mstrPubClassCaseBG;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseTeachDate)
{
return mstrPubClassCaseTeachDate;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseDateIn)
{
return mstrPubClassCaseDateIn;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileOldName)
{
return mstrFileOldName;
}
return null;
}
set
{
if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo)
{
mlngIdPubTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.IsVisible);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SubjectName)
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.SubjectName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingPlanAuthor)
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingPlanAuthor);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingObject)
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingObject);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingEmphases)
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingEmphases);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingDifficulty)
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingDifficulty);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingTool)
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingTool);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingProcess)
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingProcess);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdFtpResource);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FtpResourceID);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOriginalName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileDirName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileRename);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileUpDate);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileUpTime);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdResource);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveMode);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdResourceType);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceTypeID);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceTypeName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdPubCaseType)
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubCaseType);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubCaseTypeID)
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubCaseTypeID);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubCaseTypeName)
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubCaseTypeName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType)
{
mstrIdPubTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID)
{
mstrPubTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName)
{
mstrPubTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.TeachingPlanType)
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingPlanType);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.BrowseCount);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SimplePlanContent)
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.SimplePlanContent);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceOwner);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpFileType);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpFileSize);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpResourceOwner);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdDiscipline);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.DisciplineID);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.DisciplineName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdStudyLevel);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.StudyLevelName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdFile);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileType);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveDate);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileSize);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveTime);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubClassCase);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseID)
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseID);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseName)
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseExecutor)
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseExecutor);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseTheme)
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseTheme);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseBG)
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseBG);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseTeachDate)
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.PubClassCaseDateIn)
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseDateIn);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdTeachingPlan);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.Memo);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOriginName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.IsExistFile);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceID);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileNewName);
}
else if (strAttributeName  ==  convPubTeachCaseRelaInfo.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOldName);
}
}
}
public object this[int intIndex]
{
get
{
if (convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdPubTeachCaseRelaInfo;
}
else if (convPubTeachCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convPubTeachCaseRelaInfo.SubjectName  ==  AttributeName[intIndex])
{
return mstrSubjectName;
}
else if (convPubTeachCaseRelaInfo.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
return mstrTeachingPlanAuthor;
}
else if (convPubTeachCaseRelaInfo.TeachingObject  ==  AttributeName[intIndex])
{
return mstrTeachingObject;
}
else if (convPubTeachCaseRelaInfo.TeachingEmphases  ==  AttributeName[intIndex])
{
return mstrTeachingEmphases;
}
else if (convPubTeachCaseRelaInfo.TeachingDifficulty  ==  AttributeName[intIndex])
{
return mstrTeachingDifficulty;
}
else if (convPubTeachCaseRelaInfo.TeachingTool  ==  AttributeName[intIndex])
{
return mstrTeachingTool;
}
else if (convPubTeachCaseRelaInfo.TeachingProcess  ==  AttributeName[intIndex])
{
return mstrTeachingProcess;
}
else if (convPubTeachCaseRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convPubTeachCaseRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convPubTeachCaseRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convPubTeachCaseRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convPubTeachCaseRelaInfo.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convPubTeachCaseRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convPubTeachCaseRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convPubTeachCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convPubTeachCaseRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convPubTeachCaseRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convPubTeachCaseRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convPubTeachCaseRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convPubTeachCaseRelaInfo.IdPubCaseType  ==  AttributeName[intIndex])
{
return mstrIdPubCaseType;
}
else if (convPubTeachCaseRelaInfo.PubCaseTypeID  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeID;
}
else if (convPubTeachCaseRelaInfo.PubCaseTypeName  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeName;
}
else if (convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdPubTeachCaseRelaInfoType;
}
else if (convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
return mstrPubTeachCaseRelaInfoTypeID;
}
else if (convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrPubTeachCaseRelaInfoTypeName;
}
else if (convPubTeachCaseRelaInfo.TeachingPlanType  ==  AttributeName[intIndex])
{
return mstrTeachingPlanType;
}
else if (convPubTeachCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convPubTeachCaseRelaInfo.SimplePlanContent  ==  AttributeName[intIndex])
{
return mstrSimplePlanContent;
}
else if (convPubTeachCaseRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convPubTeachCaseRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convPubTeachCaseRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convPubTeachCaseRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convPubTeachCaseRelaInfo.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convPubTeachCaseRelaInfo.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convPubTeachCaseRelaInfo.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convPubTeachCaseRelaInfo.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convPubTeachCaseRelaInfo.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convPubTeachCaseRelaInfo.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convPubTeachCaseRelaInfo.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convPubTeachCaseRelaInfo.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convPubTeachCaseRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convPubTeachCaseRelaInfo.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convPubTeachCaseRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convPubTeachCaseRelaInfo.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (convPubTeachCaseRelaInfo.PubClassCaseID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseID;
}
else if (convPubTeachCaseRelaInfo.PubClassCaseName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseName;
}
else if (convPubTeachCaseRelaInfo.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
return mstrPubClassCaseExecutor;
}
else if (convPubTeachCaseRelaInfo.PubClassCaseTheme  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTheme;
}
else if (convPubTeachCaseRelaInfo.PubClassCaseBG  ==  AttributeName[intIndex])
{
return mstrPubClassCaseBG;
}
else if (convPubTeachCaseRelaInfo.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTeachDate;
}
else if (convPubTeachCaseRelaInfo.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseDateIn;
}
else if (convPubTeachCaseRelaInfo.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convPubTeachCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPubTeachCaseRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convPubTeachCaseRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convPubTeachCaseRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convPubTeachCaseRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convPubTeachCaseRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
return null;
}
set
{
if (convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdPubTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo);
}
else if (convPubTeachCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.IsVisible);
}
else if (convPubTeachCaseRelaInfo.SubjectName  ==  AttributeName[intIndex])
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.SubjectName);
}
else if (convPubTeachCaseRelaInfo.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingPlanAuthor);
}
else if (convPubTeachCaseRelaInfo.TeachingObject  ==  AttributeName[intIndex])
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingObject);
}
else if (convPubTeachCaseRelaInfo.TeachingEmphases  ==  AttributeName[intIndex])
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingEmphases);
}
else if (convPubTeachCaseRelaInfo.TeachingDifficulty  ==  AttributeName[intIndex])
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingDifficulty);
}
else if (convPubTeachCaseRelaInfo.TeachingTool  ==  AttributeName[intIndex])
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingTool);
}
else if (convPubTeachCaseRelaInfo.TeachingProcess  ==  AttributeName[intIndex])
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingProcess);
}
else if (convPubTeachCaseRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdFtpResource);
}
else if (convPubTeachCaseRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FtpResourceID);
}
else if (convPubTeachCaseRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOriginalName);
}
else if (convPubTeachCaseRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileDirName);
}
else if (convPubTeachCaseRelaInfo.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileRename);
}
else if (convPubTeachCaseRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileUpDate);
}
else if (convPubTeachCaseRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileUpTime);
}
else if (convPubTeachCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdResource);
}
else if (convPubTeachCaseRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveMode);
}
else if (convPubTeachCaseRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdResourceType);
}
else if (convPubTeachCaseRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceTypeID);
}
else if (convPubTeachCaseRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceTypeName);
}
else if (convPubTeachCaseRelaInfo.IdPubCaseType  ==  AttributeName[intIndex])
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubCaseType);
}
else if (convPubTeachCaseRelaInfo.PubCaseTypeID  ==  AttributeName[intIndex])
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubCaseTypeID);
}
else if (convPubTeachCaseRelaInfo.PubCaseTypeName  ==  AttributeName[intIndex])
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubCaseTypeName);
}
else if (convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdPubTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
}
else if (convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
mstrPubTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
}
else if (convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrPubTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
}
else if (convPubTeachCaseRelaInfo.TeachingPlanType  ==  AttributeName[intIndex])
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingPlanType);
}
else if (convPubTeachCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.BrowseCount);
}
else if (convPubTeachCaseRelaInfo.SimplePlanContent  ==  AttributeName[intIndex])
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.SimplePlanContent);
}
else if (convPubTeachCaseRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceOwner);
}
else if (convPubTeachCaseRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpFileType);
}
else if (convPubTeachCaseRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpFileSize);
}
else if (convPubTeachCaseRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpResourceOwner);
}
else if (convPubTeachCaseRelaInfo.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdDiscipline);
}
else if (convPubTeachCaseRelaInfo.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.DisciplineID);
}
else if (convPubTeachCaseRelaInfo.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.DisciplineName);
}
else if (convPubTeachCaseRelaInfo.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdStudyLevel);
}
else if (convPubTeachCaseRelaInfo.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.StudyLevelName);
}
else if (convPubTeachCaseRelaInfo.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdFile);
}
else if (convPubTeachCaseRelaInfo.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileName);
}
else if (convPubTeachCaseRelaInfo.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileType);
}
else if (convPubTeachCaseRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveDate);
}
else if (convPubTeachCaseRelaInfo.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileSize);
}
else if (convPubTeachCaseRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveTime);
}
else if (convPubTeachCaseRelaInfo.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubClassCase);
}
else if (convPubTeachCaseRelaInfo.PubClassCaseID  ==  AttributeName[intIndex])
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseID);
}
else if (convPubTeachCaseRelaInfo.PubClassCaseName  ==  AttributeName[intIndex])
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseName);
}
else if (convPubTeachCaseRelaInfo.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseExecutor);
}
else if (convPubTeachCaseRelaInfo.PubClassCaseTheme  ==  AttributeName[intIndex])
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseTheme);
}
else if (convPubTeachCaseRelaInfo.PubClassCaseBG  ==  AttributeName[intIndex])
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseBG);
}
else if (convPubTeachCaseRelaInfo.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
}
else if (convPubTeachCaseRelaInfo.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseDateIn);
}
else if (convPubTeachCaseRelaInfo.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdTeachingPlan);
}
else if (convPubTeachCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.Memo);
}
else if (convPubTeachCaseRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOriginName);
}
else if (convPubTeachCaseRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubTeachCaseRelaInfo.IsExistFile);
}
else if (convPubTeachCaseRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceID);
}
else if (convPubTeachCaseRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileNewName);
}
else if (convPubTeachCaseRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOldName);
}
}
}

/// <summary>
/// 公开课案例相关信息流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubTeachCaseRelaInfo
{
get
{
return mlngIdPubTeachCaseRelaInfo;
}
set
{
 mlngIdPubTeachCaseRelaInfo = value;
//记录修改过的字段
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IsVisible);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.SubjectName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingPlanAuthor);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingObject);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingEmphases);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingDifficulty);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingTool);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingProcess);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdFtpResource);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FtpResourceID);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOriginalName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileDirName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileRename);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileUpDate);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileUpTime);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdResource);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveMode);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdResourceType);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceTypeID);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceTypeName);
}
}
/// <summary>
/// 公开课案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubCaseType
{
get
{
return mstrIdPubCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubCaseType = value;
}
else
{
 mstrIdPubCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubCaseType);
}
}
/// <summary>
/// 公开课案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeID
{
get
{
return mstrPubCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeID = value;
}
else
{
 mstrPubCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubCaseTypeID);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubCaseTypeName);
}
}
/// <summary>
/// 公开课案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubTeachCaseRelaInfoType
{
get
{
return mstrIdPubTeachCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubTeachCaseRelaInfoType = value;
}
else
{
 mstrIdPubTeachCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
}
}
/// <summary>
/// 公开课案例相关信息类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubTeachCaseRelaInfoTypeID
{
get
{
return mstrPubTeachCaseRelaInfoTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubTeachCaseRelaInfoTypeID = value;
}
else
{
 mstrPubTeachCaseRelaInfoTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
}
}
/// <summary>
/// 公开课案例相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubTeachCaseRelaInfoTypeName
{
get
{
return mstrPubTeachCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubTeachCaseRelaInfoTypeName = value;
}
else
{
 mstrPubTeachCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.TeachingPlanType);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.BrowseCount);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.SimplePlanContent);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceOwner);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpFileType);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpFileSize);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.ftpResourceOwner);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdDiscipline);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.DisciplineID);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.DisciplineName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdStudyLevel);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.StudyLevelName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdFile);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileType);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveDate);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileSize);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.SaveTime);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdPubClassCase);
}
}
/// <summary>
/// 案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseID
{
get
{
return mstrPubClassCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseID = value;
}
else
{
 mstrPubClassCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseID);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseExecutor);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseTheme);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseBG);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.PubClassCaseDateIn);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IdTeachingPlan);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.Memo);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOriginName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.IsExistFile);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.ResourceID);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileNewName);
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
 AddUpdatedFld(convPubTeachCaseRelaInfo.FileOldName);
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
  return mlngIdPubTeachCaseRelaInfo.ToString();
 }
 }
}
 /// <summary>
 /// v公开课案例相关信息(vPubTeachCaseRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPubTeachCaseRelaInfo
{
public const string _CurrTabName = "vPubTeachCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubTeachCaseRelaInfo", "IsVisible", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "IdResource", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "IdPubTeachCaseRelaInfoType", "PubTeachCaseRelaInfoTypeID", "PubTeachCaseRelaInfoTypeName", "TeachingPlanType", "BrowseCount", "SimplePlanContent", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "IdDiscipline", "DisciplineID", "DisciplineName", "IdStudyLevel", "StudyLevelName", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "PubClassCaseTheme", "PubClassCaseBG", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdTeachingPlan", "Memo", "FileOriginName", "IsExistFile", "ResourceID", "FileNewName", "FileOldName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubTeachCaseRelaInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubTeachCaseRelaInfo = "IdPubTeachCaseRelaInfo";    //公开课案例相关信息流水号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

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
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

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
 /// 常量:"IdPubCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubCaseType = "IdPubCaseType";    //公开课案例类型流水号

 /// <summary>
 /// 常量:"PubCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeID = "PubCaseTypeID";    //公开课案例类型ID

 /// <summary>
 /// 常量:"PubCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeName = "PubCaseTypeName";    //公开课案例类型名称

 /// <summary>
 /// 常量:"IdPubTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubTeachCaseRelaInfoType = "IdPubTeachCaseRelaInfoType";    //公开课案例相关信息类型流水号

 /// <summary>
 /// 常量:"PubTeachCaseRelaInfoTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubTeachCaseRelaInfoTypeID = "PubTeachCaseRelaInfoTypeID";    //公开课案例相关信息类型ID

 /// <summary>
 /// 常量:"PubTeachCaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubTeachCaseRelaInfoTypeName = "PubTeachCaseRelaInfoTypeName";    //公开课案例相关信息类型名称

 /// <summary>
 /// 常量:"TeachingPlanType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanType = "TeachingPlanType";    //教案类型

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"SimplePlanContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SimplePlanContent = "SimplePlanContent";    //简案内容

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
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"PubClassCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseID = "PubClassCaseID";    //案例ID

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
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"ResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceID = "ResourceID";    //资源ID

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
}

}