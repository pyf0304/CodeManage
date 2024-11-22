
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseSenateEN
 表名:vPubClassCaseSenate(01120410)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:46
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
 /// 表vPubClassCaseSenate的关键字(IdPubClassCaseSenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseSenate_vPubClassCaseSenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubClassCaseSenate">表关键字</param>
public K_IdPubClassCaseSenate_vPubClassCaseSenate(long lngIdPubClassCaseSenate)
{
if (IsValid(lngIdPubClassCaseSenate)) Value = lngIdPubClassCaseSenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubClassCaseSenate)
{
if (lngIdPubClassCaseSenate == 0) return false;
if (lngIdPubClassCaseSenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseSenate_vPubClassCaseSenate]类型的对象</returns>
public static implicit operator K_IdPubClassCaseSenate_vPubClassCaseSenate(long value)
{
return new K_IdPubClassCaseSenate_vPubClassCaseSenate(value);
}
}
 /// <summary>
 /// v公开课案例评议(vPubClassCaseSenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPubClassCaseSenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPubClassCaseSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 57;
public static string[] AttributeName = new string[] {"IdPubClassCaseSenate", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseDateIn", "PubClassCaseTeachDate", "PubClassCaseBG", "PubClassCaseTheme", "PubClassCaseExecutor", "DisciplineID", "DisciplineName", "StudyLevelName", "IsElite", "SubjectName", "ResourceID", "ResourceTypeID", "ResourceTypeName", "PubCaseTypeID", "PubCaseTypeName", "PubClassCaseSenateClassID", "PubClassCaseSenateClassName", "PubClassCaseSenator", "PubClassCaseSenateTitle", "PubClassCaseSenateContent", "PubClassCaseSenateDate", "PubClassCaseSenateTime", "SenateReadCount", "ResourceOwner", "ftpResourceOwner", "FileNewName", "FileOldName", "FileSize", "FileType", "FileName", "SaveTime", "IsVisual", "IdTeachingPlan", "IdFtpResource", "FileUpDate", "FileDirName", "FileOriginalName", "FtpResourceID", "FileRename", "FileUpTime", "SaveMode", "IdResourceType", "IdPubCaseType", "ftpFileType", "ftpFileSize", "FileOriginName", "IdResource", "IdDiscipline", "IdStudyLevel", "IdFile", "IsVisible", "SaveDate", "IdPubClassCaseSenateClass"};

protected long mlngIdPubClassCaseSenate;    //公开课案例评议流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrPubClassCaseID;    //案例ID
protected string mstrPubClassCaseName;    //案例课题名称
protected string mstrPubClassCaseDateIn;    //案例入库日期
protected string mstrPubClassCaseTeachDate;    //案例授课日期
protected string mstrPubClassCaseBG;    //案例背景资料
protected string mstrPubClassCaseTheme;    //案例主题词
protected string mstrPubClassCaseExecutor;    //案例执教者
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrStudyLevelName;    //学段名称
protected bool mbolIsElite;    //精华标志
protected string mstrSubjectName;    //课题名称
protected string mstrResourceID;    //资源ID
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrPubCaseTypeID;    //公开课案例类型ID
protected string mstrPubCaseTypeName;    //公开课案例类型名称
protected string mstrPubClassCaseSenateClassID;    //公开课案例评议类别ID
protected string mstrPubClassCaseSenateClassName;    //公开课案例评议类别名称
protected string mstrPubClassCaseSenator;    //公开课案例评议者
protected string mstrPubClassCaseSenateTitle;    //公开课案例评议标题
protected string mstrPubClassCaseSenateContent;    //公开课案例评议内容
protected string mstrPubClassCaseSenateDate;    //公开课案例评议日期
protected string mstrPubClassCaseSenateTime;    //公开课案例评议时间
protected int? mintSenateReadCount;    //评议阅读次数
protected string mstrResourceOwner;    //上传者
protected string mstrftpResourceOwner;    //Ftp资源拥有者
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名
protected string mstrFileSize;    //文件大小
protected string mstrFileType;    //文件类型
protected string mstrFileName;    //文件名称
protected string mstrSaveTime;    //创建时间
protected bool mbolIsVisual;    //隐藏标志
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFileUpDate;    //创建日期
protected string mstrFileDirName;    //文件目录名
protected string mstrFileOriginalName;    //文件原名
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileRename;    //文件新名
protected string mstrFileUpTime;    //创建时间
protected bool mbolSaveMode;    //文件存放方式
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrIdPubCaseType;    //公开课案例类型流水号
protected string mstrftpFileType;    //ftp文件类型
protected string mstrftpFileSize;    //ftp文件大小
protected string mstrFileOriginName;    //原文件名
protected string mstrIdResource;    //资源流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrIdFile;    //文件流水号
protected bool mbolIsVisible;    //是否显示
protected string mstrSaveDate;    //创建日期
protected string mstrIdPubClassCaseSenateClass;    //公开课案例评议类别流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPubClassCaseSenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseSenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubClassCaseSenate">关键字:公开课案例评议流水号</param>
public clsvPubClassCaseSenateEN(long lngIdPubClassCaseSenate)
 {
 if (lngIdPubClassCaseSenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubClassCaseSenate = lngIdPubClassCaseSenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseSenate");
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
if (strAttributeName  ==  convPubClassCaseSenate.IdPubClassCaseSenate)
{
return mlngIdPubClassCaseSenate;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseID)
{
return mstrPubClassCaseID;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseName)
{
return mstrPubClassCaseName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseDateIn)
{
return mstrPubClassCaseDateIn;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseTeachDate)
{
return mstrPubClassCaseTeachDate;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseBG)
{
return mstrPubClassCaseBG;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseTheme)
{
return mstrPubClassCaseTheme;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseExecutor)
{
return mstrPubClassCaseExecutor;
}
else if (strAttributeName  ==  convPubClassCaseSenate.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convPubClassCaseSenate.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IsElite)
{
return mbolIsElite;
}
else if (strAttributeName  ==  convPubClassCaseSenate.SubjectName)
{
return mstrSubjectName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convPubClassCaseSenate.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convPubClassCaseSenate.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubCaseTypeID)
{
return mstrPubCaseTypeID;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubCaseTypeName)
{
return mstrPubCaseTypeName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateClassID)
{
return mstrPubClassCaseSenateClassID;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateClassName)
{
return mstrPubClassCaseSenateClassName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenator)
{
return mstrPubClassCaseSenator;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateTitle)
{
return mstrPubClassCaseSenateTitle;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateContent)
{
return mstrPubClassCaseSenateContent;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateDate)
{
return mstrPubClassCaseSenateDate;
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateTime)
{
return mstrPubClassCaseSenateTime;
}
else if (strAttributeName  ==  convPubClassCaseSenate.SenateReadCount)
{
return mintSenateReadCount;
}
else if (strAttributeName  ==  convPubClassCaseSenate.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convPubClassCaseSenate.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IsVisual)
{
return mbolIsVisual;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convPubClassCaseSenate.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdPubCaseType)
{
return mstrIdPubCaseType;
}
else if (strAttributeName  ==  convPubClassCaseSenate.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convPubClassCaseSenate.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convPubClassCaseSenate.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdPubClassCaseSenateClass)
{
return mstrIdPubClassCaseSenateClass;
}
return null;
}
set
{
if (strAttributeName  ==  convPubClassCaseSenate.IdPubClassCaseSenate)
{
mlngIdPubClassCaseSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCaseSenate);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCase);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseID)
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseID);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseName)
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseDateIn)
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseDateIn);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseTeachDate)
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseTeachDate);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseBG)
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseBG);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseTheme)
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseTheme);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseExecutor)
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseExecutor);
}
else if (strAttributeName  ==  convPubClassCaseSenate.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.DisciplineID);
}
else if (strAttributeName  ==  convPubClassCaseSenate.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.DisciplineName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.StudyLevelName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IsElite)
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.IsElite);
}
else if (strAttributeName  ==  convPubClassCaseSenate.SubjectName)
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.SubjectName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ResourceID);
}
else if (strAttributeName  ==  convPubClassCaseSenate.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ResourceTypeID);
}
else if (strAttributeName  ==  convPubClassCaseSenate.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ResourceTypeName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubCaseTypeID)
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubCaseTypeID);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubCaseTypeName)
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubCaseTypeName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateClassID)
{
mstrPubClassCaseSenateClassID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateClassID);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateClassName)
{
mstrPubClassCaseSenateClassName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateClassName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenator)
{
mstrPubClassCaseSenator = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenator);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateTitle)
{
mstrPubClassCaseSenateTitle = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateTitle);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateContent)
{
mstrPubClassCaseSenateContent = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateContent);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateDate)
{
mstrPubClassCaseSenateDate = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateDate);
}
else if (strAttributeName  ==  convPubClassCaseSenate.PubClassCaseSenateTime)
{
mstrPubClassCaseSenateTime = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateTime);
}
else if (strAttributeName  ==  convPubClassCaseSenate.SenateReadCount)
{
mintSenateReadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.SenateReadCount);
}
else if (strAttributeName  ==  convPubClassCaseSenate.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ResourceOwner);
}
else if (strAttributeName  ==  convPubClassCaseSenate.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ftpResourceOwner);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileNewName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileOldName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileSize);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileType);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.SaveTime);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IsVisual)
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.IsVisual);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdTeachingPlan);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdFtpResource);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileUpDate);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileDirName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileOriginalName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FtpResourceID);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileRename);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileUpTime);
}
else if (strAttributeName  ==  convPubClassCaseSenate.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.SaveMode);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdResourceType);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdPubCaseType)
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdPubCaseType);
}
else if (strAttributeName  ==  convPubClassCaseSenate.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ftpFileType);
}
else if (strAttributeName  ==  convPubClassCaseSenate.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ftpFileSize);
}
else if (strAttributeName  ==  convPubClassCaseSenate.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileOriginName);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdResource);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdDiscipline);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdStudyLevel);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdFile);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.IsVisible);
}
else if (strAttributeName  ==  convPubClassCaseSenate.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.SaveDate);
}
else if (strAttributeName  ==  convPubClassCaseSenate.IdPubClassCaseSenateClass)
{
mstrIdPubClassCaseSenateClass = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCaseSenateClass);
}
}
}
public object this[int intIndex]
{
get
{
if (convPubClassCaseSenate.IdPubClassCaseSenate  ==  AttributeName[intIndex])
{
return mlngIdPubClassCaseSenate;
}
else if (convPubClassCaseSenate.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (convPubClassCaseSenate.PubClassCaseID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseID;
}
else if (convPubClassCaseSenate.PubClassCaseName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseName;
}
else if (convPubClassCaseSenate.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseDateIn;
}
else if (convPubClassCaseSenate.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTeachDate;
}
else if (convPubClassCaseSenate.PubClassCaseBG  ==  AttributeName[intIndex])
{
return mstrPubClassCaseBG;
}
else if (convPubClassCaseSenate.PubClassCaseTheme  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTheme;
}
else if (convPubClassCaseSenate.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
return mstrPubClassCaseExecutor;
}
else if (convPubClassCaseSenate.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convPubClassCaseSenate.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convPubClassCaseSenate.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convPubClassCaseSenate.IsElite  ==  AttributeName[intIndex])
{
return mbolIsElite;
}
else if (convPubClassCaseSenate.SubjectName  ==  AttributeName[intIndex])
{
return mstrSubjectName;
}
else if (convPubClassCaseSenate.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convPubClassCaseSenate.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convPubClassCaseSenate.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convPubClassCaseSenate.PubCaseTypeID  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeID;
}
else if (convPubClassCaseSenate.PubCaseTypeName  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeName;
}
else if (convPubClassCaseSenate.PubClassCaseSenateClassID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateClassID;
}
else if (convPubClassCaseSenate.PubClassCaseSenateClassName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateClassName;
}
else if (convPubClassCaseSenate.PubClassCaseSenator  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenator;
}
else if (convPubClassCaseSenate.PubClassCaseSenateTitle  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateTitle;
}
else if (convPubClassCaseSenate.PubClassCaseSenateContent  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateContent;
}
else if (convPubClassCaseSenate.PubClassCaseSenateDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateDate;
}
else if (convPubClassCaseSenate.PubClassCaseSenateTime  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateTime;
}
else if (convPubClassCaseSenate.SenateReadCount  ==  AttributeName[intIndex])
{
return mintSenateReadCount;
}
else if (convPubClassCaseSenate.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convPubClassCaseSenate.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convPubClassCaseSenate.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convPubClassCaseSenate.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convPubClassCaseSenate.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convPubClassCaseSenate.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convPubClassCaseSenate.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convPubClassCaseSenate.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convPubClassCaseSenate.IsVisual  ==  AttributeName[intIndex])
{
return mbolIsVisual;
}
else if (convPubClassCaseSenate.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convPubClassCaseSenate.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convPubClassCaseSenate.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convPubClassCaseSenate.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convPubClassCaseSenate.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convPubClassCaseSenate.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convPubClassCaseSenate.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convPubClassCaseSenate.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convPubClassCaseSenate.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convPubClassCaseSenate.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convPubClassCaseSenate.IdPubCaseType  ==  AttributeName[intIndex])
{
return mstrIdPubCaseType;
}
else if (convPubClassCaseSenate.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convPubClassCaseSenate.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convPubClassCaseSenate.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convPubClassCaseSenate.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convPubClassCaseSenate.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convPubClassCaseSenate.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convPubClassCaseSenate.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convPubClassCaseSenate.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convPubClassCaseSenate.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convPubClassCaseSenate.IdPubClassCaseSenateClass  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateClass;
}
return null;
}
set
{
if (convPubClassCaseSenate.IdPubClassCaseSenate  ==  AttributeName[intIndex])
{
mlngIdPubClassCaseSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCaseSenate);
}
else if (convPubClassCaseSenate.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCase);
}
else if (convPubClassCaseSenate.PubClassCaseID  ==  AttributeName[intIndex])
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseID);
}
else if (convPubClassCaseSenate.PubClassCaseName  ==  AttributeName[intIndex])
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseName);
}
else if (convPubClassCaseSenate.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseDateIn);
}
else if (convPubClassCaseSenate.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseTeachDate);
}
else if (convPubClassCaseSenate.PubClassCaseBG  ==  AttributeName[intIndex])
{
mstrPubClassCaseBG = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseBG);
}
else if (convPubClassCaseSenate.PubClassCaseTheme  ==  AttributeName[intIndex])
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseTheme);
}
else if (convPubClassCaseSenate.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseExecutor);
}
else if (convPubClassCaseSenate.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.DisciplineID);
}
else if (convPubClassCaseSenate.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.DisciplineName);
}
else if (convPubClassCaseSenate.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.StudyLevelName);
}
else if (convPubClassCaseSenate.IsElite  ==  AttributeName[intIndex])
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.IsElite);
}
else if (convPubClassCaseSenate.SubjectName  ==  AttributeName[intIndex])
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.SubjectName);
}
else if (convPubClassCaseSenate.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ResourceID);
}
else if (convPubClassCaseSenate.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ResourceTypeID);
}
else if (convPubClassCaseSenate.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ResourceTypeName);
}
else if (convPubClassCaseSenate.PubCaseTypeID  ==  AttributeName[intIndex])
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubCaseTypeID);
}
else if (convPubClassCaseSenate.PubCaseTypeName  ==  AttributeName[intIndex])
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubCaseTypeName);
}
else if (convPubClassCaseSenate.PubClassCaseSenateClassID  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateClassID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateClassID);
}
else if (convPubClassCaseSenate.PubClassCaseSenateClassName  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateClassName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateClassName);
}
else if (convPubClassCaseSenate.PubClassCaseSenator  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenator = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenator);
}
else if (convPubClassCaseSenate.PubClassCaseSenateTitle  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateTitle = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateTitle);
}
else if (convPubClassCaseSenate.PubClassCaseSenateContent  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateContent = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateContent);
}
else if (convPubClassCaseSenate.PubClassCaseSenateDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateDate = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateDate);
}
else if (convPubClassCaseSenate.PubClassCaseSenateTime  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateTime = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateTime);
}
else if (convPubClassCaseSenate.SenateReadCount  ==  AttributeName[intIndex])
{
mintSenateReadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.SenateReadCount);
}
else if (convPubClassCaseSenate.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ResourceOwner);
}
else if (convPubClassCaseSenate.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ftpResourceOwner);
}
else if (convPubClassCaseSenate.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileNewName);
}
else if (convPubClassCaseSenate.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileOldName);
}
else if (convPubClassCaseSenate.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileSize);
}
else if (convPubClassCaseSenate.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileType);
}
else if (convPubClassCaseSenate.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileName);
}
else if (convPubClassCaseSenate.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.SaveTime);
}
else if (convPubClassCaseSenate.IsVisual  ==  AttributeName[intIndex])
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.IsVisual);
}
else if (convPubClassCaseSenate.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdTeachingPlan);
}
else if (convPubClassCaseSenate.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdFtpResource);
}
else if (convPubClassCaseSenate.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileUpDate);
}
else if (convPubClassCaseSenate.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileDirName);
}
else if (convPubClassCaseSenate.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileOriginalName);
}
else if (convPubClassCaseSenate.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FtpResourceID);
}
else if (convPubClassCaseSenate.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileRename);
}
else if (convPubClassCaseSenate.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileUpTime);
}
else if (convPubClassCaseSenate.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.SaveMode);
}
else if (convPubClassCaseSenate.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdResourceType);
}
else if (convPubClassCaseSenate.IdPubCaseType  ==  AttributeName[intIndex])
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdPubCaseType);
}
else if (convPubClassCaseSenate.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ftpFileType);
}
else if (convPubClassCaseSenate.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.ftpFileSize);
}
else if (convPubClassCaseSenate.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.FileOriginName);
}
else if (convPubClassCaseSenate.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdResource);
}
else if (convPubClassCaseSenate.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdDiscipline);
}
else if (convPubClassCaseSenate.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdStudyLevel);
}
else if (convPubClassCaseSenate.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdFile);
}
else if (convPubClassCaseSenate.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenate.IsVisible);
}
else if (convPubClassCaseSenate.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.SaveDate);
}
else if (convPubClassCaseSenate.IdPubClassCaseSenateClass  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateClass = value.ToString();
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCaseSenateClass);
}
}
}

