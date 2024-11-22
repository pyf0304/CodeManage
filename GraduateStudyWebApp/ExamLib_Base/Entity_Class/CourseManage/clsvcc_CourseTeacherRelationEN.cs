
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTeacherRelationEN
 表名:vcc_CourseTeacherRelation(01120096)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// 表vcc_CourseTeacherRelation的关键字(CourseTeacherRelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseTeacherRelationId_vcc_CourseTeacherRelation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngCourseTeacherRelationId">表关键字</param>
public K_CourseTeacherRelationId_vcc_CourseTeacherRelation(long lngCourseTeacherRelationId)
{
if (IsValid(lngCourseTeacherRelationId)) Value = lngCourseTeacherRelationId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngCourseTeacherRelationId)
{
if (lngCourseTeacherRelationId == 0) return false;
if (lngCourseTeacherRelationId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseTeacherRelationId_vcc_CourseTeacherRelation]类型的对象</returns>
public static implicit operator K_CourseTeacherRelationId_vcc_CourseTeacherRelation(long value)
{
return new K_CourseTeacherRelationId_vcc_CourseTeacherRelation(value);
}
}
 /// <summary>
 /// v课程和教师关系(vcc_CourseTeacherRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseTeacherRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CourseTeacherRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseTeacherRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"CourseTeacherRelationId", "CourseId", "CourseCode", "CourseDescription", "CourseName", "CourseTypeID", "CreateDate", "ExcellentTypeId", "ExcellentYear", "IsBuildingCourse", "IsDoubleLanguageCourse", "IsOpen", "IsRecommendedCourse", "IsSelfPropelledCourse", "OperationDate", "OrderNum", "OuterLink", "ViewCount", "ThemeId", "ExampleImgPath", "IdXzMajor", "IdXzCollege", "IdTeacher", "TeacherID", "TeacherName", "CardNo", "IsCourseManager", "LastVisitedDate", "UpdDate", "UpdUser", "Memo"};

