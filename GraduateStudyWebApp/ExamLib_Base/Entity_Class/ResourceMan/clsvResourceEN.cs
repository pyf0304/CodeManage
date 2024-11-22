
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvResourceEN
 表名:vResource(01120321)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
 /// 表vResource的关键字(IdResource)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdResource_vResource
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdResource">表关键字</param>
public K_IdResource_vResource(string strIdResource)
{
if (IsValid(strIdResource)) Value = strIdResource;
else
{
Value = null;
}
}
private static bool IsValid(string strIdResource)
{
if (string.IsNullOrEmpty(strIdResource) == true) return false;
if (strIdResource.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdResource_vResource]类型的对象</returns>
public static implicit operator K_IdResource_vResource(string value)
{
return new K_IdResource_vResource(value);
}
}
 /// <summary>
 /// v资源(vResource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvResourceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 35;
public static string[] AttributeName = new string[] {"IdResource", "ResourceID", "ResourceName", "SaveMode", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "FileSize", "FileType", "ResourceOwner", "IsExistFile", "IdFile", "FileName", "SaveDate", "SaveTime", "FileOriginName", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "Memo", "FuncModuleId", "FuncModuleNameSim", "OrderNum", "CheckDate", "CheckUser", "CheckResult", "FileNewName", "FileOldName", "ftpFileType", "ftpFileSize", "ftpResourceOwner"};

protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
protected string mstrResourceName;    //资源名称
protected bool mbolSaveMode;    //文件存放方式
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected string mstrFileSize;    //文件大小
protected string mstrFileType;    //文件类型
protected string mstrResourceOwner;    //上传者
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrIdFile;    //文件流水号
protected string mstrFileName;    //文件名称
protected string mstrSaveDate;    //创建日期
protected string mstrSaveTime;    //创建时间
protected string mstrFileOriginName;    //原文件名
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrMemo;    //备注
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleNameSim;    //功能模块简称
protected int? mintOrderNum;    //序号
protected string mstrCheckDate;    //检查日期
protected string mstrCheckUser;    //检查用户Id
protected string mstrCheckResult;    //检查结果
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名
protected string mstrftpFileType;    //ftp文件类型
protected string mstrftpFileSize;    //ftp文件大小
protected string mstrftpResourceOwner;    //Ftp资源拥有者

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvResourceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdResource");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdResource">关键字:资源流水号</param>
public clsvResourceEN(string strIdResource)
 {
strIdResource = strIdResource.Replace("'", "''");
if (strIdResource.Length > 8)
{
throw new Exception("在表:vResource中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdResource)  ==  true)
{
throw new Exception("在表:vResource中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdResource = strIdResource;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdResource");
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
if (strAttributeName  ==  convResource.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convResource.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convResource.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convResource.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convResource.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convResource.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convResource.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convResource.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convResource.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convResource.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convResource.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convResource.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convResource.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convResource.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convResource.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convResource.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convResource.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convResource.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convResource.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convResource.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convResource.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convResource.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convResource.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convResource.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convResource.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convResource.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convResource.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convResource.CheckDate)
{
return mstrCheckDate;
}
else if (strAttributeName  ==  convResource.CheckUser)
{
return mstrCheckUser;
}
else if (strAttributeName  ==  convResource.CheckResult)
{
return mstrCheckResult;
}
else if (strAttributeName  ==  convResource.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convResource.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convResource.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convResource.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convResource.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
return null;
}
set
{
if (strAttributeName  ==  convResource.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convResource.IdResource);
}
else if (strAttributeName  ==  convResource.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convResource.ResourceID);
}
else if (strAttributeName  ==  convResource.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convResource.ResourceName);
}
else if (strAttributeName  ==  convResource.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convResource.SaveMode);
}
else if (strAttributeName  ==  convResource.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convResource.IdFtpResource);
}
else if (strAttributeName  ==  convResource.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convResource.FtpResourceID);
}
else if (strAttributeName  ==  convResource.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convResource.FileOriginalName);
}
else if (strAttributeName  ==  convResource.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convResource.FileDirName);
}
else if (strAttributeName  ==  convResource.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convResource.FileRename);
}
else if (strAttributeName  ==  convResource.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convResource.FileUpDate);
}
else if (strAttributeName  ==  convResource.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convResource.FileUpTime);
}
else if (strAttributeName  ==  convResource.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convResource.FileSize);
}
else if (strAttributeName  ==  convResource.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convResource.FileType);
}
else if (strAttributeName  ==  convResource.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convResource.ResourceOwner);
}
else if (strAttributeName  ==  convResource.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convResource.IsExistFile);
}
else if (strAttributeName  ==  convResource.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convResource.IdFile);
}
else if (strAttributeName  ==  convResource.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convResource.FileName);
}
else if (strAttributeName  ==  convResource.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convResource.SaveDate);
}
else if (strAttributeName  ==  convResource.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convResource.SaveTime);
}
else if (strAttributeName  ==  convResource.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convResource.FileOriginName);
}
else if (strAttributeName  ==  convResource.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convResource.IdResourceType);
}
else if (strAttributeName  ==  convResource.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convResource.ResourceTypeID);
}
else if (strAttributeName  ==  convResource.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convResource.ResourceTypeName);
}
else if (strAttributeName  ==  convResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convResource.Memo);
}
else if (strAttributeName  ==  convResource.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convResource.FuncModuleId);
}
else if (strAttributeName  ==  convResource.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convResource.FuncModuleNameSim);
}
else if (strAttributeName  ==  convResource.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convResource.OrderNum);
}
else if (strAttributeName  ==  convResource.CheckDate)
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(convResource.CheckDate);
}
else if (strAttributeName  ==  convResource.CheckUser)
{
mstrCheckUser = value.ToString();
 AddUpdatedFld(convResource.CheckUser);
}
else if (strAttributeName  ==  convResource.CheckResult)
{
mstrCheckResult = value.ToString();
 AddUpdatedFld(convResource.CheckResult);
}
else if (strAttributeName  ==  convResource.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convResource.FileNewName);
}
else if (strAttributeName  ==  convResource.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convResource.FileOldName);
}
else if (strAttributeName  ==  convResource.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convResource.ftpFileType);
}
else if (strAttributeName  ==  convResource.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convResource.ftpFileSize);
}
else if (strAttributeName  ==  convResource.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convResource.ftpResourceOwner);
}
}
}
public object this[int intIndex]
{
get
{
if (convResource.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convResource.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convResource.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convResource.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convResource.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convResource.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convResource.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convResource.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convResource.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convResource.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convResource.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convResource.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convResource.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convResource.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convResource.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convResource.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convResource.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convResource.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convResource.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convResource.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convResource.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convResource.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convResource.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convResource.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convResource.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convResource.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convResource.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convResource.CheckDate  ==  AttributeName[intIndex])
{
return mstrCheckDate;
}
else if (convResource.CheckUser  ==  AttributeName[intIndex])
{
return mstrCheckUser;
}
else if (convResource.CheckResult  ==  AttributeName[intIndex])
{
return mstrCheckResult;
}
else if (convResource.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convResource.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convResource.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convResource.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convResource.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
return null;
}
set
{
if (convResource.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convResource.IdResource);
}
else if (convResource.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convResource.ResourceID);
}
else if (convResource.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convResource.ResourceName);
}
else if (convResource.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convResource.SaveMode);
}
else if (convResource.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convResource.IdFtpResource);
}
else if (convResource.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convResource.FtpResourceID);
}
else if (convResource.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convResource.FileOriginalName);
}
else if (convResource.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convResource.FileDirName);
}
else if (convResource.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convResource.FileRename);
}
else if (convResource.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convResource.FileUpDate);
}
else if (convResource.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convResource.FileUpTime);
}
else if (convResource.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convResource.FileSize);
}
else if (convResource.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convResource.FileType);
}
else if (convResource.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convResource.ResourceOwner);
}
else if (convResource.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convResource.IsExistFile);
}
else if (convResource.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convResource.IdFile);
}
else if (convResource.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convResource.FileName);
}
else if (convResource.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convResource.SaveDate);
}
else if (convResource.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convResource.SaveTime);
}
else if (convResource.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convResource.FileOriginName);
}
else if (convResource.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convResource.IdResourceType);
}
else if (convResource.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convResource.ResourceTypeID);
}
else if (convResource.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convResource.ResourceTypeName);
}
else if (convResource.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convResource.Memo);
}
else if (convResource.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convResource.FuncModuleId);
}
else if (convResource.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convResource.FuncModuleNameSim);
}
else if (convResource.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convResource.OrderNum);
}
else if (convResource.CheckDate  ==  AttributeName[intIndex])
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(convResource.CheckDate);
}
else if (convResource.CheckUser  ==  AttributeName[intIndex])
{
mstrCheckUser = value.ToString();
 AddUpdatedFld(convResource.CheckUser);
}
else if (convResource.CheckResult  ==  AttributeName[intIndex])
{
mstrCheckResult = value.ToString();
 AddUpdatedFld(convResource.CheckResult);
}
else if (convResource.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convResource.FileNewName);
}
else if (convResource.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convResource.FileOldName);
}
else if (convResource.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convResource.ftpFileType);
}
else if (convResource.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convResource.ftpFileSize);
}
else if (convResource.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convResource.ftpResourceOwner);
}
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
 AddUpdatedFld(convResource.IdResource);
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
 AddUpdatedFld(convResource.ResourceID);
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
 AddUpdatedFld(convResource.ResourceName);
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
 AddUpdatedFld(convResource.SaveMode);
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
 AddUpdatedFld(convResource.IdFtpResource);
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
 AddUpdatedFld(convResource.FtpResourceID);
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
 AddUpdatedFld(convResource.FileOriginalName);
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
 AddUpdatedFld(convResource.FileDirName);
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
 AddUpdatedFld(convResource.FileRename);
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
 AddUpdatedFld(convResource.FileUpDate);
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
 AddUpdatedFld(convResource.FileUpTime);
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
 AddUpdatedFld(convResource.FileSize);
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
 AddUpdatedFld(convResource.FileType);
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
 AddUpdatedFld(convResource.ResourceOwner);
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
 AddUpdatedFld(convResource.IsExistFile);
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
 AddUpdatedFld(convResource.IdFile);
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
 AddUpdatedFld(convResource.FileName);
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
 AddUpdatedFld(convResource.SaveDate);
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
 AddUpdatedFld(convResource.SaveTime);
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
 AddUpdatedFld(convResource.FileOriginName);
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
 AddUpdatedFld(convResource.IdResourceType);
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
 AddUpdatedFld(convResource.ResourceTypeID);
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
 AddUpdatedFld(convResource.ResourceTypeName);
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
 AddUpdatedFld(convResource.Memo);
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
 AddUpdatedFld(convResource.FuncModuleId);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convResource.FuncModuleNameSim);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convResource.OrderNum);
}
}
/// <summary>
/// 检查日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDate
{
get
{
return mstrCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDate = value;
}
else
{
 mstrCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convResource.CheckDate);
}
}
/// <summary>
/// 检查用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckUser
{
get
{
return mstrCheckUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckUser = value;
}
else
{
 mstrCheckUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convResource.CheckUser);
}
}
/// <summary>
/// 检查结果(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckResult
{
get
{
return mstrCheckResult;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckResult = value;
}
else
{
 mstrCheckResult = value;
}
//记录修改过的字段
 AddUpdatedFld(convResource.CheckResult);
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
 AddUpdatedFld(convResource.FileNewName);
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
 AddUpdatedFld(convResource.FileOldName);
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
 AddUpdatedFld(convResource.ftpFileType);
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
 AddUpdatedFld(convResource.ftpFileSize);
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
 AddUpdatedFld(convResource.ftpResourceOwner);
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
  return mstrIdResource;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrResourceName;
 }
 }
}
 /// <summary>
 /// v资源(vResource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convResource
{
public const string _CurrTabName = "vResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdResource", "ResourceID", "ResourceName", "SaveMode", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "FileSize", "FileType", "ResourceOwner", "IsExistFile", "IdFile", "FileName", "SaveDate", "SaveTime", "FileOriginName", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "Memo", "FuncModuleId", "FuncModuleNameSim", "OrderNum", "CheckDate", "CheckUser", "CheckResult", "FileNewName", "FileOldName", "ftpFileType", "ftpFileSize", "ftpResourceOwner"};
//以下是属性变量


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
 /// 常量:"SaveMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveMode = "SaveMode";    //文件存放方式

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
 /// 常量:"ResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceOwner = "ResourceOwner";    //上传者

 /// <summary>
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

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
 /// 常量:"SaveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveDate = "SaveDate";    //创建日期

 /// <summary>
 /// 常量:"SaveTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveTime = "SaveTime";    //创建时间

 /// <summary>
 /// 常量:"FileOriginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginName = "FileOriginName";    //原文件名

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"CheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDate = "CheckDate";    //检查日期

 /// <summary>
 /// 常量:"CheckUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckUser = "CheckUser";    //检查用户Id

 /// <summary>
 /// 常量:"CheckResult"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckResult = "CheckResult";    //检查结果

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
}

}