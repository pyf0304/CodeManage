
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_AnswerEN
 表名:vzx_Answer(01120847)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表vzx_Answer的关键字(zxAnswerId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxAnswerId_vzx_Answer
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxAnswerId">表关键字</param>
public K_zxAnswerId_vzx_Answer(string strzxAnswerId)
{
if (IsValid(strzxAnswerId)) Value = strzxAnswerId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxAnswerId)
{
if (string.IsNullOrEmpty(strzxAnswerId) == true) return false;
if (strzxAnswerId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxAnswerId_vzx_Answer]类型的对象</returns>
public static implicit operator K_zxAnswerId_vzx_Answer(string value)
{
return new K_zxAnswerId_vzx_Answer(value);
}
}
 /// <summary>
 /// vzx_Answer(vzx_Answer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_AnswerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxAnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"AnswerContent", "zxAnswerId", "zxQuestionsId", "QuestionsTypeName", "TextTitle", "QuestionsContent", "zxQuestionsTypeId", "UserId", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "UpdUser", "UserName", "UpdDate", "Memo", "IsPublic", "IsRecommend", "GroupTextId", "IsSubmit", "AppraiseCount", "StuScore", "TeaScore", "TextId", "AnswerTypeId", "IdCurrEduCls", "CreateDate", "QuestUserName"};

protected string mstrAnswerContent;    //答案内容
protected string mstrzxAnswerId;    //回答Id
protected string mstrzxQuestionsId;    //提问Id
protected string mstrQuestionsTypeName;    //问题类型名称
protected string mstrTextTitle;    //TextTitle
protected string mstrQuestionsContent;    //提问内容
protected string mstrzxQuestionsTypeId;    //问题类型Id
protected string mstrUserId;    //用户ID
protected float? mfltScore;    //评分
protected string mstrScoreType;    //评分类型
protected bool mbolIsRight;    //是否正确
protected string mstrParentId;    //父节点Id
protected int? mintVoteCount;    //点赞计数
protected string mstrUpdUser;    //修改人
protected string mstrUserName;    //用户名
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsRecommend;    //是否推荐
protected string mstrGroupTextId;    //小组Id
protected bool mbolIsSubmit;    //是否提交
protected int? mintAppraiseCount;    //评论数
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrTextId;    //课件Id
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCreateDate;    //建立日期
protected string mstrQuestUserName;    //QuestUserName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_AnswerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxAnswerId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxAnswerId">关键字:回答Id</param>
public clsvzx_AnswerEN(string strzxAnswerId)
 {
strzxAnswerId = strzxAnswerId.Replace("'", "''");
if (strzxAnswerId.Length > 10)
{
throw new Exception("在表:vzx_Answer中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxAnswerId)  ==  true)
{
throw new Exception("在表:vzx_Answer中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxAnswerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxAnswerId = strzxAnswerId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxAnswerId");
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
if (strAttributeName  ==  convzx_Answer.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  convzx_Answer.zxAnswerId)
{
return mstrzxAnswerId;
}
else if (strAttributeName  ==  convzx_Answer.zxQuestionsId)
{
return mstrzxQuestionsId;
}
else if (strAttributeName  ==  convzx_Answer.QuestionsTypeName)
{
return mstrQuestionsTypeName;
}
else if (strAttributeName  ==  convzx_Answer.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_Answer.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  convzx_Answer.zxQuestionsTypeId)
{
return mstrzxQuestionsTypeId;
}
else if (strAttributeName  ==  convzx_Answer.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convzx_Answer.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_Answer.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  convzx_Answer.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  convzx_Answer.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  convzx_Answer.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_Answer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_Answer.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convzx_Answer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_Answer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_Answer.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convzx_Answer.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  convzx_Answer.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_Answer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_Answer.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convzx_Answer.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convzx_Answer.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convzx_Answer.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_Answer.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convzx_Answer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_Answer.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_Answer.QuestUserName)
{
return mstrQuestUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_Answer.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(convzx_Answer.AnswerContent);
}
else if (strAttributeName  ==  convzx_Answer.zxAnswerId)
{
mstrzxAnswerId = value.ToString();
 AddUpdatedFld(convzx_Answer.zxAnswerId);
}
else if (strAttributeName  ==  convzx_Answer.zxQuestionsId)
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(convzx_Answer.zxQuestionsId);
}
else if (strAttributeName  ==  convzx_Answer.QuestionsTypeName)
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convzx_Answer.QuestionsTypeName);
}
else if (strAttributeName  ==  convzx_Answer.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_Answer.TextTitle);
}
else if (strAttributeName  ==  convzx_Answer.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convzx_Answer.QuestionsContent);
}
else if (strAttributeName  ==  convzx_Answer.zxQuestionsTypeId)
{
mstrzxQuestionsTypeId = value.ToString();
 AddUpdatedFld(convzx_Answer.zxQuestionsTypeId);
}
else if (strAttributeName  ==  convzx_Answer.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convzx_Answer.UserId);
}
else if (strAttributeName  ==  convzx_Answer.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Answer.Score);
}
else if (strAttributeName  ==  convzx_Answer.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(convzx_Answer.ScoreType);
}
else if (strAttributeName  ==  convzx_Answer.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Answer.IsRight);
}
else if (strAttributeName  ==  convzx_Answer.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(convzx_Answer.ParentId);
}
else if (strAttributeName  ==  convzx_Answer.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Answer.VoteCount);
}
else if (strAttributeName  ==  convzx_Answer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Answer.UpdUser);
}
else if (strAttributeName  ==  convzx_Answer.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_Answer.UserName);
}
else if (strAttributeName  ==  convzx_Answer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Answer.UpdDate);
}
else if (strAttributeName  ==  convzx_Answer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Answer.Memo);
}
else if (strAttributeName  ==  convzx_Answer.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Answer.IsPublic);
}
else if (strAttributeName  ==  convzx_Answer.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Answer.IsRecommend);
}
else if (strAttributeName  ==  convzx_Answer.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_Answer.GroupTextId);
}
else if (strAttributeName  ==  convzx_Answer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Answer.IsSubmit);
}
else if (strAttributeName  ==  convzx_Answer.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Answer.AppraiseCount);
}
else if (strAttributeName  ==  convzx_Answer.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Answer.StuScore);
}
else if (strAttributeName  ==  convzx_Answer.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Answer.TeaScore);
}
else if (strAttributeName  ==  convzx_Answer.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Answer.TextId);
}
else if (strAttributeName  ==  convzx_Answer.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convzx_Answer.AnswerTypeId);
}
else if (strAttributeName  ==  convzx_Answer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Answer.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_Answer.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_Answer.CreateDate);
}
else if (strAttributeName  ==  convzx_Answer.QuestUserName)
{
mstrQuestUserName = value.ToString();
 AddUpdatedFld(convzx_Answer.QuestUserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_Answer.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (convzx_Answer.zxAnswerId  ==  AttributeName[intIndex])
{
return mstrzxAnswerId;
}
else if (convzx_Answer.zxQuestionsId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsId;
}
else if (convzx_Answer.QuestionsTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeName;
}
else if (convzx_Answer.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_Answer.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (convzx_Answer.zxQuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsTypeId;
}
else if (convzx_Answer.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convzx_Answer.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_Answer.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (convzx_Answer.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (convzx_Answer.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (convzx_Answer.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_Answer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_Answer.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convzx_Answer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_Answer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_Answer.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convzx_Answer.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (convzx_Answer.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_Answer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_Answer.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convzx_Answer.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convzx_Answer.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convzx_Answer.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_Answer.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convzx_Answer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_Answer.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_Answer.QuestUserName  ==  AttributeName[intIndex])
{
return mstrQuestUserName;
}
return null;
}
set
{
if (convzx_Answer.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(convzx_Answer.AnswerContent);
}
else if (convzx_Answer.zxAnswerId  ==  AttributeName[intIndex])
{
mstrzxAnswerId = value.ToString();
 AddUpdatedFld(convzx_Answer.zxAnswerId);
}
else if (convzx_Answer.zxQuestionsId  ==  AttributeName[intIndex])
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(convzx_Answer.zxQuestionsId);
}
else if (convzx_Answer.QuestionsTypeName  ==  AttributeName[intIndex])
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convzx_Answer.QuestionsTypeName);
}
else if (convzx_Answer.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_Answer.TextTitle);
}
else if (convzx_Answer.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convzx_Answer.QuestionsContent);
}
else if (convzx_Answer.zxQuestionsTypeId  ==  AttributeName[intIndex])
{
mstrzxQuestionsTypeId = value.ToString();
 AddUpdatedFld(convzx_Answer.zxQuestionsTypeId);
}
else if (convzx_Answer.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convzx_Answer.UserId);
}
else if (convzx_Answer.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Answer.Score);
}
else if (convzx_Answer.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(convzx_Answer.ScoreType);
}
else if (convzx_Answer.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Answer.IsRight);
}
else if (convzx_Answer.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(convzx_Answer.ParentId);
}
else if (convzx_Answer.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Answer.VoteCount);
}
else if (convzx_Answer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Answer.UpdUser);
}
else if (convzx_Answer.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_Answer.UserName);
}
else if (convzx_Answer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Answer.UpdDate);
}
else if (convzx_Answer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Answer.Memo);
}
else if (convzx_Answer.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Answer.IsPublic);
}
else if (convzx_Answer.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Answer.IsRecommend);
}
else if (convzx_Answer.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_Answer.GroupTextId);
}
else if (convzx_Answer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Answer.IsSubmit);
}
else if (convzx_Answer.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Answer.AppraiseCount);
}
else if (convzx_Answer.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Answer.StuScore);
}
else if (convzx_Answer.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Answer.TeaScore);
}
else if (convzx_Answer.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Answer.TextId);
}
else if (convzx_Answer.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convzx_Answer.AnswerTypeId);
}
else if (convzx_Answer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Answer.IdCurrEduCls);
}
else if (convzx_Answer.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_Answer.CreateDate);
}
else if (convzx_Answer.QuestUserName  ==  AttributeName[intIndex])
{
mstrQuestUserName = value.ToString();
 AddUpdatedFld(convzx_Answer.QuestUserName);
}
}
}

