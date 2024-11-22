
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_AttachmentEN
 表名:vcc_Attachment(01120160)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:44
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
 /// 表vcc_Attachment的关键字(AttachmentID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AttachmentID_vcc_Attachment
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
public K_AttachmentID_vcc_Attachment(long lngAttachmentID)
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
 /// <returns>返回:[K_AttachmentID_vcc_Attachment]类型的对象</returns>
public static implicit operator K_AttachmentID_vcc_Attachment(long value)
{
return new K_AttachmentID_vcc_Attachment(value);
}
}
 /// <summary>
 /// v附件(vcc_Attachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_AttachmentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_Attachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AttachmentID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"AttachmentID", "TableName", "FileName", "Extension", "FilePath", "FileSize", "FileSizeUnit", "UploadDate", "UploadPerson", "TableNameKey", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "UpdDate", "UpdUserId", "Memo", "ImageHeight", "ImageWidth"};

protected long mlngAttachmentID;    //附件流水号
protected string mstrTableName;    //主表表名
protected string mstrFileName;    //文件名称
protected string mstrExtension;    //扩展名
protected string mstrFilePath;    //文件路径
protected double? mdblFileSize;    //文件大小
protected string mstrFileSizeUnit;    //文件大小单位
protected string mstrUploadDate;    //上传时间
protected string mstrUploadPerson;    //上传人
protected string mstrTableNameKey;    //主表主键值
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintImageHeight;    //图像高
protected int? mintImageWidth;    //图像宽

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_AttachmentEN()
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
public clsvcc_AttachmentEN(long lngAttachmentID)
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
if (strAttributeName  ==  convcc_Attachment.AttachmentID)
{
return mlngAttachmentID;
}
else if (strAttributeName  ==  convcc_Attachment.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  convcc_Attachment.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convcc_Attachment.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  convcc_Attachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convcc_Attachment.FileSize)
{
return mdblFileSize;
}
else if (strAttributeName  ==  convcc_Attachment.FileSizeUnit)
{
return mstrFileSizeUnit;
}
else if (strAttributeName  ==  convcc_Attachment.UploadDate)
{
return mstrUploadDate;
}
else if (strAttributeName  ==  convcc_Attachment.UploadPerson)
{
return mstrUploadPerson;
}
else if (strAttributeName  ==  convcc_Attachment.TableNameKey)
{
return mstrTableNameKey;
}
else if (strAttributeName  ==  convcc_Attachment.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convcc_Attachment.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convcc_Attachment.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convcc_Attachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_Attachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_Attachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_Attachment.ImageHeight)
{
return mintImageHeight;
}
else if (strAttributeName  ==  convcc_Attachment.ImageWidth)
{
return mintImageWidth;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_Attachment.AttachmentID)
{
mlngAttachmentID = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Attachment.AttachmentID);
}
else if (strAttributeName  ==  convcc_Attachment.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(convcc_Attachment.TableName);
}
else if (strAttributeName  ==  convcc_Attachment.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convcc_Attachment.FileName);
}
else if (strAttributeName  ==  convcc_Attachment.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(convcc_Attachment.Extension);
}
else if (strAttributeName  ==  convcc_Attachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convcc_Attachment.FilePath);
}
else if (strAttributeName  ==  convcc_Attachment.FileSize)
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_Attachment.FileSize);
}
else if (strAttributeName  ==  convcc_Attachment.FileSizeUnit)
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(convcc_Attachment.FileSizeUnit);
}
else if (strAttributeName  ==  convcc_Attachment.UploadDate)
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(convcc_Attachment.UploadDate);
}
else if (strAttributeName  ==  convcc_Attachment.UploadPerson)
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(convcc_Attachment.UploadPerson);
}
else if (strAttributeName  ==  convcc_Attachment.TableNameKey)
{
mstrTableNameKey = value.ToString();
 AddUpdatedFld(convcc_Attachment.TableNameKey);
}
else if (strAttributeName  ==  convcc_Attachment.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convcc_Attachment.IdResourceType);
}
else if (strAttributeName  ==  convcc_Attachment.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convcc_Attachment.ResourceTypeID);
}
else if (strAttributeName  ==  convcc_Attachment.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convcc_Attachment.ResourceTypeName);
}
else if (strAttributeName  ==  convcc_Attachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_Attachment.UpdDate);
}
else if (strAttributeName  ==  convcc_Attachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_Attachment.UpdUserId);
}
else if (strAttributeName  ==  convcc_Attachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_Attachment.Memo);
}
else if (strAttributeName  ==  convcc_Attachment.ImageHeight)
{
mintImageHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Attachment.ImageHeight);
}
else if (strAttributeName  ==  convcc_Attachment.ImageWidth)
{
mintImageWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Attachment.ImageWidth);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_Attachment.AttachmentID  ==  AttributeName[intIndex])
{
return mlngAttachmentID;
}
else if (convcc_Attachment.TableName  ==  AttributeName[intIndex])
{
return mstrTableName;
}
else if (convcc_Attachment.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convcc_Attachment.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (convcc_Attachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convcc_Attachment.FileSize  ==  AttributeName[intIndex])
{
return mdblFileSize;
}
else if (convcc_Attachment.FileSizeUnit  ==  AttributeName[intIndex])
{
return mstrFileSizeUnit;
}
else if (convcc_Attachment.UploadDate  ==  AttributeName[intIndex])
{
return mstrUploadDate;
}
else if (convcc_Attachment.UploadPerson  ==  AttributeName[intIndex])
{
return mstrUploadPerson;
}
else if (convcc_Attachment.TableNameKey  ==  AttributeName[intIndex])
{
return mstrTableNameKey;
}
else if (convcc_Attachment.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convcc_Attachment.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convcc_Attachment.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convcc_Attachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_Attachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_Attachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_Attachment.ImageHeight  ==  AttributeName[intIndex])
{
return mintImageHeight;
}
else if (convcc_Attachment.ImageWidth  ==  AttributeName[intIndex])
{
return mintImageWidth;
}
return null;
}
set
{
if (convcc_Attachment.AttachmentID  ==  AttributeName[intIndex])
{
mlngAttachmentID = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Attachment.AttachmentID);
}
else if (convcc_Attachment.TableName  ==  AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(convcc_Attachment.TableName);
}
else if (convcc_Attachment.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convcc_Attachment.FileName);
}
else if (convcc_Attachment.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(convcc_Attachment.Extension);
}
else if (convcc_Attachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convcc_Attachment.FilePath);
}
else if (convcc_Attachment.FileSize  ==  AttributeName[intIndex])
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_Attachment.FileSize);
}
else if (convcc_Attachment.FileSizeUnit  ==  AttributeName[intIndex])
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(convcc_Attachment.FileSizeUnit);
}
else if (convcc_Attachment.UploadDate  ==  AttributeName[intIndex])
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(convcc_Attachment.UploadDate);
}
else if (convcc_Attachment.UploadPerson  ==  AttributeName[intIndex])
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(convcc_Attachment.UploadPerson);
}
else if (convcc_Attachment.TableNameKey  ==  AttributeName[intIndex])
{
mstrTableNameKey = value.ToString();
 AddUpdatedFld(convcc_Attachment.TableNameKey);
}
else if (convcc_Attachment.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convcc_Attachment.IdResourceType);
}
else if (convcc_Attachment.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convcc_Attachment.ResourceTypeID);
}
else if (convcc_Attachment.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convcc_Attachment.ResourceTypeName);
}
else if (convcc_Attachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_Attachment.UpdDate);
}
else if (convcc_Attachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_Attachment.UpdUserId);
}
else if (convcc_Attachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_Attachment.Memo);
}
else if (convcc_Attachment.ImageHeight  ==  AttributeName[intIndex])
{
mintImageHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Attachment.ImageHeight);
}
else if (convcc_Attachment.ImageWidth  ==  AttributeName[intIndex])
{
mintImageWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Attachment.ImageWidth);
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
 AddUpdatedFld(convcc_Attachment.AttachmentID);
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
 AddUpdatedFld(convcc_Attachment.TableName);
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
 AddUpdatedFld(convcc_Attachment.FileName);
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
 AddUpdatedFld(convcc_Attachment.Extension);
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
 AddUpdatedFld(convcc_Attachment.FilePath);
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
 AddUpdatedFld(convcc_Attachment.FileSize);
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
 AddUpdatedFld(convcc_Attachment.FileSizeUnit);
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
 AddUpdatedFld(convcc_Attachment.UploadDate);
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
 AddUpdatedFld(convcc_Attachment.UploadPerson);
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
 AddUpdatedFld(convcc_Attachment.TableNameKey);
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
 AddUpdatedFld(convcc_Attachment.IdResourceType);
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
 AddUpdatedFld(convcc_Attachment.ResourceTypeID);
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
 AddUpdatedFld(convcc_Attachment.ResourceTypeName);
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
 AddUpdatedFld(convcc_Attachment.UpdDate);
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
 AddUpdatedFld(convcc_Attachment.UpdUserId);
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
 AddUpdatedFld(convcc_Attachment.Memo);
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
 AddUpdatedFld(convcc_Attachment.ImageHeight);
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
 AddUpdatedFld(convcc_Attachment.ImageWidth);
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
 /// v附件(vcc_Attachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_Attachment
{
public const string _CurrTabName = "vcc_Attachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AttachmentID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AttachmentID", "TableName", "FileName", "Extension", "FilePath", "FileSize", "FileSizeUnit", "UploadDate", "UploadPerson", "TableNameKey", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "UpdDate", "UpdUserId", "Memo", "ImageHeight", "ImageWidth"};
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
}

}