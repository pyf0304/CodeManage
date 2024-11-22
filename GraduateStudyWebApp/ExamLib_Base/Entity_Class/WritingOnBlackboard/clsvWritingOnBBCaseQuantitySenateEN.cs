
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCaseQuantitySenateEN
 表名:vWritingOnBBCaseQuantitySenate(01120446)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// 表vWritingOnBBCaseQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vWritingOnBBCaseQuantitySenate
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
public K_IdmicroteachCaseQuantitySenate_vWritingOnBBCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vWritingOnBBCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vWritingOnBBCaseQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vWritingOnBBCaseQuantitySenate(value);
}
}
 /// <summary>
 /// vWritingOnBBCaseQuantitySenate(vWritingOnBBCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvWritingOnBBCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vWritingOnBBCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 37;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "IdWritingOnBBCase", "WritingOnBBCaseID", "WritingOnBBCaseName", "WritingOnBBCaseDate", "BrowseCount", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UpdUserName", "UpdUser", "CollegeID", "CollegeName", "IsLeaved", "SenateIp", "StuIdTeacherId", "UserId", "UserName", "OwnerId", "StuID", "StuName", "OwnerName", "UserNameWithUserId", "WritingOnBBCaseTypeName", "IdXzCollege", "CollegeNameA"};

protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrIdWritingOnBBCase;    //板书案例流水号
protected string mstrWritingOnBBCaseID;    //板书教学案例ID
protected string mstrWritingOnBBCaseName;    //板书教学案例名称
protected string mstrWritingOnBBCaseDate;    //板书教学日期
protected int? mintBrowseCount;    //浏览次数
protected string mstrSenateTheme;    //量化评价主题
protected string mstrSenateContent;    //评价内容
protected float mfltSenateTotalScore;    //评价分数
protected string mstrSenateDate;    //评价日期
protected string mstrSenateTime;    //评价时间
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrUpdUserName;    //UpdUserName
protected string mstrUpdUser;    //修改人
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected bool mbolIsLeaved;    //IsLeaved
protected string mstrSenateIp;    //评议Ip
protected string mstrStuIdTeacherId;    //学工号
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrOwnerId;    //拥有者Id
protected string mstrStuID;    //学号
protected string mstrStuName;    //姓名
protected string mstrOwnerName;    //拥有者姓名
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrWritingOnBBCaseTypeName;    //板书案例类型名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvWritingOnBBCaseQuantitySenateEN()
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
public clsvWritingOnBBCaseQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
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
if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase)
{
return mstrIdWritingOnBBCase;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID)
{
return mstrWritingOnBBCaseID;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName)
{
return mstrWritingOnBBCaseName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate)
{
return mstrWritingOnBBCaseDate;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName)
{
return mstrWritingOnBBCaseTypeName;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase)
{
mstrIdWritingOnBBCase = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID)
{
mstrWritingOnBBCaseID = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName)
{
mstrWritingOnBBCaseName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate)
{
mstrWritingOnBBCaseDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UpdUserName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IsLeaved);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuIdTeacherId);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuID);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName)
{
mstrWritingOnBBCaseTypeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convWritingOnBBCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convWritingOnBBCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convWritingOnBBCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convWritingOnBBCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convWritingOnBBCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convWritingOnBBCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase  ==  AttributeName[intIndex])
{
return mstrIdWritingOnBBCase;
}
else if (convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseID;
}
else if (convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseName;
}
else if (convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseDate;
}
else if (convWritingOnBBCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convWritingOnBBCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convWritingOnBBCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convWritingOnBBCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convWritingOnBBCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convWritingOnBBCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convWritingOnBBCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convWritingOnBBCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convWritingOnBBCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (convWritingOnBBCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convWritingOnBBCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convWritingOnBBCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convWritingOnBBCaseQuantitySenate.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (convWritingOnBBCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convWritingOnBBCaseQuantitySenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (convWritingOnBBCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convWritingOnBBCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convWritingOnBBCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convWritingOnBBCaseQuantitySenate.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convWritingOnBBCaseQuantitySenate.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convWritingOnBBCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convWritingOnBBCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTypeName;
}
else if (convWritingOnBBCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convWritingOnBBCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convWritingOnBBCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.FuncModuleId);
}
else if (convWritingOnBBCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.FuncModuleName);
}
else if (convWritingOnBBCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdMicroteachCase);
}
else if (convWritingOnBBCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdAppraiseType);
}
else if (convWritingOnBBCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.AppraiseTypeName);
}
else if (convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase  ==  AttributeName[intIndex])
{
mstrIdWritingOnBBCase = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase);
}
else if (convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseID = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID);
}
else if (convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName);
}
else if (convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate);
}
else if (convWritingOnBBCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.BrowseCount);
}
else if (convWritingOnBBCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTheme);
}
else if (convWritingOnBBCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateContent);
}
else if (convWritingOnBBCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTotalScore);
}
else if (convWritingOnBBCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateDate);
}
else if (convWritingOnBBCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTime);
}
else if (convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (convWritingOnBBCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionID);
}
else if (convWritingOnBBCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionName);
}
else if (convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convWritingOnBBCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UpdUserName);
}
else if (convWritingOnBBCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UpdUser);
}
else if (convWritingOnBBCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeID);
}
else if (convWritingOnBBCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeName);
}
else if (convWritingOnBBCaseQuantitySenate.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IsLeaved);
}
else if (convWritingOnBBCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateIp);
}
else if (convWritingOnBBCaseQuantitySenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuIdTeacherId);
}
else if (convWritingOnBBCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserId);
}
else if (convWritingOnBBCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserName);
}
else if (convWritingOnBBCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.OwnerId);
}
else if (convWritingOnBBCaseQuantitySenate.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuID);
}
else if (convWritingOnBBCaseQuantitySenate.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuName);
}
else if (convWritingOnBBCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.OwnerName);
}
else if (convWritingOnBBCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserNameWithUserId);
}
else if (convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTypeName = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName);
}
else if (convWritingOnBBCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdXzCollege);
}
else if (convWritingOnBBCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeNameA);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.FuncModuleName);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdMicroteachCase);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.AppraiseTypeName);
}
}
/// <summary>
/// 板书案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdWritingOnBBCase
{
get
{
return mstrIdWritingOnBBCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdWritingOnBBCase = value;
}
else
{
 mstrIdWritingOnBBCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase);
}
}
/// <summary>
/// 板书教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseID
{
get
{
return mstrWritingOnBBCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseID = value;
}
else
{
 mstrWritingOnBBCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID);
}
}
/// <summary>
/// 板书教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseName
{
get
{
return mstrWritingOnBBCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseName = value;
}
else
{
 mstrWritingOnBBCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName);
}
}
/// <summary>
/// 板书教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseDate
{
get
{
return mstrWritingOnBBCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseDate = value;
}
else
{
 mstrWritingOnBBCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.BrowseCount);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTheme);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateContent);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTotalScore);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateDate);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateTime);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionID);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UpdUserName);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UpdUser);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IsLeaved);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.SenateIp);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuIdTeacherId);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserName);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.OwnerId);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuID
{
get
{
return mstrStuID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuID = value;
}
else
{
 mstrStuID = value;
}
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuID);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.StuName);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.OwnerName);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.UserNameWithUserId);
}
}
/// <summary>
/// 板书案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseTypeName
{
get
{
return mstrWritingOnBBCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseTypeName = value;
}
else
{
 mstrWritingOnBBCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convWritingOnBBCaseQuantitySenate.CollegeNameA);
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
 /// vWritingOnBBCaseQuantitySenate(vWritingOnBBCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convWritingOnBBCaseQuantitySenate
{
public const string _CurrTabName = "vWritingOnBBCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "IdWritingOnBBCase", "WritingOnBBCaseID", "WritingOnBBCaseName", "WritingOnBBCaseDate", "BrowseCount", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "UpdUserName", "UpdUser", "CollegeID", "CollegeName", "IsLeaved", "SenateIp", "StuIdTeacherId", "UserId", "UserName", "OwnerId", "StuID", "StuName", "OwnerName", "UserNameWithUserId", "WritingOnBBCaseTypeName", "IdXzCollege", "CollegeNameA"};
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
 /// 常量:"IdWritingOnBBCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWritingOnBBCase = "IdWritingOnBBCase";    //板书案例流水号

 /// <summary>
 /// 常量:"WritingOnBBCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseID = "WritingOnBBCaseID";    //板书教学案例ID

 /// <summary>
 /// 常量:"WritingOnBBCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseName = "WritingOnBBCaseName";    //板书教学案例名称

 /// <summary>
 /// 常量:"WritingOnBBCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseDate = "WritingOnBBCaseDate";    //板书教学日期

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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
 /// 常量:"IsLeaved"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeaved = "IsLeaved";    //IsLeaved

 /// <summary>
 /// 常量:"SenateIp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateIp = "SenateIp";    //评议Ip

 /// <summary>
 /// 常量:"StuIdTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuIdTeacherId = "StuIdTeacherId";    //学工号

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
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"StuID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuID = "StuID";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

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
 /// 常量:"WritingOnBBCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseTypeName = "WritingOnBBCaseTypeName";    //板书案例类型名称

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