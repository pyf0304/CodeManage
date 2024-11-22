
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserAnswerResultEN
 表名:UserAnswerResult(01120032)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果(QuestionnaireResult)
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
 /// 表UserAnswerResult的关键字(MinId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MinId_UserAnswerResult
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngMinId">表关键字</param>
public K_MinId_UserAnswerResult(long lngMinId)
{
if (IsValid(lngMinId)) Value = lngMinId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngMinId)
{
if (lngMinId == 0) return false;
if (lngMinId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MinId_UserAnswerResult]类型的对象</returns>
public static implicit operator K_MinId_UserAnswerResult(long value)
{
return new K_MinId_UserAnswerResult(value);
}
}
 /// <summary>
 /// 用户答题结果(UserAnswerResult)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserAnswerResultEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserAnswerResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MinId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"MinId", "QuestionId", "CourseId", "IdCurrEduCls", "ExamBatchNo", "CourseExamPaperId", "AnswerOptionId", "BatchId", "UserId", "AnswerText", "AnswerDate", "AnswerTime", "AnswerIP", "IsAccess", "IsAccessC", "IdSchool", "School", "AnswerMode", "IsMarking", "IsRight", "Score", "MarkTime", "MarkerId", "Comment", "IsAccessKnowledge", "AnswerId", "AnswerMultiOption", "UpdDate", "UpdUser", "Memo", "QuestionnaireSetId"};

