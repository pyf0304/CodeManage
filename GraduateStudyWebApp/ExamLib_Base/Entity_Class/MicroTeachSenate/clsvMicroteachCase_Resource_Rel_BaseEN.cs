
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel_BaseEN
 表名:vMicroteachCase_Resource_Rel_Base(01120490)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:29
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
 /// 表vMicroteachCase_Resource_Rel_Base的关键字(IdMicroteachCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel_Base
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
public K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel_Base(long lngIdMicroteachCaseResourceRel)
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
 /// <returns>返回:[K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel_Base]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel_Base(long value)
{
return new K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel_Base(value);
}
}
 /// <summary>
 /// vMicroteachCase_Resource_Rel_Base(vMicroteachCase_Resource_Rel_Base)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachCase_Resource_Rel_BaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachCase_Resource_Rel_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 39;
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};

protected long mlngIdMicroteachCaseResourceRel;    //微格案例资源关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
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
protected int? mintIndexNO;    //序号
protected int? mintBrowseCount;    //浏览次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachCase_Resource_Rel_BaseEN()
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
public clsvMicroteachCase_Resource_Rel_BaseEN(long lngIdMicroteachCaseResourceRel)
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
if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel)
{
return mlngIdMicroteachCaseResourceRel;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdUsingMode)
{
return mstrIdUsingMode;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel)
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FuncModuleId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FuncModuleName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdResource);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdFtpResource);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdFile);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileSize);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveTime);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FtpResourceID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOriginalName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileDirName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileRename);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileUpDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileUpTime);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveMode);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdResourceType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceTypeName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceOwner);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpFileType);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpFileSize);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOriginName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IsExistFile);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileNewName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOldName);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IsMain);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IdUsingMode)
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdUsingMode);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IndexNO);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.BrowseCount);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.UpdDate);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.UpdUser);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_Rel_Base.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseResourceRel;
}
else if (convMicroteachCase_Resource_Rel_Base.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convMicroteachCase_Resource_Rel_Base.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convMicroteachCase_Resource_Rel_Base.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroteachCase_Resource_Rel_Base.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convMicroteachCase_Resource_Rel_Base.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convMicroteachCase_Resource_Rel_Base.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convMicroteachCase_Resource_Rel_Base.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convMicroteachCase_Resource_Rel_Base.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convMicroteachCase_Resource_Rel_Base.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convMicroteachCase_Resource_Rel_Base.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convMicroteachCase_Resource_Rel_Base.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convMicroteachCase_Resource_Rel_Base.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convMicroteachCase_Resource_Rel_Base.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convMicroteachCase_Resource_Rel_Base.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convMicroteachCase_Resource_Rel_Base.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convMicroteachCase_Resource_Rel_Base.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convMicroteachCase_Resource_Rel_Base.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convMicroteachCase_Resource_Rel_Base.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convMicroteachCase_Resource_Rel_Base.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convMicroteachCase_Resource_Rel_Base.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convMicroteachCase_Resource_Rel_Base.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convMicroteachCase_Resource_Rel_Base.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convMicroteachCase_Resource_Rel_Base.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convMicroteachCase_Resource_Rel_Base.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convMicroteachCase_Resource_Rel_Base.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convMicroteachCase_Resource_Rel_Base.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convMicroteachCase_Resource_Rel_Base.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convMicroteachCase_Resource_Rel_Base.IdUsingMode  ==  AttributeName[intIndex])
{
return mstrIdUsingMode;
}
else if (convMicroteachCase_Resource_Rel_Base.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convMicroteachCase_Resource_Rel_Base.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convMicroteachCase_Resource_Rel_Base.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convMicroteachCase_Resource_Rel_Base.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convMicroteachCase_Resource_Rel_Base.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel);
}
else if (convMicroteachCase_Resource_Rel_Base.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FuncModuleId);
}
else if (convMicroteachCase_Resource_Rel_Base.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FuncModuleName);
}
else if (convMicroteachCase_Resource_Rel_Base.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdMicroteachCase);
}
else if (convMicroteachCase_Resource_Rel_Base.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdResource);
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceID);
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceName);
}
else if (convMicroteachCase_Resource_Rel_Base.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdFtpResource);
}
else if (convMicroteachCase_Resource_Rel_Base.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdFile);
}
else if (convMicroteachCase_Resource_Rel_Base.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileName);
}
else if (convMicroteachCase_Resource_Rel_Base.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileType);
}
else if (convMicroteachCase_Resource_Rel_Base.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveDate);
}
else if (convMicroteachCase_Resource_Rel_Base.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileSize);
}
else if (convMicroteachCase_Resource_Rel_Base.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveTime);
}
else if (convMicroteachCase_Resource_Rel_Base.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FtpResourceID);
}
else if (convMicroteachCase_Resource_Rel_Base.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOriginalName);
}
else if (convMicroteachCase_Resource_Rel_Base.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileDirName);
}
else if (convMicroteachCase_Resource_Rel_Base.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileRename);
}
else if (convMicroteachCase_Resource_Rel_Base.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileUpDate);
}
else if (convMicroteachCase_Resource_Rel_Base.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileUpTime);
}
else if (convMicroteachCase_Resource_Rel_Base.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveMode);
}
else if (convMicroteachCase_Resource_Rel_Base.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdResourceType);
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceTypeName);
}
else if (convMicroteachCase_Resource_Rel_Base.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceOwner);
}
else if (convMicroteachCase_Resource_Rel_Base.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpFileType);
}
else if (convMicroteachCase_Resource_Rel_Base.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpFileSize);
}
else if (convMicroteachCase_Resource_Rel_Base.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner);
}
else if (convMicroteachCase_Resource_Rel_Base.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOriginName);
}
else if (convMicroteachCase_Resource_Rel_Base.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IsExistFile);
}
else if (convMicroteachCase_Resource_Rel_Base.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileNewName);
}
else if (convMicroteachCase_Resource_Rel_Base.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOldName);
}
else if (convMicroteachCase_Resource_Rel_Base.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IsMain);
}
else if (convMicroteachCase_Resource_Rel_Base.IdUsingMode  ==  AttributeName[intIndex])
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdUsingMode);
}
else if (convMicroteachCase_Resource_Rel_Base.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IndexNO);
}
else if (convMicroteachCase_Resource_Rel_Base.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.BrowseCount);
}
else if (convMicroteachCase_Resource_Rel_Base.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.UpdDate);
}
else if (convMicroteachCase_Resource_Rel_Base.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.UpdUser);
}
else if (convMicroteachCase_Resource_Rel_Base.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.Memo);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FuncModuleId);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FuncModuleName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdMicroteachCase);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdResource);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdFtpResource);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdFile);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveDate);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileSize);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveTime);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FtpResourceID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOriginalName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileDirName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileRename);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileUpDate);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileUpTime);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.SaveMode);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdResourceType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceTypeName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ResourceOwner);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpFileType);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpFileSize);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOriginName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IsExistFile);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileNewName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.FileOldName);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IsMain);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IdUsingMode);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.IndexNO);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.BrowseCount);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.UpdDate);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.UpdUser);
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
 AddUpdatedFld(convMicroteachCase_Resource_Rel_Base.Memo);
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
 /// vMicroteachCase_Resource_Rel_Base(vMicroteachCase_Resource_Rel_Base)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachCase_Resource_Rel_Base
{
public const string _CurrTabName = "vMicroteachCase_Resource_Rel_Base"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IdUsingMode", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};
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