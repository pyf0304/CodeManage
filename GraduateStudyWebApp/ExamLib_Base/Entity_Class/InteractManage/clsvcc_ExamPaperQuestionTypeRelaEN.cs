
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperQuestionTypeRelaEN
 表名:vcc_ExamPaperQuestionTypeRela(01120238)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:59
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
 /// 表vcc_ExamPaperQuestionTypeRela的关键字(IdExamPaperQuestionTypeRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdExamPaperQuestionTypeRela_vcc_ExamPaperQuestionTypeRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdExamPaperQuestionTypeRela">表关键字</param>
public K_IdExamPaperQuestionTypeRela_vcc_ExamPaperQuestionTypeRela(long lngIdExamPaperQuestionTypeRela)
{
if (IsValid(lngIdExamPaperQuestionTypeRela)) Value = lngIdExamPaperQuestionTypeRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdExamPaperQuestionTypeRela)
{
if (lngIdExamPaperQuestionTypeRela == 0) return false;
if (lngIdExamPaperQuestionTypeRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdExamPaperQuestionTypeRela_vcc_ExamPaperQuestionTypeRela]类型的对象</returns>
public static implicit operator K_IdExamPaperQuestionTypeRela_vcc_ExamPaperQuestionTypeRela(long value)
{
return new K_IdExamPaperQuestionTypeRela_vcc_ExamPaperQuestionTypeRela(value);
}
}
 /// <summary>
 /// v考卷题型关系(vcc_ExamPaperQuestionTypeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_ExamPaperQuestionTypeRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_ExamPaperQuestionTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdExamPaperQuestionTypeRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 39;
