
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clstz_ContentAttachmentEN
 表名:tz_ContentAttachment(01120207)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
 /// 表tz_ContentAttachment的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_tz_ContentAttachment
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
public K_mId_tz_ContentAttachment(long lngmId)
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
 /// <returns>返回:[K_mId_tz_ContentAttachment]类型的对象</returns>
public static implicit operator K_mId_tz_ContentAttachment(long value)
{
return new K_mId_tz_ContentAttachment(value);
}
}
 /// <summary>
 /// 内容附件(tz_ContentAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clstz_ContentAttachmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "tz_ContentAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"mId", "ContentTypeId", "TableNameKey", "OrderNum", "AttachmentTitle", "IdResourceType", "TextContent", "FileName", "Extension", "FilePath", "PdfFilePath", "SwfFilePath", "FileSize", "FileSizeUnit", "ImageHeight", "ImageWidth", "UploadDate", "UploadPerson", "UpdDate", "UpdUserId", "Memo", "CourseId"};

protected long mlngmId;    //mId
protected string mstrContentTypeId;    //内容类型Id
protected string mstrTableNameKey;    //主表主键值
protected int? mintOrderNum;    //序号
protected string mstrAttachmentTitle;    //附件标题
protected string mstrIdResourceType;    //资源类型流水号
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
 public clstz_ContentAttachmentEN()
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
public clstz_ContentAttachmentEN(long lngmId)
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
if (strAttributeName  ==  contz_ContentAttachment.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  contz_ContentAttachment.ContentTypeId)
{
return mstrContentTypeId;
}
else if (strAttributeName  ==  contz_ContentAttachment.TableNameKey)
{
return mstrTableNameKey;
}
else if (strAttributeName  ==  contz_ContentAttachment.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  contz_ContentAttachment.AttachmentTitle)
{
return mstrAttachmentTitle;
}
else if (strAttributeName  ==  contz_ContentAttachment.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  contz_ContentAttachment.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  contz_ContentAttachment.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  contz_ContentAttachment.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  contz_ContentAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  contz_ContentAttachment.PdfFilePath)
{
return mstrPdfFilePath;
}
else if (strAttributeName  ==  contz_ContentAttachment.SwfFilePath)
{
return mstrSwfFilePath;
}
else if (strAttributeName  ==  contz_ContentAttachment.FileSize)
{
return mdblFileSize;
}
else if (strAttributeName  ==  contz_ContentAttachment.FileSizeUnit)
{
return mstrFileSizeUnit;
}
else if (strAttributeName  ==  contz_ContentAttachment.ImageHeight)
{
return mintImageHeight;
}
else if (strAttributeName  ==  contz_ContentAttachment.ImageWidth)
{
return mintImageWidth;
}
else if (strAttributeName  ==  contz_ContentAttachment.UploadDate)
{
return mstrUploadDate;
}
else if (strAttributeName  ==  contz_ContentAttachment.UploadPerson)
{
return mstrUploadPerson;
}
else if (strAttributeName  ==  contz_ContentAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  contz_ContentAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  contz_ContentAttachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  contz_ContentAttachment.CourseId)
{
return mstrCourseId;
}
return null;
}
set
{
if (strAttributeName  ==  contz_ContentAttachment.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.mId);
}
else if (strAttributeName  ==  contz_ContentAttachment.ContentTypeId)
{
mstrContentTypeId = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.ContentTypeId);
}
else if (strAttributeName  ==  contz_ContentAttachment.TableNameKey)
{
mstrTableNameKey = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.TableNameKey);
}
else if (strAttributeName  ==  contz_ContentAttachment.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.OrderNum);
}
else if (strAttributeName  ==  contz_ContentAttachment.AttachmentTitle)
{
mstrAttachmentTitle = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.AttachmentTitle);
}
else if (strAttributeName  ==  contz_ContentAttachment.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.IdResourceType);
}
else if (strAttributeName  ==  contz_ContentAttachment.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.TextContent);
}
else if (strAttributeName  ==  contz_ContentAttachment.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.FileName);
}
else if (strAttributeName  ==  contz_ContentAttachment.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.Extension);
}
else if (strAttributeName  ==  contz_ContentAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.FilePath);
}
else if (strAttributeName  ==  contz_ContentAttachment.PdfFilePath)
{
mstrPdfFilePath = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.PdfFilePath);
}
else if (strAttributeName  ==  contz_ContentAttachment.SwfFilePath)
{
mstrSwfFilePath = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.SwfFilePath);
}
else if (strAttributeName  ==  contz_ContentAttachment.FileSize)
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.FileSize);
}
else if (strAttributeName  ==  contz_ContentAttachment.FileSizeUnit)
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.FileSizeUnit);
}
else if (strAttributeName  ==  contz_ContentAttachment.ImageHeight)
{
mintImageHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.ImageHeight);
}
else if (strAttributeName  ==  contz_ContentAttachment.ImageWidth)
{
mintImageWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.ImageWidth);
}
else if (strAttributeName  ==  contz_ContentAttachment.UploadDate)
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.UploadDate);
}
else if (strAttributeName  ==  contz_ContentAttachment.UploadPerson)
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.UploadPerson);
}
else if (strAttributeName  ==  contz_ContentAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.UpdDate);
}
else if (strAttributeName  ==  contz_ContentAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.UpdUserId);
}
else if (strAttributeName  ==  contz_ContentAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.Memo);
}
else if (strAttributeName  ==  contz_ContentAttachment.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.CourseId);
}
}
}
public object this[int intIndex]
{
get
{
if (contz_ContentAttachment.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (contz_ContentAttachment.ContentTypeId  ==  AttributeName[intIndex])
{
return mstrContentTypeId;
}
else if (contz_ContentAttachment.TableNameKey  ==  AttributeName[intIndex])
{
return mstrTableNameKey;
}
else if (contz_ContentAttachment.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (contz_ContentAttachment.AttachmentTitle  ==  AttributeName[intIndex])
{
return mstrAttachmentTitle;
}
else if (contz_ContentAttachment.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (contz_ContentAttachment.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (contz_ContentAttachment.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (contz_ContentAttachment.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (contz_ContentAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (contz_ContentAttachment.PdfFilePath  ==  AttributeName[intIndex])
{
return mstrPdfFilePath;
}
else if (contz_ContentAttachment.SwfFilePath  ==  AttributeName[intIndex])
{
return mstrSwfFilePath;
}
else if (contz_ContentAttachment.FileSize  ==  AttributeName[intIndex])
{
return mdblFileSize;
}
else if (contz_ContentAttachment.FileSizeUnit  ==  AttributeName[intIndex])
{
return mstrFileSizeUnit;
}
else if (contz_ContentAttachment.ImageHeight  ==  AttributeName[intIndex])
{
return mintImageHeight;
}
else if (contz_ContentAttachment.ImageWidth  ==  AttributeName[intIndex])
{
return mintImageWidth;
}
else if (contz_ContentAttachment.UploadDate  ==  AttributeName[intIndex])
{
return mstrUploadDate;
}
else if (contz_ContentAttachment.UploadPerson  ==  AttributeName[intIndex])
{
return mstrUploadPerson;
}
else if (contz_ContentAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (contz_ContentAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (contz_ContentAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (contz_ContentAttachment.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
return null;
}
set
{
if (contz_ContentAttachment.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.mId);
}
else if (contz_ContentAttachment.ContentTypeId  ==  AttributeName[intIndex])
{
mstrContentTypeId = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.ContentTypeId);
}
else if (contz_ContentAttachment.TableNameKey  ==  AttributeName[intIndex])
{
mstrTableNameKey = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.TableNameKey);
}
else if (contz_ContentAttachment.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.OrderNum);
}
else if (contz_ContentAttachment.AttachmentTitle  ==  AttributeName[intIndex])
{
mstrAttachmentTitle = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.AttachmentTitle);
}
else if (contz_ContentAttachment.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.IdResourceType);
}
else if (contz_ContentAttachment.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.TextContent);
}
else if (contz_ContentAttachment.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.FileName);
}
else if (contz_ContentAttachment.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.Extension);
}
else if (contz_ContentAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.FilePath);
}
else if (contz_ContentAttachment.PdfFilePath  ==  AttributeName[intIndex])
{
mstrPdfFilePath = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.PdfFilePath);
}
else if (contz_ContentAttachment.SwfFilePath  ==  AttributeName[intIndex])
{
mstrSwfFilePath = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.SwfFilePath);
}
else if (contz_ContentAttachment.FileSize  ==  AttributeName[intIndex])
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.FileSize);
}
else if (contz_ContentAttachment.FileSizeUnit  ==  AttributeName[intIndex])
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.FileSizeUnit);
}
else if (contz_ContentAttachment.ImageHeight  ==  AttributeName[intIndex])
{
mintImageHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.ImageHeight);
}
else if (contz_ContentAttachment.ImageWidth  ==  AttributeName[intIndex])
{
mintImageWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(contz_ContentAttachment.ImageWidth);
}
else if (contz_ContentAttachment.UploadDate  ==  AttributeName[intIndex])
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.UploadDate);
}
else if (contz_ContentAttachment.UploadPerson  ==  AttributeName[intIndex])
{
mstrUploadPerson = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.UploadPerson);
}
else if (contz_ContentAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.UpdDate);
}
else if (contz_ContentAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.UpdUserId);
}
else if (contz_ContentAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.Memo);
}
else if (contz_ContentAttachment.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(contz_ContentAttachment.CourseId);
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
 AddUpdatedFld(contz_ContentAttachment.mId);
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
 AddUpdatedFld(contz_ContentAttachment.ContentTypeId);
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
 AddUpdatedFld(contz_ContentAttachment.TableNameKey);
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
 AddUpdatedFld(contz_ContentAttachment.OrderNum);
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
 AddUpdatedFld(contz_ContentAttachment.AttachmentTitle);
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
 AddUpdatedFld(contz_ContentAttachment.IdResourceType);
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
 AddUpdatedFld(contz_ContentAttachment.TextContent);
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
 AddUpdatedFld(contz_ContentAttachment.FileName);
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
 AddUpdatedFld(contz_ContentAttachment.Extension);
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
 AddUpdatedFld(contz_ContentAttachment.FilePath);
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
 AddUpdatedFld(contz_ContentAttachment.PdfFilePath);
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
 AddUpdatedFld(contz_ContentAttachment.SwfFilePath);
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
 AddUpdatedFld(contz_ContentAttachment.FileSize);
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
 AddUpdatedFld(contz_ContentAttachment.FileSizeUnit);
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
 AddUpdatedFld(contz_ContentAttachment.ImageHeight);
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
 AddUpdatedFld(contz_ContentAttachment.ImageWidth);
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
 AddUpdatedFld(contz_ContentAttachment.UploadDate);
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
 AddUpdatedFld(contz_ContentAttachment.UploadPerson);
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
 AddUpdatedFld(contz_ContentAttachment.UpdDate);
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
 AddUpdatedFld(contz_ContentAttachment.UpdUserId);
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
 AddUpdatedFld(contz_ContentAttachment.Memo);
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
 AddUpdatedFld(contz_ContentAttachment.CourseId);
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
 /// 内容附件(tz_ContentAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class contz_ContentAttachment
{
public const string _CurrTabName = "tz_ContentAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ContentTypeId", "TableNameKey", "OrderNum", "AttachmentTitle", "IdResourceType", "TextContent", "FileName", "Extension", "FilePath", "PdfFilePath", "SwfFilePath", "FileSize", "FileSizeUnit", "ImageHeight", "ImageWidth", "UploadDate", "UploadPerson", "UpdDate", "UpdUserId", "Memo", "CourseId"};
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