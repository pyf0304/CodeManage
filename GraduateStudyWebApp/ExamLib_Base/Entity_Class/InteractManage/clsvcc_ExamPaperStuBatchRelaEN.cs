
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperStuBatchRelaEN
 表名:vcc_ExamPaperStuBatchRela(01120242)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:01
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
 /// 表vcc_ExamPaperStuBatchRela的关键字(IdPaperStuBatch)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPaperStuBatch_vcc_ExamPaperStuBatchRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPaperStuBatch">表关键字</param>
public K_IdPaperStuBatch_vcc_ExamPaperStuBatchRela(string strIdPaperStuBatch)
{
if (IsValid(strIdPaperStuBatch)) Value = strIdPaperStuBatch;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPaperStuBatch)
{
if (string.IsNullOrEmpty(strIdPaperStuBatch) == true) return false;
if (strIdPaperStuBatch.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPaperStuBatch_vcc_ExamPaperStuBatchRela]类型的对象</returns>
public static implicit operator K_IdPaperStuBatch_vcc_ExamPaperStuBatchRela(string value)
{
return new K_IdPaperStuBatch_vcc_ExamPaperStuBatchRela(value);
}
}
 /// <summary>
 /// v考卷与学生批次关系(vcc_ExamPaperStuBatchRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_ExamPaperStuBatchRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_ExamPaperStuBatchRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPaperStuBatch"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 60;
public static string[] AttributeName = new string[] {"IdPaperStuBatch", "CourseExamPaperId", "CourseId", "CourseName", "ExamPaperName", "PaperIndex", "ExamPaperTypeId", "ExamPaperTypeName", "IsShow", "TotalScore", "ViewCount", "DoneNumber", "PaperTime", "PaperDispModeName", "ExamCreateTime", "UserName", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "IsAutoGeneQuestion", "IsCanMultiDo", "QuestionNum", "IdStudentInfo", "StuID", "StuName", "SexDesc", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "IdGradeBase", "GradeBaseName", "BatchTime", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "Scores", "IsSave", "IsSubmit", "RealFinishDate", "OperateTime", "IsMarking", "MarkerId", "MarkDate", "AnswerIP", "AnswerDate", "AnswerTime", "TotalGetScore", "UpdDate", "UpdUserId", "Memo", "NoSubmitQuesNum", "SubmitQuesNum"};

