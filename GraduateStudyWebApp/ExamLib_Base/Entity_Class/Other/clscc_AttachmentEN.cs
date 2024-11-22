
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_AttachmentEN
 表名:cc_Attachment(01120149)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
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
 /// 表cc_Attachment的关键字(AttachmentID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AttachmentID_cc_Attachment
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngAttachmentID">表关键字</param>
public K_AttachmentID_cc_Attachment(long lngAttachmentID)
{
if (IsValid(lngAttachmentID)) Value = lngAttachmentID;
else
{
Value = 0;
}
}
private static bool IsValid(long lngAttachmentID)
{
if (lngAttachmentID == 0) return false;
if (lngAttachmentID == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AttachmentID_cc_Attachment]类型的对象</returns>
public static implicit operator K_AttachmentID_cc_Attachment(long value)
{
return new K_AttachmentID_cc_Attachment(value);
}
}
 /// <summary>
 /// 附件(cc_Attachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_AttachmentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_Attachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AttachmentID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"AttachmentID", "TableName", "FileName", "Extension", "FilePath", "FileSize", "FileSizeUnit", "ImageHeight", "ImageWidth", "UploadDate", "UploadPerson", "TableNameKey", "IdResourceType", "UpdDate", "UpdUserId", "Memo"};

protected long mlngAttachmentID;    //附件流水号
protected string mstrTableName;    //主表表名
protected string mstrFileName;    //文件名称
protected string mstrExtension;    //扩展名
protected string mstrFilePath;    //文件路径
protected double? mdblFileSize;    //文件大小
protected string mstrFileSizeUnit;    //文件大小单位
protected int? mintImageHeight;    //图像高
protected int? mintImageWidth;    //图像宽
protected string mstrUploadDate;    //上传时间
protected string mstrUploadPerson;    //上传人
protected string mstrTableNameKey;    //主表主键值
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_AttachmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AttachmentID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngAttachmentID">关键字:附件流水号</param>
public clscc_AttachmentEN(long lngAttachmentID)
 {
 if (lngAttachmentID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngAttachmentID = lngAttachmentID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AttachmentID");
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
if (strAttributeName  ==  concc_Attachment.AttachmentID)
{
return mlngAttachmentID;
}
else if (strAttributeName  ==  concc_Attachment.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  concc_Attachment.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  concc_Attachment.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  concc_Attachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  concc_Attachment.FileSize)
{
return mdblFileSize;
}
else if (strAttributeName  ==  concc_Attachment.FileSizeUnit)
{
return mstrFileSizeUnit;
}
else if (strAttributeName  ==  concc_Attachment.ImageHeight)
{
return mintImageHeight;
}
else if (strAttributeName  ==  concc_Attachment.ImageWidth)
{
return mintImageWidth;
}
else if (strAttributeName  ==  concc_Attachment.UploadDate)
{
return mstrUploadDate;
}
else if (strAttributeName  ==  concc_Attachment.UploadPerson)
{
return mstrUploadPerson;
}
else if (strAttributeName  ==  concc_Attachment.TableNameKey)
{
return mstrTableNameKey;
}
else if (strAttributeName  ==  concc_Attachment.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  concc_Attachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_Attachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_Attachment.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_Attachment.AttachmentID)
{
mlngAttachmentID = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Attachment.AttachmentID);
}
else if (strAttributeName  ==  concc_Attachment.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(concc_Attachment.TableName);
}
else if (strAttributeName  ==  concc_Attachment.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(concc_Attachment.FileName);
}
else if (strAttributeName  ==  concc_Attachment.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(concc_Attachment.Extension);
}
else if (strAttributeName  ==  concc_Attachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(concc_Attachment.FilePath);
}
else if (strAttributeName  ==  concc_Attachment.FileSize)
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_Attachment.FileSize);
}
else if (strAttributeName  ==  concc_Attachment.FileSizeUnit)
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(concc_Attachment.FileSizeUnit);
}
else if (strAttributeName  ==  concc_Attachment.ImageHeight)
{
mintImageHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Attachment.ImageHeight);
}
else if (strAttributeName  ==  concc_Attachment.ImageWidth)
{
mintImageWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Attachment.ImageWidth);
}
else if (strAttributeName  ==  concc_Attachment.UploadDate)
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(concc_Attachment.UploadDate);
}
else if (strAttributeName  ==  concc_Attachment.UploadPerson)
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(concc_Attachment.UploadPerson);
}
else if (strAttributeName  ==  concc_Attachment.TableNameKey)
{
mstrTableNameKey = value.ToString();
 AddUpdatedFld(concc_Attachment.TableNameKey);
}
else if (strAttributeName  ==  concc_Attachment.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(concc_Attachment.IdResourceType);
}
else if (strAttributeName  ==  concc_Attachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Attachment.UpdDate);
}
else if (strAttributeName  ==  concc_Attachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_Attachment.UpdUserId);
}
else if (strAttributeName  ==  concc_Attachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Attachment.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_Attachment.AttachmentID  ==  AttributeName[intIndex])
{
return mlngAttachmentID;
}
else if (concc_Attachment.TableName  ==  AttributeName[intIndex])
{
return mstrTableName;
}
else if (concc_Attachment.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (concc_Attachment.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (concc_Attachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (concc_Attachment.FileSize  ==  AttributeName[intIndex])
{
return mdblFileSize;
}
else if (concc_Attachment.FileSizeUnit  ==  AttributeName[intIndex])
{
return mstrFileSizeUnit;
}
else if (concc_Attachment.ImageHeight  ==  AttributeName[intIndex])
{
return mintImageHeight;
}
else if (concc_Attachment.ImageWidth  ==  AttributeName[intIndex])
{
return mintImageWidth;
}
else if (concc_Attachment.UploadDate  ==  AttributeName[intIndex])
{
return mstrUploadDate;
}
else if (concc_Attachment.UploadPerson  ==  AttributeName[intIndex])
{
return mstrUploadPerson;
}
else if (concc_Attachment.TableNameKey  ==  AttributeName[intIndex])
{
return mstrTableNameKey;
}
else if (concc_Attachment.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (concc_Attachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_Attachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_Attachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_Attachment.AttachmentID  ==  AttributeName[intIndex])
{
mlngAttachmentID = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Attachment.AttachmentID);
}
else if (concc_Attachment.TableName  ==  AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(concc_Attachment.TableName);
}
else if (concc_Attachment.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(concc_Attachment.FileName);
}
else if (concc_Attachment.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(concc_Attachment.Extension);
}
else if (concc_Attachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(concc_Attachment.FilePath);
}
else if (concc_Attachment.FileSize  ==  AttributeName[intIndex])
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_Attachment.FileSize);
}
else if (concc_Attachment.FileSizeUnit  ==  AttributeName[intIndex])
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(concc_Attachment.FileSizeUnit);
}
else if (concc_Attachment.ImageHeight  ==  AttributeName[intIndex])
{
mintImageHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Attachment.ImageHeight);
}
else if (concc_Attachment.ImageWidth  ==  AttributeName[intIndex])
{
mintImageWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Attachment.ImageWidth);
}
else if (concc_Attachment.UploadDate  ==  AttributeName[intIndex])
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(concc_Attachment.UploadDate);
}
else if (concc_Attachment.UploadPerson  ==  AttributeName[intIndex])
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(concc_Attachment.UploadPerson);
}
else if (concc_Attachment.TableNameKey  ==  AttributeName[intIndex])
{
mstrTableNameKey = value.ToString();
 AddUpdatedFld(concc_Attachment.TableNameKey);
}
else if (concc_Attachment.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(concc_Attachment.IdResourceType);
}
else if (concc_Attachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Attachment.UpdDate);
}
else if (concc_Attachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_Attachment.UpdUserId);
}
else if (concc_Attachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Attachment.Memo);
}
}
}

