
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTopicUserRoleEN
 表名:TopicUserRole(01120590)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表TopicUserRole的关键字(TopicUserRoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicUserRoleId_TopicUserRole
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTopicUserRoleId">表关键字</param>
public K_TopicUserRoleId_TopicUserRole(string strTopicUserRoleId)
{
if (IsValid(strTopicUserRoleId)) Value = strTopicUserRoleId;
else
{
Value = null;
}
}
private static bool IsValid(string strTopicUserRoleId)
{
if (string.IsNullOrEmpty(strTopicUserRoleId) == true) return false;
if (strTopicUserRoleId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicUserRoleId_TopicUserRole]类型的对象</returns>
public static implicit operator K_TopicUserRoleId_TopicUserRole(string value)
{
return new K_TopicUserRoleId_TopicUserRole(value);
}
}
 /// <summary>
 /// 主题用户角色(TopicUserRole)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTopicUserRoleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TopicUserRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicUserRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"TopicUserRoleId", "TopicUserRoleName", "TopicUserRoleENName", "UpdUserId", "UpdDate", "Memo"};

protected string mstrTopicUserRoleId;    //主键Id
protected string mstrTopicUserRoleName;    //主题用户角色
protected string mstrTopicUserRoleENName;    //主题用户角色英文名
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTopicUserRoleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicUserRoleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTopicUserRoleId">关键字:主键Id</param>
public clsTopicUserRoleEN(string strTopicUserRoleId)
 {
strTopicUserRoleId = strTopicUserRoleId.Replace("'", "''");
if (strTopicUserRoleId.Length > 4)
{
throw new Exception("在表:TopicUserRole中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicUserRoleId)  ==  true)
{
throw new Exception("在表:TopicUserRole中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicUserRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTopicUserRoleId = strTopicUserRoleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicUserRoleId");
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
if (strAttributeName  ==  conTopicUserRole.TopicUserRoleId)
{
return mstrTopicUserRoleId;
}
else if (strAttributeName  ==  conTopicUserRole.TopicUserRoleName)
{
return mstrTopicUserRoleName;
}
else if (strAttributeName  ==  conTopicUserRole.TopicUserRoleENName)
{
return mstrTopicUserRoleENName;
}
else if (strAttributeName  ==  conTopicUserRole.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conTopicUserRole.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTopicUserRole.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTopicUserRole.TopicUserRoleId)
{
mstrTopicUserRoleId = value.ToString();
 AddUpdatedFld(conTopicUserRole.TopicUserRoleId);
}
else if (strAttributeName  ==  conTopicUserRole.TopicUserRoleName)
{
mstrTopicUserRoleName = value.ToString();
 AddUpdatedFld(conTopicUserRole.TopicUserRoleName);
}
else if (strAttributeName  ==  conTopicUserRole.TopicUserRoleENName)
{
mstrTopicUserRoleENName = value.ToString();
 AddUpdatedFld(conTopicUserRole.TopicUserRoleENName);
}
else if (strAttributeName  ==  conTopicUserRole.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTopicUserRole.UpdUserId);
}
else if (strAttributeName  ==  conTopicUserRole.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTopicUserRole.UpdDate);
}
else if (strAttributeName  ==  conTopicUserRole.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTopicUserRole.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTopicUserRole.TopicUserRoleId  ==  AttributeName[intIndex])
{
return mstrTopicUserRoleId;
}
else if (conTopicUserRole.TopicUserRoleName  ==  AttributeName[intIndex])
{
return mstrTopicUserRoleName;
}
else if (conTopicUserRole.TopicUserRoleENName  ==  AttributeName[intIndex])
{
return mstrTopicUserRoleENName;
}
else if (conTopicUserRole.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conTopicUserRole.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTopicUserRole.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTopicUserRole.TopicUserRoleId  ==  AttributeName[intIndex])
{
mstrTopicUserRoleId = value.ToString();
 AddUpdatedFld(conTopicUserRole.TopicUserRoleId);
}
else if (conTopicUserRole.TopicUserRoleName  ==  AttributeName[intIndex])
{
mstrTopicUserRoleName = value.ToString();
 AddUpdatedFld(conTopicUserRole.TopicUserRoleName);
}
else if (conTopicUserRole.TopicUserRoleENName  ==  AttributeName[intIndex])
{
mstrTopicUserRoleENName = value.ToString();
 AddUpdatedFld(conTopicUserRole.TopicUserRoleENName);
}
else if (conTopicUserRole.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTopicUserRole.UpdUserId);
}
else if (conTopicUserRole.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTopicUserRole.UpdDate);
}
else if (conTopicUserRole.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTopicUserRole.Memo);
}
}
}

/// <summary>
/// 主键Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicUserRoleId
{
get
{
return mstrTopicUserRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicUserRoleId = value;
}
else
{
 mstrTopicUserRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicUserRole.TopicUserRoleId);
}
}
/// <summary>
/// 主题用户角色(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicUserRoleName
{
get
{
return mstrTopicUserRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicUserRoleName = value;
}
else
{
 mstrTopicUserRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicUserRole.TopicUserRoleName);
}
}
/// <summary>
/// 主题用户角色英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicUserRoleENName
{
get
{
return mstrTopicUserRoleENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicUserRoleENName = value;
}
else
{
 mstrTopicUserRoleENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicUserRole.TopicUserRoleENName);
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
 AddUpdatedFld(conTopicUserRole.UpdUserId);
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
 AddUpdatedFld(conTopicUserRole.UpdDate);
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
 AddUpdatedFld(conTopicUserRole.Memo);
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
  return mstrTopicUserRoleId;
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
  return mstrTopicUserRoleName;
 }
 }
}
 /// <summary>
 /// 主题用户角色(TopicUserRole)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTopicUserRole
{
public const string _CurrTabName = "TopicUserRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicUserRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicUserRoleId", "TopicUserRoleName", "TopicUserRoleENName", "UpdUserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicUserRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicUserRoleId = "TopicUserRoleId";    //主键Id

 /// <summary>
 /// 常量:"TopicUserRoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicUserRoleName = "TopicUserRoleName";    //主题用户角色

 /// <summary>
 /// 常量:"TopicUserRoleENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicUserRoleENName = "TopicUserRoleENName";    //主题用户角色英文名

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}