﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWorkTypeEN
 表名:WorkType(01120196)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:50
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
 /// 表WorkType的关键字(WorkTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WorkTypeId_WorkType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWorkTypeId">表关键字</param>
public K_WorkTypeId_WorkType(string strWorkTypeId)
{
if (IsValid(strWorkTypeId)) Value = strWorkTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strWorkTypeId)
{
if (string.IsNullOrEmpty(strWorkTypeId) == true) return false;
if (strWorkTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WorkTypeId_WorkType]类型的对象</returns>
public static implicit operator K_WorkTypeId_WorkType(string value)
{
return new K_WorkTypeId_WorkType(value);
}
}
 /// <summary>
 /// 作业类型(WorkType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsWorkTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "WorkType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WorkTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"WorkTypeId", "WorkTypeName", "Memo"};

protected string mstrWorkTypeId;    //作业类型Id
protected string mstrWorkTypeName;    //作业类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsWorkTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WorkTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strWorkTypeId">关键字:作业类型Id</param>
public clsWorkTypeEN(string strWorkTypeId)
 {
strWorkTypeId = strWorkTypeId.Replace("'", "''");
if (strWorkTypeId.Length > 2)
{
throw new Exception("在表:WorkType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWorkTypeId)  ==  true)
{
throw new Exception("在表:WorkType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWorkTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWorkTypeId = strWorkTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WorkTypeId");
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
if (strAttributeName  ==  conWorkType.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  conWorkType.WorkTypeName)
{
return mstrWorkTypeName;
}
else if (strAttributeName  ==  conWorkType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conWorkType.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(conWorkType.WorkTypeId);
}
else if (strAttributeName  ==  conWorkType.WorkTypeName)
{
mstrWorkTypeName = value.ToString();
 AddUpdatedFld(conWorkType.WorkTypeName);
}
else if (strAttributeName  ==  conWorkType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWorkType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conWorkType.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (conWorkType.WorkTypeName  ==  AttributeName[intIndex])
{
return mstrWorkTypeName;
}
else if (conWorkType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conWorkType.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(conWorkType.WorkTypeId);
}
else if (conWorkType.WorkTypeName  ==  AttributeName[intIndex])
{
mstrWorkTypeName = value.ToString();
 AddUpdatedFld(conWorkType.WorkTypeName);
}
else if (conWorkType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWorkType.Memo);
}
}
}

/// <summary>
/// 作业类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkTypeId
{
get
{
return mstrWorkTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkTypeId = value;
}
else
{
 mstrWorkTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWorkType.WorkTypeId);
}
}
/// <summary>
/// 作业类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkTypeName
{
get
{
return mstrWorkTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkTypeName = value;
}
else
{
 mstrWorkTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conWorkType.WorkTypeName);
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
 AddUpdatedFld(conWorkType.Memo);
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
  return mstrWorkTypeId;
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
  return mstrWorkTypeName;
 }
 }
}
 /// <summary>
 /// 作业类型(WorkType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conWorkType
{
public const string _CurrTabName = "WorkType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WorkTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"WorkTypeId", "WorkTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"WorkTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkTypeId = "WorkTypeId";    //作业类型Id

 /// <summary>
 /// 常量:"WorkTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkTypeName = "WorkTypeName";    //作业类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}