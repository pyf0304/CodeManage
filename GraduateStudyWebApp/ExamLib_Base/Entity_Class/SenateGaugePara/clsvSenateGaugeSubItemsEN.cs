
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeSubItemsEN
 表名:vSenateGaugeSubItems(01120479)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:28
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
 /// 表vSenateGaugeSubItems的关键字(IdSenateGaugeSubItem)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSenateGaugeSubItem_vSenateGaugeSubItems
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
public K_IdSenateGaugeSubItem_vSenateGaugeSubItems(string strIdSenateGaugeSubItem)
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
 /// <returns>返回:[K_IdSenateGaugeSubItem_vSenateGaugeSubItems]类型的对象</returns>
public static implicit operator K_IdSenateGaugeSubItem_vSenateGaugeSubItems(string value)
{
return new K_IdSenateGaugeSubItem_vSenateGaugeSubItems(value);
}
}
 /// <summary>
 /// v量表指标子项(vSenateGaugeSubItems)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSenateGaugeSubItemsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSenateGaugeSubItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSenateGaugeSubItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 37;
public static string[] AttributeName = new string[] {"IdSenateGaugeSubItem", "senateGaugeSubItemID", "senateGaugeSubItemName", "IdSenateGaugeItem", "senateGaugeItemName", "senateGaugeVersionName", "senateGaugeSubItemScore", "IdSenateGaugeVersion", "senateGaugeItemID", "senateGaugeSubItemDesc", "AnswerTitle", "AnswerIndex", "senateGaugeItemDesc", "senateGaugeItemWeight", "senateGaugeSubItemMemo", "senateGaugeItemMemo", "senateGaugeVersionID", "senateGaugeVersionTtlScore", "senateGaugeSubItemAll", "senateGaugeSubItemAll2", "VersionNo", "IsUse", "UpdDate", "UpdUserId", "AnswerModeId", "AnswerModeName", "AnswerNum", "AnswerTypeId", "AnswerTypeName", "GridTitle", "IsHaveAdditionalMemo", "QuestionIndex", "QuestionNo", "QuestionTypeId", "QuestionTypeName", "senateGaugeItemNameWithOrder", "senateGaugeVersionMemo"};

