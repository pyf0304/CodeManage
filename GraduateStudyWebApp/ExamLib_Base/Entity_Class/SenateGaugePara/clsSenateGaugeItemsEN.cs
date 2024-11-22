
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeItemsEN
 表名:SenateGaugeItems(01120476)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:15
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
 /// 表SenateGaugeItems的关键字(IdSenateGaugeItem)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSenateGaugeItem_SenateGaugeItems
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSenateGaugeItem">表关键字</param>
public K_IdSenateGaugeItem_SenateGaugeItems(string strIdSenateGaugeItem)
{
if (IsValid(strIdSenateGaugeItem)) Value = strIdSenateGaugeItem;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSenateGaugeItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeItem) == true) return false;
if (strIdSenateGaugeItem.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSenateGaugeItem_SenateGaugeItems]类型的对象</returns>
public static implicit operator K_IdSenateGaugeItem_SenateGaugeItems(string value)
{
return new K_IdSenateGaugeItem_SenateGaugeItems(value);
}
}
 /// <summary>
 /// 量表指标(SenateGaugeItems)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSenateGaugeItemsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SenateGaugeItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSenateGaugeItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"IdSenateGaugeItem", "IdSenateGaugeVersion", "senateGaugeItemID", "senateGaugeItemName", "senateGaugeItemDesc", "senateGaugeItemWeight", "AnswerModeId", "AnswerTypeId", "GridTitle", "QuestionIndex", "QuestionNo", "QuestionTypeId", "IsHaveAdditionalMemo", "UpdDate", "UpdUserId", "senateGaugeItemMemo"};

protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeItemID;    //量表指标ID
protected string mstrsenateGaugeItemName;    //量表指标名称
protected string mstrsenateGaugeItemDesc;    //量表指标说明
protected float? mfltsenateGaugeItemWeight;    //量表指标权重
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrGridTitle;    //表格标题
protected int mintQuestionIndex;    //题目序号
protected string mstrQuestionNo;    //题目编号
protected string mstrQuestionTypeId;    //题目类型Id
protected bool mbolIsHaveAdditionalMemo;    //是否有附加说明
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrsenateGaugeItemMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSenateGaugeItemsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSenateGaugeItem");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSenateGaugeItem">关键字:量表指标流水号</param>
public clsSenateGaugeItemsEN(string strIdSenateGaugeItem)
 {
strIdSenateGaugeItem = strIdSenateGaugeItem.Replace("'", "''");
if (strIdSenateGaugeItem.Length > 4)
{
throw new Exception("在表:SenateGaugeItems中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSenateGaugeItem)  ==  true)
{
throw new Exception("在表:SenateGaugeItems中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeItem);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSenateGaugeItem = strIdSenateGaugeItem;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSenateGaugeItem");
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
if (strAttributeName  ==  conSenateGaugeItems.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  conSenateGaugeItems.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemID)
{
return mstrsenateGaugeItemID;
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemName)
{
return mstrsenateGaugeItemName;
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemDesc)
{
return mstrsenateGaugeItemDesc;
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemWeight)
{
return mfltsenateGaugeItemWeight;
}
else if (strAttributeName  ==  conSenateGaugeItems.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  conSenateGaugeItems.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  conSenateGaugeItems.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  conSenateGaugeItems.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  conSenateGaugeItems.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  conSenateGaugeItems.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  conSenateGaugeItems.IsHaveAdditionalMemo)
{
return mbolIsHaveAdditionalMemo;
}
else if (strAttributeName  ==  conSenateGaugeItems.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSenateGaugeItems.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemMemo)
{
return mstrsenateGaugeItemMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSenateGaugeItems.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.IdSenateGaugeItem);
}
else if (strAttributeName  ==  conSenateGaugeItems.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemID)
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemID);
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemName)
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemName);
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemDesc)
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemDesc);
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemWeight)
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemWeight);
}
else if (strAttributeName  ==  conSenateGaugeItems.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.AnswerModeId);
}
else if (strAttributeName  ==  conSenateGaugeItems.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.AnswerTypeId);
}
else if (strAttributeName  ==  conSenateGaugeItems.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.GridTitle);
}
else if (strAttributeName  ==  conSenateGaugeItems.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conSenateGaugeItems.QuestionIndex);
}
else if (strAttributeName  ==  conSenateGaugeItems.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.QuestionNo);
}
else if (strAttributeName  ==  conSenateGaugeItems.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.QuestionTypeId);
}
else if (strAttributeName  ==  conSenateGaugeItems.IsHaveAdditionalMemo)
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(conSenateGaugeItems.IsHaveAdditionalMemo);
}
else if (strAttributeName  ==  conSenateGaugeItems.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.UpdDate);
}
else if (strAttributeName  ==  conSenateGaugeItems.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.UpdUserId);
}
else if (strAttributeName  ==  conSenateGaugeItems.senateGaugeItemMemo)
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemMemo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSenateGaugeItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (conSenateGaugeItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conSenateGaugeItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemID;
}
else if (conSenateGaugeItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemName;
}
else if (conSenateGaugeItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemDesc;
}
else if (conSenateGaugeItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
return mfltsenateGaugeItemWeight;
}
else if (conSenateGaugeItems.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (conSenateGaugeItems.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (conSenateGaugeItems.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (conSenateGaugeItems.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (conSenateGaugeItems.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (conSenateGaugeItems.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (conSenateGaugeItems.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
return mbolIsHaveAdditionalMemo;
}
else if (conSenateGaugeItems.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSenateGaugeItems.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSenateGaugeItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemMemo;
}
return null;
}
set
{
if (conSenateGaugeItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.IdSenateGaugeItem);
}
else if (conSenateGaugeItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.IdSenateGaugeVersion);
}
else if (conSenateGaugeItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemID);
}
else if (conSenateGaugeItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemName);
}
else if (conSenateGaugeItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemDesc);
}
else if (conSenateGaugeItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemWeight);
}
else if (conSenateGaugeItems.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.AnswerModeId);
}
else if (conSenateGaugeItems.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.AnswerTypeId);
}
else if (conSenateGaugeItems.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.GridTitle);
}
else if (conSenateGaugeItems.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conSenateGaugeItems.QuestionIndex);
}
else if (conSenateGaugeItems.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.QuestionNo);
}
else if (conSenateGaugeItems.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.QuestionTypeId);
}
else if (conSenateGaugeItems.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(conSenateGaugeItems.IsHaveAdditionalMemo);
}
else if (conSenateGaugeItems.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.UpdDate);
}
else if (conSenateGaugeItems.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.UpdUserId);
}
else if (conSenateGaugeItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemMemo);
}
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
 AddUpdatedFld(conSenateGaugeItems.IdSenateGaugeItem);
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
 AddUpdatedFld(conSenateGaugeItems.IdSenateGaugeVersion);
}
}
/// <summary>
/// 量表指标ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeItemID
{
get
{
return mstrsenateGaugeItemID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeItemID = value;
}
else
{
 mstrsenateGaugeItemID = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemID);
}
}
/// <summary>
/// 量表指标名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeItemName
{
get
{
return mstrsenateGaugeItemName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeItemName = value;
}
else
{
 mstrsenateGaugeItemName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemName);
}
}
/// <summary>
/// 量表指标说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeItemDesc
{
get
{
return mstrsenateGaugeItemDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeItemDesc = value;
}
else
{
 mstrsenateGaugeItemDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemDesc);
}
}
/// <summary>
/// 量表指标权重(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeItemWeight
{
get
{
return mfltsenateGaugeItemWeight;
}
set
{
 mfltsenateGaugeItemWeight = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemWeight);
}
}
/// <summary>
/// 答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeId
{
get
{
return mstrAnswerModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeId = value;
}
else
{
 mstrAnswerModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.AnswerModeId);
}
}
/// <summary>
/// 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeId
{
get
{
return mstrAnswerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeId = value;
}
else
{
 mstrAnswerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.AnswerTypeId);
}
}
/// <summary>
/// 表格标题(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GridTitle
{
get
{
return mstrGridTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGridTitle = value;
}
else
{
 mstrGridTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.GridTitle);
}
}
/// <summary>
/// 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int QuestionIndex
{
get
{
return mintQuestionIndex;
}
set
{
 mintQuestionIndex = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.QuestionIndex);
}
}
/// <summary>
/// 题目编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionNo
{
get
{
return mstrQuestionNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionNo = value;
}
else
{
 mstrQuestionNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.QuestionNo);
}
}
/// <summary>
/// 题目类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId
{
get
{
return mstrQuestionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId = value;
}
else
{
 mstrQuestionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.QuestionTypeId);
}
}
/// <summary>
/// 是否有附加说明(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveAdditionalMemo
{
get
{
return mbolIsHaveAdditionalMemo;
}
set
{
 mbolIsHaveAdditionalMemo = value;
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.IsHaveAdditionalMemo);
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
 AddUpdatedFld(conSenateGaugeItems.UpdDate);
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
 AddUpdatedFld(conSenateGaugeItems.UpdUserId);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeItemMemo
{
get
{
return mstrsenateGaugeItemMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeItemMemo = value;
}
else
{
 mstrsenateGaugeItemMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conSenateGaugeItems.senateGaugeItemMemo);
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
  return mstrIdSenateGaugeItem;
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
  return mstrsenateGaugeItemName;
 }
 }
}
 /// <summary>
 /// 量表指标(SenateGaugeItems)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSenateGaugeItems
{
public const string _CurrTabName = "SenateGaugeItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSenateGaugeItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSenateGaugeItem", "IdSenateGaugeVersion", "senateGaugeItemID", "senateGaugeItemName", "senateGaugeItemDesc", "senateGaugeItemWeight", "AnswerModeId", "AnswerTypeId", "GridTitle", "QuestionIndex", "QuestionNo", "QuestionTypeId", "IsHaveAdditionalMemo", "UpdDate", "UpdUserId", "senateGaugeItemMemo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSenateGaugeItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeItem = "IdSenateGaugeItem";    //量表指标流水号

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"senateGaugeItemID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemID = "senateGaugeItemID";    //量表指标ID

 /// <summary>
 /// 常量:"senateGaugeItemName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemName = "senateGaugeItemName";    //量表指标名称

 /// <summary>
 /// 常量:"senateGaugeItemDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemDesc = "senateGaugeItemDesc";    //量表指标说明

 /// <summary>
 /// 常量:"senateGaugeItemWeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemWeight = "senateGaugeItemWeight";    //量表指标权重

 /// <summary>
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"GridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GridTitle = "GridTitle";    //表格标题

 /// <summary>
 /// 常量:"QuestionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex = "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNo = "QuestionNo";    //题目编号

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"IsHaveAdditionalMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveAdditionalMemo = "IsHaveAdditionalMemo";    //是否有附加说明

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
 /// 常量:"senateGaugeItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemMemo = "senateGaugeItemMemo";    //备注
}

}