/// <summary>
/// 附件流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long AttachmentID
{
get
{
return mlngAttachmentID;
}
set
{
 mlngAttachmentID = value;
//记录修改过的字段
 AddUpdatedFld(concc_Attachment.AttachmentID);
}
}
/// <summary>
/// 主表表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableName
{
get
{
return mstrTableName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableName = value;
}
else
{
 mstrTableName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Attachment.TableName);
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
 AddUpdatedFld(concc_Attachment.FileName);
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
 AddUpdatedFld(concc_Attachment.Extension);
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
 AddUpdatedFld(concc_Attachment.FilePath);
}
}
/// <summary>
/// 文件大小(说明:;字段类型:decimal;字段长度:22;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? FileSize
{
get
{
return mdblFileSize;
}
set
{
 mdblFileSize = value;
//记录修改过的字段
 AddUpdatedFld(concc_Attachment.FileSize);
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
 AddUpdatedFld(concc_Attachment.FileSizeUnit);
}
}
/// <summary>
/// 图像高(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ImageHeight
{
get
{
return mintImageHeight;
}
set
{
 mintImageHeight = value;
//记录修改过的字段
 AddUpdatedFld(concc_Attachment.ImageHeight);
}
}
/// <summary>
/// 图像宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ImageWidth
{
get
{
return mintImageWidth;
}
set
{
 mintImageWidth = value;
//记录修改过的字段
 AddUpdatedFld(concc_Attachment.ImageWidth);
}
}
/// <summary>
/// 上传时间(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadDate
{
get
{
return mstrUploadDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadDate = value;
}
else
{
 mstrUploadDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Attachment.UploadDate);
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
 AddUpdatedFld(concc_Attachment.UploadPerson);
}
}
/// <summary>
/// 主表主键值(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableNameKey
{
get
{
return mstrTableNameKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableNameKey = value;
}
else
{
 mstrTableNameKey = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Attachment.TableNameKey);
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
 AddUpdatedFld(concc_Attachment.IdResourceType);
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
 AddUpdatedFld(concc_Attachment.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Attachment.UpdUserId);
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
 AddUpdatedFld(concc_Attachment.Memo);
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
  return mlngAttachmentID.ToString();
 }
 }
}
 /// <summary>
 /// 附件(cc_Attachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_Attachment
{
public const string _CurrTabName = "cc_Attachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AttachmentID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AttachmentID", "TableName", "FileName", "Extension", "FilePath", "FileSize", "FileSizeUnit", "ImageHeight", "ImageWidth", "UploadDate", "UploadPerson", "TableNameKey", "IdResourceType", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AttachmentID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentID = "AttachmentID";    //附件流水号

 /// <summary>
 /// 常量:"TableName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableName = "TableName";    //主表表名

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"Extension"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Extension = "Extension";    //扩展名

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
 /// 常量:"ImageHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImageHeight = "ImageHeight";    //图像高

 /// <summary>
 /// 常量:"ImageWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImageWidth = "ImageWidth";    //图像宽

 /// <summary>
 /// 常量:"UploadDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadDate = "UploadDate";    //上传时间

 /// <summary>
 /// 常量:"UploadPerson"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadPerson = "UploadPerson";    //上传人

 /// <summary>
 /// 常量:"TableNameKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableNameKey = "TableNameKey";    //主表主键值

 /// <summary>
 /// 常量:"IdResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResourceType = "IdResourceType";    //资源类型流水号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}