public static string[] AttributeName = new string[] {"IdExamPaperQuestionTypeRela", "CourseExamPaperId", "CourseId", "CourseName", "ExamPaperName", "ExamPaperTypeId", "ExamPaperTypeName", "IsShow", "TotalScore", "ViewCount", "DoneNumber", "PaperTime", "PaperDispModeName", "ExamCreateTime", "UserName", "CourseChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "QuestionNum", "Scores", "QuestionTypeId", "QuestionTypeName", "QuestionTypeENName", "DefaAnswerModeId", "DefaAnswerTypeId", "IsUse", "ChapterId", "NeedQuestionNum", "PerScore", "OrderNum", "UpdDate", "UpdUserId", "Memo", "ChapterId4QT", "ChapterNameSim4QT", "ChapterName4QT"};

protected long mlngIdExamPaperQuestionTypeRela;    //Id_ExamPaperQuestionTypeRela
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrExamPaperName;    //考卷名称
protected string mstrExamPaperTypeId;    //试卷类型Id
protected string mstrExamPaperTypeName;    //试卷类型名称
protected bool mbolIsShow;    //是否启用
protected double mdblTotalScore;    //总得分
protected int? mintViewCount;    //浏览量
protected int? mintDoneNumber;    //已做人数
protected int? mintPaperTime;    //考试时间（分钟）
protected string mstrPaperDispModeName;    //试卷显示模式名称
protected string mstrExamCreateTime;    //考卷建立时间
protected string mstrUserName;    //用户名
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrSectionId;    //节Id
protected string mstrChapterName;    //章名
protected string mstrSectionName;    //节名
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected int? mintQuestionNum;    //题目数
protected double? mdblScores;    //分值
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrQuestionTypeENName;    //题目类型英文名
protected string mstrDefaAnswerModeId;    //默认答案模式Id
protected string mstrDefaAnswerTypeId;    //默认答案类型Id
protected bool mbolIsUse;    //是否使用
protected string mstrChapterId;    //章Id
protected int mintNeedQuestionNum;    //需要题目数
protected double mdblPerScore;    //每题分值
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrChapterId4QT;    //ChapterId4QT
protected string mstrChapterNameSim4QT;    //ChapterName_Sim4QT
protected string mstrChapterName4QT;    //ChapterName4QT

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_ExamPaperQuestionTypeRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamPaperQuestionTypeRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdExamPaperQuestionTypeRela">关键字:Id_ExamPaperQuestionTypeRela</param>
public clsvcc_ExamPaperQuestionTypeRelaEN(long lngIdExamPaperQuestionTypeRela)
 {
 if (lngIdExamPaperQuestionTypeRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdExamPaperQuestionTypeRela = lngIdExamPaperQuestionTypeRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamPaperQuestionTypeRela");
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
if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela)
{
return mlngIdExamPaperQuestionTypeRela;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ExamPaperName)
{
return mstrExamPaperName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId)
{
return mstrExamPaperTypeId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName)
{
return mstrExamPaperTypeName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.TotalScore)
{
return mdblTotalScore;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.DoneNumber)
{
return mintDoneNumber;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.PaperTime)
{
return mintPaperTime;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.PaperDispModeName)
{
return mstrPaperDispModeName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ExamCreateTime)
{
return mstrExamCreateTime;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.QuestionNum)
{
return mintQuestionNum;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.QuestionTypeENName)
{
return mstrQuestionTypeENName;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId)
{
return mstrDefaAnswerModeId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId)
{
return mstrDefaAnswerTypeId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.NeedQuestionNum)
{
return mintNeedQuestionNum;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.PerScore)
{
return mdblPerScore;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterId4QT)
{
return mstrChapterId4QT;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT)
{
return mstrChapterNameSim4QT;
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterName4QT)
{
return mstrChapterName4QT;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela)
{
mlngIdExamPaperQuestionTypeRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseExamPaperId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ExamPaperName)
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId)
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName)
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IsShow);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.TotalScore)
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.TotalScore);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ViewCount);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.DoneNumber)
{
mintDoneNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DoneNumber);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.PaperTime)
{
mintPaperTime = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PaperTime);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.PaperDispModeName)
{
mstrPaperDispModeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PaperDispModeName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ExamCreateTime)
{
mstrExamCreateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamCreateTime);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UserName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseChapterId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionNameSim);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.QuestionNum)
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionNum);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.Scores);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.QuestionTypeENName)
{
mstrQuestionTypeENName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeENName);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId)
{
mstrDefaAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId)
{
mstrDefaAnswerTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IsUse);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.NeedQuestionNum)
{
mintNeedQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.NeedQuestionNum);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.PerScore)
{
mdblPerScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PerScore);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.OrderNum);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UpdDate);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UpdUserId);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.Memo);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterId4QT)
{
mstrChapterId4QT = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterId4QT);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT)
{
mstrChapterNameSim4QT = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT);
}
else if (strAttributeName  ==  convcc_ExamPaperQuestionTypeRela.ChapterName4QT)
{
mstrChapterName4QT = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterName4QT);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela  ==  AttributeName[intIndex])
{
return mlngIdExamPaperQuestionTypeRela;
}
else if (convcc_ExamPaperQuestionTypeRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convcc_ExamPaperQuestionTypeRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_ExamPaperQuestionTypeRela.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_ExamPaperQuestionTypeRela.ExamPaperName  ==  AttributeName[intIndex])
{
return mstrExamPaperName;
}
else if (convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeId;
}
else if (convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeName;
}
else if (convcc_ExamPaperQuestionTypeRela.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convcc_ExamPaperQuestionTypeRela.TotalScore  ==  AttributeName[intIndex])
{
return mdblTotalScore;
}
else if (convcc_ExamPaperQuestionTypeRela.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convcc_ExamPaperQuestionTypeRela.DoneNumber  ==  AttributeName[intIndex])
{
return mintDoneNumber;
}
else if (convcc_ExamPaperQuestionTypeRela.PaperTime  ==  AttributeName[intIndex])
{
return mintPaperTime;
}
else if (convcc_ExamPaperQuestionTypeRela.PaperDispModeName  ==  AttributeName[intIndex])
{
return mstrPaperDispModeName;
}
else if (convcc_ExamPaperQuestionTypeRela.ExamCreateTime  ==  AttributeName[intIndex])
{
return mstrExamCreateTime;
}
else if (convcc_ExamPaperQuestionTypeRela.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convcc_ExamPaperQuestionTypeRela.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_ExamPaperQuestionTypeRela.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_ExamPaperQuestionTypeRela.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_ExamPaperQuestionTypeRela.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_ExamPaperQuestionTypeRela.QuestionNum  ==  AttributeName[intIndex])
{
return mintQuestionNum;
}
else if (convcc_ExamPaperQuestionTypeRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (convcc_ExamPaperQuestionTypeRela.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convcc_ExamPaperQuestionTypeRela.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convcc_ExamPaperQuestionTypeRela.QuestionTypeENName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeENName;
}
else if (convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId  ==  AttributeName[intIndex])
{
return mstrDefaAnswerModeId;
}
else if (convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId  ==  AttributeName[intIndex])
{
return mstrDefaAnswerTypeId;
}
else if (convcc_ExamPaperQuestionTypeRela.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convcc_ExamPaperQuestionTypeRela.NeedQuestionNum  ==  AttributeName[intIndex])
{
return mintNeedQuestionNum;
}
else if (convcc_ExamPaperQuestionTypeRela.PerScore  ==  AttributeName[intIndex])
{
return mdblPerScore;
}
else if (convcc_ExamPaperQuestionTypeRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_ExamPaperQuestionTypeRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_ExamPaperQuestionTypeRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_ExamPaperQuestionTypeRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterId4QT  ==  AttributeName[intIndex])
{
return mstrChapterId4QT;
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT  ==  AttributeName[intIndex])
{
return mstrChapterNameSim4QT;
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterName4QT  ==  AttributeName[intIndex])
{
return mstrChapterName4QT;
}
return null;
}
set
{
if (convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela  ==  AttributeName[intIndex])
{
mlngIdExamPaperQuestionTypeRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela);
}
else if (convcc_ExamPaperQuestionTypeRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseExamPaperId);
}
else if (convcc_ExamPaperQuestionTypeRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseId);
}
else if (convcc_ExamPaperQuestionTypeRela.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseName);
}
else if (convcc_ExamPaperQuestionTypeRela.ExamPaperName  ==  AttributeName[intIndex])
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperName);
}
else if (convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId  ==  AttributeName[intIndex])
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId);
}
else if (convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName  ==  AttributeName[intIndex])
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName);
}
else if (convcc_ExamPaperQuestionTypeRela.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IsShow);
}
else if (convcc_ExamPaperQuestionTypeRela.TotalScore  ==  AttributeName[intIndex])
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.TotalScore);
}
else if (convcc_ExamPaperQuestionTypeRela.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ViewCount);
}
else if (convcc_ExamPaperQuestionTypeRela.DoneNumber  ==  AttributeName[intIndex])
{
mintDoneNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DoneNumber);
}
else if (convcc_ExamPaperQuestionTypeRela.PaperTime  ==  AttributeName[intIndex])
{
mintPaperTime = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PaperTime);
}
else if (convcc_ExamPaperQuestionTypeRela.PaperDispModeName  ==  AttributeName[intIndex])
{
mstrPaperDispModeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PaperDispModeName);
}
else if (convcc_ExamPaperQuestionTypeRela.ExamCreateTime  ==  AttributeName[intIndex])
{
mstrExamCreateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamCreateTime);
}
else if (convcc_ExamPaperQuestionTypeRela.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UserName);
}
else if (convcc_ExamPaperQuestionTypeRela.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseChapterId);
}
else if (convcc_ExamPaperQuestionTypeRela.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionId);
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterName);
}
else if (convcc_ExamPaperQuestionTypeRela.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionName);
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterNameSim);
}
else if (convcc_ExamPaperQuestionTypeRela.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionNameSim);
}
else if (convcc_ExamPaperQuestionTypeRela.QuestionNum  ==  AttributeName[intIndex])
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionNum);
}
else if (convcc_ExamPaperQuestionTypeRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.Scores);
}
else if (convcc_ExamPaperQuestionTypeRela.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeId);
}
else if (convcc_ExamPaperQuestionTypeRela.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeName);
}
else if (convcc_ExamPaperQuestionTypeRela.QuestionTypeENName  ==  AttributeName[intIndex])
{
mstrQuestionTypeENName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeENName);
}
else if (convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId  ==  AttributeName[intIndex])
{
mstrDefaAnswerModeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId);
}
else if (convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId  ==  AttributeName[intIndex])
{
mstrDefaAnswerTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId);
}
else if (convcc_ExamPaperQuestionTypeRela.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IsUse);
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterId);
}
else if (convcc_ExamPaperQuestionTypeRela.NeedQuestionNum  ==  AttributeName[intIndex])
{
mintNeedQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.NeedQuestionNum);
}
else if (convcc_ExamPaperQuestionTypeRela.PerScore  ==  AttributeName[intIndex])
{
mdblPerScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PerScore);
}
else if (convcc_ExamPaperQuestionTypeRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.OrderNum);
}
else if (convcc_ExamPaperQuestionTypeRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UpdDate);
}
else if (convcc_ExamPaperQuestionTypeRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UpdUserId);
}
else if (convcc_ExamPaperQuestionTypeRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.Memo);
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterId4QT  ==  AttributeName[intIndex])
{
mstrChapterId4QT = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterId4QT);
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT  ==  AttributeName[intIndex])
{
mstrChapterNameSim4QT = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT);
}
else if (convcc_ExamPaperQuestionTypeRela.ChapterName4QT  ==  AttributeName[intIndex])
{
mstrChapterName4QT = value.ToString();
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterName4QT);
}
}
}

