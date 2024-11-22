
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileResourceEN
 表名:FileResource(01120373)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:09:04
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
 /// 表FileResource的关键字(FileResourceID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FileResourceID_FileResource
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngFileResourceID">表关键字</param>
public K_FileResourceID_FileResource(long lngFileResourceID)
{
if (IsValid(lngFileResourceID)) Value = lngFileResourceID;
else
{
Value = 0;
}
}
private static bool IsValid(long lngFileResourceID)
{
if (lngFileResourceID == 0) return false;
if (lngFileResourceID == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FileResourceID_FileResource]类型的对象</returns>
public static implicit operator K_FileResourceID_FileResource(long value)
{
return new K_FileResourceID_FileResource(value);
}
}
 /// <summary>
 /// 文件资源(FileResource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFileResourceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FileResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FileResourceID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"FileResourceID", "IpAddress", "FileDirName", "FileName", "FileNameBak", "Extension", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "IdFtpResource", "InUse", "IsExistFile", "UpdDate", "UpdUser", "Memo"};

protected long mlngFileResourceID;    //FileResourceID
protected string mstrIpAddress;    //Ip地址
protected string mstrFileDirName;    //文件目录名
protected string mstrFileName;    //文件名称
protected string mstrFileNameBak;    //FileName_Bak
protected string mstrExtension;    //扩展名
protected long? mlngFileLength;    //文件长度
protected string mstrFileType;    //文件类型
protected string mstrCreationTime;    //建立时间
protected string mstrLastWriteTime;    //最后修改时间
protected string mstrCheckDateTime;    //CheckDateTime
protected string mstrIdFtpResource;    //FTP资源流水号
protected bool mbolInUse;    //是否在用
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFileResourceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FileResourceID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngFileResourceID">关键字:FileResourceID</param>
public clsFileResourceEN(long lngFileResourceID)
 {
 if (lngFileResourceID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngFileResourceID = lngFileResourceID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FileResourceID");
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
if (strAttributeName  ==  conFileResource.FileResourceID)
{
return mlngFileResourceID;
}
else if (strAttributeName  ==  conFileResource.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conFileResource.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  conFileResource.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conFileResource.FileNameBak)
{
return mstrFileNameBak;
}
else if (strAttributeName  ==  conFileResource.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  conFileResource.FileLength)
{
return mlngFileLength;
}
else if (strAttributeName  ==  conFileResource.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  conFileResource.CreationTime)
{
return mstrCreationTime;
}
else if (strAttributeName  ==  conFileResource.LastWriteTime)
{
return mstrLastWriteTime;
}
else if (strAttributeName  ==  conFileResource.CheckDateTime)
{
return mstrCheckDateTime;
}
else if (strAttributeName  ==  conFileResource.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  conFileResource.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conFileResource.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  conFileResource.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFileResource.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFileResource.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFileResource.FileResourceID)
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResource.FileResourceID);
}
else if (strAttributeName  ==  conFileResource.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conFileResource.IpAddress);
}
else if (strAttributeName  ==  conFileResource.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(conFileResource.FileDirName);
}
else if (strAttributeName  ==  conFileResource.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conFileResource.FileName);
}
else if (strAttributeName  ==  conFileResource.FileNameBak)
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(conFileResource.FileNameBak);
}
else if (strAttributeName  ==  conFileResource.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(conFileResource.Extension);
}
else if (strAttributeName  ==  conFileResource.FileLength)
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResource.FileLength);
}
else if (strAttributeName  ==  conFileResource.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFileResource.FileType);
}
else if (strAttributeName  ==  conFileResource.CreationTime)
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(conFileResource.CreationTime);
}
else if (strAttributeName  ==  conFileResource.LastWriteTime)
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(conFileResource.LastWriteTime);
}
else if (strAttributeName  ==  conFileResource.CheckDateTime)
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(conFileResource.CheckDateTime);
}
else if (strAttributeName  ==  conFileResource.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFileResource.IdFtpResource);
}
else if (strAttributeName  ==  conFileResource.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.InUse);
}
else if (strAttributeName  ==  conFileResource.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsExistFile);
}
else if (strAttributeName  ==  conFileResource.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFileResource.UpdDate);
}
else if (strAttributeName  ==  conFileResource.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFileResource.UpdUser);
}
else if (strAttributeName  ==  conFileResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFileResource.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFileResource.FileResourceID  ==  AttributeName[intIndex])
{
return mlngFileResourceID;
}
else if (conFileResource.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conFileResource.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (conFileResource.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conFileResource.FileNameBak  ==  AttributeName[intIndex])
{
return mstrFileNameBak;
}
else if (conFileResource.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (conFileResource.FileLength  ==  AttributeName[intIndex])
{
return mlngFileLength;
}
else if (conFileResource.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (conFileResource.CreationTime  ==  AttributeName[intIndex])
{
return mstrCreationTime;
}
else if (conFileResource.LastWriteTime  ==  AttributeName[intIndex])
{
return mstrLastWriteTime;
}
else if (conFileResource.CheckDateTime  ==  AttributeName[intIndex])
{
return mstrCheckDateTime;
}
else if (conFileResource.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (conFileResource.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conFileResource.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (conFileResource.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFileResource.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFileResource.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFileResource.FileResourceID  ==  AttributeName[intIndex])
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResource.FileResourceID);
}
else if (conFileResource.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conFileResource.IpAddress);
}
else if (conFileResource.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(conFileResource.FileDirName);
}
else if (conFileResource.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conFileResource.FileName);
}
else if (conFileResource.FileNameBak  ==  AttributeName[intIndex])
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(conFileResource.FileNameBak);
}
else if (conFileResource.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(conFileResource.Extension);
}
else if (conFileResource.FileLength  ==  AttributeName[intIndex])
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResource.FileLength);
}
else if (conFileResource.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFileResource.FileType);
}
else if (conFileResource.CreationTime  ==  AttributeName[intIndex])
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(conFileResource.CreationTime);
}
else if (conFileResource.LastWriteTime  ==  AttributeName[intIndex])
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(conFileResource.LastWriteTime);
}
else if (conFileResource.CheckDateTime  ==  AttributeName[intIndex])
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(conFileResource.CheckDateTime);
}
else if (conFileResource.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFileResource.IdFtpResource);
}
else if (conFileResource.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.InUse);
}
else if (conFileResource.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsExistFile);
}
else if (conFileResource.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFileResource.UpdDate);
}
else if (conFileResource.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFileResource.UpdUser);
}
else if (conFileResource.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFileResource.Memo);
}
}
}

