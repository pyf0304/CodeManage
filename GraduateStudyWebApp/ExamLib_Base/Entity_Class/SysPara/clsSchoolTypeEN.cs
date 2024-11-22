﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSchoolTypeEN
 表名:SchoolType(01120030)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:26
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
 /// 表SchoolType的关键字(SchoolTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SchoolTypeId_SchoolType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSchoolTypeId">表关键字</param>
public K_SchoolTypeId_SchoolType(string strSchoolTypeId)
{
if (IsValid(strSchoolTypeId)) Value = strSchoolTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSchoolTypeId)
{
if (string.IsNullOrEmpty(strSchoolTypeId) == true) return false;
if (strSchoolTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SchoolTypeId_SchoolType]类型的对象</returns>
public static implicit operator K_SchoolTypeId_SchoolType(string value)
{
return new K_SchoolTypeId_SchoolType(value);
}
}
 /// <summary>
 /// 学校类型(SchoolType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSchoolTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SchoolType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SchoolTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"SchoolTypeId", "SchoolTypeName", "Memo"};

protected string mstrSchoolTypeId;    //学校类型Id
protected string mstrSchoolTypeName;    //学校类型名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSchoolTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SchoolTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSchoolTypeId">关键字:学校类型Id</param>
public clsSchoolTypeEN(string strSchoolTypeId)
 {
strSchoolTypeId = strSchoolTypeId.Replace("'", "''");
if (strSchoolTypeId.Length > 2)
{
throw new Exception("在表:SchoolType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSchoolTypeId)  ==  true)
{
throw new Exception("在表:SchoolType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSchoolTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSchoolTypeId = strSchoolTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SchoolTypeId");
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
if (strAttributeName  ==  conSchoolType.SchoolTypeId)
{
return mstrSchoolTypeId;
}
else if (strAttributeName  ==  conSchoolType.SchoolTypeName)
{
return mstrSchoolTypeName;
}
else if (strAttributeName  ==  conSchoolType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSchoolType.SchoolTypeId)
{
mstrSchoolTypeId = value.ToString();
 AddUpdatedFld(conSchoolType.SchoolTypeId);
}
else if (strAttributeName  ==  conSchoolType.SchoolTypeName)
{
mstrSchoolTypeName = value.ToString();
 AddUpdatedFld(conSchoolType.SchoolTypeName);
}
else if (strAttributeName  ==  conSchoolType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSchoolType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSchoolType.SchoolTypeId  ==  AttributeName[intIndex])
{
return mstrSchoolTypeId;
}
else if (conSchoolType.SchoolTypeName  ==  AttributeName[intIndex])
{
return mstrSchoolTypeName;
}
else if (conSchoolType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSchoolType.SchoolTypeId  ==  AttributeName[intIndex])
{
mstrSchoolTypeId = value.ToString();
 AddUpdatedFld(conSchoolType.SchoolTypeId);
}
else if (conSchoolType.SchoolTypeName  ==  AttributeName[intIndex])
{
mstrSchoolTypeName = value.ToString();
 AddUpdatedFld(conSchoolType.SchoolTypeName);
}
else if (conSchoolType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSchoolType.Memo);
}
}
}

/// <summary>
/// 学校类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTypeId
{
get
{
return mstrSchoolTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTypeId = value;
}
else
{
 mstrSchoolTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSchoolType.SchoolTypeId);
}
}
/// <summary>
/// 学校类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTypeName
{
get
{
return mstrSchoolTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTypeName = value;
}
else
{
 mstrSchoolTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSchoolType.SchoolTypeName);
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
 AddUpdatedFld(conSchoolType.Memo);
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
  return mstrSchoolTypeId;
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
  return mstrSchoolTypeName;
 }
 }
}
 /// <summary>
 /// 学校类型(SchoolType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSchoolType
{
public const string _CurrTabName = "SchoolType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SchoolTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SchoolTypeId", "SchoolTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SchoolTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTypeId = "SchoolTypeId";    //学校类型Id

 /// <summary>
 /// 常量:"SchoolTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTypeName = "SchoolTypeName";    //学校类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}