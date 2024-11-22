
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateItemsEN
 表名:vMicroteachCaseQuantitySenateItems(01120493)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:53
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
 /// 表vMicroteachCaseQuantitySenateItems的关键字(IdmicroteachCaseQuantitySenateItem)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenateItem_vMicroteachCaseQuantitySenateItems
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
public K_IdmicroteachCaseQuantitySenateItem_vMicroteachCaseQuantitySenateItems(long lngIdmicroteachCaseQuantitySenateItem)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenateItem_vMicroteachCaseQuantitySenateItems]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenateItem_vMicroteachCaseQuantitySenateItems(long value)
{
return new K_IdmicroteachCaseQuantitySenateItem_vMicroteachCaseQuantitySenateItems(value);
}
}
 /// <summary>
 /// 微格量化评价详细(vMicroteachCaseQuantitySenateItems)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachCaseQuantitySenateItemsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachCaseQuantitySenateItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenateItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 63;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenateItem", "IdmicroteachCaseQuantitySenate", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "IdSenateGaugeItem", "senateGaugeItemID", "senateGaugeItemName", "senateGaugeItemNameWithOrder", "senateGaugeItemDesc", "senateGaugeItemMemo", "senateGaugeItemWeight", "SenateScore", "IdSenateGaugeSubItem", "senateGaugeSubItemID", "senateGaugeSubItemName", "senateGaugeSubItemDesc", "senateGaugeSubItemMemo", "senateGaugeSubItemScore", "UserId", "UserName", "CollegeID", "CollegeName", "SenateTheme", "SenateContent", "SenateDate", "SenateTime", "SenateTotalScore", "AnswerModeId", "AnswerTypeId", "GridTitle", "QuestionIndex", "QuestionNo", "QuestionTypeId", "AnswerModeName", "AnswerNum", "AnswerTypeName", "QuestionTypeName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IdSenateGaugeVersion", "AnswerIndex", "AnswerTitle", "OwnerId", "OwnerName", "OwnerNameWithId", "SenateIp", "UserNameWithUserId", "UserTypeId", "IsAccess", "IsAccessC", "UpdDate", "UpdUser", "IdAppraiseType", "AppraiseTypeName", "FuncModuleId", "UserKindId", "UserKindName", "UserTypeName", "FuncModuleName", "IdXzCollege", "CollegeNameA"};

