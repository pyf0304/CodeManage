
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsStuEN
 表名:vCurrEduClsStu(01120127)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 17:50:16
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
 /// 表vCurrEduClsStu的关键字(IdEduClsStu)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduClsStu_vCurrEduClsStu
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdEduClsStu">表关键字</param>
public K_IdEduClsStu_vCurrEduClsStu(long lngIdEduClsStu)
{
if (IsValid(lngIdEduClsStu)) Value = lngIdEduClsStu;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdEduClsStu)
{
if (lngIdEduClsStu == 0) return false;
if (lngIdEduClsStu == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEduClsStu_vCurrEduClsStu]类型的对象</returns>
public static implicit operator K_IdEduClsStu_vCurrEduClsStu(long value)
{
return new K_IdEduClsStu_vCurrEduClsStu(value);
}
}
 /// <summary>
 /// v教学班与学生关系(vCurrEduClsStu)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCurrEduClsStuEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCurrEduClsStu"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduClsStu"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 50;
public static string[] AttributeName = new string[] {"IdEduClsStu", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "CourseId", "CourseCode", "CourseName", "TeachingSolutionId", "TeachingSolutionName", "IdXzCollege", "CollegeId", "CollegeName", "LessonQtyPerWeek", "Mark", "IdUniZone", "GradeBaseName", "IsEffective", "IdCourseType", "CourseTypeId", "CourseTypeName", "IsDegree", "CurrStuNum", "IdStu", "StuId", "StuName", "IdSex", "SexDesc", "MajorID", "MajorName", "IdAdminCls", "Birthday", "EduClsStuStateId", "GetScoreTimes", "Score", "TotalScores", "Ranking", "Percentile", "Confirmed", "SchoolTerm", "SchoolYear", "SignInDate", "SignInStateID", "SignInUser", "ModifyDate", "ModifyUserId", "CollegeName4Stu", "EduClsTypeName", "IsSynScore", "EduClsTypeId", "UserType"};

