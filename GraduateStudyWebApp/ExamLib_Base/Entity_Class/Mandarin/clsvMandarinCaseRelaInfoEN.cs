
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCaseRelaInfoEN
 表名:vMandarinCaseRelaInfo(01120401)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// 表vMandarinCaseRelaInfo的关键字(IdMicroTeachCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroTeachCaseRelaInfo_vMandarinCaseRelaInfo
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroTeachCaseRelaInfo">表关键字</param>
public K_IdMicroTeachCaseRelaInfo_vMandarinCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
if (IsValid(lngIdMicroTeachCaseRelaInfo)) Value = lngIdMicroTeachCaseRelaInfo;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroTeachCaseRelaInfo)
{
if (lngIdMicroTeachCaseRelaInfo == 0) return false;
if (lngIdMicroTeachCaseRelaInfo == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroTeachCaseRelaInfo_vMandarinCaseRelaInfo]类型的对象</returns>
public static implicit operator K_IdMicroTeachCaseRelaInfo_vMandarinCaseRelaInfo(long value)
{
return new K_IdMicroTeachCaseRelaInfo_vMandarinCaseRelaInfo(value);
}
}
 /// <summary>
 /// vMandarinCaseRelaInfo(vMandarinCaseRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMandarinCaseRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMandarinCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 42;
public static string[] AttributeName = new string[] {"IdMicroTeachCaseRelaInfo", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IsVisible", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "IdResource", "ResourceID", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeID", "MicroTeachCaseRelaInfoTypeName", "BrowseCount", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "MandarinCaseName", "FileNewName", "FileOldName", "IsExistFile", "Flag", "UpdDate", "UpdUser", "Memo", "IdMandarinCase"};

