
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseQuantitySenateItemsEN
 表名:vVideoResCaseQuantitySenateItems(01120447)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库(VideoResLib)
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
 /// 表vVideoResCaseQuantitySenateItems的关键字(IdmicroteachCaseQuantitySenateItem)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenateItem_vVideoResCaseQuantitySenateItems
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
public K_IdmicroteachCaseQuantitySenateItem_vVideoResCaseQuantitySenateItems(long lngIdmicroteachCaseQuantitySenateItem)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenateItem_vVideoResCaseQuantitySenateItems]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenateItem_vVideoResCaseQuantitySenateItems(long value)
{
return new K_IdmicroteachCaseQuantitySenateItem_vVideoResCaseQuantitySenateItems(value);
}
}
 /// <summary>
 /// v视频资源量化评价详细(vVideoResCaseQuantitySenateItems)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoResCaseQuantitySenateItemsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoResCaseQuantitySenateItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenateItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 61;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenateItem", "IdmicroteachCaseQuantitySenate", "VideoResCaseID", "VideoResCaseName", "IdAppraiseType", "AppraiseTypeName", "UserId", "IdMicroteachCase", "CollegeID", "CollegeName", "CourseId", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "FuncModuleName", "FuncModuleId", "SenateIp", "UserTypeName", "UserName", "UserNameWithUserId", "UserKindId", "UserKindName", "IdXzCollege", "IdXzMajor", "CollegeNameA", "SenateScore", "IdSenateGaugeItem", "senateGaugeItemID", "senateGaugeItemName", "senateGaugeVersionName", "senateGaugeItemDesc", "senateGaugeItemWeight", "AnswerModeId", "AnswerTypeId", "GridTitle", "QuestionIndex", "senateGaugeVersionID", "QuestionNo", "QuestionTypeId", "senateGaugeVersionTtlScore", "AnswerTypeName", "AnswerModeName", "senateGaugeItemMemo", "QuestionTypeName", "AnswerNum", "senateGaugeItemNameWithOrder", "IdSenateGaugeSubItem", "senateGaugeSubItemID", "senateGaugeSubItemName", "senateGaugeSubItemScore", "senateGaugeSubItemDesc", "AnswerTitle", "AnswerIndex", "senateGaugeSubItemMemo", "IsAccess", "IsAccessC", "UpdDate", "UpdUser"};

