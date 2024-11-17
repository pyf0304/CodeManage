
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStuTypeEN
 表名:StuType(01160061)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:57
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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

namespace SimplePrj.Entity
{
 /// <summary>
 /// 表StuType的关键字(StuTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StuTypeId_StuType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStuTypeId">表关键字</param>
public K_StuTypeId_StuType(string strStuTypeId)
{
if (IsValid(strStuTypeId)) Value = strStuTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strStuTypeId)
{
if (string.IsNullOrEmpty(strStuTypeId) == true) return false;
if (strStuTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StuTypeId_StuType]类型的对象</returns>
public static implicit operator K_StuTypeId_StuType(string value)
{
return new K_StuTypeId_StuType(value);
}
}
 /// <summary>
 /// StuType(StuType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsStuTypeEN : clsEntityBase2
{
public const string _CurrTabName_S = "StuType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StuTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"StuTypeId", "StuTypeName", "Memo"};
//以下是属性变量

protected string mstrStuTypeId;    //学生类型Id
protected string mstrStuTypeName;    //学生类型名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsStuTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "StuType";
 lstKeyFldNames.Add("StuTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStuTypeId">关键字:学生类型Id</param>
public clsStuTypeEN(string strStuTypeId)
 {
strStuTypeId = strStuTypeId.Replace("'", "''");
if (strStuTypeId.Length > 4)
{
throw new Exception("在表:StuType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStuTypeId)  ==  true)
{
throw new Exception("在表:StuType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStuTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStuTypeId = strStuTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "StuType";
 lstKeyFldNames.Add("StuTypeId");
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
if (strAttributeName  ==  conStuType.StuTypeId)
{
return mstrStuTypeId;
}
else if (strAttributeName  ==  conStuType.StuTypeName)
{
return mstrStuTypeName;
}
else if (strAttributeName  ==  conStuType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conStuType.StuTypeId)
{
mstrStuTypeId = value.ToString();
 AddUpdatedFld(conStuType.StuTypeId);
}
else if (strAttributeName  ==  conStuType.StuTypeName)
{
mstrStuTypeName = value.ToString();
 AddUpdatedFld(conStuType.StuTypeName);
}
else if (strAttributeName  ==  conStuType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStuType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conStuType.StuTypeId  ==  AttributeName[intIndex])
{
return mstrStuTypeId;
}
else if (conStuType.StuTypeName  ==  AttributeName[intIndex])
{
return mstrStuTypeName;
}
else if (conStuType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conStuType.StuTypeId  ==  AttributeName[intIndex])
{
mstrStuTypeId = value.ToString();
 AddUpdatedFld(conStuType.StuTypeId);
}
else if (conStuType.StuTypeName  ==  AttributeName[intIndex])
{
mstrStuTypeName = value.ToString();
 AddUpdatedFld(conStuType.StuTypeName);
}
else if (conStuType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStuType.Memo);
}
}
}

/// <summary>
/// 学生类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeId
{
get
{
return mstrStuTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeId = value;
}
else
{
 mstrStuTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conStuType.StuTypeId);
}
}
/// <summary>
/// 学生类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeName
{
get
{
return mstrStuTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeName = value;
}
else
{
 mstrStuTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conStuType.StuTypeName);
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
 AddUpdatedFld(conStuType.Memo);
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
  return mstrStuTypeId;
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
  return mstrStuTypeName;
 }
 }
}
 /// <summary>
 /// StuType(StuType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conStuType
{
public const string _CurrTabName_S = "StuType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StuTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StuTypeId", "StuTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"StuTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeId = "StuTypeId";    //学生类型Id

 /// <summary>
 /// 常量:"StuTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeName = "StuTypeName";    //学生类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}