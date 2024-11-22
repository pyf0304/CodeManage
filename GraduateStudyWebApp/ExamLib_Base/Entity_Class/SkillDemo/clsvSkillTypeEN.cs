
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSkillTypeEN
 表名:vSkillType(01120311)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表vSkillType的关键字(IdSkillType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSkillType_vSkillType
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
public K_IdSkillType_vSkillType(string strIdSkillType)
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
 /// <returns>返回:[K_IdSkillType_vSkillType]类型的对象</returns>
public static implicit operator K_IdSkillType_vSkillType(string value)
{
return new K_IdSkillType_vSkillType(value);
}
}
 /// <summary>
 /// v技能类型(vSkillType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSkillTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSkillType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSkillType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdSkillType", "SkillTypeID", "SkillTypeName", "VersionNum01", "VersionNum02", "VersionNum03", "Memo"};

protected string mstrIdSkillType;    //技能类型流水号
protected string mstrSkillTypeID;    //技能类型ID
protected string mstrSkillTypeName;    //技能类型名称
protected int? mintVersionNum01;    //VersionNum01
protected int? mintVersionNum02;    //VersionNum02
protected int? mintVersionNum03;    //VersionNum03
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSkillTypeEN()
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
public clsvSkillTypeEN(string strIdSkillType)
 {
strIdSkillType = strIdSkillType.Replace("'", "''");
if (strIdSkillType.Length > 4)
{
throw new Exception("在表:vSkillType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSkillType)  ==  true)
{
throw new Exception("在表:vSkillType中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSkillType.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convSkillType.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convSkillType.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convSkillType.VersionNum01)
{
return mintVersionNum01;
}
else if (strAttributeName  ==  convSkillType.VersionNum02)
{
return mintVersionNum02;
}
else if (strAttributeName  ==  convSkillType.VersionNum03)
{
return mintVersionNum03;
}
else if (strAttributeName  ==  convSkillType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convSkillType.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convSkillType.IdSkillType);
}
else if (strAttributeName  ==  convSkillType.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convSkillType.SkillTypeID);
}
else if (strAttributeName  ==  convSkillType.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convSkillType.SkillTypeName);
}
else if (strAttributeName  ==  convSkillType.VersionNum01)
{
mintVersionNum01 = TransNullToInt(value.ToString());
 AddUpdatedFld(convSkillType.VersionNum01);
}
else if (strAttributeName  ==  convSkillType.VersionNum02)
{
mintVersionNum02 = TransNullToInt(value.ToString());
 AddUpdatedFld(convSkillType.VersionNum02);
}
else if (strAttributeName  ==  convSkillType.VersionNum03)
{
mintVersionNum03 = TransNullToInt(value.ToString());
 AddUpdatedFld(convSkillType.VersionNum03);
}
else if (strAttributeName  ==  convSkillType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSkillType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convSkillType.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convSkillType.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convSkillType.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convSkillType.VersionNum01  ==  AttributeName[intIndex])
{
return mintVersionNum01;
}
else if (convSkillType.VersionNum02  ==  AttributeName[intIndex])
{
return mintVersionNum02;
}
else if (convSkillType.VersionNum03  ==  AttributeName[intIndex])
{
return mintVersionNum03;
}
else if (convSkillType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convSkillType.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convSkillType.IdSkillType);
}
else if (convSkillType.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convSkillType.SkillTypeID);
}
else if (convSkillType.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convSkillType.SkillTypeName);
}
else if (convSkillType.VersionNum01  ==  AttributeName[intIndex])
{
mintVersionNum01 = TransNullToInt(value.ToString());
 AddUpdatedFld(convSkillType.VersionNum01);
}
else if (convSkillType.VersionNum02  ==  AttributeName[intIndex])
{
mintVersionNum02 = TransNullToInt(value.ToString());
 AddUpdatedFld(convSkillType.VersionNum02);
}
else if (convSkillType.VersionNum03  ==  AttributeName[intIndex])
{
mintVersionNum03 = TransNullToInt(value.ToString());
 AddUpdatedFld(convSkillType.VersionNum03);
}
else if (convSkillType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSkillType.Memo);
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
 AddUpdatedFld(convSkillType.IdSkillType);
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
 AddUpdatedFld(convSkillType.SkillTypeID);
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
 AddUpdatedFld(convSkillType.SkillTypeName);
}
}
/// <summary>
/// VersionNum01(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionNum01
{
get
{
return mintVersionNum01;
}
set
{
 mintVersionNum01 = value;
//记录修改过的字段
 AddUpdatedFld(convSkillType.VersionNum01);
}
}
/// <summary>
/// VersionNum02(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionNum02
{
get
{
return mintVersionNum02;
}
set
{
 mintVersionNum02 = value;
//记录修改过的字段
 AddUpdatedFld(convSkillType.VersionNum02);
}
}
/// <summary>
/// VersionNum03(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionNum03
{
get
{
return mintVersionNum03;
}
set
{
 mintVersionNum03 = value;
//记录修改过的字段
 AddUpdatedFld(convSkillType.VersionNum03);
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
 AddUpdatedFld(convSkillType.Memo);
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
 /// v技能类型(vSkillType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSkillType
{
public const string _CurrTabName = "vSkillType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSkillType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSkillType", "SkillTypeID", "SkillTypeName", "VersionNum01", "VersionNum02", "VersionNum03", "Memo"};
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
 /// 常量:"VersionNum01"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNum01 = "VersionNum01";    //VersionNum01

 /// <summary>
 /// 常量:"VersionNum02"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNum02 = "VersionNum02";    //VersionNum02

 /// <summary>
 /// 常量:"VersionNum03"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNum03 = "VersionNum03";    //VersionNum03

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}