protected long mlngIdEduClsStu;    //教学班学生流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrTeachingSolutionName;    //教学方案名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected short? mshtLessonQtyPerWeek;    //周课时数
protected double? mdblMark;    //获得学分
protected string mstrIdUniZone;    //校区流水号
protected string mstrGradeBaseName;    //年级名称
protected bool mbolIsEffective;    //是否有效
protected string mstrIdCourseType;    //课程类型流水号
protected string mstrCourseTypeId;    //课程类型ID
protected string mstrCourseTypeName;    //课程类型名称
protected bool mbolIsDegree;    //是否学位课
protected int? mintCurrStuNum;    //当前学生数
protected string mstrIdStu;    //学生流水号
protected string mstrStuId;    //学号
protected string mstrStuName;    //姓名
protected string mstrIdSex;    //性别流水号
protected string mstrSexDesc;    //性别名称
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrIdAdminCls;    //行政班流水号
protected string mstrBirthday;    //出生日期
protected string mstrEduClsStuStateId;    //教学班学生状态编号
protected short? mshtGetScoreTimes;    //获得成绩次数
protected double? mdblScore;    //得分
protected double? mdblTotalScores;    //总分值
protected int? mintRanking;    //名次
protected double? mdblPercentile;    //百分位
protected bool mbolConfirmed;    //是否确认
protected string mstrSchoolTerm;    //学期
protected string mstrSchoolYear;    //学年
protected string mstrSignInDate;    //签入时间
protected string mstrSignInStateID;    //签入状态表流水号
protected string mstrSignInUser;    //签入人
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrCollegeName4Stu;    //CollegeName4Stu
protected string mstrEduClsTypeName;    //教学班类型名称
protected bool mbolIsSynScore;    //是否同步成绩
protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrUserType;    //用户类型

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCurrEduClsStuEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduClsStu");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdEduClsStu">关键字:教学班学生流水号</param>
public clsvCurrEduClsStuEN(long lngIdEduClsStu)
 {
 if (lngIdEduClsStu  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdEduClsStu = lngIdEduClsStu;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduClsStu");
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
if (strAttributeName  ==  convCurrEduClsStu.IdEduClsStu)
{
return mlngIdEduClsStu;
}
else if (strAttributeName  ==  convCurrEduClsStu.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convCurrEduClsStu.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convCurrEduClsStu.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCurrEduClsStu.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  convCurrEduClsStu.TeachingSolutionName)
{
return mstrTeachingSolutionName;
}
else if (strAttributeName  ==  convCurrEduClsStu.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCurrEduClsStu.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convCurrEduClsStu.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCurrEduClsStu.LessonQtyPerWeek)
{
return mshtLessonQtyPerWeek;
}
else if (strAttributeName  ==  convCurrEduClsStu.Mark)
{
return mdblMark;
}
else if (strAttributeName  ==  convCurrEduClsStu.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  convCurrEduClsStu.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convCurrEduClsStu.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  convCurrEduClsStu.IdCourseType)
{
return mstrIdCourseType;
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseTypeName)
{
return mstrCourseTypeName;
}
else if (strAttributeName  ==  convCurrEduClsStu.IsDegree)
{
return mbolIsDegree;
}
else if (strAttributeName  ==  convCurrEduClsStu.CurrStuNum)
{
return mintCurrStuNum;
}
else if (strAttributeName  ==  convCurrEduClsStu.IdStu)
{
return mstrIdStu;
}
else if (strAttributeName  ==  convCurrEduClsStu.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  convCurrEduClsStu.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convCurrEduClsStu.IdSex)
{
return mstrIdSex;
}
else if (strAttributeName  ==  convCurrEduClsStu.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convCurrEduClsStu.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convCurrEduClsStu.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCurrEduClsStu.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convCurrEduClsStu.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convCurrEduClsStu.EduClsStuStateId)
{
return mstrEduClsStuStateId;
}
else if (strAttributeName  ==  convCurrEduClsStu.GetScoreTimes)
{
return mshtGetScoreTimes;
}
else if (strAttributeName  ==  convCurrEduClsStu.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  convCurrEduClsStu.TotalScores)
{
return mdblTotalScores;
}
else if (strAttributeName  ==  convCurrEduClsStu.Ranking)
{
return mintRanking;
}
else if (strAttributeName  ==  convCurrEduClsStu.Percentile)
{
return mdblPercentile;
}
else if (strAttributeName  ==  convCurrEduClsStu.Confirmed)
{
return mbolConfirmed;
}
else if (strAttributeName  ==  convCurrEduClsStu.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convCurrEduClsStu.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convCurrEduClsStu.SignInDate)
{
return mstrSignInDate;
}
else if (strAttributeName  ==  convCurrEduClsStu.SignInStateID)
{
return mstrSignInStateID;
}
else if (strAttributeName  ==  convCurrEduClsStu.SignInUser)
{
return mstrSignInUser;
}
else if (strAttributeName  ==  convCurrEduClsStu.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convCurrEduClsStu.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convCurrEduClsStu.CollegeName4Stu)
{
return mstrCollegeName4Stu;
}
else if (strAttributeName  ==  convCurrEduClsStu.EduClsTypeName)
{
return mstrEduClsTypeName;
}
else if (strAttributeName  ==  convCurrEduClsStu.IsSynScore)
{
return mbolIsSynScore;
}
else if (strAttributeName  ==  convCurrEduClsStu.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  convCurrEduClsStu.UserType)
{
return mstrUserType;
}
return null;
}
set
{
if (strAttributeName  ==  convCurrEduClsStu.IdEduClsStu)
{
mlngIdEduClsStu = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.IdEduClsStu);
}
else if (strAttributeName  ==  convCurrEduClsStu.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdCurrEduCls);
}
else if (strAttributeName  ==  convCurrEduClsStu.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CurrEduClsId);
}
else if (strAttributeName  ==  convCurrEduClsStu.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.EduClsName);
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseId);
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseCode);
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseName);
}
else if (strAttributeName  ==  convCurrEduClsStu.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.TeachingSolutionId);
}
else if (strAttributeName  ==  convCurrEduClsStu.TeachingSolutionName)
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.TeachingSolutionName);
}
else if (strAttributeName  ==  convCurrEduClsStu.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdXzCollege);
}
else if (strAttributeName  ==  convCurrEduClsStu.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CollegeId);
}
else if (strAttributeName  ==  convCurrEduClsStu.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CollegeName);
}
else if (strAttributeName  ==  convCurrEduClsStu.LessonQtyPerWeek)
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.LessonQtyPerWeek);
}
else if (strAttributeName  ==  convCurrEduClsStu.Mark)
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Mark);
}
else if (strAttributeName  ==  convCurrEduClsStu.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdUniZone);
}
else if (strAttributeName  ==  convCurrEduClsStu.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.GradeBaseName);
}
else if (strAttributeName  ==  convCurrEduClsStu.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.IsEffective);
}
else if (strAttributeName  ==  convCurrEduClsStu.IdCourseType)
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdCourseType);
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseTypeId);
}
else if (strAttributeName  ==  convCurrEduClsStu.CourseTypeName)
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseTypeName);
}
else if (strAttributeName  ==  convCurrEduClsStu.IsDegree)
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.IsDegree);
}
else if (strAttributeName  ==  convCurrEduClsStu.CurrStuNum)
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.CurrStuNum);
}
else if (strAttributeName  ==  convCurrEduClsStu.IdStu)
{
mstrIdStu = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdStu);
}
else if (strAttributeName  ==  convCurrEduClsStu.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.StuId);
}
else if (strAttributeName  ==  convCurrEduClsStu.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.StuName);
}
else if (strAttributeName  ==  convCurrEduClsStu.IdSex)
{
mstrIdSex = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdSex);
}
else if (strAttributeName  ==  convCurrEduClsStu.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SexDesc);
}
else if (strAttributeName  ==  convCurrEduClsStu.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.MajorID);
}
else if (strAttributeName  ==  convCurrEduClsStu.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.MajorName);
}
else if (strAttributeName  ==  convCurrEduClsStu.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdAdminCls);
}
else if (strAttributeName  ==  convCurrEduClsStu.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.Birthday);
}
else if (strAttributeName  ==  convCurrEduClsStu.EduClsStuStateId)
{
mstrEduClsStuStateId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.EduClsStuStateId);
}
else if (strAttributeName  ==  convCurrEduClsStu.GetScoreTimes)
{
mshtGetScoreTimes = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.GetScoreTimes);
}
else if (strAttributeName  ==  convCurrEduClsStu.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Score);
}
else if (strAttributeName  ==  convCurrEduClsStu.TotalScores)
{
mdblTotalScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.TotalScores);
}
else if (strAttributeName  ==  convCurrEduClsStu.Ranking)
{
mintRanking = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Ranking);
}
else if (strAttributeName  ==  convCurrEduClsStu.Percentile)
{
mdblPercentile = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Percentile);
}
else if (strAttributeName  ==  convCurrEduClsStu.Confirmed)
{
mbolConfirmed = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Confirmed);
}
else if (strAttributeName  ==  convCurrEduClsStu.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SchoolTerm);
}
else if (strAttributeName  ==  convCurrEduClsStu.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SchoolYear);
}
else if (strAttributeName  ==  convCurrEduClsStu.SignInDate)
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SignInDate);
}
else if (strAttributeName  ==  convCurrEduClsStu.SignInStateID)
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SignInStateID);
}
else if (strAttributeName  ==  convCurrEduClsStu.SignInUser)
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SignInUser);
}
else if (strAttributeName  ==  convCurrEduClsStu.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.ModifyDate);
}
else if (strAttributeName  ==  convCurrEduClsStu.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.ModifyUserId);
}
else if (strAttributeName  ==  convCurrEduClsStu.CollegeName4Stu)
{
mstrCollegeName4Stu = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CollegeName4Stu);
}
else if (strAttributeName  ==  convCurrEduClsStu.EduClsTypeName)
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.EduClsTypeName);
}
else if (strAttributeName  ==  convCurrEduClsStu.IsSynScore)
{
mbolIsSynScore = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.IsSynScore);
}
else if (strAttributeName  ==  convCurrEduClsStu.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.EduClsTypeId);
}
else if (strAttributeName  ==  convCurrEduClsStu.UserType)
{
mstrUserType = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.UserType);
}
}
}
public object this[int intIndex]
{
get
{
if (convCurrEduClsStu.IdEduClsStu  ==  AttributeName[intIndex])
{
return mlngIdEduClsStu;
}
else if (convCurrEduClsStu.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convCurrEduClsStu.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convCurrEduClsStu.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convCurrEduClsStu.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCurrEduClsStu.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCurrEduClsStu.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCurrEduClsStu.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (convCurrEduClsStu.TeachingSolutionName  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionName;
}
else if (convCurrEduClsStu.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCurrEduClsStu.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convCurrEduClsStu.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCurrEduClsStu.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
return mshtLessonQtyPerWeek;
}
else if (convCurrEduClsStu.Mark  ==  AttributeName[intIndex])
{
return mdblMark;
}
else if (convCurrEduClsStu.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (convCurrEduClsStu.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convCurrEduClsStu.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (convCurrEduClsStu.IdCourseType  ==  AttributeName[intIndex])
{
return mstrIdCourseType;
}
else if (convCurrEduClsStu.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (convCurrEduClsStu.CourseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseTypeName;
}
else if (convCurrEduClsStu.IsDegree  ==  AttributeName[intIndex])
{
return mbolIsDegree;
}
else if (convCurrEduClsStu.CurrStuNum  ==  AttributeName[intIndex])
{
return mintCurrStuNum;
}
else if (convCurrEduClsStu.IdStu  ==  AttributeName[intIndex])
{
return mstrIdStu;
}
else if (convCurrEduClsStu.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (convCurrEduClsStu.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convCurrEduClsStu.IdSex  ==  AttributeName[intIndex])
{
return mstrIdSex;
}
else if (convCurrEduClsStu.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convCurrEduClsStu.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convCurrEduClsStu.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCurrEduClsStu.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convCurrEduClsStu.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convCurrEduClsStu.EduClsStuStateId  ==  AttributeName[intIndex])
{
return mstrEduClsStuStateId;
}
else if (convCurrEduClsStu.GetScoreTimes  ==  AttributeName[intIndex])
{
return mshtGetScoreTimes;
}
else if (convCurrEduClsStu.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (convCurrEduClsStu.TotalScores  ==  AttributeName[intIndex])
{
return mdblTotalScores;
}
else if (convCurrEduClsStu.Ranking  ==  AttributeName[intIndex])
{
return mintRanking;
}
else if (convCurrEduClsStu.Percentile  ==  AttributeName[intIndex])
{
return mdblPercentile;
}
else if (convCurrEduClsStu.Confirmed  ==  AttributeName[intIndex])
{
return mbolConfirmed;
}
else if (convCurrEduClsStu.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convCurrEduClsStu.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convCurrEduClsStu.SignInDate  ==  AttributeName[intIndex])
{
return mstrSignInDate;
}
else if (convCurrEduClsStu.SignInStateID  ==  AttributeName[intIndex])
{
return mstrSignInStateID;
}
else if (convCurrEduClsStu.SignInUser  ==  AttributeName[intIndex])
{
return mstrSignInUser;
}
else if (convCurrEduClsStu.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convCurrEduClsStu.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convCurrEduClsStu.CollegeName4Stu  ==  AttributeName[intIndex])
{
return mstrCollegeName4Stu;
}
else if (convCurrEduClsStu.EduClsTypeName  ==  AttributeName[intIndex])
{
return mstrEduClsTypeName;
}
else if (convCurrEduClsStu.IsSynScore  ==  AttributeName[intIndex])
{
return mbolIsSynScore;
}
else if (convCurrEduClsStu.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (convCurrEduClsStu.UserType  ==  AttributeName[intIndex])
{
return mstrUserType;
}
return null;
}
set
{
if (convCurrEduClsStu.IdEduClsStu  ==  AttributeName[intIndex])
{
mlngIdEduClsStu = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.IdEduClsStu);
}
else if (convCurrEduClsStu.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdCurrEduCls);
}
else if (convCurrEduClsStu.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CurrEduClsId);
}
else if (convCurrEduClsStu.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.EduClsName);
}
else if (convCurrEduClsStu.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseId);
}
else if (convCurrEduClsStu.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseCode);
}
else if (convCurrEduClsStu.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseName);
}
else if (convCurrEduClsStu.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.TeachingSolutionId);
}
else if (convCurrEduClsStu.TeachingSolutionName  ==  AttributeName[intIndex])
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.TeachingSolutionName);
}
else if (convCurrEduClsStu.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdXzCollege);
}
else if (convCurrEduClsStu.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CollegeId);
}
else if (convCurrEduClsStu.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CollegeName);
}
else if (convCurrEduClsStu.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.LessonQtyPerWeek);
}
else if (convCurrEduClsStu.Mark  ==  AttributeName[intIndex])
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Mark);
}
else if (convCurrEduClsStu.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdUniZone);
}
else if (convCurrEduClsStu.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.GradeBaseName);
}
else if (convCurrEduClsStu.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.IsEffective);
}
else if (convCurrEduClsStu.IdCourseType  ==  AttributeName[intIndex])
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdCourseType);
}
else if (convCurrEduClsStu.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseTypeId);
}
else if (convCurrEduClsStu.CourseTypeName  ==  AttributeName[intIndex])
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CourseTypeName);
}
else if (convCurrEduClsStu.IsDegree  ==  AttributeName[intIndex])
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.IsDegree);
}
else if (convCurrEduClsStu.CurrStuNum  ==  AttributeName[intIndex])
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.CurrStuNum);
}
else if (convCurrEduClsStu.IdStu  ==  AttributeName[intIndex])
{
mstrIdStu = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdStu);
}
else if (convCurrEduClsStu.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.StuId);
}
else if (convCurrEduClsStu.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.StuName);
}
else if (convCurrEduClsStu.IdSex  ==  AttributeName[intIndex])
{
mstrIdSex = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdSex);
}
else if (convCurrEduClsStu.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SexDesc);
}
else if (convCurrEduClsStu.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.MajorID);
}
else if (convCurrEduClsStu.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.MajorName);
}
else if (convCurrEduClsStu.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.IdAdminCls);
}
else if (convCurrEduClsStu.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.Birthday);
}
else if (convCurrEduClsStu.EduClsStuStateId  ==  AttributeName[intIndex])
{
mstrEduClsStuStateId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.EduClsStuStateId);
}
else if (convCurrEduClsStu.GetScoreTimes  ==  AttributeName[intIndex])
{
mshtGetScoreTimes = TransNullToShort(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.GetScoreTimes);
}
else if (convCurrEduClsStu.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Score);
}
else if (convCurrEduClsStu.TotalScores  ==  AttributeName[intIndex])
{
mdblTotalScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.TotalScores);
}
else if (convCurrEduClsStu.Ranking  ==  AttributeName[intIndex])
{
mintRanking = TransNullToInt(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Ranking);
}
else if (convCurrEduClsStu.Percentile  ==  AttributeName[intIndex])
{
mdblPercentile = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Percentile);
}
else if (convCurrEduClsStu.Confirmed  ==  AttributeName[intIndex])
{
mbolConfirmed = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.Confirmed);
}
else if (convCurrEduClsStu.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SchoolTerm);
}
else if (convCurrEduClsStu.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SchoolYear);
}
else if (convCurrEduClsStu.SignInDate  ==  AttributeName[intIndex])
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SignInDate);
}
else if (convCurrEduClsStu.SignInStateID  ==  AttributeName[intIndex])
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SignInStateID);
}
else if (convCurrEduClsStu.SignInUser  ==  AttributeName[intIndex])
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.SignInUser);
}
else if (convCurrEduClsStu.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.ModifyDate);
}
else if (convCurrEduClsStu.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.ModifyUserId);
}
else if (convCurrEduClsStu.CollegeName4Stu  ==  AttributeName[intIndex])
{
mstrCollegeName4Stu = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.CollegeName4Stu);
}
else if (convCurrEduClsStu.EduClsTypeName  ==  AttributeName[intIndex])
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.EduClsTypeName);
}
else if (convCurrEduClsStu.IsSynScore  ==  AttributeName[intIndex])
{
mbolIsSynScore = TransNullToBool(value.ToString());
 AddUpdatedFld(convCurrEduClsStu.IsSynScore);
}
else if (convCurrEduClsStu.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.EduClsTypeId);
}
else if (convCurrEduClsStu.UserType  ==  AttributeName[intIndex])
{
mstrUserType = value.ToString();
 AddUpdatedFld(convCurrEduClsStu.UserType);
}
}
}

