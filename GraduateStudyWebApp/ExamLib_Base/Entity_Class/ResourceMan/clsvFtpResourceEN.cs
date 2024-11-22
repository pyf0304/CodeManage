
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFtpResourceEN
 表名:vFtpResource(01120500)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:38
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
 /// 表vFtpResource的关键字(IdFtpResource)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdFtpResource_vFtpResource
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdFtpResource">表关键字</param>
public K_IdFtpResource_vFtpResource(string strIdFtpResource)
{
if (IsValid(strIdFtpResource)) Value = strIdFtpResource;
else
{
Value = null;
}
}
private static bool IsValid(string strIdFtpResource)
{
if (string.IsNullOrEmpty(strIdFtpResource) == true) return false;
if (strIdFtpResource.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdFtpResource_vFtpResource]类型的对象</returns>
public static implicit operator K_IdFtpResource_vFtpResource(string value)
{
return new K_IdFtpResource_vFtpResource(value);
}
}
 /// <summary>
 /// vFTP资源(vFtpResource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFtpResourceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFtpResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdFtpResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 21;
public static string[] AttributeName = new string[] {"IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileNameBak", "FileUpDate", "FileUpTime", "FileSize", "FileType", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "CheckDateTime", "ResourceOwner", "IsExistFile", "FileResourceID", "UpdDate", "UpdUser", "Memo"};

protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileNameBak;    //FileName_Bak
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected string mstrFileSize;    //文件大小
protected string mstrFileType;    //文件类型
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected int? mintOrderNum;    //序号
protected string mstrCheckDateTime;    //CheckDateTime
protected string mstrResourceOwner;    //上传者
protected bool mbolIsExistFile;    //是否存在文件
protected long mlngFileResourceID;    //FileResourceID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFtpResourceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdFtpResource");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdFtpResource">关键字:FTP资源流水号</param>
public clsvFtpResourceEN(string strIdFtpResource)
 {
strIdFtpResource = strIdFtpResource.Replace("'", "''");
if (strIdFtpResource.Length > 8)
{
throw new Exception("在表:vFtpResource中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdFtpResource)  ==  true)
{
throw new Exception("在表:vFtpResource中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdFtpResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdFtpResource = strIdFtpResource;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdFtpResource");
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
if (strAttributeName  ==  convFtpResource.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convFtpResource.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convFtpResource.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convFtpResource.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convFtpResource.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convFtpResource.FileNameBak)
{
return mstrFileNameBak;
}
else if (strAttributeName  ==  convFtpResource.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convFtpResource.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convFtpResource.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convFtpResource.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convFtpResource.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convFtpResource.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convFtpResource.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convFtpResource.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFtpResource.CheckDateTime)
{
return mstrCheckDateTime;
}
else if (strAttributeName  ==  convFtpResource.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convFtpResource.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convFtpResource.FileResourceID)
{
return mlngFileResourceID;
}
else if (strAttributeName  ==  convFtpResource.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFtpResource.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFtpResource.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFtpResource.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convFtpResource.IdFtpResource);
}
else if (strAttributeName  ==  convFtpResource.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convFtpResource.FtpResourceID);
}
else if (strAttributeName  ==  convFtpResource.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convFtpResource.FileOriginalName);
}
else if (strAttributeName  ==  convFtpResource.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convFtpResource.FileDirName);
}
else if (strAttributeName  ==  convFtpResource.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convFtpResource.FileRename);
}
else if (strAttributeName  ==  convFtpResource.FileNameBak)
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(convFtpResource.FileNameBak);
}
else if (strAttributeName  ==  convFtpResource.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convFtpResource.FileUpDate);
}
else if (strAttributeName  ==  convFtpResource.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convFtpResource.FileUpTime);
}
else if (strAttributeName  ==  convFtpResource.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convFtpResource.FileSize);
}
else if (strAttributeName  ==  convFtpResource.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convFtpResource.FileType);
}
else if (strAttributeName  ==  convFtpResource.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convFtpResource.FuncModuleId);
}
else if (strAttributeName  ==  convFtpResource.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convFtpResource.FuncModuleName);
}
else if (strAttributeName  ==  convFtpResource.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convFtpResource.FuncModuleNameSim);
}
else if (strAttributeName  ==  convFtpResource.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResource.OrderNum);
}
else if (strAttributeName  ==  convFtpResource.CheckDateTime)
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(convFtpResource.CheckDateTime);
}
else if (strAttributeName  ==  convFtpResource.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convFtpResource.ResourceOwner);
}
else if (strAttributeName  ==  convFtpResource.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convFtpResource.IsExistFile);
}
else if (strAttributeName  ==  convFtpResource.FileResourceID)
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResource.FileResourceID);
}
else if (strAttributeName  ==  convFtpResource.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFtpResource.UpdDate);
}
else if (strAttributeName  ==  convFtpResource.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFtpResource.UpdUser);
}
else if (strAttributeName  ==  convFtpResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFtpResource.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFtpResource.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convFtpResource.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convFtpResource.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convFtpResource.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convFtpResource.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convFtpResource.FileNameBak  ==  AttributeName[intIndex])
{
return mstrFileNameBak;
}
else if (convFtpResource.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convFtpResource.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convFtpResource.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convFtpResource.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convFtpResource.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convFtpResource.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convFtpResource.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convFtpResource.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFtpResource.CheckDateTime  ==  AttributeName[intIndex])
{
return mstrCheckDateTime;
}
else if (convFtpResource.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convFtpResource.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convFtpResource.FileResourceID  ==  AttributeName[intIndex])
{
return mlngFileResourceID;
}
else if (convFtpResource.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFtpResource.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFtpResource.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFtpResource.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convFtpResource.IdFtpResource);
}
else if (convFtpResource.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convFtpResource.FtpResourceID);
}
else if (convFtpResource.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convFtpResource.FileOriginalName);
}
else if (convFtpResource.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convFtpResource.FileDirName);
}
else if (convFtpResource.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convFtpResource.FileRename);
}
else if (convFtpResource.FileNameBak  ==  AttributeName[intIndex])
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(convFtpResource.FileNameBak);
}
else if (convFtpResource.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convFtpResource.FileUpDate);
}
else if (convFtpResource.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convFtpResource.FileUpTime);
}
else if (convFtpResource.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convFtpResource.FileSize);
}
else if (convFtpResource.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convFtpResource.FileType);
}
else if (convFtpResource.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convFtpResource.FuncModuleId);
}
else if (convFtpResource.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convFtpResource.FuncModuleName);
}
else if (convFtpResource.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convFtpResource.FuncModuleNameSim);
}
else if (convFtpResource.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResource.OrderNum);
}
else if (convFtpResource.CheckDateTime  ==  AttributeName[intIndex])
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(convFtpResource.CheckDateTime);
}
else if (convFtpResource.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convFtpResource.ResourceOwner);
}
else if (convFtpResource.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convFtpResource.IsExistFile);
}
else if (convFtpResource.FileResourceID  ==  AttributeName[intIndex])
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(convFtpResource.FileResourceID);
}
else if (convFtpResource.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFtpResource.UpdDate);
}
else if (convFtpResource.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFtpResource.UpdUser);
}
else if (convFtpResource.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFtpResource.Memo);
}
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
 AddUpdatedFld(convFtpResource.IdFtpResource);
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
 AddUpdatedFld(convFtpResource.FtpResourceID);
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
 AddUpdatedFld(convFtpResource.FileOriginalName);
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
 AddUpdatedFld(convFtpResource.FileDirName);
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
 AddUpdatedFld(convFtpResource.FileRename);
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
 AddUpdatedFld(convFtpResource.FileNameBak);
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
 AddUpdatedFld(convFtpResource.FileUpDate);
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
 AddUpdatedFld(convFtpResource.FileUpTime);
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
 AddUpdatedFld(convFtpResource.FileSize);
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
 AddUpdatedFld(convFtpResource.FileType);
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
 AddUpdatedFld(convFtpResource.FuncModuleId);
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
 AddUpdatedFld(convFtpResource.FuncModuleName);
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
 AddUpdatedFld(convFtpResource.FuncModuleNameSim);
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
 AddUpdatedFld(convFtpResource.OrderNum);
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
 AddUpdatedFld(convFtpResource.CheckDateTime);
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
 AddUpdatedFld(convFtpResource.ResourceOwner);
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
 AddUpdatedFld(convFtpResource.IsExistFile);
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
 AddUpdatedFld(convFtpResource.FileResourceID);
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
 AddUpdatedFld(convFtpResource.UpdDate);
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
 AddUpdatedFld(convFtpResource.UpdUser);
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
 AddUpdatedFld(convFtpResource.Memo);
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
  return mstrIdFtpResource;
 }
 }
}
 /// <summary>
 /// vFTP资源(vFtpResource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFtpResource
{
public const string _CurrTabName = "vFtpResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdFtpResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileNameBak", "FileUpDate", "FileUpTime", "FileSize", "FileType", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "CheckDateTime", "ResourceOwner", "IsExistFile", "FileResourceID", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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
 /// 常量:"FileNameBak"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNameBak = "FileNameBak";    //FileName_Bak

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
 /// 常量:"CheckDateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDateTime = "CheckDateTime";    //CheckDateTime

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
 /// 常量:"FileResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileResourceID = "FileResourceID";    //FileResourceID

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