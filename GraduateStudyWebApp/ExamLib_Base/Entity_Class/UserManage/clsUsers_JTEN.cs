
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsers_JTEN
 表名:Users_JT(01120227)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:48
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
 /// 表Users_JT的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_Users_JT
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
public K_UserId_Users_JT(string strUserId)
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
 /// <returns>返回:[K_UserId_Users_JT]类型的对象</returns>
public static implicit operator K_UserId_Users_JT(string value)
{
return new K_UserId_Users_JT(value);
}
}
 /// <summary>
 /// 用户表_交通(Users_JT)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUsers_JTEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Users_JT"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"UserId", "SiteName", "JobCategoryId", "ManagedDepartmentId", "IDNumber", "UpdDate", "UpdUser", "Memo"};

protected string mstrUserId;    //用户ID
protected string mstrSiteName;    //工地名称
protected string mstrJobCategoryId;    //岗位类别Id
protected string mstrManagedDepartmentId;    //管理的部门Id
protected string mstrIDNumber;    //身份证号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUsers_JTEN()
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
public clsUsers_JTEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:Users_JT中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:Users_JT中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conUsers_JT.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUsers_JT.SiteName)
{
return mstrSiteName;
}
else if (strAttributeName  ==  conUsers_JT.JobCategoryId)
{
return mstrJobCategoryId;
}
else if (strAttributeName  ==  conUsers_JT.ManagedDepartmentId)
{
return mstrManagedDepartmentId;
}
else if (strAttributeName  ==  conUsers_JT.IDNumber)
{
return mstrIDNumber;
}
else if (strAttributeName  ==  conUsers_JT.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUsers_JT.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conUsers_JT.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUsers_JT.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUsers_JT.UserId);
}
else if (strAttributeName  ==  conUsers_JT.SiteName)
{
mstrSiteName = value.ToString();
 AddUpdatedFld(conUsers_JT.SiteName);
}
else if (strAttributeName  ==  conUsers_JT.JobCategoryId)
{
mstrJobCategoryId = value.ToString();
 AddUpdatedFld(conUsers_JT.JobCategoryId);
}
else if (strAttributeName  ==  conUsers_JT.ManagedDepartmentId)
{
mstrManagedDepartmentId = value.ToString();
 AddUpdatedFld(conUsers_JT.ManagedDepartmentId);
}
else if (strAttributeName  ==  conUsers_JT.IDNumber)
{
mstrIDNumber = value.ToString();
 AddUpdatedFld(conUsers_JT.IDNumber);
}
else if (strAttributeName  ==  conUsers_JT.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUsers_JT.UpdDate);
}
else if (strAttributeName  ==  conUsers_JT.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUsers_JT.UpdUser);
}
else if (strAttributeName  ==  conUsers_JT.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUsers_JT.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUsers_JT.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUsers_JT.SiteName  ==  AttributeName[intIndex])
{
return mstrSiteName;
}
else if (conUsers_JT.JobCategoryId  ==  AttributeName[intIndex])
{
return mstrJobCategoryId;
}
else if (conUsers_JT.ManagedDepartmentId  ==  AttributeName[intIndex])
{
return mstrManagedDepartmentId;
}
else if (conUsers_JT.IDNumber  ==  AttributeName[intIndex])
{
return mstrIDNumber;
}
else if (conUsers_JT.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUsers_JT.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conUsers_JT.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUsers_JT.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUsers_JT.UserId);
}
else if (conUsers_JT.SiteName  ==  AttributeName[intIndex])
{
mstrSiteName = value.ToString();
 AddUpdatedFld(conUsers_JT.SiteName);
}
else if (conUsers_JT.JobCategoryId  ==  AttributeName[intIndex])
{
mstrJobCategoryId = value.ToString();
 AddUpdatedFld(conUsers_JT.JobCategoryId);
}
else if (conUsers_JT.ManagedDepartmentId  ==  AttributeName[intIndex])
{
mstrManagedDepartmentId = value.ToString();
 AddUpdatedFld(conUsers_JT.ManagedDepartmentId);
}
else if (conUsers_JT.IDNumber  ==  AttributeName[intIndex])
{
mstrIDNumber = value.ToString();
 AddUpdatedFld(conUsers_JT.IDNumber);
}
else if (conUsers_JT.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUsers_JT.UpdDate);
}
else if (conUsers_JT.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUsers_JT.UpdUser);
}
else if (conUsers_JT.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUsers_JT.Memo);
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
 AddUpdatedFld(conUsers_JT.UserId);
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
 AddUpdatedFld(conUsers_JT.SiteName);
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
 AddUpdatedFld(conUsers_JT.JobCategoryId);
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
 AddUpdatedFld(conUsers_JT.ManagedDepartmentId);
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
 AddUpdatedFld(conUsers_JT.IDNumber);
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
 AddUpdatedFld(conUsers_JT.UpdDate);
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
 AddUpdatedFld(conUsers_JT.UpdUser);
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
 AddUpdatedFld(conUsers_JT.Memo);
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
 /// 用户表_交通(Users_JT)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUsers_JT
{
public const string _CurrTabName = "Users_JT"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "SiteName", "JobCategoryId", "ManagedDepartmentId", "IDNumber", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"ManagedDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManagedDepartmentId = "ManagedDepartmentId";    //管理的部门Id

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