
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCaseQuantitySenateEN
 表名:vClsRmTeachingCaseQuantitySenate(01120456)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 表vClsRmTeachingCaseQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vClsRmTeachingCaseQuantitySenate
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
public K_IdmicroteachCaseQuantitySenate_vClsRmTeachingCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vClsRmTeachingCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vClsRmTeachingCaseQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vClsRmTeachingCaseQuantitySenate(value);
}
}
 /// <summary>
 /// v课堂教学量化评议(vClsRmTeachingCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvClsRmTeachingCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vClsRmTeachingCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 44;
public static string[] AttributeName = new string[] {"IdClsRmTeachingCase", "ClsRmTeachingCaseID", "ClsRmTeachingCaseName", "ClsRmTeachingCaseTheme", "ClsRmTeachingCaseTypeName", "ClsRmTeachingCaseDate", "ClsRmTeachingCaseTime", "ClsRmTeachingCaseDateIn", "ClsRmTeachingCaseTimeIn", "UserNameWithUserId", "OwnerId", "OwnerName", "IdXzCollege", "CollegeName", "OwnerNameWithId", "CollegeID", "CollegeNameA", "UserTypeId", "IsDualVideo", "IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UserId", "UserName", "UserKindId", "UserKindName", "UpdUser", "UpdUserName", "Memo", "UserTypeName"};

protected string mstrIdClsRmTeachingCase;    //课堂教学案例流水号
protected string mstrClsRmTeachingCaseID;    //课堂教学案例ID
protected string mstrClsRmTeachingCaseName;    //课堂教学案例名称
protected string mstrClsRmTeachingCaseTheme;    //课堂教学案例主题词
protected string mstrClsRmTeachingCaseTypeName;    //课堂案例类型名称
protected string mstrClsRmTeachingCaseDate;    //课堂教学日期
protected string mstrClsRmTeachingCaseTime;    //课堂教学时间
protected string mstrClsRmTeachingCaseDateIn;    //案例入库日期
protected string mstrClsRmTeachingCaseTimeIn;    //案例入库时间
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrUserTypeId;    //用户类型Id
protected bool mbolIsDualVideo;    //是否双视频
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
 public clsvClsRmTeachingCaseQuantitySenateEN()
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
public clsvClsRmTeachingCaseQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
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
if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase)
{
return mstrIdClsRmTeachingCase;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID)
{
return mstrClsRmTeachingCaseID;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName)
{
return mstrClsRmTeachingCaseName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme)
{
return mstrClsRmTeachingCaseTheme;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName)
{
return mstrClsRmTeachingCaseTypeName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate)
{
return mstrClsRmTeachingCaseDate;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime)
{
return mstrClsRmTeachingCaseTime;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn)
{
return mstrClsRmTeachingCaseDateIn;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn)
{
return mstrClsRmTeachingCaseTimeIn;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserTypeName)
{
return mstrUserTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase)
{
mstrIdClsRmTeachingCase = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID)
{
mstrClsRmTeachingCaseID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName)
{
mstrClsRmTeachingCaseName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme)
{
mstrClsRmTeachingCaseTheme = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName)
{
mstrClsRmTeachingCaseTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate)
{
mstrClsRmTeachingCaseDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime)
{
mstrClsRmTeachingCaseTime = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn)
{
mstrClsRmTeachingCaseDateIn = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn)
{
mstrClsRmTeachingCaseTimeIn = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerNameWithId);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeNameA);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserTypeId);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IsDualVideo);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserKindId);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserKindName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UpdUserName);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.Memo);
}
else if (strAttributeName  ==  convClsRmTeachingCaseQuantitySenate.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase  ==  AttributeName[intIndex])
{
return mstrIdClsRmTeachingCase;
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseID;
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseName;
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTheme;
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTypeName;
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseDate;
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTime;
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseDateIn;
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTimeIn;
}
else if (convClsRmTeachingCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convClsRmTeachingCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convClsRmTeachingCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convClsRmTeachingCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convClsRmTeachingCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convClsRmTeachingCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convClsRmTeachingCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convClsRmTeachingCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convClsRmTeachingCaseQuantitySenate.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convClsRmTeachingCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convClsRmTeachingCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convClsRmTeachingCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convClsRmTeachingCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convClsRmTeachingCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convClsRmTeachingCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convClsRmTeachingCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convClsRmTeachingCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convClsRmTeachingCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convClsRmTeachingCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convClsRmTeachingCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convClsRmTeachingCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convClsRmTeachingCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convClsRmTeachingCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convClsRmTeachingCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convClsRmTeachingCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convClsRmTeachingCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convClsRmTeachingCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convClsRmTeachingCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (convClsRmTeachingCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convClsRmTeachingCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
return null;
}
set
{
if (convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase  ==  AttributeName[intIndex])
{
mstrIdClsRmTeachingCase = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase);
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID);
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName);
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTheme = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme);
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName);
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate);
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTime = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime);
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseDateIn = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn);
}
else if (convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTimeIn = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn);
}
else if (convClsRmTeachingCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserNameWithUserId);
}
else if (convClsRmTeachingCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerId);
}
else if (convClsRmTeachingCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerName);
}
else if (convClsRmTeachingCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdXzCollege);
}
else if (convClsRmTeachingCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeName);
}
else if (convClsRmTeachingCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerNameWithId);
}
else if (convClsRmTeachingCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeID);
}
else if (convClsRmTeachingCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeNameA);
}
else if (convClsRmTeachingCaseQuantitySenate.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserTypeId);
}
else if (convClsRmTeachingCaseQuantitySenate.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IsDualVideo);
}
else if (convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convClsRmTeachingCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.FuncModuleId);
}
else if (convClsRmTeachingCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.FuncModuleName);
}
else if (convClsRmTeachingCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdMicroteachCase);
}
else if (convClsRmTeachingCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdAppraiseType);
}
else if (convClsRmTeachingCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.AppraiseTypeName);
}
else if (convClsRmTeachingCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTheme);
}
else if (convClsRmTeachingCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateContent);
}
else if (convClsRmTeachingCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTotalScore);
}
else if (convClsRmTeachingCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateDate);
}
else if (convClsRmTeachingCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTime);
}
else if (convClsRmTeachingCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateIp);
}
else if (convClsRmTeachingCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.BrowseCount);
}
else if (convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID);
}
else if (convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName);
}
else if (convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convClsRmTeachingCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserId);
}
else if (convClsRmTeachingCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserName);
}
else if (convClsRmTeachingCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserKindId);
}
else if (convClsRmTeachingCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserKindName);
}
else if (convClsRmTeachingCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UpdUser);
}
else if (convClsRmTeachingCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UpdUserName);
}
else if (convClsRmTeachingCaseQuantitySenate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.Memo);
}
else if (convClsRmTeachingCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserTypeName);
}
}
}

