﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsManagedDepartmentEN
 表名:ManagedDepartment(01120228)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:50
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
 /// 表ManagedDepartment的关键字(ManagedDepartmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ManagedDepartmentId_ManagedDepartment
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strManagedDepartmentId">表关键字</param>
public K_ManagedDepartmentId_ManagedDepartment(string strManagedDepartmentId)
{
if (IsValid(strManagedDepartmentId)) Value = strManagedDepartmentId;
else
{
Value = null;
}
}
private static bool IsValid(string strManagedDepartmentId)
{
if (string.IsNullOrEmpty(strManagedDepartmentId) == true) return false;
if (strManagedDepartmentId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ManagedDepartmentId_ManagedDepartment]类型的对象</returns>
public static implicit operator K_ManagedDepartmentId_ManagedDepartment(string value)
{
return new K_ManagedDepartmentId_ManagedDepartment(value);
}
}
 /// <summary>
 /// 管理的部门(ManagedDepartment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsManagedDepartmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ManagedDepartment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ManagedDepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ManagedDepartmentId", "ManagedDepartmentName", "Memo"};

protected string mstrManagedDepartmentId;    //管理的部门Id
protected string mstrManagedDepartmentName;    //管理的部门名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsManagedDepartmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ManagedDepartmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strManagedDepartmentId">关键字:管理的部门Id</param>
public clsManagedDepartmentEN(string strManagedDepartmentId)
 {
strManagedDepartmentId = strManagedDepartmentId.Replace("'", "''");
if (strManagedDepartmentId.Length > 4)
{
throw new Exception("在表:ManagedDepartment中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strManagedDepartmentId)  ==  true)
{
throw new Exception("在表:ManagedDepartment中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strManagedDepartmentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrManagedDepartmentId = strManagedDepartmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ManagedDepartmentId");
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
if (strAttributeName  ==  conManagedDepartment.ManagedDepartmentId)
{
return mstrManagedDepartmentId;
}
else if (strAttributeName  ==  conManagedDepartment.ManagedDepartmentName)
{
return mstrManagedDepartmentName;
}
else if (strAttributeName  ==  conManagedDepartment.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conManagedDepartment.ManagedDepartmentId)
{
mstrManagedDepartmentId = value.ToString();
 AddUpdatedFld(conManagedDepartment.ManagedDepartmentId);
}
else if (strAttributeName  ==  conManagedDepartment.ManagedDepartmentName)
{
mstrManagedDepartmentName = value.ToString();
 AddUpdatedFld(conManagedDepartment.ManagedDepartmentName);
}
else if (strAttributeName  ==  conManagedDepartment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conManagedDepartment.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conManagedDepartment.ManagedDepartmentId  ==  AttributeName[intIndex])
{
return mstrManagedDepartmentId;
}
else if (conManagedDepartment.ManagedDepartmentName  ==  AttributeName[intIndex])
{
return mstrManagedDepartmentName;
}
else if (conManagedDepartment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conManagedDepartment.ManagedDepartmentId  ==  AttributeName[intIndex])
{
mstrManagedDepartmentId = value.ToString();
 AddUpdatedFld(conManagedDepartment.ManagedDepartmentId);
}
else if (conManagedDepartment.ManagedDepartmentName  ==  AttributeName[intIndex])
{
mstrManagedDepartmentName = value.ToString();
 AddUpdatedFld(conManagedDepartment.ManagedDepartmentName);
}
else if (conManagedDepartment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conManagedDepartment.Memo);
}
}
}

/// <summary>
/// 管理的部门Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ManagedDepartmentId
{
get
{
return mstrManagedDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrManagedDepartmentId = value;
}
else
{
 mstrManagedDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conManagedDepartment.ManagedDepartmentId);
}
}
/// <summary>
/// 管理的部门名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ManagedDepartmentName
{
get
{
return mstrManagedDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrManagedDepartmentName = value;
}
else
{
 mstrManagedDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(conManagedDepartment.ManagedDepartmentName);
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
 AddUpdatedFld(conManagedDepartment.Memo);
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
  return mstrManagedDepartmentId;
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
  return mstrManagedDepartmentName;
 }
 }
}
 /// <summary>
 /// 管理的部门(ManagedDepartment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conManagedDepartment
{
public const string _CurrTabName = "ManagedDepartment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ManagedDepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ManagedDepartmentId", "ManagedDepartmentName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ManagedDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManagedDepartmentId = "ManagedDepartmentId";    //管理的部门Id

 /// <summary>
 /// 常量:"ManagedDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManagedDepartmentName = "ManagedDepartmentName";    //管理的部门名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}