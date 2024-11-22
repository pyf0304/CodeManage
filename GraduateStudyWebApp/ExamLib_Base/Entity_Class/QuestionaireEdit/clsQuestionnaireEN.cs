
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireEN
 表名:Questionnaire(01120001)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:16
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
 /// 表Questionnaire的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_Questionnaire
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngQuestionId">表关键字</param>
public K_QuestionId_Questionnaire(long lngQuestionId)
{
if (IsValid(lngQuestionId)) Value = lngQuestionId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngQuestionId)
{
if (lngQuestionId == 0) return false;
if (lngQuestionId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionId_Questionnaire]类型的对象</returns>
public static implicit operator K_QuestionId_Questionnaire(long value)
{
return new K_QuestionId_Questionnaire(value);
}
}
 /// <summary>
 /// 题目(Questionnaire)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionnaireEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Questionnaire"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 52;
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "QuestionMemo", "QuestionNo", "ParentQuestionId", "ExamAnswer", "CourseId", "LevelNo", "CourseChapterId", "QuestionTypeId", "QuestionTypeId4Course", "AnswerTypeId", "GridTitle", "AnswerModeId", "IsHaveAdditionalMemo", "QuestionScore", "DefaultValue", "DefaultSelectItem", "IsShow", "IsCast", "LikeCount", "AnswerAttLimitSize", "LimitedResourceType", "IsEffective", "IsCanInPaper", "ExamGradeId", "TextDirectId", "UpdDate", "UpdUser", "Memo", "QuestionCode", "DifficultyLevelId", "SectionTypeId", "KnowledgeGraphId", "FirstIndent", "QuestionNameAdd", "CodeTab", "CodeTabCode", "CodeTabCondition", "CodeTabName", "FillInTextHeight", "FillInTextWidth", "IsMulti4FillInText", "CheckBoxLimitCount", "IsJs", "MemoTextWidth", "RelaEvent", "IsTest", "LevelModeTypeId", "IsRandom"};

