
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachPlanTypeEN
 表名:TeachPlanType(01120473)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表TeachPlanType的关键字(IdTeachPlanType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachPlanType_TeachPlanType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeachPlanType">表关键字</param>
public K_IdTeachPlanType_TeachPlanType(string strIdTeachPlanType)
{
if (IsValid(strIdTeachPlanType)) Value = strIdTeachPlanType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeachPlanType)
{
if (string.IsNullOrEmpty(strIdTeachPlanType) == true) return false;
if (strIdTeachPlanType.Length != 1) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachPlanType_TeachPlanType]类型的对象</returns>
public static implicit operator K_IdTeachPlanType_TeachPlanType(string value)
{
return new K_IdTeachPlanType_TeachPlanType(value);
}
}
 /// <summary>
 /// 教案类型(TeachPlanType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachPlanTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachPlanType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachPlanType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdTeachPlanType", "TeachPlanTypeId", "TeachPlanTypeName", "Memo"};

protected string mstrIdTeachPlanType;    //教案类型流水号
protected string mstrTeachPlanTypeId;    //教案类型Id
protected string mstrTeachPlanTypeName;    //教案类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachPlanTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachPlanType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeachPlanType">关键字:教案类型流水号</param>
public clsTeachPlanTypeEN(string strIdTeachPlanType)
 {
strIdTeachPlanType = strIdTeachPlanType.Replace("'", "''");
if (strIdTeachPlanType.Length > 1)
{
throw new Exception("在表:TeachPlanType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachPlanType)  ==  true)
{
throw new Exception("在表:TeachPlanType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachPlanType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeachPlanType = strIdTeachPlanType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachPlanType");
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
if (strAttributeName  ==  conTeachPlanType.IdTeachPlanType)
{
return mstrIdTeachPlanType;
}
else if (strAttributeName  ==  conTeachPlanType.TeachPlanTypeId)
{
return mstrTeachPlanTypeId;
}
else if (strAttributeName  ==  conTeachPlanType.TeachPlanTypeName)
{
return mstrTeachPlanTypeName;
}
else if (strAttributeName  ==  conTeachPlanType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachPlanType.IdTeachPlanType)
{
mstrIdTeachPlanType = value.ToString();
 AddUpdatedFld(conTeachPlanType.IdTeachPlanType);
}
else if (strAttributeName  ==  conTeachPlanType.TeachPlanTypeId)
{
mstrTeachPlanTypeId = value.ToString();
 AddUpdatedFld(conTeachPlanType.TeachPlanTypeId);
}
else if (strAttributeName  ==  conTeachPlanType.TeachPlanTypeName)
{
mstrTeachPlanTypeName = value.ToString();
 AddUpdatedFld(conTeachPlanType.TeachPlanTypeName);
}
else if (strAttributeName  ==  conTeachPlanType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachPlanType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachPlanType.IdTeachPlanType  ==  AttributeName[intIndex])
{
return mstrIdTeachPlanType;
}
else if (conTeachPlanType.TeachPlanTypeId  ==  AttributeName[intIndex])
{
return mstrTeachPlanTypeId;
}
else if (conTeachPlanType.TeachPlanTypeName  ==  AttributeName[intIndex])
{
return mstrTeachPlanTypeName;
}
else if (conTeachPlanType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachPlanType.IdTeachPlanType  ==  AttributeName[intIndex])
{
mstrIdTeachPlanType = value.ToString();
 AddUpdatedFld(conTeachPlanType.IdTeachPlanType);
}
else if (conTeachPlanType.TeachPlanTypeId  ==  AttributeName[intIndex])
{
mstrTeachPlanTypeId = value.ToString();
 AddUpdatedFld(conTeachPlanType.TeachPlanTypeId);
}
else if (conTeachPlanType.TeachPlanTypeName  ==  AttributeName[intIndex])
{
mstrTeachPlanTypeName = value.ToString();
 AddUpdatedFld(conTeachPlanType.TeachPlanTypeName);
}
else if (conTeachPlanType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachPlanType.Memo);
}
}
}

/// <summary>
/// 教案类型流水号(说明:;字段类型:char;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachPlanType
{
get
{
return mstrIdTeachPlanType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachPlanType = value;
}
else
{
 mstrIdTeachPlanType = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachPlanType.IdTeachPlanType);
}
}
/// <summary>
/// 教案类型Id(说明:;字段类型:char;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachPlanTypeId
{
get
{
return mstrTeachPlanTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachPlanTypeId = value;
}
else
{
 mstrTeachPlanTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachPlanType.TeachPlanTypeId);
}
}
/// <summary>
/// 教案类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachPlanTypeName
{
get
{
return mstrTeachPlanTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachPlanTypeName = value;
}
else
{
 mstrTeachPlanTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachPlanType.TeachPlanTypeName);
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
 AddUpdatedFld(conTeachPlanType.Memo);
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
  return mstrIdTeachPlanType;
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
  return mstrTeachPlanTypeName;
 }
 }
}
 /// <summary>
 /// 教案类型(TeachPlanType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachPlanType
{
public const string _CurrTabName = "TeachPlanType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachPlanType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachPlanType", "TeachPlanTypeId", "TeachPlanTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachPlanType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachPlanType = "IdTeachPlanType";    //教案类型流水号

 /// <summary>
 /// 常量:"TeachPlanTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachPlanTypeId = "TeachPlanTypeId";    //教案类型Id

 /// <summary>
 /// 常量:"TeachPlanTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachPlanTypeName = "TeachPlanTypeName";    //教案类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}