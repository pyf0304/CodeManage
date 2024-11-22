
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDecompressionFileEN
 表名:DecompressionFile(01120522)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:附加网站(AddiSite)
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
 /// 表DecompressionFile的关键字(IdDecompressionFile)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdDecompressionFile_DecompressionFile
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdDecompressionFile">表关键字</param>
public K_IdDecompressionFile_DecompressionFile(long lngIdDecompressionFile)
{
if (IsValid(lngIdDecompressionFile)) Value = lngIdDecompressionFile;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdDecompressionFile)
{
if (lngIdDecompressionFile == 0) return false;
if (lngIdDecompressionFile == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdDecompressionFile_DecompressionFile]类型的对象</returns>
public static implicit operator K_IdDecompressionFile_DecompressionFile(long value)
{
return new K_IdDecompressionFile_DecompressionFile(value);
}
}
 /// <summary>
 /// 解压缩文件(DecompressionFile)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDecompressionFileEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DecompressionFile"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdDecompressionFile"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"IdDecompressionFile", "UploadFileDir", "UploadPerson", "NewName", "NewPath", "UploadDate", "DecompressionFilePath", "FileName", "FilePath", "FileSize", "FileSizeUnit", "IsRar", "UserId", "HomePage", "HomePageDir", "Memo", "Memo1"};

