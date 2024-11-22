
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduCls4SynchEN
 表名:CurrEduCls4Synch(01120358)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步(DataSynch)
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
 /// 表CurrEduCls4Synch的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CurrEduCls4Synch
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
public K_mId_CurrEduCls4Synch(long lngmId)
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
 /// <returns>返回:[K_mId_CurrEduCls4Synch]类型的对象</returns>
public static implicit operator K_mId_CurrEduCls4Synch(long value)
{
return new K_mId_CurrEduCls4Synch(value);
}
}
 /// <summary>
 /// 当前教学班_同步(CurrEduCls4Synch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCurrEduCls4SynchEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CurrEduCls4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 70;
public static string[] AttributeName = new string[] {"mId", "IpAddress", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "TeachingSolutionId", "IdXzCollege", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "CurrentStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "IsCompleteScore", "IdExecPlan", "LessonQtyPerWeek", "Mark", "CheckClassRoom", "CheckAdminCls", "CheckTeacher", "EditLocked", "Sched", "IdUniZone", "Locked", "IdGradeBase", "IsEffective", "IsUnDeterminedClsRm", "SchoolYear", "SchoolTerm", "ArrangeCourseMemo", "IdCourseType", "ExportDate", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IsSynchToWeb", "SynchToWebDate", "SynchToWebUser", "SignInDate", "SignInStateID", "SignInUser", "IdExamType", "ExamPortion", "MidExamScorePortion", "IsClearScore", "IsGeneratePwd", "GeneratePwdDate", "IsExportToGP", "IsExportToGPWeb", "IsReservedDecimal", "ExamTime", "CheckState", "CheckDate", "IdEduClassInPk", "PkWeekTime", "PkClassRooms", "BeginWeek", "TeacherNames", "IsAccessSynch", "AccessSynchDate", "IsExistEduClsInCurr", "ModifyDate", "ModifyUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrIpAddress;    //Ip地址
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrCourseId;    //课程Id
protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrIdXzCollege;    //学院流水号
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
protected bool mbolIsSynchToWeb;    //是否同步Web
protected string mstrSynchToWebDate;    //同步Web日期
protected string mstrSynchToWebUser;    //同步Web用户
protected string mstrSignInDate;    //签入时间
protected string mstrSignInStateID;    //签入状态表流水号
protected string mstrSignInUser;    //签入人
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
protected bool mbolIsAccessSynch;    //是否处理同步
protected string mstrAccessSynchDate;    //处理同步日期
protected bool mbolIsExistEduClsInCurr;    //当前是否存在教学班
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCurrEduCls4SynchEN()
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
public clsCurrEduCls4SynchEN(long lngmId)
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
if (strAttributeName  ==  conCurrEduCls4Synch.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdEduWay)
{
return mstrIdEduWay;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdClassRoomType)
{
return mstrIdClassRoomType;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.TotalLessonQty)
{
return mintTotalLessonQty;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.MaxStuQty)
{
return mintMaxStuQty;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CurrentStuQty)
{
return mintCurrentStuQty;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.WeekQty)
{
return mintWeekQty;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ScheUnitPW)
{
return mshtScheUnitPW;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.WeekStatusId)
{
return mstrWeekStatusId;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CustomerWeek)
{
return mstrCustomerWeek;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsCompleteScore)
{
return mbolIsCompleteScore;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdExecPlan)
{
return mstrIdExecPlan;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.LessonQtyPerWeek)
{
return mshtLessonQtyPerWeek;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.Mark)
{
return mdblMark;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckClassRoom)
{
return mstrCheckClassRoom;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckAdminCls)
{
return mstrCheckAdminCls;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckTeacher)
{
return mstrCheckTeacher;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.EditLocked)
{
return mbolEditLocked;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.Sched)
{
return mbolSched;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.Locked)
{
return mbolLocked;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsUnDeterminedClsRm)
{
return mbolIsUnDeterminedClsRm;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ArrangeCourseMemo)
{
return mstrArrangeCourseMemo;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdCourseType)
{
return mstrIdCourseType;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ExportDate)
{
return mstrExportDate;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsDegree)
{
return mbolIsDegree;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdScoreType)
{
return mstrIdScoreType;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.GetScoreWayId)
{
return mstrGetScoreWayId;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsProportionalCtrl)
{
return mbolIsProportionalCtrl;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsSynchToWeb)
{
return mbolIsSynchToWeb;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SynchToWebDate)
{
return mstrSynchToWebDate;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SynchToWebUser)
{
return mstrSynchToWebUser;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SignInDate)
{
return mstrSignInDate;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SignInStateID)
{
return mstrSignInStateID;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SignInUser)
{
return mstrSignInUser;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdExamType)
{
return mstrIdExamType;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ExamPortion)
{
return mshtExamPortion;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.MidExamScorePortion)
{
return mshtMidExamScorePortion;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsClearScore)
{
return mbolIsClearScore;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsGeneratePwd)
{
return mbolIsGeneratePwd;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.GeneratePwdDate)
{
return mstrGeneratePwdDate;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsExportToGP)
{
return mbolIsExportToGP;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsExportToGPWeb)
{
return mbolIsExportToGPWeb;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsReservedDecimal)
{
return mbolIsReservedDecimal;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ExamTime)
{
return mstrExamTime;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckState)
{
return mbolCheckState;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckDate)
{
return mstrCheckDate;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdEduClassInPk)
{
return mstrIdEduClassInPk;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.PkWeekTime)
{
return mstrPkWeekTime;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.PkClassRooms)
{
return mstrPkClassRooms;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.BeginWeek)
{
return mshtBeginWeek;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.TeacherNames)
{
return mstrTeacherNames;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsAccessSynch)
{
return mbolIsAccessSynch;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.AccessSynchDate)
{
return mstrAccessSynchDate;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsExistEduClsInCurr)
{
return mbolIsExistEduClsInCurr;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conCurrEduCls4Synch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCurrEduCls4Synch.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.mId);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IpAddress);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdCurrEduCls);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CurrEduClsId);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.EduClsName);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.EduClsTypeId);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CourseId);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.TeachingSolutionId);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdXzCollege);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdEduWay)
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdEduWay);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdClassRoomType)
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdClassRoomType);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.TotalLessonQty)
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.TotalLessonQty);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.MaxStuQty)
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.MaxStuQty);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CurrentStuQty)
{
mintCurrentStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.CurrentStuQty);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.WeekQty)
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.WeekQty);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ScheUnitPW)
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.ScheUnitPW);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.WeekStatusId)
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.WeekStatusId);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CustomerWeek)
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CustomerWeek);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsCompleteScore)
{
mbolIsCompleteScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsCompleteScore);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdExecPlan)
{
mstrIdExecPlan = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdExecPlan);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.LessonQtyPerWeek)
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.LessonQtyPerWeek);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.Mark)
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.Mark);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckClassRoom)
{
mstrCheckClassRoom = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CheckClassRoom);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckAdminCls)
{
mstrCheckAdminCls = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CheckAdminCls);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckTeacher)
{
mstrCheckTeacher = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CheckTeacher);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.EditLocked)
{
mbolEditLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.EditLocked);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.Sched)
{
mbolSched = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.Sched);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdUniZone);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.Locked)
{
mbolLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.Locked);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdGradeBase);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsEffective);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsUnDeterminedClsRm)
{
mbolIsUnDeterminedClsRm = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsUnDeterminedClsRm);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SchoolYear);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SchoolTerm);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ArrangeCourseMemo)
{
mstrArrangeCourseMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ArrangeCourseMemo);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdCourseType)
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdCourseType);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ExportDate)
{
mstrExportDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ExportDate);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsDegree)
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsDegree);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdScoreType)
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdScoreType);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.GetScoreWayId)
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.GetScoreWayId);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsProportionalCtrl)
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsProportionalCtrl);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsSynchToWeb)
{
mbolIsSynchToWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsSynchToWeb);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SynchToWebDate)
{
mstrSynchToWebDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SynchToWebDate);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SynchToWebUser)
{
mstrSynchToWebUser = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SynchToWebUser);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SignInDate)
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SignInDate);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SignInStateID)
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SignInStateID);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.SignInUser)
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SignInUser);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdExamType)
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdExamType);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ExamPortion)
{
mshtExamPortion = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.ExamPortion);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.MidExamScorePortion)
{
mshtMidExamScorePortion = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.MidExamScorePortion);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsClearScore)
{
mbolIsClearScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsClearScore);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsGeneratePwd)
{
mbolIsGeneratePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsGeneratePwd);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.GeneratePwdDate)
{
mstrGeneratePwdDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.GeneratePwdDate);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsExportToGP)
{
mbolIsExportToGP = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsExportToGP);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsExportToGPWeb)
{
mbolIsExportToGPWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsExportToGPWeb);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsReservedDecimal)
{
mbolIsReservedDecimal = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsReservedDecimal);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ExamTime)
{
mstrExamTime = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ExamTime);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckState)
{
mbolCheckState = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.CheckState);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.CheckDate)
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CheckDate);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IdEduClassInPk)
{
mstrIdEduClassInPk = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdEduClassInPk);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.PkWeekTime)
{
mstrPkWeekTime = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.PkWeekTime);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.PkClassRooms)
{
mstrPkClassRooms = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.PkClassRooms);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.BeginWeek)
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.BeginWeek);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.TeacherNames)
{
mstrTeacherNames = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.TeacherNames);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsAccessSynch)
{
mbolIsAccessSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsAccessSynch);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.AccessSynchDate)
{
mstrAccessSynchDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.AccessSynchDate);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.IsExistEduClsInCurr)
{
mbolIsExistEduClsInCurr = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsExistEduClsInCurr);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ModifyDate);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ModifyUserId);
}
else if (strAttributeName  ==  conCurrEduCls4Synch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCurrEduCls4Synch.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conCurrEduCls4Synch.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conCurrEduCls4Synch.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conCurrEduCls4Synch.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (conCurrEduCls4Synch.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (conCurrEduCls4Synch.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (conCurrEduCls4Synch.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conCurrEduCls4Synch.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (conCurrEduCls4Synch.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conCurrEduCls4Synch.IdEduWay  ==  AttributeName[intIndex])
{
return mstrIdEduWay;
}
else if (conCurrEduCls4Synch.IdClassRoomType  ==  AttributeName[intIndex])
{
return mstrIdClassRoomType;
}
else if (conCurrEduCls4Synch.TotalLessonQty  ==  AttributeName[intIndex])
{
return mintTotalLessonQty;
}
else if (conCurrEduCls4Synch.MaxStuQty  ==  AttributeName[intIndex])
{
return mintMaxStuQty;
}
else if (conCurrEduCls4Synch.CurrentStuQty  ==  AttributeName[intIndex])
{
return mintCurrentStuQty;
}
else if (conCurrEduCls4Synch.WeekQty  ==  AttributeName[intIndex])
{
return mintWeekQty;
}
else if (conCurrEduCls4Synch.ScheUnitPW  ==  AttributeName[intIndex])
{
return mshtScheUnitPW;
}
else if (conCurrEduCls4Synch.WeekStatusId  ==  AttributeName[intIndex])
{
return mstrWeekStatusId;
}
else if (conCurrEduCls4Synch.CustomerWeek  ==  AttributeName[intIndex])
{
return mstrCustomerWeek;
}
else if (conCurrEduCls4Synch.IsCompleteScore  ==  AttributeName[intIndex])
{
return mbolIsCompleteScore;
}
else if (conCurrEduCls4Synch.IdExecPlan  ==  AttributeName[intIndex])
{
return mstrIdExecPlan;
}
else if (conCurrEduCls4Synch.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
return mshtLessonQtyPerWeek;
}
else if (conCurrEduCls4Synch.Mark  ==  AttributeName[intIndex])
{
return mdblMark;
}
else if (conCurrEduCls4Synch.CheckClassRoom  ==  AttributeName[intIndex])
{
return mstrCheckClassRoom;
}
else if (conCurrEduCls4Synch.CheckAdminCls  ==  AttributeName[intIndex])
{
return mstrCheckAdminCls;
}
else if (conCurrEduCls4Synch.CheckTeacher  ==  AttributeName[intIndex])
{
return mstrCheckTeacher;
}
else if (conCurrEduCls4Synch.EditLocked  ==  AttributeName[intIndex])
{
return mbolEditLocked;
}
else if (conCurrEduCls4Synch.Sched  ==  AttributeName[intIndex])
{
return mbolSched;
}
else if (conCurrEduCls4Synch.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (conCurrEduCls4Synch.Locked  ==  AttributeName[intIndex])
{
return mbolLocked;
}
else if (conCurrEduCls4Synch.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conCurrEduCls4Synch.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (conCurrEduCls4Synch.IsUnDeterminedClsRm  ==  AttributeName[intIndex])
{
return mbolIsUnDeterminedClsRm;
}
else if (conCurrEduCls4Synch.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conCurrEduCls4Synch.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conCurrEduCls4Synch.ArrangeCourseMemo  ==  AttributeName[intIndex])
{
return mstrArrangeCourseMemo;
}
else if (conCurrEduCls4Synch.IdCourseType  ==  AttributeName[intIndex])
{
return mstrIdCourseType;
}
else if (conCurrEduCls4Synch.ExportDate  ==  AttributeName[intIndex])
{
return mstrExportDate;
}
else if (conCurrEduCls4Synch.IsDegree  ==  AttributeName[intIndex])
{
return mbolIsDegree;
}
else if (conCurrEduCls4Synch.IdScoreType  ==  AttributeName[intIndex])
{
return mstrIdScoreType;
}
else if (conCurrEduCls4Synch.GetScoreWayId  ==  AttributeName[intIndex])
{
return mstrGetScoreWayId;
}
else if (conCurrEduCls4Synch.IsProportionalCtrl  ==  AttributeName[intIndex])
{
return mbolIsProportionalCtrl;
}
else if (conCurrEduCls4Synch.IsSynchToWeb  ==  AttributeName[intIndex])
{
return mbolIsSynchToWeb;
}
else if (conCurrEduCls4Synch.SynchToWebDate  ==  AttributeName[intIndex])
{
return mstrSynchToWebDate;
}
else if (conCurrEduCls4Synch.SynchToWebUser  ==  AttributeName[intIndex])
{
return mstrSynchToWebUser;
}
else if (conCurrEduCls4Synch.SignInDate  ==  AttributeName[intIndex])
{
return mstrSignInDate;
}
else if (conCurrEduCls4Synch.SignInStateID  ==  AttributeName[intIndex])
{
return mstrSignInStateID;
}
else if (conCurrEduCls4Synch.SignInUser  ==  AttributeName[intIndex])
{
return mstrSignInUser;
}
else if (conCurrEduCls4Synch.IdExamType  ==  AttributeName[intIndex])
{
return mstrIdExamType;
}
else if (conCurrEduCls4Synch.ExamPortion  ==  AttributeName[intIndex])
{
return mshtExamPortion;
}
else if (conCurrEduCls4Synch.MidExamScorePortion  ==  AttributeName[intIndex])
{
return mshtMidExamScorePortion;
}
else if (conCurrEduCls4Synch.IsClearScore  ==  AttributeName[intIndex])
{
return mbolIsClearScore;
}
else if (conCurrEduCls4Synch.IsGeneratePwd  ==  AttributeName[intIndex])
{
return mbolIsGeneratePwd;
}
else if (conCurrEduCls4Synch.GeneratePwdDate  ==  AttributeName[intIndex])
{
return mstrGeneratePwdDate;
}
else if (conCurrEduCls4Synch.IsExportToGP  ==  AttributeName[intIndex])
{
return mbolIsExportToGP;
}
else if (conCurrEduCls4Synch.IsExportToGPWeb  ==  AttributeName[intIndex])
{
return mbolIsExportToGPWeb;
}
else if (conCurrEduCls4Synch.IsReservedDecimal  ==  AttributeName[intIndex])
{
return mbolIsReservedDecimal;
}
else if (conCurrEduCls4Synch.ExamTime  ==  AttributeName[intIndex])
{
return mstrExamTime;
}
else if (conCurrEduCls4Synch.CheckState  ==  AttributeName[intIndex])
{
return mbolCheckState;
}
else if (conCurrEduCls4Synch.CheckDate  ==  AttributeName[intIndex])
{
return mstrCheckDate;
}
else if (conCurrEduCls4Synch.IdEduClassInPk  ==  AttributeName[intIndex])
{
return mstrIdEduClassInPk;
}
else if (conCurrEduCls4Synch.PkWeekTime  ==  AttributeName[intIndex])
{
return mstrPkWeekTime;
}
else if (conCurrEduCls4Synch.PkClassRooms  ==  AttributeName[intIndex])
{
return mstrPkClassRooms;
}
else if (conCurrEduCls4Synch.BeginWeek  ==  AttributeName[intIndex])
{
return mshtBeginWeek;
}
else if (conCurrEduCls4Synch.TeacherNames  ==  AttributeName[intIndex])
{
return mstrTeacherNames;
}
else if (conCurrEduCls4Synch.IsAccessSynch  ==  AttributeName[intIndex])
{
return mbolIsAccessSynch;
}
else if (conCurrEduCls4Synch.AccessSynchDate  ==  AttributeName[intIndex])
{
return mstrAccessSynchDate;
}
else if (conCurrEduCls4Synch.IsExistEduClsInCurr  ==  AttributeName[intIndex])
{
return mbolIsExistEduClsInCurr;
}
else if (conCurrEduCls4Synch.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conCurrEduCls4Synch.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conCurrEduCls4Synch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCurrEduCls4Synch.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.mId);
}
else if (conCurrEduCls4Synch.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IpAddress);
}
else if (conCurrEduCls4Synch.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdCurrEduCls);
}
else if (conCurrEduCls4Synch.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CurrEduClsId);
}
else if (conCurrEduCls4Synch.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.EduClsName);
}
else if (conCurrEduCls4Synch.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.EduClsTypeId);
}
else if (conCurrEduCls4Synch.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CourseId);
}
else if (conCurrEduCls4Synch.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.TeachingSolutionId);
}
else if (conCurrEduCls4Synch.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdXzCollege);
}
else if (conCurrEduCls4Synch.IdEduWay  ==  AttributeName[intIndex])
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdEduWay);
}
else if (conCurrEduCls4Synch.IdClassRoomType  ==  AttributeName[intIndex])
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdClassRoomType);
}
else if (conCurrEduCls4Synch.TotalLessonQty  ==  AttributeName[intIndex])
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.TotalLessonQty);
}
else if (conCurrEduCls4Synch.MaxStuQty  ==  AttributeName[intIndex])
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.MaxStuQty);
}
else if (conCurrEduCls4Synch.CurrentStuQty  ==  AttributeName[intIndex])
{
mintCurrentStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.CurrentStuQty);
}
else if (conCurrEduCls4Synch.WeekQty  ==  AttributeName[intIndex])
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.WeekQty);
}
else if (conCurrEduCls4Synch.ScheUnitPW  ==  AttributeName[intIndex])
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.ScheUnitPW);
}
else if (conCurrEduCls4Synch.WeekStatusId  ==  AttributeName[intIndex])
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.WeekStatusId);
}
else if (conCurrEduCls4Synch.CustomerWeek  ==  AttributeName[intIndex])
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CustomerWeek);
}
else if (conCurrEduCls4Synch.IsCompleteScore  ==  AttributeName[intIndex])
{
mbolIsCompleteScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsCompleteScore);
}
else if (conCurrEduCls4Synch.IdExecPlan  ==  AttributeName[intIndex])
{
mstrIdExecPlan = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdExecPlan);
}
else if (conCurrEduCls4Synch.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.LessonQtyPerWeek);
}
else if (conCurrEduCls4Synch.Mark  ==  AttributeName[intIndex])
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.Mark);
}
else if (conCurrEduCls4Synch.CheckClassRoom  ==  AttributeName[intIndex])
{
mstrCheckClassRoom = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CheckClassRoom);
}
else if (conCurrEduCls4Synch.CheckAdminCls  ==  AttributeName[intIndex])
{
mstrCheckAdminCls = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CheckAdminCls);
}
else if (conCurrEduCls4Synch.CheckTeacher  ==  AttributeName[intIndex])
{
mstrCheckTeacher = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CheckTeacher);
}
else if (conCurrEduCls4Synch.EditLocked  ==  AttributeName[intIndex])
{
mbolEditLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.EditLocked);
}
else if (conCurrEduCls4Synch.Sched  ==  AttributeName[intIndex])
{
mbolSched = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.Sched);
}
else if (conCurrEduCls4Synch.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdUniZone);
}
else if (conCurrEduCls4Synch.Locked  ==  AttributeName[intIndex])
{
mbolLocked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.Locked);
}
else if (conCurrEduCls4Synch.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdGradeBase);
}
else if (conCurrEduCls4Synch.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsEffective);
}
else if (conCurrEduCls4Synch.IsUnDeterminedClsRm  ==  AttributeName[intIndex])
{
mbolIsUnDeterminedClsRm = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsUnDeterminedClsRm);
}
else if (conCurrEduCls4Synch.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SchoolYear);
}
else if (conCurrEduCls4Synch.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SchoolTerm);
}
else if (conCurrEduCls4Synch.ArrangeCourseMemo  ==  AttributeName[intIndex])
{
mstrArrangeCourseMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ArrangeCourseMemo);
}
else if (conCurrEduCls4Synch.IdCourseType  ==  AttributeName[intIndex])
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdCourseType);
}
else if (conCurrEduCls4Synch.ExportDate  ==  AttributeName[intIndex])
{
mstrExportDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ExportDate);
}
else if (conCurrEduCls4Synch.IsDegree  ==  AttributeName[intIndex])
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsDegree);
}
else if (conCurrEduCls4Synch.IdScoreType  ==  AttributeName[intIndex])
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdScoreType);
}
else if (conCurrEduCls4Synch.GetScoreWayId  ==  AttributeName[intIndex])
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.GetScoreWayId);
}
else if (conCurrEduCls4Synch.IsProportionalCtrl  ==  AttributeName[intIndex])
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsProportionalCtrl);
}
else if (conCurrEduCls4Synch.IsSynchToWeb  ==  AttributeName[intIndex])
{
mbolIsSynchToWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsSynchToWeb);
}
else if (conCurrEduCls4Synch.SynchToWebDate  ==  AttributeName[intIndex])
{
mstrSynchToWebDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SynchToWebDate);
}
else if (conCurrEduCls4Synch.SynchToWebUser  ==  AttributeName[intIndex])
{
mstrSynchToWebUser = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SynchToWebUser);
}
else if (conCurrEduCls4Synch.SignInDate  ==  AttributeName[intIndex])
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SignInDate);
}
else if (conCurrEduCls4Synch.SignInStateID  ==  AttributeName[intIndex])
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SignInStateID);
}
else if (conCurrEduCls4Synch.SignInUser  ==  AttributeName[intIndex])
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.SignInUser);
}
else if (conCurrEduCls4Synch.IdExamType  ==  AttributeName[intIndex])
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdExamType);
}
else if (conCurrEduCls4Synch.ExamPortion  ==  AttributeName[intIndex])
{
mshtExamPortion = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.ExamPortion);
}
else if (conCurrEduCls4Synch.MidExamScorePortion  ==  AttributeName[intIndex])
{
mshtMidExamScorePortion = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.MidExamScorePortion);
}
else if (conCurrEduCls4Synch.IsClearScore  ==  AttributeName[intIndex])
{
mbolIsClearScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsClearScore);
}
else if (conCurrEduCls4Synch.IsGeneratePwd  ==  AttributeName[intIndex])
{
mbolIsGeneratePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsGeneratePwd);
}
else if (conCurrEduCls4Synch.GeneratePwdDate  ==  AttributeName[intIndex])
{
mstrGeneratePwdDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.GeneratePwdDate);
}
else if (conCurrEduCls4Synch.IsExportToGP  ==  AttributeName[intIndex])
{
mbolIsExportToGP = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsExportToGP);
}
else if (conCurrEduCls4Synch.IsExportToGPWeb  ==  AttributeName[intIndex])
{
mbolIsExportToGPWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsExportToGPWeb);
}
else if (conCurrEduCls4Synch.IsReservedDecimal  ==  AttributeName[intIndex])
{
mbolIsReservedDecimal = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsReservedDecimal);
}
else if (conCurrEduCls4Synch.ExamTime  ==  AttributeName[intIndex])
{
mstrExamTime = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ExamTime);
}
else if (conCurrEduCls4Synch.CheckState  ==  AttributeName[intIndex])
{
mbolCheckState = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.CheckState);
}
else if (conCurrEduCls4Synch.CheckDate  ==  AttributeName[intIndex])
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.CheckDate);
}
else if (conCurrEduCls4Synch.IdEduClassInPk  ==  AttributeName[intIndex])
{
mstrIdEduClassInPk = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.IdEduClassInPk);
}
else if (conCurrEduCls4Synch.PkWeekTime  ==  AttributeName[intIndex])
{
mstrPkWeekTime = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.PkWeekTime);
}
else if (conCurrEduCls4Synch.PkClassRooms  ==  AttributeName[intIndex])
{
mstrPkClassRooms = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.PkClassRooms);
}
else if (conCurrEduCls4Synch.BeginWeek  ==  AttributeName[intIndex])
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.BeginWeek);
}
else if (conCurrEduCls4Synch.TeacherNames  ==  AttributeName[intIndex])
{
mstrTeacherNames = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.TeacherNames);
}
else if (conCurrEduCls4Synch.IsAccessSynch  ==  AttributeName[intIndex])
{
mbolIsAccessSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsAccessSynch);
}
else if (conCurrEduCls4Synch.AccessSynchDate  ==  AttributeName[intIndex])
{
mstrAccessSynchDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.AccessSynchDate);
}
else if (conCurrEduCls4Synch.IsExistEduClsInCurr  ==  AttributeName[intIndex])
{
mbolIsExistEduClsInCurr = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls4Synch.IsExistEduClsInCurr);
}
else if (conCurrEduCls4Synch.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ModifyDate);
}
else if (conCurrEduCls4Synch.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.ModifyUserId);
}
else if (conCurrEduCls4Synch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls4Synch.Memo);
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
 AddUpdatedFld(conCurrEduCls4Synch.mId);
}
}
/// <summary>
/// Ip地址(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls4Synch.IpAddress);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdCurrEduCls);
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
 AddUpdatedFld(conCurrEduCls4Synch.CurrEduClsId);
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
 AddUpdatedFld(conCurrEduCls4Synch.EduClsName);
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
 AddUpdatedFld(conCurrEduCls4Synch.EduClsTypeId);
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
 AddUpdatedFld(conCurrEduCls4Synch.CourseId);
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
 AddUpdatedFld(conCurrEduCls4Synch.TeachingSolutionId);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdXzCollege);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdEduWay);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdClassRoomType);
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
 AddUpdatedFld(conCurrEduCls4Synch.TotalLessonQty);
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
 AddUpdatedFld(conCurrEduCls4Synch.MaxStuQty);
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
 AddUpdatedFld(conCurrEduCls4Synch.CurrentStuQty);
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
 AddUpdatedFld(conCurrEduCls4Synch.WeekQty);
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
 AddUpdatedFld(conCurrEduCls4Synch.ScheUnitPW);
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
 AddUpdatedFld(conCurrEduCls4Synch.WeekStatusId);
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
 AddUpdatedFld(conCurrEduCls4Synch.CustomerWeek);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsCompleteScore);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdExecPlan);
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
 AddUpdatedFld(conCurrEduCls4Synch.LessonQtyPerWeek);
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
 AddUpdatedFld(conCurrEduCls4Synch.Mark);
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
 AddUpdatedFld(conCurrEduCls4Synch.CheckClassRoom);
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
 AddUpdatedFld(conCurrEduCls4Synch.CheckAdminCls);
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
 AddUpdatedFld(conCurrEduCls4Synch.CheckTeacher);
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
 AddUpdatedFld(conCurrEduCls4Synch.EditLocked);
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
 AddUpdatedFld(conCurrEduCls4Synch.Sched);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdUniZone);
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
 AddUpdatedFld(conCurrEduCls4Synch.Locked);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdGradeBase);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsEffective);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsUnDeterminedClsRm);
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
 AddUpdatedFld(conCurrEduCls4Synch.SchoolYear);
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
 AddUpdatedFld(conCurrEduCls4Synch.SchoolTerm);
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
 AddUpdatedFld(conCurrEduCls4Synch.ArrangeCourseMemo);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdCourseType);
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
 AddUpdatedFld(conCurrEduCls4Synch.ExportDate);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsDegree);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdScoreType);
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
 AddUpdatedFld(conCurrEduCls4Synch.GetScoreWayId);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsProportionalCtrl);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsSynchToWeb);
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
 AddUpdatedFld(conCurrEduCls4Synch.SynchToWebDate);
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
 AddUpdatedFld(conCurrEduCls4Synch.SynchToWebUser);
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
 AddUpdatedFld(conCurrEduCls4Synch.SignInDate);
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
 AddUpdatedFld(conCurrEduCls4Synch.SignInStateID);
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
 AddUpdatedFld(conCurrEduCls4Synch.SignInUser);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdExamType);
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
 AddUpdatedFld(conCurrEduCls4Synch.ExamPortion);
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
 AddUpdatedFld(conCurrEduCls4Synch.MidExamScorePortion);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsClearScore);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsGeneratePwd);
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
 AddUpdatedFld(conCurrEduCls4Synch.GeneratePwdDate);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsExportToGP);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsExportToGPWeb);
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
 AddUpdatedFld(conCurrEduCls4Synch.IsReservedDecimal);
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
 AddUpdatedFld(conCurrEduCls4Synch.ExamTime);
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
 AddUpdatedFld(conCurrEduCls4Synch.CheckState);
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
 AddUpdatedFld(conCurrEduCls4Synch.CheckDate);
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
 AddUpdatedFld(conCurrEduCls4Synch.IdEduClassInPk);
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
 AddUpdatedFld(conCurrEduCls4Synch.PkWeekTime);
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
 AddUpdatedFld(conCurrEduCls4Synch.PkClassRooms);
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
 AddUpdatedFld(conCurrEduCls4Synch.BeginWeek);
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
 AddUpdatedFld(conCurrEduCls4Synch.TeacherNames);
}
}
/// <summary>
/// 是否处理同步(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAccessSynch
{
get
{
return mbolIsAccessSynch;
}
set
{
 mbolIsAccessSynch = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls4Synch.IsAccessSynch);
}
}
/// <summary>
/// 处理同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AccessSynchDate
{
get
{
return mstrAccessSynchDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAccessSynchDate = value;
}
else
{
 mstrAccessSynchDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls4Synch.AccessSynchDate);
}
}
/// <summary>
/// 当前是否存在教学班(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistEduClsInCurr
{
get
{
return mbolIsExistEduClsInCurr;
}
set
{
 mbolIsExistEduClsInCurr = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduCls4Synch.IsExistEduClsInCurr);
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
 AddUpdatedFld(conCurrEduCls4Synch.ModifyDate);
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
 AddUpdatedFld(conCurrEduCls4Synch.ModifyUserId);
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
 AddUpdatedFld(conCurrEduCls4Synch.Memo);
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
 /// 当前教学班_同步(CurrEduCls4Synch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCurrEduCls4Synch
{
public const string _CurrTabName = "CurrEduCls4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IpAddress", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "TeachingSolutionId", "IdXzCollege", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "CurrentStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "IsCompleteScore", "IdExecPlan", "LessonQtyPerWeek", "Mark", "CheckClassRoom", "CheckAdminCls", "CheckTeacher", "EditLocked", "Sched", "IdUniZone", "Locked", "IdGradeBase", "IsEffective", "IsUnDeterminedClsRm", "SchoolYear", "SchoolTerm", "ArrangeCourseMemo", "IdCourseType", "ExportDate", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IsSynchToWeb", "SynchToWebDate", "SynchToWebUser", "SignInDate", "SignInStateID", "SignInUser", "IdExamType", "ExamPortion", "MidExamScorePortion", "IsClearScore", "IsGeneratePwd", "GeneratePwdDate", "IsExportToGP", "IsExportToGPWeb", "IsReservedDecimal", "ExamTime", "CheckState", "CheckDate", "IdEduClassInPk", "PkWeekTime", "PkClassRooms", "BeginWeek", "TeacherNames", "IsAccessSynch", "AccessSynchDate", "IsExistEduClsInCurr", "ModifyDate", "ModifyUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //Ip地址

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
 /// 常量:"IsSynchToWeb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToWeb = "IsSynchToWeb";    //是否同步Web

 /// <summary>
 /// 常量:"SynchToWebDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToWebDate = "SynchToWebDate";    //同步Web日期

 /// <summary>
 /// 常量:"SynchToWebUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToWebUser = "SynchToWebUser";    //同步Web用户

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
 /// 常量:"IsAccessSynch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAccessSynch = "IsAccessSynch";    //是否处理同步

 /// <summary>
 /// 常量:"AccessSynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AccessSynchDate = "AccessSynchDate";    //处理同步日期

 /// <summary>
 /// 常量:"IsExistEduClsInCurr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistEduClsInCurr = "IsExistEduClsInCurr";    //当前是否存在教学班

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
}

}