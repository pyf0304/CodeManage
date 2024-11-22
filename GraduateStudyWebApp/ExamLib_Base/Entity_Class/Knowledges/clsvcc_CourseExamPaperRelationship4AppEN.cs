
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationship4AppEN
 表名:vcc_CourseExamPaperRelationship4App(01120256)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表vcc_CourseExamPaperRelationship4App的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vcc_CourseExamPaperRelationship4App
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vcc_CourseExamPaperRelationship4App(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vcc_CourseExamPaperRelationship4App]类型的对象</returns>
public static implicit operator K_mId_vcc_CourseExamPaperRelationship4App(long value)
{
return new K_mId_vcc_CourseExamPaperRelationship4App(value);
}
}
 /// <summary>
 /// v题目与试卷关系4App(vcc_CourseExamPaperRelationship4App)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseExamPaperRelationship4AppEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CourseExamPaperRelationship4App"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"mId", "CourseExamPaperId", "ExamPaperName", "CourseId", "CourseName", "QuestionId", "QuestionIndex", "QuestionName", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "QuestionScore", "IsEffective", "UserId", "StartTime", "PapersBigTopicId", "PapersBigTopicName", "TopicDescription", "TopicScores", "TopicOrderNum", "OrderNum", "UpdDate", "UpdUser"};

