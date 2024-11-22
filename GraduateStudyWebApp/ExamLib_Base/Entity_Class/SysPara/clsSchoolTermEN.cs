
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSchoolTermEN
 表名:SchoolTerm(01120135)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:44
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
 /// 表SchoolTerm的关键字(SchoolTerm)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SchoolTerm_SchoolTerm
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSchoolTerm">表关键字</param>
public K_SchoolTerm_SchoolTerm(string strSchoolTerm)
{
if (IsValid(strSchoolTerm)) Value = strSchoolTerm;
else
{
Value = null;
}
}
private static bool IsValid(string strSchoolTerm)
{
if (string.IsNullOrEmpty(strSchoolTerm) == true) return false;
if (strSchoolTerm.Length != 1) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SchoolTerm_SchoolTerm]类型的对象</returns>
public static implicit operator K_SchoolTerm_SchoolTerm(string value)
{
return new K_SchoolTerm_SchoolTerm(value);
}
}
 /// <summary>
 /// 学期(SchoolTerm)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSchoolTermEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SchoolTerm"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SchoolTerm"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"SchoolTerm", "SchoolTermName", "IsCurrentSchoolTerm"};

protected string mstrSchoolTerm;    //学期
protected string mstrSchoolTermName;    //学期名
protected bool mbolIsCurrentSchoolTerm;    //学期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSchoolTermEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SchoolTerm");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSchoolTerm">关键字:学期</param>
public clsSchoolTermEN(string strSchoolTerm)
 {
strSchoolTerm = strSchoolTerm.Replace("'", "''");
if (strSchoolTerm.Length > 1)
{
throw new Exception("在表:SchoolTerm中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSchoolTerm)  ==  true)
{
throw new Exception("在表:SchoolTerm中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSchoolTerm);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSchoolTerm = strSchoolTerm;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SchoolTerm");
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
if (strAttributeName  ==  conSchoolTerm.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conSchoolTerm.SchoolTermName)
{
return mstrSchoolTermName;
}
else if (strAttributeName  ==  conSchoolTerm.IsCurrentSchoolTerm)
{
return mbolIsCurrentSchoolTerm;
}
return null;
}
set
{
if (strAttributeName  ==  conSchoolTerm.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conSchoolTerm.SchoolTerm);
}
else if (strAttributeName  ==  conSchoolTerm.SchoolTermName)
{
mstrSchoolTermName = value.ToString();
 AddUpdatedFld(conSchoolTerm.SchoolTermName);
}
else if (strAttributeName  ==  conSchoolTerm.IsCurrentSchoolTerm)
{
mbolIsCurrentSchoolTerm = TransNullToBool(value.ToString());
 AddUpdatedFld(conSchoolTerm.IsCurrentSchoolTerm);
}
}
}
public object this[int intIndex]
{
get
{
if (conSchoolTerm.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conSchoolTerm.SchoolTermName  ==  AttributeName[intIndex])
{
return mstrSchoolTermName;
}
else if (conSchoolTerm.IsCurrentSchoolTerm  ==  AttributeName[intIndex])
{
return mbolIsCurrentSchoolTerm;
}
return null;
}
set
{
if (conSchoolTerm.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conSchoolTerm.SchoolTerm);
}
else if (conSchoolTerm.SchoolTermName  ==  AttributeName[intIndex])
{
mstrSchoolTermName = value.ToString();
 AddUpdatedFld(conSchoolTerm.SchoolTermName);
}
else if (conSchoolTerm.IsCurrentSchoolTerm  ==  AttributeName[intIndex])
{
mbolIsCurrentSchoolTerm = TransNullToBool(value.ToString());
 AddUpdatedFld(conSchoolTerm.IsCurrentSchoolTerm);
}
}
}

/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(conSchoolTerm.SchoolTerm);
}
}
/// <summary>
/// 学期名(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTermName
{
get
{
return mstrSchoolTermName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTermName = value;
}
else
{
 mstrSchoolTermName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSchoolTerm.SchoolTermName);
}
}
/// <summary>
/// 学期(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrentSchoolTerm
{
get
{
return mbolIsCurrentSchoolTerm;
}
set
{
 mbolIsCurrentSchoolTerm = value;
//记录修改过的字段
 AddUpdatedFld(conSchoolTerm.IsCurrentSchoolTerm);
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
  return mstrSchoolTerm;
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
  return mstrSchoolTermName;
 }
 }
}
 /// <summary>
 /// 学期(SchoolTerm)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSchoolTerm
{
public const string _CurrTabName = "SchoolTerm"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SchoolTerm"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SchoolTerm", "SchoolTermName", "IsCurrentSchoolTerm"};
//以下是属性变量


 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"SchoolTermName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTermName = "SchoolTermName";    //学期名

 /// <summary>
 /// 常量:"IsCurrentSchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrentSchoolTerm = "IsCurrentSchoolTerm";    //学期
}

}