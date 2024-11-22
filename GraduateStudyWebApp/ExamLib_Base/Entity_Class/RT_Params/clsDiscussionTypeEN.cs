
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscussionTypeEN
 表名:DiscussionType(01120589)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:25
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
 /// 表DiscussionType的关键字(DiscussionTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DiscussionTypeId_DiscussionType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDiscussionTypeId">表关键字</param>
public K_DiscussionTypeId_DiscussionType(string strDiscussionTypeId)
{
if (IsValid(strDiscussionTypeId)) Value = strDiscussionTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDiscussionTypeId)
{
if (string.IsNullOrEmpty(strDiscussionTypeId) == true) return false;
if (strDiscussionTypeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DiscussionTypeId_DiscussionType]类型的对象</returns>
public static implicit operator K_DiscussionTypeId_DiscussionType(string value)
{
return new K_DiscussionTypeId_DiscussionType(value);
}
}
 /// <summary>
 /// 讨论类型表(DiscussionType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDiscussionTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DiscussionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DiscussionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"DiscussionTypeId", "DiscussionTypeName", "UpdDate", "UpdUser", "Memo"};

protected string mstrDiscussionTypeId;    //讨论类型Id
protected string mstrDiscussionTypeName;    //讨论类型名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDiscussionTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DiscussionTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDiscussionTypeId">关键字:讨论类型Id</param>
public clsDiscussionTypeEN(string strDiscussionTypeId)
 {
strDiscussionTypeId = strDiscussionTypeId.Replace("'", "''");
if (strDiscussionTypeId.Length > 8)
{
throw new Exception("在表:DiscussionType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDiscussionTypeId)  ==  true)
{
throw new Exception("在表:DiscussionType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDiscussionTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDiscussionTypeId = strDiscussionTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DiscussionTypeId");
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
if (strAttributeName  ==  conDiscussionType.DiscussionTypeId)
{
return mstrDiscussionTypeId;
}
else if (strAttributeName  ==  conDiscussionType.DiscussionTypeName)
{
return mstrDiscussionTypeName;
}
else if (strAttributeName  ==  conDiscussionType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDiscussionType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDiscussionType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDiscussionType.DiscussionTypeId)
{
mstrDiscussionTypeId = value.ToString();
 AddUpdatedFld(conDiscussionType.DiscussionTypeId);
}
else if (strAttributeName  ==  conDiscussionType.DiscussionTypeName)
{
mstrDiscussionTypeName = value.ToString();
 AddUpdatedFld(conDiscussionType.DiscussionTypeName);
}
else if (strAttributeName  ==  conDiscussionType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDiscussionType.UpdDate);
}
else if (strAttributeName  ==  conDiscussionType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDiscussionType.UpdUser);
}
else if (strAttributeName  ==  conDiscussionType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscussionType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDiscussionType.DiscussionTypeId  ==  AttributeName[intIndex])
{
return mstrDiscussionTypeId;
}
else if (conDiscussionType.DiscussionTypeName  ==  AttributeName[intIndex])
{
return mstrDiscussionTypeName;
}
else if (conDiscussionType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDiscussionType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDiscussionType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDiscussionType.DiscussionTypeId  ==  AttributeName[intIndex])
{
mstrDiscussionTypeId = value.ToString();
 AddUpdatedFld(conDiscussionType.DiscussionTypeId);
}
else if (conDiscussionType.DiscussionTypeName  ==  AttributeName[intIndex])
{
mstrDiscussionTypeName = value.ToString();
 AddUpdatedFld(conDiscussionType.DiscussionTypeName);
}
else if (conDiscussionType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDiscussionType.UpdDate);
}
else if (conDiscussionType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDiscussionType.UpdUser);
}
else if (conDiscussionType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscussionType.Memo);
}
}
}

/// <summary>
/// 讨论类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DiscussionTypeId
{
get
{
return mstrDiscussionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDiscussionTypeId = value;
}
else
{
 mstrDiscussionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionType.DiscussionTypeId);
}
}
/// <summary>
/// 讨论类型名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DiscussionTypeName
{
get
{
return mstrDiscussionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDiscussionTypeName = value;
}
else
{
 mstrDiscussionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionType.DiscussionTypeName);
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
 AddUpdatedFld(conDiscussionType.UpdDate);
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
 AddUpdatedFld(conDiscussionType.UpdUser);
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
 AddUpdatedFld(conDiscussionType.Memo);
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
  return mstrDiscussionTypeId;
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
  return mstrDiscussionTypeName;
 }
 }
}
 /// <summary>
 /// 讨论类型表(DiscussionType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDiscussionType
{
public const string _CurrTabName = "DiscussionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DiscussionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DiscussionTypeId", "DiscussionTypeName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DiscussionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DiscussionTypeId = "DiscussionTypeId";    //讨论类型Id

 /// <summary>
 /// 常量:"DiscussionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DiscussionTypeName = "DiscussionTypeName";    //讨论类型名称

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