/// <summary>
/// 答案内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
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
 AddUpdatedFld(convzx_Answer.AnswerContent);
}
}
/// <summary>
/// 回答Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxAnswerId
{
get
{
return mstrzxAnswerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxAnswerId = value;
}
else
{
 mstrzxAnswerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Answer.zxAnswerId);
}
}
/// <summary>
/// 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxQuestionsId
{
get
{
return mstrzxQuestionsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxQuestionsId = value;
}
else
{
 mstrzxQuestionsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Answer.zxQuestionsId);
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
 AddUpdatedFld(convzx_Answer.QuestionsTypeName);
}
}
/// <summary>
/// TextTitle(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTitle
{
get
{
return mstrTextTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTitle = value;
}
else
{
 mstrTextTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Answer.TextTitle);
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
 AddUpdatedFld(convzx_Answer.QuestionsContent);
}
}
/// <summary>
/// 问题类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxQuestionsTypeId
{
get
{
return mstrzxQuestionsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxQuestionsTypeId = value;
}
else
{
 mstrzxQuestionsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Answer.zxQuestionsTypeId);
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
 AddUpdatedFld(convzx_Answer.UserId);
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
 AddUpdatedFld(convzx_Answer.Score);
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
 AddUpdatedFld(convzx_Answer.ScoreType);
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
 AddUpdatedFld(convzx_Answer.IsRight);
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
 AddUpdatedFld(convzx_Answer.ParentId);
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
 AddUpdatedFld(convzx_Answer.VoteCount);
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
 AddUpdatedFld(convzx_Answer.UpdUser);
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
 AddUpdatedFld(convzx_Answer.UserName);
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
 AddUpdatedFld(convzx_Answer.UpdDate);
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
 AddUpdatedFld(convzx_Answer.Memo);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Answer.IsPublic);
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
 AddUpdatedFld(convzx_Answer.IsRecommend);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Answer.GroupTextId);
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
 AddUpdatedFld(convzx_Answer.IsSubmit);
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
 AddUpdatedFld(convzx_Answer.AppraiseCount);
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
 AddUpdatedFld(convzx_Answer.StuScore);
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
 AddUpdatedFld(convzx_Answer.TeaScore);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Answer.TextId);
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
 AddUpdatedFld(convzx_Answer.AnswerTypeId);
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
 AddUpdatedFld(convzx_Answer.IdCurrEduCls);
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
 AddUpdatedFld(convzx_Answer.CreateDate);
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
 AddUpdatedFld(convzx_Answer.QuestUserName);
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
  return mstrzxAnswerId;
 }
 }
}
 /// <summary>
 /// vzx_Answer(vzx_Answer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_Answer
{
public const string _CurrTabName = "vzx_Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxAnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerContent", "zxAnswerId", "zxQuestionsId", "QuestionsTypeName", "TextTitle", "QuestionsContent", "zxQuestionsTypeId", "UserId", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "UpdUser", "UserName", "UpdDate", "Memo", "IsPublic", "IsRecommend", "GroupTextId", "IsSubmit", "AppraiseCount", "StuScore", "TeaScore", "TextId", "AnswerTypeId", "IdCurrEduCls", "CreateDate", "QuestUserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"AnswerContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerContent = "AnswerContent";    //答案内容

 /// <summary>
 /// 常量:"zxAnswerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxAnswerId = "zxAnswerId";    //回答Id

 /// <summary>
 /// 常量:"zxQuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsId = "zxQuestionsId";    //提问Id

 /// <summary>
 /// 常量:"QuestionsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeName = "QuestionsTypeName";    //问题类型名称

 /// <summary>
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"QuestionsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsContent = "QuestionsContent";    //提问内容

 /// <summary>
 /// 常量:"zxQuestionsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsTypeId = "zxQuestionsTypeId";    //问题类型Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

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
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"QuestUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestUserName = "QuestUserName";    //QuestUserName
}

}