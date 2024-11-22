
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkEduClsRelaEN
 表名:vcc_WorkEduClsRela(01120197)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表vcc_WorkEduClsRela的关键字(IdWorkEduClsRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWorkEduClsRela_vcc_WorkEduClsRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdWorkEduClsRela">表关键字</param>
public K_IdWorkEduClsRela_vcc_WorkEduClsRela(long lngIdWorkEduClsRela)
{
if (IsValid(lngIdWorkEduClsRela)) Value = lngIdWorkEduClsRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdWorkEduClsRela)
{
if (lngIdWorkEduClsRela == 0) return false;
if (lngIdWorkEduClsRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWorkEduClsRela_vcc_WorkEduClsRela]类型的对象</returns>
public static implicit operator K_IdWorkEduClsRela_vcc_WorkEduClsRela(long value)
{
return new K_IdWorkEduClsRela_vcc_WorkEduClsRela(value);
}
}
 /// <summary>
 /// v作业教学班关系表(vcc_WorkEduClsRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_WorkEduClsRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_WorkEduClsRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWorkEduClsRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 50;
public static string[] AttributeName = new string[] {"IdWorkEduClsRela", "QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "AnswerTypeId", "AnswerModeId", "DefaultValue", "TextDirectId", "RelaEvent", "CheckBoxLimitCount", "AnswerAttLimitSize", "LimitedResourceType", "QuestionTypeId4Course", "QuestionTypeName4Course", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "Scores", "TeacherId", "IsPublish", "PubDate", "publisher", "SpecifyCompletionDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeId", "WorkTypeName", "UpdDate", "UpdUserId", "Memo", "StuNum", "EduClsStuNum"};

protected long mlngIdWorkEduClsRela;    //作业教学班关系流水号
protected long? mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionContent;    //题目内容
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
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
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrDefaultValue;    //缺省值
protected string mstrTextDirectId;    //文本方向ID
protected string mstrRelaEvent;    //相关事件
protected int? mintCheckBoxLimitCount;    //复选框限制数
protected long? mlngAnswerAttLimitSize;    //回答附件限制大小
protected string mstrLimitedResourceType;    //限制资源类型
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrQuestionTypeName4Course;    //题目类型名4课程
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected double? mdblScores;    //分值
protected string mstrTeacherId;    //教师工号
protected bool mbolIsPublish;    //是否发布
protected string mstrPubDate;    //发布日期
protected string mstrpublisher;    //发布者Id
protected string mstrSpecifyCompletionDate;    //指定完成日期
protected bool mbolIsCurrEduCls;    //是否为教学班作业
protected bool mbolIsGroupWork;    //是否为小组作业
protected long? mlngCourseStudentGroupId;    //学生分组表流水号
protected string mstrWorkTypeId;    //作业类型Id
protected string mstrWorkTypeName;    //作业类型名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintStuNum;    //学生数
protected int? mintEduClsStuNum;    //教学班学生数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_WorkEduClsRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkEduClsRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdWorkEduClsRela">关键字:作业教学班关系流水号</param>
public clsvcc_WorkEduClsRelaEN(long lngIdWorkEduClsRela)
 {
 if (lngIdWorkEduClsRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdWorkEduClsRela = lngIdWorkEduClsRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkEduClsRela");
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
if (strAttributeName  ==  convcc_WorkEduClsRela.IdWorkEduClsRela)
{
return mlngIdWorkEduClsRela;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ParentNodeId)
{
return mstrParentNodeId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ExamGradeName)
{
return mstrExamGradeName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.TextDirectId)
{
return mstrTextDirectId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.RelaEvent)
{
return mstrRelaEvent;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CheckBoxLimitCount)
{
return mintCheckBoxLimitCount;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.AnswerAttLimitSize)
{
return mlngAnswerAttLimitSize;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.LimitedResourceType)
{
return mstrLimitedResourceType;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionTypeName4Course)
{
return mstrQuestionTypeName4Course;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.IsPublish)
{
return mbolIsPublish;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.PubDate)
{
return mstrPubDate;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.publisher)
{
return mstrpublisher;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.SpecifyCompletionDate)
{
return mstrSpecifyCompletionDate;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.IsCurrEduCls)
{
return mbolIsCurrEduCls;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.IsGroupWork)
{
return mbolIsGroupWork;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseStudentGroupId)
{
return mlngCourseStudentGroupId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.WorkTypeName)
{
return mstrWorkTypeName;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.StuNum)
{
return mintStuNum;
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.EduClsStuNum)
{
return mintEduClsStuNum;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_WorkEduClsRela.IdWorkEduClsRela)
{
mlngIdWorkEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.IdWorkEduClsRela);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionIndex);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionContent);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ChapterName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.SectionName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.SectionNameSim);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ParentNodeId)
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterReferred);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeReferred);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ExamGradeId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.ExamGradeName)
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ExamGradeName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerTypeId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerModeId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.DefaultValue);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.TextDirectId)
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.TextDirectId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.RelaEvent)
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.RelaEvent);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CheckBoxLimitCount)
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.CheckBoxLimitCount);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.AnswerAttLimitSize)
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerAttLimitSize);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.LimitedResourceType)
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.LimitedResourceType);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeId4Course);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.QuestionTypeName4Course)
{
mstrQuestionTypeName4Course = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeName4Course);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CurrEduClsId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.EduClsName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.Scores);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.TeacherId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.IsPublish)
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.IsPublish);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.PubDate)
{
mstrPubDate = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.PubDate);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.publisher)
{
mstrpublisher = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.publisher);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.SpecifyCompletionDate)
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.SpecifyCompletionDate);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.IsCurrEduCls)
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.IsCurrEduCls);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.IsGroupWork)
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.IsGroupWork);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.CourseStudentGroupId)
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.CourseStudentGroupId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.WorkTypeId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.WorkTypeName)
{
mstrWorkTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.WorkTypeName);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.UpdDate);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.UpdUserId);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.Memo);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.StuNum)
{
mintStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.StuNum);
}
else if (strAttributeName  ==  convcc_WorkEduClsRela.EduClsStuNum)
{
mintEduClsStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.EduClsStuNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_WorkEduClsRela.IdWorkEduClsRela  ==  AttributeName[intIndex])
{
return mlngIdWorkEduClsRela;
}
else if (convcc_WorkEduClsRela.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convcc_WorkEduClsRela.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convcc_WorkEduClsRela.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convcc_WorkEduClsRela.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (convcc_WorkEduClsRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_WorkEduClsRela.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_WorkEduClsRela.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_WorkEduClsRela.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_WorkEduClsRela.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_WorkEduClsRela.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_WorkEduClsRela.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_WorkEduClsRela.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_WorkEduClsRela.ParentNodeId  ==  AttributeName[intIndex])
{
return mstrParentNodeId;
}
else if (convcc_WorkEduClsRela.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convcc_WorkEduClsRela.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convcc_WorkEduClsRela.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convcc_WorkEduClsRela.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convcc_WorkEduClsRela.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convcc_WorkEduClsRela.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (convcc_WorkEduClsRela.ExamGradeName  ==  AttributeName[intIndex])
{
return mstrExamGradeName;
}
else if (convcc_WorkEduClsRela.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convcc_WorkEduClsRela.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convcc_WorkEduClsRela.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convcc_WorkEduClsRela.TextDirectId  ==  AttributeName[intIndex])
{
return mstrTextDirectId;
}
else if (convcc_WorkEduClsRela.RelaEvent  ==  AttributeName[intIndex])
{
return mstrRelaEvent;
}
else if (convcc_WorkEduClsRela.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
return mintCheckBoxLimitCount;
}
else if (convcc_WorkEduClsRela.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
return mlngAnswerAttLimitSize;
}
else if (convcc_WorkEduClsRela.LimitedResourceType  ==  AttributeName[intIndex])
{
return mstrLimitedResourceType;
}
else if (convcc_WorkEduClsRela.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (convcc_WorkEduClsRela.QuestionTypeName4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName4Course;
}
else if (convcc_WorkEduClsRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convcc_WorkEduClsRela.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convcc_WorkEduClsRela.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convcc_WorkEduClsRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (convcc_WorkEduClsRela.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (convcc_WorkEduClsRela.IsPublish  ==  AttributeName[intIndex])
{
return mbolIsPublish;
}
else if (convcc_WorkEduClsRela.PubDate  ==  AttributeName[intIndex])
{
return mstrPubDate;
}
else if (convcc_WorkEduClsRela.publisher  ==  AttributeName[intIndex])
{
return mstrpublisher;
}
else if (convcc_WorkEduClsRela.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
return mstrSpecifyCompletionDate;
}
else if (convcc_WorkEduClsRela.IsCurrEduCls  ==  AttributeName[intIndex])
{
return mbolIsCurrEduCls;
}
else if (convcc_WorkEduClsRela.IsGroupWork  ==  AttributeName[intIndex])
{
return mbolIsGroupWork;
}
else if (convcc_WorkEduClsRela.CourseStudentGroupId  ==  AttributeName[intIndex])
{
return mlngCourseStudentGroupId;
}
else if (convcc_WorkEduClsRela.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (convcc_WorkEduClsRela.WorkTypeName  ==  AttributeName[intIndex])
{
return mstrWorkTypeName;
}
else if (convcc_WorkEduClsRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_WorkEduClsRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_WorkEduClsRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_WorkEduClsRela.StuNum  ==  AttributeName[intIndex])
{
return mintStuNum;
}
else if (convcc_WorkEduClsRela.EduClsStuNum  ==  AttributeName[intIndex])
{
return mintEduClsStuNum;
}
return null;
}
set
{
if (convcc_WorkEduClsRela.IdWorkEduClsRela  ==  AttributeName[intIndex])
{
mlngIdWorkEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.IdWorkEduClsRela);
}
else if (convcc_WorkEduClsRela.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionId);
}
else if (convcc_WorkEduClsRela.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionIndex);
}
else if (convcc_WorkEduClsRela.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionName);
}
else if (convcc_WorkEduClsRela.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionContent);
}
else if (convcc_WorkEduClsRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseId);
}
else if (convcc_WorkEduClsRela.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseName);
}
else if (convcc_WorkEduClsRela.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterId);
}
else if (convcc_WorkEduClsRela.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterName);
}
else if (convcc_WorkEduClsRela.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ChapterName);
}
else if (convcc_WorkEduClsRela.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.SectionName);
}
else if (convcc_WorkEduClsRela.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ChapterNameSim);
}
else if (convcc_WorkEduClsRela.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.SectionNameSim);
}
else if (convcc_WorkEduClsRela.ParentNodeId  ==  AttributeName[intIndex])
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeId);
}
else if (convcc_WorkEduClsRela.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterReferred);
}
else if (convcc_WorkEduClsRela.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeName);
}
else if (convcc_WorkEduClsRela.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeReferred);
}
else if (convcc_WorkEduClsRela.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeId);
}
else if (convcc_WorkEduClsRela.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeName);
}
else if (convcc_WorkEduClsRela.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ExamGradeId);
}
else if (convcc_WorkEduClsRela.ExamGradeName  ==  AttributeName[intIndex])
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.ExamGradeName);
}
else if (convcc_WorkEduClsRela.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerTypeId);
}
else if (convcc_WorkEduClsRela.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerModeId);
}
else if (convcc_WorkEduClsRela.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.DefaultValue);
}
else if (convcc_WorkEduClsRela.TextDirectId  ==  AttributeName[intIndex])
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.TextDirectId);
}
else if (convcc_WorkEduClsRela.RelaEvent  ==  AttributeName[intIndex])
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.RelaEvent);
}
else if (convcc_WorkEduClsRela.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.CheckBoxLimitCount);
}
else if (convcc_WorkEduClsRela.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerAttLimitSize);
}
else if (convcc_WorkEduClsRela.LimitedResourceType  ==  AttributeName[intIndex])
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.LimitedResourceType);
}
else if (convcc_WorkEduClsRela.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeId4Course);
}
else if (convcc_WorkEduClsRela.QuestionTypeName4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeName4Course = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeName4Course);
}
else if (convcc_WorkEduClsRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.IdCurrEduCls);
}
else if (convcc_WorkEduClsRela.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.CurrEduClsId);
}
else if (convcc_WorkEduClsRela.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.EduClsName);
}
else if (convcc_WorkEduClsRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.Scores);
}
else if (convcc_WorkEduClsRela.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.TeacherId);
}
else if (convcc_WorkEduClsRela.IsPublish  ==  AttributeName[intIndex])
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.IsPublish);
}
else if (convcc_WorkEduClsRela.PubDate  ==  AttributeName[intIndex])
{
mstrPubDate = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.PubDate);
}
else if (convcc_WorkEduClsRela.publisher  ==  AttributeName[intIndex])
{
mstrpublisher = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.publisher);
}
else if (convcc_WorkEduClsRela.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.SpecifyCompletionDate);
}
else if (convcc_WorkEduClsRela.IsCurrEduCls  ==  AttributeName[intIndex])
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.IsCurrEduCls);
}
else if (convcc_WorkEduClsRela.IsGroupWork  ==  AttributeName[intIndex])
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.IsGroupWork);
}
else if (convcc_WorkEduClsRela.CourseStudentGroupId  ==  AttributeName[intIndex])
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.CourseStudentGroupId);
}
else if (convcc_WorkEduClsRela.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.WorkTypeId);
}
else if (convcc_WorkEduClsRela.WorkTypeName  ==  AttributeName[intIndex])
{
mstrWorkTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.WorkTypeName);
}
else if (convcc_WorkEduClsRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.UpdDate);
}
else if (convcc_WorkEduClsRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.UpdUserId);
}
else if (convcc_WorkEduClsRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_WorkEduClsRela.Memo);
}
else if (convcc_WorkEduClsRela.StuNum  ==  AttributeName[intIndex])
{
mintStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.StuNum);
}
else if (convcc_WorkEduClsRela.EduClsStuNum  ==  AttributeName[intIndex])
{
mintEduClsStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkEduClsRela.EduClsStuNum);
}
}
}

