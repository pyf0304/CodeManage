
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserKindEN
 表名:UserKind(01120328)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表UserKind的关键字(UserKindId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserKindId_UserKind
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserKindId">表关键字</param>
public K_UserKindId_UserKind(string strUserKindId)
{
if (IsValid(strUserKindId)) Value = strUserKindId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserKindId)
{
if (string.IsNullOrEmpty(strUserKindId) == true) return false;
if (strUserKindId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserKindId_UserKind]类型的对象</returns>
public static implicit operator K_UserKindId_UserKind(string value)
{
return new K_UserKindId_UserKind(value);
}
}
 /// <summary>
 /// 用户类别(UserKind)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserKindEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserKind"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserKindId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"UserKindId", "UserKindName", "Memo"};

protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserKindEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserKindId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserKindId">关键字:用户类别Id</param>
public clsUserKindEN(string strUserKindId)
 {
strUserKindId = strUserKindId.Replace("'", "''");
if (strUserKindId.Length > 2)
{
throw new Exception("在表:UserKind中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserKindId)  ==  true)
{
throw new Exception("在表:UserKind中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserKindId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserKindId = strUserKindId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserKindId");
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
if (strAttributeName  ==  conUserKind.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  conUserKind.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  conUserKind.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserKind.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(conUserKind.UserKindId);
}
else if (strAttributeName  ==  conUserKind.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(conUserKind.UserKindName);
}
else if (strAttributeName  ==  conUserKind.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserKind.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserKind.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (conUserKind.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (conUserKind.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserKind.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(conUserKind.UserKindId);
}
else if (conUserKind.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(conUserKind.UserKindName);
}
else if (conUserKind.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserKind.Memo);
}
}
}

/// <summary>
/// 用户类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindId
{
get
{
return mstrUserKindId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindId = value;
}
else
{
 mstrUserKindId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserKind.UserKindId);
}
}
/// <summary>
/// 用户类别名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindName
{
get
{
return mstrUserKindName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindName = value;
}
else
{
 mstrUserKindName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserKind.UserKindName);
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
 AddUpdatedFld(conUserKind.Memo);
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
  return mstrUserKindId;
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
  return mstrUserKindName;
 }
 }
}
 /// <summary>
 /// 用户类别(UserKind)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserKind
{
public const string _CurrTabName = "UserKind"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserKindId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserKindId", "UserKindName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserKindId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindId = "UserKindId";    //用户类别Id

 /// <summary>
 /// 常量:"UserKindName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindName = "UserKindName";    //用户类别名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}