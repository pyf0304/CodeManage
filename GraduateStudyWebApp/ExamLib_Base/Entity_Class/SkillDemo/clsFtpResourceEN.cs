
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFtpResourceEN
 表名:FtpResource(01120326)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表FtpResource的关键字(IdFtpResource)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdFtpResource_FtpResource
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
public K_IdFtpResource_FtpResource(string strIdFtpResource)
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
 /// <returns>返回:[K_IdFtpResource_FtpResource]类型的对象</returns>
public static implicit operator K_IdFtpResource_FtpResource(string value)
{
return new K_IdFtpResource_FtpResource(value);
}
}
 /// <summary>
 /// FTP资源(FtpResource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFtpResourceEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FtpResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdFtpResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "Memo", "FileSize", "FileType", "CheckDateTime", "ResourceOwner", "IsExistFile", "FuncModuleId", "FileResourceID", "FileNameBak", "UpdDate", "UpdUser"};

protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected string mstrMemo;    //备注
protected string mstrFileSize;    //文件大小
protected string mstrFileType;    //文件类型
protected string mstrCheckDateTime;    //CheckDateTime
protected string mstrResourceOwner;    //上传者
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrFuncModuleId;    //功能模块Id
protected long mlngFileResourceID;    //FileResourceID
protected string mstrFileNameBak;    //FileName_Bak
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFtpResourceEN()
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
public clsFtpResourceEN(string strIdFtpResource)
 {
strIdFtpResource = strIdFtpResource.Replace("'", "''");
if (strIdFtpResource.Length > 8)
{
throw new Exception("在表:FtpResource中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdFtpResource)  ==  true)
{
throw new Exception("在表:FtpResource中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conFtpResource.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  conFtpResource.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  conFtpResource.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  conFtpResource.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  conFtpResource.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  conFtpResource.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  conFtpResource.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  conFtpResource.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conFtpResource.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  conFtpResource.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  conFtpResource.CheckDateTime)
{
return mstrCheckDateTime;
}
else if (strAttributeName  ==  conFtpResource.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  conFtpResource.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  conFtpResource.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conFtpResource.FileResourceID)
{
return mlngFileResourceID;
}
else if (strAttributeName  ==  conFtpResource.FileNameBak)
{
return mstrFileNameBak;
}
else if (strAttributeName  ==  conFtpResource.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFtpResource.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conFtpResource.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFtpResource.IdFtpResource);
}
else if (strAttributeName  ==  conFtpResource.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(conFtpResource.FtpResourceID);
}
else if (strAttributeName  ==  conFtpResource.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(conFtpResource.FileOriginalName);
}
else if (strAttributeName  ==  conFtpResource.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(conFtpResource.FileDirName);
}
else if (strAttributeName  ==  conFtpResource.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(conFtpResource.FileRename);
}
else if (strAttributeName  ==  conFtpResource.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(conFtpResource.FileUpDate);
}
else if (strAttributeName  ==  conFtpResource.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(conFtpResource.FileUpTime);
}
else if (strAttributeName  ==  conFtpResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFtpResource.Memo);
}
else if (strAttributeName  ==  conFtpResource.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(conFtpResource.FileSize);
}
else if (strAttributeName  ==  conFtpResource.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFtpResource.FileType);
}
else if (strAttributeName  ==  conFtpResource.CheckDateTime)
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(conFtpResource.CheckDateTime);
}
else if (strAttributeName  ==  conFtpResource.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(conFtpResource.ResourceOwner);
}
else if (strAttributeName  ==  conFtpResource.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(conFtpResource.IsExistFile);
}
else if (strAttributeName  ==  conFtpResource.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conFtpResource.FuncModuleId);
}
else if (strAttributeName  ==  conFtpResource.FileResourceID)
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(conFtpResource.FileResourceID);
}
else if (strAttributeName  ==  conFtpResource.FileNameBak)
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(conFtpResource.FileNameBak);
}
else if (strAttributeName  ==  conFtpResource.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFtpResource.UpdDate);
}
else if (strAttributeName  ==  conFtpResource.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFtpResource.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conFtpResource.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (conFtpResource.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (conFtpResource.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (conFtpResource.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (conFtpResource.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (conFtpResource.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (conFtpResource.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (conFtpResource.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conFtpResource.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (conFtpResource.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (conFtpResource.CheckDateTime  ==  AttributeName[intIndex])
{
return mstrCheckDateTime;
}
else if (conFtpResource.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (conFtpResource.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (conFtpResource.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conFtpResource.FileResourceID  ==  AttributeName[intIndex])
{
return mlngFileResourceID;
}
else if (conFtpResource.FileNameBak  ==  AttributeName[intIndex])
{
return mstrFileNameBak;
}
else if (conFtpResource.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFtpResource.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conFtpResource.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFtpResource.IdFtpResource);
}
else if (conFtpResource.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(conFtpResource.FtpResourceID);
}
else if (conFtpResource.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(conFtpResource.FileOriginalName);
}
else if (conFtpResource.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(conFtpResource.FileDirName);
}
else if (conFtpResource.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(conFtpResource.FileRename);
}
else if (conFtpResource.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(conFtpResource.FileUpDate);
}
else if (conFtpResource.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(conFtpResource.FileUpTime);
}
else if (conFtpResource.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFtpResource.Memo);
}
else if (conFtpResource.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(conFtpResource.FileSize);
}
else if (conFtpResource.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFtpResource.FileType);
}
else if (conFtpResource.CheckDateTime  ==  AttributeName[intIndex])
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(conFtpResource.CheckDateTime);
}
else if (conFtpResource.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(conFtpResource.ResourceOwner);
}
else if (conFtpResource.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(conFtpResource.IsExistFile);
}
else if (conFtpResource.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conFtpResource.FuncModuleId);
}
else if (conFtpResource.FileResourceID  ==  AttributeName[intIndex])
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(conFtpResource.FileResourceID);
}
else if (conFtpResource.FileNameBak  ==  AttributeName[intIndex])
{
mstrFileNameBak = value.ToString();
 AddUpdatedFld(conFtpResource.FileNameBak);
}
else if (conFtpResource.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFtpResource.UpdDate);
}
else if (conFtpResource.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFtpResource.UpdUser);
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
 AddUpdatedFld(conFtpResource.IdFtpResource);
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
 AddUpdatedFld(conFtpResource.FtpResourceID);
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
 AddUpdatedFld(conFtpResource.FileOriginalName);
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
 AddUpdatedFld(conFtpResource.FileDirName);
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
 AddUpdatedFld(conFtpResource.FileRename);
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
 AddUpdatedFld(conFtpResource.FileUpDate);
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
 AddUpdatedFld(conFtpResource.FileUpTime);
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
 AddUpdatedFld(conFtpResource.Memo);
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
 AddUpdatedFld(conFtpResource.FileSize);
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
 AddUpdatedFld(conFtpResource.FileType);
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
 AddUpdatedFld(conFtpResource.CheckDateTime);
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
 AddUpdatedFld(conFtpResource.ResourceOwner);
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
 AddUpdatedFld(conFtpResource.IsExistFile);
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
 AddUpdatedFld(conFtpResource.FuncModuleId);
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
 AddUpdatedFld(conFtpResource.FileResourceID);
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
 AddUpdatedFld(conFtpResource.FileNameBak);
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
 AddUpdatedFld(conFtpResource.UpdDate);
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
 AddUpdatedFld(conFtpResource.UpdUser);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrFileRename;
 }
 }
}
 /// <summary>
 /// FTP资源(FtpResource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFtpResource
{
public const string _CurrTabName = "FtpResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdFtpResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "Memo", "FileSize", "FileType", "CheckDateTime", "ResourceOwner", "IsExistFile", "FuncModuleId", "FileResourceID", "FileNameBak", "UpdDate", "UpdUser"};
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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FileResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileResourceID = "FileResourceID";    //FileResourceID

 /// <summary>
 /// 常量:"FileNameBak"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNameBak = "FileNameBak";    //FileName_Bak

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
}

}