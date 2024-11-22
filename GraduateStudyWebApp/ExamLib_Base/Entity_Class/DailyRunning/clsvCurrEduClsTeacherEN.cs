
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsTeacherEN
 表名:vCurrEduClsTeacher(01120128)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 17:50:12
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
 /// 表vCurrEduClsTeacher的关键字(IdEduClsTeacher)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduClsTeacher_vCurrEduClsTeacher
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdEduClsTeacher">表关键字</param>
public K_IdEduClsTeacher_vCurrEduClsTeacher(long lngIdEduClsTeacher)
{
if (IsValid(lngIdEduClsTeacher)) Value = lngIdEduClsTeacher;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdEduClsTeacher)
{
if (lngIdEduClsTeacher == 0) return false;
if (lngIdEduClsTeacher == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEduClsTeacher_vCurrEduClsTeacher]类型的对象</returns>
public static implicit operator K_IdEduClsTeacher_vCurrEduClsTeacher(long value)
{
return new K_IdEduClsTeacher_vCurrEduClsTeacher(value);
}
}
 /// <summary>
 /// v当前教学班教师(vCurrEduClsTeacher)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCurrEduClsTeacherEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCurrEduClsTeacher"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduClsTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 60;
public static string[] AttributeName = new string[] {"IdEduClsTeacher", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "EduClsTypeName", "CourseId", "CourseCode", "CourseName", "ExampleImgPath", "TeachingSolutionId", "TeachingSolutionName", "IdXzCollege", "CollegeId", "IdEduWay", "TotalLessonQty", "MaxStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "LessonQtyPerWeek", "IdUniZone", "IdGradeBase", "GradeBaseId", "GradeBaseName", "IsEffective", "IdCourseType", "CourseTypeId", "CourseTypeName", "IsDegree", "IdScoreType", "IsProportionalCtrl", "IdExamType", "BeginWeek", "CurrStuNumValid", "CurrStuNum", "IdTeacher", "TeacherId", "TeacherName", "IdProfGrade", "ProfenssionalGradeName", "DegreeName", "Birthday", "IsGpUser", "CollegeName", "IdPk2EduClsTeacherType", "EduClsTeacherTypeId", "EduClsTeacherTypeDesc", "SchoolTerm", "SchoolYear", "OpenBeginDate", "OpenEndDate", "OrderNum", "UpdDate", "UpdUser", "Memo", "CollegeName4EduCls", "CollegeName4Teacher", "UserType"};

protected long mlngIdEduClsTeacher;    //教学班老师流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrEduClsTypeName;    //教学班类型名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrExampleImgPath;    //示例图路径
protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrTeachingSolutionName;    //教学方案名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrIdEduWay;    //教学方式流水号
protected int? mintTotalLessonQty;    //总课时数
protected int? mintMaxStuQty;    //最大学生数
protected int? mintWeekQty;    //总周数
protected short? mshtScheUnitPW;    //周排课次数
protected string mstrWeekStatusId;    //周状态编号(单,双,全周)
protected string mstrCustomerWeek;    //自定义上课周
protected short? mshtLessonQtyPerWeek;    //周课时数
protected string mstrIdUniZone;    //校区流水号
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseId;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected bool mbolIsEffective;    //是否有效
protected string mstrIdCourseType;    //课程类型流水号
protected string mstrCourseTypeId;    //课程类型ID
protected string mstrCourseTypeName;    //课程类型名称
protected bool mbolIsDegree;    //是否学位课
protected string mstrIdScoreType;    //成绩类型流水号
protected bool mbolIsProportionalCtrl;    //是否比例控制
protected string mstrIdExamType;    //考试方式流水号
protected short? mshtBeginWeek;    //开始周
protected int? mintCurrStuNumValid;    //CurrStuNum_Valid
protected int? mintCurrStuNum;    //当前学生数
protected string mstrIdTeacher;    //教师流水号
protected string mstrTeacherId;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdProfGrade;    //专业职称流水号
protected string mstrProfenssionalGradeName;    //专业职称
protected string mstrDegreeName;    //学位名称
protected string mstrBirthday;    //出生日期
protected bool mbolIsGpUser;    //是否Gp用户
protected string mstrCollegeName;    //学院名称
protected string mstrIdPk2EduClsTeacherType;    //教学班老师角色(主讲,辅导)流水号
protected string mstrEduClsTeacherTypeId;    //教学班教学类型ID
protected string mstrEduClsTeacherTypeDesc;    //教学班教师类型名
protected string mstrSchoolTerm;    //学期
protected string mstrSchoolYear;    //学年
protected string mstrOpenBeginDate;    //开放开始日期
protected string mstrOpenEndDate;    //开放结束日期
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrCollegeName4EduCls;    //学院名_教学班
protected string mstrCollegeName4Teacher;    //学院名_教师
protected string mstrUserType;    //用户类型

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCurrEduClsTeacherEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduClsTeacher");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdEduClsTeacher">关键字:教学班老师流水号</param>
public clsvCurrEduClsTeacherEN(long lngIdEduClsTeacher)
 {
 if (lngIdEduClsTeacher  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdEduClsTeacher = lngIdEduClsTeacher;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduClsTeacher");
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
if (strAttributeName  ==  convCurrEduClsTeacher.IdEduClsTeacher)
{
return mlngIdEduClsTeacher;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsTypeName)
{
return mstrEduClsTypeName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.ExampleImgPath)
{
return mstrExampleImgPath;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TeachingSolutionName)
{
return mstrTeachingSolutionName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdEduWay)
{
return mstrIdEduWay;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TotalLessonQty)
{
return mintTotalLessonQty;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.MaxStuQty)
{
return mintMaxStuQty;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.WeekQty)
{
return mintWeekQty;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.ScheUnitPW)
{
return mshtScheUnitPW;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.WeekStatusId)
{
return mstrWeekStatusId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CustomerWeek)
{
return mstrCustomerWeek;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.LessonQtyPerWeek)
{
return mshtLessonQtyPerWeek;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.GradeBaseId)
{
return mstrGradeBaseId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdCourseType)
{
return mstrIdCourseType;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseTypeName)
{
return mstrCourseTypeName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IsDegree)
{
return mbolIsDegree;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdScoreType)
{
return mstrIdScoreType;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IsProportionalCtrl)
{
return mbolIsProportionalCtrl;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdExamType)
{
return mstrIdExamType;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.BeginWeek)
{
return mshtBeginWeek;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CurrStuNumValid)
{
return mintCurrStuNumValid;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CurrStuNum)
{
return mintCurrStuNum;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdProfGrade)
{
return mstrIdProfGrade;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.ProfenssionalGradeName)
{
return mstrProfenssionalGradeName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.DegreeName)
{
return mstrDegreeName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdPk2EduClsTeacherType)
{
return mstrIdPk2EduClsTeacherType;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsTeacherTypeId)
{
return mstrEduClsTeacherTypeId;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsTeacherTypeDesc)
{
return mstrEduClsTeacherTypeDesc;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.OpenBeginDate)
{
return mstrOpenBeginDate;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.OpenEndDate)
{
return mstrOpenEndDate;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CollegeName4EduCls)
{
return mstrCollegeName4EduCls;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CollegeName4Teacher)
{
return mstrCollegeName4Teacher;
}
else if (strAttributeName  ==  convCurrEduClsTeacher.UserType)
{
return mstrUserType;
}
return null;
}
set
{
if (strAttributeName  ==  convCurrEduClsTeacher.IdEduClsTeacher)
{
mlngIdEduClsTeacher = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IdEduClsTeacher);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdCurrEduCls);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CurrEduClsId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTypeId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsTypeName)
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTypeName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseCode);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.ExampleImgPath)
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.ExampleImgPath);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.TeachingSolutionId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TeachingSolutionName)
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.TeachingSolutionName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdXzCollege);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CollegeId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdEduWay)
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdEduWay);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TotalLessonQty)
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.TotalLessonQty);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.MaxStuQty)
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.MaxStuQty);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.WeekQty)
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.WeekQty);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.ScheUnitPW)
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.ScheUnitPW);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.WeekStatusId)
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.WeekStatusId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CustomerWeek)
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CustomerWeek);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.LessonQtyPerWeek)
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.LessonQtyPerWeek);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdUniZone);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdGradeBase);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.GradeBaseId)
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.GradeBaseId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.GradeBaseName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IsEffective);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdCourseType)
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdCourseType);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseTypeId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CourseTypeName)
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseTypeName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IsDegree)
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IsDegree);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdScoreType)
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdScoreType);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IsProportionalCtrl)
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IsProportionalCtrl);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdExamType)
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdExamType);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.BeginWeek)
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.BeginWeek);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CurrStuNumValid)
{
mintCurrStuNumValid = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.CurrStuNumValid);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CurrStuNum)
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.CurrStuNum);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdTeacher);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.TeacherId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.TeacherName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdProfGrade)
{
mstrIdProfGrade = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdProfGrade);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.ProfenssionalGradeName)
{
mstrProfenssionalGradeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.ProfenssionalGradeName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.DegreeName)
{
mstrDegreeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.DegreeName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.Birthday);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IsGpUser);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.IdPk2EduClsTeacherType)
{
mstrIdPk2EduClsTeacherType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsTeacherTypeId)
{
mstrEduClsTeacherTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTeacherTypeId);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.EduClsTeacherTypeDesc)
{
mstrEduClsTeacherTypeDesc = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTeacherTypeDesc);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.SchoolTerm);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.SchoolYear);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.OpenBeginDate)
{
mstrOpenBeginDate = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.OpenBeginDate);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.OpenEndDate)
{
mstrOpenEndDate = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.OpenEndDate);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.OrderNum);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.UpdDate);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.UpdUser);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.Memo);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CollegeName4EduCls)
{
mstrCollegeName4EduCls = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName4EduCls);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.CollegeName4Teacher)
{
mstrCollegeName4Teacher = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName4Teacher);
}
else if (strAttributeName  ==  convCurrEduClsTeacher.UserType)
{
mstrUserType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.UserType);
}
}
}
public object this[int intIndex]
{
get
{
if (convCurrEduClsTeacher.IdEduClsTeacher  ==  AttributeName[intIndex])
{
return mlngIdEduClsTeacher;
}
else if (convCurrEduClsTeacher.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convCurrEduClsTeacher.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convCurrEduClsTeacher.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convCurrEduClsTeacher.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (convCurrEduClsTeacher.EduClsTypeName  ==  AttributeName[intIndex])
{
return mstrEduClsTypeName;
}
else if (convCurrEduClsTeacher.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCurrEduClsTeacher.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCurrEduClsTeacher.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCurrEduClsTeacher.ExampleImgPath  ==  AttributeName[intIndex])
{
return mstrExampleImgPath;
}
else if (convCurrEduClsTeacher.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (convCurrEduClsTeacher.TeachingSolutionName  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionName;
}
else if (convCurrEduClsTeacher.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCurrEduClsTeacher.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convCurrEduClsTeacher.IdEduWay  ==  AttributeName[intIndex])
{
return mstrIdEduWay;
}
else if (convCurrEduClsTeacher.TotalLessonQty  ==  AttributeName[intIndex])
{
return mintTotalLessonQty;
}
else if (convCurrEduClsTeacher.MaxStuQty  ==  AttributeName[intIndex])
{
return mintMaxStuQty;
}
else if (convCurrEduClsTeacher.WeekQty  ==  AttributeName[intIndex])
{
return mintWeekQty;
}
else if (convCurrEduClsTeacher.ScheUnitPW  ==  AttributeName[intIndex])
{
return mshtScheUnitPW;
}
else if (convCurrEduClsTeacher.WeekStatusId  ==  AttributeName[intIndex])
{
return mstrWeekStatusId;
}
else if (convCurrEduClsTeacher.CustomerWeek  ==  AttributeName[intIndex])
{
return mstrCustomerWeek;
}
else if (convCurrEduClsTeacher.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
return mshtLessonQtyPerWeek;
}
else if (convCurrEduClsTeacher.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (convCurrEduClsTeacher.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convCurrEduClsTeacher.GradeBaseId  ==  AttributeName[intIndex])
{
return mstrGradeBaseId;
}
else if (convCurrEduClsTeacher.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convCurrEduClsTeacher.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (convCurrEduClsTeacher.IdCourseType  ==  AttributeName[intIndex])
{
return mstrIdCourseType;
}
else if (convCurrEduClsTeacher.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (convCurrEduClsTeacher.CourseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseTypeName;
}
else if (convCurrEduClsTeacher.IsDegree  ==  AttributeName[intIndex])
{
return mbolIsDegree;
}
else if (convCurrEduClsTeacher.IdScoreType  ==  AttributeName[intIndex])
{
return mstrIdScoreType;
}
else if (convCurrEduClsTeacher.IsProportionalCtrl  ==  AttributeName[intIndex])
{
return mbolIsProportionalCtrl;
}
else if (convCurrEduClsTeacher.IdExamType  ==  AttributeName[intIndex])
{
return mstrIdExamType;
}
else if (convCurrEduClsTeacher.BeginWeek  ==  AttributeName[intIndex])
{
return mshtBeginWeek;
}
else if (convCurrEduClsTeacher.CurrStuNumValid  ==  AttributeName[intIndex])
{
return mintCurrStuNumValid;
}
else if (convCurrEduClsTeacher.CurrStuNum  ==  AttributeName[intIndex])
{
return mintCurrStuNum;
}
else if (convCurrEduClsTeacher.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (convCurrEduClsTeacher.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (convCurrEduClsTeacher.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convCurrEduClsTeacher.IdProfGrade  ==  AttributeName[intIndex])
{
return mstrIdProfGrade;
}
else if (convCurrEduClsTeacher.ProfenssionalGradeName  ==  AttributeName[intIndex])
{
return mstrProfenssionalGradeName;
}
else if (convCurrEduClsTeacher.DegreeName  ==  AttributeName[intIndex])
{
return mstrDegreeName;
}
else if (convCurrEduClsTeacher.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convCurrEduClsTeacher.IsGpUser  ==  AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (convCurrEduClsTeacher.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCurrEduClsTeacher.IdPk2EduClsTeacherType  ==  AttributeName[intIndex])
{
return mstrIdPk2EduClsTeacherType;
}
else if (convCurrEduClsTeacher.EduClsTeacherTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTeacherTypeId;
}
else if (convCurrEduClsTeacher.EduClsTeacherTypeDesc  ==  AttributeName[intIndex])
{
return mstrEduClsTeacherTypeDesc;
}
else if (convCurrEduClsTeacher.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convCurrEduClsTeacher.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convCurrEduClsTeacher.OpenBeginDate  ==  AttributeName[intIndex])
{
return mstrOpenBeginDate;
}
else if (convCurrEduClsTeacher.OpenEndDate  ==  AttributeName[intIndex])
{
return mstrOpenEndDate;
}
else if (convCurrEduClsTeacher.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCurrEduClsTeacher.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCurrEduClsTeacher.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCurrEduClsTeacher.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCurrEduClsTeacher.CollegeName4EduCls  ==  AttributeName[intIndex])
{
return mstrCollegeName4EduCls;
}
else if (convCurrEduClsTeacher.CollegeName4Teacher  ==  AttributeName[intIndex])
{
return mstrCollegeName4Teacher;
}
else if (convCurrEduClsTeacher.UserType  ==  AttributeName[intIndex])
{
return mstrUserType;
}
return null;
}
set
{
if (convCurrEduClsTeacher.IdEduClsTeacher  ==  AttributeName[intIndex])
{
mlngIdEduClsTeacher = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IdEduClsTeacher);
}
else if (convCurrEduClsTeacher.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdCurrEduCls);
}
else if (convCurrEduClsTeacher.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CurrEduClsId);
}
else if (convCurrEduClsTeacher.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsName);
}
else if (convCurrEduClsTeacher.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTypeId);
}
else if (convCurrEduClsTeacher.EduClsTypeName  ==  AttributeName[intIndex])
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTypeName);
}
else if (convCurrEduClsTeacher.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseId);
}
else if (convCurrEduClsTeacher.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseCode);
}
else if (convCurrEduClsTeacher.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseName);
}
else if (convCurrEduClsTeacher.ExampleImgPath  ==  AttributeName[intIndex])
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.ExampleImgPath);
}
else if (convCurrEduClsTeacher.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.TeachingSolutionId);
}
else if (convCurrEduClsTeacher.TeachingSolutionName  ==  AttributeName[intIndex])
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.TeachingSolutionName);
}
else if (convCurrEduClsTeacher.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdXzCollege);
}
else if (convCurrEduClsTeacher.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CollegeId);
}
else if (convCurrEduClsTeacher.IdEduWay  ==  AttributeName[intIndex])
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdEduWay);
}
else if (convCurrEduClsTeacher.TotalLessonQty  ==  AttributeName[intIndex])
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.TotalLessonQty);
}
else if (convCurrEduClsTeacher.MaxStuQty  ==  AttributeName[intIndex])
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.MaxStuQty);
}
else if (convCurrEduClsTeacher.WeekQty  ==  AttributeName[intIndex])
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.WeekQty);
}
else if (convCurrEduClsTeacher.ScheUnitPW  ==  AttributeName[intIndex])
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.ScheUnitPW);
}
else if (convCurrEduClsTeacher.WeekStatusId  ==  AttributeName[intIndex])
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.WeekStatusId);
}
else if (convCurrEduClsTeacher.CustomerWeek  ==  AttributeName[intIndex])
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CustomerWeek);
}
else if (convCurrEduClsTeacher.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.LessonQtyPerWeek);
}
else if (convCurrEduClsTeacher.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdUniZone);
}
else if (convCurrEduClsTeacher.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdGradeBase);
}
else if (convCurrEduClsTeacher.GradeBaseId  ==  AttributeName[intIndex])
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.GradeBaseId);
}
else if (convCurrEduClsTeacher.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.GradeBaseName);
}
else if (convCurrEduClsTeacher.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IsEffective);
}
else if (convCurrEduClsTeacher.IdCourseType  ==  AttributeName[intIndex])
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdCourseType);
}
else if (convCurrEduClsTeacher.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseTypeId);
}
else if (convCurrEduClsTeacher.CourseTypeName  ==  AttributeName[intIndex])
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CourseTypeName);
}
else if (convCurrEduClsTeacher.IsDegree  ==  AttributeName[intIndex])
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IsDegree);
}
else if (convCurrEduClsTeacher.IdScoreType  ==  AttributeName[intIndex])
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdScoreType);
}
else if (convCurrEduClsTeacher.IsProportionalCtrl  ==  AttributeName[intIndex])
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IsProportionalCtrl);
}
else if (convCurrEduClsTeacher.IdExamType  ==  AttributeName[intIndex])
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdExamType);
}
else if (convCurrEduClsTeacher.BeginWeek  ==  AttributeName[intIndex])
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.BeginWeek);
}
else if (convCurrEduClsTeacher.CurrStuNumValid  ==  AttributeName[intIndex])
{
mintCurrStuNumValid = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.CurrStuNumValid);
}
else if (convCurrEduClsTeacher.CurrStuNum  ==  AttributeName[intIndex])
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.CurrStuNum);
}
else if (convCurrEduClsTeacher.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdTeacher);
}
else if (convCurrEduClsTeacher.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.TeacherId);
}
else if (convCurrEduClsTeacher.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.TeacherName);
}
else if (convCurrEduClsTeacher.IdProfGrade  ==  AttributeName[intIndex])
{
mstrIdProfGrade = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdProfGrade);
}
else if (convCurrEduClsTeacher.ProfenssionalGradeName  ==  AttributeName[intIndex])
{
mstrProfenssionalGradeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.ProfenssionalGradeName);
}
else if (convCurrEduClsTeacher.DegreeName  ==  AttributeName[intIndex])
{
mstrDegreeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.DegreeName);
}
else if (convCurrEduClsTeacher.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.Birthday);
}
else if (convCurrEduClsTeacher.IsGpUser  ==  AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.IsGpUser);
}
else if (convCurrEduClsTeacher.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName);
}
else if (convCurrEduClsTeacher.IdPk2EduClsTeacherType  ==  AttributeName[intIndex])
{
mstrIdPk2EduClsTeacherType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
else if (convCurrEduClsTeacher.EduClsTeacherTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTeacherTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTeacherTypeId);
}
else if (convCurrEduClsTeacher.EduClsTeacherTypeDesc  ==  AttributeName[intIndex])
{
mstrEduClsTeacherTypeDesc = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTeacherTypeDesc);
}
else if (convCurrEduClsTeacher.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.SchoolTerm);
}
else if (convCurrEduClsTeacher.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.SchoolYear);
}
else if (convCurrEduClsTeacher.OpenBeginDate  ==  AttributeName[intIndex])
{
mstrOpenBeginDate = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.OpenBeginDate);
}
else if (convCurrEduClsTeacher.OpenEndDate  ==  AttributeName[intIndex])
{
mstrOpenEndDate = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.OpenEndDate);
}
else if (convCurrEduClsTeacher.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsTeacher.OrderNum);
}
else if (convCurrEduClsTeacher.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.UpdDate);
}
else if (convCurrEduClsTeacher.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.UpdUser);
}
else if (convCurrEduClsTeacher.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.Memo);
}
else if (convCurrEduClsTeacher.CollegeName4EduCls  ==  AttributeName[intIndex])
{
mstrCollegeName4EduCls = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName4EduCls);
}
else if (convCurrEduClsTeacher.CollegeName4Teacher  ==  AttributeName[intIndex])
{
mstrCollegeName4Teacher = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName4Teacher);
}
else if (convCurrEduClsTeacher.UserType  ==  AttributeName[intIndex])
{
mstrUserType = value.ToString();
 AddUpdatedFld(convCurrEduClsTeacher.UserType);
}
}
}

