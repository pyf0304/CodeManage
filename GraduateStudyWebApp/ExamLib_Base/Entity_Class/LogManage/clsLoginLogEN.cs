
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLoginLogEN
 表名:LoginLog(01120357)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
 /// 表LoginLog的关键字(LoginLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LoginLogId_LoginLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngLoginLogId">表关键字</param>
public K_LoginLogId_LoginLog(long lngLoginLogId)
{
if (IsValid(lngLoginLogId)) Value = lngLoginLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngLoginLogId)
{
if (lngLoginLogId == 0) return false;
if (lngLoginLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_LoginLogId_LoginLog]类型的对象</returns>
public static implicit operator K_LoginLogId_LoginLog(long value)
{
return new K_LoginLogId_LoginLog(value);
}
}
 /// <summary>
 /// 登录日志(LoginLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsLoginLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "LoginLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LoginLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"LoginLogId", "LoginLogNumber", "LoginIP", "FailReason", "LoginResult", "LoginTime", "LoginUserId", "OnlineTime", "OutTime", "Memo"};

protected long mlngLoginLogId;    //LoginLogId
protected string mstrLoginLogNumber;    //LoginLogNumber
protected string mstrLoginIP;    //LoginIP
protected string mstrFailReason;    //FailReason
protected string mstrLoginResult;    //LoginResult
protected string mstrLoginTime;    //LoginTime
protected string mstrLoginUserId;    //LoginUserId
protected string mstrOnlineTime;    //OnlineTime
protected string mstrOutTime;    //OutTime
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsLoginLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LoginLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngLoginLogId">关键字:LoginLogId</param>
public clsLoginLogEN(long lngLoginLogId)
 {
 if (lngLoginLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngLoginLogId = lngLoginLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LoginLogId");
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
if (strAttributeName  ==  conLoginLog.LoginLogId)
{
return mlngLoginLogId;
}
else if (strAttributeName  ==  conLoginLog.LoginLogNumber)
{
return mstrLoginLogNumber;
}
else if (strAttributeName  ==  conLoginLog.LoginIP)
{
return mstrLoginIP;
}
else if (strAttributeName  ==  conLoginLog.FailReason)
{
return mstrFailReason;
}
else if (strAttributeName  ==  conLoginLog.LoginResult)
{
return mstrLoginResult;
}
else if (strAttributeName  ==  conLoginLog.LoginTime)
{
return mstrLoginTime;
}
else if (strAttributeName  ==  conLoginLog.LoginUserId)
{
return mstrLoginUserId;
}
else if (strAttributeName  ==  conLoginLog.OnlineTime)
{
return mstrOnlineTime;
}
else if (strAttributeName  ==  conLoginLog.OutTime)
{
return mstrOutTime;
}
else if (strAttributeName  ==  conLoginLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conLoginLog.LoginLogId)
{
mlngLoginLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conLoginLog.LoginLogId);
}
else if (strAttributeName  ==  conLoginLog.LoginLogNumber)
{
mstrLoginLogNumber = value.ToString();
 AddUpdatedFld(conLoginLog.LoginLogNumber);
}
else if (strAttributeName  ==  conLoginLog.LoginIP)
{
mstrLoginIP = value.ToString();
 AddUpdatedFld(conLoginLog.LoginIP);
}
else if (strAttributeName  ==  conLoginLog.FailReason)
{
mstrFailReason = value.ToString();
 AddUpdatedFld(conLoginLog.FailReason);
}
else if (strAttributeName  ==  conLoginLog.LoginResult)
{
mstrLoginResult = value.ToString();
 AddUpdatedFld(conLoginLog.LoginResult);
}
else if (strAttributeName  ==  conLoginLog.LoginTime)
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(conLoginLog.LoginTime);
}
else if (strAttributeName  ==  conLoginLog.LoginUserId)
{
mstrLoginUserId = value.ToString();
 AddUpdatedFld(conLoginLog.LoginUserId);
}
else if (strAttributeName  ==  conLoginLog.OnlineTime)
{
mstrOnlineTime = value.ToString();
 AddUpdatedFld(conLoginLog.OnlineTime);
}
else if (strAttributeName  ==  conLoginLog.OutTime)
{
mstrOutTime = value.ToString();
 AddUpdatedFld(conLoginLog.OutTime);
}
else if (strAttributeName  ==  conLoginLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLoginLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conLoginLog.LoginLogId  ==  AttributeName[intIndex])
{
return mlngLoginLogId;
}
else if (conLoginLog.LoginLogNumber  ==  AttributeName[intIndex])
{
return mstrLoginLogNumber;
}
else if (conLoginLog.LoginIP  ==  AttributeName[intIndex])
{
return mstrLoginIP;
}
else if (conLoginLog.FailReason  ==  AttributeName[intIndex])
{
return mstrFailReason;
}
else if (conLoginLog.LoginResult  ==  AttributeName[intIndex])
{
return mstrLoginResult;
}
else if (conLoginLog.LoginTime  ==  AttributeName[intIndex])
{
return mstrLoginTime;
}
else if (conLoginLog.LoginUserId  ==  AttributeName[intIndex])
{
return mstrLoginUserId;
}
else if (conLoginLog.OnlineTime  ==  AttributeName[intIndex])
{
return mstrOnlineTime;
}
else if (conLoginLog.OutTime  ==  AttributeName[intIndex])
{
return mstrOutTime;
}
else if (conLoginLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conLoginLog.LoginLogId  ==  AttributeName[intIndex])
{
mlngLoginLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conLoginLog.LoginLogId);
}
else if (conLoginLog.LoginLogNumber  ==  AttributeName[intIndex])
{
mstrLoginLogNumber = value.ToString();
 AddUpdatedFld(conLoginLog.LoginLogNumber);
}
else if (conLoginLog.LoginIP  ==  AttributeName[intIndex])
{
mstrLoginIP = value.ToString();
 AddUpdatedFld(conLoginLog.LoginIP);
}
else if (conLoginLog.FailReason  ==  AttributeName[intIndex])
{
mstrFailReason = value.ToString();
 AddUpdatedFld(conLoginLog.FailReason);
}
else if (conLoginLog.LoginResult  ==  AttributeName[intIndex])
{
mstrLoginResult = value.ToString();
 AddUpdatedFld(conLoginLog.LoginResult);
}
else if (conLoginLog.LoginTime  ==  AttributeName[intIndex])
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(conLoginLog.LoginTime);
}
else if (conLoginLog.LoginUserId  ==  AttributeName[intIndex])
{
mstrLoginUserId = value.ToString();
 AddUpdatedFld(conLoginLog.LoginUserId);
}
else if (conLoginLog.OnlineTime  ==  AttributeName[intIndex])
{
mstrOnlineTime = value.ToString();
 AddUpdatedFld(conLoginLog.OnlineTime);
}
else if (conLoginLog.OutTime  ==  AttributeName[intIndex])
{
mstrOutTime = value.ToString();
 AddUpdatedFld(conLoginLog.OutTime);
}
else if (conLoginLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLoginLog.Memo);
}
}
}

