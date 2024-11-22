
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningAppraiseEN
 表名:vCourseLearningAppraise(01120269)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表vCourseLearningAppraise的关键字(IdMicroteachAppraise)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachAppraise_vCourseLearningAppraise
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroteachAppraise">表关键字</param>
public K_IdMicroteachAppraise_vCourseLearningAppraise(long lngIdMicroteachAppraise)
{
if (IsValid(lngIdMicroteachAppraise)) Value = lngIdMicroteachAppraise;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroteachAppraise)
{
if (lngIdMicroteachAppraise == 0) return false;
if (lngIdMicroteachAppraise == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachAppraise_vCourseLearningAppraise]类型的对象</returns>
public static implicit operator K_IdMicroteachAppraise_vCourseLearningAppraise(long value)
{
return new K_IdMicroteachAppraise_vCourseLearningAppraise(value);
}
}
 /// <summary>
 /// v课程学习定性评议(vCourseLearningAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCourseLearningAppraiseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCourseLearningAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 42;
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "CourseLearningCaseTypeName", "UserNameWithUserId", "IdXzCollege", "CollegeID", "CollegeName", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "CollegeNameA", "IdMicroteachAppraise", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "AppraiseTheme", "AppraiseContent", "AppraiseDate", "AppraiseTime", "IsVisual", "IsElite", "UserId", "ExcellentOne", "ExcellentTwo", "SuggestOne", "SuggestTwo", "MicroteachAppriseScore", "VideoStopTime", "BrowseCount", "BrowseCount4Case", "UserName"};

