
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseQuantitySenateEN
 表名:vTeachingCaseResCaseQuantitySenate(01120450)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
 /// 表vTeachingCaseResCaseQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vTeachingCaseResCaseQuantitySenate
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
public K_IdmicroteachCaseQuantitySenate_vTeachingCaseResCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vTeachingCaseResCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vTeachingCaseResCaseQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vTeachingCaseResCaseQuantitySenate(value);
}
}
 /// <summary>
 /// v教学案例资源量化评议(vTeachingCaseResCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeachingCaseResCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeachingCaseResCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 55;
public static string[] AttributeName = new string[] {"UserTypeName", "IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdTeachingCaseResCase", "TeachingCaseResCaseID", "TeachingCaseResCaseName", "TeachingCaseResCaseTheme", "TeachingCaseResCaseDate", "TeachingCaseResCaseTime", "TeachingCaseResCaseDateIn", "TeachingCaseResCaseTimeIn", "TeachingCaseResCaseTypeName", "OwnerId", "OwnerName", "OwnerNameWithId", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "CollegeNameA", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UserId", "UserNameWithUserId", "UserName", "UserKindId", "UserKindName", "UpdUser", "Memo", "UpdUserName"};

protected string mstrUserTypeName;    //用户类型名称
protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdTeachingCaseResCase;    //教学案例资源案例流水号
protected string mstrTeachingCaseResCaseID;    //教学案例资源案例ID
protected string mstrTeachingCaseResCaseName;    //教学案例资源案例名称
protected string mstrTeachingCaseResCaseTheme;    //教学案例资源案例主题词
protected string mstrTeachingCaseResCaseDate;    //视频资源日期
protected string mstrTeachingCaseResCaseTime;    //视频资源时间
protected string mstrTeachingCaseResCaseDateIn;    //案例入库日期
protected string mstrTeachingCaseResCaseTimeIn;    //案例入库时间
protected string mstrTeachingCaseResCaseTypeName;    //教学案例资源案例类型名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
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
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrUserName;    //用户名
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrUpdUserName;    //UpdUserName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTeachingCaseResCaseQuantitySenateEN()
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
public clsvTeachingCaseResCaseQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
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
if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase)
{
return mstrIdTeachingCaseResCase;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID)
{
return mstrTeachingCaseResCaseID;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName)
{
return mstrTeachingCaseResCaseName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme)
{
return mstrTeachingCaseResCaseTheme;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate)
{
return mstrTeachingCaseResCaseDate;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime)
{
return mstrTeachingCaseResCaseTime;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn)
{
return mstrTeachingCaseResCaseDateIn;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn)
{
return mstrTeachingCaseResCaseTimeIn;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName)
{
return mstrTeachingCaseResCaseTypeName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserTypeName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase)
{
mstrIdTeachingCaseResCase = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID)
{
mstrTeachingCaseResCaseID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName)
{
mstrTeachingCaseResCaseName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme)
{
mstrTeachingCaseResCaseTheme = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate)
{
mstrTeachingCaseResCaseDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime)
{
mstrTeachingCaseResCaseTime = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn)
{
mstrTeachingCaseResCaseDateIn = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn)
{
mstrTeachingCaseResCaseTimeIn = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName)
{
mstrTeachingCaseResCaseTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IsDualVideo);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdXzMajor);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.MajorID);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.MajorName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseId);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseCode);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.ViewCount);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IsShow);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.DownloadNumber);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FileIntegration);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.LikeCount);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollectionCount);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeNameA);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserKindId);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserKindName);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.Memo);
}
else if (strAttributeName  ==  convTeachingCaseResCaseQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UpdUserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeachingCaseResCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convTeachingCaseResCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convTeachingCaseResCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convTeachingCaseResCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase  ==  AttributeName[intIndex])
{
return mstrIdTeachingCaseResCase;
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseID;
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseName;
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTheme;
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseDate;
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTime;
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseDateIn;
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTimeIn;
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTypeName;
}
else if (convTeachingCaseResCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convTeachingCaseResCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convTeachingCaseResCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convTeachingCaseResCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convTeachingCaseResCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convTeachingCaseResCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convTeachingCaseResCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convTeachingCaseResCaseQuantitySenate.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convTeachingCaseResCaseQuantitySenate.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convTeachingCaseResCaseQuantitySenate.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convTeachingCaseResCaseQuantitySenate.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convTeachingCaseResCaseQuantitySenate.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convTeachingCaseResCaseQuantitySenate.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convTeachingCaseResCaseQuantitySenate.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convTeachingCaseResCaseQuantitySenate.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convTeachingCaseResCaseQuantitySenate.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convTeachingCaseResCaseQuantitySenate.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convTeachingCaseResCaseQuantitySenate.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convTeachingCaseResCaseQuantitySenate.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convTeachingCaseResCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convTeachingCaseResCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convTeachingCaseResCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convTeachingCaseResCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convTeachingCaseResCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convTeachingCaseResCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convTeachingCaseResCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convTeachingCaseResCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convTeachingCaseResCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convTeachingCaseResCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convTeachingCaseResCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convTeachingCaseResCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convTeachingCaseResCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convTeachingCaseResCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convTeachingCaseResCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convTeachingCaseResCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convTeachingCaseResCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTeachingCaseResCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
return null;
}
set
{
if (convTeachingCaseResCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserTypeName);
}
else if (convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convTeachingCaseResCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FuncModuleId);
}
else if (convTeachingCaseResCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FuncModuleName);
}
else if (convTeachingCaseResCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdMicroteachCase);
}
else if (convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase  ==  AttributeName[intIndex])
{
mstrIdTeachingCaseResCase = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase);
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName);
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTheme = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme);
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTime = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseDateIn = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTimeIn = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
}
else if (convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName);
}
else if (convTeachingCaseResCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerId);
}
else if (convTeachingCaseResCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerName);
}
else if (convTeachingCaseResCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId);
}
else if (convTeachingCaseResCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IsDualVideo);
}
else if (convTeachingCaseResCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdXzCollege);
}
else if (convTeachingCaseResCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeID);
}
else if (convTeachingCaseResCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeName);
}
else if (convTeachingCaseResCaseQuantitySenate.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdXzMajor);
}
else if (convTeachingCaseResCaseQuantitySenate.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.MajorID);
}
else if (convTeachingCaseResCaseQuantitySenate.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.MajorName);
}
else if (convTeachingCaseResCaseQuantitySenate.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseId);
}
else if (convTeachingCaseResCaseQuantitySenate.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseCode);
}
else if (convTeachingCaseResCaseQuantitySenate.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseName);
}
else if (convTeachingCaseResCaseQuantitySenate.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.ViewCount);
}
else if (convTeachingCaseResCaseQuantitySenate.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IsShow);
}
else if (convTeachingCaseResCaseQuantitySenate.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.DownloadNumber);
}
else if (convTeachingCaseResCaseQuantitySenate.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FileIntegration);
}
else if (convTeachingCaseResCaseQuantitySenate.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.LikeCount);
}
else if (convTeachingCaseResCaseQuantitySenate.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollectionCount);
}
else if (convTeachingCaseResCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeNameA);
}
else if (convTeachingCaseResCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdAppraiseType);
}
else if (convTeachingCaseResCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName);
}
else if (convTeachingCaseResCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTheme);
}
else if (convTeachingCaseResCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateContent);
}
else if (convTeachingCaseResCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTotalScore);
}
else if (convTeachingCaseResCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateDate);
}
else if (convTeachingCaseResCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTime);
}
else if (convTeachingCaseResCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateIp);
}
else if (convTeachingCaseResCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.BrowseCount);
}
else if (convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
}
else if (convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName);
}
else if (convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convTeachingCaseResCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserId);
}
else if (convTeachingCaseResCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId);
}
else if (convTeachingCaseResCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserName);
}
else if (convTeachingCaseResCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserKindId);
}
else if (convTeachingCaseResCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserKindName);
}
else if (convTeachingCaseResCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UpdUser);
}
else if (convTeachingCaseResCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.Memo);
}
else if (convTeachingCaseResCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UpdUserName);
}
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserTypeName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FuncModuleName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdMicroteachCase);
}
}
/// <summary>
/// 教学案例资源案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingCaseResCase
{
get
{
return mstrIdTeachingCaseResCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingCaseResCase = value;
}
else
{
 mstrIdTeachingCaseResCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdTeachingCaseResCase);
}
}
/// <summary>
/// 教学案例资源案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseID
{
get
{
return mstrTeachingCaseResCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseID = value;
}
else
{
 mstrTeachingCaseResCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseID);
}
}
/// <summary>
/// 教学案例资源案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseName
{
get
{
return mstrTeachingCaseResCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseName = value;
}
else
{
 mstrTeachingCaseResCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseName);
}
}
/// <summary>
/// 教学案例资源案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTheme
{
get
{
return mstrTeachingCaseResCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTheme = value;
}
else
{
 mstrTeachingCaseResCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTheme);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseDate
{
get
{
return mstrTeachingCaseResCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseDate = value;
}
else
{
 mstrTeachingCaseResCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDate);
}
}
/// <summary>
/// 视频资源时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTime
{
get
{
return mstrTeachingCaseResCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTime = value;
}
else
{
 mstrTeachingCaseResCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseDateIn
{
get
{
return mstrTeachingCaseResCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseDateIn = value;
}
else
{
 mstrTeachingCaseResCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTimeIn
{
get
{
return mstrTeachingCaseResCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTimeIn = value;
}
else
{
 mstrTeachingCaseResCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTimeIn);
}
}
/// <summary>
/// 教学案例资源案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTypeName
{
get
{
return mstrTeachingCaseResCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTypeName = value;
}
else
{
 mstrTeachingCaseResCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.TeachingCaseResCaseTypeName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerId);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.OwnerNameWithId);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IsDualVideo);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdXzMajor);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.MajorID);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.MajorName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseId);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseCode);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CourseName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.ViewCount);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IsShow);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.DownloadNumber);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.FileIntegration);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.LikeCount);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollectionCount);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.CollegeNameA);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.AppraiseTypeName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTheme);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateContent);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTotalScore);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateDate);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateTime);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.SenateIp);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.BrowseCount);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.IdSenateGaugeVersion);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionID);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserNameWithUserId);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserKindId);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UserKindName);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UpdUser);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.Memo);
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
 AddUpdatedFld(convTeachingCaseResCaseQuantitySenate.UpdUserName);
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
 /// v教学案例资源量化评议(vTeachingCaseResCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeachingCaseResCaseQuantitySenate
{
public const string _CurrTabName = "vTeachingCaseResCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserTypeName", "IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdTeachingCaseResCase", "TeachingCaseResCaseID", "TeachingCaseResCaseName", "TeachingCaseResCaseTheme", "TeachingCaseResCaseDate", "TeachingCaseResCaseTime", "TeachingCaseResCaseDateIn", "TeachingCaseResCaseTimeIn", "TeachingCaseResCaseTypeName", "OwnerId", "OwnerName", "OwnerNameWithId", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "IdXzMajor", "MajorID", "MajorName", "CourseId", "CourseCode", "CourseName", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "CollegeNameA", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UserId", "UserNameWithUserId", "UserName", "UserKindId", "UserKindName", "UpdUser", "Memo", "UpdUserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

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
 /// 常量:"IdTeachingCaseResCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingCaseResCase = "IdTeachingCaseResCase";    //教学案例资源案例流水号

 /// <summary>
 /// 常量:"TeachingCaseResCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseID = "TeachingCaseResCaseID";    //教学案例资源案例ID

 /// <summary>
 /// 常量:"TeachingCaseResCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseName = "TeachingCaseResCaseName";    //教学案例资源案例名称

 /// <summary>
 /// 常量:"TeachingCaseResCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTheme = "TeachingCaseResCaseTheme";    //教学案例资源案例主题词

 /// <summary>
 /// 常量:"TeachingCaseResCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseDate = "TeachingCaseResCaseDate";    //视频资源日期

 /// <summary>
 /// 常量:"TeachingCaseResCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTime = "TeachingCaseResCaseTime";    //视频资源时间

 /// <summary>
 /// 常量:"TeachingCaseResCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseDateIn = "TeachingCaseResCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"TeachingCaseResCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTimeIn = "TeachingCaseResCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"TeachingCaseResCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTypeName = "TeachingCaseResCaseTypeName";    //教学案例资源案例类型名称

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
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserName = "UpdUserName";    //UpdUserName
}

}