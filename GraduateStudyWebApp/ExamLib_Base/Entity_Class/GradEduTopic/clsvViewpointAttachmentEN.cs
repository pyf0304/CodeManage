
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointAttachmentEN
 表名:vViewpointAttachment(01120593)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表vViewpointAttachment的关键字(ViewpointAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointAttachmentId_vViewpointAttachment
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngViewpointAttachmentId">表关键字</param>
public K_ViewpointAttachmentId_vViewpointAttachment(long lngViewpointAttachmentId)
{
if (IsValid(lngViewpointAttachmentId)) Value = lngViewpointAttachmentId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngViewpointAttachmentId)
{
if (lngViewpointAttachmentId == 0) return false;
if (lngViewpointAttachmentId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointAttachmentId_vViewpointAttachment]类型的对象</returns>
public static implicit operator K_ViewpointAttachmentId_vViewpointAttachment(long value)
{
return new K_ViewpointAttachmentId_vViewpointAttachment(value);
}
}
 /// <summary>
 /// v观点附件(vViewpointAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewpointAttachmentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewpointAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"ViewpointAttachmentId", "Reason", "ViewpointAttachmentName", "Source", "ViewpointId", "FilePath", "UpdUser", "UpdDate", "ViewpointContent", "ViewpointName", "ViewpointTypeId", "ViewpointTypeName", "VPProposePeople", "IdCurrEduCls"};

protected long mlngViewpointAttachmentId;    //主键Id
protected string mstrReason;    //理由
protected string mstrViewpointAttachmentName;    //附件名称
protected string mstrSource;    //来源
protected string mstrViewpointId;    //观点Id
protected string mstrFilePath;    //文件路径
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrViewpointContent;    //观点内容
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointTypeId;    //观点类型Id
protected string mstrViewpointTypeName;    //观点类型名
protected string mstrVPProposePeople;    //观点提出人
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewpointAttachmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointAttachmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngViewpointAttachmentId">关键字:主键Id</param>
public clsvViewpointAttachmentEN(long lngViewpointAttachmentId)
 {
 if (lngViewpointAttachmentId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngViewpointAttachmentId = lngViewpointAttachmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointAttachmentId");
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
if (strAttributeName  ==  convViewpointAttachment.ViewpointAttachmentId)
{
return mlngViewpointAttachmentId;
}
else if (strAttributeName  ==  convViewpointAttachment.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointAttachmentName)
{
return mstrViewpointAttachmentName;
}
else if (strAttributeName  ==  convViewpointAttachment.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  convViewpointAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convViewpointAttachment.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convViewpointAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointTypeId)
{
return mstrViewpointTypeId;
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointTypeName)
{
return mstrViewpointTypeName;
}
else if (strAttributeName  ==  convViewpointAttachment.VPProposePeople)
{
return mstrVPProposePeople;
}
else if (strAttributeName  ==  convViewpointAttachment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  convViewpointAttachment.ViewpointAttachmentId)
{
mlngViewpointAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointAttachment.ViewpointAttachmentId);
}
else if (strAttributeName  ==  convViewpointAttachment.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointAttachment.Reason);
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointAttachmentName)
{
mstrViewpointAttachmentName = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointAttachmentName);
}
else if (strAttributeName  ==  convViewpointAttachment.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(convViewpointAttachment.Source);
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointId);
}
else if (strAttributeName  ==  convViewpointAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convViewpointAttachment.FilePath);
}
else if (strAttributeName  ==  convViewpointAttachment.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewpointAttachment.UpdUser);
}
else if (strAttributeName  ==  convViewpointAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointAttachment.UpdDate);
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointContent);
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointName);
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointTypeId)
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointTypeId);
}
else if (strAttributeName  ==  convViewpointAttachment.ViewpointTypeName)
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointTypeName);
}
else if (strAttributeName  ==  convViewpointAttachment.VPProposePeople)
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(convViewpointAttachment.VPProposePeople);
}
else if (strAttributeName  ==  convViewpointAttachment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convViewpointAttachment.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewpointAttachment.ViewpointAttachmentId  ==  AttributeName[intIndex])
{
return mlngViewpointAttachmentId;
}
else if (convViewpointAttachment.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (convViewpointAttachment.ViewpointAttachmentName  ==  AttributeName[intIndex])
{
return mstrViewpointAttachmentName;
}
else if (convViewpointAttachment.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (convViewpointAttachment.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (convViewpointAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convViewpointAttachment.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convViewpointAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewpointAttachment.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (convViewpointAttachment.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (convViewpointAttachment.ViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrViewpointTypeId;
}
else if (convViewpointAttachment.ViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrViewpointTypeName;
}
else if (convViewpointAttachment.VPProposePeople  ==  AttributeName[intIndex])
{
return mstrVPProposePeople;
}
else if (convViewpointAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (convViewpointAttachment.ViewpointAttachmentId  ==  AttributeName[intIndex])
{
mlngViewpointAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointAttachment.ViewpointAttachmentId);
}
else if (convViewpointAttachment.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointAttachment.Reason);
}
else if (convViewpointAttachment.ViewpointAttachmentName  ==  AttributeName[intIndex])
{
mstrViewpointAttachmentName = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointAttachmentName);
}
else if (convViewpointAttachment.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(convViewpointAttachment.Source);
}
else if (convViewpointAttachment.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointId);
}
else if (convViewpointAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convViewpointAttachment.FilePath);
}
else if (convViewpointAttachment.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewpointAttachment.UpdUser);
}
else if (convViewpointAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointAttachment.UpdDate);
}
else if (convViewpointAttachment.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointContent);
}
else if (convViewpointAttachment.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointName);
}
else if (convViewpointAttachment.ViewpointTypeId  ==  AttributeName[intIndex])
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointTypeId);
}
else if (convViewpointAttachment.ViewpointTypeName  ==  AttributeName[intIndex])
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convViewpointAttachment.ViewpointTypeName);
}
else if (convViewpointAttachment.VPProposePeople  ==  AttributeName[intIndex])
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(convViewpointAttachment.VPProposePeople);
}
else if (convViewpointAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convViewpointAttachment.IdCurrEduCls);
}
}
}

