
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsEN
 表名:CurrEduCls(01120123)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:26
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
 /// 表CurrEduCls的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_CurrEduCls
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
public K_IdCurrEduCls_CurrEduCls(string strIdCurrEduCls)
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
 /// <returns>返回:[K_IdCurrEduCls_CurrEduCls]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_CurrEduCls(string value)
{
return new K_IdCurrEduCls_CurrEduCls(value);
}
}
 /// <summary>
 /// 当前教学班(CurrEduCls)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCurrEduClsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CurrEduCls"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 36;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "TeachingSolutionId", "IdXzCollege", "IdXzMajor", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "LessonQtyPerWeek", "Mark", "IdUniZone", "IdGradeBase", "IsEffective", "IsForPaperReading", "SchoolYear", "SchoolTerm", "IdCourseType", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IdExamType", "ExamTime", "BeginWeek", "UserType", "ModifyDate", "ModifyUserId", "Memo"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrCourseId;    //课程Id
protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdEduWay;    //教学方式流水号
protected string mstrIdClassRoomType;    //教室类型流水号
protected int? mintTotalLessonQty;    //总课时数
protected int? mintMaxStuQty;    //最大学生数
protected int? mintWeekQty;    //总周数
protected short? mshtScheUnitPW;    //周排课次数
protected string mstrWeekStatusId;    //周状态编号(单,双,全周)
protected string mstrCustomerWeek;    //自定义上课周
protected short? mshtLessonQtyPerWeek;    //周课时数
protected double? mdblMark;    //获得学分
protected string mstrIdUniZone;    //校区流水号
protected string mstrIdGradeBase;    //年级流水号
protected bool mbolIsEffective;    //是否有效
protected bool mbolIsForPaperReading;    //是否参与论文阅读
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrIdCourseType;    //课程类型流水号
protected bool mbolIsDegree;    //是否学位课
protected string mstrIdScoreType;    //成绩类型流水号
protected string mstrGetScoreWayId;    //获得成绩方式Id
protected bool mbolIsProportionalCtrl;    //是否比例控制
protected string mstrIdExamType;    //考试方式流水号
protected string mstrExamTime;    //考试时间
protected short? mshtBeginWeek;    //开始周
protected string mstrUserType;    //用户类型
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCurrEduClsEN()
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
public clsCurrEduClsEN(string strIdCurrEduCls)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:CurrEduCls中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:CurrEduCls中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conCurrEduCls.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conCurrEduCls.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  conCurrEduCls.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  conCurrEduCls.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  conCurrEduCls.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conCurrEduCls.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  conCurrEduCls.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conCurrEduCls.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conCurrEduCls.IdEduWay)
{
return mstrIdEduWay;
}
else if (strAttributeName  ==  conCurrEduCls.IdClassRoomType)
{
return mstrIdClassRoomType;
}
else if (strAttributeName  ==  conCurrEduCls.TotalLessonQty)
{
return mintTotalLessonQty;
}
else if (strAttributeName  ==  conCurrEduCls.MaxStuQty)
{
return mintMaxStuQty;
}
else if (strAttributeName  ==  conCurrEduCls.WeekQty)
{
return mintWeekQty;
}
else if (strAttributeName  ==  conCurrEduCls.ScheUnitPW)
{
return mshtScheUnitPW;
}
else if (strAttributeName  ==  conCurrEduCls.WeekStatusId)
{
return mstrWeekStatusId;
}
else if (strAttributeName  ==  conCurrEduCls.CustomerWeek)
{
return mstrCustomerWeek;
}
else if (strAttributeName  ==  conCurrEduCls.LessonQtyPerWeek)
{
return mshtLessonQtyPerWeek;
}
else if (strAttributeName  ==  conCurrEduCls.Mark)
{
return mdblMark;
}
else if (strAttributeName  ==  conCurrEduCls.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  conCurrEduCls.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conCurrEduCls.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  conCurrEduCls.IsForPaperReading)
{
return mbolIsForPaperReading;
}
else if (strAttributeName  ==  conCurrEduCls.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conCurrEduCls.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conCurrEduCls.IdCourseType)
{
return mstrIdCourseType;
}
else if (strAttributeName  ==  conCurrEduCls.IsDegree)
{
return mbolIsDegree;
}
else if (strAttributeName  ==  conCurrEduCls.IdScoreType)
{
return mstrIdScoreType;
}
else if (strAttributeName  ==  conCurrEduCls.GetScoreWayId)
{
return mstrGetScoreWayId;
}
else if (strAttributeName  ==  conCurrEduCls.IsProportionalCtrl)
{
return mbolIsProportionalCtrl;
}
else if (strAttributeName  ==  conCurrEduCls.IdExamType)
{
return mstrIdExamType;
}
else if (strAttributeName  ==  conCurrEduCls.ExamTime)
{
return mstrExamTime;
}
else if (strAttributeName  ==  conCurrEduCls.BeginWeek)
{
return mshtBeginWeek;
}
else if (strAttributeName  ==  conCurrEduCls.UserType)
{
return mstrUserType;
}
else if (strAttributeName  ==  conCurrEduCls.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conCurrEduCls.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conCurrEduCls.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCurrEduCls.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdCurrEduCls);
}
else if (strAttributeName  ==  conCurrEduCls.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(conCurrEduCls.CurrEduClsId);
}
else if (strAttributeName  ==  conCurrEduCls.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(conCurrEduCls.EduClsName);
}
else if (strAttributeName  ==  conCurrEduCls.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(conCurrEduCls.EduClsTypeId);
}
else if (strAttributeName  ==  conCurrEduCls.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCurrEduCls.CourseId);
}
else if (strAttributeName  ==  conCurrEduCls.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conCurrEduCls.TeachingSolutionId);
}
else if (strAttributeName  ==  conCurrEduCls.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdXzCollege);
}
else if (strAttributeName  ==  conCurrEduCls.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdXzMajor);
}
else if (strAttributeName  ==  conCurrEduCls.IdEduWay)
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdEduWay);
}
else if (strAttributeName  ==  conCurrEduCls.IdClassRoomType)
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdClassRoomType);
}
else if (strAttributeName  ==  conCurrEduCls.TotalLessonQty)
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls.TotalLessonQty);
}
else if (strAttributeName  ==  conCurrEduCls.MaxStuQty)
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls.MaxStuQty);
}
else if (strAttributeName  ==  conCurrEduCls.WeekQty)
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls.WeekQty);
}
else if (strAttributeName  ==  conCurrEduCls.ScheUnitPW)
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls.ScheUnitPW);
}
else if (strAttributeName  ==  conCurrEduCls.WeekStatusId)
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(conCurrEduCls.WeekStatusId);
}
else if (strAttributeName  ==  conCurrEduCls.CustomerWeek)
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(conCurrEduCls.CustomerWeek);
}
else if (strAttributeName  ==  conCurrEduCls.LessonQtyPerWeek)
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls.LessonQtyPerWeek);
}
else if (strAttributeName  ==  conCurrEduCls.Mark)
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduCls.Mark);
}
else if (strAttributeName  ==  conCurrEduCls.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdUniZone);
}
else if (strAttributeName  ==  conCurrEduCls.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdGradeBase);
}
else if (strAttributeName  ==  conCurrEduCls.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls.IsEffective);
}
else if (strAttributeName  ==  conCurrEduCls.IsForPaperReading)
{
mbolIsForPaperReading = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls.IsForPaperReading);
}
else if (strAttributeName  ==  conCurrEduCls.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduCls.SchoolYear);
}
else if (strAttributeName  ==  conCurrEduCls.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduCls.SchoolTerm);
}
else if (strAttributeName  ==  conCurrEduCls.IdCourseType)
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdCourseType);
}
else if (strAttributeName  ==  conCurrEduCls.IsDegree)
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls.IsDegree);
}
else if (strAttributeName  ==  conCurrEduCls.IdScoreType)
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdScoreType);
}
else if (strAttributeName  ==  conCurrEduCls.GetScoreWayId)
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(conCurrEduCls.GetScoreWayId);
}
else if (strAttributeName  ==  conCurrEduCls.IsProportionalCtrl)
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls.IsProportionalCtrl);
}
else if (strAttributeName  ==  conCurrEduCls.IdExamType)
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdExamType);
}
else if (strAttributeName  ==  conCurrEduCls.ExamTime)
{
mstrExamTime = value.ToString();
 AddUpdatedFld(conCurrEduCls.ExamTime);
}
else if (strAttributeName  ==  conCurrEduCls.BeginWeek)
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls.BeginWeek);
}
else if (strAttributeName  ==  conCurrEduCls.UserType)
{
mstrUserType = value.ToString();
 AddUpdatedFld(conCurrEduCls.UserType);
}
else if (strAttributeName  ==  conCurrEduCls.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduCls.ModifyDate);
}
else if (strAttributeName  ==  conCurrEduCls.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCurrEduCls.ModifyUserId);
}
else if (strAttributeName  ==  conCurrEduCls.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCurrEduCls.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conCurrEduCls.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (conCurrEduCls.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (conCurrEduCls.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (conCurrEduCls.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conCurrEduCls.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (conCurrEduCls.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conCurrEduCls.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conCurrEduCls.IdEduWay  ==  AttributeName[intIndex])
{
return mstrIdEduWay;
}
else if (conCurrEduCls.IdClassRoomType  ==  AttributeName[intIndex])
{
return mstrIdClassRoomType;
}
else if (conCurrEduCls.TotalLessonQty  ==  AttributeName[intIndex])
{
return mintTotalLessonQty;
}
else if (conCurrEduCls.MaxStuQty  ==  AttributeName[intIndex])
{
return mintMaxStuQty;
}
else if (conCurrEduCls.WeekQty  ==  AttributeName[intIndex])
{
return mintWeekQty;
}
else if (conCurrEduCls.ScheUnitPW  ==  AttributeName[intIndex])
{
return mshtScheUnitPW;
}
else if (conCurrEduCls.WeekStatusId  ==  AttributeName[intIndex])
{
return mstrWeekStatusId;
}
else if (conCurrEduCls.CustomerWeek  ==  AttributeName[intIndex])
{
return mstrCustomerWeek;
}
else if (conCurrEduCls.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
return mshtLessonQtyPerWeek;
}
else if (conCurrEduCls.Mark  ==  AttributeName[intIndex])
{
return mdblMark;
}
else if (conCurrEduCls.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (conCurrEduCls.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conCurrEduCls.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (conCurrEduCls.IsForPaperReading  ==  AttributeName[intIndex])
{
return mbolIsForPaperReading;
}
else if (conCurrEduCls.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conCurrEduCls.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conCurrEduCls.IdCourseType  ==  AttributeName[intIndex])
{
return mstrIdCourseType;
}
else if (conCurrEduCls.IsDegree  ==  AttributeName[intIndex])
{
return mbolIsDegree;
}
else if (conCurrEduCls.IdScoreType  ==  AttributeName[intIndex])
{
return mstrIdScoreType;
}
else if (conCurrEduCls.GetScoreWayId  ==  AttributeName[intIndex])
{
return mstrGetScoreWayId;
}
else if (conCurrEduCls.IsProportionalCtrl  ==  AttributeName[intIndex])
{
return mbolIsProportionalCtrl;
}
else if (conCurrEduCls.IdExamType  ==  AttributeName[intIndex])
{
return mstrIdExamType;
}
else if (conCurrEduCls.ExamTime  ==  AttributeName[intIndex])
{
return mstrExamTime;
}
else if (conCurrEduCls.BeginWeek  ==  AttributeName[intIndex])
{
return mshtBeginWeek;
}
else if (conCurrEduCls.UserType  ==  AttributeName[intIndex])
{
return mstrUserType;
}
else if (conCurrEduCls.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conCurrEduCls.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conCurrEduCls.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCurrEduCls.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdCurrEduCls);
}
else if (conCurrEduCls.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(conCurrEduCls.CurrEduClsId);
}
else if (conCurrEduCls.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(conCurrEduCls.EduClsName);
}
else if (conCurrEduCls.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(conCurrEduCls.EduClsTypeId);
}
else if (conCurrEduCls.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCurrEduCls.CourseId);
}
else if (conCurrEduCls.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conCurrEduCls.TeachingSolutionId);
}
else if (conCurrEduCls.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdXzCollege);
}
else if (conCurrEduCls.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdXzMajor);
}
else if (conCurrEduCls.IdEduWay  ==  AttributeName[intIndex])
{
mstrIdEduWay = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdEduWay);
}
else if (conCurrEduCls.IdClassRoomType  ==  AttributeName[intIndex])
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdClassRoomType);
}
else if (conCurrEduCls.TotalLessonQty  ==  AttributeName[intIndex])
{
mintTotalLessonQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls.TotalLessonQty);
}
else if (conCurrEduCls.MaxStuQty  ==  AttributeName[intIndex])
{
mintMaxStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls.MaxStuQty);
}
else if (conCurrEduCls.WeekQty  ==  AttributeName[intIndex])
{
mintWeekQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduCls.WeekQty);
}
else if (conCurrEduCls.ScheUnitPW  ==  AttributeName[intIndex])
{
mshtScheUnitPW = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls.ScheUnitPW);
}
else if (conCurrEduCls.WeekStatusId  ==  AttributeName[intIndex])
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(conCurrEduCls.WeekStatusId);
}
else if (conCurrEduCls.CustomerWeek  ==  AttributeName[intIndex])
{
mstrCustomerWeek = value.ToString();
 AddUpdatedFld(conCurrEduCls.CustomerWeek);
}
else if (conCurrEduCls.LessonQtyPerWeek  ==  AttributeName[intIndex])
{
mshtLessonQtyPerWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls.LessonQtyPerWeek);
}
else if (conCurrEduCls.Mark  ==  AttributeName[intIndex])
{
mdblMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduCls.Mark);
}
else if (conCurrEduCls.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdUniZone);
}
else if (conCurrEduCls.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdGradeBase);
}
else if (conCurrEduCls.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls.IsEffective);
}
else if (conCurrEduCls.IsForPaperReading  ==  AttributeName[intIndex])
{
mbolIsForPaperReading = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls.IsForPaperReading);
}
else if (conCurrEduCls.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduCls.SchoolYear);
}
else if (conCurrEduCls.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduCls.SchoolTerm);
}
else if (conCurrEduCls.IdCourseType  ==  AttributeName[intIndex])
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdCourseType);
}
else if (conCurrEduCls.IsDegree  ==  AttributeName[intIndex])
{
mbolIsDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls.IsDegree);
}
else if (conCurrEduCls.IdScoreType  ==  AttributeName[intIndex])
{
mstrIdScoreType = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdScoreType);
}
else if (conCurrEduCls.GetScoreWayId  ==  AttributeName[intIndex])
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(conCurrEduCls.GetScoreWayId);
}
else if (conCurrEduCls.IsProportionalCtrl  ==  AttributeName[intIndex])
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduCls.IsProportionalCtrl);
}
else if (conCurrEduCls.IdExamType  ==  AttributeName[intIndex])
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(conCurrEduCls.IdExamType);
}
else if (conCurrEduCls.ExamTime  ==  AttributeName[intIndex])
{
mstrExamTime = value.ToString();
 AddUpdatedFld(conCurrEduCls.ExamTime);
}
else if (conCurrEduCls.BeginWeek  ==  AttributeName[intIndex])
{
mshtBeginWeek = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduCls.BeginWeek);
}
else if (conCurrEduCls.UserType  ==  AttributeName[intIndex])
{
mstrUserType = value.ToString();
 AddUpdatedFld(conCurrEduCls.UserType);
}
else if (conCurrEduCls.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduCls.ModifyDate);
}
else if (conCurrEduCls.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCurrEduCls.ModifyUserId);
}
else if (conCurrEduCls.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduCls.Memo);
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
 AddUpdatedFld(conCurrEduCls.IdCurrEduCls);
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
 AddUpdatedFld(conCurrEduCls.CurrEduClsId);
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
 AddUpdatedFld(conCurrEduCls.EduClsName);
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
 AddUpdatedFld(conCurrEduCls.EduClsTypeId);
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
 AddUpdatedFld(conCurrEduCls.CourseId);
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
 AddUpdatedFld(conCurrEduCls.TeachingSolutionId);
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
 AddUpdatedFld(conCurrEduCls.IdXzCollege);
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
 AddUpdatedFld(conCurrEduCls.IdXzMajor);
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
 AddUpdatedFld(conCurrEduCls.IdEduWay);
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
 AddUpdatedFld(conCurrEduCls.IdClassRoomType);
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
 AddUpdatedFld(conCurrEduCls.TotalLessonQty);
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
 AddUpdatedFld(conCurrEduCls.MaxStuQty);
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
 AddUpdatedFld(conCurrEduCls.WeekQty);
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
 AddUpdatedFld(conCurrEduCls.ScheUnitPW);
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
 AddUpdatedFld(conCurrEduCls.WeekStatusId);
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
 AddUpdatedFld(conCurrEduCls.CustomerWeek);
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
 AddUpdatedFld(conCurrEduCls.LessonQtyPerWeek);
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
 AddUpdatedFld(conCurrEduCls.Mark);
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
 AddUpdatedFld(conCurrEduCls.IdUniZone);
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
 AddUpdatedFld(conCurrEduCls.IdGradeBase);
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
 AddUpdatedFld(conCurrEduCls.IsEffective);
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
 AddUpdatedFld(conCurrEduCls.IsForPaperReading);
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
 AddUpdatedFld(conCurrEduCls.SchoolYear);
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
 AddUpdatedFld(conCurrEduCls.SchoolTerm);
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
 AddUpdatedFld(conCurrEduCls.IdCourseType);
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
 AddUpdatedFld(conCurrEduCls.IsDegree);
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
 AddUpdatedFld(conCurrEduCls.IdScoreType);
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
 AddUpdatedFld(conCurrEduCls.GetScoreWayId);
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
 AddUpdatedFld(conCurrEduCls.IsProportionalCtrl);
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
 AddUpdatedFld(conCurrEduCls.IdExamType);
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
 AddUpdatedFld(conCurrEduCls.ExamTime);
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
 AddUpdatedFld(conCurrEduCls.BeginWeek);
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
 AddUpdatedFld(conCurrEduCls.UserType);
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
 AddUpdatedFld(conCurrEduCls.ModifyDate);
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
 AddUpdatedFld(conCurrEduCls.ModifyUserId);
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
 AddUpdatedFld(conCurrEduCls.Memo);
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
 /// 当前教学班(CurrEduCls)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCurrEduCls
{
public const string _CurrTabName = "CurrEduCls"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CurrEduClsId", "EduClsName", "EduClsTypeId", "CourseId", "TeachingSolutionId", "IdXzCollege", "IdXzMajor", "IdEduWay", "IdClassRoomType", "TotalLessonQty", "MaxStuQty", "WeekQty", "ScheUnitPW", "WeekStatusId", "CustomerWeek", "LessonQtyPerWeek", "Mark", "IdUniZone", "IdGradeBase", "IsEffective", "IsForPaperReading", "SchoolYear", "SchoolTerm", "IdCourseType", "IsDegree", "IdScoreType", "GetScoreWayId", "IsProportionalCtrl", "IdExamType", "ExamTime", "BeginWeek", "UserType", "ModifyDate", "ModifyUserId", "Memo"};
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
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

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
 /// 常量:"ExamTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamTime = "ExamTime";    //考试时间

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
}

}