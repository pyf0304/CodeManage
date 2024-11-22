
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireEN
 表名:vQuestionnaire(01120019)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:31:03
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
 /// 表vQuestionnaire的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_vQuestionnaire
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
public K_QuestionId_vQuestionnaire(long lngQuestionId)
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
 /// <returns>返回:[K_QuestionId_vQuestionnaire]类型的对象</returns>
public static implicit operator K_QuestionId_vQuestionnaire(long value)
{
return new K_QuestionId_vQuestionnaire(value);
}
}
 /// <summary>
 /// v题目(vQuestionnaire)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionnaireEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionnaire"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 70;
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "QuestionMemo", "QuestionNo", "ParentQuestionId", "ExamAnswer", "CourseId", "CourseCode", "CourseName", "LevelNo", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "QuestionTypeId", "QuestionTypeName", "QuestionTypeId4Course", "QuestionTypeName4Course", "AnswerTypeId", "AnswerTypeName", "GridTitle", "AnswerModeId", "AnswerModeName", "QuestionScore", "DefaultValue", "DefaultSelectItem", "IsShow", "IsCast", "LikeCount", "AnswerAttLimitSize", "LimitedResourceType", "IsEffective", "IsCanInPaper", "ExamGradeId", "ExamGradeName", "TextDirectId", "UpdDate", "UpdUser", "Memo", "FirstIndent", "CodeTab", "CodeTabCode", "CodeTabCondition", "CodeTabName", "CourseIdChapter", "OptionNum", "ChapterOrderNum", "QuestionNameAdd", "DifficultyLevelId", "FillInTextHeight", "FillInTextWidth", "IsHaveAdditionalMemo", "IsJs", "IsMulti4FillInText", "KnowledgeGraphId", "MemoTextWidth", "QuestionCode", "SectionTypeId", "CheckBoxLimitCount", "RelaEvent"};

