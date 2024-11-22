
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseFreeSenateEN
 表名:vPubClassCaseFreeSenate(01120412)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表vPubClassCaseFreeSenate的关键字(IdPubClassCaseFreeSenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseFreeSenate_vPubClassCaseFreeSenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubClassCaseFreeSenate">表关键字</param>
public K_IdPubClassCaseFreeSenate_vPubClassCaseFreeSenate(long lngIdPubClassCaseFreeSenate)
{
if (IsValid(lngIdPubClassCaseFreeSenate)) Value = lngIdPubClassCaseFreeSenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubClassCaseFreeSenate)
{
if (lngIdPubClassCaseFreeSenate == 0) return false;
if (lngIdPubClassCaseFreeSenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseFreeSenate_vPubClassCaseFreeSenate]类型的对象</returns>
public static implicit operator K_IdPubClassCaseFreeSenate_vPubClassCaseFreeSenate(long value)
{
return new K_IdPubClassCaseFreeSenate_vPubClassCaseFreeSenate(value);
}
}
 /// <summary>
 /// v公开课案例自由评议(vPubClassCaseFreeSenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPubClassCaseFreeSenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPubClassCaseFreeSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseFreeSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 35;
public static string[] AttributeName = new string[] {"IdPubClassCaseFreeSenate", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "PubClassCaseTheme", "UserId", "UserName", "AppraiseTheme", "PubClassCaseFreeSenateTitle", "PubClassCaseFreeSenateConten", "PubClassCaseFreeSenateDate", "PubClassCaseFreeSenateTime", "BrowseCount", "VideoStopTime", "IsVisible", "IdDiscipline", "DisciplineID", "DisciplineName", "IdStudyLevel", "StudyLevelName", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdTeachingPlan", "SubjectName", "IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "CollegeID", "CollegeName", "IdXzCollege", "IsLeaved", "StuIdTeacherId", "BrowseCount4Case", "CollegeNameA"};

protected long mlngIdPubClassCaseFreeSenate;    //公开课案例自由评议流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrPubClassCaseID;    //案例ID
protected string mstrPubClassCaseName;    //案例课题名称
protected string mstrPubClassCaseExecutor;    //案例执教者
protected string mstrPubClassCaseTheme;    //案例主题词
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrAppraiseTheme;    //评议主题
protected string mstrPubClassCaseFreeSenateTitle;    //公开课案例自由评议标题
protected string mstrPubClassCaseFreeSenateConten;    //公开课案例自由评议内容
protected string mstrPubClassCaseFreeSenateDate;    //公开课案例自由评议日期
protected string mstrPubClassCaseFreeSenateTime;    //公开课案例自由评议时间
protected int? mintBrowseCount;    //浏览次数
protected string mstrVideoStopTime;    //公开课案例视频暂停时间
protected bool mbolIsVisible;    //是否显示
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrPubClassCaseTeachDate;    //案例授课日期
protected string mstrPubClassCaseDateIn;    //案例入库日期
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrSubjectName;    //课题名称
protected string mstrIdPubCaseType;    //公开课案例类型流水号
protected string mstrPubCaseTypeID;    //公开课案例类型ID
protected string mstrPubCaseTypeName;    //公开课案例类型名称
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzCollege;    //学院流水号
protected bool mbolIsLeaved;    //IsLeaved
protected string mstrStuIdTeacherId;    //学工号
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPubClassCaseFreeSenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseFreeSenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubClassCaseFreeSenate">关键字:公开课案例自由评议流水号</param>
public clsvPubClassCaseFreeSenateEN(long lngIdPubClassCaseFreeSenate)
 {
 if (lngIdPubClassCaseFreeSenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubClassCaseFreeSenate = lngIdPubClassCaseFreeSenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseFreeSenate");
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
if (strAttributeName  ==  convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate)
{
return mlngIdPubClassCaseFreeSenate;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseID)
{
return mstrPubClassCaseID;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseName)
{
return mstrPubClassCaseName;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseExecutor)
{
return mstrPubClassCaseExecutor;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseTheme)
{
return mstrPubClassCaseTheme;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.AppraiseTheme)
{
return mstrAppraiseTheme;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle)
{
return mstrPubClassCaseFreeSenateTitle;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten)
{
return mstrPubClassCaseFreeSenateConten;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate)
{
return mstrPubClassCaseFreeSenateDate;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime)
{
return mstrPubClassCaseFreeSenateTime;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.VideoStopTime)
{
return mstrVideoStopTime;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseTeachDate)
{
return mstrPubClassCaseTeachDate;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseDateIn)
{
return mstrPubClassCaseDateIn;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.SubjectName)
{
return mstrSubjectName;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdPubCaseType)
{
return mstrIdPubCaseType;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubCaseTypeID)
{
return mstrPubCaseTypeID;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubCaseTypeName)
{
return mstrPubCaseTypeName;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate)
{
mlngIdPubClassCaseFreeSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubClassCase);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseID)
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseID);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseName)
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseName);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseExecutor)
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseExecutor);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseTheme)
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseTheme);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.UserId);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.UserName);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.AppraiseTheme)
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.AppraiseTheme);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle)
{
mstrPubClassCaseFreeSenateTitle = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten)
{
mstrPubClassCaseFreeSenateConten = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate)
{
mstrPubClassCaseFreeSenateDate = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime)
{
mstrPubClassCaseFreeSenateTime = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.BrowseCount);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.VideoStopTime)
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.VideoStopTime);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.IsVisible);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdDiscipline);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.DisciplineID);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.DisciplineName);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdStudyLevel);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.StudyLevelName);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseTeachDate)
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseTeachDate);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubClassCaseDateIn)
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseDateIn);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdTeachingPlan);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.SubjectName)
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.SubjectName);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdPubCaseType)
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubCaseType);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubCaseTypeID)
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubCaseTypeID);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.PubCaseTypeName)
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubCaseTypeName);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeID);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeName);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdXzCollege);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.IsLeaved);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.StuIdTeacherId);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.BrowseCount4Case);
}
else if (strAttributeName  ==  convPubClassCaseFreeSenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate  ==  AttributeName[intIndex])
{
return mlngIdPubClassCaseFreeSenate;
}
else if (convPubClassCaseFreeSenate.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (convPubClassCaseFreeSenate.PubClassCaseID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseID;
}
else if (convPubClassCaseFreeSenate.PubClassCaseName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseName;
}
else if (convPubClassCaseFreeSenate.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
return mstrPubClassCaseExecutor;
}
else if (convPubClassCaseFreeSenate.PubClassCaseTheme  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTheme;
}
else if (convPubClassCaseFreeSenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convPubClassCaseFreeSenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convPubClassCaseFreeSenate.AppraiseTheme  ==  AttributeName[intIndex])
{
return mstrAppraiseTheme;
}
else if (convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle  ==  AttributeName[intIndex])
{
return mstrPubClassCaseFreeSenateTitle;
}
else if (convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten  ==  AttributeName[intIndex])
{
return mstrPubClassCaseFreeSenateConten;
}
else if (convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseFreeSenateDate;
}
else if (convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime  ==  AttributeName[intIndex])
{
return mstrPubClassCaseFreeSenateTime;
}
else if (convPubClassCaseFreeSenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convPubClassCaseFreeSenate.VideoStopTime  ==  AttributeName[intIndex])
{
return mstrVideoStopTime;
}
else if (convPubClassCaseFreeSenate.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convPubClassCaseFreeSenate.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convPubClassCaseFreeSenate.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (convPubClassCaseFreeSenate.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convPubClassCaseFreeSenate.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convPubClassCaseFreeSenate.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convPubClassCaseFreeSenate.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTeachDate;
}
else if (convPubClassCaseFreeSenate.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
return mstrPubClassCaseDateIn;
}
else if (convPubClassCaseFreeSenate.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convPubClassCaseFreeSenate.SubjectName  ==  AttributeName[intIndex])
{
return mstrSubjectName;
}
else if (convPubClassCaseFreeSenate.IdPubCaseType  ==  AttributeName[intIndex])
{
return mstrIdPubCaseType;
}
else if (convPubClassCaseFreeSenate.PubCaseTypeID  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeID;
}
else if (convPubClassCaseFreeSenate.PubCaseTypeName  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeName;
}
else if (convPubClassCaseFreeSenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convPubClassCaseFreeSenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convPubClassCaseFreeSenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convPubClassCaseFreeSenate.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (convPubClassCaseFreeSenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (convPubClassCaseFreeSenate.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convPubClassCaseFreeSenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate  ==  AttributeName[intIndex])
{
mlngIdPubClassCaseFreeSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate);
}
else if (convPubClassCaseFreeSenate.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubClassCase);
}
else if (convPubClassCaseFreeSenate.PubClassCaseID  ==  AttributeName[intIndex])
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseID);
}
else if (convPubClassCaseFreeSenate.PubClassCaseName  ==  AttributeName[intIndex])
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseName);
}
else if (convPubClassCaseFreeSenate.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseExecutor);
}
else if (convPubClassCaseFreeSenate.PubClassCaseTheme  ==  AttributeName[intIndex])
{
mstrPubClassCaseTheme = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseTheme);
}
else if (convPubClassCaseFreeSenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.UserId);
}
else if (convPubClassCaseFreeSenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.UserName);
}
else if (convPubClassCaseFreeSenate.AppraiseTheme  ==  AttributeName[intIndex])
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.AppraiseTheme);
}
else if (convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle  ==  AttributeName[intIndex])
{
mstrPubClassCaseFreeSenateTitle = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
}
else if (convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten  ==  AttributeName[intIndex])
{
mstrPubClassCaseFreeSenateConten = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
}
else if (convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseFreeSenateDate = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
else if (convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime  ==  AttributeName[intIndex])
{
mstrPubClassCaseFreeSenateTime = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
}
else if (convPubClassCaseFreeSenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.BrowseCount);
}
else if (convPubClassCaseFreeSenate.VideoStopTime  ==  AttributeName[intIndex])
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.VideoStopTime);
}
else if (convPubClassCaseFreeSenate.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.IsVisible);
}
else if (convPubClassCaseFreeSenate.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdDiscipline);
}
else if (convPubClassCaseFreeSenate.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.DisciplineID);
}
else if (convPubClassCaseFreeSenate.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.DisciplineName);
}
else if (convPubClassCaseFreeSenate.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdStudyLevel);
}
else if (convPubClassCaseFreeSenate.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.StudyLevelName);
}
else if (convPubClassCaseFreeSenate.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseTeachDate);
}
else if (convPubClassCaseFreeSenate.PubClassCaseDateIn  ==  AttributeName[intIndex])
{
mstrPubClassCaseDateIn = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseDateIn);
}
else if (convPubClassCaseFreeSenate.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdTeachingPlan);
}
else if (convPubClassCaseFreeSenate.SubjectName  ==  AttributeName[intIndex])
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.SubjectName);
}
else if (convPubClassCaseFreeSenate.IdPubCaseType  ==  AttributeName[intIndex])
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubCaseType);
}
else if (convPubClassCaseFreeSenate.PubCaseTypeID  ==  AttributeName[intIndex])
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubCaseTypeID);
}
else if (convPubClassCaseFreeSenate.PubCaseTypeName  ==  AttributeName[intIndex])
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.PubCaseTypeName);
}
else if (convPubClassCaseFreeSenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeID);
}
else if (convPubClassCaseFreeSenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeName);
}
else if (convPubClassCaseFreeSenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.IdXzCollege);
}
else if (convPubClassCaseFreeSenate.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.IsLeaved);
}
else if (convPubClassCaseFreeSenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.StuIdTeacherId);
}
else if (convPubClassCaseFreeSenate.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseFreeSenate.BrowseCount4Case);
}
else if (convPubClassCaseFreeSenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeNameA);
}
}
}

