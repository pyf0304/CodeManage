
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysDefaValNameEN
 表名:SysDefaValName(01120936)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
 /// 表SysDefaValName的关键字(DefaValNameId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DefaValNameId_SysDefaValName
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDefaValNameId">表关键字</param>
public K_DefaValNameId_SysDefaValName(string strDefaValNameId)
{
if (IsValid(strDefaValNameId)) Value = strDefaValNameId;
else
{
Value = null;
}
}
private static bool IsValid(string strDefaValNameId)
{
if (string.IsNullOrEmpty(strDefaValNameId) == true) return false;
if (strDefaValNameId.Length > 8) return false;
if (strDefaValNameId.IndexOf(' ') >= 0) return false;
if (strDefaValNameId.IndexOf(')') >= 0) return false;
if (strDefaValNameId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DefaValNameId_SysDefaValName]类型的对象</returns>
public static implicit operator K_DefaValNameId_SysDefaValName(string value)
{
return new K_DefaValNameId_SysDefaValName(value);
}
}
 /// <summary>
 /// SysDefaValName(SysDefaValName)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysDefaValNameEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysDefaValName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DefaValNameId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"DefaValNameId", "DefaValName", "SysDefaValue"};

protected string mstrDefaValNameId;    //缺省值名称Id
protected string mstrDefaValName;    //缺省值名称
protected string mstrSysDefaValue;    //SysDefaValue

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysDefaValNameEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DefaValNameId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDefaValNameId">关键字:缺省值名称Id</param>
public clsSysDefaValNameEN(string strDefaValNameId)
 {
strDefaValNameId = strDefaValNameId.Replace("'", "''");
if (strDefaValNameId.Length > 8)
{
throw new Exception("在表:SysDefaValName中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDefaValNameId)  ==  true)
{
throw new Exception("在表:SysDefaValName中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDefaValNameId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDefaValNameId = strDefaValNameId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DefaValNameId");
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
if (strAttributeName  ==  conSysDefaValName.DefaValNameId)
{
return mstrDefaValNameId;
}
else if (strAttributeName  ==  conSysDefaValName.DefaValName)
{
return mstrDefaValName;
}
else if (strAttributeName  ==  conSysDefaValName.SysDefaValue)
{
return mstrSysDefaValue;
}
return null;
}
set
{
if (strAttributeName  ==  conSysDefaValName.DefaValNameId)
{
mstrDefaValNameId = value.ToString();
 AddUpdatedFld(conSysDefaValName.DefaValNameId);
}
else if (strAttributeName  ==  conSysDefaValName.DefaValName)
{
mstrDefaValName = value.ToString();
 AddUpdatedFld(conSysDefaValName.DefaValName);
}
else if (strAttributeName  ==  conSysDefaValName.SysDefaValue)
{
mstrSysDefaValue = value.ToString();
 AddUpdatedFld(conSysDefaValName.SysDefaValue);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysDefaValName.DefaValNameId  ==  AttributeName[intIndex])
{
return mstrDefaValNameId;
}
else if (conSysDefaValName.DefaValName  ==  AttributeName[intIndex])
{
return mstrDefaValName;
}
else if (conSysDefaValName.SysDefaValue  ==  AttributeName[intIndex])
{
return mstrSysDefaValue;
}
return null;
}
set
{
if (conSysDefaValName.DefaValNameId  ==  AttributeName[intIndex])
{
mstrDefaValNameId = value.ToString();
 AddUpdatedFld(conSysDefaValName.DefaValNameId);
}
else if (conSysDefaValName.DefaValName  ==  AttributeName[intIndex])
{
mstrDefaValName = value.ToString();
 AddUpdatedFld(conSysDefaValName.DefaValName);
}
else if (conSysDefaValName.SysDefaValue  ==  AttributeName[intIndex])
{
mstrSysDefaValue = value.ToString();
 AddUpdatedFld(conSysDefaValName.SysDefaValue);
}
}
}

/// <summary>
/// 缺省值名称Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaValNameId
{
get
{
return mstrDefaValNameId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaValNameId = value;
}
else
{
 mstrDefaValNameId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysDefaValName.DefaValNameId);
}
}
/// <summary>
/// 缺省值名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaValName
{
get
{
return mstrDefaValName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaValName = value;
}
else
{
 mstrDefaValName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysDefaValName.DefaValName);
}
}
/// <summary>
/// SysDefaValue(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SysDefaValue
{
get
{
return mstrSysDefaValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSysDefaValue = value;
}
else
{
 mstrSysDefaValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysDefaValName.SysDefaValue);
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
  return mstrDefaValNameId;
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
  return mstrDefaValName;
 }
 }
}
 /// <summary>
 /// SysDefaValName(SysDefaValName)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysDefaValName
{
public const string _CurrTabName = "SysDefaValName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DefaValNameId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DefaValNameId", "DefaValName", "SysDefaValue"};
//以下是属性变量


 /// <summary>
 /// 常量:"DefaValNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaValNameId = "DefaValNameId";    //缺省值名称Id

 /// <summary>
 /// 常量:"DefaValName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaValName = "DefaValName";    //缺省值名称

 /// <summary>
 /// 常量:"SysDefaValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SysDefaValue = "SysDefaValue";    //SysDefaValue
}

}