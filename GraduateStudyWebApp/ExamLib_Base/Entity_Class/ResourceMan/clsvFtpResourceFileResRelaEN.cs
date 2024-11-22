
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFtpResourceFileResRelaEN
 表名:vFtpResourceFileResRela(01120376)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:40
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
 /// 表vFtpResourceFileResRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vFtpResourceFileResRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vFtpResourceFileResRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vFtpResourceFileResRela]类型的对象</returns>
public static implicit operator K_mId_vFtpResourceFileResRela(long value)
{
return new K_mId_vFtpResourceFileResRela(value);
}
}
 /// <summary>
 /// vFtp资源文件资源关系(vFtpResourceFileResRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFtpResourceFileResRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFtpResourceFileResRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"mId", "FileResourceID", "IpAddress", "FileDirName", "FileName", "FileNameBak", "Extension", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "InUse", "IsExistFile", "IdFtpResource", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
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
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFtpResourceFileResRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvFtpResourceFileResRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convFtpResourceFileResRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileResourceID)
{
return mlngFileResourceID;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileNameBak)
{
return mstrFileNameBak;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileLength)
{
return mlngFileLength;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.CreationTime)
{
return mstrCreationTime;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.LastWriteTime)
{
return mstrLastWriteTime;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.CheckDateTime)
{
return mstrCheckDateTime;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFtpResourceFileResRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFtpResourceFileResRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.mId);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileResourceID)
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.FileResourceID);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.IpAddress);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FileDirName);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FileName);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileNameBak)
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FileNameBak);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.Extension);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileLength)
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.FileLength);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FileType);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.CreationTime)
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.CreationTime);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.LastWriteTime)
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.LastWriteTime);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.CheckDateTime)
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.CheckDateTime);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.InUse);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.IsExistFile);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.IdFtpResource);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleId);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleName);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleNameSim);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.OrderNum);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.UpdDate);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.UpdUser);
}
else if (strAttributeName  ==  convFtpResourceFileResRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFtpResourceFileResRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convFtpResourceFileResRela.FileResourceID  ==  AttributeName[intIndex])
{
return mlngFileResourceID;
}
else if (convFtpResourceFileResRela.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convFtpResourceFileResRela.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convFtpResourceFileResRela.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convFtpResourceFileResRela.FileNameBak  ==  AttributeName[intIndex])
{
return mstrFileNameBak;
}
else if (convFtpResourceFileResRela.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (convFtpResourceFileResRela.FileLength  ==  AttributeName[intIndex])
{
return mlngFileLength;
}
else if (convFtpResourceFileResRela.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convFtpResourceFileResRela.CreationTime  ==  AttributeName[intIndex])
{
return mstrCreationTime;
}
else if (convFtpResourceFileResRela.LastWriteTime  ==  AttributeName[intIndex])
{
return mstrLastWriteTime;
}
else if (convFtpResourceFileResRela.CheckDateTime  ==  AttributeName[intIndex])
{
return mstrCheckDateTime;
}
else if (convFtpResourceFileResRela.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convFtpResourceFileResRela.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convFtpResourceFileResRela.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convFtpResourceFileResRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convFtpResourceFileResRela.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convFtpResourceFileResRela.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convFtpResourceFileResRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFtpResourceFileResRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFtpResourceFileResRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFtpResourceFileResRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFtpResourceFileResRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.mId);
}
else if (convFtpResourceFileResRela.FileResourceID  ==  AttributeName[intIndex])
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.FileResourceID);
}
else if (convFtpResourceFileResRela.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.IpAddress);
}
else if (convFtpResourceFileResRela.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FileDirName);
}
else if (convFtpResourceFileResRela.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FileName);
}
else if (convFtpResourceFileResRela.FileNameBak  ==  AttributeName[intIndex])
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FileNameBak);
}
else if (convFtpResourceFileResRela.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.Extension);
}
else if (convFtpResourceFileResRela.FileLength  ==  AttributeName[intIndex])
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.FileLength);
}
else if (convFtpResourceFileResRela.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FileType);
}
else if (convFtpResourceFileResRela.CreationTime  ==  AttributeName[intIndex])
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.CreationTime);
}
else if (convFtpResourceFileResRela.LastWriteTime  ==  AttributeName[intIndex])
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.LastWriteTime);
}
else if (convFtpResourceFileResRela.CheckDateTime  ==  AttributeName[intIndex])
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.CheckDateTime);
}
else if (convFtpResourceFileResRela.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.InUse);
}
else if (convFtpResourceFileResRela.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.IsExistFile);
}
else if (convFtpResourceFileResRela.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.IdFtpResource);
}
else if (convFtpResourceFileResRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleId);
}
else if (convFtpResourceFileResRela.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleName);
}
else if (convFtpResourceFileResRela.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleNameSim);
}
else if (convFtpResourceFileResRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResourceFileResRela.OrderNum);
}
else if (convFtpResourceFileResRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.UpdDate);
}
else if (convFtpResourceFileResRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.UpdUser);
}
else if (convFtpResourceFileResRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFtpResourceFileResRela.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convFtpResourceFileResRela.mId);
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
 AddUpdatedFld(convFtpResourceFileResRela.FileResourceID);
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
 AddUpdatedFld(convFtpResourceFileResRela.IpAddress);
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
 AddUpdatedFld(convFtpResourceFileResRela.FileDirName);
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
 AddUpdatedFld(convFtpResourceFileResRela.FileName);
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
 AddUpdatedFld(convFtpResourceFileResRela.FileNameBak);
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
 AddUpdatedFld(convFtpResourceFileResRela.Extension);
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
 AddUpdatedFld(convFtpResourceFileResRela.FileLength);
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
 AddUpdatedFld(convFtpResourceFileResRela.FileType);
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
 AddUpdatedFld(convFtpResourceFileResRela.CreationTime);
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
 AddUpdatedFld(convFtpResourceFileResRela.LastWriteTime);
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
 AddUpdatedFld(convFtpResourceFileResRela.CheckDateTime);
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
 AddUpdatedFld(convFtpResourceFileResRela.InUse);
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
 AddUpdatedFld(convFtpResourceFileResRela.IsExistFile);
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
 AddUpdatedFld(convFtpResourceFileResRela.IdFtpResource);
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
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleId);
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
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleName);
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
 AddUpdatedFld(convFtpResourceFileResRela.FuncModuleNameSim);
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
 AddUpdatedFld(convFtpResourceFileResRela.OrderNum);
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
 AddUpdatedFld(convFtpResourceFileResRela.UpdDate);
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
 AddUpdatedFld(convFtpResourceFileResRela.UpdUser);
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
 AddUpdatedFld(convFtpResourceFileResRela.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// vFtp资源文件资源关系(vFtpResourceFileResRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFtpResourceFileResRela
{
public const string _CurrTabName = "vFtpResourceFileResRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FileResourceID", "IpAddress", "FileDirName", "FileName", "FileNameBak", "Extension", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "InUse", "IsExistFile", "IdFtpResource", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

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