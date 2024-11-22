
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWritingOnBBCaseTypeEN
 表名:WritingOnBBCaseType(01120526)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// 表WritingOnBBCaseType的关键字(IdWritingOnBBCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWritingOnBBCaseType_WritingOnBBCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdWritingOnBBCaseType">表关键字</param>
public K_IdWritingOnBBCaseType_WritingOnBBCaseType(string strIdWritingOnBBCaseType)
{
if (IsValid(strIdWritingOnBBCaseType)) Value = strIdWritingOnBBCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdWritingOnBBCaseType)
{
if (string.IsNullOrEmpty(strIdWritingOnBBCaseType) == true) return false;
if (strIdWritingOnBBCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWritingOnBBCaseType_WritingOnBBCaseType]类型的对象</returns>
public static implicit operator K_IdWritingOnBBCaseType_WritingOnBBCaseType(string value)
{
return new K_IdWritingOnBBCaseType_WritingOnBBCaseType(value);
}
}
 /// <summary>
 /// 板书案例类型(WritingOnBBCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsWritingOnBBCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "WritingOnBBCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWritingOnBBCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdWritingOnBBCaseType", "WritingOnBBCaseTypeID", "WritingOnBBCaseTypeName", "Memo"};

protected string mstrIdWritingOnBBCaseType;    //板书案例类型流水号
protected string mstrWritingOnBBCaseTypeID;    //板书案例类型ID
protected string mstrWritingOnBBCaseTypeName;    //板书案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsWritingOnBBCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWritingOnBBCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdWritingOnBBCaseType">关键字:板书案例类型流水号</param>
public clsWritingOnBBCaseTypeEN(string strIdWritingOnBBCaseType)
 {
strIdWritingOnBBCaseType = strIdWritingOnBBCaseType.Replace("'", "''");
if (strIdWritingOnBBCaseType.Length > 4)
{
throw new Exception("在表:WritingOnBBCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdWritingOnBBCaseType)  ==  true)
{
throw new Exception("在表:WritingOnBBCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdWritingOnBBCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdWritingOnBBCaseType = strIdWritingOnBBCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWritingOnBBCaseType");
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
if (strAttributeName  ==  conWritingOnBBCaseType.IdWritingOnBBCaseType)
{
return mstrIdWritingOnBBCaseType;
}
else if (strAttributeName  ==  conWritingOnBBCaseType.WritingOnBBCaseTypeID)
{
return mstrWritingOnBBCaseTypeID;
}
else if (strAttributeName  ==  conWritingOnBBCaseType.WritingOnBBCaseTypeName)
{
return mstrWritingOnBBCaseTypeName;
}
else if (strAttributeName  ==  conWritingOnBBCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conWritingOnBBCaseType.IdWritingOnBBCaseType)
{
mstrIdWritingOnBBCaseType = value.ToString();
 AddUpdatedFld(conWritingOnBBCaseType.IdWritingOnBBCaseType);
}
else if (strAttributeName  ==  conWritingOnBBCaseType.WritingOnBBCaseTypeID)
{
mstrWritingOnBBCaseTypeID = value.ToString();
 AddUpdatedFld(conWritingOnBBCaseType.WritingOnBBCaseTypeID);
}
else if (strAttributeName  ==  conWritingOnBBCaseType.WritingOnBBCaseTypeName)
{
mstrWritingOnBBCaseTypeName = value.ToString();
 AddUpdatedFld(conWritingOnBBCaseType.WritingOnBBCaseTypeName);
}
else if (strAttributeName  ==  conWritingOnBBCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWritingOnBBCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conWritingOnBBCaseType.IdWritingOnBBCaseType  ==  AttributeName[intIndex])
{
return mstrIdWritingOnBBCaseType;
}
else if (conWritingOnBBCaseType.WritingOnBBCaseTypeID  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTypeID;
}
else if (conWritingOnBBCaseType.WritingOnBBCaseTypeName  ==  AttributeName[intIndex])
{
return mstrWritingOnBBCaseTypeName;
}
else if (conWritingOnBBCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conWritingOnBBCaseType.IdWritingOnBBCaseType  ==  AttributeName[intIndex])
{
mstrIdWritingOnBBCaseType = value.ToString();
 AddUpdatedFld(conWritingOnBBCaseType.IdWritingOnBBCaseType);
}
else if (conWritingOnBBCaseType.WritingOnBBCaseTypeID  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTypeID = value.ToString();
 AddUpdatedFld(conWritingOnBBCaseType.WritingOnBBCaseTypeID);
}
else if (conWritingOnBBCaseType.WritingOnBBCaseTypeName  ==  AttributeName[intIndex])
{
mstrWritingOnBBCaseTypeName = value.ToString();
 AddUpdatedFld(conWritingOnBBCaseType.WritingOnBBCaseTypeName);
}
else if (conWritingOnBBCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWritingOnBBCaseType.Memo);
}
}
}

/// <summary>
/// 板书案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdWritingOnBBCaseType
{
get
{
return mstrIdWritingOnBBCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdWritingOnBBCaseType = value;
}
else
{
 mstrIdWritingOnBBCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCaseType.IdWritingOnBBCaseType);
}
}
/// <summary>
/// 板书案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseTypeID
{
get
{
return mstrWritingOnBBCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseTypeID = value;
}
else
{
 mstrWritingOnBBCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCaseType.WritingOnBBCaseTypeID);
}
}
/// <summary>
/// 板书案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WritingOnBBCaseTypeName
{
get
{
return mstrWritingOnBBCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWritingOnBBCaseTypeName = value;
}
else
{
 mstrWritingOnBBCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conWritingOnBBCaseType.WritingOnBBCaseTypeName);
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
 AddUpdatedFld(conWritingOnBBCaseType.Memo);
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
  return mstrIdWritingOnBBCaseType;
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
  return mstrWritingOnBBCaseTypeName;
 }
 }
}
 /// <summary>
 /// 板书案例类型(WritingOnBBCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conWritingOnBBCaseType
{
public const string _CurrTabName = "WritingOnBBCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWritingOnBBCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWritingOnBBCaseType", "WritingOnBBCaseTypeID", "WritingOnBBCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWritingOnBBCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWritingOnBBCaseType = "IdWritingOnBBCaseType";    //板书案例类型流水号

 /// <summary>
 /// 常量:"WritingOnBBCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseTypeID = "WritingOnBBCaseTypeID";    //板书案例类型ID

 /// <summary>
 /// 常量:"WritingOnBBCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WritingOnBBCaseTypeName = "WritingOnBBCaseTypeName";    //板书案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}