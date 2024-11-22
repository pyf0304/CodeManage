
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_KnowledgeEN
 表名:vQuestionnaire_Knowledge(01120143)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:16
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
 /// 表vQuestionnaire_Knowledge的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_vQuestionnaire_Knowledge
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
public K_QuestionId_vQuestionnaire_Knowledge(long lngQuestionId)
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
 /// <returns>返回:[K_QuestionId_vQuestionnaire_Knowledge]类型的对象</returns>
public static implicit operator K_QuestionId_vQuestionnaire_Knowledge(long value)
{
return new K_QuestionId_vQuestionnaire_Knowledge(value);
}
}
 /// <summary>
 /// v题目表_知识点(vQuestionnaire_Knowledge)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionnaire_KnowledgeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionnaire_Knowledge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 63;
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "QuestionMemo", "QuestionNo", "ExamAnswer", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "AnswerTypeId", "AnswerTypeName", "GridTitle", "AnswerModeId", "AnswerModeName", "IsHaveAdditionalMemo", "QuestionnaireSetId", "QuestionnaireSetName", "QuestionScore", "QuestionNameAdd", "DefaultValue", "TextDirectId", "TextDirectName", "FillInTextWidth", "MemoTextWidth", "CodeTab", "CodeTabCode", "CodeTabName", "CodeTabCondition", "RelaEvent", "FirstIndent", "DefaultSelectItem", "IsAutoGridTitle", "FillInTextHeight", "IsMulti4FillInText", "CheckBoxLimitCount", "RoleId", "RoleName", "IsShow", "IsCast", "LikeCount", "IsEffective", "IsCanInPaper", "UpdDate", "UpdUser", "Memo", "KnowledgeNum", "AnswerNum"};

