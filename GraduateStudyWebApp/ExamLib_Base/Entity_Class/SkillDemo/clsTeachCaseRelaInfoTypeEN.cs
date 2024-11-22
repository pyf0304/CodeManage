
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCaseRelaInfoTypeEN
 表名:TeachCaseRelaInfoType(01120512)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表TeachCaseRelaInfoType的关键字(IdTeachCaseRelaInfoType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachCaseRelaInfoType_TeachCaseRelaInfoType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeachCaseRelaInfoType">表关键字</param>
public K_IdTeachCaseRelaInfoType_TeachCaseRelaInfoType(string strIdTeachCaseRelaInfoType)
{
if (IsValid(strIdTeachCaseRelaInfoType)) Value = strIdTeachCaseRelaInfoType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeachCaseRelaInfoType)
{
if (string.IsNullOrEmpty(strIdTeachCaseRelaInfoType) == true) return false;
if (strIdTeachCaseRelaInfoType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachCaseRelaInfoType_TeachCaseRelaInfoType]类型的对象</returns>
public static implicit operator K_IdTeachCaseRelaInfoType_TeachCaseRelaInfoType(string value)
{
return new K_IdTeachCaseRelaInfoType_TeachCaseRelaInfoType(value);
}
}
 /// <summary>
 /// 案例相关信息类型(TeachCaseRelaInfoType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachCaseRelaInfoTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachCaseRelaInfoType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachCaseRelaInfoType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdTeachCaseRelaInfoType", "TeachCaseRelaInfoTypeID", "TeachCaseRelaInfoTypeName"};

protected string mstrIdTeachCaseRelaInfoType;    //案例相关信息类型流水号
protected string mstrTeachCaseRelaInfoTypeID;    //案例相关信息类型ID
protected string mstrTeachCaseRelaInfoTypeName;    //案例相关信息类型名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachCaseRelaInfoTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCaseRelaInfoType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeachCaseRelaInfoType">关键字:案例相关信息类型流水号</param>
public clsTeachCaseRelaInfoTypeEN(string strIdTeachCaseRelaInfoType)
 {
strIdTeachCaseRelaInfoType = strIdTeachCaseRelaInfoType.Replace("'", "''");
if (strIdTeachCaseRelaInfoType.Length > 4)
{
throw new Exception("在表:TeachCaseRelaInfoType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachCaseRelaInfoType)  ==  true)
{
throw new Exception("在表:TeachCaseRelaInfoType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachCaseRelaInfoType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeachCaseRelaInfoType = strIdTeachCaseRelaInfoType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCaseRelaInfoType");
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
if (strAttributeName  ==  conTeachCaseRelaInfoType.IdTeachCaseRelaInfoType)
{
return mstrIdTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeID)
{
return mstrTeachCaseRelaInfoTypeID;
}
else if (strAttributeName  ==  conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeName)
{
return mstrTeachCaseRelaInfoTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachCaseRelaInfoType.IdTeachCaseRelaInfoType)
{
mstrIdTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfoType.IdTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeID)
{
mstrTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeID);
}
else if (strAttributeName  ==  conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeName)
{
mstrTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachCaseRelaInfoType.IdTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdTeachCaseRelaInfoType;
}
else if (conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
return mstrTeachCaseRelaInfoTypeID;
}
else if (conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrTeachCaseRelaInfoTypeName;
}
return null;
}
set
{
if (conTeachCaseRelaInfoType.IdTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfoType.IdTeachCaseRelaInfoType);
}
else if (conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
mstrTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeID);
}
else if (conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeName);
}
}
}

/// <summary>
/// 案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachCaseRelaInfoType
{
get
{
return mstrIdTeachCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachCaseRelaInfoType = value;
}
else
{
 mstrIdTeachCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachCaseRelaInfoType.IdTeachCaseRelaInfoType);
}
}
/// <summary>
/// 案例相关信息类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseRelaInfoTypeID
{
get
{
return mstrTeachCaseRelaInfoTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseRelaInfoTypeID = value;
}
else
{
 mstrTeachCaseRelaInfoTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeID);
}
}
/// <summary>
/// 案例相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseRelaInfoTypeName
{
get
{
return mstrTeachCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseRelaInfoTypeName = value;
}
else
{
 mstrTeachCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachCaseRelaInfoType.TeachCaseRelaInfoTypeName);
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
  return mstrIdTeachCaseRelaInfoType;
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
  return mstrTeachCaseRelaInfoTypeName;
 }
 }
}
 /// <summary>
 /// 案例相关信息类型(TeachCaseRelaInfoType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachCaseRelaInfoType
{
public const string _CurrTabName = "TeachCaseRelaInfoType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachCaseRelaInfoType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachCaseRelaInfoType", "TeachCaseRelaInfoTypeID", "TeachCaseRelaInfoTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachCaseRelaInfoType = "IdTeachCaseRelaInfoType";    //案例相关信息类型流水号

 /// <summary>
 /// 常量:"TeachCaseRelaInfoTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseRelaInfoTypeID = "TeachCaseRelaInfoTypeID";    //案例相关信息类型ID

 /// <summary>
 /// 常量:"TeachCaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseRelaInfoTypeName = "TeachCaseRelaInfoTypeName";    //案例相关信息类型名称
}

}