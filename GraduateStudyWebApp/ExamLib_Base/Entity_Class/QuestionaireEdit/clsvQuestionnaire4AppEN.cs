
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4AppEN
 表名:vQuestionnaire4App(01120221)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:42
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
 /// 表vQuestionnaire4App的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_vQuestionnaire4App
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
public K_QuestionId_vQuestionnaire4App(long lngQuestionId)
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
 /// <returns>返回:[K_QuestionId_vQuestionnaire4App]类型的对象</returns>
public static implicit operator K_QuestionId_vQuestionnaire4App(long value)
{
return new K_QuestionId_vQuestionnaire4App(value);
}
}
 /// <summary>
 /// v题目表4App(vQuestionnaire4App)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionnaire4AppEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionnaire4App"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionNo", "CourseId", "CourseCode", "CourseName", "CourseChapterId", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "AnswerTypeId", "QuestionScore", "UpdDate", "OptionNum", "ChapterOrderNum"};

protected long mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionNo;    //题目编号
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrChapterId;    //章Id
protected string mstrSectionId;    //节Id
protected string mstrChapterName;    //章名
protected string mstrSectionName;    //节名
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected string mstrParentNodeId;    //父节点编号
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrExamGradeId;    //题库等级ID
protected string mstrExamGradeName;    //题库等级名
protected string mstrAnswerTypeId;    //答案类型ID
protected float? mfltQuestionScore;    //题目得分
protected string mstrUpdDate;    //修改日期
protected int? mintOptionNum;    //选项数
protected int? mintChapterOrderNum;    //章排序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionnaire4AppEN()
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
public clsvQuestionnaire4AppEN(long lngQuestionId)
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
if (strAttributeName  ==  convQuestionnaire4App.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convQuestionnaire4App.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionnaire4App.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convQuestionnaire4App.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convQuestionnaire4App.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convQuestionnaire4App.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convQuestionnaire4App.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convQuestionnaire4App.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convQuestionnaire4App.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convQuestionnaire4App.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convQuestionnaire4App.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convQuestionnaire4App.ParentNodeId)
{
return mstrParentNodeId;
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convQuestionnaire4App.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  convQuestionnaire4App.ExamGradeName)
{
return mstrExamGradeName;
}
else if (strAttributeName  ==  convQuestionnaire4App.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  convQuestionnaire4App.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQuestionnaire4App.OptionNum)
{
return mintOptionNum;
}
else if (strAttributeName  ==  convQuestionnaire4App.ChapterOrderNum)
{
return mintChapterOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionnaire4App.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.QuestionId);
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.QuestionIndex);
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.QuestionName);
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.QuestionNo);
}
else if (strAttributeName  ==  convQuestionnaire4App.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.CourseId);
}
else if (strAttributeName  ==  convQuestionnaire4App.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.CourseCode);
}
else if (strAttributeName  ==  convQuestionnaire4App.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.CourseName);
}
else if (strAttributeName  ==  convQuestionnaire4App.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.CourseChapterId);
}
else if (strAttributeName  ==  convQuestionnaire4App.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ChapterId);
}
else if (strAttributeName  ==  convQuestionnaire4App.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.SectionId);
}
else if (strAttributeName  ==  convQuestionnaire4App.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ChapterName);
}
else if (strAttributeName  ==  convQuestionnaire4App.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.SectionName);
}
else if (strAttributeName  ==  convQuestionnaire4App.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ChapterNameSim);
}
else if (strAttributeName  ==  convQuestionnaire4App.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.SectionNameSim);
}
else if (strAttributeName  ==  convQuestionnaire4App.ParentNodeId)
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ParentNodeId);
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.QuestionTypeId);
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.QuestionTypeName);
}
else if (strAttributeName  ==  convQuestionnaire4App.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ExamGradeId);
}
else if (strAttributeName  ==  convQuestionnaire4App.ExamGradeName)
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ExamGradeName);
}
else if (strAttributeName  ==  convQuestionnaire4App.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.AnswerTypeId);
}
else if (strAttributeName  ==  convQuestionnaire4App.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.QuestionScore);
}
else if (strAttributeName  ==  convQuestionnaire4App.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.UpdDate);
}
else if (strAttributeName  ==  convQuestionnaire4App.OptionNum)
{
mintOptionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.OptionNum);
}
else if (strAttributeName  ==  convQuestionnaire4App.ChapterOrderNum)
{
mintChapterOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.ChapterOrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionnaire4App.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convQuestionnaire4App.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convQuestionnaire4App.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convQuestionnaire4App.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convQuestionnaire4App.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionnaire4App.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convQuestionnaire4App.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convQuestionnaire4App.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convQuestionnaire4App.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convQuestionnaire4App.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convQuestionnaire4App.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convQuestionnaire4App.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convQuestionnaire4App.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convQuestionnaire4App.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convQuestionnaire4App.ParentNodeId  ==  AttributeName[intIndex])
{
return mstrParentNodeId;
}
else if (convQuestionnaire4App.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convQuestionnaire4App.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convQuestionnaire4App.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (convQuestionnaire4App.ExamGradeName  ==  AttributeName[intIndex])
{
return mstrExamGradeName;
}
else if (convQuestionnaire4App.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convQuestionnaire4App.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (convQuestionnaire4App.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQuestionnaire4App.OptionNum  ==  AttributeName[intIndex])
{
return mintOptionNum;
}
else if (convQuestionnaire4App.ChapterOrderNum  ==  AttributeName[intIndex])
{
return mintChapterOrderNum;
}
return null;
}
set
{
if (convQuestionnaire4App.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.QuestionId);
}
else if (convQuestionnaire4App.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.QuestionIndex);
}
else if (convQuestionnaire4App.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.QuestionName);
}
else if (convQuestionnaire4App.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.QuestionNo);
}
else if (convQuestionnaire4App.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.CourseId);
}
else if (convQuestionnaire4App.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.CourseCode);
}
else if (convQuestionnaire4App.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.CourseName);
}
else if (convQuestionnaire4App.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.CourseChapterId);
}
else if (convQuestionnaire4App.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ChapterId);
}
else if (convQuestionnaire4App.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.SectionId);
}
else if (convQuestionnaire4App.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ChapterName);
}
else if (convQuestionnaire4App.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.SectionName);
}
else if (convQuestionnaire4App.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ChapterNameSim);
}
else if (convQuestionnaire4App.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.SectionNameSim);
}
else if (convQuestionnaire4App.ParentNodeId  ==  AttributeName[intIndex])
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ParentNodeId);
}
else if (convQuestionnaire4App.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.QuestionTypeId);
}
else if (convQuestionnaire4App.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.QuestionTypeName);
}
else if (convQuestionnaire4App.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ExamGradeId);
}
else if (convQuestionnaire4App.ExamGradeName  ==  AttributeName[intIndex])
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.ExamGradeName);
}
else if (convQuestionnaire4App.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.AnswerTypeId);
}
else if (convQuestionnaire4App.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.QuestionScore);
}
else if (convQuestionnaire4App.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionnaire4App.UpdDate);
}
else if (convQuestionnaire4App.OptionNum  ==  AttributeName[intIndex])
{
mintOptionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.OptionNum);
}
else if (convQuestionnaire4App.ChapterOrderNum  ==  AttributeName[intIndex])
{
mintChapterOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App.ChapterOrderNum);
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
 AddUpdatedFld(convQuestionnaire4App.QuestionId);
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
 AddUpdatedFld(convQuestionnaire4App.QuestionIndex);
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
 AddUpdatedFld(convQuestionnaire4App.QuestionName);
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
 AddUpdatedFld(convQuestionnaire4App.QuestionNo);
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
 AddUpdatedFld(convQuestionnaire4App.CourseId);
}
}
/// <summary>
/// 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCode
{
get
{
return mstrCourseCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCode = value;
}
else
{
 mstrCourseCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire4App.CourseCode);
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
 AddUpdatedFld(convQuestionnaire4App.CourseName);
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
 AddUpdatedFld(convQuestionnaire4App.CourseChapterId);
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
 AddUpdatedFld(convQuestionnaire4App.ChapterId);
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
 AddUpdatedFld(convQuestionnaire4App.SectionId);
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
 AddUpdatedFld(convQuestionnaire4App.ChapterName);
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
 AddUpdatedFld(convQuestionnaire4App.SectionName);
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
 AddUpdatedFld(convQuestionnaire4App.ChapterNameSim);
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
 AddUpdatedFld(convQuestionnaire4App.SectionNameSim);
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
 AddUpdatedFld(convQuestionnaire4App.ParentNodeId);
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
 AddUpdatedFld(convQuestionnaire4App.QuestionTypeId);
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
 AddUpdatedFld(convQuestionnaire4App.QuestionTypeName);
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
 AddUpdatedFld(convQuestionnaire4App.ExamGradeId);
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
 AddUpdatedFld(convQuestionnaire4App.ExamGradeName);
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
 AddUpdatedFld(convQuestionnaire4App.AnswerTypeId);
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
 AddUpdatedFld(convQuestionnaire4App.QuestionScore);
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
 AddUpdatedFld(convQuestionnaire4App.UpdDate);
}
}
/// <summary>
/// 选项数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OptionNum
{
get
{
return mintOptionNum;
}
set
{
 mintOptionNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire4App.OptionNum);
}
}
/// <summary>
/// 章排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ChapterOrderNum
{
get
{
return mintChapterOrderNum;
}
set
{
 mintChapterOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire4App.ChapterOrderNum);
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
 /// v题目表4App(vQuestionnaire4App)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionnaire4App
{
public const string _CurrTabName = "vQuestionnaire4App"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionNo", "CourseId", "CourseCode", "CourseName", "CourseChapterId", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeId", "QuestionTypeId", "QuestionTypeName", "ExamGradeId", "ExamGradeName", "AnswerTypeId", "QuestionScore", "UpdDate", "OptionNum", "ChapterOrderNum"};
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
 /// 常量:"QuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNo = "QuestionNo";    //题目编号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

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
 /// 常量:"QuestionScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionScore = "QuestionScore";    //题目得分

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"OptionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionNum = "OptionNum";    //选项数

 /// <summary>
 /// 常量:"ChapterOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterOrderNum = "ChapterOrderNum";    //章排序号
}

}