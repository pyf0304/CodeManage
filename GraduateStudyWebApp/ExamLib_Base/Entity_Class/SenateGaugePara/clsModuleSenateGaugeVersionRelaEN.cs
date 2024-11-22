
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsModuleSenateGaugeVersionRelaEN
 表名:ModuleSenateGaugeVersionRela(01120462)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// 表ModuleSenateGaugeVersionRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ModuleSenateGaugeVersionRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_ModuleSenateGaugeVersionRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_ModuleSenateGaugeVersionRela]类型的对象</returns>
public static implicit operator K_mId_ModuleSenateGaugeVersionRela(long value)
{
return new K_mId_ModuleSenateGaugeVersionRela(value);
}
}
 /// <summary>
 /// 模块默认评价版本设置(ModuleSenateGaugeVersionRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsModuleSenateGaugeVersionRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ModuleSenateGaugeVersionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "IdSenateGaugeVersion", "Memo", "IsDefault"};

protected long mlngmId;    //mId
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrMemo;    //备注
protected bool mbolIsDefault;    //是否默认

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsModuleSenateGaugeVersionRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsModuleSenateGaugeVersionRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conModuleSenateGaugeVersionRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conModuleSenateGaugeVersionRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conModuleSenateGaugeVersionRela.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conModuleSenateGaugeVersionRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conModuleSenateGaugeVersionRela.IsDefault)
{
return mbolIsDefault;
}
return null;
}
set
{
if (strAttributeName  ==  conModuleSenateGaugeVersionRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conModuleSenateGaugeVersionRela.mId);
}
else if (strAttributeName  ==  conModuleSenateGaugeVersionRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conModuleSenateGaugeVersionRela.FuncModuleId);
}
else if (strAttributeName  ==  conModuleSenateGaugeVersionRela.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conModuleSenateGaugeVersionRela.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conModuleSenateGaugeVersionRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conModuleSenateGaugeVersionRela.Memo);
}
else if (strAttributeName  ==  conModuleSenateGaugeVersionRela.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conModuleSenateGaugeVersionRela.IsDefault);
}
}
}
public object this[int intIndex]
{
get
{
if (conModuleSenateGaugeVersionRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conModuleSenateGaugeVersionRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conModuleSenateGaugeVersionRela.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conModuleSenateGaugeVersionRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conModuleSenateGaugeVersionRela.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
return null;
}
set
{
if (conModuleSenateGaugeVersionRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conModuleSenateGaugeVersionRela.mId);
}
else if (conModuleSenateGaugeVersionRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conModuleSenateGaugeVersionRela.FuncModuleId);
}
else if (conModuleSenateGaugeVersionRela.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conModuleSenateGaugeVersionRela.IdSenateGaugeVersion);
}
else if (conModuleSenateGaugeVersionRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conModuleSenateGaugeVersionRela.Memo);
}
else if (conModuleSenateGaugeVersionRela.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conModuleSenateGaugeVersionRela.IsDefault);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conModuleSenateGaugeVersionRela.mId);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conModuleSenateGaugeVersionRela.FuncModuleId);
}
}
/// <summary>
/// 评价量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeVersion
{
get
{
return mstrIdSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeVersion = value;
}
else
{
 mstrIdSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(conModuleSenateGaugeVersionRela.IdSenateGaugeVersion);
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
 AddUpdatedFld(conModuleSenateGaugeVersionRela.Memo);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault = value;
//记录修改过的字段
 AddUpdatedFld(conModuleSenateGaugeVersionRela.IsDefault);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 模块默认评价版本设置(ModuleSenateGaugeVersionRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conModuleSenateGaugeVersionRela
{
public const string _CurrTabName = "ModuleSenateGaugeVersionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "IdSenateGaugeVersion", "Memo", "IsDefault"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认
}

}