
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseQuantitySenateEN
 表名:vYoungTAppraisedCaseQuantitySenate(01120445)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// 表vYoungTAppraisedCaseQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vYoungTAppraisedCaseQuantitySenate
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
public K_IdmicroteachCaseQuantitySenate_vYoungTAppraisedCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vYoungTAppraisedCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vYoungTAppraisedCaseQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vYoungTAppraisedCaseQuantitySenate(value);
}
}
 /// <summary>
 /// v青教评优专家量化评价(vYoungTAppraisedCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvYoungTAppraisedCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vYoungTAppraisedCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 39;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "IdYoungTAppraisedCase", "YoungTAppraisedCaseID", "YoungTAppraisedCaseName", "TeacherID", "TeacherName", "BrowseCount", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "UpdUser", "UpdUserName", "CollegeID", "CollegeName", "SenateIp", "CollegeIDMark", "CollegeNameMark", "IdCollegeMark", "StuIdTeacherId", "UserId", "UserName", "OwnerId", "AppraiseTypeName", "FuncModuleId", "FuncModuleName", "IdAppraiseType", "IdMicroteachCase", "OwnerName", "senateGaugeVersionTtlScore", "YoungTAppraisedCaseDate", "YoungTAppraisedCaseTypeName", "UserNameWithUserId", "IdXzCollege", "CollegeNameA"};

protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrIdYoungTAppraisedCase;    //青教评优案例流水号
protected string mstrYoungTAppraisedCaseID;    //青教评优案例ID
protected string mstrYoungTAppraisedCaseName;    //青教评优案例名称
protected string mstrTeacherID;    //教师工号
protected string mstrTeacherName;    //教师姓名
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
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrSenateIp;    //评议Ip
protected string mstrCollegeIDMark;    //CollegeID_Mark
protected string mstrCollegeNameMark;    //CollegeName_Mark
protected string mstrIdCollegeMark;    //id_College_Mark
protected string mstrStuIdTeacherId;    //学工号
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrOwnerId;    //拥有者Id
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrOwnerName;    //拥有者姓名
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrYoungTAppraisedCaseDate;    //青教评优教学日期
protected string mstrYoungTAppraisedCaseTypeName;    //青教案例类型名称
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvYoungTAppraisedCaseQuantitySenateEN()
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
public clsvYoungTAppraisedCaseQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
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
if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase)
{
return mstrIdYoungTAppraisedCase;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID)
{
return mstrYoungTAppraisedCaseID;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName)
{
return mstrYoungTAppraisedCaseName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.TeacherID)
{
return mstrTeacherID;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeIDMark)
{
return mstrCollegeIDMark;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeNameMark)
{
return mstrCollegeNameMark;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdCollegeMark)
{
return mstrIdCollegeMark;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate)
{
return mstrYoungTAppraisedCaseDate;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName)
{
return mstrYoungTAppraisedCaseTypeName;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase)
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID)
{
mstrYoungTAppraisedCaseID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName)
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.TeacherID)
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.TeacherID);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.TeacherName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UpdUserName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeIDMark)
{
mstrCollegeIDMark = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeIDMark);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeNameMark)
{
mstrCollegeNameMark = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeNameMark);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdCollegeMark)
{
mstrIdCollegeMark = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdCollegeMark);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate)
{
mstrYoungTAppraisedCaseDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName)
{
mstrYoungTAppraisedCaseTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convYoungTAppraisedCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCase;
}
else if (convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseID;
}
else if (convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseName;
}
else if (convYoungTAppraisedCaseQuantitySenate.TeacherID  ==  AttributeName[intIndex])
{
return mstrTeacherID;
}
else if (convYoungTAppraisedCaseQuantitySenate.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convYoungTAppraisedCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convYoungTAppraisedCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convYoungTAppraisedCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeIDMark  ==  AttributeName[intIndex])
{
return mstrCollegeIDMark;
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeNameMark  ==  AttributeName[intIndex])
{
return mstrCollegeNameMark;
}
else if (convYoungTAppraisedCaseQuantitySenate.IdCollegeMark  ==  AttributeName[intIndex])
{
return mstrIdCollegeMark;
}
else if (convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (convYoungTAppraisedCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convYoungTAppraisedCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convYoungTAppraisedCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convYoungTAppraisedCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convYoungTAppraisedCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convYoungTAppraisedCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convYoungTAppraisedCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseDate;
}
else if (convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTypeName;
}
else if (convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convYoungTAppraisedCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase);
}
else if (convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID);
}
else if (convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName);
}
else if (convYoungTAppraisedCaseQuantitySenate.TeacherID  ==  AttributeName[intIndex])
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.TeacherID);
}
else if (convYoungTAppraisedCaseQuantitySenate.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.TeacherName);
}
else if (convYoungTAppraisedCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.BrowseCount);
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTheme);
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateContent);
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTotalScore);
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateDate);
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTime);
}
else if (convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID);
}
else if (convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName);
}
else if (convYoungTAppraisedCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UpdUser);
}
else if (convYoungTAppraisedCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UpdUserName);
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeID);
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeName);
}
else if (convYoungTAppraisedCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateIp);
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeIDMark  ==  AttributeName[intIndex])
{
mstrCollegeIDMark = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeIDMark);
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeNameMark  ==  AttributeName[intIndex])
{
mstrCollegeNameMark = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeNameMark);
}
else if (convYoungTAppraisedCaseQuantitySenate.IdCollegeMark  ==  AttributeName[intIndex])
{
mstrIdCollegeMark = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdCollegeMark);
}
else if (convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId);
}
else if (convYoungTAppraisedCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserId);
}
else if (convYoungTAppraisedCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserName);
}
else if (convYoungTAppraisedCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.OwnerId);
}
else if (convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName);
}
else if (convYoungTAppraisedCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.FuncModuleId);
}
else if (convYoungTAppraisedCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.FuncModuleName);
}
else if (convYoungTAppraisedCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdAppraiseType);
}
else if (convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase);
}
else if (convYoungTAppraisedCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.OwnerName);
}
else if (convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseDate = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate);
}
else if (convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTypeName = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName);
}
else if (convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId);
}
else if (convYoungTAppraisedCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdXzCollege);
}
else if (convYoungTAppraisedCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeNameA);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
}
/// <summary>
/// 青教评优案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdYoungTAppraisedCase
{
get
{
return mstrIdYoungTAppraisedCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdYoungTAppraisedCase = value;
}
else
{
 mstrIdYoungTAppraisedCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase);
}
}
/// <summary>
/// 青教评优案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseID
{
get
{
return mstrYoungTAppraisedCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseID = value;
}
else
{
 mstrYoungTAppraisedCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID);
}
}
/// <summary>
/// 青教评优案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseName
{
get
{
return mstrYoungTAppraisedCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseName = value;
}
else
{
 mstrYoungTAppraisedCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherID
{
get
{
return mstrTeacherID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherID = value;
}
else
{
 mstrTeacherID = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.TeacherID);
}
}
/// <summary>
/// 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherName
{
get
{
return mstrTeacherName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherName = value;
}
else
{
 mstrTeacherName = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.TeacherName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.BrowseCount);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTheme);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateContent);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTotalScore);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateDate);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateTime);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UpdUser);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UpdUserName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.SenateIp);
}
}
/// <summary>
/// CollegeID_Mark(说明:;字段类型:varchar;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeIDMark
{
get
{
return mstrCollegeIDMark;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeIDMark = value;
}
else
{
 mstrCollegeIDMark = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeIDMark);
}
}
/// <summary>
/// CollegeName_Mark(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameMark
{
get
{
return mstrCollegeNameMark;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameMark = value;
}
else
{
 mstrCollegeNameMark = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeNameMark);
}
}
/// <summary>
/// id_College_Mark(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCollegeMark
{
get
{
return mstrIdCollegeMark;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCollegeMark = value;
}
else
{
 mstrIdCollegeMark = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdCollegeMark);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.OwnerId);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.FuncModuleName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.OwnerName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 青教评优教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseDate
{
get
{
return mstrYoungTAppraisedCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseDate = value;
}
else
{
 mstrYoungTAppraisedCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate);
}
}
/// <summary>
/// 青教案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTypeName
{
get
{
return mstrYoungTAppraisedCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTypeName = value;
}
else
{
 mstrYoungTAppraisedCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convYoungTAppraisedCaseQuantitySenate.CollegeNameA);
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
 /// v青教评优专家量化评价(vYoungTAppraisedCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convYoungTAppraisedCaseQuantitySenate
{
public const string _CurrTabName = "vYoungTAppraisedCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "IdYoungTAppraisedCase", "YoungTAppraisedCaseID", "YoungTAppraisedCaseName", "TeacherID", "TeacherName", "BrowseCount", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "UpdUser", "UpdUserName", "CollegeID", "CollegeName", "SenateIp", "CollegeIDMark", "CollegeNameMark", "IdCollegeMark", "StuIdTeacherId", "UserId", "UserName", "OwnerId", "AppraiseTypeName", "FuncModuleId", "FuncModuleName", "IdAppraiseType", "IdMicroteachCase", "OwnerName", "senateGaugeVersionTtlScore", "YoungTAppraisedCaseDate", "YoungTAppraisedCaseTypeName", "UserNameWithUserId", "IdXzCollege", "CollegeNameA"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdmicroteachCaseQuantitySenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdmicroteachCaseQuantitySenate = "IdmicroteachCaseQuantitySenate";    //微格量化评价流水号

 /// <summary>
 /// 常量:"IdYoungTAppraisedCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdYoungTAppraisedCase = "IdYoungTAppraisedCase";    //青教评优案例流水号

 /// <summary>
 /// 常量:"YoungTAppraisedCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseID = "YoungTAppraisedCaseID";    //青教评优案例ID

 /// <summary>
 /// 常量:"YoungTAppraisedCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseName = "YoungTAppraisedCaseName";    //青教评优案例名称

 /// <summary>
 /// 常量:"TeacherID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherID = "TeacherID";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

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
 /// 常量:"SenateIp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateIp = "SenateIp";    //评议Ip

 /// <summary>
 /// 常量:"CollegeIDMark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeIDMark = "CollegeIDMark";    //CollegeID_Mark

 /// <summary>
 /// 常量:"CollegeNameMark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameMark = "CollegeNameMark";    //CollegeName_Mark

 /// <summary>
 /// 常量:"IdCollegeMark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCollegeMark = "IdCollegeMark";    //id_College_Mark

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
 /// 常量:"AppraiseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName = "AppraiseTypeName";    //评议类型名称

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
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"YoungTAppraisedCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseDate = "YoungTAppraisedCaseDate";    //青教评优教学日期

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTypeName = "YoungTAppraisedCaseTypeName";    //青教案例类型名称

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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}