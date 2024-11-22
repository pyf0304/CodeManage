
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperStuBatchQuesRelaEN
 表名:cc_PaperStuBatchQuesRela(01120240)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:54
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
 /// 表cc_PaperStuBatchQuesRela的关键字(IdPaperStuBatchQuesRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPaperStuBatchQuesRela_cc_PaperStuBatchQuesRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPaperStuBatchQuesRela">表关键字</param>
public K_IdPaperStuBatchQuesRela_cc_PaperStuBatchQuesRela(long lngIdPaperStuBatchQuesRela)
{
if (IsValid(lngIdPaperStuBatchQuesRela)) Value = lngIdPaperStuBatchQuesRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPaperStuBatchQuesRela)
{
if (lngIdPaperStuBatchQuesRela == 0) return false;
if (lngIdPaperStuBatchQuesRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPaperStuBatchQuesRela_cc_PaperStuBatchQuesRela]类型的对象</returns>
public static implicit operator K_IdPaperStuBatchQuesRela_cc_PaperStuBatchQuesRela(long value)
{
return new K_IdPaperStuBatchQuesRela_cc_PaperStuBatchQuesRela(value);
}
}
 /// <summary>
 /// 学生批次题目关系(cc_PaperStuBatchQuesRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_PaperStuBatchQuesRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_PaperStuBatchQuesRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPaperStuBatchQuesRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 38;
