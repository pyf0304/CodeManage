
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseSenateClassEN
 表名:PubClassCaseSenateClass(01120509)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表PubClassCaseSenateClass的关键字(IdPubClassCaseSenateClass)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseSenateClass_PubClassCaseSenateClass
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPubClassCaseSenateClass">表关键字</param>
public K_IdPubClassCaseSenateClass_PubClassCaseSenateClass(string strIdPubClassCaseSenateClass)
{
if (IsValid(strIdPubClassCaseSenateClass)) Value = strIdPubClassCaseSenateClass;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPubClassCaseSenateClass)
{
if (string.IsNullOrEmpty(strIdPubClassCaseSenateClass) == true) return false;
if (strIdPubClassCaseSenateClass.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseSenateClass_PubClassCaseSenateClass]类型的对象</returns>
public static implicit operator K_IdPubClassCaseSenateClass_PubClassCaseSenateClass(string value)
{
return new K_IdPubClassCaseSenateClass_PubClassCaseSenateClass(value);
}
}
 /// <summary>
 /// 公开课案例评议类别(PubClassCaseSenateClass)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubClassCaseSenateClassEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubClassCaseSenateClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseSenateClass"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdPubClassCaseSenateClass", "PubClassCaseSenateClassID", "PubClassCaseSenateClassName", "Memo"};

protected string mstrIdPubClassCaseSenateClass;    //公开课案例评议类别流水号
protected string mstrPubClassCaseSenateClassID;    //公开课案例评议类别ID
protected string mstrPubClassCaseSenateClassName;    //公开课案例评议类别名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubClassCaseSenateClassEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseSenateClass");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPubClassCaseSenateClass">关键字:公开课案例评议类别流水号</param>
public clsPubClassCaseSenateClassEN(string strIdPubClassCaseSenateClass)
 {
strIdPubClassCaseSenateClass = strIdPubClassCaseSenateClass.Replace("'", "''");
if (strIdPubClassCaseSenateClass.Length > 4)
{
throw new Exception("在表:PubClassCaseSenateClass中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPubClassCaseSenateClass)  ==  true)
{
throw new Exception("在表:PubClassCaseSenateClass中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubClassCaseSenateClass);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPubClassCaseSenateClass = strIdPubClassCaseSenateClass;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseSenateClass");
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
if (strAttributeName  ==  conPubClassCaseSenateClass.IdPubClassCaseSenateClass)
{
return mstrIdPubClassCaseSenateClass;
}
else if (strAttributeName  ==  conPubClassCaseSenateClass.PubClassCaseSenateClassID)
{
return mstrPubClassCaseSenateClassID;
}
else if (strAttributeName  ==  conPubClassCaseSenateClass.PubClassCaseSenateClassName)
{
return mstrPubClassCaseSenateClassName;
}
else if (strAttributeName  ==  conPubClassCaseSenateClass.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPubClassCaseSenateClass.IdPubClassCaseSenateClass)
{
mstrIdPubClassCaseSenateClass = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateClass.IdPubClassCaseSenateClass);
}
else if (strAttributeName  ==  conPubClassCaseSenateClass.PubClassCaseSenateClassID)
{
mstrPubClassCaseSenateClassID = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateClass.PubClassCaseSenateClassID);
}
else if (strAttributeName  ==  conPubClassCaseSenateClass.PubClassCaseSenateClassName)
{
mstrPubClassCaseSenateClassName = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateClass.PubClassCaseSenateClassName);
}
else if (strAttributeName  ==  conPubClassCaseSenateClass.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateClass.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubClassCaseSenateClass.IdPubClassCaseSenateClass  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateClass;
}
else if (conPubClassCaseSenateClass.PubClassCaseSenateClassID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateClassID;
}
else if (conPubClassCaseSenateClass.PubClassCaseSenateClassName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateClassName;
}
else if (conPubClassCaseSenateClass.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPubClassCaseSenateClass.IdPubClassCaseSenateClass  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateClass = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateClass.IdPubClassCaseSenateClass);
}
else if (conPubClassCaseSenateClass.PubClassCaseSenateClassID  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateClassID = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateClass.PubClassCaseSenateClassID);
}
else if (conPubClassCaseSenateClass.PubClassCaseSenateClassName  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateClassName = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateClass.PubClassCaseSenateClassName);
}
else if (conPubClassCaseSenateClass.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubClassCaseSenateClass.Memo);
}
}
}

/// <summary>
/// 公开课案例评议类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCaseSenateClass
{
get
{
return mstrIdPubClassCaseSenateClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCaseSenateClass = value;
}
else
{
 mstrIdPubClassCaseSenateClass = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateClass.IdPubClassCaseSenateClass);
}
}
/// <summary>
/// 公开课案例评议类别ID(说明:;字段类型:varchar;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateClassID
{
get
{
return mstrPubClassCaseSenateClassID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateClassID = value;
}
else
{
 mstrPubClassCaseSenateClassID = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateClass.PubClassCaseSenateClassID);
}
}
/// <summary>
/// 公开课案例评议类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateClassName
{
get
{
return mstrPubClassCaseSenateClassName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateClassName = value;
}
else
{
 mstrPubClassCaseSenateClassName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenateClass.PubClassCaseSenateClassName);
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
 AddUpdatedFld(conPubClassCaseSenateClass.Memo);
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
  return mstrIdPubClassCaseSenateClass;
 }
 }
}
 /// <summary>
 /// 公开课案例评议类别(PubClassCaseSenateClass)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubClassCaseSenateClass
{
public const string _CurrTabName = "PubClassCaseSenateClass"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseSenateClass"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseSenateClass", "PubClassCaseSenateClassID", "PubClassCaseSenateClassName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseSenateClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenateClass = "IdPubClassCaseSenateClass";    //公开课案例评议类别流水号

 /// <summary>
 /// 常量:"PubClassCaseSenateClassID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateClassID = "PubClassCaseSenateClassID";    //公开课案例评议类别ID

 /// <summary>
 /// 常量:"PubClassCaseSenateClassName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateClassName = "PubClassCaseSenateClassName";    //公开课案例评议类别名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}