
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_RelGroupByCaseIdEN
 表名:vMicroteachCase_Resource_RelGroupByCaseId(01120427)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表vMicroteachCase_Resource_RelGroupByCaseId的关键字(IdMicroteachCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCase_vMicroteachCase_Resource_RelGroupByCaseId
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMicroteachCase">表关键字</param>
public K_IdMicroteachCase_vMicroteachCase_Resource_RelGroupByCaseId(string strIdMicroteachCase)
{
if (IsValid(strIdMicroteachCase)) Value = strIdMicroteachCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true) return false;
if (strIdMicroteachCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachCase_vMicroteachCase_Resource_RelGroupByCaseId]类型的对象</returns>
public static implicit operator K_IdMicroteachCase_vMicroteachCase_Resource_RelGroupByCaseId(string value)
{
return new K_IdMicroteachCase_vMicroteachCase_Resource_RelGroupByCaseId(value);
}
}
 /// <summary>
 /// v案例资源关系_GroupByCaseId(vMicroteachCase_Resource_RelGroupByCaseId)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachCase_Resource_RelGroupByCaseIdEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachCase_Resource_RelGroupByCaseId"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdMicroteachCase", "FuncModuleId", "ResourceNum"};

protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrFuncModuleId;    //功能模块Id
protected int? mintResourceNum;    //资源数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachCase_Resource_RelGroupByCaseIdEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMicroteachCase">关键字:微格教学案例流水号</param>
public clsvMicroteachCase_Resource_RelGroupByCaseIdEN(string strIdMicroteachCase)
 {
strIdMicroteachCase = strIdMicroteachCase.Replace("'", "''");
if (strIdMicroteachCase.Length > 8)
{
throw new Exception("在表:vMicroteachCase_Resource_RelGroupByCaseId中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMicroteachCase)  ==  true)
{
throw new Exception("在表:vMicroteachCase_Resource_RelGroupByCaseId中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroteachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMicroteachCase = strIdMicroteachCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCase");
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
if (strAttributeName  ==  convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum)
{
return mintResourceNum;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
}
else if (strAttributeName  ==  convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum)
{
mintResourceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum  ==  AttributeName[intIndex])
{
return mintResourceNum;
}
return null;
}
set
{
if (convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase);
}
else if (convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
}
else if (convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum  ==  AttributeName[intIndex])
{
mintResourceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum);
}
}
}

/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase);
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
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
}
}
/// <summary>
/// 资源数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ResourceNum
{
get
{
return mintResourceNum;
}
set
{
 mintResourceNum = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum);
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
  return mstrIdMicroteachCase;
 }
 }
}
 /// <summary>
 /// v案例资源关系_GroupByCaseId(vMicroteachCase_Resource_RelGroupByCaseId)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachCase_Resource_RelGroupByCaseId
{
public const string _CurrTabName = "vMicroteachCase_Resource_RelGroupByCaseId"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCase", "FuncModuleId", "ResourceNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"ResourceNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceNum = "ResourceNum";    //资源数
}

}