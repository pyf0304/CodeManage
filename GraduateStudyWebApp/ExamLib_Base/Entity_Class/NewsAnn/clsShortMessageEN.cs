
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsShortMessageEN
 表名:ShortMessage(01120286)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:23
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
 /// 表ShortMessage的关键字(ShortMessageId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ShortMessageId_ShortMessage
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngShortMessageId">表关键字</param>
public K_ShortMessageId_ShortMessage(long lngShortMessageId)
{
if (IsValid(lngShortMessageId)) Value = lngShortMessageId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngShortMessageId)
{
if (lngShortMessageId == 0) return false;
if (lngShortMessageId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ShortMessageId_ShortMessage]类型的对象</returns>
public static implicit operator K_ShortMessageId_ShortMessage(long value)
{
return new K_ShortMessageId_ShortMessage(value);
}
}
 /// <summary>
 /// 短信消息(ShortMessage)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsShortMessageEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ShortMessage"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ShortMessageId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"ShortMessageId", "MessageNumber", "SendMessageNumber", "Phone", "MessageContent", "ShortMessageSendSateID", "ReseiveState", "ReturnTime", "Memo"};

protected long mlngShortMessageId;    //短信消息Id
protected string mstrMessageNumber;    //消息编号
protected string mstrSendMessageNumber;    //发送消息编号
protected string mstrPhone;    //手机号
protected string mstrMessageContent;    //消息内容
protected string mstrShortMessageSendSateID;    //消息发送状态Id
protected bool mbolReseiveState;    //接收状态
protected string mstrReturnTime;    //状态返回时间
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsShortMessageEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ShortMessageId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngShortMessageId">关键字:短信消息Id</param>
public clsShortMessageEN(long lngShortMessageId)
 {
 if (lngShortMessageId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngShortMessageId = lngShortMessageId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ShortMessageId");
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
if (strAttributeName  ==  conShortMessage.ShortMessageId)
{
return mlngShortMessageId;
}
else if (strAttributeName  ==  conShortMessage.MessageNumber)
{
return mstrMessageNumber;
}
else if (strAttributeName  ==  conShortMessage.SendMessageNumber)
{
return mstrSendMessageNumber;
}
else if (strAttributeName  ==  conShortMessage.Phone)
{
return mstrPhone;
}
else if (strAttributeName  ==  conShortMessage.MessageContent)
{
return mstrMessageContent;
}
else if (strAttributeName  ==  conShortMessage.ShortMessageSendSateID)
{
return mstrShortMessageSendSateID;
}
else if (strAttributeName  ==  conShortMessage.ReseiveState)
{
return mbolReseiveState;
}
else if (strAttributeName  ==  conShortMessage.ReturnTime)
{
return mstrReturnTime;
}
else if (strAttributeName  ==  conShortMessage.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conShortMessage.ShortMessageId)
{
mlngShortMessageId = TransNullToInt(value.ToString());
 AddUpdatedFld(conShortMessage.ShortMessageId);
}
else if (strAttributeName  ==  conShortMessage.MessageNumber)
{
mstrMessageNumber = value.ToString();
 AddUpdatedFld(conShortMessage.MessageNumber);
}
else if (strAttributeName  ==  conShortMessage.SendMessageNumber)
{
mstrSendMessageNumber = value.ToString();
 AddUpdatedFld(conShortMessage.SendMessageNumber);
}
else if (strAttributeName  ==  conShortMessage.Phone)
{
mstrPhone = value.ToString();
 AddUpdatedFld(conShortMessage.Phone);
}
else if (strAttributeName  ==  conShortMessage.MessageContent)
{
mstrMessageContent = value.ToString();
 AddUpdatedFld(conShortMessage.MessageContent);
}
else if (strAttributeName  ==  conShortMessage.ShortMessageSendSateID)
{
mstrShortMessageSendSateID = value.ToString();
 AddUpdatedFld(conShortMessage.ShortMessageSendSateID);
}
else if (strAttributeName  ==  conShortMessage.ReseiveState)
{
mbolReseiveState = TransNullToBool(value.ToString());
 AddUpdatedFld(conShortMessage.ReseiveState);
}
else if (strAttributeName  ==  conShortMessage.ReturnTime)
{
mstrReturnTime = value.ToString();
 AddUpdatedFld(conShortMessage.ReturnTime);
}
else if (strAttributeName  ==  conShortMessage.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conShortMessage.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conShortMessage.ShortMessageId  ==  AttributeName[intIndex])
{
return mlngShortMessageId;
}
else if (conShortMessage.MessageNumber  ==  AttributeName[intIndex])
{
return mstrMessageNumber;
}
else if (conShortMessage.SendMessageNumber  ==  AttributeName[intIndex])
{
return mstrSendMessageNumber;
}
else if (conShortMessage.Phone  ==  AttributeName[intIndex])
{
return mstrPhone;
}
else if (conShortMessage.MessageContent  ==  AttributeName[intIndex])
{
return mstrMessageContent;
}
else if (conShortMessage.ShortMessageSendSateID  ==  AttributeName[intIndex])
{
return mstrShortMessageSendSateID;
}
else if (conShortMessage.ReseiveState  ==  AttributeName[intIndex])
{
return mbolReseiveState;
}
else if (conShortMessage.ReturnTime  ==  AttributeName[intIndex])
{
return mstrReturnTime;
}
else if (conShortMessage.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conShortMessage.ShortMessageId  ==  AttributeName[intIndex])
{
mlngShortMessageId = TransNullToInt(value.ToString());
 AddUpdatedFld(conShortMessage.ShortMessageId);
}
else if (conShortMessage.MessageNumber  ==  AttributeName[intIndex])
{
mstrMessageNumber = value.ToString();
 AddUpdatedFld(conShortMessage.MessageNumber);
}
else if (conShortMessage.SendMessageNumber  ==  AttributeName[intIndex])
{
mstrSendMessageNumber = value.ToString();
 AddUpdatedFld(conShortMessage.SendMessageNumber);
}
else if (conShortMessage.Phone  ==  AttributeName[intIndex])
{
mstrPhone = value.ToString();
 AddUpdatedFld(conShortMessage.Phone);
}
else if (conShortMessage.MessageContent  ==  AttributeName[intIndex])
{
mstrMessageContent = value.ToString();
 AddUpdatedFld(conShortMessage.MessageContent);
}
else if (conShortMessage.ShortMessageSendSateID  ==  AttributeName[intIndex])
{
mstrShortMessageSendSateID = value.ToString();
 AddUpdatedFld(conShortMessage.ShortMessageSendSateID);
}
else if (conShortMessage.ReseiveState  ==  AttributeName[intIndex])
{
mbolReseiveState = TransNullToBool(value.ToString());
 AddUpdatedFld(conShortMessage.ReseiveState);
}
else if (conShortMessage.ReturnTime  ==  AttributeName[intIndex])
{
mstrReturnTime = value.ToString();
 AddUpdatedFld(conShortMessage.ReturnTime);
}
else if (conShortMessage.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conShortMessage.Memo);
}
}
}

