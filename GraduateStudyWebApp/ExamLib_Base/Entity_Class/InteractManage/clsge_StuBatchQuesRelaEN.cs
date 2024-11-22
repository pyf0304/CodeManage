
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StuBatchQuesRelaEN
 表名:ge_StuBatchQuesRela(01120885)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:31
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
 /// 表ge_StuBatchQuesRela的关键字(IdStuBatchQuesRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdStuBatchQuesRela_ge_StuBatchQuesRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdStuBatchQuesRela">表关键字</param>
public K_IdStuBatchQuesRela_ge_StuBatchQuesRela(long lngIdStuBatchQuesRela)
{
if (IsValid(lngIdStuBatchQuesRela)) Value = lngIdStuBatchQuesRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdStuBatchQuesRela)
{
if (lngIdStuBatchQuesRela == 0) return false;
if (lngIdStuBatchQuesRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdStuBatchQuesRela_ge_StuBatchQuesRela]类型的对象</returns>
public static implicit operator K_IdStuBatchQuesRela_ge_StuBatchQuesRela(long value)
{
return new K_IdStuBatchQuesRela_ge_StuBatchQuesRela(value);
}
}
 /// <summary>
 /// 学生批次题目关系(ge_StuBatchQuesRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_StuBatchQuesRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_StuBatchQuesRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdStuBatchQuesRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 44;
