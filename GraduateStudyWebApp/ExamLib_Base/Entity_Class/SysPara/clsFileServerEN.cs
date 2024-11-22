
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileServerEN
 表名:FileServer(01120325)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表FileServer的关键字(IdFile)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdFile_FileServer
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdFile">表关键字</param>
public K_IdFile_FileServer(string strIdFile)
{
if (IsValid(strIdFile)) Value = strIdFile;
else
{
Value = null;
}
}
private static bool IsValid(string strIdFile)
{
if (string.IsNullOrEmpty(strIdFile) == true) return false;
if (strIdFile.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdFile_FileServer]类型的对象</returns>
public static implicit operator K_IdFile_FileServer(string value)
{
return new K_IdFile_FileServer(value);
}
}
 /// <summary>
 /// 文件服务(FileServer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFileServerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FileServer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdFile"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"IdFile", "FileName", "FileContent", "FileType", "SaveDate", "FileSize", "SaveTime", "ResourceOwner", "FileOriginName"};

protected string mstrIdFile;    //文件流水号
protected string mstrFileName;    //文件名称
protected byte[] mbytFileContent;    //文件内容
protected string mstrFileType;    //文件类型
protected string mstrSaveDate;    //创建日期
protected string mstrFileSize;    //文件大小
protected string mstrSaveTime;    //创建时间
protected string mstrResourceOwner;    //上传者
protected string mstrFileOriginName;    //原文件名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFileServerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdFile");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdFile">关键字:文件流水号</param>
public clsFileServerEN(string strIdFile)
 {
strIdFile = strIdFile.Replace("'", "''");
if (strIdFile.Length > 8)
{
throw new Exception("在表:FileServer中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdFile)  ==  true)
{
throw new Exception("在表:FileServer中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdFile);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdFile = strIdFile;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdFile");
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
if (strAttributeName  ==  conFileServer.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  conFileServer.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conFileServer.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  conFileServer.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  conFileServer.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  conFileServer.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  conFileServer.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  conFileServer.FileOriginName)
{
return mstrFileOriginName;
}
return null;
}
set
{
if (strAttributeName  ==  conFileServer.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(conFileServer.IdFile);
}
else if (strAttributeName  ==  conFileServer.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conFileServer.FileName);
}
else if (strAttributeName  ==  conFileServer.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFileServer.FileType);
}
else if (strAttributeName  ==  conFileServer.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(conFileServer.SaveDate);
}
else if (strAttributeName  ==  conFileServer.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(conFileServer.FileSize);
}
else if (strAttributeName  ==  conFileServer.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(conFileServer.SaveTime);
}
else if (strAttributeName  ==  conFileServer.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(conFileServer.ResourceOwner);
}
else if (strAttributeName  ==  conFileServer.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(conFileServer.FileOriginName);
}
}
}
public object this[int intIndex]
{
get
{
if (conFileServer.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (conFileServer.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conFileServer.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (conFileServer.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (conFileServer.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (conFileServer.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (conFileServer.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (conFileServer.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
return null;
}
set
{
if (conFileServer.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(conFileServer.IdFile);
}
else if (conFileServer.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conFileServer.FileName);
}
else if (conFileServer.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFileServer.FileType);
}
else if (conFileServer.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(conFileServer.SaveDate);
}
else if (conFileServer.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(conFileServer.FileSize);
}
else if (conFileServer.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(conFileServer.SaveTime);
}
else if (conFileServer.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(conFileServer.ResourceOwner);
}
else if (conFileServer.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(conFileServer.FileOriginName);
}
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
 AddUpdatedFld(conFileServer.IdFile);
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
 AddUpdatedFld(conFileServer.FileName);
}
}
/// <summary>
/// 文件内容(说明:;字段类型:image;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public byte[] FileContent
{
get
{
return mbytFileContent;
}
set
{
 mbytFileContent = value;
//记录修改过的字段
 AddUpdatedFld(conFileServer.FileContent);
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
 AddUpdatedFld(conFileServer.FileType);
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
 AddUpdatedFld(conFileServer.SaveDate);
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
 AddUpdatedFld(conFileServer.FileSize);
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
 AddUpdatedFld(conFileServer.SaveTime);
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
 AddUpdatedFld(conFileServer.ResourceOwner);
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
 AddUpdatedFld(conFileServer.FileOriginName);
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
  return mstrIdFile;
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
  return mstrFileName;
 }
 }
}
 /// <summary>
 /// 文件服务(FileServer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFileServer
{
public const string _CurrTabName = "FileServer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdFile"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdFile", "FileName", "FileContent", "FileType", "SaveDate", "FileSize", "SaveTime", "ResourceOwner", "FileOriginName"};
//以下是属性变量


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
 /// 常量:"FileContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileContent = "FileContent";    //文件内容

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
 /// 常量:"ResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceOwner = "ResourceOwner";    //上传者

 /// <summary>
 /// 常量:"FileOriginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginName = "FileOriginName";    //原文件名
}

}