/// <summary>
/// LoginLogId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long LoginLogId
{
get
{
return mlngLoginLogId;
}
set
{
 mlngLoginLogId = value;
//记录修改过的字段
 AddUpdatedFld(conLoginLog.LoginLogId);
}
}
/// <summary>
/// LoginLogNumber(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LoginLogNumber
{
get
{
return mstrLoginLogNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLoginLogNumber = value;
}
else
{
 mstrLoginLogNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(conLoginLog.LoginLogNumber);
}
}
/// <summary>
/// LoginIP(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LoginIP
{
get
{
return mstrLoginIP;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLoginIP = value;
}
else
{
 mstrLoginIP = value;
}
//记录修改过的字段
 AddUpdatedFld(conLoginLog.LoginIP);
}
}
/// <summary>
/// FailReason(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FailReason
{
get
{
return mstrFailReason;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFailReason = value;
}
else
{
 mstrFailReason = value;
}
//记录修改过的字段
 AddUpdatedFld(conLoginLog.FailReason);
}
}
/// <summary>
/// LoginResult(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LoginResult
{
get
{
return mstrLoginResult;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLoginResult = value;
}
else
{
 mstrLoginResult = value;
}
//记录修改过的字段
 AddUpdatedFld(conLoginLog.LoginResult);
}
}
/// <summary>
/// LoginTime(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LoginTime
{
get
{
return mstrLoginTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLoginTime = value;
}
else
{
 mstrLoginTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conLoginLog.LoginTime);
}
}
/// <summary>
/// LoginUserId(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LoginUserId
{
get
{
return mstrLoginUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLoginUserId = value;
}
else
{
 mstrLoginUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conLoginLog.LoginUserId);
}
}
/// <summary>
/// OnlineTime(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OnlineTime
{
get
{
return mstrOnlineTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOnlineTime = value;
}
else
{
 mstrOnlineTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conLoginLog.OnlineTime);
}
}
/// <summary>
/// OutTime(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OutTime
{
get
{
return mstrOutTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOutTime = value;
}
else
{
 mstrOutTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conLoginLog.OutTime);
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
 AddUpdatedFld(conLoginLog.Memo);
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
  return mlngLoginLogId.ToString();
 }
 }
}
 /// <summary>
 /// 登录日志(LoginLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conLoginLog
{
public const string _CurrTabName = "LoginLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LoginLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"LoginLogId", "LoginLogNumber", "LoginIP", "FailReason", "LoginResult", "LoginTime", "LoginUserId", "OnlineTime", "OutTime", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"LoginLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LoginLogId = "LoginLogId";    //LoginLogId

 /// <summary>
 /// 常量:"LoginLogNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LoginLogNumber = "LoginLogNumber";    //LoginLogNumber

 /// <summary>
 /// 常量:"LoginIP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LoginIP = "LoginIP";    //LoginIP

 /// <summary>
 /// 常量:"FailReason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FailReason = "FailReason";    //FailReason

 /// <summary>
 /// 常量:"LoginResult"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LoginResult = "LoginResult";    //LoginResult

 /// <summary>
 /// 常量:"LoginTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LoginTime = "LoginTime";    //LoginTime

 /// <summary>
 /// 常量:"LoginUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LoginUserId = "LoginUserId";    //LoginUserId

 /// <summary>
 /// 常量:"OnlineTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OnlineTime = "OnlineTime";    //OnlineTime

 /// <summary>
 /// 常量:"OutTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OutTime = "OutTime";    //OutTime

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}