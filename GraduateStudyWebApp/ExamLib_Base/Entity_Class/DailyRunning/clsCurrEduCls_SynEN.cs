
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduCls_SynEN
 表名:CurrEduCls_Syn(01120927)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 表CurrEduCls_Syn的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_CurrEduCls_Syn
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
public K_IdCurrEduCls_CurrEduCls_Syn(string strIdCurrEduCls)
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
 /// <returns>返回:[K_IdCurrEduCls_CurrEduCls_Syn]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_CurrEduCls_Syn(string value)
{
return new K_IdCurrEduCls_CurrEduCls_Syn(value);
}
}
 /// <summary>
 /// 当前教学班_动态(CurrEduCls_Syn)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCurrEduCls_SynEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CurrEduCls_Syn"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 69;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "TeachingSolutionId", "IdXzCollege", "IdMajor", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "CurrentStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "IsCompleteScore", "IdExecPlan", "LessonQtyPerWeek", "Mark", "CheckClassRoom", "CheckAdminCls", "CheckTeacher", "EditLocked", "Sched", "IdUniZone", "Locked", "IdGradeBase", "IsEffective", "IsForPaperReading", "IsUnDeterminedClsRm", "SchoolYear", "SchoolTerm", "ArrangeCourseMemo", "IdCourseType", "ExportDate", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IdExamType", "ExamPortion", "MidExamScorePortion", "IsClearScore", "IsGeneratePwd", "GeneratePwdDate", "IsExportToGP", "IsExportToGPWeb", "IsReservedDecimal", "ExamTime", "CheckState", "CheckDate", "IdEduClassInPk", "PkWeekTime", "PkClassRooms", "BeginWeek", "TeacherNames", "IsSynch", "SynchDate", "ModifyDate", "ModifyUserId", "Memo", "SignInDate", "SignInStateID", "SignInUser", "SynchToWebUser", "IsSynchToWeb", "SynchToWebDate"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrCourseId;    //课程Id
protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdMajor;    //专业流水号
protected string mstrIdEduWay;    //教学方式流水号
protected string mstrIdClassRoomType;    //教室类型流水号
protected int? mintTotalLessonQty;    //总课时数
protected int? mintMaxStuQty;    //最大学生数
protected int? mintCurrentStuQty;    //当前学生数
protected int? mintWeekQty;    //总周数
protected short? mshtScheUnitPW;    //周排课次数
protected string mstrWeekStatusId;    //周状态编号(单,双,全周)
protected string mstrCustomerWeek;    //自定义上课周
protected bool mbolIsCompleteScore;    //是否成绩齐全
protected string mstrIdExecPlan;    //执行计划流水号
protected short? mshtLessonQtyPerWeek;    //周课时数
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
protected string mstrExportDate;    //导出日期
protected bool mbolIsDegree;    //是否学位课
protected string mstrIdScoreType;    //成绩类型流水号
protected string mstrGetScoreWayId;    //获得成绩方式Id
protected bool mbolIsProportionalCtrl;    //是否比例控制
protected string mstrIdExamType;    //考试方式流水号
protected short? mshtExamPortion;    //平时成绩所占比例
protected short? mshtMidExamScorePortion;    //期末成绩所占比例
protected bool mbolIsClearScore;    //是否重录成绩
protected bool mbolIsGeneratePwd;    //是否生成口令
protected string mstrGeneratePwdDate;    //生成口令时间
protected bool mbolIsExportToGP;    //是否导出到平台
protected bool mbolIsExportToGPWeb;    //是否导出到Web平台
protected bool mbolIsReservedDecimal;    //是否保留小数
protected string mstrExamTime;    //考试时间
protected bool mbolCheckState;    //检查状态
protected string mstrCheckDate;    //检查日期
protected string mstrIdEduClassInPk;    //id_EduClassInPk
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
 public clsCurrEduCls_SynEN()
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
public clsCurrEduCls_SynEN(string strIdCurrEduCls)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:CurrEduCls_Syn中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:CurrEduCls_Syn中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conCurrEduCls_Syn.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdMajor)
{
return mstrIdMajor;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdEduWay)
{
return mstrIdEduWay;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdClassRoomType)
{
return mstrIdClassRoomType;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.TotalLessonQty)
{
return mintTotalLessonQty;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.MaxStuQty)
{
return mintMaxStuQty;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CurrentStuQty)
{
return mintCurrentStuQty;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.WeekQty)
{
return mintWeekQty;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ScheUnitPW)
{
return mshtScheUnitPW;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.WeekStatusId)
{
return mstrWeekStatusId;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CustomerWeek)
{
return mstrCustomerWeek;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsCompleteScore)
{
return mbolIsCompleteScore;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdExecPlan)
{
return mstrIdExecPlan;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.LessonQtyPerWeek)
{
return mshtLessonQtyPerWeek;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.Mark)
{
return mdblMark;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckClassRoom)
{
return mstrCheckClassRoom;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckAdminCls)
{
return mstrCheckAdminCls;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckTeacher)
{
return mstrCheckTeacher;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.EditLocked)
{
return mbolEditLocked;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.Sched)
{
return mbolSched;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.Locked)
{
return mbolLocked;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsForPaperReading)
{
return mbolIsForPaperReading;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsUnDeterminedClsRm)
{
return mbolIsUnDeterminedClsRm;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ArrangeCourseMemo)
{
return mstrArrangeCourseMemo;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdCourseType)
{
return mstrIdCourseType;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ExportDate)
{
return mstrExportDate;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsDegree)
{
return mbolIsDegree;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdScoreType)
{
return mstrIdScoreType;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.GetScoreWayId)
{
return mstrGetScoreWayId;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsProportionalCtrl)
{
return mbolIsProportionalCtrl;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdExamType)
{
return mstrIdExamType;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ExamPortion)
{
return mshtExamPortion;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.MidExamScorePortion)
{
return mshtMidExamScorePortion;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsClearScore)
{
return mbolIsClearScore;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsGeneratePwd)
{
return mbolIsGeneratePwd;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.GeneratePwdDate)
{
return mstrGeneratePwdDate;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsExportToGP)
{
return mbolIsExportToGP;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsExportToGPWeb)
{
return mbolIsExportToGPWeb;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsReservedDecimal)
{
return mbolIsReservedDecimal;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ExamTime)
{
return mstrExamTime;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckState)
{
return mbolCheckState;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckDate)
{
return mstrCheckDate;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdEduClassInPk)
{
return mstrIdEduClassInPk;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.PkWeekTime)
{
return mstrPkWeekTime;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.PkClassRooms)
{
return mstrPkClassRooms;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.BeginWeek)
{
return mshtBeginWeek;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.TeacherNames)
{
return mstrTeacherNames;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsSynch)
{
return mbolIsSynch;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SynchDate)
{
return mstrSynchDate;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SignInDate)
{
return mstrSignInDate;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SignInStateID)
{
return mstrSignInStateID;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SignInUser)
{
return mstrSignInUser;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SynchToWebUser)
{
return mstrSynchToWebUser;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsSynchToWeb)
{
return mbolIsSynchToWeb;
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SynchToWebDate)
{
return mstrSynchToWebDate;
}
return null;
}
set
{
if (strAttributeName  ==  conCurrEduCls_Syn.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdCurrEduCls);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CurrEduClsId);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.EduClsName);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.EduClsTypeId);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CourseId);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.TeachingSolutionId);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdXzCollege);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdMajor)
{
mstrIdMajor = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdMajor);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdEduWay)
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdEduWay);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdClassRoomType)
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdClassRoomType);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.TotalLessonQty)
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.TotalLessonQty);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.MaxStuQty)
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.MaxStuQty);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CurrentStuQty)
{
mintCurrentStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.CurrentStuQty);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.WeekQty)
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.WeekQty);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ScheUnitPW)
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.ScheUnitPW);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.WeekStatusId)
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.WeekStatusId);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CustomerWeek)
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CustomerWeek);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsCompleteScore)
{
mbolIsCompleteScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsCompleteScore);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdExecPlan)
{
mstrIdExecPlan = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdExecPlan);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.LessonQtyPerWeek)
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.LessonQtyPerWeek);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.Mark)
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.Mark);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckClassRoom)
{
mstrCheckClassRoom = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CheckClassRoom);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckAdminCls)
{
mstrCheckAdminCls = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CheckAdminCls);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckTeacher)
{
mstrCheckTeacher = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CheckTeacher);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.EditLocked)
{
mbolEditLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.EditLocked);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.Sched)
{
mbolSched = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.Sched);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdUniZone);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.Locked)
{
mbolLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.Locked);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdGradeBase);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsEffective);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsForPaperReading)
{
mbolIsForPaperReading = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsForPaperReading);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsUnDeterminedClsRm)
{
mbolIsUnDeterminedClsRm = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsUnDeterminedClsRm);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SchoolYear);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SchoolTerm);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ArrangeCourseMemo)
{
mstrArrangeCourseMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ArrangeCourseMemo);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdCourseType)
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdCourseType);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ExportDate)
{
mstrExportDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ExportDate);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsDegree)
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsDegree);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdScoreType)
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdScoreType);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.GetScoreWayId)
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.GetScoreWayId);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsProportionalCtrl)
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsProportionalCtrl);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdExamType)
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdExamType);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ExamPortion)
{
mshtExamPortion = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.ExamPortion);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.MidExamScorePortion)
{
mshtMidExamScorePortion = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.MidExamScorePortion);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsClearScore)
{
mbolIsClearScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsClearScore);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsGeneratePwd)
{
mbolIsGeneratePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsGeneratePwd);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.GeneratePwdDate)
{
mstrGeneratePwdDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.GeneratePwdDate);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsExportToGP)
{
mbolIsExportToGP = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsExportToGP);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsExportToGPWeb)
{
mbolIsExportToGPWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsExportToGPWeb);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsReservedDecimal)
{
mbolIsReservedDecimal = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsReservedDecimal);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ExamTime)
{
mstrExamTime = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ExamTime);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckState)
{
mbolCheckState = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.CheckState);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.CheckDate)
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CheckDate);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IdEduClassInPk)
{
mstrIdEduClassInPk = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdEduClassInPk);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.PkWeekTime)
{
mstrPkWeekTime = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.PkWeekTime);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.PkClassRooms)
{
mstrPkClassRooms = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.PkClassRooms);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.BeginWeek)
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.BeginWeek);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.TeacherNames)
{
mstrTeacherNames = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.TeacherNames);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsSynch)
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsSynch);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SynchDate)
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SynchDate);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ModifyDate);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ModifyUserId);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.Memo);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SignInDate)
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SignInDate);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SignInStateID)
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SignInStateID);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SignInUser)
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SignInUser);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SynchToWebUser)
{
mstrSynchToWebUser = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SynchToWebUser);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.IsSynchToWeb)
{
mbolIsSynchToWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsSynchToWeb);
}
else if (strAttributeName  ==  conCurrEduCls_Syn.SynchToWebDate)
{
mstrSynchToWebDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SynchToWebDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conCurrEduCls_Syn.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conCurrEduCls_Syn.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (conCurrEduCls_Syn.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (conCurrEduCls_Syn.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (conCurrEduCls_Syn.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conCurrEduCls_Syn.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (conCurrEduCls_Syn.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conCurrEduCls_Syn.IdMajor  ==  AttributeName[intIndex])
{
return mstrIdMajor;
}
else if (conCurrEduCls_Syn.IdEduWay  ==  AttributeName[intIndex])
{
return mstrIdEduWay;
}
else if (conCurrEduCls_Syn.IdClassRoomType  ==  AttributeName[intIndex])
{
return mstrIdClassRoomType;
}
else if (conCurrEduCls_Syn.TotalLessonQty  ==  AttributeName[intIndex])
{
return mintTotalLessonQty;
}
else if (conCurrEduCls_Syn.MaxStuQty  ==  AttributeName[intIndex])
{
return mintMaxStuQty;
}
else if (conCurrEduCls_Syn.CurrentStuQty  ==  AttributeName[intIndex])
{
return mintCurrentStuQty;
}
else if (conCurrEduCls_Syn.WeekQty  ==  AttributeName[intIndex])
{
return mintWeekQty;
}
else if (conCurrEduCls_Syn.ScheUnitPW  ==  AttributeName[intIndex])
{
return mshtScheUnitPW;
}
else if (conCurrEduCls_Syn.WeekStatusId  ==  AttributeName[intIndex])
{
return mstrWeekStatusId;
}
else if (conCurrEduCls_Syn.CustomerWeek  ==  AttributeName[intIndex])
{
return mstrCustomerWeek;
}
else if (conCurrEduCls_Syn.IsCompleteScore  ==  AttributeName[intIndex])
{
return mbolIsCompleteScore;
}
else if (conCurrEduCls_Syn.IdExecPlan  ==  AttributeName[intIndex])
{
return mstrIdExecPlan;
}
else if (conCurrEduCls_Syn.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
return mshtLessonQtyPerWeek;
}
else if (conCurrEduCls_Syn.Mark  ==  AttributeName[intIndex])
{
return mdblMark;
}
else if (conCurrEduCls_Syn.CheckClassRoom  ==  AttributeName[intIndex])
{
return mstrCheckClassRoom;
}
else if (conCurrEduCls_Syn.CheckAdminCls  ==  AttributeName[intIndex])
{
return mstrCheckAdminCls;
}
else if (conCurrEduCls_Syn.CheckTeacher  ==  AttributeName[intIndex])
{
return mstrCheckTeacher;
}
else if (conCurrEduCls_Syn.EditLocked  ==  AttributeName[intIndex])
{
return mbolEditLocked;
}
else if (conCurrEduCls_Syn.Sched  ==  AttributeName[intIndex])
{
return mbolSched;
}
else if (conCurrEduCls_Syn.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (conCurrEduCls_Syn.Locked  ==  AttributeName[intIndex])
{
return mbolLocked;
}
else if (conCurrEduCls_Syn.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conCurrEduCls_Syn.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (conCurrEduCls_Syn.IsForPaperReading  ==  AttributeName[intIndex])
{
return mbolIsForPaperReading;
}
else if (conCurrEduCls_Syn.IsUnDeterminedClsRm  ==  AttributeName[intIndex])
{
return mbolIsUnDeterminedClsRm;
}
else if (conCurrEduCls_Syn.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conCurrEduCls_Syn.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conCurrEduCls_Syn.ArrangeCourseMemo  ==  AttributeName[intIndex])
{
return mstrArrangeCourseMemo;
}
else if (conCurrEduCls_Syn.IdCourseType  ==  AttributeName[intIndex])
{
return mstrIdCourseType;
}
else if (conCurrEduCls_Syn.ExportDate  ==  AttributeName[intIndex])
{
return mstrExportDate;
}
else if (conCurrEduCls_Syn.IsDegree  ==  AttributeName[intIndex])
{
return mbolIsDegree;
}
else if (conCurrEduCls_Syn.IdScoreType  ==  AttributeName[intIndex])
{
return mstrIdScoreType;
}
else if (conCurrEduCls_Syn.GetScoreWayId  ==  AttributeName[intIndex])
{
return mstrGetScoreWayId;
}
else if (conCurrEduCls_Syn.IsProportionalCtrl  ==  AttributeName[intIndex])
{
return mbolIsProportionalCtrl;
}
else if (conCurrEduCls_Syn.IdExamType  ==  AttributeName[intIndex])
{
return mstrIdExamType;
}
else if (conCurrEduCls_Syn.ExamPortion  ==  AttributeName[intIndex])
{
return mshtExamPortion;
}
else if (conCurrEduCls_Syn.MidExamScorePortion  ==  AttributeName[intIndex])
{
return mshtMidExamScorePortion;
}
else if (conCurrEduCls_Syn.IsClearScore  ==  AttributeName[intIndex])
{
return mbolIsClearScore;
}
else if (conCurrEduCls_Syn.IsGeneratePwd  ==  AttributeName[intIndex])
{
return mbolIsGeneratePwd;
}
else if (conCurrEduCls_Syn.GeneratePwdDate  ==  AttributeName[intIndex])
{
return mstrGeneratePwdDate;
}
else if (conCurrEduCls_Syn.IsExportToGP  ==  AttributeName[intIndex])
{
return mbolIsExportToGP;
}
else if (conCurrEduCls_Syn.IsExportToGPWeb  ==  AttributeName[intIndex])
{
return mbolIsExportToGPWeb;
}
else if (conCurrEduCls_Syn.IsReservedDecimal  ==  AttributeName[intIndex])
{
return mbolIsReservedDecimal;
}
else if (conCurrEduCls_Syn.ExamTime  ==  AttributeName[intIndex])
{
return mstrExamTime;
}
else if (conCurrEduCls_Syn.CheckState  ==  AttributeName[intIndex])
{
return mbolCheckState;
}
else if (conCurrEduCls_Syn.CheckDate  ==  AttributeName[intIndex])
{
return mstrCheckDate;
}
else if (conCurrEduCls_Syn.IdEduClassInPk  ==  AttributeName[intIndex])
{
return mstrIdEduClassInPk;
}
else if (conCurrEduCls_Syn.PkWeekTime  ==  AttributeName[intIndex])
{
return mstrPkWeekTime;
}
else if (conCurrEduCls_Syn.PkClassRooms  ==  AttributeName[intIndex])
{
return mstrPkClassRooms;
}
else if (conCurrEduCls_Syn.BeginWeek  ==  AttributeName[intIndex])
{
return mshtBeginWeek;
}
else if (conCurrEduCls_Syn.TeacherNames  ==  AttributeName[intIndex])
{
return mstrTeacherNames;
}
else if (conCurrEduCls_Syn.IsSynch  ==  AttributeName[intIndex])
{
return mbolIsSynch;
}
else if (conCurrEduCls_Syn.SynchDate  ==  AttributeName[intIndex])
{
return mstrSynchDate;
}
else if (conCurrEduCls_Syn.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conCurrEduCls_Syn.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conCurrEduCls_Syn.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conCurrEduCls_Syn.SignInDate  ==  AttributeName[intIndex])
{
return mstrSignInDate;
}
else if (conCurrEduCls_Syn.SignInStateID  ==  AttributeName[intIndex])
{
return mstrSignInStateID;
}
else if (conCurrEduCls_Syn.SignInUser  ==  AttributeName[intIndex])
{
return mstrSignInUser;
}
else if (conCurrEduCls_Syn.SynchToWebUser  ==  AttributeName[intIndex])
{
return mstrSynchToWebUser;
}
else if (conCurrEduCls_Syn.IsSynchToWeb  ==  AttributeName[intIndex])
{
return mbolIsSynchToWeb;
}
else if (conCurrEduCls_Syn.SynchToWebDate  ==  AttributeName[intIndex])
{
return mstrSynchToWebDate;
}
return null;
}
set
{
if (conCurrEduCls_Syn.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdCurrEduCls);
}
else if (conCurrEduCls_Syn.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CurrEduClsId);
}
else if (conCurrEduCls_Syn.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.EduClsName);
}
else if (conCurrEduCls_Syn.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.EduClsTypeId);
}
else if (conCurrEduCls_Syn.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CourseId);
}
else if (conCurrEduCls_Syn.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.TeachingSolutionId);
}
else if (conCurrEduCls_Syn.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdXzCollege);
}
else if (conCurrEduCls_Syn.IdMajor  ==  AttributeName[intIndex])
{
mstrIdMajor = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdMajor);
}
else if (conCurrEduCls_Syn.IdEduWay  ==  AttributeName[intIndex])
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdEduWay);
}
else if (conCurrEduCls_Syn.IdClassRoomType  ==  AttributeName[intIndex])
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdClassRoomType);
}
else if (conCurrEduCls_Syn.TotalLessonQty  ==  AttributeName[intIndex])
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.TotalLessonQty);
}
else if (conCurrEduCls_Syn.MaxStuQty  ==  AttributeName[intIndex])
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.MaxStuQty);
}
else if (conCurrEduCls_Syn.CurrentStuQty  ==  AttributeName[intIndex])
{
mintCurrentStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.CurrentStuQty);
}
else if (conCurrEduCls_Syn.WeekQty  ==  AttributeName[intIndex])
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.WeekQty);
}
else if (conCurrEduCls_Syn.ScheUnitPW  ==  AttributeName[intIndex])
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.ScheUnitPW);
}
else if (conCurrEduCls_Syn.WeekStatusId  ==  AttributeName[intIndex])
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.WeekStatusId);
}
else if (conCurrEduCls_Syn.CustomerWeek  ==  AttributeName[intIndex])
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CustomerWeek);
}
else if (conCurrEduCls_Syn.IsCompleteScore  ==  AttributeName[intIndex])
{
mbolIsCompleteScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsCompleteScore);
}
else if (conCurrEduCls_Syn.IdExecPlan  ==  AttributeName[intIndex])
{
mstrIdExecPlan = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdExecPlan);
}
else if (conCurrEduCls_Syn.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.LessonQtyPerWeek);
}
else if (conCurrEduCls_Syn.Mark  ==  AttributeName[intIndex])
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.Mark);
}
else if (conCurrEduCls_Syn.CheckClassRoom  ==  AttributeName[intIndex])
{
mstrCheckClassRoom = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CheckClassRoom);
}
else if (conCurrEduCls_Syn.CheckAdminCls  ==  AttributeName[intIndex])
{
mstrCheckAdminCls = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CheckAdminCls);
}
else if (conCurrEduCls_Syn.CheckTeacher  ==  AttributeName[intIndex])
{
mstrCheckTeacher = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CheckTeacher);
}
else if (conCurrEduCls_Syn.EditLocked  ==  AttributeName[intIndex])
{
mbolEditLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.EditLocked);
}
else if (conCurrEduCls_Syn.Sched  ==  AttributeName[intIndex])
{
mbolSched = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.Sched);
}
else if (conCurrEduCls_Syn.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdUniZone);
}
else if (conCurrEduCls_Syn.Locked  ==  AttributeName[intIndex])
{
mbolLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.Locked);
}
else if (conCurrEduCls_Syn.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdGradeBase);
}
else if (conCurrEduCls_Syn.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsEffective);
}
else if (conCurrEduCls_Syn.IsForPaperReading  ==  AttributeName[intIndex])
{
mbolIsForPaperReading = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsForPaperReading);
}
else if (conCurrEduCls_Syn.IsUnDeterminedClsRm  ==  AttributeName[intIndex])
{
mbolIsUnDeterminedClsRm = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsUnDeterminedClsRm);
}
else if (conCurrEduCls_Syn.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SchoolYear);
}
else if (conCurrEduCls_Syn.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SchoolTerm);
}
else if (conCurrEduCls_Syn.ArrangeCourseMemo  ==  AttributeName[intIndex])
{
mstrArrangeCourseMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ArrangeCourseMemo);
}
else if (conCurrEduCls_Syn.IdCourseType  ==  AttributeName[intIndex])
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdCourseType);
}
else if (conCurrEduCls_Syn.ExportDate  ==  AttributeName[intIndex])
{
mstrExportDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ExportDate);
}
else if (conCurrEduCls_Syn.IsDegree  ==  AttributeName[intIndex])
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsDegree);
}
else if (conCurrEduCls_Syn.IdScoreType  ==  AttributeName[intIndex])
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdScoreType);
}
else if (conCurrEduCls_Syn.GetScoreWayId  ==  AttributeName[intIndex])
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.GetScoreWayId);
}
else if (conCurrEduCls_Syn.IsProportionalCtrl  ==  AttributeName[intIndex])
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsProportionalCtrl);
}
else if (conCurrEduCls_Syn.IdExamType  ==  AttributeName[intIndex])
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdExamType);
}
else if (conCurrEduCls_Syn.ExamPortion  ==  AttributeName[intIndex])
{
mshtExamPortion = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.ExamPortion);
}
else if (conCurrEduCls_Syn.MidExamScorePortion  ==  AttributeName[intIndex])
{
mshtMidExamScorePortion = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.MidExamScorePortion);
}
else if (conCurrEduCls_Syn.IsClearScore  ==  AttributeName[intIndex])
{
mbolIsClearScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsClearScore);
}
else if (conCurrEduCls_Syn.IsGeneratePwd  ==  AttributeName[intIndex])
{
mbolIsGeneratePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsGeneratePwd);
}
else if (conCurrEduCls_Syn.GeneratePwdDate  ==  AttributeName[intIndex])
{
mstrGeneratePwdDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.GeneratePwdDate);
}
else if (conCurrEduCls_Syn.IsExportToGP  ==  AttributeName[intIndex])
{
mbolIsExportToGP = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsExportToGP);
}
else if (conCurrEduCls_Syn.IsExportToGPWeb  ==  AttributeName[intIndex])
{
mbolIsExportToGPWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsExportToGPWeb);
}
else if (conCurrEduCls_Syn.IsReservedDecimal  ==  AttributeName[intIndex])
{
mbolIsReservedDecimal = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsReservedDecimal);
}
else if (conCurrEduCls_Syn.ExamTime  ==  AttributeName[intIndex])
{
mstrExamTime = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ExamTime);
}
else if (conCurrEduCls_Syn.CheckState  ==  AttributeName[intIndex])
{
mbolCheckState = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.CheckState);
}
else if (conCurrEduCls_Syn.CheckDate  ==  AttributeName[intIndex])
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.CheckDate);
}
else if (conCurrEduCls_Syn.IdEduClassInPk  ==  AttributeName[intIndex])
{
mstrIdEduClassInPk = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.IdEduClassInPk);
}
else if (conCurrEduCls_Syn.PkWeekTime  ==  AttributeName[intIndex])
{
mstrPkWeekTime = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.PkWeekTime);
}
else if (conCurrEduCls_Syn.PkClassRooms  ==  AttributeName[intIndex])
{
mstrPkClassRooms = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.PkClassRooms);
}
else if (conCurrEduCls_Syn.BeginWeek  ==  AttributeName[intIndex])
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.BeginWeek);
}
else if (conCurrEduCls_Syn.TeacherNames  ==  AttributeName[intIndex])
{
mstrTeacherNames = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.TeacherNames);
}
else if (conCurrEduCls_Syn.IsSynch  ==  AttributeName[intIndex])
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsSynch);
}
else if (conCurrEduCls_Syn.SynchDate  ==  AttributeName[intIndex])
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SynchDate);
}
else if (conCurrEduCls_Syn.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ModifyDate);
}
else if (conCurrEduCls_Syn.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.ModifyUserId);
}
else if (conCurrEduCls_Syn.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.Memo);
}
else if (conCurrEduCls_Syn.SignInDate  ==  AttributeName[intIndex])
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SignInDate);
}
else if (conCurrEduCls_Syn.SignInStateID  ==  AttributeName[intIndex])
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SignInStateID);
}
else if (conCurrEduCls_Syn.SignInUser  ==  AttributeName[intIndex])
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SignInUser);
}
else if (conCurrEduCls_Syn.SynchToWebUser  ==  AttributeName[intIndex])
{
mstrSynchToWebUser = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SynchToWebUser);
}
else if (conCurrEduCls_Syn.IsSynchToWeb  ==  AttributeName[intIndex])
{
mbolIsSynchToWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls_Syn.IsSynchToWeb);
}
else if (conCurrEduCls_Syn.SynchToWebDate  ==  AttributeName[intIndex])
{
mstrSynchToWebDate = value.ToString();
 AddUpdatedFld(conCurrEduCls_Syn.SynchToWebDate);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdCurrEduCls);
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
 AddUpdatedFld(conCurrEduCls_Syn.CurrEduClsId);
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
 AddUpdatedFld(conCurrEduCls_Syn.EduClsName);
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
 AddUpdatedFld(conCurrEduCls_Syn.EduClsTypeId);
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
 AddUpdatedFld(conCurrEduCls_Syn.CourseId);
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
 AddUpdatedFld(conCurrEduCls_Syn.TeachingSolutionId);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdXzCollege);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMajor
{
get
{
return mstrIdMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMajor = value;
}
else
{
 mstrIdMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.IdMajor);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdEduWay);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdClassRoomType);
}
}
/// <summary>
/// 总课时数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TotalLessonQty
{
get
{
return mintTotalLessonQty;
}
set
{
 mintTotalLessonQty = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.TotalLessonQty);
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
 AddUpdatedFld(conCurrEduCls_Syn.MaxStuQty);
}
}
/// <summary>
/// 当前学生数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CurrentStuQty
{
get
{
return mintCurrentStuQty;
}
set
{
 mintCurrentStuQty = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.CurrentStuQty);
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
 AddUpdatedFld(conCurrEduCls_Syn.WeekQty);
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
 AddUpdatedFld(conCurrEduCls_Syn.ScheUnitPW);
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
 AddUpdatedFld(conCurrEduCls_Syn.WeekStatusId);
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
 AddUpdatedFld(conCurrEduCls_Syn.CustomerWeek);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsCompleteScore);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdExecPlan);
}
}
/// <summary>
/// 周课时数(说明:;字段类型:smallint;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short? LessonQtyPerWeek
{
get
{
return mshtLessonQtyPerWeek;
}
set
{
 mshtLessonQtyPerWeek = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.LessonQtyPerWeek);
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
 AddUpdatedFld(conCurrEduCls_Syn.Mark);
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
 AddUpdatedFld(conCurrEduCls_Syn.CheckClassRoom);
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
 AddUpdatedFld(conCurrEduCls_Syn.CheckAdminCls);
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
 AddUpdatedFld(conCurrEduCls_Syn.CheckTeacher);
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
 AddUpdatedFld(conCurrEduCls_Syn.EditLocked);
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
 AddUpdatedFld(conCurrEduCls_Syn.Sched);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdUniZone);
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
 AddUpdatedFld(conCurrEduCls_Syn.Locked);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdGradeBase);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsEffective);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsForPaperReading);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsUnDeterminedClsRm);
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
 AddUpdatedFld(conCurrEduCls_Syn.SchoolYear);
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
 AddUpdatedFld(conCurrEduCls_Syn.SchoolTerm);
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
 AddUpdatedFld(conCurrEduCls_Syn.ArrangeCourseMemo);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdCourseType);
}
}
/// <summary>
/// 导出日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExportDate
{
get
{
return mstrExportDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExportDate = value;
}
else
{
 mstrExportDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.ExportDate);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsDegree);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdScoreType);
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
 AddUpdatedFld(conCurrEduCls_Syn.GetScoreWayId);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsProportionalCtrl);
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
 AddUpdatedFld(conCurrEduCls_Syn.IdExamType);
}
}
/// <summary>
/// 平时成绩所占比例(说明:;字段类型:smallint;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short? ExamPortion
{
get
{
return mshtExamPortion;
}
set
{
 mshtExamPortion = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.ExamPortion);
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
 AddUpdatedFld(conCurrEduCls_Syn.MidExamScorePortion);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsClearScore);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsGeneratePwd);
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
 AddUpdatedFld(conCurrEduCls_Syn.GeneratePwdDate);
}
}
/// <summary>
/// 是否导出到平台(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExportToGP
{
get
{
return mbolIsExportToGP;
}
set
{
 mbolIsExportToGP = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.IsExportToGP);
}
}
/// <summary>
/// 是否导出到Web平台(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExportToGPWeb
{
get
{
return mbolIsExportToGPWeb;
}
set
{
 mbolIsExportToGPWeb = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.IsExportToGPWeb);
}
}
/// <summary>
/// 是否保留小数(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsReservedDecimal
{
get
{
return mbolIsReservedDecimal;
}
set
{
 mbolIsReservedDecimal = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.IsReservedDecimal);
}
}
/// <summary>
/// 考试时间(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamTime
{
get
{
return mstrExamTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamTime = value;
}
else
{
 mstrExamTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.ExamTime);
}
}
/// <summary>
/// 检查状态(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool CheckState
{
get
{
return mbolCheckState;
}
set
{
 mbolCheckState = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.CheckState);
}
}
/// <summary>
/// 检查日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDate
{
get
{
return mstrCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDate = value;
}
else
{
 mstrCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.CheckDate);
}
}
/// <summary>
/// id_EduClassInPk(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduClassInPk
{
get
{
return mstrIdEduClassInPk;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduClassInPk = value;
}
else
{
 mstrIdEduClassInPk = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls_Syn.IdEduClassInPk);
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
 AddUpdatedFld(conCurrEduCls_Syn.PkWeekTime);
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
 AddUpdatedFld(conCurrEduCls_Syn.PkClassRooms);
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
 AddUpdatedFld(conCurrEduCls_Syn.BeginWeek);
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
 AddUpdatedFld(conCurrEduCls_Syn.TeacherNames);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsSynch);
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
 AddUpdatedFld(conCurrEduCls_Syn.SynchDate);
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
 AddUpdatedFld(conCurrEduCls_Syn.ModifyDate);
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
 AddUpdatedFld(conCurrEduCls_Syn.ModifyUserId);
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
 AddUpdatedFld(conCurrEduCls_Syn.Memo);
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
 AddUpdatedFld(conCurrEduCls_Syn.SignInDate);
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
 AddUpdatedFld(conCurrEduCls_Syn.SignInStateID);
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
 AddUpdatedFld(conCurrEduCls_Syn.SignInUser);
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
 AddUpdatedFld(conCurrEduCls_Syn.SynchToWebUser);
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
 AddUpdatedFld(conCurrEduCls_Syn.IsSynchToWeb);
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
 AddUpdatedFld(conCurrEduCls_Syn.SynchToWebDate);
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
  return mstrEduClsName;
 }
 }
}
 /// <summary>
 /// 当前教学班_动态(CurrEduCls_Syn)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCurrEduCls_Syn
{
public const string _CurrTabName = "CurrEduCls_Syn"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "TeachingSolutionId", "IdXzCollege", "IdMajor", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "CurrentStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "IsCompleteScore", "IdExecPlan", "LessonQtyPerWeek", "Mark", "CheckClassRoom", "CheckAdminCls", "CheckTeacher", "EditLocked", "Sched", "IdUniZone", "Locked", "IdGradeBase", "IsEffective", "IsForPaperReading", "IsUnDeterminedClsRm", "SchoolYear", "SchoolTerm", "ArrangeCourseMemo", "IdCourseType", "ExportDate", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IdExamType", "ExamPortion", "MidExamScorePortion", "IsClearScore", "IsGeneratePwd", "GeneratePwdDate", "IsExportToGP", "IsExportToGPWeb", "IsReservedDecimal", "ExamTime", "CheckState", "CheckDate", "IdEduClassInPk", "PkWeekTime", "PkClassRooms", "BeginWeek", "TeacherNames", "IsSynch", "SynchDate", "ModifyDate", "ModifyUserId", "Memo", "SignInDate", "SignInStateID", "SignInUser", "SynchToWebUser", "IsSynchToWeb", "SynchToWebDate"};
//以下是属性变量


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
 /// 常量:"IdMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMajor = "IdMajor";    //专业流水号

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
 /// 常量:"CurrentStuQty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrentStuQty = "CurrentStuQty";    //当前学生数

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
 /// 常量:"ExportDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExportDate = "ExportDate";    //导出日期

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
 /// 常量:"IsExportToGP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExportToGP = "IsExportToGP";    //是否导出到平台

 /// <summary>
 /// 常量:"IsExportToGPWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExportToGPWeb = "IsExportToGPWeb";    //是否导出到Web平台

 /// <summary>
 /// 常量:"IsReservedDecimal"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReservedDecimal = "IsReservedDecimal";    //是否保留小数

 /// <summary>
 /// 常量:"ExamTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamTime = "ExamTime";    //考试时间

 /// <summary>
 /// 常量:"CheckState"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckState = "CheckState";    //检查状态

 /// <summary>
 /// 常量:"CheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDate = "CheckDate";    //检查日期

 /// <summary>
 /// 常量:"IdEduClassInPk"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduClassInPk = "IdEduClassInPk";    //id_EduClassInPk

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