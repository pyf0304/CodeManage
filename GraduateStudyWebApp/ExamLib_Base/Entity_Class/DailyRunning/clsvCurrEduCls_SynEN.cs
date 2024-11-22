
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls_SynEN
 表名:vCurrEduCls_Syn(01120928)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 表vCurrEduCls_Syn的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_vCurrEduCls_Syn
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
public K_IdCurrEduCls_vCurrEduCls_Syn(string strIdCurrEduCls)
{
if (IsValid(strIdCurrEduCls)) Value = strIdCurrEduCls;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return false;
if (strIdCurrEduCls.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCurrEduCls_vCurrEduCls_Syn]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_vCurrEduCls_Syn(string value)
{
return new K_IdCurrEduCls_vCurrEduCls_Syn(value);
}
}
 /// <summary>
 /// vCurrEduCls_Syn(vCurrEduCls_Syn)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCurrEduCls_SynEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCurrEduCls_Syn"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 80;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "EduClsTypeName", "CourseCode", "CourseDescription", "CourseName", "ViewCount", "ExampleImgPath", "TeachingSolutionName", "IdTeacher", "TeacherId", "TeacherName", "CollegeId", "CollegeName", "IdXzMajor", "MajorName", "GradeBaseId", "GradeBaseName", "GradeBaseNameA", "CourseTypeId", "CourseTypeName", "CurrStuNumValid", "CurrStuNum", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "TeachingSolutionId", "IdXzCollege", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "IsCompleteScore", "IdExecPlan", "LessonQtyPerWeek", "Mark", "CheckClassRoom", "CheckAdminCls", "CheckTeacher", "EditLocked", "Sched", "IdUniZone", "Locked", "IdGradeBase", "IsEffective", "IsForPaperReading", "IsUnDeterminedClsRm", "SchoolYear", "SchoolTerm", "ArrangeCourseMemo", "IdCourseType", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IdExamType", "ExamPortion", "MidExamScorePortion", "IsClearScore", "IsGeneratePwd", "GeneratePwdDate", "PkWeekTime", "PkClassRooms", "BeginWeek", "TeacherNames", "IsSynch", "SynchDate", "ModifyDate", "ModifyUserId", "Memo", "SignInDate", "SignInStateID", "SignInUser", "SynchToWebUser", "IsSynchToWeb", "SynchToWebDate"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrEduClsTypeName;    //教学班类型名称
