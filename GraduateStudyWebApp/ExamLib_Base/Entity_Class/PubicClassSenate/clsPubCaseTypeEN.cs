
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubCaseTypeEN
 表名:PubCaseType(01120506)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表PubCaseType的关键字(IdPubCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubCaseType_PubCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPubCaseType">表关键字</param>
public K_IdPubCaseType_PubCaseType(string strIdPubCaseType)
{
if (IsValid(strIdPubCaseType)) Value = strIdPubCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPubCaseType)
{
if (string.IsNullOrEmpty(strIdPubCaseType) == true) return false;
if (strIdPubCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubCaseType_PubCaseType]类型的对象</returns>
public static implicit operator K_IdPubCaseType_PubCaseType(string value)
{
return new K_IdPubCaseType_PubCaseType(value);
}
}
 /// <summary>
 /// 公开课案例类型(PubCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "IdSchool", "Memo"};

protected string mstrIdPubCaseType;    //公开课案例类型流水号
protected string mstrPubCaseTypeID;    //公开课案例类型ID
protected string mstrPubCaseTypeName;    //公开课案例类型名称
protected string mstrIdSchool;    //学校流水号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPubCaseType">关键字:公开课案例类型流水号</param>
public clsPubCaseTypeEN(string strIdPubCaseType)
 {
strIdPubCaseType = strIdPubCaseType.Replace("'", "''");
if (strIdPubCaseType.Length > 4)
{
throw new Exception("在表:PubCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPubCaseType)  ==  true)
{
throw new Exception("在表:PubCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPubCaseType = strIdPubCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubCaseType");
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
if (strAttributeName  ==  conPubCaseType.IdPubCaseType)
{
return mstrIdPubCaseType;
}
else if (strAttributeName  ==  conPubCaseType.PubCaseTypeID)
{
return mstrPubCaseTypeID;
}
else if (strAttributeName  ==  conPubCaseType.PubCaseTypeName)
{
return mstrPubCaseTypeName;
}
else if (strAttributeName  ==  conPubCaseType.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conPubCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPubCaseType.IdPubCaseType)
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(conPubCaseType.IdPubCaseType);
}
else if (strAttributeName  ==  conPubCaseType.PubCaseTypeID)
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(conPubCaseType.PubCaseTypeID);
}
else if (strAttributeName  ==  conPubCaseType.PubCaseTypeName)
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(conPubCaseType.PubCaseTypeName);
}
else if (strAttributeName  ==  conPubCaseType.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conPubCaseType.IdSchool);
}
else if (strAttributeName  ==  conPubCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubCaseType.IdPubCaseType  ==  AttributeName[intIndex])
{
return mstrIdPubCaseType;
}
else if (conPubCaseType.PubCaseTypeID  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeID;
}
else if (conPubCaseType.PubCaseTypeName  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeName;
}
else if (conPubCaseType.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conPubCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPubCaseType.IdPubCaseType  ==  AttributeName[intIndex])
{
mstrIdPubCaseType = value.ToString();
 AddUpdatedFld(conPubCaseType.IdPubCaseType);
}
else if (conPubCaseType.PubCaseTypeID  ==  AttributeName[intIndex])
{
mstrPubCaseTypeID = value.ToString();
 AddUpdatedFld(conPubCaseType.PubCaseTypeID);
}
else if (conPubCaseType.PubCaseTypeName  ==  AttributeName[intIndex])
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(conPubCaseType.PubCaseTypeName);
}
else if (conPubCaseType.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conPubCaseType.IdSchool);
}
else if (conPubCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubCaseType.Memo);
}
}
}

/// <summary>
/// 公开课案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubCaseType
{
get
{
return mstrIdPubCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubCaseType = value;
}
else
{
 mstrIdPubCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubCaseType.IdPubCaseType);
}
}
/// <summary>
/// 公开课案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeID
{
get
{
return mstrPubCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeID = value;
}
else
{
 mstrPubCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubCaseType.PubCaseTypeID);
}
}
/// <summary>
/// 公开课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeName
{
get
{
return mstrPubCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeName = value;
}
else
{
 mstrPubCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubCaseType.PubCaseTypeName);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubCaseType.IdSchool);
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
 AddUpdatedFld(conPubCaseType.Memo);
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
  return mstrIdPubCaseType;
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
  return mstrPubCaseTypeName;
 }
 }
}
 /// <summary>
 /// 公开课案例类型(PubCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubCaseType
{
public const string _CurrTabName = "PubCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubCaseType", "PubCaseTypeID", "PubCaseTypeName", "IdSchool", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubCaseType = "IdPubCaseType";    //公开课案例类型流水号

 /// <summary>
 /// 常量:"PubCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeID = "PubCaseTypeID";    //公开课案例类型ID

 /// <summary>
 /// 常量:"PubCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeName = "PubCaseTypeName";    //公开课案例类型名称

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}