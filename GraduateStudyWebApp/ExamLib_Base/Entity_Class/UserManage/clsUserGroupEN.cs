
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserGroupEN
 表名:UserGroup(01120043)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:15
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
 /// 表UserGroup的关键字(GroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GroupId_UserGroup
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGroupId">表关键字</param>
public K_GroupId_UserGroup(string strGroupId)
{
if (IsValid(strGroupId)) Value = strGroupId;
else
{
Value = null;
}
}
private static bool IsValid(string strGroupId)
{
if (string.IsNullOrEmpty(strGroupId) == true) return false;
if (strGroupId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GroupId_UserGroup]类型的对象</returns>
public static implicit operator K_GroupId_UserGroup(string value)
{
return new K_GroupId_UserGroup(value);
}
}
 /// <summary>
 /// 用户组(UserGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserGroupEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"GroupId", "GroupName", "HomePage", "Memo", "GroupType", "RoleID", "UserId"};

protected string mstrGroupId;    //组Id
protected string mstrGroupName;    //组名
protected string mstrHomePage;    //HomePage
protected string mstrMemo;    //备注
protected string mstrGroupType;    //GroupType
protected string mstrRoleID;    //RoleID
protected string mstrUserId;    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserGroupEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGroupId">关键字:组Id</param>
public clsUserGroupEN(string strGroupId)
 {
strGroupId = strGroupId.Replace("'", "''");
if (strGroupId.Length > 8)
{
throw new Exception("在表:UserGroup中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGroupId)  ==  true)
{
throw new Exception("在表:UserGroup中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGroupId = strGroupId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupId");
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
if (strAttributeName  ==  conUserGroup.GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  conUserGroup.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  conUserGroup.HomePage)
{
return mstrHomePage;
}
else if (strAttributeName  ==  conUserGroup.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conUserGroup.GroupType)
{
return mstrGroupType;
}
else if (strAttributeName  ==  conUserGroup.RoleID)
{
return mstrRoleID;
}
else if (strAttributeName  ==  conUserGroup.UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conUserGroup.GroupId)
{
mstrGroupId = value.ToString();
 AddUpdatedFld(conUserGroup.GroupId);
}
else if (strAttributeName  ==  conUserGroup.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conUserGroup.GroupName);
}
else if (strAttributeName  ==  conUserGroup.HomePage)
{
mstrHomePage = value.ToString();
 AddUpdatedFld(conUserGroup.HomePage);
}
else if (strAttributeName  ==  conUserGroup.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserGroup.Memo);
}
else if (strAttributeName  ==  conUserGroup.GroupType)
{
mstrGroupType = value.ToString();
 AddUpdatedFld(conUserGroup.GroupType);
}
else if (strAttributeName  ==  conUserGroup.RoleID)
{
mstrRoleID = value.ToString();
 AddUpdatedFld(conUserGroup.RoleID);
}
else if (strAttributeName  ==  conUserGroup.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserGroup.UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserGroup.GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (conUserGroup.GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (conUserGroup.HomePage  ==  AttributeName[intIndex])
{
return mstrHomePage;
}
else if (conUserGroup.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conUserGroup.GroupType  ==  AttributeName[intIndex])
{
return mstrGroupType;
}
else if (conUserGroup.RoleID  ==  AttributeName[intIndex])
{
return mstrRoleID;
}
else if (conUserGroup.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (conUserGroup.GroupId  ==  AttributeName[intIndex])
{
mstrGroupId = value.ToString();
 AddUpdatedFld(conUserGroup.GroupId);
}
else if (conUserGroup.GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conUserGroup.GroupName);
}
else if (conUserGroup.HomePage  ==  AttributeName[intIndex])
{
mstrHomePage = value.ToString();
 AddUpdatedFld(conUserGroup.HomePage);
}
else if (conUserGroup.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserGroup.Memo);
}
else if (conUserGroup.GroupType  ==  AttributeName[intIndex])
{
mstrGroupType = value.ToString();
 AddUpdatedFld(conUserGroup.GroupType);
}
else if (conUserGroup.RoleID  ==  AttributeName[intIndex])
{
mstrRoleID = value.ToString();
 AddUpdatedFld(conUserGroup.RoleID);
}
else if (conUserGroup.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserGroup.UserId);
}
}
}

/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupId
{
get
{
return mstrGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupId = value;
}
else
{
 mstrGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserGroup.GroupId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserGroup.GroupName);
}
}
/// <summary>
/// HomePage(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomePage
{
get
{
return mstrHomePage;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomePage = value;
}
else
{
 mstrHomePage = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserGroup.HomePage);
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
 AddUpdatedFld(conUserGroup.Memo);
}
}
/// <summary>
/// GroupType(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupType
{
get
{
return mstrGroupType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupType = value;
}
else
{
 mstrGroupType = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserGroup.GroupType);
}
}
/// <summary>
/// RoleID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleID
{
get
{
return mstrRoleID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleID = value;
}
else
{
 mstrRoleID = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserGroup.RoleID);
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
 AddUpdatedFld(conUserGroup.UserId);
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
  return mstrGroupId;
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
  return mstrGroupName;
 }
 }
}
 /// <summary>
 /// 用户组(UserGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserGroup
{
public const string _CurrTabName = "UserGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GroupId", "GroupName", "HomePage", "Memo", "GroupType", "RoleID", "UserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"GroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupId = "GroupId";    //组Id

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"HomePage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomePage = "HomePage";    //HomePage

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"GroupType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupType = "GroupType";    //GroupType

 /// <summary>
 /// 常量:"RoleID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleID = "RoleID";    //RoleID

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID
}

}