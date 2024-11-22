
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseSiteSenateEN
 表名:vMicroteachCaseSiteSenate(01120457)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:01
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
 /// 表vMicroteachCaseSiteSenate的关键字(IdMicroteachCaseSiteSenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseSiteSenate_vMicroteachCaseSiteSenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroteachCaseSiteSenate">表关键字</param>
public K_IdMicroteachCaseSiteSenate_vMicroteachCaseSiteSenate(long lngIdMicroteachCaseSiteSenate)
{
if (IsValid(lngIdMicroteachCaseSiteSenate)) Value = lngIdMicroteachCaseSiteSenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroteachCaseSiteSenate)
{
if (lngIdMicroteachCaseSiteSenate == 0) return false;
if (lngIdMicroteachCaseSiteSenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachCaseSiteSenate_vMicroteachCaseSiteSenate]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseSiteSenate_vMicroteachCaseSiteSenate(long value)
{
return new K_IdMicroteachCaseSiteSenate_vMicroteachCaseSiteSenate(value);
}
}
 /// <summary>
 /// v微格教学现场评议(vMicroteachCaseSiteSenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachCaseSiteSenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachCaseSiteSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseSiteSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 78;
public static string[] AttributeName = new string[] {"IdMicroteachCaseSiteSenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IsVisible", "microteachCaseText", "OwnerId", "StuName", "StuID", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "BrowseCount4Case", "IdMicroteachCaseSiteSenateType", "MicroteachCaseSiteSenateTypeID", "MicroteachCaseSiteSenateTypeName", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "SiteSenateSenator", "SiteSenateTitle", "SiteSenateContent", "SiteSenateData", "SiteSenateTime", "SiteSenateReadCount", "Memo"};

