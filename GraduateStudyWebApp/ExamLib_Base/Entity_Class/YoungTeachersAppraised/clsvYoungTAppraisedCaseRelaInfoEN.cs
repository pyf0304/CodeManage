
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseRelaInfoEN
 表名:vYoungTAppraisedCaseRelaInfo(01120396)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// 表vYoungTAppraisedCaseRelaInfo的关键字(IdMicroTeachCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroTeachCaseRelaInfo_vYoungTAppraisedCaseRelaInfo
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
public K_IdMicroTeachCaseRelaInfo_vYoungTAppraisedCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
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
 /// <returns>返回:[K_IdMicroTeachCaseRelaInfo_vYoungTAppraisedCaseRelaInfo]类型的对象</returns>
public static implicit operator K_IdMicroTeachCaseRelaInfo_vYoungTAppraisedCaseRelaInfo(long value)
{
return new K_IdMicroTeachCaseRelaInfo_vYoungTAppraisedCaseRelaInfo(value);
}
}
 /// <summary>
 /// vYoungTAppraisedCaseRelaInfo(vYoungTAppraisedCaseRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvYoungTAppraisedCaseRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vYoungTAppraisedCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 42;
public static string[] AttributeName = new string[] {"IdMicroTeachCaseRelaInfo", "IsVisible", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "IdResource", "ResourceID", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeName", "BrowseCount", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IdYoungTAppraisedCase", "YoungTAppraisedCaseName", "Flag", "FileNewName", "FileOldName", "IsExistFile", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "MicroTeachCaseRelaInfoTypeID", "UpdDate", "UpdUser", "Memo"};

