
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeVersionEN
 表名:vSenateGaugeVersion(01120480)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// 表vSenateGaugeVersion的关键字(IdSenateGaugeVersion)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSenateGaugeVersion_vSenateGaugeVersion
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
public K_IdSenateGaugeVersion_vSenateGaugeVersion(string strIdSenateGaugeVersion)
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
 /// <returns>返回:[K_IdSenateGaugeVersion_vSenateGaugeVersion]类型的对象</returns>
public static implicit operator K_IdSenateGaugeVersion_vSenateGaugeVersion(string value)
{
return new K_IdSenateGaugeVersion_vSenateGaugeVersion(value);
}
}
 /// <summary>
 /// v评价量规版本(vSenateGaugeVersion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSenateGaugeVersionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSenateGaugeVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSenateGaugeVersion"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionMemo", "senateGaugeVersionTtlScore", "SkillTypeID", "SkillTypeName", "IdSkillType", "VersionNo", "IsUse", "UserTypeId", "UserTypeName", "SenateGaugeNum", "CalaTotalScore", "UpdDate", "UpdUserId"};

protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected string mstrsenateGaugeVersionMemo;    //评价量表版本说明
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrSkillTypeID;    //技能类型ID
protected string mstrSkillTypeName;    //技能类型名称
protected string mstrIdSkillType;    //技能类型流水号
protected int? mintVersionNo;    //版本号
protected bool mbolIsUse;    //是否使用
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected int? mintSenateGaugeNum;    //SenateGaugeNum
protected float? mfltCalaTotalScore;    //CalaTotalScore
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSenateGaugeVersionEN()
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
public clsvSenateGaugeVersionEN(string strIdSenateGaugeVersion)
 {
strIdSenateGaugeVersion = strIdSenateGaugeVersion.Replace("'", "''");
if (strIdSenateGaugeVersion.Length > 4)
{
throw new Exception("在表:vSenateGaugeVersion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSenateGaugeVersion)  ==  true)
{
throw new Exception("在表:vSenateGaugeVersion中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSenateGaugeVersion.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convSenateGaugeVersion.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convSenateGaugeVersion.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convSenateGaugeVersion.senateGaugeVersionMemo)
{
return mstrsenateGaugeVersionMemo;
}
else if (strAttributeName  ==  convSenateGaugeVersion.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convSenateGaugeVersion.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convSenateGaugeVersion.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convSenateGaugeVersion.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convSenateGaugeVersion.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convSenateGaugeVersion.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convSenateGaugeVersion.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convSenateGaugeVersion.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convSenateGaugeVersion.SenateGaugeNum)
{
return mintSenateGaugeNum;
}
else if (strAttributeName  ==  convSenateGaugeVersion.CalaTotalScore)
{
return mfltCalaTotalScore;
}
else if (strAttributeName  ==  convSenateGaugeVersion.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSenateGaugeVersion.UpdUserId)
{
return mstrUpdUserId;
}
return null;
}
set
{
if (strAttributeName  ==  convSenateGaugeVersion.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convSenateGaugeVersion.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionID);
}
else if (strAttributeName  ==  convSenateGaugeVersion.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionName);
}
else if (strAttributeName  ==  convSenateGaugeVersion.senateGaugeVersionMemo)
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionMemo);
}
else if (strAttributeName  ==  convSenateGaugeVersion.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convSenateGaugeVersion.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.SkillTypeID);
}
else if (strAttributeName  ==  convSenateGaugeVersion.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.SkillTypeName);
}
else if (strAttributeName  ==  convSenateGaugeVersion.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.IdSkillType);
}
else if (strAttributeName  ==  convSenateGaugeVersion.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.VersionNo);
}
else if (strAttributeName  ==  convSenateGaugeVersion.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.IsUse);
}
else if (strAttributeName  ==  convSenateGaugeVersion.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.UserTypeId);
}
else if (strAttributeName  ==  convSenateGaugeVersion.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.UserTypeName);
}
else if (strAttributeName  ==  convSenateGaugeVersion.SenateGaugeNum)
{
mintSenateGaugeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.SenateGaugeNum);
}
else if (strAttributeName  ==  convSenateGaugeVersion.CalaTotalScore)
{
mfltCalaTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.CalaTotalScore);
}
else if (strAttributeName  ==  convSenateGaugeVersion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.UpdDate);
}
else if (strAttributeName  ==  convSenateGaugeVersion.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.UpdUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (convSenateGaugeVersion.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convSenateGaugeVersion.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convSenateGaugeVersion.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convSenateGaugeVersion.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionMemo;
}
else if (convSenateGaugeVersion.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convSenateGaugeVersion.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convSenateGaugeVersion.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convSenateGaugeVersion.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convSenateGaugeVersion.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convSenateGaugeVersion.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convSenateGaugeVersion.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convSenateGaugeVersion.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convSenateGaugeVersion.SenateGaugeNum  ==  AttributeName[intIndex])
{
return mintSenateGaugeNum;
}
else if (convSenateGaugeVersion.CalaTotalScore  ==  AttributeName[intIndex])
{
return mfltCalaTotalScore;
}
else if (convSenateGaugeVersion.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSenateGaugeVersion.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
return null;
}
set
{
if (convSenateGaugeVersion.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.IdSenateGaugeVersion);
}
else if (convSenateGaugeVersion.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionID);
}
else if (convSenateGaugeVersion.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionName);
}
else if (convSenateGaugeVersion.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionMemo);
}
else if (convSenateGaugeVersion.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionTtlScore);
}
else if (convSenateGaugeVersion.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.SkillTypeID);
}
else if (convSenateGaugeVersion.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.SkillTypeName);
}
else if (convSenateGaugeVersion.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.IdSkillType);
}
else if (convSenateGaugeVersion.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.VersionNo);
}
else if (convSenateGaugeVersion.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.IsUse);
}
else if (convSenateGaugeVersion.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.UserTypeId);
}
else if (convSenateGaugeVersion.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.UserTypeName);
}
else if (convSenateGaugeVersion.SenateGaugeNum  ==  AttributeName[intIndex])
{
mintSenateGaugeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.SenateGaugeNum);
}
else if (convSenateGaugeVersion.CalaTotalScore  ==  AttributeName[intIndex])
{
mfltCalaTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeVersion.CalaTotalScore);
}
else if (convSenateGaugeVersion.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.UpdDate);
}
else if (convSenateGaugeVersion.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSenateGaugeVersion.UpdUserId);
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
 AddUpdatedFld(convSenateGaugeVersion.IdSenateGaugeVersion);
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
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionID);
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
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionName);
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
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionMemo);
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
 AddUpdatedFld(convSenateGaugeVersion.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 技能类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeID
{
get
{
return mstrSkillTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeID = value;
}
else
{
 mstrSkillTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeVersion.SkillTypeID);
}
}
/// <summary>
/// 技能类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeName
{
get
{
return mstrSkillTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeName = value;
}
else
{
 mstrSkillTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeVersion.SkillTypeName);
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
 AddUpdatedFld(convSenateGaugeVersion.IdSkillType);
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
 AddUpdatedFld(convSenateGaugeVersion.VersionNo);
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
 AddUpdatedFld(convSenateGaugeVersion.IsUse);
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
 AddUpdatedFld(convSenateGaugeVersion.UserTypeId);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeVersion.UserTypeName);
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
 AddUpdatedFld(convSenateGaugeVersion.SenateGaugeNum);
}
}
/// <summary>
/// CalaTotalScore(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? CalaTotalScore
{
get
{
return mfltCalaTotalScore;
}
set
{
 mfltCalaTotalScore = value;
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeVersion.CalaTotalScore);
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
 AddUpdatedFld(convSenateGaugeVersion.UpdDate);
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
 AddUpdatedFld(convSenateGaugeVersion.UpdUserId);
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
 /// v评价量规版本(vSenateGaugeVersion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSenateGaugeVersion
{
public const string _CurrTabName = "vSenateGaugeVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSenateGaugeVersion"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionMemo", "senateGaugeVersionTtlScore", "SkillTypeID", "SkillTypeName", "IdSkillType", "VersionNo", "IsUse", "UserTypeId", "UserTypeName", "SenateGaugeNum", "CalaTotalScore", "UpdDate", "UpdUserId"};
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
 /// 常量:"senateGaugeVersionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionMemo = "senateGaugeVersionMemo";    //评价量表版本说明

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"SkillTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeID = "SkillTypeID";    //技能类型ID

 /// <summary>
 /// 常量:"SkillTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeName = "SkillTypeName";    //技能类型名称

 /// <summary>
 /// 常量:"IdSkillType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSkillType = "IdSkillType";    //技能类型流水号

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
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"SenateGaugeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateGaugeNum = "SenateGaugeNum";    //SenateGaugeNum

 /// <summary>
 /// 常量:"CalaTotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CalaTotalScore = "CalaTotalScore";    //CalaTotalScore

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