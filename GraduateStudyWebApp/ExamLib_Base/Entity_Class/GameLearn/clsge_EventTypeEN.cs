
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_EventTypeEN
 表名:ge_EventType(01120899)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 表ge_EventType的关键字(EventTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_EventTypeId_ge_EventType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strEventTypeId">表关键字</param>
public K_EventTypeId_ge_EventType(string strEventTypeId)
{
if (IsValid(strEventTypeId)) Value = strEventTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strEventTypeId)
{
if (string.IsNullOrEmpty(strEventTypeId) == true) return false;
if (strEventTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_EventTypeId_ge_EventType]类型的对象</returns>
public static implicit operator K_EventTypeId_ge_EventType(string value)
{
return new K_EventTypeId_ge_EventType(value);
}
}
 /// <summary>
 /// 事件类型表(ge_EventType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_EventTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_EventType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "EventTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"EventTypeId", "EventTypeName", "EventTypeEnName", "UpdDate", "UpdUser", "Memo"};

protected string mstrEventTypeId;    //事件Id
protected string mstrEventTypeName;    //事件名称
protected string mstrEventTypeEnName;    //事件英文名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_EventTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("EventTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strEventTypeId">关键字:事件Id</param>
public clsge_EventTypeEN(string strEventTypeId)
 {
strEventTypeId = strEventTypeId.Replace("'", "''");
if (strEventTypeId.Length > 4)
{
throw new Exception("在表:ge_EventType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strEventTypeId)  ==  true)
{
throw new Exception("在表:ge_EventType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strEventTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrEventTypeId = strEventTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("EventTypeId");
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
if (strAttributeName  ==  conge_EventType.EventTypeId)
{
return mstrEventTypeId;
}
else if (strAttributeName  ==  conge_EventType.EventTypeName)
{
return mstrEventTypeName;
}
else if (strAttributeName  ==  conge_EventType.EventTypeEnName)
{
return mstrEventTypeEnName;
}
else if (strAttributeName  ==  conge_EventType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_EventType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_EventType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_EventType.EventTypeId)
{
mstrEventTypeId = value.ToString();
 AddUpdatedFld(conge_EventType.EventTypeId);
}
else if (strAttributeName  ==  conge_EventType.EventTypeName)
{
mstrEventTypeName = value.ToString();
 AddUpdatedFld(conge_EventType.EventTypeName);
}
else if (strAttributeName  ==  conge_EventType.EventTypeEnName)
{
mstrEventTypeEnName = value.ToString();
 AddUpdatedFld(conge_EventType.EventTypeEnName);
}
else if (strAttributeName  ==  conge_EventType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_EventType.UpdDate);
}
else if (strAttributeName  ==  conge_EventType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_EventType.UpdUser);
}
else if (strAttributeName  ==  conge_EventType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_EventType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_EventType.EventTypeId  ==  AttributeName[intIndex])
{
return mstrEventTypeId;
}
else if (conge_EventType.EventTypeName  ==  AttributeName[intIndex])
{
return mstrEventTypeName;
}
else if (conge_EventType.EventTypeEnName  ==  AttributeName[intIndex])
{
return mstrEventTypeEnName;
}
else if (conge_EventType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_EventType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_EventType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_EventType.EventTypeId  ==  AttributeName[intIndex])
{
mstrEventTypeId = value.ToString();
 AddUpdatedFld(conge_EventType.EventTypeId);
}
else if (conge_EventType.EventTypeName  ==  AttributeName[intIndex])
{
mstrEventTypeName = value.ToString();
 AddUpdatedFld(conge_EventType.EventTypeName);
}
else if (conge_EventType.EventTypeEnName  ==  AttributeName[intIndex])
{
mstrEventTypeEnName = value.ToString();
 AddUpdatedFld(conge_EventType.EventTypeEnName);
}
else if (conge_EventType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_EventType.UpdDate);
}
else if (conge_EventType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_EventType.UpdUser);
}
else if (conge_EventType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_EventType.Memo);
}
}
}

/// <summary>
/// 事件Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EventTypeId
{
get
{
return mstrEventTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEventTypeId = value;
}
else
{
 mstrEventTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_EventType.EventTypeId);
}
}
/// <summary>
/// 事件名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EventTypeName
{
get
{
return mstrEventTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEventTypeName = value;
}
else
{
 mstrEventTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_EventType.EventTypeName);
}
}
/// <summary>
/// 事件英文名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EventTypeEnName
{
get
{
return mstrEventTypeEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEventTypeEnName = value;
}
else
{
 mstrEventTypeEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_EventType.EventTypeEnName);
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
 AddUpdatedFld(conge_EventType.UpdDate);
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
 AddUpdatedFld(conge_EventType.UpdUser);
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
 AddUpdatedFld(conge_EventType.Memo);
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
  return mstrEventTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrEventTypeName;
 }
 }
}
 /// <summary>
 /// 事件类型表(ge_EventType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_EventType
{
public const string _CurrTabName = "ge_EventType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "EventTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"EventTypeId", "EventTypeName", "EventTypeEnName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"EventTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EventTypeId = "EventTypeId";    //事件Id

 /// <summary>
 /// 常量:"EventTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EventTypeName = "EventTypeName";    //事件名称

 /// <summary>
 /// 常量:"EventTypeEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EventTypeEnName = "EventTypeEnName";    //事件英文名称

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