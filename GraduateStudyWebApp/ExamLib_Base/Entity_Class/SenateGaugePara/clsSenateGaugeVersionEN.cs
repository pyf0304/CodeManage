
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeVersionEN
 表名:SenateGaugeVersion(01120297)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// 表SenateGaugeVersion的关键字(IdSenateGaugeVersion)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSenateGaugeVersion_SenateGaugeVersion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSenateGaugeVersion">表关键字</param>
public K_IdSenateGaugeVersion_SenateGaugeVersion(string strIdSenateGaugeVersion)
{
if (IsValid(strIdSenateGaugeVersion)) Value = strIdSenateGaugeVersion;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true) return false;
if (strIdSenateGaugeVersion.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSenateGaugeVersion_SenateGaugeVersion]类型的对象</returns>
public static implicit operator K_IdSenateGaugeVersion_SenateGaugeVersion(string value)
{
return new K_IdSenateGaugeVersion_SenateGaugeVersion(value);
}
}
 /// <summary>
 /// 评价量规版本(SenateGaugeVersion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSenateGaugeVersionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SenateGaugeVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSenateGaugeVersion"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IsUse", "VersionNo", "IdSkillType", "UserTypeId", "UpdDate", "UpdUserId", "senateGaugeVersionMemo"};

protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected bool mbolIsUse;    //是否使用
protected int? mintVersionNo;    //版本号
protected string mstrIdSkillType;    //技能类型流水号
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrsenateGaugeVersionMemo;    //评价量表版本说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSenateGaugeVersionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSenateGaugeVersion");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSenateGaugeVersion">关键字:评价量表版本流水号</param>
public clsSenateGaugeVersionEN(string strIdSenateGaugeVersion)
 {
strIdSenateGaugeVersion = strIdSenateGaugeVersion.Replace("'", "''");
if (strIdSenateGaugeVersion.Length > 4)
{
throw new Exception("在表:SenateGaugeVersion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSenateGaugeVersion)  ==  true)
{
throw new Exception("在表:SenateGaugeVersion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeVersion);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSenateGaugeVersion = strIdSenateGaugeVersion;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSenateGaugeVersion");
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
if (strAttributeName  ==  conSenateGaugeVersion.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conSenateGaugeVersion.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  conSenateGaugeVersion.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  conSenateGaugeVersion.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  conSenateGaugeVersion.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  conSenateGaugeVersion.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  conSenateGaugeVersion.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  conSenateGaugeVersion.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conSenateGaugeVersion.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSenateGaugeVersion.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSenateGaugeVersion.senateGaugeVersionMemo)
{
return mstrsenateGaugeVersionMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSenateGaugeVersion.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conSenateGaugeVersion.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionID);
}
else if (strAttributeName  ==  conSenateGaugeVersion.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionName);
}
else if (strAttributeName  ==  conSenateGaugeVersion.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  conSenateGaugeVersion.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conSenateGaugeVersion.IsUse);
}
else if (strAttributeName  ==  conSenateGaugeVersion.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conSenateGaugeVersion.VersionNo);
}
else if (strAttributeName  ==  conSenateGaugeVersion.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.IdSkillType);
}
else if (strAttributeName  ==  conSenateGaugeVersion.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.UserTypeId);
}
else if (strAttributeName  ==  conSenateGaugeVersion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.UpdDate);
}
else if (strAttributeName  ==  conSenateGaugeVersion.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.UpdUserId);
}
else if (strAttributeName  ==  conSenateGaugeVersion.senateGaugeVersionMemo)
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionMemo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSenateGaugeVersion.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conSenateGaugeVersion.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (conSenateGaugeVersion.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (conSenateGaugeVersion.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (conSenateGaugeVersion.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (conSenateGaugeVersion.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (conSenateGaugeVersion.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (conSenateGaugeVersion.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conSenateGaugeVersion.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSenateGaugeVersion.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSenateGaugeVersion.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionMemo;
}
return null;
}
set
{
if (conSenateGaugeVersion.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.IdSenateGaugeVersion);
}
else if (conSenateGaugeVersion.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionID);
}
else if (conSenateGaugeVersion.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionName);
}
else if (conSenateGaugeVersion.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionTtlScore);
}
else if (conSenateGaugeVersion.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conSenateGaugeVersion.IsUse);
}
else if (conSenateGaugeVersion.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conSenateGaugeVersion.VersionNo);
}
else if (conSenateGaugeVersion.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.IdSkillType);
}
else if (conSenateGaugeVersion.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.UserTypeId);
}
else if (conSenateGaugeVersion.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.UpdDate);
}
else if (conSenateGaugeVersion.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.UpdUserId);
}
else if (conSenateGaugeVersion.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionMemo);
}
}
}

/// <summary>
/// 评价量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeVersion
{
get
{
return mstrIdSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeVersion = value;
}
else
{
 mstrIdSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeVersion.IdSenateGaugeVersion);
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
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionID);
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
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(conSenateGaugeVersion.IsUse);
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
 AddUpdatedFld(conSenateGaugeVersion.VersionNo);
}
}
/// <summary>
/// 技能类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSkillType
{
get
{
return mstrIdSkillType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSkillType = value;
}
else
{
 mstrIdSkillType = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeVersion.IdSkillType);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeVersion.UserTypeId);
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
 AddUpdatedFld(conSenateGaugeVersion.UpdDate);
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
 AddUpdatedFld(conSenateGaugeVersion.UpdUserId);
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
 AddUpdatedFld(conSenateGaugeVersion.senateGaugeVersionMemo);
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
  return mstrIdSenateGaugeVersion;
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
 /// 评价量规版本(SenateGaugeVersion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSenateGaugeVersion
{
public const string _CurrTabName = "SenateGaugeVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSenateGaugeVersion"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IsUse", "VersionNo", "IdSkillType", "UserTypeId", "UpdDate", "UpdUserId", "senateGaugeVersionMemo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

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
 /// 常量:"IdSkillType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSkillType = "IdSkillType";    //技能类型流水号

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

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
 /// 常量:"senateGaugeVersionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionMemo = "senateGaugeVersionMemo";    //评价量表版本说明
}

}