
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSkillTypeEN
 表名:SkillType(01120312)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表SkillType的关键字(IdSkillType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSkillType_SkillType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSkillType">表关键字</param>
public K_IdSkillType_SkillType(string strIdSkillType)
{
if (IsValid(strIdSkillType)) Value = strIdSkillType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSkillType)
{
if (string.IsNullOrEmpty(strIdSkillType) == true) return false;
if (strIdSkillType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSkillType_SkillType]类型的对象</returns>
public static implicit operator K_IdSkillType_SkillType(string value)
{
return new K_IdSkillType_SkillType(value);
}
}
 /// <summary>
 /// 技能类型(SkillType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSkillTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SkillType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSkillType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdSkillType", "SkillTypeID", "SkillTypeName", "Memo"};

protected string mstrIdSkillType;    //技能类型流水号
protected string mstrSkillTypeID;    //技能类型ID
protected string mstrSkillTypeName;    //技能类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSkillTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSkillType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSkillType">关键字:技能类型流水号</param>
public clsSkillTypeEN(string strIdSkillType)
 {
strIdSkillType = strIdSkillType.Replace("'", "''");
if (strIdSkillType.Length > 4)
{
throw new Exception("在表:SkillType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSkillType)  ==  true)
{
throw new Exception("在表:SkillType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSkillType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSkillType = strIdSkillType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSkillType");
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
if (strAttributeName  ==  conSkillType.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  conSkillType.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  conSkillType.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  conSkillType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSkillType.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(conSkillType.IdSkillType);
}
else if (strAttributeName  ==  conSkillType.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(conSkillType.SkillTypeID);
}
else if (strAttributeName  ==  conSkillType.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(conSkillType.SkillTypeName);
}
else if (strAttributeName  ==  conSkillType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSkillType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSkillType.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (conSkillType.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (conSkillType.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (conSkillType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSkillType.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(conSkillType.IdSkillType);
}
else if (conSkillType.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(conSkillType.SkillTypeID);
}
else if (conSkillType.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(conSkillType.SkillTypeName);
}
else if (conSkillType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSkillType.Memo);
}
}
}

/// <summary>
/// 技能类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSkillType
{
get
{
return mstrIdSkillType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSkillType = value;
}
else
{
 mstrIdSkillType = value;
}
//记录修改过的字段
 AddUpdatedFld(conSkillType.IdSkillType);
}
}
/// <summary>
/// 技能类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeID
{
get
{
return mstrSkillTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeID = value;
}
else
{
 mstrSkillTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conSkillType.SkillTypeID);
}
}
/// <summary>
/// 技能类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeName
{
get
{
return mstrSkillTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeName = value;
}
else
{
 mstrSkillTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSkillType.SkillTypeName);
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
 AddUpdatedFld(conSkillType.Memo);
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
  return mstrIdSkillType;
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
  return mstrSkillTypeName;
 }
 }
}
 /// <summary>
 /// 技能类型(SkillType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSkillType
{
public const string _CurrTabName = "SkillType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSkillType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSkillType", "SkillTypeID", "SkillTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSkillType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSkillType = "IdSkillType";    //技能类型流水号

 /// <summary>
 /// 常量:"SkillTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeID = "SkillTypeID";    //技能类型ID

 /// <summary>
 /// 常量:"SkillTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeName = "SkillTypeName";    //技能类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}