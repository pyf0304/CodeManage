
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseQuantitySenateEN
 表名:vCourseLearningCaseQuantitySenate(01120455)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:50
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
 /// 表vCourseLearningCaseQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdmicroteachCaseQuantitySenate">表关键字</param>
public K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
if (IsValid(lngIdmicroteachCaseQuantitySenate)) Value = lngIdmicroteachCaseQuantitySenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdmicroteachCaseQuantitySenate)
{
if (lngIdmicroteachCaseQuantitySenate == 0) return false;
if (lngIdmicroteachCaseQuantitySenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenate(value);
}
}
 /// <summary>
 /// v课程学习案例资源量化评议(vCourseLearningCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCourseLearningCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCourseLearningCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 55;
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "CourseLearningCaseTypeName", "OwnerId", "OwnerName", "OwnerNameWithId", "UserNameWithUserId", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "CollegeNameA", "IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UserId", "UserName", "UserKindId", "UserKindName", "UpdUser", "UpdUserName", "Memo", "UserTypeName"};

protected string mstrIdCourseLearningCase;    //课程学习案例流水号
protected string mstrCourseLearningCaseID;    //课程学习案例ID
protected string mstrCourseLearningCaseName;    //课程学习案例名称
protected string mstrCourseLearningCaseTheme;    //课程学习案例主题词
protected string mstrCourseLearningCaseDate;    //课程学习日期
protected string mstrCourseLearningCaseTime;    //课程学习时间
protected string mstrCourseLearningCaseDateIn;    //案例入库日期
protected string mstrCourseLearningCaseTimeIn;    //案例入库时间
protected string mstrCourseLearningCaseTypeName;    //课程学习案例类型名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected int? mintViewCount;    //浏览量
protected bool mbolIsShow;    //是否启用
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrCollegeNameA;    //学院名称简写
protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrSenateTheme;    //量化评价主题
protected string mstrSenateContent;    //评价内容
protected float mfltSenateTotalScore;    //评价分数
protected string mstrSenateDate;    //评价日期
protected string mstrSenateTime;    //评价时间
protected string mstrSenateIp;    //评议Ip
protected int? mintBrowseCount;    //浏览次数
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrUpdUser;    //修改人
protected string mstrUpdUserName;    //UpdUserName
protected string mstrMemo;    //备注
protected string mstrUserTypeName;    //用户类型名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCourseLearningCaseQuantitySenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdmicroteachCaseQuantitySenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdmicroteachCaseQuantitySenate">关键字:微格量化评价流水号</param>
public clsvCourseLearningCaseQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
 {
 if (lngIdmicroteachCaseQuantitySenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdmicroteachCaseQuantitySenate");
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
if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdCourseLearningCase)
{
return mstrIdCourseLearningCase;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseID)
{
return mstrCourseLearningCaseID;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseName)
{
return mstrCourseLearningCaseName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme)
{
return mstrCourseLearningCaseTheme;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseDate)
{
return mstrCourseLearningCaseDate;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseTime)
{
return mstrCourseLearningCaseTime;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn)
{
return mstrCourseLearningCaseDateIn;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn)
{
return mstrCourseLearningCaseTimeIn;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName)
{
return mstrCourseLearningCaseTypeName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserTypeName)
{
return mstrUserTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdCourseLearningCase)
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdCourseLearningCase);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseID)
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseName)
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme)
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseDate)
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseTime)
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn)
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn)
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName)
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerNameWithId);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IsDualVideo);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdXzMajor);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.MajorID);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.MajorName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseId);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseCode);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.ViewCount);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IsShow);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.DownloadNumber);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FileIntegration);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.LikeCount);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollectionCount);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeNameA);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserKindId);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserKindName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UpdUserName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.Memo);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenate.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convCourseLearningCaseQuantitySenate.IdCourseLearningCase  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCase;
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseID  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseID;
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseName;
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTheme;
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDate;
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTime;
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseDateIn;
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTimeIn;
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTypeName;
}
else if (convCourseLearningCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCourseLearningCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCourseLearningCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convCourseLearningCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convCourseLearningCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCourseLearningCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCourseLearningCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convCourseLearningCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCourseLearningCaseQuantitySenate.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCourseLearningCaseQuantitySenate.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convCourseLearningCaseQuantitySenate.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCourseLearningCaseQuantitySenate.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCourseLearningCaseQuantitySenate.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCourseLearningCaseQuantitySenate.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCourseLearningCaseQuantitySenate.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convCourseLearningCaseQuantitySenate.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convCourseLearningCaseQuantitySenate.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convCourseLearningCaseQuantitySenate.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convCourseLearningCaseQuantitySenate.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convCourseLearningCaseQuantitySenate.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convCourseLearningCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convCourseLearningCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCourseLearningCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCourseLearningCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convCourseLearningCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convCourseLearningCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convCourseLearningCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convCourseLearningCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convCourseLearningCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convCourseLearningCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convCourseLearningCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convCourseLearningCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convCourseLearningCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convCourseLearningCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convCourseLearningCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convCourseLearningCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCourseLearningCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convCourseLearningCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convCourseLearningCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convCourseLearningCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCourseLearningCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (convCourseLearningCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCourseLearningCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
return null;
}
set
{
if (convCourseLearningCaseQuantitySenate.IdCourseLearningCase  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdCourseLearningCase);
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseID  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseName);
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTheme = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme);
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseDate  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseTime  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTime = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseDateIn = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTimeIn = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
}
else if (convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName);
}
else if (convCourseLearningCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerId);
}
else if (convCourseLearningCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerName);
}
else if (convCourseLearningCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerNameWithId);
}
else if (convCourseLearningCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserNameWithUserId);
}
else if (convCourseLearningCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IsDualVideo);
}
else if (convCourseLearningCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdXzCollege);
}
else if (convCourseLearningCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeID);
}
else if (convCourseLearningCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeName);
}
else if (convCourseLearningCaseQuantitySenate.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdXzMajor);
}
else if (convCourseLearningCaseQuantitySenate.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.MajorID);
}
else if (convCourseLearningCaseQuantitySenate.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.MajorName);
}
else if (convCourseLearningCaseQuantitySenate.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseId);
}
else if (convCourseLearningCaseQuantitySenate.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseCode);
}
else if (convCourseLearningCaseQuantitySenate.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseName);
}
else if (convCourseLearningCaseQuantitySenate.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.ViewCount);
}
else if (convCourseLearningCaseQuantitySenate.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IsShow);
}
else if (convCourseLearningCaseQuantitySenate.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.DownloadNumber);
}
else if (convCourseLearningCaseQuantitySenate.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FileIntegration);
}
else if (convCourseLearningCaseQuantitySenate.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.LikeCount);
}
else if (convCourseLearningCaseQuantitySenate.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollectionCount);
}
else if (convCourseLearningCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeNameA);
}
else if (convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convCourseLearningCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FuncModuleId);
}
else if (convCourseLearningCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FuncModuleName);
}
else if (convCourseLearningCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdMicroteachCase);
}
else if (convCourseLearningCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdAppraiseType);
}
else if (convCourseLearningCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.AppraiseTypeName);
}
else if (convCourseLearningCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTheme);
}
else if (convCourseLearningCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateContent);
}
else if (convCourseLearningCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTotalScore);
}
else if (convCourseLearningCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateDate);
}
else if (convCourseLearningCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTime);
}
else if (convCourseLearningCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateIp);
}
else if (convCourseLearningCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.BrowseCount);
}
else if (convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (convCourseLearningCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
}
else if (convCourseLearningCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionName);
}
else if (convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convCourseLearningCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserId);
}
else if (convCourseLearningCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserName);
}
else if (convCourseLearningCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserKindId);
}
else if (convCourseLearningCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserKindName);
}
else if (convCourseLearningCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UpdUser);
}
else if (convCourseLearningCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UpdUserName);
}
else if (convCourseLearningCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.Memo);
}
else if (convCourseLearningCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserTypeName);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdCourseLearningCase);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseID);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseName);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTheme);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseDate);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTime);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseDateIn);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTimeIn);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseLearningCaseTypeName);
}
}
/// <summary>
/// 拥有者Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId
{
get
{
return mstrOwnerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId = value;
}
else
{
 mstrOwnerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerId);
}
}
/// <summary>
/// 拥有者姓名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerName
{
get
{
return mstrOwnerName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerName = value;
}
else
{
 mstrOwnerName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerName);
}
}
/// <summary>
/// 拥有者名称附Id(说明:;字段类型:varchar;字段长度:51;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerNameWithId
{
get
{
return mstrOwnerNameWithId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerNameWithId = value;
}
else
{
 mstrOwnerNameWithId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.OwnerNameWithId);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserNameWithUserId);
}
}
/// <summary>
/// 是否双视频(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDualVideo
{
get
{
return mbolIsDualVideo;
}
set
{
 mbolIsDualVideo = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IsDualVideo);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdXzMajor);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.MajorID);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.MajorName);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseId);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseCode);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CourseName);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.ViewCount);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IsShow);
}
}
/// <summary>
/// 下载数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadNumber
{
get
{
return mintDownloadNumber;
}
set
{
 mintDownloadNumber = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.DownloadNumber);
}
}
/// <summary>
/// 文件积分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FileIntegration
{
get
{
return mintFileIntegration;
}
set
{
 mintFileIntegration = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FileIntegration);
}
}
/// <summary>
/// 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? LikeCount
{
get
{
return mlngLikeCount;
}
set
{
 mlngLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.LikeCount);
}
}
/// <summary>
/// 收藏数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CollectionCount
{
get
{
return mlngCollectionCount;
}
set
{
 mlngCollectionCount = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollectionCount);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.CollegeNameA);
}
}
/// <summary>
/// 微格量化评价流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdmicroteachCaseQuantitySenate
{
get
{
return mlngIdmicroteachCaseQuantitySenate;
}
set
{
 mlngIdmicroteachCaseQuantitySenate = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.FuncModuleName);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdMicroteachCase);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.AppraiseTypeName);
}
}
/// <summary>
/// 量化评价主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateTheme
{
get
{
return mstrSenateTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateTheme = value;
}
else
{
 mstrSenateTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTheme);
}
}
/// <summary>
/// 评价内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateContent
{
get
{
return mstrSenateContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateContent = value;
}
else
{
 mstrSenateContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateContent);
}
}
/// <summary>
/// 评价分数(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float SenateTotalScore
{
get
{
return mfltSenateTotalScore;
}
set
{
 mfltSenateTotalScore = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTotalScore);
}
}
/// <summary>
/// 评价日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateDate
{
get
{
return mstrSenateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateDate = value;
}
else
{
 mstrSenateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateDate);
}
}
/// <summary>
/// 评价时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateTime
{
get
{
return mstrSenateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateTime = value;
}
else
{
 mstrSenateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateTime);
}
}
/// <summary>
/// 评议Ip(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateIp
{
get
{
return mstrSenateIp;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateIp = value;
}
else
{
 mstrSenateIp = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.SenateIp);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.BrowseCount);
}
}
/// <summary>
/// 评价量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeVersion
{
get
{
return mstrIdSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeVersion = value;
}
else
{
 mstrIdSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.IdSenateGaugeVersion);
}
}
/// <summary>
/// 评价量表版本ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionID
{
get
{
return mstrsenateGaugeVersionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionID = value;
}
else
{
 mstrsenateGaugeVersionID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionID);
}
}
/// <summary>
/// 评价量表版本名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionName
{
get
{
return mstrsenateGaugeVersionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionName = value;
}
else
{
 mstrsenateGaugeVersionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserName);
}
}
/// <summary>
/// 用户类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindId
{
get
{
return mstrUserKindId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindId = value;
}
else
{
 mstrUserKindId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserKindId);
}
}
/// <summary>
/// 用户类别名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserKindName
{
get
{
return mstrUserKindName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserKindName = value;
}
else
{
 mstrUserKindName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserKindName);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UpdUser);
}
}
/// <summary>
/// UpdUserName(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserName
{
get
{
return mstrUpdUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserName = value;
}
else
{
 mstrUpdUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UpdUserName);
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
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.Memo);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenate.UserTypeName);
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
  return mlngIdmicroteachCaseQuantitySenate.ToString();
 }
 }
}
 /// <summary>
 /// v课程学习案例资源量化评议(vCourseLearningCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCourseLearningCaseQuantitySenate
{
public const string _CurrTabName = "vCourseLearningCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseLearningCaseTheme", "CourseLearningCaseDate", "CourseLearningCaseTime", "CourseLearningCaseDateIn", "CourseLearningCaseTimeIn", "CourseLearningCaseTypeName", "OwnerId", "OwnerName", "OwnerNameWithId", "UserNameWithUserId", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "CollegeNameA", "IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UserId", "UserName", "UserKindId", "UserKindName", "UpdUser", "UpdUserName", "Memo", "UserTypeName"};
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
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

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
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"DownloadNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadNumber = "DownloadNumber";    //下载数目

 /// <summary>
 /// 常量:"FileIntegration"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileIntegration = "FileIntegration";    //文件积分

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"IdmicroteachCaseQuantitySenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdmicroteachCaseQuantitySenate = "IdmicroteachCaseQuantitySenate";    //微格量化评价流水号

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
 /// 常量:"SenateTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateTheme = "SenateTheme";    //量化评价主题

 /// <summary>
 /// 常量:"SenateContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateContent = "SenateContent";    //评价内容

 /// <summary>
 /// 常量:"SenateTotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateTotalScore = "SenateTotalScore";    //评价分数

 /// <summary>
 /// 常量:"SenateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateDate = "SenateDate";    //评价日期

 /// <summary>
 /// 常量:"SenateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateTime = "SenateTime";    //评价时间

 /// <summary>
 /// 常量:"SenateIp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateIp = "SenateIp";    //评议Ip

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"senateGaugeVersionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionID = "senateGaugeVersionID";    //评价量表版本ID

 /// <summary>
 /// 常量:"senateGaugeVersionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionName = "senateGaugeVersionName";    //评价量表版本名称

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

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
 /// 常量:"UserKindId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindId = "UserKindId";    //用户类别Id

 /// <summary>
 /// 常量:"UserKindName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindName = "UserKindName";    //用户类别名

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserName = "UpdUserName";    //UpdUserName

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称
}

}