protected long mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionContent;    //题目内容
protected string mstrQuestionMemo;    //题目说明
protected string mstrQuestionNo;    //题目编号
protected string mstrExamAnswer;    //题目答案
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
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
protected string mstrExamGradeId;    //题库等级ID
protected string mstrExamGradeName;    //题库等级名
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrGridTitle;    //表格标题
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerModeName;    //答案模式名称
protected bool mbolIsHaveAdditionalMemo;    //是否有附加说明
protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrQuestionnaireSetName;    //问卷集名
protected float? mfltQuestionScore;    //题目得分
protected string mstrQuestionNameAdd;    //题目补充
protected string mstrDefaultValue;    //缺省值
protected string mstrTextDirectId;    //文本方向ID
protected string mstrTextDirectName;    //文本方向名
protected int? mintFillInTextWidth;    //填空框宽度
protected int? mintMemoTextWidth;    //备注框宽度
protected string mstrCodeTab;    //代码表
protected string mstrCodeTabCode;    //CodeTab_Code
protected string mstrCodeTabName;    //CodeTab_Name
protected string mstrCodeTabCondition;    //代码表_条件
protected string mstrRelaEvent;    //相关事件
protected bool mbolFirstIndent;    //首行缩进
protected string mstrDefaultSelectItem;    //默认选项
protected bool mbolIsAutoGridTitle;    //是否自动编表格标题
protected int? mintFillInTextHeight;    //填空框高度
protected bool mbolIsMulti4FillInText;    //是否填空框多行
protected int? mintCheckBoxLimitCount;    //复选框限制数
protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名
protected bool mbolIsShow;    //是否启用
protected bool mbolIsCast;    //是否播放
protected long? mlngLikeCount;    //资源喜欢数量
protected bool mbolIsEffective;    //是否有效
protected bool mbolIsCanInPaper;    //是否可在Paper
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected int? mintKnowledgeNum;    //知识点数
protected int? mintAnswerNum;    //答案数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionnaire_KnowledgeEN()
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
public clsvQuestionnaire_KnowledgeEN(long lngQuestionId)
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
if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionMemo)
{
return mstrQuestionMemo;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ExamAnswer)
{
return mstrExamAnswer;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ParentNodeId)
{
return mstrParentNodeId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ExamGradeName)
{
return mstrExamGradeName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsHaveAdditionalMemo)
{
return mbolIsHaveAdditionalMemo;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionnaireSetName)
{
return mstrQuestionnaireSetName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionNameAdd)
{
return mstrQuestionNameAdd;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.TextDirectId)
{
return mstrTextDirectId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.TextDirectName)
{
return mstrTextDirectName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.FillInTextWidth)
{
return mintFillInTextWidth;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.MemoTextWidth)
{
return mintMemoTextWidth;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CodeTab)
{
return mstrCodeTab;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CodeTabCode)
{
return mstrCodeTabCode;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CodeTabName)
{
return mstrCodeTabName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CodeTabCondition)
{
return mstrCodeTabCondition;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.RelaEvent)
{
return mstrRelaEvent;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.FirstIndent)
{
return mbolFirstIndent;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.DefaultSelectItem)
{
return mstrDefaultSelectItem;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsAutoGridTitle)
{
return mbolIsAutoGridTitle;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.FillInTextHeight)
{
return mintFillInTextHeight;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsMulti4FillInText)
{
return mbolIsMulti4FillInText;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CheckBoxLimitCount)
{
return mintCheckBoxLimitCount;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsCast)
{
return mbolIsCast;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsCanInPaper)
{
return mbolIsCanInPaper;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.KnowledgeNum)
{
return mintKnowledgeNum;
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerNum)
{
return mintAnswerNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionIndex);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionContent);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionMemo)
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionMemo);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionNo);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ExamAnswer)
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamAnswer);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterNameSim);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionNameSim);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ParentNodeId)
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterReferred);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeReferred);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionTypeId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionTypeName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamGradeId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.ExamGradeName)
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamGradeName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerTypeId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerTypeName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.GridTitle);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerModeId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerModeName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsHaveAdditionalMemo)
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsHaveAdditionalMemo);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionnaireSetId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionnaireSetName)
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionnaireSetName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionScore);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.QuestionNameAdd)
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionNameAdd);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.DefaultValue);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.TextDirectId)
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.TextDirectId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.TextDirectName)
{
mstrTextDirectName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.TextDirectName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.FillInTextWidth)
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.FillInTextWidth);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.MemoTextWidth)
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.MemoTextWidth);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CodeTab)
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTab);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CodeTabCode)
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabCode);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CodeTabName)
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CodeTabCondition)
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabCondition);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.RelaEvent)
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.RelaEvent);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.FirstIndent)
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.FirstIndent);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.DefaultSelectItem)
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.DefaultSelectItem);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsAutoGridTitle)
{
mbolIsAutoGridTitle = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsAutoGridTitle);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.FillInTextHeight)
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.FillInTextHeight);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsMulti4FillInText)
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsMulti4FillInText);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.CheckBoxLimitCount)
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.CheckBoxLimitCount);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.RoleId);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.RoleName);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsShow);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsCast)
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsCast);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.LikeCount);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsEffective);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.IsCanInPaper)
{
mbolIsCanInPaper = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsCanInPaper);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.UpdDate);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.UpdUser);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.Memo);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.KnowledgeNum)
{
mintKnowledgeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.KnowledgeNum);
}
else if (strAttributeName  ==  convQuestionnaire_Knowledge.AnswerNum)
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionnaire_Knowledge.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convQuestionnaire_Knowledge.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convQuestionnaire_Knowledge.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convQuestionnaire_Knowledge.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (convQuestionnaire_Knowledge.QuestionMemo  ==  AttributeName[intIndex])
{
return mstrQuestionMemo;
}
else if (convQuestionnaire_Knowledge.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convQuestionnaire_Knowledge.ExamAnswer  ==  AttributeName[intIndex])
{
return mstrExamAnswer;
}
else if (convQuestionnaire_Knowledge.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionnaire_Knowledge.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convQuestionnaire_Knowledge.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convQuestionnaire_Knowledge.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convQuestionnaire_Knowledge.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convQuestionnaire_Knowledge.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convQuestionnaire_Knowledge.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convQuestionnaire_Knowledge.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convQuestionnaire_Knowledge.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convQuestionnaire_Knowledge.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convQuestionnaire_Knowledge.ParentNodeId  ==  AttributeName[intIndex])
{
return mstrParentNodeId;
}
else if (convQuestionnaire_Knowledge.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convQuestionnaire_Knowledge.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convQuestionnaire_Knowledge.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convQuestionnaire_Knowledge.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convQuestionnaire_Knowledge.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convQuestionnaire_Knowledge.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (convQuestionnaire_Knowledge.ExamGradeName  ==  AttributeName[intIndex])
{
return mstrExamGradeName;
}
else if (convQuestionnaire_Knowledge.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convQuestionnaire_Knowledge.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convQuestionnaire_Knowledge.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convQuestionnaire_Knowledge.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convQuestionnaire_Knowledge.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (convQuestionnaire_Knowledge.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
return mbolIsHaveAdditionalMemo;
}
else if (convQuestionnaire_Knowledge.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (convQuestionnaire_Knowledge.QuestionnaireSetName  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetName;
}
else if (convQuestionnaire_Knowledge.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (convQuestionnaire_Knowledge.QuestionNameAdd  ==  AttributeName[intIndex])
{
return mstrQuestionNameAdd;
}
else if (convQuestionnaire_Knowledge.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convQuestionnaire_Knowledge.TextDirectId  ==  AttributeName[intIndex])
{
return mstrTextDirectId;
}
else if (convQuestionnaire_Knowledge.TextDirectName  ==  AttributeName[intIndex])
{
return mstrTextDirectName;
}
else if (convQuestionnaire_Knowledge.FillInTextWidth  ==  AttributeName[intIndex])
{
return mintFillInTextWidth;
}
else if (convQuestionnaire_Knowledge.MemoTextWidth  ==  AttributeName[intIndex])
{
return mintMemoTextWidth;
}
else if (convQuestionnaire_Knowledge.CodeTab  ==  AttributeName[intIndex])
{
return mstrCodeTab;
}
else if (convQuestionnaire_Knowledge.CodeTabCode  ==  AttributeName[intIndex])
{
return mstrCodeTabCode;
}
else if (convQuestionnaire_Knowledge.CodeTabName  ==  AttributeName[intIndex])
{
return mstrCodeTabName;
}
else if (convQuestionnaire_Knowledge.CodeTabCondition  ==  AttributeName[intIndex])
{
return mstrCodeTabCondition;
}
else if (convQuestionnaire_Knowledge.RelaEvent  ==  AttributeName[intIndex])
{
return mstrRelaEvent;
}
else if (convQuestionnaire_Knowledge.FirstIndent  ==  AttributeName[intIndex])
{
return mbolFirstIndent;
}
else if (convQuestionnaire_Knowledge.DefaultSelectItem  ==  AttributeName[intIndex])
{
return mstrDefaultSelectItem;
}
else if (convQuestionnaire_Knowledge.IsAutoGridTitle  ==  AttributeName[intIndex])
{
return mbolIsAutoGridTitle;
}
else if (convQuestionnaire_Knowledge.FillInTextHeight  ==  AttributeName[intIndex])
{
return mintFillInTextHeight;
}
else if (convQuestionnaire_Knowledge.IsMulti4FillInText  ==  AttributeName[intIndex])
{
return mbolIsMulti4FillInText;
}
else if (convQuestionnaire_Knowledge.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
return mintCheckBoxLimitCount;
}
else if (convQuestionnaire_Knowledge.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQuestionnaire_Knowledge.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQuestionnaire_Knowledge.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convQuestionnaire_Knowledge.IsCast  ==  AttributeName[intIndex])
{
return mbolIsCast;
}
else if (convQuestionnaire_Knowledge.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convQuestionnaire_Knowledge.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (convQuestionnaire_Knowledge.IsCanInPaper  ==  AttributeName[intIndex])
{
return mbolIsCanInPaper;
}
else if (convQuestionnaire_Knowledge.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQuestionnaire_Knowledge.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQuestionnaire_Knowledge.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQuestionnaire_Knowledge.KnowledgeNum  ==  AttributeName[intIndex])
{
return mintKnowledgeNum;
}
else if (convQuestionnaire_Knowledge.AnswerNum  ==  AttributeName[intIndex])
{
return mintAnswerNum;
}
return null;
}
set
{
if (convQuestionnaire_Knowledge.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionId);
}
else if (convQuestionnaire_Knowledge.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionIndex);
}
else if (convQuestionnaire_Knowledge.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionName);
}
else if (convQuestionnaire_Knowledge.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionContent);
}
else if (convQuestionnaire_Knowledge.QuestionMemo  ==  AttributeName[intIndex])
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionMemo);
}
else if (convQuestionnaire_Knowledge.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionNo);
}
else if (convQuestionnaire_Knowledge.ExamAnswer  ==  AttributeName[intIndex])
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamAnswer);
}
else if (convQuestionnaire_Knowledge.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseId);
}
else if (convQuestionnaire_Knowledge.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseName);
}
else if (convQuestionnaire_Knowledge.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterId);
}
else if (convQuestionnaire_Knowledge.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterName);
}
else if (convQuestionnaire_Knowledge.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterId);
}
else if (convQuestionnaire_Knowledge.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionId);
}
else if (convQuestionnaire_Knowledge.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterName);
}
else if (convQuestionnaire_Knowledge.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionName);
}
else if (convQuestionnaire_Knowledge.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterNameSim);
}
else if (convQuestionnaire_Knowledge.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionNameSim);
}
else if (convQuestionnaire_Knowledge.ParentNodeId  ==  AttributeName[intIndex])
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeId);
}
else if (convQuestionnaire_Knowledge.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterReferred);
}
else if (convQuestionnaire_Knowledge.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeName);
}
else if (convQuestionnaire_Knowledge.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeReferred);
}
else if (convQuestionnaire_Knowledge.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionTypeId);
}
else if (convQuestionnaire_Knowledge.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionTypeName);
}
else if (convQuestionnaire_Knowledge.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamGradeId);
}
else if (convQuestionnaire_Knowledge.ExamGradeName  ==  AttributeName[intIndex])
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamGradeName);
}
else if (convQuestionnaire_Knowledge.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerTypeId);
}
else if (convQuestionnaire_Knowledge.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerTypeName);
}
else if (convQuestionnaire_Knowledge.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.GridTitle);
}
else if (convQuestionnaire_Knowledge.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerModeId);
}
else if (convQuestionnaire_Knowledge.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerModeName);
}
else if (convQuestionnaire_Knowledge.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsHaveAdditionalMemo);
}
else if (convQuestionnaire_Knowledge.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionnaireSetId);
}
else if (convQuestionnaire_Knowledge.QuestionnaireSetName  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionnaireSetName);
}
else if (convQuestionnaire_Knowledge.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionScore);
}
else if (convQuestionnaire_Knowledge.QuestionNameAdd  ==  AttributeName[intIndex])
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionNameAdd);
}
else if (convQuestionnaire_Knowledge.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.DefaultValue);
}
else if (convQuestionnaire_Knowledge.TextDirectId  ==  AttributeName[intIndex])
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.TextDirectId);
}
else if (convQuestionnaire_Knowledge.TextDirectName  ==  AttributeName[intIndex])
{
mstrTextDirectName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.TextDirectName);
}
else if (convQuestionnaire_Knowledge.FillInTextWidth  ==  AttributeName[intIndex])
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.FillInTextWidth);
}
else if (convQuestionnaire_Knowledge.MemoTextWidth  ==  AttributeName[intIndex])
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.MemoTextWidth);
}
else if (convQuestionnaire_Knowledge.CodeTab  ==  AttributeName[intIndex])
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTab);
}
else if (convQuestionnaire_Knowledge.CodeTabCode  ==  AttributeName[intIndex])
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabCode);
}
else if (convQuestionnaire_Knowledge.CodeTabName  ==  AttributeName[intIndex])
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabName);
}
else if (convQuestionnaire_Knowledge.CodeTabCondition  ==  AttributeName[intIndex])
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabCondition);
}
else if (convQuestionnaire_Knowledge.RelaEvent  ==  AttributeName[intIndex])
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.RelaEvent);
}
else if (convQuestionnaire_Knowledge.FirstIndent  ==  AttributeName[intIndex])
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.FirstIndent);
}
else if (convQuestionnaire_Knowledge.DefaultSelectItem  ==  AttributeName[intIndex])
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.DefaultSelectItem);
}
else if (convQuestionnaire_Knowledge.IsAutoGridTitle  ==  AttributeName[intIndex])
{
mbolIsAutoGridTitle = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsAutoGridTitle);
}
else if (convQuestionnaire_Knowledge.FillInTextHeight  ==  AttributeName[intIndex])
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.FillInTextHeight);
}
else if (convQuestionnaire_Knowledge.IsMulti4FillInText  ==  AttributeName[intIndex])
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsMulti4FillInText);
}
else if (convQuestionnaire_Knowledge.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.CheckBoxLimitCount);
}
else if (convQuestionnaire_Knowledge.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.RoleId);
}
else if (convQuestionnaire_Knowledge.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.RoleName);
}
else if (convQuestionnaire_Knowledge.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsShow);
}
else if (convQuestionnaire_Knowledge.IsCast  ==  AttributeName[intIndex])
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsCast);
}
else if (convQuestionnaire_Knowledge.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.LikeCount);
}
else if (convQuestionnaire_Knowledge.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsEffective);
}
else if (convQuestionnaire_Knowledge.IsCanInPaper  ==  AttributeName[intIndex])
{
mbolIsCanInPaper = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.IsCanInPaper);
}
else if (convQuestionnaire_Knowledge.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.UpdDate);
}
else if (convQuestionnaire_Knowledge.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.UpdUser);
}
else if (convQuestionnaire_Knowledge.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionnaire_Knowledge.Memo);
}
else if (convQuestionnaire_Knowledge.KnowledgeNum  ==  AttributeName[intIndex])
{
mintKnowledgeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.KnowledgeNum);
}
else if (convQuestionnaire_Knowledge.AnswerNum  ==  AttributeName[intIndex])
{
mintAnswerNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerNum);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionIndex);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionContent);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionMemo);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionNo);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamAnswer);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ChapterNameSim);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.SectionNameSim);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CourseChapterReferred);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ParentNodeReferred);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionTypeId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionTypeName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamGradeId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.ExamGradeName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerTypeId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerTypeName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.GridTitle);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerModeId);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerModeName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.IsHaveAdditionalMemo);
}
}
/// <summary>
/// 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetId
{
get
{
return mstrQuestionnaireSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetId = value;
}
else
{
 mstrQuestionnaireSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionnaireSetId);
}
}
/// <summary>
/// 问卷集名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetName
{
get
{
return mstrQuestionnaireSetName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetName = value;
}
else
{
 mstrQuestionnaireSetName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionnaireSetName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionScore);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.QuestionNameAdd);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.DefaultValue);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.TextDirectId);
}
}
/// <summary>
/// 文本方向名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextDirectName
{
get
{
return mstrTextDirectName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextDirectName = value;
}
else
{
 mstrTextDirectName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Knowledge.TextDirectName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.FillInTextWidth);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.MemoTextWidth);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTab);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabCode);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CodeTabCondition);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.RelaEvent);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.FirstIndent);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.DefaultSelectItem);
}
}
/// <summary>
/// 是否自动编表格标题(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAutoGridTitle
{
get
{
return mbolIsAutoGridTitle;
}
set
{
 mbolIsAutoGridTitle = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Knowledge.IsAutoGridTitle);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.FillInTextHeight);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.IsMulti4FillInText);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.CheckBoxLimitCount);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Knowledge.RoleId);
}
}
/// <summary>
/// 角色名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Knowledge.RoleName);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.IsShow);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.IsCast);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.LikeCount);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.IsEffective);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.IsCanInPaper);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.UpdDate);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.UpdUser);
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
 AddUpdatedFld(convQuestionnaire_Knowledge.Memo);
}
}
/// <summary>
/// 知识点数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? KnowledgeNum
{
get
{
return mintKnowledgeNum;
}
set
{
 mintKnowledgeNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Knowledge.KnowledgeNum);
}
}
/// <summary>
/// 答案数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerNum
{
get
{
return mintAnswerNum;
}
set
{
 mintAnswerNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Knowledge.AnswerNum);
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
 /// v题目表_知识点(vQuestionnaire_Knowledge)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionnaire_Knowledge
{
public const string _CurrTabName = "vQuestionnaire_Knowledge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "QuestionMemo", "QuestionNo", "ExamAnswer", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "AnswerTypeId", "AnswerTypeName", "GridTitle", "AnswerModeId", "AnswerModeName", "IsHaveAdditionalMemo", "QuestionnaireSetId", "QuestionnaireSetName", "QuestionScore", "QuestionNameAdd", "DefaultValue", "TextDirectId", "TextDirectName", "FillInTextWidth", "MemoTextWidth", "CodeTab", "CodeTabCode", "CodeTabName", "CodeTabCondition", "RelaEvent", "FirstIndent", "DefaultSelectItem", "IsAutoGridTitle", "FillInTextHeight", "IsMulti4FillInText", "CheckBoxLimitCount", "RoleId", "RoleName", "IsShow", "IsCast", "LikeCount", "IsEffective", "IsCanInPaper", "UpdDate", "UpdUser", "Memo", "KnowledgeNum", "AnswerNum"};
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
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

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
 /// 常量:"IsHaveAdditionalMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveAdditionalMemo = "IsHaveAdditionalMemo";    //是否有附加说明

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"QuestionnaireSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetName = "QuestionnaireSetName";    //问卷集名

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
 /// 常量:"TextDirectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextDirectName = "TextDirectName";    //文本方向名

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
 /// 常量:"IsAutoGridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAutoGridTitle = "IsAutoGridTitle";    //是否自动编表格标题

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
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名

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
 /// 常量:"KnowledgeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeNum = "KnowledgeNum";    //知识点数

 /// <summary>
 /// 常量:"AnswerNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerNum = "AnswerNum";    //答案数
}

}