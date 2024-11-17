
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserStateEN
 表名:UserState(01160003)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:04:14
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:系统基本参数(BaseParameter)
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

namespace SimplePrj.Entity
{
 /// <summary>
 /// 表UserState的关键字(UserStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserStateId_UserState
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserStateId">表关键字</param>
public K_UserStateId_UserState(string strUserStateId)
{
if (IsValid(strUserStateId)) Value = strUserStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserStateId)
{
if (string.IsNullOrEmpty(strUserStateId) == true) return false;
if (strUserStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserStateId_UserState]类型的对象</returns>
public static implicit operator K_UserStateId_UserState(string value)
{
return new K_UserStateId_UserState(value);
}
}
 /// <summary>
 /// 用户状态(UserState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserStateEN : clsEntityBase2
{
public const string _CurrTabName_S = "UserState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"UserStateId", "UserStateName", "Memo"};
//以下是属性变量

protected string mstrUserStateId;    //用户状态Id
protected string mstrUserStateName;    //用户状态名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "UserState";
 lstKeyFldNames.Add("UserStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserStateId">关键字:用户状态Id</param>
public clsUserStateEN(string strUserStateId)
 {
strUserStateId = strUserStateId.Replace("'", "''");
if (strUserStateId.Length > 2)
{
throw new Exception("在表:UserState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserStateId)  ==  true)
{
throw new Exception("在表:UserState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserStateId = strUserStateId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "UserState";
 lstKeyFldNames.Add("UserStateId");
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
if (strAttributeName  ==  conUserState.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  conUserState.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  conUserState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserState.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conUserState.UserStateId);
}
else if (strAttributeName  ==  conUserState.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(conUserState.UserStateName);
}
else if (strAttributeName  ==  conUserState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserState.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (conUserState.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (conUserState.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserState.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conUserState.UserStateId);
}
else if (conUserState.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(conUserState.UserStateName);
}
else if (conUserState.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserState.Memo);
}
}
}

/// <summary>
/// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateId
{
get
{
return mstrUserStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateId = value;
}
else
{
 mstrUserStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserState.UserStateId);
}
}
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateName
{
get
{
return mstrUserStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateName = value;
}
else
{
 mstrUserStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserState.UserStateName);
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
 AddUpdatedFld(conUserState.Memo);
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
  return mstrUserStateId;
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
  return mstrUserStateName;
 }
 }
}
 /// <summary>
 /// 用户状态(UserState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserState
{
public const string _CurrTabName_S = "UserState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserStateId", "UserStateName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}