protected long mlngMinId;    //MinId
protected long? mlngQuestionId;    //题目Id
protected string mstrCourseId;    //课程Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrExamBatchNo;    //学生批次号
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrAnswerOptionId;    //回答选项Id
protected string mstrBatchId;    //批次ID
protected string mstrUserId;    //用户ID
protected string mstrAnswerText;    //回答文本
protected string mstrAnswerDate;    //回答日期
protected string mstrAnswerTime;    //回答时间
protected string mstrAnswerIP;    //回答IP
protected bool mbolIsAccess;    //IsAccess
protected bool mbolIsAccessC;    //IsAccessC
protected string mstrIdSchool;    //学校流水号
protected string mstrSchool;    //School
protected int? mintAnswerMode;    //AnswerMode
protected bool mbolIsMarking;    //是否批阅
protected bool mbolIsRight;    //是否正确
protected double? mdblScore;    //得分
protected string mstrMarkTime;    //批改时间
protected string mstrMarkerId;    //打分者
protected string mstrComment;    //批注
protected bool mbolIsAccessKnowledge;    //是否处理知识点
protected long? mlngAnswerId;    //问答ID
protected string mstrAnswerMultiOption;    //多选项答案
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrQuestionnaireSetId;    //问卷集ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserAnswerResultEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MinId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngMinId">关键字:MinId</param>
public clsUserAnswerResultEN(long lngMinId)
 {
 if (lngMinId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngMinId = lngMinId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MinId");
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
if (strAttributeName  ==  conUserAnswerResult.MinId)
{
return mlngMinId;
}
else if (strAttributeName  ==  conUserAnswerResult.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conUserAnswerResult.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conUserAnswerResult.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conUserAnswerResult.ExamBatchNo)
{
return mstrExamBatchNo;
}
else if (strAttributeName  ==  conUserAnswerResult.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  conUserAnswerResult.BatchId)
{
return mstrBatchId;
}
else if (strAttributeName  ==  conUserAnswerResult.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerText)
{
return mstrAnswerText;
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  conUserAnswerResult.IsAccess)
{
return mbolIsAccess;
}
else if (strAttributeName  ==  conUserAnswerResult.IsAccessC)
{
return mbolIsAccessC;
}
else if (strAttributeName  ==  conUserAnswerResult.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conUserAnswerResult.School)
{
return mstrSchool;
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerMode)
{
return mintAnswerMode;
}
else if (strAttributeName  ==  conUserAnswerResult.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  conUserAnswerResult.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  conUserAnswerResult.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  conUserAnswerResult.MarkTime)
{
return mstrMarkTime;
}
else if (strAttributeName  ==  conUserAnswerResult.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  conUserAnswerResult.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  conUserAnswerResult.IsAccessKnowledge)
{
return mbolIsAccessKnowledge;
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerId)
{
return mlngAnswerId;
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerMultiOption)
{
return mstrAnswerMultiOption;
}
else if (strAttributeName  ==  conUserAnswerResult.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserAnswerResult.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conUserAnswerResult.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conUserAnswerResult.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
return null;
}
set
{
if (strAttributeName  ==  conUserAnswerResult.MinId)
{
mlngMinId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserAnswerResult.MinId);
}
else if (strAttributeName  ==  conUserAnswerResult.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserAnswerResult.QuestionId);
}
else if (strAttributeName  ==  conUserAnswerResult.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.CourseId);
}
else if (strAttributeName  ==  conUserAnswerResult.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conUserAnswerResult.IdCurrEduCls);
}
else if (strAttributeName  ==  conUserAnswerResult.ExamBatchNo)
{
mstrExamBatchNo = value.ToString();
 AddUpdatedFld(conUserAnswerResult.ExamBatchNo);
}
else if (strAttributeName  ==  conUserAnswerResult.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.CourseExamPaperId);
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerOptionId);
}
else if (strAttributeName  ==  conUserAnswerResult.BatchId)
{
mstrBatchId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.BatchId);
}
else if (strAttributeName  ==  conUserAnswerResult.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.UserId);
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerText)
{
mstrAnswerText = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerText);
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerDate);
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerTime);
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerIP);
}
else if (strAttributeName  ==  conUserAnswerResult.IsAccess)
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsAccess);
}
else if (strAttributeName  ==  conUserAnswerResult.IsAccessC)
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsAccessC);
}
else if (strAttributeName  ==  conUserAnswerResult.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conUserAnswerResult.IdSchool);
}
else if (strAttributeName  ==  conUserAnswerResult.School)
{
mstrSchool = value.ToString();
 AddUpdatedFld(conUserAnswerResult.School);
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerMode)
{
mintAnswerMode = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserAnswerResult.AnswerMode);
}
else if (strAttributeName  ==  conUserAnswerResult.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsMarking);
}
else if (strAttributeName  ==  conUserAnswerResult.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsRight);
}
else if (strAttributeName  ==  conUserAnswerResult.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserAnswerResult.Score);
}
else if (strAttributeName  ==  conUserAnswerResult.MarkTime)
{
mstrMarkTime = value.ToString();
 AddUpdatedFld(conUserAnswerResult.MarkTime);
}
else if (strAttributeName  ==  conUserAnswerResult.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.MarkerId);
}
else if (strAttributeName  ==  conUserAnswerResult.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(conUserAnswerResult.Comment);
}
else if (strAttributeName  ==  conUserAnswerResult.IsAccessKnowledge)
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsAccessKnowledge);
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerId)
{
mlngAnswerId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserAnswerResult.AnswerId);
}
else if (strAttributeName  ==  conUserAnswerResult.AnswerMultiOption)
{
mstrAnswerMultiOption = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerMultiOption);
}
else if (strAttributeName  ==  conUserAnswerResult.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserAnswerResult.UpdDate);
}
else if (strAttributeName  ==  conUserAnswerResult.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUserAnswerResult.UpdUser);
}
else if (strAttributeName  ==  conUserAnswerResult.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserAnswerResult.Memo);
}
else if (strAttributeName  ==  conUserAnswerResult.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.QuestionnaireSetId);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserAnswerResult.MinId  ==  AttributeName[intIndex])
{
return mlngMinId;
}
else if (conUserAnswerResult.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conUserAnswerResult.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conUserAnswerResult.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conUserAnswerResult.ExamBatchNo  ==  AttributeName[intIndex])
{
return mstrExamBatchNo;
}
else if (conUserAnswerResult.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (conUserAnswerResult.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (conUserAnswerResult.BatchId  ==  AttributeName[intIndex])
{
return mstrBatchId;
}
else if (conUserAnswerResult.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserAnswerResult.AnswerText  ==  AttributeName[intIndex])
{
return mstrAnswerText;
}
else if (conUserAnswerResult.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (conUserAnswerResult.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (conUserAnswerResult.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (conUserAnswerResult.IsAccess  ==  AttributeName[intIndex])
{
return mbolIsAccess;
}
else if (conUserAnswerResult.IsAccessC  ==  AttributeName[intIndex])
{
return mbolIsAccessC;
}
else if (conUserAnswerResult.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conUserAnswerResult.School  ==  AttributeName[intIndex])
{
return mstrSchool;
}
else if (conUserAnswerResult.AnswerMode  ==  AttributeName[intIndex])
{
return mintAnswerMode;
}
else if (conUserAnswerResult.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (conUserAnswerResult.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (conUserAnswerResult.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (conUserAnswerResult.MarkTime  ==  AttributeName[intIndex])
{
return mstrMarkTime;
}
else if (conUserAnswerResult.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (conUserAnswerResult.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (conUserAnswerResult.IsAccessKnowledge  ==  AttributeName[intIndex])
{
return mbolIsAccessKnowledge;
}
else if (conUserAnswerResult.AnswerId  ==  AttributeName[intIndex])
{
return mlngAnswerId;
}
else if (conUserAnswerResult.AnswerMultiOption  ==  AttributeName[intIndex])
{
return mstrAnswerMultiOption;
}
else if (conUserAnswerResult.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserAnswerResult.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conUserAnswerResult.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conUserAnswerResult.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
return null;
}
set
{
if (conUserAnswerResult.MinId  ==  AttributeName[intIndex])
{
mlngMinId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserAnswerResult.MinId);
}
else if (conUserAnswerResult.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserAnswerResult.QuestionId);
}
else if (conUserAnswerResult.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.CourseId);
}
else if (conUserAnswerResult.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conUserAnswerResult.IdCurrEduCls);
}
else if (conUserAnswerResult.ExamBatchNo  ==  AttributeName[intIndex])
{
mstrExamBatchNo = value.ToString();
 AddUpdatedFld(conUserAnswerResult.ExamBatchNo);
}
else if (conUserAnswerResult.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.CourseExamPaperId);
}
else if (conUserAnswerResult.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerOptionId);
}
else if (conUserAnswerResult.BatchId  ==  AttributeName[intIndex])
{
mstrBatchId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.BatchId);
}
else if (conUserAnswerResult.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.UserId);
}
else if (conUserAnswerResult.AnswerText  ==  AttributeName[intIndex])
{
mstrAnswerText = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerText);
}
else if (conUserAnswerResult.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerDate);
}
else if (conUserAnswerResult.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerTime);
}
else if (conUserAnswerResult.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerIP);
}
else if (conUserAnswerResult.IsAccess  ==  AttributeName[intIndex])
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsAccess);
}
else if (conUserAnswerResult.IsAccessC  ==  AttributeName[intIndex])
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsAccessC);
}
else if (conUserAnswerResult.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conUserAnswerResult.IdSchool);
}
else if (conUserAnswerResult.School  ==  AttributeName[intIndex])
{
mstrSchool = value.ToString();
 AddUpdatedFld(conUserAnswerResult.School);
}
else if (conUserAnswerResult.AnswerMode  ==  AttributeName[intIndex])
{
mintAnswerMode = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserAnswerResult.AnswerMode);
}
else if (conUserAnswerResult.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsMarking);
}
else if (conUserAnswerResult.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsRight);
}
else if (conUserAnswerResult.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserAnswerResult.Score);
}
else if (conUserAnswerResult.MarkTime  ==  AttributeName[intIndex])
{
mstrMarkTime = value.ToString();
 AddUpdatedFld(conUserAnswerResult.MarkTime);
}
else if (conUserAnswerResult.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.MarkerId);
}
else if (conUserAnswerResult.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(conUserAnswerResult.Comment);
}
else if (conUserAnswerResult.IsAccessKnowledge  ==  AttributeName[intIndex])
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserAnswerResult.IsAccessKnowledge);
}
else if (conUserAnswerResult.AnswerId  ==  AttributeName[intIndex])
{
mlngAnswerId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserAnswerResult.AnswerId);
}
else if (conUserAnswerResult.AnswerMultiOption  ==  AttributeName[intIndex])
{
mstrAnswerMultiOption = value.ToString();
 AddUpdatedFld(conUserAnswerResult.AnswerMultiOption);
}
else if (conUserAnswerResult.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserAnswerResult.UpdDate);
}
else if (conUserAnswerResult.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUserAnswerResult.UpdUser);
}
else if (conUserAnswerResult.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserAnswerResult.Memo);
}
else if (conUserAnswerResult.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conUserAnswerResult.QuestionnaireSetId);
}
}
}