protected string mstrIdSenateGaugeSubItem;    //量表指标子项流水号
protected string mstrsenateGaugeSubItemID;    //量表指标子项ID
protected string mstrsenateGaugeSubItemName;    //量表指标子项名称
protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected string mstrsenateGaugeItemName;    //量表指标名称
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeSubItemScore;    //量表指标子项分数
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeItemID;    //量表指标ID
protected string mstrsenateGaugeSubItemDesc;    //量表指标子项说明
protected string mstrAnswerTitle;    //答案标题
protected int? mintAnswerIndex;    //问答序号
protected string mstrsenateGaugeItemDesc;    //量表指标说明
protected float? mfltsenateGaugeItemWeight;    //量表指标权重
protected string mstrsenateGaugeSubItemMemo;    //量表指标子项备注
protected string mstrsenateGaugeItemMemo;    //备注
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrsenateGaugeSubItemAll;    //子项等地分数
protected string mstrsenateGaugeSubItemAll2;    //senateGaugeSubItemAll2
protected int? mintVersionNo;    //版本号
protected bool mbolIsUse;    //是否使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerModeName;    //答案模式名称
protected int? mintAnswerNum;    //答案数
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrGridTitle;    //表格标题
protected bool mbolIsHaveAdditionalMemo;    //是否有附加说明
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionNo;    //题目编号
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrsenateGaugeItemNameWithOrder;    //量表指标名称WithOrder
protected string mstrsenateGaugeVersionMemo;    //评价量表版本说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSenateGaugeSubItemsEN()
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
public clsvSenateGaugeSubItemsEN(string strIdSenateGaugeSubItem)
 {
strIdSenateGaugeSubItem = strIdSenateGaugeSubItem.Replace("'", "''");
if (strIdSenateGaugeSubItem.Length > 4)
{
throw new Exception("在表:vSenateGaugeSubItems中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem)  ==  true)
{
throw new Exception("在表:vSenateGaugeSubItems中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSenateGaugeSubItems.IdSenateGaugeSubItem)
{
return mstrIdSenateGaugeSubItem;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemID)
{
return mstrsenateGaugeSubItemID;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemName)
{
return mstrsenateGaugeSubItemName;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemName)
{
return mstrsenateGaugeItemName;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemScore)
{
return mfltsenateGaugeSubItemScore;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemID)
{
return mstrsenateGaugeItemID;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemDesc)
{
return mstrsenateGaugeSubItemDesc;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerTitle)
{
return mstrAnswerTitle;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemDesc)
{
return mstrsenateGaugeItemDesc;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemWeight)
{
return mfltsenateGaugeItemWeight;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemMemo)
{
return mstrsenateGaugeSubItemMemo;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemMemo)
{
return mstrsenateGaugeItemMemo;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemAll)
{
return mstrsenateGaugeSubItemAll;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemAll2)
{
return mstrsenateGaugeSubItemAll2;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerNum)
{
return mintAnswerNum;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.IsHaveAdditionalMemo)
{
return mbolIsHaveAdditionalMemo;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemNameWithOrder)
{
return mstrsenateGaugeItemNameWithOrder;
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeVersionMemo)
{
return mstrsenateGaugeVersionMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convSenateGaugeSubItems.IdSenateGaugeSubItem)
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeSubItem);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemID)
{
mstrsenateGaugeSubItemID = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemID);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemName)
{
mstrsenateGaugeSubItemName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemName);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeItem);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemName)
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemName);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionName);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemScore)
{
mfltsenateGaugeSubItemScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemScore);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemID)
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemID);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemDesc)
{
mstrsenateGaugeSubItemDesc = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemDesc);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerTitle)
{
mstrAnswerTitle = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTitle);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerIndex)
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.AnswerIndex);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemDesc)
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemDesc);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemWeight)
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemWeight);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemMemo)
{
mstrsenateGaugeSubItemMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemMemo);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemMemo)
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemMemo);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionID);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemAll)
{
mstrsenateGaugeSubItemAll = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemAll);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeSubItemAll2)
{
mstrsenateGaugeSubItemAll2 = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemAll2);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.VersionNo);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.IsUse);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.UpdDate);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.UpdUserId);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerModeId);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerModeName);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerNum)
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.AnswerNum);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTypeId);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTypeName);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.GridTitle);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.IsHaveAdditionalMemo)
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.IsHaveAdditionalMemo);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.QuestionIndex);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.QuestionNo);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.QuestionTypeId);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.QuestionTypeName);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeItemNameWithOrder)
{
mstrsenateGaugeItemNameWithOrder = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemNameWithOrder);
}
else if (strAttributeName  ==  convSenateGaugeSubItems.senateGaugeVersionMemo)
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionMemo);
}
}
}
public object this[int intIndex]
{
get
{
if (convSenateGaugeSubItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeSubItem;
}
else if (convSenateGaugeSubItems.senateGaugeSubItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemID;
}
else if (convSenateGaugeSubItems.senateGaugeSubItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemName;
}
else if (convSenateGaugeSubItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (convSenateGaugeSubItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemName;
}
else if (convSenateGaugeSubItems.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convSenateGaugeSubItems.senateGaugeSubItemScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeSubItemScore;
}
else if (convSenateGaugeSubItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convSenateGaugeSubItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemID;
}
else if (convSenateGaugeSubItems.senateGaugeSubItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemDesc;
}
else if (convSenateGaugeSubItems.AnswerTitle  ==  AttributeName[intIndex])
{
return mstrAnswerTitle;
}
else if (convSenateGaugeSubItems.AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (convSenateGaugeSubItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemDesc;
}
else if (convSenateGaugeSubItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
return mfltsenateGaugeItemWeight;
}
else if (convSenateGaugeSubItems.senateGaugeSubItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemMemo;
}
else if (convSenateGaugeSubItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemMemo;
}
else if (convSenateGaugeSubItems.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convSenateGaugeSubItems.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convSenateGaugeSubItems.senateGaugeSubItemAll  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemAll;
}
else if (convSenateGaugeSubItems.senateGaugeSubItemAll2  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemAll2;
}
else if (convSenateGaugeSubItems.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convSenateGaugeSubItems.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convSenateGaugeSubItems.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSenateGaugeSubItems.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convSenateGaugeSubItems.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convSenateGaugeSubItems.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (convSenateGaugeSubItems.AnswerNum  ==  AttributeName[intIndex])
{
return mintAnswerNum;
}
else if (convSenateGaugeSubItems.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convSenateGaugeSubItems.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convSenateGaugeSubItems.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convSenateGaugeSubItems.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
return mbolIsHaveAdditionalMemo;
}
else if (convSenateGaugeSubItems.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convSenateGaugeSubItems.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convSenateGaugeSubItems.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convSenateGaugeSubItems.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convSenateGaugeSubItems.senateGaugeItemNameWithOrder  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemNameWithOrder;
}
else if (convSenateGaugeSubItems.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionMemo;
}
return null;
}
set
{
if (convSenateGaugeSubItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeSubItem);
}
else if (convSenateGaugeSubItems.senateGaugeSubItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemID = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemID);
}
else if (convSenateGaugeSubItems.senateGaugeSubItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemName);
}
else if (convSenateGaugeSubItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeItem);
}
else if (convSenateGaugeSubItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemName);
}
else if (convSenateGaugeSubItems.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionName);
}
else if (convSenateGaugeSubItems.senateGaugeSubItemScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeSubItemScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemScore);
}
else if (convSenateGaugeSubItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeVersion);
}
else if (convSenateGaugeSubItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemID);
}
else if (convSenateGaugeSubItems.senateGaugeSubItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemDesc = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemDesc);
}
else if (convSenateGaugeSubItems.AnswerTitle  ==  AttributeName[intIndex])
{
mstrAnswerTitle = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTitle);
}
else if (convSenateGaugeSubItems.AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.AnswerIndex);
}
else if (convSenateGaugeSubItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemDesc);
}
else if (convSenateGaugeSubItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemWeight);
}
else if (convSenateGaugeSubItems.senateGaugeSubItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemMemo);
}
else if (convSenateGaugeSubItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemMemo);
}
else if (convSenateGaugeSubItems.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionID);
}
else if (convSenateGaugeSubItems.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionTtlScore);
}
else if (convSenateGaugeSubItems.senateGaugeSubItemAll  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemAll = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemAll);
}
else if (convSenateGaugeSubItems.senateGaugeSubItemAll2  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemAll2 = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemAll2);
}
else if (convSenateGaugeSubItems.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.VersionNo);
}
else if (convSenateGaugeSubItems.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.IsUse);
}
else if (convSenateGaugeSubItems.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.UpdDate);
}
else if (convSenateGaugeSubItems.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.UpdUserId);
}
else if (convSenateGaugeSubItems.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerModeId);
}
else if (convSenateGaugeSubItems.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerModeName);
}
else if (convSenateGaugeSubItems.AnswerNum  ==  AttributeName[intIndex])
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.AnswerNum);
}
else if (convSenateGaugeSubItems.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTypeId);
}
else if (convSenateGaugeSubItems.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTypeName);
}
else if (convSenateGaugeSubItems.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.GridTitle);
}
else if (convSenateGaugeSubItems.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.IsHaveAdditionalMemo);
}
else if (convSenateGaugeSubItems.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convSenateGaugeSubItems.QuestionIndex);
}
else if (convSenateGaugeSubItems.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.QuestionNo);
}
else if (convSenateGaugeSubItems.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.QuestionTypeId);
}
else if (convSenateGaugeSubItems.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.QuestionTypeName);
}
else if (convSenateGaugeSubItems.senateGaugeItemNameWithOrder  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemNameWithOrder = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemNameWithOrder);
}
else if (convSenateGaugeSubItems.senateGaugeVersionMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionMemo = value.ToString();
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionMemo);
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
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeSubItem);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemID);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemName);
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
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeItem);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemName);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionName);
}
}
/// <summary>
/// 量表指标子项分数(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeSubItemScore
{
get
{
return mfltsenateGaugeSubItemScore;
}
set
{
 mfltsenateGaugeSubItemScore = value;
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemScore);
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
 AddUpdatedFld(convSenateGaugeSubItems.IdSenateGaugeVersion);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemID);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemDesc);
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
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTitle);
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
 AddUpdatedFld(convSenateGaugeSubItems.AnswerIndex);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemDesc);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemWeight);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemMemo);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemMemo);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionID);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 子项等地分数(说明:;字段类型:varchar;字段长度:230;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeSubItemAll
{
get
{
return mstrsenateGaugeSubItemAll;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeSubItemAll = value;
}
else
{
 mstrsenateGaugeSubItemAll = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemAll);
}
}
/// <summary>
/// senateGaugeSubItemAll2(说明:;字段类型:varchar;字段长度:2235;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeSubItemAll2
{
get
{
return mstrsenateGaugeSubItemAll2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeSubItemAll2 = value;
}
else
{
 mstrsenateGaugeSubItemAll2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeSubItemAll2);
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
 AddUpdatedFld(convSenateGaugeSubItems.VersionNo);
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
 AddUpdatedFld(convSenateGaugeSubItems.IsUse);
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
 AddUpdatedFld(convSenateGaugeSubItems.UpdDate);
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
 AddUpdatedFld(convSenateGaugeSubItems.UpdUserId);
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
 AddUpdatedFld(convSenateGaugeSubItems.AnswerModeId);
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
 AddUpdatedFld(convSenateGaugeSubItems.AnswerModeName);
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
 AddUpdatedFld(convSenateGaugeSubItems.AnswerNum);
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
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTypeId);
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
 AddUpdatedFld(convSenateGaugeSubItems.AnswerTypeName);
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
 AddUpdatedFld(convSenateGaugeSubItems.GridTitle);
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
 AddUpdatedFld(convSenateGaugeSubItems.IsHaveAdditionalMemo);
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
 AddUpdatedFld(convSenateGaugeSubItems.QuestionIndex);
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
 AddUpdatedFld(convSenateGaugeSubItems.QuestionNo);
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
 AddUpdatedFld(convSenateGaugeSubItems.QuestionTypeId);
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
 AddUpdatedFld(convSenateGaugeSubItems.QuestionTypeName);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeItemNameWithOrder);
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
 AddUpdatedFld(convSenateGaugeSubItems.senateGaugeVersionMemo);
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
}
 /// <summary>
 /// v量表指标子项(vSenateGaugeSubItems)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSenateGaugeSubItems
{
public const string _CurrTabName = "vSenateGaugeSubItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSenateGaugeSubItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSenateGaugeSubItem", "senateGaugeSubItemID", "senateGaugeSubItemName", "IdSenateGaugeItem", "senateGaugeItemName", "senateGaugeVersionName", "senateGaugeSubItemScore", "IdSenateGaugeVersion", "senateGaugeItemID", "senateGaugeSubItemDesc", "AnswerTitle", "AnswerIndex", "senateGaugeItemDesc", "senateGaugeItemWeight", "senateGaugeSubItemMemo", "senateGaugeItemMemo", "senateGaugeVersionID", "senateGaugeVersionTtlScore", "senateGaugeSubItemAll", "senateGaugeSubItemAll2", "VersionNo", "IsUse", "UpdDate", "UpdUserId", "AnswerModeId", "AnswerModeName", "AnswerNum", "AnswerTypeId", "AnswerTypeName", "GridTitle", "IsHaveAdditionalMemo", "QuestionIndex", "QuestionNo", "QuestionTypeId", "QuestionTypeName", "senateGaugeItemNameWithOrder", "senateGaugeVersionMemo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSenateGaugeSubItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeSubItem = "IdSenateGaugeSubItem";    //量表指标子项流水号

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
 /// 常量:"IdSenateGaugeItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeItem = "IdSenateGaugeItem";    //量表指标流水号

 /// <summary>
 /// 常量:"senateGaugeItemName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemName = "senateGaugeItemName";    //量表指标名称

 /// <summary>
 /// 常量:"senateGaugeVersionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionName = "senateGaugeVersionName";    //评价量表版本名称

 /// <summary>
 /// 常量:"senateGaugeSubItemScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemScore = "senateGaugeSubItemScore";    //量表指标子项分数

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
 /// 常量:"senateGaugeSubItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemMemo = "senateGaugeSubItemMemo";    //量表指标子项备注

 /// <summary>
 /// 常量:"senateGaugeItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemMemo = "senateGaugeItemMemo";    //备注

 /// <summary>
 /// 常量:"senateGaugeVersionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionID = "senateGaugeVersionID";    //评价量表版本ID

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"senateGaugeSubItemAll"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemAll = "senateGaugeSubItemAll";    //子项等地分数

 /// <summary>
 /// 常量:"senateGaugeSubItemAll2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemAll2 = "senateGaugeSubItemAll2";    //senateGaugeSubItemAll2

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
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"AnswerModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeName = "AnswerModeName";    //答案模式名称

 /// <summary>
 /// 常量:"AnswerNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerNum = "AnswerNum";    //答案数

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"AnswerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeName = "AnswerTypeName";    //答案类型名

 /// <summary>
 /// 常量:"GridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GridTitle = "GridTitle";    //表格标题

 /// <summary>
 /// 常量:"IsHaveAdditionalMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveAdditionalMemo = "IsHaveAdditionalMemo";    //是否有附加说明

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
 /// 常量:"QuestionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName = "QuestionTypeName";    //题目类型名

 /// <summary>
 /// 常量:"senateGaugeItemNameWithOrder"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemNameWithOrder = "senateGaugeItemNameWithOrder";    //量表指标名称WithOrder

 /// <summary>
 /// 常量:"senateGaugeVersionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionMemo = "senateGaugeVersionMemo";    //评价量表版本说明
}

}