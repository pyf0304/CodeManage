
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeEN
 表名:SenateGauge(01120529)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:37
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
 /// 表SenateGauge的关键字(IdsenateGauge)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdsenateGauge_SenateGauge
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdsenateGauge">表关键字</param>
public K_IdsenateGauge_SenateGauge(string strIdsenateGauge)
{
if (IsValid(strIdsenateGauge)) Value = strIdsenateGauge;
else
{
Value = null;
}
}
private static bool IsValid(string strIdsenateGauge)
{
if (string.IsNullOrEmpty(strIdsenateGauge) == true) return false;
if (strIdsenateGauge.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdsenateGauge_SenateGauge]类型的对象</returns>
public static implicit operator K_IdsenateGauge_SenateGauge(string value)
{
return new K_IdsenateGauge_SenateGauge(value);
}
}
 /// <summary>
 /// 评价量规(SenateGauge)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSenateGaugeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SenateGauge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdsenateGauge"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"IdsenateGauge", "senateGaugeID", "senateGaugeName", "senateGaugeScore", "SenateGaugeWeight", "senateGaugeMemo", "IdPubClassCaseSenateGaugeVersion", "OrderNum", "UpdDate", "UpdUserId"};

protected string mstrIdsenateGauge;    //评价量规流水号
protected string mstrsenateGaugeID;    //评价量规ID
protected string mstrsenateGaugeName;    //评价量规名称
protected float? mfltsenateGaugeScore;    //评价量规分值
protected float? mfltSenateGaugeWeight;    //评价量规权重
protected string mstrsenateGaugeMemo;    //评价量规指标与说明
protected string mstrIdPubClassCaseSenateGaugeVersion;    //公开课量表版本流水号
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSenateGaugeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdsenateGauge");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdsenateGauge">关键字:评价量规流水号</param>
public clsSenateGaugeEN(string strIdsenateGauge)
 {
strIdsenateGauge = strIdsenateGauge.Replace("'", "''");
if (strIdsenateGauge.Length > 4)
{
throw new Exception("在表:SenateGauge中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdsenateGauge)  ==  true)
{
throw new Exception("在表:SenateGauge中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdsenateGauge);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdsenateGauge = strIdsenateGauge;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdsenateGauge");
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
if (strAttributeName  ==  conSenateGauge.IdsenateGauge)
{
return mstrIdsenateGauge;
}
else if (strAttributeName  ==  conSenateGauge.senateGaugeID)
{
return mstrsenateGaugeID;
}
else if (strAttributeName  ==  conSenateGauge.senateGaugeName)
{
return mstrsenateGaugeName;
}
else if (strAttributeName  ==  conSenateGauge.senateGaugeScore)
{
return mfltsenateGaugeScore;
}
else if (strAttributeName  ==  conSenateGauge.SenateGaugeWeight)
{
return mfltSenateGaugeWeight;
}
else if (strAttributeName  ==  conSenateGauge.senateGaugeMemo)
{
return mstrsenateGaugeMemo;
}
else if (strAttributeName  ==  conSenateGauge.IdPubClassCaseSenateGaugeVersion)
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (strAttributeName  ==  conSenateGauge.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conSenateGauge.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSenateGauge.UpdUserId)
{
return mstrUpdUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conSenateGauge.IdsenateGauge)
{
mstrIdsenateGauge = value.ToString();
 AddUpdatedFld(conSenateGauge.IdsenateGauge);
}
else if (strAttributeName  ==  conSenateGauge.senateGaugeID)
{
mstrsenateGaugeID = value.ToString();
 AddUpdatedFld(conSenateGauge.senateGaugeID);
}
else if (strAttributeName  ==  conSenateGauge.senateGaugeName)
{
mstrsenateGaugeName = value.ToString();
 AddUpdatedFld(conSenateGauge.senateGaugeName);
}
else if (strAttributeName  ==  conSenateGauge.senateGaugeScore)
{
mfltsenateGaugeScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGauge.senateGaugeScore);
}
else if (strAttributeName  ==  conSenateGauge.SenateGaugeWeight)
{
mfltSenateGaugeWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGauge.SenateGaugeWeight);
}
else if (strAttributeName  ==  conSenateGauge.senateGaugeMemo)
{
mstrsenateGaugeMemo = value.ToString();
 AddUpdatedFld(conSenateGauge.senateGaugeMemo);
}
else if (strAttributeName  ==  conSenateGauge.IdPubClassCaseSenateGaugeVersion)
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
else if (strAttributeName  ==  conSenateGauge.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSenateGauge.OrderNum);
}
else if (strAttributeName  ==  conSenateGauge.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSenateGauge.UpdDate);
}
else if (strAttributeName  ==  conSenateGauge.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSenateGauge.UpdUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conSenateGauge.IdsenateGauge  ==  AttributeName[intIndex])
{
return mstrIdsenateGauge;
}
else if (conSenateGauge.senateGaugeID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeID;
}
else if (conSenateGauge.senateGaugeName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeName;
}
else if (conSenateGauge.senateGaugeScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeScore;
}
else if (conSenateGauge.SenateGaugeWeight  ==  AttributeName[intIndex])
{
return mfltSenateGaugeWeight;
}
else if (conSenateGauge.senateGaugeMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeMemo;
}
else if (conSenateGauge.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (conSenateGauge.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conSenateGauge.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSenateGauge.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
return null;
}
set
{
if (conSenateGauge.IdsenateGauge  ==  AttributeName[intIndex])
{
mstrIdsenateGauge = value.ToString();
 AddUpdatedFld(conSenateGauge.IdsenateGauge);
}
else if (conSenateGauge.senateGaugeID  ==  AttributeName[intIndex])
{
mstrsenateGaugeID = value.ToString();
 AddUpdatedFld(conSenateGauge.senateGaugeID);
}
else if (conSenateGauge.senateGaugeName  ==  AttributeName[intIndex])
{
mstrsenateGaugeName = value.ToString();
 AddUpdatedFld(conSenateGauge.senateGaugeName);
}
else if (conSenateGauge.senateGaugeScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGauge.senateGaugeScore);
}
else if (conSenateGauge.SenateGaugeWeight  ==  AttributeName[intIndex])
{
mfltSenateGaugeWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGauge.SenateGaugeWeight);
}
else if (conSenateGauge.senateGaugeMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeMemo = value.ToString();
 AddUpdatedFld(conSenateGauge.senateGaugeMemo);
}
else if (conSenateGauge.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
else if (conSenateGauge.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSenateGauge.OrderNum);
}
else if (conSenateGauge.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSenateGauge.UpdDate);
}
else if (conSenateGauge.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSenateGauge.UpdUserId);
}
}
}

