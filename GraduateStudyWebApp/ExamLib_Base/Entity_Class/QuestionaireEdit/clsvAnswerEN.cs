
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAnswerEN
 表名:vAnswer(01120017)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:49
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
 /// 表vAnswer的关键字(AnswerId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerId_vAnswer
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
public K_AnswerId_vAnswer(long lngAnswerId)
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
 /// <returns>返回:[K_AnswerId_vAnswer]类型的对象</returns>
public static implicit operator K_AnswerId_vAnswer(long value)
{
return new K_AnswerId_vAnswer(value);
}
}
 /// <summary>
 /// v答案(vAnswer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvAnswerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vAnswer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 27;
public static string[] AttributeName = new string[] {"AnswerContent", "AnswerId", "QuestionId", "QuestionName", "QuestionMemo", "QuestionTypeId", "QuestionTypeName", "AnswerTypeId", "AnswerTypeName", "GridTitle", "AnswerModeId", "QuestionScore", "AnswerIndex", "AnswerOptionId", "OptionName", "OptionTitle", "AnswerMultiOptions", "IsAutoCorrect", "AnswerFillInBlank", "AnswerTrueOrFalse", "Provider", "Score", "IsShow", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected string mstrAnswerContent;    //答案内容
protected long mlngAnswerId;    //问答ID
protected long? mlngQuestionId;    //题目Id
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionMemo;    //题目说明
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrGridTitle;    //表格标题
protected string mstrAnswerModeId;    //答案模式Id
protected float? mfltQuestionScore;    //题目得分
protected int? mintAnswerIndex;    //问答序号
protected string mstrAnswerOptionId;    //回答选项Id
protected string mstrOptionName;    //选项名称
protected string mstrOptionTitle;    //选项标题
protected string mstrAnswerMultiOptions;    //多选项答案
protected bool mbolIsAutoCorrect;    //是否支持自动批改
protected string mstrAnswerFillInBlank;    //填空题答案
protected bool mbolAnswerTrueOrFalse;    //判断题答案
protected string mstrProvider;    //提供者
protected double? mdblScore;    //得分
protected bool mbolIsShow;    //是否启用
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvAnswerEN()
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
public clsvAnswerEN(long lngAnswerId)
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
if (strAttributeName  ==  convAnswer.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  convAnswer.AnswerId)
{
return mlngAnswerId;
}
else if (strAttributeName  ==  convAnswer.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convAnswer.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convAnswer.QuestionMemo)
{
return mstrQuestionMemo;
}
else if (strAttributeName  ==  convAnswer.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convAnswer.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convAnswer.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convAnswer.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convAnswer.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convAnswer.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convAnswer.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  convAnswer.AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  convAnswer.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  convAnswer.OptionName)
{
return mstrOptionName;
}
else if (strAttributeName  ==  convAnswer.OptionTitle)
{
return mstrOptionTitle;
}
else if (strAttributeName  ==  convAnswer.AnswerMultiOptions)
{
return mstrAnswerMultiOptions;
}
else if (strAttributeName  ==  convAnswer.IsAutoCorrect)
{
return mbolIsAutoCorrect;
}
else if (strAttributeName  ==  convAnswer.AnswerFillInBlank)
{
return mstrAnswerFillInBlank;
}
else if (strAttributeName  ==  convAnswer.AnswerTrueOrFalse)
{
return mbolAnswerTrueOrFalse;
}
else if (strAttributeName  ==  convAnswer.Provider)
{
return mstrProvider;
}
else if (strAttributeName  ==  convAnswer.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  convAnswer.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convAnswer.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convAnswer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convAnswer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convAnswer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convAnswer.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(convAnswer.AnswerContent);
}
else if (strAttributeName  ==  convAnswer.AnswerId)
{
mlngAnswerId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAnswer.AnswerId);
}
else if (strAttributeName  ==  convAnswer.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAnswer.QuestionId);
}
else if (strAttributeName  ==  convAnswer.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convAnswer.QuestionName);
}
else if (strAttributeName  ==  convAnswer.QuestionMemo)
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(convAnswer.QuestionMemo);
}
else if (strAttributeName  ==  convAnswer.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convAnswer.QuestionTypeId);
}
else if (strAttributeName  ==  convAnswer.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convAnswer.QuestionTypeName);
}
else if (strAttributeName  ==  convAnswer.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convAnswer.AnswerTypeId);
}
else if (strAttributeName  ==  convAnswer.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convAnswer.AnswerTypeName);
}
else if (strAttributeName  ==  convAnswer.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convAnswer.GridTitle);
}
else if (strAttributeName  ==  convAnswer.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convAnswer.AnswerModeId);
}
else if (strAttributeName  ==  convAnswer.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convAnswer.QuestionScore);
}
else if (strAttributeName  ==  convAnswer.AnswerIndex)
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convAnswer.AnswerIndex);
}
else if (strAttributeName  ==  convAnswer.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(convAnswer.AnswerOptionId);
}
else if (strAttributeName  ==  convAnswer.OptionName)
{
mstrOptionName = value.ToString();
 AddUpdatedFld(convAnswer.OptionName);
}
else if (strAttributeName  ==  convAnswer.OptionTitle)
{
mstrOptionTitle = value.ToString();
 AddUpdatedFld(convAnswer.OptionTitle);
}
else if (strAttributeName  ==  convAnswer.AnswerMultiOptions)
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(convAnswer.AnswerMultiOptions);
}
else if (strAttributeName  ==  convAnswer.IsAutoCorrect)
{
mbolIsAutoCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(convAnswer.IsAutoCorrect);
}
else if (strAttributeName  ==  convAnswer.AnswerFillInBlank)
{
mstrAnswerFillInBlank = value.ToString();
 AddUpdatedFld(convAnswer.AnswerFillInBlank);
}
else if (strAttributeName  ==  convAnswer.AnswerTrueOrFalse)
{
mbolAnswerTrueOrFalse = TransNullToBool(value.ToString());
 AddUpdatedFld(convAnswer.AnswerTrueOrFalse);
}
else if (strAttributeName  ==  convAnswer.Provider)
{
mstrProvider = value.ToString();
 AddUpdatedFld(convAnswer.Provider);
}
else if (strAttributeName  ==  convAnswer.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convAnswer.Score);
}
else if (strAttributeName  ==  convAnswer.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convAnswer.IsShow);
}
else if (strAttributeName  ==  convAnswer.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convAnswer.CourseId);
}
else if (strAttributeName  ==  convAnswer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convAnswer.UpdDate);
}
else if (strAttributeName  ==  convAnswer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convAnswer.UpdUser);
}
else if (strAttributeName  ==  convAnswer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convAnswer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convAnswer.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (convAnswer.AnswerId  ==  AttributeName[intIndex])
{
return mlngAnswerId;
}
else if (convAnswer.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convAnswer.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convAnswer.QuestionMemo  ==  AttributeName[intIndex])
{
return mstrQuestionMemo;
}
else if (convAnswer.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convAnswer.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convAnswer.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convAnswer.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convAnswer.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convAnswer.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convAnswer.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (convAnswer.AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (convAnswer.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (convAnswer.OptionName  ==  AttributeName[intIndex])
{
return mstrOptionName;
}
else if (convAnswer.OptionTitle  ==  AttributeName[intIndex])
{
return mstrOptionTitle;
}
else if (convAnswer.AnswerMultiOptions  ==  AttributeName[intIndex])
{
return mstrAnswerMultiOptions;
}
else if (convAnswer.IsAutoCorrect  ==  AttributeName[intIndex])
{
return mbolIsAutoCorrect;
}
else if (convAnswer.AnswerFillInBlank  ==  AttributeName[intIndex])
{
return mstrAnswerFillInBlank;
}
else if (convAnswer.AnswerTrueOrFalse  ==  AttributeName[intIndex])
{
return mbolAnswerTrueOrFalse;
}
else if (convAnswer.Provider  ==  AttributeName[intIndex])
{
return mstrProvider;
}
else if (convAnswer.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (convAnswer.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convAnswer.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convAnswer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convAnswer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convAnswer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convAnswer.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(convAnswer.AnswerContent);
}
else if (convAnswer.AnswerId  ==  AttributeName[intIndex])
{
mlngAnswerId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAnswer.AnswerId);
}
else if (convAnswer.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAnswer.QuestionId);
}
else if (convAnswer.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convAnswer.QuestionName);
}
else if (convAnswer.QuestionMemo  ==  AttributeName[intIndex])
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(convAnswer.QuestionMemo);
}
else if (convAnswer.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convAnswer.QuestionTypeId);
}
else if (convAnswer.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convAnswer.QuestionTypeName);
}
else if (convAnswer.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convAnswer.AnswerTypeId);
}
else if (convAnswer.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convAnswer.AnswerTypeName);
}
else if (convAnswer.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convAnswer.GridTitle);
}
else if (convAnswer.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convAnswer.AnswerModeId);
}
else if (convAnswer.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convAnswer.QuestionScore);
}
else if (convAnswer.AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convAnswer.AnswerIndex);
}
else if (convAnswer.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(convAnswer.AnswerOptionId);
}
else if (convAnswer.OptionName  ==  AttributeName[intIndex])
{
mstrOptionName = value.ToString();
 AddUpdatedFld(convAnswer.OptionName);
}
else if (convAnswer.OptionTitle  ==  AttributeName[intIndex])
{
mstrOptionTitle = value.ToString();
 AddUpdatedFld(convAnswer.OptionTitle);
}
else if (convAnswer.AnswerMultiOptions  ==  AttributeName[intIndex])
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(convAnswer.AnswerMultiOptions);
}
else if (convAnswer.IsAutoCorrect  ==  AttributeName[intIndex])
{
mbolIsAutoCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(convAnswer.IsAutoCorrect);
}
else if (convAnswer.AnswerFillInBlank  ==  AttributeName[intIndex])
{
mstrAnswerFillInBlank = value.ToString();
 AddUpdatedFld(convAnswer.AnswerFillInBlank);
}
else if (convAnswer.AnswerTrueOrFalse  ==  AttributeName[intIndex])
{
mbolAnswerTrueOrFalse = TransNullToBool(value.ToString());
 AddUpdatedFld(convAnswer.AnswerTrueOrFalse);
}
else if (convAnswer.Provider  ==  AttributeName[intIndex])
{
mstrProvider = value.ToString();
 AddUpdatedFld(convAnswer.Provider);
}
else if (convAnswer.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convAnswer.Score);
}
else if (convAnswer.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convAnswer.IsShow);
}
else if (convAnswer.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convAnswer.CourseId);
}
else if (convAnswer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convAnswer.UpdDate);
}
else if (convAnswer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convAnswer.UpdUser);
}
else if (convAnswer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convAnswer.Memo);
}
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
 AddUpdatedFld(convAnswer.AnswerContent);
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
 AddUpdatedFld(convAnswer.AnswerId);
}
}
/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(convAnswer.QuestionId);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionName = value;
}
else
{
 mstrQuestionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAnswer.QuestionName);
}
}
/// <summary>
/// 题目说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionMemo
{
get
{
return mstrQuestionMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionMemo = value;
}
else
{
 mstrQuestionMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(convAnswer.QuestionMemo);
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
 AddUpdatedFld(convAnswer.QuestionTypeId);
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
 AddUpdatedFld(convAnswer.QuestionTypeName);
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
 AddUpdatedFld(convAnswer.AnswerTypeId);
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
 AddUpdatedFld(convAnswer.AnswerTypeName);
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
 AddUpdatedFld(convAnswer.GridTitle);
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
 AddUpdatedFld(convAnswer.AnswerModeId);
}
}
/// <summary>
/// 题目得分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? QuestionScore
{
get
{
return mfltQuestionScore;
}
set
{
 mfltQuestionScore = value;
//记录修改过的字段
 AddUpdatedFld(convAnswer.QuestionScore);
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
 AddUpdatedFld(convAnswer.AnswerIndex);
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
 AddUpdatedFld(convAnswer.AnswerOptionId);
}
}
/// <summary>
/// 选项名称(说明:;字段类型:varchar;字段长度:4000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptionName
{
get
{
return mstrOptionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptionName = value;
}
else
{
 mstrOptionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAnswer.OptionName);
}
}
/// <summary>
/// 选项标题(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptionTitle
{
get
{
return mstrOptionTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptionTitle = value;
}
else
{
 mstrOptionTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convAnswer.OptionTitle);
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
 AddUpdatedFld(convAnswer.AnswerMultiOptions);
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
 AddUpdatedFld(convAnswer.IsAutoCorrect);
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
 AddUpdatedFld(convAnswer.AnswerFillInBlank);
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
 AddUpdatedFld(convAnswer.AnswerTrueOrFalse);
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
 AddUpdatedFld(convAnswer.Provider);
}
}
/// <summary>
/// 得分(说明:;字段类型:decimal;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Score
{
get
{
return mdblScore;
}
set
{
 mdblScore = value;
//记录修改过的字段
 AddUpdatedFld(convAnswer.Score);
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
 AddUpdatedFld(convAnswer.IsShow);
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
 AddUpdatedFld(convAnswer.CourseId);
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
 AddUpdatedFld(convAnswer.UpdDate);
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
 AddUpdatedFld(convAnswer.UpdUser);
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
 AddUpdatedFld(convAnswer.Memo);
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
 /// v答案(vAnswer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convAnswer
{
public const string _CurrTabName = "vAnswer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerContent", "AnswerId", "QuestionId", "QuestionName", "QuestionMemo", "QuestionTypeId", "QuestionTypeName", "AnswerTypeId", "AnswerTypeName", "GridTitle", "AnswerModeId", "QuestionScore", "AnswerIndex", "AnswerOptionId", "OptionName", "OptionTitle", "AnswerMultiOptions", "IsAutoCorrect", "AnswerFillInBlank", "AnswerTrueOrFalse", "Provider", "Score", "IsShow", "CourseId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AnswerContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerContent = "AnswerContent";    //答案内容

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
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"QuestionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionMemo = "QuestionMemo";    //题目说明

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName = "QuestionTypeName";    //题目类型名

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"AnswerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeName = "AnswerTypeName";    //答案类型名

 /// <summary>
 /// 常量:"GridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GridTitle = "GridTitle";    //表格标题

 /// <summary>
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"QuestionScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionScore = "QuestionScore";    //题目得分

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
 /// 常量:"OptionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionName = "OptionName";    //选项名称

 /// <summary>
 /// 常量:"OptionTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionTitle = "OptionTitle";    //选项标题

 /// <summary>
 /// 常量:"AnswerMultiOptions"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerMultiOptions = "AnswerMultiOptions";    //多选项答案

 /// <summary>
 /// 常量:"IsAutoCorrect"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAutoCorrect = "IsAutoCorrect";    //是否支持自动批改

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