/// <summary>
/// 主键Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ViewpointAttachmentId
{
get
{
return mlngViewpointAttachmentId;
}
set
{
 mlngViewpointAttachmentId = value;
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.ViewpointAttachmentId);
}
}
/// <summary>
/// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Reason
{
get
{
return mstrReason;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReason = value;
}
else
{
 mstrReason = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.Reason);
}
}
/// <summary>
/// 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointAttachmentName
{
get
{
return mstrViewpointAttachmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointAttachmentName = value;
}
else
{
 mstrViewpointAttachmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.ViewpointAttachmentName);
}
}
/// <summary>
/// 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Source
{
get
{
return mstrSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSource = value;
}
else
{
 mstrSource = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.Source);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointId
{
get
{
return mstrViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointId = value;
}
else
{
 mstrViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.ViewpointId);
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
 AddUpdatedFld(convViewpointAttachment.FilePath);
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
 AddUpdatedFld(convViewpointAttachment.UpdUser);
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
 AddUpdatedFld(convViewpointAttachment.UpdDate);
}
}
/// <summary>
/// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointContent
{
get
{
return mstrViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointContent = value;
}
else
{
 mstrViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.ViewpointContent);
}
}
/// <summary>
/// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointName
{
get
{
return mstrViewpointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointName = value;
}
else
{
 mstrViewpointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.ViewpointName);
}
}
/// <summary>
/// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeId
{
get
{
return mstrViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeId = value;
}
else
{
 mstrViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.ViewpointTypeId);
}
}
/// <summary>
/// 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeName
{
get
{
return mstrViewpointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeName = value;
}
else
{
 mstrViewpointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.ViewpointTypeName);
}
}
/// <summary>
/// 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VPProposePeople
{
get
{
return mstrVPProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVPProposePeople = value;
}
else
{
 mstrVPProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.VPProposePeople);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointAttachment.IdCurrEduCls);
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
  return mlngViewpointAttachmentId.ToString();
 }
 }
}
 /// <summary>
 /// v观点附件(vViewpointAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewpointAttachment
{
public const string _CurrTabName = "vViewpointAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointAttachmentId", "Reason", "ViewpointAttachmentName", "Source", "ViewpointId", "FilePath", "UpdUser", "UpdDate", "ViewpointContent", "ViewpointName", "ViewpointTypeId", "ViewpointTypeName", "VPProposePeople", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewpointAttachmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointAttachmentId = "ViewpointAttachmentId";    //主键Id

 /// <summary>
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由

 /// <summary>
 /// 常量:"ViewpointAttachmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointAttachmentName = "ViewpointAttachmentName";    //附件名称

 /// <summary>
 /// 常量:"Source"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Source = "Source";    //来源

 /// <summary>
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"ViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointContent = "ViewpointContent";    //观点内容

 /// <summary>
 /// 常量:"ViewpointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointName = "ViewpointName";    //观点名称

 /// <summary>
 /// 常量:"ViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeId = "ViewpointTypeId";    //观点类型Id

 /// <summary>
 /// 常量:"ViewpointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeName = "ViewpointTypeName";    //观点类型名

 /// <summary>
 /// 常量:"VPProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VPProposePeople = "VPProposePeople";    //观点提出人

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}