public static string[] AttributeName = new string[] {"IdPaperStuBatchQuesRela", "IdPaperStuBatch", "QuestionId", "QuestionIndex4Batch", "Scores", "Score", "StuAnswerText", "AnswerDate", "AnswerIP", "AnswerModeId", "AnswerMultiOptions", "AnswerOptionId", "AnswerTime", "ApplySendBackDate", "Comment", "IsAccessKnowledge", "IsApplySendBack", "IsInErrorQuestion", "IsLook", "IsMarking", "IsNotProcessTimeout", "IsPublish", "IsRight", "IsSave", "IsSendBack", "IsSubmit", "MarkDate", "MarkerId", "OperateTime", "RealFinishDate", "WorkTypeId", "SchoolYear", "SchoolTerm", "ErrMsg", "CourseId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdPaperStuBatchQuesRela;    //学生批次题目关系流水号
protected string mstrIdPaperStuBatch;    //学生试卷批次流水号
protected long? mlngQuestionId;    //题目Id
protected int? mintQuestionIndex4Batch;    //题序号4批次
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
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_PaperStuBatchQuesRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPaperStuBatchQuesRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPaperStuBatchQuesRela">关键字:学生批次题目关系流水号</param>
public clscc_PaperStuBatchQuesRelaEN(long lngIdPaperStuBatchQuesRela)
 {
 if (lngIdPaperStuBatchQuesRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPaperStuBatchQuesRela = lngIdPaperStuBatchQuesRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPaperStuBatchQuesRela");
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
if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela)
{
return mlngIdPaperStuBatchQuesRela;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IdPaperStuBatch)
{
return mstrIdPaperStuBatch;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.QuestionIndex4Batch)
{
return mintQuestionIndex4Batch;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.StuAnswerText)
{
return mstrStuAnswerText;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerMultiOptions)
{
return mstrAnswerMultiOptions;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.ApplySendBackDate)
{
return mstrApplySendBackDate;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsAccessKnowledge)
{
return mbolIsAccessKnowledge;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsApplySendBack)
{
return mbolIsApplySendBack;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsInErrorQuestion)
{
return mbolIsInErrorQuestion;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsLook)
{
return mbolIsLook;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsNotProcessTimeout)
{
return mbolIsNotProcessTimeout;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsPublish)
{
return mbolIsPublish;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsSave)
{
return mbolIsSave;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsSendBack)
{
return mbolIsSendBack;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.MarkDate)
{
return mstrMarkDate;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.OperateTime)
{
return mstrOperateTime;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.RealFinishDate)
{
return mstrRealFinishDate;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela)
{
mlngIdPaperStuBatchQuesRela = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IdPaperStuBatch)
{
mstrIdPaperStuBatch = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IdPaperStuBatch);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.QuestionId);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.QuestionIndex4Batch)
{
mintQuestionIndex4Batch = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.QuestionIndex4Batch);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Scores);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Score);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.StuAnswerText)
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.StuAnswerText);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerDate);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerIP);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerModeId);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerMultiOptions)
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerMultiOptions);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerOptionId);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerTime);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.ApplySendBackDate)
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.ApplySendBackDate);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Comment);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsAccessKnowledge)
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsAccessKnowledge);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsApplySendBack)
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsApplySendBack);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsInErrorQuestion)
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsInErrorQuestion);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsLook)
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsLook);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsMarking);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsNotProcessTimeout)
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsPublish)
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsPublish);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsRight);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsSave)
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSave);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsSendBack)
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSendBack);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSubmit);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.MarkDate)
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.MarkDate);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.MarkerId);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.OperateTime)
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.OperateTime);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.RealFinishDate)
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.RealFinishDate);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.WorkTypeId);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.SchoolYear);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.SchoolTerm);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.ErrMsg);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.CourseId);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.UpdDate);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.UpdUserId);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela  ==  AttributeName[intIndex])
{
return mlngIdPaperStuBatchQuesRela;
}
else if (concc_PaperStuBatchQuesRela.IdPaperStuBatch  ==  AttributeName[intIndex])
{
return mstrIdPaperStuBatch;
}
else if (concc_PaperStuBatchQuesRela.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (concc_PaperStuBatchQuesRela.QuestionIndex4Batch  ==  AttributeName[intIndex])
{
return mintQuestionIndex4Batch;
}
else if (concc_PaperStuBatchQuesRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (concc_PaperStuBatchQuesRela.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (concc_PaperStuBatchQuesRela.StuAnswerText  ==  AttributeName[intIndex])
{
return mstrStuAnswerText;
}
else if (concc_PaperStuBatchQuesRela.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (concc_PaperStuBatchQuesRela.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (concc_PaperStuBatchQuesRela.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (concc_PaperStuBatchQuesRela.AnswerMultiOptions  ==  AttributeName[intIndex])
{
return mstrAnswerMultiOptions;
}
else if (concc_PaperStuBatchQuesRela.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (concc_PaperStuBatchQuesRela.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (concc_PaperStuBatchQuesRela.ApplySendBackDate  ==  AttributeName[intIndex])
{
return mstrApplySendBackDate;
}
else if (concc_PaperStuBatchQuesRela.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (concc_PaperStuBatchQuesRela.IsAccessKnowledge  ==  AttributeName[intIndex])
{
return mbolIsAccessKnowledge;
}
else if (concc_PaperStuBatchQuesRela.IsApplySendBack  ==  AttributeName[intIndex])
{
return mbolIsApplySendBack;
}
else if (concc_PaperStuBatchQuesRela.IsInErrorQuestion  ==  AttributeName[intIndex])
{
return mbolIsInErrorQuestion;
}
else if (concc_PaperStuBatchQuesRela.IsLook  ==  AttributeName[intIndex])
{
return mbolIsLook;
}
else if (concc_PaperStuBatchQuesRela.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (concc_PaperStuBatchQuesRela.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
return mbolIsNotProcessTimeout;
}
else if (concc_PaperStuBatchQuesRela.IsPublish  ==  AttributeName[intIndex])
{
return mbolIsPublish;
}
else if (concc_PaperStuBatchQuesRela.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (concc_PaperStuBatchQuesRela.IsSave  ==  AttributeName[intIndex])
{
return mbolIsSave;
}
else if (concc_PaperStuBatchQuesRela.IsSendBack  ==  AttributeName[intIndex])
{
return mbolIsSendBack;
}
else if (concc_PaperStuBatchQuesRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (concc_PaperStuBatchQuesRela.MarkDate  ==  AttributeName[intIndex])
{
return mstrMarkDate;
}
else if (concc_PaperStuBatchQuesRela.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (concc_PaperStuBatchQuesRela.OperateTime  ==  AttributeName[intIndex])
{
return mstrOperateTime;
}
else if (concc_PaperStuBatchQuesRela.RealFinishDate  ==  AttributeName[intIndex])
{
return mstrRealFinishDate;
}
else if (concc_PaperStuBatchQuesRela.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (concc_PaperStuBatchQuesRela.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (concc_PaperStuBatchQuesRela.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (concc_PaperStuBatchQuesRela.ErrMsg  ==  AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (concc_PaperStuBatchQuesRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_PaperStuBatchQuesRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_PaperStuBatchQuesRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_PaperStuBatchQuesRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela  ==  AttributeName[intIndex])
{
mlngIdPaperStuBatchQuesRela = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela);
}
else if (concc_PaperStuBatchQuesRela.IdPaperStuBatch  ==  AttributeName[intIndex])
{
mstrIdPaperStuBatch = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IdPaperStuBatch);
}
else if (concc_PaperStuBatchQuesRela.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.QuestionId);
}
else if (concc_PaperStuBatchQuesRela.QuestionIndex4Batch  ==  AttributeName[intIndex])
{
mintQuestionIndex4Batch = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.QuestionIndex4Batch);
}
else if (concc_PaperStuBatchQuesRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Scores);
}
else if (concc_PaperStuBatchQuesRela.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Score);
}
else if (concc_PaperStuBatchQuesRela.StuAnswerText  ==  AttributeName[intIndex])
{
mstrStuAnswerText = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.StuAnswerText);
}
else if (concc_PaperStuBatchQuesRela.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerDate);
}
else if (concc_PaperStuBatchQuesRela.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerIP);
}
else if (concc_PaperStuBatchQuesRela.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerModeId);
}
else if (concc_PaperStuBatchQuesRela.AnswerMultiOptions  ==  AttributeName[intIndex])
{
mstrAnswerMultiOptions = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerMultiOptions);
}
else if (concc_PaperStuBatchQuesRela.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerOptionId);
}
else if (concc_PaperStuBatchQuesRela.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerTime);
}
else if (concc_PaperStuBatchQuesRela.ApplySendBackDate  ==  AttributeName[intIndex])
{
mstrApplySendBackDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.ApplySendBackDate);
}
else if (concc_PaperStuBatchQuesRela.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Comment);
}
else if (concc_PaperStuBatchQuesRela.IsAccessKnowledge  ==  AttributeName[intIndex])
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsAccessKnowledge);
}
else if (concc_PaperStuBatchQuesRela.IsApplySendBack  ==  AttributeName[intIndex])
{
mbolIsApplySendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsApplySendBack);
}
else if (concc_PaperStuBatchQuesRela.IsInErrorQuestion  ==  AttributeName[intIndex])
{
mbolIsInErrorQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsInErrorQuestion);
}
else if (concc_PaperStuBatchQuesRela.IsLook  ==  AttributeName[intIndex])
{
mbolIsLook = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsLook);
}
else if (concc_PaperStuBatchQuesRela.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsMarking);
}
else if (concc_PaperStuBatchQuesRela.IsNotProcessTimeout  ==  AttributeName[intIndex])
{
mbolIsNotProcessTimeout = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
}
else if (concc_PaperStuBatchQuesRela.IsPublish  ==  AttributeName[intIndex])
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsPublish);
}
else if (concc_PaperStuBatchQuesRela.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsRight);
}
else if (concc_PaperStuBatchQuesRela.IsSave  ==  AttributeName[intIndex])
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSave);
}
else if (concc_PaperStuBatchQuesRela.IsSendBack  ==  AttributeName[intIndex])
{
mbolIsSendBack = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSendBack);
}
else if (concc_PaperStuBatchQuesRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSubmit);
}
else if (concc_PaperStuBatchQuesRela.MarkDate  ==  AttributeName[intIndex])
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.MarkDate);
}
else if (concc_PaperStuBatchQuesRela.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.MarkerId);
}
else if (concc_PaperStuBatchQuesRela.OperateTime  ==  AttributeName[intIndex])
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.OperateTime);
}
else if (concc_PaperStuBatchQuesRela.RealFinishDate  ==  AttributeName[intIndex])
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.RealFinishDate);
}
else if (concc_PaperStuBatchQuesRela.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.WorkTypeId);
}
else if (concc_PaperStuBatchQuesRela.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.SchoolYear);
}
else if (concc_PaperStuBatchQuesRela.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.SchoolTerm);
}
else if (concc_PaperStuBatchQuesRela.ErrMsg  ==  AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.ErrMsg);
}
else if (concc_PaperStuBatchQuesRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.CourseId);
}
else if (concc_PaperStuBatchQuesRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.UpdDate);
}
else if (concc_PaperStuBatchQuesRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.UpdUserId);
}
else if (concc_PaperStuBatchQuesRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Memo);
}
}
}

