
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_AnswerEN
 表名:vqa_Answer(01120635)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表vqa_Answer的关键字(AnswerId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerId_vqa_Answer
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
public K_AnswerId_vqa_Answer(string strAnswerId)
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
 /// <returns>返回:[K_AnswerId_vqa_Answer]类型的对象</returns>
public static implicit operator K_AnswerId_vqa_Answer(string value)
{
return new K_AnswerId_vqa_Answer(value);
}
}
 /// <summary>
 /// v答疑回答(vqa_Answer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvqa_AnswerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vqa_Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"AnswerId", "QuestionsId", "AnswerContent", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "UpdUser", "UserName", "UpdDate", "Memo", "QaPaperId", "QuestionsContent", "PaperId", "QuestionsTypeId", "QuestionsTypeName", "IsRecommend", "TopicId", "AnswerTypeId", "IsSubmit", "AnswerCount", "PaperTitle", "QuestUserName", "AppraiseCount", "StuScore", "TeaScore", "UserId", "IdCurrEduCls"};

protected string mstrAnswerId;    //回答Id
protected string mstrQuestionsId;    //提问Id
protected string mstrAnswerContent;    //答案内容
protected float? mfltScore;    //评分
protected string mstrScoreType;    //评分类型
protected bool mbolIsRight;    //是否正确
protected string mstrParentId;    //父节点Id
protected int? mintVoteCount;    //点赞计数
protected string mstrUpdUser;    //修改人
protected string mstrUserName;    //用户名
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrQaPaperId;    //论文答疑Id
protected string mstrQuestionsContent;    //提问内容
protected string mstrPaperId;    //论文Id
protected string mstrQuestionsTypeId;    //问题类型Id
protected string mstrQuestionsTypeName;    //问题类型名称
protected bool mbolIsRecommend;    //是否推荐
protected string mstrTopicId;    //主题Id
protected string mstrAnswerTypeId;    //答案类型ID
protected bool mbolIsSubmit;    //是否提交
protected int? mintAnswerCount;    //回答计数
protected string mstrPaperTitle;    //论文标题
protected string mstrQuestUserName;    //QuestUserName
protected int? mintAppraiseCount;    //评论数
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrUserId;    //用户ID
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvqa_AnswerEN()
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
public clsvqa_AnswerEN(string strAnswerId)
 {
strAnswerId = strAnswerId.Replace("'", "''");
if (strAnswerId.Length > 10)
{
throw new Exception("在表:vqa_Answer中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAnswerId)  ==  true)
{
throw new Exception("在表:vqa_Answer中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convqa_Answer.AnswerId)
{
return mstrAnswerId;
}
else if (strAttributeName  ==  convqa_Answer.QuestionsId)
{
return mstrQuestionsId;
}
else if (strAttributeName  ==  convqa_Answer.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  convqa_Answer.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convqa_Answer.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  convqa_Answer.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  convqa_Answer.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  convqa_Answer.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convqa_Answer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convqa_Answer.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convqa_Answer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convqa_Answer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convqa_Answer.QaPaperId)
{
return mstrQaPaperId;
}
else if (strAttributeName  ==  convqa_Answer.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  convqa_Answer.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convqa_Answer.QuestionsTypeId)
{
return mstrQuestionsTypeId;
}
else if (strAttributeName  ==  convqa_Answer.QuestionsTypeName)
{
return mstrQuestionsTypeName;
}
else if (strAttributeName  ==  convqa_Answer.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  convqa_Answer.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convqa_Answer.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convqa_Answer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convqa_Answer.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convqa_Answer.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convqa_Answer.QuestUserName)
{
return mstrQuestUserName;
}
else if (strAttributeName  ==  convqa_Answer.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convqa_Answer.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convqa_Answer.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convqa_Answer.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convqa_Answer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  convqa_Answer.AnswerId)
{
mstrAnswerId = value.ToString();
 AddUpdatedFld(convqa_Answer.AnswerId);
}
else if (strAttributeName  ==  convqa_Answer.QuestionsId)
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestionsId);
}
else if (strAttributeName  ==  convqa_Answer.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(convqa_Answer.AnswerContent);
}
else if (strAttributeName  ==  convqa_Answer.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convqa_Answer.Score);
}
else if (strAttributeName  ==  convqa_Answer.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(convqa_Answer.ScoreType);
}
else if (strAttributeName  ==  convqa_Answer.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Answer.IsRight);
}
else if (strAttributeName  ==  convqa_Answer.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(convqa_Answer.ParentId);
}
else if (strAttributeName  ==  convqa_Answer.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Answer.VoteCount);
}
else if (strAttributeName  ==  convqa_Answer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convqa_Answer.UpdUser);
}
else if (strAttributeName  ==  convqa_Answer.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convqa_Answer.UserName);
}
else if (strAttributeName  ==  convqa_Answer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convqa_Answer.UpdDate);
}
else if (strAttributeName  ==  convqa_Answer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convqa_Answer.Memo);
}
else if (strAttributeName  ==  convqa_Answer.QaPaperId)
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convqa_Answer.QaPaperId);
}
else if (strAttributeName  ==  convqa_Answer.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestionsContent);
}
else if (strAttributeName  ==  convqa_Answer.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convqa_Answer.PaperId);
}
else if (strAttributeName  ==  convqa_Answer.QuestionsTypeId)
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestionsTypeId);
}
else if (strAttributeName  ==  convqa_Answer.QuestionsTypeName)
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestionsTypeName);
}
else if (strAttributeName  ==  convqa_Answer.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Answer.IsRecommend);
}
else if (strAttributeName  ==  convqa_Answer.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convqa_Answer.TopicId);
}
else if (strAttributeName  ==  convqa_Answer.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convqa_Answer.AnswerTypeId);
}
else if (strAttributeName  ==  convqa_Answer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Answer.IsSubmit);
}
else if (strAttributeName  ==  convqa_Answer.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Answer.AnswerCount);
}
else if (strAttributeName  ==  convqa_Answer.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convqa_Answer.PaperTitle);
}
else if (strAttributeName  ==  convqa_Answer.QuestUserName)
{
mstrQuestUserName = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestUserName);
}
else if (strAttributeName  ==  convqa_Answer.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Answer.AppraiseCount);
}
else if (strAttributeName  ==  convqa_Answer.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convqa_Answer.StuScore);
}
else if (strAttributeName  ==  convqa_Answer.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convqa_Answer.TeaScore);
}
else if (strAttributeName  ==  convqa_Answer.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convqa_Answer.UserId);
}
else if (strAttributeName  ==  convqa_Answer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convqa_Answer.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (convqa_Answer.AnswerId  ==  AttributeName[intIndex])
{
return mstrAnswerId;
}
else if (convqa_Answer.QuestionsId  ==  AttributeName[intIndex])
{
return mstrQuestionsId;
}
else if (convqa_Answer.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (convqa_Answer.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convqa_Answer.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (convqa_Answer.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (convqa_Answer.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (convqa_Answer.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convqa_Answer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convqa_Answer.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convqa_Answer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convqa_Answer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convqa_Answer.QaPaperId  ==  AttributeName[intIndex])
{
return mstrQaPaperId;
}
else if (convqa_Answer.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (convqa_Answer.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convqa_Answer.QuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeId;
}
else if (convqa_Answer.QuestionsTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeName;
}
else if (convqa_Answer.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (convqa_Answer.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convqa_Answer.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convqa_Answer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convqa_Answer.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convqa_Answer.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convqa_Answer.QuestUserName  ==  AttributeName[intIndex])
{
return mstrQuestUserName;
}
else if (convqa_Answer.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convqa_Answer.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convqa_Answer.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convqa_Answer.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convqa_Answer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (convqa_Answer.AnswerId  ==  AttributeName[intIndex])
{
mstrAnswerId = value.ToString();
 AddUpdatedFld(convqa_Answer.AnswerId);
}
else if (convqa_Answer.QuestionsId  ==  AttributeName[intIndex])
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestionsId);
}
else if (convqa_Answer.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(convqa_Answer.AnswerContent);
}
else if (convqa_Answer.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convqa_Answer.Score);
}
else if (convqa_Answer.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(convqa_Answer.ScoreType);
}
else if (convqa_Answer.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Answer.IsRight);
}
else if (convqa_Answer.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(convqa_Answer.ParentId);
}
else if (convqa_Answer.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Answer.VoteCount);
}
else if (convqa_Answer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convqa_Answer.UpdUser);
}
else if (convqa_Answer.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convqa_Answer.UserName);
}
else if (convqa_Answer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convqa_Answer.UpdDate);
}
else if (convqa_Answer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convqa_Answer.Memo);
}
else if (convqa_Answer.QaPaperId  ==  AttributeName[intIndex])
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convqa_Answer.QaPaperId);
}
else if (convqa_Answer.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestionsContent);
}
else if (convqa_Answer.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convqa_Answer.PaperId);
}
else if (convqa_Answer.QuestionsTypeId  ==  AttributeName[intIndex])
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestionsTypeId);
}
else if (convqa_Answer.QuestionsTypeName  ==  AttributeName[intIndex])
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestionsTypeName);
}
else if (convqa_Answer.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Answer.IsRecommend);
}
else if (convqa_Answer.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convqa_Answer.TopicId);
}
else if (convqa_Answer.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convqa_Answer.AnswerTypeId);
}
else if (convqa_Answer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Answer.IsSubmit);
}
else if (convqa_Answer.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Answer.AnswerCount);
}
else if (convqa_Answer.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convqa_Answer.PaperTitle);
}
else if (convqa_Answer.QuestUserName  ==  AttributeName[intIndex])
{
mstrQuestUserName = value.ToString();
 AddUpdatedFld(convqa_Answer.QuestUserName);
}
else if (convqa_Answer.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Answer.AppraiseCount);
}
else if (convqa_Answer.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convqa_Answer.StuScore);
}
else if (convqa_Answer.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convqa_Answer.TeaScore);
}
else if (convqa_Answer.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convqa_Answer.UserId);
}
else if (convqa_Answer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convqa_Answer.IdCurrEduCls);
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
 AddUpdatedFld(convqa_Answer.AnswerId);
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
 AddUpdatedFld(convqa_Answer.QuestionsId);
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
 AddUpdatedFld(convqa_Answer.AnswerContent);
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
 AddUpdatedFld(convqa_Answer.Score);
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
 AddUpdatedFld(convqa_Answer.ScoreType);
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
 AddUpdatedFld(convqa_Answer.IsRight);
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
 AddUpdatedFld(convqa_Answer.ParentId);
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
 AddUpdatedFld(convqa_Answer.VoteCount);
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
 AddUpdatedFld(convqa_Answer.UpdUser);
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
 AddUpdatedFld(convqa_Answer.UserName);
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
 AddUpdatedFld(convqa_Answer.UpdDate);
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
 AddUpdatedFld(convqa_Answer.Memo);
}
}
/// <summary>
/// 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QaPaperId
{
get
{
return mstrQaPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQaPaperId = value;
}
else
{
 mstrQaPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Answer.QaPaperId);
}
}
/// <summary>
/// 提问内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsContent
{
get
{
return mstrQuestionsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsContent = value;
}
else
{
 mstrQuestionsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Answer.QuestionsContent);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Answer.PaperId);
}
}
/// <summary>
/// 问题类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsTypeId
{
get
{
return mstrQuestionsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsTypeId = value;
}
else
{
 mstrQuestionsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Answer.QuestionsTypeId);
}
}
/// <summary>
/// 问题类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsTypeName
{
get
{
return mstrQuestionsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsTypeName = value;
}
else
{
 mstrQuestionsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Answer.QuestionsTypeName);
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
 AddUpdatedFld(convqa_Answer.IsRecommend);
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
 AddUpdatedFld(convqa_Answer.TopicId);
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
 AddUpdatedFld(convqa_Answer.AnswerTypeId);
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
 AddUpdatedFld(convqa_Answer.IsSubmit);
}
}
/// <summary>
/// 回答计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerCount
{
get
{
return mintAnswerCount;
}
set
{
 mintAnswerCount = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Answer.AnswerCount);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Answer.PaperTitle);
}
}
/// <summary>
/// QuestUserName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestUserName
{
get
{
return mstrQuestUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestUserName = value;
}
else
{
 mstrQuestUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Answer.QuestUserName);
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
 AddUpdatedFld(convqa_Answer.AppraiseCount);
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
 AddUpdatedFld(convqa_Answer.StuScore);
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
 AddUpdatedFld(convqa_Answer.TeaScore);
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
 AddUpdatedFld(convqa_Answer.UserId);
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
 AddUpdatedFld(convqa_Answer.IdCurrEduCls);
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
 /// v答疑回答(vqa_Answer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convqa_Answer
{
public const string _CurrTabName = "vqa_Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerId", "QuestionsId", "AnswerContent", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "UpdUser", "UserName", "UpdDate", "Memo", "QaPaperId", "QuestionsContent", "PaperId", "QuestionsTypeId", "QuestionsTypeName", "IsRecommend", "TopicId", "AnswerTypeId", "IsSubmit", "AnswerCount", "PaperTitle", "QuestUserName", "AppraiseCount", "StuScore", "TeaScore", "UserId", "IdCurrEduCls"};
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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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

 /// <summary>
 /// 常量:"QaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QaPaperId = "QaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"QuestionsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsContent = "QuestionsContent";    //提问内容

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"QuestionsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeId = "QuestionsTypeId";    //问题类型Id

 /// <summary>
 /// 常量:"QuestionsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeName = "QuestionsTypeName";    //问题类型名称

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
 /// 常量:"AnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCount = "AnswerCount";    //回答计数

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"QuestUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestUserName = "QuestUserName";    //QuestUserName

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}