protected long mlngIdMicroteachCaseSiteSenate;    //微格现场评议流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
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
protected bool mbolIsVisible;    //是否显示
protected string mstrmicroteachCaseText;    //案例文本内容
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
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrBirthday;    //出生日期
protected string mstrNativePlace;    //籍贯
protected string mstrDuty;    //职位
protected string mstrIDCardNo;    //身份证号
protected string mstrStuCardNo;    //学生证号
protected string mstrLiveAddress;    //居住地址
protected string mstrHomePhone;    //住宅电话
protected string mstrEnrollmentDate;    //入校日期
protected string mstrPostCode;    //邮编
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrIdMicroteachCaseSiteSenateType;    //微格现场评价类型流水号
protected string mstrMicroteachCaseSiteSenateTypeID;    //微格现场评价类型ID
protected string mstrMicroteachCaseSiteSenateTypeName;    //微格现场评价类型名称
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
protected string mstrSiteSenateSenator;    //评议者
protected string mstrSiteSenateTitle;    //评议名称
protected string mstrSiteSenateContent;    //现场评议内容
protected string mstrSiteSenateData;    //现场评议日期
protected string mstrSiteSenateTime;    //现场评议时间
protected int? mintSiteSenateReadCount;    //现场评议阅读次数
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachCaseSiteSenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseSiteSenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroteachCaseSiteSenate">关键字:微格现场评议流水号</param>
public clsvMicroteachCaseSiteSenateEN(long lngIdMicroteachCaseSiteSenate)
 {
 if (lngIdMicroteachCaseSiteSenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroteachCaseSiteSenate = lngIdMicroteachCaseSiteSenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseSiteSenate");
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
if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate)
{
return mlngIdMicroteachCaseSiteSenate;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseID)
{
return mstrMicroteachCaseID;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseName)
{
return mstrMicroteachCaseName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseTheme)
{
return mstrMicroteachCaseTheme;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseDate)
{
return mstrMicroteachCaseDate;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseTime)
{
return mstrMicroteachCaseTime;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseDateIn)
{
return mstrMicroteachCaseDateIn;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn)
{
return mstrMicroTeachCaseTimeIn;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.microteachCaseText)
{
return mstrmicroteachCaseText;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IDCardNo)
{
return mstrIDCardNo;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType)
{
return mstrIdMicroteachCaseSiteSenateType;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID)
{
return mstrMicroteachCaseSiteSenateTypeID;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName)
{
return mstrMicroteachCaseSiteSenateTypeName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateSenator)
{
return mstrSiteSenateSenator;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateTitle)
{
return mstrSiteSenateTitle;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateContent)
{
return mstrSiteSenateContent;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateData)
{
return mstrSiteSenateData;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateTime)
{
return mstrSiteSenateTime;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateReadCount)
{
return mintSiteSenateReadCount;
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate)
{
mlngIdMicroteachCaseSiteSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FuncModuleId);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FuncModuleName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseID)
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseID);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseName)
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseTheme)
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseTheme);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseDate)
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseDate);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseTime)
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseTime);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseDateIn)
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdStudyLevel);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StudyLevelName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdTeachingPlan);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn)
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.IsVisible);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.microteachCaseText)
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.microteachCaseText);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.OwnerId);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuID);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.PoliticsName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SexDesc);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.EthnicName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.UniZoneDesc);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuTypeDesc);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdXzCollege);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.CollegeName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdXzMajor);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MajorName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdGradeBase);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.GradeBaseName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.Birthday);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.NativePlace);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.Duty);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IDCardNo)
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IDCardNo);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuCardNo);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.LiveAddress);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.HomePhone);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.EnrollmentDate);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.PostCode);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.BrowseCount4Case);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType)
{
mstrIdMicroteachCaseSiteSenateType = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID)
{
mstrMicroteachCaseSiteSenateTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName)
{
mstrMicroteachCaseSiteSenateTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdResource);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceID);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdFtpResource);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdFile);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileType);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveDate);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileSize);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveTime);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FtpResourceID);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOriginalName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileDirName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileRename);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileUpDate);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileUpTime);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveMode);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdResourceType);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceTypeID);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceTypeName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceOwner);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpFileType);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpFileSize);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpResourceOwner);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOriginName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.IsExistFile);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileNewName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOldName);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateSenator)
{
mstrSiteSenateSenator = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateSenator);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateTitle)
{
mstrSiteSenateTitle = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateTitle);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateContent)
{
mstrSiteSenateContent = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateContent);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateData)
{
mstrSiteSenateData = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateData);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateTime)
{
mstrSiteSenateTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateTime);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.SiteSenateReadCount)
{
mintSiteSenateReadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateReadCount);
}
else if (strAttributeName  ==  convMicroteachCaseSiteSenate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseSiteSenate;
}
else if (convMicroteachCaseSiteSenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convMicroteachCaseSiteSenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convMicroteachCaseSiteSenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseID;
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseName;
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTheme;
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseDate  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDate;
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseTime  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTime;
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDateIn;
}
else if (convMicroteachCaseSiteSenate.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convMicroteachCaseSiteSenate.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convMicroteachCaseSiteSenate.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseTimeIn;
}
else if (convMicroteachCaseSiteSenate.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convMicroteachCaseSiteSenate.microteachCaseText  ==  AttributeName[intIndex])
{
return mstrmicroteachCaseText;
}
else if (convMicroteachCaseSiteSenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convMicroteachCaseSiteSenate.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convMicroteachCaseSiteSenate.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convMicroteachCaseSiteSenate.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (convMicroteachCaseSiteSenate.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convMicroteachCaseSiteSenate.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (convMicroteachCaseSiteSenate.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convMicroteachCaseSiteSenate.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convMicroteachCaseSiteSenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convMicroteachCaseSiteSenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convMicroteachCaseSiteSenate.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convMicroteachCaseSiteSenate.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convMicroteachCaseSiteSenate.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convMicroteachCaseSiteSenate.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convMicroteachCaseSiteSenate.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convMicroteachCaseSiteSenate.NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (convMicroteachCaseSiteSenate.Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (convMicroteachCaseSiteSenate.IDCardNo  ==  AttributeName[intIndex])
{
return mstrIDCardNo;
}
else if (convMicroteachCaseSiteSenate.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convMicroteachCaseSiteSenate.LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (convMicroteachCaseSiteSenate.HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (convMicroteachCaseSiteSenate.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convMicroteachCaseSiteSenate.PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (convMicroteachCaseSiteSenate.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCaseSiteSenateType;
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseSiteSenateTypeID;
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseSiteSenateTypeName;
}
else if (convMicroteachCaseSiteSenate.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convMicroteachCaseSiteSenate.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convMicroteachCaseSiteSenate.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convMicroteachCaseSiteSenate.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convMicroteachCaseSiteSenate.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convMicroteachCaseSiteSenate.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convMicroteachCaseSiteSenate.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convMicroteachCaseSiteSenate.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convMicroteachCaseSiteSenate.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convMicroteachCaseSiteSenate.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convMicroteachCaseSiteSenate.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convMicroteachCaseSiteSenate.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convMicroteachCaseSiteSenate.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convMicroteachCaseSiteSenate.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convMicroteachCaseSiteSenate.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convMicroteachCaseSiteSenate.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convMicroteachCaseSiteSenate.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convMicroteachCaseSiteSenate.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convMicroteachCaseSiteSenate.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convMicroteachCaseSiteSenate.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convMicroteachCaseSiteSenate.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convMicroteachCaseSiteSenate.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convMicroteachCaseSiteSenate.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convMicroteachCaseSiteSenate.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convMicroteachCaseSiteSenate.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convMicroteachCaseSiteSenate.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convMicroteachCaseSiteSenate.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convMicroteachCaseSiteSenate.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convMicroteachCaseSiteSenate.SiteSenateSenator  ==  AttributeName[intIndex])
{
return mstrSiteSenateSenator;
}
else if (convMicroteachCaseSiteSenate.SiteSenateTitle  ==  AttributeName[intIndex])
{
return mstrSiteSenateTitle;
}
else if (convMicroteachCaseSiteSenate.SiteSenateContent  ==  AttributeName[intIndex])
{
return mstrSiteSenateContent;
}
else if (convMicroteachCaseSiteSenate.SiteSenateData  ==  AttributeName[intIndex])
{
return mstrSiteSenateData;
}
else if (convMicroteachCaseSiteSenate.SiteSenateTime  ==  AttributeName[intIndex])
{
return mstrSiteSenateTime;
}
else if (convMicroteachCaseSiteSenate.SiteSenateReadCount  ==  AttributeName[intIndex])
{
return mintSiteSenateReadCount;
}
else if (convMicroteachCaseSiteSenate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseSiteSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate);
}
else if (convMicroteachCaseSiteSenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FuncModuleId);
}
else if (convMicroteachCaseSiteSenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FuncModuleName);
}
else if (convMicroteachCaseSiteSenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCase);
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseID);
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseName);
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseTheme  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTheme = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseTheme);
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseDate  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseDate);
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseTime  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseTime);
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseDateIn  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDateIn = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
}
else if (convMicroteachCaseSiteSenate.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdStudyLevel);
}
else if (convMicroteachCaseSiteSenate.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StudyLevelName);
}
else if (convMicroteachCaseSiteSenate.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdTeachingPlan);
}
else if (convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
}
else if (convMicroteachCaseSiteSenate.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.IsVisible);
}
else if (convMicroteachCaseSiteSenate.microteachCaseText  ==  AttributeName[intIndex])
{
mstrmicroteachCaseText = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.microteachCaseText);
}
else if (convMicroteachCaseSiteSenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.OwnerId);
}
else if (convMicroteachCaseSiteSenate.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuName);
}
else if (convMicroteachCaseSiteSenate.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuID);
}
else if (convMicroteachCaseSiteSenate.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.PoliticsName);
}
else if (convMicroteachCaseSiteSenate.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SexDesc);
}
else if (convMicroteachCaseSiteSenate.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.EthnicName);
}
else if (convMicroteachCaseSiteSenate.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.UniZoneDesc);
}
else if (convMicroteachCaseSiteSenate.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuTypeDesc);
}
else if (convMicroteachCaseSiteSenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdXzCollege);
}
else if (convMicroteachCaseSiteSenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.CollegeName);
}
else if (convMicroteachCaseSiteSenate.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdXzMajor);
}
else if (convMicroteachCaseSiteSenate.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MajorName);
}
else if (convMicroteachCaseSiteSenate.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdGradeBase);
}
else if (convMicroteachCaseSiteSenate.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.GradeBaseName);
}
else if (convMicroteachCaseSiteSenate.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.Birthday);
}
else if (convMicroteachCaseSiteSenate.NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.NativePlace);
}
else if (convMicroteachCaseSiteSenate.Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.Duty);
}
else if (convMicroteachCaseSiteSenate.IDCardNo  ==  AttributeName[intIndex])
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IDCardNo);
}
else if (convMicroteachCaseSiteSenate.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuCardNo);
}
else if (convMicroteachCaseSiteSenate.LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.LiveAddress);
}
else if (convMicroteachCaseSiteSenate.HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.HomePhone);
}
else if (convMicroteachCaseSiteSenate.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.EnrollmentDate);
}
else if (convMicroteachCaseSiteSenate.PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.PostCode);
}
else if (convMicroteachCaseSiteSenate.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.BrowseCount4Case);
}
else if (convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType  ==  AttributeName[intIndex])
{
mstrIdMicroteachCaseSiteSenateType = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseSiteSenateTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
}
else if (convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseSiteSenateTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
}
else if (convMicroteachCaseSiteSenate.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdResource);
}
else if (convMicroteachCaseSiteSenate.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceID);
}
else if (convMicroteachCaseSiteSenate.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceName);
}
else if (convMicroteachCaseSiteSenate.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdFtpResource);
}
else if (convMicroteachCaseSiteSenate.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdFile);
}
else if (convMicroteachCaseSiteSenate.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileName);
}
else if (convMicroteachCaseSiteSenate.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileType);
}
else if (convMicroteachCaseSiteSenate.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveDate);
}
else if (convMicroteachCaseSiteSenate.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileSize);
}
else if (convMicroteachCaseSiteSenate.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveTime);
}
else if (convMicroteachCaseSiteSenate.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FtpResourceID);
}
else if (convMicroteachCaseSiteSenate.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOriginalName);
}
else if (convMicroteachCaseSiteSenate.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileDirName);
}
else if (convMicroteachCaseSiteSenate.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileRename);
}
else if (convMicroteachCaseSiteSenate.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileUpDate);
}
else if (convMicroteachCaseSiteSenate.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileUpTime);
}
else if (convMicroteachCaseSiteSenate.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveMode);
}
else if (convMicroteachCaseSiteSenate.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdResourceType);
}
else if (convMicroteachCaseSiteSenate.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceTypeID);
}
else if (convMicroteachCaseSiteSenate.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceTypeName);
}
else if (convMicroteachCaseSiteSenate.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceOwner);
}
else if (convMicroteachCaseSiteSenate.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpFileType);
}
else if (convMicroteachCaseSiteSenate.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpFileSize);
}
else if (convMicroteachCaseSiteSenate.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpResourceOwner);
}
else if (convMicroteachCaseSiteSenate.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOriginName);
}
else if (convMicroteachCaseSiteSenate.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.IsExistFile);
}
else if (convMicroteachCaseSiteSenate.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileNewName);
}
else if (convMicroteachCaseSiteSenate.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOldName);
}
else if (convMicroteachCaseSiteSenate.SiteSenateSenator  ==  AttributeName[intIndex])
{
mstrSiteSenateSenator = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateSenator);
}
else if (convMicroteachCaseSiteSenate.SiteSenateTitle  ==  AttributeName[intIndex])
{
mstrSiteSenateTitle = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateTitle);
}
else if (convMicroteachCaseSiteSenate.SiteSenateContent  ==  AttributeName[intIndex])
{
mstrSiteSenateContent = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateContent);
}
else if (convMicroteachCaseSiteSenate.SiteSenateData  ==  AttributeName[intIndex])
{
mstrSiteSenateData = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateData);
}
else if (convMicroteachCaseSiteSenate.SiteSenateTime  ==  AttributeName[intIndex])
{
mstrSiteSenateTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateTime);
}
else if (convMicroteachCaseSiteSenate.SiteSenateReadCount  ==  AttributeName[intIndex])
{
mintSiteSenateReadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateReadCount);
}
else if (convMicroteachCaseSiteSenate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCaseSiteSenate.Memo);
}
}
}