/// <summary>
/// 公开课案例评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubClassCaseSenate
{
get
{
return mlngIdPubClassCaseSenate;
}
set
{
 mlngIdPubClassCaseSenate = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCaseSenate);
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
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCase);
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
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseID);
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
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseName);
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
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseDateIn);
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
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseTeachDate);
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
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseBG);
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
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseTheme);
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
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseExecutor);
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
 AddUpdatedFld(convPubClassCaseSenate.DisciplineID);
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
 AddUpdatedFld(convPubClassCaseSenate.DisciplineName);
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
 AddUpdatedFld(convPubClassCaseSenate.StudyLevelName);
}
}
/// <summary>
/// 精华标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsElite
{
get
{
return mbolIsElite;
}
set
{
 mbolIsElite = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.IsElite);
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
 AddUpdatedFld(convPubClassCaseSenate.SubjectName);
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
 AddUpdatedFld(convPubClassCaseSenate.ResourceID);
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
 AddUpdatedFld(convPubClassCaseSenate.ResourceTypeID);
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
 AddUpdatedFld(convPubClassCaseSenate.ResourceTypeName);
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
 AddUpdatedFld(convPubClassCaseSenate.PubCaseTypeID);
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
 AddUpdatedFld(convPubClassCaseSenate.PubCaseTypeName);
}
}
/// <summary>
/// 公开课案例评议类别ID(说明:;字段类型:varchar;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateClassID
{
get
{
return mstrPubClassCaseSenateClassID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateClassID = value;
}
else
{
 mstrPubClassCaseSenateClassID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateClassID);
}
}
/// <summary>
/// 公开课案例评议类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateClassName
{
get
{
return mstrPubClassCaseSenateClassName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateClassName = value;
}
else
{
 mstrPubClassCaseSenateClassName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateClassName);
}
}
/// <summary>
/// 公开课案例评议者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenator
{
get
{
return mstrPubClassCaseSenator;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenator = value;
}
else
{
 mstrPubClassCaseSenator = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenator);
}
}
/// <summary>
/// 公开课案例评议标题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateTitle
{
get
{
return mstrPubClassCaseSenateTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateTitle = value;
}
else
{
 mstrPubClassCaseSenateTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateTitle);
}
}
/// <summary>
/// 公开课案例评议内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateContent
{
get
{
return mstrPubClassCaseSenateContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateContent = value;
}
else
{
 mstrPubClassCaseSenateContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateContent);
}
}
/// <summary>
/// 公开课案例评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateDate
{
get
{
return mstrPubClassCaseSenateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateDate = value;
}
else
{
 mstrPubClassCaseSenateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateDate);
}
}
/// <summary>
/// 公开课案例评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateTime
{
get
{
return mstrPubClassCaseSenateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateTime = value;
}
else
{
 mstrPubClassCaseSenateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.PubClassCaseSenateTime);
}
}
/// <summary>
/// 评议阅读次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SenateReadCount
{
get
{
return mintSenateReadCount;
}
set
{
 mintSenateReadCount = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.SenateReadCount);
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
 AddUpdatedFld(convPubClassCaseSenate.ResourceOwner);
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
 AddUpdatedFld(convPubClassCaseSenate.ftpResourceOwner);
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
 AddUpdatedFld(convPubClassCaseSenate.FileNewName);
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
 AddUpdatedFld(convPubClassCaseSenate.FileOldName);
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
 AddUpdatedFld(convPubClassCaseSenate.FileSize);
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
 AddUpdatedFld(convPubClassCaseSenate.FileType);
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
 AddUpdatedFld(convPubClassCaseSenate.FileName);
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
 AddUpdatedFld(convPubClassCaseSenate.SaveTime);
}
}
/// <summary>
/// 隐藏标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisual
{
get
{
return mbolIsVisual;
}
set
{
 mbolIsVisual = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.IsVisual);
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
 AddUpdatedFld(convPubClassCaseSenate.IdTeachingPlan);
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
 AddUpdatedFld(convPubClassCaseSenate.IdFtpResource);
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
 AddUpdatedFld(convPubClassCaseSenate.FileUpDate);
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
 AddUpdatedFld(convPubClassCaseSenate.FileDirName);
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
 AddUpdatedFld(convPubClassCaseSenate.FileOriginalName);
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
 AddUpdatedFld(convPubClassCaseSenate.FtpResourceID);
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
 AddUpdatedFld(convPubClassCaseSenate.FileRename);
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
 AddUpdatedFld(convPubClassCaseSenate.FileUpTime);
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
 AddUpdatedFld(convPubClassCaseSenate.SaveMode);
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
 AddUpdatedFld(convPubClassCaseSenate.IdResourceType);
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
 AddUpdatedFld(convPubClassCaseSenate.IdPubCaseType);
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
 AddUpdatedFld(convPubClassCaseSenate.ftpFileType);
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
 AddUpdatedFld(convPubClassCaseSenate.ftpFileSize);
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
 AddUpdatedFld(convPubClassCaseSenate.FileOriginName);
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
 AddUpdatedFld(convPubClassCaseSenate.IdResource);
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
 AddUpdatedFld(convPubClassCaseSenate.IdDiscipline);
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
 AddUpdatedFld(convPubClassCaseSenate.IdStudyLevel);
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
 AddUpdatedFld(convPubClassCaseSenate.IdFile);
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
 AddUpdatedFld(convPubClassCaseSenate.IsVisible);
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
 AddUpdatedFld(convPubClassCaseSenate.SaveDate);
}
}
/// <summary>
/// 公开课案例评议类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCaseSenateClass
{
get
{
return mstrIdPubClassCaseSenateClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCaseSenateClass = value;
}
else
{
 mstrIdPubClassCaseSenateClass = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenate.IdPubClassCaseSenateClass);
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
  return mlngIdPubClassCaseSenate.ToString();
 }
 }
}
 /// <summary>
 /// v公开课案例评议(vPubClassCaseSenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPubClassCaseSenate
{
public const string _CurrTabName = "vPubClassCaseSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseSenate", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseDateIn", "PubClassCaseTeachDate", "PubClassCaseBG", "PubClassCaseTheme", "PubClassCaseExecutor", "DisciplineID", "DisciplineName", "StudyLevelName", "IsElite", "SubjectName", "ResourceID", "ResourceTypeID", "ResourceTypeName", "PubCaseTypeID", "PubCaseTypeName", "PubClassCaseSenateClassID", "PubClassCaseSenateClassName", "PubClassCaseSenator", "PubClassCaseSenateTitle", "PubClassCaseSenateContent", "PubClassCaseSenateDate", "PubClassCaseSenateTime", "SenateReadCount", "ResourceOwner", "ftpResourceOwner", "FileNewName", "FileOldName", "FileSize", "FileType", "FileName", "SaveTime", "IsVisual", "IdTeachingPlan", "IdFtpResource", "FileUpDate", "FileDirName", "FileOriginalName", "FtpResourceID", "FileRename", "FileUpTime", "SaveMode", "IdResourceType", "IdPubCaseType", "ftpFileType", "ftpFileSize", "FileOriginName", "IdResource", "IdDiscipline", "IdStudyLevel", "IdFile", "IsVisible", "SaveDate", "IdPubClassCaseSenateClass"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseSenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenate = "IdPubClassCaseSenate";    //公开课案例评议流水号

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
 /// 常量:"PubClassCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseDateIn = "PubClassCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"PubClassCaseTeachDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTeachDate = "PubClassCaseTeachDate";    //案例授课日期

 /// <summary>
 /// 常量:"PubClassCaseBG"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseBG = "PubClassCaseBG";    //案例背景资料

 /// <summary>
 /// 常量:"PubClassCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTheme = "PubClassCaseTheme";    //案例主题词

 /// <summary>
 /// 常量:"PubClassCaseExecutor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseExecutor = "PubClassCaseExecutor";    //案例执教者

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
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

 /// <summary>
 /// 常量:"IsElite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsElite = "IsElite";    //精华标志

 /// <summary>
 /// 常量:"SubjectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubjectName = "SubjectName";    //课题名称

 /// <summary>
 /// 常量:"ResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceID = "ResourceID";    //资源ID

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
 /// 常量:"PubClassCaseSenateClassID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateClassID = "PubClassCaseSenateClassID";    //公开课案例评议类别ID

 /// <summary>
 /// 常量:"PubClassCaseSenateClassName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateClassName = "PubClassCaseSenateClassName";    //公开课案例评议类别名称

 /// <summary>
 /// 常量:"PubClassCaseSenator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenator = "PubClassCaseSenator";    //公开课案例评议者

 /// <summary>
 /// 常量:"PubClassCaseSenateTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateTitle = "PubClassCaseSenateTitle";    //公开课案例评议标题

 /// <summary>
 /// 常量:"PubClassCaseSenateContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateContent = "PubClassCaseSenateContent";    //公开课案例评议内容

 /// <summary>
 /// 常量:"PubClassCaseSenateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateDate = "PubClassCaseSenateDate";    //公开课案例评议日期

 /// <summary>
 /// 常量:"PubClassCaseSenateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateTime = "PubClassCaseSenateTime";    //公开课案例评议时间

 /// <summary>
 /// 常量:"SenateReadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateReadCount = "SenateReadCount";    //评议阅读次数

 /// <summary>
 /// 常量:"ResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceOwner = "ResourceOwner";    //上传者

 /// <summary>
 /// 常量:"ftpResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpResourceOwner = "ftpResourceOwner";    //Ftp资源拥有者

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
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"FileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileType = "FileType";    //文件类型

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"SaveTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveTime = "SaveTime";    //创建时间

 /// <summary>
 /// 常量:"IsVisual"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisual = "IsVisual";    //隐藏标志

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

 /// <summary>
 /// 常量:"FileUpDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileUpDate = "FileUpDate";    //创建日期

 /// <summary>
 /// 常量:"FileDirName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileDirName = "FileDirName";    //文件目录名

 /// <summary>
 /// 常量:"FileOriginalName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginalName = "FileOriginalName";    //文件原名

 /// <summary>
 /// 常量:"FtpResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpResourceID = "FtpResourceID";    //FTP资源ID

 /// <summary>
 /// 常量:"FileRename"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileRename = "FileRename";    //文件新名

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
 /// 常量:"IdPubCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubCaseType = "IdPubCaseType";    //公开课案例类型流水号

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
 /// 常量:"FileOriginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginName = "FileOriginName";    //原文件名

 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //id_StudyLevel

 /// <summary>
 /// 常量:"IdFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFile = "IdFile";    //文件流水号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"SaveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveDate = "SaveDate";    //创建日期

 /// <summary>
 /// 常量:"IdPubClassCaseSenateClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenateClass = "IdPubClassCaseSenateClass";    //公开课案例评议类别流水号
}

}