
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsEN
 表名:vCurrEduCls(01120126)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 12:58:39
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
 /// 表vCurrEduCls的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_vCurrEduCls
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
public K_IdCurrEduCls_vCurrEduCls(string strIdCurrEduCls)
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
 /// <returns>返回:[K_IdCurrEduCls_vCurrEduCls]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_vCurrEduCls(string value)
{
return new K_IdCurrEduCls_vCurrEduCls(value);
}
}
 /// <summary>
 /// v当前教学班(vCurrEduCls)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCurrEduClsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCurrEduCls"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 57;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "EduClsTypeName", "CourseId", "CourseCode", "CourseDescription", "CourseName", "ViewCount", "ExampleImgPath", "TeachingSolutionId", "TeachingSolutionName", "IdTeacher", "TeacherId", "TeacherName", "IdXzCollege", "CollegeId", "CollegeName", "ClgEnglishName", "PhoneNumber", "IdXzMajor", "MajorName", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "LessonQtyPerWeek", "Mark", "IdUniZone", "IdGradeBase", "GradeBaseId", "GradeBaseName", "GradeBaseNameA", "IsEffective", "IsForPaperReading", "SchoolYear", "SchoolTerm", "IdCourseType", "CourseTypeId", "CourseTypeName", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IdExamType", "BeginWeek", "UserType", "ModifyDate", "ModifyUserId", "Memo", "CurrStuNumValid", "CurrStuNum"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrEduClsTypeName;    //教学班类型名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseDescription;    //课程描述
