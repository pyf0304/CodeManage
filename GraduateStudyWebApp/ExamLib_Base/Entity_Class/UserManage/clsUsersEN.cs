
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersEN
 表名:Users(01120034)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表Users的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_Users
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
public K_UserId_Users(string strUserId)
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
 /// <returns>返回:[K_UserId_Users]类型的对象</returns>
public static implicit operator K_UserId_Users(string value)
{
return new K_UserId_Users(value);
}
}
 /// <summary>
 /// 用户(Users)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUsersEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Users"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "UserStateId", "Password", "IsGpUser", "IdSchool", "BeginYearMonth", "EndYearMonth", "IdGradeBase", "IdGrade", "IdXzCollege", "IdXzMajor", "IsLeaved", "StuIdTeacherId", "Email", "PhoneNumber", "AvatarsPicture", "IdentityId", "AuditDate", "AuditUser", "IsAudit", "IsRegister", "RegisterDate", "MobilePhone", "OpenId", "UpdDate", "UpdUser", "Memo", "HeadPic", "IsGSuser"};

protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门Id
protected string mstrUserStateId;    //用户状态Id
protected string mstrPassword;    //口令
protected bool mbolIsGpUser;    //是否Gp用户
protected string mstrIdSchool;    //学校流水号
protected string mstrBeginYearMonth;    //开始年月
protected string mstrEndYearMonth;    //结束年月
protected string mstrIdGradeBase;    //年级流水号
protected string mstrIdGrade;    //年级流水号
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected bool mbolIsLeaved;    //是否离开
protected string mstrStuIdTeacherId;    //学工号
protected string mstrEmail;    //电子邮箱
protected string mstrPhoneNumber;    //电话
protected string mstrAvatarsPicture;    //虚拟头像
protected string mstrIdentityId;    //身份Id
protected string mstrAuditDate;    //AuditDate
protected string mstrAuditUser;    //AuditUser
protected bool mbolIsAudit;    //是否审核
protected bool mbolIsRegister;    //IsRegister
protected string mstrRegisterDate;    //RegisterDate
protected string mstrMobilePhone;    //手机
protected string mstrOpenId;    //微信OpenId
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrHeadPic;    //头像
protected bool mbolIsGSuser;    //是否GS用户

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUsersEN()
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
public clsUsersEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:Users中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:Users中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conUsers.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUsers.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  conUsers.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  conUsers.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  conUsers.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  conUsers.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  conUsers.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conUsers.BeginYearMonth)
{
return mstrBeginYearMonth;
}
else if (strAttributeName  ==  conUsers.EndYearMonth)
{
return mstrEndYearMonth;
}
else if (strAttributeName  ==  conUsers.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conUsers.IdGrade)
{
return mstrIdGrade;
}
else if (strAttributeName  ==  conUsers.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conUsers.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conUsers.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  conUsers.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  conUsers.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  conUsers.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  conUsers.AvatarsPicture)
{
return mstrAvatarsPicture;
}
else if (strAttributeName  ==  conUsers.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  conUsers.AuditDate)
{
return mstrAuditDate;
}
else if (strAttributeName  ==  conUsers.AuditUser)
{
return mstrAuditUser;
}
else if (strAttributeName  ==  conUsers.IsAudit)
{
return mbolIsAudit;
}
else if (strAttributeName  ==  conUsers.IsRegister)
{
return mbolIsRegister;
}
else if (strAttributeName  ==  conUsers.RegisterDate)
{
return mstrRegisterDate;
}
else if (strAttributeName  ==  conUsers.MobilePhone)
{
return mstrMobilePhone;
}
else if (strAttributeName  ==  conUsers.OpenId)
{
return mstrOpenId;
}
else if (strAttributeName  ==  conUsers.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUsers.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conUsers.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conUsers.HeadPic)
{
return mstrHeadPic;
}
else if (strAttributeName  ==  conUsers.IsGSuser)
{
return mbolIsGSuser;
}
return null;
}
set
{
if (strAttributeName  ==  conUsers.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUsers.UserId);
}
else if (strAttributeName  ==  conUsers.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(conUsers.UserName);
}
else if (strAttributeName  ==  conUsers.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conUsers.DepartmentId);
}
else if (strAttributeName  ==  conUsers.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conUsers.UserStateId);
}
else if (strAttributeName  ==  conUsers.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(conUsers.Password);
}
else if (strAttributeName  ==  conUsers.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsGpUser);
}
else if (strAttributeName  ==  conUsers.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conUsers.IdSchool);
}
else if (strAttributeName  ==  conUsers.BeginYearMonth)
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(conUsers.BeginYearMonth);
}
else if (strAttributeName  ==  conUsers.EndYearMonth)
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(conUsers.EndYearMonth);
}
else if (strAttributeName  ==  conUsers.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conUsers.IdGradeBase);
}
else if (strAttributeName  ==  conUsers.IdGrade)
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conUsers.IdGrade);
}
else if (strAttributeName  ==  conUsers.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conUsers.IdXzCollege);
}
else if (strAttributeName  ==  conUsers.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conUsers.IdXzMajor);
}
else if (strAttributeName  ==  conUsers.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsLeaved);
}
else if (strAttributeName  ==  conUsers.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(conUsers.StuIdTeacherId);
}
else if (strAttributeName  ==  conUsers.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(conUsers.Email);
}
else if (strAttributeName  ==  conUsers.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conUsers.PhoneNumber);
}
else if (strAttributeName  ==  conUsers.AvatarsPicture)
{
mstrAvatarsPicture = value.ToString();
 AddUpdatedFld(conUsers.AvatarsPicture);
}
else if (strAttributeName  ==  conUsers.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conUsers.IdentityId);
}
else if (strAttributeName  ==  conUsers.AuditDate)
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(conUsers.AuditDate);
}
else if (strAttributeName  ==  conUsers.AuditUser)
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(conUsers.AuditUser);
}
else if (strAttributeName  ==  conUsers.IsAudit)
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsAudit);
}
else if (strAttributeName  ==  conUsers.IsRegister)
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsRegister);
}
else if (strAttributeName  ==  conUsers.RegisterDate)
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(conUsers.RegisterDate);
}
else if (strAttributeName  ==  conUsers.MobilePhone)
{
mstrMobilePhone = value.ToString();
 AddUpdatedFld(conUsers.MobilePhone);
}
else if (strAttributeName  ==  conUsers.OpenId)
{
mstrOpenId = value.ToString();
 AddUpdatedFld(conUsers.OpenId);
}
else if (strAttributeName  ==  conUsers.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUsers.UpdDate);
}
else if (strAttributeName  ==  conUsers.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUsers.UpdUser);
}
else if (strAttributeName  ==  conUsers.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUsers.Memo);
}
else if (strAttributeName  ==  conUsers.HeadPic)
{
mstrHeadPic = value.ToString();
 AddUpdatedFld(conUsers.HeadPic);
}
else if (strAttributeName  ==  conUsers.IsGSuser)
{
mbolIsGSuser = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsGSuser);
}
}
}
public object this[int intIndex]
{
get
{
if (conUsers.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUsers.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (conUsers.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (conUsers.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (conUsers.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (conUsers.IsGpUser  ==  AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (conUsers.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conUsers.BeginYearMonth  ==  AttributeName[intIndex])
{
return mstrBeginYearMonth;
}
else if (conUsers.EndYearMonth  ==  AttributeName[intIndex])
{
return mstrEndYearMonth;
}
else if (conUsers.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conUsers.IdGrade  ==  AttributeName[intIndex])
{
return mstrIdGrade;
}
else if (conUsers.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conUsers.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conUsers.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (conUsers.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (conUsers.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (conUsers.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (conUsers.AvatarsPicture  ==  AttributeName[intIndex])
{
return mstrAvatarsPicture;
}
else if (conUsers.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (conUsers.AuditDate  ==  AttributeName[intIndex])
{
return mstrAuditDate;
}
else if (conUsers.AuditUser  ==  AttributeName[intIndex])
{
return mstrAuditUser;
}
else if (conUsers.IsAudit  ==  AttributeName[intIndex])
{
return mbolIsAudit;
}
else if (conUsers.IsRegister  ==  AttributeName[intIndex])
{
return mbolIsRegister;
}
else if (conUsers.RegisterDate  ==  AttributeName[intIndex])
{
return mstrRegisterDate;
}
else if (conUsers.MobilePhone  ==  AttributeName[intIndex])
{
return mstrMobilePhone;
}
else if (conUsers.OpenId  ==  AttributeName[intIndex])
{
return mstrOpenId;
}
else if (conUsers.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUsers.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conUsers.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conUsers.HeadPic  ==  AttributeName[intIndex])
{
return mstrHeadPic;
}
else if (conUsers.IsGSuser  ==  AttributeName[intIndex])
{
return mbolIsGSuser;
}
return null;
}
set
{
if (conUsers.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUsers.UserId);
}
else if (conUsers.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(conUsers.UserName);
}
else if (conUsers.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conUsers.DepartmentId);
}
else if (conUsers.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conUsers.UserStateId);
}
else if (conUsers.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(conUsers.Password);
}
else if (conUsers.IsGpUser  ==  AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsGpUser);
}
else if (conUsers.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conUsers.IdSchool);
}
else if (conUsers.BeginYearMonth  ==  AttributeName[intIndex])
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(conUsers.BeginYearMonth);
}
else if (conUsers.EndYearMonth  ==  AttributeName[intIndex])
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(conUsers.EndYearMonth);
}
else if (conUsers.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conUsers.IdGradeBase);
}
else if (conUsers.IdGrade  ==  AttributeName[intIndex])
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conUsers.IdGrade);
}
else if (conUsers.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conUsers.IdXzCollege);
}
else if (conUsers.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conUsers.IdXzMajor);
}
else if (conUsers.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsLeaved);
}
else if (conUsers.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(conUsers.StuIdTeacherId);
}
else if (conUsers.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(conUsers.Email);
}
else if (conUsers.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conUsers.PhoneNumber);
}
else if (conUsers.AvatarsPicture  ==  AttributeName[intIndex])
{
mstrAvatarsPicture = value.ToString();
 AddUpdatedFld(conUsers.AvatarsPicture);
}
else if (conUsers.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conUsers.IdentityId);
}
else if (conUsers.AuditDate  ==  AttributeName[intIndex])
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(conUsers.AuditDate);
}
else if (conUsers.AuditUser  ==  AttributeName[intIndex])
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(conUsers.AuditUser);
}
else if (conUsers.IsAudit  ==  AttributeName[intIndex])
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsAudit);
}
else if (conUsers.IsRegister  ==  AttributeName[intIndex])
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsRegister);
}
else if (conUsers.RegisterDate  ==  AttributeName[intIndex])
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(conUsers.RegisterDate);
}
else if (conUsers.MobilePhone  ==  AttributeName[intIndex])
{
mstrMobilePhone = value.ToString();
 AddUpdatedFld(conUsers.MobilePhone);
}
else if (conUsers.OpenId  ==  AttributeName[intIndex])
{
mstrOpenId = value.ToString();
 AddUpdatedFld(conUsers.OpenId);
}
else if (conUsers.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUsers.UpdDate);
}
else if (conUsers.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUsers.UpdUser);
}
else if (conUsers.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUsers.Memo);
}
else if (conUsers.HeadPic  ==  AttributeName[intIndex])
{
mstrHeadPic = value.ToString();
 AddUpdatedFld(conUsers.HeadPic);
}
else if (conUsers.IsGSuser  ==  AttributeName[intIndex])
{
mbolIsGSuser = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsGSuser);
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
 AddUpdatedFld(conUsers.UserId);
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
 AddUpdatedFld(conUsers.UserName);
}
}
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.DepartmentId);
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
 AddUpdatedFld(conUsers.UserStateId);
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
 AddUpdatedFld(conUsers.Password);
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
 AddUpdatedFld(conUsers.IsGpUser);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.IdSchool);
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
 AddUpdatedFld(conUsers.BeginYearMonth);
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
 AddUpdatedFld(conUsers.EndYearMonth);
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
 AddUpdatedFld(conUsers.IdGradeBase);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGrade
{
get
{
return mstrIdGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGrade = value;
}
else
{
 mstrIdGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.IdGrade);
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
 AddUpdatedFld(conUsers.IdXzCollege);
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
 AddUpdatedFld(conUsers.IdXzMajor);
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
 AddUpdatedFld(conUsers.IsLeaved);
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
 AddUpdatedFld(conUsers.StuIdTeacherId);
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
 AddUpdatedFld(conUsers.Email);
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
 AddUpdatedFld(conUsers.PhoneNumber);
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
 AddUpdatedFld(conUsers.AvatarsPicture);
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
 AddUpdatedFld(conUsers.IdentityId);
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
 AddUpdatedFld(conUsers.AuditDate);
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
 AddUpdatedFld(conUsers.AuditUser);
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
 AddUpdatedFld(conUsers.IsAudit);
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
 AddUpdatedFld(conUsers.IsRegister);
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
 AddUpdatedFld(conUsers.RegisterDate);
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
 AddUpdatedFld(conUsers.MobilePhone);
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
 AddUpdatedFld(conUsers.OpenId);
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
 AddUpdatedFld(conUsers.UpdDate);
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
 AddUpdatedFld(conUsers.UpdUser);
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
 AddUpdatedFld(conUsers.Memo);
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
 AddUpdatedFld(conUsers.HeadPic);
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
 AddUpdatedFld(conUsers.IsGSuser);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrUserName;
 }
 }
}
 /// <summary>
 /// 用户(Users)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUsers
{
public const string _CurrTabName = "Users"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "UserStateId", "Password", "IsGpUser", "IdSchool", "BeginYearMonth", "EndYearMonth", "IdGradeBase", "IdGrade", "IdXzCollege", "IdXzMajor", "IsLeaved", "StuIdTeacherId", "Email", "PhoneNumber", "AvatarsPicture", "IdentityId", "AuditDate", "AuditUser", "IsAudit", "IsRegister", "RegisterDate", "MobilePhone", "OpenId", "UpdDate", "UpdUser", "Memo", "HeadPic", "IsGSuser"};
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
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态Id

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
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

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
 /// 常量:"IdGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGrade = "IdGrade";    //年级流水号

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
 /// 常量:"AvatarsPicture"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AvatarsPicture = "AvatarsPicture";    //虚拟头像

 /// <summary>
 /// 常量:"IdentityId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityId = "IdentityId";    //身份Id

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
 /// 常量:"OpenId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenId = "OpenId";    //微信OpenId

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