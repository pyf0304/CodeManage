
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibAppraiseEN
 表名:vVideoLibAppraise(01120266)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
 /// 表vVideoLibAppraise的关键字(IdMicroteachAppraise)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachAppraise_vVideoLibAppraise
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
public K_IdMicroteachAppraise_vVideoLibAppraise(long lngIdMicroteachAppraise)
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
 /// <returns>返回:[K_IdMicroteachAppraise_vVideoLibAppraise]类型的对象</returns>
public static implicit operator K_IdMicroteachAppraise_vVideoLibAppraise(long value)
{
return new K_IdMicroteachAppraise_vVideoLibAppraise(value);
}
}
 /// <summary>
 /// v视频库定性评议(vVideoLibAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoLibAppraiseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoLibAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 38;
public static string[] AttributeName = new string[] {"IdMicroteachAppraise", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdVideoLib", "VideoLibID", "VideoLibName", "VideoLibTheme", "VideoLibTypeName", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "IdXzCollege", "CollegeID", "CollegeName", "CourseId", "CourseCode", "CourseName", "BrowseCount4Case", "IdAppraiseType", "AppraiseTypeName", "AppraiseTheme", "AppraiseContent", "AppraiseDate", "AppraiseTime", "IsVisual", "IsElite", "ExcellentOne", "ExcellentTwo", "SuggestOne", "SuggestTwo", "MicroteachAppriseScore", "VideoStopTime", "BrowseCount", "UserId", "UserName", "UserNameWithUserId"};

protected long mlngIdMicroteachAppraise;    //评议流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdVideoLib;    //视频库流水号
protected string mstrVideoLibID;    //视频库ID
protected string mstrVideoLibName;    //视频名称
protected string mstrVideoLibTheme;    //视频库主题词
protected string mstrVideoLibTypeName;    //视频库类型名称
protected string mstrVideoLibDate;    //视频资源日期
protected string mstrVideoLibTime;    //视频资源时间
protected string mstrVideoLibDateIn;    //案例入库日期
protected string mstrVideoLibTimeIn;    //案例入库时间
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrAppraiseTheme;    //评议主题
protected string mstrAppraiseContent;    //评议内容
protected string mstrAppraiseDate;    //评议日期
protected string mstrAppraiseTime;    //评议时间
protected bool mbolIsVisual;    //隐藏标志
protected bool mbolIsElite;    //精华标志
protected string mstrExcellentOne;    //优点1
protected string mstrExcellentTwo;    //优点2
protected string mstrSuggestOne;    //建议1
protected string mstrSuggestTwo;    //建议2
protected float? mfltMicroteachAppriseScore;    //打分
protected string mstrVideoStopTime;    //公开课案例视频暂停时间
protected int? mintBrowseCount;    //浏览次数
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrUserNameWithUserId;    //UserNameWithUserId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvVideoLibAppraiseEN()
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
public clsvVideoLibAppraiseEN(long lngIdMicroteachAppraise)
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
if (strAttributeName  ==  convVideoLibAppraise.IdMicroteachAppraise)
{
return mlngIdMicroteachAppraise;
}
else if (strAttributeName  ==  convVideoLibAppraise.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convVideoLibAppraise.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convVideoLibAppraise.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convVideoLibAppraise.IdVideoLib)
{
return mstrIdVideoLib;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibID)
{
return mstrVideoLibID;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibName)
{
return mstrVideoLibName;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibTheme)
{
return mstrVideoLibTheme;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibTypeName)
{
return mstrVideoLibTypeName;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibDate)
{
return mstrVideoLibDate;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibTime)
{
return mstrVideoLibTime;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibDateIn)
{
return mstrVideoLibDateIn;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibTimeIn)
{
return mstrVideoLibTimeIn;
}
else if (strAttributeName  ==  convVideoLibAppraise.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convVideoLibAppraise.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convVideoLibAppraise.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convVideoLibAppraise.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convVideoLibAppraise.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convVideoLibAppraise.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convVideoLibAppraise.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convVideoLibAppraise.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseTheme)
{
return mstrAppraiseTheme;
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseDate)
{
return mstrAppraiseDate;
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseTime)
{
return mstrAppraiseTime;
}
else if (strAttributeName  ==  convVideoLibAppraise.IsVisual)
{
return mbolIsVisual;
}
else if (strAttributeName  ==  convVideoLibAppraise.IsElite)
{
return mbolIsElite;
}
else if (strAttributeName  ==  convVideoLibAppraise.ExcellentOne)
{
return mstrExcellentOne;
}
else if (strAttributeName  ==  convVideoLibAppraise.ExcellentTwo)
{
return mstrExcellentTwo;
}
else if (strAttributeName  ==  convVideoLibAppraise.SuggestOne)
{
return mstrSuggestOne;
}
else if (strAttributeName  ==  convVideoLibAppraise.SuggestTwo)
{
return mstrSuggestTwo;
}
else if (strAttributeName  ==  convVideoLibAppraise.MicroteachAppriseScore)
{
return mfltMicroteachAppriseScore;
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoStopTime)
{
return mstrVideoStopTime;
}
else if (strAttributeName  ==  convVideoLibAppraise.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convVideoLibAppraise.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convVideoLibAppraise.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convVideoLibAppraise.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoLibAppraise.IdMicroteachAppraise)
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.IdMicroteachAppraise);
}
else if (strAttributeName  ==  convVideoLibAppraise.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.FuncModuleId);
}
else if (strAttributeName  ==  convVideoLibAppraise.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.FuncModuleName);
}
else if (strAttributeName  ==  convVideoLibAppraise.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.IdMicroteachCase);
}
else if (strAttributeName  ==  convVideoLibAppraise.IdVideoLib)
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.IdVideoLib);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibID)
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibID);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibName)
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibName);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibTheme)
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibTheme);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibTypeName)
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibTypeName);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibDate)
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibDate);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibTime)
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibTime);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibDateIn)
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibDateIn);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoLibTimeIn)
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibTimeIn);
}
else if (strAttributeName  ==  convVideoLibAppraise.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.IdXzCollege);
}
else if (strAttributeName  ==  convVideoLibAppraise.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CollegeID);
}
else if (strAttributeName  ==  convVideoLibAppraise.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CollegeName);
}
else if (strAttributeName  ==  convVideoLibAppraise.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CourseId);
}
else if (strAttributeName  ==  convVideoLibAppraise.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CourseCode);
}
else if (strAttributeName  ==  convVideoLibAppraise.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CourseName);
}
else if (strAttributeName  ==  convVideoLibAppraise.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.BrowseCount4Case);
}
else if (strAttributeName  ==  convVideoLibAppraise.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.IdAppraiseType);
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseTypeName);
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseTheme)
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseTheme);
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseContent);
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseDate)
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseDate);
}
else if (strAttributeName  ==  convVideoLibAppraise.AppraiseTime)
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseTime);
}
else if (strAttributeName  ==  convVideoLibAppraise.IsVisual)
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.IsVisual);
}
else if (strAttributeName  ==  convVideoLibAppraise.IsElite)
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.IsElite);
}
else if (strAttributeName  ==  convVideoLibAppraise.ExcellentOne)
{
mstrExcellentOne = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.ExcellentOne);
}
else if (strAttributeName  ==  convVideoLibAppraise.ExcellentTwo)
{
mstrExcellentTwo = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.ExcellentTwo);
}
else if (strAttributeName  ==  convVideoLibAppraise.SuggestOne)
{
mstrSuggestOne = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.SuggestOne);
}
else if (strAttributeName  ==  convVideoLibAppraise.SuggestTwo)
{
mstrSuggestTwo = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.SuggestTwo);
}
else if (strAttributeName  ==  convVideoLibAppraise.MicroteachAppriseScore)
{
mfltMicroteachAppriseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.MicroteachAppriseScore);
}
else if (strAttributeName  ==  convVideoLibAppraise.VideoStopTime)
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoStopTime);
}
else if (strAttributeName  ==  convVideoLibAppraise.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.BrowseCount);
}
else if (strAttributeName  ==  convVideoLibAppraise.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.UserId);
}
else if (strAttributeName  ==  convVideoLibAppraise.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.UserName);
}
else if (strAttributeName  ==  convVideoLibAppraise.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.UserNameWithUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoLibAppraise.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
return mlngIdMicroteachAppraise;
}
else if (convVideoLibAppraise.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convVideoLibAppraise.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convVideoLibAppraise.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convVideoLibAppraise.IdVideoLib  ==  AttributeName[intIndex])
{
return mstrIdVideoLib;
}
else if (convVideoLibAppraise.VideoLibID  ==  AttributeName[intIndex])
{
return mstrVideoLibID;
}
else if (convVideoLibAppraise.VideoLibName  ==  AttributeName[intIndex])
{
return mstrVideoLibName;
}
else if (convVideoLibAppraise.VideoLibTheme  ==  AttributeName[intIndex])
{
return mstrVideoLibTheme;
}
else if (convVideoLibAppraise.VideoLibTypeName  ==  AttributeName[intIndex])
{
return mstrVideoLibTypeName;
}
else if (convVideoLibAppraise.VideoLibDate  ==  AttributeName[intIndex])
{
return mstrVideoLibDate;
}
else if (convVideoLibAppraise.VideoLibTime  ==  AttributeName[intIndex])
{
return mstrVideoLibTime;
}
else if (convVideoLibAppraise.VideoLibDateIn  ==  AttributeName[intIndex])
{
return mstrVideoLibDateIn;
}
else if (convVideoLibAppraise.VideoLibTimeIn  ==  AttributeName[intIndex])
{
return mstrVideoLibTimeIn;
}
else if (convVideoLibAppraise.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convVideoLibAppraise.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convVideoLibAppraise.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convVideoLibAppraise.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convVideoLibAppraise.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convVideoLibAppraise.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convVideoLibAppraise.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convVideoLibAppraise.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convVideoLibAppraise.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convVideoLibAppraise.AppraiseTheme  ==  AttributeName[intIndex])
{
return mstrAppraiseTheme;
}
else if (convVideoLibAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (convVideoLibAppraise.AppraiseDate  ==  AttributeName[intIndex])
{
return mstrAppraiseDate;
}
else if (convVideoLibAppraise.AppraiseTime  ==  AttributeName[intIndex])
{
return mstrAppraiseTime;
}
else if (convVideoLibAppraise.IsVisual  ==  AttributeName[intIndex])
{
return mbolIsVisual;
}
else if (convVideoLibAppraise.IsElite  ==  AttributeName[intIndex])
{
return mbolIsElite;
}
else if (convVideoLibAppraise.ExcellentOne  ==  AttributeName[intIndex])
{
return mstrExcellentOne;
}
else if (convVideoLibAppraise.ExcellentTwo  ==  AttributeName[intIndex])
{
return mstrExcellentTwo;
}
else if (convVideoLibAppraise.SuggestOne  ==  AttributeName[intIndex])
{
return mstrSuggestOne;
}
else if (convVideoLibAppraise.SuggestTwo  ==  AttributeName[intIndex])
{
return mstrSuggestTwo;
}
else if (convVideoLibAppraise.MicroteachAppriseScore  ==  AttributeName[intIndex])
{
return mfltMicroteachAppriseScore;
}
else if (convVideoLibAppraise.VideoStopTime  ==  AttributeName[intIndex])
{
return mstrVideoStopTime;
}
else if (convVideoLibAppraise.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convVideoLibAppraise.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convVideoLibAppraise.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convVideoLibAppraise.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
return null;
}
set
{
if (convVideoLibAppraise.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.IdMicroteachAppraise);
}
else if (convVideoLibAppraise.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.FuncModuleId);
}
else if (convVideoLibAppraise.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.FuncModuleName);
}
else if (convVideoLibAppraise.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.IdMicroteachCase);
}
else if (convVideoLibAppraise.IdVideoLib  ==  AttributeName[intIndex])
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.IdVideoLib);
}
else if (convVideoLibAppraise.VideoLibID  ==  AttributeName[intIndex])
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibID);
}
else if (convVideoLibAppraise.VideoLibName  ==  AttributeName[intIndex])
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibName);
}
else if (convVideoLibAppraise.VideoLibTheme  ==  AttributeName[intIndex])
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibTheme);
}
else if (convVideoLibAppraise.VideoLibTypeName  ==  AttributeName[intIndex])
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibTypeName);
}
else if (convVideoLibAppraise.VideoLibDate  ==  AttributeName[intIndex])
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibDate);
}
else if (convVideoLibAppraise.VideoLibTime  ==  AttributeName[intIndex])
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibTime);
}
else if (convVideoLibAppraise.VideoLibDateIn  ==  AttributeName[intIndex])
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibDateIn);
}
else if (convVideoLibAppraise.VideoLibTimeIn  ==  AttributeName[intIndex])
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoLibTimeIn);
}
else if (convVideoLibAppraise.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.IdXzCollege);
}
else if (convVideoLibAppraise.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CollegeID);
}
else if (convVideoLibAppraise.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CollegeName);
}
else if (convVideoLibAppraise.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CourseId);
}
else if (convVideoLibAppraise.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CourseCode);
}
else if (convVideoLibAppraise.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.CourseName);
}
else if (convVideoLibAppraise.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.BrowseCount4Case);
}
else if (convVideoLibAppraise.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.IdAppraiseType);
}
else if (convVideoLibAppraise.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseTypeName);
}
else if (convVideoLibAppraise.AppraiseTheme  ==  AttributeName[intIndex])
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseTheme);
}
else if (convVideoLibAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseContent);
}
else if (convVideoLibAppraise.AppraiseDate  ==  AttributeName[intIndex])
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseDate);
}
else if (convVideoLibAppraise.AppraiseTime  ==  AttributeName[intIndex])
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.AppraiseTime);
}
else if (convVideoLibAppraise.IsVisual  ==  AttributeName[intIndex])
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.IsVisual);
}
else if (convVideoLibAppraise.IsElite  ==  AttributeName[intIndex])
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.IsElite);
}
else if (convVideoLibAppraise.ExcellentOne  ==  AttributeName[intIndex])
{
mstrExcellentOne = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.ExcellentOne);
}
else if (convVideoLibAppraise.ExcellentTwo  ==  AttributeName[intIndex])
{
mstrExcellentTwo = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.ExcellentTwo);
}
else if (convVideoLibAppraise.SuggestOne  ==  AttributeName[intIndex])
{
mstrSuggestOne = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.SuggestOne);
}
else if (convVideoLibAppraise.SuggestTwo  ==  AttributeName[intIndex])
{
mstrSuggestTwo = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.SuggestTwo);
}
else if (convVideoLibAppraise.MicroteachAppriseScore  ==  AttributeName[intIndex])
{
mfltMicroteachAppriseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.MicroteachAppriseScore);
}
else if (convVideoLibAppraise.VideoStopTime  ==  AttributeName[intIndex])
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.VideoStopTime);
}
else if (convVideoLibAppraise.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibAppraise.BrowseCount);
}
else if (convVideoLibAppraise.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.UserId);
}
else if (convVideoLibAppraise.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.UserName);
}
else if (convVideoLibAppraise.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convVideoLibAppraise.UserNameWithUserId);
}
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
 AddUpdatedFld(convVideoLibAppraise.IdMicroteachAppraise);
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
 AddUpdatedFld(convVideoLibAppraise.FuncModuleId);
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
 AddUpdatedFld(convVideoLibAppraise.FuncModuleName);
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
 AddUpdatedFld(convVideoLibAppraise.IdMicroteachCase);
}
}
/// <summary>
/// 视频库流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdVideoLib
{
get
{
return mstrIdVideoLib;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdVideoLib = value;
}
else
{
 mstrIdVideoLib = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.IdVideoLib);
}
}
/// <summary>
/// 视频库ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibID
{
get
{
return mstrVideoLibID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibID = value;
}
else
{
 mstrVideoLibID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.VideoLibID);
}
}
/// <summary>
/// 视频名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibName
{
get
{
return mstrVideoLibName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibName = value;
}
else
{
 mstrVideoLibName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.VideoLibName);
}
}
/// <summary>
/// 视频库主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTheme
{
get
{
return mstrVideoLibTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTheme = value;
}
else
{
 mstrVideoLibTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.VideoLibTheme);
}
}
/// <summary>
/// 视频库类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTypeName
{
get
{
return mstrVideoLibTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTypeName = value;
}
else
{
 mstrVideoLibTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.VideoLibTypeName);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibDate
{
get
{
return mstrVideoLibDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibDate = value;
}
else
{
 mstrVideoLibDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.VideoLibDate);
}
}
/// <summary>
/// 视频资源时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTime
{
get
{
return mstrVideoLibTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTime = value;
}
else
{
 mstrVideoLibTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.VideoLibTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibDateIn
{
get
{
return mstrVideoLibDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibDateIn = value;
}
else
{
 mstrVideoLibDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.VideoLibDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTimeIn
{
get
{
return mstrVideoLibTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTimeIn = value;
}
else
{
 mstrVideoLibTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibAppraise.VideoLibTimeIn);
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
 AddUpdatedFld(convVideoLibAppraise.IdXzCollege);
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
 AddUpdatedFld(convVideoLibAppraise.CollegeID);
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
 AddUpdatedFld(convVideoLibAppraise.CollegeName);
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
 AddUpdatedFld(convVideoLibAppraise.CourseId);
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
 AddUpdatedFld(convVideoLibAppraise.CourseCode);
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
 AddUpdatedFld(convVideoLibAppraise.CourseName);
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
 AddUpdatedFld(convVideoLibAppraise.BrowseCount4Case);
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
 AddUpdatedFld(convVideoLibAppraise.IdAppraiseType);
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
 AddUpdatedFld(convVideoLibAppraise.AppraiseTypeName);
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
 AddUpdatedFld(convVideoLibAppraise.AppraiseTheme);
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
 AddUpdatedFld(convVideoLibAppraise.AppraiseContent);
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
 AddUpdatedFld(convVideoLibAppraise.AppraiseDate);
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
 AddUpdatedFld(convVideoLibAppraise.AppraiseTime);
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
 AddUpdatedFld(convVideoLibAppraise.IsVisual);
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
 AddUpdatedFld(convVideoLibAppraise.IsElite);
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
 AddUpdatedFld(convVideoLibAppraise.ExcellentOne);
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
 AddUpdatedFld(convVideoLibAppraise.ExcellentTwo);
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
 AddUpdatedFld(convVideoLibAppraise.SuggestOne);
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
 AddUpdatedFld(convVideoLibAppraise.SuggestTwo);
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
 AddUpdatedFld(convVideoLibAppraise.MicroteachAppriseScore);
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
 AddUpdatedFld(convVideoLibAppraise.VideoStopTime);
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
 AddUpdatedFld(convVideoLibAppraise.BrowseCount);
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
 AddUpdatedFld(convVideoLibAppraise.UserId);
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
 AddUpdatedFld(convVideoLibAppraise.UserName);
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
 AddUpdatedFld(convVideoLibAppraise.UserNameWithUserId);
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
 /// v视频库定性评议(vVideoLibAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoLibAppraise
{
public const string _CurrTabName = "vVideoLibAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachAppraise", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdVideoLib", "VideoLibID", "VideoLibName", "VideoLibTheme", "VideoLibTypeName", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "IdXzCollege", "CollegeID", "CollegeName", "CourseId", "CourseCode", "CourseName", "BrowseCount4Case", "IdAppraiseType", "AppraiseTypeName", "AppraiseTheme", "AppraiseContent", "AppraiseDate", "AppraiseTime", "IsVisual", "IsElite", "ExcellentOne", "ExcellentTwo", "SuggestOne", "SuggestTwo", "MicroteachAppriseScore", "VideoStopTime", "BrowseCount", "UserId", "UserName", "UserNameWithUserId"};
//以下是属性变量


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
 /// 常量:"IdVideoLib"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoLib = "IdVideoLib";    //视频库流水号

 /// <summary>
 /// 常量:"VideoLibID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibID = "VideoLibID";    //视频库ID

 /// <summary>
 /// 常量:"VideoLibName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibName = "VideoLibName";    //视频名称

 /// <summary>
 /// 常量:"VideoLibTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTheme = "VideoLibTheme";    //视频库主题词

 /// <summary>
 /// 常量:"VideoLibTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTypeName = "VideoLibTypeName";    //视频库类型名称

 /// <summary>
 /// 常量:"VideoLibDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibDate = "VideoLibDate";    //视频资源日期

 /// <summary>
 /// 常量:"VideoLibTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTime = "VideoLibTime";    //视频资源时间

 /// <summary>
 /// 常量:"VideoLibDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibDateIn = "VideoLibDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"VideoLibTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTimeIn = "VideoLibTimeIn";    //案例入库时间

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
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

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
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId
}

}