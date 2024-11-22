
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMessagePushUsersRelationEN
 表名:vMessagePushUsersRelation(01120285)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
 /// 表vMessagePushUsersRelation的关键字(MessagePushUsersRelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MessagePushUsersRelationId_vMessagePushUsersRelation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngMessagePushUsersRelationId">表关键字</param>
public K_MessagePushUsersRelationId_vMessagePushUsersRelation(long lngMessagePushUsersRelationId)
{
if (IsValid(lngMessagePushUsersRelationId)) Value = lngMessagePushUsersRelationId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngMessagePushUsersRelationId)
{
if (lngMessagePushUsersRelationId == 0) return false;
if (lngMessagePushUsersRelationId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MessagePushUsersRelationId_vMessagePushUsersRelation]类型的对象</returns>
public static implicit operator K_MessagePushUsersRelationId_vMessagePushUsersRelation(long value)
{
return new K_MessagePushUsersRelationId_vMessagePushUsersRelation(value);
}
}
 /// <summary>
 /// 消息推送用户关系视图(vMessagePushUsersRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMessagePushUsersRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMessagePushUsersRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MessagePushUsersRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"MessagePushUsersRelationId", "MessagePushId", "MessagePushNumber", "MessageTitle", "MessageContent", "MessageTypeId", "IsAllpush", "ClientVersionTypeId", "ReceivePeople", "IsReceive", "CreateTime", "Memo"};

protected long mlngMessagePushUsersRelationId;    //消息推送与用户关系Id
protected string mstrMessagePushId;    //消息Id
protected string mstrMessagePushNumber;    //消息编号
protected string mstrMessageTitle;    //消息标题
protected string mstrMessageContent;    //消息内容
protected string mstrMessageTypeId;    //消息类型Id
protected bool mbolIsAllpush;    //是否全体推送
protected string mstrClientVersionTypeId;    //客户端版本类型Id
protected string mstrReceivePeople;    //接收人员
protected bool mbolIsReceive;    //是否接收
protected string mstrCreateTime;    //建立时间
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMessagePushUsersRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MessagePushUsersRelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngMessagePushUsersRelationId">关键字:消息推送与用户关系Id</param>
public clsvMessagePushUsersRelationEN(long lngMessagePushUsersRelationId)
 {
 if (lngMessagePushUsersRelationId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngMessagePushUsersRelationId = lngMessagePushUsersRelationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MessagePushUsersRelationId");
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
if (strAttributeName  ==  convMessagePushUsersRelation.MessagePushUsersRelationId)
{
return mlngMessagePushUsersRelationId;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessagePushId)
{
return mstrMessagePushId;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessagePushNumber)
{
return mstrMessagePushNumber;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessageTitle)
{
return mstrMessageTitle;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessageContent)
{
return mstrMessageContent;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessageTypeId)
{
return mstrMessageTypeId;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.IsAllpush)
{
return mbolIsAllpush;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.ClientVersionTypeId)
{
return mstrClientVersionTypeId;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.ReceivePeople)
{
return mstrReceivePeople;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.IsReceive)
{
return mbolIsReceive;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  convMessagePushUsersRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convMessagePushUsersRelation.MessagePushUsersRelationId)
{
mlngMessagePushUsersRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushUsersRelationId);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessagePushId)
{
mstrMessagePushId = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushId);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessagePushNumber)
{
mstrMessagePushNumber = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushNumber);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessageTitle)
{
mstrMessageTitle = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessageTitle);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessageContent)
{
mstrMessageContent = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessageContent);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.MessageTypeId)
{
mstrMessageTypeId = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessageTypeId);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.IsAllpush)
{
mbolIsAllpush = TransNullToBool(value.ToString());
 AddUpdatedFld(convMessagePushUsersRelation.IsAllpush);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.ClientVersionTypeId)
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.ClientVersionTypeId);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.ReceivePeople)
{
mstrReceivePeople = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.ReceivePeople);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.IsReceive)
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(convMessagePushUsersRelation.IsReceive);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.CreateTime)
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.CreateTime);
}
else if (strAttributeName  ==  convMessagePushUsersRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convMessagePushUsersRelation.MessagePushUsersRelationId  ==  AttributeName[intIndex])
{
return mlngMessagePushUsersRelationId;
}
else if (convMessagePushUsersRelation.MessagePushId  ==  AttributeName[intIndex])
{
return mstrMessagePushId;
}
else if (convMessagePushUsersRelation.MessagePushNumber  ==  AttributeName[intIndex])
{
return mstrMessagePushNumber;
}
else if (convMessagePushUsersRelation.MessageTitle  ==  AttributeName[intIndex])
{
return mstrMessageTitle;
}
else if (convMessagePushUsersRelation.MessageContent  ==  AttributeName[intIndex])
{
return mstrMessageContent;
}
else if (convMessagePushUsersRelation.MessageTypeId  ==  AttributeName[intIndex])
{
return mstrMessageTypeId;
}
else if (convMessagePushUsersRelation.IsAllpush  ==  AttributeName[intIndex])
{
return mbolIsAllpush;
}
else if (convMessagePushUsersRelation.ClientVersionTypeId  ==  AttributeName[intIndex])
{
return mstrClientVersionTypeId;
}
else if (convMessagePushUsersRelation.ReceivePeople  ==  AttributeName[intIndex])
{
return mstrReceivePeople;
}
else if (convMessagePushUsersRelation.IsReceive  ==  AttributeName[intIndex])
{
return mbolIsReceive;
}
else if (convMessagePushUsersRelation.CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (convMessagePushUsersRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convMessagePushUsersRelation.MessagePushUsersRelationId  ==  AttributeName[intIndex])
{
mlngMessagePushUsersRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushUsersRelationId);
}
else if (convMessagePushUsersRelation.MessagePushId  ==  AttributeName[intIndex])
{
mstrMessagePushId = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushId);
}
else if (convMessagePushUsersRelation.MessagePushNumber  ==  AttributeName[intIndex])
{
mstrMessagePushNumber = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushNumber);
}
else if (convMessagePushUsersRelation.MessageTitle  ==  AttributeName[intIndex])
{
mstrMessageTitle = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessageTitle);
}
else if (convMessagePushUsersRelation.MessageContent  ==  AttributeName[intIndex])
{
mstrMessageContent = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessageContent);
}
else if (convMessagePushUsersRelation.MessageTypeId  ==  AttributeName[intIndex])
{
mstrMessageTypeId = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.MessageTypeId);
}
else if (convMessagePushUsersRelation.IsAllpush  ==  AttributeName[intIndex])
{
mbolIsAllpush = TransNullToBool(value.ToString());
 AddUpdatedFld(convMessagePushUsersRelation.IsAllpush);
}
else if (convMessagePushUsersRelation.ClientVersionTypeId  ==  AttributeName[intIndex])
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.ClientVersionTypeId);
}
else if (convMessagePushUsersRelation.ReceivePeople  ==  AttributeName[intIndex])
{
mstrReceivePeople = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.ReceivePeople);
}
else if (convMessagePushUsersRelation.IsReceive  ==  AttributeName[intIndex])
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(convMessagePushUsersRelation.IsReceive);
}
else if (convMessagePushUsersRelation.CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.CreateTime);
}
else if (convMessagePushUsersRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMessagePushUsersRelation.Memo);
}
}
}