/// <summary>
/// FileResourceID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long FileResourceID
{
get
{
return mlngFileResourceID;
}
set
{
 mlngFileResourceID = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.FileResourceID);
}
}
/// <summary>
/// Ip地址(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.IpAddress);
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
 AddUpdatedFld(conFileResource.FileDirName);
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
 AddUpdatedFld(conFileResource.FileName);
}
}
/// <summary>
/// FileName_Bak(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileNameBak
{
get
{
return mstrFileNameBak;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileNameBak = value;
}
else
{
 mstrFileNameBak = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.FileNameBak);
}
}
/// <summary>
/// 扩展名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Extension
{
get
{
return mstrExtension;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExtension = value;
}
else
{
 mstrExtension = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.Extension);
}
}
/// <summary>
/// 文件长度(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? FileLength
{
get
{
return mlngFileLength;
}
set
{
 mlngFileLength = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.FileLength);
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
 AddUpdatedFld(conFileResource.FileType);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreationTime
{
get
{
return mstrCreationTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreationTime = value;
}
else
{
 mstrCreationTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.CreationTime);
}
}
/// <summary>
/// 最后修改时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastWriteTime
{
get
{
return mstrLastWriteTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastWriteTime = value;
}
else
{
 mstrLastWriteTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.LastWriteTime);
}
}
/// <summary>
/// CheckDateTime(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDateTime
{
get
{
return mstrCheckDateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDateTime = value;
}
else
{
 mstrCheckDateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.CheckDateTime);
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
 AddUpdatedFld(conFileResource.IdFtpResource);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.InUse);
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
 AddUpdatedFld(conFileResource.IsExistFile);
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
 AddUpdatedFld(conFileResource.UpdDate);
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
 AddUpdatedFld(conFileResource.UpdUser);
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
 AddUpdatedFld(conFileResource.Memo);
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
  return mlngFileResourceID.ToString();
 }
 }
}
 /// <summary>
 /// 文件资源(FileResource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFileResource
{
public const string _CurrTabName = "FileResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FileResourceID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FileResourceID", "IpAddress", "FileDirName", "FileName", "FileNameBak", "Extension", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "IdFtpResource", "InUse", "IsExistFile", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FileResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileResourceID = "FileResourceID";    //FileResourceID

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //Ip地址

 /// <summary>
 /// 常量:"FileDirName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileDirName = "FileDirName";    //文件目录名

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"FileNameBak"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNameBak = "FileNameBak";    //FileName_Bak

 /// <summary>
 /// 常量:"Extension"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Extension = "Extension";    //扩展名

 /// <summary>
 /// 常量:"FileLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileLength = "FileLength";    //文件长度

 /// <summary>
 /// 常量:"FileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileType = "FileType";    //文件类型

 /// <summary>
 /// 常量:"CreationTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreationTime = "CreationTime";    //建立时间

 /// <summary>
 /// 常量:"LastWriteTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastWriteTime = "LastWriteTime";    //最后修改时间

 /// <summary>
 /// 常量:"CheckDateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDateTime = "CheckDateTime";    //CheckDateTime

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

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