/// <summary>
/// 微格现场评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroteachCaseSiteSenate
{
get
{
return mlngIdMicroteachCaseSiteSenate;
}
set
{
 mlngIdMicroteachCaseSiteSenate = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FuncModuleId);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FuncModuleName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCase);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseID);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseTheme);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseDate);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseTime);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdStudyLevel);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.StudyLevelName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdTeachingPlan);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IsVisible);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.microteachCaseText);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.OwnerId);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuID);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.PoliticsName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.SexDesc);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.EthnicName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.UniZoneDesc);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuTypeDesc);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdXzCollege);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.CollegeName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdXzMajor);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.MajorName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdGradeBase);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.GradeBaseName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.Birthday);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.NativePlace);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.Duty);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IDCardNo);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.StuCardNo);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.LiveAddress);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.HomePhone);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.EnrollmentDate);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.PostCode);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.BrowseCount4Case);
}
}
/// <summary>
/// 微格现场评价类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCaseSiteSenateType
{
get
{
return mstrIdMicroteachCaseSiteSenateType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCaseSiteSenateType = value;
}
else
{
 mstrIdMicroteachCaseSiteSenateType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
}
/// <summary>
/// 微格现场评价类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseSiteSenateTypeID
{
get
{
return mstrMicroteachCaseSiteSenateTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseSiteSenateTypeID = value;
}
else
{
 mstrMicroteachCaseSiteSenateTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
}
}
/// <summary>
/// 微格现场评价类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseSiteSenateTypeName
{
get
{
return mstrMicroteachCaseSiteSenateTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseSiteSenateTypeName = value;
}
else
{
 mstrMicroteachCaseSiteSenateTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdResource);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceID);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdFtpResource);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdFile);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileType);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveDate);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileSize);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveTime);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FtpResourceID);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOriginalName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileDirName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileRename);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileUpDate);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileUpTime);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.SaveMode);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IdResourceType);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceTypeID);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceTypeName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.ResourceOwner);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpFileType);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpFileSize);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.ftpResourceOwner);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOriginName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.IsExistFile);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileNewName);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.FileOldName);
}
}
/// <summary>
/// 评议者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateSenator
{
get
{
return mstrSiteSenateSenator;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateSenator = value;
}
else
{
 mstrSiteSenateSenator = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateSenator);
}
}
/// <summary>
/// 评议名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateTitle
{
get
{
return mstrSiteSenateTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateTitle = value;
}
else
{
 mstrSiteSenateTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateTitle);
}
}
/// <summary>
/// 现场评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateContent
{
get
{
return mstrSiteSenateContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateContent = value;
}
else
{
 mstrSiteSenateContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateContent);
}
}
/// <summary>
/// 现场评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateData
{
get
{
return mstrSiteSenateData;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateData = value;
}
else
{
 mstrSiteSenateData = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateData);
}
}
/// <summary>
/// 现场评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateTime
{
get
{
return mstrSiteSenateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateTime = value;
}
else
{
 mstrSiteSenateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateTime);
}
}
/// <summary>
/// 现场评议阅读次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SiteSenateReadCount
{
get
{
return mintSiteSenateReadCount;
}
set
{
 mintSiteSenateReadCount = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseSiteSenate.SiteSenateReadCount);
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
 AddUpdatedFld(convMicroteachCaseSiteSenate.Memo);
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
  return mlngIdMicroteachCaseSiteSenate.ToString();
 }
 }
}
 /// <summary>
 /// v微格教学现场评议(vMicroteachCaseSiteSenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachCaseSiteSenate
{
public const string _CurrTabName = "vMicroteachCaseSiteSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseSiteSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseSiteSenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "MicroteachCaseTheme", "MicroteachCaseDate", "MicroteachCaseTime", "MicroteachCaseDateIn", "IdStudyLevel", "StudyLevelName", "IdTeachingPlan", "MicroTeachCaseTimeIn", "IsVisible", "microteachCaseText", "OwnerId", "StuName", "StuID", "PoliticsName", "SexDesc", "EthnicName", "UniZoneDesc", "StuTypeDesc", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "EnrollmentDate", "PostCode", "BrowseCount4Case", "IdMicroteachCaseSiteSenateType", "MicroteachCaseSiteSenateTypeID", "MicroteachCaseSiteSenateTypeName", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "SiteSenateSenator", "SiteSenateTitle", "SiteSenateContent", "SiteSenateData", "SiteSenateTime", "SiteSenateReadCount", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCaseSiteSenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseSiteSenate = "IdMicroteachCaseSiteSenate";    //微格现场评议流水号

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
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"IdMicroteachCaseSiteSenateType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseSiteSenateType = "IdMicroteachCaseSiteSenateType";    //微格现场评价类型流水号

 /// <summary>
 /// 常量:"MicroteachCaseSiteSenateTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseSiteSenateTypeID = "MicroteachCaseSiteSenateTypeID";    //微格现场评价类型ID

 /// <summary>
 /// 常量:"MicroteachCaseSiteSenateTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseSiteSenateTypeName = "MicroteachCaseSiteSenateTypeName";    //微格现场评价类型名称

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
 /// 常量:"SiteSenateSenator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateSenator = "SiteSenateSenator";    //评议者

 /// <summary>
 /// 常量:"SiteSenateTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateTitle = "SiteSenateTitle";    //评议名称

 /// <summary>
 /// 常量:"SiteSenateContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateContent = "SiteSenateContent";    //现场评议内容

 /// <summary>
 /// 常量:"SiteSenateData"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateData = "SiteSenateData";    //现场评议日期

 /// <summary>
 /// 常量:"SiteSenateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateTime = "SiteSenateTime";    //现场评议时间

 /// <summary>
 /// 常量:"SiteSenateReadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateReadCount = "SiteSenateReadCount";    //现场评议阅读次数

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}