
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserAnswerResultEN
 表名:vUserAnswerResult(01120022)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:25
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
 /// 表vUserAnswerResult的关键字(MinId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MinId_vUserAnswerResult
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
public K_MinId_vUserAnswerResult(long lngMinId)
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
 /// <returns>返回:[K_MinId_vUserAnswerResult]类型的对象</returns>
public static implicit operator K_MinId_vUserAnswerResult(long value)
{
return new K_MinId_vUserAnswerResult(value);
}
}
 /// <summary>
 /// v用户答题结果(vUserAnswerResult)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserAnswerResultEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserAnswerResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MinId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 42;
public static string[] AttributeName = new string[] {"MinId", "QuestionId", "QuestionIndex", "QuestionName", "QuestionNo", "QuestionTypeId", "QuestionTypeName", "AnswerTypeId", "AnswerTypeName", "GridTitle", "AnswerModeId", "QuestionScore", "QuestionnaireSetId", "CourseId", "CourseName", "CourseExamPaperId", "AnswerOptionId", "OptionName", "OptionIndex", "OptionTitle", "BatchId", "UserId", "UserName", "AnswerText", "AnswerDate", "AnswerTime", "AnswerIP", "IsAccess", "IsAccessC", "IdSchool", "School", "AnswerMode", "IsMarking", "IsRight", "Score", "MarkTime", "MarkerId", "Comment", "IsAccessKnowledge", "UpdDate", "UpdUser", "Memo"};

