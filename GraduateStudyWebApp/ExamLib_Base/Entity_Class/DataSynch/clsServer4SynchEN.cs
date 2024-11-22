
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsServer4SynchEN
 表名:Server4Synch(01120362)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步(DataSynch)
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
 /// 表Server4Synch的关键字(ServerId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ServerId_Server4Synch
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strServerId">表关键字</param>
public K_ServerId_Server4Synch(string strServerId)
{
if (IsValid(strServerId)) Value = strServerId;
else
{
Value = null;
}
}
private static bool IsValid(string strServerId)
{
if (string.IsNullOrEmpty(strServerId) == true) return false;
if (strServerId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ServerId_Server4Synch]类型的对象</returns>
public static implicit operator K_ServerId_Server4Synch(string value)
{
return new K_ServerId_Server4Synch(value);
}
}
 /// <summary>
 /// 同步服务器(Server4Synch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsServer4SynchEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Server4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ServerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"ServerId", "ServerName", "IpAddress", "WebApiAddress", "IsSelf", "InUse", "UpdDate", "UpdUser", "Memo"};

protected string mstrServerId;    //服务器Id
protected string mstrServerName;    //服务器名
protected string mstrIpAddress;    //Ip地址
protected string mstrWebApiAddress;    //WApi地址
protected bool mbolIsSelf;    //是否当前服务器
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsServer4SynchEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ServerId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strServerId">关键字:服务器Id</param>
public clsServer4SynchEN(string strServerId)
 {
strServerId = strServerId.Replace("'", "''");
if (strServerId.Length > 4)
{
throw new Exception("在表:Server4Synch中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strServerId)  ==  true)
{
throw new Exception("在表:Server4Synch中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strServerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrServerId = strServerId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ServerId");
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
if (strAttributeName  ==  conServer4Synch.ServerId)
{
return mstrServerId;
}
else if (strAttributeName  ==  conServer4Synch.ServerName)
{
return mstrServerName;
}
else if (strAttributeName  ==  conServer4Synch.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conServer4Synch.WebApiAddress)
{
return mstrWebApiAddress;
}
else if (strAttributeName  ==  conServer4Synch.IsSelf)
{
return mbolIsSelf;
}
else if (strAttributeName  ==  conServer4Synch.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conServer4Synch.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conServer4Synch.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conServer4Synch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conServer4Synch.ServerId)
{
mstrServerId = value.ToString();
 AddUpdatedFld(conServer4Synch.ServerId);
}
else if (strAttributeName  ==  conServer4Synch.ServerName)
{
mstrServerName = value.ToString();
 AddUpdatedFld(conServer4Synch.ServerName);
}
else if (strAttributeName  ==  conServer4Synch.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conServer4Synch.IpAddress);
}
else if (strAttributeName  ==  conServer4Synch.WebApiAddress)
{
mstrWebApiAddress = value.ToString();
 AddUpdatedFld(conServer4Synch.WebApiAddress);
}
else if (strAttributeName  ==  conServer4Synch.IsSelf)
{
mbolIsSelf = TransNullToBool(value.ToString());
 AddUpdatedFld(conServer4Synch.IsSelf);
}
else if (strAttributeName  ==  conServer4Synch.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conServer4Synch.InUse);
}
else if (strAttributeName  ==  conServer4Synch.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conServer4Synch.UpdDate);
}
else if (strAttributeName  ==  conServer4Synch.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conServer4Synch.UpdUser);
}
else if (strAttributeName  ==  conServer4Synch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conServer4Synch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conServer4Synch.ServerId  ==  AttributeName[intIndex])
{
return mstrServerId;
}
else if (conServer4Synch.ServerName  ==  AttributeName[intIndex])
{
return mstrServerName;
}
else if (conServer4Synch.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conServer4Synch.WebApiAddress  ==  AttributeName[intIndex])
{
return mstrWebApiAddress;
}
else if (conServer4Synch.IsSelf  ==  AttributeName[intIndex])
{
return mbolIsSelf;
}
else if (conServer4Synch.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conServer4Synch.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conServer4Synch.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conServer4Synch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conServer4Synch.ServerId  ==  AttributeName[intIndex])
{
mstrServerId = value.ToString();
 AddUpdatedFld(conServer4Synch.ServerId);
}
else if (conServer4Synch.ServerName  ==  AttributeName[intIndex])
{
mstrServerName = value.ToString();
 AddUpdatedFld(conServer4Synch.ServerName);
}
else if (conServer4Synch.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conServer4Synch.IpAddress);
}
else if (conServer4Synch.WebApiAddress  ==  AttributeName[intIndex])
{
mstrWebApiAddress = value.ToString();
 AddUpdatedFld(conServer4Synch.WebApiAddress);
}
else if (conServer4Synch.IsSelf  ==  AttributeName[intIndex])
{
mbolIsSelf = TransNullToBool(value.ToString());
 AddUpdatedFld(conServer4Synch.IsSelf);
}
else if (conServer4Synch.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conServer4Synch.InUse);
}
else if (conServer4Synch.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conServer4Synch.UpdDate);
}
else if (conServer4Synch.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conServer4Synch.UpdUser);
}
else if (conServer4Synch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conServer4Synch.Memo);
}
}
}

/// <summary>
/// 服务器Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ServerId
{
get
{
return mstrServerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrServerId = value;
}
else
{
 mstrServerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conServer4Synch.ServerId);
}
}
/// <summary>
/// 服务器名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ServerName
{
get
{
return mstrServerName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrServerName = value;
}
else
{
 mstrServerName = value;
}
//记录修改过的字段
 AddUpdatedFld(conServer4Synch.ServerName);
}
}
/// <summary>
/// Ip地址(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conServer4Synch.IpAddress);
}
}
/// <summary>
/// WApi地址(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebApiAddress
{
get
{
return mstrWebApiAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebApiAddress = value;
}
else
{
 mstrWebApiAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conServer4Synch.WebApiAddress);
}
}
/// <summary>
/// 是否当前服务器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSelf
{
get
{
return mbolIsSelf;
}
set
{
 mbolIsSelf = value;
//记录修改过的字段
 AddUpdatedFld(conServer4Synch.IsSelf);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conServer4Synch.InUse);
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
 AddUpdatedFld(conServer4Synch.UpdDate);
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
 AddUpdatedFld(conServer4Synch.UpdUser);
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
 AddUpdatedFld(conServer4Synch.Memo);
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
  return mstrServerId;
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
  return mstrServerName;
 }
 }
}
 /// <summary>
 /// 同步服务器(Server4Synch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conServer4Synch
{
public const string _CurrTabName = "Server4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ServerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ServerId", "ServerName", "IpAddress", "WebApiAddress", "IsSelf", "InUse", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ServerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ServerId = "ServerId";    //服务器Id

 /// <summary>
 /// 常量:"ServerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ServerName = "ServerName";    //服务器名

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //Ip地址

 /// <summary>
 /// 常量:"WebApiAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebApiAddress = "WebApiAddress";    //WApi地址

 /// <summary>
 /// 常量:"IsSelf"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSelf = "IsSelf";    //是否当前服务器

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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