
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMessagePushTypeEN
 表名:MessagePushType(01120281)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:51
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
 /// 表MessagePushType的关键字(MessageTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MessageTypeId_MessagePushType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMessageTypeId">表关键字</param>
public K_MessageTypeId_MessagePushType(string strMessageTypeId)
{
if (IsValid(strMessageTypeId)) Value = strMessageTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strMessageTypeId)
{
if (string.IsNullOrEmpty(strMessageTypeId) == true) return false;
if (strMessageTypeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MessageTypeId_MessagePushType]类型的对象</returns>
public static implicit operator K_MessageTypeId_MessagePushType(string value)
{
return new K_MessageTypeId_MessagePushType(value);
}
}
 /// <summary>
 /// 消息类型(MessagePushType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMessagePushTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MessagePushType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MessageTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"MessageTypeId", "MessageTypeName", "UpdDate", "UpdUser", "Memo"};

protected string mstrMessageTypeId;    //消息类型Id
protected string mstrMessageTypeName;    //消息类型名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMessagePushTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MessageTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMessageTypeId">关键字:消息类型Id</param>
public clsMessagePushTypeEN(string strMessageTypeId)
 {
strMessageTypeId = strMessageTypeId.Replace("'", "''");
if (strMessageTypeId.Length > 8)
{
throw new Exception("在表:MessagePushType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMessageTypeId)  ==  true)
{
throw new Exception("在表:MessagePushType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMessageTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMessageTypeId = strMessageTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MessageTypeId");
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
if (strAttributeName  ==  conMessagePushType.MessageTypeId)
{
return mstrMessageTypeId;
}
else if (strAttributeName  ==  conMessagePushType.MessageTypeName)
{
return mstrMessageTypeName;
}
else if (strAttributeName  ==  conMessagePushType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conMessagePushType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conMessagePushType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMessagePushType.MessageTypeId)
{
mstrMessageTypeId = value.ToString();
 AddUpdatedFld(conMessagePushType.MessageTypeId);
}
else if (strAttributeName  ==  conMessagePushType.MessageTypeName)
{
mstrMessageTypeName = value.ToString();
 AddUpdatedFld(conMessagePushType.MessageTypeName);
}
else if (strAttributeName  ==  conMessagePushType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMessagePushType.UpdDate);
}
else if (strAttributeName  ==  conMessagePushType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conMessagePushType.UpdUser);
}
else if (strAttributeName  ==  conMessagePushType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMessagePushType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMessagePushType.MessageTypeId  ==  AttributeName[intIndex])
{
return mstrMessageTypeId;
}
else if (conMessagePushType.MessageTypeName  ==  AttributeName[intIndex])
{
return mstrMessageTypeName;
}
else if (conMessagePushType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conMessagePushType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conMessagePushType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMessagePushType.MessageTypeId  ==  AttributeName[intIndex])
{
mstrMessageTypeId = value.ToString();
 AddUpdatedFld(conMessagePushType.MessageTypeId);
}
else if (conMessagePushType.MessageTypeName  ==  AttributeName[intIndex])
{
mstrMessageTypeName = value.ToString();
 AddUpdatedFld(conMessagePushType.MessageTypeName);
}
else if (conMessagePushType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMessagePushType.UpdDate);
}
else if (conMessagePushType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conMessagePushType.UpdUser);
}
else if (conMessagePushType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMessagePushType.Memo);
}
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
 AddUpdatedFld(conMessagePushType.MessageTypeId);
}
}
/// <summary>
/// 消息类型名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MessageTypeName
{
get
{
return mstrMessageTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMessageTypeName = value;
}
else
{
 mstrMessageTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMessagePushType.MessageTypeName);
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
 AddUpdatedFld(conMessagePushType.UpdDate);
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
 AddUpdatedFld(conMessagePushType.UpdUser);
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
 AddUpdatedFld(conMessagePushType.Memo);
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
  return mstrMessageTypeId;
 }
 }
}
 /// <summary>
 /// 消息类型(MessagePushType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMessagePushType
{
public const string _CurrTabName = "MessagePushType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MessageTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MessageTypeId", "MessageTypeName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MessageTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessageTypeId = "MessageTypeId";    //消息类型Id

 /// <summary>
 /// 常量:"MessageTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MessageTypeName = "MessageTypeName";    //消息类型名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}