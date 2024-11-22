
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerVerEN
 表名:qa_AnswerVer(01120756)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表qa_AnswerVer的关键字(AnswerVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerVId_qa_AnswerVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngAnswerVId">表关键字</param>
public K_AnswerVId_qa_AnswerVer(long lngAnswerVId)
{
if (IsValid(lngAnswerVId)) Value = lngAnswerVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngAnswerVId)
{
if (lngAnswerVId == 0) return false;
if (lngAnswerVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AnswerVId_qa_AnswerVer]类型的对象</returns>
public static implicit operator K_AnswerVId_qa_AnswerVer(long value)
{
return new K_AnswerVId_qa_AnswerVer(value);
}
}
 /// <summary>
 /// 答疑回答历史V(qa_AnswerVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsqa_AnswerVerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "qa_AnswerVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"AnswerVId", "AnswerId", "QuestionsId", "AnswerContent", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "IsRecommend", "TopicId", "AnswerTypeId", "IsSubmit", "UpdUser", "UpdDate", "Memo"};

protected long mlngAnswerVId;    //问答历史主键
protected string mstrAnswerId;    //回答Id
protected string mstrQuestionsId;    //提问Id
protected string mstrAnswerContent;    //答案内容
protected float? mfltScore;    //评分
protected string mstrScoreType;    //评分类型
protected bool mbolIsRight;    //是否正确
protected string mstrParentId;    //父节点Id
protected int? mintVoteCount;    //点赞计数
protected bool mbolIsRecommend;    //是否推荐
protected string mstrTopicId;    //主题Id
protected string mstrAnswerTypeId;    //答案类型ID
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsqa_AnswerVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngAnswerVId">关键字:问答历史主键</param>
public clsqa_AnswerVerEN(long lngAnswerVId)
 {
 if (lngAnswerVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngAnswerVId = lngAnswerVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerVId");
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
if (strAttributeName  ==  conqa_AnswerVer.AnswerVId)
{
return mlngAnswerVId;
}
else if (strAttributeName  ==  conqa_AnswerVer.AnswerId)
{
return mstrAnswerId;
}
else if (strAttributeName  ==  conqa_AnswerVer.QuestionsId)
{
return mstrQuestionsId;
}
else if (strAttributeName  ==  conqa_AnswerVer.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  conqa_AnswerVer.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conqa_AnswerVer.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  conqa_AnswerVer.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  conqa_AnswerVer.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conqa_AnswerVer.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conqa_AnswerVer.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  conqa_AnswerVer.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  conqa_AnswerVer.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  conqa_AnswerVer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conqa_AnswerVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conqa_AnswerVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conqa_AnswerVer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conqa_AnswerVer.AnswerVId)
{
mlngAnswerVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.AnswerVId);
}
else if (strAttributeName  ==  conqa_AnswerVer.AnswerId)
{
mstrAnswerId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.AnswerId);
}
else if (strAttributeName  ==  conqa_AnswerVer.QuestionsId)
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.QuestionsId);
}
else if (strAttributeName  ==  conqa_AnswerVer.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.AnswerContent);
}
else if (strAttributeName  ==  conqa_AnswerVer.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.Score);
}
else if (strAttributeName  ==  conqa_AnswerVer.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.ScoreType);
}
else if (strAttributeName  ==  conqa_AnswerVer.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.IsRight);
}
else if (strAttributeName  ==  conqa_AnswerVer.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.ParentId);
}
else if (strAttributeName  ==  conqa_AnswerVer.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.VoteCount);
}
else if (strAttributeName  ==  conqa_AnswerVer.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.IsRecommend);
}
else if (strAttributeName  ==  conqa_AnswerVer.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.TopicId);
}
else if (strAttributeName  ==  conqa_AnswerVer.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.AnswerTypeId);
}
else if (strAttributeName  ==  conqa_AnswerVer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.IsSubmit);
}
else if (strAttributeName  ==  conqa_AnswerVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.UpdUser);
}
else if (strAttributeName  ==  conqa_AnswerVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.UpdDate);
}
else if (strAttributeName  ==  conqa_AnswerVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conqa_AnswerVer.AnswerVId  ==  AttributeName[intIndex])
{
return mlngAnswerVId;
}
else if (conqa_AnswerVer.AnswerId  ==  AttributeName[intIndex])
{
return mstrAnswerId;
}
else if (conqa_AnswerVer.QuestionsId  ==  AttributeName[intIndex])
{
return mstrQuestionsId;
}
else if (conqa_AnswerVer.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (conqa_AnswerVer.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conqa_AnswerVer.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (conqa_AnswerVer.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (conqa_AnswerVer.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conqa_AnswerVer.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conqa_AnswerVer.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (conqa_AnswerVer.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (conqa_AnswerVer.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (conqa_AnswerVer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conqa_AnswerVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conqa_AnswerVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conqa_AnswerVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conqa_AnswerVer.AnswerVId  ==  AttributeName[intIndex])
{
mlngAnswerVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.AnswerVId);
}
else if (conqa_AnswerVer.AnswerId  ==  AttributeName[intIndex])
{
mstrAnswerId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.AnswerId);
}
else if (conqa_AnswerVer.QuestionsId  ==  AttributeName[intIndex])
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.QuestionsId);
}
else if (conqa_AnswerVer.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.AnswerContent);
}
else if (conqa_AnswerVer.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.Score);
}
else if (conqa_AnswerVer.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.ScoreType);
}
else if (conqa_AnswerVer.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.IsRight);
}
else if (conqa_AnswerVer.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.ParentId);
}
else if (conqa_AnswerVer.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.VoteCount);
}
else if (conqa_AnswerVer.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.IsRecommend);
}
else if (conqa_AnswerVer.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.TopicId);
}
else if (conqa_AnswerVer.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.AnswerTypeId);
}
else if (conqa_AnswerVer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_AnswerVer.IsSubmit);
}
else if (conqa_AnswerVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.UpdUser);
}
else if (conqa_AnswerVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.UpdDate);
}
else if (conqa_AnswerVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conqa_AnswerVer.Memo);
}
}
}