protected string mstrIdPaperStuBatch;    //学生试卷批次流水号
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrExamPaperName;    //考卷名称
protected int? mintPaperIndex;    //试卷序号
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
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrStuID;    //学号
protected string mstrStuName;    //姓名
protected string mstrSexDesc;    //性别名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrBatchTime;    //批次
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected double? mdblScores;    //分值
protected bool mbolIsSave;    //是否保存
protected bool mbolIsSubmit;    //是否提交
protected string mstrRealFinishDate;    //实际完成日期
protected string mstrOperateTime;    //操作时间
protected bool mbolIsMarking;    //是否批阅
protected string mstrMarkerId;    //打分者
protected string mstrMarkDate;    //打分日期
protected string mstrAnswerIP;    //回答IP
protected string mstrAnswerDate;    //回答日期
protected string mstrAnswerTime;    //回答时间
protected double mdblTotalGetScore;    //考生获取总分
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintNoSubmitQuesNum;    //未提交题数
protected int? mintSubmitQuesNum;    //提交题数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_ExamPaperStuBatchRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPaperStuBatch");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPaperStuBatch">关键字:学生试卷批次流水号</param>
public clsvcc_ExamPaperStuBatchRelaEN(string strIdPaperStuBatch)
 {
strIdPaperStuBatch = strIdPaperStuBatch.Replace("'", "''");
if (strIdPaperStuBatch.Length > 10)
{
throw new Exception("在表:vcc_ExamPaperStuBatchRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPaperStuBatch)  ==  true)
{
throw new Exception("在表:vcc_ExamPaperStuBatchRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPaperStuBatch);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPaperStuBatch = strIdPaperStuBatch;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPaperStuBatch");
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
if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdPaperStuBatch)
{
return mstrIdPaperStuBatch;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ExamPaperName)
{
return mstrExamPaperName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.PaperIndex)
{
return mintPaperIndex;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ExamPaperTypeId)
{
return mstrExamPaperTypeId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ExamPaperTypeName)
{
return mstrExamPaperTypeName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.TotalScore)
{
return mdblTotalScore;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.DoneNumber)
{
return mintDoneNumber;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.PaperTime)
{
return mintPaperTime;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.PaperDispModeName)
{
return mstrPaperDispModeName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ExamCreateTime)
{
return mstrExamCreateTime;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion)
{
return mbolIsAutoGeneQuestion;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsCanMultiDo)
{
return mbolIsCanMultiDo;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.QuestionNum)
{
return mintQuestionNum;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.BatchTime)
{
return mstrBatchTime;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsSave)
{
return mbolIsSave;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.RealFinishDate)
{
return mstrRealFinishDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.OperateTime)
{
return mstrOperateTime;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.MarkDate)
{
return mstrMarkDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.TotalGetScore)
{
return mdblTotalGetScore;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.NoSubmitQuesNum)
{
return mintNoSubmitQuesNum;
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SubmitQuesNum)
{
return mintSubmitQuesNum;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdPaperStuBatch)
{
mstrIdPaperStuBatch = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdPaperStuBatch);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseExamPaperId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ExamPaperName)
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.PaperIndex)
{
mintPaperIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperIndex);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ExamPaperTypeId)
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ExamPaperTypeName)
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperTypeName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsShow);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.TotalScore)
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.TotalScore);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ViewCount);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.DoneNumber)
{
mintDoneNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.DoneNumber);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.PaperTime)
{
mintPaperTime = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperTime);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.PaperDispModeName)
{
mstrPaperDispModeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperDispModeName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ExamCreateTime)
{
mstrExamCreateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamCreateTime);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UserName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseChapterId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseChapterName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionNameSim);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion)
{
mbolIsAutoGeneQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsCanMultiDo)
{
mbolIsCanMultiDo = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsCanMultiDo);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.QuestionNum)
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.QuestionNum);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdStudentInfo);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.StuID);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.StuName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SexDesc);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdXzCollege);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CollegeName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CollegeNameA);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdXzMajor);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MajorID);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MajorName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdGradeBase);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.GradeBaseName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.BatchTime)
{
mstrBatchTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.BatchTime);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CurrEduClsId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.EduClsName);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.Scores);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsSave)
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsSave);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsSubmit);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.RealFinishDate)
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.RealFinishDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.OperateTime)
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.OperateTime);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsMarking);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MarkerId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.MarkDate)
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MarkDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerIP);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerTime);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.TotalGetScore)
{
mdblTotalGetScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.TotalGetScore);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UpdDate);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UpdUserId);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.Memo);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.NoSubmitQuesNum)
{
mintNoSubmitQuesNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum);
}
else if (strAttributeName  ==  convcc_ExamPaperStuBatchRela.SubmitQuesNum)
{
mintSubmitQuesNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SubmitQuesNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_ExamPaperStuBatchRela.IdPaperStuBatch  ==  AttributeName[intIndex])
{
return mstrIdPaperStuBatch;
}
else if (convcc_ExamPaperStuBatchRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convcc_ExamPaperStuBatchRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_ExamPaperStuBatchRela.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_ExamPaperStuBatchRela.ExamPaperName  ==  AttributeName[intIndex])
{
return mstrExamPaperName;
}
else if (convcc_ExamPaperStuBatchRela.PaperIndex  ==  AttributeName[intIndex])
{
return mintPaperIndex;
}
else if (convcc_ExamPaperStuBatchRela.ExamPaperTypeId  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeId;
}
else if (convcc_ExamPaperStuBatchRela.ExamPaperTypeName  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeName;
}
else if (convcc_ExamPaperStuBatchRela.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convcc_ExamPaperStuBatchRela.TotalScore  ==  AttributeName[intIndex])
{
return mdblTotalScore;
}
else if (convcc_ExamPaperStuBatchRela.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convcc_ExamPaperStuBatchRela.DoneNumber  ==  AttributeName[intIndex])
{
return mintDoneNumber;
}
else if (convcc_ExamPaperStuBatchRela.PaperTime  ==  AttributeName[intIndex])
{
return mintPaperTime;
}
else if (convcc_ExamPaperStuBatchRela.PaperDispModeName  ==  AttributeName[intIndex])
{
return mstrPaperDispModeName;
}
else if (convcc_ExamPaperStuBatchRela.ExamCreateTime  ==  AttributeName[intIndex])
{
return mstrExamCreateTime;
}
else if (convcc_ExamPaperStuBatchRela.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convcc_ExamPaperStuBatchRela.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_ExamPaperStuBatchRela.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_ExamPaperStuBatchRela.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convcc_ExamPaperStuBatchRela.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convcc_ExamPaperStuBatchRela.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_ExamPaperStuBatchRela.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_ExamPaperStuBatchRela.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_ExamPaperStuBatchRela.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion  ==  AttributeName[intIndex])
{
return mbolIsAutoGeneQuestion;
}
else if (convcc_ExamPaperStuBatchRela.IsCanMultiDo  ==  AttributeName[intIndex])
{
return mbolIsCanMultiDo;
}
else if (convcc_ExamPaperStuBatchRela.QuestionNum  ==  AttributeName[intIndex])
{
return mintQuestionNum;
}
else if (convcc_ExamPaperStuBatchRela.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convcc_ExamPaperStuBatchRela.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convcc_ExamPaperStuBatchRela.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convcc_ExamPaperStuBatchRela.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convcc_ExamPaperStuBatchRela.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convcc_ExamPaperStuBatchRela.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convcc_ExamPaperStuBatchRela.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convcc_ExamPaperStuBatchRela.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convcc_ExamPaperStuBatchRela.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convcc_ExamPaperStuBatchRela.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convcc_ExamPaperStuBatchRela.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convcc_ExamPaperStuBatchRela.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convcc_ExamPaperStuBatchRela.BatchTime  ==  AttributeName[intIndex])
{
return mstrBatchTime;
}
else if (convcc_ExamPaperStuBatchRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convcc_ExamPaperStuBatchRela.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convcc_ExamPaperStuBatchRela.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convcc_ExamPaperStuBatchRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (convcc_ExamPaperStuBatchRela.IsSave  ==  AttributeName[intIndex])
{
return mbolIsSave;
}
else if (convcc_ExamPaperStuBatchRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convcc_ExamPaperStuBatchRela.RealFinishDate  ==  AttributeName[intIndex])
{
return mstrRealFinishDate;
}
else if (convcc_ExamPaperStuBatchRela.OperateTime  ==  AttributeName[intIndex])
{
return mstrOperateTime;
}
else if (convcc_ExamPaperStuBatchRela.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (convcc_ExamPaperStuBatchRela.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (convcc_ExamPaperStuBatchRela.MarkDate  ==  AttributeName[intIndex])
{
return mstrMarkDate;
}
else if (convcc_ExamPaperStuBatchRela.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (convcc_ExamPaperStuBatchRela.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (convcc_ExamPaperStuBatchRela.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (convcc_ExamPaperStuBatchRela.TotalGetScore  ==  AttributeName[intIndex])
{
return mdblTotalGetScore;
}
else if (convcc_ExamPaperStuBatchRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_ExamPaperStuBatchRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_ExamPaperStuBatchRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_ExamPaperStuBatchRela.NoSubmitQuesNum  ==  AttributeName[intIndex])
{
return mintNoSubmitQuesNum;
}
else if (convcc_ExamPaperStuBatchRela.SubmitQuesNum  ==  AttributeName[intIndex])
{
return mintSubmitQuesNum;
}
return null;
}
set
{
if (convcc_ExamPaperStuBatchRela.IdPaperStuBatch  ==  AttributeName[intIndex])
{
mstrIdPaperStuBatch = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdPaperStuBatch);
}
else if (convcc_ExamPaperStuBatchRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseExamPaperId);
}
else if (convcc_ExamPaperStuBatchRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseId);
}
else if (convcc_ExamPaperStuBatchRela.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseName);
}
else if (convcc_ExamPaperStuBatchRela.ExamPaperName  ==  AttributeName[intIndex])
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperName);
}
else if (convcc_ExamPaperStuBatchRela.PaperIndex  ==  AttributeName[intIndex])
{
mintPaperIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperIndex);
}
else if (convcc_ExamPaperStuBatchRela.ExamPaperTypeId  ==  AttributeName[intIndex])
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
}
else if (convcc_ExamPaperStuBatchRela.ExamPaperTypeName  ==  AttributeName[intIndex])
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperTypeName);
}
else if (convcc_ExamPaperStuBatchRela.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsShow);
}
else if (convcc_ExamPaperStuBatchRela.TotalScore  ==  AttributeName[intIndex])
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.TotalScore);
}
else if (convcc_ExamPaperStuBatchRela.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ViewCount);
}
else if (convcc_ExamPaperStuBatchRela.DoneNumber  ==  AttributeName[intIndex])
{
mintDoneNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.DoneNumber);
}
else if (convcc_ExamPaperStuBatchRela.PaperTime  ==  AttributeName[intIndex])
{
mintPaperTime = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperTime);
}
else if (convcc_ExamPaperStuBatchRela.PaperDispModeName  ==  AttributeName[intIndex])
{
mstrPaperDispModeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperDispModeName);
}
else if (convcc_ExamPaperStuBatchRela.ExamCreateTime  ==  AttributeName[intIndex])
{
mstrExamCreateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamCreateTime);
}
else if (convcc_ExamPaperStuBatchRela.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UserName);
}
else if (convcc_ExamPaperStuBatchRela.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseChapterId);
}
else if (convcc_ExamPaperStuBatchRela.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseChapterName);
}
else if (convcc_ExamPaperStuBatchRela.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterId);
}
else if (convcc_ExamPaperStuBatchRela.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionId);
}
else if (convcc_ExamPaperStuBatchRela.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterName);
}
else if (convcc_ExamPaperStuBatchRela.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionName);
}
else if (convcc_ExamPaperStuBatchRela.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterNameSim);
}
else if (convcc_ExamPaperStuBatchRela.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionNameSim);
}
else if (convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion  ==  AttributeName[intIndex])
{
mbolIsAutoGeneQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion);
}
else if (convcc_ExamPaperStuBatchRela.IsCanMultiDo  ==  AttributeName[intIndex])
{
mbolIsCanMultiDo = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsCanMultiDo);
}
else if (convcc_ExamPaperStuBatchRela.QuestionNum  ==  AttributeName[intIndex])
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.QuestionNum);
}
else if (convcc_ExamPaperStuBatchRela.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdStudentInfo);
}
else if (convcc_ExamPaperStuBatchRela.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.StuID);
}
else if (convcc_ExamPaperStuBatchRela.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.StuName);
}
else if (convcc_ExamPaperStuBatchRela.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SexDesc);
}
else if (convcc_ExamPaperStuBatchRela.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdXzCollege);
}
else if (convcc_ExamPaperStuBatchRela.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CollegeName);
}
else if (convcc_ExamPaperStuBatchRela.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CollegeNameA);
}
else if (convcc_ExamPaperStuBatchRela.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdXzMajor);
}
else if (convcc_ExamPaperStuBatchRela.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MajorID);
}
else if (convcc_ExamPaperStuBatchRela.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MajorName);
}
else if (convcc_ExamPaperStuBatchRela.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdGradeBase);
}
else if (convcc_ExamPaperStuBatchRela.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.GradeBaseName);
}
else if (convcc_ExamPaperStuBatchRela.BatchTime  ==  AttributeName[intIndex])
{
mstrBatchTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.BatchTime);
}
else if (convcc_ExamPaperStuBatchRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdCurrEduCls);
}
else if (convcc_ExamPaperStuBatchRela.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CurrEduClsId);
}
else if (convcc_ExamPaperStuBatchRela.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.EduClsName);
}
else if (convcc_ExamPaperStuBatchRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.Scores);
}
else if (convcc_ExamPaperStuBatchRela.IsSave  ==  AttributeName[intIndex])
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsSave);
}
else if (convcc_ExamPaperStuBatchRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsSubmit);
}
else if (convcc_ExamPaperStuBatchRela.RealFinishDate  ==  AttributeName[intIndex])
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.RealFinishDate);
}
else if (convcc_ExamPaperStuBatchRela.OperateTime  ==  AttributeName[intIndex])
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.OperateTime);
}
else if (convcc_ExamPaperStuBatchRela.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsMarking);
}
else if (convcc_ExamPaperStuBatchRela.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MarkerId);
}
else if (convcc_ExamPaperStuBatchRela.MarkDate  ==  AttributeName[intIndex])
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MarkDate);
}
else if (convcc_ExamPaperStuBatchRela.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerIP);
}
else if (convcc_ExamPaperStuBatchRela.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerDate);
}
else if (convcc_ExamPaperStuBatchRela.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerTime);
}
else if (convcc_ExamPaperStuBatchRela.TotalGetScore  ==  AttributeName[intIndex])
{
mdblTotalGetScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.TotalGetScore);
}
else if (convcc_ExamPaperStuBatchRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UpdDate);
}
else if (convcc_ExamPaperStuBatchRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UpdUserId);
}
else if (convcc_ExamPaperStuBatchRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.Memo);
}
else if (convcc_ExamPaperStuBatchRela.NoSubmitQuesNum  ==  AttributeName[intIndex])
{
mintNoSubmitQuesNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum);
}
else if (convcc_ExamPaperStuBatchRela.SubmitQuesNum  ==  AttributeName[intIndex])
{
mintSubmitQuesNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SubmitQuesNum);
}
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdPaperStuBatch);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseExamPaperId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperIndex);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperTypeId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamPaperTypeName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsShow);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.TotalScore);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ViewCount);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.DoneNumber);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperTime);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.PaperDispModeName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ExamCreateTime);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UserName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseChapterId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CourseChapterName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.ChapterNameSim);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SectionNameSim);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsAutoGeneQuestion);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsCanMultiDo);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.QuestionNum);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdStudentInfo);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.StuID);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.StuName);
}
}
/// <summary>
/// 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SexDesc
{
get
{
return mstrSexDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexDesc = value;
}
else
{
 mstrSexDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SexDesc);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdXzCollege);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CollegeName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CollegeNameA);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdXzMajor);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MajorID);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MajorName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdGradeBase);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.GradeBaseName);
}
}
/// <summary>
/// 批次(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BatchTime
{
get
{
return mstrBatchTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBatchTime = value;
}
else
{
 mstrBatchTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.BatchTime);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IdCurrEduCls);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.CurrEduClsId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.EduClsName);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.Scores);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsSave);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsSubmit);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.RealFinishDate);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.OperateTime);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.IsMarking);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MarkerId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.MarkDate);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerIP);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerDate);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.AnswerTime);
}
}
/// <summary>
/// 考生获取总分(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double TotalGetScore
{
get
{
return mdblTotalGetScore;
}
set
{
 mdblTotalGetScore = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.TotalGetScore);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UpdDate);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.UpdUserId);
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
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.Memo);
}
}
/// <summary>
/// 未提交题数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? NoSubmitQuesNum
{
get
{
return mintNoSubmitQuesNum;
}
set
{
 mintNoSubmitQuesNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.NoSubmitQuesNum);
}
}
/// <summary>
/// 提交题数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubmitQuesNum
{
get
{
return mintSubmitQuesNum;
}
set
{
 mintSubmitQuesNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExamPaperStuBatchRela.SubmitQuesNum);
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
  return mstrIdPaperStuBatch;
 }
 }
}
 /// <summary>
 /// v考卷与学生批次关系(vcc_ExamPaperStuBatchRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_ExamPaperStuBatchRela
{
public const string _CurrTabName = "vcc_ExamPaperStuBatchRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPaperStuBatch"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPaperStuBatch", "CourseExamPaperId", "CourseId", "CourseName", "ExamPaperName", "PaperIndex", "ExamPaperTypeId", "ExamPaperTypeName", "IsShow", "TotalScore", "ViewCount", "DoneNumber", "PaperTime", "PaperDispModeName", "ExamCreateTime", "UserName", "CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "IsAutoGeneQuestion", "IsCanMultiDo", "QuestionNum", "IdStudentInfo", "StuID", "StuName", "SexDesc", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "IdGradeBase", "GradeBaseName", "BatchTime", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "Scores", "IsSave", "IsSubmit", "RealFinishDate", "OperateTime", "IsMarking", "MarkerId", "MarkDate", "AnswerIP", "AnswerDate", "AnswerTime", "TotalGetScore", "UpdDate", "UpdUserId", "Memo", "NoSubmitQuesNum", "SubmitQuesNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPaperStuBatch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPaperStuBatch = "IdPaperStuBatch";    //学生试卷批次流水号

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
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

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
 /// 常量:"BatchTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BatchTime = "BatchTime";    //批次

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"Scores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Scores = "Scores";    //分值

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
 /// 常量:"TotalGetScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalGetScore = "TotalGetScore";    //考生获取总分

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
 /// 常量:"NoSubmitQuesNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NoSubmitQuesNum = "NoSubmitQuesNum";    //未提交题数

 /// <summary>
 /// 常量:"SubmitQuesNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubmitQuesNum = "SubmitQuesNum";    //提交题数
}

}