protected string mstrCourseCode;    //课程代码
protected string mstrCourseDescription;    //课程描述
protected string mstrCourseName;    //课程名称
protected int? mintViewCount;    //浏览量
protected string mstrExampleImgPath;    //示例图路径
protected string mstrTeachingSolutionName;    //教学方案名称
protected string mstrIdTeacher;    //教师流水号
protected string mstrTeacherId;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrGradeBaseId;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected string mstrGradeBaseNameA;    //年级名称缩写
protected string mstrCourseTypeId;    //课程类型ID
protected string mstrCourseTypeName;    //课程类型名称
protected int? mintCurrStuNumValid;    //CurrStuNum_Valid
protected int? mintCurrStuNum;    //当前学生数
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrCourseId;    //课程Id
protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdEduWay;    //教学方式流水号
protected string mstrIdClassRoomType;    //教室类型流水号
protected int mintTotalLessonQty;    //总课时数
protected int? mintMaxStuQty;    //最大学生数
protected int? mintWeekQty;    //总周数
protected short? mshtScheUnitPW;    //周排课次数
protected string mstrWeekStatusId;    //周状态编号(单,双,全周)
protected string mstrCustomerWeek;    //自定义上课周
protected bool mbolIsCompleteScore;    //是否成绩齐全
protected string mstrIdExecPlan;    //执行计划流水号
protected short mshtLessonQtyPerWeek;    //周课时数
protected double? mdblMark;    //获得学分
protected string mstrCheckClassRoom;    //检查教室结果
protected string mstrCheckAdminCls;    //检查行政班结果
protected string mstrCheckTeacher;    //检查教师结果
protected bool mbolEditLocked;    //编辑锁定
protected bool mbolSched;    //是否排课
protected string mstrIdUniZone;    //校区流水号
protected bool mbolLocked;    //锁定状态
protected string mstrIdGradeBase;    //年级流水号
protected bool mbolIsEffective;    //是否有效
protected bool mbolIsForPaperReading;    //是否参与论文阅读
protected bool mbolIsUnDeterminedClsRm;    //是否待定教室
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrArrangeCourseMemo;    //排课备注
protected string mstrIdCourseType;    //课程类型流水号
protected bool mbolIsDegree;    //是否学位课
protected string mstrIdScoreType;    //成绩类型流水号
protected string mstrGetScoreWayId;    //获得成绩方式Id
protected bool mbolIsProportionalCtrl;    //是否比例控制
protected string mstrIdExamType;    //考试方式流水号
protected short mshtExamPortion;    //平时成绩所占比例
protected short? mshtMidExamScorePortion;    //期末成绩所占比例
protected bool mbolIsClearScore;    //是否重录成绩
protected bool mbolIsGeneratePwd;    //是否生成口令
protected string mstrGeneratePwdDate;    //生成口令时间
protected string mstrPkWeekTime;    //排课时间
protected string mstrPkClassRooms;    //排课教室
protected short? mshtBeginWeek;    //开始周
protected string mstrTeacherNames;    //教师姓名
protected bool mbolIsSynch;    //是否同步
protected string mstrSynchDate;    //同步日期
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注
protected string mstrSignInDate;    //签入时间
protected string mstrSignInStateID;    //签入状态表流水号
protected string mstrSignInUser;    //签入人
protected string mstrSynchToWebUser;    //同步Web用户
protected bool mbolIsSynchToWeb;    //是否同步Web
protected string mstrSynchToWebDate;    //同步Web日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCurrEduCls_SynEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCurrEduCls">关键字:教学班流水号</param>
public clsvCurrEduCls_SynEN(string strIdCurrEduCls)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:vCurrEduCls_Syn中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:vCurrEduCls_Syn中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCurrEduCls = strIdCurrEduCls;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
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
if (strAttributeName  ==  convCurrEduCls_Syn.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.EduClsTypeName)
{
return mstrEduClsTypeName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseDescription)
{
return mstrCourseDescription;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ExampleImgPath)
{
return mstrExampleImgPath;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeachingSolutionName)
{
return mstrTeachingSolutionName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GradeBaseId)
{
return mstrGradeBaseId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GradeBaseNameA)
{
return mstrGradeBaseNameA;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseTypeName)
{
return mstrCourseTypeName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CurrStuNumValid)
{
return mintCurrStuNumValid;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CurrStuNum)
{
return mintCurrStuNum;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdEduWay)
{
return mstrIdEduWay;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdClassRoomType)
{
return mstrIdClassRoomType;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TotalLessonQty)
{
return mintTotalLessonQty;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.MaxStuQty)
{
return mintMaxStuQty;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.WeekQty)
{
return mintWeekQty;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ScheUnitPW)
{
return mshtScheUnitPW;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.WeekStatusId)
{
return mstrWeekStatusId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CustomerWeek)
{
return mstrCustomerWeek;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsCompleteScore)
{
return mbolIsCompleteScore;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdExecPlan)
{
return mstrIdExecPlan;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.LessonQtyPerWeek)
{
return mshtLessonQtyPerWeek;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.Mark)
{
return mdblMark;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CheckClassRoom)
{
return mstrCheckClassRoom;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CheckAdminCls)
{
return mstrCheckAdminCls;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CheckTeacher)
{
return mstrCheckTeacher;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.EditLocked)
{
return mbolEditLocked;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.Sched)
{
return mbolSched;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.Locked)
{
return mbolLocked;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsForPaperReading)
{
return mbolIsForPaperReading;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsUnDeterminedClsRm)
{
return mbolIsUnDeterminedClsRm;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ArrangeCourseMemo)
{
return mstrArrangeCourseMemo;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdCourseType)
{
return mstrIdCourseType;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsDegree)
{
return mbolIsDegree;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdScoreType)
{
return mstrIdScoreType;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GetScoreWayId)
{
return mstrGetScoreWayId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsProportionalCtrl)
{
return mbolIsProportionalCtrl;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdExamType)
{
return mstrIdExamType;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ExamPortion)
{
return mshtExamPortion;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.MidExamScorePortion)
{
return mshtMidExamScorePortion;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsClearScore)
{
return mbolIsClearScore;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsGeneratePwd)
{
return mbolIsGeneratePwd;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GeneratePwdDate)
{
return mstrGeneratePwdDate;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.PkWeekTime)
{
return mstrPkWeekTime;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.PkClassRooms)
{
return mstrPkClassRooms;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.BeginWeek)
{
return mshtBeginWeek;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeacherNames)
{
return mstrTeacherNames;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsSynch)
{
return mbolIsSynch;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SynchDate)
{
return mstrSynchDate;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SignInDate)
{
return mstrSignInDate;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SignInStateID)
{
return mstrSignInStateID;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SignInUser)
{
return mstrSignInUser;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SynchToWebUser)
{
return mstrSynchToWebUser;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsSynchToWeb)
{
return mbolIsSynchToWeb;
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SynchToWebDate)
{
return mstrSynchToWebDate;
}
return null;
}
set
{
if (strAttributeName  ==  convCurrEduCls_Syn.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdCurrEduCls);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.EduClsTypeName)
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.EduClsTypeName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseCode);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseDescription)
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseDescription);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.ViewCount);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ExampleImgPath)
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.ExampleImgPath);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeachingSolutionName)
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeachingSolutionName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdTeacher);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeacherId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeacherName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CollegeId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CollegeName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdXzMajor);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.MajorName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GradeBaseId)
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GradeBaseNameA)
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseNameA);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseTypeId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseTypeName)
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseTypeName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CurrStuNumValid)
{
mintCurrStuNumValid = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.CurrStuNumValid);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CurrStuNum)
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.CurrStuNum);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CurrEduClsId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.EduClsName);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.EduClsTypeId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeachingSolutionId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdXzCollege);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdEduWay)
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdEduWay);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdClassRoomType)
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdClassRoomType);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TotalLessonQty)
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.TotalLessonQty);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.MaxStuQty)
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.MaxStuQty);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.WeekQty)
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.WeekQty);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ScheUnitPW)
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.ScheUnitPW);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.WeekStatusId)
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.WeekStatusId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CustomerWeek)
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CustomerWeek);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsCompleteScore)
{
mbolIsCompleteScore = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsCompleteScore);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdExecPlan)
{
mstrIdExecPlan = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdExecPlan);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.LessonQtyPerWeek)
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.LessonQtyPerWeek);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.Mark)
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.Mark);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CheckClassRoom)
{
mstrCheckClassRoom = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CheckClassRoom);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CheckAdminCls)
{
mstrCheckAdminCls = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CheckAdminCls);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.CheckTeacher)
{
mstrCheckTeacher = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CheckTeacher);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.EditLocked)
{
mbolEditLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.EditLocked);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.Sched)
{
mbolSched = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.Sched);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdUniZone);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.Locked)
{
mbolLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.Locked);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdGradeBase);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsEffective);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsForPaperReading)
{
mbolIsForPaperReading = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsForPaperReading);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsUnDeterminedClsRm)
{
mbolIsUnDeterminedClsRm = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsUnDeterminedClsRm);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SchoolYear);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SchoolTerm);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ArrangeCourseMemo)
{
mstrArrangeCourseMemo = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.ArrangeCourseMemo);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdCourseType)
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdCourseType);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsDegree)
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsDegree);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdScoreType)
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdScoreType);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GetScoreWayId)
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GetScoreWayId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsProportionalCtrl)
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsProportionalCtrl);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IdExamType)
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdExamType);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ExamPortion)
{
mshtExamPortion = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.ExamPortion);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.MidExamScorePortion)
{
mshtMidExamScorePortion = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.MidExamScorePortion);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsClearScore)
{
mbolIsClearScore = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsClearScore);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsGeneratePwd)
{
mbolIsGeneratePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsGeneratePwd);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.GeneratePwdDate)
{
mstrGeneratePwdDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GeneratePwdDate);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.PkWeekTime)
{
mstrPkWeekTime = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.PkWeekTime);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.PkClassRooms)
{
mstrPkClassRooms = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.PkClassRooms);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.BeginWeek)
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.BeginWeek);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.TeacherNames)
{
mstrTeacherNames = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeacherNames);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsSynch)
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsSynch);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SynchDate)
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SynchDate);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.ModifyDate);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.ModifyUserId);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.Memo);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SignInDate)
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SignInDate);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SignInStateID)
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SignInStateID);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SignInUser)
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SignInUser);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SynchToWebUser)
{
mstrSynchToWebUser = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SynchToWebUser);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.IsSynchToWeb)
{
mbolIsSynchToWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsSynchToWeb);
}
else if (strAttributeName  ==  convCurrEduCls_Syn.SynchToWebDate)
{
mstrSynchToWebDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SynchToWebDate);
}
}
}
public object this[int intIndex]
{
get
{
if (convCurrEduCls_Syn.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convCurrEduCls_Syn.EduClsTypeName  ==  AttributeName[intIndex])
{
return mstrEduClsTypeName;
}
else if (convCurrEduCls_Syn.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCurrEduCls_Syn.CourseDescription  ==  AttributeName[intIndex])
{
return mstrCourseDescription;
}
else if (convCurrEduCls_Syn.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCurrEduCls_Syn.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convCurrEduCls_Syn.ExampleImgPath  ==  AttributeName[intIndex])
{
return mstrExampleImgPath;
}
else if (convCurrEduCls_Syn.TeachingSolutionName  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionName;
}
else if (convCurrEduCls_Syn.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (convCurrEduCls_Syn.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (convCurrEduCls_Syn.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convCurrEduCls_Syn.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convCurrEduCls_Syn.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCurrEduCls_Syn.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCurrEduCls_Syn.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCurrEduCls_Syn.GradeBaseId  ==  AttributeName[intIndex])
{
return mstrGradeBaseId;
}
else if (convCurrEduCls_Syn.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convCurrEduCls_Syn.GradeBaseNameA  ==  AttributeName[intIndex])
{
return mstrGradeBaseNameA;
}
else if (convCurrEduCls_Syn.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (convCurrEduCls_Syn.CourseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseTypeName;
}
else if (convCurrEduCls_Syn.CurrStuNumValid  ==  AttributeName[intIndex])
{
return mintCurrStuNumValid;
}
else if (convCurrEduCls_Syn.CurrStuNum  ==  AttributeName[intIndex])
{
return mintCurrStuNum;
}
else if (convCurrEduCls_Syn.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convCurrEduCls_Syn.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convCurrEduCls_Syn.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (convCurrEduCls_Syn.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCurrEduCls_Syn.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (convCurrEduCls_Syn.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCurrEduCls_Syn.IdEduWay  ==  AttributeName[intIndex])
{
return mstrIdEduWay;
}
else if (convCurrEduCls_Syn.IdClassRoomType  ==  AttributeName[intIndex])
{
return mstrIdClassRoomType;
}
else if (convCurrEduCls_Syn.TotalLessonQty  ==  AttributeName[intIndex])
{
return mintTotalLessonQty;
}
else if (convCurrEduCls_Syn.MaxStuQty  ==  AttributeName[intIndex])
{
return mintMaxStuQty;
}
else if (convCurrEduCls_Syn.WeekQty  ==  AttributeName[intIndex])
{
return mintWeekQty;
}
else if (convCurrEduCls_Syn.ScheUnitPW  ==  AttributeName[intIndex])
{
return mshtScheUnitPW;
}
else if (convCurrEduCls_Syn.WeekStatusId  ==  AttributeName[intIndex])
{
return mstrWeekStatusId;
}
else if (convCurrEduCls_Syn.CustomerWeek  ==  AttributeName[intIndex])
{
return mstrCustomerWeek;
}
else if (convCurrEduCls_Syn.IsCompleteScore  ==  AttributeName[intIndex])
{
return mbolIsCompleteScore;
}
else if (convCurrEduCls_Syn.IdExecPlan  ==  AttributeName[intIndex])
{
return mstrIdExecPlan;
}
else if (convCurrEduCls_Syn.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
return mshtLessonQtyPerWeek;
}
else if (convCurrEduCls_Syn.Mark  ==  AttributeName[intIndex])
{
return mdblMark;
}
else if (convCurrEduCls_Syn.CheckClassRoom  ==  AttributeName[intIndex])
{
return mstrCheckClassRoom;
}
else if (convCurrEduCls_Syn.CheckAdminCls  ==  AttributeName[intIndex])
{
return mstrCheckAdminCls;
}
else if (convCurrEduCls_Syn.CheckTeacher  ==  AttributeName[intIndex])
{
return mstrCheckTeacher;
}
else if (convCurrEduCls_Syn.EditLocked  ==  AttributeName[intIndex])
{
return mbolEditLocked;
}
else if (convCurrEduCls_Syn.Sched  ==  AttributeName[intIndex])
{
return mbolSched;
}
else if (convCurrEduCls_Syn.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (convCurrEduCls_Syn.Locked  ==  AttributeName[intIndex])
{
return mbolLocked;
}
else if (convCurrEduCls_Syn.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convCurrEduCls_Syn.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (convCurrEduCls_Syn.IsForPaperReading  ==  AttributeName[intIndex])
{
return mbolIsForPaperReading;
}
else if (convCurrEduCls_Syn.IsUnDeterminedClsRm  ==  AttributeName[intIndex])
{
return mbolIsUnDeterminedClsRm;
}
else if (convCurrEduCls_Syn.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convCurrEduCls_Syn.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convCurrEduCls_Syn.ArrangeCourseMemo  ==  AttributeName[intIndex])
{
return mstrArrangeCourseMemo;
}
else if (convCurrEduCls_Syn.IdCourseType  ==  AttributeName[intIndex])
{
return mstrIdCourseType;
}
else if (convCurrEduCls_Syn.IsDegree  ==  AttributeName[intIndex])
{
return mbolIsDegree;
}
else if (convCurrEduCls_Syn.IdScoreType  ==  AttributeName[intIndex])
{
return mstrIdScoreType;
}
else if (convCurrEduCls_Syn.GetScoreWayId  ==  AttributeName[intIndex])
{
return mstrGetScoreWayId;
}
else if (convCurrEduCls_Syn.IsProportionalCtrl  ==  AttributeName[intIndex])
{
return mbolIsProportionalCtrl;
}
else if (convCurrEduCls_Syn.IdExamType  ==  AttributeName[intIndex])
{
return mstrIdExamType;
}
else if (convCurrEduCls_Syn.ExamPortion  ==  AttributeName[intIndex])
{
return mshtExamPortion;
}
else if (convCurrEduCls_Syn.MidExamScorePortion  ==  AttributeName[intIndex])
{
return mshtMidExamScorePortion;
}
else if (convCurrEduCls_Syn.IsClearScore  ==  AttributeName[intIndex])
{
return mbolIsClearScore;
}
else if (convCurrEduCls_Syn.IsGeneratePwd  ==  AttributeName[intIndex])
{
return mbolIsGeneratePwd;
}
else if (convCurrEduCls_Syn.GeneratePwdDate  ==  AttributeName[intIndex])
{
return mstrGeneratePwdDate;
}
else if (convCurrEduCls_Syn.PkWeekTime  ==  AttributeName[intIndex])
{
return mstrPkWeekTime;
}
else if (convCurrEduCls_Syn.PkClassRooms  ==  AttributeName[intIndex])
{
return mstrPkClassRooms;
}
else if (convCurrEduCls_Syn.BeginWeek  ==  AttributeName[intIndex])
{
return mshtBeginWeek;
}
else if (convCurrEduCls_Syn.TeacherNames  ==  AttributeName[intIndex])
{
return mstrTeacherNames;
}
else if (convCurrEduCls_Syn.IsSynch  ==  AttributeName[intIndex])
{
return mbolIsSynch;
}
else if (convCurrEduCls_Syn.SynchDate  ==  AttributeName[intIndex])
{
return mstrSynchDate;
}
else if (convCurrEduCls_Syn.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convCurrEduCls_Syn.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convCurrEduCls_Syn.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCurrEduCls_Syn.SignInDate  ==  AttributeName[intIndex])
{
return mstrSignInDate;
}
else if (convCurrEduCls_Syn.SignInStateID  ==  AttributeName[intIndex])
{
return mstrSignInStateID;
}
else if (convCurrEduCls_Syn.SignInUser  ==  AttributeName[intIndex])
{
return mstrSignInUser;
}
else if (convCurrEduCls_Syn.SynchToWebUser  ==  AttributeName[intIndex])
{
return mstrSynchToWebUser;
}
else if (convCurrEduCls_Syn.IsSynchToWeb  ==  AttributeName[intIndex])
{
return mbolIsSynchToWeb;
}
else if (convCurrEduCls_Syn.SynchToWebDate  ==  AttributeName[intIndex])
{
return mstrSynchToWebDate;
}
return null;
}
set
{
if (convCurrEduCls_Syn.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdCurrEduCls);
}
else if (convCurrEduCls_Syn.EduClsTypeName  ==  AttributeName[intIndex])
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.EduClsTypeName);
}
else if (convCurrEduCls_Syn.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseCode);
}
else if (convCurrEduCls_Syn.CourseDescription  ==  AttributeName[intIndex])
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseDescription);
}
else if (convCurrEduCls_Syn.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseName);
}
else if (convCurrEduCls_Syn.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.ViewCount);
}
else if (convCurrEduCls_Syn.ExampleImgPath  ==  AttributeName[intIndex])
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.ExampleImgPath);
}
else if (convCurrEduCls_Syn.TeachingSolutionName  ==  AttributeName[intIndex])
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeachingSolutionName);
}
else if (convCurrEduCls_Syn.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdTeacher);
}
else if (convCurrEduCls_Syn.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeacherId);
}
else if (convCurrEduCls_Syn.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeacherName);
}
else if (convCurrEduCls_Syn.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CollegeId);
}
else if (convCurrEduCls_Syn.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CollegeName);
}
else if (convCurrEduCls_Syn.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdXzMajor);
}
else if (convCurrEduCls_Syn.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.MajorName);
}
else if (convCurrEduCls_Syn.GradeBaseId  ==  AttributeName[intIndex])
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseId);
}
else if (convCurrEduCls_Syn.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseName);
}
else if (convCurrEduCls_Syn.GradeBaseNameA  ==  AttributeName[intIndex])
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseNameA);
}
else if (convCurrEduCls_Syn.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseTypeId);
}
else if (convCurrEduCls_Syn.CourseTypeName  ==  AttributeName[intIndex])
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseTypeName);
}
else if (convCurrEduCls_Syn.CurrStuNumValid  ==  AttributeName[intIndex])
{
mintCurrStuNumValid = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.CurrStuNumValid);
}
else if (convCurrEduCls_Syn.CurrStuNum  ==  AttributeName[intIndex])
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.CurrStuNum);
}
else if (convCurrEduCls_Syn.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CurrEduClsId);
}
else if (convCurrEduCls_Syn.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.EduClsName);
}
else if (convCurrEduCls_Syn.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.EduClsTypeId);
}
else if (convCurrEduCls_Syn.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CourseId);
}
else if (convCurrEduCls_Syn.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeachingSolutionId);
}
else if (convCurrEduCls_Syn.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdXzCollege);
}
else if (convCurrEduCls_Syn.IdEduWay  ==  AttributeName[intIndex])
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdEduWay);
}
else if (convCurrEduCls_Syn.IdClassRoomType  ==  AttributeName[intIndex])
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdClassRoomType);
}
else if (convCurrEduCls_Syn.TotalLessonQty  ==  AttributeName[intIndex])
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.TotalLessonQty);
}
else if (convCurrEduCls_Syn.MaxStuQty  ==  AttributeName[intIndex])
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.MaxStuQty);
}
else if (convCurrEduCls_Syn.WeekQty  ==  AttributeName[intIndex])
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.WeekQty);
}
else if (convCurrEduCls_Syn.ScheUnitPW  ==  AttributeName[intIndex])
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.ScheUnitPW);
}
else if (convCurrEduCls_Syn.WeekStatusId  ==  AttributeName[intIndex])
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.WeekStatusId);
}
else if (convCurrEduCls_Syn.CustomerWeek  ==  AttributeName[intIndex])
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CustomerWeek);
}
else if (convCurrEduCls_Syn.IsCompleteScore  ==  AttributeName[intIndex])
{
mbolIsCompleteScore = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsCompleteScore);
}
else if (convCurrEduCls_Syn.IdExecPlan  ==  AttributeName[intIndex])
{
mstrIdExecPlan = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdExecPlan);
}
else if (convCurrEduCls_Syn.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.LessonQtyPerWeek);
}
else if (convCurrEduCls_Syn.Mark  ==  AttributeName[intIndex])
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.Mark);
}
else if (convCurrEduCls_Syn.CheckClassRoom  ==  AttributeName[intIndex])
{
mstrCheckClassRoom = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CheckClassRoom);
}
else if (convCurrEduCls_Syn.CheckAdminCls  ==  AttributeName[intIndex])
{
mstrCheckAdminCls = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CheckAdminCls);
}
else if (convCurrEduCls_Syn.CheckTeacher  ==  AttributeName[intIndex])
{
mstrCheckTeacher = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.CheckTeacher);
}
else if (convCurrEduCls_Syn.EditLocked  ==  AttributeName[intIndex])
{
mbolEditLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.EditLocked);
}
else if (convCurrEduCls_Syn.Sched  ==  AttributeName[intIndex])
{
mbolSched = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.Sched);
}
else if (convCurrEduCls_Syn.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdUniZone);
}
else if (convCurrEduCls_Syn.Locked  ==  AttributeName[intIndex])
{
mbolLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.Locked);
}
else if (convCurrEduCls_Syn.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdGradeBase);
}
else if (convCurrEduCls_Syn.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsEffective);
}
else if (convCurrEduCls_Syn.IsForPaperReading  ==  AttributeName[intIndex])
{
mbolIsForPaperReading = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsForPaperReading);
}
else if (convCurrEduCls_Syn.IsUnDeterminedClsRm  ==  AttributeName[intIndex])
{
mbolIsUnDeterminedClsRm = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsUnDeterminedClsRm);
}
else if (convCurrEduCls_Syn.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SchoolYear);
}
else if (convCurrEduCls_Syn.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SchoolTerm);
}
else if (convCurrEduCls_Syn.ArrangeCourseMemo  ==  AttributeName[intIndex])
{
mstrArrangeCourseMemo = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.ArrangeCourseMemo);
}
else if (convCurrEduCls_Syn.IdCourseType  ==  AttributeName[intIndex])
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdCourseType);
}
else if (convCurrEduCls_Syn.IsDegree  ==  AttributeName[intIndex])
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsDegree);
}
else if (convCurrEduCls_Syn.IdScoreType  ==  AttributeName[intIndex])
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdScoreType);
}
else if (convCurrEduCls_Syn.GetScoreWayId  ==  AttributeName[intIndex])
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GetScoreWayId);
}
else if (convCurrEduCls_Syn.IsProportionalCtrl  ==  AttributeName[intIndex])
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsProportionalCtrl);
}
else if (convCurrEduCls_Syn.IdExamType  ==  AttributeName[intIndex])
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.IdExamType);
}
else if (convCurrEduCls_Syn.ExamPortion  ==  AttributeName[intIndex])
{
mshtExamPortion = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.ExamPortion);
}
else if (convCurrEduCls_Syn.MidExamScorePortion  ==  AttributeName[intIndex])
{
mshtMidExamScorePortion = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.MidExamScorePortion);
}
else if (convCurrEduCls_Syn.IsClearScore  ==  AttributeName[intIndex])
{
mbolIsClearScore = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsClearScore);
}
else if (convCurrEduCls_Syn.IsGeneratePwd  ==  AttributeName[intIndex])
{
mbolIsGeneratePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsGeneratePwd);
}
else if (convCurrEduCls_Syn.GeneratePwdDate  ==  AttributeName[intIndex])
{
mstrGeneratePwdDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.GeneratePwdDate);
}
else if (convCurrEduCls_Syn.PkWeekTime  ==  AttributeName[intIndex])
{
mstrPkWeekTime = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.PkWeekTime);
}
else if (convCurrEduCls_Syn.PkClassRooms  ==  AttributeName[intIndex])
{
mstrPkClassRooms = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.PkClassRooms);
}
else if (convCurrEduCls_Syn.BeginWeek  ==  AttributeName[intIndex])
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.BeginWeek);
}
else if (convCurrEduCls_Syn.TeacherNames  ==  AttributeName[intIndex])
{
mstrTeacherNames = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.TeacherNames);
}
else if (convCurrEduCls_Syn.IsSynch  ==  AttributeName[intIndex])
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsSynch);
}
else if (convCurrEduCls_Syn.SynchDate  ==  AttributeName[intIndex])
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SynchDate);
}
else if (convCurrEduCls_Syn.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.ModifyDate);
}
else if (convCurrEduCls_Syn.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.ModifyUserId);
}
else if (convCurrEduCls_Syn.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.Memo);
}
else if (convCurrEduCls_Syn.SignInDate  ==  AttributeName[intIndex])
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SignInDate);
}
else if (convCurrEduCls_Syn.SignInStateID  ==  AttributeName[intIndex])
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SignInStateID);
}
else if (convCurrEduCls_Syn.SignInUser  ==  AttributeName[intIndex])
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SignInUser);
}
else if (convCurrEduCls_Syn.SynchToWebUser  ==  AttributeName[intIndex])
{
mstrSynchToWebUser = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SynchToWebUser);
}
else if (convCurrEduCls_Syn.IsSynchToWeb  ==  AttributeName[intIndex])
{
mbolIsSynchToWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls_Syn.IsSynchToWeb);
}
else if (convCurrEduCls_Syn.SynchToWebDate  ==  AttributeName[intIndex])
{
mstrSynchToWebDate = value.ToString();
 AddUpdatedFld(convCurrEduCls_Syn.SynchToWebDate);
}
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
 AddUpdatedFld(convCurrEduCls_Syn.IdCurrEduCls);
}
}
/// <summary>
/// 教学班类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTypeName
{
get
{
return mstrEduClsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTypeName = value;
}
else
{
 mstrEduClsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.EduClsTypeName);
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
 AddUpdatedFld(convCurrEduCls_Syn.CourseCode);
}
}
/// <summary>
/// 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseDescription
{
get
{
return mstrCourseDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseDescription = value;
}
else
{
 mstrCourseDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CourseDescription);
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
 AddUpdatedFld(convCurrEduCls_Syn.CourseName);
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
 AddUpdatedFld(convCurrEduCls_Syn.ViewCount);
}
}
/// <summary>
/// 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExampleImgPath
{
get
{
return mstrExampleImgPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExampleImgPath = value;
}
else
{
 mstrExampleImgPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.ExampleImgPath);
}
}
/// <summary>
/// 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingSolutionName
{
get
{
return mstrTeachingSolutionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingSolutionName = value;
}
else
{
 mstrTeachingSolutionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.TeachingSolutionName);
}
}
/// <summary>
/// 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeacher
{
get
{
return mstrIdTeacher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeacher = value;
}
else
{
 mstrIdTeacher = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IdTeacher);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherId
{
get
{
return mstrTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherId = value;
}
else
{
 mstrTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.TeacherId);
}
}
/// <summary>
/// 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherName
{
get
{
return mstrTeacherName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherName = value;
}
else
{
 mstrTeacherName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.TeacherName);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CollegeId);
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
 AddUpdatedFld(convCurrEduCls_Syn.CollegeName);
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
 AddUpdatedFld(convCurrEduCls_Syn.IdXzMajor);
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
 AddUpdatedFld(convCurrEduCls_Syn.MajorName);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseId
{
get
{
return mstrGradeBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseId = value;
}
else
{
 mstrGradeBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseId);
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
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseName);
}
}
/// <summary>
/// 年级名称缩写(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseNameA
{
get
{
return mstrGradeBaseNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseNameA = value;
}
else
{
 mstrGradeBaseNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.GradeBaseNameA);
}
}
/// <summary>
/// 课程类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeId
{
get
{
return mstrCourseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeId = value;
}
else
{
 mstrCourseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CourseTypeId);
}
}
/// <summary>
/// 课程类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeName
{
get
{
return mstrCourseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeName = value;
}
else
{
 mstrCourseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CourseTypeName);
}
}
/// <summary>
/// CurrStuNum_Valid(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CurrStuNumValid
{
get
{
return mintCurrStuNumValid;
}
set
{
 mintCurrStuNumValid = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CurrStuNumValid);
}
}
/// <summary>
/// 当前学生数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CurrStuNum
{
get
{
return mintCurrStuNum;
}
set
{
 mintCurrStuNum = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CurrStuNum);
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
 AddUpdatedFld(convCurrEduCls_Syn.CurrEduClsId);
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
 AddUpdatedFld(convCurrEduCls_Syn.EduClsName);
}
}
/// <summary>
/// 教学班类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTypeId
{
get
{
return mstrEduClsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTypeId = value;
}
else
{
 mstrEduClsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.EduClsTypeId);
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
 AddUpdatedFld(convCurrEduCls_Syn.CourseId);
}
}
/// <summary>
/// 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingSolutionId
{
get
{
return mstrTeachingSolutionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingSolutionId = value;
}
else
{
 mstrTeachingSolutionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.TeachingSolutionId);
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
 AddUpdatedFld(convCurrEduCls_Syn.IdXzCollege);
}
}
/// <summary>
/// 教学方式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduWay
{
get
{
return mstrIdEduWay;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduWay = value;
}
else
{
 mstrIdEduWay = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IdEduWay);
}
}
/// <summary>
/// 教室类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdClassRoomType
{
get
{
return mstrIdClassRoomType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdClassRoomType = value;
}
else
{
 mstrIdClassRoomType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IdClassRoomType);
}
}
/// <summary>
/// 总课时数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int TotalLessonQty
{
get
{
return mintTotalLessonQty;
}
set
{
 mintTotalLessonQty = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.TotalLessonQty);
}
}
/// <summary>
/// 最大学生数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? MaxStuQty
{
get
{
return mintMaxStuQty;
}
set
{
 mintMaxStuQty = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.MaxStuQty);
}
}
/// <summary>
/// 总周数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WeekQty
{
get
{
return mintWeekQty;
}
set
{
 mintWeekQty = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.WeekQty);
}
}
/// <summary>
/// 周排课次数(说明:;字段类型:smallint;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short? ScheUnitPW
{
get
{
return mshtScheUnitPW;
}
set
{
 mshtScheUnitPW = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.ScheUnitPW);
}
}
/// <summary>
/// 周状态编号(单,双,全周)(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WeekStatusId
{
get
{
return mstrWeekStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWeekStatusId = value;
}
else
{
 mstrWeekStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.WeekStatusId);
}
}
/// <summary>
/// 自定义上课周(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CustomerWeek
{
get
{
return mstrCustomerWeek;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCustomerWeek = value;
}
else
{
 mstrCustomerWeek = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CustomerWeek);
}
}
/// <summary>
/// 是否成绩齐全(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCompleteScore
{
get
{
return mbolIsCompleteScore;
}
set
{
 mbolIsCompleteScore = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsCompleteScore);
}
}
/// <summary>
/// 执行计划流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdExecPlan
{
get
{
return mstrIdExecPlan;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdExecPlan = value;
}
else
{
 mstrIdExecPlan = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IdExecPlan);
}
}
/// <summary>
/// 周课时数(说明:;字段类型:smallint;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short LessonQtyPerWeek
{
get
{
return mshtLessonQtyPerWeek;
}
set
{
 mshtLessonQtyPerWeek = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.LessonQtyPerWeek);
}
}
/// <summary>
/// 获得学分(说明:;字段类型:decimal;字段长度:7;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Mark
{
get
{
return mdblMark;
}
set
{
 mdblMark = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.Mark);
}
}
/// <summary>
/// 检查教室结果(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckClassRoom
{
get
{
return mstrCheckClassRoom;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckClassRoom = value;
}
else
{
 mstrCheckClassRoom = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CheckClassRoom);
}
}
/// <summary>
/// 检查行政班结果(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckAdminCls
{
get
{
return mstrCheckAdminCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckAdminCls = value;
}
else
{
 mstrCheckAdminCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CheckAdminCls);
}
}
/// <summary>
/// 检查教师结果(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckTeacher
{
get
{
return mstrCheckTeacher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckTeacher = value;
}
else
{
 mstrCheckTeacher = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.CheckTeacher);
}
}
/// <summary>
/// 编辑锁定(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool EditLocked
{
get
{
return mbolEditLocked;
}
set
{
 mbolEditLocked = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.EditLocked);
}
}
/// <summary>
/// 是否排课(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Sched
{
get
{
return mbolSched;
}
set
{
 mbolSched = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.Sched);
}
}
/// <summary>
/// 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUniZone
{
get
{
return mstrIdUniZone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUniZone = value;
}
else
{
 mstrIdUniZone = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IdUniZone);
}
}
/// <summary>
/// 锁定状态(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Locked
{
get
{
return mbolLocked;
}
set
{
 mbolLocked = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.Locked);
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
 AddUpdatedFld(convCurrEduCls_Syn.IdGradeBase);
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
 AddUpdatedFld(convCurrEduCls_Syn.IsEffective);
}
}
/// <summary>
/// 是否参与论文阅读(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForPaperReading
{
get
{
return mbolIsForPaperReading;
}
set
{
 mbolIsForPaperReading = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsForPaperReading);
}
}
/// <summary>
/// 是否待定教室(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUnDeterminedClsRm
{
get
{
return mbolIsUnDeterminedClsRm;
}
set
{
 mbolIsUnDeterminedClsRm = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsUnDeterminedClsRm);
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
 AddUpdatedFld(convCurrEduCls_Syn.SchoolYear);
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
 AddUpdatedFld(convCurrEduCls_Syn.SchoolTerm);
}
}
/// <summary>
/// 排课备注(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ArrangeCourseMemo
{
get
{
return mstrArrangeCourseMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrArrangeCourseMemo = value;
}
else
{
 mstrArrangeCourseMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.ArrangeCourseMemo);
}
}
/// <summary>
/// 课程类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourseType
{
get
{
return mstrIdCourseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourseType = value;
}
else
{
 mstrIdCourseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IdCourseType);
}
}
/// <summary>
/// 是否学位课(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDegree
{
get
{
return mbolIsDegree;
}
set
{
 mbolIsDegree = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsDegree);
}
}
/// <summary>
/// 成绩类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdScoreType
{
get
{
return mstrIdScoreType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdScoreType = value;
}
else
{
 mstrIdScoreType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IdScoreType);
}
}
/// <summary>
/// 获得成绩方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GetScoreWayId
{
get
{
return mstrGetScoreWayId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGetScoreWayId = value;
}
else
{
 mstrGetScoreWayId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.GetScoreWayId);
}
}
/// <summary>
/// 是否比例控制(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsProportionalCtrl
{
get
{
return mbolIsProportionalCtrl;
}
set
{
 mbolIsProportionalCtrl = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsProportionalCtrl);
}
}
/// <summary>
/// 考试方式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdExamType
{
get
{
return mstrIdExamType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdExamType = value;
}
else
{
 mstrIdExamType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IdExamType);
}
}
/// <summary>
/// 平时成绩所占比例(说明:;字段类型:smallint;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short ExamPortion
{
get
{
return mshtExamPortion;
}
set
{
 mshtExamPortion = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.ExamPortion);
}
}
/// <summary>
/// 期末成绩所占比例(说明:;字段类型:smallint;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short? MidExamScorePortion
{
get
{
return mshtMidExamScorePortion;
}
set
{
 mshtMidExamScorePortion = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.MidExamScorePortion);
}
}
/// <summary>
/// 是否重录成绩(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsClearScore
{
get
{
return mbolIsClearScore;
}
set
{
 mbolIsClearScore = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsClearScore);
}
}
/// <summary>
/// 是否生成口令(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneratePwd
{
get
{
return mbolIsGeneratePwd;
}
set
{
 mbolIsGeneratePwd = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsGeneratePwd);
}
}
/// <summary>
/// 生成口令时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GeneratePwdDate
{
get
{
return mstrGeneratePwdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGeneratePwdDate = value;
}
else
{
 mstrGeneratePwdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.GeneratePwdDate);
}
}
/// <summary>
/// 排课时间(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PkWeekTime
{
get
{
return mstrPkWeekTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPkWeekTime = value;
}
else
{
 mstrPkWeekTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.PkWeekTime);
}
}
/// <summary>
/// 排课教室(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PkClassRooms
{
get
{
return mstrPkClassRooms;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPkClassRooms = value;
}
else
{
 mstrPkClassRooms = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.PkClassRooms);
}
}
/// <summary>
/// 开始周(说明:;字段类型:smallint;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short? BeginWeek
{
get
{
return mshtBeginWeek;
}
set
{
 mshtBeginWeek = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.BeginWeek);
}
}
/// <summary>
/// 教师姓名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherNames
{
get
{
return mstrTeacherNames;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherNames = value;
}
else
{
 mstrTeacherNames = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.TeacherNames);
}
}
/// <summary>
/// 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynch
{
get
{
return mbolIsSynch;
}
set
{
 mbolIsSynch = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsSynch);
}
}
/// <summary>
/// 同步日期(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchDate
{
get
{
return mstrSynchDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchDate = value;
}
else
{
 mstrSynchDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.SynchDate);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.ModifyUserId);
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
 AddUpdatedFld(convCurrEduCls_Syn.Memo);
}
}
/// <summary>
/// 签入时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SignInDate
{
get
{
return mstrSignInDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSignInDate = value;
}
else
{
 mstrSignInDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.SignInDate);
}
}
/// <summary>
/// 签入状态表流水号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SignInStateID
{
get
{
return mstrSignInStateID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSignInStateID = value;
}
else
{
 mstrSignInStateID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.SignInStateID);
}
}
/// <summary>
/// 签入人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SignInUser
{
get
{
return mstrSignInUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSignInUser = value;
}
else
{
 mstrSignInUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.SignInUser);
}
}
/// <summary>
/// 同步Web用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToWebUser
{
get
{
return mstrSynchToWebUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToWebUser = value;
}
else
{
 mstrSynchToWebUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.SynchToWebUser);
}
}
/// <summary>
/// 是否同步Web(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToWeb
{
get
{
return mbolIsSynchToWeb;
}
set
{
 mbolIsSynchToWeb = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.IsSynchToWeb);
}
}
/// <summary>
/// 同步Web日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToWebDate
{
get
{
return mstrSynchToWebDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToWebDate = value;
}
else
{
 mstrSynchToWebDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls_Syn.SynchToWebDate);
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
  return mstrIdCurrEduCls;
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
  return mstrCourseName;
 }
 }
}
 /// <summary>
 /// vCurrEduCls_Syn(vCurrEduCls_Syn)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCurrEduCls_Syn
{
public const string _CurrTabName = "vCurrEduCls_Syn"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "EduClsTypeName", "CourseCode", "CourseDescription", "CourseName", "ViewCount", "ExampleImgPath", "TeachingSolutionName", "IdTeacher", "TeacherId", "TeacherName", "CollegeId", "CollegeName", "IdXzMajor", "MajorName", "GradeBaseId", "GradeBaseName", "GradeBaseNameA", "CourseTypeId", "CourseTypeName", "CurrStuNumValid", "CurrStuNum", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "TeachingSolutionId", "IdXzCollege", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "IsCompleteScore", "IdExecPlan", "LessonQtyPerWeek", "Mark", "CheckClassRoom", "CheckAdminCls", "CheckTeacher", "EditLocked", "Sched", "IdUniZone", "Locked", "IdGradeBase", "IsEffective", "IsForPaperReading", "IsUnDeterminedClsRm", "SchoolYear", "SchoolTerm", "ArrangeCourseMemo", "IdCourseType", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IdExamType", "ExamPortion", "MidExamScorePortion", "IsClearScore", "IsGeneratePwd", "GeneratePwdDate", "PkWeekTime", "PkClassRooms", "BeginWeek", "TeacherNames", "IsSynch", "SynchDate", "ModifyDate", "ModifyUserId", "Memo", "SignInDate", "SignInStateID", "SignInUser", "SynchToWebUser", "IsSynchToWeb", "SynchToWebDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"EduClsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeName = "EduClsTypeName";    //教学班类型名称

 /// <summary>
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

 /// <summary>
 /// 常量:"CourseDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseDescription = "CourseDescription";    //课程描述

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"ExampleImgPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExampleImgPath = "ExampleImgPath";    //示例图路径

 /// <summary>
 /// 常量:"TeachingSolutionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionName = "TeachingSolutionName";    //教学方案名称

 /// <summary>
 /// 常量:"IdTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeacher = "IdTeacher";    //教师流水号

 /// <summary>
 /// 常量:"TeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherId = "TeacherId";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"GradeBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseId = "GradeBaseId";    //年级代号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"GradeBaseNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseNameA = "GradeBaseNameA";    //年级名称缩写

 /// <summary>
 /// 常量:"CourseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeId = "CourseTypeId";    //课程类型ID

 /// <summary>
 /// 常量:"CourseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeName = "CourseTypeName";    //课程类型名称

 /// <summary>
 /// 常量:"CurrStuNumValid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrStuNumValid = "CurrStuNumValid";    //CurrStuNum_Valid

 /// <summary>
 /// 常量:"CurrStuNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrStuNum = "CurrStuNum";    //当前学生数

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
 /// 常量:"EduClsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeId = "EduClsTypeId";    //教学班类型Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"TeachingSolutionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionId = "TeachingSolutionId";    //教学方案Id

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdEduWay"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduWay = "IdEduWay";    //教学方式流水号

 /// <summary>
 /// 常量:"IdClassRoomType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdClassRoomType = "IdClassRoomType";    //教室类型流水号

 /// <summary>
 /// 常量:"TotalLessonQty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalLessonQty = "TotalLessonQty";    //总课时数

 /// <summary>
 /// 常量:"MaxStuQty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MaxStuQty = "MaxStuQty";    //最大学生数

 /// <summary>
 /// 常量:"WeekQty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WeekQty = "WeekQty";    //总周数

 /// <summary>
 /// 常量:"ScheUnitPW"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScheUnitPW = "ScheUnitPW";    //周排课次数

 /// <summary>
 /// 常量:"WeekStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WeekStatusId = "WeekStatusId";    //周状态编号(单,双,全周)

 /// <summary>
 /// 常量:"CustomerWeek"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CustomerWeek = "CustomerWeek";    //自定义上课周

 /// <summary>
 /// 常量:"IsCompleteScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCompleteScore = "IsCompleteScore";    //是否成绩齐全

 /// <summary>
 /// 常量:"IdExecPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExecPlan = "IdExecPlan";    //执行计划流水号

 /// <summary>
 /// 常量:"LessonQtyPerWeek"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LessonQtyPerWeek = "LessonQtyPerWeek";    //周课时数

 /// <summary>
 /// 常量:"Mark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Mark = "Mark";    //获得学分

 /// <summary>
 /// 常量:"CheckClassRoom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckClassRoom = "CheckClassRoom";    //检查教室结果

 /// <summary>
 /// 常量:"CheckAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckAdminCls = "CheckAdminCls";    //检查行政班结果

 /// <summary>
 /// 常量:"CheckTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckTeacher = "CheckTeacher";    //检查教师结果

 /// <summary>
 /// 常量:"EditLocked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EditLocked = "EditLocked";    //编辑锁定

 /// <summary>
 /// 常量:"Sched"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Sched = "Sched";    //是否排课

 /// <summary>
 /// 常量:"IdUniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUniZone = "IdUniZone";    //校区流水号

 /// <summary>
 /// 常量:"Locked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Locked = "Locked";    //锁定状态

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"IsEffective"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEffective = "IsEffective";    //是否有效

 /// <summary>
 /// 常量:"IsForPaperReading"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForPaperReading = "IsForPaperReading";    //是否参与论文阅读

 /// <summary>
 /// 常量:"IsUnDeterminedClsRm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUnDeterminedClsRm = "IsUnDeterminedClsRm";    //是否待定教室

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
 /// 常量:"ArrangeCourseMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ArrangeCourseMemo = "ArrangeCourseMemo";    //排课备注

 /// <summary>
 /// 常量:"IdCourseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseType = "IdCourseType";    //课程类型流水号

 /// <summary>
 /// 常量:"IsDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDegree = "IsDegree";    //是否学位课

 /// <summary>
 /// 常量:"IdScoreType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdScoreType = "IdScoreType";    //成绩类型流水号

 /// <summary>
 /// 常量:"GetScoreWayId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetScoreWayId = "GetScoreWayId";    //获得成绩方式Id

 /// <summary>
 /// 常量:"IsProportionalCtrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsProportionalCtrl = "IsProportionalCtrl";    //是否比例控制

 /// <summary>
 /// 常量:"IdExamType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExamType = "IdExamType";    //考试方式流水号

 /// <summary>
 /// 常量:"ExamPortion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPortion = "ExamPortion";    //平时成绩所占比例

 /// <summary>
 /// 常量:"MidExamScorePortion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MidExamScorePortion = "MidExamScorePortion";    //期末成绩所占比例

 /// <summary>
 /// 常量:"IsClearScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsClearScore = "IsClearScore";    //是否重录成绩

 /// <summary>
 /// 常量:"IsGeneratePwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneratePwd = "IsGeneratePwd";    //是否生成口令

 /// <summary>
 /// 常量:"GeneratePwdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GeneratePwdDate = "GeneratePwdDate";    //生成口令时间

 /// <summary>
 /// 常量:"PkWeekTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PkWeekTime = "PkWeekTime";    //排课时间

 /// <summary>
 /// 常量:"PkClassRooms"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PkClassRooms = "PkClassRooms";    //排课教室

 /// <summary>
 /// 常量:"BeginWeek"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BeginWeek = "BeginWeek";    //开始周

 /// <summary>
 /// 常量:"TeacherNames"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherNames = "TeacherNames";    //教师姓名

 /// <summary>
 /// 常量:"IsSynch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynch = "IsSynch";    //是否同步

 /// <summary>
 /// 常量:"SynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchDate = "SynchDate";    //同步日期

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"SignInDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SignInDate = "SignInDate";    //签入时间

 /// <summary>
 /// 常量:"SignInStateID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SignInStateID = "SignInStateID";    //签入状态表流水号

 /// <summary>
 /// 常量:"SignInUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SignInUser = "SignInUser";    //签入人

 /// <summary>
 /// 常量:"SynchToWebUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToWebUser = "SynchToWebUser";    //同步Web用户

 /// <summary>
 /// 常量:"IsSynchToWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToWeb = "IsSynchToWeb";    //是否同步Web

 /// <summary>
 /// 常量:"SynchToWebDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToWebDate = "SynchToWebDate";    //同步Web日期
}

}