protected string mstrCourseName;    //课程名称
protected int? mintViewCount;    //浏览量
protected string mstrExampleImgPath;    //示例图路径
protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrTeachingSolutionName;    //教学方案名称
protected string mstrIdTeacher;    //教师流水号
protected string mstrTeacherId;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrClgEnglishName;    //ClgEnglishName
protected string mstrPhoneNumber;    //电话
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdEduWay;    //教学方式流水号
protected string mstrIdClassRoomType;    //教室类型流水号
protected int mintTotalLessonQty;    //总课时数
protected int? mintMaxStuQty;    //最大学生数
protected int? mintWeekQty;    //总周数
protected short? mshtScheUnitPW;    //周排课次数
protected string mstrWeekStatusId;    //周状态编号(单,双,全周)
protected string mstrCustomerWeek;    //自定义上课周
protected short? mshtLessonQtyPerWeek;    //周课时数
protected double? mdblMark;    //获得学分
protected string mstrIdUniZone;    //校区流水号
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseId;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected string mstrGradeBaseNameA;    //年级名称缩写
protected bool mbolIsEffective;    //是否有效
protected bool mbolIsForPaperReading;    //是否参与论文阅读
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrIdCourseType;    //课程类型流水号
protected string mstrCourseTypeId;    //课程类型ID
protected string mstrCourseTypeName;    //课程类型名称
protected bool mbolIsDegree;    //是否学位课
protected string mstrIdScoreType;    //成绩类型流水号
protected string mstrGetScoreWayId;    //获得成绩方式Id
protected bool mbolIsProportionalCtrl;    //是否比例控制
protected string mstrIdExamType;    //考试方式流水号
protected short? mshtBeginWeek;    //开始周
protected string mstrUserType;    //用户类型
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注
protected int? mintCurrStuNumValid;    //CurrStuNum_Valid
protected int? mintCurrStuNum;    //当前学生数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCurrEduClsEN()
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
public clsvCurrEduClsEN(string strIdCurrEduCls)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:vCurrEduCls中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:vCurrEduCls中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convCurrEduCls.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convCurrEduCls.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convCurrEduCls.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convCurrEduCls.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  convCurrEduCls.EduClsTypeName)
{
return mstrEduClsTypeName;
}
else if (strAttributeName  ==  convCurrEduCls.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCurrEduCls.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCurrEduCls.CourseDescription)
{
return mstrCourseDescription;
}
else if (strAttributeName  ==  convCurrEduCls.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCurrEduCls.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convCurrEduCls.ExampleImgPath)
{
return mstrExampleImgPath;
}
else if (strAttributeName  ==  convCurrEduCls.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  convCurrEduCls.TeachingSolutionName)
{
return mstrTeachingSolutionName;
}
else if (strAttributeName  ==  convCurrEduCls.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  convCurrEduCls.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  convCurrEduCls.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convCurrEduCls.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCurrEduCls.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convCurrEduCls.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCurrEduCls.ClgEnglishName)
{
return mstrClgEnglishName;
}
else if (strAttributeName  ==  convCurrEduCls.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  convCurrEduCls.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCurrEduCls.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCurrEduCls.IdEduWay)
{
return mstrIdEduWay;
}
else if (strAttributeName  ==  convCurrEduCls.IdClassRoomType)
{
return mstrIdClassRoomType;
}
else if (strAttributeName  ==  convCurrEduCls.TotalLessonQty)
{
return mintTotalLessonQty;
}
else if (strAttributeName  ==  convCurrEduCls.MaxStuQty)
{
return mintMaxStuQty;
}
else if (strAttributeName  ==  convCurrEduCls.WeekQty)
{
return mintWeekQty;
}
else if (strAttributeName  ==  convCurrEduCls.ScheUnitPW)
{
return mshtScheUnitPW;
}
else if (strAttributeName  ==  convCurrEduCls.WeekStatusId)
{
return mstrWeekStatusId;
}
else if (strAttributeName  ==  convCurrEduCls.CustomerWeek)
{
return mstrCustomerWeek;
}
else if (strAttributeName  ==  convCurrEduCls.LessonQtyPerWeek)
{
return mshtLessonQtyPerWeek;
}
else if (strAttributeName  ==  convCurrEduCls.Mark)
{
return mdblMark;
}
else if (strAttributeName  ==  convCurrEduCls.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  convCurrEduCls.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convCurrEduCls.GradeBaseId)
{
return mstrGradeBaseId;
}
else if (strAttributeName  ==  convCurrEduCls.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convCurrEduCls.GradeBaseNameA)
{
return mstrGradeBaseNameA;
}
else if (strAttributeName  ==  convCurrEduCls.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  convCurrEduCls.IsForPaperReading)
{
return mbolIsForPaperReading;
}
else if (strAttributeName  ==  convCurrEduCls.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convCurrEduCls.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convCurrEduCls.IdCourseType)
{
return mstrIdCourseType;
}
else if (strAttributeName  ==  convCurrEduCls.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  convCurrEduCls.CourseTypeName)
{
return mstrCourseTypeName;
}
else if (strAttributeName  ==  convCurrEduCls.IsDegree)
{
return mbolIsDegree;
}
else if (strAttributeName  ==  convCurrEduCls.IdScoreType)
{
return mstrIdScoreType;
}
else if (strAttributeName  ==  convCurrEduCls.GetScoreWayId)
{
return mstrGetScoreWayId;
}
else if (strAttributeName  ==  convCurrEduCls.IsProportionalCtrl)
{
return mbolIsProportionalCtrl;
}
else if (strAttributeName  ==  convCurrEduCls.IdExamType)
{
return mstrIdExamType;
}
else if (strAttributeName  ==  convCurrEduCls.BeginWeek)
{
return mshtBeginWeek;
}
else if (strAttributeName  ==  convCurrEduCls.UserType)
{
return mstrUserType;
}
else if (strAttributeName  ==  convCurrEduCls.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convCurrEduCls.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convCurrEduCls.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCurrEduCls.CurrStuNumValid)
{
return mintCurrStuNumValid;
}
else if (strAttributeName  ==  convCurrEduCls.CurrStuNum)
{
return mintCurrStuNum;
}
return null;
}
set
{
if (strAttributeName  ==  convCurrEduCls.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdCurrEduCls);
}
else if (strAttributeName  ==  convCurrEduCls.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduCls.CurrEduClsId);
}
else if (strAttributeName  ==  convCurrEduCls.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduCls.EduClsName);
}
else if (strAttributeName  ==  convCurrEduCls.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls.EduClsTypeId);
}
else if (strAttributeName  ==  convCurrEduCls.EduClsTypeName)
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(convCurrEduCls.EduClsTypeName);
}
else if (strAttributeName  ==  convCurrEduCls.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseId);
}
else if (strAttributeName  ==  convCurrEduCls.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseCode);
}
else if (strAttributeName  ==  convCurrEduCls.CourseDescription)
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseDescription);
}
else if (strAttributeName  ==  convCurrEduCls.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseName);
}
else if (strAttributeName  ==  convCurrEduCls.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.ViewCount);
}
else if (strAttributeName  ==  convCurrEduCls.ExampleImgPath)
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convCurrEduCls.ExampleImgPath);
}
else if (strAttributeName  ==  convCurrEduCls.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCurrEduCls.TeachingSolutionId);
}
else if (strAttributeName  ==  convCurrEduCls.TeachingSolutionName)
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convCurrEduCls.TeachingSolutionName);
}
else if (strAttributeName  ==  convCurrEduCls.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdTeacher);
}
else if (strAttributeName  ==  convCurrEduCls.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convCurrEduCls.TeacherId);
}
else if (strAttributeName  ==  convCurrEduCls.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convCurrEduCls.TeacherName);
}
else if (strAttributeName  ==  convCurrEduCls.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdXzCollege);
}
else if (strAttributeName  ==  convCurrEduCls.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCurrEduCls.CollegeId);
}
else if (strAttributeName  ==  convCurrEduCls.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCurrEduCls.CollegeName);
}
else if (strAttributeName  ==  convCurrEduCls.ClgEnglishName)
{
mstrClgEnglishName = value.ToString();
 AddUpdatedFld(convCurrEduCls.ClgEnglishName);
}
else if (strAttributeName  ==  convCurrEduCls.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convCurrEduCls.PhoneNumber);
}
else if (strAttributeName  ==  convCurrEduCls.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdXzMajor);
}
else if (strAttributeName  ==  convCurrEduCls.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCurrEduCls.MajorName);
}
else if (strAttributeName  ==  convCurrEduCls.IdEduWay)
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdEduWay);
}
else if (strAttributeName  ==  convCurrEduCls.IdClassRoomType)
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdClassRoomType);
}
else if (strAttributeName  ==  convCurrEduCls.TotalLessonQty)
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.TotalLessonQty);
}
else if (strAttributeName  ==  convCurrEduCls.MaxStuQty)
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.MaxStuQty);
}
else if (strAttributeName  ==  convCurrEduCls.WeekQty)
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.WeekQty);
}
else if (strAttributeName  ==  convCurrEduCls.ScheUnitPW)
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls.ScheUnitPW);
}
else if (strAttributeName  ==  convCurrEduCls.WeekStatusId)
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(convCurrEduCls.WeekStatusId);
}
else if (strAttributeName  ==  convCurrEduCls.CustomerWeek)
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(convCurrEduCls.CustomerWeek);
}
else if (strAttributeName  ==  convCurrEduCls.LessonQtyPerWeek)
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls.LessonQtyPerWeek);
}
else if (strAttributeName  ==  convCurrEduCls.Mark)
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduCls.Mark);
}
else if (strAttributeName  ==  convCurrEduCls.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdUniZone);
}
else if (strAttributeName  ==  convCurrEduCls.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdGradeBase);
}
else if (strAttributeName  ==  convCurrEduCls.GradeBaseId)
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convCurrEduCls.GradeBaseId);
}
else if (strAttributeName  ==  convCurrEduCls.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCurrEduCls.GradeBaseName);
}
else if (strAttributeName  ==  convCurrEduCls.GradeBaseNameA)
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(convCurrEduCls.GradeBaseNameA);
}
else if (strAttributeName  ==  convCurrEduCls.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls.IsEffective);
}
else if (strAttributeName  ==  convCurrEduCls.IsForPaperReading)
{
mbolIsForPaperReading = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls.IsForPaperReading);
}
else if (strAttributeName  ==  convCurrEduCls.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convCurrEduCls.SchoolYear);
}
else if (strAttributeName  ==  convCurrEduCls.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convCurrEduCls.SchoolTerm);
}
else if (strAttributeName  ==  convCurrEduCls.IdCourseType)
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdCourseType);
}
else if (strAttributeName  ==  convCurrEduCls.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseTypeId);
}
else if (strAttributeName  ==  convCurrEduCls.CourseTypeName)
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseTypeName);
}
else if (strAttributeName  ==  convCurrEduCls.IsDegree)
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls.IsDegree);
}
else if (strAttributeName  ==  convCurrEduCls.IdScoreType)
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdScoreType);
}
else if (strAttributeName  ==  convCurrEduCls.GetScoreWayId)
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(convCurrEduCls.GetScoreWayId);
}
else if (strAttributeName  ==  convCurrEduCls.IsProportionalCtrl)
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls.IsProportionalCtrl);
}
else if (strAttributeName  ==  convCurrEduCls.IdExamType)
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdExamType);
}
else if (strAttributeName  ==  convCurrEduCls.BeginWeek)
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls.BeginWeek);
}
else if (strAttributeName  ==  convCurrEduCls.UserType)
{
mstrUserType = value.ToString();
 AddUpdatedFld(convCurrEduCls.UserType);
}
else if (strAttributeName  ==  convCurrEduCls.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convCurrEduCls.ModifyDate);
}
else if (strAttributeName  ==  convCurrEduCls.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convCurrEduCls.ModifyUserId);
}
else if (strAttributeName  ==  convCurrEduCls.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCurrEduCls.Memo);
}
else if (strAttributeName  ==  convCurrEduCls.CurrStuNumValid)
{
mintCurrStuNumValid = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.CurrStuNumValid);
}
else if (strAttributeName  ==  convCurrEduCls.CurrStuNum)
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.CurrStuNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convCurrEduCls.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convCurrEduCls.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convCurrEduCls.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convCurrEduCls.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (convCurrEduCls.EduClsTypeName  ==  AttributeName[intIndex])
{
return mstrEduClsTypeName;
}
else if (convCurrEduCls.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCurrEduCls.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCurrEduCls.CourseDescription  ==  AttributeName[intIndex])
{
return mstrCourseDescription;
}
else if (convCurrEduCls.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCurrEduCls.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convCurrEduCls.ExampleImgPath  ==  AttributeName[intIndex])
{
return mstrExampleImgPath;
}
else if (convCurrEduCls.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (convCurrEduCls.TeachingSolutionName  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionName;
}
else if (convCurrEduCls.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (convCurrEduCls.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (convCurrEduCls.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convCurrEduCls.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCurrEduCls.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convCurrEduCls.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCurrEduCls.ClgEnglishName  ==  AttributeName[intIndex])
{
return mstrClgEnglishName;
}
else if (convCurrEduCls.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (convCurrEduCls.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCurrEduCls.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCurrEduCls.IdEduWay  ==  AttributeName[intIndex])
{
return mstrIdEduWay;
}
else if (convCurrEduCls.IdClassRoomType  ==  AttributeName[intIndex])
{
return mstrIdClassRoomType;
}
else if (convCurrEduCls.TotalLessonQty  ==  AttributeName[intIndex])
{
return mintTotalLessonQty;
}
else if (convCurrEduCls.MaxStuQty  ==  AttributeName[intIndex])
{
return mintMaxStuQty;
}
else if (convCurrEduCls.WeekQty  ==  AttributeName[intIndex])
{
return mintWeekQty;
}
else if (convCurrEduCls.ScheUnitPW  ==  AttributeName[intIndex])
{
return mshtScheUnitPW;
}
else if (convCurrEduCls.WeekStatusId  ==  AttributeName[intIndex])
{
return mstrWeekStatusId;
}
else if (convCurrEduCls.CustomerWeek  ==  AttributeName[intIndex])
{
return mstrCustomerWeek;
}
else if (convCurrEduCls.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
return mshtLessonQtyPerWeek;
}
else if (convCurrEduCls.Mark  ==  AttributeName[intIndex])
{
return mdblMark;
}
else if (convCurrEduCls.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (convCurrEduCls.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convCurrEduCls.GradeBaseId  ==  AttributeName[intIndex])
{
return mstrGradeBaseId;
}
else if (convCurrEduCls.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convCurrEduCls.GradeBaseNameA  ==  AttributeName[intIndex])
{
return mstrGradeBaseNameA;
}
else if (convCurrEduCls.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (convCurrEduCls.IsForPaperReading  ==  AttributeName[intIndex])
{
return mbolIsForPaperReading;
}
else if (convCurrEduCls.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convCurrEduCls.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convCurrEduCls.IdCourseType  ==  AttributeName[intIndex])
{
return mstrIdCourseType;
}
else if (convCurrEduCls.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (convCurrEduCls.CourseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseTypeName;
}
else if (convCurrEduCls.IsDegree  ==  AttributeName[intIndex])
{
return mbolIsDegree;
}
else if (convCurrEduCls.IdScoreType  ==  AttributeName[intIndex])
{
return mstrIdScoreType;
}
else if (convCurrEduCls.GetScoreWayId  ==  AttributeName[intIndex])
{
return mstrGetScoreWayId;
}
else if (convCurrEduCls.IsProportionalCtrl  ==  AttributeName[intIndex])
{
return mbolIsProportionalCtrl;
}
else if (convCurrEduCls.IdExamType  ==  AttributeName[intIndex])
{
return mstrIdExamType;
}
else if (convCurrEduCls.BeginWeek  ==  AttributeName[intIndex])
{
return mshtBeginWeek;
}
else if (convCurrEduCls.UserType  ==  AttributeName[intIndex])
{
return mstrUserType;
}
else if (convCurrEduCls.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convCurrEduCls.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convCurrEduCls.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCurrEduCls.CurrStuNumValid  ==  AttributeName[intIndex])
{
return mintCurrStuNumValid;
}
else if (convCurrEduCls.CurrStuNum  ==  AttributeName[intIndex])
{
return mintCurrStuNum;
}
return null;
}
set
{
if (convCurrEduCls.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdCurrEduCls);
}
else if (convCurrEduCls.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduCls.CurrEduClsId);
}
else if (convCurrEduCls.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduCls.EduClsName);
}
else if (convCurrEduCls.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls.EduClsTypeId);
}
else if (convCurrEduCls.EduClsTypeName  ==  AttributeName[intIndex])
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(convCurrEduCls.EduClsTypeName);
}
else if (convCurrEduCls.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseId);
}
else if (convCurrEduCls.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseCode);
}
else if (convCurrEduCls.CourseDescription  ==  AttributeName[intIndex])
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseDescription);
}
else if (convCurrEduCls.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseName);
}
else if (convCurrEduCls.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.ViewCount);
}
else if (convCurrEduCls.ExampleImgPath  ==  AttributeName[intIndex])
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convCurrEduCls.ExampleImgPath);
}
else if (convCurrEduCls.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCurrEduCls.TeachingSolutionId);
}
else if (convCurrEduCls.TeachingSolutionName  ==  AttributeName[intIndex])
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convCurrEduCls.TeachingSolutionName);
}
else if (convCurrEduCls.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdTeacher);
}
else if (convCurrEduCls.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convCurrEduCls.TeacherId);
}
else if (convCurrEduCls.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convCurrEduCls.TeacherName);
}
else if (convCurrEduCls.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdXzCollege);
}
else if (convCurrEduCls.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCurrEduCls.CollegeId);
}
else if (convCurrEduCls.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCurrEduCls.CollegeName);
}
else if (convCurrEduCls.ClgEnglishName  ==  AttributeName[intIndex])
{
mstrClgEnglishName = value.ToString();
 AddUpdatedFld(convCurrEduCls.ClgEnglishName);
}
else if (convCurrEduCls.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convCurrEduCls.PhoneNumber);
}
else if (convCurrEduCls.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdXzMajor);
}
else if (convCurrEduCls.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCurrEduCls.MajorName);
}
else if (convCurrEduCls.IdEduWay  ==  AttributeName[intIndex])
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdEduWay);
}
else if (convCurrEduCls.IdClassRoomType  ==  AttributeName[intIndex])
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdClassRoomType);
}
else if (convCurrEduCls.TotalLessonQty  ==  AttributeName[intIndex])
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.TotalLessonQty);
}
else if (convCurrEduCls.MaxStuQty  ==  AttributeName[intIndex])
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.MaxStuQty);
}
else if (convCurrEduCls.WeekQty  ==  AttributeName[intIndex])
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.WeekQty);
}
else if (convCurrEduCls.ScheUnitPW  ==  AttributeName[intIndex])
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls.ScheUnitPW);
}
else if (convCurrEduCls.WeekStatusId  ==  AttributeName[intIndex])
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(convCurrEduCls.WeekStatusId);
}
else if (convCurrEduCls.CustomerWeek  ==  AttributeName[intIndex])
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(convCurrEduCls.CustomerWeek);
}
else if (convCurrEduCls.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls.LessonQtyPerWeek);
}
else if (convCurrEduCls.Mark  ==  AttributeName[intIndex])
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduCls.Mark);
}
else if (convCurrEduCls.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdUniZone);
}
else if (convCurrEduCls.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdGradeBase);
}
else if (convCurrEduCls.GradeBaseId  ==  AttributeName[intIndex])
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convCurrEduCls.GradeBaseId);
}
else if (convCurrEduCls.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCurrEduCls.GradeBaseName);
}
else if (convCurrEduCls.GradeBaseNameA  ==  AttributeName[intIndex])
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(convCurrEduCls.GradeBaseNameA);
}
else if (convCurrEduCls.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls.IsEffective);
}
else if (convCurrEduCls.IsForPaperReading  ==  AttributeName[intIndex])
{
mbolIsForPaperReading = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls.IsForPaperReading);
}
else if (convCurrEduCls.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convCurrEduCls.SchoolYear);
}
else if (convCurrEduCls.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convCurrEduCls.SchoolTerm);
}
else if (convCurrEduCls.IdCourseType  ==  AttributeName[intIndex])
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdCourseType);
}
else if (convCurrEduCls.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseTypeId);
}
else if (convCurrEduCls.CourseTypeName  ==  AttributeName[intIndex])
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convCurrEduCls.CourseTypeName);
}
else if (convCurrEduCls.IsDegree  ==  AttributeName[intIndex])
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls.IsDegree);
}
else if (convCurrEduCls.IdScoreType  ==  AttributeName[intIndex])
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdScoreType);
}
else if (convCurrEduCls.GetScoreWayId  ==  AttributeName[intIndex])
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(convCurrEduCls.GetScoreWayId);
}
else if (convCurrEduCls.IsProportionalCtrl  ==  AttributeName[intIndex])
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduCls.IsProportionalCtrl);
}
else if (convCurrEduCls.IdExamType  ==  AttributeName[intIndex])
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(convCurrEduCls.IdExamType);
}
else if (convCurrEduCls.BeginWeek  ==  AttributeName[intIndex])
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduCls.BeginWeek);
}
else if (convCurrEduCls.UserType  ==  AttributeName[intIndex])
{
mstrUserType = value.ToString();
 AddUpdatedFld(convCurrEduCls.UserType);
}
else if (convCurrEduCls.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convCurrEduCls.ModifyDate);
}
else if (convCurrEduCls.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convCurrEduCls.ModifyUserId);
}
else if (convCurrEduCls.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCurrEduCls.Memo);
}
else if (convCurrEduCls.CurrStuNumValid  ==  AttributeName[intIndex])
{
mintCurrStuNumValid = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.CurrStuNumValid);
}
else if (convCurrEduCls.CurrStuNum  ==  AttributeName[intIndex])
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduCls.CurrStuNum);
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
 AddUpdatedFld(convCurrEduCls.IdCurrEduCls);
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
 AddUpdatedFld(convCurrEduCls.CurrEduClsId);
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
 AddUpdatedFld(convCurrEduCls.EduClsName);
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
 AddUpdatedFld(convCurrEduCls.EduClsTypeId);
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
 AddUpdatedFld(convCurrEduCls.EduClsTypeName);
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
 AddUpdatedFld(convCurrEduCls.CourseId);
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
 AddUpdatedFld(convCurrEduCls.CourseCode);
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
 AddUpdatedFld(convCurrEduCls.CourseDescription);
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
 AddUpdatedFld(convCurrEduCls.CourseName);
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
 AddUpdatedFld(convCurrEduCls.ViewCount);
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
 AddUpdatedFld(convCurrEduCls.ExampleImgPath);
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
 AddUpdatedFld(convCurrEduCls.TeachingSolutionId);
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
 AddUpdatedFld(convCurrEduCls.TeachingSolutionName);
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
 AddUpdatedFld(convCurrEduCls.IdTeacher);
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
 AddUpdatedFld(convCurrEduCls.TeacherId);
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
 AddUpdatedFld(convCurrEduCls.TeacherName);
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
 AddUpdatedFld(convCurrEduCls.IdXzCollege);
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
 AddUpdatedFld(convCurrEduCls.CollegeId);
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
 AddUpdatedFld(convCurrEduCls.CollegeName);
}
}
/// <summary>
/// ClgEnglishName(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClgEnglishName
{
get
{
return mstrClgEnglishName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClgEnglishName = value;
}
else
{
 mstrClgEnglishName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls.ClgEnglishName);
}
}
/// <summary>
/// 电话(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhoneNumber
{
get
{
return mstrPhoneNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhoneNumber = value;
}
else
{
 mstrPhoneNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduCls.PhoneNumber);
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
 AddUpdatedFld(convCurrEduCls.IdXzMajor);
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
 AddUpdatedFld(convCurrEduCls.MajorName);
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
 AddUpdatedFld(convCurrEduCls.IdEduWay);
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
 AddUpdatedFld(convCurrEduCls.IdClassRoomType);
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
 AddUpdatedFld(convCurrEduCls.TotalLessonQty);
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
 AddUpdatedFld(convCurrEduCls.MaxStuQty);
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
 AddUpdatedFld(convCurrEduCls.WeekQty);
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
 AddUpdatedFld(convCurrEduCls.ScheUnitPW);
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
 AddUpdatedFld(convCurrEduCls.WeekStatusId);
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
 AddUpdatedFld(convCurrEduCls.CustomerWeek);
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
 AddUpdatedFld(convCurrEduCls.LessonQtyPerWeek);
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
 AddUpdatedFld(convCurrEduCls.Mark);
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
 AddUpdatedFld(convCurrEduCls.IdUniZone);
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
 AddUpdatedFld(convCurrEduCls.IdGradeBase);
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
 AddUpdatedFld(convCurrEduCls.GradeBaseId);
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
 AddUpdatedFld(convCurrEduCls.GradeBaseName);
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
 AddUpdatedFld(convCurrEduCls.GradeBaseNameA);
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
 AddUpdatedFld(convCurrEduCls.IsEffective);
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
 AddUpdatedFld(convCurrEduCls.IsForPaperReading);
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
 AddUpdatedFld(convCurrEduCls.SchoolYear);
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
 AddUpdatedFld(convCurrEduCls.SchoolTerm);
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
 AddUpdatedFld(convCurrEduCls.IdCourseType);
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
 AddUpdatedFld(convCurrEduCls.CourseTypeId);
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
 AddUpdatedFld(convCurrEduCls.CourseTypeName);
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
 AddUpdatedFld(convCurrEduCls.IsDegree);
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
 AddUpdatedFld(convCurrEduCls.IdScoreType);
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
 AddUpdatedFld(convCurrEduCls.GetScoreWayId);
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
 AddUpdatedFld(convCurrEduCls.IsProportionalCtrl);
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
 AddUpdatedFld(convCurrEduCls.IdExamType);
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
 AddUpdatedFld(convCurrEduCls.BeginWeek);
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
 AddUpdatedFld(convCurrEduCls.UserType);
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
 AddUpdatedFld(convCurrEduCls.ModifyDate);
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
 AddUpdatedFld(convCurrEduCls.ModifyUserId);
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
 AddUpdatedFld(convCurrEduCls.Memo);
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
 AddUpdatedFld(convCurrEduCls.CurrStuNumValid);
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
 AddUpdatedFld(convCurrEduCls.CurrStuNum);
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
 /// v当前教学班(vCurrEduCls)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCurrEduCls
{
public const string _CurrTabName = "vCurrEduCls"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "EduClsTypeName", "CourseId", "CourseCode", "CourseDescription", "CourseName", "ViewCount", "ExampleImgPath", "TeachingSolutionId", "TeachingSolutionName", "IdTeacher", "TeacherId", "TeacherName", "IdXzCollege", "CollegeId", "CollegeName", "ClgEnglishName", "PhoneNumber", "IdXzMajor", "MajorName", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "LessonQtyPerWeek", "Mark", "IdUniZone", "IdGradeBase", "GradeBaseId", "GradeBaseName", "GradeBaseNameA", "IsEffective", "IsForPaperReading", "SchoolYear", "SchoolTerm", "IdCourseType", "CourseTypeId", "CourseTypeName", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IdExamType", "BeginWeek", "UserType", "ModifyDate", "ModifyUserId", "Memo", "CurrStuNumValid", "CurrStuNum"};
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
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"ClgEnglishName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClgEnglishName = "ClgEnglishName";    //ClgEnglishName

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //电话

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
 /// 常量:"GradeBaseNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseNameA = "GradeBaseNameA";    //年级名称缩写

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
 /// 常量:"BeginWeek"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BeginWeek = "BeginWeek";    //开始周

 /// <summary>
 /// 常量:"UserType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserType = "UserType";    //用户类型

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
 /// 常量:"CurrStuNumValid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrStuNumValid = "CurrStuNumValid";    //CurrStuNum_Valid

 /// <summary>
 /// 常量:"CurrStuNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrStuNum = "CurrStuNum";    //当前学生数
}

}