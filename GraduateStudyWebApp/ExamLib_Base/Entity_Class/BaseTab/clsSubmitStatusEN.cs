
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSubmitStatusEN
 表名:SubmitStatus(01120970)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本表(BaseTab)
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
 /// 表SubmitStatus的关键字(IdSubmitStatus)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSubmitStatus_SubmitStatus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSubmitStatus">表关键字</param>
public K_IdSubmitStatus_SubmitStatus(string strIdSubmitStatus)
{
if (IsValid(strIdSubmitStatus)) Value = strIdSubmitStatus;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSubmitStatus)
{
if (string.IsNullOrEmpty(strIdSubmitStatus) == true) return false;
if (strIdSubmitStatus.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSubmitStatus_SubmitStatus]类型的对象</returns>
public static implicit operator K_IdSubmitStatus_SubmitStatus(string value)
{
return new K_IdSubmitStatus_SubmitStatus(value);
}
}
 /// <summary>
 /// 送审状态(SubmitStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSubmitStatusEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SubmitStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSubmitStatus"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdSubmitStatus", "SubmitStatusDesc", "SubmitStatusEnDesc", "Memo"};

protected string mstrIdSubmitStatus;    //送审状态流水号
protected string mstrSubmitStatusDesc;    //送审状态流描述
protected string mstrSubmitStatusEnDesc;    //送审状态流英文描述
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSubmitStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSubmitStatus");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSubmitStatus">关键字:送审状态流水号</param>
public clsSubmitStatusEN(string strIdSubmitStatus)
 {
strIdSubmitStatus = strIdSubmitStatus.Replace("'", "''");
if (strIdSubmitStatus.Length > 2)
{
throw new Exception("在表:SubmitStatus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSubmitStatus)  ==  true)
{
throw new Exception("在表:SubmitStatus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSubmitStatus);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSubmitStatus = strIdSubmitStatus;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSubmitStatus");
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
if (strAttributeName  ==  conSubmitStatus.IdSubmitStatus)
{
return mstrIdSubmitStatus;
}
else if (strAttributeName  ==  conSubmitStatus.SubmitStatusDesc)
{
return mstrSubmitStatusDesc;
}
else if (strAttributeName  ==  conSubmitStatus.SubmitStatusEnDesc)
{
return mstrSubmitStatusEnDesc;
}
else if (strAttributeName  ==  conSubmitStatus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSubmitStatus.IdSubmitStatus)
{
mstrIdSubmitStatus = value.ToString();
 AddUpdatedFld(conSubmitStatus.IdSubmitStatus);
}
else if (strAttributeName  ==  conSubmitStatus.SubmitStatusDesc)
{
mstrSubmitStatusDesc = value.ToString();
 AddUpdatedFld(conSubmitStatus.SubmitStatusDesc);
}
else if (strAttributeName  ==  conSubmitStatus.SubmitStatusEnDesc)
{
mstrSubmitStatusEnDesc = value.ToString();
 AddUpdatedFld(conSubmitStatus.SubmitStatusEnDesc);
}
else if (strAttributeName  ==  conSubmitStatus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSubmitStatus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSubmitStatus.IdSubmitStatus  ==  AttributeName[intIndex])
{
return mstrIdSubmitStatus;
}
else if (conSubmitStatus.SubmitStatusDesc  ==  AttributeName[intIndex])
{
return mstrSubmitStatusDesc;
}
else if (conSubmitStatus.SubmitStatusEnDesc  ==  AttributeName[intIndex])
{
return mstrSubmitStatusEnDesc;
}
else if (conSubmitStatus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSubmitStatus.IdSubmitStatus  ==  AttributeName[intIndex])
{
mstrIdSubmitStatus = value.ToString();
 AddUpdatedFld(conSubmitStatus.IdSubmitStatus);
}
else if (conSubmitStatus.SubmitStatusDesc  ==  AttributeName[intIndex])
{
mstrSubmitStatusDesc = value.ToString();
 AddUpdatedFld(conSubmitStatus.SubmitStatusDesc);
}
else if (conSubmitStatus.SubmitStatusEnDesc  ==  AttributeName[intIndex])
{
mstrSubmitStatusEnDesc = value.ToString();
 AddUpdatedFld(conSubmitStatus.SubmitStatusEnDesc);
}
else if (conSubmitStatus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSubmitStatus.Memo);
}
}
}

/// <summary>
/// 送审状态流水号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSubmitStatus
{
get
{
return mstrIdSubmitStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSubmitStatus = value;
}
else
{
 mstrIdSubmitStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubmitStatus.IdSubmitStatus);
}
}
/// <summary>
/// 送审状态流描述(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubmitStatusDesc
{
get
{
return mstrSubmitStatusDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubmitStatusDesc = value;
}
else
{
 mstrSubmitStatusDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubmitStatus.SubmitStatusDesc);
}
}
/// <summary>
/// 送审状态流英文描述(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubmitStatusEnDesc
{
get
{
return mstrSubmitStatusEnDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubmitStatusEnDesc = value;
}
else
{
 mstrSubmitStatusEnDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubmitStatus.SubmitStatusEnDesc);
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
 AddUpdatedFld(conSubmitStatus.Memo);
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
  return mstrIdSubmitStatus;
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
  return mstrSubmitStatusDesc;
 }
 }
}
 /// <summary>
 /// 送审状态(SubmitStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSubmitStatus
{
public const string _CurrTabName = "SubmitStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSubmitStatus"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSubmitStatus", "SubmitStatusDesc", "SubmitStatusEnDesc", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSubmitStatus"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSubmitStatus = "IdSubmitStatus";    //送审状态流水号

 /// <summary>
 /// 常量:"SubmitStatusDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubmitStatusDesc = "SubmitStatusDesc";    //送审状态流描述

 /// <summary>
 /// 常量:"SubmitStatusEnDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubmitStatusEnDesc = "SubmitStatusEnDesc";    //送审状态流英文描述

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}