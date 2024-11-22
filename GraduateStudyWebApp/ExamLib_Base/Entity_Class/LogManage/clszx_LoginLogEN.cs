
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_LoginLogEN
 表名:zx_LoginLog(01120813)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
 /// 表zx_LoginLog的关键字(LoginLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LoginLogId_zx_LoginLog
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
public K_LoginLogId_zx_LoginLog(long lngLoginLogId)
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
 /// <returns>返回:[K_LoginLogId_zx_LoginLog]类型的对象</returns>
public static implicit operator K_LoginLogId_zx_LoginLog(long value)
{
return new K_LoginLogId_zx_LoginLog(value);
}
}
 /// <summary>
 /// 中学登录日志(zx_LoginLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_LoginLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_LoginLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LoginLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"LoginLogId", "LoginLogNumber", "LoginIP", "FailReason", "LoginResult", "LoginTime", "LoginUserId", "Memo", "OnlineTime", "OutTime"};

protected long mlngLoginLogId;    //LoginLogId
protected string mstrLoginLogNumber;    //LoginLogNumber
protected string mstrLoginIP;    //LoginIP
protected string mstrFailReason;    //FailReason
protected string mstrLoginResult;    //LoginResult
protected string mstrLoginTime;    //LoginTime
protected string mstrLoginUserId;    //LoginUserId
protected string mstrMemo;    //备注
protected string mstrOnlineTime;    //OnlineTime
protected string mstrOutTime;    //OutTime

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_LoginLogEN()
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
public clszx_LoginLogEN(long lngLoginLogId)
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
if (strAttributeName  ==  conzx_LoginLog.LoginLogId)
{
return mlngLoginLogId;
}
else if (strAttributeName  ==  conzx_LoginLog.LoginLogNumber)
{
return mstrLoginLogNumber;
}
else if (strAttributeName  ==  conzx_LoginLog.LoginIP)
{
return mstrLoginIP;
}
else if (strAttributeName  ==  conzx_LoginLog.FailReason)
{
return mstrFailReason;
}
else if (strAttributeName  ==  conzx_LoginLog.LoginResult)
{
return mstrLoginResult;
}
else if (strAttributeName  ==  conzx_LoginLog.LoginTime)
{
return mstrLoginTime;
}
else if (strAttributeName  ==  conzx_LoginLog.LoginUserId)
{
return mstrLoginUserId;
}
else if (strAttributeName  ==  conzx_LoginLog.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_LoginLog.OnlineTime)
{
return mstrOnlineTime;
}
else if (strAttributeName  ==  conzx_LoginLog.OutTime)
{
return mstrOutTime;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_LoginLog.LoginLogId)
{
mlngLoginLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_LoginLog.LoginLogId);
}
else if (strAttributeName  ==  conzx_LoginLog.LoginLogNumber)
{
mstrLoginLogNumber = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginLogNumber);
}
else if (strAttributeName  ==  conzx_LoginLog.LoginIP)
{
mstrLoginIP = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginIP);
}
else if (strAttributeName  ==  conzx_LoginLog.FailReason)
{
mstrFailReason = value.ToString();
 AddUpdatedFld(conzx_LoginLog.FailReason);
}
else if (strAttributeName  ==  conzx_LoginLog.LoginResult)
{
mstrLoginResult = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginResult);
}
else if (strAttributeName  ==  conzx_LoginLog.LoginTime)
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginTime);
}
else if (strAttributeName  ==  conzx_LoginLog.LoginUserId)
{
mstrLoginUserId = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginUserId);
}
else if (strAttributeName  ==  conzx_LoginLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_LoginLog.Memo);
}
else if (strAttributeName  ==  conzx_LoginLog.OnlineTime)
{
mstrOnlineTime = value.ToString();
 AddUpdatedFld(conzx_LoginLog.OnlineTime);
}
else if (strAttributeName  ==  conzx_LoginLog.OutTime)
{
mstrOutTime = value.ToString();
 AddUpdatedFld(conzx_LoginLog.OutTime);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_LoginLog.LoginLogId  ==  AttributeName[intIndex])
{
return mlngLoginLogId;
}
else if (conzx_LoginLog.LoginLogNumber  ==  AttributeName[intIndex])
{
return mstrLoginLogNumber;
}
else if (conzx_LoginLog.LoginIP  ==  AttributeName[intIndex])
{
return mstrLoginIP;
}
else if (conzx_LoginLog.FailReason  ==  AttributeName[intIndex])
{
return mstrFailReason;
}
else if (conzx_LoginLog.LoginResult  ==  AttributeName[intIndex])
{
return mstrLoginResult;
}
else if (conzx_LoginLog.LoginTime  ==  AttributeName[intIndex])
{
return mstrLoginTime;
}
else if (conzx_LoginLog.LoginUserId  ==  AttributeName[intIndex])
{
return mstrLoginUserId;
}
else if (conzx_LoginLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_LoginLog.OnlineTime  ==  AttributeName[intIndex])
{
return mstrOnlineTime;
}
else if (conzx_LoginLog.OutTime  ==  AttributeName[intIndex])
{
return mstrOutTime;
}
return null;
}
set
{
if (conzx_LoginLog.LoginLogId  ==  AttributeName[intIndex])
{
mlngLoginLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_LoginLog.LoginLogId);
}
else if (conzx_LoginLog.LoginLogNumber  ==  AttributeName[intIndex])
{
mstrLoginLogNumber = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginLogNumber);
}
else if (conzx_LoginLog.LoginIP  ==  AttributeName[intIndex])
{
mstrLoginIP = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginIP);
}
else if (conzx_LoginLog.FailReason  ==  AttributeName[intIndex])
{
mstrFailReason = value.ToString();
 AddUpdatedFld(conzx_LoginLog.FailReason);
}
else if (conzx_LoginLog.LoginResult  ==  AttributeName[intIndex])
{
mstrLoginResult = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginResult);
}
else if (conzx_LoginLog.LoginTime  ==  AttributeName[intIndex])
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginTime);
}
else if (conzx_LoginLog.LoginUserId  ==  AttributeName[intIndex])
{
mstrLoginUserId = value.ToString();
 AddUpdatedFld(conzx_LoginLog.LoginUserId);
}
else if (conzx_LoginLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_LoginLog.Memo);
}
else if (conzx_LoginLog.OnlineTime  ==  AttributeName[intIndex])
{
mstrOnlineTime = value.ToString();
 AddUpdatedFld(conzx_LoginLog.OnlineTime);
}
else if (conzx_LoginLog.OutTime  ==  AttributeName[intIndex])
{
mstrOutTime = value.ToString();
 AddUpdatedFld(conzx_LoginLog.OutTime);
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
 AddUpdatedFld(conzx_LoginLog.LoginLogId);
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
 AddUpdatedFld(conzx_LoginLog.LoginLogNumber);
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
 AddUpdatedFld(conzx_LoginLog.LoginIP);
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
 AddUpdatedFld(conzx_LoginLog.FailReason);
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
 AddUpdatedFld(conzx_LoginLog.LoginResult);
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
 AddUpdatedFld(conzx_LoginLog.LoginTime);
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
 AddUpdatedFld(conzx_LoginLog.LoginUserId);
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
 AddUpdatedFld(conzx_LoginLog.Memo);
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
 AddUpdatedFld(conzx_LoginLog.OnlineTime);
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
 AddUpdatedFld(conzx_LoginLog.OutTime);
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
 /// 中学登录日志(zx_LoginLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_LoginLog
{
public const string _CurrTabName = "zx_LoginLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LoginLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"LoginLogId", "LoginLogNumber", "LoginIP", "FailReason", "LoginResult", "LoginTime", "LoginUserId", "Memo", "OnlineTime", "OutTime"};
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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
}

}