protected string mstrIdCourseLearningCase;    //课程学习案例流水号
protected string mstrCourseLearningCaseID;    //课程学习案例ID
protected string mstrCourseLearningCaseName;    //课程学习案例名称
protected string mstrCourseLearningCaseTheme;    //课程学习案例主题词
protected string mstrCourseLearningCaseDate;    //课程学习日期
protected string mstrCourseLearningCaseTime;    //课程学习时间
protected string mstrCourseLearningCaseDateIn;    //案例入库日期
protected string mstrCourseLearningCaseTimeIn;    //案例入库时间
protected string mstrCourseLearningCaseTypeName;    //课程学习案例类型名称
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrCollegeNameA;    //学院名称简写
protected long mlngIdMicroteachAppraise;    //评议流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrAppraiseTheme;    //评议主题
protected string mstrAppraiseContent;    //评议内容
protected string mstrAppraiseDate;    //评议日期
protected string mstrAppraiseTime;    //评议时间
protected bool mbolIsVisual;    //隐藏标志
protected bool mbolIsElite;    //精华标志
protected string mstrUserId;    //用户ID
protected string mstrExcellentOne;    //优点1
protected string mstrExcellentTwo;    //优点2
protected string mstrSuggestOne;    //建议1
protected string mstrSuggestTwo;    //建议2
protected float? mfltMicroteachAppriseScore;    //打分
protected string mstrVideoStopTime;    //公开课案例视频暂停时间
protected int? mintBrowseCount;    //浏览次数
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCourseLearningAppraiseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachAppraise");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroteachAppraise">关键字:评议流水号</param>
public clsvCourseLearningAppraiseEN(long lngIdMicroteachAppraise)
 {
 if (lngIdMicroteachAppraise  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroteachAppraise = lngIdMicroteachAppraise;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachAppraise");
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
if (strAttributeName  ==  convCourseLearningAppraise.IdCourseLearningCase)
{
return mstrIdCourseLearningCase;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseID)
{
return mstrCourseLearningCaseID;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseName)
{
return mstrCourseLearningCaseName;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseTheme)
{
return mstrCourseLearningCaseTheme;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseDate)
{
return mstrCourseLearningCaseDate;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseTime)
{
return mstrCourseLearningCaseTime;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseDateIn)
{
return mstrCourseLearningCaseDateIn;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseTimeIn)
{
return mstrCourseLearningCaseTimeIn;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseTypeName)
{
return mstrCourseLearningCaseTypeName;
}
else if (strAttributeName  ==  convCourseLearningAppraise.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCourseLearningAppraise.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convCourseLearningAppraise.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCourseLearningAppraise.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdMicroteachAppraise)
{
return mlngIdMicroteachAppraise;
}
else if (strAttributeName  ==  convCourseLearningAppraise.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCourseLearningAppraise.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseTheme)
{
return mstrAppraiseTheme;
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseDate)
{
return mstrAppraiseDate;
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseTime)
{
return mstrAppraiseTime;
}
else if (strAttributeName  ==  convCourseLearningAppraise.IsVisual)
{
return mbolIsVisual;
}
else if (strAttributeName  ==  convCourseLearningAppraise.IsElite)
{
return mbolIsElite;
}
else if (strAttributeName  ==  convCourseLearningAppraise.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCourseLearningAppraise.ExcellentOne)
{
return mstrExcellentOne;
}
else if (strAttributeName  ==  convCourseLearningAppraise.ExcellentTwo)
{
return mstrExcellentTwo;
}
else if (strAttributeName  ==  convCourseLearningAppraise.SuggestOne)
{
return mstrSuggestOne;
}
else if (strAttributeName  ==  convCourseLearningAppraise.SuggestTwo)
{
return mstrSuggestTwo;
}
else if (strAttributeName  ==  convCourseLearningAppraise.MicroteachAppriseScore)
{
return mfltMicroteachAppriseScore;
}
else if (strAttributeName  ==  convCourseLearningAppraise.VideoStopTime)
{
return mstrVideoStopTime;
}
else if (strAttributeName  ==  convCourseLearningAppraise.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCourseLearningAppraise.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convCourseLearningAppraise.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convCourseLearningAppraise.IdCourseLearningCase)
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdCourseLearningCase);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseID)
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseID);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseName)
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseName);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseTheme)
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTheme);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseDate)
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseDate);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseTime)
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTime);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseDateIn)
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseDateIn);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseTimeIn)
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTimeIn);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseLearningCaseTypeName)
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTypeName);
}
else if (strAttributeName  ==  convCourseLearningAppraise.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.UserNameWithUserId);
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdXzCollege);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CollegeID);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CollegeName);
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdXzMajor);
}
else if (strAttributeName  ==  convCourseLearningAppraise.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.MajorID);
}
else if (strAttributeName  ==  convCourseLearningAppraise.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.MajorName);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseId);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseCode);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseName);
}
else if (strAttributeName  ==  convCourseLearningAppraise.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CollegeNameA);
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdMicroteachAppraise)
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.IdMicroteachAppraise);
}
else if (strAttributeName  ==  convCourseLearningAppraise.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.FuncModuleId);
}
else if (strAttributeName  ==  convCourseLearningAppraise.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.FuncModuleName);
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdMicroteachCase);
}
else if (strAttributeName  ==  convCourseLearningAppraise.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdAppraiseType);
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTypeName);
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseTheme)
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTheme);
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseContent);
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseDate)
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseDate);
}
else if (strAttributeName  ==  convCourseLearningAppraise.AppraiseTime)
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTime);
}
else if (strAttributeName  ==  convCourseLearningAppraise.IsVisual)
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.IsVisual);
}
else if (strAttributeName  ==  convCourseLearningAppraise.IsElite)
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.IsElite);
}
else if (strAttributeName  ==  convCourseLearningAppraise.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.UserId);
}
else if (strAttributeName  ==  convCourseLearningAppraise.ExcellentOne)
{
mstrExcellentOne = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.ExcellentOne);
}
else if (strAttributeName  ==  convCourseLearningAppraise.ExcellentTwo)
{
mstrExcellentTwo = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.ExcellentTwo);
}
else if (strAttributeName  ==  convCourseLearningAppraise.SuggestOne)
{
mstrSuggestOne = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.SuggestOne);
}
else if (strAttributeName  ==  convCourseLearningAppraise.SuggestTwo)
{
mstrSuggestTwo = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.SuggestTwo);
}
else if (strAttributeName  ==  convCourseLearningAppraise.MicroteachAppriseScore)
{
mfltMicroteachAppriseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.MicroteachAppriseScore);
}
else if (strAttributeName  ==  convCourseLearningAppraise.VideoStopTime)
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.VideoStopTime);
}
else if (strAttributeName  ==  convCourseLearningAppraise.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.BrowseCount);
}
else if (strAttributeName  ==  convCourseLearningAppraise.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.BrowseCount4Case);
}
else if (strAttributeName  ==  convCourseLearningAppraise.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convCourseLearningAppraise.IdCourseLearningCase  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCase;
}
else if (convCourseLearningAppraise.CourseLearningCaseID  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseID;
}
else if (convCourseLearningAppraise.CourseLearningCaseName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseName;
}
else if (convCourseLearningAppraise.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTheme;
}
else if (convCourseLearningAppraise.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDate;
}
else if (convCourseLearningAppraise.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTime;
}
else if (convCourseLearningAppraise.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDateIn;
}
else if (convCourseLearningAppraise.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTimeIn;
}
else if (convCourseLearningAppraise.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTypeName;
}
else if (convCourseLearningAppraise.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convCourseLearningAppraise.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCourseLearningAppraise.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convCourseLearningAppraise.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCourseLearningAppraise.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCourseLearningAppraise.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convCourseLearningAppraise.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCourseLearningAppraise.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCourseLearningAppraise.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCourseLearningAppraise.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCourseLearningAppraise.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convCourseLearningAppraise.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
return mlngIdMicroteachAppraise;
}
else if (convCourseLearningAppraise.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCourseLearningAppraise.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCourseLearningAppraise.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convCourseLearningAppraise.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convCourseLearningAppraise.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convCourseLearningAppraise.AppraiseTheme  ==  AttributeName[intIndex])
{
return mstrAppraiseTheme;
}
else if (convCourseLearningAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (convCourseLearningAppraise.AppraiseDate  ==  AttributeName[intIndex])
{
return mstrAppraiseDate;
}
else if (convCourseLearningAppraise.AppraiseTime  ==  AttributeName[intIndex])
{
return mstrAppraiseTime;
}
else if (convCourseLearningAppraise.IsVisual  ==  AttributeName[intIndex])
{
return mbolIsVisual;
}
else if (convCourseLearningAppraise.IsElite  ==  AttributeName[intIndex])
{
return mbolIsElite;
}
else if (convCourseLearningAppraise.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCourseLearningAppraise.ExcellentOne  ==  AttributeName[intIndex])
{
return mstrExcellentOne;
}
else if (convCourseLearningAppraise.ExcellentTwo  ==  AttributeName[intIndex])
{
return mstrExcellentTwo;
}
else if (convCourseLearningAppraise.SuggestOne  ==  AttributeName[intIndex])
{
return mstrSuggestOne;
}
else if (convCourseLearningAppraise.SuggestTwo  ==  AttributeName[intIndex])
{
return mstrSuggestTwo;
}
else if (convCourseLearningAppraise.MicroteachAppriseScore  ==  AttributeName[intIndex])
{
return mfltMicroteachAppriseScore;
}
else if (convCourseLearningAppraise.VideoStopTime  ==  AttributeName[intIndex])
{
return mstrVideoStopTime;
}
else if (convCourseLearningAppraise.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCourseLearningAppraise.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convCourseLearningAppraise.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (convCourseLearningAppraise.IdCourseLearningCase  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdCourseLearningCase);
}
else if (convCourseLearningAppraise.CourseLearningCaseID  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseID);
}
else if (convCourseLearningAppraise.CourseLearningCaseName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseName);
}
else if (convCourseLearningAppraise.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTheme);
}
else if (convCourseLearningAppraise.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseDate);
}
else if (convCourseLearningAppraise.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTime);
}
else if (convCourseLearningAppraise.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseDateIn);
}
else if (convCourseLearningAppraise.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTimeIn);
}
else if (convCourseLearningAppraise.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTypeName);
}
else if (convCourseLearningAppraise.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.UserNameWithUserId);
}
else if (convCourseLearningAppraise.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdXzCollege);
}
else if (convCourseLearningAppraise.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CollegeID);
}
else if (convCourseLearningAppraise.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CollegeName);
}
else if (convCourseLearningAppraise.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdXzMajor);
}
else if (convCourseLearningAppraise.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.MajorID);
}
else if (convCourseLearningAppraise.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.MajorName);
}
else if (convCourseLearningAppraise.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseId);
}
else if (convCourseLearningAppraise.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseCode);
}
else if (convCourseLearningAppraise.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CourseName);
}
else if (convCourseLearningAppraise.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.CollegeNameA);
}
else if (convCourseLearningAppraise.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.IdMicroteachAppraise);
}
else if (convCourseLearningAppraise.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.FuncModuleId);
}
else if (convCourseLearningAppraise.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.FuncModuleName);
}
else if (convCourseLearningAppraise.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdMicroteachCase);
}
else if (convCourseLearningAppraise.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.IdAppraiseType);
}
else if (convCourseLearningAppraise.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTypeName);
}
else if (convCourseLearningAppraise.AppraiseTheme  ==  AttributeName[intIndex])
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTheme);
}
else if (convCourseLearningAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseContent);
}
else if (convCourseLearningAppraise.AppraiseDate  ==  AttributeName[intIndex])
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseDate);
}
else if (convCourseLearningAppraise.AppraiseTime  ==  AttributeName[intIndex])
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTime);
}
else if (convCourseLearningAppraise.IsVisual  ==  AttributeName[intIndex])
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.IsVisual);
}
else if (convCourseLearningAppraise.IsElite  ==  AttributeName[intIndex])
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.IsElite);
}
else if (convCourseLearningAppraise.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.UserId);
}
else if (convCourseLearningAppraise.ExcellentOne  ==  AttributeName[intIndex])
{
mstrExcellentOne = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.ExcellentOne);
}
else if (convCourseLearningAppraise.ExcellentTwo  ==  AttributeName[intIndex])
{
mstrExcellentTwo = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.ExcellentTwo);
}
else if (convCourseLearningAppraise.SuggestOne  ==  AttributeName[intIndex])
{
mstrSuggestOne = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.SuggestOne);
}
else if (convCourseLearningAppraise.SuggestTwo  ==  AttributeName[intIndex])
{
mstrSuggestTwo = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.SuggestTwo);
}
else if (convCourseLearningAppraise.MicroteachAppriseScore  ==  AttributeName[intIndex])
{
mfltMicroteachAppriseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.MicroteachAppriseScore);
}
else if (convCourseLearningAppraise.VideoStopTime  ==  AttributeName[intIndex])
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.VideoStopTime);
}
else if (convCourseLearningAppraise.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.BrowseCount);
}
else if (convCourseLearningAppraise.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise.BrowseCount4Case);
}
else if (convCourseLearningAppraise.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise.UserName);
}
}
}

