
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsOperationTypeEN
 表名:OperationType(01120538)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:47
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
 /// 表OperationType的关键字(OperationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_OperationTypeId_OperationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strOperationTypeId">表关键字</param>
public K_OperationTypeId_OperationType(string strOperationTypeId)
{
if (IsValid(strOperationTypeId)) Value = strOperationTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strOperationTypeId)
{
if (string.IsNullOrEmpty(strOperationTypeId) == true) return false;
if (strOperationTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_OperationTypeId_OperationType]类型的对象</returns>
public static implicit operator K_OperationTypeId_OperationType(string value)
{
return new K_OperationTypeId_OperationType(value);
}
}
 /// <summary>
 /// 操作类型(OperationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsOperationTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "OperationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "OperationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"OperationTypeId", "OperationTypeName", "UpdDate", "UpdUserId", "Memo"};

protected string mstrOperationTypeId;    //操作类型ID
protected string mstrOperationTypeName;    //操作类型名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsOperationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("OperationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strOperationTypeId">关键字:操作类型ID</param>
public clsOperationTypeEN(string strOperationTypeId)
 {
strOperationTypeId = strOperationTypeId.Replace("'", "''");
if (strOperationTypeId.Length > 4)
{
throw new Exception("在表:OperationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strOperationTypeId)  ==  true)
{
throw new Exception("在表:OperationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strOperationTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrOperationTypeId = strOperationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("OperationTypeId");
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
if (strAttributeName  ==  conOperationType.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  conOperationType.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  conOperationType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conOperationType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conOperationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conOperationType.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conOperationType.OperationTypeId);
}
else if (strAttributeName  ==  conOperationType.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(conOperationType.OperationTypeName);
}
else if (strAttributeName  ==  conOperationType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conOperationType.UpdDate);
}
else if (strAttributeName  ==  conOperationType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conOperationType.UpdUserId);
}
else if (strAttributeName  ==  conOperationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conOperationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conOperationType.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (conOperationType.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (conOperationType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conOperationType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conOperationType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conOperationType.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conOperationType.OperationTypeId);
}
else if (conOperationType.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(conOperationType.OperationTypeName);
}
else if (conOperationType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conOperationType.UpdDate);
}
else if (conOperationType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conOperationType.UpdUserId);
}
else if (conOperationType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conOperationType.Memo);
}
}
}

/// <summary>
/// 操作类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeId
{
get
{
return mstrOperationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeId = value;
}
else
{
 mstrOperationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conOperationType.OperationTypeId);
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
 AddUpdatedFld(conOperationType.OperationTypeName);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conOperationType.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conOperationType.UpdUserId);
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
 AddUpdatedFld(conOperationType.Memo);
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
  return mstrOperationTypeId;
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
 /// 操作类型(OperationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conOperationType
{
public const string _CurrTabName = "OperationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "OperationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"OperationTypeId", "OperationTypeName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"OperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeId = "OperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"OperationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeName = "OperationTypeName";    //操作类型名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}