/// <summary>
/// Id_ExamPaperQuestionTypeRela(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdExamPaperQuestionTypeRela
{
get
{
return mlngIdExamPaperQuestionTypeRela;
}
set
{
 mlngIdExamPaperQuestionTypeRela = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseExamPaperId);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseId);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseName);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperName);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IsShow);
}
}
/// <summary>
/// 总得分(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double TotalScore
{
get
{
return mdblTotalScore;
}
set
{
 mdblTotalScore = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.TotalScore);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ViewCount
{
get
{
return mintViewCount;
}
set
{
 mintViewCount = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ViewCount);
}
}
/// <summary>
/// 已做人数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DoneNumber
{
get
{
return mintDoneNumber;
}
set
{
 mintDoneNumber = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DoneNumber);
}
}
/// <summary>
/// 考试时间（分钟）(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperTime
{
get
{
return mintPaperTime;
}
set
{
 mintPaperTime = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PaperTime);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PaperDispModeName);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ExamCreateTime);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UserName);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.CourseChapterId);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionId);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterName);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionName);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterNameSim);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.SectionNameSim);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionNum);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.Scores);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeId);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeName);
}
}
/// <summary>
/// 题目类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeENName
{
get
{
return mstrQuestionTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeENName = value;
}
else
{
 mstrQuestionTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.QuestionTypeENName);
}
}
/// <summary>
/// 默认答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaAnswerModeId
{
get
{
return mstrDefaAnswerModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaAnswerModeId = value;
}
else
{
 mstrDefaAnswerModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId);
}
}
/// <summary>
/// 默认答案类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaAnswerTypeId
{
get
{
return mstrDefaAnswerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaAnswerTypeId = value;
}
else
{
 mstrDefaAnswerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.IsUse);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterId);
}
}
/// <summary>
/// 需要题目数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int NeedQuestionNum
{
get
{
return mintNeedQuestionNum;
}
set
{
 mintNeedQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.NeedQuestionNum);
}
}
/// <summary>
/// 每题分值(说明:;字段类型:decimal;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double PerScore
{
get
{
return mdblPerScore;
}
set
{
 mdblPerScore = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.PerScore);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.OrderNum);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UpdDate);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.UpdUserId);
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
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.Memo);
}
}
/// <summary>
/// ChapterId4QT(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterId4QT
{
get
{
return mstrChapterId4QT;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterId4QT = value;
}
else
{
 mstrChapterId4QT = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterId4QT);
}
}
/// <summary>
/// ChapterName_Sim4QT(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim4QT
{
get
{
return mstrChapterNameSim4QT;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim4QT = value;
}
else
{
 mstrChapterNameSim4QT = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT);
}
}
/// <summary>
/// ChapterName4QT(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterName4QT
{
get
{
return mstrChapterName4QT;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterName4QT = value;
}
else
{
 mstrChapterName4QT = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperQuestionTypeRela.ChapterName4QT);
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
  return mlngIdExamPaperQuestionTypeRela.ToString();
 }
 }
}
 /// <summary>
 /// v考卷题型关系(vcc_ExamPaperQuestionTypeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_ExamPaperQuestionTypeRela
{
public const string _CurrTabName = "vcc_ExamPaperQuestionTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdExamPaperQuestionTypeRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdExamPaperQuestionTypeRela", "CourseExamPaperId", "CourseId", "CourseName", "ExamPaperName", "ExamPaperTypeId", "ExamPaperTypeName", "IsShow", "TotalScore", "ViewCount", "DoneNumber", "PaperTime", "PaperDispModeName", "ExamCreateTime", "UserName", "CourseChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "QuestionNum", "Scores", "QuestionTypeId", "QuestionTypeName", "QuestionTypeENName", "DefaAnswerModeId", "DefaAnswerTypeId", "IsUse", "ChapterId", "NeedQuestionNum", "PerScore", "OrderNum", "UpdDate", "UpdUserId", "Memo", "ChapterId4QT", "ChapterNameSim4QT", "ChapterName4QT"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdExamPaperQuestionTypeRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExamPaperQuestionTypeRela = "IdExamPaperQuestionTypeRela";    //Id_ExamPaperQuestionTypeRela

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

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
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"TotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalScore = "TotalScore";    //总得分

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"DoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DoneNumber = "DoneNumber";    //已做人数

 /// <summary>
 /// 常量:"PaperTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTime = "PaperTime";    //考试时间（分钟）

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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

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
 /// 常量:"QuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNum = "QuestionNum";    //题目数

 /// <summary>
 /// 常量:"Scores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Scores = "Scores";    //分值

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
 /// 常量:"QuestionTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeENName = "QuestionTypeENName";    //题目类型英文名

 /// <summary>
 /// 常量:"DefaAnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaAnswerModeId = "DefaAnswerModeId";    //默认答案模式Id

 /// <summary>
 /// 常量:"DefaAnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaAnswerTypeId = "DefaAnswerTypeId";    //默认答案类型Id

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

 /// <summary>
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"NeedQuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NeedQuestionNum = "NeedQuestionNum";    //需要题目数

 /// <summary>
 /// 常量:"PerScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PerScore = "PerScore";    //每题分值

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
 /// 常量:"ChapterId4QT"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId4QT = "ChapterId4QT";    //ChapterId4QT

 /// <summary>
 /// 常量:"ChapterNameSim4QT"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim4QT = "ChapterNameSim4QT";    //ChapterName_Sim4QT

 /// <summary>
 /// 常量:"ChapterName4QT"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterName4QT = "ChapterName4QT";    //ChapterName4QT
}

}