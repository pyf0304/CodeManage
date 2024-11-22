
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeEN
 表名:vSenateGauge(01120508)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:23
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
 /// 表vSenateGauge的关键字(IdsenateGauge)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdsenateGauge_vSenateGauge
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
public K_IdsenateGauge_vSenateGauge(string strIdsenateGauge)
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
 /// <returns>返回:[K_IdsenateGauge_vSenateGauge]类型的对象</returns>
public static implicit operator K_IdsenateGauge_vSenateGauge(string value)
{
return new K_IdsenateGauge_vSenateGauge(value);
}
}
 /// <summary>
 /// v公开课评价量规(vSenateGauge)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSenateGaugeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSenateGauge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdsenateGauge"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"IdsenateGauge", "senateGaugeID", "senateGaugeName", "senateGaugeScore", "senateGaugeMemo", "SenateGaugeWeight", "IdPubClassCaseSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "senateGaugeVersionMemo", "IsUse", "OrderNum", "UpdDate", "UpdUserId", "VersionNo", "senateGaugeNameWithOrder"};

protected string mstrIdsenateGauge;    //评价量规流水号
protected string mstrsenateGaugeID;    //评价量规ID
protected string mstrsenateGaugeName;    //评价量规名称
protected float? mfltsenateGaugeScore;    //评价量规分值
protected string mstrsenateGaugeMemo;    //评价量规指标与说明
protected float? mfltSenateGaugeWeight;    //评价量规权重
protected string mstrIdPubClassCaseSenateGaugeVersion;    //公开课量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrsenateGaugeVersionMemo;    //评价量表版本说明
protected bool mbolIsUse;    //是否使用
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected int? mintVersionNo;    //版本号
protected string mstrsenateGaugeNameWithOrder;    //senateGaugeNameWithOrder

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSenateGaugeEN()
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
public clsvSenateGaugeEN(string strIdsenateGauge)
 {
strIdsenateGauge = strIdsenateGauge.Replace("'", "''");
if (strIdsenateGauge.Length > 4)
{
throw new Exception("在表:vSenateGauge中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdsenateGauge)  ==  true)
{
throw new Exception("在表:vSenateGauge中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSenateGauge.IdsenateGauge)
{
return mstrIdsenateGauge;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeID)
{
return mstrsenateGaugeID;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeName)
{
return mstrsenateGaugeName;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeScore)
{
return mfltsenateGaugeScore;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeMemo)
{
return mstrsenateGaugeMemo;
}
else if (strAttributeName  ==  convSenateGauge.SenateGaugeWeight)
{
return mfltSenateGaugeWeight;
}
else if (strAttributeName  ==  convSenateGauge.IdPubClassCaseSenateGaugeVersion)
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeVersionMemo)
{
return mstrsenateGaugeVersionMemo;
}
else if (strAttributeName  ==  convSenateGauge.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convSenateGauge.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convSenateGauge.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSenateGauge.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convSenateGauge.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeNameWithOrder)
{
return mstrsenateGaugeNameWithOrder;
}
return null;
}
set
{
if (strAttributeName  ==  convSenateGauge.IdsenateGauge)
{
mstrIdsenateGauge = value.ToString();
 AddUpdatedFld(convSenateGauge.IdsenateGauge);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeID)
{
mstrsenateGaugeID = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeID);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeName)
{
mstrsenateGaugeName = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeName);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeScore)
{
mfltsenateGaugeScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGauge.senateGaugeScore);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeMemo)
{
mstrsenateGaugeMemo = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeMemo);
}
else if (strAttributeName  ==  convSenateGauge.SenateGaugeWeight)
{
mfltSenateGaugeWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGauge.SenateGaugeWeight);
}
else if (strAttributeName  ==  convSenateGauge.IdPubClassCaseSenateGaugeVersion)
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeVersionID);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeVersionName);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGauge.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeVersionMemo)
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeVersionMemo);
}
else if (strAttributeName  ==  convSenateGauge.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGauge.IsUse);
}
else if (strAttributeName  ==  convSenateGauge.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGauge.OrderNum);
}
else if (strAttributeName  ==  convSenateGauge.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSenateGauge.UpdDate);
}
else if (strAttributeName  ==  convSenateGauge.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSenateGauge.UpdUserId);
}
else if (strAttributeName  ==  convSenateGauge.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGauge.VersionNo);
}
else if (strAttributeName  ==  convSenateGauge.senateGaugeNameWithOrder)
{
mstrsenateGaugeNameWithOrder = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeNameWithOrder);
}
}
}
public object this[int intIndex]
{
get
{
if (convSenateGauge.IdsenateGauge  ==  AttributeName[intIndex])
{
return mstrIdsenateGauge;
}
else if (convSenateGauge.senateGaugeID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeID;
}
else if (convSenateGauge.senateGaugeName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeName;
}
else if (convSenateGauge.senateGaugeScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeScore;
}
else if (convSenateGauge.senateGaugeMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeMemo;
}
else if (convSenateGauge.SenateGaugeWeight  ==  AttributeName[intIndex])
{
return mfltSenateGaugeWeight;
}
else if (convSenateGauge.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (convSenateGauge.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convSenateGauge.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convSenateGauge.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convSenateGauge.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionMemo;
}
else if (convSenateGauge.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convSenateGauge.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convSenateGauge.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSenateGauge.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convSenateGauge.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convSenateGauge.senateGaugeNameWithOrder  ==  AttributeName[intIndex])
{
return mstrsenateGaugeNameWithOrder;
}
return null;
}
set
{
if (convSenateGauge.IdsenateGauge  ==  AttributeName[intIndex])
{
mstrIdsenateGauge = value.ToString();
 AddUpdatedFld(convSenateGauge.IdsenateGauge);
}
else if (convSenateGauge.senateGaugeID  ==  AttributeName[intIndex])
{
mstrsenateGaugeID = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeID);
}
else if (convSenateGauge.senateGaugeName  ==  AttributeName[intIndex])
{
mstrsenateGaugeName = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeName);
}
else if (convSenateGauge.senateGaugeScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGauge.senateGaugeScore);
}
else if (convSenateGauge.senateGaugeMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeMemo = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeMemo);
}
else if (convSenateGauge.SenateGaugeWeight  ==  AttributeName[intIndex])
{
mfltSenateGaugeWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGauge.SenateGaugeWeight);
}
else if (convSenateGauge.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convSenateGauge.IdPubClassCaseSenateGaugeVersion);
}
else if (convSenateGauge.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeVersionID);
}
else if (convSenateGauge.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeVersionName);
}
else if (convSenateGauge.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGauge.senateGaugeVersionTtlScore);
}
else if (convSenateGauge.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeVersionMemo);
}
else if (convSenateGauge.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGauge.IsUse);
}
else if (convSenateGauge.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGauge.OrderNum);
}
else if (convSenateGauge.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSenateGauge.UpdDate);
}
else if (convSenateGauge.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSenateGauge.UpdUserId);
}
else if (convSenateGauge.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGauge.VersionNo);
}
else if (convSenateGauge.senateGaugeNameWithOrder  ==  AttributeName[intIndex])
{
mstrsenateGaugeNameWithOrder = value.ToString();
 AddUpdatedFld(convSenateGauge.senateGaugeNameWithOrder);
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
 AddUpdatedFld(convSenateGauge.IdsenateGauge);
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
 AddUpdatedFld(convSenateGauge.senateGaugeID);
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
 AddUpdatedFld(convSenateGauge.senateGaugeName);
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
 AddUpdatedFld(convSenateGauge.senateGaugeScore);
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
 AddUpdatedFld(convSenateGauge.senateGaugeMemo);
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
 AddUpdatedFld(convSenateGauge.SenateGaugeWeight);
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
 AddUpdatedFld(convSenateGauge.IdPubClassCaseSenateGaugeVersion);
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
 AddUpdatedFld(convSenateGauge.senateGaugeVersionID);
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
 AddUpdatedFld(convSenateGauge.senateGaugeVersionName);
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
 AddUpdatedFld(convSenateGauge.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convSenateGauge.senateGaugeVersionMemo);
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
 AddUpdatedFld(convSenateGauge.IsUse);
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
 AddUpdatedFld(convSenateGauge.OrderNum);
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
 AddUpdatedFld(convSenateGauge.UpdDate);
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
 AddUpdatedFld(convSenateGauge.UpdUserId);
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
 AddUpdatedFld(convSenateGauge.VersionNo);
}
}
/// <summary>
/// senateGaugeNameWithOrder(说明:;字段类型:varchar;字段长度:204;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeNameWithOrder
{
get
{
return mstrsenateGaugeNameWithOrder;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeNameWithOrder = value;
}
else
{
 mstrsenateGaugeNameWithOrder = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGauge.senateGaugeNameWithOrder);
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
 /// v公开课评价量规(vSenateGauge)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSenateGauge
{
public const string _CurrTabName = "vSenateGauge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdsenateGauge"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdsenateGauge", "senateGaugeID", "senateGaugeName", "senateGaugeScore", "senateGaugeMemo", "SenateGaugeWeight", "IdPubClassCaseSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "senateGaugeVersionMemo", "IsUse", "OrderNum", "UpdDate", "UpdUserId", "VersionNo", "senateGaugeNameWithOrder"};
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
 /// 常量:"senateGaugeMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeMemo = "senateGaugeMemo";    //评价量规指标与说明

 /// <summary>
 /// 常量:"SenateGaugeWeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateGaugeWeight = "SenateGaugeWeight";    //评价量规权重

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
 /// 常量:"senateGaugeVersionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionMemo = "senateGaugeVersionMemo";    //评价量表版本说明

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

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

 /// <summary>
 /// 常量:"VersionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNo = "VersionNo";    //版本号

 /// <summary>
 /// 常量:"senateGaugeNameWithOrder"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeNameWithOrder = "senateGaugeNameWithOrder";    //senateGaugeNameWithOrder
}

}