protected long mlngIdMicroTeachCaseRelaInfo;    //案例相关信息流水号
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
protected string mstrMicroTeachCaseRelaInfoTypeName;    //微格案例相关信息类型名称
protected int? mintBrowseCount;    //浏览次数
protected string mstrResourceOwner;    //上传者
protected string mstrftpFileType;    //ftp文件类型
protected string mstrftpFileSize;    //ftp文件大小
protected string mstrftpResourceOwner;    //Ftp资源拥有者
protected string mstrFileOriginName;    //原文件名
protected string mstrIdYoungTAppraisedCase;    //青教评优案例流水号
protected string mstrYoungTAppraisedCaseName;    //青教评优案例名称
protected string mstrFlag;    //标志
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrMicroTeachCaseRelaInfoTypeID;    //微格案例相关信息类型ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvYoungTAppraisedCaseRelaInfoEN()
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
public clsvYoungTAppraisedCaseRelaInfoEN(long lngIdMicroTeachCaseRelaInfo)
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
if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
return mlngIdMicroTeachCaseRelaInfo;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType)
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName)
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase)
{
return mstrIdYoungTAppraisedCase;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName)
{
return mstrYoungTAppraisedCaseName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.Flag)
{
return mstrFlag;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID)
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
mlngIdMicroTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IsVisible);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdFile);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileType);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileSize);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveTime);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdFtpResource);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FtpResourceID);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOriginalName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileDirName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileRename);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileUpDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileUpTime);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdResource);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceID);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveMode);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdResourceType);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceTypeID);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType)
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName)
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.BrowseCount);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceOwner);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpFileType);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpFileSize);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpResourceOwner);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOriginName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase)
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName)
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.Flag)
{
mstrFlag = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.Flag);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileNewName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOldName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IsExistFile);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FuncModuleId);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FuncModuleName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroteachCase);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID)
{
mstrMicroTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.UpdDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.UpdUser);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdMicroTeachCaseRelaInfo;
}
else if (convYoungTAppraisedCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convYoungTAppraisedCaseRelaInfo.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convYoungTAppraisedCaseRelaInfo.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convYoungTAppraisedCaseRelaInfo.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convYoungTAppraisedCaseRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convYoungTAppraisedCaseRelaInfo.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convYoungTAppraisedCaseRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convYoungTAppraisedCaseRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convYoungTAppraisedCaseRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convYoungTAppraisedCaseRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convYoungTAppraisedCaseRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convYoungTAppraisedCaseRelaInfo.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convYoungTAppraisedCaseRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convYoungTAppraisedCaseRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convYoungTAppraisedCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convYoungTAppraisedCaseRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convYoungTAppraisedCaseRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convYoungTAppraisedCaseRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convYoungTAppraisedCaseRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convYoungTAppraisedCaseRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (convYoungTAppraisedCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convYoungTAppraisedCaseRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convYoungTAppraisedCaseRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convYoungTAppraisedCaseRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convYoungTAppraisedCaseRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convYoungTAppraisedCaseRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCase;
}
else if (convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseName;
}
else if (convYoungTAppraisedCaseRelaInfo.Flag  ==  AttributeName[intIndex])
{
return mstrFlag;
}
else if (convYoungTAppraisedCaseRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convYoungTAppraisedCaseRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convYoungTAppraisedCaseRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convYoungTAppraisedCaseRelaInfo.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convYoungTAppraisedCaseRelaInfo.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convYoungTAppraisedCaseRelaInfo.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
else if (convYoungTAppraisedCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convYoungTAppraisedCaseRelaInfo.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convYoungTAppraisedCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdMicroTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo);
}
else if (convYoungTAppraisedCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IsVisible);
}
else if (convYoungTAppraisedCaseRelaInfo.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdFile);
}
else if (convYoungTAppraisedCaseRelaInfo.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileName);
}
else if (convYoungTAppraisedCaseRelaInfo.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileType);
}
else if (convYoungTAppraisedCaseRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveDate);
}
else if (convYoungTAppraisedCaseRelaInfo.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileSize);
}
else if (convYoungTAppraisedCaseRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveTime);
}
else if (convYoungTAppraisedCaseRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdFtpResource);
}
else if (convYoungTAppraisedCaseRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FtpResourceID);
}
else if (convYoungTAppraisedCaseRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOriginalName);
}
else if (convYoungTAppraisedCaseRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileDirName);
}
else if (convYoungTAppraisedCaseRelaInfo.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileRename);
}
else if (convYoungTAppraisedCaseRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileUpDate);
}
else if (convYoungTAppraisedCaseRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileUpTime);
}
else if (convYoungTAppraisedCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdResource);
}
else if (convYoungTAppraisedCaseRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceID);
}
else if (convYoungTAppraisedCaseRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveMode);
}
else if (convYoungTAppraisedCaseRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdResourceType);
}
else if (convYoungTAppraisedCaseRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceTypeID);
}
else if (convYoungTAppraisedCaseRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceTypeName);
}
else if (convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
else if (convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
else if (convYoungTAppraisedCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.BrowseCount);
}
else if (convYoungTAppraisedCaseRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceOwner);
}
else if (convYoungTAppraisedCaseRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpFileType);
}
else if (convYoungTAppraisedCaseRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpFileSize);
}
else if (convYoungTAppraisedCaseRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpResourceOwner);
}
else if (convYoungTAppraisedCaseRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOriginName);
}
else if (convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase);
}
else if (convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName);
}
else if (convYoungTAppraisedCaseRelaInfo.Flag  ==  AttributeName[intIndex])
{
mstrFlag = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.Flag);
}
else if (convYoungTAppraisedCaseRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileNewName);
}
else if (convYoungTAppraisedCaseRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOldName);
}
else if (convYoungTAppraisedCaseRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IsExistFile);
}
else if (convYoungTAppraisedCaseRelaInfo.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FuncModuleId);
}
else if (convYoungTAppraisedCaseRelaInfo.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FuncModuleName);
}
else if (convYoungTAppraisedCaseRelaInfo.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroteachCase);
}
else if (convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
else if (convYoungTAppraisedCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.UpdDate);
}
else if (convYoungTAppraisedCaseRelaInfo.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.UpdUser);
}
else if (convYoungTAppraisedCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.Memo);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfo);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IsVisible);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdFile);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileType);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveDate);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileSize);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveTime);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdFtpResource);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FtpResourceID);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOriginalName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileDirName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileRename);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileUpDate);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileUpTime);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdResource);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceID);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.SaveMode);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdResourceType);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceTypeID);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.BrowseCount);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ResourceOwner);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpFileType);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpFileSize);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.ftpResourceOwner);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOriginName);
}
}
/// <summary>
/// 青教评优案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdYoungTAppraisedCase
{
get
{
return mstrIdYoungTAppraisedCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdYoungTAppraisedCase = value;
}
else
{
 mstrIdYoungTAppraisedCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdYoungTAppraisedCase);
}
}
/// <summary>
/// 青教评优案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseName
{
get
{
return mstrYoungTAppraisedCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseName = value;
}
else
{
 mstrYoungTAppraisedCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.Flag);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileNewName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FileOldName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IsExistFile);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FuncModuleId);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.FuncModuleName);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.IdMicroteachCase);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.UpdDate);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.UpdUser);
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
 AddUpdatedFld(convYoungTAppraisedCaseRelaInfo.Memo);
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
 /// vYoungTAppraisedCaseRelaInfo(vYoungTAppraisedCaseRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convYoungTAppraisedCaseRelaInfo
{
public const string _CurrTabName = "vYoungTAppraisedCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroTeachCaseRelaInfo", "IsVisible", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "IdResource", "ResourceID", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeName", "BrowseCount", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IdYoungTAppraisedCase", "YoungTAppraisedCaseName", "Flag", "FileNewName", "FileOldName", "IsExistFile", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "MicroTeachCaseRelaInfoTypeID", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroTeachCaseRelaInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroTeachCaseRelaInfo = "IdMicroTeachCaseRelaInfo";    //案例相关信息流水号

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
 /// 常量:"IdYoungTAppraisedCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdYoungTAppraisedCase = "IdYoungTAppraisedCase";    //青教评优案例流水号

 /// <summary>
 /// 常量:"YoungTAppraisedCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseName = "YoungTAppraisedCaseName";    //青教评优案例名称

 /// <summary>
 /// 常量:"Flag"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Flag = "Flag";    //标志

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
 /// 常量:"MicroTeachCaseRelaInfoTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseRelaInfoTypeID = "MicroTeachCaseRelaInfoTypeID";    //微格案例相关信息类型ID

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