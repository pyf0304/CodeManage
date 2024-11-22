
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvtz_ContentAttachmentEN
 表名:vtz_ContentAttachment(01120208)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:20
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
 /// 表vtz_ContentAttachment的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vtz_ContentAttachment
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
public K_mId_vtz_ContentAttachment(long lngmId)
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
 /// <returns>返回:[K_mId_vtz_ContentAttachment]类型的对象</returns>
public static implicit operator K_mId_vtz_ContentAttachment(long value)
{
return new K_mId_vtz_ContentAttachment(value);
}
}
 /// <summary>
 /// v内容附件(vtz_ContentAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvtz_ContentAttachmentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vtz_ContentAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 27;
public static string[] AttributeName = new string[] {"mId", "ContentTypeId", "ContentTypeName", "TableName", "FldName", "TableNameKey", "OrderNum", "AttachmentTitle", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "TextContent", "FileName", "Extension", "FilePath", "PdfFilePath", "SwfFilePath", "FileSize", "FileSizeUnit", "ImageHeight", "ImageWidth", "UploadDate", "UploadPerson", "UpdDate", "UpdUserId", "Memo", "CourseId"};

protected long mlngmId;    //mId
protected string mstrContentTypeId;    //内容类型Id
protected string mstrContentTypeName;    //内容类型名
protected string mstrTableName;    //主表表名
protected string mstrFldName;    //字段名
protected string mstrTableNameKey;    //主表主键值
protected int? mintOrderNum;    //序号
protected string mstrAttachmentTitle;    //附件标题
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrTextContent;    //文本内容
protected string mstrFileName;    //文件名称
protected string mstrExtension;    //扩展名
protected string mstrFilePath;    //文件路径
protected string mstrPdfFilePath;    //Pdf文件路径
protected string mstrSwfFilePath;    //Swf文件路径
protected double? mdblFileSize;    //文件大小
protected string mstrFileSizeUnit;    //文件大小单位
protected int? mintImageHeight;    //图像高
protected int? mintImageWidth;    //图像宽
protected string mstrUploadDate;    //上传时间
protected string mstrUploadPerson;    //上传人
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrCourseId;    //课程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvtz_ContentAttachmentEN()
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
public clsvtz_ContentAttachmentEN(long lngmId)
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
if (strAttributeName  ==  convtz_ContentAttachment.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convtz_ContentAttachment.ContentTypeId)
{
return mstrContentTypeId;
}
else if (strAttributeName  ==  convtz_ContentAttachment.ContentTypeName)
{
return mstrContentTypeName;
}
else if (strAttributeName  ==  convtz_ContentAttachment.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  convtz_ContentAttachment.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convtz_ContentAttachment.TableNameKey)
{
return mstrTableNameKey;
}
else if (strAttributeName  ==  convtz_ContentAttachment.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convtz_ContentAttachment.AttachmentTitle)
{
return mstrAttachmentTitle;
}
else if (strAttributeName  ==  convtz_ContentAttachment.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convtz_ContentAttachment.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convtz_ContentAttachment.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convtz_ContentAttachment.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  convtz_ContentAttachment.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convtz_ContentAttachment.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  convtz_ContentAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convtz_ContentAttachment.PdfFilePath)
{
return mstrPdfFilePath;
}
else if (strAttributeName  ==  convtz_ContentAttachment.SwfFilePath)
{
return mstrSwfFilePath;
}
else if (strAttributeName  ==  convtz_ContentAttachment.FileSize)
{
return mdblFileSize;
}
else if (strAttributeName  ==  convtz_ContentAttachment.FileSizeUnit)
{
return mstrFileSizeUnit;
}
else if (strAttributeName  ==  convtz_ContentAttachment.ImageHeight)
{
return mintImageHeight;
}
else if (strAttributeName  ==  convtz_ContentAttachment.ImageWidth)
{
return mintImageWidth;
}
else if (strAttributeName  ==  convtz_ContentAttachment.UploadDate)
{
return mstrUploadDate;
}
else if (strAttributeName  ==  convtz_ContentAttachment.UploadPerson)
{
return mstrUploadPerson;
}
else if (strAttributeName  ==  convtz_ContentAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convtz_ContentAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convtz_ContentAttachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convtz_ContentAttachment.CourseId)
{
return mstrCourseId;
}
return null;
}
set
{
if (strAttributeName  ==  convtz_ContentAttachment.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.mId);
}
else if (strAttributeName  ==  convtz_ContentAttachment.ContentTypeId)
{
mstrContentTypeId = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.ContentTypeId);
}
else if (strAttributeName  ==  convtz_ContentAttachment.ContentTypeName)
{
mstrContentTypeName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.ContentTypeName);
}
else if (strAttributeName  ==  convtz_ContentAttachment.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.TableName);
}
else if (strAttributeName  ==  convtz_ContentAttachment.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.FldName);
}
else if (strAttributeName  ==  convtz_ContentAttachment.TableNameKey)
{
mstrTableNameKey = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.TableNameKey);
}
else if (strAttributeName  ==  convtz_ContentAttachment.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.OrderNum);
}
else if (strAttributeName  ==  convtz_ContentAttachment.AttachmentTitle)
{
mstrAttachmentTitle = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.AttachmentTitle);
}
else if (strAttributeName  ==  convtz_ContentAttachment.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.IdResourceType);
}
else if (strAttributeName  ==  convtz_ContentAttachment.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.ResourceTypeID);
}
else if (strAttributeName  ==  convtz_ContentAttachment.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.ResourceTypeName);
}
else if (strAttributeName  ==  convtz_ContentAttachment.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.TextContent);
}
else if (strAttributeName  ==  convtz_ContentAttachment.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.FileName);
}
else if (strAttributeName  ==  convtz_ContentAttachment.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.Extension);
}
else if (strAttributeName  ==  convtz_ContentAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.FilePath);
}
else if (strAttributeName  ==  convtz_ContentAttachment.PdfFilePath)
{
mstrPdfFilePath = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.PdfFilePath);
}
else if (strAttributeName  ==  convtz_ContentAttachment.SwfFilePath)
{
mstrSwfFilePath = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.SwfFilePath);
}
else if (strAttributeName  ==  convtz_ContentAttachment.FileSize)
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.FileSize);
}
else if (strAttributeName  ==  convtz_ContentAttachment.FileSizeUnit)
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.FileSizeUnit);
}
else if (strAttributeName  ==  convtz_ContentAttachment.ImageHeight)
{
mintImageHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.ImageHeight);
}
else if (strAttributeName  ==  convtz_ContentAttachment.ImageWidth)
{
mintImageWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.ImageWidth);
}
else if (strAttributeName  ==  convtz_ContentAttachment.UploadDate)
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.UploadDate);
}
else if (strAttributeName  ==  convtz_ContentAttachment.UploadPerson)
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.UploadPerson);
}
else if (strAttributeName  ==  convtz_ContentAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.UpdDate);
}
else if (strAttributeName  ==  convtz_ContentAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.UpdUserId);
}
else if (strAttributeName  ==  convtz_ContentAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.Memo);
}
else if (strAttributeName  ==  convtz_ContentAttachment.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.CourseId);
}
}
}
public object this[int intIndex]
{
get
{
if (convtz_ContentAttachment.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convtz_ContentAttachment.ContentTypeId  ==  AttributeName[intIndex])
{
return mstrContentTypeId;
}
else if (convtz_ContentAttachment.ContentTypeName  ==  AttributeName[intIndex])
{
return mstrContentTypeName;
}
else if (convtz_ContentAttachment.TableName  ==  AttributeName[intIndex])
{
return mstrTableName;
}
else if (convtz_ContentAttachment.FldName  ==  AttributeName[intIndex])
{
return mstrFldName;
}
else if (convtz_ContentAttachment.TableNameKey  ==  AttributeName[intIndex])
{
return mstrTableNameKey;
}
else if (convtz_ContentAttachment.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convtz_ContentAttachment.AttachmentTitle  ==  AttributeName[intIndex])
{
return mstrAttachmentTitle;
}
else if (convtz_ContentAttachment.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convtz_ContentAttachment.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convtz_ContentAttachment.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convtz_ContentAttachment.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (convtz_ContentAttachment.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convtz_ContentAttachment.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (convtz_ContentAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convtz_ContentAttachment.PdfFilePath  ==  AttributeName[intIndex])
{
return mstrPdfFilePath;
}
else if (convtz_ContentAttachment.SwfFilePath  ==  AttributeName[intIndex])
{
return mstrSwfFilePath;
}
else if (convtz_ContentAttachment.FileSize  ==  AttributeName[intIndex])
{
return mdblFileSize;
}
else if (convtz_ContentAttachment.FileSizeUnit  ==  AttributeName[intIndex])
{
return mstrFileSizeUnit;
}
else if (convtz_ContentAttachment.ImageHeight  ==  AttributeName[intIndex])
{
return mintImageHeight;
}
else if (convtz_ContentAttachment.ImageWidth  ==  AttributeName[intIndex])
{
return mintImageWidth;
}
else if (convtz_ContentAttachment.UploadDate  ==  AttributeName[intIndex])
{
return mstrUploadDate;
}
else if (convtz_ContentAttachment.UploadPerson  ==  AttributeName[intIndex])
{
return mstrUploadPerson;
}
else if (convtz_ContentAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convtz_ContentAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convtz_ContentAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convtz_ContentAttachment.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
return null;
}
set
{
if (convtz_ContentAttachment.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.mId);
}
else if (convtz_ContentAttachment.ContentTypeId  ==  AttributeName[intIndex])
{
mstrContentTypeId = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.ContentTypeId);
}
else if (convtz_ContentAttachment.ContentTypeName  ==  AttributeName[intIndex])
{
mstrContentTypeName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.ContentTypeName);
}
else if (convtz_ContentAttachment.TableName  ==  AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.TableName);
}
else if (convtz_ContentAttachment.FldName  ==  AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.FldName);
}
else if (convtz_ContentAttachment.TableNameKey  ==  AttributeName[intIndex])
{
mstrTableNameKey = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.TableNameKey);
}
else if (convtz_ContentAttachment.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.OrderNum);
}
else if (convtz_ContentAttachment.AttachmentTitle  ==  AttributeName[intIndex])
{
mstrAttachmentTitle = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.AttachmentTitle);
}
else if (convtz_ContentAttachment.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.IdResourceType);
}
else if (convtz_ContentAttachment.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.ResourceTypeID);
}
else if (convtz_ContentAttachment.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.ResourceTypeName);
}
else if (convtz_ContentAttachment.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.TextContent);
}
else if (convtz_ContentAttachment.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.FileName);
}
else if (convtz_ContentAttachment.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.Extension);
}
else if (convtz_ContentAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.FilePath);
}
else if (convtz_ContentAttachment.PdfFilePath  ==  AttributeName[intIndex])
{
mstrPdfFilePath = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.PdfFilePath);
}
else if (convtz_ContentAttachment.SwfFilePath  ==  AttributeName[intIndex])
{
mstrSwfFilePath = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.SwfFilePath);
}
else if (convtz_ContentAttachment.FileSize  ==  AttributeName[intIndex])
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.FileSize);
}
else if (convtz_ContentAttachment.FileSizeUnit  ==  AttributeName[intIndex])
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.FileSizeUnit);
}
else if (convtz_ContentAttachment.ImageHeight  ==  AttributeName[intIndex])
{
mintImageHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.ImageHeight);
}
else if (convtz_ContentAttachment.ImageWidth  ==  AttributeName[intIndex])
{
mintImageWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convtz_ContentAttachment.ImageWidth);
}
else if (convtz_ContentAttachment.UploadDate  ==  AttributeName[intIndex])
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.UploadDate);
}
else if (convtz_ContentAttachment.UploadPerson  ==  AttributeName[intIndex])
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.UploadPerson);
}
else if (convtz_ContentAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.UpdDate);
}
else if (convtz_ContentAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.UpdUserId);
}
else if (convtz_ContentAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.Memo);
}
else if (convtz_ContentAttachment.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convtz_ContentAttachment.CourseId);
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
 AddUpdatedFld(convtz_ContentAttachment.mId);
}
}
/// <summary>
/// 内容类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContentTypeId
{
get
{
return mstrContentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContentTypeId = value;
}
else
{
 mstrContentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convtz_ContentAttachment.ContentTypeId);
}
}
/// <summary>
/// 内容类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContentTypeName
{
get
{
return mstrContentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContentTypeName = value;
}
else
{
 mstrContentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convtz_ContentAttachment.ContentTypeName);
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
 AddUpdatedFld(convtz_ContentAttachment.TableName);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convtz_ContentAttachment.FldName);
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
 AddUpdatedFld(convtz_ContentAttachment.TableNameKey);
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
 AddUpdatedFld(convtz_ContentAttachment.OrderNum);
}
}
/// <summary>
/// 附件标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AttachmentTitle
{
get
{
return mstrAttachmentTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAttachmentTitle = value;
}
else
{
 mstrAttachmentTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convtz_ContentAttachment.AttachmentTitle);
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
 AddUpdatedFld(convtz_ContentAttachment.IdResourceType);
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
 AddUpdatedFld(convtz_ContentAttachment.ResourceTypeID);
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
 AddUpdatedFld(convtz_ContentAttachment.ResourceTypeName);
}
}
/// <summary>
/// 文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextContent
{
get
{
return mstrTextContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextContent = value;
}
else
{
 mstrTextContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convtz_ContentAttachment.TextContent);
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
 AddUpdatedFld(convtz_ContentAttachment.FileName);
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
 AddUpdatedFld(convtz_ContentAttachment.Extension);
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
 AddUpdatedFld(convtz_ContentAttachment.FilePath);
}
}
/// <summary>
/// Pdf文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfFilePath
{
get
{
return mstrPdfFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfFilePath = value;
}
else
{
 mstrPdfFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(convtz_ContentAttachment.PdfFilePath);
}
}
/// <summary>
/// Swf文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SwfFilePath
{
get
{
return mstrSwfFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSwfFilePath = value;
}
else
{
 mstrSwfFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(convtz_ContentAttachment.SwfFilePath);
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
 AddUpdatedFld(convtz_ContentAttachment.FileSize);
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
 AddUpdatedFld(convtz_ContentAttachment.FileSizeUnit);
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
 AddUpdatedFld(convtz_ContentAttachment.ImageHeight);
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
 AddUpdatedFld(convtz_ContentAttachment.ImageWidth);
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
 AddUpdatedFld(convtz_ContentAttachment.UploadDate);
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
 AddUpdatedFld(convtz_ContentAttachment.UploadPerson);
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
 AddUpdatedFld(convtz_ContentAttachment.UpdDate);
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
 AddUpdatedFld(convtz_ContentAttachment.UpdUserId);
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
 AddUpdatedFld(convtz_ContentAttachment.Memo);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convtz_ContentAttachment.CourseId);
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
 /// v内容附件(vtz_ContentAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convtz_ContentAttachment
{
public const string _CurrTabName = "vtz_ContentAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ContentTypeId", "ContentTypeName", "TableName", "FldName", "TableNameKey", "OrderNum", "AttachmentTitle", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "TextContent", "FileName", "Extension", "FilePath", "PdfFilePath", "SwfFilePath", "FileSize", "FileSizeUnit", "ImageHeight", "ImageWidth", "UploadDate", "UploadPerson", "UpdDate", "UpdUserId", "Memo", "CourseId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ContentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContentTypeId = "ContentTypeId";    //内容类型Id

 /// <summary>
 /// 常量:"ContentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContentTypeName = "ContentTypeName";    //内容类型名

 /// <summary>
 /// 常量:"TableName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableName = "TableName";    //主表表名

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"TableNameKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableNameKey = "TableNameKey";    //主表主键值

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"AttachmentTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentTitle = "AttachmentTitle";    //附件标题

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
 /// 常量:"TextContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextContent = "TextContent";    //文本内容

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
 /// 常量:"PdfFilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfFilePath = "PdfFilePath";    //Pdf文件路径

 /// <summary>
 /// 常量:"SwfFilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SwfFilePath = "SwfFilePath";    //Swf文件路径

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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id
}

}