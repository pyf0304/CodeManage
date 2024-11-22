
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseSiteSenateTypeEN
 表名:MicroteachCaseSiteSenateType(01120502)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表MicroteachCaseSiteSenateType的关键字(IdMicroteachCaseSiteSenateType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseSiteSenateType_MicroteachCaseSiteSenateType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMicroteachCaseSiteSenateType">表关键字</param>
public K_IdMicroteachCaseSiteSenateType_MicroteachCaseSiteSenateType(string strIdMicroteachCaseSiteSenateType)
{
if (IsValid(strIdMicroteachCaseSiteSenateType)) Value = strIdMicroteachCaseSiteSenateType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMicroteachCaseSiteSenateType)
{
if (string.IsNullOrEmpty(strIdMicroteachCaseSiteSenateType) == true) return false;
if (strIdMicroteachCaseSiteSenateType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachCaseSiteSenateType_MicroteachCaseSiteSenateType]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseSiteSenateType_MicroteachCaseSiteSenateType(string value)
{
return new K_IdMicroteachCaseSiteSenateType_MicroteachCaseSiteSenateType(value);
}
}
 /// <summary>
 /// 微格现场评价类型(MicroteachCaseSiteSenateType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMicroteachCaseSiteSenateTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MicroteachCaseSiteSenateType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseSiteSenateType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdMicroteachCaseSiteSenateType", "MicroteachCaseSiteSenateTypeID", "MicroteachCaseSiteSenateTypeName"};

protected string mstrIdMicroteachCaseSiteSenateType;    //微格现场评价类型流水号
protected string mstrMicroteachCaseSiteSenateTypeID;    //微格现场评价类型ID
protected string mstrMicroteachCaseSiteSenateTypeName;    //微格现场评价类型名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMicroteachCaseSiteSenateTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseSiteSenateType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMicroteachCaseSiteSenateType">关键字:微格现场评价类型流水号</param>
public clsMicroteachCaseSiteSenateTypeEN(string strIdMicroteachCaseSiteSenateType)
 {
strIdMicroteachCaseSiteSenateType = strIdMicroteachCaseSiteSenateType.Replace("'", "''");
if (strIdMicroteachCaseSiteSenateType.Length > 4)
{
throw new Exception("在表:MicroteachCaseSiteSenateType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMicroteachCaseSiteSenateType)  ==  true)
{
throw new Exception("在表:MicroteachCaseSiteSenateType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroteachCaseSiteSenateType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMicroteachCaseSiteSenateType = strIdMicroteachCaseSiteSenateType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseSiteSenateType");
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
if (strAttributeName  ==  conMicroteachCaseSiteSenateType.IdMicroteachCaseSiteSenateType)
{
return mstrIdMicroteachCaseSiteSenateType;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID)
{
return mstrMicroteachCaseSiteSenateTypeID;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName)
{
return mstrMicroteachCaseSiteSenateTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  conMicroteachCaseSiteSenateType.IdMicroteachCaseSiteSenateType)
{
mstrIdMicroteachCaseSiteSenateType = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenateType.IdMicroteachCaseSiteSenateType);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID)
{
mstrMicroteachCaseSiteSenateTypeID = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName)
{
mstrMicroteachCaseSiteSenateTypeName = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (conMicroteachCaseSiteSenateType.IdMicroteachCaseSiteSenateType  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCaseSiteSenateType;
}
else if (conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseSiteSenateTypeID;
}
else if (conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseSiteSenateTypeName;
}
return null;
}
set
{
if (conMicroteachCaseSiteSenateType.IdMicroteachCaseSiteSenateType  ==  AttributeName[intIndex])
{
mstrIdMicroteachCaseSiteSenateType = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenateType.IdMicroteachCaseSiteSenateType);
}
else if (conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseSiteSenateTypeID = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID);
}
else if (conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseSiteSenateTypeName = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName);
}
}
}

/// <summary>
/// 微格现场评价类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCaseSiteSenateType
{
get
{
return mstrIdMicroteachCaseSiteSenateType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCaseSiteSenateType = value;
}
else
{
 mstrIdMicroteachCaseSiteSenateType = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenateType.IdMicroteachCaseSiteSenateType);
}
}
/// <summary>
/// 微格现场评价类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseSiteSenateTypeID
{
get
{
return mstrMicroteachCaseSiteSenateTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseSiteSenateTypeID = value;
}
else
{
 mstrMicroteachCaseSiteSenateTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeID);
}
}
/// <summary>
/// 微格现场评价类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseSiteSenateTypeName
{
get
{
return mstrMicroteachCaseSiteSenateTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseSiteSenateTypeName = value;
}
else
{
 mstrMicroteachCaseSiteSenateTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenateType.MicroteachCaseSiteSenateTypeName);
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
  return mstrIdMicroteachCaseSiteSenateType;
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
  return mstrMicroteachCaseSiteSenateTypeName;
 }
 }
}
 /// <summary>
 /// 微格现场评价类型(MicroteachCaseSiteSenateType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMicroteachCaseSiteSenateType
{
public const string _CurrTabName = "MicroteachCaseSiteSenateType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseSiteSenateType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseSiteSenateType", "MicroteachCaseSiteSenateTypeID", "MicroteachCaseSiteSenateTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCaseSiteSenateType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseSiteSenateType = "IdMicroteachCaseSiteSenateType";    //微格现场评价类型流水号

 /// <summary>
 /// 常量:"MicroteachCaseSiteSenateTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseSiteSenateTypeID = "MicroteachCaseSiteSenateTypeID";    //微格现场评价类型ID

 /// <summary>
 /// 常量:"MicroteachCaseSiteSenateTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseSiteSenateTypeName = "MicroteachCaseSiteSenateTypeName";    //微格现场评价类型名称
}

}