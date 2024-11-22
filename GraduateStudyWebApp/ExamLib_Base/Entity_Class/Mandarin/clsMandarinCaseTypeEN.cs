
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMandarinCaseTypeEN
 表名:MandarinCaseType(01120501)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// 表MandarinCaseType的关键字(IdMandarinCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMandarinCaseType_MandarinCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMandarinCaseType">表关键字</param>
public K_IdMandarinCaseType_MandarinCaseType(string strIdMandarinCaseType)
{
if (IsValid(strIdMandarinCaseType)) Value = strIdMandarinCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMandarinCaseType)
{
if (string.IsNullOrEmpty(strIdMandarinCaseType) == true) return false;
if (strIdMandarinCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMandarinCaseType_MandarinCaseType]类型的对象</returns>
public static implicit operator K_IdMandarinCaseType_MandarinCaseType(string value)
{
return new K_IdMandarinCaseType_MandarinCaseType(value);
}
}
 /// <summary>
 /// 普通话案例类型(MandarinCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMandarinCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MandarinCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMandarinCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdMandarinCaseType", "MandarinCaseTypeID", "MandarinCaseTypeName", "Memo"};

protected string mstrIdMandarinCaseType;    //普通话案例类型流水号
protected string mstrMandarinCaseTypeID;    //普通话案例类型ID
protected string mstrMandarinCaseTypeName;    //普通话案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMandarinCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMandarinCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMandarinCaseType">关键字:普通话案例类型流水号</param>
public clsMandarinCaseTypeEN(string strIdMandarinCaseType)
 {
strIdMandarinCaseType = strIdMandarinCaseType.Replace("'", "''");
if (strIdMandarinCaseType.Length > 4)
{
throw new Exception("在表:MandarinCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMandarinCaseType)  ==  true)
{
throw new Exception("在表:MandarinCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMandarinCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMandarinCaseType = strIdMandarinCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMandarinCaseType");
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
if (strAttributeName  ==  conMandarinCaseType.IdMandarinCaseType)
{
return mstrIdMandarinCaseType;
}
else if (strAttributeName  ==  conMandarinCaseType.MandarinCaseTypeID)
{
return mstrMandarinCaseTypeID;
}
else if (strAttributeName  ==  conMandarinCaseType.MandarinCaseTypeName)
{
return mstrMandarinCaseTypeName;
}
else if (strAttributeName  ==  conMandarinCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMandarinCaseType.IdMandarinCaseType)
{
mstrIdMandarinCaseType = value.ToString();
 AddUpdatedFld(conMandarinCaseType.IdMandarinCaseType);
}
else if (strAttributeName  ==  conMandarinCaseType.MandarinCaseTypeID)
{
mstrMandarinCaseTypeID = value.ToString();
 AddUpdatedFld(conMandarinCaseType.MandarinCaseTypeID);
}
else if (strAttributeName  ==  conMandarinCaseType.MandarinCaseTypeName)
{
mstrMandarinCaseTypeName = value.ToString();
 AddUpdatedFld(conMandarinCaseType.MandarinCaseTypeName);
}
else if (strAttributeName  ==  conMandarinCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMandarinCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMandarinCaseType.IdMandarinCaseType  ==  AttributeName[intIndex])
{
return mstrIdMandarinCaseType;
}
else if (conMandarinCaseType.MandarinCaseTypeID  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTypeID;
}
else if (conMandarinCaseType.MandarinCaseTypeName  ==  AttributeName[intIndex])
{
return mstrMandarinCaseTypeName;
}
else if (conMandarinCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMandarinCaseType.IdMandarinCaseType  ==  AttributeName[intIndex])
{
mstrIdMandarinCaseType = value.ToString();
 AddUpdatedFld(conMandarinCaseType.IdMandarinCaseType);
}
else if (conMandarinCaseType.MandarinCaseTypeID  ==  AttributeName[intIndex])
{
mstrMandarinCaseTypeID = value.ToString();
 AddUpdatedFld(conMandarinCaseType.MandarinCaseTypeID);
}
else if (conMandarinCaseType.MandarinCaseTypeName  ==  AttributeName[intIndex])
{
mstrMandarinCaseTypeName = value.ToString();
 AddUpdatedFld(conMandarinCaseType.MandarinCaseTypeName);
}
else if (conMandarinCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMandarinCaseType.Memo);
}
}
}

/// <summary>
/// 普通话案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMandarinCaseType
{
get
{
return mstrIdMandarinCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMandarinCaseType = value;
}
else
{
 mstrIdMandarinCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCaseType.IdMandarinCaseType);
}
}
/// <summary>
/// 普通话案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseTypeID
{
get
{
return mstrMandarinCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseTypeID = value;
}
else
{
 mstrMandarinCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCaseType.MandarinCaseTypeID);
}
}
/// <summary>
/// 普通话案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MandarinCaseTypeName
{
get
{
return mstrMandarinCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMandarinCaseTypeName = value;
}
else
{
 mstrMandarinCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMandarinCaseType.MandarinCaseTypeName);
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
 AddUpdatedFld(conMandarinCaseType.Memo);
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
  return mstrIdMandarinCaseType;
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
  return mstrMandarinCaseTypeName;
 }
 }
}
 /// <summary>
 /// 普通话案例类型(MandarinCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMandarinCaseType
{
public const string _CurrTabName = "MandarinCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMandarinCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMandarinCaseType", "MandarinCaseTypeID", "MandarinCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMandarinCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMandarinCaseType = "IdMandarinCaseType";    //普通话案例类型流水号

 /// <summary>
 /// 常量:"MandarinCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseTypeID = "MandarinCaseTypeID";    //普通话案例类型ID

 /// <summary>
 /// 常量:"MandarinCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MandarinCaseTypeName = "MandarinCaseTypeName";    //普通话案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}