protected long mlngCourseTeacherRelationId;    //课程教师关系表流水号
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseDescription;    //课程描述
protected string mstrCourseName;    //课程名称
protected string mstrCourseTypeID;    //课程类型ID
protected string mstrCreateDate;    //建立日期
protected string mstrExcellentTypeId;    //精品课程类型Id
protected int? mintExcellentYear;    //课程年份
protected bool mbolIsBuildingCourse;    //是否已建设课程
protected bool mbolIsDoubleLanguageCourse;    //是否双语课程
protected bool mbolIsOpen;    //是否公开
protected bool mbolIsRecommendedCourse;    //是否推荐课程
protected bool mbolIsSelfPropelledCourse;    //是否自荐课程
protected string mstrOperationDate;    //操作时间
protected int? mintOrderNum;    //序号
protected string mstrOuterLink;    //外链地址
protected int? mintViewCount;    //浏览量
protected string mstrThemeId;    //主题Id
protected string mstrExampleImgPath;    //示例图路径
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdTeacher;    //教师流水号
protected string mstrTeacherID;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrCardNo;    //卡号
protected bool mbolIsCourseManager;    //是否课程主要人
protected string mstrLastVisitedDate;    //最后访问时间
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseTeacherRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseTeacherRelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngCourseTeacherRelationId">关键字:课程教师关系表流水号</param>
public clsvcc_CourseTeacherRelationEN(long lngCourseTeacherRelationId)
 {
 if (lngCourseTeacherRelationId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngCourseTeacherRelationId = lngCourseTeacherRelationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseTeacherRelationId");
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
if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseTeacherRelationId)
{
return mlngCourseTeacherRelationId;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseDescription)
{
return mstrCourseDescription;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseTypeID)
{
return mstrCourseTypeID;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ExcellentTypeId)
{
return mstrExcellentTypeId;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ExcellentYear)
{
return mintExcellentYear;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsBuildingCourse)
{
return mbolIsBuildingCourse;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsDoubleLanguageCourse)
{
return mbolIsDoubleLanguageCourse;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsOpen)
{
return mbolIsOpen;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsRecommendedCourse)
{
return mbolIsRecommendedCourse;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsSelfPropelledCourse)
{
return mbolIsSelfPropelledCourse;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.OperationDate)
{
return mstrOperationDate;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.OuterLink)
{
return mstrOuterLink;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ThemeId)
{
return mstrThemeId;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ExampleImgPath)
{
return mstrExampleImgPath;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.TeacherID)
{
return mstrTeacherID;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsCourseManager)
{
return mbolIsCourseManager;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseTeacherRelationId)
{
mlngCourseTeacherRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseTeacherRelationId);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseId);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseCode);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseDescription)
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseDescription);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseName);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CourseTypeID)
{
mstrCourseTypeID = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseTypeID);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CreateDate);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ExcellentTypeId)
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.ExcellentTypeId);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ExcellentYear)
{
mintExcellentYear = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.ExcellentYear);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsBuildingCourse)
{
mbolIsBuildingCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsBuildingCourse);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsDoubleLanguageCourse)
{
mbolIsDoubleLanguageCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsDoubleLanguageCourse);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsOpen)
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsOpen);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsRecommendedCourse)
{
mbolIsRecommendedCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsRecommendedCourse);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsSelfPropelledCourse)
{
mbolIsSelfPropelledCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsSelfPropelledCourse);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.OperationDate)
{
mstrOperationDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.OperationDate);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.OrderNum);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.OuterLink)
{
mstrOuterLink = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.OuterLink);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.ViewCount);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ThemeId)
{
mstrThemeId = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.ThemeId);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.ExampleImgPath)
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.ExampleImgPath);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.IdXzMajor);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.IdXzCollege);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.IdTeacher);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.TeacherID)
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.TeacherID);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.TeacherName);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CardNo);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.IsCourseManager)
{
mbolIsCourseManager = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsCourseManager);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.LastVisitedDate);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.UpdDate);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.UpdUser);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CourseTeacherRelation.CourseTeacherRelationId  ==  AttributeName[intIndex])
{
return mlngCourseTeacherRelationId;
}
else if (convcc_CourseTeacherRelation.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CourseTeacherRelation.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convcc_CourseTeacherRelation.CourseDescription  ==  AttributeName[intIndex])
{
return mstrCourseDescription;
}
else if (convcc_CourseTeacherRelation.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_CourseTeacherRelation.CourseTypeID  ==  AttributeName[intIndex])
{
return mstrCourseTypeID;
}
else if (convcc_CourseTeacherRelation.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convcc_CourseTeacherRelation.ExcellentTypeId  ==  AttributeName[intIndex])
{
return mstrExcellentTypeId;
}
else if (convcc_CourseTeacherRelation.ExcellentYear  ==  AttributeName[intIndex])
{
return mintExcellentYear;
}
else if (convcc_CourseTeacherRelation.IsBuildingCourse  ==  AttributeName[intIndex])
{
return mbolIsBuildingCourse;
}
else if (convcc_CourseTeacherRelation.IsDoubleLanguageCourse  ==  AttributeName[intIndex])
{
return mbolIsDoubleLanguageCourse;
}
else if (convcc_CourseTeacherRelation.IsOpen  ==  AttributeName[intIndex])
{
return mbolIsOpen;
}
else if (convcc_CourseTeacherRelation.IsRecommendedCourse  ==  AttributeName[intIndex])
{
return mbolIsRecommendedCourse;
}
else if (convcc_CourseTeacherRelation.IsSelfPropelledCourse  ==  AttributeName[intIndex])
{
return mbolIsSelfPropelledCourse;
}
else if (convcc_CourseTeacherRelation.OperationDate  ==  AttributeName[intIndex])
{
return mstrOperationDate;
}
else if (convcc_CourseTeacherRelation.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_CourseTeacherRelation.OuterLink  ==  AttributeName[intIndex])
{
return mstrOuterLink;
}
else if (convcc_CourseTeacherRelation.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convcc_CourseTeacherRelation.ThemeId  ==  AttributeName[intIndex])
{
return mstrThemeId;
}
else if (convcc_CourseTeacherRelation.ExampleImgPath  ==  AttributeName[intIndex])
{
return mstrExampleImgPath;
}
else if (convcc_CourseTeacherRelation.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convcc_CourseTeacherRelation.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convcc_CourseTeacherRelation.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (convcc_CourseTeacherRelation.TeacherID  ==  AttributeName[intIndex])
{
return mstrTeacherID;
}
else if (convcc_CourseTeacherRelation.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convcc_CourseTeacherRelation.CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (convcc_CourseTeacherRelation.IsCourseManager  ==  AttributeName[intIndex])
{
return mbolIsCourseManager;
}
else if (convcc_CourseTeacherRelation.LastVisitedDate  ==  AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (convcc_CourseTeacherRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_CourseTeacherRelation.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcc_CourseTeacherRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convcc_CourseTeacherRelation.CourseTeacherRelationId  ==  AttributeName[intIndex])
{
mlngCourseTeacherRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseTeacherRelationId);
}
else if (convcc_CourseTeacherRelation.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseId);
}
else if (convcc_CourseTeacherRelation.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseCode);
}
else if (convcc_CourseTeacherRelation.CourseDescription  ==  AttributeName[intIndex])
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseDescription);
}
else if (convcc_CourseTeacherRelation.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseName);
}
else if (convcc_CourseTeacherRelation.CourseTypeID  ==  AttributeName[intIndex])
{
mstrCourseTypeID = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseTypeID);
}
else if (convcc_CourseTeacherRelation.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CreateDate);
}
else if (convcc_CourseTeacherRelation.ExcellentTypeId  ==  AttributeName[intIndex])
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.ExcellentTypeId);
}
else if (convcc_CourseTeacherRelation.ExcellentYear  ==  AttributeName[intIndex])
{
mintExcellentYear = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.ExcellentYear);
}
else if (convcc_CourseTeacherRelation.IsBuildingCourse  ==  AttributeName[intIndex])
{
mbolIsBuildingCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsBuildingCourse);
}
else if (convcc_CourseTeacherRelation.IsDoubleLanguageCourse  ==  AttributeName[intIndex])
{
mbolIsDoubleLanguageCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsDoubleLanguageCourse);
}
else if (convcc_CourseTeacherRelation.IsOpen  ==  AttributeName[intIndex])
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsOpen);
}
else if (convcc_CourseTeacherRelation.IsRecommendedCourse  ==  AttributeName[intIndex])
{
mbolIsRecommendedCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsRecommendedCourse);
}
else if (convcc_CourseTeacherRelation.IsSelfPropelledCourse  ==  AttributeName[intIndex])
{
mbolIsSelfPropelledCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsSelfPropelledCourse);
}
else if (convcc_CourseTeacherRelation.OperationDate  ==  AttributeName[intIndex])
{
mstrOperationDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.OperationDate);
}
else if (convcc_CourseTeacherRelation.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.OrderNum);
}
else if (convcc_CourseTeacherRelation.OuterLink  ==  AttributeName[intIndex])
{
mstrOuterLink = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.OuterLink);
}
else if (convcc_CourseTeacherRelation.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.ViewCount);
}
else if (convcc_CourseTeacherRelation.ThemeId  ==  AttributeName[intIndex])
{
mstrThemeId = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.ThemeId);
}
else if (convcc_CourseTeacherRelation.ExampleImgPath  ==  AttributeName[intIndex])
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.ExampleImgPath);
}
else if (convcc_CourseTeacherRelation.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.IdXzMajor);
}
else if (convcc_CourseTeacherRelation.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.IdXzCollege);
}
else if (convcc_CourseTeacherRelation.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.IdTeacher);
}
else if (convcc_CourseTeacherRelation.TeacherID  ==  AttributeName[intIndex])
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.TeacherID);
}
else if (convcc_CourseTeacherRelation.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.TeacherName);
}
else if (convcc_CourseTeacherRelation.CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.CardNo);
}
else if (convcc_CourseTeacherRelation.IsCourseManager  ==  AttributeName[intIndex])
{
mbolIsCourseManager = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation.IsCourseManager);
}
else if (convcc_CourseTeacherRelation.LastVisitedDate  ==  AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.LastVisitedDate);
}
else if (convcc_CourseTeacherRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.UpdDate);
}
else if (convcc_CourseTeacherRelation.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.UpdUser);
}
else if (convcc_CourseTeacherRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation.Memo);
}
}
}

