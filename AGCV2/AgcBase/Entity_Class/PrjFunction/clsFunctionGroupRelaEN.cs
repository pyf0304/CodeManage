﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionGroupRelaEN
 表名:FunctionGroupRela(00050328)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:49:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表FunctionGroupRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FunctionGroupRela
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
public K_mId_FunctionGroupRela(long lngmId)
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
 /// <returns>返回:[K_mId_FunctionGroupRela]类型的对象</returns>
public static implicit operator K_mId_FunctionGroupRela(long value)
{
return new K_mId_FunctionGroupRela(value);
}
}
 /// <summary>
 /// 函数与组关系(FunctionGroupRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionGroupRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionGroupRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"mId", "FunctionGroupId", "FuncId4GC", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrFunctionGroupId;    //函数组Id
protected string mstrFuncId4GC;    //函数ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFunctionGroupRelaEN()
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
public clsFunctionGroupRelaEN(long lngmId)
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
if (strAttributeName  ==  conFunctionGroupRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFunctionGroupRela.FunctionGroupId)
{
return mstrFunctionGroupId;
}
else if (strAttributeName  ==  conFunctionGroupRela.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  conFunctionGroupRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunctionGroupRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunctionGroupRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionGroupRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionGroupRela.mId);
}
else if (strAttributeName  ==  conFunctionGroupRela.FunctionGroupId)
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.FunctionGroupId);
}
else if (strAttributeName  ==  conFunctionGroupRela.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.FuncId4GC);
}
else if (strAttributeName  ==  conFunctionGroupRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.UpdDate);
}
else if (strAttributeName  ==  conFunctionGroupRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.UpdUser);
}
else if (strAttributeName  ==  conFunctionGroupRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionGroupRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conFunctionGroupRela.FunctionGroupId  ==  AttributeName[intIndex])
{
return mstrFunctionGroupId;
}
else if (conFunctionGroupRela.FuncId4GC  ==  AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (conFunctionGroupRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunctionGroupRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunctionGroupRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionGroupRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunctionGroupRela.mId);
}
else if (conFunctionGroupRela.FunctionGroupId  ==  AttributeName[intIndex])
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.FunctionGroupId);
}
else if (conFunctionGroupRela.FuncId4GC  ==  AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.FuncId4GC);
}
else if (conFunctionGroupRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.UpdDate);
}
else if (conFunctionGroupRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.UpdUser);
}
else if (conFunctionGroupRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionGroupRela.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
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
 AddUpdatedFld(conFunctionGroupRela.mId);
}
}
/// <summary>
/// 函数组Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionGroupId
{
get
{
return mstrFunctionGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionGroupId = value;
}
else
{
 mstrFunctionGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionGroupRela.FunctionGroupId);
}
}
/// <summary>
/// 函数ID(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4GC
{
get
{
return mstrFuncId4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4GC = value;
}
else
{
 mstrFuncId4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionGroupRela.FuncId4GC);
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
 AddUpdatedFld(conFunctionGroupRela.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionGroupRela.UpdUser);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
 AddUpdatedFld(conFunctionGroupRela.Memo);
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
 /// 函数与组关系(FunctionGroupRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionGroupRela
{
public const string _CurrTabName = "FunctionGroupRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FunctionGroupId", "FuncId4GC", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FunctionGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionGroupId = "FunctionGroupId";    //函数组Id

 /// <summary>
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}