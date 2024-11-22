
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysOperationTypeEN
 表名:zx_SysOperationType(01120824)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表zx_SysOperationType的关键字(zxOperationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxOperationTypeId_zx_SysOperationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxOperationTypeId">表关键字</param>
public K_zxOperationTypeId_zx_SysOperationType(string strzxOperationTypeId)
{
if (IsValid(strzxOperationTypeId)) Value = strzxOperationTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxOperationTypeId)
{
if (string.IsNullOrEmpty(strzxOperationTypeId) == true) return false;
if (strzxOperationTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxOperationTypeId_zx_SysOperationType]类型的对象</returns>
public static implicit operator K_zxOperationTypeId_zx_SysOperationType(string value)
{
return new K_zxOperationTypeId_zx_SysOperationType(value);
}
}
 /// <summary>
 /// 中学操作类型表(zx_SysOperationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysOperationTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysOperationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxOperationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxOperationTypeId", "Memo", "OperationTypeName"};

protected string mstrzxOperationTypeId;    //操作类型ID
protected string mstrMemo;    //备注
protected string mstrOperationTypeName;    //操作类型名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysOperationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxOperationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxOperationTypeId">关键字:操作类型ID</param>
public clszx_SysOperationTypeEN(string strzxOperationTypeId)
 {
strzxOperationTypeId = strzxOperationTypeId.Replace("'", "''");
if (strzxOperationTypeId.Length > 2)
{
throw new Exception("在表:zx_SysOperationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxOperationTypeId)  ==  true)
{
throw new Exception("在表:zx_SysOperationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxOperationTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxOperationTypeId = strzxOperationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxOperationTypeId");
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
if (strAttributeName  ==  conzx_SysOperationType.zxOperationTypeId)
{
return mstrzxOperationTypeId;
}
else if (strAttributeName  ==  conzx_SysOperationType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_SysOperationType.OperationTypeName)
{
return mstrOperationTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysOperationType.zxOperationTypeId)
{
mstrzxOperationTypeId = value.ToString();
 AddUpdatedFld(conzx_SysOperationType.zxOperationTypeId);
}
else if (strAttributeName  ==  conzx_SysOperationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysOperationType.Memo);
}
else if (strAttributeName  ==  conzx_SysOperationType.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(conzx_SysOperationType.OperationTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysOperationType.zxOperationTypeId  ==  AttributeName[intIndex])
{
return mstrzxOperationTypeId;
}
else if (conzx_SysOperationType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_SysOperationType.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
return null;
}
set
{
if (conzx_SysOperationType.zxOperationTypeId  ==  AttributeName[intIndex])
{
mstrzxOperationTypeId = value.ToString();
 AddUpdatedFld(conzx_SysOperationType.zxOperationTypeId);
}
else if (conzx_SysOperationType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysOperationType.Memo);
}
else if (conzx_SysOperationType.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(conzx_SysOperationType.OperationTypeName);
}
}
}

/// <summary>
/// 操作类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxOperationTypeId
{
get
{
return mstrzxOperationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxOperationTypeId = value;
}
else
{
 mstrzxOperationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysOperationType.zxOperationTypeId);
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
 AddUpdatedFld(conzx_SysOperationType.Memo);
}
}
/// <summary>
/// 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeName
{
get
{
return mstrOperationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeName = value;
}
else
{
 mstrOperationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysOperationType.OperationTypeName);
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
  return mstrzxOperationTypeId;
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
  return mstrOperationTypeName;
 }
 }
}
 /// <summary>
 /// 中学操作类型表(zx_SysOperationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysOperationType
{
public const string _CurrTabName = "zx_SysOperationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxOperationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxOperationTypeId", "Memo", "OperationTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxOperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxOperationTypeId = "zxOperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"OperationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeName = "OperationTypeName";    //操作类型名
}

}