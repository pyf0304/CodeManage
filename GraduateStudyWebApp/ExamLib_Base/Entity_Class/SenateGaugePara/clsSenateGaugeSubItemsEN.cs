
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeSubItemsEN
 表名:SenateGaugeSubItems(01120478)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:19
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
 /// 表SenateGaugeSubItems的关键字(IdSenateGaugeSubItem)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSenateGaugeSubItem_SenateGaugeSubItems
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSenateGaugeSubItem">表关键字</param>
public K_IdSenateGaugeSubItem_SenateGaugeSubItems(string strIdSenateGaugeSubItem)
{
if (IsValid(strIdSenateGaugeSubItem)) Value = strIdSenateGaugeSubItem;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem) == true) return false;
if (strIdSenateGaugeSubItem.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSenateGaugeSubItem_SenateGaugeSubItems]类型的对象</returns>
public static implicit operator K_IdSenateGaugeSubItem_SenateGaugeSubItems(string value)
{
return new K_IdSenateGaugeSubItem_SenateGaugeSubItems(value);
}
}
 /// <summary>
 /// 量表指标子项(SenateGaugeSubItems)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSenateGaugeSubItemsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SenateGaugeSubItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSenateGaugeSubItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"IdSenateGaugeSubItem", "IdSenateGaugeItem", "senateGaugeSubItemID", "senateGaugeSubItemName", "senateGaugeSubItemScore", "senateGaugeSubItemDesc", "AnswerTitle", "AnswerIndex", "UpdDate", "UpdUserId", "senateGaugeSubItemMemo"};