/// <summary>
/// 问答历史主键(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long AnswerVId
{
get
{
return mlngAnswerVId;
}
set
{
 mlngAnswerVId = value;
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.AnswerVId);
}
}
/// <summary>
/// 回答Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerId
{
get
{
return mstrAnswerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerId = value;
}
else
{
 mstrAnswerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.AnswerId);
}
}
/// <summary>
/// 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsId
{
get
{
return mstrQuestionsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsId = value;
}
else
{
 mstrQuestionsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.QuestionsId);
}
}
/// <summary>
/// 答案内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerContent
{
get
{
return mstrAnswerContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerContent = value;
}
else
{
 mstrAnswerContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.AnswerContent);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.Score);
}
}
/// <summary>
/// 评分类型(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreType
{
get
{
return mstrScoreType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreType = value;
}
else
{
 mstrScoreType = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.ScoreType);
}
}
/// <summary>
/// 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRight
{
get
{
return mbolIsRight;
}
set
{
 mbolIsRight = value;
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.IsRight);
}
}
/// <summary>
/// 父节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentId
{
get
{
return mstrParentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentId = value;
}
else
{
 mstrParentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.ParentId);
}
}
/// <summary>
/// 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VoteCount
{
get
{
return mintVoteCount;
}
set
{
 mintVoteCount = value;
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.VoteCount);
}
}
/// <summary>
/// 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecommend
{
get
{
return mbolIsRecommend;
}
set
{
 mbolIsRecommend = value;
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.IsRecommend);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicId
{
get
{
return mstrTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicId = value;
}
else
{
 mstrTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.TopicId);
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
 AddUpdatedFld(conqa_AnswerVer.AnswerTypeId);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(conqa_AnswerVer.IsSubmit);
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
 AddUpdatedFld(conqa_AnswerVer.UpdUser);
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
 AddUpdatedFld(conqa_AnswerVer.UpdDate);
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
 AddUpdatedFld(conqa_AnswerVer.Memo);
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
  return mlngAnswerVId.ToString();
 }
 }
}
 /// <summary>
 /// 答疑回答历史V(qa_AnswerVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conqa_AnswerVer
{
public const string _CurrTabName = "qa_AnswerVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerVId", "AnswerId", "QuestionsId", "AnswerContent", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "IsRecommend", "TopicId", "AnswerTypeId", "IsSubmit", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AnswerVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerVId = "AnswerVId";    //问答历史主键

 /// <summary>
 /// 常量:"AnswerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerId = "AnswerId";    //回答Id

 /// <summary>
 /// 常量:"QuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsId = "QuestionsId";    //提问Id

 /// <summary>
 /// 常量:"AnswerContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerContent = "AnswerContent";    //答案内容

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"ScoreType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreType = "ScoreType";    //评分类型

 /// <summary>
 /// 常量:"IsRight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRight = "IsRight";    //是否正确

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

 /// <summary>
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}