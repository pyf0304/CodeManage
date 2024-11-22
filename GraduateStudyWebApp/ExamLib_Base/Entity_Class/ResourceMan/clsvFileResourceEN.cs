
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFileResourceEN
 表名:vFileResource(01120374)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:34
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
 /// 表vFileResource的关键字(FileResourceID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FileResourceID_vFileResource
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
public K_FileResourceID_vFileResource(long lngFileResourceID)
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
 /// <returns>返回:[K_FileResourceID_vFileResource]类型的对象</returns>
public static implicit operator K_FileResourceID_vFileResource(long value)
{
return new K_FileResourceID_vFileResource(value);
}
}
 /// <summary>
 /// v文件资源(vFileResource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFileResourceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFileResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FileResourceID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"FileResourceID", "IpAddress", "FileDirName", "FileName", "FileNameBak", "Extension", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "InUse", "IsExistFile", "UpdDate", "UpdUser", "Memo", "FtpResourceCount"};

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
protected bool mbolInUse;    //是否在用
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected int? mintFtpResourceCount;    //Ftp资源数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFileResourceEN()
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
public clsvFileResourceEN(long lngFileResourceID)
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
if (strAttributeName  ==  convFileResource.FileResourceID)
{
return mlngFileResourceID;
}
else if (strAttributeName  ==  convFileResource.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convFileResource.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convFileResource.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convFileResource.FileNameBak)
{
return mstrFileNameBak;
}
else if (strAttributeName  ==  convFileResource.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  convFileResource.FileLength)
{
return mlngFileLength;
}
else if (strAttributeName  ==  convFileResource.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convFileResource.CreationTime)
{
return mstrCreationTime;
}
else if (strAttributeName  ==  convFileResource.LastWriteTime)
{
return mstrLastWriteTime;
}
else if (strAttributeName  ==  convFileResource.CheckDateTime)
{
return mstrCheckDateTime;
}
else if (strAttributeName  ==  convFileResource.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convFileResource.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convFileResource.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFileResource.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFileResource.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFileResource.FtpResourceCount)
{
return mintFtpResourceCount;
}
return null;
}
set
{
if (strAttributeName  ==  convFileResource.FileResourceID)
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FileResourceID);
}
else if (strAttributeName  ==  convFileResource.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convFileResource.IpAddress);
}
else if (strAttributeName  ==  convFileResource.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convFileResource.FileDirName);
}
else if (strAttributeName  ==  convFileResource.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convFileResource.FileName);
}
else if (strAttributeName  ==  convFileResource.FileNameBak)
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(convFileResource.FileNameBak);
}
else if (strAttributeName  ==  convFileResource.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(convFileResource.Extension);
}
else if (strAttributeName  ==  convFileResource.FileLength)
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FileLength);
}
else if (strAttributeName  ==  convFileResource.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convFileResource.FileType);
}
else if (strAttributeName  ==  convFileResource.CreationTime)
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(convFileResource.CreationTime);
}
else if (strAttributeName  ==  convFileResource.LastWriteTime)
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(convFileResource.LastWriteTime);
}
else if (strAttributeName  ==  convFileResource.CheckDateTime)
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(convFileResource.CheckDateTime);
}
else if (strAttributeName  ==  convFileResource.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.InUse);
}
else if (strAttributeName  ==  convFileResource.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsExistFile);
}
else if (strAttributeName  ==  convFileResource.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFileResource.UpdDate);
}
else if (strAttributeName  ==  convFileResource.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFileResource.UpdUser);
}
else if (strAttributeName  ==  convFileResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFileResource.Memo);
}
else if (strAttributeName  ==  convFileResource.FtpResourceCount)
{
mintFtpResourceCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FtpResourceCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convFileResource.FileResourceID  ==  AttributeName[intIndex])
{
return mlngFileResourceID;
}
else if (convFileResource.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convFileResource.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convFileResource.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convFileResource.FileNameBak  ==  AttributeName[intIndex])
{
return mstrFileNameBak;
}
else if (convFileResource.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (convFileResource.FileLength  ==  AttributeName[intIndex])
{
return mlngFileLength;
}
else if (convFileResource.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convFileResource.CreationTime  ==  AttributeName[intIndex])
{
return mstrCreationTime;
}
else if (convFileResource.LastWriteTime  ==  AttributeName[intIndex])
{
return mstrLastWriteTime;
}
else if (convFileResource.CheckDateTime  ==  AttributeName[intIndex])
{
return mstrCheckDateTime;
}
else if (convFileResource.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convFileResource.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convFileResource.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFileResource.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFileResource.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFileResource.FtpResourceCount  ==  AttributeName[intIndex])
{
return mintFtpResourceCount;
}
return null;
}
set
{
if (convFileResource.FileResourceID  ==  AttributeName[intIndex])
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FileResourceID);
}
else if (convFileResource.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convFileResource.IpAddress);
}
else if (convFileResource.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convFileResource.FileDirName);
}
else if (convFileResource.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convFileResource.FileName);
}
else if (convFileResource.FileNameBak  ==  AttributeName[intIndex])
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(convFileResource.FileNameBak);
}
else if (convFileResource.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(convFileResource.Extension);
}
else if (convFileResource.FileLength  ==  AttributeName[intIndex])
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FileLength);
}
else if (convFileResource.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convFileResource.FileType);
}
else if (convFileResource.CreationTime  ==  AttributeName[intIndex])
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(convFileResource.CreationTime);
}
else if (convFileResource.LastWriteTime  ==  AttributeName[intIndex])
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(convFileResource.LastWriteTime);
}
else if (convFileResource.CheckDateTime  ==  AttributeName[intIndex])
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(convFileResource.CheckDateTime);
}
else if (convFileResource.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.InUse);
}
else if (convFileResource.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsExistFile);
}
else if (convFileResource.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFileResource.UpdDate);
}
else if (convFileResource.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFileResource.UpdUser);
}
else if (convFileResource.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFileResource.Memo);
}
else if (convFileResource.FtpResourceCount  ==  AttributeName[intIndex])
{
mintFtpResourceCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FtpResourceCount);
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
 AddUpdatedFld(convFileResource.FileResourceID);
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
 AddUpdatedFld(convFileResource.IpAddress);
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
 AddUpdatedFld(convFileResource.FileDirName);
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
 AddUpdatedFld(convFileResource.FileName);
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
 AddUpdatedFld(convFileResource.FileNameBak);
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
 AddUpdatedFld(convFileResource.Extension);
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
 AddUpdatedFld(convFileResource.FileLength);
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
 AddUpdatedFld(convFileResource.FileType);
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
 AddUpdatedFld(convFileResource.CreationTime);
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
 AddUpdatedFld(convFileResource.LastWriteTime);
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
 AddUpdatedFld(convFileResource.CheckDateTime);
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
 AddUpdatedFld(convFileResource.InUse);
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
 AddUpdatedFld(convFileResource.IsExistFile);
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
 AddUpdatedFld(convFileResource.UpdDate);
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
 AddUpdatedFld(convFileResource.UpdUser);
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
 AddUpdatedFld(convFileResource.Memo);
}
}
/// <summary>
/// Ftp资源数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FtpResourceCount
{
get
{
return mintFtpResourceCount;
}
set
{
 mintFtpResourceCount = value;
//记录修改过的字段
 AddUpdatedFld(convFileResource.FtpResourceCount);
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
 /// v文件资源(vFileResource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFileResource
{
public const string _CurrTabName = "vFileResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FileResourceID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FileResourceID", "IpAddress", "FileDirName", "FileName", "FileNameBak", "Extension", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "InUse", "IsExistFile", "UpdDate", "UpdUser", "Memo", "FtpResourceCount"};
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

 /// <summary>
 /// 常量:"FtpResourceCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpResourceCount = "FtpResourceCount";    //Ftp资源数
}

}