
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsProvinceEN
 表名:RsProvince(01120107)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:19
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
 /// 表RsProvince的关键字(IdProvince)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdProvince_RsProvince
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdProvince">表关键字</param>
public K_IdProvince_RsProvince(string strIdProvince)
{
if (IsValid(strIdProvince)) Value = strIdProvince;
else
{
Value = null;
}
}
private static bool IsValid(string strIdProvince)
{
if (string.IsNullOrEmpty(strIdProvince) == true) return false;
if (strIdProvince.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdProvince_RsProvince]类型的对象</returns>
public static implicit operator K_IdProvince_RsProvince(string value)
{
return new K_IdProvince_RsProvince(value);
}
}
 /// <summary>
 /// 省份(RsProvince)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsProvinceEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsProvince"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdProvince"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdProvince", "ProvinceID", "ProvinceName", "ProvinceRecuitID", "ModifyDate", "ModifyUserId"};

protected string mstrIdProvince;    //省份流水号
protected string mstrProvinceID;    //ProvinceID
protected string mstrProvinceName;    //ProvinceName
protected string mstrProvinceRecuitID;    //ProvinceRecuitID
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsProvinceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdProvince");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdProvince">关键字:省份流水号</param>
public clsRsProvinceEN(string strIdProvince)
 {
strIdProvince = strIdProvince.Replace("'", "''");
if (strIdProvince.Length > 4)
{
throw new Exception("在表:RsProvince中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdProvince)  ==  true)
{
throw new Exception("在表:RsProvince中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdProvince);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdProvince = strIdProvince;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdProvince");
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
if (strAttributeName  ==  conRsProvince.IdProvince)
{
return mstrIdProvince;
}
else if (strAttributeName  ==  conRsProvince.ProvinceID)
{
return mstrProvinceID;
}
else if (strAttributeName  ==  conRsProvince.ProvinceName)
{
return mstrProvinceName;
}
else if (strAttributeName  ==  conRsProvince.ProvinceRecuitID)
{
return mstrProvinceRecuitID;
}
else if (strAttributeName  ==  conRsProvince.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conRsProvince.ModifyUserId)
{
return mstrModifyUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conRsProvince.IdProvince)
{
mstrIdProvince = value.ToString();
 AddUpdatedFld(conRsProvince.IdProvince);
}
else if (strAttributeName  ==  conRsProvince.ProvinceID)
{
mstrProvinceID = value.ToString();
 AddUpdatedFld(conRsProvince.ProvinceID);
}
else if (strAttributeName  ==  conRsProvince.ProvinceName)
{
mstrProvinceName = value.ToString();
 AddUpdatedFld(conRsProvince.ProvinceName);
}
else if (strAttributeName  ==  conRsProvince.ProvinceRecuitID)
{
mstrProvinceRecuitID = value.ToString();
 AddUpdatedFld(conRsProvince.ProvinceRecuitID);
}
else if (strAttributeName  ==  conRsProvince.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsProvince.ModifyDate);
}
else if (strAttributeName  ==  conRsProvince.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsProvince.ModifyUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsProvince.IdProvince  ==  AttributeName[intIndex])
{
return mstrIdProvince;
}
else if (conRsProvince.ProvinceID  ==  AttributeName[intIndex])
{
return mstrProvinceID;
}
else if (conRsProvince.ProvinceName  ==  AttributeName[intIndex])
{
return mstrProvinceName;
}
else if (conRsProvince.ProvinceRecuitID  ==  AttributeName[intIndex])
{
return mstrProvinceRecuitID;
}
else if (conRsProvince.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conRsProvince.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
return null;
}
set
{
if (conRsProvince.IdProvince  ==  AttributeName[intIndex])
{
mstrIdProvince = value.ToString();
 AddUpdatedFld(conRsProvince.IdProvince);
}
else if (conRsProvince.ProvinceID  ==  AttributeName[intIndex])
{
mstrProvinceID = value.ToString();
 AddUpdatedFld(conRsProvince.ProvinceID);
}
else if (conRsProvince.ProvinceName  ==  AttributeName[intIndex])
{
mstrProvinceName = value.ToString();
 AddUpdatedFld(conRsProvince.ProvinceName);
}
else if (conRsProvince.ProvinceRecuitID  ==  AttributeName[intIndex])
{
mstrProvinceRecuitID = value.ToString();
 AddUpdatedFld(conRsProvince.ProvinceRecuitID);
}
else if (conRsProvince.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsProvince.ModifyDate);
}
else if (conRsProvince.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsProvince.ModifyUserId);
}
}
}

/// <summary>
/// 省份流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdProvince
{
get
{
return mstrIdProvince;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdProvince = value;
}
else
{
 mstrIdProvince = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsProvince.IdProvince);
}
}
/// <summary>
/// ProvinceID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProvinceID
{
get
{
return mstrProvinceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProvinceID = value;
}
else
{
 mstrProvinceID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsProvince.ProvinceID);
}
}
/// <summary>
/// ProvinceName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProvinceName
{
get
{
return mstrProvinceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProvinceName = value;
}
else
{
 mstrProvinceName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsProvince.ProvinceName);
}
}
/// <summary>
/// ProvinceRecuitID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProvinceRecuitID
{
get
{
return mstrProvinceRecuitID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProvinceRecuitID = value;
}
else
{
 mstrProvinceRecuitID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsProvince.ProvinceRecuitID);
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
 AddUpdatedFld(conRsProvince.ModifyDate);
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
 AddUpdatedFld(conRsProvince.ModifyUserId);
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
  return mstrIdProvince;
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
  return mstrProvinceName;
 }
 }
}
 /// <summary>
 /// 省份(RsProvince)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsProvince
{
public const string _CurrTabName = "RsProvince"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdProvince"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdProvince", "ProvinceID", "ProvinceName", "ProvinceRecuitID", "ModifyDate", "ModifyUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdProvince"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdProvince = "IdProvince";    //省份流水号

 /// <summary>
 /// 常量:"ProvinceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProvinceID = "ProvinceID";    //ProvinceID

 /// <summary>
 /// 常量:"ProvinceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProvinceName = "ProvinceName";    //ProvinceName

 /// <summary>
 /// 常量:"ProvinceRecuitID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProvinceRecuitID = "ProvinceRecuitID";    //ProvinceRecuitID

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