protected long mlngIdDecompressionFile;    //解压缩文件流水号
protected string mstrUploadFileDir;    //上传文件的路径
protected string mstrUploadPerson;    //上传人
protected string mstrNewName;    //新名称
protected string mstrNewPath;    //新路径
protected DateTime mdteUploadDate;    //上传时间
protected string mstrDecompressionFilePath;    //解压缩文件路径
protected string mstrFileName;    //文件名称
protected string mstrFilePath;    //文件路径
protected string mstrFileSize;    //文件大小
protected string mstrFileSizeUnit;    //文件大小单位
protected bool mbolIsRar;    //是否解压缩
protected string mstrUserId;    //用户ID
protected string mstrHomePage;    //HomePage
protected string mstrHomePageDir;    //首页文件目录
protected string mstrMemo;    //备注
protected string mstrMemo1;    //Memo1

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDecompressionFileEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDecompressionFile");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdDecompressionFile">关键字:解压缩文件流水号</param>
public clsDecompressionFileEN(long lngIdDecompressionFile)
 {
 if (lngIdDecompressionFile  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdDecompressionFile = lngIdDecompressionFile;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDecompressionFile");
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
if (strAttributeName  ==  conDecompressionFile.IdDecompressionFile)
{
return mlngIdDecompressionFile;
}
else if (strAttributeName  ==  conDecompressionFile.UploadFileDir)
{
return mstrUploadFileDir;
}
else if (strAttributeName  ==  conDecompressionFile.UploadPerson)
{
return mstrUploadPerson;
}
else if (strAttributeName  ==  conDecompressionFile.NewName)
{
return mstrNewName;
}
else if (strAttributeName  ==  conDecompressionFile.NewPath)
{
return mstrNewPath;
}
else if (strAttributeName  ==  conDecompressionFile.UploadDate)
{
return mdteUploadDate;
}
else if (strAttributeName  ==  conDecompressionFile.DecompressionFilePath)
{
return mstrDecompressionFilePath;
}
else if (strAttributeName  ==  conDecompressionFile.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conDecompressionFile.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conDecompressionFile.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  conDecompressionFile.FileSizeUnit)
{
return mstrFileSizeUnit;
}
else if (strAttributeName  ==  conDecompressionFile.IsRar)
{
return mbolIsRar;
}
else if (strAttributeName  ==  conDecompressionFile.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conDecompressionFile.HomePage)
{
return mstrHomePage;
}
else if (strAttributeName  ==  conDecompressionFile.HomePageDir)
{
return mstrHomePageDir;
}
else if (strAttributeName  ==  conDecompressionFile.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conDecompressionFile.Memo1)
{
return mstrMemo1;
}
return null;
}
set
{
if (strAttributeName  ==  conDecompressionFile.IdDecompressionFile)
{
mlngIdDecompressionFile = TransNullToInt(value.ToString());
 AddUpdatedFld(conDecompressionFile.IdDecompressionFile);
}
else if (strAttributeName  ==  conDecompressionFile.UploadFileDir)
{
mstrUploadFileDir = value.ToString();
 AddUpdatedFld(conDecompressionFile.UploadFileDir);
}
else if (strAttributeName  ==  conDecompressionFile.UploadPerson)
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(conDecompressionFile.UploadPerson);
}
else if (strAttributeName  ==  conDecompressionFile.NewName)
{
mstrNewName = value.ToString();
 AddUpdatedFld(conDecompressionFile.NewName);
}
else if (strAttributeName  ==  conDecompressionFile.NewPath)
{
mstrNewPath = value.ToString();
 AddUpdatedFld(conDecompressionFile.NewPath);
}
else if (strAttributeName  ==  conDecompressionFile.UploadDate)
{
mdteUploadDate = TransNullToDate(value.ToString());
 AddUpdatedFld(conDecompressionFile.UploadDate);
}
else if (strAttributeName  ==  conDecompressionFile.DecompressionFilePath)
{
mstrDecompressionFilePath = value.ToString();
 AddUpdatedFld(conDecompressionFile.DecompressionFilePath);
}
else if (strAttributeName  ==  conDecompressionFile.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conDecompressionFile.FileName);
}
else if (strAttributeName  ==  conDecompressionFile.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conDecompressionFile.FilePath);
}
else if (strAttributeName  ==  conDecompressionFile.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(conDecompressionFile.FileSize);
}
else if (strAttributeName  ==  conDecompressionFile.FileSizeUnit)
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(conDecompressionFile.FileSizeUnit);
}
else if (strAttributeName  ==  conDecompressionFile.IsRar)
{
mbolIsRar = TransNullToBool(value.ToString());
 AddUpdatedFld(conDecompressionFile.IsRar);
}
else if (strAttributeName  ==  conDecompressionFile.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conDecompressionFile.UserId);
}
else if (strAttributeName  ==  conDecompressionFile.HomePage)
{
mstrHomePage = value.ToString();
 AddUpdatedFld(conDecompressionFile.HomePage);
}
else if (strAttributeName  ==  conDecompressionFile.HomePageDir)
{
mstrHomePageDir = value.ToString();
 AddUpdatedFld(conDecompressionFile.HomePageDir);
}
else if (strAttributeName  ==  conDecompressionFile.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDecompressionFile.Memo);
}
else if (strAttributeName  ==  conDecompressionFile.Memo1)
{
mstrMemo1 = value.ToString();
 AddUpdatedFld(conDecompressionFile.Memo1);
}
}
}
public object this[int intIndex]
{
get
{
if (conDecompressionFile.IdDecompressionFile  ==  AttributeName[intIndex])
{
return mlngIdDecompressionFile;
}
else if (conDecompressionFile.UploadFileDir  ==  AttributeName[intIndex])
{
return mstrUploadFileDir;
}
else if (conDecompressionFile.UploadPerson  ==  AttributeName[intIndex])
{
return mstrUploadPerson;
}
else if (conDecompressionFile.NewName  ==  AttributeName[intIndex])
{
return mstrNewName;
}
else if (conDecompressionFile.NewPath  ==  AttributeName[intIndex])
{
return mstrNewPath;
}
else if (conDecompressionFile.UploadDate  ==  AttributeName[intIndex])
{
return mdteUploadDate;
}
else if (conDecompressionFile.DecompressionFilePath  ==  AttributeName[intIndex])
{
return mstrDecompressionFilePath;
}
else if (conDecompressionFile.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conDecompressionFile.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conDecompressionFile.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (conDecompressionFile.FileSizeUnit  ==  AttributeName[intIndex])
{
return mstrFileSizeUnit;
}
else if (conDecompressionFile.IsRar  ==  AttributeName[intIndex])
{
return mbolIsRar;
}
else if (conDecompressionFile.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conDecompressionFile.HomePage  ==  AttributeName[intIndex])
{
return mstrHomePage;
}
else if (conDecompressionFile.HomePageDir  ==  AttributeName[intIndex])
{
return mstrHomePageDir;
}
else if (conDecompressionFile.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conDecompressionFile.Memo1  ==  AttributeName[intIndex])
{
return mstrMemo1;
}
return null;
}
set
{
if (conDecompressionFile.IdDecompressionFile  ==  AttributeName[intIndex])
{
mlngIdDecompressionFile = TransNullToInt(value.ToString());
 AddUpdatedFld(conDecompressionFile.IdDecompressionFile);
}
else if (conDecompressionFile.UploadFileDir  ==  AttributeName[intIndex])
{
mstrUploadFileDir = value.ToString();
 AddUpdatedFld(conDecompressionFile.UploadFileDir);
}
else if (conDecompressionFile.UploadPerson  ==  AttributeName[intIndex])
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(conDecompressionFile.UploadPerson);
}
else if (conDecompressionFile.NewName  ==  AttributeName[intIndex])
{
mstrNewName = value.ToString();
 AddUpdatedFld(conDecompressionFile.NewName);
}
else if (conDecompressionFile.NewPath  ==  AttributeName[intIndex])
{
mstrNewPath = value.ToString();
 AddUpdatedFld(conDecompressionFile.NewPath);
}
else if (conDecompressionFile.UploadDate  ==  AttributeName[intIndex])
{
mdteUploadDate = TransNullToDate(value.ToString());
 AddUpdatedFld(conDecompressionFile.UploadDate);
}
else if (conDecompressionFile.DecompressionFilePath  ==  AttributeName[intIndex])
{
mstrDecompressionFilePath = value.ToString();
 AddUpdatedFld(conDecompressionFile.DecompressionFilePath);
}
else if (conDecompressionFile.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conDecompressionFile.FileName);
}
else if (conDecompressionFile.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conDecompressionFile.FilePath);
}
else if (conDecompressionFile.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(conDecompressionFile.FileSize);
}
else if (conDecompressionFile.FileSizeUnit  ==  AttributeName[intIndex])
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(conDecompressionFile.FileSizeUnit);
}
else if (conDecompressionFile.IsRar  ==  AttributeName[intIndex])
{
mbolIsRar = TransNullToBool(value.ToString());
 AddUpdatedFld(conDecompressionFile.IsRar);
}
else if (conDecompressionFile.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conDecompressionFile.UserId);
}
else if (conDecompressionFile.HomePage  ==  AttributeName[intIndex])
{
mstrHomePage = value.ToString();
 AddUpdatedFld(conDecompressionFile.HomePage);
}
else if (conDecompressionFile.HomePageDir  ==  AttributeName[intIndex])
{
mstrHomePageDir = value.ToString();
 AddUpdatedFld(conDecompressionFile.HomePageDir);
}
else if (conDecompressionFile.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDecompressionFile.Memo);
}
else if (conDecompressionFile.Memo1  ==  AttributeName[intIndex])
{
mstrMemo1 = value.ToString();
 AddUpdatedFld(conDecompressionFile.Memo1);
}
}
}