protected long mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionContent;    //题目内容
protected string mstrQuestionMemo;    //题目说明
protected string mstrQuestionNo;    //题目编号
protected string mstrParentQuestionId;    //父题目Id
protected string mstrExamAnswer;    //题目答案
protected string mstrCourseId;    //课程Id
protected int? mintLevelNo;    //学习关号2
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrGridTitle;    //表格标题
protected string mstrAnswerModeId;    //答案模式Id
protected bool mbolIsHaveAdditionalMemo;    //是否有附加说明
protected float? mfltQuestionScore;    //题目得分
protected string mstrDefaultValue;    //缺省值
protected string mstrDefaultSelectItem;    //默认选项
protected bool mbolIsShow;    //是否启用
protected bool mbolIsCast;    //是否播放
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngAnswerAttLimitSize;    //回答附件限制大小
protected string mstrLimitedResourceType;    //限制资源类型
protected bool mbolIsEffective;    //是否有效
protected bool mbolIsCanInPaper;    //是否可在Paper
protected string mstrExamGradeId;    //题库等级ID
protected string mstrTextDirectId;    //文本方向ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrQuestionCode;    //html代码
protected string mstrDifficultyLevelId;    //难度等级Id
protected string mstrSectionTypeId;    //节点类型Id
protected string mstrKnowledgeGraphId;    //知识点图Id
protected bool mbolFirstIndent;    //首行缩进
protected string mstrQuestionNameAdd;    //题目补充
protected string mstrCodeTab;    //代码表
protected string mstrCodeTabCode;    //CodeTab_Code
protected string mstrCodeTabCondition;    //代码表_条件
protected string mstrCodeTabName;    //CodeTab_Name
protected int? mintFillInTextHeight;    //填空框高度
protected int? mintFillInTextWidth;    //填空框宽度
protected bool mbolIsMulti4FillInText;    //是否填空框多行
protected int? mintCheckBoxLimitCount;    //复选框限制数
protected bool mbolIsJs;    //是否是JS
protected int? mintMemoTextWidth;    //备注框宽度
protected string mstrRelaEvent;    //相关事件
protected bool mbolIsTest;    //是否测试
protected string mstrLevelModeTypeId;    //模式Id
protected bool mbolIsRandom;    //是否随机

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionnaireEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngQuestionId">关键字:题目Id</param>
public clsQuestionnaireEN(long lngQuestionId)
 {
 if (lngQuestionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngQuestionId = lngQuestionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
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
if (strAttributeName  ==  conQuestionnaire.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionMemo)
{
return mstrQuestionMemo;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  conQuestionnaire.ParentQuestionId)
{
return mstrParentQuestionId;
}
else if (strAttributeName  ==  conQuestionnaire.ExamAnswer)
{
return mstrExamAnswer;
}
else if (strAttributeName  ==  conQuestionnaire.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conQuestionnaire.LevelNo)
{
return mintLevelNo;
}
else if (strAttributeName  ==  conQuestionnaire.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  conQuestionnaire.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  conQuestionnaire.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  conQuestionnaire.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  conQuestionnaire.IsHaveAdditionalMemo)
{
return mbolIsHaveAdditionalMemo;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  conQuestionnaire.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  conQuestionnaire.DefaultSelectItem)
{
return mstrDefaultSelectItem;
}
else if (strAttributeName  ==  conQuestionnaire.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conQuestionnaire.IsCast)
{
return mbolIsCast;
}
else if (strAttributeName  ==  conQuestionnaire.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  conQuestionnaire.AnswerAttLimitSize)
{
return mlngAnswerAttLimitSize;
}
else if (strAttributeName  ==  conQuestionnaire.LimitedResourceType)
{
return mstrLimitedResourceType;
}
else if (strAttributeName  ==  conQuestionnaire.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  conQuestionnaire.IsCanInPaper)
{
return mbolIsCanInPaper;
}
else if (strAttributeName  ==  conQuestionnaire.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  conQuestionnaire.TextDirectId)
{
return mstrTextDirectId;
}
else if (strAttributeName  ==  conQuestionnaire.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQuestionnaire.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQuestionnaire.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionCode)
{
return mstrQuestionCode;
}
else if (strAttributeName  ==  conQuestionnaire.DifficultyLevelId)
{
return mstrDifficultyLevelId;
}
else if (strAttributeName  ==  conQuestionnaire.SectionTypeId)
{
return mstrSectionTypeId;
}
else if (strAttributeName  ==  conQuestionnaire.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  conQuestionnaire.FirstIndent)
{
return mbolFirstIndent;
}
else if (strAttributeName  ==  conQuestionnaire.QuestionNameAdd)
{
return mstrQuestionNameAdd;
}
else if (strAttributeName  ==  conQuestionnaire.CodeTab)
{
return mstrCodeTab;
}
else if (strAttributeName  ==  conQuestionnaire.CodeTabCode)
{
return mstrCodeTabCode;
}
else if (strAttributeName  ==  conQuestionnaire.CodeTabCondition)
{
return mstrCodeTabCondition;
}
else if (strAttributeName  ==  conQuestionnaire.CodeTabName)
{
return mstrCodeTabName;
}
else if (strAttributeName  ==  conQuestionnaire.FillInTextHeight)
{
return mintFillInTextHeight;
}
else if (strAttributeName  ==  conQuestionnaire.FillInTextWidth)
{
return mintFillInTextWidth;
}
else if (strAttributeName  ==  conQuestionnaire.IsMulti4FillInText)
{
return mbolIsMulti4FillInText;
}
else if (strAttributeName  ==  conQuestionnaire.CheckBoxLimitCount)
{
return mintCheckBoxLimitCount;
}
else if (strAttributeName  ==  conQuestionnaire.IsJs)
{
return mbolIsJs;
}
else if (strAttributeName  ==  conQuestionnaire.MemoTextWidth)
{
return mintMemoTextWidth;
}
else if (strAttributeName  ==  conQuestionnaire.RelaEvent)
{
return mstrRelaEvent;
}
else if (strAttributeName  ==  conQuestionnaire.IsTest)
{
return mbolIsTest;
}
else if (strAttributeName  ==  conQuestionnaire.LevelModeTypeId)
{
return mstrLevelModeTypeId;
}
else if (strAttributeName  ==  conQuestionnaire.IsRandom)
{
return mbolIsRandom;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionnaire.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.QuestionId);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.QuestionIndex);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionName);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionContent);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionMemo)
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionMemo);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionNo);
}
else if (strAttributeName  ==  conQuestionnaire.ParentQuestionId)
{
mstrParentQuestionId = value.ToString();
 AddUpdatedFld(conQuestionnaire.ParentQuestionId);
}
else if (strAttributeName  ==  conQuestionnaire.ExamAnswer)
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(conQuestionnaire.ExamAnswer);
}
else if (strAttributeName  ==  conQuestionnaire.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conQuestionnaire.CourseId);
}
else if (strAttributeName  ==  conQuestionnaire.LevelNo)
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.LevelNo);
}
else if (strAttributeName  ==  conQuestionnaire.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conQuestionnaire.CourseChapterId);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionTypeId);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionTypeId4Course);
}
else if (strAttributeName  ==  conQuestionnaire.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.AnswerTypeId);
}
else if (strAttributeName  ==  conQuestionnaire.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(conQuestionnaire.GridTitle);
}
else if (strAttributeName  ==  conQuestionnaire.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.AnswerModeId);
}
else if (strAttributeName  ==  conQuestionnaire.IsHaveAdditionalMemo)
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsHaveAdditionalMemo);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conQuestionnaire.QuestionScore);
}
else if (strAttributeName  ==  conQuestionnaire.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conQuestionnaire.DefaultValue);
}
else if (strAttributeName  ==  conQuestionnaire.DefaultSelectItem)
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(conQuestionnaire.DefaultSelectItem);
}
else if (strAttributeName  ==  conQuestionnaire.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsShow);
}
else if (strAttributeName  ==  conQuestionnaire.IsCast)
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsCast);
}
else if (strAttributeName  ==  conQuestionnaire.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.LikeCount);
}
else if (strAttributeName  ==  conQuestionnaire.AnswerAttLimitSize)
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.AnswerAttLimitSize);
}
else if (strAttributeName  ==  conQuestionnaire.LimitedResourceType)
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(conQuestionnaire.LimitedResourceType);
}
else if (strAttributeName  ==  conQuestionnaire.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsEffective);
}
else if (strAttributeName  ==  conQuestionnaire.IsCanInPaper)
{
mbolIsCanInPaper = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsCanInPaper);
}
else if (strAttributeName  ==  conQuestionnaire.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.ExamGradeId);
}
else if (strAttributeName  ==  conQuestionnaire.TextDirectId)
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(conQuestionnaire.TextDirectId);
}
else if (strAttributeName  ==  conQuestionnaire.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionnaire.UpdDate);
}
else if (strAttributeName  ==  conQuestionnaire.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionnaire.UpdUser);
}
else if (strAttributeName  ==  conQuestionnaire.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionnaire.Memo);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionCode)
{
mstrQuestionCode = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionCode);
}
else if (strAttributeName  ==  conQuestionnaire.DifficultyLevelId)
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(conQuestionnaire.DifficultyLevelId);
}
else if (strAttributeName  ==  conQuestionnaire.SectionTypeId)
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.SectionTypeId);
}
else if (strAttributeName  ==  conQuestionnaire.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(conQuestionnaire.KnowledgeGraphId);
}
else if (strAttributeName  ==  conQuestionnaire.FirstIndent)
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.FirstIndent);
}
else if (strAttributeName  ==  conQuestionnaire.QuestionNameAdd)
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionNameAdd);
}
else if (strAttributeName  ==  conQuestionnaire.CodeTab)
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(conQuestionnaire.CodeTab);
}
else if (strAttributeName  ==  conQuestionnaire.CodeTabCode)
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(conQuestionnaire.CodeTabCode);
}
else if (strAttributeName  ==  conQuestionnaire.CodeTabCondition)
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(conQuestionnaire.CodeTabCondition);
}
else if (strAttributeName  ==  conQuestionnaire.CodeTabName)
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(conQuestionnaire.CodeTabName);
}
else if (strAttributeName  ==  conQuestionnaire.FillInTextHeight)
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.FillInTextHeight);
}
else if (strAttributeName  ==  conQuestionnaire.FillInTextWidth)
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.FillInTextWidth);
}
else if (strAttributeName  ==  conQuestionnaire.IsMulti4FillInText)
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsMulti4FillInText);
}
else if (strAttributeName  ==  conQuestionnaire.CheckBoxLimitCount)
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.CheckBoxLimitCount);
}
else if (strAttributeName  ==  conQuestionnaire.IsJs)
{
mbolIsJs = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsJs);
}
else if (strAttributeName  ==  conQuestionnaire.MemoTextWidth)
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.MemoTextWidth);
}
else if (strAttributeName  ==  conQuestionnaire.RelaEvent)
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(conQuestionnaire.RelaEvent);
}
else if (strAttributeName  ==  conQuestionnaire.IsTest)
{
mbolIsTest = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsTest);
}
else if (strAttributeName  ==  conQuestionnaire.LevelModeTypeId)
{
mstrLevelModeTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.LevelModeTypeId);
}
else if (strAttributeName  ==  conQuestionnaire.IsRandom)
{
mbolIsRandom = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsRandom);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionnaire.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conQuestionnaire.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (conQuestionnaire.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (conQuestionnaire.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (conQuestionnaire.QuestionMemo  ==  AttributeName[intIndex])
{
return mstrQuestionMemo;
}
else if (conQuestionnaire.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (conQuestionnaire.ParentQuestionId  ==  AttributeName[intIndex])
{
return mstrParentQuestionId;
}
else if (conQuestionnaire.ExamAnswer  ==  AttributeName[intIndex])
{
return mstrExamAnswer;
}
else if (conQuestionnaire.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conQuestionnaire.LevelNo  ==  AttributeName[intIndex])
{
return mintLevelNo;
}
else if (conQuestionnaire.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (conQuestionnaire.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (conQuestionnaire.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (conQuestionnaire.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (conQuestionnaire.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (conQuestionnaire.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (conQuestionnaire.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
return mbolIsHaveAdditionalMemo;
}
else if (conQuestionnaire.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (conQuestionnaire.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (conQuestionnaire.DefaultSelectItem  ==  AttributeName[intIndex])
{
return mstrDefaultSelectItem;
}
else if (conQuestionnaire.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conQuestionnaire.IsCast  ==  AttributeName[intIndex])
{
return mbolIsCast;
}
else if (conQuestionnaire.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (conQuestionnaire.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
return mlngAnswerAttLimitSize;
}
else if (conQuestionnaire.LimitedResourceType  ==  AttributeName[intIndex])
{
return mstrLimitedResourceType;
}
else if (conQuestionnaire.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (conQuestionnaire.IsCanInPaper  ==  AttributeName[intIndex])
{
return mbolIsCanInPaper;
}
else if (conQuestionnaire.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (conQuestionnaire.TextDirectId  ==  AttributeName[intIndex])
{
return mstrTextDirectId;
}
else if (conQuestionnaire.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQuestionnaire.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQuestionnaire.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQuestionnaire.QuestionCode  ==  AttributeName[intIndex])
{
return mstrQuestionCode;
}
else if (conQuestionnaire.DifficultyLevelId  ==  AttributeName[intIndex])
{
return mstrDifficultyLevelId;
}
else if (conQuestionnaire.SectionTypeId  ==  AttributeName[intIndex])
{
return mstrSectionTypeId;
}
else if (conQuestionnaire.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (conQuestionnaire.FirstIndent  ==  AttributeName[intIndex])
{
return mbolFirstIndent;
}
else if (conQuestionnaire.QuestionNameAdd  ==  AttributeName[intIndex])
{
return mstrQuestionNameAdd;
}
else if (conQuestionnaire.CodeTab  ==  AttributeName[intIndex])
{
return mstrCodeTab;
}
else if (conQuestionnaire.CodeTabCode  ==  AttributeName[intIndex])
{
return mstrCodeTabCode;
}
else if (conQuestionnaire.CodeTabCondition  ==  AttributeName[intIndex])
{
return mstrCodeTabCondition;
}
else if (conQuestionnaire.CodeTabName  ==  AttributeName[intIndex])
{
return mstrCodeTabName;
}
else if (conQuestionnaire.FillInTextHeight  ==  AttributeName[intIndex])
{
return mintFillInTextHeight;
}
else if (conQuestionnaire.FillInTextWidth  ==  AttributeName[intIndex])
{
return mintFillInTextWidth;
}
else if (conQuestionnaire.IsMulti4FillInText  ==  AttributeName[intIndex])
{
return mbolIsMulti4FillInText;
}
else if (conQuestionnaire.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
return mintCheckBoxLimitCount;
}
else if (conQuestionnaire.IsJs  ==  AttributeName[intIndex])
{
return mbolIsJs;
}
else if (conQuestionnaire.MemoTextWidth  ==  AttributeName[intIndex])
{
return mintMemoTextWidth;
}
else if (conQuestionnaire.RelaEvent  ==  AttributeName[intIndex])
{
return mstrRelaEvent;
}
else if (conQuestionnaire.IsTest  ==  AttributeName[intIndex])
{
return mbolIsTest;
}
else if (conQuestionnaire.LevelModeTypeId  ==  AttributeName[intIndex])
{
return mstrLevelModeTypeId;
}
else if (conQuestionnaire.IsRandom  ==  AttributeName[intIndex])
{
return mbolIsRandom;
}
return null;
}
set
{
if (conQuestionnaire.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.QuestionId);
}
else if (conQuestionnaire.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.QuestionIndex);
}
else if (conQuestionnaire.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionName);
}
else if (conQuestionnaire.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionContent);
}
else if (conQuestionnaire.QuestionMemo  ==  AttributeName[intIndex])
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionMemo);
}
else if (conQuestionnaire.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionNo);
}
else if (conQuestionnaire.ParentQuestionId  ==  AttributeName[intIndex])
{
mstrParentQuestionId = value.ToString();
 AddUpdatedFld(conQuestionnaire.ParentQuestionId);
}
else if (conQuestionnaire.ExamAnswer  ==  AttributeName[intIndex])
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(conQuestionnaire.ExamAnswer);
}
else if (conQuestionnaire.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conQuestionnaire.CourseId);
}
else if (conQuestionnaire.LevelNo  ==  AttributeName[intIndex])
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.LevelNo);
}
else if (conQuestionnaire.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conQuestionnaire.CourseChapterId);
}
else if (conQuestionnaire.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionTypeId);
}
else if (conQuestionnaire.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionTypeId4Course);
}
else if (conQuestionnaire.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.AnswerTypeId);
}
else if (conQuestionnaire.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(conQuestionnaire.GridTitle);
}
else if (conQuestionnaire.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.AnswerModeId);
}
else if (conQuestionnaire.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsHaveAdditionalMemo);
}
else if (conQuestionnaire.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conQuestionnaire.QuestionScore);
}
else if (conQuestionnaire.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conQuestionnaire.DefaultValue);
}
else if (conQuestionnaire.DefaultSelectItem  ==  AttributeName[intIndex])
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(conQuestionnaire.DefaultSelectItem);
}
else if (conQuestionnaire.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsShow);
}
else if (conQuestionnaire.IsCast  ==  AttributeName[intIndex])
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsCast);
}
else if (conQuestionnaire.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.LikeCount);
}
else if (conQuestionnaire.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.AnswerAttLimitSize);
}
else if (conQuestionnaire.LimitedResourceType  ==  AttributeName[intIndex])
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(conQuestionnaire.LimitedResourceType);
}
else if (conQuestionnaire.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsEffective);
}
else if (conQuestionnaire.IsCanInPaper  ==  AttributeName[intIndex])
{
mbolIsCanInPaper = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsCanInPaper);
}
else if (conQuestionnaire.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.ExamGradeId);
}
else if (conQuestionnaire.TextDirectId  ==  AttributeName[intIndex])
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(conQuestionnaire.TextDirectId);
}
else if (conQuestionnaire.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionnaire.UpdDate);
}
else if (conQuestionnaire.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionnaire.UpdUser);
}
else if (conQuestionnaire.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionnaire.Memo);
}
else if (conQuestionnaire.QuestionCode  ==  AttributeName[intIndex])
{
mstrQuestionCode = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionCode);
}
else if (conQuestionnaire.DifficultyLevelId  ==  AttributeName[intIndex])
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(conQuestionnaire.DifficultyLevelId);
}
else if (conQuestionnaire.SectionTypeId  ==  AttributeName[intIndex])
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.SectionTypeId);
}
else if (conQuestionnaire.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(conQuestionnaire.KnowledgeGraphId);
}
else if (conQuestionnaire.FirstIndent  ==  AttributeName[intIndex])
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.FirstIndent);
}
else if (conQuestionnaire.QuestionNameAdd  ==  AttributeName[intIndex])
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(conQuestionnaire.QuestionNameAdd);
}
else if (conQuestionnaire.CodeTab  ==  AttributeName[intIndex])
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(conQuestionnaire.CodeTab);
}
else if (conQuestionnaire.CodeTabCode  ==  AttributeName[intIndex])
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(conQuestionnaire.CodeTabCode);
}
else if (conQuestionnaire.CodeTabCondition  ==  AttributeName[intIndex])
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(conQuestionnaire.CodeTabCondition);
}
else if (conQuestionnaire.CodeTabName  ==  AttributeName[intIndex])
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(conQuestionnaire.CodeTabName);
}
else if (conQuestionnaire.FillInTextHeight  ==  AttributeName[intIndex])
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.FillInTextHeight);
}
else if (conQuestionnaire.FillInTextWidth  ==  AttributeName[intIndex])
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.FillInTextWidth);
}
else if (conQuestionnaire.IsMulti4FillInText  ==  AttributeName[intIndex])
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsMulti4FillInText);
}
else if (conQuestionnaire.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.CheckBoxLimitCount);
}
else if (conQuestionnaire.IsJs  ==  AttributeName[intIndex])
{
mbolIsJs = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsJs);
}
else if (conQuestionnaire.MemoTextWidth  ==  AttributeName[intIndex])
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaire.MemoTextWidth);
}
else if (conQuestionnaire.RelaEvent  ==  AttributeName[intIndex])
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(conQuestionnaire.RelaEvent);
}
else if (conQuestionnaire.IsTest  ==  AttributeName[intIndex])
{
mbolIsTest = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsTest);
}
else if (conQuestionnaire.LevelModeTypeId  ==  AttributeName[intIndex])
{
mstrLevelModeTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaire.LevelModeTypeId);
}
else if (conQuestionnaire.IsRandom  ==  AttributeName[intIndex])
{
mbolIsRandom = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaire.IsRandom);
}
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
 AddUpdatedFld(conQuestionnaire.QuestionId);
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
 AddUpdatedFld(conQuestionnaire.QuestionIndex);
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
 AddUpdatedFld(conQuestionnaire.QuestionName);
}
}
/// <summary>
/// 题目内容(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionContent
{
get
{
return mstrQuestionContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionContent = value;
}
else
{
 mstrQuestionContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.QuestionContent);
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
 AddUpdatedFld(conQuestionnaire.QuestionMemo);
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
 AddUpdatedFld(conQuestionnaire.QuestionNo);
}
}
/// <summary>
/// 父题目Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentQuestionId
{
get
{
return mstrParentQuestionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentQuestionId = value;
}
else
{
 mstrParentQuestionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.ParentQuestionId);
}
}
/// <summary>
/// 题目答案(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamAnswer
{
get
{
return mstrExamAnswer;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamAnswer = value;
}
else
{
 mstrExamAnswer = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.ExamAnswer);
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
 AddUpdatedFld(conQuestionnaire.CourseId);
}
}
/// <summary>
/// 学习关号2(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LevelNo
{
get
{
return mintLevelNo;
}
set
{
 mintLevelNo = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.LevelNo);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.CourseChapterId);
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
 AddUpdatedFld(conQuestionnaire.QuestionTypeId);
}
}
/// <summary>
/// 题目类型Id4课程(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId4Course
{
get
{
return mstrQuestionTypeId4Course;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId4Course = value;
}
else
{
 mstrQuestionTypeId4Course = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.QuestionTypeId4Course);
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
 AddUpdatedFld(conQuestionnaire.AnswerTypeId);
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
 AddUpdatedFld(conQuestionnaire.GridTitle);
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
 AddUpdatedFld(conQuestionnaire.AnswerModeId);
}
}
/// <summary>
/// 是否有附加说明(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveAdditionalMemo
{
get
{
return mbolIsHaveAdditionalMemo;
}
set
{
 mbolIsHaveAdditionalMemo = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.IsHaveAdditionalMemo);
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
 AddUpdatedFld(conQuestionnaire.QuestionScore);
}
}
/// <summary>
/// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaultValue
{
get
{
return mstrDefaultValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaultValue = value;
}
else
{
 mstrDefaultValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.DefaultValue);
}
}
/// <summary>
/// 默认选项(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaultSelectItem
{
get
{
return mstrDefaultSelectItem;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaultSelectItem = value;
}
else
{
 mstrDefaultSelectItem = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.DefaultSelectItem);
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
 AddUpdatedFld(conQuestionnaire.IsShow);
}
}
/// <summary>
/// 是否播放(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCast
{
get
{
return mbolIsCast;
}
set
{
 mbolIsCast = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.IsCast);
}
}
/// <summary>
/// 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? LikeCount
{
get
{
return mlngLikeCount;
}
set
{
 mlngLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.LikeCount);
}
}
/// <summary>
/// 回答附件限制大小(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? AnswerAttLimitSize
{
get
{
return mlngAnswerAttLimitSize;
}
set
{
 mlngAnswerAttLimitSize = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.AnswerAttLimitSize);
}
}
/// <summary>
/// 限制资源类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LimitedResourceType
{
get
{
return mstrLimitedResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLimitedResourceType = value;
}
else
{
 mstrLimitedResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.LimitedResourceType);
}
}
/// <summary>
/// 是否有效(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsEffective
{
get
{
return mbolIsEffective;
}
set
{
 mbolIsEffective = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.IsEffective);
}
}
/// <summary>
/// 是否可在Paper(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCanInPaper
{
get
{
return mbolIsCanInPaper;
}
set
{
 mbolIsCanInPaper = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.IsCanInPaper);
}
}
/// <summary>
/// 题库等级ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamGradeId
{
get
{
return mstrExamGradeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamGradeId = value;
}
else
{
 mstrExamGradeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.ExamGradeId);
}
}
/// <summary>
/// 文本方向ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextDirectId
{
get
{
return mstrTextDirectId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextDirectId = value;
}
else
{
 mstrTextDirectId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.TextDirectId);
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
 AddUpdatedFld(conQuestionnaire.UpdDate);
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
 AddUpdatedFld(conQuestionnaire.UpdUser);
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
 AddUpdatedFld(conQuestionnaire.Memo);
}
}
/// <summary>
/// html代码(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionCode
{
get
{
return mstrQuestionCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionCode = value;
}
else
{
 mstrQuestionCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.QuestionCode);
}
}
/// <summary>
/// 难度等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DifficultyLevelId
{
get
{
return mstrDifficultyLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDifficultyLevelId = value;
}
else
{
 mstrDifficultyLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.DifficultyLevelId);
}
}
/// <summary>
/// 节点类型Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionTypeId
{
get
{
return mstrSectionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionTypeId = value;
}
else
{
 mstrSectionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.SectionTypeId);
}
}
/// <summary>
/// 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeGraphId
{
get
{
return mstrKnowledgeGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeGraphId = value;
}
else
{
 mstrKnowledgeGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.KnowledgeGraphId);
}
}
/// <summary>
/// 首行缩进(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool FirstIndent
{
get
{
return mbolFirstIndent;
}
set
{
 mbolFirstIndent = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.FirstIndent);
}
}
/// <summary>
/// 题目补充(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionNameAdd
{
get
{
return mstrQuestionNameAdd;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionNameAdd = value;
}
else
{
 mstrQuestionNameAdd = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.QuestionNameAdd);
}
}
/// <summary>
/// 代码表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTab
{
get
{
return mstrCodeTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTab = value;
}
else
{
 mstrCodeTab = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.CodeTab);
}
}
/// <summary>
/// CodeTab_Code(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCode
{
get
{
return mstrCodeTabCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCode = value;
}
else
{
 mstrCodeTabCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.CodeTabCode);
}
}
/// <summary>
/// 代码表_条件(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCondition
{
get
{
return mstrCodeTabCondition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCondition = value;
}
else
{
 mstrCodeTabCondition = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.CodeTabCondition);
}
}
/// <summary>
/// CodeTab_Name(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabName
{
get
{
return mstrCodeTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabName = value;
}
else
{
 mstrCodeTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.CodeTabName);
}
}
/// <summary>
/// 填空框高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FillInTextHeight
{
get
{
return mintFillInTextHeight;
}
set
{
 mintFillInTextHeight = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.FillInTextHeight);
}
}
/// <summary>
/// 填空框宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FillInTextWidth
{
get
{
return mintFillInTextWidth;
}
set
{
 mintFillInTextWidth = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.FillInTextWidth);
}
}
/// <summary>
/// 是否填空框多行(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMulti4FillInText
{
get
{
return mbolIsMulti4FillInText;
}
set
{
 mbolIsMulti4FillInText = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.IsMulti4FillInText);
}
}
/// <summary>
/// 复选框限制数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CheckBoxLimitCount
{
get
{
return mintCheckBoxLimitCount;
}
set
{
 mintCheckBoxLimitCount = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.CheckBoxLimitCount);
}
}
/// <summary>
/// 是否是JS(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsJs
{
get
{
return mbolIsJs;
}
set
{
 mbolIsJs = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.IsJs);
}
}
/// <summary>
/// 备注框宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? MemoTextWidth
{
get
{
return mintMemoTextWidth;
}
set
{
 mintMemoTextWidth = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.MemoTextWidth);
}
}
/// <summary>
/// 相关事件(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaEvent
{
get
{
return mstrRelaEvent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaEvent = value;
}
else
{
 mstrRelaEvent = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.RelaEvent);
}
}
/// <summary>
/// 是否测试(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTest
{
get
{
return mbolIsTest;
}
set
{
 mbolIsTest = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.IsTest);
}
}
/// <summary>
/// 模式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelModeTypeId
{
get
{
return mstrLevelModeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelModeTypeId = value;
}
else
{
 mstrLevelModeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.LevelModeTypeId);
}
}
/// <summary>
/// 是否随机(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRandom
{
get
{
return mbolIsRandom;
}
set
{
 mbolIsRandom = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaire.IsRandom);
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
  return mlngQuestionId.ToString();
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrQuestionName;
 }
 }
}
 /// <summary>
 /// 题目(Questionnaire)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionnaire
{
public const string _CurrTabName = "Questionnaire"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "QuestionMemo", "QuestionNo", "ParentQuestionId", "ExamAnswer", "CourseId", "LevelNo", "CourseChapterId", "QuestionTypeId", "QuestionTypeId4Course", "AnswerTypeId", "GridTitle", "AnswerModeId", "IsHaveAdditionalMemo", "QuestionScore", "DefaultValue", "DefaultSelectItem", "IsShow", "IsCast", "LikeCount", "AnswerAttLimitSize", "LimitedResourceType", "IsEffective", "IsCanInPaper", "ExamGradeId", "TextDirectId", "UpdDate", "UpdUser", "Memo", "QuestionCode", "DifficultyLevelId", "SectionTypeId", "KnowledgeGraphId", "FirstIndent", "QuestionNameAdd", "CodeTab", "CodeTabCode", "CodeTabCondition", "CodeTabName", "FillInTextHeight", "FillInTextWidth", "IsMulti4FillInText", "CheckBoxLimitCount", "IsJs", "MemoTextWidth", "RelaEvent", "IsTest", "LevelModeTypeId", "IsRandom"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"QuestionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex = "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"QuestionContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionContent = "QuestionContent";    //题目内容

 /// <summary>
 /// 常量:"QuestionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionMemo = "QuestionMemo";    //题目说明

 /// <summary>
 /// 常量:"QuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNo = "QuestionNo";    //题目编号

 /// <summary>
 /// 常量:"ParentQuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentQuestionId = "ParentQuestionId";    //父题目Id

 /// <summary>
 /// 常量:"ExamAnswer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamAnswer = "ExamAnswer";    //题目答案

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"LevelNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelNo = "LevelNo";    //学习关号2

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程

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
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"IsHaveAdditionalMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveAdditionalMemo = "IsHaveAdditionalMemo";    //是否有附加说明

 /// <summary>
 /// 常量:"QuestionScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionScore = "QuestionScore";    //题目得分

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"DefaultSelectItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultSelectItem = "DefaultSelectItem";    //默认选项

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"IsCast"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCast = "IsCast";    //是否播放

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"AnswerAttLimitSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerAttLimitSize = "AnswerAttLimitSize";    //回答附件限制大小

 /// <summary>
 /// 常量:"LimitedResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LimitedResourceType = "LimitedResourceType";    //限制资源类型

 /// <summary>
 /// 常量:"IsEffective"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEffective = "IsEffective";    //是否有效

 /// <summary>
 /// 常量:"IsCanInPaper"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCanInPaper = "IsCanInPaper";    //是否可在Paper

 /// <summary>
 /// 常量:"ExamGradeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamGradeId = "ExamGradeId";    //题库等级ID

 /// <summary>
 /// 常量:"TextDirectId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextDirectId = "TextDirectId";    //文本方向ID

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

 /// <summary>
 /// 常量:"QuestionCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionCode = "QuestionCode";    //html代码

 /// <summary>
 /// 常量:"DifficultyLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DifficultyLevelId = "DifficultyLevelId";    //难度等级Id

 /// <summary>
 /// 常量:"SectionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionTypeId = "SectionTypeId";    //节点类型Id

 /// <summary>
 /// 常量:"KnowledgeGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphId = "KnowledgeGraphId";    //知识点图Id

 /// <summary>
 /// 常量:"FirstIndent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FirstIndent = "FirstIndent";    //首行缩进

 /// <summary>
 /// 常量:"QuestionNameAdd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNameAdd = "QuestionNameAdd";    //题目补充

 /// <summary>
 /// 常量:"CodeTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTab = "CodeTab";    //代码表

 /// <summary>
 /// 常量:"CodeTabCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCode = "CodeTabCode";    //CodeTab_Code

 /// <summary>
 /// 常量:"CodeTabCondition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCondition = "CodeTabCondition";    //代码表_条件

 /// <summary>
 /// 常量:"CodeTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabName = "CodeTabName";    //CodeTab_Name

 /// <summary>
 /// 常量:"FillInTextHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FillInTextHeight = "FillInTextHeight";    //填空框高度

 /// <summary>
 /// 常量:"FillInTextWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FillInTextWidth = "FillInTextWidth";    //填空框宽度

 /// <summary>
 /// 常量:"IsMulti4FillInText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMulti4FillInText = "IsMulti4FillInText";    //是否填空框多行

 /// <summary>
 /// 常量:"CheckBoxLimitCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckBoxLimitCount = "CheckBoxLimitCount";    //复选框限制数

 /// <summary>
 /// 常量:"IsJs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsJs = "IsJs";    //是否是JS

 /// <summary>
 /// 常量:"MemoTextWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MemoTextWidth = "MemoTextWidth";    //备注框宽度

 /// <summary>
 /// 常量:"RelaEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaEvent = "RelaEvent";    //相关事件

 /// <summary>
 /// 常量:"IsTest"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTest = "IsTest";    //是否测试

 /// <summary>
 /// 常量:"LevelModeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelModeTypeId = "LevelModeTypeId";    //模式Id

 /// <summary>
 /// 常量:"IsRandom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRandom = "IsRandom";    //是否随机
}

}