/// <summary>
/// 课程学习案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourseLearningCase
{
get
{
return mstrIdCourseLearningCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourseLearningCase = value;
}
else
{
 mstrIdCourseLearningCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.IdCourseLearningCase);
}
}
/// <summary>
/// 课程学习案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseID
{
get
{
return mstrCourseLearningCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseID = value;
}
else
{
 mstrCourseLearningCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseID);
}
}
/// <summary>
/// 课程学习案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseName
{
get
{
return mstrCourseLearningCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseName = value;
}
else
{
 mstrCourseLearningCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseName);
}
}
/// <summary>
/// 课程学习案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTheme
{
get
{
return mstrCourseLearningCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTheme = value;
}
else
{
 mstrCourseLearningCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTheme);
}
}
/// <summary>
/// 课程学习日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseDate
{
get
{
return mstrCourseLearningCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseDate = value;
}
else
{
 mstrCourseLearningCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseDate);
}
}
/// <summary>
/// 课程学习时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTime
{
get
{
return mstrCourseLearningCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTime = value;
}
else
{
 mstrCourseLearningCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseDateIn
{
get
{
return mstrCourseLearningCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseDateIn = value;
}
else
{
 mstrCourseLearningCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTimeIn
{
get
{
return mstrCourseLearningCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTimeIn = value;
}
else
{
 mstrCourseLearningCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTimeIn);
}
}
/// <summary>
/// 课程学习案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTypeName
{
get
{
return mstrCourseLearningCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTypeName = value;
}
else
{
 mstrCourseLearningCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CourseLearningCaseTypeName);
}
}
/// <summary>
/// UserNameWithUserId(说明:;字段类型:varchar;字段长度:51;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserNameWithUserId
{
get
{
return mstrUserNameWithUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserNameWithUserId = value;
}
else
{
 mstrUserNameWithUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.UserNameWithUserId);
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
 AddUpdatedFld(convCourseLearningAppraise.IdXzCollege);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeID
{
get
{
return mstrCollegeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeID = value;
}
else
{
 mstrCollegeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.CollegeID);
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
 AddUpdatedFld(convCourseLearningAppraise.CollegeName);
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
 AddUpdatedFld(convCourseLearningAppraise.IdXzMajor);
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
 AddUpdatedFld(convCourseLearningAppraise.MajorID);
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
 AddUpdatedFld(convCourseLearningAppraise.MajorName);
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
 AddUpdatedFld(convCourseLearningAppraise.CourseId);
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
 AddUpdatedFld(convCourseLearningAppraise.CourseCode);
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
 AddUpdatedFld(convCourseLearningAppraise.CourseName);
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
 AddUpdatedFld(convCourseLearningAppraise.CollegeNameA);
}
}
/// <summary>
/// 评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroteachAppraise
{
get
{
return mlngIdMicroteachAppraise;
}
set
{
 mlngIdMicroteachAppraise = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.IdMicroteachAppraise);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.FuncModuleName);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.IdMicroteachCase);
}
}
/// <summary>
/// 评议类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAppraiseType
{
get
{
return mstrIdAppraiseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAppraiseType = value;
}
else
{
 mstrIdAppraiseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.IdAppraiseType);
}
}
/// <summary>
/// 评议类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeName
{
get
{
return mstrAppraiseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeName = value;
}
else
{
 mstrAppraiseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTypeName);
}
}
/// <summary>
/// 评议主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTheme
{
get
{
return mstrAppraiseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTheme = value;
}
else
{
 mstrAppraiseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTheme);
}
}
/// <summary>
/// 评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseContent
{
get
{
return mstrAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseContent = value;
}
else
{
 mstrAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.AppraiseContent);
}
}
/// <summary>
/// 评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseDate
{
get
{
return mstrAppraiseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseDate = value;
}
else
{
 mstrAppraiseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.AppraiseDate);
}
}
/// <summary>
/// 评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTime
{
get
{
return mstrAppraiseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTime = value;
}
else
{
 mstrAppraiseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.AppraiseTime);
}
}
/// <summary>
/// 隐藏标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisual
{
get
{
return mbolIsVisual;
}
set
{
 mbolIsVisual = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.IsVisual);
}
}
/// <summary>
/// 精华标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsElite
{
get
{
return mbolIsElite;
}
set
{
 mbolIsElite = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.IsElite);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.UserId);
}
}
/// <summary>
/// 优点1(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentOne
{
get
{
return mstrExcellentOne;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentOne = value;
}
else
{
 mstrExcellentOne = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.ExcellentOne);
}
}
/// <summary>
/// 优点2(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTwo
{
get
{
return mstrExcellentTwo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTwo = value;
}
else
{
 mstrExcellentTwo = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.ExcellentTwo);
}
}
/// <summary>
/// 建议1(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SuggestOne
{
get
{
return mstrSuggestOne;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSuggestOne = value;
}
else
{
 mstrSuggestOne = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.SuggestOne);
}
}
/// <summary>
/// 建议2(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SuggestTwo
{
get
{
return mstrSuggestTwo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSuggestTwo = value;
}
else
{
 mstrSuggestTwo = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.SuggestTwo);
}
}
/// <summary>
/// 打分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? MicroteachAppriseScore
{
get
{
return mfltMicroteachAppriseScore;
}
set
{
 mfltMicroteachAppriseScore = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.MicroteachAppriseScore);
}
}
/// <summary>
/// 公开课案例视频暂停时间(说明:;字段类型:varchar;字段长度:48;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoStopTime
{
get
{
return mstrVideoStopTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoStopTime = value;
}
else
{
 mstrVideoStopTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.VideoStopTime);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.BrowseCount);
}
}
/// <summary>
/// 课例浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount4Case
{
get
{
return mintBrowseCount4Case;
}
set
{
 mintBrowseCount4Case = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise.BrowseCount4Case);
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
 AddUpdatedFld(convCourseLearningAppraise.UserName);
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
  return mlngIdMicroteachAppraise.ToString();
 }
 }
}
 /// <summary>
 /// v课程学习定性评议(vCourseLearningAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCourseLearningAppraise
{
public const string _CurrTabName = "vCourseLearningAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "CourseLearningCaseTypeName", "UserNameWithUserId", "IdXzCollege", "CollegeID", "CollegeName", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "CollegeNameA", "IdMicroteachAppraise", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "AppraiseTheme", "AppraiseContent", "AppraiseDate", "AppraiseTime", "IsVisual", "IsElite", "UserId", "ExcellentOne", "ExcellentTwo", "SuggestOne", "SuggestTwo", "MicroteachAppriseScore", "VideoStopTime", "BrowseCount", "BrowseCount4Case", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCourseLearningCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseLearningCase = "IdCourseLearningCase";    //课程学习案例流水号

 /// <summary>
 /// 常量:"CourseLearningCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseID = "CourseLearningCaseID";    //课程学习案例ID

 /// <summary>
 /// 常量:"CourseLearningCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseName = "CourseLearningCaseName";    //课程学习案例名称

 /// <summary>
 /// 常量:"CourseLearningCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTheme = "CourseLearningCaseTheme";    //课程学习案例主题词

 /// <summary>
 /// 常量:"CourseLearningCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseDate = "CourseLearningCaseDate";    //课程学习日期

 /// <summary>
 /// 常量:"CourseLearningCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTime = "CourseLearningCaseTime";    //课程学习时间

 /// <summary>
 /// 常量:"CourseLearningCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseDateIn = "CourseLearningCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CourseLearningCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTimeIn = "CourseLearningCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"CourseLearningCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTypeName = "CourseLearningCaseTypeName";    //课程学习案例类型名称

 /// <summary>
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"IdMicroteachAppraise"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachAppraise = "IdMicroteachAppraise";    //评议流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName = "AppraiseTypeName";    //评议类型名称

 /// <summary>
 /// 常量:"AppraiseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTheme = "AppraiseTheme";    //评议主题

 /// <summary>
 /// 常量:"AppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseContent = "AppraiseContent";    //评议内容

 /// <summary>
 /// 常量:"AppraiseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseDate = "AppraiseDate";    //评议日期

 /// <summary>
 /// 常量:"AppraiseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTime = "AppraiseTime";    //评议时间

 /// <summary>
 /// 常量:"IsVisual"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisual = "IsVisual";    //隐藏标志

 /// <summary>
 /// 常量:"IsElite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsElite = "IsElite";    //精华标志

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"ExcellentOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentOne = "ExcellentOne";    //优点1

 /// <summary>
 /// 常量:"ExcellentTwo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTwo = "ExcellentTwo";    //优点2

 /// <summary>
 /// 常量:"SuggestOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuggestOne = "SuggestOne";    //建议1

 /// <summary>
 /// 常量:"SuggestTwo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuggestTwo = "SuggestTwo";    //建议2

 /// <summary>
 /// 常量:"MicroteachAppriseScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachAppriseScore = "MicroteachAppriseScore";    //打分

 /// <summary>
 /// 常量:"VideoStopTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoStopTime = "VideoStopTime";    //公开课案例视频暂停时间

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名
}

}