/// <summary>
/// 教学班学生流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdEduClsStu
{
get
{
return mlngIdEduClsStu;
}
set
{
 mlngIdEduClsStu = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.IdEduClsStu);
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
 AddUpdatedFld(convCurrEduClsStu.IdCurrEduCls);
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
 AddUpdatedFld(convCurrEduClsStu.CurrEduClsId);
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
 AddUpdatedFld(convCurrEduClsStu.EduClsName);
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
 AddUpdatedFld(convCurrEduClsStu.CourseId);
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
 AddUpdatedFld(convCurrEduClsStu.CourseCode);
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
 AddUpdatedFld(convCurrEduClsStu.CourseName);
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
 AddUpdatedFld(convCurrEduClsStu.TeachingSolutionId);
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
 AddUpdatedFld(convCurrEduClsStu.TeachingSolutionName);
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
 AddUpdatedFld(convCurrEduClsStu.IdXzCollege);
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
 AddUpdatedFld(convCurrEduClsStu.CollegeId);
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
 AddUpdatedFld(convCurrEduClsStu.CollegeName);
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
 AddUpdatedFld(convCurrEduClsStu.LessonQtyPerWeek);
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
 AddUpdatedFld(convCurrEduClsStu.Mark);
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
 AddUpdatedFld(convCurrEduClsStu.IdUniZone);
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
 AddUpdatedFld(convCurrEduClsStu.GradeBaseName);
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
 AddUpdatedFld(convCurrEduClsStu.IsEffective);
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
 AddUpdatedFld(convCurrEduClsStu.IdCourseType);
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
 AddUpdatedFld(convCurrEduClsStu.CourseTypeId);
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
 AddUpdatedFld(convCurrEduClsStu.CourseTypeName);
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
 AddUpdatedFld(convCurrEduClsStu.IsDegree);
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
 AddUpdatedFld(convCurrEduClsStu.CurrStuNum);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStu
{
get
{
return mstrIdStu;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStu = value;
}
else
{
 mstrIdStu = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.IdStu);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuId
{
get
{
return mstrStuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuId = value;
}
else
{
 mstrStuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.StuId);
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
 AddUpdatedFld(convCurrEduClsStu.StuName);
}
}
/// <summary>
/// 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSex
{
get
{
return mstrIdSex;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSex = value;
}
else
{
 mstrIdSex = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.IdSex);
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
 AddUpdatedFld(convCurrEduClsStu.SexDesc);
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
 AddUpdatedFld(convCurrEduClsStu.MajorID);
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
 AddUpdatedFld(convCurrEduClsStu.MajorName);
}
}
/// <summary>
/// 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminCls
{
get
{
return mstrIdAdminCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminCls = value;
}
else
{
 mstrIdAdminCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.IdAdminCls);
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
 AddUpdatedFld(convCurrEduClsStu.Birthday);
}
}
/// <summary>
/// 教学班学生状态编号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsStuStateId
{
get
{
return mstrEduClsStuStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsStuStateId = value;
}
else
{
 mstrEduClsStuStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.EduClsStuStateId);
}
}
/// <summary>
/// 获得成绩次数(说明:;字段类型:tinyint;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short? GetScoreTimes
{
get
{
return mshtGetScoreTimes;
}
set
{
 mshtGetScoreTimes = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.GetScoreTimes);
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
 AddUpdatedFld(convCurrEduClsStu.Score);
}
}
/// <summary>
/// 总分值(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TotalScores
{
get
{
return mdblTotalScores;
}
set
{
 mdblTotalScores = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.TotalScores);
}
}
/// <summary>
/// 名次(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Ranking
{
get
{
return mintRanking;
}
set
{
 mintRanking = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.Ranking);
}
}
/// <summary>
/// 百分位(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Percentile
{
get
{
return mdblPercentile;
}
set
{
 mdblPercentile = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.Percentile);
}
}
/// <summary>
/// 是否确认(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Confirmed
{
get
{
return mbolConfirmed;
}
set
{
 mbolConfirmed = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.Confirmed);
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
 AddUpdatedFld(convCurrEduClsStu.SchoolTerm);
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
 AddUpdatedFld(convCurrEduClsStu.SchoolYear);
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
 AddUpdatedFld(convCurrEduClsStu.SignInDate);
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
 AddUpdatedFld(convCurrEduClsStu.SignInStateID);
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
 AddUpdatedFld(convCurrEduClsStu.SignInUser);
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
 AddUpdatedFld(convCurrEduClsStu.ModifyDate);
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
 AddUpdatedFld(convCurrEduClsStu.ModifyUserId);
}
}
/// <summary>
/// CollegeName4Stu(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName4Stu
{
get
{
return mstrCollegeName4Stu;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName4Stu = value;
}
else
{
 mstrCollegeName4Stu = value;
}
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.CollegeName4Stu);
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
 AddUpdatedFld(convCurrEduClsStu.EduClsTypeName);
}
}
/// <summary>
/// 是否同步成绩(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynScore
{
get
{
return mbolIsSynScore;
}
set
{
 mbolIsSynScore = value;
//记录修改过的字段
 AddUpdatedFld(convCurrEduClsStu.IsSynScore);
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
 AddUpdatedFld(convCurrEduClsStu.EduClsTypeId);
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
 AddUpdatedFld(convCurrEduClsStu.UserType);
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
  return mlngIdEduClsStu.ToString();
 }
 }
}
 /// <summary>
 /// v教学班与学生关系(vCurrEduClsStu)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCurrEduClsStu
{
public const string _CurrTabName = "vCurrEduClsStu"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduClsStu"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduClsStu", "IdCurrEduCls", "CurrEduClsId", "EduClsName", "CourseId", "CourseCode", "CourseName", "TeachingSolutionId", "TeachingSolutionName", "IdXzCollege", "CollegeId", "CollegeName", "LessonQtyPerWeek", "Mark", "IdUniZone", "GradeBaseName", "IsEffective", "IdCourseType", "CourseTypeId", "CourseTypeName", "IsDegree", "CurrStuNum", "IdStu", "StuId", "StuName", "IdSex", "SexDesc", "MajorID", "MajorName", "IdAdminCls", "Birthday", "EduClsStuStateId", "GetScoreTimes", "Score", "TotalScores", "Ranking", "Percentile", "Confirmed", "SchoolTerm", "SchoolYear", "SignInDate", "SignInStateID", "SignInUser", "ModifyDate", "ModifyUserId", "CollegeName4Stu", "EduClsTypeName", "IsSynScore", "EduClsTypeId", "UserType"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEduClsStu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduClsStu = "IdEduClsStu";    //教学班学生流水号

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
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

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
 /// 常量:"CurrStuNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrStuNum = "CurrStuNum";    //当前学生数

 /// <summary>
 /// 常量:"IdStu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStu = "IdStu";    //学生流水号

 /// <summary>
 /// 常量:"StuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuId = "StuId";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"IdSex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSex = "IdSex";    //性别流水号

 /// <summary>
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

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
 /// 常量:"IdAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminCls = "IdAdminCls";    //行政班流水号

 /// <summary>
 /// 常量:"Birthday"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Birthday = "Birthday";    //出生日期

 /// <summary>
 /// 常量:"EduClsStuStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsStuStateId = "EduClsStuStateId";    //教学班学生状态编号

 /// <summary>
 /// 常量:"GetScoreTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetScoreTimes = "GetScoreTimes";    //获得成绩次数

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"TotalScores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalScores = "TotalScores";    //总分值

 /// <summary>
 /// 常量:"Ranking"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Ranking = "Ranking";    //名次

 /// <summary>
 /// 常量:"Percentile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Percentile = "Percentile";    //百分位

 /// <summary>
 /// 常量:"Confirmed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Confirmed = "Confirmed";    //是否确认

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
 /// 常量:"CollegeName4Stu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName4Stu = "CollegeName4Stu";    //CollegeName4Stu

 /// <summary>
 /// 常量:"EduClsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeName = "EduClsTypeName";    //教学班类型名称

 /// <summary>
 /// 常量:"IsSynScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynScore = "IsSynScore";    //是否同步成绩

 /// <summary>
 /// 常量:"EduClsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeId = "EduClsTypeId";    //教学班类型Id

 /// <summary>
 /// 常量:"UserType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserType = "UserType";    //用户类型
}

}