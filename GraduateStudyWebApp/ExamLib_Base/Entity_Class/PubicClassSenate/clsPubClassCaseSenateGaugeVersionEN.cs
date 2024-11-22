
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseSenateGaugeVersionEN
 表名:PubClassCaseSenateGaugeVersion(01120504)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:22
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
 /// 表PubClassCaseSenateGaugeVersion的关键字(IdPubClassCaseSenateGaugeVersion)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseSenateGaugeVersion_PubClassCaseSenateGaugeVersion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPubClassCaseSenateGaugeVersion">表关键字</param>
public K_IdPubClassCaseSenateGaugeVersion_PubClassCaseSenateGaugeVersion(string strIdPubClassCaseSenateGaugeVersion)
{
if (IsValid(strIdPubClassCaseSenateGaugeVersion)) Value = strIdPubClassCaseSenateGaugeVersion;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true) return false;
if (strIdPubClassCaseSenateGaugeVersion.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseSenateGaugeVersion_PubClassCaseSenateGaugeVersion]类型的对象</returns>
public static implicit operator K_IdPubClassCaseSenateGaugeVersion_PubClassCaseSenateGaugeVersion(string value)
{
return new K_IdPubClassCaseSenateGaugeVersion_PubClassCaseSenateGaugeVersion(value);
}
}
 /// <summary>
 /// 公开课评价量规版本(PubClassCaseSenateGaugeVersion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubClassCaseSenateGaugeVersionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubClassCaseSenateGaugeVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseSenateGaugeVersion"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdPubClassCaseSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IsUse", "VersionNo", "senateGaugeVersionMemo"};

protected string mstrIdPubClassCaseSenateGaugeVersion;    //公开课量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected bool mbolIsUse;    //是否使用
protected int? mintVersionNo;    //版本号
protected string mstrsenateGaugeVersionMemo;    //评价量表版本说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubClassCaseSenateGaugeVersionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseSenateGaugeVersion");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPubClassCaseSenateGaugeVersion">关键字:公开课量表版本流水号</param>
public clsPubClassCaseSenateGaugeVersionEN(string strIdPubClassCaseSenateGaugeVersion)
 {
strIdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion.Replace("'", "''");
if (strIdPubClassCaseSenateGaugeVersion.Length > 4)
{
throw new Exception("在表:PubClassCaseSenateGaugeVersion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion)  ==  true)
{
throw new Exception("在表:PubClassCaseSenateGaugeVersion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubClassCaseSenateGaugeVersion);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseSenateGaugeVersion");
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
if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion)
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo)
{
return mstrsenateGaugeVersionMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion)
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.IsUse);
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.VersionNo);
}
else if (strAttributeName  ==  conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo)
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (conPubClassCaseSenateGaugeVersion.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (conPubClassCaseSenateGaugeVersion.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (conPubClassCaseSenateGaugeVersion.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (conPubClassCaseSenateGaugeVersion.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionMemo;
}
return null;
}
set
{
if (conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
else if (conPubClassCaseSenateGaugeVersion.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
else if (conPubClassCaseSenateGaugeVersion.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
}
else if (conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
}
else if (conPubClassCaseSenateGaugeVersion.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.IsUse);
}
else if (conPubClassCaseSenateGaugeVersion.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.VersionNo);
}
else if (conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
}
}
}

/// <summary>
/// 公开课量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCaseSenateGaugeVersion
{
get
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCaseSenateGaugeVersion = value;
}
else
{
 mstrIdPubClassCaseSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
}
/// <summary>
/// 评价量表版本ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionID
{
get
{
return mstrsenateGaugeVersionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionID = value;
}
else
{
 mstrsenateGaugeVersionID = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
}
/// <summary>
/// 评价量表版本名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionName
{
get
{
return mstrsenateGaugeVersionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionName = value;
}
else
{
 mstrsenateGaugeVersionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.IsUse);
}
}
/// <summary>
/// 版本号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionNo
{
get
{
return mintVersionNo;
}
set
{
 mintVersionNo = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.VersionNo);
}
}
/// <summary>
/// 评价量表版本说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionMemo
{
get
{
return mstrsenateGaugeVersionMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionMemo = value;
}
else
{
 mstrsenateGaugeVersionMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
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
  return mstrIdPubClassCaseSenateGaugeVersion;
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
  return mstrsenateGaugeVersionName;
 }
 }
}
 /// <summary>
 /// 公开课评价量规版本(PubClassCaseSenateGaugeVersion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubClassCaseSenateGaugeVersion
{
public const string _CurrTabName = "PubClassCaseSenateGaugeVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseSenateGaugeVersion"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IsUse", "VersionNo", "senateGaugeVersionMemo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenateGaugeVersion = "IdPubClassCaseSenateGaugeVersion";    //公开课量表版本流水号

 /// <summary>
 /// 常量:"senateGaugeVersionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionID = "senateGaugeVersionID";    //评价量表版本ID

 /// <summary>
 /// 常量:"senateGaugeVersionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionName = "senateGaugeVersionName";    //评价量表版本名称

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

 /// <summary>
 /// 常量:"VersionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNo = "VersionNo";    //版本号

 /// <summary>
 /// 常量:"senateGaugeVersionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionMemo = "senateGaugeVersionMemo";    //评价量表版本说明
}

}