/// <summary>
/// 短信消息Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ShortMessageId
{
get
{
return mlngShortMessageId;
}
set
{
 mlngShortMessageId = value;
//记录修改过的字段
 AddUpdatedFld(conShortMessage.ShortMessageId);
}
}
/// <summary>
/// 消息编号(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MessageNumber
{
get
{
return mstrMessageNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMessageNumber = value;
}
else
{
 mstrMessageNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(conShortMessage.MessageNumber);
}
}
/// <summary>
/// 发送消息编号(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SendMessageNumber
{
get
{
return mstrSendMessageNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSendMessageNumber = value;
}
else
{
 mstrSendMessageNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(conShortMessage.SendMessageNumber);
}
}
/// <summary>
/// 手机号(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Phone
{
get
{
return mstrPhone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhone = value;
}
else
{
 mstrPhone = value;
}
//记录修改过的字段
 AddUpdatedFld(conShortMessage.Phone);
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
 AddUpdatedFld(conShortMessage.MessageContent);
}
}
/// <summary>
/// 消息发送状态Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShortMessageSendSateID
{
get
{
return mstrShortMessageSendSateID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShortMessageSendSateID = value;
}
else
{
 mstrShortMessageSendSateID = value;
}
//记录修改过的字段
 AddUpdatedFld(conShortMessage.ShortMessageSendSateID);
}
}
/// <summary>
/// 接收状态(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool ReseiveState
{
get
{
return mbolReseiveState;
}
set
{
 mbolReseiveState = value;
//记录修改过的字段
 AddUpdatedFld(conShortMessage.ReseiveState);
}
}
/// <summary>
/// 状态返回时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnTime
{
get
{
return mstrReturnTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnTime = value;
}
else
{
 mstrReturnTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conShortMessage.ReturnTime);
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
 AddUpdatedFld(conShortMessage.Memo);
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
  return mlngShortMessageId.ToString();
 }
 }
}
 /// <summary>
 /// 短信消息(ShortMessage)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conShortMessage
{
public const string _CurrTabName = "ShortMessage"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ShortMessageId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ShortMessageId", "MessageNumber", "SendMessageNumber", "Phone", "MessageContent", "ShortMessageSendSateID", "ReseiveState", "ReturnTime", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ShortMessageId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShortMessageId = "ShortMessageId";    //短信消息Id

 /// <summary>
 /// 常量:"MessageNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessageNumber = "MessageNumber";    //消息编号

 /// <summary>
 /// 常量:"SendMessageNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SendMessageNumber = "SendMessageNumber";    //发送消息编号

 /// <summary>
 /// 常量:"Phone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Phone = "Phone";    //手机号

 /// <summary>
 /// 常量:"MessageContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessageContent = "MessageContent";    //消息内容

 /// <summary>
 /// 常量:"ShortMessageSendSateID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShortMessageSendSateID = "ShortMessageSendSateID";    //消息发送状态Id

 /// <summary>
 /// 常量:"ReseiveState"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReseiveState = "ReseiveState";    //接收状态

 /// <summary>
 /// 常量:"ReturnTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTime = "ReturnTime";    //状态返回时间

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}