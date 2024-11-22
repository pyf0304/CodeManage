
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMyTest1EN
 表名:MyTest1(01120220)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表MyTest1的关键字(StrKey)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StrKey_MyTest1
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStrKey">表关键字</param>
public K_StrKey_MyTest1(string strStrKey)
{
if (IsValid(strStrKey)) Value = strStrKey;
else
{
Value = null;
}
}
private static bool IsValid(string strStrKey)
{
if (string.IsNullOrEmpty(strStrKey) == true) return false;
if (strStrKey.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StrKey_MyTest1]类型的对象</returns>
public static implicit operator K_StrKey_MyTest1(string value)
{
return new K_StrKey_MyTest1(value);
}
}
 /// <summary>
 /// 测试表1(MyTest1)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMyTest1EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MyTest1"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StrKey"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"StrKey", "myInt", "myLong", "myString", "myBool"};

protected string mstrStrKey;    //s主键
protected int mintmyInt;    //my整型
protected long mlngmyLong;    //my长整型
protected string mstrmyString;    //my字符串
protected bool mbolmyBool;    //my布尔型

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMyTest1EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StrKey");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStrKey">关键字:s主键</param>
public clsMyTest1EN(string strStrKey)
 {
strStrKey = strStrKey.Replace("'", "''");
if (strStrKey.Length > 4)
{
throw new Exception("在表:MyTest1中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStrKey)  ==  true)
{
throw new Exception("在表:MyTest1中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStrKey);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStrKey = strStrKey;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StrKey");
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
if (strAttributeName  ==  conMyTest1.StrKey)
{
return mstrStrKey;
}
else if (strAttributeName  ==  conMyTest1.myInt)
{
return mintmyInt;
}
else if (strAttributeName  ==  conMyTest1.myLong)
{
return mlngmyLong;
}
else if (strAttributeName  ==  conMyTest1.myString)
{
return mstrmyString;
}
else if (strAttributeName  ==  conMyTest1.myBool)
{
return mbolmyBool;
}
return null;
}
set
{
if (strAttributeName  ==  conMyTest1.StrKey)
{
mstrStrKey = value.ToString();
 AddUpdatedFld(conMyTest1.StrKey);
}
else if (strAttributeName  ==  conMyTest1.myInt)
{
mintmyInt = TransNullToInt(value.ToString());
 AddUpdatedFld(conMyTest1.myInt);
}
else if (strAttributeName  ==  conMyTest1.myLong)
{
mlngmyLong = TransNullToInt(value.ToString());
 AddUpdatedFld(conMyTest1.myLong);
}
else if (strAttributeName  ==  conMyTest1.myString)
{
mstrmyString = value.ToString();
 AddUpdatedFld(conMyTest1.myString);
}
else if (strAttributeName  ==  conMyTest1.myBool)
{
mbolmyBool = TransNullToBool(value.ToString());
 AddUpdatedFld(conMyTest1.myBool);
}
}
}
public object this[int intIndex]
{
get
{
if (conMyTest1.StrKey  ==  AttributeName[intIndex])
{
return mstrStrKey;
}
else if (conMyTest1.myInt  ==  AttributeName[intIndex])
{
return mintmyInt;
}
else if (conMyTest1.myLong  ==  AttributeName[intIndex])
{
return mlngmyLong;
}
else if (conMyTest1.myString  ==  AttributeName[intIndex])
{
return mstrmyString;
}
else if (conMyTest1.myBool  ==  AttributeName[intIndex])
{
return mbolmyBool;
}
return null;
}
set
{
if (conMyTest1.StrKey  ==  AttributeName[intIndex])
{
mstrStrKey = value.ToString();
 AddUpdatedFld(conMyTest1.StrKey);
}
else if (conMyTest1.myInt  ==  AttributeName[intIndex])
{
mintmyInt = TransNullToInt(value.ToString());
 AddUpdatedFld(conMyTest1.myInt);
}
else if (conMyTest1.myLong  ==  AttributeName[intIndex])
{
mlngmyLong = TransNullToInt(value.ToString());
 AddUpdatedFld(conMyTest1.myLong);
}
else if (conMyTest1.myString  ==  AttributeName[intIndex])
{
mstrmyString = value.ToString();
 AddUpdatedFld(conMyTest1.myString);
}
else if (conMyTest1.myBool  ==  AttributeName[intIndex])
{
mbolmyBool = TransNullToBool(value.ToString());
 AddUpdatedFld(conMyTest1.myBool);
}
}
}

/// <summary>
/// s主键(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StrKey
{
get
{
return mstrStrKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStrKey = value;
}
else
{
 mstrStrKey = value;
}
//记录修改过的字段
 AddUpdatedFld(conMyTest1.StrKey);
}
}
/// <summary>
/// my整型(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int myInt
{
get
{
return mintmyInt;
}
set
{
 mintmyInt = value;
//记录修改过的字段
 AddUpdatedFld(conMyTest1.myInt);
}
}
/// <summary>
/// my长整型(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long myLong
{
get
{
return mlngmyLong;
}
set
{
 mlngmyLong = value;
//记录修改过的字段
 AddUpdatedFld(conMyTest1.myLong);
}
}
/// <summary>
/// my字符串(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string myString
{
get
{
return mstrmyString;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmyString = value;
}
else
{
 mstrmyString = value;
}
//记录修改过的字段
 AddUpdatedFld(conMyTest1.myString);
}
}
/// <summary>
/// my布尔型(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool myBool
{
get
{
return mbolmyBool;
}
set
{
 mbolmyBool = value;
//记录修改过的字段
 AddUpdatedFld(conMyTest1.myBool);
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
  return mstrStrKey;
 }
 }
}
 /// <summary>
 /// 测试表1(MyTest1)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMyTest1
{
public const string _CurrTabName = "MyTest1"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StrKey"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StrKey", "myInt", "myLong", "myString", "myBool"};
//以下是属性变量


 /// <summary>
 /// 常量:"StrKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StrKey = "StrKey";    //s主键

 /// <summary>
 /// 常量:"myInt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string myInt = "myInt";    //my整型

 /// <summary>
 /// 常量:"myLong"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string myLong = "myLong";    //my长整型

 /// <summary>
 /// 常量:"myString"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string myString = "myString";    //my字符串

 /// <summary>
 /// 常量:"myBool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string myBool = "myBool";    //my布尔型
}

}