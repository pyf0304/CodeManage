
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSchoolYearEN
 表名:SchoolYear(01120134)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:43
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
 /// 表SchoolYear的关键字(SchoolYear)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SchoolYear_SchoolYear
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSchoolYear">表关键字</param>
public K_SchoolYear_SchoolYear(string strSchoolYear)
{
if (IsValid(strSchoolYear)) Value = strSchoolYear;
else
{
Value = null;
}
}
private static bool IsValid(string strSchoolYear)
{
if (string.IsNullOrEmpty(strSchoolYear) == true) return false;
if (strSchoolYear.Length > 10) return false;
if (strSchoolYear.IndexOf(' ') >= 0) return false;
if (strSchoolYear.IndexOf(')') >= 0) return false;
if (strSchoolYear.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SchoolYear_SchoolYear]类型的对象</returns>
public static implicit operator K_SchoolYear_SchoolYear(string value)
{
return new K_SchoolYear_SchoolYear(value);
}
}
 /// <summary>
 /// 学年(SchoolYear)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSchoolYearEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SchoolYear"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SchoolYear"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"SchoolYear", "SchoolYearName", "IsCurrentSchoolYear", "IsVisible"};

protected string mstrSchoolYear;    //学年
protected string mstrSchoolYearName;    //学年名
protected bool mbolIsCurrentSchoolYear;    //是否当前学年
protected bool mbolIsVisible;    //是否显示

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSchoolYearEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SchoolYear");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSchoolYear">关键字:学年</param>
public clsSchoolYearEN(string strSchoolYear)
 {
strSchoolYear = strSchoolYear.Replace("'", "''");
if (strSchoolYear.Length > 10)
{
throw new Exception("在表:SchoolYear中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSchoolYear)  ==  true)
{
throw new Exception("在表:SchoolYear中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSchoolYear);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSchoolYear = strSchoolYear;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SchoolYear");
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
if (strAttributeName  ==  conSchoolYear.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conSchoolYear.SchoolYearName)
{
return mstrSchoolYearName;
}
else if (strAttributeName  ==  conSchoolYear.IsCurrentSchoolYear)
{
return mbolIsCurrentSchoolYear;
}
else if (strAttributeName  ==  conSchoolYear.IsVisible)
{
return mbolIsVisible;
}
return null;
}
set
{
if (strAttributeName  ==  conSchoolYear.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conSchoolYear.SchoolYear);
}
else if (strAttributeName  ==  conSchoolYear.SchoolYearName)
{
mstrSchoolYearName = value.ToString();
 AddUpdatedFld(conSchoolYear.SchoolYearName);
}
else if (strAttributeName  ==  conSchoolYear.IsCurrentSchoolYear)
{
mbolIsCurrentSchoolYear = TransNullToBool(value.ToString());
 AddUpdatedFld(conSchoolYear.IsCurrentSchoolYear);
}
else if (strAttributeName  ==  conSchoolYear.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conSchoolYear.IsVisible);
}
}
}
public object this[int intIndex]
{
get
{
if (conSchoolYear.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conSchoolYear.SchoolYearName  ==  AttributeName[intIndex])
{
return mstrSchoolYearName;
}
else if (conSchoolYear.IsCurrentSchoolYear  ==  AttributeName[intIndex])
{
return mbolIsCurrentSchoolYear;
}
else if (conSchoolYear.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
return null;
}
set
{
if (conSchoolYear.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conSchoolYear.SchoolYear);
}
else if (conSchoolYear.SchoolYearName  ==  AttributeName[intIndex])
{
mstrSchoolYearName = value.ToString();
 AddUpdatedFld(conSchoolYear.SchoolYearName);
}
else if (conSchoolYear.IsCurrentSchoolYear  ==  AttributeName[intIndex])
{
mbolIsCurrentSchoolYear = TransNullToBool(value.ToString());
 AddUpdatedFld(conSchoolYear.IsCurrentSchoolYear);
}
else if (conSchoolYear.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conSchoolYear.IsVisible);
}
}
}

/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolYear
{
get
{
return mstrSchoolYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolYear = value;
}
else
{
 mstrSchoolYear = value;
}
//记录修改过的字段
 AddUpdatedFld(conSchoolYear.SchoolYear);
}
}
/// <summary>
/// 学年名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolYearName
{
get
{
return mstrSchoolYearName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolYearName = value;
}
else
{
 mstrSchoolYearName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSchoolYear.SchoolYearName);
}
}
/// <summary>
/// 是否当前学年(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrentSchoolYear
{
get
{
return mbolIsCurrentSchoolYear;
}
set
{
 mbolIsCurrentSchoolYear = value;
//记录修改过的字段
 AddUpdatedFld(conSchoolYear.IsCurrentSchoolYear);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conSchoolYear.IsVisible);
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
  return mstrSchoolYear;
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
  return mstrSchoolYearName;
 }
 }
}
 /// <summary>
 /// 学年(SchoolYear)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSchoolYear
{
public const string _CurrTabName = "SchoolYear"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SchoolYear"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SchoolYear", "SchoolYearName", "IsCurrentSchoolYear", "IsVisible"};
//以下是属性变量


 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"SchoolYearName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYearName = "SchoolYearName";    //学年名

 /// <summary>
 /// 常量:"IsCurrentSchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrentSchoolYear = "IsCurrentSchoolYear";    //是否当前学年

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示
}

}