protected long mlngIdMicroTeachCaseRelaInfo;    //案例相关信息流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected bool mbolIsVisible;    //是否显示
protected string mstrIdFile;    //文件流水号
protected string mstrFileName;    //文件名称
protected string mstrFileType;    //文件类型
protected string mstrSaveDate;    //创建日期
protected string mstrFileSize;    //文件大小
protected string mstrSaveTime;    //创建时间
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
protected bool mbolSaveMode;    //文件存放方式
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrIdMicroTeachCaseRelaInfoType;    //微格案例相关信息类型流水号
protected string mstrMicroTeachCaseRelaInfoTypeID;    //微格案例相关信息类型ID
protected string mstrMicroTeachCaseRelaInfoTypeName;    //微格案例相关信息类型名称
protected int? mintBrowseCount;    //浏览次数
protected string mstrResourceOwner;    //上传者
protected string mstrftpFileType;    //ftp文件类型
protected string mstrftpFileSize;    //ftp文件大小
protected string mstrftpResourceOwner;    //Ftp资源拥有者
protected string mstrFileOriginName;    //原文件名
protected string mstrMandarinCaseName;    //普通话教学案例名称
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrFlag;    //标志
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrIdMandarinCase;    //普通话案例流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMandarinCaseRelaInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroTeachCaseRelaInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroTeachCaseRelaInfo">关键字:案例相关信息流水号</param>
public clsvMandarinCaseRelaInfoEN(long lngIdMicroTeachCaseRelaInfo)
 {
 if (lngIdMicroTeachCaseRelaInfo  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroTeachCaseRelaInfo = lngIdMicroTeachCaseRelaInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroTeachCaseRelaInfo");
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
if (strAttributeName  ==  convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
return mlngIdMicroTeachCaseRelaInfo;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType)
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID)
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName)
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.MandarinCaseName)
{
return mstrMandarinCaseName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.Flag)
{
return mstrFlag;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdMandarinCase)
{
return mstrIdMandarinCase;
}
return null;
}
set
{
if (strAttributeName  ==  convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
mlngIdMicroTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FuncModuleId);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FuncModuleName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroteachCase);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.IsVisible);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdFile);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileType);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveDate);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileSize);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveTime);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdFtpResource);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FtpResourceID);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOriginalName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileDirName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileRename);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileUpDate);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileUpTime);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdResource);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceID);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveMode);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdResourceType);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceTypeID);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceTypeName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType)
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID)
{
mstrMicroTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName)
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.BrowseCount);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceOwner);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpFileType);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpFileSize);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpResourceOwner);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOriginName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.MandarinCaseName)
{
mstrMandarinCaseName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.MandarinCaseName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileNewName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOldName);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.IsExistFile);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.Flag)
{
mstrFlag = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.Flag);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.UpdDate);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.UpdUser);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.Memo);
}
else if (strAttributeName  ==  convMandarinCaseRelaInfo.IdMandarinCase)
{
mstrIdMandarinCase = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMandarinCase);
}
}
}
public object this[int intIndex]
{
get
{
if (convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdMicroTeachCaseRelaInfo;
}
else if (convMandarinCaseRelaInfo.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convMandarinCaseRelaInfo.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convMandarinCaseRelaInfo.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMandarinCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convMandarinCaseRelaInfo.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convMandarinCaseRelaInfo.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convMandarinCaseRelaInfo.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convMandarinCaseRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convMandarinCaseRelaInfo.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convMandarinCaseRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convMandarinCaseRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convMandarinCaseRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convMandarinCaseRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convMandarinCaseRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convMandarinCaseRelaInfo.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convMandarinCaseRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convMandarinCaseRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convMandarinCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convMandarinCaseRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convMandarinCaseRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convMandarinCaseRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convMandarinCaseRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convMandarinCaseRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
else if (convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (convMandarinCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convMandarinCaseRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convMandarinCaseRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convMandarinCaseRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convMandarinCaseRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convMandarinCaseRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convMandarinCaseRelaInfo.MandarinCaseName  ==  AttributeName[intIndex])
{
return mstrMandarinCaseName;
}
else if (convMandarinCaseRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convMandarinCaseRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convMandarinCaseRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convMandarinCaseRelaInfo.Flag  ==  AttributeName[intIndex])
{
return mstrFlag;
}
else if (convMandarinCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convMandarinCaseRelaInfo.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convMandarinCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convMandarinCaseRelaInfo.IdMandarinCase  ==  AttributeName[intIndex])
{
return mstrIdMandarinCase;
}
return null;
}
set
{
if (convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdMicroTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo);
}
else if (convMandarinCaseRelaInfo.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FuncModuleId);
}
else if (convMandarinCaseRelaInfo.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FuncModuleName);
}
else if (convMandarinCaseRelaInfo.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroteachCase);
}
else if (convMandarinCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.IsVisible);
}
else if (convMandarinCaseRelaInfo.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdFile);
}
else if (convMandarinCaseRelaInfo.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileName);
}
else if (convMandarinCaseRelaInfo.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileType);
}
else if (convMandarinCaseRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveDate);
}
else if (convMandarinCaseRelaInfo.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileSize);
}
else if (convMandarinCaseRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveTime);
}
else if (convMandarinCaseRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdFtpResource);
}
else if (convMandarinCaseRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FtpResourceID);
}
else if (convMandarinCaseRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOriginalName);
}
else if (convMandarinCaseRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileDirName);
}
else if (convMandarinCaseRelaInfo.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileRename);
}
else if (convMandarinCaseRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileUpDate);
}
else if (convMandarinCaseRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileUpTime);
}
else if (convMandarinCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdResource);
}
else if (convMandarinCaseRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceID);
}
else if (convMandarinCaseRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveMode);
}
else if (convMandarinCaseRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdResourceType);
}
else if (convMandarinCaseRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceTypeID);
}
else if (convMandarinCaseRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceTypeName);
}
else if (convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
else if (convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
else if (convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
else if (convMandarinCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.BrowseCount);
}
else if (convMandarinCaseRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceOwner);
}
else if (convMandarinCaseRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpFileType);
}
else if (convMandarinCaseRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpFileSize);
}
else if (convMandarinCaseRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpResourceOwner);
}
else if (convMandarinCaseRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOriginName);
}
else if (convMandarinCaseRelaInfo.MandarinCaseName  ==  AttributeName[intIndex])
{
mstrMandarinCaseName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.MandarinCaseName);
}
else if (convMandarinCaseRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileNewName);
}
else if (convMandarinCaseRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOldName);
}
else if (convMandarinCaseRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMandarinCaseRelaInfo.IsExistFile);
}
else if (convMandarinCaseRelaInfo.Flag  ==  AttributeName[intIndex])
{
mstrFlag = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.Flag);
}
else if (convMandarinCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.UpdDate);
}
else if (convMandarinCaseRelaInfo.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.UpdUser);
}
else if (convMandarinCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.Memo);
}
else if (convMandarinCaseRelaInfo.IdMandarinCase  ==  AttributeName[intIndex])
{
mstrIdMandarinCase = value.ToString();
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMandarinCase);
}
}
}

