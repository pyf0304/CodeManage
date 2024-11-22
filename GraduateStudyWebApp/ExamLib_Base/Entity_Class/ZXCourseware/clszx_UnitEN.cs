
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_UnitEN
 表名:zx_Unit(01120713)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_Unit的关键字(UnitId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UnitId_zx_Unit
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUnitId">表关键字</param>
public K_UnitId_zx_Unit(string strUnitId)
{
if (IsValid(strUnitId)) Value = strUnitId;
else
{
Value = null;
}
}
private static bool IsValid(string strUnitId)
{
if (string.IsNullOrEmpty(strUnitId) == true) return false;
if (strUnitId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UnitId_zx_Unit]类型的对象</returns>
public static implicit operator K_UnitId_zx_Unit(string value)
{
return new K_UnitId_zx_Unit(value);
}
}
 /// <summary>
 /// 中学课件单元表(zx_Unit)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_UnitEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_Unit"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UnitId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"UnitId", "UnitName", "Memo"};

protected string mstrUnitId;    //UnitId
protected string mstrUnitName;    //UnitName
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_UnitEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UnitId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUnitId">关键字:UnitId</param>
public clszx_UnitEN(string strUnitId)
 {
strUnitId = strUnitId.Replace("'", "''");
if (strUnitId.Length > 4)
{
throw new Exception("在表:zx_Unit中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUnitId)  ==  true)
{
throw new Exception("在表:zx_Unit中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUnitId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUnitId = strUnitId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UnitId");
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
if (strAttributeName  ==  conzx_Unit.UnitId)
{
return mstrUnitId;
}
else if (strAttributeName  ==  conzx_Unit.UnitName)
{
return mstrUnitName;
}
else if (strAttributeName  ==  conzx_Unit.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_Unit.UnitId)
{
mstrUnitId = value.ToString();
 AddUpdatedFld(conzx_Unit.UnitId);
}
else if (strAttributeName  ==  conzx_Unit.UnitName)
{
mstrUnitName = value.ToString();
 AddUpdatedFld(conzx_Unit.UnitName);
}
else if (strAttributeName  ==  conzx_Unit.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Unit.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_Unit.UnitId  ==  AttributeName[intIndex])
{
return mstrUnitId;
}
else if (conzx_Unit.UnitName  ==  AttributeName[intIndex])
{
return mstrUnitName;
}
else if (conzx_Unit.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_Unit.UnitId  ==  AttributeName[intIndex])
{
mstrUnitId = value.ToString();
 AddUpdatedFld(conzx_Unit.UnitId);
}
else if (conzx_Unit.UnitName  ==  AttributeName[intIndex])
{
mstrUnitName = value.ToString();
 AddUpdatedFld(conzx_Unit.UnitName);
}
else if (conzx_Unit.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Unit.Memo);
}
}
}

/// <summary>
/// UnitId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UnitId
{
get
{
return mstrUnitId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUnitId = value;
}
else
{
 mstrUnitId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Unit.UnitId);
}
}
/// <summary>
/// UnitName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UnitName
{
get
{
return mstrUnitName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUnitName = value;
}
else
{
 mstrUnitName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Unit.UnitName);
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
 AddUpdatedFld(conzx_Unit.Memo);
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
  return mstrUnitId;
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
  return mstrUnitName;
 }
 }
}
 /// <summary>
 /// 中学课件单元表(zx_Unit)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_Unit
{
public const string _CurrTabName = "zx_Unit"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UnitId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UnitId", "UnitName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UnitId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UnitId = "UnitId";    //UnitId

 /// <summary>
 /// 常量:"UnitName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UnitName = "UnitName";    //UnitName

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}