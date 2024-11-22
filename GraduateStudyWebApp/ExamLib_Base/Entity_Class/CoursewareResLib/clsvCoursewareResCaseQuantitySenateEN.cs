
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseQuantitySenateEN
 表名:vCoursewareResCaseQuantitySenate(01120453)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库(CoursewareResLib)
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
 /// 表vCoursewareResCaseQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vCoursewareResCaseQuantitySenate
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
public K_IdmicroteachCaseQuantitySenate_vCoursewareResCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vCoursewareResCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vCoursewareResCaseQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vCoursewareResCaseQuantitySenate(value);
}
}
 /// <summary>
 /// v课件资源量化评议(vCoursewareResCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCoursewareResCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCoursewareResCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 56;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdCoursewareResCase", "IdMicroteachCase", "CoursewareResCaseID", "CoursewareResCaseName", "CoursewareResCaseTheme", "CoursewareResCaseDate", "CoursewareResCaseTime", "CoursewareResCaseDateIn", "CoursewareResCaseTimeIn", "IdCoursewareResCaseType", "CoursewareResCaseTypeName", "UserId", "MajorID", "MajorName", "IdAppraiseType", "AppraiseTypeName", "CollegeID", "CollegeName", "CourseId", "CourseCode", "CourseName", "BrowseCount", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UpdUserName", "SenateIp", "UserTypeName", "UserName", "UserNameWithUserId", "IsDualVideo", "UserKindId", "UserKindName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "UpdUser", "Memo", "OwnerId", "OwnerName", "OwnerNameWithId", "IdXzCollege", "IdXzMajor", "CollegeNameA"};

protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdCoursewareResCase;    //课件资源案例流水号
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrCoursewareResCaseID;    //课件资源案例ID
protected string mstrCoursewareResCaseName;    //课件资源案例名称
protected string mstrCoursewareResCaseTheme;    //课件资源案例主题词
protected string mstrCoursewareResCaseDate;    //视频资源日期
protected string mstrCoursewareResCaseTime;    //视频资源时间
protected string mstrCoursewareResCaseDateIn;    //案例入库日期
protected string mstrCoursewareResCaseTimeIn;    //案例入库时间
protected string mstrIdCoursewareResCaseType;    //课件资源类型流水号
protected string mstrCoursewareResCaseTypeName;    //课件资源案例类型名称
protected string mstrUserId;    //用户ID
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected int? mintBrowseCount;    //浏览次数
protected string mstrSenateTheme;    //量化评价主题
protected string mstrSenateContent;    //评价内容
protected float mfltSenateTotalScore;    //评价分数
protected string mstrSenateDate;    //评价日期
protected string mstrSenateTime;    //评价时间
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrUpdUserName;    //UpdUserName
protected string mstrSenateIp;    //评议Ip
protected string mstrUserTypeName;    //用户类型名称
protected string mstrUserName;    //用户名
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected int? mintViewCount;    //浏览量
protected bool mbolIsShow;    //是否启用
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCoursewareResCaseQuantitySenateEN()
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
public clsvCoursewareResCaseQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
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
if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdCoursewareResCase)
{
return mstrIdCoursewareResCase;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseID)
{
return mstrCoursewareResCaseID;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseName)
{
return mstrCoursewareResCaseName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme)
{
return mstrCoursewareResCaseTheme;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseDate)
{
return mstrCoursewareResCaseDate;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseTime)
{
return mstrCoursewareResCaseTime;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn)
{
return mstrCoursewareResCaseDateIn;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn)
{
return mstrCoursewareResCaseTimeIn;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType)
{
return mstrIdCoursewareResCaseType;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName)
{
return mstrCoursewareResCaseTypeName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdCoursewareResCase)
{
mstrIdCoursewareResCase = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdCoursewareResCase);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseID)
{
mstrCoursewareResCaseID = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseID);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseName)
{
mstrCoursewareResCaseName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme)
{
mstrCoursewareResCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseDate)
{
mstrCoursewareResCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseDate);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseTime)
{
mstrCoursewareResCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTime);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn)
{
mstrCoursewareResCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn)
{
mstrCoursewareResCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType)
{
mstrIdCoursewareResCaseType = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName)
{
mstrCoursewareResCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.MajorID);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.MajorName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseId);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseCode);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UpdUserName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserTypeName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IsDualVideo);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserKindId);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserKindName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.ViewCount);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IsShow);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.DownloadNumber);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FileIntegration);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.LikeCount);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollectionCount);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.Memo);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerNameWithId);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdXzMajor);
}
else if (strAttributeName  ==  convCoursewareResCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convCoursewareResCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCoursewareResCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCoursewareResCaseQuantitySenate.IdCoursewareResCase  ==  AttributeName[intIndex])
{
return mstrIdCoursewareResCase;
}
else if (convCoursewareResCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseID  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseID;
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseName  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseName;
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTheme;
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseDate  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseDate;
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseTime  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTime;
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseDateIn;
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTimeIn;
}
else if (convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareResCaseType;
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTypeName;
}
else if (convCoursewareResCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCoursewareResCaseQuantitySenate.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convCoursewareResCaseQuantitySenate.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convCoursewareResCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convCoursewareResCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convCoursewareResCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convCoursewareResCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCoursewareResCaseQuantitySenate.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCoursewareResCaseQuantitySenate.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCoursewareResCaseQuantitySenate.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCoursewareResCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCoursewareResCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convCoursewareResCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convCoursewareResCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convCoursewareResCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convCoursewareResCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convCoursewareResCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convCoursewareResCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convCoursewareResCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (convCoursewareResCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convCoursewareResCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convCoursewareResCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convCoursewareResCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convCoursewareResCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCoursewareResCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convCoursewareResCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convCoursewareResCaseQuantitySenate.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convCoursewareResCaseQuantitySenate.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convCoursewareResCaseQuantitySenate.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convCoursewareResCaseQuantitySenate.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convCoursewareResCaseQuantitySenate.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convCoursewareResCaseQuantitySenate.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convCoursewareResCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCoursewareResCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCoursewareResCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCoursewareResCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCoursewareResCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convCoursewareResCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCoursewareResCaseQuantitySenate.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCoursewareResCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convCoursewareResCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FuncModuleId);
}
else if (convCoursewareResCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FuncModuleName);
}
else if (convCoursewareResCaseQuantitySenate.IdCoursewareResCase  ==  AttributeName[intIndex])
{
mstrIdCoursewareResCase = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdCoursewareResCase);
}
else if (convCoursewareResCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdMicroteachCase);
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseID  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseID = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseID);
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseName  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseName);
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme);
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseDate  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseDate);
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseTime  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTime);
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn);
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn);
}
else if (convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareResCaseType = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType);
}
else if (convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName);
}
else if (convCoursewareResCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserId);
}
else if (convCoursewareResCaseQuantitySenate.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.MajorID);
}
else if (convCoursewareResCaseQuantitySenate.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.MajorName);
}
else if (convCoursewareResCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdAppraiseType);
}
else if (convCoursewareResCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.AppraiseTypeName);
}
else if (convCoursewareResCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeID);
}
else if (convCoursewareResCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeName);
}
else if (convCoursewareResCaseQuantitySenate.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseId);
}
else if (convCoursewareResCaseQuantitySenate.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseCode);
}
else if (convCoursewareResCaseQuantitySenate.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseName);
}
else if (convCoursewareResCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.BrowseCount);
}
else if (convCoursewareResCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTheme);
}
else if (convCoursewareResCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateContent);
}
else if (convCoursewareResCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTotalScore);
}
else if (convCoursewareResCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateDate);
}
else if (convCoursewareResCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTime);
}
else if (convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (convCoursewareResCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionID);
}
else if (convCoursewareResCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionName);
}
else if (convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convCoursewareResCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UpdUserName);
}
else if (convCoursewareResCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateIp);
}
else if (convCoursewareResCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserTypeName);
}
else if (convCoursewareResCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserName);
}
else if (convCoursewareResCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserNameWithUserId);
}
else if (convCoursewareResCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IsDualVideo);
}
else if (convCoursewareResCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserKindId);
}
else if (convCoursewareResCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserKindName);
}
else if (convCoursewareResCaseQuantitySenate.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.ViewCount);
}
else if (convCoursewareResCaseQuantitySenate.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IsShow);
}
else if (convCoursewareResCaseQuantitySenate.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.DownloadNumber);
}
else if (convCoursewareResCaseQuantitySenate.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FileIntegration);
}
else if (convCoursewareResCaseQuantitySenate.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.LikeCount);
}
else if (convCoursewareResCaseQuantitySenate.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollectionCount);
}
else if (convCoursewareResCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UpdUser);
}
else if (convCoursewareResCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.Memo);
}
else if (convCoursewareResCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerId);
}
else if (convCoursewareResCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerName);
}
else if (convCoursewareResCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerNameWithId);
}
else if (convCoursewareResCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdXzCollege);
}
else if (convCoursewareResCaseQuantitySenate.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdXzMajor);
}
else if (convCoursewareResCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeNameA);
}
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FuncModuleName);
}
}
/// <summary>
/// 课件资源案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareResCase
{
get
{
return mstrIdCoursewareResCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareResCase = value;
}
else
{
 mstrIdCoursewareResCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdCoursewareResCase);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdMicroteachCase);
}
}
/// <summary>
/// 课件资源案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseID
{
get
{
return mstrCoursewareResCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseID = value;
}
else
{
 mstrCoursewareResCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseID);
}
}
/// <summary>
/// 课件资源案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseName
{
get
{
return mstrCoursewareResCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseName = value;
}
else
{
 mstrCoursewareResCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseName);
}
}
/// <summary>
/// 课件资源案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTheme
{
get
{
return mstrCoursewareResCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTheme = value;
}
else
{
 mstrCoursewareResCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseDate
{
get
{
return mstrCoursewareResCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseDate = value;
}
else
{
 mstrCoursewareResCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseDate);
}
}
/// <summary>
/// 视频资源时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTime
{
get
{
return mstrCoursewareResCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTime = value;
}
else
{
 mstrCoursewareResCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseDateIn
{
get
{
return mstrCoursewareResCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseDateIn = value;
}
else
{
 mstrCoursewareResCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTimeIn
{
get
{
return mstrCoursewareResCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTimeIn = value;
}
else
{
 mstrCoursewareResCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn);
}
}
/// <summary>
/// 课件资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareResCaseType
{
get
{
return mstrIdCoursewareResCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareResCaseType = value;
}
else
{
 mstrIdCoursewareResCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType);
}
}
/// <summary>
/// 课件资源案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTypeName
{
get
{
return mstrCoursewareResCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTypeName = value;
}
else
{
 mstrCoursewareResCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.MajorID);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.MajorName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.AppraiseTypeName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseId);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseCode);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CourseName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.BrowseCount);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTheme);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateContent);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTotalScore);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateDate);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateTime);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionID);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UpdUserName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.SenateIp);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserTypeName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserNameWithUserId);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IsDualVideo);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserKindId);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UserKindName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.ViewCount);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IsShow);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.DownloadNumber);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.FileIntegration);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.LikeCount);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollectionCount);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.UpdUser);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.Memo);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerId);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerName);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.OwnerNameWithId);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.IdXzMajor);
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
 AddUpdatedFld(convCoursewareResCaseQuantitySenate.CollegeNameA);
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
 /// v课件资源量化评议(vCoursewareResCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCoursewareResCaseQuantitySenate
{
public const string _CurrTabName = "vCoursewareResCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdCoursewareResCase", "IdMicroteachCase", "CoursewareResCaseID", "CoursewareResCaseName", "CoursewareResCaseTheme", "CoursewareResCaseDate", "CoursewareResCaseTime", "CoursewareResCaseDateIn", "CoursewareResCaseTimeIn", "IdCoursewareResCaseType", "CoursewareResCaseTypeName", "UserId", "MajorID", "MajorName", "IdAppraiseType", "AppraiseTypeName", "CollegeID", "CollegeName", "CourseId", "CourseCode", "CourseName", "BrowseCount", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UpdUserName", "SenateIp", "UserTypeName", "UserName", "UserNameWithUserId", "IsDualVideo", "UserKindId", "UserKindName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "UpdUser", "Memo", "OwnerId", "OwnerName", "OwnerNameWithId", "IdXzCollege", "IdXzMajor", "CollegeNameA"};
//以下是属性变量


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
 /// 常量:"IdCoursewareResCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareResCase = "IdCoursewareResCase";    //课件资源案例流水号

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"CoursewareResCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseID = "CoursewareResCaseID";    //课件资源案例ID

 /// <summary>
 /// 常量:"CoursewareResCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseName = "CoursewareResCaseName";    //课件资源案例名称

 /// <summary>
 /// 常量:"CoursewareResCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTheme = "CoursewareResCaseTheme";    //课件资源案例主题词

 /// <summary>
 /// 常量:"CoursewareResCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseDate = "CoursewareResCaseDate";    //视频资源日期

 /// <summary>
 /// 常量:"CoursewareResCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTime = "CoursewareResCaseTime";    //视频资源时间

 /// <summary>
 /// 常量:"CoursewareResCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseDateIn = "CoursewareResCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CoursewareResCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTimeIn = "CoursewareResCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdCoursewareResCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareResCaseType = "IdCoursewareResCaseType";    //课件资源类型流水号

 /// <summary>
 /// 常量:"CoursewareResCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTypeName = "CoursewareResCaseTypeName";    //课件资源案例类型名称

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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
 /// 常量:"UpdUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserName = "UpdUserName";    //UpdUserName

 /// <summary>
 /// 常量:"SenateIp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateIp = "SenateIp";    //评议Ip

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

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

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}