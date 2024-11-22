
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAnswerEN
 表名:Answer(01120002)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 表Answer的关键字(AnswerId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerId_Answer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngAnswerId">表关键字</param>
public K_AnswerId_Answer(long lngAnswerId)
{
if (IsValid(lngAnswerId)) Value = lngAnswerId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngAnswerId)
{
if (lngAnswerId == 0) return false;
if (lngAnswerId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AnswerId_Answer]类型的对象</returns>
public static implicit operator K_AnswerId_Answer(long value)
{
return new K_AnswerId_Answer(value);
}
}
 /// <summary>
 /// 答案(Answer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAnswerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"AnswerId", "QuestionId", "AnswerIndex", "AnswerOptionId", "AnswerMultiOptions", "AnswerFillInBlank", "AnswerTrueOrFalse", "AnswerContent", "IsAutoCorrect", "Provider", "Score", "IsShow", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected long mlngAnswerId;    //问答ID
protected long mlngQuestionId;    //题目Id
protected int mintAnswerIndex;    //问答序号
protected string mstrAnswerOptionId;    //回答选项Id
protected string mstrAnswerMultiOptions;    //多选项答案
protected string mstrAnswerFillInBlank;    //填空题答案
protected bool mbolAnswerTrueOrFalse;    //判断题答案
protected string mstrAnswerContent;    //答案内容
protected bool mbolIsAutoCorrect;    //是否支持自动批改
protected string mstrProvider;    //提供者
protected double mdblScore;    //得分
protected bool mbolIsShow;    //是否启用
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAnswerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngAnswerId">关键字:问答ID</param>
public clsAnswerEN(long lngAnswerId)
 {
 if (lngAnswerId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngAnswerId = lngAnswerId;
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
if (strAttributeName  ==  conAnswer.AnswerId)
{
return mlngAnswerId;
}
else if (strAttributeName  ==  conAnswer.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conAnswer.AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  conAnswer.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  conAnswer.AnswerMultiOptions)
{
return mstrAnswerMultiOptions;
}
else if (strAttributeName  ==  conAnswer.AnswerFillInBlank)
{
return mstrAnswerFillInBlank;
}
else if (strAttributeName  ==  conAnswer.AnswerTrueOrFalse)
{
return mbolAnswerTrueOrFalse;
}
else if (strAttributeName  ==  conAnswer.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  conAnswer.IsAutoCorrect)
{
return mbolIsAutoCorrect;
}
else if (strAttributeName  ==  conAnswer.Provider)
{
return mstrProvider;
}
else if (strAttributeName  ==  conAnswer.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  conAnswer.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conAnswer.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conAnswer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAnswer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conAnswer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAnswer.AnswerId)
{
mlngAnswerId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAnswer.AnswerId);
}
else if (strAttributeName  ==  conAnswer.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAnswer.QuestionId);
}
else if (strAttributeName  ==  conAnswer.AnswerIndex)
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conAnswer.AnswerIndex);
}
else if (strAttributeName  ==  conAnswer.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(conAnswer.AnswerOptionId);
}
else if (strAttributeName  ==  conAnswer.AnswerMultiOptions)
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(conAnswer.AnswerMultiOptions);
}
else if (strAttributeName  ==  conAnswer.AnswerFillInBlank)
{
mstrAnswerFillInBlank = value.ToString();
 AddUpdatedFld(conAnswer.AnswerFillInBlank);
}
else if (strAttributeName  ==  conAnswer.AnswerTrueOrFalse)
{
mbolAnswerTrueOrFalse = TransNullToBool(value.ToString());
 AddUpdatedFld(conAnswer.AnswerTrueOrFalse);
}
else if (strAttributeName  ==  conAnswer.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conAnswer.AnswerContent);
}
else if (strAttributeName  ==  conAnswer.IsAutoCorrect)
{
mbolIsAutoCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(conAnswer.IsAutoCorrect);
}
else if (strAttributeName  ==  conAnswer.Provider)
{
mstrProvider = value.ToString();
 AddUpdatedFld(conAnswer.Provider);
}
else if (strAttributeName  ==  conAnswer.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conAnswer.Score);
}
else if (strAttributeName  ==  conAnswer.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conAnswer.IsShow);
}
else if (strAttributeName  ==  conAnswer.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conAnswer.CourseId);
}
else if (strAttributeName  ==  conAnswer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAnswer.UpdDate);
}
else if (strAttributeName  ==  conAnswer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAnswer.UpdUser);
}
else if (strAttributeName  ==  conAnswer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAnswer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAnswer.AnswerId  ==  AttributeName[intIndex])
{
return mlngAnswerId;
}
else if (conAnswer.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conAnswer.AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (conAnswer.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (conAnswer.AnswerMultiOptions  ==  AttributeName[intIndex])
{
return mstrAnswerMultiOptions;
}
else if (conAnswer.AnswerFillInBlank  ==  AttributeName[intIndex])
{
return mstrAnswerFillInBlank;
}
else if (conAnswer.AnswerTrueOrFalse  ==  AttributeName[intIndex])
{
return mbolAnswerTrueOrFalse;
}
else if (conAnswer.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (conAnswer.IsAutoCorrect  ==  AttributeName[intIndex])
{
return mbolIsAutoCorrect;
}
else if (conAnswer.Provider  ==  AttributeName[intIndex])
{
return mstrProvider;
}
else if (conAnswer.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (conAnswer.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conAnswer.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conAnswer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAnswer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conAnswer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAnswer.AnswerId  ==  AttributeName[intIndex])
{
mlngAnswerId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAnswer.AnswerId);
}
else if (conAnswer.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAnswer.QuestionId);
}
else if (conAnswer.AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conAnswer.AnswerIndex);
}
else if (conAnswer.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(conAnswer.AnswerOptionId);
}
else if (conAnswer.AnswerMultiOptions  ==  AttributeName[intIndex])
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(conAnswer.AnswerMultiOptions);
}
else if (conAnswer.AnswerFillInBlank  ==  AttributeName[intIndex])
{
mstrAnswerFillInBlank = value.ToString();
 AddUpdatedFld(conAnswer.AnswerFillInBlank);
}
else if (conAnswer.AnswerTrueOrFalse  ==  AttributeName[intIndex])
{
mbolAnswerTrueOrFalse = TransNullToBool(value.ToString());
 AddUpdatedFld(conAnswer.AnswerTrueOrFalse);
}
else if (conAnswer.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conAnswer.AnswerContent);
}
else if (conAnswer.IsAutoCorrect  ==  AttributeName[intIndex])
{
mbolIsAutoCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(conAnswer.IsAutoCorrect);
}
else if (conAnswer.Provider  ==  AttributeName[intIndex])
{
mstrProvider = value.ToString();
 AddUpdatedFld(conAnswer.Provider);
}
else if (conAnswer.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conAnswer.Score);
}
else if (conAnswer.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conAnswer.IsShow);
}
else if (conAnswer.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conAnswer.CourseId);
}
else if (conAnswer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAnswer.UpdDate);
}
else if (conAnswer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAnswer.UpdUser);
}
else if (conAnswer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAnswer.Memo);
}
}
}