/// <summary>
/// 消息推送与用户关系Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long MessagePushUsersRelationId
{
get
{
return mlngMessagePushUsersRelationId;
}
set
{
 mlngMessagePushUsersRelationId = value;
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushUsersRelationId);
}
}
/// <summary>
/// 消息Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MessagePushId
{
get
{
return mstrMessagePushId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMessagePushId = value;
}
else
{
 mstrMessagePushId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushId);
}
}
/// <summary>
/// 消息编号(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MessagePushNumber
{
get
{
return mstrMessagePushNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMessagePushNumber = value;
}
else
{
 mstrMessagePushNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.MessagePushNumber);
}
}
/// <summary>
/// 消息标题(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MessageTitle
{
get
{
return mstrMessageTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMessageTitle = value;
}
else
{
 mstrMessageTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.MessageTitle);
}
}
/// <summary>
/// 消息内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MessageContent
{
get
{
return mstrMessageContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMessageContent = value;
}
else
{
 mstrMessageContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.MessageContent);
}
}
/// <summary>
/// 消息类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MessageTypeId
{
get
{
return mstrMessageTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMessageTypeId = value;
}
else
{
 mstrMessageTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.MessageTypeId);
}
}
/// <summary>
/// 是否全体推送(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAllpush
{
get
{
return mbolIsAllpush;
}
set
{
 mbolIsAllpush = value;
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.IsAllpush);
}
}
/// <summary>
/// 客户端版本类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClientVersionTypeId
{
get
{
return mstrClientVersionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClientVersionTypeId = value;
}
else
{
 mstrClientVersionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.ClientVersionTypeId);
}
}
/// <summary>
/// 接收人员(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReceivePeople
{
get
{
return mstrReceivePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReceivePeople = value;
}
else
{
 mstrReceivePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.ReceivePeople);
}
}
/// <summary>
/// 是否接收(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsReceive
{
get
{
return mbolIsReceive;
}
set
{
 mbolIsReceive = value;
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.IsReceive);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateTime
{
get
{
return mstrCreateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateTime = value;
}
else
{
 mstrCreateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMessagePushUsersRelation.CreateTime);
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
 AddUpdatedFld(convMessagePushUsersRelation.Memo);
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
  return mlngMessagePushUsersRelationId.ToString();
 }
 }
}
 /// <summary>
 /// 消息推送用户关系视图(vMessagePushUsersRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMessagePushUsersRelation
{
public const string _CurrTabName = "vMessagePushUsersRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MessagePushUsersRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MessagePushUsersRelationId", "MessagePushId", "MessagePushNumber", "MessageTitle", "MessageContent", "MessageTypeId", "IsAllpush", "ClientVersionTypeId", "ReceivePeople", "IsReceive", "CreateTime", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MessagePushUsersRelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessagePushUsersRelationId = "MessagePushUsersRelationId";    //消息推送与用户关系Id

 /// <summary>
 /// 常量:"MessagePushId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessagePushId = "MessagePushId";    //消息Id

 /// <summary>
 /// 常量:"MessagePushNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessagePushNumber = "MessagePushNumber";    //消息编号

 /// <summary>
 /// 常量:"MessageTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessageTitle = "MessageTitle";    //消息标题

 /// <summary>
 /// 常量:"MessageContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessageContent = "MessageContent";    //消息内容

 /// <summary>
 /// 常量:"MessageTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessageTypeId = "MessageTypeId";    //消息类型Id

 /// <summary>
 /// 常量:"IsAllpush"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAllpush = "IsAllpush";    //是否全体推送

 /// <summary>
 /// 常量:"ClientVersionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClientVersionTypeId = "ClientVersionTypeId";    //客户端版本类型Id

 /// <summary>
 /// 常量:"ReceivePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReceivePeople = "ReceivePeople";    //接收人员

 /// <summary>
 /// 常量:"IsReceive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReceive = "IsReceive";    //是否接收

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //建立时间

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}