protected long mlngIdmicroteachCaseQuantitySenateItem;    //微格量化评价指标流水号
protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrVideoResCaseID;    //视频资源案例ID
protected string mstrVideoResCaseName;    //视频资源案例名称
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrUserId;    //用户ID
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCourseId;    //课程Id
protected string mstrSenateTheme;    //量化评价主题
protected string mstrSenateContent;    //评价内容
protected float? mfltSenateTotalScore;    //评价分数
protected string mstrSenateDate;    //评价日期
protected string mstrSenateTime;    //评价时间
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrSenateIp;    //评议Ip
protected string mstrUserTypeName;    //用户类型名称
protected string mstrUserName;    //用户名
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrCollegeNameA;    //学院名称简写
protected float mfltSenateScore;    //指标得分
protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected string mstrsenateGaugeItemID;    //量表指标ID
protected string mstrsenateGaugeItemName;    //量表指标名称
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
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrAnswerModeName;    //答案模式名称
protected string mstrsenateGaugeItemMemo;    //备注
protected string mstrQuestionTypeName;    //题目类型名
protected int? mintAnswerNum;    //答案数
protected string mstrsenateGaugeItemNameWithOrder;    //量表指标名称WithOrder
protected string mstrIdSenateGaugeSubItem;    //量表指标子项流水号
protected string mstrsenateGaugeSubItemID;    //量表指标子项ID
protected string mstrsenateGaugeSubItemName;    //量表指标子项名称
protected float? mfltsenateGaugeSubItemScore;    //量表指标子项分数
protected string mstrsenateGaugeSubItemDesc;    //量表指标子项说明
protected string mstrAnswerTitle;    //答案标题
protected int? mintAnswerIndex;    //问答序号
protected string mstrsenateGaugeSubItemMemo;    //量表指标子项备注
protected bool mbolIsAccess;    //IsAccess
protected bool mbolIsAccessC;    //IsAccessC
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvVideoResCaseQuantitySenateItemsEN()
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
public clsvVideoResCaseQuantitySenateItemsEN(long lngIdmicroteachCaseQuantitySenateItem)
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
if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem)
{
return mlngIdmicroteachCaseQuantitySenateItem;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.VideoResCaseID)
{
return mstrVideoResCaseID;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.VideoResCaseName)
{
return mstrVideoResCaseName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateScore)
{
return mfltSenateScore;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemID)
{
return mstrsenateGaugeItemID;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemName)
{
return mstrsenateGaugeItemName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemDesc)
{
return mstrsenateGaugeItemDesc;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemWeight)
{
return mfltsenateGaugeItemWeight;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemMemo)
{
return mstrsenateGaugeItemMemo;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerNum)
{
return mintAnswerNum;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder)
{
return mstrsenateGaugeItemNameWithOrder;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem)
{
return mstrIdSenateGaugeSubItem;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemID)
{
return mstrsenateGaugeSubItemID;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemName)
{
return mstrsenateGaugeSubItemName;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore)
{
return mfltsenateGaugeSubItemScore;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc)
{
return mstrsenateGaugeSubItemDesc;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerTitle)
{
return mstrAnswerTitle;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo)
{
return mstrsenateGaugeSubItemMemo;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IsAccess)
{
return mbolIsAccess;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IsAccessC)
{
return mbolIsAccessC;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem)
{
mlngIdmicroteachCaseQuantitySenateItem = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.VideoResCaseID)
{
mstrVideoResCaseID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.VideoResCaseID);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.VideoResCaseName)
{
mstrVideoResCaseName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.VideoResCaseName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdAppraiseType);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AppraiseTypeName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserId);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdMicroteachCase);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeID);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CourseId);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTheme);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateContent);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTotalScore);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateDate);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTime);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.FuncModuleName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.FuncModuleId);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateIp);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserTypeName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserNameWithUserId);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserKindId);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserKindName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdXzCollege);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdXzMajor);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeNameA);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.SenateScore)
{
mfltSenateScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateScore);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeItem);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemID)
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemID);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemName)
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemDesc)
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemDesc);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemWeight)
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemWeight);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerModeId);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTypeId);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.GridTitle);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionIndex);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionID);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionNo);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionTypeId);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTypeName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerModeName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemMemo)
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemMemo);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionTypeName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerNum)
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerNum);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder)
{
mstrsenateGaugeItemNameWithOrder = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem)
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemID)
{
mstrsenateGaugeSubItemID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemID);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemName)
{
mstrsenateGaugeSubItemName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemName);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore)
{
mfltsenateGaugeSubItemScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc)
{
mstrsenateGaugeSubItemDesc = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerTitle)
{
mstrAnswerTitle = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTitle);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.AnswerIndex)
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerIndex);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo)
{
mstrsenateGaugeSubItemMemo = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IsAccess)
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IsAccess);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.IsAccessC)
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IsAccessC);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UpdDate);
}
else if (strAttributeName  ==  convVideoResCaseQuantitySenateItems.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenateItem;
}
else if (convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convVideoResCaseQuantitySenateItems.VideoResCaseID  ==  AttributeName[intIndex])
{
return mstrVideoResCaseID;
}
else if (convVideoResCaseQuantitySenateItems.VideoResCaseName  ==  AttributeName[intIndex])
{
return mstrVideoResCaseName;
}
else if (convVideoResCaseQuantitySenateItems.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convVideoResCaseQuantitySenateItems.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convVideoResCaseQuantitySenateItems.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convVideoResCaseQuantitySenateItems.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convVideoResCaseQuantitySenateItems.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convVideoResCaseQuantitySenateItems.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convVideoResCaseQuantitySenateItems.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convVideoResCaseQuantitySenateItems.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convVideoResCaseQuantitySenateItems.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convVideoResCaseQuantitySenateItems.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convVideoResCaseQuantitySenateItems.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convVideoResCaseQuantitySenateItems.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convVideoResCaseQuantitySenateItems.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convVideoResCaseQuantitySenateItems.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convVideoResCaseQuantitySenateItems.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convVideoResCaseQuantitySenateItems.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convVideoResCaseQuantitySenateItems.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convVideoResCaseQuantitySenateItems.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convVideoResCaseQuantitySenateItems.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convVideoResCaseQuantitySenateItems.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convVideoResCaseQuantitySenateItems.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convVideoResCaseQuantitySenateItems.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convVideoResCaseQuantitySenateItems.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convVideoResCaseQuantitySenateItems.SenateScore  ==  AttributeName[intIndex])
{
return mfltSenateScore;
}
else if (convVideoResCaseQuantitySenateItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemID;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemName;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemDesc;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
return mfltsenateGaugeItemWeight;
}
else if (convVideoResCaseQuantitySenateItems.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convVideoResCaseQuantitySenateItems.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convVideoResCaseQuantitySenateItems.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convVideoResCaseQuantitySenateItems.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convVideoResCaseQuantitySenateItems.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convVideoResCaseQuantitySenateItems.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convVideoResCaseQuantitySenateItems.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convVideoResCaseQuantitySenateItems.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemMemo;
}
else if (convVideoResCaseQuantitySenateItems.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convVideoResCaseQuantitySenateItems.AnswerNum  ==  AttributeName[intIndex])
{
return mintAnswerNum;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemNameWithOrder;
}
else if (convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeSubItem;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemID;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemName;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeSubItemScore;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemDesc;
}
else if (convVideoResCaseQuantitySenateItems.AnswerTitle  ==  AttributeName[intIndex])
{
return mstrAnswerTitle;
}
else if (convVideoResCaseQuantitySenateItems.AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeSubItemMemo;
}
else if (convVideoResCaseQuantitySenateItems.IsAccess  ==  AttributeName[intIndex])
{
return mbolIsAccess;
}
else if (convVideoResCaseQuantitySenateItems.IsAccessC  ==  AttributeName[intIndex])
{
return mbolIsAccessC;
}
else if (convVideoResCaseQuantitySenateItems.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convVideoResCaseQuantitySenateItems.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenateItem = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
}
else if (convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
else if (convVideoResCaseQuantitySenateItems.VideoResCaseID  ==  AttributeName[intIndex])
{
mstrVideoResCaseID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.VideoResCaseID);
}
else if (convVideoResCaseQuantitySenateItems.VideoResCaseName  ==  AttributeName[intIndex])
{
mstrVideoResCaseName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.VideoResCaseName);
}
else if (convVideoResCaseQuantitySenateItems.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdAppraiseType);
}
else if (convVideoResCaseQuantitySenateItems.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AppraiseTypeName);
}
else if (convVideoResCaseQuantitySenateItems.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserId);
}
else if (convVideoResCaseQuantitySenateItems.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdMicroteachCase);
}
else if (convVideoResCaseQuantitySenateItems.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeID);
}
else if (convVideoResCaseQuantitySenateItems.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeName);
}
else if (convVideoResCaseQuantitySenateItems.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CourseId);
}
else if (convVideoResCaseQuantitySenateItems.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTheme);
}
else if (convVideoResCaseQuantitySenateItems.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateContent);
}
else if (convVideoResCaseQuantitySenateItems.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTotalScore);
}
else if (convVideoResCaseQuantitySenateItems.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateDate);
}
else if (convVideoResCaseQuantitySenateItems.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTime);
}
else if (convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion);
}
else if (convVideoResCaseQuantitySenateItems.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.FuncModuleName);
}
else if (convVideoResCaseQuantitySenateItems.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.FuncModuleId);
}
else if (convVideoResCaseQuantitySenateItems.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateIp);
}
else if (convVideoResCaseQuantitySenateItems.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserTypeName);
}
else if (convVideoResCaseQuantitySenateItems.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserName);
}
else if (convVideoResCaseQuantitySenateItems.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserNameWithUserId);
}
else if (convVideoResCaseQuantitySenateItems.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserKindId);
}
else if (convVideoResCaseQuantitySenateItems.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserKindName);
}
else if (convVideoResCaseQuantitySenateItems.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdXzCollege);
}
else if (convVideoResCaseQuantitySenateItems.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdXzMajor);
}
else if (convVideoResCaseQuantitySenateItems.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeNameA);
}
else if (convVideoResCaseQuantitySenateItems.SenateScore  ==  AttributeName[intIndex])
{
mfltSenateScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateScore);
}
else if (convVideoResCaseQuantitySenateItems.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeItem);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemID);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemName);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionName);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemDesc = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemDesc);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemWeight);
}
else if (convVideoResCaseQuantitySenateItems.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerModeId);
}
else if (convVideoResCaseQuantitySenateItems.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTypeId);
}
else if (convVideoResCaseQuantitySenateItems.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.GridTitle);
}
else if (convVideoResCaseQuantitySenateItems.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionIndex);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionID);
}
else if (convVideoResCaseQuantitySenateItems.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionNo);
}
else if (convVideoResCaseQuantitySenateItems.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionTypeId);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore);
}
else if (convVideoResCaseQuantitySenateItems.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTypeName);
}
else if (convVideoResCaseQuantitySenateItems.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerModeName);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemMemo = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemMemo);
}
else if (convVideoResCaseQuantitySenateItems.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionTypeName);
}
else if (convVideoResCaseQuantitySenateItems.AnswerNum  ==  AttributeName[intIndex])
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerNum);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemNameWithOrder = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
}
else if (convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeSubItem = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemID  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemID = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemID);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemName = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemName);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeSubItemScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemDesc = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc);
}
else if (convVideoResCaseQuantitySenateItems.AnswerTitle  ==  AttributeName[intIndex])
{
mstrAnswerTitle = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTitle);
}
else if (convVideoResCaseQuantitySenateItems.AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerIndex);
}
else if (convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeSubItemMemo = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo);
}
else if (convVideoResCaseQuantitySenateItems.IsAccess  ==  AttributeName[intIndex])
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IsAccess);
}
else if (convVideoResCaseQuantitySenateItems.IsAccessC  ==  AttributeName[intIndex])
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IsAccessC);
}
else if (convVideoResCaseQuantitySenateItems.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UpdDate);
}
else if (convVideoResCaseQuantitySenateItems.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UpdUser);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
}
}
/// <summary>
/// 视频资源案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseID
{
get
{
return mstrVideoResCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseID = value;
}
else
{
 mstrVideoResCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.VideoResCaseID);
}
}
/// <summary>
/// 视频资源案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseName
{
get
{
return mstrVideoResCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseName = value;
}
else
{
 mstrVideoResCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.VideoResCaseName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdAppraiseType);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AppraiseTypeName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserId);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdMicroteachCase);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeID);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeName);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CourseId);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTheme);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateContent);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTotalScore);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateDate);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateTime);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.FuncModuleName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.FuncModuleId);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateIp);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserTypeName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserNameWithUserId);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserKindId);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UserKindName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdXzCollege);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdXzMajor);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.CollegeNameA);
}
}
/// <summary>
/// 指标得分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float SenateScore
{
get
{
return mfltSenateScore;
}
set
{
 mfltSenateScore = value;
//记录修改过的字段
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.SenateScore);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeItem);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemID);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemDesc);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemWeight);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerModeId);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTypeId);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.GridTitle);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionIndex);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionID);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionNo);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionTypeId);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTypeName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerModeName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemMemo);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.QuestionTypeName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerNum);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemID);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemName);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerTitle);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.AnswerIndex);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IsAccess);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.IsAccessC);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UpdDate);
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
 AddUpdatedFld(convVideoResCaseQuantitySenateItems.UpdUser);
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
 /// v视频资源量化评价详细(vVideoResCaseQuantitySenateItems)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoResCaseQuantitySenateItems
{
public const string _CurrTabName = "vVideoResCaseQuantitySenateItems"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenateItem"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenateItem", "IdmicroteachCaseQuantitySenate", "VideoResCaseID", "VideoResCaseName", "IdAppraiseType", "AppraiseTypeName", "UserId", "IdMicroteachCase", "CollegeID", "CollegeName", "CourseId", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "FuncModuleName", "FuncModuleId", "SenateIp", "UserTypeName", "UserName", "UserNameWithUserId", "UserKindId", "UserKindName", "IdXzCollege", "IdXzMajor", "CollegeNameA", "SenateScore", "IdSenateGaugeItem", "senateGaugeItemID", "senateGaugeItemName", "senateGaugeVersionName", "senateGaugeItemDesc", "senateGaugeItemWeight", "AnswerModeId", "AnswerTypeId", "GridTitle", "QuestionIndex", "senateGaugeVersionID", "QuestionNo", "QuestionTypeId", "senateGaugeVersionTtlScore", "AnswerTypeName", "AnswerModeName", "senateGaugeItemMemo", "QuestionTypeName", "AnswerNum", "senateGaugeItemNameWithOrder", "IdSenateGaugeSubItem", "senateGaugeSubItemID", "senateGaugeSubItemName", "senateGaugeSubItemScore", "senateGaugeSubItemDesc", "AnswerTitle", "AnswerIndex", "senateGaugeSubItemMemo", "IsAccess", "IsAccessC", "UpdDate", "UpdUser"};
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
 /// 常量:"VideoResCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseID = "VideoResCaseID";    //视频资源案例ID

 /// <summary>
 /// 常量:"VideoResCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseName = "VideoResCaseName";    //视频资源案例名称

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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
 /// 常量:"SenateTotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateTotalScore = "SenateTotalScore";    //评价分数

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
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"SenateIp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateIp = "SenateIp";    //评议Ip

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

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
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

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
 /// 常量:"senateGaugeItemNameWithOrder"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemNameWithOrder = "senateGaugeItemNameWithOrder";    //量表指标名称WithOrder

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
 /// 常量:"senateGaugeSubItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeSubItemMemo = "senateGaugeSubItemMemo";    //量表指标子项备注

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