/// <summary>
/// 案例相关信息流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroTeachCaseRelaInfo
{
get
{
return mlngIdMicroTeachCaseRelaInfo;
}
set
{
 mlngIdMicroTeachCaseRelaInfo = value;
//记录修改过的字段
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FuncModuleId);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FuncModuleName);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroteachCase);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.IsVisible);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.IdFile);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileName);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileType);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveDate);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileSize);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveTime);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.IdFtpResource);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FtpResourceID);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOriginalName);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileDirName);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileRename);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileUpDate);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileUpTime);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.IdResource);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceID);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.SaveMode);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.IdResourceType);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceTypeID);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceTypeName);
}
}
/// <summary>
/// 微格案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroTeachCaseRelaInfoType
{
get
{
return mstrIdMicroTeachCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroTeachCaseRelaInfoType = value;
}
else
{
 mstrIdMicroTeachCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
}
/// <summary>
/// 微格案例相关信息类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseRelaInfoTypeID
{
get
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseRelaInfoTypeID = value;
}
else
{
 mstrMicroTeachCaseRelaInfoTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
}
/// <summary>
/// 微格案例相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseRelaInfoTypeName
{
get
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseRelaInfoTypeName = value;
}
else
{
 mstrMicroTeachCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.BrowseCount);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.ResourceOwner);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpFileType);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpFileSize);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.ftpResourceOwner);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOriginName);
}
}
/// <summary>
/// 普通话教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseName
{
get
{
return mstrMandarinCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseName = value;
}
else
{
 mstrMandarinCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCaseRelaInfo.MandarinCaseName);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileNewName);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.FileOldName);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.IsExistFile);
}
}
/// <summary>
/// 标志(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Flag
{
get
{
return mstrFlag;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFlag = value;
}
else
{
 mstrFlag = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCaseRelaInfo.Flag);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.UpdDate);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.UpdUser);
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
 AddUpdatedFld(convMandarinCaseRelaInfo.Memo);
}
}
/// <summary>
/// 普通话案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMandarinCase
{
get
{
return mstrIdMandarinCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMandarinCase = value;
}
else
{
 mstrIdMandarinCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convMandarinCaseRelaInfo.IdMandarinCase);
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
  return mlngIdMicroTeachCaseRelaInfo.ToString();
 }
 }
}
 /// <summary>
 /// vMandarinCaseRelaInfo(vMandarinCaseRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMandarinCaseRelaInfo
{
public const string _CurrTabName = "vMandarinCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroTeachCaseRelaInfo", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IsVisible", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "IdResource", "ResourceID", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeID", "MicroTeachCaseRelaInfoTypeName", "BrowseCount", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "MandarinCaseName", "FileNewName", "FileOldName", "IsExistFile", "Flag", "UpdDate", "UpdUser", "Memo", "IdMandarinCase"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroTeachCaseRelaInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroTeachCaseRelaInfo = "IdMicroTeachCaseRelaInfo";    //案例相关信息流水号

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
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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
 /// 常量:"ResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceID = "ResourceID";    //资源ID

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
 /// 常量:"IdMicroTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroTeachCaseRelaInfoType = "IdMicroTeachCaseRelaInfoType";    //微格案例相关信息类型流水号

 /// <summary>
 /// 常量:"MicroTeachCaseRelaInfoTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseRelaInfoTypeID = "MicroTeachCaseRelaInfoTypeID";    //微格案例相关信息类型ID

 /// <summary>
 /// 常量:"MicroTeachCaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseRelaInfoTypeName = "MicroTeachCaseRelaInfoTypeName";    //微格案例相关信息类型名称

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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
 /// 常量:"MandarinCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseName = "MandarinCaseName";    //普通话教学案例名称

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
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

 /// <summary>
 /// 常量:"Flag"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Flag = "Flag";    //标志

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
 /// 常量:"IdMandarinCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMandarinCase = "IdMandarinCase";    //普通话案例流水号
}

}