/// <summary>
/// 公开课案例自由评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubClassCaseFreeSenate
{
get
{
return mlngIdPubClassCaseFreeSenate;
}
set
{
 mlngIdPubClassCaseFreeSenate = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCase
{
get
{
return mstrIdPubClassCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCase = value;
}
else
{
 mstrIdPubClassCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubClassCase);
}
}
/// <summary>
/// 案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseID
{
get
{
return mstrPubClassCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseID = value;
}
else
{
 mstrPubClassCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseID);
}
}
/// <summary>
/// 案例课题名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseName
{
get
{
return mstrPubClassCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseName = value;
}
else
{
 mstrPubClassCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseName);
}
}
/// <summary>
/// 案例执教者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseExecutor
{
get
{
return mstrPubClassCaseExecutor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseExecutor = value;
}
else
{
 mstrPubClassCaseExecutor = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseExecutor);
}
}
/// <summary>
/// 案例主题词(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseTheme
{
get
{
return mstrPubClassCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseTheme = value;
}
else
{
 mstrPubClassCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseTheme);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.UserId);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.UserName);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.AppraiseTheme);
}
}
/// <summary>
/// 公开课案例自由评议标题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseFreeSenateTitle
{
get
{
return mstrPubClassCaseFreeSenateTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseFreeSenateTitle = value;
}
else
{
 mstrPubClassCaseFreeSenateTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
}
}
/// <summary>
/// 公开课案例自由评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseFreeSenateConten
{
get
{
return mstrPubClassCaseFreeSenateConten;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseFreeSenateConten = value;
}
else
{
 mstrPubClassCaseFreeSenateConten = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
}
}
/// <summary>
/// 公开课案例自由评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseFreeSenateDate
{
get
{
return mstrPubClassCaseFreeSenateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseFreeSenateDate = value;
}
else
{
 mstrPubClassCaseFreeSenateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
}
/// <summary>
/// 公开课案例自由评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseFreeSenateTime
{
get
{
return mstrPubClassCaseFreeSenateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseFreeSenateTime = value;
}
else
{
 mstrPubClassCaseFreeSenateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.BrowseCount);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.VideoStopTime);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.IsVisible);
}
}
/// <summary>
/// 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDiscipline
{
get
{
return mstrIdDiscipline;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDiscipline = value;
}
else
{
 mstrIdDiscipline = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.IdDiscipline);
}
}
/// <summary>
/// 学科ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineID
{
get
{
return mstrDisciplineID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineID = value;
}
else
{
 mstrDisciplineID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.DisciplineID);
}
}
/// <summary>
/// 学科名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineName
{
get
{
return mstrDisciplineName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineName = value;
}
else
{
 mstrDisciplineName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.DisciplineName);
}
}
/// <summary>
/// id_StudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudyLevel
{
get
{
return mstrIdStudyLevel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudyLevel = value;
}
else
{
 mstrIdStudyLevel = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.IdStudyLevel);
}
}
/// <summary>
/// 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StudyLevelName
{
get
{
return mstrStudyLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStudyLevelName = value;
}
else
{
 mstrStudyLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.StudyLevelName);
}
}
/// <summary>
/// 案例授课日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseTeachDate
{
get
{
return mstrPubClassCaseTeachDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseTeachDate = value;
}
else
{
 mstrPubClassCaseTeachDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseTeachDate);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseDateIn
{
get
{
return mstrPubClassCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseDateIn = value;
}
else
{
 mstrPubClassCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubClassCaseDateIn);
}
}
/// <summary>
/// 教案流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingPlan
{
get
{
return mstrIdTeachingPlan;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingPlan = value;
}
else
{
 mstrIdTeachingPlan = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.IdTeachingPlan);
}
}
/// <summary>
/// 课题名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubjectName
{
get
{
return mstrSubjectName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubjectName = value;
}
else
{
 mstrSubjectName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.SubjectName);
}
}
/// <summary>
/// 公开课案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubCaseType
{
get
{
return mstrIdPubCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubCaseType = value;
}
else
{
 mstrIdPubCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.IdPubCaseType);
}
}
/// <summary>
/// 公开课案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeID
{
get
{
return mstrPubCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeID = value;
}
else
{
 mstrPubCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubCaseTypeID);
}
}
/// <summary>
/// 公开课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeName
{
get
{
return mstrPubCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeName = value;
}
else
{
 mstrPubCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.PubCaseTypeName);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeID);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeName);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.IdXzCollege);
}
}
/// <summary>
/// IsLeaved(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLeaved
{
get
{
return mbolIsLeaved;
}
set
{
 mbolIsLeaved = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.IsLeaved);
}
}
/// <summary>
/// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuIdTeacherId
{
get
{
return mstrStuIdTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuIdTeacherId = value;
}
else
{
 mstrStuIdTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseFreeSenate.StuIdTeacherId);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.BrowseCount4Case);
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
 AddUpdatedFld(convPubClassCaseFreeSenate.CollegeNameA);
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
  return mlngIdPubClassCaseFreeSenate.ToString();
 }
 }
}
 /// <summary>
 /// v公开课案例自由评议(vPubClassCaseFreeSenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPubClassCaseFreeSenate
{
public const string _CurrTabName = "vPubClassCaseFreeSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseFreeSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseFreeSenate", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "PubClassCaseTheme", "UserId", "UserName", "AppraiseTheme", "PubClassCaseFreeSenateTitle", "PubClassCaseFreeSenateConten", "PubClassCaseFreeSenateDate", "PubClassCaseFreeSenateTime", "BrowseCount", "VideoStopTime", "IsVisible", "IdDiscipline", "DisciplineID", "DisciplineName", "IdStudyLevel", "StudyLevelName", "PubClassCaseTeachDate", "PubClassCaseDateIn", "IdTeachingPlan", "SubjectName", "IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "CollegeID", "CollegeName", "IdXzCollege", "IsLeaved", "StuIdTeacherId", "BrowseCount4Case", "CollegeNameA"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseFreeSenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseFreeSenate = "IdPubClassCaseFreeSenate";    //公开课案例自由评议流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"PubClassCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseID = "PubClassCaseID";    //案例ID

 /// <summary>
 /// 常量:"PubClassCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseName = "PubClassCaseName";    //案例课题名称

 /// <summary>
 /// 常量:"PubClassCaseExecutor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseExecutor = "PubClassCaseExecutor";    //案例执教者

 /// <summary>
 /// 常量:"PubClassCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTheme = "PubClassCaseTheme";    //案例主题词

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"AppraiseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTheme = "AppraiseTheme";    //评议主题

 /// <summary>
 /// 常量:"PubClassCaseFreeSenateTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseFreeSenateTitle = "PubClassCaseFreeSenateTitle";    //公开课案例自由评议标题

 /// <summary>
 /// 常量:"PubClassCaseFreeSenateConten"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseFreeSenateConten = "PubClassCaseFreeSenateConten";    //公开课案例自由评议内容

 /// <summary>
 /// 常量:"PubClassCaseFreeSenateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseFreeSenateDate = "PubClassCaseFreeSenateDate";    //公开课案例自由评议日期

 /// <summary>
 /// 常量:"PubClassCaseFreeSenateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseFreeSenateTime = "PubClassCaseFreeSenateTime";    //公开课案例自由评议时间

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"VideoStopTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoStopTime = "VideoStopTime";    //公开课案例视频暂停时间

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

 /// <summary>
 /// 常量:"DisciplineID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineID = "DisciplineID";    //学科ID

 /// <summary>
 /// 常量:"DisciplineName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineName = "DisciplineName";    //学科名称

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //id_StudyLevel

 /// <summary>
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

 /// <summary>
 /// 常量:"PubClassCaseTeachDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTeachDate = "PubClassCaseTeachDate";    //案例授课日期

 /// <summary>
 /// 常量:"PubClassCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseDateIn = "PubClassCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"SubjectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubjectName = "SubjectName";    //课题名称

 /// <summary>
 /// 常量:"IdPubCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubCaseType = "IdPubCaseType";    //公开课案例类型流水号

 /// <summary>
 /// 常量:"PubCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeID = "PubCaseTypeID";    //公开课案例类型ID

 /// <summary>
 /// 常量:"PubCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeName = "PubCaseTypeName";    //公开课案例类型名称

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
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IsLeaved"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeaved = "IsLeaved";    //IsLeaved

 /// <summary>
 /// 常量:"StuIdTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuIdTeacherId = "StuIdTeacherId";    //学工号

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}