/// <summary>
/// 教学班老师流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdEduClsTeacher
{
get
{
return mlngIdEduClsTeacher;
}
set
{
 mlngIdEduClsTeacher = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.IdEduClsTeacher);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdCurrEduCls);
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
 AddUpdatedFld(convCurrEduClsTeacher.CurrEduClsId);
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
 AddUpdatedFld(convCurrEduClsTeacher.EduClsName);
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
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTypeId);
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
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTypeName);
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
 AddUpdatedFld(convCurrEduClsTeacher.CourseId);
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
 AddUpdatedFld(convCurrEduClsTeacher.CourseCode);
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
 AddUpdatedFld(convCurrEduClsTeacher.CourseName);
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
 AddUpdatedFld(convCurrEduClsTeacher.ExampleImgPath);
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
 AddUpdatedFld(convCurrEduClsTeacher.TeachingSolutionId);
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
 AddUpdatedFld(convCurrEduClsTeacher.TeachingSolutionName);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdXzCollege);
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
 AddUpdatedFld(convCurrEduClsTeacher.CollegeId);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdEduWay);
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
 AddUpdatedFld(convCurrEduClsTeacher.TotalLessonQty);
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
 AddUpdatedFld(convCurrEduClsTeacher.MaxStuQty);
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
 AddUpdatedFld(convCurrEduClsTeacher.WeekQty);
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
 AddUpdatedFld(convCurrEduClsTeacher.ScheUnitPW);
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
 AddUpdatedFld(convCurrEduClsTeacher.WeekStatusId);
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
 AddUpdatedFld(convCurrEduClsTeacher.CustomerWeek);
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
 AddUpdatedFld(convCurrEduClsTeacher.LessonQtyPerWeek);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdUniZone);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdGradeBase);
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
 AddUpdatedFld(convCurrEduClsTeacher.GradeBaseId);
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
 AddUpdatedFld(convCurrEduClsTeacher.GradeBaseName);
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
 AddUpdatedFld(convCurrEduClsTeacher.IsEffective);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdCourseType);
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
 AddUpdatedFld(convCurrEduClsTeacher.CourseTypeId);
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
 AddUpdatedFld(convCurrEduClsTeacher.CourseTypeName);
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
 AddUpdatedFld(convCurrEduClsTeacher.IsDegree);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdScoreType);
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
 AddUpdatedFld(convCurrEduClsTeacher.IsProportionalCtrl);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdExamType);
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
 AddUpdatedFld(convCurrEduClsTeacher.BeginWeek);
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
 AddUpdatedFld(convCurrEduClsTeacher.CurrStuNumValid);
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
 AddUpdatedFld(convCurrEduClsTeacher.CurrStuNum);
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
 AddUpdatedFld(convCurrEduClsTeacher.IdTeacher);
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
 AddUpdatedFld(convCurrEduClsTeacher.TeacherId);
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
 AddUpdatedFld(convCurrEduClsTeacher.TeacherName);
}
}
/// <summary>
/// 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdProfGrade
{
get
{
return mstrIdProfGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdProfGrade = value;
}
else
{
 mstrIdProfGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.IdProfGrade);
}
}
/// <summary>
/// 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProfenssionalGradeName
{
get
{
return mstrProfenssionalGradeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProfenssionalGradeName = value;
}
else
{
 mstrProfenssionalGradeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.ProfenssionalGradeName);
}
}
/// <summary>
/// 学位名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DegreeName
{
get
{
return mstrDegreeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDegreeName = value;
}
else
{
 mstrDegreeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.DegreeName);
}
}
/// <summary>
/// 出生日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Birthday
{
get
{
return mstrBirthday;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBirthday = value;
}
else
{
 mstrBirthday = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.Birthday);
}
}
/// <summary>
/// 是否Gp用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGpUser
{
get
{
return mbolIsGpUser;
}
set
{
 mbolIsGpUser = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.IsGpUser);
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
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName);
}
}
/// <summary>
/// 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPk2EduClsTeacherType
{
get
{
return mstrIdPk2EduClsTeacherType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPk2EduClsTeacherType = value;
}
else
{
 mstrIdPk2EduClsTeacherType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
}
/// <summary>
/// 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTeacherTypeId
{
get
{
return mstrEduClsTeacherTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTeacherTypeId = value;
}
else
{
 mstrEduClsTeacherTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTeacherTypeId);
}
}
/// <summary>
/// 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTeacherTypeDesc
{
get
{
return mstrEduClsTeacherTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTeacherTypeDesc = value;
}
else
{
 mstrEduClsTeacherTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.EduClsTeacherTypeDesc);
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
 AddUpdatedFld(convCurrEduClsTeacher.SchoolTerm);
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
 AddUpdatedFld(convCurrEduClsTeacher.SchoolYear);
}
}
/// <summary>
/// 开放开始日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpenBeginDate
{
get
{
return mstrOpenBeginDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpenBeginDate = value;
}
else
{
 mstrOpenBeginDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.OpenBeginDate);
}
}
/// <summary>
/// 开放结束日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpenEndDate
{
get
{
return mstrOpenEndDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpenEndDate = value;
}
else
{
 mstrOpenEndDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.OpenEndDate);
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
 AddUpdatedFld(convCurrEduClsTeacher.OrderNum);
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
 AddUpdatedFld(convCurrEduClsTeacher.UpdDate);
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
 AddUpdatedFld(convCurrEduClsTeacher.UpdUser);
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
 AddUpdatedFld(convCurrEduClsTeacher.Memo);
}
}
/// <summary>
/// 学院名_教学班(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName4EduCls
{
get
{
return mstrCollegeName4EduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName4EduCls = value;
}
else
{
 mstrCollegeName4EduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName4EduCls);
}
}
/// <summary>
/// 学院名_教师(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName4Teacher
{
get
{
return mstrCollegeName4Teacher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName4Teacher = value;
}
else
{
 mstrCollegeName4Teacher = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.CollegeName4Teacher);
}
}
/// <summary>
/// 用户类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserType
{
get
{
return mstrUserType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserType = value;
}
else
{
 mstrUserType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsTeacher.UserType);
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
  return mlngIdEduClsTeacher.ToString();
 }
 }
}
 /// <summary>
 /// v当前教学班教师(vCurrEduClsTeacher)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCurrEduClsTeacher
{
public const string _CurrTabName = "vCurrEduClsTeacher"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduClsTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduClsTeacher", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "EduClsTypeName", "CourseId", "CourseCode", "CourseName", "ExampleImgPath", "TeachingSolutionId", "TeachingSolutionName", "IdXzCollege", "CollegeId", "IdEduWay", "TotalLessonQty", "MaxStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "LessonQtyPerWeek", "IdUniZone", "IdGradeBase", "GradeBaseId", "GradeBaseName", "IsEffective", "IdCourseType", "CourseTypeId", "CourseTypeName", "IsDegree", "IdScoreType", "IsProportionalCtrl", "IdExamType", "BeginWeek", "CurrStuNumValid", "CurrStuNum", "IdTeacher", "TeacherId", "TeacherName", "IdProfGrade", "ProfenssionalGradeName", "DegreeName", "Birthday", "IsGpUser", "CollegeName", "IdPk2EduClsTeacherType", "EduClsTeacherTypeId", "EduClsTeacherTypeDesc", "SchoolTerm", "SchoolYear", "OpenBeginDate", "OpenEndDate", "OrderNum", "UpdDate", "UpdUser", "Memo", "CollegeName4EduCls", "CollegeName4Teacher", "UserType"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEduClsTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduClsTeacher = "IdEduClsTeacher";    //教学班老师流水号

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
 /// 常量:"EduClsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeName = "EduClsTypeName";    //教学班类型名称

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
 /// 常量:"ExampleImgPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExampleImgPath = "ExampleImgPath";    //示例图路径

 /// <summary>
 /// 常量:"TeachingSolutionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionId = "TeachingSolutionId";    //教学方案Id

 /// <summary>
 /// 常量:"TeachingSolutionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionName = "TeachingSolutionName";    //教学方案名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

 /// <summary>
 /// 常量:"IdEduWay"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduWay = "IdEduWay";    //教学方式流水号

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
 /// 常量:"LessonQtyPerWeek"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LessonQtyPerWeek = "LessonQtyPerWeek";    //周课时数

 /// <summary>
 /// 常量:"IdUniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUniZone = "IdUniZone";    //校区流水号

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

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
 /// 常量:"IsEffective"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEffective = "IsEffective";    //是否有效

 /// <summary>
 /// 常量:"IdCourseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseType = "IdCourseType";    //课程类型流水号

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
 /// 常量:"BeginWeek"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BeginWeek = "BeginWeek";    //开始周

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
 /// 常量:"IdProfGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdProfGrade = "IdProfGrade";    //专业职称流水号

 /// <summary>
 /// 常量:"ProfenssionalGradeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProfenssionalGradeName = "ProfenssionalGradeName";    //专业职称

 /// <summary>
 /// 常量:"DegreeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DegreeName = "DegreeName";    //学位名称

 /// <summary>
 /// 常量:"Birthday"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Birthday = "Birthday";    //出生日期

 /// <summary>
 /// 常量:"IsGpUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGpUser = "IsGpUser";    //是否Gp用户

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdPk2EduClsTeacherType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPk2EduClsTeacherType = "IdPk2EduClsTeacherType";    //教学班老师角色(主讲,辅导)流水号

 /// <summary>
 /// 常量:"EduClsTeacherTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTeacherTypeId = "EduClsTeacherTypeId";    //教学班教学类型ID

 /// <summary>
 /// 常量:"EduClsTeacherTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTeacherTypeDesc = "EduClsTeacherTypeDesc";    //教学班教师类型名

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"OpenBeginDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenBeginDate = "OpenBeginDate";    //开放开始日期

 /// <summary>
 /// 常量:"OpenEndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenEndDate = "OpenEndDate";    //开放结束日期

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

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"CollegeName4EduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName4EduCls = "CollegeName4EduCls";    //学院名_教学班

 /// <summary>
 /// 常量:"CollegeName4Teacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName4Teacher = "CollegeName4Teacher";    //学院名_教师

 /// <summary>
 /// 常量:"UserType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserType = "UserType";    //用户类型
}

}