protected string mstrIdSenateGaugeSubItem;    //量表指标子项流水号
protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected string mstrsenateGaugeSubItemID;    //量表指标子项ID
protected string mstrsenateGaugeSubItemName;    //量表指标子项名称
protected float mfltsenateGaugeSubItemScore;    //量表指标子项分数
protected string mstrsenateGaugeSubItemDesc;    //量表指标子项说明
protected string mstrAnswerTitle;    //答案标题
protected int? mintAnswerIndex;    //问答序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrsenateGaugeSubItemMemo;    //量表指标子项备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSenateGaugeSubItemsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSenateGaugeSubItem");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSenateGaugeSubItem">关键字:量表指标子项流水号</param>
public clsSenateGaugeSubItemsEN(string strIdSenateGaugeSubItem)
 {
strIdSenateGaugeSubItem = strIdSenateGaugeSubItem.Replace("'", "''");
if (strIdSenateGaugeSubItem.Length > 4)
{
throw new Exception("在表:SenateGaugeSubItems中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem)  ==  true)
{
throw new Exception("在表:SenateGaugeSubItems中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeSubItem);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSenateGaugeSubItem = strIdSenateGaugeSubItem;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSenateGaugeSubItem");
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
if (strAttributeName  ==  conSenateGaugeSubItems.IdSenateGaugeSubItem)
{
return mstrIdSenateGaugeSubItem;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemID)
{
return mstrsenateGaugeSubItemID;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemName)
{
return mstrsenateGaugeSubItemName;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemScore)
{
return mfltsenateGaugeSubItemScore;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemDesc)
{
return mstrsenateGaugeSubItemDesc;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.AnswerTitle)
{
return mstrAnswerTitle;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemMemo)
{
return mstrsenateGaugeSubItemMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSenateGaugeSubItems.IdSenateGaugeSubItem)
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.IdSenateGaugeSubItem);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.IdSenateGaugeItem);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemID)
{
mstrsenateGaugeSubItemID = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemID);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemName)
{
mstrsenateGaugeSubItemName = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemName);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemScore)
{
mfltsenateGaugeSubItemScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemScore);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemDesc)
{
mstrsenateGaugeSubItemDesc = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemDesc);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.AnswerTitle)
{
mstrAnswerTitle = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.AnswerTitle);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.AnswerIndex)
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conSenateGaugeSubItems.AnswerIndex);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.UpdDate);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.UpdUserId);
}
else if (strAttributeName  ==  conSenateGaugeSubItems.senateGaugeSubItemMemo)
{
mstrsenateGaugeSubItemMemo = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemMemo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSenateGaugeSubItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeSubItem;
}
else if (conSenateGaugeSubItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (conSenateGaugeSubItems.senateGaugeSubItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemID;
}
else if (conSenateGaugeSubItems.senateGaugeSubItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemName;
}
else if (conSenateGaugeSubItems.senateGaugeSubItemScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeSubItemScore;
}
else if (conSenateGaugeSubItems.senateGaugeSubItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemDesc;
}
else if (conSenateGaugeSubItems.AnswerTitle  ==  AttributeName[intIndex])
{
return mstrAnswerTitle;
}
else if (conSenateGaugeSubItems.AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (conSenateGaugeSubItems.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSenateGaugeSubItems.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSenateGaugeSubItems.senateGaugeSubItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemMemo;
}
return null;
}
set
{
if (conSenateGaugeSubItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.IdSenateGaugeSubItem);
}
else if (conSenateGaugeSubItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.IdSenateGaugeItem);
}
else if (conSenateGaugeSubItems.senateGaugeSubItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemID = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemID);
}
else if (conSenateGaugeSubItems.senateGaugeSubItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemName = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemName);
}
else if (conSenateGaugeSubItems.senateGaugeSubItemScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeSubItemScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemScore);
}
else if (conSenateGaugeSubItems.senateGaugeSubItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemDesc = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemDesc);
}
else if (conSenateGaugeSubItems.AnswerTitle  ==  AttributeName[intIndex])
{
mstrAnswerTitle = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.AnswerTitle);
}
else if (conSenateGaugeSubItems.AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conSenateGaugeSubItems.AnswerIndex);
}
else if (conSenateGaugeSubItems.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.UpdDate);
}
else if (conSenateGaugeSubItems.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.UpdUserId);
}
else if (conSenateGaugeSubItems.senateGaugeSubItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemMemo = value.ToString();
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemMemo);
}
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
 AddUpdatedFld(conSenateGaugeSubItems.IdSenateGaugeSubItem);
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
 AddUpdatedFld(conSenateGaugeSubItems.IdSenateGaugeItem);
}
}
/// <summary>
/// 量表指标子项ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeSubItemID
{
get
{
return mstrsenateGaugeSubItemID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeSubItemID = value;
}
else
{
 mstrsenateGaugeSubItemID = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemID);
}
}
/// <summary>
/// 量表指标子项名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeSubItemName
{
get
{
return mstrsenateGaugeSubItemName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeSubItemName = value;
}
else
{
 mstrsenateGaugeSubItemName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemName);
}
}
/// <summary>
/// 量表指标子项分数(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float senateGaugeSubItemScore
{
get
{
return mfltsenateGaugeSubItemScore;
}
set
{
 mfltsenateGaugeSubItemScore = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemScore);
}
}
/// <summary>
/// 量表指标子项说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeSubItemDesc
{
get
{
return mstrsenateGaugeSubItemDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeSubItemDesc = value;
}
else
{
 mstrsenateGaugeSubItemDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemDesc);
}
}
/// <summary>
/// 答案标题(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTitle
{
get
{
return mstrAnswerTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTitle = value;
}
else
{
 mstrAnswerTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeSubItems.AnswerTitle);
}
}
/// <summary>
/// 问答序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerIndex
{
get
{
return mintAnswerIndex;
}
set
{
 mintAnswerIndex = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeSubItems.AnswerIndex);
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
 AddUpdatedFld(conSenateGaugeSubItems.UpdDate);
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
 AddUpdatedFld(conSenateGaugeSubItems.UpdUserId);
}
}
/// <summary>
/// 量表指标子项备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeSubItemMemo
{
get
{
return mstrsenateGaugeSubItemMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeSubItemMemo = value;
}
else
{
 mstrsenateGaugeSubItemMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeSubItems.senateGaugeSubItemMemo);
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
  return mstrIdSenateGaugeSubItem;
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
  return mstrsenateGaugeSubItemName;
 }
 }
}
 /// <summary>
 /// 量表指标子项(SenateGaugeSubItems)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSenateGaugeSubItems
{
public const string _CurrTabName = "SenateGaugeSubItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSenateGaugeSubItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSenateGaugeSubItem", "IdSenateGaugeItem", "senateGaugeSubItemID", "senateGaugeSubItemName", "senateGaugeSubItemScore", "senateGaugeSubItemDesc", "AnswerTitle", "AnswerIndex", "UpdDate", "UpdUserId", "senateGaugeSubItemMemo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSenateGaugeSubItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeSubItem = "IdSenateGaugeSubItem";    //量表指标子项流水号

 /// <summary>
 /// 常量:"IdSenateGaugeItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeItem = "IdSenateGaugeItem";    //量表指标流水号

 /// <summary>
 /// 常量:"senateGaugeSubItemID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemID = "senateGaugeSubItemID";    //量表指标子项ID

 /// <summary>
 /// 常量:"senateGaugeSubItemName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemName = "senateGaugeSubItemName";    //量表指标子项名称

 /// <summary>
 /// 常量:"senateGaugeSubItemScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemScore = "senateGaugeSubItemScore";    //量表指标子项分数

 /// <summary>
 /// 常量:"senateGaugeSubItemDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemDesc = "senateGaugeSubItemDesc";    //量表指标子项说明

 /// <summary>
 /// 常量:"AnswerTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTitle = "AnswerTitle";    //答案标题

 /// <summary>
 /// 常量:"AnswerIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIndex = "AnswerIndex";    //问答序号

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
 /// 常量:"senateGaugeSubItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemMemo = "senateGaugeSubItemMemo";    //量表指标子项备注
}

}