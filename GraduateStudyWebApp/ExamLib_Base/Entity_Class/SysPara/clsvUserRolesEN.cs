
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserRolesEN
 表名:vUserRoles(01120026)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表vUserRoles的关键字(RoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RoleId_vUserRoles
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRoleId">表关键字</param>
public K_RoleId_vUserRoles(string strRoleId)
{
if (IsValid(strRoleId)) Value = strRoleId;
else
{
Value = null;
}
}
private static bool IsValid(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return false;
if (strRoleId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RoleId_vUserRoles]类型的对象</returns>
public static implicit operator K_RoleId_vUserRoles(string value)
{
return new K_RoleId_vUserRoles(value);
}
}
 /// <summary>
 /// v角色(vUserRoles)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserRolesEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserRoles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"RoleId", "RoleName", "QuestionnaireSetId", "QuestionnaireSetName", "PrjId", "Memo", "IsInUse", "UpdDate", "UpdUserId"};

protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名
protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrQuestionnaireSetName;    //问卷集名
protected string mstrPrjId;    //PrjId
protected string mstrMemo;    //备注
protected bool mbolIsInUse;    //IsInUse
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvUserRolesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RoleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRoleId">关键字:角色Id</param>
public clsvUserRolesEN(string strRoleId)
 {
strRoleId = strRoleId.Replace("'", "''");
if (strRoleId.Length > 8)
{
throw new Exception("在表:vUserRoles中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRoleId)  ==  true)
{
throw new Exception("在表:vUserRoles中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRoleId = strRoleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RoleId");
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
if (strAttributeName  ==  convUserRoles.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convUserRoles.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convUserRoles.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  convUserRoles.QuestionnaireSetName)
{
return mstrQuestionnaireSetName;
}
else if (strAttributeName  ==  convUserRoles.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convUserRoles.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convUserRoles.IsInUse)
{
return mbolIsInUse;
}
else if (strAttributeName  ==  convUserRoles.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUserRoles.UpdUserId)
{
return mstrUpdUserId;
}
return null;
}
set
{
if (strAttributeName  ==  convUserRoles.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convUserRoles.RoleId);
}
else if (strAttributeName  ==  convUserRoles.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convUserRoles.RoleName);
}
else if (strAttributeName  ==  convUserRoles.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convUserRoles.QuestionnaireSetId);
}
else if (strAttributeName  ==  convUserRoles.QuestionnaireSetName)
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convUserRoles.QuestionnaireSetName);
}
else if (strAttributeName  ==  convUserRoles.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserRoles.PrjId);
}
else if (strAttributeName  ==  convUserRoles.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserRoles.Memo);
}
else if (strAttributeName  ==  convUserRoles.IsInUse)
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserRoles.IsInUse);
}
else if (strAttributeName  ==  convUserRoles.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserRoles.UpdDate);
}
else if (strAttributeName  ==  convUserRoles.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convUserRoles.UpdUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserRoles.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convUserRoles.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convUserRoles.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (convUserRoles.QuestionnaireSetName  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetName;
}
else if (convUserRoles.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convUserRoles.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convUserRoles.IsInUse  ==  AttributeName[intIndex])
{
return mbolIsInUse;
}
else if (convUserRoles.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUserRoles.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
return null;
}
set
{
if (convUserRoles.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convUserRoles.RoleId);
}
else if (convUserRoles.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convUserRoles.RoleName);
}
else if (convUserRoles.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convUserRoles.QuestionnaireSetId);
}
else if (convUserRoles.QuestionnaireSetName  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convUserRoles.QuestionnaireSetName);
}
else if (convUserRoles.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convUserRoles.PrjId);
}
else if (convUserRoles.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserRoles.Memo);
}
else if (convUserRoles.IsInUse  ==  AttributeName[intIndex])
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convUserRoles.IsInUse);
}
else if (convUserRoles.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserRoles.UpdDate);
}
else if (convUserRoles.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convUserRoles.UpdUserId);
}
}
}

/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserRoles.RoleId);
}
}
/// <summary>
/// 角色名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserRoles.RoleName);
}
}
/// <summary>
/// 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetId
{
get
{
return mstrQuestionnaireSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetId = value;
}
else
{
 mstrQuestionnaireSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserRoles.QuestionnaireSetId);
}
}
/// <summary>
/// 问卷集名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetName
{
get
{
return mstrQuestionnaireSetName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetName = value;
}
else
{
 mstrQuestionnaireSetName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserRoles.QuestionnaireSetName);
}
}
/// <summary>
/// PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserRoles.PrjId);
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
 AddUpdatedFld(convUserRoles.Memo);
}
}
/// <summary>
/// IsInUse(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsInUse
{
get
{
return mbolIsInUse;
}
set
{
 mbolIsInUse = value;
//记录修改过的字段
 AddUpdatedFld(convUserRoles.IsInUse);
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
 AddUpdatedFld(convUserRoles.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserRoles.UpdUserId);
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
  return mstrRoleId;
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
  return mstrRoleName;
 }
 }
}
 /// <summary>
 /// v角色(vUserRoles)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserRoles
{
public const string _CurrTabName = "vUserRoles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RoleId", "RoleName", "QuestionnaireSetId", "QuestionnaireSetName", "PrjId", "Memo", "IsInUse", "UpdDate", "UpdUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"QuestionnaireSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetName = "QuestionnaireSetName";    //问卷集名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //PrjId

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IsInUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsInUse = "IsInUse";    //IsInUse

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id
}

}