
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBottleStateEN
 表名:BottleState(01120975)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:42
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
 /// 表BottleState的关键字(BottleStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_BottleStateId_BottleState
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strBottleStateId">表关键字</param>
public K_BottleStateId_BottleState(string strBottleStateId)
{
if (IsValid(strBottleStateId)) Value = strBottleStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strBottleStateId)
{
if (string.IsNullOrEmpty(strBottleStateId) == true) return false;
if (strBottleStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_BottleStateId_BottleState]类型的对象</returns>
public static implicit operator K_BottleStateId_BottleState(string value)
{
return new K_BottleStateId_BottleState(value);
}
}
 /// <summary>
 /// 瓶子状态(BottleState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsBottleStateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "BottleState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "BottleStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"BottleStateId", "BottleStateName", "BottleStateEnName", "Memo"};

protected string mstrBottleStateId;    //操作方式Id
protected string mstrBottleStateName;    //瓶子状态名
protected string mstrBottleStateEnName;    //瓶子状态名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsBottleStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("BottleStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strBottleStateId">关键字:操作方式Id</param>
public clsBottleStateEN(string strBottleStateId)
 {
strBottleStateId = strBottleStateId.Replace("'", "''");
if (strBottleStateId.Length > 2)
{
throw new Exception("在表:BottleState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strBottleStateId)  ==  true)
{
throw new Exception("在表:BottleState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strBottleStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrBottleStateId = strBottleStateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("BottleStateId");
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
if (strAttributeName  ==  conBottleState.BottleStateId)
{
return mstrBottleStateId;
}
else if (strAttributeName  ==  conBottleState.BottleStateName)
{
return mstrBottleStateName;
}
else if (strAttributeName  ==  conBottleState.BottleStateEnName)
{
return mstrBottleStateEnName;
}
else if (strAttributeName  ==  conBottleState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conBottleState.BottleStateId)
{
mstrBottleStateId = value.ToString();
 AddUpdatedFld(conBottleState.BottleStateId);
}
else if (strAttributeName  ==  conBottleState.BottleStateName)
{
mstrBottleStateName = value.ToString();
 AddUpdatedFld(conBottleState.BottleStateName);
}
else if (strAttributeName  ==  conBottleState.BottleStateEnName)
{
mstrBottleStateEnName = value.ToString();
 AddUpdatedFld(conBottleState.BottleStateEnName);
}
else if (strAttributeName  ==  conBottleState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conBottleState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conBottleState.BottleStateId  ==  AttributeName[intIndex])
{
return mstrBottleStateId;
}
else if (conBottleState.BottleStateName  ==  AttributeName[intIndex])
{
return mstrBottleStateName;
}
else if (conBottleState.BottleStateEnName  ==  AttributeName[intIndex])
{
return mstrBottleStateEnName;
}
else if (conBottleState.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conBottleState.BottleStateId  ==  AttributeName[intIndex])
{
mstrBottleStateId = value.ToString();
 AddUpdatedFld(conBottleState.BottleStateId);
}
else if (conBottleState.BottleStateName  ==  AttributeName[intIndex])
{
mstrBottleStateName = value.ToString();
 AddUpdatedFld(conBottleState.BottleStateName);
}
else if (conBottleState.BottleStateEnName  ==  AttributeName[intIndex])
{
mstrBottleStateEnName = value.ToString();
 AddUpdatedFld(conBottleState.BottleStateEnName);
}
else if (conBottleState.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conBottleState.Memo);
}
}
}

/// <summary>
/// 操作方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BottleStateId
{
get
{
return mstrBottleStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBottleStateId = value;
}
else
{
 mstrBottleStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conBottleState.BottleStateId);
}
}
/// <summary>
/// 瓶子状态名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BottleStateName
{
get
{
return mstrBottleStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBottleStateName = value;
}
else
{
 mstrBottleStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conBottleState.BottleStateName);
}
}
/// <summary>
/// 瓶子状态名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BottleStateEnName
{
get
{
return mstrBottleStateEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBottleStateEnName = value;
}
else
{
 mstrBottleStateEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conBottleState.BottleStateEnName);
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
 AddUpdatedFld(conBottleState.Memo);
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
  return mstrBottleStateId;
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
  return mstrBottleStateName;
 }
 }
}
 /// <summary>
 /// 瓶子状态(BottleState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conBottleState
{
public const string _CurrTabName = "BottleState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "BottleStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"BottleStateId", "BottleStateName", "BottleStateEnName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"BottleStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BottleStateId = "BottleStateId";    //操作方式Id

 /// <summary>
 /// 常量:"BottleStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BottleStateName = "BottleStateName";    //瓶子状态名

 /// <summary>
 /// 常量:"BottleStateEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BottleStateEnName = "BottleStateEnName";    //瓶子状态名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}