protected long mlngmId;    //mId
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrExamPaperName;    //考卷名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected long mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrExamGradeId;    //题库等级ID
protected string mstrExamGradeName;    //题库等级名
protected float? mfltQuestionScore;    //题目得分
protected bool mbolIsEffective;    //是否有效
protected string mstrUserId;    //用户ID
protected double? mdblStartTime;    //开始时间(s)
protected string mstrPapersBigTopicId;    //试卷大题目Id
protected string mstrPapersBigTopicName;    //试卷大题目名称
protected string mstrTopicDescription;    //标题描述
protected int? mintTopicScores;    //大题得分
protected int? mintTopicOrderNum;    //TopicOrderNum
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseExamPaperRelationship4AppEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvcc_CourseExamPaperRelationship4AppEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.ExamPaperName)
{
return mstrExamPaperName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.ExamGradeName)
{
return mstrExamGradeName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.StartTime)
{
return mdblStartTime;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.PapersBigTopicId)
{
return mstrPapersBigTopicId;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.PapersBigTopicName)
{
return mstrPapersBigTopicName;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.TopicDescription)
{
return mstrTopicDescription;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.TopicScores)
{
return mintTopicScores;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.TopicOrderNum)
{
return mintTopicOrderNum;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.mId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.ExamPaperName)
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamPaperName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionIndex);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionTypeId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionTypeName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamGradeId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.ExamGradeName)
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamGradeName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionScore);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.IsEffective);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UserId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.StartTime)
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.StartTime);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.PapersBigTopicId)
{
mstrPapersBigTopicId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.PapersBigTopicName)
{
mstrPapersBigTopicName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.PapersBigTopicName);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.TopicDescription)
{
mstrTopicDescription = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicDescription);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.TopicScores)
{
mintTopicScores = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicScores);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.TopicOrderNum)
{
mintTopicOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicOrderNum);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.OrderNum);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UpdDate);
}
else if (strAttributeName  ==  convcc_CourseExamPaperRelationship4App.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CourseExamPaperRelationship4App.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convcc_CourseExamPaperRelationship4App.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convcc_CourseExamPaperRelationship4App.ExamPaperName  ==  AttributeName[intIndex])
{
return mstrExamPaperName;
}
else if (convcc_CourseExamPaperRelationship4App.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CourseExamPaperRelationship4App.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_CourseExamPaperRelationship4App.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convcc_CourseExamPaperRelationship4App.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convcc_CourseExamPaperRelationship4App.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convcc_CourseExamPaperRelationship4App.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convcc_CourseExamPaperRelationship4App.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convcc_CourseExamPaperRelationship4App.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (convcc_CourseExamPaperRelationship4App.ExamGradeName  ==  AttributeName[intIndex])
{
return mstrExamGradeName;
}
else if (convcc_CourseExamPaperRelationship4App.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (convcc_CourseExamPaperRelationship4App.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (convcc_CourseExamPaperRelationship4App.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convcc_CourseExamPaperRelationship4App.StartTime  ==  AttributeName[intIndex])
{
return mdblStartTime;
}
else if (convcc_CourseExamPaperRelationship4App.PapersBigTopicId  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicId;
}
else if (convcc_CourseExamPaperRelationship4App.PapersBigTopicName  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicName;
}
else if (convcc_CourseExamPaperRelationship4App.TopicDescription  ==  AttributeName[intIndex])
{
return mstrTopicDescription;
}
else if (convcc_CourseExamPaperRelationship4App.TopicScores  ==  AttributeName[intIndex])
{
return mintTopicScores;
}
else if (convcc_CourseExamPaperRelationship4App.TopicOrderNum  ==  AttributeName[intIndex])
{
return mintTopicOrderNum;
}
else if (convcc_CourseExamPaperRelationship4App.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_CourseExamPaperRelationship4App.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_CourseExamPaperRelationship4App.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convcc_CourseExamPaperRelationship4App.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.mId);
}
else if (convcc_CourseExamPaperRelationship4App.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
}
else if (convcc_CourseExamPaperRelationship4App.ExamPaperName  ==  AttributeName[intIndex])
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamPaperName);
}
else if (convcc_CourseExamPaperRelationship4App.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseId);
}
else if (convcc_CourseExamPaperRelationship4App.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseName);
}
else if (convcc_CourseExamPaperRelationship4App.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionId);
}
else if (convcc_CourseExamPaperRelationship4App.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionIndex);
}
else if (convcc_CourseExamPaperRelationship4App.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionName);
}
else if (convcc_CourseExamPaperRelationship4App.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionTypeId);
}
else if (convcc_CourseExamPaperRelationship4App.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionTypeName);
}
else if (convcc_CourseExamPaperRelationship4App.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamGradeId);
}
else if (convcc_CourseExamPaperRelationship4App.ExamGradeName  ==  AttributeName[intIndex])
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamGradeName);
}
else if (convcc_CourseExamPaperRelationship4App.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionScore);
}
else if (convcc_CourseExamPaperRelationship4App.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.IsEffective);
}
else if (convcc_CourseExamPaperRelationship4App.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UserId);
}
else if (convcc_CourseExamPaperRelationship4App.StartTime  ==  AttributeName[intIndex])
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.StartTime);
}
else if (convcc_CourseExamPaperRelationship4App.PapersBigTopicId  ==  AttributeName[intIndex])
{
mstrPapersBigTopicId = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
}
else if (convcc_CourseExamPaperRelationship4App.PapersBigTopicName  ==  AttributeName[intIndex])
{
mstrPapersBigTopicName = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.PapersBigTopicName);
}
else if (convcc_CourseExamPaperRelationship4App.TopicDescription  ==  AttributeName[intIndex])
{
mstrTopicDescription = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicDescription);
}
else if (convcc_CourseExamPaperRelationship4App.TopicScores  ==  AttributeName[intIndex])
{
mintTopicScores = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicScores);
}
else if (convcc_CourseExamPaperRelationship4App.TopicOrderNum  ==  AttributeName[intIndex])
{
mintTopicOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicOrderNum);
}
else if (convcc_CourseExamPaperRelationship4App.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.OrderNum);
}
else if (convcc_CourseExamPaperRelationship4App.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UpdDate);
}
else if (convcc_CourseExamPaperRelationship4App.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UpdUser);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.mId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamPaperName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.CourseName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionIndex);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionTypeId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionTypeName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamGradeId);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.ExamGradeName);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.QuestionScore);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.IsEffective);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UserId);
}
}
/// <summary>
/// 开始时间(s)(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? StartTime
{
get
{
return mdblStartTime;
}
set
{
 mdblStartTime = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.StartTime);
}
}
/// <summary>
/// 试卷大题目Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PapersBigTopicId
{
get
{
return mstrPapersBigTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPapersBigTopicId = value;
}
else
{
 mstrPapersBigTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
}
}
/// <summary>
/// 试卷大题目名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PapersBigTopicName
{
get
{
return mstrPapersBigTopicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPapersBigTopicName = value;
}
else
{
 mstrPapersBigTopicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.PapersBigTopicName);
}
}
/// <summary>
/// 标题描述(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicDescription
{
get
{
return mstrTopicDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicDescription = value;
}
else
{
 mstrTopicDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicDescription);
}
}
/// <summary>
/// 大题得分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TopicScores
{
get
{
return mintTopicScores;
}
set
{
 mintTopicScores = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicScores);
}
}
/// <summary>
/// TopicOrderNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TopicOrderNum
{
get
{
return mintTopicOrderNum;
}
set
{
 mintTopicOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.TopicOrderNum);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.OrderNum);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UpdDate);
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
 AddUpdatedFld(convcc_CourseExamPaperRelationship4App.UpdUser);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v题目与试卷关系4App(vcc_CourseExamPaperRelationship4App)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CourseExamPaperRelationship4App
{
public const string _CurrTabName = "vcc_CourseExamPaperRelationship4App"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseExamPaperId", "ExamPaperName", "CourseId", "CourseName", "QuestionId", "QuestionIndex", "QuestionName", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "QuestionScore", "IsEffective", "UserId", "StartTime", "PapersBigTopicId", "PapersBigTopicName", "TopicDescription", "TopicScores", "TopicOrderNum", "OrderNum", "UpdDate", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"ExamPaperName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperName = "ExamPaperName";    //考卷名称

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
 /// 常量:"QuestionScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionScore = "QuestionScore";    //题目得分

 /// <summary>
 /// 常量:"IsEffective"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEffective = "IsEffective";    //是否有效

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"StartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartTime = "StartTime";    //开始时间(s)

 /// <summary>
 /// 常量:"PapersBigTopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PapersBigTopicId = "PapersBigTopicId";    //试卷大题目Id

 /// <summary>
 /// 常量:"PapersBigTopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PapersBigTopicName = "PapersBigTopicName";    //试卷大题目名称

 /// <summary>
 /// 常量:"TopicDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicDescription = "TopicDescription";    //标题描述

 /// <summary>
 /// 常量:"TopicScores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicScores = "TopicScores";    //大题得分

 /// <summary>
 /// 常量:"TopicOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicOrderNum = "TopicOrderNum";    //TopicOrderNum

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
}

}