/// <summary>
/// 作业教学班关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdWorkEduClsRela
{
get
{
return mlngIdWorkEduClsRela;
}
set
{
 mlngIdWorkEduClsRela = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.IdWorkEduClsRela);
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
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionIndex);
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
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionContent);
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
 AddUpdatedFld(convcc_WorkEduClsRela.CourseId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.CourseName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.ChapterName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.SectionName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.ChapterNameSim);
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
 AddUpdatedFld(convcc_WorkEduClsRela.SectionNameSim);
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
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.CourseChapterReferred);
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
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.ParentNodeReferred);
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
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.ExamGradeId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.ExamGradeName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerTypeId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerModeId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.DefaultValue);
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
 AddUpdatedFld(convcc_WorkEduClsRela.TextDirectId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.RelaEvent);
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
 AddUpdatedFld(convcc_WorkEduClsRela.CheckBoxLimitCount);
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
 AddUpdatedFld(convcc_WorkEduClsRela.AnswerAttLimitSize);
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
 AddUpdatedFld(convcc_WorkEduClsRela.LimitedResourceType);
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
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeId4Course);
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
 AddUpdatedFld(convcc_WorkEduClsRela.QuestionTypeName4Course);
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
 AddUpdatedFld(convcc_WorkEduClsRela.IdCurrEduCls);
}
}
/// <summary>
/// 教学班Id(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CurrEduClsId
{
get
{
return mstrCurrEduClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCurrEduClsId = value;
}
else
{
 mstrCurrEduClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.CurrEduClsId);
}
}
/// <summary>
/// 教学班名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsName
{
get
{
return mstrEduClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsName = value;
}
else
{
 mstrEduClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.EduClsName);
}
}
/// <summary>
/// 分值(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Scores
{
get
{
return mdblScores;
}
set
{
 mdblScores = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.Scores);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherId
{
get
{
return mstrTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherId = value;
}
else
{
 mstrTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.TeacherId);
}
}
/// <summary>
/// 是否发布(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublish
{
get
{
return mbolIsPublish;
}
set
{
 mbolIsPublish = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.IsPublish);
}
}
/// <summary>
/// 发布日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubDate
{
get
{
return mstrPubDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubDate = value;
}
else
{
 mstrPubDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.PubDate);
}
}
/// <summary>
/// 发布者Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string publisher
{
get
{
return mstrpublisher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrpublisher = value;
}
else
{
 mstrpublisher = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.publisher);
}
}
/// <summary>
/// 指定完成日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SpecifyCompletionDate
{
get
{
return mstrSpecifyCompletionDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSpecifyCompletionDate = value;
}
else
{
 mstrSpecifyCompletionDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.SpecifyCompletionDate);
}
}
/// <summary>
/// 是否为教学班作业(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrEduCls
{
get
{
return mbolIsCurrEduCls;
}
set
{
 mbolIsCurrEduCls = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.IsCurrEduCls);
}
}
/// <summary>
/// 是否为小组作业(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGroupWork
{
get
{
return mbolIsGroupWork;
}
set
{
 mbolIsGroupWork = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.IsGroupWork);
}
}
/// <summary>
/// 学生分组表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CourseStudentGroupId
{
get
{
return mlngCourseStudentGroupId;
}
set
{
 mlngCourseStudentGroupId = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.CourseStudentGroupId);
}
}
/// <summary>
/// 作业类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkTypeId
{
get
{
return mstrWorkTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkTypeId = value;
}
else
{
 mstrWorkTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.WorkTypeId);
}
}
/// <summary>
/// 作业类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkTypeName
{
get
{
return mstrWorkTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkTypeName = value;
}
else
{
 mstrWorkTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.WorkTypeName);
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
 AddUpdatedFld(convcc_WorkEduClsRela.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.UpdUserId);
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
 AddUpdatedFld(convcc_WorkEduClsRela.Memo);
}
}
/// <summary>
/// 学生数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? StuNum
{
get
{
return mintStuNum;
}
set
{
 mintStuNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.StuNum);
}
}
/// <summary>
/// 教学班学生数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? EduClsStuNum
{
get
{
return mintEduClsStuNum;
}
set
{
 mintEduClsStuNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkEduClsRela.EduClsStuNum);
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
  return mlngIdWorkEduClsRela.ToString();
 }
 }
}
 /// <summary>
 /// v作业教学班关系表(vcc_WorkEduClsRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_WorkEduClsRela
{
public const string _CurrTabName = "vcc_WorkEduClsRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWorkEduClsRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWorkEduClsRela", "QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "AnswerTypeId", "AnswerModeId", "DefaultValue", "TextDirectId", "RelaEvent", "CheckBoxLimitCount", "AnswerAttLimitSize", "LimitedResourceType", "QuestionTypeId4Course", "QuestionTypeName4Course", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "Scores", "TeacherId", "IsPublish", "PubDate", "publisher", "SpecifyCompletionDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeId", "WorkTypeName", "UpdDate", "UpdUserId", "Memo", "StuNum", "EduClsStuNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWorkEduClsRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWorkEduClsRela = "IdWorkEduClsRela";    //作业教学班关系流水号

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
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

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
 /// 常量:"RelaEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaEvent = "RelaEvent";    //相关事件

 /// <summary>
 /// 常量:"CheckBoxLimitCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckBoxLimitCount = "CheckBoxLimitCount";    //复选框限制数

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CurrEduClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrEduClsId = "CurrEduClsId";    //教学班Id

 /// <summary>
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名

 /// <summary>
 /// 常量:"Scores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Scores = "Scores";    //分值

 /// <summary>
 /// 常量:"TeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherId = "TeacherId";    //教师工号

 /// <summary>
 /// 常量:"IsPublish"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublish = "IsPublish";    //是否发布

 /// <summary>
 /// 常量:"PubDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubDate = "PubDate";    //发布日期

 /// <summary>
 /// 常量:"publisher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string publisher = "publisher";    //发布者Id

 /// <summary>
 /// 常量:"SpecifyCompletionDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SpecifyCompletionDate = "SpecifyCompletionDate";    //指定完成日期

 /// <summary>
 /// 常量:"IsCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrEduCls = "IsCurrEduCls";    //是否为教学班作业

 /// <summary>
 /// 常量:"IsGroupWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGroupWork = "IsGroupWork";    //是否为小组作业

 /// <summary>
 /// 常量:"CourseStudentGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseStudentGroupId = "CourseStudentGroupId";    //学生分组表流水号

 /// <summary>
 /// 常量:"WorkTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkTypeId = "WorkTypeId";    //作业类型Id

 /// <summary>
 /// 常量:"WorkTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkTypeName = "WorkTypeName";    //作业类型名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"StuNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuNum = "StuNum";    //学生数

 /// <summary>
 /// 常量:"EduClsStuNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsStuNum = "EduClsStuNum";    //教学班学生数
}

}