
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsers_JTEN
 表名:vUsers_JT(01120230)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vUsers_JT的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_vUsers_JT
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
public K_UserId_vUsers_JT(string strUserId)
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
 /// <returns>返回:[K_UserId_vUsers_JT]类型的对象</returns>
public static implicit operator K_UserId_vUsers_JT(string value)
{
return new K_UserId_vUsers_JT(value);
}
}
 /// <summary>
 /// v用户_JT(vUsers_JT)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUsers_JTEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUsers_JT"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 19;
public static string[] AttributeName = new string[] {"UserId", "UserName", "Password", "PhoneNumber", "AuditDate", "AuditUser", "IsAudit", "IsRegister", "RegisterDate", "MobilePhone", "SiteName", "JobCategoryId", "JobCategoryName", "ManagedDepartmentId", "ManagedDepartmentName", "IDNumber", "UpdDate", "UpdUser", "Memo"};

protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrPassword;    //Password
protected string mstrPhoneNumber;    //PhoneNumber
protected string mstrAuditDate;    //AuditDate
protected string mstrAuditUser;    //AuditUser
protected bool mbolIsAudit;    //是否审核
protected bool mbolIsRegister;    //IsRegister
protected string mstrRegisterDate;    //RegisterDate
protected string mstrMobilePhone;    //手机
protected string mstrSiteName;    //工地名称
protected string mstrJobCategoryId;    //岗位类别Id
protected string mstrJobCategoryName;    //岗位类别名
protected string mstrManagedDepartmentId;    //管理的部门Id
protected string mstrManagedDepartmentName;    //管理的部门名
protected string mstrIDNumber;    //身份证号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvUsers_JTEN()
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
public clsvUsers_JTEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:vUsers_JT中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:vUsers_JT中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convUsers_JT.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUsers_JT.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUsers_JT.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  convUsers_JT.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  convUsers_JT.AuditDate)
{
return mstrAuditDate;
}
else if (strAttributeName  ==  convUsers_JT.AuditUser)
{
return mstrAuditUser;
}
else if (strAttributeName  ==  convUsers_JT.IsAudit)
{
return mbolIsAudit;
}
else if (strAttributeName  ==  convUsers_JT.IsRegister)
{
return mbolIsRegister;
}
else if (strAttributeName  ==  convUsers_JT.RegisterDate)
{
return mstrRegisterDate;
}
else if (strAttributeName  ==  convUsers_JT.MobilePhone)
{
return mstrMobilePhone;
}
else if (strAttributeName  ==  convUsers_JT.SiteName)
{
return mstrSiteName;
}
else if (strAttributeName  ==  convUsers_JT.JobCategoryId)
{
return mstrJobCategoryId;
}
else if (strAttributeName  ==  convUsers_JT.JobCategoryName)
{
return mstrJobCategoryName;
}
else if (strAttributeName  ==  convUsers_JT.ManagedDepartmentId)
{
return mstrManagedDepartmentId;
}
else if (strAttributeName  ==  convUsers_JT.ManagedDepartmentName)
{
return mstrManagedDepartmentName;
}
else if (strAttributeName  ==  convUsers_JT.IDNumber)
{
return mstrIDNumber;
}
else if (strAttributeName  ==  convUsers_JT.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUsers_JT.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convUsers_JT.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convUsers_JT.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUsers_JT.UserId);
}
else if (strAttributeName  ==  convUsers_JT.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUsers_JT.UserName);
}
else if (strAttributeName  ==  convUsers_JT.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(convUsers_JT.Password);
}
else if (strAttributeName  ==  convUsers_JT.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convUsers_JT.PhoneNumber);
}
else if (strAttributeName  ==  convUsers_JT.AuditDate)
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(convUsers_JT.AuditDate);
}
else if (strAttributeName  ==  convUsers_JT.AuditUser)
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(convUsers_JT.AuditUser);
}
else if (strAttributeName  ==  convUsers_JT.IsAudit)
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers_JT.IsAudit);
}
else if (strAttributeName  ==  convUsers_JT.IsRegister)
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers_JT.IsRegister);
}
else if (strAttributeName  ==  convUsers_JT.RegisterDate)
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(convUsers_JT.RegisterDate);
}
else if (strAttributeName  ==  convUsers_JT.MobilePhone)
{
mstrMobilePhone = value.ToString();
 AddUpdatedFld(convUsers_JT.MobilePhone);
}
else if (strAttributeName  ==  convUsers_JT.SiteName)
{
mstrSiteName = value.ToString();
 AddUpdatedFld(convUsers_JT.SiteName);
}
else if (strAttributeName  ==  convUsers_JT.JobCategoryId)
{
mstrJobCategoryId = value.ToString();
 AddUpdatedFld(convUsers_JT.JobCategoryId);
}
else if (strAttributeName  ==  convUsers_JT.JobCategoryName)
{
mstrJobCategoryName = value.ToString();
 AddUpdatedFld(convUsers_JT.JobCategoryName);
}
else if (strAttributeName  ==  convUsers_JT.ManagedDepartmentId)
{
mstrManagedDepartmentId = value.ToString();
 AddUpdatedFld(convUsers_JT.ManagedDepartmentId);
}
else if (strAttributeName  ==  convUsers_JT.ManagedDepartmentName)
{
mstrManagedDepartmentName = value.ToString();
 AddUpdatedFld(convUsers_JT.ManagedDepartmentName);
}
else if (strAttributeName  ==  convUsers_JT.IDNumber)
{
mstrIDNumber = value.ToString();
 AddUpdatedFld(convUsers_JT.IDNumber);
}
else if (strAttributeName  ==  convUsers_JT.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUsers_JT.UpdDate);
}
else if (strAttributeName  ==  convUsers_JT.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convUsers_JT.UpdUser);
}
else if (strAttributeName  ==  convUsers_JT.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUsers_JT.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convUsers_JT.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUsers_JT.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUsers_JT.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (convUsers_JT.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (convUsers_JT.AuditDate  ==  AttributeName[intIndex])
{
return mstrAuditDate;
}
else if (convUsers_JT.AuditUser  ==  AttributeName[intIndex])
{
return mstrAuditUser;
}
else if (convUsers_JT.IsAudit  ==  AttributeName[intIndex])
{
return mbolIsAudit;
}
else if (convUsers_JT.IsRegister  ==  AttributeName[intIndex])
{
return mbolIsRegister;
}
else if (convUsers_JT.RegisterDate  ==  AttributeName[intIndex])
{
return mstrRegisterDate;
}
else if (convUsers_JT.MobilePhone  ==  AttributeName[intIndex])
{
return mstrMobilePhone;
}
else if (convUsers_JT.SiteName  ==  AttributeName[intIndex])
{
return mstrSiteName;
}
else if (convUsers_JT.JobCategoryId  ==  AttributeName[intIndex])
{
return mstrJobCategoryId;
}
else if (convUsers_JT.JobCategoryName  ==  AttributeName[intIndex])
{
return mstrJobCategoryName;
}
else if (convUsers_JT.ManagedDepartmentId  ==  AttributeName[intIndex])
{
return mstrManagedDepartmentId;
}
else if (convUsers_JT.ManagedDepartmentName  ==  AttributeName[intIndex])
{
return mstrManagedDepartmentName;
}
else if (convUsers_JT.IDNumber  ==  AttributeName[intIndex])
{
return mstrIDNumber;
}
else if (convUsers_JT.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUsers_JT.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convUsers_JT.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convUsers_JT.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUsers_JT.UserId);
}
else if (convUsers_JT.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUsers_JT.UserName);
}
else if (convUsers_JT.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(convUsers_JT.Password);
}
else if (convUsers_JT.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convUsers_JT.PhoneNumber);
}
else if (convUsers_JT.AuditDate  ==  AttributeName[intIndex])
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(convUsers_JT.AuditDate);
}
else if (convUsers_JT.AuditUser  ==  AttributeName[intIndex])
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(convUsers_JT.AuditUser);
}
else if (convUsers_JT.IsAudit  ==  AttributeName[intIndex])
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers_JT.IsAudit);
}
else if (convUsers_JT.IsRegister  ==  AttributeName[intIndex])
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers_JT.IsRegister);
}
else if (convUsers_JT.RegisterDate  ==  AttributeName[intIndex])
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(convUsers_JT.RegisterDate);
}
else if (convUsers_JT.MobilePhone  ==  AttributeName[intIndex])
{
mstrMobilePhone = value.ToString();
 AddUpdatedFld(convUsers_JT.MobilePhone);
}
else if (convUsers_JT.SiteName  ==  AttributeName[intIndex])
{
mstrSiteName = value.ToString();
 AddUpdatedFld(convUsers_JT.SiteName);
}
else if (convUsers_JT.JobCategoryId  ==  AttributeName[intIndex])
{
mstrJobCategoryId = value.ToString();
 AddUpdatedFld(convUsers_JT.JobCategoryId);
}
else if (convUsers_JT.JobCategoryName  ==  AttributeName[intIndex])
{
mstrJobCategoryName = value.ToString();
 AddUpdatedFld(convUsers_JT.JobCategoryName);
}
else if (convUsers_JT.ManagedDepartmentId  ==  AttributeName[intIndex])
{
mstrManagedDepartmentId = value.ToString();
 AddUpdatedFld(convUsers_JT.ManagedDepartmentId);
}
else if (convUsers_JT.ManagedDepartmentName  ==  AttributeName[intIndex])
{
mstrManagedDepartmentName = value.ToString();
 AddUpdatedFld(convUsers_JT.ManagedDepartmentName);
}
else if (convUsers_JT.IDNumber  ==  AttributeName[intIndex])
{
mstrIDNumber = value.ToString();
 AddUpdatedFld(convUsers_JT.IDNumber);
}
else if (convUsers_JT.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUsers_JT.UpdDate);
}
else if (convUsers_JT.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convUsers_JT.UpdUser);
}
else if (convUsers_JT.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUsers_JT.Memo);
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
 AddUpdatedFld(convUsers_JT.UserId);
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
 AddUpdatedFld(convUsers_JT.UserName);
}
}
/// <summary>
/// Password(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(convUsers_JT.Password);
}
}
/// <summary>
/// PhoneNumber(说明:;字段类型:varchar;字段长度:15;是否可空:True)
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
 AddUpdatedFld(convUsers_JT.PhoneNumber);
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
 AddUpdatedFld(convUsers_JT.AuditDate);
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
 AddUpdatedFld(convUsers_JT.AuditUser);
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
 AddUpdatedFld(convUsers_JT.IsAudit);
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
 AddUpdatedFld(convUsers_JT.IsRegister);
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
 AddUpdatedFld(convUsers_JT.RegisterDate);
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
 AddUpdatedFld(convUsers_JT.MobilePhone);
}
}
/// <summary>
/// 工地名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteName
{
get
{
return mstrSiteName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteName = value;
}
else
{
 mstrSiteName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers_JT.SiteName);
}
}
/// <summary>
/// 岗位类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JobCategoryId
{
get
{
return mstrJobCategoryId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJobCategoryId = value;
}
else
{
 mstrJobCategoryId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers_JT.JobCategoryId);
}
}
/// <summary>
/// 岗位类别名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JobCategoryName
{
get
{
return mstrJobCategoryName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJobCategoryName = value;
}
else
{
 mstrJobCategoryName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers_JT.JobCategoryName);
}
}
/// <summary>
/// 管理的部门Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ManagedDepartmentId
{
get
{
return mstrManagedDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrManagedDepartmentId = value;
}
else
{
 mstrManagedDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers_JT.ManagedDepartmentId);
}
}
/// <summary>
/// 管理的部门名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ManagedDepartmentName
{
get
{
return mstrManagedDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrManagedDepartmentName = value;
}
else
{
 mstrManagedDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers_JT.ManagedDepartmentName);
}
}
/// <summary>
/// 身份证号(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IDNumber
{
get
{
return mstrIDNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIDNumber = value;
}
else
{
 mstrIDNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers_JT.IDNumber);
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
 AddUpdatedFld(convUsers_JT.UpdDate);
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
 AddUpdatedFld(convUsers_JT.UpdUser);
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
 AddUpdatedFld(convUsers_JT.Memo);
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
 /// v用户_JT(vUsers_JT)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUsers_JT
{
public const string _CurrTabName = "vUsers_JT"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "UserName", "Password", "PhoneNumber", "AuditDate", "AuditUser", "IsAudit", "IsRegister", "RegisterDate", "MobilePhone", "SiteName", "JobCategoryId", "JobCategoryName", "ManagedDepartmentId", "ManagedDepartmentName", "IDNumber", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Password = "Password";    //Password

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //PhoneNumber

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
 /// 常量:"SiteName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteName = "SiteName";    //工地名称

 /// <summary>
 /// 常量:"JobCategoryId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JobCategoryId = "JobCategoryId";    //岗位类别Id

 /// <summary>
 /// 常量:"JobCategoryName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JobCategoryName = "JobCategoryName";    //岗位类别名

 /// <summary>
 /// 常量:"ManagedDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManagedDepartmentId = "ManagedDepartmentId";    //管理的部门Id

 /// <summary>
 /// 常量:"ManagedDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManagedDepartmentName = "ManagedDepartmentName";    //管理的部门名

 /// <summary>
 /// 常量:"IDNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IDNumber = "IDNumber";    //身份证号

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
}

}