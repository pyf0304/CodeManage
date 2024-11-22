
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerEN
 表名:qa_Answer(01120641)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:10
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
 /// 表qa_Answer的关键字(AnswerId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerId_qa_Answer
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAnswerId">表关键字</param>
public K_AnswerId_qa_Answer(string strAnswerId)
{
if (IsValid(strAnswerId)) Value = strAnswerId;
else
{
Value = null;
}
}
private static bool IsValid(string strAnswerId)
{
if (string.IsNullOrEmpty(strAnswerId) == true) return false;
if (strAnswerId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AnswerId_qa_Answer]类型的对象</returns>
public static implicit operator K_AnswerId_qa_Answer(string value)
{
return new K_AnswerId_qa_Answer(value);
}
}
 /// <summary>
 /// 答疑回答(qa_Answer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsqa_AnswerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "qa_Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"AnswerId", "QuestionsId", "AnswerContent", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "IsRecommend", "TopicId", "AnswerTypeId", "IsSubmit", "AppraiseCount", "StuScore", "TeaScore", "CreateDate", "IdCurrEduCls", "UpdUser", "UpdDate", "Memo"};

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
protected int? mintAppraiseCount;    //评论数
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrCreateDate;    //建立日期
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsqa_AnswerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAnswerId">关键字:回答Id</param>
public clsqa_AnswerEN(string strAnswerId)
 {
strAnswerId = strAnswerId.Replace("'", "''");
if (strAnswerId.Length > 10)
{
throw new Exception("在表:qa_Answer中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAnswerId)  ==  true)
{
throw new Exception("在表:qa_Answer中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAnswerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAnswerId = strAnswerId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerId");
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
if (strAttributeName  ==  conqa_Answer.AnswerId)
{
return mstrAnswerId;
}
else if (strAttributeName  ==  conqa_Answer.QuestionsId)
{
return mstrQuestionsId;
}
else if (strAttributeName  ==  conqa_Answer.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  conqa_Answer.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conqa_Answer.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  conqa_Answer.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  conqa_Answer.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conqa_Answer.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conqa_Answer.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  conqa_Answer.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  conqa_Answer.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  conqa_Answer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conqa_Answer.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conqa_Answer.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conqa_Answer.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conqa_Answer.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conqa_Answer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conqa_Answer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conqa_Answer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conqa_Answer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conqa_Answer.AnswerId)
{
mstrAnswerId = value.ToString();
 AddUpdatedFld(conqa_Answer.AnswerId);
}
else if (strAttributeName  ==  conqa_Answer.QuestionsId)
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(conqa_Answer.QuestionsId);
}
else if (strAttributeName  ==  conqa_Answer.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conqa_Answer.AnswerContent);
}
else if (strAttributeName  ==  conqa_Answer.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conqa_Answer.Score);
}
else if (strAttributeName  ==  conqa_Answer.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conqa_Answer.ScoreType);
}
else if (strAttributeName  ==  conqa_Answer.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Answer.IsRight);
}
else if (strAttributeName  ==  conqa_Answer.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conqa_Answer.ParentId);
}
else if (strAttributeName  ==  conqa_Answer.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Answer.VoteCount);
}
else if (strAttributeName  ==  conqa_Answer.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Answer.IsRecommend);
}
else if (strAttributeName  ==  conqa_Answer.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conqa_Answer.TopicId);
}
else if (strAttributeName  ==  conqa_Answer.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conqa_Answer.AnswerTypeId);
}
else if (strAttributeName  ==  conqa_Answer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Answer.IsSubmit);
}
else if (strAttributeName  ==  conqa_Answer.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Answer.AppraiseCount);
}
else if (strAttributeName  ==  conqa_Answer.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conqa_Answer.StuScore);
}
else if (strAttributeName  ==  conqa_Answer.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conqa_Answer.TeaScore);
}
else if (strAttributeName  ==  conqa_Answer.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conqa_Answer.CreateDate);
}
else if (strAttributeName  ==  conqa_Answer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conqa_Answer.IdCurrEduCls);
}
else if (strAttributeName  ==  conqa_Answer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conqa_Answer.UpdUser);
}
else if (strAttributeName  ==  conqa_Answer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conqa_Answer.UpdDate);
}
else if (strAttributeName  ==  conqa_Answer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conqa_Answer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conqa_Answer.AnswerId  ==  AttributeName[intIndex])
{
return mstrAnswerId;
}
else if (conqa_Answer.QuestionsId  ==  AttributeName[intIndex])
{
return mstrQuestionsId;
}
else if (conqa_Answer.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (conqa_Answer.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conqa_Answer.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (conqa_Answer.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (conqa_Answer.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conqa_Answer.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conqa_Answer.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (conqa_Answer.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (conqa_Answer.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (conqa_Answer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conqa_Answer.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conqa_Answer.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conqa_Answer.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conqa_Answer.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conqa_Answer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conqa_Answer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conqa_Answer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conqa_Answer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conqa_Answer.AnswerId  ==  AttributeName[intIndex])
{
mstrAnswerId = value.ToString();
 AddUpdatedFld(conqa_Answer.AnswerId);
}
else if (conqa_Answer.QuestionsId  ==  AttributeName[intIndex])
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(conqa_Answer.QuestionsId);
}
else if (conqa_Answer.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conqa_Answer.AnswerContent);
}
else if (conqa_Answer.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conqa_Answer.Score);
}
else if (conqa_Answer.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conqa_Answer.ScoreType);
}
else if (conqa_Answer.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Answer.IsRight);
}
else if (conqa_Answer.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conqa_Answer.ParentId);
}
else if (conqa_Answer.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Answer.VoteCount);
}
else if (conqa_Answer.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Answer.IsRecommend);
}
else if (conqa_Answer.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conqa_Answer.TopicId);
}
else if (conqa_Answer.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conqa_Answer.AnswerTypeId);
}
else if (conqa_Answer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Answer.IsSubmit);
}
else if (conqa_Answer.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Answer.AppraiseCount);
}
else if (conqa_Answer.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conqa_Answer.StuScore);
}
else if (conqa_Answer.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conqa_Answer.TeaScore);
}
else if (conqa_Answer.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conqa_Answer.CreateDate);
}
else if (conqa_Answer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conqa_Answer.IdCurrEduCls);
}
else if (conqa_Answer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conqa_Answer.UpdUser);
}
else if (conqa_Answer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conqa_Answer.UpdDate);
}
else if (conqa_Answer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conqa_Answer.Memo);
}
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
 AddUpdatedFld(conqa_Answer.AnswerId);
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
 AddUpdatedFld(conqa_Answer.QuestionsId);
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
 AddUpdatedFld(conqa_Answer.AnswerContent);
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
 AddUpdatedFld(conqa_Answer.Score);
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
 AddUpdatedFld(conqa_Answer.ScoreType);
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
 AddUpdatedFld(conqa_Answer.IsRight);
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
 AddUpdatedFld(conqa_Answer.ParentId);
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
 AddUpdatedFld(conqa_Answer.VoteCount);
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
 AddUpdatedFld(conqa_Answer.IsRecommend);
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
 AddUpdatedFld(conqa_Answer.TopicId);
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
 AddUpdatedFld(conqa_Answer.AnswerTypeId);
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
 AddUpdatedFld(conqa_Answer.IsSubmit);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppraiseCount
{
get
{
return mintAppraiseCount;
}
set
{
 mintAppraiseCount = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Answer.AppraiseCount);
}
}
/// <summary>
/// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? StuScore
{
get
{
return mfltStuScore;
}
set
{
 mfltStuScore = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Answer.StuScore);
}
}
/// <summary>
/// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? TeaScore
{
get
{
return mfltTeaScore;
}
set
{
 mfltTeaScore = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Answer.TeaScore);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Answer.CreateDate);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Answer.IdCurrEduCls);
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
 AddUpdatedFld(conqa_Answer.UpdUser);
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
 AddUpdatedFld(conqa_Answer.UpdDate);
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
 AddUpdatedFld(conqa_Answer.Memo);
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
  return mstrAnswerId;
 }
 }
}
 /// <summary>
 /// 答疑回答(qa_Answer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conqa_Answer
{
public const string _CurrTabName = "qa_Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerId", "QuestionsId", "AnswerContent", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "IsRecommend", "TopicId", "AnswerTypeId", "IsSubmit", "AppraiseCount", "StuScore", "TeaScore", "CreateDate", "IdCurrEduCls", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


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
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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