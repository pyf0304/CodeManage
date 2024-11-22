
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExplainTypeEN
 表名:ExplainType(01120548)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表ExplainType的关键字(ExplainTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ExplainTypeId_ExplainType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strExplainTypeId">表关键字</param>
public K_ExplainTypeId_ExplainType(string strExplainTypeId)
{
if (IsValid(strExplainTypeId)) Value = strExplainTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strExplainTypeId)
{
if (string.IsNullOrEmpty(strExplainTypeId) == true) return false;
if (strExplainTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ExplainTypeId_ExplainType]类型的对象</returns>
public static implicit operator K_ExplainTypeId_ExplainType(string value)
{
return new K_ExplainTypeId_ExplainType(value);
}
}
 /// <summary>
 /// 说明类型(ExplainType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsExplainTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ExplainType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ExplainTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"ExplainTypeId", "ExplainTypeName", "ExplainTypeENName", "UpdDate", "UpdUserId", "Memo"};

protected string mstrExplainTypeId;    //说明类型Id
protected string mstrExplainTypeName;    //说明类型名
protected string mstrExplainTypeENName;    //说明类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsExplainTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExplainTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strExplainTypeId">关键字:说明类型Id</param>
public clsExplainTypeEN(string strExplainTypeId)
 {
strExplainTypeId = strExplainTypeId.Replace("'", "''");
if (strExplainTypeId.Length > 2)
{
throw new Exception("在表:ExplainType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strExplainTypeId)  ==  true)
{
throw new Exception("在表:ExplainType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strExplainTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrExplainTypeId = strExplainTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExplainTypeId");
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
if (strAttributeName  ==  conExplainType.ExplainTypeId)
{
return mstrExplainTypeId;
}
else if (strAttributeName  ==  conExplainType.ExplainTypeName)
{
return mstrExplainTypeName;
}
else if (strAttributeName  ==  conExplainType.ExplainTypeENName)
{
return mstrExplainTypeENName;
}
else if (strAttributeName  ==  conExplainType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conExplainType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conExplainType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conExplainType.ExplainTypeId)
{
mstrExplainTypeId = value.ToString();
 AddUpdatedFld(conExplainType.ExplainTypeId);
}
else if (strAttributeName  ==  conExplainType.ExplainTypeName)
{
mstrExplainTypeName = value.ToString();
 AddUpdatedFld(conExplainType.ExplainTypeName);
}
else if (strAttributeName  ==  conExplainType.ExplainTypeENName)
{
mstrExplainTypeENName = value.ToString();
 AddUpdatedFld(conExplainType.ExplainTypeENName);
}
else if (strAttributeName  ==  conExplainType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conExplainType.UpdDate);
}
else if (strAttributeName  ==  conExplainType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conExplainType.UpdUserId);
}
else if (strAttributeName  ==  conExplainType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExplainType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conExplainType.ExplainTypeId  ==  AttributeName[intIndex])
{
return mstrExplainTypeId;
}
else if (conExplainType.ExplainTypeName  ==  AttributeName[intIndex])
{
return mstrExplainTypeName;
}
else if (conExplainType.ExplainTypeENName  ==  AttributeName[intIndex])
{
return mstrExplainTypeENName;
}
else if (conExplainType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conExplainType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conExplainType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conExplainType.ExplainTypeId  ==  AttributeName[intIndex])
{
mstrExplainTypeId = value.ToString();
 AddUpdatedFld(conExplainType.ExplainTypeId);
}
else if (conExplainType.ExplainTypeName  ==  AttributeName[intIndex])
{
mstrExplainTypeName = value.ToString();
 AddUpdatedFld(conExplainType.ExplainTypeName);
}
else if (conExplainType.ExplainTypeENName  ==  AttributeName[intIndex])
{
mstrExplainTypeENName = value.ToString();
 AddUpdatedFld(conExplainType.ExplainTypeENName);
}
else if (conExplainType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conExplainType.UpdDate);
}
else if (conExplainType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conExplainType.UpdUserId);
}
else if (conExplainType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conExplainType.Memo);
}
}
}

/// <summary>
/// 说明类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainTypeId
{
get
{
return mstrExplainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainTypeId = value;
}
else
{
 mstrExplainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conExplainType.ExplainTypeId);
}
}
/// <summary>
/// 说明类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainTypeName
{
get
{
return mstrExplainTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainTypeName = value;
}
else
{
 mstrExplainTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExplainType.ExplainTypeName);
}
}
/// <summary>
/// 说明类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainTypeENName
{
get
{
return mstrExplainTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainTypeENName = value;
}
else
{
 mstrExplainTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conExplainType.ExplainTypeENName);
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
 AddUpdatedFld(conExplainType.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conExplainType.UpdUserId);
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
 AddUpdatedFld(conExplainType.Memo);
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
  return mstrExplainTypeId;
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
  return mstrExplainTypeName;
 }
 }
}
 /// <summary>
 /// 说明类型(ExplainType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conExplainType
{
public const string _CurrTabName = "ExplainType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ExplainTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ExplainTypeId", "ExplainTypeName", "ExplainTypeENName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ExplainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainTypeId = "ExplainTypeId";    //说明类型Id

 /// <summary>
 /// 常量:"ExplainTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainTypeName = "ExplainTypeName";    //说明类型名

 /// <summary>
 /// 常量:"ExplainTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainTypeENName = "ExplainTypeENName";    //说明类型英文名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}