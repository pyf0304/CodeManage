
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserTypeEN
 表名:UserType(01120309)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 表UserType的关键字(UserTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserTypeId_UserType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserTypeId">表关键字</param>
public K_UserTypeId_UserType(string strUserTypeId)
{
if (IsValid(strUserTypeId)) Value = strUserTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserTypeId)
{
if (string.IsNullOrEmpty(strUserTypeId) == true) return false;
if (strUserTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserTypeId_UserType]类型的对象</returns>
public static implicit operator K_UserTypeId_UserType(string value)
{
return new K_UserTypeId_UserType(value);
}
}
 /// <summary>
 /// 用户类型(UserType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"UserTypeId", "UserTypeName", "UserTypeNameSim", "Memo"};

protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrUserTypeNameSim;    //用户类型名_Sim
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserTypeId">关键字:用户类型Id</param>
public clsUserTypeEN(string strUserTypeId)
 {
strUserTypeId = strUserTypeId.Replace("'", "''");
if (strUserTypeId.Length > 2)
{
throw new Exception("在表:UserType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserTypeId)  ==  true)
{
throw new Exception("在表:UserType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserTypeId = strUserTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserTypeId");
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
if (strAttributeName  ==  conUserType.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conUserType.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  conUserType.UserTypeNameSim)
{
return mstrUserTypeNameSim;
}
else if (strAttributeName  ==  conUserType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserType.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conUserType.UserTypeId);
}
else if (strAttributeName  ==  conUserType.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(conUserType.UserTypeName);
}
else if (strAttributeName  ==  conUserType.UserTypeNameSim)
{
mstrUserTypeNameSim = value.ToString();
 AddUpdatedFld(conUserType.UserTypeNameSim);
}
else if (strAttributeName  ==  conUserType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserType.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conUserType.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (conUserType.UserTypeNameSim  ==  AttributeName[intIndex])
{
return mstrUserTypeNameSim;
}
else if (conUserType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserType.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conUserType.UserTypeId);
}
else if (conUserType.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(conUserType.UserTypeName);
}
else if (conUserType.UserTypeNameSim  ==  AttributeName[intIndex])
{
mstrUserTypeNameSim = value.ToString();
 AddUpdatedFld(conUserType.UserTypeNameSim);
}
else if (conUserType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserType.Memo);
}
}
}

/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserType.UserTypeId);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserType.UserTypeName);
}
}
/// <summary>
/// 用户类型名_Sim(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeNameSim
{
get
{
return mstrUserTypeNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeNameSim = value;
}
else
{
 mstrUserTypeNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserType.UserTypeNameSim);
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
 AddUpdatedFld(conUserType.Memo);
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
  return mstrUserTypeId;
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
  return mstrUserTypeName;
 }
 }
}
 /// <summary>
 /// 用户类型(UserType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserType
{
public const string _CurrTabName = "UserType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserTypeId", "UserTypeName", "UserTypeNameSim", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"UserTypeNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeNameSim = "UserTypeNameSim";    //用户类型名_Sim

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}