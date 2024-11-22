
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudyLevelEN
 表名:StudyLevel(01120212)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:43
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
 /// 表StudyLevel的关键字(IdStudyLevel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdStudyLevel_StudyLevel
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdStudyLevel">表关键字</param>
public K_IdStudyLevel_StudyLevel(string strIdStudyLevel)
{
if (IsValid(strIdStudyLevel)) Value = strIdStudyLevel;
else
{
Value = null;
}
}
private static bool IsValid(string strIdStudyLevel)
{
if (string.IsNullOrEmpty(strIdStudyLevel) == true) return false;
if (strIdStudyLevel.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdStudyLevel_StudyLevel]类型的对象</returns>
public static implicit operator K_IdStudyLevel_StudyLevel(string value)
{
return new K_IdStudyLevel_StudyLevel(value);
}
}
 /// <summary>
 /// 学段(StudyLevel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsStudyLevelEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "StudyLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdStudyLevel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdStudyLevel", "StudyLevelName", "StudyLevelEnName", "IsForReading", "SequenceNumber", "Memo"};

protected string mstrIdStudyLevel;    //学段流水号
protected string mstrStudyLevelName;    //学段名称
protected string mstrStudyLevelEnName;    //学段英文名
protected bool mbolIsForReading;    //专门用于阅读
protected int mintSequenceNumber;    //序号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsStudyLevelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStudyLevel");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdStudyLevel">关键字:学段流水号</param>
public clsStudyLevelEN(string strIdStudyLevel)
 {
strIdStudyLevel = strIdStudyLevel.Replace("'", "''");
if (strIdStudyLevel.Length > 4)
{
throw new Exception("在表:StudyLevel中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdStudyLevel)  ==  true)
{
throw new Exception("在表:StudyLevel中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdStudyLevel);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdStudyLevel = strIdStudyLevel;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStudyLevel");
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
if (strAttributeName  ==  conStudyLevel.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conStudyLevel.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  conStudyLevel.StudyLevelEnName)
{
return mstrStudyLevelEnName;
}
else if (strAttributeName  ==  conStudyLevel.IsForReading)
{
return mbolIsForReading;
}
else if (strAttributeName  ==  conStudyLevel.SequenceNumber)
{
return mintSequenceNumber;
}
else if (strAttributeName  ==  conStudyLevel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conStudyLevel.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conStudyLevel.IdStudyLevel);
}
else if (strAttributeName  ==  conStudyLevel.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(conStudyLevel.StudyLevelName);
}
else if (strAttributeName  ==  conStudyLevel.StudyLevelEnName)
{
mstrStudyLevelEnName = value.ToString();
 AddUpdatedFld(conStudyLevel.StudyLevelEnName);
}
else if (strAttributeName  ==  conStudyLevel.IsForReading)
{
mbolIsForReading = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudyLevel.IsForReading);
}
else if (strAttributeName  ==  conStudyLevel.SequenceNumber)
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conStudyLevel.SequenceNumber);
}
else if (strAttributeName  ==  conStudyLevel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStudyLevel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conStudyLevel.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conStudyLevel.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (conStudyLevel.StudyLevelEnName  ==  AttributeName[intIndex])
{
return mstrStudyLevelEnName;
}
else if (conStudyLevel.IsForReading  ==  AttributeName[intIndex])
{
return mbolIsForReading;
}
else if (conStudyLevel.SequenceNumber  ==  AttributeName[intIndex])
{
return mintSequenceNumber;
}
else if (conStudyLevel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conStudyLevel.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conStudyLevel.IdStudyLevel);
}
else if (conStudyLevel.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(conStudyLevel.StudyLevelName);
}
else if (conStudyLevel.StudyLevelEnName  ==  AttributeName[intIndex])
{
mstrStudyLevelEnName = value.ToString();
 AddUpdatedFld(conStudyLevel.StudyLevelEnName);
}
else if (conStudyLevel.IsForReading  ==  AttributeName[intIndex])
{
mbolIsForReading = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudyLevel.IsForReading);
}
else if (conStudyLevel.SequenceNumber  ==  AttributeName[intIndex])
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conStudyLevel.SequenceNumber);
}
else if (conStudyLevel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStudyLevel.Memo);
}
}
}

/// <summary>
/// 学段流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudyLevel
{
get
{
return mstrIdStudyLevel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudyLevel = value;
}
else
{
 mstrIdStudyLevel = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudyLevel.IdStudyLevel);
}
}
/// <summary>
/// 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StudyLevelName
{
get
{
return mstrStudyLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStudyLevelName = value;
}
else
{
 mstrStudyLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudyLevel.StudyLevelName);
}
}
/// <summary>
/// 学段英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StudyLevelEnName
{
get
{
return mstrStudyLevelEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStudyLevelEnName = value;
}
else
{
 mstrStudyLevelEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudyLevel.StudyLevelEnName);
}
}
/// <summary>
/// 专门用于阅读(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForReading
{
get
{
return mbolIsForReading;
}
set
{
 mbolIsForReading = value;
//记录修改过的字段
 AddUpdatedFld(conStudyLevel.IsForReading);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SequenceNumber
{
get
{
return mintSequenceNumber;
}
set
{
 mintSequenceNumber = value;
//记录修改过的字段
 AddUpdatedFld(conStudyLevel.SequenceNumber);
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
 AddUpdatedFld(conStudyLevel.Memo);
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
  return mstrIdStudyLevel;
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
  return mstrStudyLevelName;
 }
 }
}
 /// <summary>
 /// 学段(StudyLevel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conStudyLevel
{
public const string _CurrTabName = "StudyLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdStudyLevel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdStudyLevel", "StudyLevelName", "StudyLevelEnName", "IsForReading", "SequenceNumber", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //学段流水号

 /// <summary>
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

 /// <summary>
 /// 常量:"StudyLevelEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelEnName = "StudyLevelEnName";    //学段英文名

 /// <summary>
 /// 常量:"IsForReading"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForReading = "IsForReading";    //专门用于阅读

 /// <summary>
 /// 常量:"SequenceNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SequenceNumber = "SequenceNumber";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}