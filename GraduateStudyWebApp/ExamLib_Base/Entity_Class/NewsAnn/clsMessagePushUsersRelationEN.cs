
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMessagePushUsersRelationEN
 表名:MessagePushUsersRelation(01120284)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:22
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
 /// 表MessagePushUsersRelation的关键字(MessagePushUsersRelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MessagePushUsersRelationId_MessagePushUsersRelation
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
public K_MessagePushUsersRelationId_MessagePushUsersRelation(long lngMessagePushUsersRelationId)
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
 /// <returns>返回:[K_MessagePushUsersRelationId_MessagePushUsersRelation]类型的对象</returns>
public static implicit operator K_MessagePushUsersRelationId_MessagePushUsersRelation(long value)
{
return new K_MessagePushUsersRelationId_MessagePushUsersRelation(value);
}
}
 /// <summary>
 /// 消息推送与用户关系(MessagePushUsersRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMessagePushUsersRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MessagePushUsersRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MessagePushUsersRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"MessagePushUsersRelationId", "MessagePushId", "ReceivePeople", "IsReceive", "CreateTime", "Memo"};

protected long mlngMessagePushUsersRelationId;    //消息推送用户关系Id
protected string mstrMessagePushId;    //消息Id
protected string mstrReceivePeople;    //接收人员
protected bool mbolIsReceive;    //是否接收
protected string mstrCreateTime;    //建立时间
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMessagePushUsersRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MessagePushUsersRelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngMessagePushUsersRelationId">关键字:消息推送用户关系Id</param>
public clsMessagePushUsersRelationEN(long lngMessagePushUsersRelationId)
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
if (strAttributeName  ==  conMessagePushUsersRelation.MessagePushUsersRelationId)
{
return mlngMessagePushUsersRelationId;
}
else if (strAttributeName  ==  conMessagePushUsersRelation.MessagePushId)
{
return mstrMessagePushId;
}
else if (strAttributeName  ==  conMessagePushUsersRelation.ReceivePeople)
{
return mstrReceivePeople;
}
else if (strAttributeName  ==  conMessagePushUsersRelation.IsReceive)
{
return mbolIsReceive;
}
else if (strAttributeName  ==  conMessagePushUsersRelation.CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  conMessagePushUsersRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMessagePushUsersRelation.MessagePushUsersRelationId)
{
mlngMessagePushUsersRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(conMessagePushUsersRelation.MessagePushUsersRelationId);
}
else if (strAttributeName  ==  conMessagePushUsersRelation.MessagePushId)
{
mstrMessagePushId = value.ToString();
 AddUpdatedFld(conMessagePushUsersRelation.MessagePushId);
}
else if (strAttributeName  ==  conMessagePushUsersRelation.ReceivePeople)
{
mstrReceivePeople = value.ToString();
 AddUpdatedFld(conMessagePushUsersRelation.ReceivePeople);
}
else if (strAttributeName  ==  conMessagePushUsersRelation.IsReceive)
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(conMessagePushUsersRelation.IsReceive);
}
else if (strAttributeName  ==  conMessagePushUsersRelation.CreateTime)
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(conMessagePushUsersRelation.CreateTime);
}
else if (strAttributeName  ==  conMessagePushUsersRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMessagePushUsersRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMessagePushUsersRelation.MessagePushUsersRelationId  ==  AttributeName[intIndex])
{
return mlngMessagePushUsersRelationId;
}
else if (conMessagePushUsersRelation.MessagePushId  ==  AttributeName[intIndex])
{
return mstrMessagePushId;
}
else if (conMessagePushUsersRelation.ReceivePeople  ==  AttributeName[intIndex])
{
return mstrReceivePeople;
}
else if (conMessagePushUsersRelation.IsReceive  ==  AttributeName[intIndex])
{
return mbolIsReceive;
}
else if (conMessagePushUsersRelation.CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (conMessagePushUsersRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMessagePushUsersRelation.MessagePushUsersRelationId  ==  AttributeName[intIndex])
{
mlngMessagePushUsersRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(conMessagePushUsersRelation.MessagePushUsersRelationId);
}
else if (conMessagePushUsersRelation.MessagePushId  ==  AttributeName[intIndex])
{
mstrMessagePushId = value.ToString();
 AddUpdatedFld(conMessagePushUsersRelation.MessagePushId);
}
else if (conMessagePushUsersRelation.ReceivePeople  ==  AttributeName[intIndex])
{
mstrReceivePeople = value.ToString();
 AddUpdatedFld(conMessagePushUsersRelation.ReceivePeople);
}
else if (conMessagePushUsersRelation.IsReceive  ==  AttributeName[intIndex])
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(conMessagePushUsersRelation.IsReceive);
}
else if (conMessagePushUsersRelation.CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(conMessagePushUsersRelation.CreateTime);
}
else if (conMessagePushUsersRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMessagePushUsersRelation.Memo);
}
}
}

/// <summary>
/// 消息推送用户关系Id(说明:;字段类型:bigint identity;字段长度:8;是否可空:True)
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
 AddUpdatedFld(conMessagePushUsersRelation.MessagePushUsersRelationId);
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
 AddUpdatedFld(conMessagePushUsersRelation.MessagePushId);
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
 AddUpdatedFld(conMessagePushUsersRelation.ReceivePeople);
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
 AddUpdatedFld(conMessagePushUsersRelation.IsReceive);
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
 AddUpdatedFld(conMessagePushUsersRelation.CreateTime);
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
 AddUpdatedFld(conMessagePushUsersRelation.Memo);
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
 /// 消息推送与用户关系(MessagePushUsersRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMessagePushUsersRelation
{
public const string _CurrTabName = "MessagePushUsersRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MessagePushUsersRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MessagePushUsersRelationId", "MessagePushId", "ReceivePeople", "IsReceive", "CreateTime", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MessagePushUsersRelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessagePushUsersRelationId = "MessagePushUsersRelationId";    //消息推送用户关系Id

 /// <summary>
 /// 常量:"MessagePushId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessagePushId = "MessagePushId";    //消息Id

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