public static string[] AttributeName = new string[] {"IdStuBatchQuesRela", "ExamBatchNo", "LevelNo", "QuestionId", "UserId", "IdCurrEduCls", "QuestionIndex4Batch", "GameLevelId", "Scores", "Score", "StuAnswerText", "AnswerDate", "AnswerIP", "AnswerModeId", "AnswerMultiOptions", "AnswerOptionId", "AnswerTime", "ApplySendBackDate", "Comment", "IsAccessKnowledge", "IsApplySendBack", "IsInErrorQuestion", "IsLook", "IsMarking", "IsNotProcessTimeout", "IsHasAnswer", "IsPublish", "IsRight", "IsSave", "IsSendBack", "IsSubmit", "MarkDate", "MarkerId", "OperateTime", "RealFinishDate", "WorkTypeId", "SchoolYear", "SchoolTerm", "ErrMsg", "IsRecommend", "CourseId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdStuBatchQuesRela;    //学生批次题目关系流水号
protected string mstrExamBatchNo;    //学生批次号
protected int? mintLevelNo;    //学习关号2
protected long mlngQuestionId;    //题目Id
protected string mstrUserId;    //用户ID
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintQuestionIndex4Batch;    //题序号4批次
protected string mstrGameLevelId;    //游戏关卡Id
protected double? mdblScores;    //分值
protected double? mdblScore;    //得分
protected string mstrStuAnswerText;    //学生回答文本
protected string mstrAnswerDate;    //回答日期
protected string mstrAnswerIP;    //回答IP
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerMultiOptions;    //多选项答案
protected string mstrAnswerOptionId;    //回答选项Id
protected string mstrAnswerTime;    //回答时间
protected string mstrApplySendBackDate;    //申请退回日期
protected string mstrComment;    //批注
protected bool mbolIsAccessKnowledge;    //是否处理知识点
protected bool mbolIsApplySendBack;    //是否申请退回
protected bool mbolIsInErrorQuestion;    //是否进入错题
protected bool mbolIsLook;    //是否查看
protected bool mbolIsMarking;    //是否批阅
protected bool mbolIsNotProcessTimeout;    //是否不处理超时
protected bool mbolIsHasAnswer;    //是否有答案
protected bool mbolIsPublish;    //是否发布
protected bool mbolIsRight;    //是否正确
protected bool mbolIsSave;    //是否保存
protected bool mbolIsSendBack;    //是否退回
protected bool mbolIsSubmit;    //是否提交
protected string mstrMarkDate;    //打分日期
protected string mstrMarkerId;    //打分者
protected string mstrOperateTime;    //操作时间
protected string mstrRealFinishDate;    //实际完成日期
protected string mstrWorkTypeId;    //作业类型Id
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrErrMsg;    //错误信息
protected bool mbolIsRecommend;    //是否推荐
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_StuBatchQuesRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStuBatchQuesRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdStuBatchQuesRela">关键字:学生批次题目关系流水号</param>
public clsge_StuBatchQuesRelaEN(long lngIdStuBatchQuesRela)
 {
 if (lngIdStuBatchQuesRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdStuBatchQuesRela = lngIdStuBatchQuesRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStuBatchQuesRela");
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
if (strAttributeName  ==  conge_StuBatchQuesRela.IdStuBatchQuesRela)
{
return mlngIdStuBatchQuesRela;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.ExamBatchNo)
{
return mstrExamBatchNo;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.LevelNo)
{
return mintLevelNo;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.QuestionIndex4Batch)
{
return mintQuestionIndex4Batch;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.GameLevelId)
{
return mstrGameLevelId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.StuAnswerText)
{
return mstrStuAnswerText;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerMultiOptions)
{
return mstrAnswerMultiOptions;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.ApplySendBackDate)
{
return mstrApplySendBackDate;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsAccessKnowledge)
{
return mbolIsAccessKnowledge;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsApplySendBack)
{
return mbolIsApplySendBack;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsInErrorQuestion)
{
return mbolIsInErrorQuestion;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsLook)
{
return mbolIsLook;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsNotProcessTimeout)
{
return mbolIsNotProcessTimeout;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsHasAnswer)
{
return mbolIsHasAnswer;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsPublish)
{
return mbolIsPublish;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsSave)
{
return mbolIsSave;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsSendBack)
{
return mbolIsSendBack;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.MarkDate)
{
return mstrMarkDate;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.OperateTime)
{
return mstrOperateTime;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.RealFinishDate)
{
return mstrRealFinishDate;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_StuBatchQuesRela.IdStuBatchQuesRela)
{
mlngIdStuBatchQuesRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IdStuBatchQuesRela);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.ExamBatchNo)
{
mstrExamBatchNo = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.ExamBatchNo);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.LevelNo)
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.LevelNo);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.QuestionId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.UserId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.IdCurrEduCls);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.QuestionIndex4Batch)
{
mintQuestionIndex4Batch = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.QuestionIndex4Batch);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.GameLevelId)
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.GameLevelId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.Scores);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.Score);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.StuAnswerText)
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.StuAnswerText);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerDate);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerIP);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerModeId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerMultiOptions)
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerMultiOptions);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerOptionId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerTime);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.ApplySendBackDate)
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.ApplySendBackDate);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.Comment);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsAccessKnowledge)
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsAccessKnowledge);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsApplySendBack)
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsApplySendBack);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsInErrorQuestion)
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsInErrorQuestion);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsLook)
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsLook);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsMarking);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsNotProcessTimeout)
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsNotProcessTimeout);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsHasAnswer)
{
mbolIsHasAnswer = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsHasAnswer);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsPublish)
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsPublish);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsRight);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsSave)
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsSave);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsSendBack)
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsSendBack);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsSubmit);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.MarkDate)
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.MarkDate);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.MarkerId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.OperateTime)
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.OperateTime);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.RealFinishDate)
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.RealFinishDate);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.WorkTypeId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.SchoolYear);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.SchoolTerm);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.ErrMsg);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsRecommend);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.CourseId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.UpdDate);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.UpdUserId);
}
else if (strAttributeName  ==  conge_StuBatchQuesRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_StuBatchQuesRela.IdStuBatchQuesRela  ==  AttributeName[intIndex])
{
return mlngIdStuBatchQuesRela;
}
else if (conge_StuBatchQuesRela.ExamBatchNo  ==  AttributeName[intIndex])
{
return mstrExamBatchNo;
}
else if (conge_StuBatchQuesRela.LevelNo  ==  AttributeName[intIndex])
{
return mintLevelNo;
}
else if (conge_StuBatchQuesRela.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conge_StuBatchQuesRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conge_StuBatchQuesRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conge_StuBatchQuesRela.QuestionIndex4Batch  ==  AttributeName[intIndex])
{
return mintQuestionIndex4Batch;
}
else if (conge_StuBatchQuesRela.GameLevelId  ==  AttributeName[intIndex])
{
return mstrGameLevelId;
}
else if (conge_StuBatchQuesRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (conge_StuBatchQuesRela.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (conge_StuBatchQuesRela.StuAnswerText  ==  AttributeName[intIndex])
{
return mstrStuAnswerText;
}
else if (conge_StuBatchQuesRela.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (conge_StuBatchQuesRela.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (conge_StuBatchQuesRela.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (conge_StuBatchQuesRela.AnswerMultiOptions  ==  AttributeName[intIndex])
{
return mstrAnswerMultiOptions;
}
else if (conge_StuBatchQuesRela.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (conge_StuBatchQuesRela.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (conge_StuBatchQuesRela.ApplySendBackDate  ==  AttributeName[intIndex])
{
return mstrApplySendBackDate;
}
else if (conge_StuBatchQuesRela.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (conge_StuBatchQuesRela.IsAccessKnowledge  ==  AttributeName[intIndex])
{
return mbolIsAccessKnowledge;
}
else if (conge_StuBatchQuesRela.IsApplySendBack  ==  AttributeName[intIndex])
{
return mbolIsApplySendBack;
}
else if (conge_StuBatchQuesRela.IsInErrorQuestion  ==  AttributeName[intIndex])
{
return mbolIsInErrorQuestion;
}
else if (conge_StuBatchQuesRela.IsLook  ==  AttributeName[intIndex])
{
return mbolIsLook;
}
else if (conge_StuBatchQuesRela.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (conge_StuBatchQuesRela.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
return mbolIsNotProcessTimeout;
}
else if (conge_StuBatchQuesRela.IsHasAnswer  ==  AttributeName[intIndex])
{
return mbolIsHasAnswer;
}
else if (conge_StuBatchQuesRela.IsPublish  ==  AttributeName[intIndex])
{
return mbolIsPublish;
}
else if (conge_StuBatchQuesRela.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (conge_StuBatchQuesRela.IsSave  ==  AttributeName[intIndex])
{
return mbolIsSave;
}
else if (conge_StuBatchQuesRela.IsSendBack  ==  AttributeName[intIndex])
{
return mbolIsSendBack;
}
else if (conge_StuBatchQuesRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conge_StuBatchQuesRela.MarkDate  ==  AttributeName[intIndex])
{
return mstrMarkDate;
}
else if (conge_StuBatchQuesRela.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (conge_StuBatchQuesRela.OperateTime  ==  AttributeName[intIndex])
{
return mstrOperateTime;
}
else if (conge_StuBatchQuesRela.RealFinishDate  ==  AttributeName[intIndex])
{
return mstrRealFinishDate;
}
else if (conge_StuBatchQuesRela.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (conge_StuBatchQuesRela.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conge_StuBatchQuesRela.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conge_StuBatchQuesRela.ErrMsg  ==  AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conge_StuBatchQuesRela.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (conge_StuBatchQuesRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_StuBatchQuesRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_StuBatchQuesRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conge_StuBatchQuesRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_StuBatchQuesRela.IdStuBatchQuesRela  ==  AttributeName[intIndex])
{
mlngIdStuBatchQuesRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IdStuBatchQuesRela);
}
else if (conge_StuBatchQuesRela.ExamBatchNo  ==  AttributeName[intIndex])
{
mstrExamBatchNo = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.ExamBatchNo);
}
else if (conge_StuBatchQuesRela.LevelNo  ==  AttributeName[intIndex])
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.LevelNo);
}
else if (conge_StuBatchQuesRela.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.QuestionId);
}
else if (conge_StuBatchQuesRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.UserId);
}
else if (conge_StuBatchQuesRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.IdCurrEduCls);
}
else if (conge_StuBatchQuesRela.QuestionIndex4Batch  ==  AttributeName[intIndex])
{
mintQuestionIndex4Batch = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.QuestionIndex4Batch);
}
else if (conge_StuBatchQuesRela.GameLevelId  ==  AttributeName[intIndex])
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.GameLevelId);
}
else if (conge_StuBatchQuesRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.Scores);
}
else if (conge_StuBatchQuesRela.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.Score);
}
else if (conge_StuBatchQuesRela.StuAnswerText  ==  AttributeName[intIndex])
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.StuAnswerText);
}
else if (conge_StuBatchQuesRela.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerDate);
}
else if (conge_StuBatchQuesRela.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerIP);
}
else if (conge_StuBatchQuesRela.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerModeId);
}
else if (conge_StuBatchQuesRela.AnswerMultiOptions  ==  AttributeName[intIndex])
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerMultiOptions);
}
else if (conge_StuBatchQuesRela.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerOptionId);
}
else if (conge_StuBatchQuesRela.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerTime);
}
else if (conge_StuBatchQuesRela.ApplySendBackDate  ==  AttributeName[intIndex])
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.ApplySendBackDate);
}
else if (conge_StuBatchQuesRela.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.Comment);
}
else if (conge_StuBatchQuesRela.IsAccessKnowledge  ==  AttributeName[intIndex])
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsAccessKnowledge);
}
else if (conge_StuBatchQuesRela.IsApplySendBack  ==  AttributeName[intIndex])
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsApplySendBack);
}
else if (conge_StuBatchQuesRela.IsInErrorQuestion  ==  AttributeName[intIndex])
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsInErrorQuestion);
}
else if (conge_StuBatchQuesRela.IsLook  ==  AttributeName[intIndex])
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsLook);
}
else if (conge_StuBatchQuesRela.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsMarking);
}
else if (conge_StuBatchQuesRela.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsNotProcessTimeout);
}
else if (conge_StuBatchQuesRela.IsHasAnswer  ==  AttributeName[intIndex])
{
mbolIsHasAnswer = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsHasAnswer);
}
else if (conge_StuBatchQuesRela.IsPublish  ==  AttributeName[intIndex])
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsPublish);
}
else if (conge_StuBatchQuesRela.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsRight);
}
else if (conge_StuBatchQuesRela.IsSave  ==  AttributeName[intIndex])
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsSave);
}
else if (conge_StuBatchQuesRela.IsSendBack  ==  AttributeName[intIndex])
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsSendBack);
}
else if (conge_StuBatchQuesRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsSubmit);
}
else if (conge_StuBatchQuesRela.MarkDate  ==  AttributeName[intIndex])
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.MarkDate);
}
else if (conge_StuBatchQuesRela.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.MarkerId);
}
else if (conge_StuBatchQuesRela.OperateTime  ==  AttributeName[intIndex])
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.OperateTime);
}
else if (conge_StuBatchQuesRela.RealFinishDate  ==  AttributeName[intIndex])
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.RealFinishDate);
}
else if (conge_StuBatchQuesRela.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.WorkTypeId);
}
else if (conge_StuBatchQuesRela.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.SchoolYear);
}
else if (conge_StuBatchQuesRela.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.SchoolTerm);
}
else if (conge_StuBatchQuesRela.ErrMsg  ==  AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.ErrMsg);
}
else if (conge_StuBatchQuesRela.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StuBatchQuesRela.IsRecommend);
}
else if (conge_StuBatchQuesRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.CourseId);
}
else if (conge_StuBatchQuesRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.UpdDate);
}
else if (conge_StuBatchQuesRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.UpdUserId);
}
else if (conge_StuBatchQuesRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StuBatchQuesRela.Memo);
}
}
}