protected long mlngIdmicroteachCaseQuantitySenateItem;    //微格量化评价指标流水号
protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrMicroteachCaseID;    //微格教学案例ID
protected string mstrMicroteachCaseName;    //微格教学案例名称
protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected string mstrsenateGaugeItemID;    //量表指标ID
protected string mstrsenateGaugeItemName;    //量表指标名称
protected string mstrsenateGaugeItemNameWithOrder;    //量表指标名称WithOrder
protected string mstrsenateGaugeItemDesc;    //量表指标说明
protected string mstrsenateGaugeItemMemo;    //备注
protected float? mfltsenateGaugeItemWeight;    //量表指标权重
protected float? mfltSenateScore;    //指标得分
protected string mstrIdSenateGaugeSubItem;    //量表指标子项流水号
protected string mstrsenateGaugeSubItemID;    //量表指标子项ID
protected string mstrsenateGaugeSubItemName;    //量表指标子项名称
protected string mstrsenateGaugeSubItemDesc;    //量表指标子项说明
protected string mstrsenateGaugeSubItemMemo;    //量表指标子项备注
protected float? mfltsenateGaugeSubItemScore;    //量表指标子项分数
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrSenateTheme;    //量化评价主题
protected string mstrSenateContent;    //评价内容
protected string mstrSenateDate;    //评价日期
protected string mstrSenateTime;    //评价时间
protected float? mfltSenateTotalScore;    //评价分数
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrGridTitle;    //表格标题
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionNo;    //题目编号
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrAnswerModeName;    //答案模式名称
protected int? mintAnswerNum;    //答案数
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected int? mintAnswerIndex;    //问答序号
protected string mstrAnswerTitle;    //答案标题
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrSenateIp;    //评议Ip
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrUserTypeId;    //用户类型Id
protected bool mbolIsAccess;    //IsAccess
protected bool mbolIsAccessC;    //IsAccessC
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrUserTypeName;    //用户类型名称
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachCaseQuantitySenateItemsEN()
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
public clsvMicroteachCaseQuantitySenateItemsEN(long lngIdmicroteachCaseQuantitySenateItem)
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
if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem)
{
return mlngIdmicroteachCaseQuantitySenateItem;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.MicroteachCaseID)
{
return mstrMicroteachCaseID;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.MicroteachCaseName)
{
return mstrMicroteachCaseName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemID)
{
return mstrsenateGaugeItemID;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemName)
{
return mstrsenateGaugeItemName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder)
{
return mstrsenateGaugeItemNameWithOrder;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc)
{
return mstrsenateGaugeItemDesc;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo)
{
return mstrsenateGaugeItemMemo;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight)
{
return mfltsenateGaugeItemWeight;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateScore)
{
return mfltSenateScore;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem)
{
return mstrIdSenateGaugeSubItem;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID)
{
return mstrsenateGaugeSubItemID;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName)
{
return mstrsenateGaugeSubItemName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc)
{
return mstrsenateGaugeSubItemDesc;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo)
{
return mstrsenateGaugeSubItemMemo;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore)
{
return mfltsenateGaugeSubItemScore;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerNum)
{
return mintAnswerNum;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerTitle)
{
return mstrAnswerTitle;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IsAccess)
{
return mbolIsAccess;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IsAccessC)
{
return mbolIsAccessC;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem)
{
mlngIdmicroteachCaseQuantitySenateItem = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.MicroteachCaseID)
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.MicroteachCaseName)
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.MicroteachCaseName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemID)
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemName)
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder)
{
mstrsenateGaugeItemNameWithOrder = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc)
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo)
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight)
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateScore)
{
mfltSenateScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateScore);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem)
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID)
{
mstrsenateGaugeSubItemID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName)
{
mstrsenateGaugeSubItemName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc)
{
mstrsenateGaugeSubItemDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo)
{
mstrsenateGaugeSubItemMemo = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore)
{
mfltsenateGaugeSubItemScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeID);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTheme);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateContent);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateDate);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTime);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTotalScore);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerModeId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTypeId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.GridTitle);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionIndex);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionNo);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionTypeId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerModeName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerNum)
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerNum);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTypeName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionTypeName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerIndex)
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerIndex);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AnswerTitle)
{
mstrAnswerTitle = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTitle);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerNameWithId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateIp);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserNameWithUserId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserTypeId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IsAccess)
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IsAccess);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IsAccessC)
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IsAccessC);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UpdDate);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UpdUser);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdAppraiseType);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AppraiseTypeName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.FuncModuleId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserKindId);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserKindName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserTypeName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.FuncModuleName);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdXzCollege);
}
else if (strAttributeName  ==  convMicroteachCaseQuantitySenateItems.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenateItem;
}
else if (convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convMicroteachCaseQuantitySenateItems.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroteachCaseQuantitySenateItems.MicroteachCaseID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseID;
}
else if (convMicroteachCaseQuantitySenateItems.MicroteachCaseName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseName;
}
else if (convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemID;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemName;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemNameWithOrder;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemDesc;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemMemo;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
return mfltsenateGaugeItemWeight;
}
else if (convMicroteachCaseQuantitySenateItems.SenateScore  ==  AttributeName[intIndex])
{
return mfltSenateScore;
}
else if (convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeSubItem;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemID;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemName;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemDesc;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemMemo;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeSubItemScore;
}
else if (convMicroteachCaseQuantitySenateItems.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convMicroteachCaseQuantitySenateItems.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convMicroteachCaseQuantitySenateItems.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convMicroteachCaseQuantitySenateItems.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convMicroteachCaseQuantitySenateItems.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convMicroteachCaseQuantitySenateItems.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convMicroteachCaseQuantitySenateItems.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convMicroteachCaseQuantitySenateItems.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convMicroteachCaseQuantitySenateItems.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convMicroteachCaseQuantitySenateItems.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convMicroteachCaseQuantitySenateItems.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convMicroteachCaseQuantitySenateItems.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convMicroteachCaseQuantitySenateItems.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convMicroteachCaseQuantitySenateItems.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convMicroteachCaseQuantitySenateItems.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convMicroteachCaseQuantitySenateItems.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (convMicroteachCaseQuantitySenateItems.AnswerNum  ==  AttributeName[intIndex])
{
return mintAnswerNum;
}
else if (convMicroteachCaseQuantitySenateItems.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convMicroteachCaseQuantitySenateItems.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convMicroteachCaseQuantitySenateItems.AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (convMicroteachCaseQuantitySenateItems.AnswerTitle  ==  AttributeName[intIndex])
{
return mstrAnswerTitle;
}
else if (convMicroteachCaseQuantitySenateItems.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convMicroteachCaseQuantitySenateItems.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convMicroteachCaseQuantitySenateItems.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convMicroteachCaseQuantitySenateItems.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convMicroteachCaseQuantitySenateItems.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convMicroteachCaseQuantitySenateItems.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convMicroteachCaseQuantitySenateItems.IsAccess  ==  AttributeName[intIndex])
{
return mbolIsAccess;
}
else if (convMicroteachCaseQuantitySenateItems.IsAccessC  ==  AttributeName[intIndex])
{
return mbolIsAccessC;
}
else if (convMicroteachCaseQuantitySenateItems.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convMicroteachCaseQuantitySenateItems.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convMicroteachCaseQuantitySenateItems.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convMicroteachCaseQuantitySenateItems.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convMicroteachCaseQuantitySenateItems.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convMicroteachCaseQuantitySenateItems.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convMicroteachCaseQuantitySenateItems.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convMicroteachCaseQuantitySenateItems.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convMicroteachCaseQuantitySenateItems.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convMicroteachCaseQuantitySenateItems.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convMicroteachCaseQuantitySenateItems.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenateItem = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
}
else if (convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
else if (convMicroteachCaseQuantitySenateItems.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdMicroteachCase);
}
else if (convMicroteachCaseQuantitySenateItems.MicroteachCaseID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
}
else if (convMicroteachCaseQuantitySenateItems.MicroteachCaseName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.MicroteachCaseName);
}
else if (convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemName);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemNameWithOrder = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight);
}
else if (convMicroteachCaseQuantitySenateItems.SenateScore  ==  AttributeName[intIndex])
{
mfltSenateScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateScore);
}
else if (convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemDesc = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemMemo = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeSubItemScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore);
}
else if (convMicroteachCaseQuantitySenateItems.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserId);
}
else if (convMicroteachCaseQuantitySenateItems.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserName);
}
else if (convMicroteachCaseQuantitySenateItems.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeID);
}
else if (convMicroteachCaseQuantitySenateItems.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeName);
}
else if (convMicroteachCaseQuantitySenateItems.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTheme);
}
else if (convMicroteachCaseQuantitySenateItems.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateContent);
}
else if (convMicroteachCaseQuantitySenateItems.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateDate);
}
else if (convMicroteachCaseQuantitySenateItems.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTime);
}
else if (convMicroteachCaseQuantitySenateItems.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTotalScore);
}
else if (convMicroteachCaseQuantitySenateItems.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerModeId);
}
else if (convMicroteachCaseQuantitySenateItems.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTypeId);
}
else if (convMicroteachCaseQuantitySenateItems.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.GridTitle);
}
else if (convMicroteachCaseQuantitySenateItems.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionIndex);
}
else if (convMicroteachCaseQuantitySenateItems.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionNo);
}
else if (convMicroteachCaseQuantitySenateItems.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionTypeId);
}
else if (convMicroteachCaseQuantitySenateItems.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerModeName);
}
else if (convMicroteachCaseQuantitySenateItems.AnswerNum  ==  AttributeName[intIndex])
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerNum);
}
else if (convMicroteachCaseQuantitySenateItems.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTypeName);
}
else if (convMicroteachCaseQuantitySenateItems.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionTypeName);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName);
}
else if (convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore);
}
else if (convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion);
}
else if (convMicroteachCaseQuantitySenateItems.AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerIndex);
}
else if (convMicroteachCaseQuantitySenateItems.AnswerTitle  ==  AttributeName[intIndex])
{
mstrAnswerTitle = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTitle);
}
else if (convMicroteachCaseQuantitySenateItems.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerId);
}
else if (convMicroteachCaseQuantitySenateItems.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerName);
}
else if (convMicroteachCaseQuantitySenateItems.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerNameWithId);
}
else if (convMicroteachCaseQuantitySenateItems.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateIp);
}
else if (convMicroteachCaseQuantitySenateItems.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserNameWithUserId);
}
else if (convMicroteachCaseQuantitySenateItems.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserTypeId);
}
else if (convMicroteachCaseQuantitySenateItems.IsAccess  ==  AttributeName[intIndex])
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IsAccess);
}
else if (convMicroteachCaseQuantitySenateItems.IsAccessC  ==  AttributeName[intIndex])
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IsAccessC);
}
else if (convMicroteachCaseQuantitySenateItems.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UpdDate);
}
else if (convMicroteachCaseQuantitySenateItems.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UpdUser);
}
else if (convMicroteachCaseQuantitySenateItems.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdAppraiseType);
}
else if (convMicroteachCaseQuantitySenateItems.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AppraiseTypeName);
}
else if (convMicroteachCaseQuantitySenateItems.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.FuncModuleId);
}
else if (convMicroteachCaseQuantitySenateItems.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserKindId);
}
else if (convMicroteachCaseQuantitySenateItems.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserKindName);
}
else if (convMicroteachCaseQuantitySenateItems.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserTypeName);
}
else if (convMicroteachCaseQuantitySenateItems.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.FuncModuleName);
}
else if (convMicroteachCaseQuantitySenateItems.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdXzCollege);
}
else if (convMicroteachCaseQuantitySenateItems.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeNameA);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdMicroteachCase);
}
}
/// <summary>
/// 微格教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseID
{
get
{
return mstrMicroteachCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseID = value;
}
else
{
 mstrMicroteachCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
}
}
/// <summary>
/// 微格教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseName
{
get
{
return mstrMicroteachCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseName = value;
}
else
{
 mstrMicroteachCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.MicroteachCaseName);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemName);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateScore);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserName);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeID
{
get
{
return mstrCollegeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeID = value;
}
else
{
 mstrCollegeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeID);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeName);
}
}
/// <summary>
/// 量化评价主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateTheme
{
get
{
return mstrSenateTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateTheme = value;
}
else
{
 mstrSenateTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTheme);
}
}
/// <summary>
/// 评价内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateContent
{
get
{
return mstrSenateContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateContent = value;
}
else
{
 mstrSenateContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateContent);
}
}
/// <summary>
/// 评价日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateDate
{
get
{
return mstrSenateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateDate = value;
}
else
{
 mstrSenateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateDate);
}
}
/// <summary>
/// 评价时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateTime
{
get
{
return mstrSenateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateTime = value;
}
else
{
 mstrSenateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTime);
}
}
/// <summary>
/// 评价分数(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? SenateTotalScore
{
get
{
return mfltSenateTotalScore;
}
set
{
 mfltSenateTotalScore = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateTotalScore);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerModeId);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTypeId);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.GridTitle);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionIndex);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionNo);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionTypeId);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerModeName);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerNum);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTypeName);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.QuestionTypeName);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerIndex);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AnswerTitle);
}
}
/// <summary>
/// 拥有者Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId
{
get
{
return mstrOwnerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId = value;
}
else
{
 mstrOwnerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerId);
}
}
/// <summary>
/// 拥有者姓名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerName
{
get
{
return mstrOwnerName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerName = value;
}
else
{
 mstrOwnerName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerName);
}
}
/// <summary>
/// 拥有者名称附Id(说明:;字段类型:varchar;字段长度:51;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerNameWithId
{
get
{
return mstrOwnerNameWithId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerNameWithId = value;
}
else
{
 mstrOwnerNameWithId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.OwnerNameWithId);
}
}
/// <summary>
/// 评议Ip(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateIp
{
get
{
return mstrSenateIp;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateIp = value;
}
else
{
 mstrSenateIp = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.SenateIp);
}
}
/// <summary>
/// UserNameWithUserId(说明:;字段类型:varchar;字段长度:51;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserNameWithUserId
{
get
{
return mstrUserNameWithUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserNameWithUserId = value;
}
else
{
 mstrUserNameWithUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserNameWithUserId);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserTypeId);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IsAccess);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IsAccessC);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UpdDate);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UpdUser);
}
}
/// <summary>
/// 评议类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAppraiseType
{
get
{
return mstrIdAppraiseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAppraiseType = value;
}
else
{
 mstrIdAppraiseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdAppraiseType);
}
}
/// <summary>
/// 评议类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeName
{
get
{
return mstrAppraiseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeName = value;
}
else
{
 mstrAppraiseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.AppraiseTypeName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.FuncModuleId);
}
}
/// <summary>
/// 用户类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindId
{
get
{
return mstrUserKindId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindId = value;
}
else
{
 mstrUserKindId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserKindId);
}
}
/// <summary>
/// 用户类别名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindName
{
get
{
return mstrUserKindName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindName = value;
}
else
{
 mstrUserKindName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserKindName);
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
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.UserTypeName);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.FuncModuleName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.IdXzCollege);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCaseQuantitySenateItems.CollegeNameA);
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
 /// 微格量化评价详细(vMicroteachCaseQuantitySenateItems)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachCaseQuantitySenateItems
{
public const string _CurrTabName = "vMicroteachCaseQuantitySenateItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenateItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenateItem", "IdmicroteachCaseQuantitySenate", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "IdSenateGaugeItem", "senateGaugeItemID", "senateGaugeItemName", "senateGaugeItemNameWithOrder", "senateGaugeItemDesc", "senateGaugeItemMemo", "senateGaugeItemWeight", "SenateScore", "IdSenateGaugeSubItem", "senateGaugeSubItemID", "senateGaugeSubItemName", "senateGaugeSubItemDesc", "senateGaugeSubItemMemo", "senateGaugeSubItemScore", "UserId", "UserName", "CollegeID", "CollegeName", "SenateTheme", "SenateContent", "SenateDate", "SenateTime", "SenateTotalScore", "AnswerModeId", "AnswerTypeId", "GridTitle", "QuestionIndex", "QuestionNo", "QuestionTypeId", "AnswerModeName", "AnswerNum", "AnswerTypeName", "QuestionTypeName", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IdSenateGaugeVersion", "AnswerIndex", "AnswerTitle", "OwnerId", "OwnerName", "OwnerNameWithId", "SenateIp", "UserNameWithUserId", "UserTypeId", "IsAccess", "IsAccessC", "UpdDate", "UpdUser", "IdAppraiseType", "AppraiseTypeName", "FuncModuleId", "UserKindId", "UserKindName", "UserTypeName", "FuncModuleName", "IdXzCollege", "CollegeNameA"};
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
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"MicroteachCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseID = "MicroteachCaseID";    //微格教学案例ID

 /// <summary>
 /// 常量:"MicroteachCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseName = "MicroteachCaseName";    //微格教学案例名称

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
 /// 常量:"senateGaugeItemNameWithOrder"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemNameWithOrder = "senateGaugeItemNameWithOrder";    //量表指标名称WithOrder

 /// <summary>
 /// 常量:"senateGaugeItemDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemDesc = "senateGaugeItemDesc";    //量表指标说明

 /// <summary>
 /// 常量:"senateGaugeItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemMemo = "senateGaugeItemMemo";    //备注

 /// <summary>
 /// 常量:"senateGaugeItemWeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemWeight = "senateGaugeItemWeight";    //量表指标权重

 /// <summary>
 /// 常量:"SenateScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateScore = "SenateScore";    //指标得分

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
 /// 常量:"senateGaugeSubItemDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemDesc = "senateGaugeSubItemDesc";    //量表指标子项说明

 /// <summary>
 /// 常量:"senateGaugeSubItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemMemo = "senateGaugeSubItemMemo";    //量表指标子项备注

 /// <summary>
 /// 常量:"senateGaugeSubItemScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemScore = "senateGaugeSubItemScore";    //量表指标子项分数

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"SenateTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateTheme = "SenateTheme";    //量化评价主题

 /// <summary>
 /// 常量:"SenateContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateContent = "SenateContent";    //评价内容

 /// <summary>
 /// 常量:"SenateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateDate = "SenateDate";    //评价日期

 /// <summary>
 /// 常量:"SenateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateTime = "SenateTime";    //评价时间

 /// <summary>
 /// 常量:"SenateTotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateTotalScore = "SenateTotalScore";    //评价分数

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
 /// 常量:"AnswerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeName = "AnswerTypeName";    //答案类型名

 /// <summary>
 /// 常量:"QuestionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName = "QuestionTypeName";    //题目类型名

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
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"AnswerIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIndex = "AnswerIndex";    //问答序号

 /// <summary>
 /// 常量:"AnswerTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTitle = "AnswerTitle";    //答案标题

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"SenateIp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateIp = "SenateIp";    //评议Ip

 /// <summary>
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

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

 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName = "AppraiseTypeName";    //评议类型名称

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"UserKindId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindId = "UserKindId";    //用户类别Id

 /// <summary>
 /// 常量:"UserKindName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindName = "UserKindName";    //用户类别名

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}