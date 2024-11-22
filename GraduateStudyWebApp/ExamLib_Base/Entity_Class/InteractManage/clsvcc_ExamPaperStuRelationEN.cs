
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperStuRelationEN
 表名:vcc_ExamPaperStuRelation(01120236)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表vcc_ExamPaperStuRelation的关键字(IdExamPaperStuRelation)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdExamPaperStuRelation_vcc_ExamPaperStuRelation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdExamPaperStuRelation">表关键字</param>
public K_IdExamPaperStuRelation_vcc_ExamPaperStuRelation(long lngIdExamPaperStuRelation)
{
if (IsValid(lngIdExamPaperStuRelation)) Value = lngIdExamPaperStuRelation;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdExamPaperStuRelation)
{
if (lngIdExamPaperStuRelation == 0) return false;
if (lngIdExamPaperStuRelation == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdExamPaperStuRelation_vcc_ExamPaperStuRelation]类型的对象</returns>
public static implicit operator K_IdExamPaperStuRelation_vcc_ExamPaperStuRelation(long value)
{
return new K_IdExamPaperStuRelation_vcc_ExamPaperStuRelation(value);
}
}
 /// <summary>
 /// v考卷与学生关系(vcc_ExamPaperStuRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_ExamPaperStuRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_ExamPaperStuRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdExamPaperStuRelation"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 77;
public static string[] AttributeName = new string[] {"IdExamPaperStuRelation", "CourseExamPaperId", "IdExamPaperEduClsRela", "CourseId", "CourseName", "ExamPaperName", "PaperIndex", "ExamPaperTypeId", "ExamPaperTypeName", "PaperDispModeName", "ExamCreateTime", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "IsAutoGeneQuestion", "IsCanMultiDo", "QuestionNum", "CurrEduClsId", "EduClsName", "TeacherID", "PubDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeName", "IdCurrEduCls", "Scores", "SpecifyCompletionDate", "IdStudentInfo", "StuID", "StuName", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "IdGradeBase", "GradeBaseName", "AnswerModeId", "AnswerOptionId", "AnswerMultiOptions", "StuAnswerText", "IsPublish", "IsLook", "IsSave", "IsSubmit", "ApplySendBackDate", "IsApplySendBack", "RealFinishDate", "OperateTime", "Score", "Comment", "IsMarking", "MarkerId", "MarkDate", "IsSendBack", "IsInErrorQuestion", "WorkTypeId", "AnswerIP", "AnswerDate", "AnswerTime", "IsRight", "IsAccessKnowledge", "IsNotProcessTimeout", "SchoolYear", "SchoolTerm", "UpdDate", "UpdUserId", "Memo", "NoSubmitBatchNum", "SubmitBatchNum"};

