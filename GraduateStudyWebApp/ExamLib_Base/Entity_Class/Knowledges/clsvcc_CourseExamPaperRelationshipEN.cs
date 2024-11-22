
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationshipEN
 表名:vcc_CourseExamPaperRelationship(01120075)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:23
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
 /// 表vcc_CourseExamPaperRelationship的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vcc_CourseExamPaperRelationship
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
public K_mId_vcc_CourseExamPaperRelationship(long lngmId)
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
 /// <returns>返回:[K_mId_vcc_CourseExamPaperRelationship]类型的对象</returns>
public static implicit operator K_mId_vcc_CourseExamPaperRelationship(long value)
{
return new K_mId_vcc_CourseExamPaperRelationship(value);
}
}
 /// <summary>
 /// 题目与试卷关系(vcc_CourseExamPaperRelationship)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseExamPaperRelationshipEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CourseExamPaperRelationship"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 48;
public static string[] AttributeName = new string[] {"mId", "CourseExamPaperId", "ExamPaperName", "CourseId", "CourseName", "QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "ExamAnswer", "CourseChapterId", "CourseChapterName", "ParentNodeId", "ParentNodeName", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "AnswerTypeId", "AnswerModeId", "IsHaveAdditionalMemo", "QuestionScore", "QuestionNameAdd", "DefaultValue", "TextDirectId", "FillInTextWidth", "MemoTextWidth", "CodeTab", "CodeTabCode", "CodeTabName", "CodeTabCondition", "RelaEvent", "FirstIndent", "DefaultSelectItem", "FillInTextHeight", "IsMulti4FillInText", "CheckBoxLimitCount", "IsEffective", "UserId", "StartTime", "PapersBigTopicId", "PapersBigTopicName", "TopicDescription", "TopicScores", "TopicOrderNum", "OrderNum", "UpdDate", "UpdUser"};

protected long mlngmId;    //mId
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrExamPaperName;    //考卷名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected long? mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionContent;    //题目内容
protected string mstrExamAnswer;    //题目答案
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrParentNodeId;    //父节点编号
protected string mstrParentNodeName;    //父节点名称
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrExamGradeId;    //题库等级ID
protected string mstrExamGradeName;    //题库等级名
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrAnswerModeId;    //答案模式Id
protected bool mbolIsHaveAdditionalMemo;    //是否有附加说明
protected float? mfltQuestionScore;    //题目得分
protected string mstrQuestionNameAdd;    //题目补充
protected string mstrDefaultValue;    //缺省值
protected string mstrTextDirectId;    //文本方向ID
protected int? mintFillInTextWidth;    //填空框宽度
protected int? mintMemoTextWidth;    //备注框宽度
protected string mstrCodeTab;    //代码表
protected string mstrCodeTabCode;    //CodeTab_Code
protected string mstrCodeTabName;    //CodeTab_Name
protected string mstrCodeTabCondition;    //代码表_条件
protected string mstrRelaEvent;    //相关事件
protected bool mbolFirstIndent;    //首行缩进
protected string mstrDefaultSelectItem;    //默认选项
protected int? mintFillInTextHeight;    //填空框高度
protected bool mbolIsMulti4FillInText;    //是否填空框多行
protected int? mintCheckBoxLimitCount;    //复选框限制数
protected bool mbolIsEffective;    //是否有效
protected string mstrUserId;    //用户ID
protected double? mdblStartTime;    //开始时间(s)
protected string mstrPapersBigTopicId;    //试卷大题目Id
protected string mstrPapersBigTopicName;    //试卷大题目名称
protected string mstrTopicDescription;    //标题描述
protected int? mintTopicScores;    //大题得分
protected int? mintTopicOrderNum;    //TopicOrderNum
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseExamPaperRelationshipEN()
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
public clsvcc_CourseExamPaperRelationshipEN(long lngmId)
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
if (strAttributeName  ==  convcc_CourseExamPaperRelationship.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ExamPaperName)
{
return mstrExamPaperName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ExamAnswer)
{
return mstrExamAnswer;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ParentNodeId)
{
return mstrParentNodeId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ExamGradeName)
{
return mstrExamGradeName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo)
{
return mbolIsHaveAdditionalMemo;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionNameAdd)
{
return mstrQuestionNameAdd;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.TextDirectId)
{
return mstrTextDirectId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.FillInTextWidth)
{
return mintFillInTextWidth;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.MemoTextWidth)
{
return mintMemoTextWidth;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CodeTab)
{
return mstrCodeTab;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CodeTabCode)
{
return mstrCodeTabCode;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CodeTabName)
{
return mstrCodeTabName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CodeTabCondition)
{
return mstrCodeTabCondition;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.RelaEvent)
{
return mstrRelaEvent;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.FirstIndent)
{
return mbolFirstIndent;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.DefaultSelectItem)
{
return mstrDefaultSelectItem;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.FillInTextHeight)
{
return mintFillInTextHeight;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.IsMulti4FillInText)
{
return mbolIsMulti4FillInText;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CheckBoxLimitCount)
{
return mintCheckBoxLimitCount;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.StartTime)
{
return mdblStartTime;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.PapersBigTopicId)
{
return mstrPapersBigTopicId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.PapersBigTopicName)
{
return mstrPapersBigTopicName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.TopicDescription)
{
return mstrTopicDescription;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.TopicScores)
{
return mintTopicScores;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.TopicOrderNum)
{
return mintTopicOrderNum;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CourseExamPaperRelationship.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.mId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseExamPaperId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ExamPaperName)
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamPaperName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionIndex);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionContent);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ExamAnswer)
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamAnswer);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseChapterId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseChapterName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ParentNodeId)
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ParentNodeId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ParentNodeName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionTypeId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionTypeName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamGradeId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.ExamGradeName)
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamGradeName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.AnswerTypeId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.AnswerModeId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo)
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionScore);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.QuestionNameAdd)
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionNameAdd);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.DefaultValue);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.TextDirectId)
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TextDirectId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.FillInTextWidth)
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FillInTextWidth);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.MemoTextWidth)
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.MemoTextWidth);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CodeTab)
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTab);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CodeTabCode)
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabCode);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CodeTabName)
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CodeTabCondition)
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabCondition);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.RelaEvent)
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.RelaEvent);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.FirstIndent)
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FirstIndent);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.DefaultSelectItem)
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.DefaultSelectItem);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.FillInTextHeight)
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FillInTextHeight);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.IsMulti4FillInText)
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsMulti4FillInText);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.CheckBoxLimitCount)
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CheckBoxLimitCount);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsEffective);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UserId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.StartTime)
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.StartTime);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.PapersBigTopicId)
{
mstrPapersBigTopicId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.PapersBigTopicId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.PapersBigTopicName)
{
mstrPapersBigTopicName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.PapersBigTopicName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.TopicDescription)
{
mstrTopicDescription = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicDescription);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.TopicScores)
{
mintTopicScores = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicScores);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.TopicOrderNum)
{
mintTopicOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicOrderNum);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.OrderNum);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UpdDate);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CourseExamPaperRelationship.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convcc_CourseExamPaperRelationship.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convcc_CourseExamPaperRelationship.ExamPaperName  ==  AttributeName[intIndex])
{
return mstrExamPaperName;
}
else if (convcc_CourseExamPaperRelationship.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CourseExamPaperRelationship.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_CourseExamPaperRelationship.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convcc_CourseExamPaperRelationship.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convcc_CourseExamPaperRelationship.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convcc_CourseExamPaperRelationship.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (convcc_CourseExamPaperRelationship.ExamAnswer  ==  AttributeName[intIndex])
{
return mstrExamAnswer;
}
else if (convcc_CourseExamPaperRelationship.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_CourseExamPaperRelationship.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_CourseExamPaperRelationship.ParentNodeId  ==  AttributeName[intIndex])
{
return mstrParentNodeId;
}
else if (convcc_CourseExamPaperRelationship.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convcc_CourseExamPaperRelationship.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convcc_CourseExamPaperRelationship.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convcc_CourseExamPaperRelationship.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (convcc_CourseExamPaperRelationship.ExamGradeName  ==  AttributeName[intIndex])
{
return mstrExamGradeName;
}
else if (convcc_CourseExamPaperRelationship.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convcc_CourseExamPaperRelationship.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
return mbolIsHaveAdditionalMemo;
}
else if (convcc_CourseExamPaperRelationship.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (convcc_CourseExamPaperRelationship.QuestionNameAdd  ==  AttributeName[intIndex])
{
return mstrQuestionNameAdd;
}
else if (convcc_CourseExamPaperRelationship.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convcc_CourseExamPaperRelationship.TextDirectId  ==  AttributeName[intIndex])
{
return mstrTextDirectId;
}
else if (convcc_CourseExamPaperRelationship.FillInTextWidth  ==  AttributeName[intIndex])
{
return mintFillInTextWidth;
}
else if (convcc_CourseExamPaperRelationship.MemoTextWidth  ==  AttributeName[intIndex])
{
return mintMemoTextWidth;
}
else if (convcc_CourseExamPaperRelationship.CodeTab  ==  AttributeName[intIndex])
{
return mstrCodeTab;
}
else if (convcc_CourseExamPaperRelationship.CodeTabCode  ==  AttributeName[intIndex])
{
return mstrCodeTabCode;
}
else if (convcc_CourseExamPaperRelationship.CodeTabName  ==  AttributeName[intIndex])
{
return mstrCodeTabName;
}
else if (convcc_CourseExamPaperRelationship.CodeTabCondition  ==  AttributeName[intIndex])
{
return mstrCodeTabCondition;
}
else if (convcc_CourseExamPaperRelationship.RelaEvent  ==  AttributeName[intIndex])
{
return mstrRelaEvent;
}
else if (convcc_CourseExamPaperRelationship.FirstIndent  ==  AttributeName[intIndex])
{
return mbolFirstIndent;
}
else if (convcc_CourseExamPaperRelationship.DefaultSelectItem  ==  AttributeName[intIndex])
{
return mstrDefaultSelectItem;
}
else if (convcc_CourseExamPaperRelationship.FillInTextHeight  ==  AttributeName[intIndex])
{
return mintFillInTextHeight;
}
else if (convcc_CourseExamPaperRelationship.IsMulti4FillInText  ==  AttributeName[intIndex])
{
return mbolIsMulti4FillInText;
}
else if (convcc_CourseExamPaperRelationship.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
return mintCheckBoxLimitCount;
}
else if (convcc_CourseExamPaperRelationship.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (convcc_CourseExamPaperRelationship.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convcc_CourseExamPaperRelationship.StartTime  ==  AttributeName[intIndex])
{
return mdblStartTime;
}
else if (convcc_CourseExamPaperRelationship.PapersBigTopicId  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicId;
}
else if (convcc_CourseExamPaperRelationship.PapersBigTopicName  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicName;
}
else if (convcc_CourseExamPaperRelationship.TopicDescription  ==  AttributeName[intIndex])
{
return mstrTopicDescription;
}
else if (convcc_CourseExamPaperRelationship.TopicScores  ==  AttributeName[intIndex])
{
return mintTopicScores;
}
else if (convcc_CourseExamPaperRelationship.TopicOrderNum  ==  AttributeName[intIndex])
{
return mintTopicOrderNum;
}
else if (convcc_CourseExamPaperRelationship.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_CourseExamPaperRelationship.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_CourseExamPaperRelationship.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convcc_CourseExamPaperRelationship.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.mId);
}
else if (convcc_CourseExamPaperRelationship.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseExamPaperId);
}
else if (convcc_CourseExamPaperRelationship.ExamPaperName  ==  AttributeName[intIndex])
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamPaperName);
}
else if (convcc_CourseExamPaperRelationship.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseId);
}
else if (convcc_CourseExamPaperRelationship.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseName);
}
else if (convcc_CourseExamPaperRelationship.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionId);
}
else if (convcc_CourseExamPaperRelationship.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionIndex);
}
else if (convcc_CourseExamPaperRelationship.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionName);
}
else if (convcc_CourseExamPaperRelationship.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionContent);
}
else if (convcc_CourseExamPaperRelationship.ExamAnswer  ==  AttributeName[intIndex])
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamAnswer);
}
else if (convcc_CourseExamPaperRelationship.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseChapterId);
}
else if (convcc_CourseExamPaperRelationship.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseChapterName);
}
else if (convcc_CourseExamPaperRelationship.ParentNodeId  ==  AttributeName[intIndex])
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ParentNodeId);
}
else if (convcc_CourseExamPaperRelationship.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ParentNodeName);
}
else if (convcc_CourseExamPaperRelationship.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionTypeId);
}
else if (convcc_CourseExamPaperRelationship.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionTypeName);
}
else if (convcc_CourseExamPaperRelationship.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamGradeId);
}
else if (convcc_CourseExamPaperRelationship.ExamGradeName  ==  AttributeName[intIndex])
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamGradeName);
}
else if (convcc_CourseExamPaperRelationship.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.AnswerTypeId);
}
else if (convcc_CourseExamPaperRelationship.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.AnswerModeId);
}
else if (convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo);
}
else if (convcc_CourseExamPaperRelationship.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionScore);
}
else if (convcc_CourseExamPaperRelationship.QuestionNameAdd  ==  AttributeName[intIndex])
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionNameAdd);
}
else if (convcc_CourseExamPaperRelationship.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.DefaultValue);
}
else if (convcc_CourseExamPaperRelationship.TextDirectId  ==  AttributeName[intIndex])
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TextDirectId);
}
else if (convcc_CourseExamPaperRelationship.FillInTextWidth  ==  AttributeName[intIndex])
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FillInTextWidth);
}
else if (convcc_CourseExamPaperRelationship.MemoTextWidth  ==  AttributeName[intIndex])
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.MemoTextWidth);
}
else if (convcc_CourseExamPaperRelationship.CodeTab  ==  AttributeName[intIndex])
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTab);
}
else if (convcc_CourseExamPaperRelationship.CodeTabCode  ==  AttributeName[intIndex])
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabCode);
}
else if (convcc_CourseExamPaperRelationship.CodeTabName  ==  AttributeName[intIndex])
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabName);
}
else if (convcc_CourseExamPaperRelationship.CodeTabCondition  ==  AttributeName[intIndex])
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabCondition);
}
else if (convcc_CourseExamPaperRelationship.RelaEvent  ==  AttributeName[intIndex])
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.RelaEvent);
}
else if (convcc_CourseExamPaperRelationship.FirstIndent  ==  AttributeName[intIndex])
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FirstIndent);
}
else if (convcc_CourseExamPaperRelationship.DefaultSelectItem  ==  AttributeName[intIndex])
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.DefaultSelectItem);
}
else if (convcc_CourseExamPaperRelationship.FillInTextHeight  ==  AttributeName[intIndex])
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FillInTextHeight);
}
else if (convcc_CourseExamPaperRelationship.IsMulti4FillInText  ==  AttributeName[intIndex])
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsMulti4FillInText);
}
else if (convcc_CourseExamPaperRelationship.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CheckBoxLimitCount);
}
else if (convcc_CourseExamPaperRelationship.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsEffective);
}
else if (convcc_CourseExamPaperRelationship.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UserId);
}
else if (convcc_CourseExamPaperRelationship.StartTime  ==  AttributeName[intIndex])
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.StartTime);
}
else if (convcc_CourseExamPaperRelationship.PapersBigTopicId  ==  AttributeName[intIndex])
{
mstrPapersBigTopicId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.PapersBigTopicId);
}
else if (convcc_CourseExamPaperRelationship.PapersBigTopicName  ==  AttributeName[intIndex])
{
mstrPapersBigTopicName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.PapersBigTopicName);
}
else if (convcc_CourseExamPaperRelationship.TopicDescription  ==  AttributeName[intIndex])
{
mstrTopicDescription = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicDescription);
}
else if (convcc_CourseExamPaperRelationship.TopicScores  ==  AttributeName[intIndex])
{
mintTopicScores = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicScores);
}
else if (convcc_CourseExamPaperRelationship.TopicOrderNum  ==  AttributeName[intIndex])
{
mintTopicOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicOrderNum);
}
else if (convcc_CourseExamPaperRelationship.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship.OrderNum);
}
else if (convcc_CourseExamPaperRelationship.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UpdDate);
}
else if (convcc_CourseExamPaperRelationship.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UpdUser);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.mId);
}
}
/// <summary>
/// 考卷流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseExamPaperId
{
get
{
return mstrCourseExamPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseExamPaperId = value;
}
else
{
 mstrCourseExamPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseExamPaperId);
}
}
/// <summary>
/// 考卷名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperName
{
get
{
return mstrExamPaperName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperName = value;
}
else
{
 mstrExamPaperName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamPaperName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseId);
}
}
/// <summary>
/// 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseName
{
get
{
return mstrCourseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseName = value;
}
else
{
 mstrCourseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionIndex);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionContent);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamAnswer);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseChapterId);
}
}
/// <summary>
/// 课程章节名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterName
{
get
{
return mstrCourseChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterName = value;
}
else
{
 mstrCourseChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CourseChapterName);
}
}
/// <summary>
/// 父节点编号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeId
{
get
{
return mstrParentNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeId = value;
}
else
{
 mstrParentNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ParentNodeId);
}
}
/// <summary>
/// 父节点名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeName
{
get
{
return mstrParentNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeName = value;
}
else
{
 mstrParentNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ParentNodeName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionTypeId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionTypeName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamGradeId);
}
}
/// <summary>
/// 题库等级名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamGradeName
{
get
{
return mstrExamGradeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamGradeName = value;
}
else
{
 mstrExamGradeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.ExamGradeName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.AnswerTypeId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.AnswerModeId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionScore);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.QuestionNameAdd);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.DefaultValue);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TextDirectId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FillInTextWidth);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.MemoTextWidth);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTab);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabCode);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CodeTabCondition);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.RelaEvent);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FirstIndent);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.DefaultSelectItem);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.FillInTextHeight);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsMulti4FillInText);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.CheckBoxLimitCount);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.IsEffective);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UserId);
}
}
/// <summary>
/// 开始时间(s)(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? StartTime
{
get
{
return mdblStartTime;
}
set
{
 mdblStartTime = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.StartTime);
}
}
/// <summary>
/// 试卷大题目Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PapersBigTopicId
{
get
{
return mstrPapersBigTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPapersBigTopicId = value;
}
else
{
 mstrPapersBigTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.PapersBigTopicId);
}
}
/// <summary>
/// 试卷大题目名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PapersBigTopicName
{
get
{
return mstrPapersBigTopicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPapersBigTopicName = value;
}
else
{
 mstrPapersBigTopicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.PapersBigTopicName);
}
}
/// <summary>
/// 标题描述(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicDescription
{
get
{
return mstrTopicDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicDescription = value;
}
else
{
 mstrTopicDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicDescription);
}
}
/// <summary>
/// 大题得分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TopicScores
{
get
{
return mintTopicScores;
}
set
{
 mintTopicScores = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicScores);
}
}
/// <summary>
/// TopicOrderNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TopicOrderNum
{
get
{
return mintTopicOrderNum;
}
set
{
 mintTopicOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.TopicOrderNum);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship.OrderNum);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UpdDate);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship.UpdUser);
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
 /// 题目与试卷关系(vcc_CourseExamPaperRelationship)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CourseExamPaperRelationship
{
public const string _CurrTabName = "vcc_CourseExamPaperRelationship"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseExamPaperId", "ExamPaperName", "CourseId", "CourseName", "QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "ExamAnswer", "CourseChapterId", "CourseChapterName", "ParentNodeId", "ParentNodeName", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "AnswerTypeId", "AnswerModeId", "IsHaveAdditionalMemo", "QuestionScore", "QuestionNameAdd", "DefaultValue", "TextDirectId", "FillInTextWidth", "MemoTextWidth", "CodeTab", "CodeTabCode", "CodeTabName", "CodeTabCondition", "RelaEvent", "FirstIndent", "DefaultSelectItem", "FillInTextHeight", "IsMulti4FillInText", "CheckBoxLimitCount", "IsEffective", "UserId", "StartTime", "PapersBigTopicId", "PapersBigTopicName", "TopicDescription", "TopicScores", "TopicOrderNum", "OrderNum", "UpdDate", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"ExamPaperName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperName = "ExamPaperName";    //考卷名称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

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
 /// 常量:"ExamAnswer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamAnswer = "ExamAnswer";    //题目答案

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"CourseChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterName = "CourseChapterName";    //课程章节名称

 /// <summary>
 /// 常量:"ParentNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeId = "ParentNodeId";    //父节点编号

 /// <summary>
 /// 常量:"ParentNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeName = "ParentNodeName";    //父节点名称

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
 /// 常量:"ExamGradeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamGradeId = "ExamGradeId";    //题库等级ID

 /// <summary>
 /// 常量:"ExamGradeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamGradeName = "ExamGradeName";    //题库等级名

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

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
 /// 常量:"QuestionNameAdd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNameAdd = "QuestionNameAdd";    //题目补充

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"TextDirectId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextDirectId = "TextDirectId";    //文本方向ID

 /// <summary>
 /// 常量:"FillInTextWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FillInTextWidth = "FillInTextWidth";    //填空框宽度

 /// <summary>
 /// 常量:"MemoTextWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MemoTextWidth = "MemoTextWidth";    //备注框宽度

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
 /// 常量:"CodeTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabName = "CodeTabName";    //CodeTab_Name

 /// <summary>
 /// 常量:"CodeTabCondition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCondition = "CodeTabCondition";    //代码表_条件

 /// <summary>
 /// 常量:"RelaEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaEvent = "RelaEvent";    //相关事件

 /// <summary>
 /// 常量:"FirstIndent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FirstIndent = "FirstIndent";    //首行缩进

 /// <summary>
 /// 常量:"DefaultSelectItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultSelectItem = "DefaultSelectItem";    //默认选项

 /// <summary>
 /// 常量:"FillInTextHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FillInTextHeight = "FillInTextHeight";    //填空框高度

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
 /// 常量:"IsEffective"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEffective = "IsEffective";    //是否有效

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"StartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartTime = "StartTime";    //开始时间(s)

 /// <summary>
 /// 常量:"PapersBigTopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PapersBigTopicId = "PapersBigTopicId";    //试卷大题目Id

 /// <summary>
 /// 常量:"PapersBigTopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PapersBigTopicName = "PapersBigTopicName";    //试卷大题目名称

 /// <summary>
 /// 常量:"TopicDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicDescription = "TopicDescription";    //标题描述

 /// <summary>
 /// 常量:"TopicScores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicScores = "TopicScores";    //大题得分

 /// <summary>
 /// 常量:"TopicOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicOrderNum = "TopicOrderNum";    //TopicOrderNum

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
}

}