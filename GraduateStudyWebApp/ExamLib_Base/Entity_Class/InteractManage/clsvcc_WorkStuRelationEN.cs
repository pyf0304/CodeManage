
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationEN
 表名:vcc_WorkStuRelation(01120198)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:11
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
 /// 表vcc_WorkStuRelation的关键字(IdWorkStuRelation)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWorkStuRelation_vcc_WorkStuRelation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdWorkStuRelation">表关键字</param>
public K_IdWorkStuRelation_vcc_WorkStuRelation(long lngIdWorkStuRelation)
{
if (IsValid(lngIdWorkStuRelation)) Value = lngIdWorkStuRelation;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdWorkStuRelation)
{
if (lngIdWorkStuRelation == 0) return false;
if (lngIdWorkStuRelation == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWorkStuRelation_vcc_WorkStuRelation]类型的对象</returns>
public static implicit operator K_IdWorkStuRelation_vcc_WorkStuRelation(long value)
{
return new K_IdWorkStuRelation_vcc_WorkStuRelation(value);
}
}
 /// <summary>
 /// v作业与学生关系表(vcc_WorkStuRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_WorkStuRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_WorkStuRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWorkStuRelation"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 87;
public static string[] AttributeName = new string[] {"IdWorkStuRelation", "IdCurrEduCls", "IdWorkEduClsRela", "QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "QuestionTypeId", "QuestionTypeName", "AnswerTypeId", "DefaultValue", "TextDirectId", "RelaEvent", "CheckBoxLimitCount", "AnswerAttLimitSize", "LimitedResourceType", "QuestionTypeId4Course", "QuestionTypeName4Course", "CurrEduClsId", "EduClsName", "TeacherId", "PubDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeName", "Scores", "SpecifyCompletionDate", "IdStudentInfo", "StuId", "StuName", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorId", "MajorName", "IdGradeBase", "GradeBaseName", "AdminClsName", "AdminClsId", "AnswerModeId", "AnswerOptionId", "AnswerMultiOptions", "AnswerBoolResult", "StuAnswerText", "IsPublish", "IsLook", "IsSave", "IsSubmit", "ApplySendBackDate", "IsApplySendBack", "RealFinishDate", "OperateTime", "Score", "Comment", "IsMarking", "MarkerId", "MarkDate", "IsSendBack", "IsInErrorQuestion", "WorkTypeId", "AnswerIP", "AnswerDate", "AnswerTime", "CourseExamPaperId", "IsRight", "IsAccessKnowledge", "IsNotProcessTimeout", "SchoolYear", "SchoolTerm", "ErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdWorkStuRelation;    //流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected long? mlngIdWorkEduClsRela;    //作业教学班关系流水号
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
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrDefaultValue;    //缺省值
protected string mstrTextDirectId;    //文本方向ID
protected string mstrRelaEvent;    //相关事件
protected int? mintCheckBoxLimitCount;    //复选框限制数
protected long? mlngAnswerAttLimitSize;    //回答附件限制大小
protected string mstrLimitedResourceType;    //限制资源类型
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrQuestionTypeName4Course;    //题目类型名4课程
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrTeacherId;    //教师工号
protected string mstrPubDate;    //发布日期
protected bool mbolIsCurrEduCls;    //是否为教学班作业
protected bool mbolIsGroupWork;    //是否为小组作业
protected long? mlngCourseStudentGroupId;    //学生分组表流水号
protected string mstrWorkTypeName;    //作业类型名称
protected double? mdblScores;    //分值
protected string mstrSpecifyCompletionDate;    //指定完成日期
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrStuId;    //学号
protected string mstrStuName;    //姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorId;    //专业Id
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrAdminClsName;    //行政班名称
protected string mstrAdminClsId;    //行政班代号
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerOptionId;    //回答选项Id
protected string mstrAnswerMultiOptions;    //多选项答案
protected bool mbolAnswerBoolResult;    //答案布尔结果
protected string mstrStuAnswerText;    //学生回答文本
protected bool mbolIsPublish;    //是否发布
protected bool mbolIsLook;    //是否查看
protected bool mbolIsSave;    //是否保存
protected bool mbolIsSubmit;    //是否提交
protected string mstrApplySendBackDate;    //申请退回日期
protected bool mbolIsApplySendBack;    //是否申请退回
protected string mstrRealFinishDate;    //实际完成日期
protected string mstrOperateTime;    //操作时间
protected double? mdblScore;    //得分
protected string mstrComment;    //批注
protected bool mbolIsMarking;    //是否批阅
protected string mstrMarkerId;    //打分者
protected string mstrMarkDate;    //打分日期
protected bool mbolIsSendBack;    //是否退回
protected bool mbolIsInErrorQuestion;    //是否进入错题
protected string mstrWorkTypeId;    //作业类型Id
protected string mstrAnswerIP;    //回答IP
protected string mstrAnswerDate;    //回答日期
protected string mstrAnswerTime;    //回答时间
protected string mstrCourseExamPaperId;    //考卷流水号
protected bool mbolIsRight;    //是否正确
protected bool mbolIsAccessKnowledge;    //是否处理知识点
protected bool mbolIsNotProcessTimeout;    //是否不处理超时
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrErrMsg;    //错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_WorkStuRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkStuRelation");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdWorkStuRelation">关键字:流水号</param>
public clsvcc_WorkStuRelationEN(long lngIdWorkStuRelation)
 {
 if (lngIdWorkStuRelation  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdWorkStuRelation = lngIdWorkStuRelation;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkStuRelation");
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
if (strAttributeName  ==  convcc_WorkStuRelation.IdWorkStuRelation)
{
return mlngIdWorkStuRelation;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdWorkEduClsRela)
{
return mlngIdWorkEduClsRela;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ParentNodeId)
{
return mstrParentNodeId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.TextDirectId)
{
return mstrTextDirectId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.RelaEvent)
{
return mstrRelaEvent;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CheckBoxLimitCount)
{
return mintCheckBoxLimitCount;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerAttLimitSize)
{
return mlngAnswerAttLimitSize;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.LimitedResourceType)
{
return mstrLimitedResourceType;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionTypeName4Course)
{
return mstrQuestionTypeName4Course;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.PubDate)
{
return mstrPubDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsCurrEduCls)
{
return mbolIsCurrEduCls;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsGroupWork)
{
return mbolIsGroupWork;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseStudentGroupId)
{
return mlngCourseStudentGroupId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.WorkTypeName)
{
return mstrWorkTypeName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SpecifyCompletionDate)
{
return mstrSpecifyCompletionDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.MajorId)
{
return mstrMajorId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerMultiOptions)
{
return mstrAnswerMultiOptions;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerBoolResult)
{
return mbolAnswerBoolResult;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.StuAnswerText)
{
return mstrStuAnswerText;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsPublish)
{
return mbolIsPublish;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsLook)
{
return mbolIsLook;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsSave)
{
return mbolIsSave;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ApplySendBackDate)
{
return mstrApplySendBackDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsApplySendBack)
{
return mbolIsApplySendBack;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.RealFinishDate)
{
return mstrRealFinishDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.OperateTime)
{
return mstrOperateTime;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.MarkDate)
{
return mstrMarkDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsSendBack)
{
return mbolIsSendBack;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsInErrorQuestion)
{
return mbolIsInErrorQuestion;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsAccessKnowledge)
{
return mbolIsAccessKnowledge;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsNotProcessTimeout)
{
return mbolIsNotProcessTimeout;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_WorkStuRelation.IdWorkStuRelation)
{
mlngIdWorkStuRelation = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IdWorkStuRelation);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdCurrEduCls);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdWorkEduClsRela)
{
mlngIdWorkEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IdWorkEduClsRela);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.QuestionId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.QuestionIndex);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionContent);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ChapterName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SectionName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SectionNameSim);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ParentNodeId)
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterReferred);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeReferred);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerTypeId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.DefaultValue);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.TextDirectId)
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.TextDirectId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.RelaEvent)
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.RelaEvent);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CheckBoxLimitCount)
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.CheckBoxLimitCount);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerAttLimitSize)
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.AnswerAttLimitSize);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.LimitedResourceType)
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.LimitedResourceType);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeId4Course);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.QuestionTypeName4Course)
{
mstrQuestionTypeName4Course = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeName4Course);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CurrEduClsId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.EduClsName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.TeacherId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.PubDate)
{
mstrPubDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.PubDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsCurrEduCls)
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsCurrEduCls);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsGroupWork)
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsGroupWork);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseStudentGroupId)
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.CourseStudentGroupId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.WorkTypeName)
{
mstrWorkTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.WorkTypeName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.Scores);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SpecifyCompletionDate)
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SpecifyCompletionDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdStudentInfo);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.StuId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.StuName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdXzCollege);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CollegeName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CollegeNameA);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdXzMajor);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.MajorId)
{
mstrMajorId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.MajorId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.MajorName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdGradeBase);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.GradeBaseName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AdminClsName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AdminClsId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerModeId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerOptionId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerMultiOptions)
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerMultiOptions);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerBoolResult)
{
mbolAnswerBoolResult = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.AnswerBoolResult);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.StuAnswerText)
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.StuAnswerText);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsPublish)
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsPublish);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsLook)
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsLook);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsSave)
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsSave);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsSubmit);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ApplySendBackDate)
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ApplySendBackDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsApplySendBack)
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsApplySendBack);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.RealFinishDate)
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.RealFinishDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.OperateTime)
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.OperateTime);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.Score);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.Comment);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsMarking);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.MarkerId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.MarkDate)
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.MarkDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsSendBack)
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsSendBack);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsInErrorQuestion)
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsInErrorQuestion);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.WorkTypeId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerIP);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerTime);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseExamPaperId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsRight);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsAccessKnowledge)
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsAccessKnowledge);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.IsNotProcessTimeout)
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsNotProcessTimeout);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SchoolYear);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SchoolTerm);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ErrMsg);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.UpdDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.UpdUserId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_WorkStuRelation.IdWorkStuRelation  ==  AttributeName[intIndex])
{
return mlngIdWorkStuRelation;
}
else if (convcc_WorkStuRelation.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convcc_WorkStuRelation.IdWorkEduClsRela  ==  AttributeName[intIndex])
{
return mlngIdWorkEduClsRela;
}
else if (convcc_WorkStuRelation.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convcc_WorkStuRelation.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convcc_WorkStuRelation.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convcc_WorkStuRelation.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (convcc_WorkStuRelation.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_WorkStuRelation.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_WorkStuRelation.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_WorkStuRelation.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_WorkStuRelation.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_WorkStuRelation.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_WorkStuRelation.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_WorkStuRelation.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_WorkStuRelation.ParentNodeId  ==  AttributeName[intIndex])
{
return mstrParentNodeId;
}
else if (convcc_WorkStuRelation.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convcc_WorkStuRelation.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convcc_WorkStuRelation.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convcc_WorkStuRelation.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convcc_WorkStuRelation.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convcc_WorkStuRelation.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convcc_WorkStuRelation.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (convcc_WorkStuRelation.TextDirectId  ==  AttributeName[intIndex])
{
return mstrTextDirectId;
}
else if (convcc_WorkStuRelation.RelaEvent  ==  AttributeName[intIndex])
{
return mstrRelaEvent;
}
else if (convcc_WorkStuRelation.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
return mintCheckBoxLimitCount;
}
else if (convcc_WorkStuRelation.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
return mlngAnswerAttLimitSize;
}
else if (convcc_WorkStuRelation.LimitedResourceType  ==  AttributeName[intIndex])
{
return mstrLimitedResourceType;
}
else if (convcc_WorkStuRelation.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (convcc_WorkStuRelation.QuestionTypeName4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName4Course;
}
else if (convcc_WorkStuRelation.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convcc_WorkStuRelation.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convcc_WorkStuRelation.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (convcc_WorkStuRelation.PubDate  ==  AttributeName[intIndex])
{
return mstrPubDate;
}
else if (convcc_WorkStuRelation.IsCurrEduCls  ==  AttributeName[intIndex])
{
return mbolIsCurrEduCls;
}
else if (convcc_WorkStuRelation.IsGroupWork  ==  AttributeName[intIndex])
{
return mbolIsGroupWork;
}
else if (convcc_WorkStuRelation.CourseStudentGroupId  ==  AttributeName[intIndex])
{
return mlngCourseStudentGroupId;
}
else if (convcc_WorkStuRelation.WorkTypeName  ==  AttributeName[intIndex])
{
return mstrWorkTypeName;
}
else if (convcc_WorkStuRelation.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (convcc_WorkStuRelation.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
return mstrSpecifyCompletionDate;
}
else if (convcc_WorkStuRelation.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convcc_WorkStuRelation.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (convcc_WorkStuRelation.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convcc_WorkStuRelation.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convcc_WorkStuRelation.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convcc_WorkStuRelation.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convcc_WorkStuRelation.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convcc_WorkStuRelation.MajorId  ==  AttributeName[intIndex])
{
return mstrMajorId;
}
else if (convcc_WorkStuRelation.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convcc_WorkStuRelation.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convcc_WorkStuRelation.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convcc_WorkStuRelation.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (convcc_WorkStuRelation.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (convcc_WorkStuRelation.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convcc_WorkStuRelation.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (convcc_WorkStuRelation.AnswerMultiOptions  ==  AttributeName[intIndex])
{
return mstrAnswerMultiOptions;
}
else if (convcc_WorkStuRelation.AnswerBoolResult  ==  AttributeName[intIndex])
{
return mbolAnswerBoolResult;
}
else if (convcc_WorkStuRelation.StuAnswerText  ==  AttributeName[intIndex])
{
return mstrStuAnswerText;
}
else if (convcc_WorkStuRelation.IsPublish  ==  AttributeName[intIndex])
{
return mbolIsPublish;
}
else if (convcc_WorkStuRelation.IsLook  ==  AttributeName[intIndex])
{
return mbolIsLook;
}
else if (convcc_WorkStuRelation.IsSave  ==  AttributeName[intIndex])
{
return mbolIsSave;
}
else if (convcc_WorkStuRelation.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convcc_WorkStuRelation.ApplySendBackDate  ==  AttributeName[intIndex])
{
return mstrApplySendBackDate;
}
else if (convcc_WorkStuRelation.IsApplySendBack  ==  AttributeName[intIndex])
{
return mbolIsApplySendBack;
}
else if (convcc_WorkStuRelation.RealFinishDate  ==  AttributeName[intIndex])
{
return mstrRealFinishDate;
}
else if (convcc_WorkStuRelation.OperateTime  ==  AttributeName[intIndex])
{
return mstrOperateTime;
}
else if (convcc_WorkStuRelation.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (convcc_WorkStuRelation.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (convcc_WorkStuRelation.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (convcc_WorkStuRelation.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (convcc_WorkStuRelation.MarkDate  ==  AttributeName[intIndex])
{
return mstrMarkDate;
}
else if (convcc_WorkStuRelation.IsSendBack  ==  AttributeName[intIndex])
{
return mbolIsSendBack;
}
else if (convcc_WorkStuRelation.IsInErrorQuestion  ==  AttributeName[intIndex])
{
return mbolIsInErrorQuestion;
}
else if (convcc_WorkStuRelation.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (convcc_WorkStuRelation.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (convcc_WorkStuRelation.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (convcc_WorkStuRelation.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (convcc_WorkStuRelation.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convcc_WorkStuRelation.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (convcc_WorkStuRelation.IsAccessKnowledge  ==  AttributeName[intIndex])
{
return mbolIsAccessKnowledge;
}
else if (convcc_WorkStuRelation.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
return mbolIsNotProcessTimeout;
}
else if (convcc_WorkStuRelation.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convcc_WorkStuRelation.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convcc_WorkStuRelation.ErrMsg  ==  AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (convcc_WorkStuRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_WorkStuRelation.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_WorkStuRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convcc_WorkStuRelation.IdWorkStuRelation  ==  AttributeName[intIndex])
{
mlngIdWorkStuRelation = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IdWorkStuRelation);
}
else if (convcc_WorkStuRelation.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdCurrEduCls);
}
else if (convcc_WorkStuRelation.IdWorkEduClsRela  ==  AttributeName[intIndex])
{
mlngIdWorkEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IdWorkEduClsRela);
}
else if (convcc_WorkStuRelation.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.QuestionId);
}
else if (convcc_WorkStuRelation.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.QuestionIndex);
}
else if (convcc_WorkStuRelation.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionName);
}
else if (convcc_WorkStuRelation.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionContent);
}
else if (convcc_WorkStuRelation.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseId);
}
else if (convcc_WorkStuRelation.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseName);
}
else if (convcc_WorkStuRelation.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterId);
}
else if (convcc_WorkStuRelation.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterName);
}
else if (convcc_WorkStuRelation.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ChapterName);
}
else if (convcc_WorkStuRelation.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SectionName);
}
else if (convcc_WorkStuRelation.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ChapterNameSim);
}
else if (convcc_WorkStuRelation.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SectionNameSim);
}
else if (convcc_WorkStuRelation.ParentNodeId  ==  AttributeName[intIndex])
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeId);
}
else if (convcc_WorkStuRelation.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterReferred);
}
else if (convcc_WorkStuRelation.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeName);
}
else if (convcc_WorkStuRelation.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeReferred);
}
else if (convcc_WorkStuRelation.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeId);
}
else if (convcc_WorkStuRelation.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeName);
}
else if (convcc_WorkStuRelation.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerTypeId);
}
else if (convcc_WorkStuRelation.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.DefaultValue);
}
else if (convcc_WorkStuRelation.TextDirectId  ==  AttributeName[intIndex])
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.TextDirectId);
}
else if (convcc_WorkStuRelation.RelaEvent  ==  AttributeName[intIndex])
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.RelaEvent);
}
else if (convcc_WorkStuRelation.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.CheckBoxLimitCount);
}
else if (convcc_WorkStuRelation.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.AnswerAttLimitSize);
}
else if (convcc_WorkStuRelation.LimitedResourceType  ==  AttributeName[intIndex])
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.LimitedResourceType);
}
else if (convcc_WorkStuRelation.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeId4Course);
}
else if (convcc_WorkStuRelation.QuestionTypeName4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeName4Course = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeName4Course);
}
else if (convcc_WorkStuRelation.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CurrEduClsId);
}
else if (convcc_WorkStuRelation.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.EduClsName);
}
else if (convcc_WorkStuRelation.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.TeacherId);
}
else if (convcc_WorkStuRelation.PubDate  ==  AttributeName[intIndex])
{
mstrPubDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.PubDate);
}
else if (convcc_WorkStuRelation.IsCurrEduCls  ==  AttributeName[intIndex])
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsCurrEduCls);
}
else if (convcc_WorkStuRelation.IsGroupWork  ==  AttributeName[intIndex])
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsGroupWork);
}
else if (convcc_WorkStuRelation.CourseStudentGroupId  ==  AttributeName[intIndex])
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.CourseStudentGroupId);
}
else if (convcc_WorkStuRelation.WorkTypeName  ==  AttributeName[intIndex])
{
mstrWorkTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.WorkTypeName);
}
else if (convcc_WorkStuRelation.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.Scores);
}
else if (convcc_WorkStuRelation.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SpecifyCompletionDate);
}
else if (convcc_WorkStuRelation.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdStudentInfo);
}
else if (convcc_WorkStuRelation.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.StuId);
}
else if (convcc_WorkStuRelation.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.StuName);
}
else if (convcc_WorkStuRelation.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdXzCollege);
}
else if (convcc_WorkStuRelation.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CollegeName);
}
else if (convcc_WorkStuRelation.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CollegeNameA);
}
else if (convcc_WorkStuRelation.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdXzMajor);
}
else if (convcc_WorkStuRelation.MajorId  ==  AttributeName[intIndex])
{
mstrMajorId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.MajorId);
}
else if (convcc_WorkStuRelation.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.MajorName);
}
else if (convcc_WorkStuRelation.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.IdGradeBase);
}
else if (convcc_WorkStuRelation.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.GradeBaseName);
}
else if (convcc_WorkStuRelation.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AdminClsName);
}
else if (convcc_WorkStuRelation.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AdminClsId);
}
else if (convcc_WorkStuRelation.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerModeId);
}
else if (convcc_WorkStuRelation.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerOptionId);
}
else if (convcc_WorkStuRelation.AnswerMultiOptions  ==  AttributeName[intIndex])
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerMultiOptions);
}
else if (convcc_WorkStuRelation.AnswerBoolResult  ==  AttributeName[intIndex])
{
mbolAnswerBoolResult = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.AnswerBoolResult);
}
else if (convcc_WorkStuRelation.StuAnswerText  ==  AttributeName[intIndex])
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.StuAnswerText);
}
else if (convcc_WorkStuRelation.IsPublish  ==  AttributeName[intIndex])
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsPublish);
}
else if (convcc_WorkStuRelation.IsLook  ==  AttributeName[intIndex])
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsLook);
}
else if (convcc_WorkStuRelation.IsSave  ==  AttributeName[intIndex])
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsSave);
}
else if (convcc_WorkStuRelation.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsSubmit);
}
else if (convcc_WorkStuRelation.ApplySendBackDate  ==  AttributeName[intIndex])
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ApplySendBackDate);
}
else if (convcc_WorkStuRelation.IsApplySendBack  ==  AttributeName[intIndex])
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsApplySendBack);
}
else if (convcc_WorkStuRelation.RealFinishDate  ==  AttributeName[intIndex])
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.RealFinishDate);
}
else if (convcc_WorkStuRelation.OperateTime  ==  AttributeName[intIndex])
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.OperateTime);
}
else if (convcc_WorkStuRelation.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.Score);
}
else if (convcc_WorkStuRelation.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.Comment);
}
else if (convcc_WorkStuRelation.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsMarking);
}
else if (convcc_WorkStuRelation.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.MarkerId);
}
else if (convcc_WorkStuRelation.MarkDate  ==  AttributeName[intIndex])
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.MarkDate);
}
else if (convcc_WorkStuRelation.IsSendBack  ==  AttributeName[intIndex])
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsSendBack);
}
else if (convcc_WorkStuRelation.IsInErrorQuestion  ==  AttributeName[intIndex])
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsInErrorQuestion);
}
else if (convcc_WorkStuRelation.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.WorkTypeId);
}
else if (convcc_WorkStuRelation.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerIP);
}
else if (convcc_WorkStuRelation.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerDate);
}
else if (convcc_WorkStuRelation.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.AnswerTime);
}
else if (convcc_WorkStuRelation.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.CourseExamPaperId);
}
else if (convcc_WorkStuRelation.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsRight);
}
else if (convcc_WorkStuRelation.IsAccessKnowledge  ==  AttributeName[intIndex])
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsAccessKnowledge);
}
else if (convcc_WorkStuRelation.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation.IsNotProcessTimeout);
}
else if (convcc_WorkStuRelation.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SchoolYear);
}
else if (convcc_WorkStuRelation.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.SchoolTerm);
}
else if (convcc_WorkStuRelation.ErrMsg  ==  AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.ErrMsg);
}
else if (convcc_WorkStuRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.UpdDate);
}
else if (convcc_WorkStuRelation.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.UpdUserId);
}
else if (convcc_WorkStuRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation.Memo);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdWorkStuRelation
{
get
{
return mlngIdWorkStuRelation;
}
set
{
 mlngIdWorkStuRelation = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IdWorkStuRelation);
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
 AddUpdatedFld(convcc_WorkStuRelation.IdCurrEduCls);
}
}
/// <summary>
/// 作业教学班关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? IdWorkEduClsRela
{
get
{
return mlngIdWorkEduClsRela;
}
set
{
 mlngIdWorkEduClsRela = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IdWorkEduClsRela);
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
 AddUpdatedFld(convcc_WorkStuRelation.QuestionId);
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
 AddUpdatedFld(convcc_WorkStuRelation.QuestionIndex);
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
 AddUpdatedFld(convcc_WorkStuRelation.QuestionName);
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
 AddUpdatedFld(convcc_WorkStuRelation.QuestionContent);
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
 AddUpdatedFld(convcc_WorkStuRelation.CourseId);
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
 AddUpdatedFld(convcc_WorkStuRelation.CourseName);
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
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterId);
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
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterName);
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
 AddUpdatedFld(convcc_WorkStuRelation.ChapterName);
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
 AddUpdatedFld(convcc_WorkStuRelation.SectionName);
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
 AddUpdatedFld(convcc_WorkStuRelation.ChapterNameSim);
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
 AddUpdatedFld(convcc_WorkStuRelation.SectionNameSim);
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
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeId);
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
 AddUpdatedFld(convcc_WorkStuRelation.CourseChapterReferred);
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
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeName);
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
 AddUpdatedFld(convcc_WorkStuRelation.ParentNodeReferred);
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
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeId);
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
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeName);
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
 AddUpdatedFld(convcc_WorkStuRelation.AnswerTypeId);
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
 AddUpdatedFld(convcc_WorkStuRelation.DefaultValue);
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
 AddUpdatedFld(convcc_WorkStuRelation.TextDirectId);
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
 AddUpdatedFld(convcc_WorkStuRelation.RelaEvent);
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
 AddUpdatedFld(convcc_WorkStuRelation.CheckBoxLimitCount);
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
 AddUpdatedFld(convcc_WorkStuRelation.AnswerAttLimitSize);
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
 AddUpdatedFld(convcc_WorkStuRelation.LimitedResourceType);
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
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeId4Course);
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
 AddUpdatedFld(convcc_WorkStuRelation.QuestionTypeName4Course);
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
 AddUpdatedFld(convcc_WorkStuRelation.CurrEduClsId);
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
 AddUpdatedFld(convcc_WorkStuRelation.EduClsName);
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
 AddUpdatedFld(convcc_WorkStuRelation.TeacherId);
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
 AddUpdatedFld(convcc_WorkStuRelation.PubDate);
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
 AddUpdatedFld(convcc_WorkStuRelation.IsCurrEduCls);
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
 AddUpdatedFld(convcc_WorkStuRelation.IsGroupWork);
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
 AddUpdatedFld(convcc_WorkStuRelation.CourseStudentGroupId);
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
 AddUpdatedFld(convcc_WorkStuRelation.WorkTypeName);
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
 AddUpdatedFld(convcc_WorkStuRelation.Scores);
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
 AddUpdatedFld(convcc_WorkStuRelation.SpecifyCompletionDate);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IdStudentInfo);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuId
{
get
{
return mstrStuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuId = value;
}
else
{
 mstrStuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.StuId);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.StuName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IdXzCollege);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.CollegeName);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.CollegeNameA);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IdXzMajor);
}
}
/// <summary>
/// 专业Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorId
{
get
{
return mstrMajorId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorId = value;
}
else
{
 mstrMajorId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.MajorId);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.MajorName);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IdGradeBase);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.GradeBaseName);
}
}
/// <summary>
/// 行政班名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsName
{
get
{
return mstrAdminClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsName = value;
}
else
{
 mstrAdminClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.AdminClsName);
}
}
/// <summary>
/// 行政班代号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsId
{
get
{
return mstrAdminClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsId = value;
}
else
{
 mstrAdminClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.AdminClsId);
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
 AddUpdatedFld(convcc_WorkStuRelation.AnswerModeId);
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
 AddUpdatedFld(convcc_WorkStuRelation.AnswerOptionId);
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
 AddUpdatedFld(convcc_WorkStuRelation.AnswerMultiOptions);
}
}
/// <summary>
/// 答案布尔结果(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool AnswerBoolResult
{
get
{
return mbolAnswerBoolResult;
}
set
{
 mbolAnswerBoolResult = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.AnswerBoolResult);
}
}
/// <summary>
/// 学生回答文本(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuAnswerText
{
get
{
return mstrStuAnswerText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuAnswerText = value;
}
else
{
 mstrStuAnswerText = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.StuAnswerText);
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
 AddUpdatedFld(convcc_WorkStuRelation.IsPublish);
}
}
/// <summary>
/// 是否查看(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLook
{
get
{
return mbolIsLook;
}
set
{
 mbolIsLook = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IsLook);
}
}
/// <summary>
/// 是否保存(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSave
{
get
{
return mbolIsSave;
}
set
{
 mbolIsSave = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IsSave);
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
 AddUpdatedFld(convcc_WorkStuRelation.IsSubmit);
}
}
/// <summary>
/// 申请退回日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplySendBackDate
{
get
{
return mstrApplySendBackDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplySendBackDate = value;
}
else
{
 mstrApplySendBackDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.ApplySendBackDate);
}
}
/// <summary>
/// 是否申请退回(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsApplySendBack
{
get
{
return mbolIsApplySendBack;
}
set
{
 mbolIsApplySendBack = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IsApplySendBack);
}
}
/// <summary>
/// 实际完成日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RealFinishDate
{
get
{
return mstrRealFinishDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRealFinishDate = value;
}
else
{
 mstrRealFinishDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.RealFinishDate);
}
}
/// <summary>
/// 操作时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperateTime
{
get
{
return mstrOperateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperateTime = value;
}
else
{
 mstrOperateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.OperateTime);
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
 AddUpdatedFld(convcc_WorkStuRelation.Score);
}
}
/// <summary>
/// 批注(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Comment
{
get
{
return mstrComment;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrComment = value;
}
else
{
 mstrComment = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.Comment);
}
}
/// <summary>
/// 是否批阅(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMarking
{
get
{
return mbolIsMarking;
}
set
{
 mbolIsMarking = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IsMarking);
}
}
/// <summary>
/// 打分者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkerId
{
get
{
return mstrMarkerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkerId = value;
}
else
{
 mstrMarkerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.MarkerId);
}
}
/// <summary>
/// 打分日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkDate
{
get
{
return mstrMarkDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkDate = value;
}
else
{
 mstrMarkDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.MarkDate);
}
}
/// <summary>
/// 是否退回(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSendBack
{
get
{
return mbolIsSendBack;
}
set
{
 mbolIsSendBack = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IsSendBack);
}
}
/// <summary>
/// 是否进入错题(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsInErrorQuestion
{
get
{
return mbolIsInErrorQuestion;
}
set
{
 mbolIsInErrorQuestion = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IsInErrorQuestion);
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
 AddUpdatedFld(convcc_WorkStuRelation.WorkTypeId);
}
}
/// <summary>
/// 回答IP(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerIP
{
get
{
return mstrAnswerIP;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerIP = value;
}
else
{
 mstrAnswerIP = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.AnswerIP);
}
}
/// <summary>
/// 回答日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerDate
{
get
{
return mstrAnswerDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerDate = value;
}
else
{
 mstrAnswerDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.AnswerDate);
}
}
/// <summary>
/// 回答时间(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTime
{
get
{
return mstrAnswerTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTime = value;
}
else
{
 mstrAnswerTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.AnswerTime);
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
 AddUpdatedFld(convcc_WorkStuRelation.CourseExamPaperId);
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
 AddUpdatedFld(convcc_WorkStuRelation.IsRight);
}
}
/// <summary>
/// 是否处理知识点(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAccessKnowledge
{
get
{
return mbolIsAccessKnowledge;
}
set
{
 mbolIsAccessKnowledge = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IsAccessKnowledge);
}
}
/// <summary>
/// 是否不处理超时(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNotProcessTimeout
{
get
{
return mbolIsNotProcessTimeout;
}
set
{
 mbolIsNotProcessTimeout = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.IsNotProcessTimeout);
}
}
/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolYear
{
get
{
return mstrSchoolYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolYear = value;
}
else
{
 mstrSchoolYear = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.SchoolYear);
}
}
/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.SchoolTerm);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation.ErrMsg);
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
 AddUpdatedFld(convcc_WorkStuRelation.UpdDate);
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
 AddUpdatedFld(convcc_WorkStuRelation.UpdUserId);
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
 AddUpdatedFld(convcc_WorkStuRelation.Memo);
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
  return mlngIdWorkStuRelation.ToString();
 }
 }
}
 /// <summary>
 /// v作业与学生关系表(vcc_WorkStuRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_WorkStuRelation
{
public const string _CurrTabName = "vcc_WorkStuRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWorkStuRelation"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWorkStuRelation", "IdCurrEduCls", "IdWorkEduClsRela", "QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "QuestionTypeId", "QuestionTypeName", "AnswerTypeId", "DefaultValue", "TextDirectId", "RelaEvent", "CheckBoxLimitCount", "AnswerAttLimitSize", "LimitedResourceType", "QuestionTypeId4Course", "QuestionTypeName4Course", "CurrEduClsId", "EduClsName", "TeacherId", "PubDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeName", "Scores", "SpecifyCompletionDate", "IdStudentInfo", "StuId", "StuName", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorId", "MajorName", "IdGradeBase", "GradeBaseName", "AdminClsName", "AdminClsId", "AnswerModeId", "AnswerOptionId", "AnswerMultiOptions", "AnswerBoolResult", "StuAnswerText", "IsPublish", "IsLook", "IsSave", "IsSubmit", "ApplySendBackDate", "IsApplySendBack", "RealFinishDate", "OperateTime", "Score", "Comment", "IsMarking", "MarkerId", "MarkDate", "IsSendBack", "IsInErrorQuestion", "WorkTypeId", "AnswerIP", "AnswerDate", "AnswerTime", "CourseExamPaperId", "IsRight", "IsAccessKnowledge", "IsNotProcessTimeout", "SchoolYear", "SchoolTerm", "ErrMsg", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWorkStuRelation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWorkStuRelation = "IdWorkStuRelation";    //流水号

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

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
 /// 常量:"TeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherId = "TeacherId";    //教师工号

 /// <summary>
 /// 常量:"PubDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubDate = "PubDate";    //发布日期

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
 /// 常量:"WorkTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkTypeName = "WorkTypeName";    //作业类型名称

 /// <summary>
 /// 常量:"Scores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Scores = "Scores";    //分值

 /// <summary>
 /// 常量:"SpecifyCompletionDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SpecifyCompletionDate = "SpecifyCompletionDate";    //指定完成日期

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"StuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuId = "StuId";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorId = "MajorId";    //专业Id

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"AdminClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsName = "AdminClsName";    //行政班名称

 /// <summary>
 /// 常量:"AdminClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsId = "AdminClsId";    //行政班代号

 /// <summary>
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

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
 /// 常量:"AnswerBoolResult"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerBoolResult = "AnswerBoolResult";    //答案布尔结果

 /// <summary>
 /// 常量:"StuAnswerText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuAnswerText = "StuAnswerText";    //学生回答文本

 /// <summary>
 /// 常量:"IsPublish"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublish = "IsPublish";    //是否发布

 /// <summary>
 /// 常量:"IsLook"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLook = "IsLook";    //是否查看

 /// <summary>
 /// 常量:"IsSave"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSave = "IsSave";    //是否保存

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"ApplySendBackDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplySendBackDate = "ApplySendBackDate";    //申请退回日期

 /// <summary>
 /// 常量:"IsApplySendBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsApplySendBack = "IsApplySendBack";    //是否申请退回

 /// <summary>
 /// 常量:"RealFinishDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RealFinishDate = "RealFinishDate";    //实际完成日期

 /// <summary>
 /// 常量:"OperateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperateTime = "OperateTime";    //操作时间

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"Comment"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Comment = "Comment";    //批注

 /// <summary>
 /// 常量:"IsMarking"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMarking = "IsMarking";    //是否批阅

 /// <summary>
 /// 常量:"MarkerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkerId = "MarkerId";    //打分者

 /// <summary>
 /// 常量:"MarkDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkDate = "MarkDate";    //打分日期

 /// <summary>
 /// 常量:"IsSendBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSendBack = "IsSendBack";    //是否退回

 /// <summary>
 /// 常量:"IsInErrorQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsInErrorQuestion = "IsInErrorQuestion";    //是否进入错题

 /// <summary>
 /// 常量:"WorkTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkTypeId = "WorkTypeId";    //作业类型Id

 /// <summary>
 /// 常量:"AnswerIP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIP = "AnswerIP";    //回答IP

 /// <summary>
 /// 常量:"AnswerDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerDate = "AnswerDate";    //回答日期

 /// <summary>
 /// 常量:"AnswerTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTime = "AnswerTime";    //回答时间

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"IsRight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRight = "IsRight";    //是否正确

 /// <summary>
 /// 常量:"IsAccessKnowledge"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAccessKnowledge = "IsAccessKnowledge";    //是否处理知识点

 /// <summary>
 /// 常量:"IsNotProcessTimeout"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNotProcessTimeout = "IsNotProcessTimeout";    //是否不处理超时

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

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
}

}