protected long mlngMinId;    //MinId
protected long? mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionNo;    //题目编号
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrGridTitle;    //表格标题
protected string mstrAnswerModeId;    //答案模式Id
protected float? mfltQuestionScore;    //题目得分
protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrAnswerOptionId;    //回答选项Id
protected string mstrOptionName;    //选项名称
protected int? mintOptionIndex;    //选项序号
protected string mstrOptionTitle;    //选项标题
protected string mstrBatchId;    //批次ID
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
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
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvUserAnswerResultEN()
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
public clsvUserAnswerResultEN(long lngMinId)
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
if (strAttributeName  ==  convUserAnswerResult.MinId)
{
return mlngMinId;
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convUserAnswerResult.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  convUserAnswerResult.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convUserAnswerResult.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convUserAnswerResult.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerOptionId)
{
return mstrAnswerOptionId;
}
else if (strAttributeName  ==  convUserAnswerResult.OptionName)
{
return mstrOptionName;
}
else if (strAttributeName  ==  convUserAnswerResult.OptionIndex)
{
return mintOptionIndex;
}
else if (strAttributeName  ==  convUserAnswerResult.OptionTitle)
{
return mstrOptionTitle;
}
else if (strAttributeName  ==  convUserAnswerResult.BatchId)
{
return mstrBatchId;
}
else if (strAttributeName  ==  convUserAnswerResult.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUserAnswerResult.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerText)
{
return mstrAnswerText;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  convUserAnswerResult.IsAccess)
{
return mbolIsAccess;
}
else if (strAttributeName  ==  convUserAnswerResult.IsAccessC)
{
return mbolIsAccessC;
}
else if (strAttributeName  ==  convUserAnswerResult.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convUserAnswerResult.School)
{
return mstrSchool;
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerMode)
{
return mintAnswerMode;
}
else if (strAttributeName  ==  convUserAnswerResult.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  convUserAnswerResult.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  convUserAnswerResult.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  convUserAnswerResult.MarkTime)
{
return mstrMarkTime;
}
else if (strAttributeName  ==  convUserAnswerResult.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  convUserAnswerResult.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  convUserAnswerResult.IsAccessKnowledge)
{
return mbolIsAccessKnowledge;
}
else if (strAttributeName  ==  convUserAnswerResult.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUserAnswerResult.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convUserAnswerResult.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convUserAnswerResult.MinId)
{
mlngMinId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.MinId);
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.QuestionId);
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.QuestionIndex);
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionName);
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionNo);
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionTypeId);
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionTypeName);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerTypeId);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerTypeName);
}
else if (strAttributeName  ==  convUserAnswerResult.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convUserAnswerResult.GridTitle);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerModeId);
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convUserAnswerResult.QuestionScore);
}
else if (strAttributeName  ==  convUserAnswerResult.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionnaireSetId);
}
else if (strAttributeName  ==  convUserAnswerResult.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.CourseId);
}
else if (strAttributeName  ==  convUserAnswerResult.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.CourseName);
}
else if (strAttributeName  ==  convUserAnswerResult.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.CourseExamPaperId);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerOptionId)
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerOptionId);
}
else if (strAttributeName  ==  convUserAnswerResult.OptionName)
{
mstrOptionName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.OptionName);
}
else if (strAttributeName  ==  convUserAnswerResult.OptionIndex)
{
mintOptionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.OptionIndex);
}
else if (strAttributeName  ==  convUserAnswerResult.OptionTitle)
{
mstrOptionTitle = value.ToString();
 AddUpdatedFld(convUserAnswerResult.OptionTitle);
}
else if (strAttributeName  ==  convUserAnswerResult.BatchId)
{
mstrBatchId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.BatchId);
}
else if (strAttributeName  ==  convUserAnswerResult.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.UserId);
}
else if (strAttributeName  ==  convUserAnswerResult.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.UserName);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerText)
{
mstrAnswerText = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerText);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerDate);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerTime);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerIP);
}
else if (strAttributeName  ==  convUserAnswerResult.IsAccess)
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsAccess);
}
else if (strAttributeName  ==  convUserAnswerResult.IsAccessC)
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsAccessC);
}
else if (strAttributeName  ==  convUserAnswerResult.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convUserAnswerResult.IdSchool);
}
else if (strAttributeName  ==  convUserAnswerResult.School)
{
mstrSchool = value.ToString();
 AddUpdatedFld(convUserAnswerResult.School);
}
else if (strAttributeName  ==  convUserAnswerResult.AnswerMode)
{
mintAnswerMode = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.AnswerMode);
}
else if (strAttributeName  ==  convUserAnswerResult.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsMarking);
}
else if (strAttributeName  ==  convUserAnswerResult.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsRight);
}
else if (strAttributeName  ==  convUserAnswerResult.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convUserAnswerResult.Score);
}
else if (strAttributeName  ==  convUserAnswerResult.MarkTime)
{
mstrMarkTime = value.ToString();
 AddUpdatedFld(convUserAnswerResult.MarkTime);
}
else if (strAttributeName  ==  convUserAnswerResult.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.MarkerId);
}
else if (strAttributeName  ==  convUserAnswerResult.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(convUserAnswerResult.Comment);
}
else if (strAttributeName  ==  convUserAnswerResult.IsAccessKnowledge)
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsAccessKnowledge);
}
else if (strAttributeName  ==  convUserAnswerResult.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserAnswerResult.UpdDate);
}
else if (strAttributeName  ==  convUserAnswerResult.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convUserAnswerResult.UpdUser);
}
else if (strAttributeName  ==  convUserAnswerResult.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserAnswerResult.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserAnswerResult.MinId  ==  AttributeName[intIndex])
{
return mlngMinId;
}
else if (convUserAnswerResult.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convUserAnswerResult.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convUserAnswerResult.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convUserAnswerResult.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convUserAnswerResult.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convUserAnswerResult.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convUserAnswerResult.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convUserAnswerResult.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convUserAnswerResult.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convUserAnswerResult.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convUserAnswerResult.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (convUserAnswerResult.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (convUserAnswerResult.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convUserAnswerResult.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convUserAnswerResult.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convUserAnswerResult.AnswerOptionId  ==  AttributeName[intIndex])
{
return mstrAnswerOptionId;
}
else if (convUserAnswerResult.OptionName  ==  AttributeName[intIndex])
{
return mstrOptionName;
}
else if (convUserAnswerResult.OptionIndex  ==  AttributeName[intIndex])
{
return mintOptionIndex;
}
else if (convUserAnswerResult.OptionTitle  ==  AttributeName[intIndex])
{
return mstrOptionTitle;
}
else if (convUserAnswerResult.BatchId  ==  AttributeName[intIndex])
{
return mstrBatchId;
}
else if (convUserAnswerResult.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUserAnswerResult.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUserAnswerResult.AnswerText  ==  AttributeName[intIndex])
{
return mstrAnswerText;
}
else if (convUserAnswerResult.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (convUserAnswerResult.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (convUserAnswerResult.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (convUserAnswerResult.IsAccess  ==  AttributeName[intIndex])
{
return mbolIsAccess;
}
else if (convUserAnswerResult.IsAccessC  ==  AttributeName[intIndex])
{
return mbolIsAccessC;
}
else if (convUserAnswerResult.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convUserAnswerResult.School  ==  AttributeName[intIndex])
{
return mstrSchool;
}
else if (convUserAnswerResult.AnswerMode  ==  AttributeName[intIndex])
{
return mintAnswerMode;
}
else if (convUserAnswerResult.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (convUserAnswerResult.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (convUserAnswerResult.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (convUserAnswerResult.MarkTime  ==  AttributeName[intIndex])
{
return mstrMarkTime;
}
else if (convUserAnswerResult.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (convUserAnswerResult.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (convUserAnswerResult.IsAccessKnowledge  ==  AttributeName[intIndex])
{
return mbolIsAccessKnowledge;
}
else if (convUserAnswerResult.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUserAnswerResult.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convUserAnswerResult.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convUserAnswerResult.MinId  ==  AttributeName[intIndex])
{
mlngMinId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.MinId);
}
else if (convUserAnswerResult.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.QuestionId);
}
else if (convUserAnswerResult.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.QuestionIndex);
}
else if (convUserAnswerResult.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionName);
}
else if (convUserAnswerResult.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionNo);
}
else if (convUserAnswerResult.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionTypeId);
}
else if (convUserAnswerResult.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionTypeName);
}
else if (convUserAnswerResult.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerTypeId);
}
else if (convUserAnswerResult.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerTypeName);
}
else if (convUserAnswerResult.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convUserAnswerResult.GridTitle);
}
else if (convUserAnswerResult.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerModeId);
}
else if (convUserAnswerResult.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convUserAnswerResult.QuestionScore);
}
else if (convUserAnswerResult.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.QuestionnaireSetId);
}
else if (convUserAnswerResult.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.CourseId);
}
else if (convUserAnswerResult.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.CourseName);
}
else if (convUserAnswerResult.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.CourseExamPaperId);
}
else if (convUserAnswerResult.AnswerOptionId  ==  AttributeName[intIndex])
{
mstrAnswerOptionId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerOptionId);
}
else if (convUserAnswerResult.OptionName  ==  AttributeName[intIndex])
{
mstrOptionName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.OptionName);
}
else if (convUserAnswerResult.OptionIndex  ==  AttributeName[intIndex])
{
mintOptionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.OptionIndex);
}
else if (convUserAnswerResult.OptionTitle  ==  AttributeName[intIndex])
{
mstrOptionTitle = value.ToString();
 AddUpdatedFld(convUserAnswerResult.OptionTitle);
}
else if (convUserAnswerResult.BatchId  ==  AttributeName[intIndex])
{
mstrBatchId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.BatchId);
}
else if (convUserAnswerResult.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.UserId);
}
else if (convUserAnswerResult.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserAnswerResult.UserName);
}
else if (convUserAnswerResult.AnswerText  ==  AttributeName[intIndex])
{
mstrAnswerText = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerText);
}
else if (convUserAnswerResult.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerDate);
}
else if (convUserAnswerResult.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerTime);
}
else if (convUserAnswerResult.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(convUserAnswerResult.AnswerIP);
}
else if (convUserAnswerResult.IsAccess  ==  AttributeName[intIndex])
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsAccess);
}
else if (convUserAnswerResult.IsAccessC  ==  AttributeName[intIndex])
{
mbolIsAccessC = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsAccessC);
}
else if (convUserAnswerResult.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convUserAnswerResult.IdSchool);
}
else if (convUserAnswerResult.School  ==  AttributeName[intIndex])
{
mstrSchool = value.ToString();
 AddUpdatedFld(convUserAnswerResult.School);
}
else if (convUserAnswerResult.AnswerMode  ==  AttributeName[intIndex])
{
mintAnswerMode = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult.AnswerMode);
}
else if (convUserAnswerResult.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsMarking);
}
else if (convUserAnswerResult.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsRight);
}
else if (convUserAnswerResult.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convUserAnswerResult.Score);
}
else if (convUserAnswerResult.MarkTime  ==  AttributeName[intIndex])
{
mstrMarkTime = value.ToString();
 AddUpdatedFld(convUserAnswerResult.MarkTime);
}
else if (convUserAnswerResult.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convUserAnswerResult.MarkerId);
}
else if (convUserAnswerResult.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(convUserAnswerResult.Comment);
}
else if (convUserAnswerResult.IsAccessKnowledge  ==  AttributeName[intIndex])
{
mbolIsAccessKnowledge = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserAnswerResult.IsAccessKnowledge);
}
else if (convUserAnswerResult.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserAnswerResult.UpdDate);
}
else if (convUserAnswerResult.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convUserAnswerResult.UpdUser);
}
else if (convUserAnswerResult.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserAnswerResult.Memo);
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
 AddUpdatedFld(convUserAnswerResult.MinId);
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
 AddUpdatedFld(convUserAnswerResult.QuestionId);
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
 AddUpdatedFld(convUserAnswerResult.QuestionIndex);
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
 AddUpdatedFld(convUserAnswerResult.QuestionName);
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
 AddUpdatedFld(convUserAnswerResult.QuestionNo);
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
 AddUpdatedFld(convUserAnswerResult.QuestionTypeId);
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
 AddUpdatedFld(convUserAnswerResult.QuestionTypeName);
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
 AddUpdatedFld(convUserAnswerResult.AnswerTypeId);
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
 AddUpdatedFld(convUserAnswerResult.AnswerTypeName);
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
 AddUpdatedFld(convUserAnswerResult.GridTitle);
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
 AddUpdatedFld(convUserAnswerResult.AnswerModeId);
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
 AddUpdatedFld(convUserAnswerResult.QuestionScore);
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
 AddUpdatedFld(convUserAnswerResult.QuestionnaireSetId);
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
 AddUpdatedFld(convUserAnswerResult.CourseId);
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
 AddUpdatedFld(convUserAnswerResult.CourseName);
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
 AddUpdatedFld(convUserAnswerResult.CourseExamPaperId);
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
 AddUpdatedFld(convUserAnswerResult.AnswerOptionId);
}
}
/// <summary>
/// 选项名称(说明:;字段类型:varchar;字段长度:4000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptionName
{
get
{
return mstrOptionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptionName = value;
}
else
{
 mstrOptionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserAnswerResult.OptionName);
}
}
/// <summary>
/// 选项序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OptionIndex
{
get
{
return mintOptionIndex;
}
set
{
 mintOptionIndex = value;
//记录修改过的字段
 AddUpdatedFld(convUserAnswerResult.OptionIndex);
}
}
/// <summary>
/// 选项标题(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptionTitle
{
get
{
return mstrOptionTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptionTitle = value;
}
else
{
 mstrOptionTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserAnswerResult.OptionTitle);
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
 AddUpdatedFld(convUserAnswerResult.BatchId);
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
 AddUpdatedFld(convUserAnswerResult.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserAnswerResult.UserName);
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
 AddUpdatedFld(convUserAnswerResult.AnswerText);
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
 AddUpdatedFld(convUserAnswerResult.AnswerDate);
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
 AddUpdatedFld(convUserAnswerResult.AnswerTime);
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
 AddUpdatedFld(convUserAnswerResult.AnswerIP);
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
 AddUpdatedFld(convUserAnswerResult.IsAccess);
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
 AddUpdatedFld(convUserAnswerResult.IsAccessC);
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
 AddUpdatedFld(convUserAnswerResult.IdSchool);
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
 AddUpdatedFld(convUserAnswerResult.School);
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
 AddUpdatedFld(convUserAnswerResult.AnswerMode);
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
 AddUpdatedFld(convUserAnswerResult.IsMarking);
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
 AddUpdatedFld(convUserAnswerResult.IsRight);
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
 AddUpdatedFld(convUserAnswerResult.Score);
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
 AddUpdatedFld(convUserAnswerResult.MarkTime);
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
 AddUpdatedFld(convUserAnswerResult.MarkerId);
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
 AddUpdatedFld(convUserAnswerResult.Comment);
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
 AddUpdatedFld(convUserAnswerResult.IsAccessKnowledge);
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
 AddUpdatedFld(convUserAnswerResult.UpdDate);
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
 AddUpdatedFld(convUserAnswerResult.UpdUser);
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
 AddUpdatedFld(convUserAnswerResult.Memo);
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
 /// v用户答题结果(vUserAnswerResult)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserAnswerResult
{
public const string _CurrTabName = "vUserAnswerResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MinId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MinId", "QuestionId", "QuestionIndex", "QuestionName", "QuestionNo", "QuestionTypeId", "QuestionTypeName", "AnswerTypeId", "AnswerTypeName", "GridTitle", "AnswerModeId", "QuestionScore", "QuestionnaireSetId", "CourseId", "CourseName", "CourseExamPaperId", "AnswerOptionId", "OptionName", "OptionIndex", "OptionTitle", "BatchId", "UserId", "UserName", "AnswerText", "AnswerDate", "AnswerTime", "AnswerIP", "IsAccess", "IsAccessC", "IdSchool", "School", "AnswerMode", "IsMarking", "IsRight", "Score", "MarkTime", "MarkerId", "Comment", "IsAccessKnowledge", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"QuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNo = "QuestionNo";    //题目编号

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
 /// 常量:"QuestionScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionScore = "QuestionScore";    //题目得分

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

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
 /// 常量:"OptionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionName = "OptionName";    //选项名称

 /// <summary>
 /// 常量:"OptionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionIndex = "OptionIndex";    //选项序号

 /// <summary>
 /// 常量:"OptionTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionTitle = "OptionTitle";    //选项标题

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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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
}

}