
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ControlTypeEN
 表名:ge_ControlType(01120900)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:02
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
 /// 表ge_ControlType的关键字(ControlTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ControlTypeId_ge_ControlType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strControlTypeId">表关键字</param>
public K_ControlTypeId_ge_ControlType(string strControlTypeId)
{
if (IsValid(strControlTypeId)) Value = strControlTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strControlTypeId)
{
if (string.IsNullOrEmpty(strControlTypeId) == true) return false;
if (strControlTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ControlTypeId_ge_ControlType]类型的对象</returns>
public static implicit operator K_ControlTypeId_ge_ControlType(string value)
{
return new K_ControlTypeId_ge_ControlType(value);
}
}
 /// <summary>
 /// 控件类型(ge_ControlType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_ControlTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_ControlType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ControlTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"ControlTypeId", "ControlTypeName", "ControlTypeEnName", "UpdDate", "UpdUser", "Memo"};

protected string mstrControlTypeId;    //控件Id
protected string mstrControlTypeName;    //控件名称
protected string mstrControlTypeEnName;    //控件英文名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_ControlTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ControlTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strControlTypeId">关键字:控件Id</param>
public clsge_ControlTypeEN(string strControlTypeId)
 {
strControlTypeId = strControlTypeId.Replace("'", "''");
if (strControlTypeId.Length > 4)
{
throw new Exception("在表:ge_ControlType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strControlTypeId)  ==  true)
{
throw new Exception("在表:ge_ControlType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strControlTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrControlTypeId = strControlTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ControlTypeId");
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
if (strAttributeName  ==  conge_ControlType.ControlTypeId)
{
return mstrControlTypeId;
}
else if (strAttributeName  ==  conge_ControlType.ControlTypeName)
{
return mstrControlTypeName;
}
else if (strAttributeName  ==  conge_ControlType.ControlTypeEnName)
{
return mstrControlTypeEnName;
}
else if (strAttributeName  ==  conge_ControlType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_ControlType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_ControlType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_ControlType.ControlTypeId)
{
mstrControlTypeId = value.ToString();
 AddUpdatedFld(conge_ControlType.ControlTypeId);
}
else if (strAttributeName  ==  conge_ControlType.ControlTypeName)
{
mstrControlTypeName = value.ToString();
 AddUpdatedFld(conge_ControlType.ControlTypeName);
}
else if (strAttributeName  ==  conge_ControlType.ControlTypeEnName)
{
mstrControlTypeEnName = value.ToString();
 AddUpdatedFld(conge_ControlType.ControlTypeEnName);
}
else if (strAttributeName  ==  conge_ControlType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ControlType.UpdDate);
}
else if (strAttributeName  ==  conge_ControlType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ControlType.UpdUser);
}
else if (strAttributeName  ==  conge_ControlType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ControlType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_ControlType.ControlTypeId  ==  AttributeName[intIndex])
{
return mstrControlTypeId;
}
else if (conge_ControlType.ControlTypeName  ==  AttributeName[intIndex])
{
return mstrControlTypeName;
}
else if (conge_ControlType.ControlTypeEnName  ==  AttributeName[intIndex])
{
return mstrControlTypeEnName;
}
else if (conge_ControlType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_ControlType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_ControlType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_ControlType.ControlTypeId  ==  AttributeName[intIndex])
{
mstrControlTypeId = value.ToString();
 AddUpdatedFld(conge_ControlType.ControlTypeId);
}
else if (conge_ControlType.ControlTypeName  ==  AttributeName[intIndex])
{
mstrControlTypeName = value.ToString();
 AddUpdatedFld(conge_ControlType.ControlTypeName);
}
else if (conge_ControlType.ControlTypeEnName  ==  AttributeName[intIndex])
{
mstrControlTypeEnName = value.ToString();
 AddUpdatedFld(conge_ControlType.ControlTypeEnName);
}
else if (conge_ControlType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ControlType.UpdDate);
}
else if (conge_ControlType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ControlType.UpdUser);
}
else if (conge_ControlType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ControlType.Memo);
}
}
}

/// <summary>
/// 控件Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlTypeId
{
get
{
return mstrControlTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlTypeId = value;
}
else
{
 mstrControlTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ControlType.ControlTypeId);
}
}
/// <summary>
/// 控件名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlTypeName
{
get
{
return mstrControlTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlTypeName = value;
}
else
{
 mstrControlTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ControlType.ControlTypeName);
}
}
/// <summary>
/// 控件英文名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlTypeEnName
{
get
{
return mstrControlTypeEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlTypeEnName = value;
}
else
{
 mstrControlTypeEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ControlType.ControlTypeEnName);
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
 AddUpdatedFld(conge_ControlType.UpdDate);
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
 AddUpdatedFld(conge_ControlType.UpdUser);
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
 AddUpdatedFld(conge_ControlType.Memo);
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
  return mstrControlTypeId;
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
  return mstrControlTypeName;
 }
 }
}
 /// <summary>
 /// 控件类型(ge_ControlType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_ControlType
{
public const string _CurrTabName = "ge_ControlType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ControlTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ControlTypeId", "ControlTypeName", "ControlTypeEnName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ControlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlTypeId = "ControlTypeId";    //控件Id

 /// <summary>
 /// 常量:"ControlTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlTypeName = "ControlTypeName";    //控件名称

 /// <summary>
 /// 常量:"ControlTypeEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlTypeEnName = "ControlTypeEnName";    //控件英文名称

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