/// <summary>
/// 评价量规流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdsenateGauge
{
get
{
return mstrIdsenateGauge;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdsenateGauge = value;
}
else
{
 mstrIdsenateGauge = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGauge.IdsenateGauge);
}
}
/// <summary>
/// 评价量规ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeID
{
get
{
return mstrsenateGaugeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeID = value;
}
else
{
 mstrsenateGaugeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGauge.senateGaugeID);
}
}
/// <summary>
/// 评价量规名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeName
{
get
{
return mstrsenateGaugeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeName = value;
}
else
{
 mstrsenateGaugeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGauge.senateGaugeName);
}
}
/// <summary>
/// 评价量规分值(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeScore
{
get
{
return mfltsenateGaugeScore;
}
set
{
 mfltsenateGaugeScore = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGauge.senateGaugeScore);
}
}
/// <summary>
/// 评价量规权重(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? SenateGaugeWeight
{
get
{
return mfltSenateGaugeWeight;
}
set
{
 mfltSenateGaugeWeight = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGauge.SenateGaugeWeight);
}
}
/// <summary>
/// 评价量规指标与说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeMemo
{
get
{
return mstrsenateGaugeMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeMemo = value;
}
else
{
 mstrsenateGaugeMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGauge.senateGaugeMemo);
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
 AddUpdatedFld(conSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGauge.OrderNum);
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
 AddUpdatedFld(conSenateGauge.UpdDate);
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
 AddUpdatedFld(conSenateGauge.UpdUserId);
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
  return mstrIdsenateGauge;
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
  return mstrsenateGaugeName;
 }
 }
}
 /// <summary>
 /// 评价量规(SenateGauge)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSenateGauge
{
public const string _CurrTabName = "SenateGauge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdsenateGauge"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdsenateGauge", "senateGaugeID", "senateGaugeName", "senateGaugeScore", "SenateGaugeWeight", "senateGaugeMemo", "IdPubClassCaseSenateGaugeVersion", "OrderNum", "UpdDate", "UpdUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdsenateGauge"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdsenateGauge = "IdsenateGauge";    //评价量规流水号

 /// <summary>
 /// 常量:"senateGaugeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeID = "senateGaugeID";    //评价量规ID

 /// <summary>
 /// 常量:"senateGaugeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeName = "senateGaugeName";    //评价量规名称

 /// <summary>
 /// 常量:"senateGaugeScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeScore = "senateGaugeScore";    //评价量规分值

 /// <summary>
 /// 常量:"SenateGaugeWeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateGaugeWeight = "SenateGaugeWeight";    //评价量规权重

 /// <summary>
 /// 常量:"senateGaugeMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeMemo = "senateGaugeMemo";    //评价量规指标与说明

 /// <summary>
 /// 常量:"IdPubClassCaseSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenateGaugeVersion = "IdPubClassCaseSenateGaugeVersion";    //公开课量表版本流水号

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
}

}