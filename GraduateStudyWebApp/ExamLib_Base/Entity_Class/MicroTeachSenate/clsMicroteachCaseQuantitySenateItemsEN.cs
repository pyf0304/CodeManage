
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseQuantitySenateItemsEN
 表名:MicroteachCaseQuantitySenateItems(01120492)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表MicroteachCaseQuantitySenateItems的关键字(IdmicroteachCaseQuantitySenateItem)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenateItem_MicroteachCaseQuantitySenateItems
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
public K_IdmicroteachCaseQuantitySenateItem_MicroteachCaseQuantitySenateItems(long lngIdmicroteachCaseQuantitySenateItem)
{
if (IsValid(lngIdmicroteachCaseQuantitySenateItem)) Value = lngIdmicroteachCaseQuantitySenateItem;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdmicroteachCaseQuantitySenateItem)
{
if (lngIdmicroteachCaseQuantitySenateItem == 0) return false;
if (lngIdmicroteachCaseQuantitySenateItem == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenateItem_MicroteachCaseQuantitySenateItems]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenateItem_MicroteachCaseQuantitySenateItems(long value)
{
return new K_IdmicroteachCaseQuantitySenateItem_MicroteachCaseQuantitySenateItems(value);
}
}
 /// <summary>
 /// 微格量化评价详细指标(MicroteachCaseQuantitySenateItems)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMicroteachCaseQuantitySenateItemsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MicroteachCaseQuantitySenateItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenateItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenateItem", "IdmicroteachCaseQuantitySenate", "SenateScore", "IdSenateGaugeItem", "IdSenateGaugeSubItem", "IsAccess", "IsAccessC", "UpdDate", "UpdUser"};

protected long mlngIdmicroteachCaseQuantitySenateItem;    //微格量化评价指标流水号
protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected float? mfltSenateScore;    //指标得分
protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected string mstrIdSenateGaugeSubItem;    //量表指标子项流水号
protected bool mbolIsAccess;    //IsAccess
protected bool mbolIsAccessC;    //IsAccessC
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMicroteachCaseQuantitySenateItemsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdmicroteachCaseQuantitySenateItem");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdmicroteachCaseQuantitySenateItem">关键字:微格量化评价指标流水号</param>
public clsMicroteachCaseQuantitySenateItemsEN(long lngIdmicroteachCaseQuantitySenateItem)
 {
 if (lngIdmicroteachCaseQuantitySenateItem  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdmicroteachCaseQuantitySenateItem = lngIdmicroteachCaseQuantitySenateItem;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdmicroteachCaseQuantitySenateItem");
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
if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem)
{
return mlngIdmicroteachCaseQuantitySenateItem;
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.SenateScore)
{
return mfltSenateScore;
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem)
{
return mstrIdSenateGaugeSubItem;
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IsAccess)
{
return mbolIsAccess;
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IsAccessC)
{
return mbolIsAccessC;
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem)
{
mlngIdmicroteachCaseQuantitySenateItem = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.SenateScore)
{
mfltSenateScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.SenateScore);
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem)
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IsAccess)
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IsAccess);
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.IsAccessC)
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IsAccessC);
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.UpdDate);
}
else if (strAttributeName  ==  conMicroteachCaseQuantitySenateItems.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenateItem;
}
else if (conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (conMicroteachCaseQuantitySenateItems.SenateScore  ==  AttributeName[intIndex])
{
return mfltSenateScore;
}
else if (conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeSubItem;
}
else if (conMicroteachCaseQuantitySenateItems.IsAccess  ==  AttributeName[intIndex])
{
return mbolIsAccess;
}
else if (conMicroteachCaseQuantitySenateItems.IsAccessC  ==  AttributeName[intIndex])
{
return mbolIsAccessC;
}
else if (conMicroteachCaseQuantitySenateItems.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conMicroteachCaseQuantitySenateItems.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenateItem = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
}
else if (conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
else if (conMicroteachCaseQuantitySenateItems.SenateScore  ==  AttributeName[intIndex])
{
mfltSenateScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.SenateScore);
}
else if (conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
else if (conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
else if (conMicroteachCaseQuantitySenateItems.IsAccess  ==  AttributeName[intIndex])
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IsAccess);
}
else if (conMicroteachCaseQuantitySenateItems.IsAccessC  ==  AttributeName[intIndex])
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IsAccessC);
}
else if (conMicroteachCaseQuantitySenateItems.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.UpdDate);
}
else if (conMicroteachCaseQuantitySenateItems.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.UpdUser);
}
}
}

/// <summary>
/// 微格量化评价指标流水号(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdmicroteachCaseQuantitySenateItem
{
get
{
return mlngIdmicroteachCaseQuantitySenateItem;
}
set
{
 mlngIdmicroteachCaseQuantitySenateItem = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
}
}
/// <summary>
/// 微格量化评价流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdmicroteachCaseQuantitySenate
{
get
{
return mlngIdmicroteachCaseQuantitySenate;
}
set
{
 mlngIdmicroteachCaseQuantitySenate = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
}
/// <summary>
/// 指标得分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? SenateScore
{
get
{
return mfltSenateScore;
}
set
{
 mfltSenateScore = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.SenateScore);
}
}
/// <summary>
/// 量表指标流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeItem
{
get
{
return mstrIdSenateGaugeItem;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeItem = value;
}
else
{
 mstrIdSenateGaugeItem = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
}
/// <summary>
/// 量表指标子项流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeSubItem
{
get
{
return mstrIdSenateGaugeSubItem;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeSubItem = value;
}
else
{
 mstrIdSenateGaugeSubItem = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
}
/// <summary>
/// IsAccess(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAccess
{
get
{
return mbolIsAccess;
}
set
{
 mbolIsAccess = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IsAccess);
}
}
/// <summary>
/// IsAccessC(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAccessC
{
get
{
return mbolIsAccessC;
}
set
{
 mbolIsAccessC = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.IsAccessC);
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
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseQuantitySenateItems.UpdUser);
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
  return mlngIdmicroteachCaseQuantitySenateItem.ToString();
 }
 }
}
 /// <summary>
 /// 微格量化评价详细指标(MicroteachCaseQuantitySenateItems)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMicroteachCaseQuantitySenateItems
{
public const string _CurrTabName = "MicroteachCaseQuantitySenateItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenateItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenateItem", "IdmicroteachCaseQuantitySenate", "SenateScore", "IdSenateGaugeItem", "IdSenateGaugeSubItem", "IsAccess", "IsAccessC", "UpdDate", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdmicroteachCaseQuantitySenateItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdmicroteachCaseQuantitySenateItem = "IdmicroteachCaseQuantitySenateItem";    //微格量化评价指标流水号

 /// <summary>
 /// 常量:"IdmicroteachCaseQuantitySenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdmicroteachCaseQuantitySenate = "IdmicroteachCaseQuantitySenate";    //微格量化评价流水号

 /// <summary>
 /// 常量:"SenateScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateScore = "SenateScore";    //指标得分

 /// <summary>
 /// 常量:"IdSenateGaugeItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeItem = "IdSenateGaugeItem";    //量表指标流水号

 /// <summary>
 /// 常量:"IdSenateGaugeSubItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeSubItem = "IdSenateGaugeSubItem";    //量表指标子项流水号

 /// <summary>
 /// 常量:"IsAccess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAccess = "IsAccess";    //IsAccess

 /// <summary>
 /// 常量:"IsAccessC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAccessC = "IsAccessC";    //IsAccessC

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}