/// <summary>
/// 课堂教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdClsRmTeachingCase
{
get
{
return mstrIdClsRmTeachingCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdClsRmTeachingCase = value;
}
else
{
 mstrIdClsRmTeachingCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase);
}
}
/// <summary>
/// 课堂教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseID
{
get
{
return mstrClsRmTeachingCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseID = value;
}
else
{
 mstrClsRmTeachingCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID);
}
}
/// <summary>
/// 课堂教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseName
{
get
{
return mstrClsRmTeachingCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseName = value;
}
else
{
 mstrClsRmTeachingCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName);
}
}
/// <summary>
/// 课堂教学案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTheme
{
get
{
return mstrClsRmTeachingCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTheme = value;
}
else
{
 mstrClsRmTeachingCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme);
}
}
/// <summary>
/// 课堂案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTypeName
{
get
{
return mstrClsRmTeachingCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTypeName = value;
}
else
{
 mstrClsRmTeachingCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName);
}
}
/// <summary>
/// 课堂教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseDate
{
get
{
return mstrClsRmTeachingCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseDate = value;
}
else
{
 mstrClsRmTeachingCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate);
}
}
/// <summary>
/// 课堂教学时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTime
{
get
{
return mstrClsRmTeachingCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTime = value;
}
else
{
 mstrClsRmTeachingCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseDateIn
{
get
{
return mstrClsRmTeachingCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseDateIn = value;
}
else
{
 mstrClsRmTeachingCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTimeIn
{
get
{
return mstrClsRmTeachingCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTimeIn = value;
}
else
{
 mstrClsRmTeachingCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserNameWithUserId);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerId);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerName);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.OwnerNameWithId);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.CollegeNameA);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserTypeId);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IsDualVideo);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.FuncModuleName);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdMicroteachCase);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.AppraiseTypeName);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTheme);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateContent);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTotalScore);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateDate);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateTime);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.SenateIp);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.BrowseCount);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserName);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserKindId);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserKindName);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UpdUser);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UpdUserName);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.Memo);
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
 AddUpdatedFld(convClsRmTeachingCaseQuantitySenate.UserTypeName);
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
 /// v课堂教学量化评议(vClsRmTeachingCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convClsRmTeachingCaseQuantitySenate
{
public const string _CurrTabName = "vClsRmTeachingCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdClsRmTeachingCase", "ClsRmTeachingCaseID", "ClsRmTeachingCaseName", "ClsRmTeachingCaseTheme", "ClsRmTeachingCaseTypeName", "ClsRmTeachingCaseDate", "ClsRmTeachingCaseTime", "ClsRmTeachingCaseDateIn", "ClsRmTeachingCaseTimeIn", "UserNameWithUserId", "OwnerId", "OwnerName", "IdXzCollege", "CollegeName", "OwnerNameWithId", "CollegeID", "CollegeNameA", "UserTypeId", "IsDualVideo", "IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UserId", "UserName", "UserKindId", "UserKindName", "UpdUser", "UpdUserName", "Memo", "UserTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdClsRmTeachingCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdClsRmTeachingCase = "IdClsRmTeachingCase";    //课堂教学案例流水号

 /// <summary>
 /// 常量:"ClsRmTeachingCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseID = "ClsRmTeachingCaseID";    //课堂教学案例ID

 /// <summary>
 /// 常量:"ClsRmTeachingCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseName = "ClsRmTeachingCaseName";    //课堂教学案例名称

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTheme = "ClsRmTeachingCaseTheme";    //课堂教学案例主题词

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTypeName = "ClsRmTeachingCaseTypeName";    //课堂案例类型名称

 /// <summary>
 /// 常量:"ClsRmTeachingCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseDate = "ClsRmTeachingCaseDate";    //课堂教学日期

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTime = "ClsRmTeachingCaseTime";    //课堂教学时间

 /// <summary>
 /// 常量:"ClsRmTeachingCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseDateIn = "ClsRmTeachingCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTimeIn = "ClsRmTeachingCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

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
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

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