﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTemplate1EN
 表名:Template1(00050198)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:48:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表Template1的关键字(Key1)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_Key1_Template1
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKey1">表关键字</param>
public K_Key1_Template1(string strKey1)
{
if (IsValid(strKey1)) Value = strKey1;
else
{
Value = null;
}
}
private static bool IsValid(string strKey1)
{
if (string.IsNullOrEmpty(strKey1) == true) return false;
if (strKey1.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_Key1_Template1]类型的对象</returns>
public static implicit operator K_Key1_Template1(string value)
{
return new K_Key1_Template1(value);
}
}
 /// <summary>
 /// 模板1(Template1)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTemplate1EN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Template1"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "Key1"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"Key1", "Name1", "Memo"};

protected string mstrKey1;    //关键字段1
protected string mstrName1;    //名称字段1
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTemplate1EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("Key1");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strKey1">关键字:关键字段1</param>
public clsTemplate1EN(string strKey1)
 {
strKey1 = strKey1.Replace("'", "''");
if (strKey1.Length > 4)
{
throw new Exception("在表:Template1中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKey1)  ==  true)
{
throw new Exception("在表:Template1中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKey1);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKey1 = strKey1;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("Key1");
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
if (strAttributeName  ==  conTemplate1.Key1)
{
return mstrKey1;
}
else if (strAttributeName  ==  conTemplate1.Name1)
{
return mstrName1;
}
else if (strAttributeName  ==  conTemplate1.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTemplate1.Key1)
{
mstrKey1 = value.ToString();
 AddUpdatedFld(conTemplate1.Key1);
}
else if (strAttributeName  ==  conTemplate1.Name1)
{
mstrName1 = value.ToString();
 AddUpdatedFld(conTemplate1.Name1);
}
else if (strAttributeName  ==  conTemplate1.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTemplate1.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTemplate1.Key1  ==  AttributeName[intIndex])
{
return mstrKey1;
}
else if (conTemplate1.Name1  ==  AttributeName[intIndex])
{
return mstrName1;
}
else if (conTemplate1.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTemplate1.Key1  ==  AttributeName[intIndex])
{
mstrKey1 = value.ToString();
 AddUpdatedFld(conTemplate1.Key1);
}
else if (conTemplate1.Name1  ==  AttributeName[intIndex])
{
mstrName1 = value.ToString();
 AddUpdatedFld(conTemplate1.Name1);
}
else if (conTemplate1.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTemplate1.Memo);
}
}
}

/// <summary>
/// 关键字段1(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Key1
{
get
{
return mstrKey1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKey1 = value;
}
else
{
 mstrKey1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conTemplate1.Key1);
}
}
/// <summary>
/// 名称字段1(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Name1
{
get
{
return mstrName1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrName1 = value;
}
else
{
 mstrName1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conTemplate1.Name1);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
 AddUpdatedFld(conTemplate1.Memo);
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
  return mstrKey1;
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
  return mstrName1;
 }
 }
}
 /// <summary>
 /// 模板1(Template1)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTemplate1
{
public const string _CurrTabName = "Template1"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "Key1"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Key1", "Name1", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"Key1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Key1 = "Key1";    //关键字段1

 /// <summary>
 /// 常量:"Name1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Name1 = "Name1";    //名称字段1

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}