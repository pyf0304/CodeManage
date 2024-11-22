
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibQuantitySenateEN
 表名:vVideoLibQuantitySenate(01120449)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:40
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
 /// 表vVideoLibQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vVideoLibQuantitySenate
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
public K_IdmicroteachCaseQuantitySenate_vVideoLibQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vVideoLibQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vVideoLibQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vVideoLibQuantitySenate(value);
}
}
 /// <summary>
 /// v视频库量化评议(vVideoLibQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoLibQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoLibQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 51;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdVideoLib", "VideoLibID", "VideoLibName", "VideoLibTheme", "VideoLibTypeName", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "OwnerId", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "ViewCount", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "CourseId", "CourseCode", "CourseName", "OwnerName", "OwnerNameWithId", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UserId", "UserNameWithUserId", "UserName", "UserKindId", "UserKindName", "UserTypeId", "UserTypeName", "UpdUser", "Memo", "UpdUserName"};

protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
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
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected int? mintViewCount;    //浏览量
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
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
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrUpdUserName;    //UpdUserName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvVideoLibQuantitySenateEN()
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
public clsvVideoLibQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
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
if (strAttributeName  ==  convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdVideoLib)
{
return mstrIdVideoLib;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibID)
{
return mstrVideoLibID;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibName)
{
return mstrVideoLibName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibTheme)
{
return mstrVideoLibTheme;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibTypeName)
{
return mstrVideoLibTypeName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibDate)
{
return mstrVideoLibDate;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibTime)
{
return mstrVideoLibTime;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibDateIn)
{
return mstrVideoLibDateIn;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibTimeIn)
{
return mstrVideoLibTimeIn;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdVideoLib)
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdVideoLib);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibID)
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibID);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibName)
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibTheme)
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTheme);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibTypeName)
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTypeName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibDate)
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibDate);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibTime)
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTime);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibDateIn)
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibDateIn);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.VideoLibTimeIn)
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTimeIn);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeNameA);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.ViewCount);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.DownloadNumber);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.FileIntegration);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.LikeCount);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.CollectionCount);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CourseId);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CourseCode);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CourseName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerNameWithId);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserId);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserKindId);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserKindName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserTypeId);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserTypeName);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.Memo);
}
else if (strAttributeName  ==  convVideoLibQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UpdUserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convVideoLibQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convVideoLibQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convVideoLibQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convVideoLibQuantitySenate.IdVideoLib  ==  AttributeName[intIndex])
{
return mstrIdVideoLib;
}
else if (convVideoLibQuantitySenate.VideoLibID  ==  AttributeName[intIndex])
{
return mstrVideoLibID;
}
else if (convVideoLibQuantitySenate.VideoLibName  ==  AttributeName[intIndex])
{
return mstrVideoLibName;
}
else if (convVideoLibQuantitySenate.VideoLibTheme  ==  AttributeName[intIndex])
{
return mstrVideoLibTheme;
}
else if (convVideoLibQuantitySenate.VideoLibTypeName  ==  AttributeName[intIndex])
{
return mstrVideoLibTypeName;
}
else if (convVideoLibQuantitySenate.VideoLibDate  ==  AttributeName[intIndex])
{
return mstrVideoLibDate;
}
else if (convVideoLibQuantitySenate.VideoLibTime  ==  AttributeName[intIndex])
{
return mstrVideoLibTime;
}
else if (convVideoLibQuantitySenate.VideoLibDateIn  ==  AttributeName[intIndex])
{
return mstrVideoLibDateIn;
}
else if (convVideoLibQuantitySenate.VideoLibTimeIn  ==  AttributeName[intIndex])
{
return mstrVideoLibTimeIn;
}
else if (convVideoLibQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convVideoLibQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convVideoLibQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convVideoLibQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convVideoLibQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convVideoLibQuantitySenate.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convVideoLibQuantitySenate.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convVideoLibQuantitySenate.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convVideoLibQuantitySenate.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convVideoLibQuantitySenate.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convVideoLibQuantitySenate.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convVideoLibQuantitySenate.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convVideoLibQuantitySenate.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convVideoLibQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convVideoLibQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convVideoLibQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convVideoLibQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convVideoLibQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convVideoLibQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convVideoLibQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convVideoLibQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convVideoLibQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convVideoLibQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convVideoLibQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convVideoLibQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convVideoLibQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convVideoLibQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convVideoLibQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convVideoLibQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convVideoLibQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convVideoLibQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convVideoLibQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convVideoLibQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convVideoLibQuantitySenate.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convVideoLibQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convVideoLibQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convVideoLibQuantitySenate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convVideoLibQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
return null;
}
set
{
if (convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convVideoLibQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.FuncModuleId);
}
else if (convVideoLibQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.FuncModuleName);
}
else if (convVideoLibQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdMicroteachCase);
}
else if (convVideoLibQuantitySenate.IdVideoLib  ==  AttributeName[intIndex])
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdVideoLib);
}
else if (convVideoLibQuantitySenate.VideoLibID  ==  AttributeName[intIndex])
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibID);
}
else if (convVideoLibQuantitySenate.VideoLibName  ==  AttributeName[intIndex])
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibName);
}
else if (convVideoLibQuantitySenate.VideoLibTheme  ==  AttributeName[intIndex])
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTheme);
}
else if (convVideoLibQuantitySenate.VideoLibTypeName  ==  AttributeName[intIndex])
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTypeName);
}
else if (convVideoLibQuantitySenate.VideoLibDate  ==  AttributeName[intIndex])
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibDate);
}
else if (convVideoLibQuantitySenate.VideoLibTime  ==  AttributeName[intIndex])
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTime);
}
else if (convVideoLibQuantitySenate.VideoLibDateIn  ==  AttributeName[intIndex])
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibDateIn);
}
else if (convVideoLibQuantitySenate.VideoLibTimeIn  ==  AttributeName[intIndex])
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTimeIn);
}
else if (convVideoLibQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerId);
}
else if (convVideoLibQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdXzCollege);
}
else if (convVideoLibQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeID);
}
else if (convVideoLibQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeName);
}
else if (convVideoLibQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeNameA);
}
else if (convVideoLibQuantitySenate.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.ViewCount);
}
else if (convVideoLibQuantitySenate.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.DownloadNumber);
}
else if (convVideoLibQuantitySenate.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.FileIntegration);
}
else if (convVideoLibQuantitySenate.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.LikeCount);
}
else if (convVideoLibQuantitySenate.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.CollectionCount);
}
else if (convVideoLibQuantitySenate.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CourseId);
}
else if (convVideoLibQuantitySenate.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CourseCode);
}
else if (convVideoLibQuantitySenate.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.CourseName);
}
else if (convVideoLibQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerName);
}
else if (convVideoLibQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerNameWithId);
}
else if (convVideoLibQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdAppraiseType);
}
else if (convVideoLibQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.AppraiseTypeName);
}
else if (convVideoLibQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTheme);
}
else if (convVideoLibQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateContent);
}
else if (convVideoLibQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTotalScore);
}
else if (convVideoLibQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateDate);
}
else if (convVideoLibQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTime);
}
else if (convVideoLibQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.SenateIp);
}
else if (convVideoLibQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.BrowseCount);
}
else if (convVideoLibQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.IdSenateGaugeVersion);
}
else if (convVideoLibQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionID);
}
else if (convVideoLibQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionName);
}
else if (convVideoLibQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convVideoLibQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserId);
}
else if (convVideoLibQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserNameWithUserId);
}
else if (convVideoLibQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserName);
}
else if (convVideoLibQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserKindId);
}
else if (convVideoLibQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserKindName);
}
else if (convVideoLibQuantitySenate.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserTypeId);
}
else if (convVideoLibQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UserTypeName);
}
else if (convVideoLibQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UpdUser);
}
else if (convVideoLibQuantitySenate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.Memo);
}
else if (convVideoLibQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convVideoLibQuantitySenate.UpdUserName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.IdmicroteachCaseQuantitySenate);
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
 AddUpdatedFld(convVideoLibQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convVideoLibQuantitySenate.FuncModuleName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.IdMicroteachCase);
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
 AddUpdatedFld(convVideoLibQuantitySenate.IdVideoLib);
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
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibID);
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
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTheme);
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
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTypeName);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:char;字段长度:8;是否可空:True)
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
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibDate);
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
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTime);
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
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibDateIn);
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
 AddUpdatedFld(convVideoLibQuantitySenate.VideoLibTimeIn);
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
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerId);
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
 AddUpdatedFld(convVideoLibQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeID);
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
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.CollegeNameA);
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
 AddUpdatedFld(convVideoLibQuantitySenate.ViewCount);
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
 AddUpdatedFld(convVideoLibQuantitySenate.DownloadNumber);
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
 AddUpdatedFld(convVideoLibQuantitySenate.FileIntegration);
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
 AddUpdatedFld(convVideoLibQuantitySenate.LikeCount);
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
 AddUpdatedFld(convVideoLibQuantitySenate.CollectionCount);
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
 AddUpdatedFld(convVideoLibQuantitySenate.CourseId);
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
 AddUpdatedFld(convVideoLibQuantitySenate.CourseCode);
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
 AddUpdatedFld(convVideoLibQuantitySenate.CourseName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.OwnerNameWithId);
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
 AddUpdatedFld(convVideoLibQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convVideoLibQuantitySenate.AppraiseTypeName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTheme);
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
 AddUpdatedFld(convVideoLibQuantitySenate.SenateContent);
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
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTotalScore);
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
 AddUpdatedFld(convVideoLibQuantitySenate.SenateDate);
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
 AddUpdatedFld(convVideoLibQuantitySenate.SenateTime);
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
 AddUpdatedFld(convVideoLibQuantitySenate.SenateIp);
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
 AddUpdatedFld(convVideoLibQuantitySenate.BrowseCount);
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
 AddUpdatedFld(convVideoLibQuantitySenate.IdSenateGaugeVersion);
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
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionID);
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
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convVideoLibQuantitySenate.UserId);
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
 AddUpdatedFld(convVideoLibQuantitySenate.UserNameWithUserId);
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
 AddUpdatedFld(convVideoLibQuantitySenate.UserName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.UserKindId);
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
 AddUpdatedFld(convVideoLibQuantitySenate.UserKindName);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibQuantitySenate.UserTypeId);
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
 AddUpdatedFld(convVideoLibQuantitySenate.UserTypeName);
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
 AddUpdatedFld(convVideoLibQuantitySenate.UpdUser);
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
 AddUpdatedFld(convVideoLibQuantitySenate.Memo);
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
 AddUpdatedFld(convVideoLibQuantitySenate.UpdUserName);
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
 /// v视频库量化评议(vVideoLibQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoLibQuantitySenate
{
public const string _CurrTabName = "vVideoLibQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdVideoLib", "VideoLibID", "VideoLibName", "VideoLibTheme", "VideoLibTypeName", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "OwnerId", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "ViewCount", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "CourseId", "CourseCode", "CourseName", "OwnerName", "OwnerNameWithId", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UserId", "UserNameWithUserId", "UserName", "UserKindId", "UserKindName", "UserTypeId", "UserTypeName", "UpdUser", "Memo", "UpdUserName"};
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
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

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
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

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