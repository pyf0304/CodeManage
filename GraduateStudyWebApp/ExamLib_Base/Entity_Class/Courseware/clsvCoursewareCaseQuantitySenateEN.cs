
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCaseQuantitySenateEN
 表名:vCoursewareCaseQuantitySenate(01120454)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// 表vCoursewareCaseQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vCoursewareCaseQuantitySenate
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
public K_IdmicroteachCaseQuantitySenate_vCoursewareCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vCoursewareCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vCoursewareCaseQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vCoursewareCaseQuantitySenate(value);
}
}
 /// <summary>
 /// v课件量化评议(vCoursewareCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCoursewareCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCoursewareCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 44;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "UserId", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "CollegeID", "CollegeName", "BrowseCount", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "UpdUser", "UpdUserName", "FuncModuleName", "FuncModuleId", "UserTypeId", "SenateIp", "UserTypeName", "UserName", "OwnerId", "OwnerName", "UserNameWithUserId", "IsDualVideo", "CoursewareCaseDate", "CoursewareCaseDateIn", "CoursewareCaseID", "CoursewareCaseName", "CoursewareCaseTheme", "CoursewareCaseTime", "CoursewareCaseTimeIn", "IdCoursewareCase", "IdCoursewareCaseType", "CoursewareCaseTypeName", "UserKindId", "UserKindName", "Memo", "OwnerNameWithId", "IdXzCollege", "CollegeNameA"};

protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrUserId;    //用户ID
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected int? mintBrowseCount;    //浏览次数
protected string mstrSenateTheme;    //量化评价主题
protected string mstrSenateContent;    //评价内容
protected float mfltSenateTotalScore;    //评价分数
protected string mstrSenateDate;    //评价日期
protected string mstrSenateTime;    //评价时间
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected string mstrUpdUser;    //修改人
protected string mstrUpdUserName;    //UpdUserName
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrUserTypeId;    //用户类型Id
protected string mstrSenateIp;    //评议Ip
protected string mstrUserTypeName;    //用户类型名称
protected string mstrUserName;    //用户名
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrCoursewareCaseDate;    //课件教学日期
protected string mstrCoursewareCaseDateIn;    //案例入库日期
protected string mstrCoursewareCaseID;    //课件教学案例ID
protected string mstrCoursewareCaseName;    //课件教学案例名称
protected string mstrCoursewareCaseTheme;    //课件教学案例主题词
protected string mstrCoursewareCaseTime;    //课件教学时间
protected string mstrCoursewareCaseTimeIn;    //案例入库时间
protected string mstrIdCoursewareCase;    //课件教学案例流水号
protected string mstrIdCoursewareCaseType;    //课件案例类型流水号
protected string mstrCoursewareCaseTypeName;    //课件案例类型名称
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserKindName;    //用户类别名
protected string mstrMemo;    //备注
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCoursewareCaseQuantitySenateEN()
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
public clsvCoursewareCaseQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
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
if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseDate)
{
return mstrCoursewareCaseDate;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseDateIn)
{
return mstrCoursewareCaseDateIn;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseID)
{
return mstrCoursewareCaseID;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseName)
{
return mstrCoursewareCaseName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseTheme)
{
return mstrCoursewareCaseTheme;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseTime)
{
return mstrCoursewareCaseTime;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn)
{
return mstrCoursewareCaseTimeIn;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdCoursewareCase)
{
return mstrIdCoursewareCase;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdCoursewareCaseType)
{
return mstrIdCoursewareCaseType;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseTypeName)
{
return mstrCoursewareCaseTypeName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCaseQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UpdUserName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserTypeId);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserTypeName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IsDualVideo);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseDate)
{
mstrCoursewareCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseDate);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseDateIn)
{
mstrCoursewareCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseDateIn);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseID)
{
mstrCoursewareCaseID = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseID);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseName)
{
mstrCoursewareCaseName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseTheme)
{
mstrCoursewareCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTheme);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseTime)
{
mstrCoursewareCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTime);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn)
{
mstrCoursewareCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdCoursewareCase)
{
mstrIdCoursewareCase = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdCoursewareCase);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdCoursewareCaseType)
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdCoursewareCaseType);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CoursewareCaseTypeName)
{
mstrCoursewareCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTypeName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserKindId);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserKindName);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.Memo);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerNameWithId);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convCoursewareCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convCoursewareCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCoursewareCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convCoursewareCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convCoursewareCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convCoursewareCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convCoursewareCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCoursewareCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCoursewareCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convCoursewareCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convCoursewareCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convCoursewareCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convCoursewareCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convCoursewareCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convCoursewareCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convCoursewareCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCoursewareCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCoursewareCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (convCoursewareCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCoursewareCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCoursewareCaseQuantitySenate.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convCoursewareCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convCoursewareCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convCoursewareCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convCoursewareCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCoursewareCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCoursewareCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convCoursewareCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseDate  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseDate;
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseDateIn  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseDateIn;
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseID  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseID;
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseName;
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseTheme  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTheme;
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseTime  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTime;
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTimeIn;
}
else if (convCoursewareCaseQuantitySenate.IdCoursewareCase  ==  AttributeName[intIndex])
{
return mstrIdCoursewareCase;
}
else if (convCoursewareCaseQuantitySenate.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareCaseType;
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTypeName;
}
else if (convCoursewareCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convCoursewareCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convCoursewareCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCoursewareCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convCoursewareCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convCoursewareCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convCoursewareCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserId);
}
else if (convCoursewareCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdMicroteachCase);
}
else if (convCoursewareCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdAppraiseType);
}
else if (convCoursewareCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.AppraiseTypeName);
}
else if (convCoursewareCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeID);
}
else if (convCoursewareCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeName);
}
else if (convCoursewareCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCoursewareCaseQuantitySenate.BrowseCount);
}
else if (convCoursewareCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTheme);
}
else if (convCoursewareCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateContent);
}
else if (convCoursewareCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTotalScore);
}
else if (convCoursewareCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateDate);
}
else if (convCoursewareCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTime);
}
else if (convCoursewareCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (convCoursewareCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.senateGaugeVersionID);
}
else if (convCoursewareCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.senateGaugeVersionName);
}
else if (convCoursewareCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UpdUser);
}
else if (convCoursewareCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UpdUserName);
}
else if (convCoursewareCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.FuncModuleName);
}
else if (convCoursewareCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.FuncModuleId);
}
else if (convCoursewareCaseQuantitySenate.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserTypeId);
}
else if (convCoursewareCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateIp);
}
else if (convCoursewareCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserTypeName);
}
else if (convCoursewareCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserName);
}
else if (convCoursewareCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerId);
}
else if (convCoursewareCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerName);
}
else if (convCoursewareCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserNameWithUserId);
}
else if (convCoursewareCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IsDualVideo);
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseDate  ==  AttributeName[intIndex])
{
mstrCoursewareCaseDate = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseDate);
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseDateIn  ==  AttributeName[intIndex])
{
mstrCoursewareCaseDateIn = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseDateIn);
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseID  ==  AttributeName[intIndex])
{
mstrCoursewareCaseID = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseID);
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseName);
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseTheme  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTheme = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTheme);
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseTime  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTime = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTime);
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTimeIn = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn);
}
else if (convCoursewareCaseQuantitySenate.IdCoursewareCase  ==  AttributeName[intIndex])
{
mstrIdCoursewareCase = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdCoursewareCase);
}
else if (convCoursewareCaseQuantitySenate.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdCoursewareCaseType);
}
else if (convCoursewareCaseQuantitySenate.CoursewareCaseTypeName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTypeName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTypeName);
}
else if (convCoursewareCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserKindId);
}
else if (convCoursewareCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserKindName);
}
else if (convCoursewareCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.Memo);
}
else if (convCoursewareCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerNameWithId);
}
else if (convCoursewareCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdXzCollege);
}
else if (convCoursewareCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeNameA);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdMicroteachCase);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.AppraiseTypeName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.BrowseCount);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTheme);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateContent);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTotalScore);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateDate);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateTime);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdSenateGaugeVersion);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.senateGaugeVersionID);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.senateGaugeVersionName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UpdUser);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UpdUserName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.FuncModuleName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserTypeId);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.SenateIp);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserTypeName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerId);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserNameWithUserId);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IsDualVideo);
}
}
/// <summary>
/// 课件教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseDate
{
get
{
return mstrCoursewareCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseDate = value;
}
else
{
 mstrCoursewareCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseDate);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseDateIn
{
get
{
return mstrCoursewareCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseDateIn = value;
}
else
{
 mstrCoursewareCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseDateIn);
}
}
/// <summary>
/// 课件教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseID
{
get
{
return mstrCoursewareCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseID = value;
}
else
{
 mstrCoursewareCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseID);
}
}
/// <summary>
/// 课件教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseName
{
get
{
return mstrCoursewareCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseName = value;
}
else
{
 mstrCoursewareCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseName);
}
}
/// <summary>
/// 课件教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTheme
{
get
{
return mstrCoursewareCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTheme = value;
}
else
{
 mstrCoursewareCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTheme);
}
}
/// <summary>
/// 课件教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTime
{
get
{
return mstrCoursewareCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTime = value;
}
else
{
 mstrCoursewareCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTime);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTimeIn
{
get
{
return mstrCoursewareCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTimeIn = value;
}
else
{
 mstrCoursewareCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTimeIn);
}
}
/// <summary>
/// 课件教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareCase
{
get
{
return mstrIdCoursewareCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareCase = value;
}
else
{
 mstrIdCoursewareCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdCoursewareCase);
}
}
/// <summary>
/// 课件案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareCaseType
{
get
{
return mstrIdCoursewareCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareCaseType = value;
}
else
{
 mstrIdCoursewareCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdCoursewareCaseType);
}
}
/// <summary>
/// 课件案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTypeName
{
get
{
return mstrCoursewareCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTypeName = value;
}
else
{
 mstrCoursewareCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CoursewareCaseTypeName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserKindId);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.UserKindName);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.Memo);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.OwnerNameWithId);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convCoursewareCaseQuantitySenate.CollegeNameA);
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
 /// v课件量化评议(vCoursewareCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCoursewareCaseQuantitySenate
{
public const string _CurrTabName = "vCoursewareCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "UserId", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "CollegeID", "CollegeName", "BrowseCount", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "UpdUser", "UpdUserName", "FuncModuleName", "FuncModuleId", "UserTypeId", "SenateIp", "UserTypeName", "UserName", "OwnerId", "OwnerName", "UserNameWithUserId", "IsDualVideo", "CoursewareCaseDate", "CoursewareCaseDateIn", "CoursewareCaseID", "CoursewareCaseName", "CoursewareCaseTheme", "CoursewareCaseTime", "CoursewareCaseTimeIn", "IdCoursewareCase", "IdCoursewareCaseType", "CoursewareCaseTypeName", "UserKindId", "UserKindName", "Memo", "OwnerNameWithId", "IdXzCollege", "CollegeNameA"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdmicroteachCaseQuantitySenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdmicroteachCaseQuantitySenate = "IdmicroteachCaseQuantitySenate";    //微格量化评价流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

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
 /// 常量:"CoursewareCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseDate = "CoursewareCaseDate";    //课件教学日期

 /// <summary>
 /// 常量:"CoursewareCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseDateIn = "CoursewareCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CoursewareCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseID = "CoursewareCaseID";    //课件教学案例ID

 /// <summary>
 /// 常量:"CoursewareCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseName = "CoursewareCaseName";    //课件教学案例名称

 /// <summary>
 /// 常量:"CoursewareCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTheme = "CoursewareCaseTheme";    //课件教学案例主题词

 /// <summary>
 /// 常量:"CoursewareCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTime = "CoursewareCaseTime";    //课件教学时间

 /// <summary>
 /// 常量:"CoursewareCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTimeIn = "CoursewareCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IdCoursewareCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareCase = "IdCoursewareCase";    //课件教学案例流水号

 /// <summary>
 /// 常量:"IdCoursewareCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareCaseType = "IdCoursewareCaseType";    //课件案例类型流水号

 /// <summary>
 /// 常量:"CoursewareCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTypeName = "CoursewareCaseTypeName";    //课件案例类型名称

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}