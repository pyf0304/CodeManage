
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsStaffTypeEN
 表名:RsStaffType(01120101)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表RsStaffType的关键字(IdStaffType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdStaffType_RsStaffType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdStaffType">表关键字</param>
public K_IdStaffType_RsStaffType(string strIdStaffType)
{
if (IsValid(strIdStaffType)) Value = strIdStaffType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdStaffType)
{
if (string.IsNullOrEmpty(strIdStaffType) == true) return false;
if (strIdStaffType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdStaffType_RsStaffType]类型的对象</returns>
public static implicit operator K_IdStaffType_RsStaffType(string value)
{
return new K_IdStaffType_RsStaffType(value);
}
}
 /// <summary>
 /// 职工类型(RsStaffType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsStaffTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsStaffType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdStaffType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdStaffType", "StaffTypeId", "StaffTypeName", "ModifyDate", "ModifyUserId"};

protected string mstrIdStaffType;    //职工类型流水号
protected string mstrStaffTypeId;    //职工类型Id
protected string mstrStaffTypeName;    //职工类型名称
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsStaffTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStaffType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdStaffType">关键字:职工类型流水号</param>
public clsRsStaffTypeEN(string strIdStaffType)
 {
strIdStaffType = strIdStaffType.Replace("'", "''");
if (strIdStaffType.Length > 4)
{
throw new Exception("在表:RsStaffType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdStaffType)  ==  true)
{
throw new Exception("在表:RsStaffType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdStaffType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdStaffType = strIdStaffType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStaffType");
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
if (strAttributeName  ==  conRsStaffType.IdStaffType)
{
return mstrIdStaffType;
}
else if (strAttributeName  ==  conRsStaffType.StaffTypeId)
{
return mstrStaffTypeId;
}
else if (strAttributeName  ==  conRsStaffType.StaffTypeName)
{
return mstrStaffTypeName;
}
else if (strAttributeName  ==  conRsStaffType.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conRsStaffType.ModifyUserId)
{
return mstrModifyUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conRsStaffType.IdStaffType)
{
mstrIdStaffType = value.ToString();
 AddUpdatedFld(conRsStaffType.IdStaffType);
}
else if (strAttributeName  ==  conRsStaffType.StaffTypeId)
{
mstrStaffTypeId = value.ToString();
 AddUpdatedFld(conRsStaffType.StaffTypeId);
}
else if (strAttributeName  ==  conRsStaffType.StaffTypeName)
{
mstrStaffTypeName = value.ToString();
 AddUpdatedFld(conRsStaffType.StaffTypeName);
}
else if (strAttributeName  ==  conRsStaffType.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsStaffType.ModifyDate);
}
else if (strAttributeName  ==  conRsStaffType.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsStaffType.ModifyUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsStaffType.IdStaffType  ==  AttributeName[intIndex])
{
return mstrIdStaffType;
}
else if (conRsStaffType.StaffTypeId  ==  AttributeName[intIndex])
{
return mstrStaffTypeId;
}
else if (conRsStaffType.StaffTypeName  ==  AttributeName[intIndex])
{
return mstrStaffTypeName;
}
else if (conRsStaffType.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conRsStaffType.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
return null;
}
set
{
if (conRsStaffType.IdStaffType  ==  AttributeName[intIndex])
{
mstrIdStaffType = value.ToString();
 AddUpdatedFld(conRsStaffType.IdStaffType);
}
else if (conRsStaffType.StaffTypeId  ==  AttributeName[intIndex])
{
mstrStaffTypeId = value.ToString();
 AddUpdatedFld(conRsStaffType.StaffTypeId);
}
else if (conRsStaffType.StaffTypeName  ==  AttributeName[intIndex])
{
mstrStaffTypeName = value.ToString();
 AddUpdatedFld(conRsStaffType.StaffTypeName);
}
else if (conRsStaffType.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsStaffType.ModifyDate);
}
else if (conRsStaffType.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsStaffType.ModifyUserId);
}
}
}

/// <summary>
/// 职工类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStaffType
{
get
{
return mstrIdStaffType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStaffType = value;
}
else
{
 mstrIdStaffType = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStaffType.IdStaffType);
}
}
/// <summary>
/// 职工类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StaffTypeId
{
get
{
return mstrStaffTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStaffTypeId = value;
}
else
{
 mstrStaffTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStaffType.StaffTypeId);
}
}
/// <summary>
/// 职工类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StaffTypeName
{
get
{
return mstrStaffTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStaffTypeName = value;
}
else
{
 mstrStaffTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStaffType.StaffTypeName);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStaffType.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStaffType.ModifyUserId);
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
  return mstrIdStaffType;
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
  return mstrStaffTypeName;
 }
 }
}
 /// <summary>
 /// 职工类型(RsStaffType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsStaffType
{
public const string _CurrTabName = "RsStaffType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdStaffType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdStaffType", "StaffTypeId", "StaffTypeName", "ModifyDate", "ModifyUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdStaffType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStaffType = "IdStaffType";    //职工类型流水号

 /// <summary>
 /// 常量:"StaffTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StaffTypeId = "StaffTypeId";    //职工类型Id

 /// <summary>
 /// 常量:"StaffTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StaffTypeName = "StaffTypeName";    //职工类型名称

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人
}

}