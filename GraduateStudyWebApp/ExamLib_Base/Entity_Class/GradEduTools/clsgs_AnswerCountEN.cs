
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_AnswerCountEN
 表名:gs_AnswerCount(01120767)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表gs_AnswerCount的关键字(AnswerCountId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerCountId_gs_AnswerCount
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAnswerCountId">表关键字</param>
public K_AnswerCountId_gs_AnswerCount(string strAnswerCountId)
{
if (IsValid(strAnswerCountId)) Value = strAnswerCountId;
else
{
Value = null;
}
}
private static bool IsValid(string strAnswerCountId)
{
if (string.IsNullOrEmpty(strAnswerCountId) == true) return false;
if (strAnswerCountId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AnswerCountId_gs_AnswerCount]类型的对象</returns>
public static implicit operator K_AnswerCountId_gs_AnswerCount(string value)
{
return new K_AnswerCountId_gs_AnswerCount(value);
}
}
 /// <summary>
 /// 问题讨论回答统计(gs_AnswerCount)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_AnswerCountEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_AnswerCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerCountId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"Memo", "AnswerCountId", "DataUser", "DataAddDate", "Month", "Week", "WeekTimeRange", "IsRecommend", "AnswerId", "AnswerTypeId", "QuestionsId", "TopicId", "PaperId", "IdCurrEduCls", "AnswerContent", "Score", "ScoreType", "UpdUser", "UpdDate", "UserName"};

protected string mstrMemo;    //备注
protected string mstrAnswerCountId;    //AnswerCountId
protected string mstrDataUser;    //数据用户
protected string mstrDataAddDate;    //数据添加日期
protected int? mintMonth;    //月
protected int? mintWeek;    //周
protected string mstrWeekTimeRange;    //WeekTimeRange
protected bool mbolIsRecommend;    //是否推荐
protected string mstrAnswerId;    //回答Id
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrQuestionsId;    //提问Id
protected string mstrTopicId;    //主题Id
protected string mstrPaperId;    //论文Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrAnswerContent;    //答案内容
protected float? mfltScore;    //评分
protected string mstrScoreType;    //评分类型
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_AnswerCountEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerCountId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAnswerCountId">关键字:AnswerCountId</param>
public clsgs_AnswerCountEN(string strAnswerCountId)
 {
strAnswerCountId = strAnswerCountId.Replace("'", "''");
if (strAnswerCountId.Length > 10)
{
throw new Exception("在表:gs_AnswerCount中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAnswerCountId)  ==  true)
{
throw new Exception("在表:gs_AnswerCount中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAnswerCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAnswerCountId = strAnswerCountId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerCountId");
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
if (strAttributeName  ==  congs_AnswerCount.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_AnswerCount.AnswerCountId)
{
return mstrAnswerCountId;
}
else if (strAttributeName  ==  congs_AnswerCount.DataUser)
{
return mstrDataUser;
}
else if (strAttributeName  ==  congs_AnswerCount.DataAddDate)
{
return mstrDataAddDate;
}
else if (strAttributeName  ==  congs_AnswerCount.Month)
{
return mintMonth;
}
else if (strAttributeName  ==  congs_AnswerCount.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  congs_AnswerCount.WeekTimeRange)
{
return mstrWeekTimeRange;
}
else if (strAttributeName  ==  congs_AnswerCount.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  congs_AnswerCount.AnswerId)
{
return mstrAnswerId;
}
else if (strAttributeName  ==  congs_AnswerCount.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  congs_AnswerCount.QuestionsId)
{
return mstrQuestionsId;
}
else if (strAttributeName  ==  congs_AnswerCount.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_AnswerCount.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  congs_AnswerCount.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_AnswerCount.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  congs_AnswerCount.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  congs_AnswerCount.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  congs_AnswerCount.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_AnswerCount.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_AnswerCount.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  congs_AnswerCount.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_AnswerCount.Memo);
}
else if (strAttributeName  ==  congs_AnswerCount.AnswerCountId)
{
mstrAnswerCountId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.AnswerCountId);
}
else if (strAttributeName  ==  congs_AnswerCount.DataUser)
{
mstrDataUser = value.ToString();
 AddUpdatedFld(congs_AnswerCount.DataUser);
}
else if (strAttributeName  ==  congs_AnswerCount.DataAddDate)
{
mstrDataAddDate = value.ToString();
 AddUpdatedFld(congs_AnswerCount.DataAddDate);
}
else if (strAttributeName  ==  congs_AnswerCount.Month)
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_AnswerCount.Month);
}
else if (strAttributeName  ==  congs_AnswerCount.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_AnswerCount.Week);
}
else if (strAttributeName  ==  congs_AnswerCount.WeekTimeRange)
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(congs_AnswerCount.WeekTimeRange);
}
else if (strAttributeName  ==  congs_AnswerCount.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_AnswerCount.IsRecommend);
}
else if (strAttributeName  ==  congs_AnswerCount.AnswerId)
{
mstrAnswerId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.AnswerId);
}
else if (strAttributeName  ==  congs_AnswerCount.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.AnswerTypeId);
}
else if (strAttributeName  ==  congs_AnswerCount.QuestionsId)
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.QuestionsId);
}
else if (strAttributeName  ==  congs_AnswerCount.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.TopicId);
}
else if (strAttributeName  ==  congs_AnswerCount.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.PaperId);
}
else if (strAttributeName  ==  congs_AnswerCount.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_AnswerCount.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_AnswerCount.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(congs_AnswerCount.AnswerContent);
}
else if (strAttributeName  ==  congs_AnswerCount.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_AnswerCount.Score);
}
else if (strAttributeName  ==  congs_AnswerCount.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(congs_AnswerCount.ScoreType);
}
else if (strAttributeName  ==  congs_AnswerCount.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_AnswerCount.UpdUser);
}
else if (strAttributeName  ==  congs_AnswerCount.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_AnswerCount.UpdDate);
}
else if (strAttributeName  ==  congs_AnswerCount.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(congs_AnswerCount.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_AnswerCount.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_AnswerCount.AnswerCountId  ==  AttributeName[intIndex])
{
return mstrAnswerCountId;
}
else if (congs_AnswerCount.DataUser  ==  AttributeName[intIndex])
{
return mstrDataUser;
}
else if (congs_AnswerCount.DataAddDate  ==  AttributeName[intIndex])
{
return mstrDataAddDate;
}
else if (congs_AnswerCount.Month  ==  AttributeName[intIndex])
{
return mintMonth;
}
else if (congs_AnswerCount.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (congs_AnswerCount.WeekTimeRange  ==  AttributeName[intIndex])
{
return mstrWeekTimeRange;
}
else if (congs_AnswerCount.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (congs_AnswerCount.AnswerId  ==  AttributeName[intIndex])
{
return mstrAnswerId;
}
else if (congs_AnswerCount.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (congs_AnswerCount.QuestionsId  ==  AttributeName[intIndex])
{
return mstrQuestionsId;
}
else if (congs_AnswerCount.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_AnswerCount.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (congs_AnswerCount.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_AnswerCount.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (congs_AnswerCount.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (congs_AnswerCount.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (congs_AnswerCount.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_AnswerCount.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_AnswerCount.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (congs_AnswerCount.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_AnswerCount.Memo);
}
else if (congs_AnswerCount.AnswerCountId  ==  AttributeName[intIndex])
{
mstrAnswerCountId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.AnswerCountId);
}
else if (congs_AnswerCount.DataUser  ==  AttributeName[intIndex])
{
mstrDataUser = value.ToString();
 AddUpdatedFld(congs_AnswerCount.DataUser);
}
else if (congs_AnswerCount.DataAddDate  ==  AttributeName[intIndex])
{
mstrDataAddDate = value.ToString();
 AddUpdatedFld(congs_AnswerCount.DataAddDate);
}
else if (congs_AnswerCount.Month  ==  AttributeName[intIndex])
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_AnswerCount.Month);
}
else if (congs_AnswerCount.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_AnswerCount.Week);
}
else if (congs_AnswerCount.WeekTimeRange  ==  AttributeName[intIndex])
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(congs_AnswerCount.WeekTimeRange);
}
else if (congs_AnswerCount.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_AnswerCount.IsRecommend);
}
else if (congs_AnswerCount.AnswerId  ==  AttributeName[intIndex])
{
mstrAnswerId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.AnswerId);
}
else if (congs_AnswerCount.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.AnswerTypeId);
}
else if (congs_AnswerCount.QuestionsId  ==  AttributeName[intIndex])
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.QuestionsId);
}
else if (congs_AnswerCount.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.TopicId);
}
else if (congs_AnswerCount.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_AnswerCount.PaperId);
}
else if (congs_AnswerCount.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_AnswerCount.IdCurrEduCls);
}
else if (congs_AnswerCount.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(congs_AnswerCount.AnswerContent);
}
else if (congs_AnswerCount.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_AnswerCount.Score);
}
else if (congs_AnswerCount.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(congs_AnswerCount.ScoreType);
}
else if (congs_AnswerCount.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_AnswerCount.UpdUser);
}
else if (congs_AnswerCount.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_AnswerCount.UpdDate);
}
else if (congs_AnswerCount.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(congs_AnswerCount.UserName);
}
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
 AddUpdatedFld(congs_AnswerCount.Memo);
}
}
/// <summary>
/// AnswerCountId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerCountId
{
get
{
return mstrAnswerCountId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerCountId = value;
}
else
{
 mstrAnswerCountId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_AnswerCount.AnswerCountId);
}
}
/// <summary>
/// 数据用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataUser
{
get
{
return mstrDataUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataUser = value;
}
else
{
 mstrDataUser = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_AnswerCount.DataUser);
}
}
/// <summary>
/// 数据添加日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataAddDate
{
get
{
return mstrDataAddDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataAddDate = value;
}
else
{
 mstrDataAddDate = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_AnswerCount.DataAddDate);
}
}
/// <summary>
/// 月(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Month
{
get
{
return mintMonth;
}
set
{
 mintMonth = value;
//记录修改过的字段
 AddUpdatedFld(congs_AnswerCount.Month);
}
}
/// <summary>
/// 周(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Week
{
get
{
return mintWeek;
}
set
{
 mintWeek = value;
//记录修改过的字段
 AddUpdatedFld(congs_AnswerCount.Week);
}
}
/// <summary>
/// WeekTimeRange(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WeekTimeRange
{
get
{
return mstrWeekTimeRange;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWeekTimeRange = value;
}
else
{
 mstrWeekTimeRange = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_AnswerCount.WeekTimeRange);
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
 AddUpdatedFld(congs_AnswerCount.IsRecommend);
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
 AddUpdatedFld(congs_AnswerCount.AnswerId);
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
 AddUpdatedFld(congs_AnswerCount.AnswerTypeId);
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
 AddUpdatedFld(congs_AnswerCount.QuestionsId);
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
 AddUpdatedFld(congs_AnswerCount.TopicId);
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
 AddUpdatedFld(congs_AnswerCount.PaperId);
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
 AddUpdatedFld(congs_AnswerCount.IdCurrEduCls);
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
 AddUpdatedFld(congs_AnswerCount.AnswerContent);
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
 AddUpdatedFld(congs_AnswerCount.Score);
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
 AddUpdatedFld(congs_AnswerCount.ScoreType);
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
 AddUpdatedFld(congs_AnswerCount.UpdUser);
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
 AddUpdatedFld(congs_AnswerCount.UpdDate);
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
 AddUpdatedFld(congs_AnswerCount.UserName);
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
  return mstrAnswerCountId;
 }
 }
}
 /// <summary>
 /// 问题讨论回答统计(gs_AnswerCount)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_AnswerCount
{
public const string _CurrTabName = "gs_AnswerCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerCountId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "AnswerCountId", "DataUser", "DataAddDate", "Month", "Week", "WeekTimeRange", "IsRecommend", "AnswerId", "AnswerTypeId", "QuestionsId", "TopicId", "PaperId", "IdCurrEduCls", "AnswerContent", "Score", "ScoreType", "UpdUser", "UpdDate", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"AnswerCountId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCountId = "AnswerCountId";    //AnswerCountId

 /// <summary>
 /// 常量:"DataUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataUser = "DataUser";    //数据用户

 /// <summary>
 /// 常量:"DataAddDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataAddDate = "DataAddDate";    //数据添加日期

 /// <summary>
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Month = "Month";    //月

 /// <summary>
 /// 常量:"Week"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Week = "Week";    //周

 /// <summary>
 /// 常量:"WeekTimeRange"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WeekTimeRange = "WeekTimeRange";    //WeekTimeRange

 /// <summary>
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

 /// <summary>
 /// 常量:"AnswerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerId = "AnswerId";    //回答Id

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"QuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsId = "QuestionsId";    //提问Id

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名
}

}