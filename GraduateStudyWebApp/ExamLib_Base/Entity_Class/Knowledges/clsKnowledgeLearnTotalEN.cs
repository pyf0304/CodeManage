
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeLearnTotalEN
 表名:KnowledgeLearnTotal(01120155)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表KnowledgeLearnTotal的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_KnowledgeLearnTotal
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_KnowledgeLearnTotal(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_KnowledgeLearnTotal]类型的对象</returns>
public static implicit operator K_mId_KnowledgeLearnTotal(long value)
{
return new K_mId_KnowledgeLearnTotal(value);
}
}
 /// <summary>
 /// 知识点学习汇总表(KnowledgeLearnTotal)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKnowledgeLearnTotalEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KnowledgeLearnTotal"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"mId", "UserId", "MasterDegree", "LearnCount", "CourseKnowledgeId", "SuccessCount", "FailCount", "ContinuousSuccessCount", "ContinuousFailCount", "LastLearnDate", "RecommendedNextReviewDate", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected double mdblMasterDegree;    //掌握程度
protected int? mintLearnCount;    //学习次数
protected string mstrCourseKnowledgeId;    //知识点Id
protected int? mintSuccessCount;    //成功次数
protected int? mintFailCount;    //失败次数
protected int mintContinuousSuccessCount;    //连续成功次数
protected int mintContinuousFailCount;    //连续失败次数
protected string mstrLastLearnDate;    //最后学习日期
protected string mstrRecommendedNextReviewDate;    //推荐下次复习日期
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKnowledgeLearnTotalEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsKnowledgeLearnTotalEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conKnowledgeLearnTotal.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.MasterDegree)
{
return mdblMasterDegree;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.LearnCount)
{
return mintLearnCount;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.SuccessCount)
{
return mintSuccessCount;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.FailCount)
{
return mintFailCount;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.ContinuousSuccessCount)
{
return mintContinuousSuccessCount;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.ContinuousFailCount)
{
return mintContinuousFailCount;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.LastLearnDate)
{
return mstrLastLearnDate;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.RecommendedNextReviewDate)
{
return mstrRecommendedNextReviewDate;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conKnowledgeLearnTotal.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.mId);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.UserId);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.MasterDegree)
{
mdblMasterDegree = TransNullToDouble(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.MasterDegree);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.LearnCount)
{
mintLearnCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.LearnCount);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.CourseKnowledgeId);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.SuccessCount)
{
mintSuccessCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.SuccessCount);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.FailCount)
{
mintFailCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.FailCount);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.ContinuousSuccessCount)
{
mintContinuousSuccessCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.ContinuousSuccessCount);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.ContinuousFailCount)
{
mintContinuousFailCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.ContinuousFailCount);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.LastLearnDate)
{
mstrLastLearnDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.LastLearnDate);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.RecommendedNextReviewDate)
{
mstrRecommendedNextReviewDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.RecommendedNextReviewDate);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.CourseId);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.UpdDate);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.UpdUser);
}
else if (strAttributeName  ==  conKnowledgeLearnTotal.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conKnowledgeLearnTotal.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conKnowledgeLearnTotal.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conKnowledgeLearnTotal.MasterDegree  ==  AttributeName[intIndex])
{
return mdblMasterDegree;
}
else if (conKnowledgeLearnTotal.LearnCount  ==  AttributeName[intIndex])
{
return mintLearnCount;
}
else if (conKnowledgeLearnTotal.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (conKnowledgeLearnTotal.SuccessCount  ==  AttributeName[intIndex])
{
return mintSuccessCount;
}
else if (conKnowledgeLearnTotal.FailCount  ==  AttributeName[intIndex])
{
return mintFailCount;
}
else if (conKnowledgeLearnTotal.ContinuousSuccessCount  ==  AttributeName[intIndex])
{
return mintContinuousSuccessCount;
}
else if (conKnowledgeLearnTotal.ContinuousFailCount  ==  AttributeName[intIndex])
{
return mintContinuousFailCount;
}
else if (conKnowledgeLearnTotal.LastLearnDate  ==  AttributeName[intIndex])
{
return mstrLastLearnDate;
}
else if (conKnowledgeLearnTotal.RecommendedNextReviewDate  ==  AttributeName[intIndex])
{
return mstrRecommendedNextReviewDate;
}
else if (conKnowledgeLearnTotal.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conKnowledgeLearnTotal.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conKnowledgeLearnTotal.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conKnowledgeLearnTotal.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conKnowledgeLearnTotal.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.mId);
}
else if (conKnowledgeLearnTotal.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.UserId);
}
else if (conKnowledgeLearnTotal.MasterDegree  ==  AttributeName[intIndex])
{
mdblMasterDegree = TransNullToDouble(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.MasterDegree);
}
else if (conKnowledgeLearnTotal.LearnCount  ==  AttributeName[intIndex])
{
mintLearnCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.LearnCount);
}
else if (conKnowledgeLearnTotal.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.CourseKnowledgeId);
}
else if (conKnowledgeLearnTotal.SuccessCount  ==  AttributeName[intIndex])
{
mintSuccessCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.SuccessCount);
}
else if (conKnowledgeLearnTotal.FailCount  ==  AttributeName[intIndex])
{
mintFailCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.FailCount);
}
else if (conKnowledgeLearnTotal.ContinuousSuccessCount  ==  AttributeName[intIndex])
{
mintContinuousSuccessCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.ContinuousSuccessCount);
}
else if (conKnowledgeLearnTotal.ContinuousFailCount  ==  AttributeName[intIndex])
{
mintContinuousFailCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnTotal.ContinuousFailCount);
}
else if (conKnowledgeLearnTotal.LastLearnDate  ==  AttributeName[intIndex])
{
mstrLastLearnDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.LastLearnDate);
}
else if (conKnowledgeLearnTotal.RecommendedNextReviewDate  ==  AttributeName[intIndex])
{
mstrRecommendedNextReviewDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.RecommendedNextReviewDate);
}
else if (conKnowledgeLearnTotal.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.CourseId);
}
else if (conKnowledgeLearnTotal.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.UpdDate);
}
else if (conKnowledgeLearnTotal.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.UpdUser);
}
else if (conKnowledgeLearnTotal.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeLearnTotal.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.mId);
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
 AddUpdatedFld(conKnowledgeLearnTotal.UserId);
}
}
/// <summary>
/// 掌握程度(说明:;字段类型:numeric;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double MasterDegree
{
get
{
return mdblMasterDegree;
}
set
{
 mdblMasterDegree = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.MasterDegree);
}
}
/// <summary>
/// 学习次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LearnCount
{
get
{
return mintLearnCount;
}
set
{
 mintLearnCount = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.LearnCount);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.CourseKnowledgeId);
}
}
/// <summary>
/// 成功次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SuccessCount
{
get
{
return mintSuccessCount;
}
set
{
 mintSuccessCount = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.SuccessCount);
}
}
/// <summary>
/// 失败次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FailCount
{
get
{
return mintFailCount;
}
set
{
 mintFailCount = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.FailCount);
}
}
/// <summary>
/// 连续成功次数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ContinuousSuccessCount
{
get
{
return mintContinuousSuccessCount;
}
set
{
 mintContinuousSuccessCount = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.ContinuousSuccessCount);
}
}
/// <summary>
/// 连续失败次数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ContinuousFailCount
{
get
{
return mintContinuousFailCount;
}
set
{
 mintContinuousFailCount = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.ContinuousFailCount);
}
}
/// <summary>
/// 最后学习日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastLearnDate
{
get
{
return mstrLastLearnDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastLearnDate = value;
}
else
{
 mstrLastLearnDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.LastLearnDate);
}
}
/// <summary>
/// 推荐下次复习日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedNextReviewDate
{
get
{
return mstrRecommendedNextReviewDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedNextReviewDate = value;
}
else
{
 mstrRecommendedNextReviewDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.RecommendedNextReviewDate);
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
 AddUpdatedFld(conKnowledgeLearnTotal.CourseId);
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
 AddUpdatedFld(conKnowledgeLearnTotal.UpdDate);
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
 AddUpdatedFld(conKnowledgeLearnTotal.UpdUser);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnTotal.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 知识点学习汇总表(KnowledgeLearnTotal)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKnowledgeLearnTotal
{
public const string _CurrTabName = "KnowledgeLearnTotal"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "MasterDegree", "LearnCount", "CourseKnowledgeId", "SuccessCount", "FailCount", "ContinuousSuccessCount", "ContinuousFailCount", "LastLearnDate", "RecommendedNextReviewDate", "CourseId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"MasterDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterDegree = "MasterDegree";    //掌握程度

 /// <summary>
 /// 常量:"LearnCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnCount = "LearnCount";    //学习次数

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"SuccessCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuccessCount = "SuccessCount";    //成功次数

 /// <summary>
 /// 常量:"FailCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FailCount = "FailCount";    //失败次数

 /// <summary>
 /// 常量:"ContinuousSuccessCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContinuousSuccessCount = "ContinuousSuccessCount";    //连续成功次数

 /// <summary>
 /// 常量:"ContinuousFailCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContinuousFailCount = "ContinuousFailCount";    //连续失败次数

 /// <summary>
 /// 常量:"LastLearnDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastLearnDate = "LastLearnDate";    //最后学习日期

 /// <summary>
 /// 常量:"RecommendedNextReviewDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedNextReviewDate = "RecommendedNextReviewDate";    //推荐下次复习日期

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}