/// <summary>
/// 学生批次题目关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdStuBatchQuesRela
{
get
{
return mlngIdStuBatchQuesRela;
}
set
{
 mlngIdStuBatchQuesRela = value;
//记录修改过的字段
 AddUpdatedFld(conge_StuBatchQuesRela.IdStuBatchQuesRela);
}
}
/// <summary>
/// 学生批次号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamBatchNo
{
get
{
return mstrExamBatchNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamBatchNo = value;
}
else
{
 mstrExamBatchNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StuBatchQuesRela.ExamBatchNo);
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
 AddUpdatedFld(conge_StuBatchQuesRela.LevelNo);
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
 AddUpdatedFld(conge_StuBatchQuesRela.QuestionId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.UserId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IdCurrEduCls);
}
}
/// <summary>
/// 题序号4批次(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionIndex4Batch
{
get
{
return mintQuestionIndex4Batch;
}
set
{
 mintQuestionIndex4Batch = value;
//记录修改过的字段
 AddUpdatedFld(conge_StuBatchQuesRela.QuestionIndex4Batch);
}
}
/// <summary>
/// 游戏关卡Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GameLevelId
{
get
{
return mstrGameLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGameLevelId = value;
}
else
{
 mstrGameLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StuBatchQuesRela.GameLevelId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.Scores);
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
 AddUpdatedFld(conge_StuBatchQuesRela.Score);
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
 AddUpdatedFld(conge_StuBatchQuesRela.StuAnswerText);
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
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerDate);
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
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerIP);
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
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerModeId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerMultiOptions);
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
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerOptionId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.AnswerTime);
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
 AddUpdatedFld(conge_StuBatchQuesRela.ApplySendBackDate);
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
 AddUpdatedFld(conge_StuBatchQuesRela.Comment);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsAccessKnowledge);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsApplySendBack);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsInErrorQuestion);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsLook);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsMarking);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsNotProcessTimeout);
}
}
/// <summary>
/// 是否有答案(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHasAnswer
{
get
{
return mbolIsHasAnswer;
}
set
{
 mbolIsHasAnswer = value;
//记录修改过的字段
 AddUpdatedFld(conge_StuBatchQuesRela.IsHasAnswer);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsPublish);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsRight);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsSave);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsSendBack);
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
 AddUpdatedFld(conge_StuBatchQuesRela.IsSubmit);
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
 AddUpdatedFld(conge_StuBatchQuesRela.MarkDate);
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
 AddUpdatedFld(conge_StuBatchQuesRela.MarkerId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.OperateTime);
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
 AddUpdatedFld(conge_StuBatchQuesRela.RealFinishDate);
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
 AddUpdatedFld(conge_StuBatchQuesRela.WorkTypeId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.SchoolYear);
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
 AddUpdatedFld(conge_StuBatchQuesRela.SchoolTerm);
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
 AddUpdatedFld(conge_StuBatchQuesRela.ErrMsg);
}
}
/// <summary>
/// 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecommend
{
get
{
return mbolIsRecommend;
}
set
{
 mbolIsRecommend = value;
//记录修改过的字段
 AddUpdatedFld(conge_StuBatchQuesRela.IsRecommend);
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
 AddUpdatedFld(conge_StuBatchQuesRela.CourseId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.UpdDate);
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
 AddUpdatedFld(conge_StuBatchQuesRela.UpdUserId);
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
 AddUpdatedFld(conge_StuBatchQuesRela.Memo);
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
  return mlngIdStuBatchQuesRela.ToString();
 }
 }
}
 /// <summary>
 /// 学生批次题目关系(ge_StuBatchQuesRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_StuBatchQuesRela
{
public const string _CurrTabName = "ge_StuBatchQuesRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdStuBatchQuesRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdStuBatchQuesRela", "ExamBatchNo", "LevelNo", "QuestionId", "UserId", "IdCurrEduCls", "QuestionIndex4Batch", "GameLevelId", "Scores", "Score", "StuAnswerText", "AnswerDate", "AnswerIP", "AnswerModeId", "AnswerMultiOptions", "AnswerOptionId", "AnswerTime", "ApplySendBackDate", "Comment", "IsAccessKnowledge", "IsApplySendBack", "IsInErrorQuestion", "IsLook", "IsMarking", "IsNotProcessTimeout", "IsHasAnswer", "IsPublish", "IsRight", "IsSave", "IsSendBack", "IsSubmit", "MarkDate", "MarkerId", "OperateTime", "RealFinishDate", "WorkTypeId", "SchoolYear", "SchoolTerm", "ErrMsg", "IsRecommend", "CourseId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdStuBatchQuesRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStuBatchQuesRela = "IdStuBatchQuesRela";    //学生批次题目关系流水号

 /// <summary>
 /// 常量:"ExamBatchNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamBatchNo = "ExamBatchNo";    //学生批次号

 /// <summary>
 /// 常量:"LevelNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelNo = "LevelNo";    //学习关号2

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"QuestionIndex4Batch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex4Batch = "QuestionIndex4Batch";    //题序号4批次

 /// <summary>
 /// 常量:"GameLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GameLevelId = "GameLevelId";    //游戏关卡Id

 /// <summary>
 /// 常量:"Scores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Scores = "Scores";    //分值

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"StuAnswerText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuAnswerText = "StuAnswerText";    //学生回答文本

 /// <summary>
 /// 常量:"AnswerDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerDate = "AnswerDate";    //回答日期

 /// <summary>
 /// 常量:"AnswerIP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIP = "AnswerIP";    //回答IP

 /// <summary>
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"AnswerMultiOptions"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerMultiOptions = "AnswerMultiOptions";    //多选项答案

 /// <summary>
 /// 常量:"AnswerOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerOptionId = "AnswerOptionId";    //回答选项Id

 /// <summary>
 /// 常量:"AnswerTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTime = "AnswerTime";    //回答时间

 /// <summary>
 /// 常量:"ApplySendBackDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplySendBackDate = "ApplySendBackDate";    //申请退回日期

 /// <summary>
 /// 常量:"Comment"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Comment = "Comment";    //批注

 /// <summary>
 /// 常量:"IsAccessKnowledge"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAccessKnowledge = "IsAccessKnowledge";    //是否处理知识点

 /// <summary>
 /// 常量:"IsApplySendBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsApplySendBack = "IsApplySendBack";    //是否申请退回

 /// <summary>
 /// 常量:"IsInErrorQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsInErrorQuestion = "IsInErrorQuestion";    //是否进入错题

 /// <summary>
 /// 常量:"IsLook"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLook = "IsLook";    //是否查看

 /// <summary>
 /// 常量:"IsMarking"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMarking = "IsMarking";    //是否批阅

 /// <summary>
 /// 常量:"IsNotProcessTimeout"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNotProcessTimeout = "IsNotProcessTimeout";    //是否不处理超时

 /// <summary>
 /// 常量:"IsHasAnswer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHasAnswer = "IsHasAnswer";    //是否有答案

 /// <summary>
 /// 常量:"IsPublish"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublish = "IsPublish";    //是否发布

 /// <summary>
 /// 常量:"IsRight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRight = "IsRight";    //是否正确

 /// <summary>
 /// 常量:"IsSave"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSave = "IsSave";    //是否保存

 /// <summary>
 /// 常量:"IsSendBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSendBack = "IsSendBack";    //是否退回

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"MarkDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkDate = "MarkDate";    //打分日期

 /// <summary>
 /// 常量:"MarkerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkerId = "MarkerId";    //打分者

 /// <summary>
 /// 常量:"OperateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperateTime = "OperateTime";    //操作时间

 /// <summary>
 /// 常量:"RealFinishDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RealFinishDate = "RealFinishDate";    //实际完成日期

 /// <summary>
 /// 常量:"WorkTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkTypeId = "WorkTypeId";    //作业类型Id

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
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

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