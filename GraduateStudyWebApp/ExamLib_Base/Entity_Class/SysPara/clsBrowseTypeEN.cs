
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBrowseTypeEN
 表名:BrowseType(01120483)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:04
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
 /// 表BrowseType的关键字(BrowseTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_BrowseTypeId_BrowseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strBrowseTypeId">表关键字</param>
public K_BrowseTypeId_BrowseType(string strBrowseTypeId)
{
if (IsValid(strBrowseTypeId)) Value = strBrowseTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strBrowseTypeId)
{
if (string.IsNullOrEmpty(strBrowseTypeId) == true) return false;
if (strBrowseTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_BrowseTypeId_BrowseType]类型的对象</returns>
public static implicit operator K_BrowseTypeId_BrowseType(string value)
{
return new K_BrowseTypeId_BrowseType(value);
}
}
 /// <summary>
 /// 浏览类型(BrowseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsBrowseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "BrowseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "BrowseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"BrowseTypeId", "BrowseTypeName", "UpdDate"};

protected string mstrBrowseTypeId;    //BrowseTypeId
protected string mstrBrowseTypeName;    //BrowseTypeName
protected string mstrUpdDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsBrowseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("BrowseTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strBrowseTypeId">关键字:BrowseTypeId</param>
public clsBrowseTypeEN(string strBrowseTypeId)
 {
strBrowseTypeId = strBrowseTypeId.Replace("'", "''");
if (strBrowseTypeId.Length > 4)
{
throw new Exception("在表:BrowseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strBrowseTypeId)  ==  true)
{
throw new Exception("在表:BrowseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strBrowseTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrBrowseTypeId = strBrowseTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("BrowseTypeId");
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
if (strAttributeName  ==  conBrowseType.BrowseTypeId)
{
return mstrBrowseTypeId;
}
else if (strAttributeName  ==  conBrowseType.BrowseTypeName)
{
return mstrBrowseTypeName;
}
else if (strAttributeName  ==  conBrowseType.UpdDate)
{
return mstrUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  conBrowseType.BrowseTypeId)
{
mstrBrowseTypeId = value.ToString();
 AddUpdatedFld(conBrowseType.BrowseTypeId);
}
else if (strAttributeName  ==  conBrowseType.BrowseTypeName)
{
mstrBrowseTypeName = value.ToString();
 AddUpdatedFld(conBrowseType.BrowseTypeName);
}
else if (strAttributeName  ==  conBrowseType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conBrowseType.UpdDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conBrowseType.BrowseTypeId  ==  AttributeName[intIndex])
{
return mstrBrowseTypeId;
}
else if (conBrowseType.BrowseTypeName  ==  AttributeName[intIndex])
{
return mstrBrowseTypeName;
}
else if (conBrowseType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
return null;
}
set
{
if (conBrowseType.BrowseTypeId  ==  AttributeName[intIndex])
{
mstrBrowseTypeId = value.ToString();
 AddUpdatedFld(conBrowseType.BrowseTypeId);
}
else if (conBrowseType.BrowseTypeName  ==  AttributeName[intIndex])
{
mstrBrowseTypeName = value.ToString();
 AddUpdatedFld(conBrowseType.BrowseTypeName);
}
else if (conBrowseType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conBrowseType.UpdDate);
}
}
}

/// <summary>
/// BrowseTypeId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BrowseTypeId
{
get
{
return mstrBrowseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBrowseTypeId = value;
}
else
{
 mstrBrowseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conBrowseType.BrowseTypeId);
}
}
/// <summary>
/// BrowseTypeName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BrowseTypeName
{
get
{
return mstrBrowseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBrowseTypeName = value;
}
else
{
 mstrBrowseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conBrowseType.BrowseTypeName);
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
 AddUpdatedFld(conBrowseType.UpdDate);
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
  return mstrBrowseTypeId;
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
  return mstrBrowseTypeName;
 }
 }
}
 /// <summary>
 /// 浏览类型(BrowseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conBrowseType
{
public const string _CurrTabName = "BrowseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "BrowseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"BrowseTypeId", "BrowseTypeName", "UpdDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"BrowseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseTypeId = "BrowseTypeId";    //BrowseTypeId

 /// <summary>
 /// 常量:"BrowseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseTypeName = "BrowseTypeName";    //BrowseTypeName

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期
}

}