protected long mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionContent;    //题目内容
protected string mstrQuestionMemo;    //题目说明
protected string mstrQuestionNo;    //题目编号
protected string mstrParentQuestionId;    //父题目Id
protected string mstrExamAnswer;    //题目答案
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected int? mintLevelNo;    //学习关号2
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrChapterId;    //章Id
protected string mstrSectionId;    //节Id
protected string mstrChapterName;    //章名
protected string mstrSectionName;    //节名
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected string mstrParentNodeId;    //父节点编号
protected string mstrCourseChapterReferred;    //节简称
protected string mstrParentNodeName;    //父节点名称
protected string mstrParentNodeReferred;    //章简称
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrQuestionTypeName4Course;    //题目类型名4课程
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrGridTitle;    //表格标题
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerModeName;    //答案模式名称
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
protected string mstrExamGradeName;    //题库等级名
protected string mstrTextDirectId;    //文本方向ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected bool mbolFirstIndent;    //首行缩进
protected string mstrCodeTab;    //代码表
protected string mstrCodeTabCode;    //CodeTab_Code
protected string mstrCodeTabCondition;    //代码表_条件
protected string mstrCodeTabName;    //CodeTab_Name
protected string mstrCourseIdChapter;    //CourseId_Chapter
protected int? mintOptionNum;    //选项数
protected int? mintChapterOrderNum;    //章排序号
protected string mstrQuestionNameAdd;    //题目补充
protected string mstrDifficultyLevelId;    //难度等级Id
protected int? mintFillInTextHeight;    //填空框高度
protected int? mintFillInTextWidth;    //填空框宽度
protected bool mbolIsHaveAdditionalMemo;    //是否有附加说明
protected bool mbolIsJs;    //是否是JS
protected bool mbolIsMulti4FillInText;    //是否填空框多行
protected string mstrKnowledgeGraphId;    //知识点图Id
protected int? mintMemoTextWidth;    //备注框宽度
protected string mstrQuestionCode;    //html代码
protected string mstrSectionTypeId;    //节点类型Id
protected int? mintCheckBoxLimitCount;    //复选框限制数
protected string mstrRelaEvent;    //相关事件

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionnaireEN()
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
public clsvQuestionnaireEN(long lngQuestionId)
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
if (strAttributeName  ==  convQuestionnaire.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionMemo)
{
return mstrQuestionMemo;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convQuestionnaire.ParentQuestionId)
{
return mstrParentQuestionId;
}
else if (strAttributeName  ==  convQuestionnaire.ExamAnswer)
{
return mstrExamAnswer;
}
else if (strAttributeName  ==  convQuestionnaire.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionnaire.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convQuestionnaire.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convQuestionnaire.LevelNo)
{
return mintLevelNo;
}
else if (strAttributeName  ==  convQuestionnaire.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convQuestionnaire.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convQuestionnaire.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convQuestionnaire.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convQuestionnaire.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convQuestionnaire.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convQuestionnaire.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convQuestionnaire.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convQuestionnaire.ParentNodeId)
{
return mstrParentNodeId;
}
else if (strAttributeName  ==  convQuestionnaire.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convQuestionnaire.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convQuestionnaire.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionTypeName4Course)
{
return mstrQuestionTypeName4Course;
}
else if (strAttributeName  ==  convQuestionnaire.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convQuestionnaire.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convQuestionnaire.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convQuestionnaire.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convQuestionnaire.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  convQuestionnaire.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convQuestionnaire.DefaultSelectItem)
{
return mstrDefaultSelectItem;
}
else if (strAttributeName  ==  convQuestionnaire.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convQuestionnaire.IsCast)
{
return mbolIsCast;
}
else if (strAttributeName  ==  convQuestionnaire.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convQuestionnaire.AnswerAttLimitSize)
{
return mlngAnswerAttLimitSize;
}
else if (strAttributeName  ==  convQuestionnaire.LimitedResourceType)
{
return mstrLimitedResourceType;
}
else if (strAttributeName  ==  convQuestionnaire.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  convQuestionnaire.IsCanInPaper)
{
return mbolIsCanInPaper;
}
else if (strAttributeName  ==  convQuestionnaire.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  convQuestionnaire.ExamGradeName)
{
return mstrExamGradeName;
}
else if (strAttributeName  ==  convQuestionnaire.TextDirectId)
{
return mstrTextDirectId;
}
else if (strAttributeName  ==  convQuestionnaire.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQuestionnaire.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQuestionnaire.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQuestionnaire.FirstIndent)
{
return mbolFirstIndent;
}
else if (strAttributeName  ==  convQuestionnaire.CodeTab)
{
return mstrCodeTab;
}
else if (strAttributeName  ==  convQuestionnaire.CodeTabCode)
{
return mstrCodeTabCode;
}
else if (strAttributeName  ==  convQuestionnaire.CodeTabCondition)
{
return mstrCodeTabCondition;
}
else if (strAttributeName  ==  convQuestionnaire.CodeTabName)
{
return mstrCodeTabName;
}
else if (strAttributeName  ==  convQuestionnaire.CourseIdChapter)
{
return mstrCourseIdChapter;
}
else if (strAttributeName  ==  convQuestionnaire.OptionNum)
{
return mintOptionNum;
}
else if (strAttributeName  ==  convQuestionnaire.ChapterOrderNum)
{
return mintChapterOrderNum;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionNameAdd)
{
return mstrQuestionNameAdd;
}
else if (strAttributeName  ==  convQuestionnaire.DifficultyLevelId)
{
return mstrDifficultyLevelId;
}
else if (strAttributeName  ==  convQuestionnaire.FillInTextHeight)
{
return mintFillInTextHeight;
}
else if (strAttributeName  ==  convQuestionnaire.FillInTextWidth)
{
return mintFillInTextWidth;
}
else if (strAttributeName  ==  convQuestionnaire.IsHaveAdditionalMemo)
{
return mbolIsHaveAdditionalMemo;
}
else if (strAttributeName  ==  convQuestionnaire.IsJs)
{
return mbolIsJs;
}
else if (strAttributeName  ==  convQuestionnaire.IsMulti4FillInText)
{
return mbolIsMulti4FillInText;
}
else if (strAttributeName  ==  convQuestionnaire.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  convQuestionnaire.MemoTextWidth)
{
return mintMemoTextWidth;
}
else if (strAttributeName  ==  convQuestionnaire.QuestionCode)
{
return mstrQuestionCode;
}
else if (strAttributeName  ==  convQuestionnaire.SectionTypeId)
{
return mstrSectionTypeId;
}
else if (strAttributeName  ==  convQuestionnaire.CheckBoxLimitCount)
{
return mintCheckBoxLimitCount;
}
else if (strAttributeName  ==  convQuestionnaire.RelaEvent)
{
return mstrRelaEvent;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionnaire.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.QuestionId);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.QuestionIndex);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionName);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionContent);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionMemo)
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionMemo);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionNo);
}
else if (strAttributeName  ==  convQuestionnaire.ParentQuestionId)
{
mstrParentQuestionId = value.ToString();
 AddUpdatedFld(convQuestionnaire.ParentQuestionId);
}
else if (strAttributeName  ==  convQuestionnaire.ExamAnswer)
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(convQuestionnaire.ExamAnswer);
}
else if (strAttributeName  ==  convQuestionnaire.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseId);
}
else if (strAttributeName  ==  convQuestionnaire.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseCode);
}
else if (strAttributeName  ==  convQuestionnaire.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseName);
}
else if (strAttributeName  ==  convQuestionnaire.LevelNo)
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.LevelNo);
}
else if (strAttributeName  ==  convQuestionnaire.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseChapterId);
}
else if (strAttributeName  ==  convQuestionnaire.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseChapterName);
}
else if (strAttributeName  ==  convQuestionnaire.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire.ChapterId);
}
else if (strAttributeName  ==  convQuestionnaire.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convQuestionnaire.SectionId);
}
else if (strAttributeName  ==  convQuestionnaire.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire.ChapterName);
}
else if (strAttributeName  ==  convQuestionnaire.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convQuestionnaire.SectionName);
}
else if (strAttributeName  ==  convQuestionnaire.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire.ChapterNameSim);
}
else if (strAttributeName  ==  convQuestionnaire.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire.SectionNameSim);
}
else if (strAttributeName  ==  convQuestionnaire.ParentNodeId)
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.ParentNodeId);
}
else if (strAttributeName  ==  convQuestionnaire.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseChapterReferred);
}
else if (strAttributeName  ==  convQuestionnaire.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.ParentNodeName);
}
else if (strAttributeName  ==  convQuestionnaire.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convQuestionnaire.ParentNodeReferred);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionTypeId);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionTypeName);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionTypeId4Course);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionTypeName4Course)
{
mstrQuestionTypeName4Course = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionTypeName4Course);
}
else if (strAttributeName  ==  convQuestionnaire.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.AnswerTypeId);
}
else if (strAttributeName  ==  convQuestionnaire.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.AnswerTypeName);
}
else if (strAttributeName  ==  convQuestionnaire.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convQuestionnaire.GridTitle);
}
else if (strAttributeName  ==  convQuestionnaire.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.AnswerModeId);
}
else if (strAttributeName  ==  convQuestionnaire.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.AnswerModeName);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convQuestionnaire.QuestionScore);
}
else if (strAttributeName  ==  convQuestionnaire.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convQuestionnaire.DefaultValue);
}
else if (strAttributeName  ==  convQuestionnaire.DefaultSelectItem)
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(convQuestionnaire.DefaultSelectItem);
}
else if (strAttributeName  ==  convQuestionnaire.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsShow);
}
else if (strAttributeName  ==  convQuestionnaire.IsCast)
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsCast);
}
else if (strAttributeName  ==  convQuestionnaire.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.LikeCount);
}
else if (strAttributeName  ==  convQuestionnaire.AnswerAttLimitSize)
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.AnswerAttLimitSize);
}
else if (strAttributeName  ==  convQuestionnaire.LimitedResourceType)
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(convQuestionnaire.LimitedResourceType);
}
else if (strAttributeName  ==  convQuestionnaire.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsEffective);
}
else if (strAttributeName  ==  convQuestionnaire.IsCanInPaper)
{
mbolIsCanInPaper = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsCanInPaper);
}
else if (strAttributeName  ==  convQuestionnaire.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.ExamGradeId);
}
else if (strAttributeName  ==  convQuestionnaire.ExamGradeName)
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.ExamGradeName);
}
else if (strAttributeName  ==  convQuestionnaire.TextDirectId)
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convQuestionnaire.TextDirectId);
}
else if (strAttributeName  ==  convQuestionnaire.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionnaire.UpdDate);
}
else if (strAttributeName  ==  convQuestionnaire.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionnaire.UpdUser);
}
else if (strAttributeName  ==  convQuestionnaire.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionnaire.Memo);
}
else if (strAttributeName  ==  convQuestionnaire.FirstIndent)
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.FirstIndent);
}
else if (strAttributeName  ==  convQuestionnaire.CodeTab)
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convQuestionnaire.CodeTab);
}
else if (strAttributeName  ==  convQuestionnaire.CodeTabCode)
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convQuestionnaire.CodeTabCode);
}
else if (strAttributeName  ==  convQuestionnaire.CodeTabCondition)
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(convQuestionnaire.CodeTabCondition);
}
else if (strAttributeName  ==  convQuestionnaire.CodeTabName)
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convQuestionnaire.CodeTabName);
}
else if (strAttributeName  ==  convQuestionnaire.CourseIdChapter)
{
mstrCourseIdChapter = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseIdChapter);
}
else if (strAttributeName  ==  convQuestionnaire.OptionNum)
{
mintOptionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.OptionNum);
}
else if (strAttributeName  ==  convQuestionnaire.ChapterOrderNum)
{
mintChapterOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.ChapterOrderNum);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionNameAdd)
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionNameAdd);
}
else if (strAttributeName  ==  convQuestionnaire.DifficultyLevelId)
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(convQuestionnaire.DifficultyLevelId);
}
else if (strAttributeName  ==  convQuestionnaire.FillInTextHeight)
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.FillInTextHeight);
}
else if (strAttributeName  ==  convQuestionnaire.FillInTextWidth)
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.FillInTextWidth);
}
else if (strAttributeName  ==  convQuestionnaire.IsHaveAdditionalMemo)
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsHaveAdditionalMemo);
}
else if (strAttributeName  ==  convQuestionnaire.IsJs)
{
mbolIsJs = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsJs);
}
else if (strAttributeName  ==  convQuestionnaire.IsMulti4FillInText)
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsMulti4FillInText);
}
else if (strAttributeName  ==  convQuestionnaire.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(convQuestionnaire.KnowledgeGraphId);
}
else if (strAttributeName  ==  convQuestionnaire.MemoTextWidth)
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.MemoTextWidth);
}
else if (strAttributeName  ==  convQuestionnaire.QuestionCode)
{
mstrQuestionCode = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionCode);
}
else if (strAttributeName  ==  convQuestionnaire.SectionTypeId)
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.SectionTypeId);
}
else if (strAttributeName  ==  convQuestionnaire.CheckBoxLimitCount)
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.CheckBoxLimitCount);
}
else if (strAttributeName  ==  convQuestionnaire.RelaEvent)
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convQuestionnaire.RelaEvent);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionnaire.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convQuestionnaire.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convQuestionnaire.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convQuestionnaire.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (convQuestionnaire.QuestionMemo  ==  AttributeName[intIndex])
{
return mstrQuestionMemo;
}
else if (convQuestionnaire.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convQuestionnaire.ParentQuestionId  ==  AttributeName[intIndex])
{
return mstrParentQuestionId;
}
else if (convQuestionnaire.ExamAnswer  ==  AttributeName[intIndex])
{
return mstrExamAnswer;
}
else if (convQuestionnaire.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionnaire.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convQuestionnaire.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convQuestionnaire.LevelNo  ==  AttributeName[intIndex])
{
return mintLevelNo;
}
else if (convQuestionnaire.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convQuestionnaire.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convQuestionnaire.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convQuestionnaire.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convQuestionnaire.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convQuestionnaire.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convQuestionnaire.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convQuestionnaire.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convQuestionnaire.ParentNodeId  ==  AttributeName[intIndex])
{
return mstrParentNodeId;
}
else if (convQuestionnaire.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convQuestionnaire.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convQuestionnaire.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convQuestionnaire.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convQuestionnaire.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convQuestionnaire.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (convQuestionnaire.QuestionTypeName4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName4Course;
}
else if (convQuestionnaire.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convQuestionnaire.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convQuestionnaire.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convQuestionnaire.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convQuestionnaire.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (convQuestionnaire.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (convQuestionnaire.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convQuestionnaire.DefaultSelectItem  ==  AttributeName[intIndex])
{
return mstrDefaultSelectItem;
}
else if (convQuestionnaire.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convQuestionnaire.IsCast  ==  AttributeName[intIndex])
{
return mbolIsCast;
}
else if (convQuestionnaire.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convQuestionnaire.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
return mlngAnswerAttLimitSize;
}
else if (convQuestionnaire.LimitedResourceType  ==  AttributeName[intIndex])
{
return mstrLimitedResourceType;
}
else if (convQuestionnaire.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (convQuestionnaire.IsCanInPaper  ==  AttributeName[intIndex])
{
return mbolIsCanInPaper;
}
else if (convQuestionnaire.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (convQuestionnaire.ExamGradeName  ==  AttributeName[intIndex])
{
return mstrExamGradeName;
}
else if (convQuestionnaire.TextDirectId  ==  AttributeName[intIndex])
{
return mstrTextDirectId;
}
else if (convQuestionnaire.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQuestionnaire.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQuestionnaire.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQuestionnaire.FirstIndent  ==  AttributeName[intIndex])
{
return mbolFirstIndent;
}
else if (convQuestionnaire.CodeTab  ==  AttributeName[intIndex])
{
return mstrCodeTab;
}
else if (convQuestionnaire.CodeTabCode  ==  AttributeName[intIndex])
{
return mstrCodeTabCode;
}
else if (convQuestionnaire.CodeTabCondition  ==  AttributeName[intIndex])
{
return mstrCodeTabCondition;
}
else if (convQuestionnaire.CodeTabName  ==  AttributeName[intIndex])
{
return mstrCodeTabName;
}
else if (convQuestionnaire.CourseIdChapter  ==  AttributeName[intIndex])
{
return mstrCourseIdChapter;
}
else if (convQuestionnaire.OptionNum  ==  AttributeName[intIndex])
{
return mintOptionNum;
}
else if (convQuestionnaire.ChapterOrderNum  ==  AttributeName[intIndex])
{
return mintChapterOrderNum;
}
else if (convQuestionnaire.QuestionNameAdd  ==  AttributeName[intIndex])
{
return mstrQuestionNameAdd;
}
else if (convQuestionnaire.DifficultyLevelId  ==  AttributeName[intIndex])
{
return mstrDifficultyLevelId;
}
else if (convQuestionnaire.FillInTextHeight  ==  AttributeName[intIndex])
{
return mintFillInTextHeight;
}
else if (convQuestionnaire.FillInTextWidth  ==  AttributeName[intIndex])
{
return mintFillInTextWidth;
}
else if (convQuestionnaire.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
return mbolIsHaveAdditionalMemo;
}
else if (convQuestionnaire.IsJs  ==  AttributeName[intIndex])
{
return mbolIsJs;
}
else if (convQuestionnaire.IsMulti4FillInText  ==  AttributeName[intIndex])
{
return mbolIsMulti4FillInText;
}
else if (convQuestionnaire.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (convQuestionnaire.MemoTextWidth  ==  AttributeName[intIndex])
{
return mintMemoTextWidth;
}
else if (convQuestionnaire.QuestionCode  ==  AttributeName[intIndex])
{
return mstrQuestionCode;
}
else if (convQuestionnaire.SectionTypeId  ==  AttributeName[intIndex])
{
return mstrSectionTypeId;
}
else if (convQuestionnaire.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
return mintCheckBoxLimitCount;
}
else if (convQuestionnaire.RelaEvent  ==  AttributeName[intIndex])
{
return mstrRelaEvent;
}
return null;
}
set
{
if (convQuestionnaire.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.QuestionId);
}
else if (convQuestionnaire.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.QuestionIndex);
}
else if (convQuestionnaire.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionName);
}
else if (convQuestionnaire.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionContent);
}
else if (convQuestionnaire.QuestionMemo  ==  AttributeName[intIndex])
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionMemo);
}
else if (convQuestionnaire.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionNo);
}
else if (convQuestionnaire.ParentQuestionId  ==  AttributeName[intIndex])
{
mstrParentQuestionId = value.ToString();
 AddUpdatedFld(convQuestionnaire.ParentQuestionId);
}
else if (convQuestionnaire.ExamAnswer  ==  AttributeName[intIndex])
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(convQuestionnaire.ExamAnswer);
}
else if (convQuestionnaire.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseId);
}
else if (convQuestionnaire.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseCode);
}
else if (convQuestionnaire.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseName);
}
else if (convQuestionnaire.LevelNo  ==  AttributeName[intIndex])
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.LevelNo);
}
else if (convQuestionnaire.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseChapterId);
}
else if (convQuestionnaire.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseChapterName);
}
else if (convQuestionnaire.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire.ChapterId);
}
else if (convQuestionnaire.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convQuestionnaire.SectionId);
}
else if (convQuestionnaire.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire.ChapterName);
}
else if (convQuestionnaire.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convQuestionnaire.SectionName);
}
else if (convQuestionnaire.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire.ChapterNameSim);
}
else if (convQuestionnaire.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire.SectionNameSim);
}
else if (convQuestionnaire.ParentNodeId  ==  AttributeName[intIndex])
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.ParentNodeId);
}
else if (convQuestionnaire.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseChapterReferred);
}
else if (convQuestionnaire.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.ParentNodeName);
}
else if (convQuestionnaire.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convQuestionnaire.ParentNodeReferred);
}
else if (convQuestionnaire.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionTypeId);
}
else if (convQuestionnaire.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionTypeName);
}
else if (convQuestionnaire.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionTypeId4Course);
}
else if (convQuestionnaire.QuestionTypeName4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeName4Course = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionTypeName4Course);
}
else if (convQuestionnaire.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.AnswerTypeId);
}
else if (convQuestionnaire.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.AnswerTypeName);
}
else if (convQuestionnaire.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convQuestionnaire.GridTitle);
}
else if (convQuestionnaire.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.AnswerModeId);
}
else if (convQuestionnaire.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.AnswerModeName);
}
else if (convQuestionnaire.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convQuestionnaire.QuestionScore);
}
else if (convQuestionnaire.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convQuestionnaire.DefaultValue);
}
else if (convQuestionnaire.DefaultSelectItem  ==  AttributeName[intIndex])
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(convQuestionnaire.DefaultSelectItem);
}
else if (convQuestionnaire.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsShow);
}
else if (convQuestionnaire.IsCast  ==  AttributeName[intIndex])
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsCast);
}
else if (convQuestionnaire.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.LikeCount);
}
else if (convQuestionnaire.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.AnswerAttLimitSize);
}
else if (convQuestionnaire.LimitedResourceType  ==  AttributeName[intIndex])
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(convQuestionnaire.LimitedResourceType);
}
else if (convQuestionnaire.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsEffective);
}
else if (convQuestionnaire.IsCanInPaper  ==  AttributeName[intIndex])
{
mbolIsCanInPaper = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsCanInPaper);
}
else if (convQuestionnaire.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.ExamGradeId);
}
else if (convQuestionnaire.ExamGradeName  ==  AttributeName[intIndex])
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convQuestionnaire.ExamGradeName);
}
else if (convQuestionnaire.TextDirectId  ==  AttributeName[intIndex])
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convQuestionnaire.TextDirectId);
}
else if (convQuestionnaire.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionnaire.UpdDate);
}
else if (convQuestionnaire.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionnaire.UpdUser);
}
else if (convQuestionnaire.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionnaire.Memo);
}
else if (convQuestionnaire.FirstIndent  ==  AttributeName[intIndex])
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.FirstIndent);
}
else if (convQuestionnaire.CodeTab  ==  AttributeName[intIndex])
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convQuestionnaire.CodeTab);
}
else if (convQuestionnaire.CodeTabCode  ==  AttributeName[intIndex])
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convQuestionnaire.CodeTabCode);
}
else if (convQuestionnaire.CodeTabCondition  ==  AttributeName[intIndex])
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(convQuestionnaire.CodeTabCondition);
}
else if (convQuestionnaire.CodeTabName  ==  AttributeName[intIndex])
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convQuestionnaire.CodeTabName);
}
else if (convQuestionnaire.CourseIdChapter  ==  AttributeName[intIndex])
{
mstrCourseIdChapter = value.ToString();
 AddUpdatedFld(convQuestionnaire.CourseIdChapter);
}
else if (convQuestionnaire.OptionNum  ==  AttributeName[intIndex])
{
mintOptionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.OptionNum);
}
else if (convQuestionnaire.ChapterOrderNum  ==  AttributeName[intIndex])
{
mintChapterOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.ChapterOrderNum);
}
else if (convQuestionnaire.QuestionNameAdd  ==  AttributeName[intIndex])
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionNameAdd);
}
else if (convQuestionnaire.DifficultyLevelId  ==  AttributeName[intIndex])
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(convQuestionnaire.DifficultyLevelId);
}
else if (convQuestionnaire.FillInTextHeight  ==  AttributeName[intIndex])
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.FillInTextHeight);
}
else if (convQuestionnaire.FillInTextWidth  ==  AttributeName[intIndex])
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.FillInTextWidth);
}
else if (convQuestionnaire.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsHaveAdditionalMemo);
}
else if (convQuestionnaire.IsJs  ==  AttributeName[intIndex])
{
mbolIsJs = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsJs);
}
else if (convQuestionnaire.IsMulti4FillInText  ==  AttributeName[intIndex])
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire.IsMulti4FillInText);
}
else if (convQuestionnaire.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(convQuestionnaire.KnowledgeGraphId);
}
else if (convQuestionnaire.MemoTextWidth  ==  AttributeName[intIndex])
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.MemoTextWidth);
}
else if (convQuestionnaire.QuestionCode  ==  AttributeName[intIndex])
{
mstrQuestionCode = value.ToString();
 AddUpdatedFld(convQuestionnaire.QuestionCode);
}
else if (convQuestionnaire.SectionTypeId  ==  AttributeName[intIndex])
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire.SectionTypeId);
}
else if (convQuestionnaire.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire.CheckBoxLimitCount);
}
else if (convQuestionnaire.RelaEvent  ==  AttributeName[intIndex])
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convQuestionnaire.RelaEvent);
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
 AddUpdatedFld(convQuestionnaire.QuestionId);
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
 AddUpdatedFld(convQuestionnaire.QuestionIndex);
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
 AddUpdatedFld(convQuestionnaire.QuestionName);
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
 AddUpdatedFld(convQuestionnaire.QuestionContent);
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
 AddUpdatedFld(convQuestionnaire.QuestionMemo);
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
 AddUpdatedFld(convQuestionnaire.QuestionNo);
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
 AddUpdatedFld(convQuestionnaire.ParentQuestionId);
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
 AddUpdatedFld(convQuestionnaire.ExamAnswer);
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
 AddUpdatedFld(convQuestionnaire.CourseId);
}
}
/// <summary>
/// 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCode
{
get
{
return mstrCourseCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCode = value;
}
else
{
 mstrCourseCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.CourseCode);
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
 AddUpdatedFld(convQuestionnaire.CourseName);
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
 AddUpdatedFld(convQuestionnaire.LevelNo);
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
 AddUpdatedFld(convQuestionnaire.CourseChapterId);
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
 AddUpdatedFld(convQuestionnaire.CourseChapterName);
}
}
/// <summary>
/// 章Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterId
{
get
{
return mstrChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterId = value;
}
else
{
 mstrChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.ChapterId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.SectionId);
}
}
/// <summary>
/// 章名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterName
{
get
{
return mstrChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterName = value;
}
else
{
 mstrChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.ChapterName);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.SectionName);
}
}
/// <summary>
/// 章名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim
{
get
{
return mstrChapterNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim = value;
}
else
{
 mstrChapterNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.ChapterNameSim);
}
}
/// <summary>
/// 节名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionNameSim
{
get
{
return mstrSectionNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionNameSim = value;
}
else
{
 mstrSectionNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.SectionNameSim);
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
 AddUpdatedFld(convQuestionnaire.ParentNodeId);
}
}
/// <summary>
/// 节简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterReferred
{
get
{
return mstrCourseChapterReferred;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterReferred = value;
}
else
{
 mstrCourseChapterReferred = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.CourseChapterReferred);
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
 AddUpdatedFld(convQuestionnaire.ParentNodeName);
}
}
/// <summary>
/// 章简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeReferred
{
get
{
return mstrParentNodeReferred;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeReferred = value;
}
else
{
 mstrParentNodeReferred = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.ParentNodeReferred);
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
 AddUpdatedFld(convQuestionnaire.QuestionTypeId);
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
 AddUpdatedFld(convQuestionnaire.QuestionTypeName);
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
 AddUpdatedFld(convQuestionnaire.QuestionTypeId4Course);
}
}
/// <summary>
/// 题目类型名4课程(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeName4Course
{
get
{
return mstrQuestionTypeName4Course;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeName4Course = value;
}
else
{
 mstrQuestionTypeName4Course = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.QuestionTypeName4Course);
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
 AddUpdatedFld(convQuestionnaire.AnswerTypeId);
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
 AddUpdatedFld(convQuestionnaire.AnswerTypeName);
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
 AddUpdatedFld(convQuestionnaire.GridTitle);
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
 AddUpdatedFld(convQuestionnaire.AnswerModeId);
}
}
/// <summary>
/// 答案模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeName
{
get
{
return mstrAnswerModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeName = value;
}
else
{
 mstrAnswerModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.AnswerModeName);
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
 AddUpdatedFld(convQuestionnaire.QuestionScore);
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
 AddUpdatedFld(convQuestionnaire.DefaultValue);
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
 AddUpdatedFld(convQuestionnaire.DefaultSelectItem);
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
 AddUpdatedFld(convQuestionnaire.IsShow);
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
 AddUpdatedFld(convQuestionnaire.IsCast);
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
 AddUpdatedFld(convQuestionnaire.LikeCount);
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
 AddUpdatedFld(convQuestionnaire.AnswerAttLimitSize);
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
 AddUpdatedFld(convQuestionnaire.LimitedResourceType);
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
 AddUpdatedFld(convQuestionnaire.IsEffective);
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
 AddUpdatedFld(convQuestionnaire.IsCanInPaper);
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
 AddUpdatedFld(convQuestionnaire.ExamGradeId);
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
 AddUpdatedFld(convQuestionnaire.ExamGradeName);
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
 AddUpdatedFld(convQuestionnaire.TextDirectId);
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
 AddUpdatedFld(convQuestionnaire.UpdDate);
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
 AddUpdatedFld(convQuestionnaire.UpdUser);
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
 AddUpdatedFld(convQuestionnaire.Memo);
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
 AddUpdatedFld(convQuestionnaire.FirstIndent);
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
 AddUpdatedFld(convQuestionnaire.CodeTab);
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
 AddUpdatedFld(convQuestionnaire.CodeTabCode);
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
 AddUpdatedFld(convQuestionnaire.CodeTabCondition);
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
 AddUpdatedFld(convQuestionnaire.CodeTabName);
}
}
/// <summary>
/// CourseId_Chapter(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseIdChapter
{
get
{
return mstrCourseIdChapter;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseIdChapter = value;
}
else
{
 mstrCourseIdChapter = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.CourseIdChapter);
}
}
/// <summary>
/// 选项数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OptionNum
{
get
{
return mintOptionNum;
}
set
{
 mintOptionNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.OptionNum);
}
}
/// <summary>
/// 章排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ChapterOrderNum
{
get
{
return mintChapterOrderNum;
}
set
{
 mintChapterOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire.ChapterOrderNum);
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
 AddUpdatedFld(convQuestionnaire.QuestionNameAdd);
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
 AddUpdatedFld(convQuestionnaire.DifficultyLevelId);
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
 AddUpdatedFld(convQuestionnaire.FillInTextHeight);
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
 AddUpdatedFld(convQuestionnaire.FillInTextWidth);
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
 AddUpdatedFld(convQuestionnaire.IsHaveAdditionalMemo);
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
 AddUpdatedFld(convQuestionnaire.IsJs);
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
 AddUpdatedFld(convQuestionnaire.IsMulti4FillInText);
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
 AddUpdatedFld(convQuestionnaire.KnowledgeGraphId);
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
 AddUpdatedFld(convQuestionnaire.MemoTextWidth);
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
 AddUpdatedFld(convQuestionnaire.QuestionCode);
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
 AddUpdatedFld(convQuestionnaire.SectionTypeId);
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
 AddUpdatedFld(convQuestionnaire.CheckBoxLimitCount);
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
 AddUpdatedFld(convQuestionnaire.RelaEvent);
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
 /// v题目(vQuestionnaire)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionnaire
{
public const string _CurrTabName = "vQuestionnaire"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "QuestionMemo", "QuestionNo", "ParentQuestionId", "ExamAnswer", "CourseId", "CourseCode", "CourseName", "LevelNo", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "QuestionTypeId", "QuestionTypeName", "QuestionTypeId4Course", "QuestionTypeName4Course", "AnswerTypeId", "AnswerTypeName", "GridTitle", "AnswerModeId", "AnswerModeName", "QuestionScore", "DefaultValue", "DefaultSelectItem", "IsShow", "IsCast", "LikeCount", "AnswerAttLimitSize", "LimitedResourceType", "IsEffective", "IsCanInPaper", "ExamGradeId", "ExamGradeName", "TextDirectId", "UpdDate", "UpdUser", "Memo", "FirstIndent", "CodeTab", "CodeTabCode", "CodeTabCondition", "CodeTabName", "CourseIdChapter", "OptionNum", "ChapterOrderNum", "QuestionNameAdd", "DifficultyLevelId", "FillInTextHeight", "FillInTextWidth", "IsHaveAdditionalMemo", "IsJs", "IsMulti4FillInText", "KnowledgeGraphId", "MemoTextWidth", "QuestionCode", "SectionTypeId", "CheckBoxLimitCount", "RelaEvent"};
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
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

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
 /// 常量:"CourseChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterName = "CourseChapterName";    //课程章节名称

 /// <summary>
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"ChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterName = "ChapterName";    //章名

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"ChapterNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim = "ChapterNameSim";    //章名简称

 /// <summary>
 /// 常量:"SectionNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionNameSim = "SectionNameSim";    //节名简称

 /// <summary>
 /// 常量:"ParentNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeId = "ParentNodeId";    //父节点编号

 /// <summary>
 /// 常量:"CourseChapterReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterReferred = "CourseChapterReferred";    //节简称

 /// <summary>
 /// 常量:"ParentNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeName = "ParentNodeName";    //父节点名称

 /// <summary>
 /// 常量:"ParentNodeReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeReferred = "ParentNodeReferred";    //章简称

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
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程

 /// <summary>
 /// 常量:"QuestionTypeName4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName4Course = "QuestionTypeName4Course";    //题目类型名4课程

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
 /// 常量:"AnswerModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeName = "AnswerModeName";    //答案模式名称

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
 /// 常量:"ExamGradeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamGradeName = "ExamGradeName";    //题库等级名

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
 /// 常量:"FirstIndent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FirstIndent = "FirstIndent";    //首行缩进

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
 /// 常量:"CourseIdChapter"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseIdChapter = "CourseIdChapter";    //CourseId_Chapter

 /// <summary>
 /// 常量:"OptionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionNum = "OptionNum";    //选项数

 /// <summary>
 /// 常量:"ChapterOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterOrderNum = "ChapterOrderNum";    //章排序号

 /// <summary>
 /// 常量:"QuestionNameAdd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNameAdd = "QuestionNameAdd";    //题目补充

 /// <summary>
 /// 常量:"DifficultyLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DifficultyLevelId = "DifficultyLevelId";    //难度等级Id

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
 /// 常量:"IsHaveAdditionalMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveAdditionalMemo = "IsHaveAdditionalMemo";    //是否有附加说明

 /// <summary>
 /// 常量:"IsJs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsJs = "IsJs";    //是否是JS

 /// <summary>
 /// 常量:"IsMulti4FillInText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMulti4FillInText = "IsMulti4FillInText";    //是否填空框多行

 /// <summary>
 /// 常量:"KnowledgeGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphId = "KnowledgeGraphId";    //知识点图Id

 /// <summary>
 /// 常量:"MemoTextWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MemoTextWidth = "MemoTextWidth";    //备注框宽度

 /// <summary>
 /// 常量:"QuestionCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionCode = "QuestionCode";    //html代码

 /// <summary>
 /// 常量:"SectionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionTypeId = "SectionTypeId";    //节点类型Id

 /// <summary>
 /// 常量:"CheckBoxLimitCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckBoxLimitCount = "CheckBoxLimitCount";    //复选框限制数

 /// <summary>
 /// 常量:"RelaEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaEvent = "RelaEvent";    //相关事件
}

}