/// <summary>
/// 学生批次题目关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPaperStuBatchQuesRela
{
get
{
return mlngIdPaperStuBatchQuesRela;
}
set
{
 mlngIdPaperStuBatchQuesRela = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela);
}
}
/// <summary>
/// 学生试卷批次流水号(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPaperStuBatch
{
get
{
return mstrIdPaperStuBatch;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPaperStuBatch = value;
}
else
{
 mstrIdPaperStuBatch = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IdPaperStuBatch);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.QuestionId);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.QuestionIndex4Batch);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Scores);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Score);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.StuAnswerText);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerDate);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerIP);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerModeId);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerMultiOptions);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerOptionId);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.AnswerTime);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.ApplySendBackDate);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Comment);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsAccessKnowledge);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsApplySendBack);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsInErrorQuestion);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsLook);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsMarking);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsPublish);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsRight);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSave);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSendBack);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.IsSubmit);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.MarkDate);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.MarkerId);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.OperateTime);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.RealFinishDate);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.WorkTypeId);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.SchoolYear);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.SchoolTerm);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.ErrMsg);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.CourseId);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.UpdDate);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.UpdUserId);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela.Memo);
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
  return mlngIdPaperStuBatchQuesRela.ToString();
 }
 }
}
 /// <summary>
 /// 学生批次题目关系(cc_PaperStuBatchQuesRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_PaperStuBatchQuesRela
{
public const string _CurrTabName = "cc_PaperStuBatchQuesRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPaperStuBatchQuesRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPaperStuBatchQuesRela", "IdPaperStuBatch", "QuestionId", "QuestionIndex4Batch", "Scores", "Score", "StuAnswerText", "AnswerDate", "AnswerIP", "AnswerModeId", "AnswerMultiOptions", "AnswerOptionId", "AnswerTime", "ApplySendBackDate", "Comment", "IsAccessKnowledge", "IsApplySendBack", "IsInErrorQuestion", "IsLook", "IsMarking", "IsNotProcessTimeout", "IsPublish", "IsRight", "IsSave", "IsSendBack", "IsSubmit", "MarkDate", "MarkerId", "OperateTime", "RealFinishDate", "WorkTypeId", "SchoolYear", "SchoolTerm", "ErrMsg", "CourseId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPaperStuBatchQuesRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPaperStuBatchQuesRela = "IdPaperStuBatchQuesRela";    //学生批次题目关系流水号

 /// <summary>
 /// 常量:"IdPaperStuBatch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPaperStuBatch = "IdPaperStuBatch";    //学生试卷批次流水号

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"QuestionIndex4Batch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex4Batch = "QuestionIndex4Batch";    //题序号4批次

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