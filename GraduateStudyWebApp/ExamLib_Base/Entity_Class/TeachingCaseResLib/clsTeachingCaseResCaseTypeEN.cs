
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingCaseResCaseTypeEN
 表名:TeachingCaseResCaseType(01120514)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
 /// 表TeachingCaseResCaseType的关键字(IdTeachingCaseResCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachingCaseResCaseType_TeachingCaseResCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeachingCaseResCaseType">表关键字</param>
public K_IdTeachingCaseResCaseType_TeachingCaseResCaseType(string strIdTeachingCaseResCaseType)
{
if (IsValid(strIdTeachingCaseResCaseType)) Value = strIdTeachingCaseResCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeachingCaseResCaseType)
{
if (string.IsNullOrEmpty(strIdTeachingCaseResCaseType) == true) return false;
if (strIdTeachingCaseResCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachingCaseResCaseType_TeachingCaseResCaseType]类型的对象</returns>
public static implicit operator K_IdTeachingCaseResCaseType_TeachingCaseResCaseType(string value)
{
return new K_IdTeachingCaseResCaseType_TeachingCaseResCaseType(value);
}
}
 /// <summary>
 /// 教学案例资源案例类型(TeachingCaseResCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachingCaseResCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachingCaseResCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachingCaseResCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdTeachingCaseResCaseType", "TeachingCaseResCaseTypeId", "TeachingCaseResCaseTypeName", "Memo"};

protected string mstrIdTeachingCaseResCaseType;    //教学案例资源类型流水号
protected string mstrTeachingCaseResCaseTypeId;    //教学案例资源案例类型Id
protected string mstrTeachingCaseResCaseTypeName;    //教学案例资源案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachingCaseResCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachingCaseResCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeachingCaseResCaseType">关键字:教学案例资源类型流水号</param>
public clsTeachingCaseResCaseTypeEN(string strIdTeachingCaseResCaseType)
 {
strIdTeachingCaseResCaseType = strIdTeachingCaseResCaseType.Replace("'", "''");
if (strIdTeachingCaseResCaseType.Length > 4)
{
throw new Exception("在表:TeachingCaseResCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachingCaseResCaseType)  ==  true)
{
throw new Exception("在表:TeachingCaseResCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingCaseResCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeachingCaseResCaseType = strIdTeachingCaseResCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachingCaseResCaseType");
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
if (strAttributeName  ==  conTeachingCaseResCaseType.IdTeachingCaseResCaseType)
{
return mstrIdTeachingCaseResCaseType;
}
else if (strAttributeName  ==  conTeachingCaseResCaseType.TeachingCaseResCaseTypeId)
{
return mstrTeachingCaseResCaseTypeId;
}
else if (strAttributeName  ==  conTeachingCaseResCaseType.TeachingCaseResCaseTypeName)
{
return mstrTeachingCaseResCaseTypeName;
}
else if (strAttributeName  ==  conTeachingCaseResCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachingCaseResCaseType.IdTeachingCaseResCaseType)
{
mstrIdTeachingCaseResCaseType = value.ToString();
 AddUpdatedFld(conTeachingCaseResCaseType.IdTeachingCaseResCaseType);
}
else if (strAttributeName  ==  conTeachingCaseResCaseType.TeachingCaseResCaseTypeId)
{
mstrTeachingCaseResCaseTypeId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCaseType.TeachingCaseResCaseTypeId);
}
else if (strAttributeName  ==  conTeachingCaseResCaseType.TeachingCaseResCaseTypeName)
{
mstrTeachingCaseResCaseTypeName = value.ToString();
 AddUpdatedFld(conTeachingCaseResCaseType.TeachingCaseResCaseTypeName);
}
else if (strAttributeName  ==  conTeachingCaseResCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingCaseResCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachingCaseResCaseType.IdTeachingCaseResCaseType  ==  AttributeName[intIndex])
{
return mstrIdTeachingCaseResCaseType;
}
else if (conTeachingCaseResCaseType.TeachingCaseResCaseTypeId  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTypeId;
}
else if (conTeachingCaseResCaseType.TeachingCaseResCaseTypeName  ==  AttributeName[intIndex])
{
return mstrTeachingCaseResCaseTypeName;
}
else if (conTeachingCaseResCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachingCaseResCaseType.IdTeachingCaseResCaseType  ==  AttributeName[intIndex])
{
mstrIdTeachingCaseResCaseType = value.ToString();
 AddUpdatedFld(conTeachingCaseResCaseType.IdTeachingCaseResCaseType);
}
else if (conTeachingCaseResCaseType.TeachingCaseResCaseTypeId  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTypeId = value.ToString();
 AddUpdatedFld(conTeachingCaseResCaseType.TeachingCaseResCaseTypeId);
}
else if (conTeachingCaseResCaseType.TeachingCaseResCaseTypeName  ==  AttributeName[intIndex])
{
mstrTeachingCaseResCaseTypeName = value.ToString();
 AddUpdatedFld(conTeachingCaseResCaseType.TeachingCaseResCaseTypeName);
}
else if (conTeachingCaseResCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingCaseResCaseType.Memo);
}
}
}

/// <summary>
/// 教学案例资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingCaseResCaseType
{
get
{
return mstrIdTeachingCaseResCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingCaseResCaseType = value;
}
else
{
 mstrIdTeachingCaseResCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingCaseResCaseType.IdTeachingCaseResCaseType);
}
}
/// <summary>
/// 教学案例资源案例类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTypeId
{
get
{
return mstrTeachingCaseResCaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTypeId = value;
}
else
{
 mstrTeachingCaseResCaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingCaseResCaseType.TeachingCaseResCaseTypeId);
}
}
/// <summary>
/// 教学案例资源案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingCaseResCaseTypeName
{
get
{
return mstrTeachingCaseResCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingCaseResCaseTypeName = value;
}
else
{
 mstrTeachingCaseResCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingCaseResCaseType.TeachingCaseResCaseTypeName);
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
 AddUpdatedFld(conTeachingCaseResCaseType.Memo);
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
  return mstrIdTeachingCaseResCaseType;
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
  return mstrTeachingCaseResCaseTypeName;
 }
 }
}
 /// <summary>
 /// 教学案例资源案例类型(TeachingCaseResCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachingCaseResCaseType
{
public const string _CurrTabName = "TeachingCaseResCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachingCaseResCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachingCaseResCaseType", "TeachingCaseResCaseTypeId", "TeachingCaseResCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachingCaseResCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingCaseResCaseType = "IdTeachingCaseResCaseType";    //教学案例资源类型流水号

 /// <summary>
 /// 常量:"TeachingCaseResCaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTypeId = "TeachingCaseResCaseTypeId";    //教学案例资源案例类型Id

 /// <summary>
 /// 常量:"TeachingCaseResCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingCaseResCaseTypeName = "TeachingCaseResCaseTypeName";    //教学案例资源案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}