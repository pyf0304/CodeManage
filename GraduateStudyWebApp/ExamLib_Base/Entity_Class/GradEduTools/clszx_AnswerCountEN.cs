
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_AnswerCountEN
 表名:zx_AnswerCount(01120785)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表zx_AnswerCount的关键字(AnswerCountId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerCountId_zx_AnswerCount
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
public K_AnswerCountId_zx_AnswerCount(string strAnswerCountId)
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
 /// <returns>返回:[K_AnswerCountId_zx_AnswerCount]类型的对象</returns>
public static implicit operator K_AnswerCountId_zx_AnswerCount(string value)
{
return new K_AnswerCountId_zx_AnswerCount(value);
}
}
 /// <summary>
 /// z中学问题讨论回答统计(zx_AnswerCount)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_AnswerCountEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_AnswerCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerCountId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"Memo", "AnswerCountId", "DataUser", "DataAddDate", "Month", "Week", "WeekTimeRange", "IsRecommend", "zxAnswerId", "AnswerTypeId", "zxQuestionsId", "GroupTextId", "TextId", "IdCurrEduCls", "AnswerContent", "Score", "ScoreType", "UpdUser", "UpdDate", "UserName"};

protected string mstrMemo;    //备注
protected string mstrAnswerCountId;    //AnswerCountId
protected string mstrDataUser;    //数据用户
protected string mstrDataAddDate;    //数据添加日期
protected int? mintMonth;    //月
protected int? mintWeek;    //周
protected string mstrWeekTimeRange;    //WeekTimeRange
protected bool mbolIsRecommend;    //是否推荐
protected string mstrzxAnswerId;    //回答Id
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrzxQuestionsId;    //提问Id
protected string mstrGroupTextId;    //小组Id
protected string mstrTextId;    //课件Id
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
 public clszx_AnswerCountEN()
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
public clszx_AnswerCountEN(string strAnswerCountId)
 {
strAnswerCountId = strAnswerCountId.Replace("'", "''");
if (strAnswerCountId.Length > 10)
{
throw new Exception("在表:zx_AnswerCount中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAnswerCountId)  ==  true)
{
throw new Exception("在表:zx_AnswerCount中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conzx_AnswerCount.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_AnswerCount.AnswerCountId)
{
return mstrAnswerCountId;
}
else if (strAttributeName  ==  conzx_AnswerCount.DataUser)
{
return mstrDataUser;
}
else if (strAttributeName  ==  conzx_AnswerCount.DataAddDate)
{
return mstrDataAddDate;
}
else if (strAttributeName  ==  conzx_AnswerCount.Month)
{
return mintMonth;
}
else if (strAttributeName  ==  conzx_AnswerCount.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  conzx_AnswerCount.WeekTimeRange)
{
return mstrWeekTimeRange;
}
else if (strAttributeName  ==  conzx_AnswerCount.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  conzx_AnswerCount.zxAnswerId)
{
return mstrzxAnswerId;
}
else if (strAttributeName  ==  conzx_AnswerCount.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  conzx_AnswerCount.zxQuestionsId)
{
return mstrzxQuestionsId;
}
else if (strAttributeName  ==  conzx_AnswerCount.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  conzx_AnswerCount.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_AnswerCount.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_AnswerCount.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  conzx_AnswerCount.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_AnswerCount.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  conzx_AnswerCount.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_AnswerCount.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_AnswerCount.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_AnswerCount.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.Memo);
}
else if (strAttributeName  ==  conzx_AnswerCount.AnswerCountId)
{
mstrAnswerCountId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.AnswerCountId);
}
else if (strAttributeName  ==  conzx_AnswerCount.DataUser)
{
mstrDataUser = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.DataUser);
}
else if (strAttributeName  ==  conzx_AnswerCount.DataAddDate)
{
mstrDataAddDate = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.DataAddDate);
}
else if (strAttributeName  ==  conzx_AnswerCount.Month)
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_AnswerCount.Month);
}
else if (strAttributeName  ==  conzx_AnswerCount.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_AnswerCount.Week);
}
else if (strAttributeName  ==  conzx_AnswerCount.WeekTimeRange)
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.WeekTimeRange);
}
else if (strAttributeName  ==  conzx_AnswerCount.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_AnswerCount.IsRecommend);
}
else if (strAttributeName  ==  conzx_AnswerCount.zxAnswerId)
{
mstrzxAnswerId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.zxAnswerId);
}
else if (strAttributeName  ==  conzx_AnswerCount.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.AnswerTypeId);
}
else if (strAttributeName  ==  conzx_AnswerCount.zxQuestionsId)
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.zxQuestionsId);
}
else if (strAttributeName  ==  conzx_AnswerCount.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.GroupTextId);
}
else if (strAttributeName  ==  conzx_AnswerCount.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.TextId);
}
else if (strAttributeName  ==  conzx_AnswerCount.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_AnswerCount.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.AnswerContent);
}
else if (strAttributeName  ==  conzx_AnswerCount.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_AnswerCount.Score);
}
else if (strAttributeName  ==  conzx_AnswerCount.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.ScoreType);
}
else if (strAttributeName  ==  conzx_AnswerCount.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.UpdUser);
}
else if (strAttributeName  ==  conzx_AnswerCount.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.UpdDate);
}
else if (strAttributeName  ==  conzx_AnswerCount.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_AnswerCount.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_AnswerCount.AnswerCountId  ==  AttributeName[intIndex])
{
return mstrAnswerCountId;
}
else if (conzx_AnswerCount.DataUser  ==  AttributeName[intIndex])
{
return mstrDataUser;
}
else if (conzx_AnswerCount.DataAddDate  ==  AttributeName[intIndex])
{
return mstrDataAddDate;
}
else if (conzx_AnswerCount.Month  ==  AttributeName[intIndex])
{
return mintMonth;
}
else if (conzx_AnswerCount.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (conzx_AnswerCount.WeekTimeRange  ==  AttributeName[intIndex])
{
return mstrWeekTimeRange;
}
else if (conzx_AnswerCount.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (conzx_AnswerCount.zxAnswerId  ==  AttributeName[intIndex])
{
return mstrzxAnswerId;
}
else if (conzx_AnswerCount.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (conzx_AnswerCount.zxQuestionsId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsId;
}
else if (conzx_AnswerCount.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (conzx_AnswerCount.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_AnswerCount.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_AnswerCount.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (conzx_AnswerCount.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_AnswerCount.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (conzx_AnswerCount.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_AnswerCount.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_AnswerCount.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (conzx_AnswerCount.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.Memo);
}
else if (conzx_AnswerCount.AnswerCountId  ==  AttributeName[intIndex])
{
mstrAnswerCountId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.AnswerCountId);
}
else if (conzx_AnswerCount.DataUser  ==  AttributeName[intIndex])
{
mstrDataUser = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.DataUser);
}
else if (conzx_AnswerCount.DataAddDate  ==  AttributeName[intIndex])
{
mstrDataAddDate = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.DataAddDate);
}
else if (conzx_AnswerCount.Month  ==  AttributeName[intIndex])
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_AnswerCount.Month);
}
else if (conzx_AnswerCount.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_AnswerCount.Week);
}
else if (conzx_AnswerCount.WeekTimeRange  ==  AttributeName[intIndex])
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.WeekTimeRange);
}
else if (conzx_AnswerCount.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_AnswerCount.IsRecommend);
}
else if (conzx_AnswerCount.zxAnswerId  ==  AttributeName[intIndex])
{
mstrzxAnswerId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.zxAnswerId);
}
else if (conzx_AnswerCount.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.AnswerTypeId);
}
else if (conzx_AnswerCount.zxQuestionsId  ==  AttributeName[intIndex])
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.zxQuestionsId);
}
else if (conzx_AnswerCount.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.GroupTextId);
}
else if (conzx_AnswerCount.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.TextId);
}
else if (conzx_AnswerCount.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.IdCurrEduCls);
}
else if (conzx_AnswerCount.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.AnswerContent);
}
else if (conzx_AnswerCount.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_AnswerCount.Score);
}
else if (conzx_AnswerCount.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.ScoreType);
}
else if (conzx_AnswerCount.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.UpdUser);
}
else if (conzx_AnswerCount.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.UpdDate);
}
else if (conzx_AnswerCount.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(conzx_AnswerCount.UserName);
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
 AddUpdatedFld(conzx_AnswerCount.Memo);
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
 AddUpdatedFld(conzx_AnswerCount.AnswerCountId);
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
 AddUpdatedFld(conzx_AnswerCount.DataUser);
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
 AddUpdatedFld(conzx_AnswerCount.DataAddDate);
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
 AddUpdatedFld(conzx_AnswerCount.Month);
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
 AddUpdatedFld(conzx_AnswerCount.Week);
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
 AddUpdatedFld(conzx_AnswerCount.WeekTimeRange);
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
 AddUpdatedFld(conzx_AnswerCount.IsRecommend);
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
 AddUpdatedFld(conzx_AnswerCount.zxAnswerId);
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
 AddUpdatedFld(conzx_AnswerCount.AnswerTypeId);
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
 AddUpdatedFld(conzx_AnswerCount.zxQuestionsId);
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
 AddUpdatedFld(conzx_AnswerCount.GroupTextId);
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
 AddUpdatedFld(conzx_AnswerCount.TextId);
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
 AddUpdatedFld(conzx_AnswerCount.IdCurrEduCls);
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
 AddUpdatedFld(conzx_AnswerCount.AnswerContent);
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
 AddUpdatedFld(conzx_AnswerCount.Score);
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
 AddUpdatedFld(conzx_AnswerCount.ScoreType);
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
 AddUpdatedFld(conzx_AnswerCount.UpdUser);
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
 AddUpdatedFld(conzx_AnswerCount.UpdDate);
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
 AddUpdatedFld(conzx_AnswerCount.UserName);
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
 /// z中学问题讨论回答统计(zx_AnswerCount)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_AnswerCount
{
public const string _CurrTabName = "zx_AnswerCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerCountId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "AnswerCountId", "DataUser", "DataAddDate", "Month", "Week", "WeekTimeRange", "IsRecommend", "zxAnswerId", "AnswerTypeId", "zxQuestionsId", "GroupTextId", "TextId", "IdCurrEduCls", "AnswerContent", "Score", "ScoreType", "UpdUser", "UpdDate", "UserName"};
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
 /// 常量:"zxAnswerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxAnswerId = "zxAnswerId";    //回答Id

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"zxQuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsId = "zxQuestionsId";    //提问Id

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

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