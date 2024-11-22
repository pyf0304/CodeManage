
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersEN
 表名:vUsers(01120027)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 表vUsers的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_vUsers
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserId">表关键字</param>
public K_UserId_vUsers(string strUserId)
{
if (IsValid(strUserId)) Value = strUserId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return false;
if (strUserId.Length > 18) return false;
if (strUserId.IndexOf(' ') >= 0) return false;
if (strUserId.IndexOf(')') >= 0) return false;
if (strUserId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserId_vUsers]类型的对象</returns>
public static implicit operator K_UserId_vUsers(string value)
{
return new K_UserId_vUsers(value);
}
}
 /// <summary>
 /// v用户(vUsers)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUsersEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUsers"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 36;
public static string[] AttributeName = new string[] {"UserId", "UserName", "UserStateId", "UserStateName", "Password", "IsGpUser", "BeginYearMonth", "EndYearMonth", "IdGradeBase", "GradeBaseName", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IsLeaved", "StuIdTeacherId", "IdentityId", "IdentityDesc", "AuditDate", "AuditUser", "IsAudit", "IsRegister", "RegisterDate", "MobilePhone", "UpdDate", "UpdUser", "Memo", "UserNameWithUserId", "OpenId", "AvatarsPicture", "Email", "PhoneNumber", "HeadPic", "IsGSuser"};

protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrUserStateId;    //用户状态Id
protected string mstrUserStateName;    //用户状态名
protected string mstrPassword;    //口令
protected bool mbolIsGpUser;    //是否Gp用户
protected string mstrBeginYearMonth;    //开始年月
protected string mstrEndYearMonth;    //结束年月
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected bool mbolIsLeaved;    //是否离开
protected string mstrStuIdTeacherId;    //学工号
protected string mstrIdentityId;    //身份Id
protected string mstrIdentityDesc;    //身份描述
protected string mstrAuditDate;    //AuditDate
protected string mstrAuditUser;    //AuditUser
protected bool mbolIsAudit;    //是否审核
protected bool mbolIsRegister;    //IsRegister
protected string mstrRegisterDate;    //RegisterDate
protected string mstrMobilePhone;    //手机
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrOpenId;    //微信OpenId
protected string mstrAvatarsPicture;    //虚拟头像
protected string mstrEmail;    //电子邮箱
protected string mstrPhoneNumber;    //电话
protected string mstrHeadPic;    //头像
protected bool mbolIsGSuser;    //是否GS用户

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvUsersEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserId">关键字:用户ID</param>
public clsvUsersEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:vUsers中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:vUsers中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserId = strUserId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
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
if (strAttributeName  ==  convUsers.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUsers.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUsers.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convUsers.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convUsers.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  convUsers.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  convUsers.BeginYearMonth)
{
return mstrBeginYearMonth;
}
else if (strAttributeName  ==  convUsers.EndYearMonth)
{
return mstrEndYearMonth;
}
else if (strAttributeName  ==  convUsers.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convUsers.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convUsers.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convUsers.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convUsers.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convUsers.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convUsers.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convUsers.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convUsers.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  convUsers.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  convUsers.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  convUsers.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convUsers.AuditDate)
{
return mstrAuditDate;
}
else if (strAttributeName  ==  convUsers.AuditUser)
{
return mstrAuditUser;
}
else if (strAttributeName  ==  convUsers.IsAudit)
{
return mbolIsAudit;
}
else if (strAttributeName  ==  convUsers.IsRegister)
{
return mbolIsRegister;
}
else if (strAttributeName  ==  convUsers.RegisterDate)
{
return mstrRegisterDate;
}
else if (strAttributeName  ==  convUsers.MobilePhone)
{
return mstrMobilePhone;
}
else if (strAttributeName  ==  convUsers.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUsers.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convUsers.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convUsers.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convUsers.OpenId)
{
return mstrOpenId;
}
else if (strAttributeName  ==  convUsers.AvatarsPicture)
{
return mstrAvatarsPicture;
}
else if (strAttributeName  ==  convUsers.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  convUsers.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  convUsers.HeadPic)
{
return mstrHeadPic;
}
else if (strAttributeName  ==  convUsers.IsGSuser)
{
return mbolIsGSuser;
}
return null;
}
set
{
if (strAttributeName  ==  convUsers.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUsers.UserId);
}
else if (strAttributeName  ==  convUsers.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUsers.UserName);
}
else if (strAttributeName  ==  convUsers.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convUsers.UserStateId);
}
else if (strAttributeName  ==  convUsers.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUsers.UserStateName);
}
else if (strAttributeName  ==  convUsers.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(convUsers.Password);
}
else if (strAttributeName  ==  convUsers.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsGpUser);
}
else if (strAttributeName  ==  convUsers.BeginYearMonth)
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(convUsers.BeginYearMonth);
}
else if (strAttributeName  ==  convUsers.EndYearMonth)
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(convUsers.EndYearMonth);
}
else if (strAttributeName  ==  convUsers.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convUsers.IdGradeBase);
}
else if (strAttributeName  ==  convUsers.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convUsers.GradeBaseName);
}
else if (strAttributeName  ==  convUsers.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convUsers.IdXzCollege);
}
else if (strAttributeName  ==  convUsers.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convUsers.CollegeId);
}
else if (strAttributeName  ==  convUsers.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convUsers.CollegeName);
}
else if (strAttributeName  ==  convUsers.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convUsers.CollegeNameA);
}
else if (strAttributeName  ==  convUsers.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convUsers.IdXzMajor);
}
else if (strAttributeName  ==  convUsers.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convUsers.MajorName);
}
else if (strAttributeName  ==  convUsers.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsLeaved);
}
else if (strAttributeName  ==  convUsers.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convUsers.StuIdTeacherId);
}
else if (strAttributeName  ==  convUsers.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convUsers.IdentityId);
}
else if (strAttributeName  ==  convUsers.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convUsers.IdentityDesc);
}
else if (strAttributeName  ==  convUsers.AuditDate)
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(convUsers.AuditDate);
}
else if (strAttributeName  ==  convUsers.AuditUser)
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(convUsers.AuditUser);
}
else if (strAttributeName  ==  convUsers.IsAudit)
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsAudit);
}
else if (strAttributeName  ==  convUsers.IsRegister)
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsRegister);
}
else if (strAttributeName  ==  convUsers.RegisterDate)
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(convUsers.RegisterDate);
}
else if (strAttributeName  ==  convUsers.MobilePhone)
{
mstrMobilePhone = value.ToString();
 AddUpdatedFld(convUsers.MobilePhone);
}
else if (strAttributeName  ==  convUsers.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUsers.UpdDate);
}
else if (strAttributeName  ==  convUsers.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convUsers.UpdUser);
}
else if (strAttributeName  ==  convUsers.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUsers.Memo);
}
else if (strAttributeName  ==  convUsers.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convUsers.UserNameWithUserId);
}
else if (strAttributeName  ==  convUsers.OpenId)
{
mstrOpenId = value.ToString();
 AddUpdatedFld(convUsers.OpenId);
}
else if (strAttributeName  ==  convUsers.AvatarsPicture)
{
mstrAvatarsPicture = value.ToString();
 AddUpdatedFld(convUsers.AvatarsPicture);
}
else if (strAttributeName  ==  convUsers.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(convUsers.Email);
}
else if (strAttributeName  ==  convUsers.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convUsers.PhoneNumber);
}
else if (strAttributeName  ==  convUsers.HeadPic)
{
mstrHeadPic = value.ToString();
 AddUpdatedFld(convUsers.HeadPic);
}
else if (strAttributeName  ==  convUsers.IsGSuser)
{
mbolIsGSuser = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsGSuser);
}
}
}
public object this[int intIndex]
{
get
{
if (convUsers.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUsers.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUsers.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convUsers.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convUsers.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (convUsers.IsGpUser  ==  AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (convUsers.BeginYearMonth  ==  AttributeName[intIndex])
{
return mstrBeginYearMonth;
}
else if (convUsers.EndYearMonth  ==  AttributeName[intIndex])
{
return mstrEndYearMonth;
}
else if (convUsers.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convUsers.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convUsers.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convUsers.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convUsers.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convUsers.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convUsers.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convUsers.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convUsers.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (convUsers.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (convUsers.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (convUsers.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convUsers.AuditDate  ==  AttributeName[intIndex])
{
return mstrAuditDate;
}
else if (convUsers.AuditUser  ==  AttributeName[intIndex])
{
return mstrAuditUser;
}
else if (convUsers.IsAudit  ==  AttributeName[intIndex])
{
return mbolIsAudit;
}
else if (convUsers.IsRegister  ==  AttributeName[intIndex])
{
return mbolIsRegister;
}
else if (convUsers.RegisterDate  ==  AttributeName[intIndex])
{
return mstrRegisterDate;
}
else if (convUsers.MobilePhone  ==  AttributeName[intIndex])
{
return mstrMobilePhone;
}
else if (convUsers.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUsers.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convUsers.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convUsers.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convUsers.OpenId  ==  AttributeName[intIndex])
{
return mstrOpenId;
}
else if (convUsers.AvatarsPicture  ==  AttributeName[intIndex])
{
return mstrAvatarsPicture;
}
else if (convUsers.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (convUsers.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (convUsers.HeadPic  ==  AttributeName[intIndex])
{
return mstrHeadPic;
}
else if (convUsers.IsGSuser  ==  AttributeName[intIndex])
{
return mbolIsGSuser;
}
return null;
}
set
{
if (convUsers.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUsers.UserId);
}
else if (convUsers.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUsers.UserName);
}
else if (convUsers.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convUsers.UserStateId);
}
else if (convUsers.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUsers.UserStateName);
}
else if (convUsers.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(convUsers.Password);
}
else if (convUsers.IsGpUser  ==  AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsGpUser);
}
else if (convUsers.BeginYearMonth  ==  AttributeName[intIndex])
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(convUsers.BeginYearMonth);
}
else if (convUsers.EndYearMonth  ==  AttributeName[intIndex])
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(convUsers.EndYearMonth);
}
else if (convUsers.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convUsers.IdGradeBase);
}
else if (convUsers.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convUsers.GradeBaseName);
}
else if (convUsers.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convUsers.IdXzCollege);
}
else if (convUsers.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convUsers.CollegeId);
}
else if (convUsers.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convUsers.CollegeName);
}
else if (convUsers.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convUsers.CollegeNameA);
}
else if (convUsers.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convUsers.IdXzMajor);
}
else if (convUsers.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convUsers.MajorName);
}
else if (convUsers.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsLeaved);
}
else if (convUsers.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convUsers.StuIdTeacherId);
}
else if (convUsers.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convUsers.IdentityId);
}
else if (convUsers.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convUsers.IdentityDesc);
}
else if (convUsers.AuditDate  ==  AttributeName[intIndex])
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(convUsers.AuditDate);
}
else if (convUsers.AuditUser  ==  AttributeName[intIndex])
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(convUsers.AuditUser);
}
else if (convUsers.IsAudit  ==  AttributeName[intIndex])
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsAudit);
}
else if (convUsers.IsRegister  ==  AttributeName[intIndex])
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsRegister);
}
else if (convUsers.RegisterDate  ==  AttributeName[intIndex])
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(convUsers.RegisterDate);
}
else if (convUsers.MobilePhone  ==  AttributeName[intIndex])
{
mstrMobilePhone = value.ToString();
 AddUpdatedFld(convUsers.MobilePhone);
}
else if (convUsers.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUsers.UpdDate);
}
else if (convUsers.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convUsers.UpdUser);
}
else if (convUsers.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUsers.Memo);
}
else if (convUsers.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convUsers.UserNameWithUserId);
}
else if (convUsers.OpenId  ==  AttributeName[intIndex])
{
mstrOpenId = value.ToString();
 AddUpdatedFld(convUsers.OpenId);
}
else if (convUsers.AvatarsPicture  ==  AttributeName[intIndex])
{
mstrAvatarsPicture = value.ToString();
 AddUpdatedFld(convUsers.AvatarsPicture);
}
else if (convUsers.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(convUsers.Email);
}
else if (convUsers.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convUsers.PhoneNumber);
}
else if (convUsers.HeadPic  ==  AttributeName[intIndex])
{
mstrHeadPic = value.ToString();
 AddUpdatedFld(convUsers.HeadPic);
}
else if (convUsers.IsGSuser  ==  AttributeName[intIndex])
{
mbolIsGSuser = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsGSuser);
}
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
 AddUpdatedFld(convUsers.UserId);
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
 AddUpdatedFld(convUsers.UserName);
}
}
/// <summary>
/// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateId
{
get
{
return mstrUserStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateId = value;
}
else
{
 mstrUserStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.UserStateId);
}
}
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateName
{
get
{
return mstrUserStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateName = value;
}
else
{
 mstrUserStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.UserStateName);
}
}
/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Password
{
get
{
return mstrPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPassword = value;
}
else
{
 mstrPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.Password);
}
}
/// <summary>
/// 是否Gp用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGpUser
{
get
{
return mbolIsGpUser;
}
set
{
 mbolIsGpUser = value;
//记录修改过的字段
 AddUpdatedFld(convUsers.IsGpUser);
}
}
/// <summary>
/// 开始年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BeginYearMonth
{
get
{
return mstrBeginYearMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBeginYearMonth = value;
}
else
{
 mstrBeginYearMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.BeginYearMonth);
}
}
/// <summary>
/// 结束年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndYearMonth
{
get
{
return mstrEndYearMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndYearMonth = value;
}
else
{
 mstrEndYearMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.EndYearMonth);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.IdGradeBase);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.GradeBaseName);
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
 AddUpdatedFld(convUsers.IdXzCollege);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.CollegeId);
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
 AddUpdatedFld(convUsers.CollegeName);
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
 AddUpdatedFld(convUsers.CollegeNameA);
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
 AddUpdatedFld(convUsers.IdXzMajor);
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
 AddUpdatedFld(convUsers.MajorName);
}
}
/// <summary>
/// 是否离开(说明:;字段类型:bit;字段长度:1;是否可空:True)
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
 AddUpdatedFld(convUsers.IsLeaved);
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
 AddUpdatedFld(convUsers.StuIdTeacherId);
}
}
/// <summary>
/// 身份Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityId
{
get
{
return mstrIdentityId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityId = value;
}
else
{
 mstrIdentityId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.IdentityId);
}
}
/// <summary>
/// 身份描述(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityDesc
{
get
{
return mstrIdentityDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityDesc = value;
}
else
{
 mstrIdentityDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.IdentityDesc);
}
}
/// <summary>
/// AuditDate(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AuditDate
{
get
{
return mstrAuditDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuditDate = value;
}
else
{
 mstrAuditDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.AuditDate);
}
}
/// <summary>
/// AuditUser(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AuditUser
{
get
{
return mstrAuditUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuditUser = value;
}
else
{
 mstrAuditUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.AuditUser);
}
}
/// <summary>
/// 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAudit
{
get
{
return mbolIsAudit;
}
set
{
 mbolIsAudit = value;
//记录修改过的字段
 AddUpdatedFld(convUsers.IsAudit);
}
}
/// <summary>
/// IsRegister(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRegister
{
get
{
return mbolIsRegister;
}
set
{
 mbolIsRegister = value;
//记录修改过的字段
 AddUpdatedFld(convUsers.IsRegister);
}
}
/// <summary>
/// RegisterDate(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegisterDate
{
get
{
return mstrRegisterDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegisterDate = value;
}
else
{
 mstrRegisterDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.RegisterDate);
}
}
/// <summary>
/// 手机(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MobilePhone
{
get
{
return mstrMobilePhone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMobilePhone = value;
}
else
{
 mstrMobilePhone = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.MobilePhone);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.UpdDate);
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
 AddUpdatedFld(convUsers.UpdUser);
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
 AddUpdatedFld(convUsers.Memo);
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
 AddUpdatedFld(convUsers.UserNameWithUserId);
}
}
/// <summary>
/// 微信OpenId(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpenId
{
get
{
return mstrOpenId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpenId = value;
}
else
{
 mstrOpenId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.OpenId);
}
}
/// <summary>
/// 虚拟头像(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AvatarsPicture
{
get
{
return mstrAvatarsPicture;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAvatarsPicture = value;
}
else
{
 mstrAvatarsPicture = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.AvatarsPicture);
}
}
/// <summary>
/// 电子邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Email
{
get
{
return mstrEmail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEmail = value;
}
else
{
 mstrEmail = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.Email);
}
}
/// <summary>
/// 电话(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhoneNumber
{
get
{
return mstrPhoneNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhoneNumber = value;
}
else
{
 mstrPhoneNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.PhoneNumber);
}
}
/// <summary>
/// 头像(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HeadPic
{
get
{
return mstrHeadPic;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHeadPic = value;
}
else
{
 mstrHeadPic = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.HeadPic);
}
}
/// <summary>
/// 是否GS用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGSuser
{
get
{
return mbolIsGSuser;
}
set
{
 mbolIsGSuser = value;
//记录修改过的字段
 AddUpdatedFld(convUsers.IsGSuser);
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
  return mstrUserId;
 }
 }
}
 /// <summary>
 /// v用户(vUsers)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUsers
{
public const string _CurrTabName = "vUsers"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "UserName", "UserStateId", "UserStateName", "Password", "IsGpUser", "BeginYearMonth", "EndYearMonth", "IdGradeBase", "GradeBaseName", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorName", "IsLeaved", "StuIdTeacherId", "IdentityId", "IdentityDesc", "AuditDate", "AuditUser", "IsAudit", "IsRegister", "RegisterDate", "MobilePhone", "UpdDate", "UpdUser", "Memo", "UserNameWithUserId", "OpenId", "AvatarsPicture", "Email", "PhoneNumber", "HeadPic", "IsGSuser"};
//以下是属性变量


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
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Password = "Password";    //口令

 /// <summary>
 /// 常量:"IsGpUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGpUser = "IsGpUser";    //是否Gp用户

 /// <summary>
 /// 常量:"BeginYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BeginYearMonth = "BeginYearMonth";    //开始年月

 /// <summary>
 /// 常量:"EndYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndYearMonth = "EndYearMonth";    //结束年月

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

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
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IsLeaved"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeaved = "IsLeaved";    //是否离开

 /// <summary>
 /// 常量:"StuIdTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuIdTeacherId = "StuIdTeacherId";    //学工号

 /// <summary>
 /// 常量:"IdentityId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityId = "IdentityId";    //身份Id

 /// <summary>
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityDesc = "IdentityDesc";    //身份描述

 /// <summary>
 /// 常量:"AuditDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AuditDate = "AuditDate";    //AuditDate

 /// <summary>
 /// 常量:"AuditUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AuditUser = "AuditUser";    //AuditUser

 /// <summary>
 /// 常量:"IsAudit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAudit = "IsAudit";    //是否审核

 /// <summary>
 /// 常量:"IsRegister"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRegister = "IsRegister";    //IsRegister

 /// <summary>
 /// 常量:"RegisterDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegisterDate = "RegisterDate";    //RegisterDate

 /// <summary>
 /// 常量:"MobilePhone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MobilePhone = "MobilePhone";    //手机

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

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
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

 /// <summary>
 /// 常量:"OpenId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenId = "OpenId";    //微信OpenId

 /// <summary>
 /// 常量:"AvatarsPicture"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AvatarsPicture = "AvatarsPicture";    //虚拟头像

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Email = "Email";    //电子邮箱

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //电话

 /// <summary>
 /// 常量:"HeadPic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HeadPic = "HeadPic";    //头像

 /// <summary>
 /// 常量:"IsGSuser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGSuser = "IsGSuser";    //是否GS用户
}

}