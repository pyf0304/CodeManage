
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseProEN
 表名:vcc_CoursePro(01120213)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vcc_CoursePro的关键字(CourseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseId_vcc_CoursePro
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseId">表关键字</param>
public K_CourseId_vcc_CoursePro(string strCourseId)
{
if (IsValid(strCourseId)) Value = strCourseId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return false;
if (strCourseId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseId_vcc_CoursePro]类型的对象</returns>
public static implicit operator K_CourseId_vcc_CoursePro(string value)
{
return new K_CourseId_vcc_CoursePro(value);
}
}
 /// <summary>
 /// v课程Pro(vcc_CoursePro)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseProEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CoursePro"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 35;
public static string[] AttributeName = new string[] {"CourseId", "LikeCount", "CourseCode", "CourseDescription", "CourseName", "CourseTypeId", "CourseTypeName", "CreateDate", "ExcellentTypeId", "ExcellentTypeName", "ExcellentYear", "IsBuildingCourse", "IsDoubleLanguageCourse", "IsOpen", "IsRecommendedCourse", "IsSelfPropelledCourse", "OperationDate", "OrderNum", "OuterLink", "ViewCount", "ThemeId", "ThemeName", "ExampleImgPath", "IdXzMajor", "MajorID", "MajorName", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "Memo", "QuestionNum", "KnowledgesNum", "TeacherNum", "ChapterNum"};

protected string mstrCourseId;    //课程Id
protected int? mintLikeCount;    //LikeCount
protected string mstrCourseCode;    //课程代码
protected string mstrCourseDescription;    //课程描述
protected string mstrCourseName;    //课程名称
protected string mstrCourseTypeId;    //课程类型ID
protected string mstrCourseTypeName;    //课程类型名称
protected string mstrCreateDate;    //建立日期
protected string mstrExcellentTypeId;    //精品课程类型Id
protected string mstrExcellentTypeName;    //精品课程类型名称
protected int mintExcellentYear;    //课程年份
protected bool mbolIsBuildingCourse;    //是否已建设课程
protected bool mbolIsDoubleLanguageCourse;    //是否双语课程
protected bool mbolIsOpen;    //是否公开
protected bool mbolIsRecommendedCourse;    //是否推荐课程
protected bool mbolIsSelfPropelledCourse;    //是否自荐课程
protected string mstrOperationDate;    //操作时间
protected int? mintOrderNum;    //序号
protected string mstrOuterLink;    //外链地址
protected int mintViewCount;    //浏览量
protected string mstrThemeId;    //主题Id
protected string mstrThemeName;    //主题名
protected string mstrExampleImgPath;    //示例图路径
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrMemo;    //备注
protected int? mintQuestionNum;    //题目数
protected int? mintKnowledgesNum;    //知识点数
protected int? mintTeacherNum;    //教师数
protected int? mintChapterNum;    //章节数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseProEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseId">关键字:课程Id</param>
public clsvcc_CourseProEN(string strCourseId)
 {
strCourseId = strCourseId.Replace("'", "''");
if (strCourseId.Length > 8)
{
throw new Exception("在表:vcc_CoursePro中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseId)  ==  true)
{
throw new Exception("在表:vcc_CoursePro中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseId = strCourseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseId");
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
if (strAttributeName  ==  convcc_CoursePro.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CoursePro.LikeCount)
{
return mintLikeCount;
}
else if (strAttributeName  ==  convcc_CoursePro.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convcc_CoursePro.CourseDescription)
{
return mstrCourseDescription;
}
else if (strAttributeName  ==  convcc_CoursePro.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_CoursePro.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  convcc_CoursePro.CourseTypeName)
{
return mstrCourseTypeName;
}
else if (strAttributeName  ==  convcc_CoursePro.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convcc_CoursePro.ExcellentTypeId)
{
return mstrExcellentTypeId;
}
else if (strAttributeName  ==  convcc_CoursePro.ExcellentTypeName)
{
return mstrExcellentTypeName;
}
else if (strAttributeName  ==  convcc_CoursePro.ExcellentYear)
{
return mintExcellentYear;
}
else if (strAttributeName  ==  convcc_CoursePro.IsBuildingCourse)
{
return mbolIsBuildingCourse;
}
else if (strAttributeName  ==  convcc_CoursePro.IsDoubleLanguageCourse)
{
return mbolIsDoubleLanguageCourse;
}
else if (strAttributeName  ==  convcc_CoursePro.IsOpen)
{
return mbolIsOpen;
}
else if (strAttributeName  ==  convcc_CoursePro.IsRecommendedCourse)
{
return mbolIsRecommendedCourse;
}
else if (strAttributeName  ==  convcc_CoursePro.IsSelfPropelledCourse)
{
return mbolIsSelfPropelledCourse;
}
else if (strAttributeName  ==  convcc_CoursePro.OperationDate)
{
return mstrOperationDate;
}
else if (strAttributeName  ==  convcc_CoursePro.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_CoursePro.OuterLink)
{
return mstrOuterLink;
}
else if (strAttributeName  ==  convcc_CoursePro.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convcc_CoursePro.ThemeId)
{
return mstrThemeId;
}
else if (strAttributeName  ==  convcc_CoursePro.ThemeName)
{
return mstrThemeName;
}
else if (strAttributeName  ==  convcc_CoursePro.ExampleImgPath)
{
return mstrExampleImgPath;
}
else if (strAttributeName  ==  convcc_CoursePro.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convcc_CoursePro.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convcc_CoursePro.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convcc_CoursePro.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convcc_CoursePro.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convcc_CoursePro.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convcc_CoursePro.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convcc_CoursePro.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_CoursePro.QuestionNum)
{
return mintQuestionNum;
}
else if (strAttributeName  ==  convcc_CoursePro.KnowledgesNum)
{
return mintKnowledgesNum;
}
else if (strAttributeName  ==  convcc_CoursePro.TeacherNum)
{
return mintTeacherNum;
}
else if (strAttributeName  ==  convcc_CoursePro.ChapterNum)
{
return mintChapterNum;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CoursePro.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseId);
}
else if (strAttributeName  ==  convcc_CoursePro.LikeCount)
{
mintLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.LikeCount);
}
else if (strAttributeName  ==  convcc_CoursePro.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseCode);
}
else if (strAttributeName  ==  convcc_CoursePro.CourseDescription)
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseDescription);
}
else if (strAttributeName  ==  convcc_CoursePro.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseName);
}
else if (strAttributeName  ==  convcc_CoursePro.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseTypeId);
}
else if (strAttributeName  ==  convcc_CoursePro.CourseTypeName)
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseTypeName);
}
else if (strAttributeName  ==  convcc_CoursePro.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CreateDate);
}
else if (strAttributeName  ==  convcc_CoursePro.ExcellentTypeId)
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ExcellentTypeId);
}
else if (strAttributeName  ==  convcc_CoursePro.ExcellentTypeName)
{
mstrExcellentTypeName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ExcellentTypeName);
}
else if (strAttributeName  ==  convcc_CoursePro.ExcellentYear)
{
mintExcellentYear = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.ExcellentYear);
}
else if (strAttributeName  ==  convcc_CoursePro.IsBuildingCourse)
{
mbolIsBuildingCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsBuildingCourse);
}
else if (strAttributeName  ==  convcc_CoursePro.IsDoubleLanguageCourse)
{
mbolIsDoubleLanguageCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsDoubleLanguageCourse);
}
else if (strAttributeName  ==  convcc_CoursePro.IsOpen)
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsOpen);
}
else if (strAttributeName  ==  convcc_CoursePro.IsRecommendedCourse)
{
mbolIsRecommendedCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsRecommendedCourse);
}
else if (strAttributeName  ==  convcc_CoursePro.IsSelfPropelledCourse)
{
mbolIsSelfPropelledCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsSelfPropelledCourse);
}
else if (strAttributeName  ==  convcc_CoursePro.OperationDate)
{
mstrOperationDate = value.ToString();
 AddUpdatedFld(convcc_CoursePro.OperationDate);
}
else if (strAttributeName  ==  convcc_CoursePro.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.OrderNum);
}
else if (strAttributeName  ==  convcc_CoursePro.OuterLink)
{
mstrOuterLink = value.ToString();
 AddUpdatedFld(convcc_CoursePro.OuterLink);
}
else if (strAttributeName  ==  convcc_CoursePro.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.ViewCount);
}
else if (strAttributeName  ==  convcc_CoursePro.ThemeId)
{
mstrThemeId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ThemeId);
}
else if (strAttributeName  ==  convcc_CoursePro.ThemeName)
{
mstrThemeName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ThemeName);
}
else if (strAttributeName  ==  convcc_CoursePro.ExampleImgPath)
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ExampleImgPath);
}
else if (strAttributeName  ==  convcc_CoursePro.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_CoursePro.IdXzMajor);
}
else if (strAttributeName  ==  convcc_CoursePro.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convcc_CoursePro.MajorID);
}
else if (strAttributeName  ==  convcc_CoursePro.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.MajorName);
}
else if (strAttributeName  ==  convcc_CoursePro.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_CoursePro.IdXzCollege);
}
else if (strAttributeName  ==  convcc_CoursePro.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CollegeId);
}
else if (strAttributeName  ==  convcc_CoursePro.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CollegeName);
}
else if (strAttributeName  ==  convcc_CoursePro.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CollegeNameA);
}
else if (strAttributeName  ==  convcc_CoursePro.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CoursePro.Memo);
}
else if (strAttributeName  ==  convcc_CoursePro.QuestionNum)
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.QuestionNum);
}
else if (strAttributeName  ==  convcc_CoursePro.KnowledgesNum)
{
mintKnowledgesNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.KnowledgesNum);
}
else if (strAttributeName  ==  convcc_CoursePro.TeacherNum)
{
mintTeacherNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.TeacherNum);
}
else if (strAttributeName  ==  convcc_CoursePro.ChapterNum)
{
mintChapterNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.ChapterNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CoursePro.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CoursePro.LikeCount  ==  AttributeName[intIndex])
{
return mintLikeCount;
}
else if (convcc_CoursePro.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convcc_CoursePro.CourseDescription  ==  AttributeName[intIndex])
{
return mstrCourseDescription;
}
else if (convcc_CoursePro.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_CoursePro.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (convcc_CoursePro.CourseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseTypeName;
}
else if (convcc_CoursePro.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convcc_CoursePro.ExcellentTypeId  ==  AttributeName[intIndex])
{
return mstrExcellentTypeId;
}
else if (convcc_CoursePro.ExcellentTypeName  ==  AttributeName[intIndex])
{
return mstrExcellentTypeName;
}
else if (convcc_CoursePro.ExcellentYear  ==  AttributeName[intIndex])
{
return mintExcellentYear;
}
else if (convcc_CoursePro.IsBuildingCourse  ==  AttributeName[intIndex])
{
return mbolIsBuildingCourse;
}
else if (convcc_CoursePro.IsDoubleLanguageCourse  ==  AttributeName[intIndex])
{
return mbolIsDoubleLanguageCourse;
}
else if (convcc_CoursePro.IsOpen  ==  AttributeName[intIndex])
{
return mbolIsOpen;
}
else if (convcc_CoursePro.IsRecommendedCourse  ==  AttributeName[intIndex])
{
return mbolIsRecommendedCourse;
}
else if (convcc_CoursePro.IsSelfPropelledCourse  ==  AttributeName[intIndex])
{
return mbolIsSelfPropelledCourse;
}
else if (convcc_CoursePro.OperationDate  ==  AttributeName[intIndex])
{
return mstrOperationDate;
}
else if (convcc_CoursePro.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_CoursePro.OuterLink  ==  AttributeName[intIndex])
{
return mstrOuterLink;
}
else if (convcc_CoursePro.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convcc_CoursePro.ThemeId  ==  AttributeName[intIndex])
{
return mstrThemeId;
}
else if (convcc_CoursePro.ThemeName  ==  AttributeName[intIndex])
{
return mstrThemeName;
}
else if (convcc_CoursePro.ExampleImgPath  ==  AttributeName[intIndex])
{
return mstrExampleImgPath;
}
else if (convcc_CoursePro.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convcc_CoursePro.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convcc_CoursePro.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convcc_CoursePro.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convcc_CoursePro.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convcc_CoursePro.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convcc_CoursePro.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convcc_CoursePro.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_CoursePro.QuestionNum  ==  AttributeName[intIndex])
{
return mintQuestionNum;
}
else if (convcc_CoursePro.KnowledgesNum  ==  AttributeName[intIndex])
{
return mintKnowledgesNum;
}
else if (convcc_CoursePro.TeacherNum  ==  AttributeName[intIndex])
{
return mintTeacherNum;
}
else if (convcc_CoursePro.ChapterNum  ==  AttributeName[intIndex])
{
return mintChapterNum;
}
return null;
}
set
{
if (convcc_CoursePro.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseId);
}
else if (convcc_CoursePro.LikeCount  ==  AttributeName[intIndex])
{
mintLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.LikeCount);
}
else if (convcc_CoursePro.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseCode);
}
else if (convcc_CoursePro.CourseDescription  ==  AttributeName[intIndex])
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseDescription);
}
else if (convcc_CoursePro.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseName);
}
else if (convcc_CoursePro.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseTypeId);
}
else if (convcc_CoursePro.CourseTypeName  ==  AttributeName[intIndex])
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CourseTypeName);
}
else if (convcc_CoursePro.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CreateDate);
}
else if (convcc_CoursePro.ExcellentTypeId  ==  AttributeName[intIndex])
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ExcellentTypeId);
}
else if (convcc_CoursePro.ExcellentTypeName  ==  AttributeName[intIndex])
{
mstrExcellentTypeName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ExcellentTypeName);
}
else if (convcc_CoursePro.ExcellentYear  ==  AttributeName[intIndex])
{
mintExcellentYear = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.ExcellentYear);
}
else if (convcc_CoursePro.IsBuildingCourse  ==  AttributeName[intIndex])
{
mbolIsBuildingCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsBuildingCourse);
}
else if (convcc_CoursePro.IsDoubleLanguageCourse  ==  AttributeName[intIndex])
{
mbolIsDoubleLanguageCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsDoubleLanguageCourse);
}
else if (convcc_CoursePro.IsOpen  ==  AttributeName[intIndex])
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsOpen);
}
else if (convcc_CoursePro.IsRecommendedCourse  ==  AttributeName[intIndex])
{
mbolIsRecommendedCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsRecommendedCourse);
}
else if (convcc_CoursePro.IsSelfPropelledCourse  ==  AttributeName[intIndex])
{
mbolIsSelfPropelledCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CoursePro.IsSelfPropelledCourse);
}
else if (convcc_CoursePro.OperationDate  ==  AttributeName[intIndex])
{
mstrOperationDate = value.ToString();
 AddUpdatedFld(convcc_CoursePro.OperationDate);
}
else if (convcc_CoursePro.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.OrderNum);
}
else if (convcc_CoursePro.OuterLink  ==  AttributeName[intIndex])
{
mstrOuterLink = value.ToString();
 AddUpdatedFld(convcc_CoursePro.OuterLink);
}
else if (convcc_CoursePro.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.ViewCount);
}
else if (convcc_CoursePro.ThemeId  ==  AttributeName[intIndex])
{
mstrThemeId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ThemeId);
}
else if (convcc_CoursePro.ThemeName  ==  AttributeName[intIndex])
{
mstrThemeName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ThemeName);
}
else if (convcc_CoursePro.ExampleImgPath  ==  AttributeName[intIndex])
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convcc_CoursePro.ExampleImgPath);
}
else if (convcc_CoursePro.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_CoursePro.IdXzMajor);
}
else if (convcc_CoursePro.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convcc_CoursePro.MajorID);
}
else if (convcc_CoursePro.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.MajorName);
}
else if (convcc_CoursePro.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_CoursePro.IdXzCollege);
}
else if (convcc_CoursePro.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CollegeId);
}
else if (convcc_CoursePro.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CollegeName);
}
else if (convcc_CoursePro.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_CoursePro.CollegeNameA);
}
else if (convcc_CoursePro.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CoursePro.Memo);
}
else if (convcc_CoursePro.QuestionNum  ==  AttributeName[intIndex])
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.QuestionNum);
}
else if (convcc_CoursePro.KnowledgesNum  ==  AttributeName[intIndex])
{
mintKnowledgesNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.KnowledgesNum);
}
else if (convcc_CoursePro.TeacherNum  ==  AttributeName[intIndex])
{
mintTeacherNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.TeacherNum);
}
else if (convcc_CoursePro.ChapterNum  ==  AttributeName[intIndex])
{
mintChapterNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CoursePro.ChapterNum);
}
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
 AddUpdatedFld(convcc_CoursePro.CourseId);
}
}
/// <summary>
/// LikeCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LikeCount
{
get
{
return mintLikeCount;
}
set
{
 mintLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CoursePro.LikeCount);
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
 AddUpdatedFld(convcc_CoursePro.CourseCode);
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
 AddUpdatedFld(convcc_CoursePro.CourseDescription);
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
 AddUpdatedFld(convcc_CoursePro.CourseName);
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
 AddUpdatedFld(convcc_CoursePro.CourseTypeId);
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
 AddUpdatedFld(convcc_CoursePro.CourseTypeName);
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
 AddUpdatedFld(convcc_CoursePro.CreateDate);
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
 AddUpdatedFld(convcc_CoursePro.ExcellentTypeId);
}
}
/// <summary>
/// 精品课程类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTypeName
{
get
{
return mstrExcellentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTypeName = value;
}
else
{
 mstrExcellentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CoursePro.ExcellentTypeName);
}
}
/// <summary>
/// 课程年份(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ExcellentYear
{
get
{
return mintExcellentYear;
}
set
{
 mintExcellentYear = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CoursePro.ExcellentYear);
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
 AddUpdatedFld(convcc_CoursePro.IsBuildingCourse);
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
 AddUpdatedFld(convcc_CoursePro.IsDoubleLanguageCourse);
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
 AddUpdatedFld(convcc_CoursePro.IsOpen);
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
 AddUpdatedFld(convcc_CoursePro.IsRecommendedCourse);
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
 AddUpdatedFld(convcc_CoursePro.IsSelfPropelledCourse);
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
 AddUpdatedFld(convcc_CoursePro.OperationDate);
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
 AddUpdatedFld(convcc_CoursePro.OrderNum);
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
 AddUpdatedFld(convcc_CoursePro.OuterLink);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ViewCount
{
get
{
return mintViewCount;
}
set
{
 mintViewCount = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CoursePro.ViewCount);
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
 AddUpdatedFld(convcc_CoursePro.ThemeId);
}
}
/// <summary>
/// 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThemeName
{
get
{
return mstrThemeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThemeName = value;
}
else
{
 mstrThemeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CoursePro.ThemeName);
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
 AddUpdatedFld(convcc_CoursePro.ExampleImgPath);
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
 AddUpdatedFld(convcc_CoursePro.IdXzMajor);
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
 AddUpdatedFld(convcc_CoursePro.MajorID);
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
 AddUpdatedFld(convcc_CoursePro.MajorName);
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
 AddUpdatedFld(convcc_CoursePro.IdXzCollege);
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
 AddUpdatedFld(convcc_CoursePro.CollegeId);
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
 AddUpdatedFld(convcc_CoursePro.CollegeName);
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
 AddUpdatedFld(convcc_CoursePro.CollegeNameA);
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
 AddUpdatedFld(convcc_CoursePro.Memo);
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
 AddUpdatedFld(convcc_CoursePro.QuestionNum);
}
}
/// <summary>
/// 知识点数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? KnowledgesNum
{
get
{
return mintKnowledgesNum;
}
set
{
 mintKnowledgesNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CoursePro.KnowledgesNum);
}
}
/// <summary>
/// 教师数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TeacherNum
{
get
{
return mintTeacherNum;
}
set
{
 mintTeacherNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CoursePro.TeacherNum);
}
}
/// <summary>
/// 章节数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ChapterNum
{
get
{
return mintChapterNum;
}
set
{
 mintChapterNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CoursePro.ChapterNum);
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
  return mstrCourseId;
 }
 }
}
 /// <summary>
 /// v课程Pro(vcc_CoursePro)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CoursePro
{
public const string _CurrTabName = "vcc_CoursePro"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseId", "LikeCount", "CourseCode", "CourseDescription", "CourseName", "CourseTypeId", "CourseTypeName", "CreateDate", "ExcellentTypeId", "ExcellentTypeName", "ExcellentYear", "IsBuildingCourse", "IsDoubleLanguageCourse", "IsOpen", "IsRecommendedCourse", "IsSelfPropelledCourse", "OperationDate", "OrderNum", "OuterLink", "ViewCount", "ThemeId", "ThemeName", "ExampleImgPath", "IdXzMajor", "MajorID", "MajorName", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "Memo", "QuestionNum", "KnowledgesNum", "TeacherNum", "ChapterNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //LikeCount

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
 /// 常量:"ExcellentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTypeName = "ExcellentTypeName";    //精品课程类型名称

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
 /// 常量:"ThemeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThemeName = "ThemeName";    //主题名

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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"QuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNum = "QuestionNum";    //题目数

 /// <summary>
 /// 常量:"KnowledgesNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgesNum = "KnowledgesNum";    //知识点数

 /// <summary>
 /// 常量:"TeacherNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherNum = "TeacherNum";    //教师数

 /// <summary>
 /// 常量:"ChapterNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNum = "ChapterNum";    //章节数
}

}