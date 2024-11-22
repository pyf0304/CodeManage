
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseSenateGaugeVersionEN
 表名:vPubClassCaseSenateGaugeVersion(01120505)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表vPubClassCaseSenateGaugeVersion的关键字(IdPubClassCaseSenateGaugeVersion)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseSenateGaugeVersion_vPubClassCaseSenateGaugeVersion
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
public K_IdPubClassCaseSenateGaugeVersion_vPubClassCaseSenateGaugeVersion(string strIdPubClassCaseSenateGaugeVersion)
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
 /// <returns>返回:[K_IdPubClassCaseSenateGaugeVersion_vPubClassCaseSenateGaugeVersion]类型的对象</returns>
public static implicit operator K_IdPubClassCaseSenateGaugeVersion_vPubClassCaseSenateGaugeVersion(string value)
{
return new K_IdPubClassCaseSenateGaugeVersion_vPubClassCaseSenateGaugeVersion(value);
}
}
 /// <summary>
 /// v公开课评价量规版本(vPubClassCaseSenateGaugeVersion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPubClassCaseSenateGaugeVersionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPubClassCaseSenateGaugeVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseSenateGaugeVersion"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"IdPubClassCaseSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "VersionNo", "IsUse", "senateGaugeVersionTtlScore", "senateGaugeVersionMemo", "SenateGaugeNum"};

protected string mstrIdPubClassCaseSenateGaugeVersion;    //公开课量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected int? mintVersionNo;    //版本号
protected bool mbolIsUse;    //是否使用
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrsenateGaugeVersionMemo;    //评价量表版本说明
protected int? mintSenateGaugeNum;    //SenateGaugeNum

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPubClassCaseSenateGaugeVersionEN()
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
public clsvPubClassCaseSenateGaugeVersionEN(string strIdPubClassCaseSenateGaugeVersion)
 {
strIdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion.Replace("'", "''");
if (strIdPubClassCaseSenateGaugeVersion.Length > 4)
{
throw new Exception("在表:vPubClassCaseSenateGaugeVersion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion)  ==  true)
{
throw new Exception("在表:vPubClassCaseSenateGaugeVersion中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion)
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo)
{
return mstrsenateGaugeVersionMemo;
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.SenateGaugeNum)
{
return mintSenateGaugeNum;
}
return null;
}
set
{
if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion)
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.VersionNo);
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.IsUse);
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo)
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
}
else if (strAttributeName  ==  convPubClassCaseSenateGaugeVersion.SenateGaugeNum)
{
mintSenateGaugeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.SenateGaugeNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (convPubClassCaseSenateGaugeVersion.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convPubClassCaseSenateGaugeVersion.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convPubClassCaseSenateGaugeVersion.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convPubClassCaseSenateGaugeVersion.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionMemo;
}
else if (convPubClassCaseSenateGaugeVersion.SenateGaugeNum  ==  AttributeName[intIndex])
{
return mintSenateGaugeNum;
}
return null;
}
set
{
if (convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
else if (convPubClassCaseSenateGaugeVersion.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
else if (convPubClassCaseSenateGaugeVersion.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
}
else if (convPubClassCaseSenateGaugeVersion.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.VersionNo);
}
else if (convPubClassCaseSenateGaugeVersion.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.IsUse);
}
else if (convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
}
else if (convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
}
else if (convPubClassCaseSenateGaugeVersion.SenateGaugeNum  ==  AttributeName[intIndex])
{
mintSenateGaugeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.SenateGaugeNum);
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
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
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
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
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
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
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
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.VersionNo);
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
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.IsUse);
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
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
}
}
/// <summary>
/// SenateGaugeNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SenateGaugeNum
{
get
{
return mintSenateGaugeNum;
}
set
{
 mintSenateGaugeNum = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseSenateGaugeVersion.SenateGaugeNum);
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
 /// v公开课评价量规版本(vPubClassCaseSenateGaugeVersion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPubClassCaseSenateGaugeVersion
{
public const string _CurrTabName = "vPubClassCaseSenateGaugeVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseSenateGaugeVersion"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "VersionNo", "IsUse", "senateGaugeVersionTtlScore", "senateGaugeVersionMemo", "SenateGaugeNum"};
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
 /// 常量:"VersionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNo = "VersionNo";    //版本号

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"senateGaugeVersionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionMemo = "senateGaugeVersionMemo";    //评价量表版本说明

 /// <summary>
 /// 常量:"SenateGaugeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateGaugeNum = "SenateGaugeNum";    //SenateGaugeNum
}

}