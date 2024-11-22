
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubTeachCaseRelaInfoTypeEN
 表名:PubTeachCaseRelaInfoType(01120510)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:29
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
 /// 表PubTeachCaseRelaInfoType的关键字(IdPubTeachCaseRelaInfoType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubTeachCaseRelaInfoType_PubTeachCaseRelaInfoType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPubTeachCaseRelaInfoType">表关键字</param>
public K_IdPubTeachCaseRelaInfoType_PubTeachCaseRelaInfoType(string strIdPubTeachCaseRelaInfoType)
{
if (IsValid(strIdPubTeachCaseRelaInfoType)) Value = strIdPubTeachCaseRelaInfoType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPubTeachCaseRelaInfoType)
{
if (string.IsNullOrEmpty(strIdPubTeachCaseRelaInfoType) == true) return false;
if (strIdPubTeachCaseRelaInfoType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubTeachCaseRelaInfoType_PubTeachCaseRelaInfoType]类型的对象</returns>
public static implicit operator K_IdPubTeachCaseRelaInfoType_PubTeachCaseRelaInfoType(string value)
{
return new K_IdPubTeachCaseRelaInfoType_PubTeachCaseRelaInfoType(value);
}
}
 /// <summary>
 /// 公开课案例相关信息类型(PubTeachCaseRelaInfoType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubTeachCaseRelaInfoTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubTeachCaseRelaInfoType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubTeachCaseRelaInfoType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdPubTeachCaseRelaInfoType", "PubTeachCaseRelaInfoTypeID", "PubTeachCaseRelaInfoTypeName"};

protected string mstrIdPubTeachCaseRelaInfoType;    //公开课案例相关信息类型流水号
protected string mstrPubTeachCaseRelaInfoTypeID;    //公开课案例相关信息类型ID
protected string mstrPubTeachCaseRelaInfoTypeName;    //公开课案例相关信息类型名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubTeachCaseRelaInfoTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubTeachCaseRelaInfoType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPubTeachCaseRelaInfoType">关键字:公开课案例相关信息类型流水号</param>
public clsPubTeachCaseRelaInfoTypeEN(string strIdPubTeachCaseRelaInfoType)
 {
strIdPubTeachCaseRelaInfoType = strIdPubTeachCaseRelaInfoType.Replace("'", "''");
if (strIdPubTeachCaseRelaInfoType.Length > 4)
{
throw new Exception("在表:PubTeachCaseRelaInfoType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPubTeachCaseRelaInfoType)  ==  true)
{
throw new Exception("在表:PubTeachCaseRelaInfoType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubTeachCaseRelaInfoType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPubTeachCaseRelaInfoType = strIdPubTeachCaseRelaInfoType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubTeachCaseRelaInfoType");
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
if (strAttributeName  ==  conPubTeachCaseRelaInfoType.IdPubTeachCaseRelaInfoType)
{
return mstrIdPubTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeID)
{
return mstrPubTeachCaseRelaInfoTypeID;
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeName)
{
return mstrPubTeachCaseRelaInfoTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  conPubTeachCaseRelaInfoType.IdPubTeachCaseRelaInfoType)
{
mstrIdPubTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfoType.IdPubTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeID)
{
mstrPubTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeID);
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeName)
{
mstrPubTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubTeachCaseRelaInfoType.IdPubTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdPubTeachCaseRelaInfoType;
}
else if (conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
return mstrPubTeachCaseRelaInfoTypeID;
}
else if (conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrPubTeachCaseRelaInfoTypeName;
}
return null;
}
set
{
if (conPubTeachCaseRelaInfoType.IdPubTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdPubTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfoType.IdPubTeachCaseRelaInfoType);
}
else if (conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
mstrPubTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeID);
}
else if (conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrPubTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeName);
}
}
}

/// <summary>
/// 公开课案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubTeachCaseRelaInfoType
{
get
{
return mstrIdPubTeachCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubTeachCaseRelaInfoType = value;
}
else
{
 mstrIdPubTeachCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubTeachCaseRelaInfoType.IdPubTeachCaseRelaInfoType);
}
}
/// <summary>
/// 公开课案例相关信息类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubTeachCaseRelaInfoTypeID
{
get
{
return mstrPubTeachCaseRelaInfoTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubTeachCaseRelaInfoTypeID = value;
}
else
{
 mstrPubTeachCaseRelaInfoTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeID);
}
}
/// <summary>
/// 公开课案例相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubTeachCaseRelaInfoTypeName
{
get
{
return mstrPubTeachCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubTeachCaseRelaInfoTypeName = value;
}
else
{
 mstrPubTeachCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubTeachCaseRelaInfoType.PubTeachCaseRelaInfoTypeName);
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
  return mstrIdPubTeachCaseRelaInfoType;
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
  return mstrPubTeachCaseRelaInfoTypeName;
 }
 }
}
 /// <summary>
 /// 公开课案例相关信息类型(PubTeachCaseRelaInfoType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubTeachCaseRelaInfoType
{
public const string _CurrTabName = "PubTeachCaseRelaInfoType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubTeachCaseRelaInfoType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubTeachCaseRelaInfoType", "PubTeachCaseRelaInfoTypeID", "PubTeachCaseRelaInfoTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubTeachCaseRelaInfoType = "IdPubTeachCaseRelaInfoType";    //公开课案例相关信息类型流水号

 /// <summary>
 /// 常量:"PubTeachCaseRelaInfoTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubTeachCaseRelaInfoTypeID = "PubTeachCaseRelaInfoTypeID";    //公开课案例相关信息类型ID

 /// <summary>
 /// 常量:"PubTeachCaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubTeachCaseRelaInfoTypeName = "PubTeachCaseRelaInfoTypeName";    //公开课案例相关信息类型名称
}

}