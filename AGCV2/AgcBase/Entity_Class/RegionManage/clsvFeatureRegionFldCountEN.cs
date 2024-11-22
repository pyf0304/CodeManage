﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFldCountEN
 表名:vFeatureRegionFldCount(00050578)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:55:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vFeatureRegionFldCount的关键字(RegionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RegionId_vFeatureRegionFldCount
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRegionId">表关键字</param>
public K_RegionId_vFeatureRegionFldCount(string strRegionId)
{
if (IsValid(strRegionId)) Value = strRegionId;
else
{
Value = null;
}
}
private static bool IsValid(string strRegionId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return false;
if (strRegionId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RegionId_vFeatureRegionFldCount]类型的对象</returns>
public static implicit operator K_RegionId_vFeatureRegionFldCount(string value)
{
return new K_RegionId_vFeatureRegionFldCount(value);
}
}
 /// <summary>
 /// v功能区字段数(vFeatureRegionFldCount)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFeatureRegionFldCountEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFeatureRegionFldCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"RegionId", "FldCount", "PrjId"};

protected string mstrRegionId;    //区域Id
protected int? mintFldCount;    //字段数
protected string mstrPrjId;    //工程ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFeatureRegionFldCountEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RegionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRegionId">关键字:区域Id</param>
public clsvFeatureRegionFldCountEN(string strRegionId)
 {
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("在表:vFeatureRegionFldCount中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("在表:vFeatureRegionFldCount中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRegionId = strRegionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RegionId");
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
if (strAttributeName  ==  convFeatureRegionFldCount.RegionId)
{
return mstrRegionId;
}
else if (strAttributeName  ==  convFeatureRegionFldCount.FldCount)
{
return mintFldCount;
}
else if (strAttributeName  ==  convFeatureRegionFldCount.PrjId)
{
return mstrPrjId;
}
return null;
}
set
{
if (strAttributeName  ==  convFeatureRegionFldCount.RegionId)
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convFeatureRegionFldCount.RegionId);
}
else if (strAttributeName  ==  convFeatureRegionFldCount.FldCount)
{
mintFldCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFldCount.FldCount);
}
else if (strAttributeName  ==  convFeatureRegionFldCount.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFeatureRegionFldCount.PrjId);
}
}
}
public object this[int intIndex]
{
get
{
if (convFeatureRegionFldCount.RegionId  ==  AttributeName[intIndex])
{
return mstrRegionId;
}
else if (convFeatureRegionFldCount.FldCount  ==  AttributeName[intIndex])
{
return mintFldCount;
}
else if (convFeatureRegionFldCount.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
return null;
}
set
{
if (convFeatureRegionFldCount.RegionId  ==  AttributeName[intIndex])
{
mstrRegionId = value.ToString();
 AddUpdatedFld(convFeatureRegionFldCount.RegionId);
}
else if (convFeatureRegionFldCount.FldCount  ==  AttributeName[intIndex])
{
mintFldCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFeatureRegionFldCount.FldCount);
}
else if (convFeatureRegionFldCount.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFeatureRegionFldCount.PrjId);
}
}
}

/// <summary>
/// 区域Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionId
{
get
{
return mstrRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionId = value;
}
else
{
 mstrRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFldCount.RegionId);
}
}
/// <summary>
/// 字段数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldCount
{
get
{
return mintFldCount;
}
set
{
 mintFldCount = value;
//记录修改过的字段
 AddUpdatedFld(convFeatureRegionFldCount.FldCount);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convFeatureRegionFldCount.PrjId);
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
  return mstrRegionId;
 }
 }
}
 /// <summary>
 /// v功能区字段数(vFeatureRegionFldCount)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFeatureRegionFldCount
{
public const string _CurrTabName = "vFeatureRegionFldCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RegionId", "FldCount", "PrjId"};
//以下是属性变量


 /// <summary>
 /// 常量:"RegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionId = "RegionId";    //区域Id

 /// <summary>
 /// 常量:"FldCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldCount = "FldCount";    //字段数

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID
}

}