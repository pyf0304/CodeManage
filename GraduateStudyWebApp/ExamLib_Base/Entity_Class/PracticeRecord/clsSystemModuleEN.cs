
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSystemModuleEN
 表名:SystemModule(01120484)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:实习记录(PracticeRecord)
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
 /// 表SystemModule的关键字(IdSystemModule)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSystemModule_SystemModule
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSystemModule">表关键字</param>
public K_IdSystemModule_SystemModule(string strIdSystemModule)
{
if (IsValid(strIdSystemModule)) Value = strIdSystemModule;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSystemModule)
{
if (string.IsNullOrEmpty(strIdSystemModule) == true) return false;
if (strIdSystemModule.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSystemModule_SystemModule]类型的对象</returns>
public static implicit operator K_IdSystemModule_SystemModule(string value)
{
return new K_IdSystemModule_SystemModule(value);
}
}
 /// <summary>
 /// 系统模块(SystemModule)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSystemModuleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SystemModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSystemModule"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdSystemModule", "SystemModuleCode", "SystemModuleName", "Memo"};

protected string mstrIdSystemModule;    //系统模块流水号
protected int? mintSystemModuleCode;    //系统模块代码
protected string mstrSystemModuleName;    //系统模块名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSystemModuleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSystemModule");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSystemModule">关键字:系统模块流水号</param>
public clsSystemModuleEN(string strIdSystemModule)
 {
strIdSystemModule = strIdSystemModule.Replace("'", "''");
if (strIdSystemModule.Length > 4)
{
throw new Exception("在表:SystemModule中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSystemModule)  ==  true)
{
throw new Exception("在表:SystemModule中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSystemModule);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSystemModule = strIdSystemModule;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSystemModule");
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
if (strAttributeName  ==  conSystemModule.IdSystemModule)
{
return mstrIdSystemModule;
}
else if (strAttributeName  ==  conSystemModule.SystemModuleCode)
{
return mintSystemModuleCode;
}
else if (strAttributeName  ==  conSystemModule.SystemModuleName)
{
return mstrSystemModuleName;
}
else if (strAttributeName  ==  conSystemModule.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSystemModule.IdSystemModule)
{
mstrIdSystemModule = value.ToString();
 AddUpdatedFld(conSystemModule.IdSystemModule);
}
else if (strAttributeName  ==  conSystemModule.SystemModuleCode)
{
mintSystemModuleCode = TransNullToInt(value.ToString());
 AddUpdatedFld(conSystemModule.SystemModuleCode);
}
else if (strAttributeName  ==  conSystemModule.SystemModuleName)
{
mstrSystemModuleName = value.ToString();
 AddUpdatedFld(conSystemModule.SystemModuleName);
}
else if (strAttributeName  ==  conSystemModule.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSystemModule.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSystemModule.IdSystemModule  ==  AttributeName[intIndex])
{
return mstrIdSystemModule;
}
else if (conSystemModule.SystemModuleCode  ==  AttributeName[intIndex])
{
return mintSystemModuleCode;
}
else if (conSystemModule.SystemModuleName  ==  AttributeName[intIndex])
{
return mstrSystemModuleName;
}
else if (conSystemModule.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSystemModule.IdSystemModule  ==  AttributeName[intIndex])
{
mstrIdSystemModule = value.ToString();
 AddUpdatedFld(conSystemModule.IdSystemModule);
}
else if (conSystemModule.SystemModuleCode  ==  AttributeName[intIndex])
{
mintSystemModuleCode = TransNullToInt(value.ToString());
 AddUpdatedFld(conSystemModule.SystemModuleCode);
}
else if (conSystemModule.SystemModuleName  ==  AttributeName[intIndex])
{
mstrSystemModuleName = value.ToString();
 AddUpdatedFld(conSystemModule.SystemModuleName);
}
else if (conSystemModule.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSystemModule.Memo);
}
}
}

/// <summary>
/// 系统模块流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSystemModule
{
get
{
return mstrIdSystemModule;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSystemModule = value;
}
else
{
 mstrIdSystemModule = value;
}
//记录修改过的字段
 AddUpdatedFld(conSystemModule.IdSystemModule);
}
}
/// <summary>
/// 系统模块代码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SystemModuleCode
{
get
{
return mintSystemModuleCode;
}
set
{
 mintSystemModuleCode = value;
//记录修改过的字段
 AddUpdatedFld(conSystemModule.SystemModuleCode);
}
}
/// <summary>
/// 系统模块名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SystemModuleName
{
get
{
return mstrSystemModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSystemModuleName = value;
}
else
{
 mstrSystemModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSystemModule.SystemModuleName);
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
 AddUpdatedFld(conSystemModule.Memo);
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
  return mstrIdSystemModule;
 }
 }
}
 /// <summary>
 /// 系统模块(SystemModule)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSystemModule
{
public const string _CurrTabName = "SystemModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSystemModule"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSystemModule", "SystemModuleCode", "SystemModuleName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSystemModule"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSystemModule = "IdSystemModule";    //系统模块流水号

 /// <summary>
 /// 常量:"SystemModuleCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SystemModuleCode = "SystemModuleCode";    //系统模块代码

 /// <summary>
 /// 常量:"SystemModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SystemModuleName = "SystemModuleName";    //系统模块名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}