/// <summary>
/// 解压缩文件流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdDecompressionFile
{
get
{
return mlngIdDecompressionFile;
}
set
{
 mlngIdDecompressionFile = value;
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.IdDecompressionFile);
}
}
/// <summary>
/// 上传文件的路径(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadFileDir
{
get
{
return mstrUploadFileDir;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadFileDir = value;
}
else
{
 mstrUploadFileDir = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.UploadFileDir);
}
}
/// <summary>
/// 上传人(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadPerson
{
get
{
return mstrUploadPerson;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadPerson = value;
}
else
{
 mstrUploadPerson = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.UploadPerson);
}
}
/// <summary>
/// 新名称(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewName
{
get
{
return mstrNewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewName = value;
}
else
{
 mstrNewName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.NewName);
}
}
/// <summary>
/// 新路径(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NewPath
{
get
{
return mstrNewPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNewPath = value;
}
else
{
 mstrNewPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.NewPath);
}
}
/// <summary>
/// 上传时间(说明:;字段类型:datetime;字段长度:16;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime UploadDate
{
get
{
return mdteUploadDate;
}
set
{
 mdteUploadDate = value;
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.UploadDate);
}
}
/// <summary>
/// 解压缩文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DecompressionFilePath
{
get
{
return mstrDecompressionFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDecompressionFilePath = value;
}
else
{
 mstrDecompressionFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.DecompressionFilePath);
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
 AddUpdatedFld(conDecompressionFile.FileName);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.FilePath);
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
 AddUpdatedFld(conDecompressionFile.FileSize);
}
}
/// <summary>
/// 文件大小单位(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileSizeUnit
{
get
{
return mstrFileSizeUnit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileSizeUnit = value;
}
else
{
 mstrFileSizeUnit = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.FileSizeUnit);
}
}
/// <summary>
/// 是否解压缩(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRar
{
get
{
return mbolIsRar;
}
set
{
 mbolIsRar = value;
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.IsRar);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.UserId);
}
}
/// <summary>
/// HomePage(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomePage
{
get
{
return mstrHomePage;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomePage = value;
}
else
{
 mstrHomePage = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.HomePage);
}
}
/// <summary>
/// 首页文件目录(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomePageDir
{
get
{
return mstrHomePageDir;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomePageDir = value;
}
else
{
 mstrHomePageDir = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.HomePageDir);
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
 AddUpdatedFld(conDecompressionFile.Memo);
}
}
/// <summary>
/// Memo1(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo1
{
get
{
return mstrMemo1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo1 = value;
}
else
{
 mstrMemo1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conDecompressionFile.Memo1);
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
  return mlngIdDecompressionFile.ToString();
 }
 }
}
 /// <summary>
 /// 解压缩文件(DecompressionFile)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDecompressionFile
{
public const string _CurrTabName = "DecompressionFile"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdDecompressionFile"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdDecompressionFile", "UploadFileDir", "UploadPerson", "NewName", "NewPath", "UploadDate", "DecompressionFilePath", "FileName", "FilePath", "FileSize", "FileSizeUnit", "IsRar", "UserId", "HomePage", "HomePageDir", "Memo", "Memo1"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdDecompressionFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDecompressionFile = "IdDecompressionFile";    //解压缩文件流水号

 /// <summary>
 /// 常量:"UploadFileDir"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadFileDir = "UploadFileDir";    //上传文件的路径

 /// <summary>
 /// 常量:"UploadPerson"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadPerson = "UploadPerson";    //上传人

 /// <summary>
 /// 常量:"NewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewName = "NewName";    //新名称

 /// <summary>
 /// 常量:"NewPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NewPath = "NewPath";    //新路径

 /// <summary>
 /// 常量:"UploadDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadDate = "UploadDate";    //上传时间

 /// <summary>
 /// 常量:"DecompressionFilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DecompressionFilePath = "DecompressionFilePath";    //解压缩文件路径

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"FileSizeUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSizeUnit = "FileSizeUnit";    //文件大小单位

 /// <summary>
 /// 常量:"IsRar"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRar = "IsRar";    //是否解压缩

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"HomePage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomePage = "HomePage";    //HomePage

 /// <summary>
 /// 常量:"HomePageDir"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomePageDir = "HomePageDir";    //首页文件目录

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"Memo1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo1 = "Memo1";    //Memo1
}

}