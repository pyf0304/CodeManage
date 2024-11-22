
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ControlAttributeEN
 表名:ge_ControlAttribute(01120914)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 表ge_ControlAttribute的关键字(AttributeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AttributeId_ge_ControlAttribute
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAttributeId">表关键字</param>
public K_AttributeId_ge_ControlAttribute(string strAttributeId)
{
if (IsValid(strAttributeId)) Value = strAttributeId;
else
{
Value = null;
}
}
private static bool IsValid(string strAttributeId)
{
if (string.IsNullOrEmpty(strAttributeId) == true) return false;
if (strAttributeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AttributeId_ge_ControlAttribute]类型的对象</returns>
public static implicit operator K_AttributeId_ge_ControlAttribute(string value)
{
return new K_AttributeId_ge_ControlAttribute(value);
}
}
 /// <summary>
 /// 属性表(ge_ControlAttribute)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_ControlAttributeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_ControlAttribute"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AttributeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"AttributeId", "ControlAttributeName", "UpdDate", "UpdUser", "Memo"};

protected string mstrAttributeId;    //控件属性Id
protected string mstrControlAttributeName;    //属性名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_ControlAttributeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AttributeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAttributeId">关键字:控件属性Id</param>
public clsge_ControlAttributeEN(string strAttributeId)
 {
strAttributeId = strAttributeId.Replace("'", "''");
if (strAttributeId.Length > 4)
{
throw new Exception("在表:ge_ControlAttribute中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAttributeId)  ==  true)
{
throw new Exception("在表:ge_ControlAttribute中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAttributeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAttributeId = strAttributeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AttributeId");
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
if (strAttributeName  ==  conge_ControlAttribute.AttributeId)
{
return mstrAttributeId;
}
else if (strAttributeName  ==  conge_ControlAttribute.ControlAttributeName)
{
return mstrControlAttributeName;
}
else if (strAttributeName  ==  conge_ControlAttribute.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_ControlAttribute.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_ControlAttribute.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_ControlAttribute.AttributeId)
{
mstrAttributeId = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.AttributeId);
}
else if (strAttributeName  ==  conge_ControlAttribute.ControlAttributeName)
{
mstrControlAttributeName = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.ControlAttributeName);
}
else if (strAttributeName  ==  conge_ControlAttribute.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.UpdDate);
}
else if (strAttributeName  ==  conge_ControlAttribute.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.UpdUser);
}
else if (strAttributeName  ==  conge_ControlAttribute.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_ControlAttribute.AttributeId  ==  AttributeName[intIndex])
{
return mstrAttributeId;
}
else if (conge_ControlAttribute.ControlAttributeName  ==  AttributeName[intIndex])
{
return mstrControlAttributeName;
}
else if (conge_ControlAttribute.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_ControlAttribute.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_ControlAttribute.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_ControlAttribute.AttributeId  ==  AttributeName[intIndex])
{
mstrAttributeId = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.AttributeId);
}
else if (conge_ControlAttribute.ControlAttributeName  ==  AttributeName[intIndex])
{
mstrControlAttributeName = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.ControlAttributeName);
}
else if (conge_ControlAttribute.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.UpdDate);
}
else if (conge_ControlAttribute.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.UpdUser);
}
else if (conge_ControlAttribute.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ControlAttribute.Memo);
}
}
}

/// <summary>
/// 控件属性Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AttributeId
{
get
{
return mstrAttributeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAttributeId = value;
}
else
{
 mstrAttributeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ControlAttribute.AttributeId);
}
}
/// <summary>
/// 属性名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlAttributeName
{
get
{
return mstrControlAttributeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlAttributeName = value;
}
else
{
 mstrControlAttributeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ControlAttribute.ControlAttributeName);
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
 AddUpdatedFld(conge_ControlAttribute.UpdDate);
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
 AddUpdatedFld(conge_ControlAttribute.UpdUser);
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
 AddUpdatedFld(conge_ControlAttribute.Memo);
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
  return mstrAttributeId;
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
  return mstrControlAttributeName;
 }
 }
}
 /// <summary>
 /// 属性表(ge_ControlAttribute)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_ControlAttribute
{
public const string _CurrTabName = "ge_ControlAttribute"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AttributeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AttributeId", "ControlAttributeName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AttributeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttributeId = "AttributeId";    //控件属性Id

 /// <summary>
 /// 常量:"ControlAttributeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlAttributeName = "ControlAttributeName";    //属性名称

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