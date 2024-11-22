
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMessagePushEN
 表名:MessagePush(01120280)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
 /// 表MessagePush的关键字(MessagePushId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MessagePushId_MessagePush
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMessagePushId">表关键字</param>
public K_MessagePushId_MessagePush(string strMessagePushId)
{
if (IsValid(strMessagePushId)) Value = strMessagePushId;
else
{
Value = null;
}
}
private static bool IsValid(string strMessagePushId)
{
if (string.IsNullOrEmpty(strMessagePushId) == true) return false;
if (strMessagePushId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MessagePushId_MessagePush]类型的对象</returns>
public static implicit operator K_MessagePushId_MessagePush(string value)
{
return new K_MessagePushId_MessagePush(value);
}
}
 /// <summary>
 /// 消息推送(MessagePush)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMessagePushEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MessagePush"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MessagePushId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"MessagePushId", "MessagePushNumber", "MessageTitle", "MessageContent", "ReceivePeople", "MessageTypeId", "IsAllpush", "IsReceive", "ClientVersionTypeId", "UpdDate", "Memo"};

protected string mstrMessagePushId;    //消息Id
protected string mstrMessagePushNumber;    //消息编号
protected string mstrMessageTitle;    //消息标题
protected string mstrMessageContent;    //消息内容
protected string mstrReceivePeople;    //接收人员
protected string mstrMessageTypeId;    //消息类型Id
protected bool mbolIsAllpush;    //是否全体推送
protected bool mbolIsReceive;    //是否接收
protected string mstrClientVersionTypeId;    //客户端版本类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMessagePushEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MessagePushId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMessagePushId">关键字:消息Id</param>
public clsMessagePushEN(string strMessagePushId)
 {
strMessagePushId = strMessagePushId.Replace("'", "''");
if (strMessagePushId.Length > 8)
{
throw new Exception("在表:MessagePush中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMessagePushId)  ==  true)
{
throw new Exception("在表:MessagePush中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMessagePushId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMessagePushId = strMessagePushId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MessagePushId");
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
if (strAttributeName  ==  conMessagePush.MessagePushId)
{
return mstrMessagePushId;
}
else if (strAttributeName  ==  conMessagePush.MessagePushNumber)
{
return mstrMessagePushNumber;
}
else if (strAttributeName  ==  conMessagePush.MessageTitle)
{
return mstrMessageTitle;
}
else if (strAttributeName  ==  conMessagePush.MessageContent)
{
return mstrMessageContent;
}
else if (strAttributeName  ==  conMessagePush.ReceivePeople)
{
return mstrReceivePeople;
}
else if (strAttributeName  ==  conMessagePush.MessageTypeId)
{
return mstrMessageTypeId;
}
else if (strAttributeName  ==  conMessagePush.IsAllpush)
{
return mbolIsAllpush;
}
else if (strAttributeName  ==  conMessagePush.IsReceive)
{
return mbolIsReceive;
}
else if (strAttributeName  ==  conMessagePush.ClientVersionTypeId)
{
return mstrClientVersionTypeId;
}
else if (strAttributeName  ==  conMessagePush.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conMessagePush.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMessagePush.MessagePushId)
{
mstrMessagePushId = value.ToString();
 AddUpdatedFld(conMessagePush.MessagePushId);
}
else if (strAttributeName  ==  conMessagePush.MessagePushNumber)
{
mstrMessagePushNumber = value.ToString();
 AddUpdatedFld(conMessagePush.MessagePushNumber);
}
else if (strAttributeName  ==  conMessagePush.MessageTitle)
{
mstrMessageTitle = value.ToString();
 AddUpdatedFld(conMessagePush.MessageTitle);
}
else if (strAttributeName  ==  conMessagePush.MessageContent)
{
mstrMessageContent = value.ToString();
 AddUpdatedFld(conMessagePush.MessageContent);
}
else if (strAttributeName  ==  conMessagePush.ReceivePeople)
{
mstrReceivePeople = value.ToString();
 AddUpdatedFld(conMessagePush.ReceivePeople);
}
else if (strAttributeName  ==  conMessagePush.MessageTypeId)
{
mstrMessageTypeId = value.ToString();
 AddUpdatedFld(conMessagePush.MessageTypeId);
}
else if (strAttributeName  ==  conMessagePush.IsAllpush)
{
mbolIsAllpush = TransNullToBool(value.ToString());
 AddUpdatedFld(conMessagePush.IsAllpush);
}
else if (strAttributeName  ==  conMessagePush.IsReceive)
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(conMessagePush.IsReceive);
}
else if (strAttributeName  ==  conMessagePush.ClientVersionTypeId)
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(conMessagePush.ClientVersionTypeId);
}
else if (strAttributeName  ==  conMessagePush.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMessagePush.UpdDate);
}
else if (strAttributeName  ==  conMessagePush.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMessagePush.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMessagePush.MessagePushId  ==  AttributeName[intIndex])
{
return mstrMessagePushId;
}
else if (conMessagePush.MessagePushNumber  ==  AttributeName[intIndex])
{
return mstrMessagePushNumber;
}
else if (conMessagePush.MessageTitle  ==  AttributeName[intIndex])
{
return mstrMessageTitle;
}
else if (conMessagePush.MessageContent  ==  AttributeName[intIndex])
{
return mstrMessageContent;
}
else if (conMessagePush.ReceivePeople  ==  AttributeName[intIndex])
{
return mstrReceivePeople;
}
else if (conMessagePush.MessageTypeId  ==  AttributeName[intIndex])
{
return mstrMessageTypeId;
}
else if (conMessagePush.IsAllpush  ==  AttributeName[intIndex])
{
return mbolIsAllpush;
}
else if (conMessagePush.IsReceive  ==  AttributeName[intIndex])
{
return mbolIsReceive;
}
else if (conMessagePush.ClientVersionTypeId  ==  AttributeName[intIndex])
{
return mstrClientVersionTypeId;
}
else if (conMessagePush.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conMessagePush.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMessagePush.MessagePushId  ==  AttributeName[intIndex])
{
mstrMessagePushId = value.ToString();
 AddUpdatedFld(conMessagePush.MessagePushId);
}
else if (conMessagePush.MessagePushNumber  ==  AttributeName[intIndex])
{
mstrMessagePushNumber = value.ToString();
 AddUpdatedFld(conMessagePush.MessagePushNumber);
}
else if (conMessagePush.MessageTitle  ==  AttributeName[intIndex])
{
mstrMessageTitle = value.ToString();
 AddUpdatedFld(conMessagePush.MessageTitle);
}
else if (conMessagePush.MessageContent  ==  AttributeName[intIndex])
{
mstrMessageContent = value.ToString();
 AddUpdatedFld(conMessagePush.MessageContent);
}
else if (conMessagePush.ReceivePeople  ==  AttributeName[intIndex])
{
mstrReceivePeople = value.ToString();
 AddUpdatedFld(conMessagePush.ReceivePeople);
}
else if (conMessagePush.MessageTypeId  ==  AttributeName[intIndex])
{
mstrMessageTypeId = value.ToString();
 AddUpdatedFld(conMessagePush.MessageTypeId);
}
else if (conMessagePush.IsAllpush  ==  AttributeName[intIndex])
{
mbolIsAllpush = TransNullToBool(value.ToString());
 AddUpdatedFld(conMessagePush.IsAllpush);
}
else if (conMessagePush.IsReceive  ==  AttributeName[intIndex])
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(conMessagePush.IsReceive);
}
else if (conMessagePush.ClientVersionTypeId  ==  AttributeName[intIndex])
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(conMessagePush.ClientVersionTypeId);
}
else if (conMessagePush.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMessagePush.UpdDate);
}
else if (conMessagePush.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMessagePush.Memo);
}
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
 AddUpdatedFld(conMessagePush.MessagePushId);
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
 AddUpdatedFld(conMessagePush.MessagePushNumber);
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
 AddUpdatedFld(conMessagePush.MessageTitle);
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
 AddUpdatedFld(conMessagePush.MessageContent);
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
 AddUpdatedFld(conMessagePush.ReceivePeople);
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
 AddUpdatedFld(conMessagePush.MessageTypeId);
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
 AddUpdatedFld(conMessagePush.IsAllpush);
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
 AddUpdatedFld(conMessagePush.IsReceive);
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
 AddUpdatedFld(conMessagePush.ClientVersionTypeId);
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
 AddUpdatedFld(conMessagePush.UpdDate);
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
 AddUpdatedFld(conMessagePush.Memo);
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
  return mstrMessagePushId;
 }
 }
}
 /// <summary>
 /// 消息推送(MessagePush)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMessagePush
{
public const string _CurrTabName = "MessagePush"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MessagePushId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MessagePushId", "MessagePushNumber", "MessageTitle", "MessageContent", "ReceivePeople", "MessageTypeId", "IsAllpush", "IsReceive", "ClientVersionTypeId", "UpdDate", "Memo"};
//以下是属性变量


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
 /// 常量:"ReceivePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReceivePeople = "ReceivePeople";    //接收人员

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
 /// 常量:"IsReceive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReceive = "IsReceive";    //是否接收

 /// <summary>
 /// 常量:"ClientVersionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClientVersionTypeId = "ClientVersionTypeId";    //客户端版本类型Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}