/// <summary>
/// MinId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long MinId
{
get
{
return mlngMinId;
}
set
{
 mlngMinId = value;
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.MinId);
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
 AddUpdatedFld(conUserAnswerResult.QuestionId);
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
 AddUpdatedFld(conUserAnswerResult.CourseId);
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
 AddUpdatedFld(conUserAnswerResult.IdCurrEduCls);
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
 AddUpdatedFld(conUserAnswerResult.ExamBatchNo);
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
 AddUpdatedFld(conUserAnswerResult.CourseExamPaperId);
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
 AddUpdatedFld(conUserAnswerResult.AnswerOptionId);
}
}
/// <summary>
/// 批次ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BatchId
{
get
{
return mstrBatchId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBatchId = value;
}
else
{
 mstrBatchId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.BatchId);
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
 AddUpdatedFld(conUserAnswerResult.UserId);
}
}
/// <summary>
/// 回答文本(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerText
{
get
{
return mstrAnswerText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerText = value;
}
else
{
 mstrAnswerText = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.AnswerText);
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
 AddUpdatedFld(conUserAnswerResult.AnswerDate);
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
 AddUpdatedFld(conUserAnswerResult.AnswerTime);
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
 AddUpdatedFld(conUserAnswerResult.AnswerIP);
}
}
/// <summary>
/// IsAccess(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAccess
{
get
{
return mbolIsAccess;
}
set
{
 mbolIsAccess = value;
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.IsAccess);
}
}
/// <summary>
/// IsAccessC(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAccessC
{
get
{
return mbolIsAccessC;
}
set
{
 mbolIsAccessC = value;
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.IsAccessC);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.IdSchool);
}
}
/// <summary>
/// School(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string School
{
get
{
return mstrSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchool = value;
}
else
{
 mstrSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.School);
}
}
/// <summary>
/// AnswerMode(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerMode
{
get
{
return mintAnswerMode;
}
set
{
 mintAnswerMode = value;
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.AnswerMode);
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
 AddUpdatedFld(conUserAnswerResult.IsMarking);
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
 AddUpdatedFld(conUserAnswerResult.IsRight);
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
 AddUpdatedFld(conUserAnswerResult.Score);
}
}
/// <summary>
/// 批改时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkTime
{
get
{
return mstrMarkTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkTime = value;
}
else
{
 mstrMarkTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.MarkTime);
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
 AddUpdatedFld(conUserAnswerResult.MarkerId);
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
 AddUpdatedFld(conUserAnswerResult.Comment);
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
 AddUpdatedFld(conUserAnswerResult.IsAccessKnowledge);
}
}
/// <summary>
/// 问答ID(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? AnswerId
{
get
{
return mlngAnswerId;
}
set
{
 mlngAnswerId = value;
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.AnswerId);
}
}
/// <summary>
/// 多选项答案(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerMultiOption
{
get
{
return mstrAnswerMultiOption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerMultiOption = value;
}
else
{
 mstrAnswerMultiOption = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserAnswerResult.AnswerMultiOption);
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
 AddUpdatedFld(conUserAnswerResult.UpdDate);
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
 AddUpdatedFld(conUserAnswerResult.UpdUser);
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
 AddUpdatedFld(conUserAnswerResult.Memo);
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
 AddUpdatedFld(conUserAnswerResult.QuestionnaireSetId);
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
  return mlngMinId.ToString();
 }
 }
}
 /// <summary>
 /// 用户答题结果(UserAnswerResult)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserAnswerResult
{
public const string _CurrTabName = "UserAnswerResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MinId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MinId", "QuestionId", "CourseId", "IdCurrEduCls", "ExamBatchNo", "CourseExamPaperId", "AnswerOptionId", "BatchId", "UserId", "AnswerText", "AnswerDate", "AnswerTime", "AnswerIP", "IsAccess", "IsAccessC", "IdSchool", "School", "AnswerMode", "IsMarking", "IsRight", "Score", "MarkTime", "MarkerId", "Comment", "IsAccessKnowledge", "AnswerId", "AnswerMultiOption", "UpdDate", "UpdUser", "Memo", "QuestionnaireSetId"};
//以下是属性变量


 /// <summary>
 /// 常量:"MinId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MinId = "MinId";    //MinId

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"ExamBatchNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamBatchNo = "ExamBatchNo";    //学生批次号

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"AnswerOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerOptionId = "AnswerOptionId";    //回答选项Id

 /// <summary>
 /// 常量:"BatchId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BatchId = "BatchId";    //批次ID

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"AnswerText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerText = "AnswerText";    //回答文本

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
 /// 常量:"AnswerIP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIP = "AnswerIP";    //回答IP

 /// <summary>
 /// 常量:"IsAccess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAccess = "IsAccess";    //IsAccess

 /// <summary>
 /// 常量:"IsAccessC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAccessC = "IsAccessC";    //IsAccessC

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"School"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string School = "School";    //School

 /// <summary>
 /// 常量:"AnswerMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerMode = "AnswerMode";    //AnswerMode

 /// <summary>
 /// 常量:"IsMarking"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMarking = "IsMarking";    //是否批阅

 /// <summary>
 /// 常量:"IsRight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRight = "IsRight";    //是否正确

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"MarkTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkTime = "MarkTime";    //批改时间

 /// <summary>
 /// 常量:"MarkerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkerId = "MarkerId";    //打分者

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
 /// 常量:"AnswerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerId = "AnswerId";    //问答ID

 /// <summary>
 /// 常量:"AnswerMultiOption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerMultiOption = "AnswerMultiOption";    //多选项答案

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
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID
}

}