/// <summary>
/// 问答ID(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long AnswerId
{
get
{
return mlngAnswerId;
}
set
{
 mlngAnswerId = value;
//记录修改过的字段
 AddUpdatedFld(conAnswer.AnswerId);
}
}
/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(conAnswer.QuestionId);
}
}
/// <summary>
/// 问答序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int AnswerIndex
{
get
{
return mintAnswerIndex;
}
set
{
 mintAnswerIndex = value;
//记录修改过的字段
 AddUpdatedFld(conAnswer.AnswerIndex);
}
}
/// <summary>
/// 回答选项Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerOptionId
{
get
{
return mstrAnswerOptionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerOptionId = value;
}
else
{
 mstrAnswerOptionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswer.AnswerOptionId);
}
}
/// <summary>
/// 多选项答案(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerMultiOptions
{
get
{
return mstrAnswerMultiOptions;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerMultiOptions = value;
}
else
{
 mstrAnswerMultiOptions = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswer.AnswerMultiOptions);
}
}
/// <summary>
/// 填空题答案(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerFillInBlank
{
get
{
return mstrAnswerFillInBlank;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerFillInBlank = value;
}
else
{
 mstrAnswerFillInBlank = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswer.AnswerFillInBlank);
}
}
/// <summary>
/// 判断题答案(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool AnswerTrueOrFalse
{
get
{
return mbolAnswerTrueOrFalse;
}
set
{
 mbolAnswerTrueOrFalse = value;
//记录修改过的字段
 AddUpdatedFld(conAnswer.AnswerTrueOrFalse);
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
 AddUpdatedFld(conAnswer.AnswerContent);
}
}
/// <summary>
/// 是否支持自动批改(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAutoCorrect
{
get
{
return mbolIsAutoCorrect;
}
set
{
 mbolIsAutoCorrect = value;
//记录修改过的字段
 AddUpdatedFld(conAnswer.IsAutoCorrect);
}
}
/// <summary>
/// 提供者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Provider
{
get
{
return mstrProvider;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProvider = value;
}
else
{
 mstrProvider = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswer.Provider);
}
}
/// <summary>
/// 得分(说明:;字段类型:decimal;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double Score
{
get
{
return mdblScore;
}
set
{
 mdblScore = value;
//记录修改过的字段
 AddUpdatedFld(conAnswer.Score);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(conAnswer.IsShow);
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
 AddUpdatedFld(conAnswer.CourseId);
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
 AddUpdatedFld(conAnswer.UpdDate);
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
 AddUpdatedFld(conAnswer.UpdUser);
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
 AddUpdatedFld(conAnswer.Memo);
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
  return mlngAnswerId.ToString();
 }
 }
}
 /// <summary>
 /// 答案(Answer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAnswer
{
public const string _CurrTabName = "Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerId", "QuestionId", "AnswerIndex", "AnswerOptionId", "AnswerMultiOptions", "AnswerFillInBlank", "AnswerTrueOrFalse", "AnswerContent", "IsAutoCorrect", "Provider", "Score", "IsShow", "CourseId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AnswerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerId = "AnswerId";    //问答ID

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"AnswerIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIndex = "AnswerIndex";    //问答序号

 /// <summary>
 /// 常量:"AnswerOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerOptionId = "AnswerOptionId";    //回答选项Id

 /// <summary>
 /// 常量:"AnswerMultiOptions"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerMultiOptions = "AnswerMultiOptions";    //多选项答案

 /// <summary>
 /// 常量:"AnswerFillInBlank"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerFillInBlank = "AnswerFillInBlank";    //填空题答案

 /// <summary>
 /// 常量:"AnswerTrueOrFalse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTrueOrFalse = "AnswerTrueOrFalse";    //判断题答案

 /// <summary>
 /// 常量:"AnswerContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerContent = "AnswerContent";    //答案内容

 /// <summary>
 /// 常量:"IsAutoCorrect"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAutoCorrect = "IsAutoCorrect";    //是否支持自动批改

 /// <summary>
 /// 常量:"Provider"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Provider = "Provider";    //提供者

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

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