protected long mlngIdExamPaperStuRelation;    //流水号
protected string mstrCourseExamPaperId;    //考卷流水号
protected long? mlngIdExamPaperEduClsRela;    //作业教学班关系流水号
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrExamPaperName;    //考卷名称
protected int? mintPaperIndex;    //试卷序号
protected string mstrExamPaperTypeId;    //试卷类型Id
protected string mstrExamPaperTypeName;    //试卷类型名称
protected string mstrPaperDispModeName;    //试卷显示模式名称
protected string mstrExamCreateTime;    //考卷建立时间
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrChapterId;    //章Id
protected string mstrSectionId;    //节Id
protected string mstrChapterName;    //章名
protected string mstrSectionName;    //节名
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected bool mbolIsAutoGeneQuestion;    //是否自动生成题目
protected bool mbolIsCanMultiDo;    //是否可以做多次
protected int? mintQuestionNum;    //题目数
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrTeacherID;    //教师工号
protected string mstrPubDate;    //发布日期
protected bool mbolIsCurrEduCls;    //是否为教学班作业
protected bool mbolIsGroupWork;    //是否为小组作业
protected long mlngCourseStudentGroupId;    //学生分组表流水号
protected string mstrWorkTypeName;    //作业类型名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected double? mdblScores;    //分值
protected string mstrSpecifyCompletionDate;    //指定完成日期
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrStuID;    //学号
protected string mstrStuName;    //姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerOptionId;    //回答选项Id
protected string mstrAnswerMultiOptions;    //多选项答案
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
protected bool mbolIsRight;    //是否正确
protected bool mbolIsAccessKnowledge;    //是否处理知识点
protected bool mbolIsNotProcessTimeout;    //是否不处理超时
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintNoSubmitBatchNum;    //未提交批次数
protected int? mintSubmitBatchNum;    //提交批次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_ExamPaperStuRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamPaperStuRelation");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdExamPaperStuRelation">关键字:流水号</param>
public clsvcc_ExamPaperStuRelationEN(long lngIdExamPaperStuRelation)
 {
 if (lngIdExamPaperStuRelation  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdExamPaperStuRelation = lngIdExamPaperStuRelation;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamPaperStuRelation");
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
if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdExamPaperStuRelation)
{
return mlngIdExamPaperStuRelation;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdExamPaperEduClsRela)
{
return mlngIdExamPaperEduClsRela;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ExamPaperName)
{
return mstrExamPaperName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.PaperIndex)
{
return mintPaperIndex;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ExamPaperTypeId)
{
return mstrExamPaperTypeId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ExamPaperTypeName)
{
return mstrExamPaperTypeName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.PaperDispModeName)
{
return mstrPaperDispModeName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ExamCreateTime)
{
return mstrExamCreateTime;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsAutoGeneQuestion)
{
return mbolIsAutoGeneQuestion;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsCanMultiDo)
{
return mbolIsCanMultiDo;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.QuestionNum)
{
return mintQuestionNum;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.TeacherID)
{
return mstrTeacherID;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.PubDate)
{
return mstrPubDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsCurrEduCls)
{
return mbolIsCurrEduCls;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsGroupWork)
{
return mbolIsGroupWork;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseStudentGroupId)
{
return mlngCourseStudentGroupId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.WorkTypeName)
{
return mstrWorkTypeName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SpecifyCompletionDate)
{
return mstrSpecifyCompletionDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerMultiOptions)
{
return mstrAnswerMultiOptions;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.StuAnswerText)
{
return mstrStuAnswerText;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsPublish)
{
return mbolIsPublish;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsLook)
{
return mbolIsLook;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsSave)
{
return mbolIsSave;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ApplySendBackDate)
{
return mstrApplySendBackDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsApplySendBack)
{
return mbolIsApplySendBack;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.RealFinishDate)
{
return mstrRealFinishDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.OperateTime)
{
return mstrOperateTime;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.MarkDate)
{
return mstrMarkDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsSendBack)
{
return mbolIsSendBack;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsInErrorQuestion)
{
return mbolIsInErrorQuestion;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsAccessKnowledge)
{
return mbolIsAccessKnowledge;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsNotProcessTimeout)
{
return mbolIsNotProcessTimeout;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.NoSubmitBatchNum)
{
return mintNoSubmitBatchNum;
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SubmitBatchNum)
{
return mintSubmitBatchNum;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdExamPaperStuRelation)
{
mlngIdExamPaperStuRelation = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdExamPaperStuRelation);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseExamPaperId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdExamPaperEduClsRela)
{
mlngIdExamPaperEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdExamPaperEduClsRela);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ExamPaperName)
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.PaperIndex)
{
mintPaperIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.PaperIndex);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ExamPaperTypeId)
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperTypeId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ExamPaperTypeName)
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperTypeName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.PaperDispModeName)
{
mstrPaperDispModeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.PaperDispModeName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ExamCreateTime)
{
mstrExamCreateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamCreateTime);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseChapterId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseChapterName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionNameSim);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsAutoGeneQuestion)
{
mbolIsAutoGeneQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsAutoGeneQuestion);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsCanMultiDo)
{
mbolIsCanMultiDo = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsCanMultiDo);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.QuestionNum)
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.QuestionNum);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CurrEduClsId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.EduClsName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.TeacherID)
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.TeacherID);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.PubDate)
{
mstrPubDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.PubDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsCurrEduCls)
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsCurrEduCls);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsGroupWork)
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsGroupWork);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CourseStudentGroupId)
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseStudentGroupId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.WorkTypeName)
{
mstrWorkTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.WorkTypeName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdCurrEduCls);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.Scores);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SpecifyCompletionDate)
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SpecifyCompletionDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdStudentInfo);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuID);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdXzCollege);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CollegeName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CollegeNameA);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdXzMajor);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.MajorID);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.MajorName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdGradeBase);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.GradeBaseName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerModeId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerOptionId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerMultiOptions)
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerMultiOptions);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.StuAnswerText)
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuAnswerText);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsPublish)
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsPublish);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsLook)
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsLook);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsSave)
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSave);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSubmit);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.ApplySendBackDate)
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ApplySendBackDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsApplySendBack)
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsApplySendBack);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.RealFinishDate)
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.RealFinishDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.OperateTime)
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.OperateTime);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.Score);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.Comment);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsMarking);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.MarkerId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.MarkDate)
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.MarkDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsSendBack)
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSendBack);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsInErrorQuestion)
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsInErrorQuestion);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.WorkTypeId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerIP);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerTime);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsRight);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsAccessKnowledge)
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsAccessKnowledge);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.IsNotProcessTimeout)
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsNotProcessTimeout);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SchoolYear);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SchoolTerm);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.UpdDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.UpdUserId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.Memo);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.NoSubmitBatchNum)
{
mintNoSubmitBatchNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.NoSubmitBatchNum);
}
else if (strAttributeName  ==  convcc_ExamPaperStuRelation.SubmitBatchNum)
{
mintSubmitBatchNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.SubmitBatchNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_ExamPaperStuRelation.IdExamPaperStuRelation  ==  AttributeName[intIndex])
{
return mlngIdExamPaperStuRelation;
}
else if (convcc_ExamPaperStuRelation.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convcc_ExamPaperStuRelation.IdExamPaperEduClsRela  ==  AttributeName[intIndex])
{
return mlngIdExamPaperEduClsRela;
}
else if (convcc_ExamPaperStuRelation.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_ExamPaperStuRelation.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_ExamPaperStuRelation.ExamPaperName  ==  AttributeName[intIndex])
{
return mstrExamPaperName;
}
else if (convcc_ExamPaperStuRelation.PaperIndex  ==  AttributeName[intIndex])
{
return mintPaperIndex;
}
else if (convcc_ExamPaperStuRelation.ExamPaperTypeId  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeId;
}
else if (convcc_ExamPaperStuRelation.ExamPaperTypeName  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeName;
}
else if (convcc_ExamPaperStuRelation.PaperDispModeName  ==  AttributeName[intIndex])
{
return mstrPaperDispModeName;
}
else if (convcc_ExamPaperStuRelation.ExamCreateTime  ==  AttributeName[intIndex])
{
return mstrExamCreateTime;
}
else if (convcc_ExamPaperStuRelation.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_ExamPaperStuRelation.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_ExamPaperStuRelation.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convcc_ExamPaperStuRelation.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convcc_ExamPaperStuRelation.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_ExamPaperStuRelation.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_ExamPaperStuRelation.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_ExamPaperStuRelation.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_ExamPaperStuRelation.IsAutoGeneQuestion  ==  AttributeName[intIndex])
{
return mbolIsAutoGeneQuestion;
}
else if (convcc_ExamPaperStuRelation.IsCanMultiDo  ==  AttributeName[intIndex])
{
return mbolIsCanMultiDo;
}
else if (convcc_ExamPaperStuRelation.QuestionNum  ==  AttributeName[intIndex])
{
return mintQuestionNum;
}
else if (convcc_ExamPaperStuRelation.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convcc_ExamPaperStuRelation.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convcc_ExamPaperStuRelation.TeacherID  ==  AttributeName[intIndex])
{
return mstrTeacherID;
}
else if (convcc_ExamPaperStuRelation.PubDate  ==  AttributeName[intIndex])
{
return mstrPubDate;
}
else if (convcc_ExamPaperStuRelation.IsCurrEduCls  ==  AttributeName[intIndex])
{
return mbolIsCurrEduCls;
}
else if (convcc_ExamPaperStuRelation.IsGroupWork  ==  AttributeName[intIndex])
{
return mbolIsGroupWork;
}
else if (convcc_ExamPaperStuRelation.CourseStudentGroupId  ==  AttributeName[intIndex])
{
return mlngCourseStudentGroupId;
}
else if (convcc_ExamPaperStuRelation.WorkTypeName  ==  AttributeName[intIndex])
{
return mstrWorkTypeName;
}
else if (convcc_ExamPaperStuRelation.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convcc_ExamPaperStuRelation.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (convcc_ExamPaperStuRelation.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
return mstrSpecifyCompletionDate;
}
else if (convcc_ExamPaperStuRelation.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convcc_ExamPaperStuRelation.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convcc_ExamPaperStuRelation.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convcc_ExamPaperStuRelation.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convcc_ExamPaperStuRelation.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convcc_ExamPaperStuRelation.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convcc_ExamPaperStuRelation.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convcc_ExamPaperStuRelation.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convcc_ExamPaperStuRelation.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convcc_ExamPaperStuRelation.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convcc_ExamPaperStuRelation.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convcc_ExamPaperStuRelation.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convcc_ExamPaperStuRelation.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (convcc_ExamPaperStuRelation.AnswerMultiOptions  ==  AttributeName[intIndex])
{
return mstrAnswerMultiOptions;
}
else if (convcc_ExamPaperStuRelation.StuAnswerText  ==  AttributeName[intIndex])
{
return mstrStuAnswerText;
}
else if (convcc_ExamPaperStuRelation.IsPublish  ==  AttributeName[intIndex])
{
return mbolIsPublish;
}
else if (convcc_ExamPaperStuRelation.IsLook  ==  AttributeName[intIndex])
{
return mbolIsLook;
}
else if (convcc_ExamPaperStuRelation.IsSave  ==  AttributeName[intIndex])
{
return mbolIsSave;
}
else if (convcc_ExamPaperStuRelation.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convcc_ExamPaperStuRelation.ApplySendBackDate  ==  AttributeName[intIndex])
{
return mstrApplySendBackDate;
}
else if (convcc_ExamPaperStuRelation.IsApplySendBack  ==  AttributeName[intIndex])
{
return mbolIsApplySendBack;
}
else if (convcc_ExamPaperStuRelation.RealFinishDate  ==  AttributeName[intIndex])
{
return mstrRealFinishDate;
}
else if (convcc_ExamPaperStuRelation.OperateTime  ==  AttributeName[intIndex])
{
return mstrOperateTime;
}
else if (convcc_ExamPaperStuRelation.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (convcc_ExamPaperStuRelation.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (convcc_ExamPaperStuRelation.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (convcc_ExamPaperStuRelation.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (convcc_ExamPaperStuRelation.MarkDate  ==  AttributeName[intIndex])
{
return mstrMarkDate;
}
else if (convcc_ExamPaperStuRelation.IsSendBack  ==  AttributeName[intIndex])
{
return mbolIsSendBack;
}
else if (convcc_ExamPaperStuRelation.IsInErrorQuestion  ==  AttributeName[intIndex])
{
return mbolIsInErrorQuestion;
}
else if (convcc_ExamPaperStuRelation.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (convcc_ExamPaperStuRelation.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (convcc_ExamPaperStuRelation.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (convcc_ExamPaperStuRelation.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (convcc_ExamPaperStuRelation.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (convcc_ExamPaperStuRelation.IsAccessKnowledge  ==  AttributeName[intIndex])
{
return mbolIsAccessKnowledge;
}
else if (convcc_ExamPaperStuRelation.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
return mbolIsNotProcessTimeout;
}
else if (convcc_ExamPaperStuRelation.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convcc_ExamPaperStuRelation.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convcc_ExamPaperStuRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_ExamPaperStuRelation.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_ExamPaperStuRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_ExamPaperStuRelation.NoSubmitBatchNum  ==  AttributeName[intIndex])
{
return mintNoSubmitBatchNum;
}
else if (convcc_ExamPaperStuRelation.SubmitBatchNum  ==  AttributeName[intIndex])
{
return mintSubmitBatchNum;
}
return null;
}
set
{
if (convcc_ExamPaperStuRelation.IdExamPaperStuRelation  ==  AttributeName[intIndex])
{
mlngIdExamPaperStuRelation = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdExamPaperStuRelation);
}
else if (convcc_ExamPaperStuRelation.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseExamPaperId);
}
else if (convcc_ExamPaperStuRelation.IdExamPaperEduClsRela  ==  AttributeName[intIndex])
{
mlngIdExamPaperEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdExamPaperEduClsRela);
}
else if (convcc_ExamPaperStuRelation.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseId);
}
else if (convcc_ExamPaperStuRelation.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseName);
}
else if (convcc_ExamPaperStuRelation.ExamPaperName  ==  AttributeName[intIndex])
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperName);
}
else if (convcc_ExamPaperStuRelation.PaperIndex  ==  AttributeName[intIndex])
{
mintPaperIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.PaperIndex);
}
else if (convcc_ExamPaperStuRelation.ExamPaperTypeId  ==  AttributeName[intIndex])
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperTypeId);
}
else if (convcc_ExamPaperStuRelation.ExamPaperTypeName  ==  AttributeName[intIndex])
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperTypeName);
}
else if (convcc_ExamPaperStuRelation.PaperDispModeName  ==  AttributeName[intIndex])
{
mstrPaperDispModeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.PaperDispModeName);
}
else if (convcc_ExamPaperStuRelation.ExamCreateTime  ==  AttributeName[intIndex])
{
mstrExamCreateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamCreateTime);
}
else if (convcc_ExamPaperStuRelation.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseChapterId);
}
else if (convcc_ExamPaperStuRelation.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseChapterName);
}
else if (convcc_ExamPaperStuRelation.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterId);
}
else if (convcc_ExamPaperStuRelation.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionId);
}
else if (convcc_ExamPaperStuRelation.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterName);
}
else if (convcc_ExamPaperStuRelation.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionName);
}
else if (convcc_ExamPaperStuRelation.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterNameSim);
}
else if (convcc_ExamPaperStuRelation.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionNameSim);
}
else if (convcc_ExamPaperStuRelation.IsAutoGeneQuestion  ==  AttributeName[intIndex])
{
mbolIsAutoGeneQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsAutoGeneQuestion);
}
else if (convcc_ExamPaperStuRelation.IsCanMultiDo  ==  AttributeName[intIndex])
{
mbolIsCanMultiDo = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsCanMultiDo);
}
else if (convcc_ExamPaperStuRelation.QuestionNum  ==  AttributeName[intIndex])
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.QuestionNum);
}
else if (convcc_ExamPaperStuRelation.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CurrEduClsId);
}
else if (convcc_ExamPaperStuRelation.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.EduClsName);
}
else if (convcc_ExamPaperStuRelation.TeacherID  ==  AttributeName[intIndex])
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.TeacherID);
}
else if (convcc_ExamPaperStuRelation.PubDate  ==  AttributeName[intIndex])
{
mstrPubDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.PubDate);
}
else if (convcc_ExamPaperStuRelation.IsCurrEduCls  ==  AttributeName[intIndex])
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsCurrEduCls);
}
else if (convcc_ExamPaperStuRelation.IsGroupWork  ==  AttributeName[intIndex])
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsGroupWork);
}
else if (convcc_ExamPaperStuRelation.CourseStudentGroupId  ==  AttributeName[intIndex])
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseStudentGroupId);
}
else if (convcc_ExamPaperStuRelation.WorkTypeName  ==  AttributeName[intIndex])
{
mstrWorkTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.WorkTypeName);
}
else if (convcc_ExamPaperStuRelation.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdCurrEduCls);
}
else if (convcc_ExamPaperStuRelation.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.Scores);
}
else if (convcc_ExamPaperStuRelation.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SpecifyCompletionDate);
}
else if (convcc_ExamPaperStuRelation.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdStudentInfo);
}
else if (convcc_ExamPaperStuRelation.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuID);
}
else if (convcc_ExamPaperStuRelation.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuName);
}
else if (convcc_ExamPaperStuRelation.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdXzCollege);
}
else if (convcc_ExamPaperStuRelation.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CollegeName);
}
else if (convcc_ExamPaperStuRelation.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.CollegeNameA);
}
else if (convcc_ExamPaperStuRelation.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdXzMajor);
}
else if (convcc_ExamPaperStuRelation.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.MajorID);
}
else if (convcc_ExamPaperStuRelation.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.MajorName);
}
else if (convcc_ExamPaperStuRelation.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdGradeBase);
}
else if (convcc_ExamPaperStuRelation.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.GradeBaseName);
}
else if (convcc_ExamPaperStuRelation.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerModeId);
}
else if (convcc_ExamPaperStuRelation.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerOptionId);
}
else if (convcc_ExamPaperStuRelation.AnswerMultiOptions  ==  AttributeName[intIndex])
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerMultiOptions);
}
else if (convcc_ExamPaperStuRelation.StuAnswerText  ==  AttributeName[intIndex])
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuAnswerText);
}
else if (convcc_ExamPaperStuRelation.IsPublish  ==  AttributeName[intIndex])
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsPublish);
}
else if (convcc_ExamPaperStuRelation.IsLook  ==  AttributeName[intIndex])
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsLook);
}
else if (convcc_ExamPaperStuRelation.IsSave  ==  AttributeName[intIndex])
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSave);
}
else if (convcc_ExamPaperStuRelation.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSubmit);
}
else if (convcc_ExamPaperStuRelation.ApplySendBackDate  ==  AttributeName[intIndex])
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.ApplySendBackDate);
}
else if (convcc_ExamPaperStuRelation.IsApplySendBack  ==  AttributeName[intIndex])
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsApplySendBack);
}
else if (convcc_ExamPaperStuRelation.RealFinishDate  ==  AttributeName[intIndex])
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.RealFinishDate);
}
else if (convcc_ExamPaperStuRelation.OperateTime  ==  AttributeName[intIndex])
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.OperateTime);
}
else if (convcc_ExamPaperStuRelation.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.Score);
}
else if (convcc_ExamPaperStuRelation.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.Comment);
}
else if (convcc_ExamPaperStuRelation.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsMarking);
}
else if (convcc_ExamPaperStuRelation.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.MarkerId);
}
else if (convcc_ExamPaperStuRelation.MarkDate  ==  AttributeName[intIndex])
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.MarkDate);
}
else if (convcc_ExamPaperStuRelation.IsSendBack  ==  AttributeName[intIndex])
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSendBack);
}
else if (convcc_ExamPaperStuRelation.IsInErrorQuestion  ==  AttributeName[intIndex])
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsInErrorQuestion);
}
else if (convcc_ExamPaperStuRelation.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.WorkTypeId);
}
else if (convcc_ExamPaperStuRelation.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerIP);
}
else if (convcc_ExamPaperStuRelation.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerDate);
}
else if (convcc_ExamPaperStuRelation.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerTime);
}
else if (convcc_ExamPaperStuRelation.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsRight);
}
else if (convcc_ExamPaperStuRelation.IsAccessKnowledge  ==  AttributeName[intIndex])
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsAccessKnowledge);
}
else if (convcc_ExamPaperStuRelation.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsNotProcessTimeout);
}
else if (convcc_ExamPaperStuRelation.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SchoolYear);
}
else if (convcc_ExamPaperStuRelation.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.SchoolTerm);
}
else if (convcc_ExamPaperStuRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.UpdDate);
}
else if (convcc_ExamPaperStuRelation.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.UpdUserId);
}
else if (convcc_ExamPaperStuRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuRelation.Memo);
}
else if (convcc_ExamPaperStuRelation.NoSubmitBatchNum  ==  AttributeName[intIndex])
{
mintNoSubmitBatchNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.NoSubmitBatchNum);
}
else if (convcc_ExamPaperStuRelation.SubmitBatchNum  ==  AttributeName[intIndex])
{
mintSubmitBatchNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuRelation.SubmitBatchNum);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdExamPaperStuRelation
{
get
{
return mlngIdExamPaperStuRelation;
}
set
{
 mlngIdExamPaperStuRelation = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdExamPaperStuRelation);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseExamPaperId);
}
}
/// <summary>
/// 作业教学班关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? IdExamPaperEduClsRela
{
get
{
return mlngIdExamPaperEduClsRela;
}
set
{
 mlngIdExamPaperEduClsRela = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdExamPaperEduClsRela);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperName);
}
}
/// <summary>
/// 试卷序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperIndex
{
get
{
return mintPaperIndex;
}
set
{
 mintPaperIndex = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.PaperIndex);
}
}
/// <summary>
/// 试卷类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperTypeId
{
get
{
return mstrExamPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperTypeId = value;
}
else
{
 mstrExamPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperTypeId);
}
}
/// <summary>
/// 试卷类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperTypeName
{
get
{
return mstrExamPaperTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperTypeName = value;
}
else
{
 mstrExamPaperTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamPaperTypeName);
}
}
/// <summary>
/// 试卷显示模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperDispModeName
{
get
{
return mstrPaperDispModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperDispModeName = value;
}
else
{
 mstrPaperDispModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.PaperDispModeName);
}
}
/// <summary>
/// 考卷建立时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamCreateTime
{
get
{
return mstrExamCreateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamCreateTime = value;
}
else
{
 mstrExamCreateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.ExamCreateTime);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseChapterId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseChapterName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.ChapterNameSim);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.SectionNameSim);
}
}
/// <summary>
/// 是否自动生成题目(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAutoGeneQuestion
{
get
{
return mbolIsAutoGeneQuestion;
}
set
{
 mbolIsAutoGeneQuestion = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsAutoGeneQuestion);
}
}
/// <summary>
/// 是否可以做多次(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCanMultiDo
{
get
{
return mbolIsCanMultiDo;
}
set
{
 mbolIsCanMultiDo = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsCanMultiDo);
}
}
/// <summary>
/// 题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionNum
{
get
{
return mintQuestionNum;
}
set
{
 mintQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.QuestionNum);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.CurrEduClsId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.EduClsName);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherID
{
get
{
return mstrTeacherID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherID = value;
}
else
{
 mstrTeacherID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.TeacherID);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.PubDate);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsCurrEduCls);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsGroupWork);
}
}
/// <summary>
/// 学生分组表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CourseStudentGroupId
{
get
{
return mlngCourseStudentGroupId;
}
set
{
 mlngCourseStudentGroupId = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.CourseStudentGroupId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.WorkTypeName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdCurrEduCls);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.Scores);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.SpecifyCompletionDate);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdStudentInfo);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuID
{
get
{
return mstrStuID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuID = value;
}
else
{
 mstrStuID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuID);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdXzCollege);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.CollegeName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.CollegeNameA);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdXzMajor);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.MajorID);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.MajorName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IdGradeBase);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.GradeBaseName);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerModeId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerOptionId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerMultiOptions);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.StuAnswerText);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsPublish);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsLook);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSave);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSubmit);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.ApplySendBackDate);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsApplySendBack);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.RealFinishDate);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.OperateTime);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.Score);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.Comment);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsMarking);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.MarkerId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.MarkDate);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsSendBack);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsInErrorQuestion);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.WorkTypeId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerIP);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerDate);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.AnswerTime);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsRight);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsAccessKnowledge);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.IsNotProcessTimeout);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.SchoolYear);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.SchoolTerm);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.UpdDate);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.UpdUserId);
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
 AddUpdatedFld(convcc_ExamPaperStuRelation.Memo);
}
}
/// <summary>
/// 未提交批次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? NoSubmitBatchNum
{
get
{
return mintNoSubmitBatchNum;
}
set
{
 mintNoSubmitBatchNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.NoSubmitBatchNum);
}
}
/// <summary>
/// 提交批次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubmitBatchNum
{
get
{
return mintSubmitBatchNum;
}
set
{
 mintSubmitBatchNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuRelation.SubmitBatchNum);
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
  return mlngIdExamPaperStuRelation.ToString();
 }
 }
}
 /// <summary>
 /// v考卷与学生关系(vcc_ExamPaperStuRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_ExamPaperStuRelation
{
public const string _CurrTabName = "vcc_ExamPaperStuRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdExamPaperStuRelation"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdExamPaperStuRelation", "CourseExamPaperId", "IdExamPaperEduClsRela", "CourseId", "CourseName", "ExamPaperName", "PaperIndex", "ExamPaperTypeId", "ExamPaperTypeName", "PaperDispModeName", "ExamCreateTime", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "IsAutoGeneQuestion", "IsCanMultiDo", "QuestionNum", "CurrEduClsId", "EduClsName", "TeacherID", "PubDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeName", "IdCurrEduCls", "Scores", "SpecifyCompletionDate", "IdStudentInfo", "StuID", "StuName", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "IdGradeBase", "GradeBaseName", "AnswerModeId", "AnswerOptionId", "AnswerMultiOptions", "StuAnswerText", "IsPublish", "IsLook", "IsSave", "IsSubmit", "ApplySendBackDate", "IsApplySendBack", "RealFinishDate", "OperateTime", "Score", "Comment", "IsMarking", "MarkerId", "MarkDate", "IsSendBack", "IsInErrorQuestion", "WorkTypeId", "AnswerIP", "AnswerDate", "AnswerTime", "IsRight", "IsAccessKnowledge", "IsNotProcessTimeout", "SchoolYear", "SchoolTerm", "UpdDate", "UpdUserId", "Memo", "NoSubmitBatchNum", "SubmitBatchNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdExamPaperStuRelation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExamPaperStuRelation = "IdExamPaperStuRelation";    //流水号

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"IdExamPaperEduClsRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExamPaperEduClsRela = "IdExamPaperEduClsRela";    //作业教学班关系流水号

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
 /// 常量:"ExamPaperName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperName = "ExamPaperName";    //考卷名称

 /// <summary>
 /// 常量:"PaperIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperIndex = "PaperIndex";    //试卷序号

 /// <summary>
 /// 常量:"ExamPaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperTypeId = "ExamPaperTypeId";    //试卷类型Id

 /// <summary>
 /// 常量:"ExamPaperTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperTypeName = "ExamPaperTypeName";    //试卷类型名称

 /// <summary>
 /// 常量:"PaperDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperDispModeName = "PaperDispModeName";    //试卷显示模式名称

 /// <summary>
 /// 常量:"ExamCreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamCreateTime = "ExamCreateTime";    //考卷建立时间

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
 /// 常量:"IsAutoGeneQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAutoGeneQuestion = "IsAutoGeneQuestion";    //是否自动生成题目

 /// <summary>
 /// 常量:"IsCanMultiDo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCanMultiDo = "IsCanMultiDo";    //是否可以做多次

 /// <summary>
 /// 常量:"QuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNum = "QuestionNum";    //题目数

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
 /// 常量:"TeacherID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherID = "TeacherID";    //教师工号

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"StuID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuID = "StuID";    //学号

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
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

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
 /// 常量:"NoSubmitBatchNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NoSubmitBatchNum = "NoSubmitBatchNum";    //未提交批次数

 /// <summary>
 /// 常量:"SubmitBatchNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubmitBatchNum = "SubmitBatchNum";    //提交批次数
}

}