/// <summary>
/// 课程教师关系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CourseTeacherRelationId
{
get
{
return mlngCourseTeacherRelationId;
}
set
{
 mlngCourseTeacherRelationId = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseTeacherRelationId);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseId);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseCode);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseDescription);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseName);
}
}
/// <summary>
/// 课程类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeID
{
get
{
return mstrCourseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeID = value;
}
else
{
 mstrCourseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.CourseTypeID);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.CreateDate);
}
}
/// <summary>
/// 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTypeId
{
get
{
return mstrExcellentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTypeId = value;
}
else
{
 mstrExcellentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.ExcellentTypeId);
}
}
/// <summary>
/// 课程年份(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ExcellentYear
{
get
{
return mintExcellentYear;
}
set
{
 mintExcellentYear = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.ExcellentYear);
}
}
/// <summary>
/// 是否已建设课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsBuildingCourse
{
get
{
return mbolIsBuildingCourse;
}
set
{
 mbolIsBuildingCourse = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.IsBuildingCourse);
}
}
/// <summary>
/// 是否双语课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDoubleLanguageCourse
{
get
{
return mbolIsDoubleLanguageCourse;
}
set
{
 mbolIsDoubleLanguageCourse = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.IsDoubleLanguageCourse);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpen
{
get
{
return mbolIsOpen;
}
set
{
 mbolIsOpen = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.IsOpen);
}
}
/// <summary>
/// 是否推荐课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecommendedCourse
{
get
{
return mbolIsRecommendedCourse;
}
set
{
 mbolIsRecommendedCourse = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.IsRecommendedCourse);
}
}
/// <summary>
/// 是否自荐课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSelfPropelledCourse
{
get
{
return mbolIsSelfPropelledCourse;
}
set
{
 mbolIsSelfPropelledCourse = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.IsSelfPropelledCourse);
}
}
/// <summary>
/// 操作时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationDate
{
get
{
return mstrOperationDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationDate = value;
}
else
{
 mstrOperationDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.OperationDate);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.OrderNum);
}
}
/// <summary>
/// 外链地址(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OuterLink
{
get
{
return mstrOuterLink;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOuterLink = value;
}
else
{
 mstrOuterLink = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.OuterLink);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.ViewCount);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThemeId
{
get
{
return mstrThemeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThemeId = value;
}
else
{
 mstrThemeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.ThemeId);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.ExampleImgPath);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.IdXzMajor);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.IdXzCollege);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.IdTeacher);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherID
{
get
{
return mstrTeacherID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherID = value;
}
else
{
 mstrTeacherID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.TeacherID);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.TeacherName);
}
}
/// <summary>
/// 卡号(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CardNo
{
get
{
return mstrCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCardNo = value;
}
else
{
 mstrCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.CardNo);
}
}
/// <summary>
/// 是否课程主要人(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCourseManager
{
get
{
return mbolIsCourseManager;
}
set
{
 mbolIsCourseManager = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.IsCourseManager);
}
}
/// <summary>
/// 最后访问时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastVisitedDate
{
get
{
return mstrLastVisitedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastVisitedDate = value;
}
else
{
 mstrLastVisitedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation.LastVisitedDate);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.UpdDate);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.UpdUser);
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
 AddUpdatedFld(convcc_CourseTeacherRelation.Memo);
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
  return mlngCourseTeacherRelationId.ToString();
 }
 }
}
 /// <summary>
 /// v课程和教师关系(vcc_CourseTeacherRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CourseTeacherRelation
{
public const string _CurrTabName = "vcc_CourseTeacherRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseTeacherRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseTeacherRelationId", "CourseId", "CourseCode", "CourseDescription", "CourseName", "CourseTypeID", "CreateDate", "ExcellentTypeId", "ExcellentYear", "IsBuildingCourse", "IsDoubleLanguageCourse", "IsOpen", "IsRecommendedCourse", "IsSelfPropelledCourse", "OperationDate", "OrderNum", "OuterLink", "ViewCount", "ThemeId", "ExampleImgPath", "IdXzMajor", "IdXzCollege", "IdTeacher", "TeacherID", "TeacherName", "CardNo", "IsCourseManager", "LastVisitedDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseTeacherRelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTeacherRelationId = "CourseTeacherRelationId";    //课程教师关系表流水号

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
 /// 常量:"CourseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeID = "CourseTypeID";    //课程类型ID

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"ExcellentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTypeId = "ExcellentTypeId";    //精品课程类型Id

 /// <summary>
 /// 常量:"ExcellentYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentYear = "ExcellentYear";    //课程年份

 /// <summary>
 /// 常量:"IsBuildingCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsBuildingCourse = "IsBuildingCourse";    //是否已建设课程

 /// <summary>
 /// 常量:"IsDoubleLanguageCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDoubleLanguageCourse = "IsDoubleLanguageCourse";    //是否双语课程

 /// <summary>
 /// 常量:"IsOpen"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpen = "IsOpen";    //是否公开

 /// <summary>
 /// 常量:"IsRecommendedCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommendedCourse = "IsRecommendedCourse";    //是否推荐课程

 /// <summary>
 /// 常量:"IsSelfPropelledCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSelfPropelledCourse = "IsSelfPropelledCourse";    //是否自荐课程

 /// <summary>
 /// 常量:"OperationDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationDate = "OperationDate";    //操作时间

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"OuterLink"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OuterLink = "OuterLink";    //外链地址

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"ThemeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThemeId = "ThemeId";    //主题Id

 /// <summary>
 /// 常量:"ExampleImgPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExampleImgPath = "ExampleImgPath";    //示例图路径

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeacher = "IdTeacher";    //教师流水号

 /// <summary>
 /// 常量:"TeacherID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherID = "TeacherID";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

 /// <summary>
 /// 常量:"CardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CardNo = "CardNo";    //卡号

 /// <summary>
 /// 常量:"IsCourseManager"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCourseManager = "IsCourseManager";    //是否课程主要人

 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastVisitedDate = "LastVisitedDate";    //最后访问时间

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
}

}