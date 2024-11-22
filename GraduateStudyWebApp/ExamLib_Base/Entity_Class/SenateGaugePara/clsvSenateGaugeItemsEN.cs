
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeItemsEN
 表名:vSenateGaugeItems(01120477)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:26
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
 /// 表vSenateGaugeItems的关键字(IdSenateGaugeItem)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSenateGaugeItem_vSenateGaugeItems
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
public K_IdSenateGaugeItem_vSenateGaugeItems(string strIdSenateGaugeItem)
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
 /// <returns>返回:[K_IdSenateGaugeItem_vSenateGaugeItems]类型的对象</returns>
public static implicit operator K_IdSenateGaugeItem_vSenateGaugeItems(string value)
{
return new K_IdSenateGaugeItem_vSenateGaugeItems(value);
}
}
 /// <summary>
 /// v量表指标(vSenateGaugeItems)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSenateGaugeItemsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSenateGaugeItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSenateGaugeItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 27;
public static string[] AttributeName = new string[] {"IdSenateGaugeItem", "senateGaugeItemID", "senateGaugeItemName", "IdSenateGaugeVersion", "senateGaugeVersionName", "senateGaugeItemDesc", "senateGaugeItemWeight", "AnswerModeId", "AnswerTypeId", "GridTitle", "QuestionIndex", "senateGaugeVersionID", "QuestionNo", "QuestionTypeId", "senateGaugeVersionTtlScore", "AnswerTypeName", "AnswerModeName", "senateGaugeItemMemo", "QuestionTypeName", "AnswerNum", "VersionNo", "IsUse", "senateGaugeVersionMemo", "senateGaugeItemNameWithOrder", "UpdDate", "UpdUserId", "IsHaveAdditionalMemo"};

protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected string mstrsenateGaugeItemID;    //量表指标ID
protected string mstrsenateGaugeItemName;    //量表指标名称
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected string mstrsenateGaugeItemDesc;    //量表指标说明
protected float? mfltsenateGaugeItemWeight;    //量表指标权重
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrGridTitle;    //表格标题
protected int? mintQuestionIndex;    //题目序号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrQuestionNo;    //题目编号
protected string mstrQuestionTypeId;    //题目类型Id
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrAnswerModeName;    //答案模式名称
protected string mstrsenateGaugeItemMemo;    //备注
protected string mstrQuestionTypeName;    //题目类型名
protected int? mintAnswerNum;    //答案数
protected int? mintVersionNo;    //版本号
protected bool mbolIsUse;    //是否使用
protected string mstrsenateGaugeVersionMemo;    //评价量表版本说明
protected string mstrsenateGaugeItemNameWithOrder;    //量表指标名称WithOrder
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected bool mbolIsHaveAdditionalMemo;    //是否有附加说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSenateGaugeItemsEN()
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
public clsvSenateGaugeItemsEN(string strIdSenateGaugeItem)
 {
strIdSenateGaugeItem = strIdSenateGaugeItem.Replace("'", "''");
if (strIdSenateGaugeItem.Length > 4)
{
throw new Exception("在表:vSenateGaugeItems中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSenateGaugeItem)  ==  true)
{
throw new Exception("在表:vSenateGaugeItems中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSenateGaugeItems.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemID)
{
return mstrsenateGaugeItemID;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemName)
{
return mstrsenateGaugeItemName;
}
else if (strAttributeName  ==  convSenateGaugeItems.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemDesc)
{
return mstrsenateGaugeItemDesc;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemWeight)
{
return mfltsenateGaugeItemWeight;
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convSenateGaugeItems.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convSenateGaugeItems.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convSenateGaugeItems.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convSenateGaugeItems.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemMemo)
{
return mstrsenateGaugeItemMemo;
}
else if (strAttributeName  ==  convSenateGaugeItems.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerNum)
{
return mintAnswerNum;
}
else if (strAttributeName  ==  convSenateGaugeItems.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convSenateGaugeItems.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeVersionMemo)
{
return mstrsenateGaugeVersionMemo;
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemNameWithOrder)
{
return mstrsenateGaugeItemNameWithOrder;
}
else if (strAttributeName  ==  convSenateGaugeItems.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSenateGaugeItems.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convSenateGaugeItems.IsHaveAdditionalMemo)
{
return mbolIsHaveAdditionalMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convSenateGaugeItems.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.IdSenateGaugeItem);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemID)
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemID);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemName)
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemName);
}
else if (strAttributeName  ==  convSenateGaugeItems.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionName);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemDesc)
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemDesc);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemWeight)
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemWeight);
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.AnswerModeId);
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.AnswerTypeId);
}
else if (strAttributeName  ==  convSenateGaugeItems.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.GridTitle);
}
else if (strAttributeName  ==  convSenateGaugeItems.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.QuestionIndex);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionID);
}
else if (strAttributeName  ==  convSenateGaugeItems.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.QuestionNo);
}
else if (strAttributeName  ==  convSenateGaugeItems.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.QuestionTypeId);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.AnswerTypeName);
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.AnswerModeName);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemMemo)
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemMemo);
}
else if (strAttributeName  ==  convSenateGaugeItems.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.QuestionTypeName);
}
else if (strAttributeName  ==  convSenateGaugeItems.AnswerNum)
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.AnswerNum);
}
else if (strAttributeName  ==  convSenateGaugeItems.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.VersionNo);
}
else if (strAttributeName  ==  convSenateGaugeItems.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.IsUse);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeVersionMemo)
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionMemo);
}
else if (strAttributeName  ==  convSenateGaugeItems.senateGaugeItemNameWithOrder)
{
mstrsenateGaugeItemNameWithOrder = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemNameWithOrder);
}
else if (strAttributeName  ==  convSenateGaugeItems.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.UpdDate);
}
else if (strAttributeName  ==  convSenateGaugeItems.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.UpdUserId);
}
else if (strAttributeName  ==  convSenateGaugeItems.IsHaveAdditionalMemo)
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.IsHaveAdditionalMemo);
}
}
}
public object this[int intIndex]
{
get
{
if (convSenateGaugeItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (convSenateGaugeItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemID;
}
else if (convSenateGaugeItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemName;
}
else if (convSenateGaugeItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convSenateGaugeItems.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convSenateGaugeItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemDesc;
}
else if (convSenateGaugeItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
return mfltsenateGaugeItemWeight;
}
else if (convSenateGaugeItems.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convSenateGaugeItems.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convSenateGaugeItems.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convSenateGaugeItems.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convSenateGaugeItems.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convSenateGaugeItems.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convSenateGaugeItems.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convSenateGaugeItems.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convSenateGaugeItems.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convSenateGaugeItems.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (convSenateGaugeItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemMemo;
}
else if (convSenateGaugeItems.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convSenateGaugeItems.AnswerNum  ==  AttributeName[intIndex])
{
return mintAnswerNum;
}
else if (convSenateGaugeItems.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convSenateGaugeItems.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convSenateGaugeItems.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionMemo;
}
else if (convSenateGaugeItems.senateGaugeItemNameWithOrder  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemNameWithOrder;
}
else if (convSenateGaugeItems.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSenateGaugeItems.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convSenateGaugeItems.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
return mbolIsHaveAdditionalMemo;
}
return null;
}
set
{
if (convSenateGaugeItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.IdSenateGaugeItem);
}
else if (convSenateGaugeItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemID);
}
else if (convSenateGaugeItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemName);
}
else if (convSenateGaugeItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.IdSenateGaugeVersion);
}
else if (convSenateGaugeItems.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionName);
}
else if (convSenateGaugeItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemDesc);
}
else if (convSenateGaugeItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemWeight);
}
else if (convSenateGaugeItems.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.AnswerModeId);
}
else if (convSenateGaugeItems.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.AnswerTypeId);
}
else if (convSenateGaugeItems.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.GridTitle);
}
else if (convSenateGaugeItems.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.QuestionIndex);
}
else if (convSenateGaugeItems.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionID);
}
else if (convSenateGaugeItems.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.QuestionNo);
}
else if (convSenateGaugeItems.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.QuestionTypeId);
}
else if (convSenateGaugeItems.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionTtlScore);
}
else if (convSenateGaugeItems.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.AnswerTypeName);
}
else if (convSenateGaugeItems.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.AnswerModeName);
}
else if (convSenateGaugeItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemMemo);
}
else if (convSenateGaugeItems.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.QuestionTypeName);
}
else if (convSenateGaugeItems.AnswerNum  ==  AttributeName[intIndex])
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.AnswerNum);
}
else if (convSenateGaugeItems.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.VersionNo);
}
else if (convSenateGaugeItems.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.IsUse);
}
else if (convSenateGaugeItems.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionMemo);
}
else if (convSenateGaugeItems.senateGaugeItemNameWithOrder  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemNameWithOrder = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemNameWithOrder);
}
else if (convSenateGaugeItems.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.UpdDate);
}
else if (convSenateGaugeItems.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSenateGaugeItems.UpdUserId);
}
else if (convSenateGaugeItems.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeItems.IsHaveAdditionalMemo);
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
 AddUpdatedFld(convSenateGaugeItems.IdSenateGaugeItem);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemID);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemName);
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
 AddUpdatedFld(convSenateGaugeItems.IdSenateGaugeVersion);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionName);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemDesc);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemWeight);
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
 AddUpdatedFld(convSenateGaugeItems.AnswerModeId);
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
 AddUpdatedFld(convSenateGaugeItems.AnswerTypeId);
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
 AddUpdatedFld(convSenateGaugeItems.GridTitle);
}
}
/// <summary>
/// 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionIndex
{
get
{
return mintQuestionIndex;
}
set
{
 mintQuestionIndex = value;
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeItems.QuestionIndex);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionID);
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
 AddUpdatedFld(convSenateGaugeItems.QuestionNo);
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
 AddUpdatedFld(convSenateGaugeItems.QuestionTypeId);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 答案类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeName
{
get
{
return mstrAnswerTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeName = value;
}
else
{
 mstrAnswerTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeItems.AnswerTypeName);
}
}
/// <summary>
/// 答案模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeName
{
get
{
return mstrAnswerModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeName = value;
}
else
{
 mstrAnswerModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeItems.AnswerModeName);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemMemo);
}
}
/// <summary>
/// 题目类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeName
{
get
{
return mstrQuestionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeName = value;
}
else
{
 mstrQuestionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeItems.QuestionTypeName);
}
}
/// <summary>
/// 答案数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerNum
{
get
{
return mintAnswerNum;
}
set
{
 mintAnswerNum = value;
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeItems.AnswerNum);
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
 AddUpdatedFld(convSenateGaugeItems.VersionNo);
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
 AddUpdatedFld(convSenateGaugeItems.IsUse);
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
 AddUpdatedFld(convSenateGaugeItems.senateGaugeVersionMemo);
}
}
/// <summary>
/// 量表指标名称WithOrder(说明:;字段类型:varchar;字段长度:204;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeItemNameWithOrder
{
get
{
return mstrsenateGaugeItemNameWithOrder;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeItemNameWithOrder = value;
}
else
{
 mstrsenateGaugeItemNameWithOrder = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeItems.senateGaugeItemNameWithOrder);
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
 AddUpdatedFld(convSenateGaugeItems.UpdDate);
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
 AddUpdatedFld(convSenateGaugeItems.UpdUserId);
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
 AddUpdatedFld(convSenateGaugeItems.IsHaveAdditionalMemo);
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
}
 /// <summary>
 /// v量表指标(vSenateGaugeItems)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSenateGaugeItems
{
public const string _CurrTabName = "vSenateGaugeItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSenateGaugeItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSenateGaugeItem", "senateGaugeItemID", "senateGaugeItemName", "IdSenateGaugeVersion", "senateGaugeVersionName", "senateGaugeItemDesc", "senateGaugeItemWeight", "AnswerModeId", "AnswerTypeId", "GridTitle", "QuestionIndex", "senateGaugeVersionID", "QuestionNo", "QuestionTypeId", "senateGaugeVersionTtlScore", "AnswerTypeName", "AnswerModeName", "senateGaugeItemMemo", "QuestionTypeName", "AnswerNum", "VersionNo", "IsUse", "senateGaugeVersionMemo", "senateGaugeItemNameWithOrder", "UpdDate", "UpdUserId", "IsHaveAdditionalMemo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSenateGaugeItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeItem = "IdSenateGaugeItem";    //量表指标流水号

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
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"senateGaugeVersionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionName = "senateGaugeVersionName";    //评价量表版本名称

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
 /// 常量:"senateGaugeVersionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionID = "senateGaugeVersionID";    //评价量表版本ID

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
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"AnswerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeName = "AnswerTypeName";    //答案类型名

 /// <summary>
 /// 常量:"AnswerModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeName = "AnswerModeName";    //答案模式名称

 /// <summary>
 /// 常量:"senateGaugeItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemMemo = "senateGaugeItemMemo";    //备注

 /// <summary>
 /// 常量:"QuestionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName = "QuestionTypeName";    //题目类型名

 /// <summary>
 /// 常量:"AnswerNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerNum = "AnswerNum";    //答案数

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
 /// 常量:"senateGaugeVersionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionMemo = "senateGaugeVersionMemo";    //评价量表版本说明

 /// <summary>
 /// 常量:"senateGaugeItemNameWithOrder"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemNameWithOrder = "senateGaugeItemNameWithOrder";    //量表指标名称WithOrder

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
 /// 常量:"IsHaveAdditionalMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveAdditionalMemo = "IsHaveAdditionalMemo";    //是否有附加说明
}

}