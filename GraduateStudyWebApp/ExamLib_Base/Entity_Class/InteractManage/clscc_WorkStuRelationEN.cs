
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelationEN
 表名:cc_WorkStuRelation(01120145)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:39
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
 /// 表cc_WorkStuRelation的关键字(IdWorkStuRelation)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWorkStuRelation_cc_WorkStuRelation
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
public K_IdWorkStuRelation_cc_WorkStuRelation(long lngIdWorkStuRelation)
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
 /// <returns>返回:[K_IdWorkStuRelation_cc_WorkStuRelation]类型的对象</returns>
public static implicit operator K_IdWorkStuRelation_cc_WorkStuRelation(long value)
{
return new K_IdWorkStuRelation_cc_WorkStuRelation(value);
}
}
 /// <summary>
 /// 作业与学生关系(cc_WorkStuRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_WorkStuRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_WorkStuRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWorkStuRelation"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 41;
public static string[] AttributeName = new string[] {"IdWorkStuRelation", "IdCurrEduCls", "QuestionId", "Scores", "SpecifyCompletionDate", "IdStudentInfo", "AnswerModeId", "AnswerOptionId", "AnswerMultiOptions", "AnswerBoolResult", "StuAnswerText", "IsPublish", "IsLook", "IsSave", "IsSubmit", "ApplySendBackDate", "IsApplySendBack", "RealFinishDate", "OperateTime", "Score", "Comment", "IsMarking", "MarkerId", "MarkDate", "IsSendBack", "IsInErrorQuestion", "WorkTypeId", "AnswerIP", "AnswerDate", "AnswerTime", "CourseExamPaperId", "IsRight", "IsAccessKnowledge", "IsNotProcessTimeout", "SchoolYear", "SchoolTerm", "ErrMsg", "CourseId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdWorkStuRelation;    //流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected long mlngQuestionId;    //题目Id
protected double? mdblScores;    //分值
protected string mstrSpecifyCompletionDate;    //指定完成日期
protected string mstrIdStudentInfo;    //学生流水号
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
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_WorkStuRelationEN()
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
public clscc_WorkStuRelationEN(long lngIdWorkStuRelation)
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
if (strAttributeName  ==  concc_WorkStuRelation.IdWorkStuRelation)
{
return mlngIdWorkStuRelation;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  concc_WorkStuRelation.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  concc_WorkStuRelation.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  concc_WorkStuRelation.SpecifyCompletionDate)
{
return mstrSpecifyCompletionDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerMultiOptions)
{
return mstrAnswerMultiOptions;
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerBoolResult)
{
return mbolAnswerBoolResult;
}
else if (strAttributeName  ==  concc_WorkStuRelation.StuAnswerText)
{
return mstrStuAnswerText;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsPublish)
{
return mbolIsPublish;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsLook)
{
return mbolIsLook;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsSave)
{
return mbolIsSave;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  concc_WorkStuRelation.ApplySendBackDate)
{
return mstrApplySendBackDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsApplySendBack)
{
return mbolIsApplySendBack;
}
else if (strAttributeName  ==  concc_WorkStuRelation.RealFinishDate)
{
return mstrRealFinishDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation.OperateTime)
{
return mstrOperateTime;
}
else if (strAttributeName  ==  concc_WorkStuRelation.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  concc_WorkStuRelation.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  concc_WorkStuRelation.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  concc_WorkStuRelation.MarkDate)
{
return mstrMarkDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsSendBack)
{
return mbolIsSendBack;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsInErrorQuestion)
{
return mbolIsInErrorQuestion;
}
else if (strAttributeName  ==  concc_WorkStuRelation.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  concc_WorkStuRelation.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsAccessKnowledge)
{
return mbolIsAccessKnowledge;
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsNotProcessTimeout)
{
return mbolIsNotProcessTimeout;
}
else if (strAttributeName  ==  concc_WorkStuRelation.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  concc_WorkStuRelation.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  concc_WorkStuRelation.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  concc_WorkStuRelation.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_WorkStuRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_WorkStuRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_WorkStuRelation.IdWorkStuRelation)
{
mlngIdWorkStuRelation = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IdWorkStuRelation);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.IdCurrEduCls);
}
else if (strAttributeName  ==  concc_WorkStuRelation.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.QuestionId);
}
else if (strAttributeName  ==  concc_WorkStuRelation.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.Scores);
}
else if (strAttributeName  ==  concc_WorkStuRelation.SpecifyCompletionDate)
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.SpecifyCompletionDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.IdStudentInfo);
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerModeId);
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerOptionId);
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerMultiOptions)
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerMultiOptions);
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerBoolResult)
{
mbolAnswerBoolResult = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.AnswerBoolResult);
}
else if (strAttributeName  ==  concc_WorkStuRelation.StuAnswerText)
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.StuAnswerText);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsPublish)
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsPublish);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsLook)
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsLook);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsSave)
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsSave);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsSubmit);
}
else if (strAttributeName  ==  concc_WorkStuRelation.ApplySendBackDate)
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.ApplySendBackDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsApplySendBack)
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsApplySendBack);
}
else if (strAttributeName  ==  concc_WorkStuRelation.RealFinishDate)
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.RealFinishDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation.OperateTime)
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.OperateTime);
}
else if (strAttributeName  ==  concc_WorkStuRelation.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.Score);
}
else if (strAttributeName  ==  concc_WorkStuRelation.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.Comment);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsMarking);
}
else if (strAttributeName  ==  concc_WorkStuRelation.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.MarkerId);
}
else if (strAttributeName  ==  concc_WorkStuRelation.MarkDate)
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.MarkDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsSendBack)
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsSendBack);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsInErrorQuestion)
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsInErrorQuestion);
}
else if (strAttributeName  ==  concc_WorkStuRelation.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.WorkTypeId);
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerIP);
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerTime);
}
else if (strAttributeName  ==  concc_WorkStuRelation.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.CourseExamPaperId);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsRight);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsAccessKnowledge)
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsAccessKnowledge);
}
else if (strAttributeName  ==  concc_WorkStuRelation.IsNotProcessTimeout)
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsNotProcessTimeout);
}
else if (strAttributeName  ==  concc_WorkStuRelation.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.SchoolYear);
}
else if (strAttributeName  ==  concc_WorkStuRelation.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.SchoolTerm);
}
else if (strAttributeName  ==  concc_WorkStuRelation.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.ErrMsg);
}
else if (strAttributeName  ==  concc_WorkStuRelation.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.CourseId);
}
else if (strAttributeName  ==  concc_WorkStuRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.UpdDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.UpdUserId);
}
else if (strAttributeName  ==  concc_WorkStuRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_WorkStuRelation.IdWorkStuRelation  ==  AttributeName[intIndex])
{
return mlngIdWorkStuRelation;
}
else if (concc_WorkStuRelation.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (concc_WorkStuRelation.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (concc_WorkStuRelation.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (concc_WorkStuRelation.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
return mstrSpecifyCompletionDate;
}
else if (concc_WorkStuRelation.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (concc_WorkStuRelation.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (concc_WorkStuRelation.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (concc_WorkStuRelation.AnswerMultiOptions  ==  AttributeName[intIndex])
{
return mstrAnswerMultiOptions;
}
else if (concc_WorkStuRelation.AnswerBoolResult  ==  AttributeName[intIndex])
{
return mbolAnswerBoolResult;
}
else if (concc_WorkStuRelation.StuAnswerText  ==  AttributeName[intIndex])
{
return mstrStuAnswerText;
}
else if (concc_WorkStuRelation.IsPublish  ==  AttributeName[intIndex])
{
return mbolIsPublish;
}
else if (concc_WorkStuRelation.IsLook  ==  AttributeName[intIndex])
{
return mbolIsLook;
}
else if (concc_WorkStuRelation.IsSave  ==  AttributeName[intIndex])
{
return mbolIsSave;
}
else if (concc_WorkStuRelation.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (concc_WorkStuRelation.ApplySendBackDate  ==  AttributeName[intIndex])
{
return mstrApplySendBackDate;
}
else if (concc_WorkStuRelation.IsApplySendBack  ==  AttributeName[intIndex])
{
return mbolIsApplySendBack;
}
else if (concc_WorkStuRelation.RealFinishDate  ==  AttributeName[intIndex])
{
return mstrRealFinishDate;
}
else if (concc_WorkStuRelation.OperateTime  ==  AttributeName[intIndex])
{
return mstrOperateTime;
}
else if (concc_WorkStuRelation.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (concc_WorkStuRelation.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (concc_WorkStuRelation.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (concc_WorkStuRelation.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (concc_WorkStuRelation.MarkDate  ==  AttributeName[intIndex])
{
return mstrMarkDate;
}
else if (concc_WorkStuRelation.IsSendBack  ==  AttributeName[intIndex])
{
return mbolIsSendBack;
}
else if (concc_WorkStuRelation.IsInErrorQuestion  ==  AttributeName[intIndex])
{
return mbolIsInErrorQuestion;
}
else if (concc_WorkStuRelation.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (concc_WorkStuRelation.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (concc_WorkStuRelation.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (concc_WorkStuRelation.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (concc_WorkStuRelation.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (concc_WorkStuRelation.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (concc_WorkStuRelation.IsAccessKnowledge  ==  AttributeName[intIndex])
{
return mbolIsAccessKnowledge;
}
else if (concc_WorkStuRelation.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
return mbolIsNotProcessTimeout;
}
else if (concc_WorkStuRelation.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (concc_WorkStuRelation.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (concc_WorkStuRelation.ErrMsg  ==  AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (concc_WorkStuRelation.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_WorkStuRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_WorkStuRelation.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_WorkStuRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_WorkStuRelation.IdWorkStuRelation  ==  AttributeName[intIndex])
{
mlngIdWorkStuRelation = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IdWorkStuRelation);
}
else if (concc_WorkStuRelation.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.IdCurrEduCls);
}
else if (concc_WorkStuRelation.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.QuestionId);
}
else if (concc_WorkStuRelation.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.Scores);
}
else if (concc_WorkStuRelation.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.SpecifyCompletionDate);
}
else if (concc_WorkStuRelation.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.IdStudentInfo);
}
else if (concc_WorkStuRelation.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerModeId);
}
else if (concc_WorkStuRelation.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerOptionId);
}
else if (concc_WorkStuRelation.AnswerMultiOptions  ==  AttributeName[intIndex])
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerMultiOptions);
}
else if (concc_WorkStuRelation.AnswerBoolResult  ==  AttributeName[intIndex])
{
mbolAnswerBoolResult = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.AnswerBoolResult);
}
else if (concc_WorkStuRelation.StuAnswerText  ==  AttributeName[intIndex])
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.StuAnswerText);
}
else if (concc_WorkStuRelation.IsPublish  ==  AttributeName[intIndex])
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsPublish);
}
else if (concc_WorkStuRelation.IsLook  ==  AttributeName[intIndex])
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsLook);
}
else if (concc_WorkStuRelation.IsSave  ==  AttributeName[intIndex])
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsSave);
}
else if (concc_WorkStuRelation.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsSubmit);
}
else if (concc_WorkStuRelation.ApplySendBackDate  ==  AttributeName[intIndex])
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.ApplySendBackDate);
}
else if (concc_WorkStuRelation.IsApplySendBack  ==  AttributeName[intIndex])
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsApplySendBack);
}
else if (concc_WorkStuRelation.RealFinishDate  ==  AttributeName[intIndex])
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.RealFinishDate);
}
else if (concc_WorkStuRelation.OperateTime  ==  AttributeName[intIndex])
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.OperateTime);
}
else if (concc_WorkStuRelation.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.Score);
}
else if (concc_WorkStuRelation.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.Comment);
}
else if (concc_WorkStuRelation.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsMarking);
}
else if (concc_WorkStuRelation.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.MarkerId);
}
else if (concc_WorkStuRelation.MarkDate  ==  AttributeName[intIndex])
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.MarkDate);
}
else if (concc_WorkStuRelation.IsSendBack  ==  AttributeName[intIndex])
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsSendBack);
}
else if (concc_WorkStuRelation.IsInErrorQuestion  ==  AttributeName[intIndex])
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsInErrorQuestion);
}
else if (concc_WorkStuRelation.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.WorkTypeId);
}
else if (concc_WorkStuRelation.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerIP);
}
else if (concc_WorkStuRelation.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerDate);
}
else if (concc_WorkStuRelation.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.AnswerTime);
}
else if (concc_WorkStuRelation.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.CourseExamPaperId);
}
else if (concc_WorkStuRelation.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsRight);
}
else if (concc_WorkStuRelation.IsAccessKnowledge  ==  AttributeName[intIndex])
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsAccessKnowledge);
}
else if (concc_WorkStuRelation.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation.IsNotProcessTimeout);
}
else if (concc_WorkStuRelation.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.SchoolYear);
}
else if (concc_WorkStuRelation.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.SchoolTerm);
}
else if (concc_WorkStuRelation.ErrMsg  ==  AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.ErrMsg);
}
else if (concc_WorkStuRelation.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.CourseId);
}
else if (concc_WorkStuRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.UpdDate);
}
else if (concc_WorkStuRelation.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.UpdUserId);
}
else if (concc_WorkStuRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation.Memo);
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
 AddUpdatedFld(concc_WorkStuRelation.IdWorkStuRelation);
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
 AddUpdatedFld(concc_WorkStuRelation.IdCurrEduCls);
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
 AddUpdatedFld(concc_WorkStuRelation.QuestionId);
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
 AddUpdatedFld(concc_WorkStuRelation.Scores);
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
 AddUpdatedFld(concc_WorkStuRelation.SpecifyCompletionDate);
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
 AddUpdatedFld(concc_WorkStuRelation.IdStudentInfo);
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
 AddUpdatedFld(concc_WorkStuRelation.AnswerModeId);
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
 AddUpdatedFld(concc_WorkStuRelation.AnswerOptionId);
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
 AddUpdatedFld(concc_WorkStuRelation.AnswerMultiOptions);
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
 AddUpdatedFld(concc_WorkStuRelation.AnswerBoolResult);
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
 AddUpdatedFld(concc_WorkStuRelation.StuAnswerText);
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
 AddUpdatedFld(concc_WorkStuRelation.IsPublish);
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
 AddUpdatedFld(concc_WorkStuRelation.IsLook);
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
 AddUpdatedFld(concc_WorkStuRelation.IsSave);
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
 AddUpdatedFld(concc_WorkStuRelation.IsSubmit);
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
 AddUpdatedFld(concc_WorkStuRelation.ApplySendBackDate);
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
 AddUpdatedFld(concc_WorkStuRelation.IsApplySendBack);
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
 AddUpdatedFld(concc_WorkStuRelation.RealFinishDate);
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
 AddUpdatedFld(concc_WorkStuRelation.OperateTime);
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
 AddUpdatedFld(concc_WorkStuRelation.Score);
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
 AddUpdatedFld(concc_WorkStuRelation.Comment);
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
 AddUpdatedFld(concc_WorkStuRelation.IsMarking);
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
 AddUpdatedFld(concc_WorkStuRelation.MarkerId);
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
 AddUpdatedFld(concc_WorkStuRelation.MarkDate);
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
 AddUpdatedFld(concc_WorkStuRelation.IsSendBack);
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
 AddUpdatedFld(concc_WorkStuRelation.IsInErrorQuestion);
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
 AddUpdatedFld(concc_WorkStuRelation.WorkTypeId);
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
 AddUpdatedFld(concc_WorkStuRelation.AnswerIP);
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
 AddUpdatedFld(concc_WorkStuRelation.AnswerDate);
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
 AddUpdatedFld(concc_WorkStuRelation.AnswerTime);
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
 AddUpdatedFld(concc_WorkStuRelation.CourseExamPaperId);
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
 AddUpdatedFld(concc_WorkStuRelation.IsRight);
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
 AddUpdatedFld(concc_WorkStuRelation.IsAccessKnowledge);
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
 AddUpdatedFld(concc_WorkStuRelation.IsNotProcessTimeout);
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
 AddUpdatedFld(concc_WorkStuRelation.SchoolYear);
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
 AddUpdatedFld(concc_WorkStuRelation.SchoolTerm);
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
 AddUpdatedFld(concc_WorkStuRelation.ErrMsg);
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
 AddUpdatedFld(concc_WorkStuRelation.CourseId);
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
 AddUpdatedFld(concc_WorkStuRelation.UpdDate);
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
 AddUpdatedFld(concc_WorkStuRelation.UpdUserId);
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
 AddUpdatedFld(concc_WorkStuRelation.Memo);
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
 /// 作业与学生关系(cc_WorkStuRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_WorkStuRelation
{
public const string _CurrTabName = "cc_WorkStuRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWorkStuRelation"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWorkStuRelation", "IdCurrEduCls", "QuestionId", "Scores", "SpecifyCompletionDate", "IdStudentInfo", "AnswerModeId", "AnswerOptionId", "AnswerMultiOptions", "AnswerBoolResult", "StuAnswerText", "IsPublish", "IsLook", "IsSave", "IsSubmit", "ApplySendBackDate", "IsApplySendBack", "RealFinishDate", "OperateTime", "Score", "Comment", "IsMarking", "MarkerId", "MarkDate", "IsSendBack", "IsInErrorQuestion", "WorkTypeId", "AnswerIP", "AnswerDate", "AnswerTime", "CourseExamPaperId", "IsRight", "IsAccessKnowledge", "IsNotProcessTimeout", "SchoolYear", "SchoolTerm", "ErrMsg", "CourseId", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

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