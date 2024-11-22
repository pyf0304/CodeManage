
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseQuantitySenateEN
 表名:vEduMSTRGiftedClsCaseQuantitySenate(01120452)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
 /// 表vEduMSTRGiftedClsCaseQuantitySenate的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vEduMSTRGiftedClsCaseQuantitySenate
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
public K_IdmicroteachCaseQuantitySenate_vEduMSTRGiftedClsCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
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
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vEduMSTRGiftedClsCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vEduMSTRGiftedClsCaseQuantitySenate(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vEduMSTRGiftedClsCaseQuantitySenate(value);
}
}
 /// <summary>
 /// v教育硕士优课教师量化评价(vEduMSTRGiftedClsCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvEduMSTRGiftedClsCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vEduMSTRGiftedClsCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 42;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTypeName", "senateGaugeVersionTtlScore", "OwnerId", "StuName", "StuID", "IdXzCollege", "UserKindName", "UserTypeName", "OwnerName", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "UserId", "CollegeID", "CollegeName", "IsLeaved", "StuIdTeacherId", "UserNameWithUserId", "CollegeNameA", "UserName", "UserKindId", "UserTypeId", "UpdUser", "UpdUserName", "OwnerNameWithId"};

protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdEduMSTRGiftedClsCase;    //教育硕士优课案例流水号
protected string mstrEduMSTRGiftedClsCaseID;    //教育硕士优课案例ID
protected string mstrEduMSTRGiftedClsCaseName;    //教育硕士优课案例名称
protected string mstrEduMSTRGiftedClsCaseDate;    //教育硕士优课案例日期
protected string mstrEduMSTRGiftedClsCaseTypeName;    //教育硕士优课案例类型名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrOwnerId;    //拥有者Id
protected string mstrStuName;    //姓名
protected string mstrStuID;    //学号
protected string mstrIdXzCollege;    //学院流水号
protected string mstrUserKindName;    //用户类别名
protected string mstrUserTypeName;    //用户类型名称
protected string mstrOwnerName;    //拥有者姓名
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
protected string mstrUserId;    //用户ID
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected bool mbolIsLeaved;    //IsLeaved
protected string mstrStuIdTeacherId;    //学工号
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrUserName;    //用户名
protected string mstrUserKindId;    //用户类别Id
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdUserName;    //UpdUserName
protected string mstrOwnerNameWithId;    //拥有者名称附Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvEduMSTRGiftedClsCaseQuantitySenateEN()
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
public clsvEduMSTRGiftedClsCaseQuantitySenateEN(long lngIdmicroteachCaseQuantitySenate)
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
if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase)
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID)
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName)
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate)
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName)
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserKindName)
{
return mstrUserKindName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme)
{
return mstrSenateTheme;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateContent)
{
return mstrSenateContent;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore)
{
return mfltSenateTotalScore;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateTime)
{
return mstrSenateTime;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateIp)
{
return mstrSenateIp;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserKindId)
{
return mstrUserKindId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
return null;
}
set
{
if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase)
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID)
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName)
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate)
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName)
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserKindName)
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserKindName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme)
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateContent)
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateContent);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore)
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateTime)
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTime);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.SenateIp)
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateIp);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserKindId)
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserKindId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UpdUser);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId);
}
}
}
public object this[int intIndex]
{
get
{
if (convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseDate;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
return mstrUserKindName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
return mstrSenateTheme;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
return mstrSenateContent;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
return mfltSenateTotalScore;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
return mstrSenateTime;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
return mstrSenateIp;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
return mstrUserKindId;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
return null;
}
set
{
if (convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerId);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuID);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserKindName  ==  AttributeName[intIndex])
{
mstrUserKindName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserKindName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme  ==  AttributeName[intIndex])
{
mstrSenateTheme = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateContent  ==  AttributeName[intIndex])
{
mstrSenateContent = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateContent);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore  ==  AttributeName[intIndex])
{
mfltSenateTotalScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateDate);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateTime  ==  AttributeName[intIndex])
{
mstrSenateTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTime);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.SenateIp  ==  AttributeName[intIndex])
{
mstrSenateIp = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateIp);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserId);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeID);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserKindId  ==  AttributeName[intIndex])
{
mstrUserKindId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserKindId);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UpdUser);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName);
}
else if (convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase);
}
}
/// <summary>
/// 教育硕士优课案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduMSTRGiftedClsCase
{
get
{
return mstrIdEduMSTRGiftedClsCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduMSTRGiftedClsCase = value;
}
else
{
 mstrIdEduMSTRGiftedClsCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase);
}
}
/// <summary>
/// 教育硕士优课案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseID
{
get
{
return mstrEduMSTRGiftedClsCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseID = value;
}
else
{
 mstrEduMSTRGiftedClsCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID);
}
}
/// <summary>
/// 教育硕士优课案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseName
{
get
{
return mstrEduMSTRGiftedClsCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseName = value;
}
else
{
 mstrEduMSTRGiftedClsCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName);
}
}
/// <summary>
/// 教育硕士优课案例日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseDate
{
get
{
return mstrEduMSTRGiftedClsCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseDate = value;
}
else
{
 mstrEduMSTRGiftedClsCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate);
}
}
/// <summary>
/// 教育硕士优课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseTypeName
{
get
{
return mstrEduMSTRGiftedClsCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseTypeName = value;
}
else
{
 mstrEduMSTRGiftedClsCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserKindName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateContent);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateTime);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.SenateIp);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserKindId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UpdUser);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId);
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
 /// v教育硕士优课教师量化评价(vEduMSTRGiftedClsCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convEduMSTRGiftedClsCaseQuantitySenate
{
public const string _CurrTabName = "vEduMSTRGiftedClsCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseID", "EduMSTRGiftedClsCaseName", "EduMSTRGiftedClsCaseDate", "EduMSTRGiftedClsCaseTypeName", "senateGaugeVersionTtlScore", "OwnerId", "StuName", "StuID", "IdXzCollege", "UserKindName", "UserTypeName", "OwnerName", "IdAppraiseType", "AppraiseTypeName", "SenateTheme", "SenateContent", "SenateTotalScore", "SenateDate", "SenateTime", "SenateIp", "BrowseCount", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "UserId", "CollegeID", "CollegeName", "IsLeaved", "StuIdTeacherId", "UserNameWithUserId", "CollegeNameA", "UserName", "UserKindId", "UserTypeId", "UpdUser", "UpdUserName", "OwnerNameWithId"};
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
 /// 常量:"IdEduMSTRGiftedClsCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduMSTRGiftedClsCase = "IdEduMSTRGiftedClsCase";    //教育硕士优课案例流水号

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseID = "EduMSTRGiftedClsCaseID";    //教育硕士优课案例ID

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseName = "EduMSTRGiftedClsCaseName";    //教育硕士优课案例名称

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseDate = "EduMSTRGiftedClsCaseDate";    //教育硕士优课案例日期

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseTypeName = "EduMSTRGiftedClsCaseTypeName";    //教育硕士优课案例类型名称

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"StuID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuID = "StuID";    //学号

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"UserKindName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserKindName = "UserKindName";    //用户类别名

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"StuIdTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuIdTeacherId = "StuIdTeacherId";    //学工号

 /// <summary>
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

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
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

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
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id
}

}